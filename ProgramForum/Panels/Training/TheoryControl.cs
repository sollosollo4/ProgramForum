﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScintillaNET.Demo.Utils;
using System.IO;
using ScintillaNET;

namespace ProgramForum.Panels.Training
{
    public partial class TheoryControl : UserControl
    {
        private const int NullCodeId = 1011;

        public int CurrentPosition;

        LessonSet Lesson;
        List<Content.Training.Theory> Theories;
        List<Content.Training.Question> Questions;

        private Scintilla TextArea;

        public TheoryControl(LessonSet lessonSet, List<Content.Training.Theory> theories, List<Content.Training.Question> questions)
        {
            Lesson = lessonSet;
            Theories = theories;
            Questions = questions;

            InitializeComponent();
            CurrentPosition = 0;

            LoadTheoryControl();
        }

        private void LoadTheoryControl()
        {
			ClearPanels();

			var isNowTheory = Theories.FirstOrDefault(x => x.Position == CurrentPosition);
            if(isNowTheory == null) {
                var isNowQuestion = Questions.FirstOrDefault(x => x.Position == CurrentPosition);

                if(isNowQuestion == null) {
					// Пользователь завершил урок. Возвращаем его на панель Training!
					// В бд отмечаем, что последний урок который он прошел, следующий по Position от этого LessonSet
					using(ForumContainer container = new ForumContainer())
					{
						int NextPosition = Lesson.Position + 1;
						// Получаем следующий урок
						var nextLesson = container.LessonSet.FirstOrDefault(x => x.TrainingId == Lesson.TrainingId && x.Position == NextPosition);
						if(nextLesson == null)
						{
							var training = container.TrainingProgressSet.FirstOrDefault(x => x.TrainingId == Lesson.TrainingId);
							container.TrainingProgressSet.Remove(training);
							MessageBox.Show("Вы успешно прошли данное обучение!");
							container.SaveChanges();

							var tPlane = (Training)Parent;
							tPlane.Completed();
							Dispose();
							return;
						}
						// Обновляем строку в LessonProgress
						var nextProgress = container.TrainingProgressSet.FirstOrDefault(x => x.LessonId == Lesson.LessonId);
						nextProgress.LessonId = nextLesson.LessonId;
						container.SaveChanges();
					}
					
					var TrainingPanel = (Training)Parent;
					TrainingPanel.UpdateTrainingPanel();
					Dispose();
				}
                else {
                    LoadQuestion();
                }
            }
            else {
                LoadTheory();
            }

        }

		private void ClearPanels()
		{
			LabelPanel.Visible = false;
			CodePanel.Visible = false;
			QuestionPanel.Visible = false;

			LabelPanel.Controls.Clear();
			CodePanel.Controls.Clear();
			QuestionPanel.Controls.Clear();
		}

		private void LoadQuestion() {
			TryAnswer.Visible = true;
			GoNext.Visible = false;

			QuestionPanel.Visible = true;
			using (ForumContainer container = new ForumContainer())
			{
				var quest = Questions.FirstOrDefault(x => x.Position == CurrentPosition).QuestionSet;
				var question = container.QuestionSet.FirstOrDefault(x => x.QuestionId == quest.QuestionId);
				SimpleQuestion simpleQuestion = new SimpleQuestion(new Size(443, 291), question);
				QuestionPanel.Controls.Add(simpleQuestion);
			}
		}

