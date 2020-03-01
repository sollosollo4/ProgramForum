using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF_UnitTests
{
    public class SendMessage
    {

        public bool Send(string message, int AccountId1, int AccountId2)
        {
            var s = 0;
            for (int i = 0; i < 100000000; i++)
                s = i;

            return true;
        }
    }
}
