using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Classes
{
    public class Questionnaire
    {
        public List<Question> Questions { get; private set; }

        public Questionnaire(string subject, int grade)
        {
            GenerateQuestions(subject, grade);
        }

        private void GenerateQuestions(string subject, int grade)
        {
            Questions = new List<Question>();

            if (subject == "История")
            {
                if (grade == 5)
                {
                    Questions.Add(new Question("Кто был первым Президентом Соединенных Штатов Америки?", new List<string> { "Джордж Вашингтон", "Томас Джефферсон", "Авраам Линкольн", "Джон Адамс" }, 0));
                    Questions.Add(new Question("В каком году Кристофор Колумб прибыл в Америку?", new List<string> { "1492", "1607", "1776", "1620" }, 0));
                }
                else if (grade == 6)
                {
                    Questions.Add(new Question("Какая древняя цивилизация построила Великую Китайскую стену?", new List<string> { "Китайская", "Монгольская", "Римская", "Инков" }, 0));
                    Questions.Add(new Question("Какая египетская царица была известна своими отношениями с Юлием Цезарем и Марком Антонием?", new List<string> { "Клеопатра", "Нофретет", "Хатшепсут", "Исида" }, 0));
                }
                else
                {
                }
            }
            else
            {
            }

            ShuffleQuestions();
        }

        public void ShuffleQuestions()
        {
            Random rnd = new Random();
            Questions = Questions.OrderBy(x => rnd.Next()).ToList();
        }
    }
}