        private void LoadTheory() {
			GoNext.Visible = true;

			var needTheoryLesson = Theories.FirstOrDefault(x => x.Position == CurrentPosition);

			Label theoryText = new Label() { Text = needTheoryLesson.TheoryLessonSet.TheoryText, AutoSize = true, Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right };
			LabelPanel.Visible = true;
			LabelPanel.Controls.Add(theoryText);

            if(Theories.FirstOrDefault(x => x.Position == CurrentPosition).TheoryLessonSet.CodeId != NullCodeId)
            {
                using (ForumContainer container = new ForumContainer())
                {
                    Scintilla newCodeBlock = new Scintilla() { Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right };
					TextArea = newCodeBlock;
					LoadScintilla();
					newCodeBlock.Click += Scintilla_Click;
                    newCodeBlock.TextChanged += Scintilla_TextChanged;

                    var codeElementFromDb = container.CodeSet.FirstOrDefault(x => x.CodeId == needTheoryLesson.TheoryLessonSet.CodeId);
					newCodeBlock.Text = Encoding.UTF8.GetString(codeElementFromDb.BinaryFileData.Where(x => x != 0).ToArray());

					newCodeBlock.Height = TextRenderer.MeasureText(newCodeBlock.Text, new Font("Consolas", 10.0f,FontStyle.Bold)).Height;
					newCodeBlock.Width = TextRenderer.MeasureText(newCodeBlock.Text, new Font("Consolas", 10.0f, FontStyle.Bold)).Width;

					CodePanel.Visible = true;
					CodePanel.Controls.Add(newCodeBlock);                    
                }
            }
        }

		private void GoNext_Click(object sender, EventArgs e)
        {
            CurrentPosition++;

            LoadTheoryControl();
        }

		private void TryAnswer_Click(object sender, EventArgs e)
		{
			using (ForumContainer container = new ForumContainer())
			{
				var quest = Questions.FirstOrDefault(x => x.Position == CurrentPosition).QuestionSet;
				var question = container.QuestionSet.FirstOrDefault(x => x.QuestionId == quest.QuestionId);

				var boolean = QuestionTypes.TryToAnswer((SimpleQuestion)QuestionPanel.Controls[0], question);
				
				if (boolean)
				{
					MessageBox.Show("Правильно");
					CurrentPosition++;
					LoadTheoryControl();
				}
				else
				{
					MessageBox.Show("Не правильно");
					return;
				}
			}
		}

		private void Scintilla_TextChanged(object sender, EventArgs e)
		{
			Scintilla tb = sender as Scintilla;
			tb.Height = TextRenderer.MeasureText(tb.Text, tb.Font).Height + 14;
		}

		private void Scintilla_Click(object sender, EventArgs e)
		{
			var Scintilla = (Scintilla)sender;
			TextArea = Scintilla;
		}

		private void LoadScintilla()
		{
			// BASIC CONFIG
			//TextArea.Dock = System.Windows.Forms.DockStyle.Fill;


			// INITIAL VIEW CONFIG
			TextArea.WrapMode = WrapMode.None;
			TextArea.IndentationGuides = IndentView.LookBoth;

			// STYLING
			InitColors();
			InitSyntaxColoring();

			// NUMBER MARGIN
			InitNumberMargin();

			// BOOKMARK MARGIN
			InitBookmarkMargin();

			// CODE FOLDING MARGIN
			InitCodeFolding();

			// DRAG DROP
			InitDragDropFile();

			// INIT HOTKEYS
			InitHotkeys();
		}

		private void InitColors()
		{
			TextArea.SetSelectionBackColor(true, IntToColor(0x114D9C));
		}

		private void InitHotkeys()
		{

			// register the hotkeys with the form
			HotKeyManager.AddHotKey(MainForm.ActiveForm, OpenFindDialog, Keys.F, true, false, true);
			HotKeyManager.AddHotKey(MainForm.ActiveForm, OpenReplaceDialog, Keys.R, true);
			HotKeyManager.AddHotKey(MainForm.ActiveForm, OpenReplaceDialog, Keys.H, true);
			HotKeyManager.AddHotKey(MainForm.ActiveForm, Uppercase, Keys.U, true);
			HotKeyManager.AddHotKey(MainForm.ActiveForm, Lowercase, Keys.L, true);
			HotKeyManager.AddHotKey(MainForm.ActiveForm, ZoomIn, Keys.Oemplus, true);
			HotKeyManager.AddHotKey(MainForm.ActiveForm, ZoomOut, Keys.OemMinus, true);
			HotKeyManager.AddHotKey(MainForm.ActiveForm, ZoomDefault, Keys.D0, true);

			// remove conflicting hotkeys from scintilla
			TextArea.ClearCmdKey(Keys.Control | Keys.F);
			TextArea.ClearCmdKey(Keys.Control | Keys.R);
			TextArea.ClearCmdKey(Keys.Control | Keys.H);
			TextArea.ClearCmdKey(Keys.Control | Keys.L);
			TextArea.ClearCmdKey(Keys.Control | Keys.U);

		}

