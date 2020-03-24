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
    public partial class InteractiveThemeControl : UserControl
    {
        public ThemeSet Theme;
        public InteractiveThemeControl(ThemeSet theme)
        {
            EventHandlerTransform handlerTransform = new EventHandlerTransform(Theme, this);
            handlerTransform.LoadAllLinks();

            InitializeComponent();
            Theme = theme;

            ThemeText.Text = Theme.ThemeText;
            int v1 = ThemeText.Text.IndexOf('<');
            int v2 = ThemeText.Text.IndexOf('>');
            ThemeText.LinkArea = new LinkArea(v1, v2);
            
            handlerTransform.SetLinkLabel(ThemeText);
            ThemeText.LinkClicked += handlerTransform.GetParametrByName(Theme.ThemeText.Substring(++v1, ++v2));
        }

        public class EventHandlerTransform
        {
            static List<LinkLabelLinkClickedEventHandler> linkLabelLinkClickedEvents;

            ThemeSet Theme;
            LinkLabel Label;
            public void SetLinkLabel(LinkLabel lbl) { Label = lbl; }

            InteractiveThemeControl Control;

            public EventHandlerTransform(ThemeSet set, InteractiveThemeControl control) {
                Theme = set;
                Control = control;
            }

            public LinkLabelLinkClickedEventHandler GetParametrByName(string prmtName)
            {
                return linkLabelLinkClickedEvents.FirstOrDefault(x => x.Method.Name == prmtName);
            }

            internal void LoadAllLinks()
            {

                linkLabelLinkClickedEvents = new List<LinkLabelLinkClickedEventHandler>();
                linkLabelLinkClickedEvents.Add(Test_7975d5e3cbbf436bf1247dd3d0b1322a);
            }

            private void Test_7975d5e3cbbf436bf1247dd3d0b1322a(object sender, LinkLabelLinkClickedEventArgs e)
            {

            }
        }
    }
}
