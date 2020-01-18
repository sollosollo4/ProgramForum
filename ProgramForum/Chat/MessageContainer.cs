using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramForum.Chat
{
    public partial class MessageContainer : UserControl
    {
        public MessageContainer()
        {
            InitializeComponent();
        }

        public void SetMessage(AccountSet sender, MessageSet message)
        {
            NickName.Text = sender.Login;
            Message.ReadOnly = true;
            Message.Text = message.MessageText;
            Date.Text = message.Date.ToString();
        }
    }
}