		private void InitSyntaxColoring()
		{

			// Configure the default style
			TextArea.StyleResetDefault();
			TextArea.Styles[Style.Default].Font = "Consolas";
			TextArea.Styles[Style.Default].Size = 10;
			TextArea.Styles[Style.Default].BackColor = IntToColor(0x212121);
			TextArea.Styles[Style.Default].ForeColor = IntToColor(0xFFFFFF);
			TextArea.StyleClearAll();

			// Configure the CPP (C#) lexer styles
			TextArea.Styles[Style.Cpp.Identifier].ForeColor = IntToColor(0xD0DAE2);
			TextArea.Styles[Style.Cpp.Comment].ForeColor = IntToColor(0xBD758B);
			TextArea.Styles[Style.Cpp.CommentLine].ForeColor = IntToColor(0x40BF57);
			TextArea.Styles[Style.Cpp.CommentDoc].ForeColor = IntToColor(0x2FAE35);
			TextArea.Styles[Style.Cpp.Number].ForeColor = IntToColor(0xFFFF00);
			TextArea.Styles[Style.Cpp.String].ForeColor = IntToColor(0xFFFF00);
			TextArea.Styles[Style.Cpp.Character].ForeColor = IntToColor(0xE95454);
			TextArea.Styles[Style.Cpp.Preprocessor].ForeColor = IntToColor(0x8AAFEE);
			TextArea.Styles[Style.Cpp.Operator].ForeColor = IntToColor(0xE0E0E0);
			TextArea.Styles[Style.Cpp.Regex].ForeColor = IntToColor(0xff00ff);
			TextArea.Styles[Style.Cpp.CommentLineDoc].ForeColor = IntToColor(0x77A7DB);
			TextArea.Styles[Style.Cpp.Word].ForeColor = IntToColor(0x48A8EE);
			TextArea.Styles[Style.Cpp.Word2].ForeColor = IntToColor(0xF98906);
			TextArea.Styles[Style.Cpp.CommentDocKeyword].ForeColor = IntToColor(0xB3D991);
			TextArea.Styles[Style.Cpp.CommentDocKeywordError].ForeColor = IntToColor(0xFF0000);
			TextArea.Styles[Style.Cpp.GlobalClass].ForeColor = IntToColor(0x48A8EE);

			TextArea.Lexer = Lexer.Cpp;

			TextArea.SetKeywords(0, "class extends implements import interface new case do while else if for in switch throw get set function var try catch finally while with default break continue delete return each const namespace package include use is as instanceof typeof author copy default deprecated eventType example exampleText exception haxe inheritDoc internal link mtasc mxmlc param private return see serial serialData serialField since throws usage version langversion playerversion productversion dynamic private public partial static intrinsic internal native override protected AS3 final super this arguments null Infinity NaN undefined true false abstract as base bool break by byte case catch char checked class const continue decimal default delegate do double descending explicit event extern else enum false finally fixed float for foreach from goto group if implicit in int interface internal into is lock long new null namespace object operator out override orderby params private protected public readonly ref return switch struct sbyte sealed short sizeof stackalloc static string select this throw true try typeof uint ulong unchecked unsafe ushort using var virtual volatile void while where yield");
			TextArea.SetKeywords(1, "void Null ArgumentError arguments Array Boolean Class Date DefinitionError Error EvalError Function int Math Namespace Number Object RangeError ReferenceError RegExp SecurityError String SyntaxError TypeError uint XML XMLList Boolean Byte Char DateTime Decimal Double Int16 Int32 Int64 IntPtr SByte Single UInt16 UInt32 UInt64 UIntPtr Void Path File System Windows Forms ScintillaNET");

		}


		#region Numbers, Bookmarks, Code Folding

		/// <summary>
		/// the background color of the text area
		/// </summary>
		private const int BACK_COLOR = 0x2A211C;

		/// <summary>
		/// default text color of the text area
		/// </summary>
		private const int FORE_COLOR = 0xB7B7B7;

