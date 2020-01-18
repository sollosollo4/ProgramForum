using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramForum.Panels
{
    public partial class QuestionType3Form : Form
    {
        public int newAddingTextBoxs;
        public Point newAddingPointTextBoxs;
        public Point newAddingPointComboBoxs;
        public string CodeText;

        List<string> keyWords = new List<string>();

        public QuestionType3Form(string CodeText)
        {
            InitializeComponent();
            this.CodeText = CodeText;
            newAddingTextBoxs = 4;
            newAddingPointTextBoxs = new Point(0, 0);
            newAddingPointComboBoxs = new Point(138, 0);

            SetComboBox();
        }

        private void SetComboBox()
        {
            char[] keys = new char[] {' ', '\n', '{', '}', '.', '(', ')', ';'};
            keyWords = CodeText.Split(keys).ToList().Distinct().ToList();
            keyWords.RemoveAll(x => x == string.Empty || x == " ");
            WordsCollectionComboBox1.Items.AddRange(keyWords.ToArray());
            WordsCollectionComboBox2.Items.AddRange(keyWords.ToArray());
            WordsCollectionComboBox3.Items.AddRange(keyWords.ToArray());
            WordsCollectionComboBox4.Items.AddRange(keyWords.ToArray());
        }

        private void AddNewWord_Click(object sender, EventArgs e)
        {
            newAddingTextBoxs++;
            

            TextBox addingTextBox = new TextBox()
            {
                Name = "SelectableWordTextBox" + newAddingTextBoxs,
                Location = newAddingPointTextBoxs,
                Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204))),
                Size = new Size(131, 29)
            };

            ComboBox keyWordsComboBox = new ComboBox()
            {
                Name = "WordsCollectionComboBox" + newAddingTextBoxs,
                Location = newAddingPointComboBoxs,
                Size = new Size(474, 30),
                Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204))),
            };
            keyWordsComboBox.Items.AddRange(keyWords.ToArray());

            Point newPointLoc = new Point(newAddingPointTextBoxs.X, newAddingPointTextBoxs.Y + 35);
            newAddingPointTextBoxs = newPointLoc;

            Point newPointLoc1 = new Point(newAddingPointComboBoxs.X, newAddingPointComboBoxs.Y + 35);
            newAddingPointComboBoxs = newPointLoc1;

            AddNewWord.Location = newAddingPointTextBoxs;

            newTextoxesPanel.Controls.Add(addingTextBox);
            newTextoxesPanel.Controls.Add(keyWordsComboBox);

            if (newAddingTextBoxs == 8)
            {
                newTextoxesPanel.Controls.Remove(AddNewWord);
                return;
            }
        }

        private void EndWorkWithKeysWord_Click(object sender, EventArgs e)
        {

        }
    }
}
