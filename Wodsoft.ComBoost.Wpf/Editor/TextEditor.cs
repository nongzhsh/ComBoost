﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wodsoft.ComBoost.Wpf.Editor
{
    [TemplatePart(Name = "PART_TextBox", Type = typeof(TextBox))]
    public class TextEditor : DefaultEditor
    {
        static TextEditor()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TextEditor), new FrameworkPropertyMetadata(typeof(TextEditor)));
        }
    }
}