		/// <summary>
		/// change this to whatever margin you want the line numbers to show in
		/// </summary>
		private const int NUMBER_MARGIN = 1;

		/// <summary>
		/// change this to whatever margin you want the bookmarks/breakpoints to show in
		/// </summary>
		private const int BOOKMARK_MARGIN = 2;
		private const int BOOKMARK_MARKER = 2;

		/// <summary>
		/// change this to whatever margin you want the code folding tree (+/-) to show in
		/// </summary>
		private const int FOLDING_MARGIN = 3;

		/// <summary>
		/// set this true to show circular buttons for code folding (the [+] and [-] buttons on the margin)
		/// </summary>
		private const bool CODEFOLDING_CIRCULAR = true;

		private void InitNumberMargin()
		{

			TextArea.Styles[Style.LineNumber].BackColor = IntToColor(BACK_COLOR);
			TextArea.Styles[Style.LineNumber].ForeColor = IntToColor(FORE_COLOR);
			TextArea.Styles[Style.IndentGuide].ForeColor = IntToColor(FORE_COLOR);
			TextArea.Styles[Style.IndentGuide].BackColor = IntToColor(BACK_COLOR);

			var nums = TextArea.Margins[NUMBER_MARGIN];
			nums.Width = 30;
			nums.Type = MarginType.Number;
			nums.Sensitive = true;
			nums.Mask = 0;

			TextArea.MarginClick += TextArea_MarginClick;
		}

		private void InitBookmarkMargin()
		{

			//TextArea.SetFoldMarginColor(true, IntToColor(BACK_COLOR));

			var margin = TextArea.Margins[BOOKMARK_MARGIN];
			margin.Width = 20;
			margin.Sensitive = true;
			margin.Type = MarginType.Symbol;
			margin.Mask = (1 << BOOKMARK_MARKER);
			//margin.Cursor = MarginCursor.Arrow;

			var marker = TextArea.Markers[BOOKMARK_MARKER];
			marker.Symbol = MarkerSymbol.Circle;
			marker.SetBackColor(IntToColor(0xFF003B));
			marker.SetForeColor(IntToColor(0x000000));
			marker.SetAlpha(100);

		}

		private void InitCodeFolding()
		{

			TextArea.SetFoldMarginColor(true, IntToColor(BACK_COLOR));
			TextArea.SetFoldMarginHighlightColor(true, IntToColor(BACK_COLOR));

			// Enable code folding
			TextArea.SetProperty("fold", "1");
			TextArea.SetProperty("fold.compact", "1");

			// Configure a margin to display folding symbols
			TextArea.Margins[FOLDING_MARGIN].Type = MarginType.Symbol;
			TextArea.Margins[FOLDING_MARGIN].Mask = Marker.MaskFolders;
			TextArea.Margins[FOLDING_MARGIN].Sensitive = true;
			TextArea.Margins[FOLDING_MARGIN].Width = 20;

			// Set colors for all folding markers
			for (int i = 25; i <= 31; i++)
			{
				TextArea.Markers[i].SetForeColor(IntToColor(BACK_COLOR)); // styles for [+] and [-]
				TextArea.Markers[i].SetBackColor(IntToColor(FORE_COLOR)); // styles for [+] and [-]
			}

			// Configure folding markers with respective symbols
			TextArea.Markers[Marker.Folder].Symbol = CODEFOLDING_CIRCULAR ? MarkerSymbol.CirclePlus : MarkerSymbol.BoxPlus;
			TextArea.Markers[Marker.FolderOpen].Symbol = CODEFOLDING_CIRCULAR ? MarkerSymbol.CircleMinus : MarkerSymbol.BoxMinus;
			TextArea.Markers[Marker.FolderEnd].Symbol = CODEFOLDING_CIRCULAR ? MarkerSymbol.CirclePlusConnected : MarkerSymbol.BoxPlusConnected;
			TextArea.Markers[Marker.FolderMidTail].Symbol = MarkerSymbol.TCorner;
			TextArea.Markers[Marker.FolderOpenMid].Symbol = CODEFOLDING_CIRCULAR ? MarkerSymbol.CircleMinusConnected : MarkerSymbol.BoxMinusConnected;
			TextArea.Markers[Marker.FolderSub].Symbol = MarkerSymbol.VLine;
			TextArea.Markers[Marker.FolderTail].Symbol = MarkerSymbol.LCorner;

			// Enable automatic folding
			TextArea.AutomaticFold = (AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change);

		}

