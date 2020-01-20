using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramForum.Content.PrivateMessage.Chat
{
    public partial class Chat : UserControl
    {
        public Chat(string Name, EventHandler _handler)
        {
            InitializeComponent();
            NickName.Text = Name;
            Click += _handler;
        }
    }
}
