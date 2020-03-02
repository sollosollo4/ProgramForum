using ProgramForum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF_UnitTests
{
    public class AddNewQuestion
    {
        public enum StringTypeQuestion : int
        {
            QuestionText = 0,
            QuestionType = 1,
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="keyValuePairs">Значения тип вопроса</param>
        /// <param name="questionVariable">Ответы на вопросы</param>
        /// <param name="langId">Айди языка</param>
        /// <param name="typeId">Айди типа</param>
        /// <returns></returns>
        public bool NewQuestion(Dictionary<StringTypeQuestion, string> keyValuePairs, List<string> questionVariable, int LangId, int correctOtvet)
        {
            using (ForumContainer container = new ForumContainer())
            {
                int langId = LangId;
                int questTypeId = Convert.ToInt32(keyValuePairs[StringTypeQuestion.QuestionType]);

                QuestionSet setQuest = new QuestionSet()
                {
                    QuestionText = keyValuePairs[StringTypeQuestion.QuestionText],
                    CorrectOption = correctOtvet,
                    LanguageLanguageId = langId,
                    QuestionTypeQuestionTypeId = questTypeId,
                    AccountAccountId = 0,
                    AccountSet = container.AccountSet.Single(x => x.Login == "admin"),
                    QuestionTypeSet = container.QuestionTypeSet.Single(x => x.QuestionTypeId == questTypeId),
                    LanguageSet = container.LanguageSet.Single(x => x.LanguageId == langId),
                };

                container.QuestionSet.Add(setQuest);

                for (int i = 0; i < 4; i++)
                {
                    AnswerSet secAnswer = new AnswerSet()
                    {
                        AnswerVarible = questionVariable[i],
                        QuestionSet = setQuest
                    };
                    container.AnswerSet.Add(secAnswer);
                    container.SaveChanges();
                }
                container.SaveChanges();
            }

            return true;
        }
    }
}
