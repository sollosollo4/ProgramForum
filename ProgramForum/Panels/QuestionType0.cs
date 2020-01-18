using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramForum.Panels
{
    public partial class QuestionType0 : UserControl
    {
        public RadioButtonQuestionType questionType;

        public QuestionType0()
        {
            InitializeComponent();
            questionType = new RadioButtonQuestionType();
        }

        public void SetTextBoxReadOnly(bool value)
        {
            textBox1.ReadOnly = value;
            textBox2.ReadOnly = value;
            textBox3.ReadOnly = value;
            textBox4.ReadOnly = value;
        }

        public void SetTextBox(QuestionSet quest)
        {
            if(quest != null)
            {
                textBox1.Text = quest.AnswerSet.ToList()[0].AnswerVarible;
                textBox2.Text = quest.AnswerSet.ToList()[1].AnswerVarible;
                textBox3.Text = quest.AnswerSet.ToList()[2].AnswerVarible;
                textBox4.Text = quest.AnswerSet.ToList()[3].AnswerVarible;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            questionType.setRadioButton(0);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            questionType.setRadioButton(1);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            questionType.setRadioButton(2);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            questionType.setRadioButton(3);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            questionType.TextBoxes[0] = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            questionType.TextBoxes[1] = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            questionType.TextBoxes[2] = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            questionType.TextBoxes[3] = textBox4.Text;
        }
    }
}
