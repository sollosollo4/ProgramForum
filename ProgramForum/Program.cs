using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramForum
{

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        { 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            /*using (ForumContainer container = new ForumContainer())
            {
                var inital = container.AccountSet.Single(x => x.AccountId == 2);
                var sender = container.AccountSet.Single(x => x.AccountId == 1);
                Application.Run(new Chat.MessageSendForm(inital, sender));
            }*/

            Application.Run(new AuthForm());

            if (AuthForm.Client != null)
            {
                if (AuthForm.Client.Login != string.Empty)
                {
                    MainForm mainForm = new MainForm(AuthForm.Client);
                    mainForm.ShowDialog();
                }
                else return;
            }
            else return;
        }
    }
}
