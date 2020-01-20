using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramForum.Content
{
    public partial class RandomQuestion : UserControl
    {
        QuestionSet currentQuestion;
        Panels.SimpleQuestion currentPanel;

        public EventHandler ReturnToMain;

        public RandomQuestion(QuestionSet questionSet)
        {
            InitializeComponent();
            currentQuestion = questionSet;
            Panels.SimpleQuestion simpleQuestion = new Panels.SimpleQuestion(questionSet)
            {
                Anchor = AnchorStyles.Left | AnchorStyles.Right
            };
            currentPanel = simpleQuestion;
            Controls.Add(simpleQuestion);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var boolean = Panels.QuestionTypes.TryToAnswer(currentPanel, currentQuestion);
            if(boolean)
            {
                MessageBox.Show("Правильно");
                ReturnToMain.Invoke(sender, e);
            }
            else
            {
                MessageBox.Show("Не правильно");
                return;
            }
        }
    }
}