		private void TextArea_MarginClick(object sender, MarginClickEventArgs e)
		{
			if (e.Margin == BOOKMARK_MARGIN)
			{
				// Do we have a marker for this line?
				const uint mask = (1 << BOOKMARK_MARKER);
				var line = TextArea.Lines[TextArea.LineFromPosition(e.Position)];
				if ((line.MarkerGet() & mask) > 0)
				{
					// Remove existing bookmark
					line.MarkerDelete(BOOKMARK_MARKER);
				}
				else
				{
					// Add bookmark
					line.MarkerAdd(BOOKMARK_MARKER);
				}
			}
		}

		#endregion

		#region Drag & Drop File

		public void InitDragDropFile()
		{

			TextArea.AllowDrop = true;
			TextArea.DragEnter += delegate (object sender, DragEventArgs e) {
				if (e.Data.GetDataPresent(DataFormats.FileDrop))
					e.Effect = DragDropEffects.Copy;
				else
					e.Effect = DragDropEffects.None;
			};
			TextArea.DragDrop += delegate (object sender, DragEventArgs e) {

				// get file drop
				if (e.Data.GetDataPresent(DataFormats.FileDrop))
				{

					Array a = (Array)e.Data.GetData(DataFormats.FileDrop);
					if (a != null)
					{

						string path = a.GetValue(0).ToString();

						LoadDataFromFile(path);

					}
				}
			};

		}

		private void LoadDataFromFile(string path)
		{
			if (File.Exists(path))
			{
				TextArea.Text = File.ReadAllText(path);
			}
		}

		#endregion

		#region Uppercase / Lowercase

		private void Lowercase()
		{

			// save the selection
			int start = TextArea.SelectionStart;
			int end = TextArea.SelectionEnd;

			// modify the selected text
			TextArea.ReplaceSelection(TextArea.GetTextRange(start, end - start).ToLower());

			// preserve the original selection
			TextArea.SetSelection(start, end);
		}

		private void Uppercase()
		{

			// save the selection
			int start = TextArea.SelectionStart;
			int end = TextArea.SelectionEnd;

			// modify the selected text
			TextArea.ReplaceSelection(TextArea.GetTextRange(start, end - start).ToUpper());

			// preserve the original selection
			TextArea.SetSelection(start, end);
		}

		#endregion

		#region Indent / Outdent

		private void Indent()
		{
			// we use this hack to send "Shift+Tab" to scintilla, since there is no known API to indent,
			// although the indentation function exists. Pressing TAB with the editor focused confirms this.
			GenerateKeystrokes("{TAB}");
		}

		private void Outdent()
		{
			// we use this hack to send "Shift+Tab" to scintilla, since there is no known API to outdent,
			// although the indentation function exists. Pressing Shift+Tab with the editor focused confirms this.
			GenerateKeystrokes("+{TAB}");
		}

		private void GenerateKeystrokes(string keys)
		{
			HotKeyManager.Enable = false;
			TextArea.Focus();
			SendKeys.Send(keys);
			HotKeyManager.Enable = true;
		}

		#endregion

		#region Zoom

		private void ZoomIn()
		{
			TextArea.ZoomIn();
		}

		private void ZoomOut()
		{
			TextArea.ZoomOut();
		}

		private void ZoomDefault()
		{
			TextArea.Zoom = 0;
		}


		#endregion

		#region Find & Replace Dialog

		private void OpenFindDialog()
		{

		}
		private void OpenReplaceDialog()
		{


		}

		#endregion

		#region Utils

		public static Color IntToColor(int rgb)
		{
			return Color.FromArgb(255, (byte)(rgb >> 16), (byte)(rgb >> 8), (byte)rgb);
		}

		public void InvokeIfNeeded(Action action)
		{
			if (this.InvokeRequired)
			{
				this.BeginInvoke(action);
			}
			else
			{
				action.Invoke();
			}
		}

		#endregion		
	}
}
