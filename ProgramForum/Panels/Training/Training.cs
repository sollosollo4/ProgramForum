﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramForum.Panels.Training
{
    public partial class Training : UserControl
    {
        public Training()
        {
            InitializeComponent();

            using(ForumContainer container = new ForumContainer())
            {

            }
        }
    }
}
