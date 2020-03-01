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

        public bool NewQuestion(Dictionary<StringTypeQuestion, string> keyValuePairs, List<string> questionVariable)
        {
            var s = 0;
            for (int i = 0; i < 100056560; i++)
                s = i;

            return false;
        }
    }
}
