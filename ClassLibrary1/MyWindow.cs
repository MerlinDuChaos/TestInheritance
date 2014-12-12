using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ClassLibrary1
{
    public class MyWindow : Window
    {
        public bool ShowHeader
        {
            get { return (bool)GetValue(ShowHeaderProperty); }
            set { SetValue(ShowHeaderProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ShowHeader.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ShowHeaderProperty =
            DependencyProperty.Register("ShowHeader", typeof(bool), typeof(MyWindow), new PropertyMetadata(true));

        public string HeaderText
        {
            get { return (string)GetValue(HeaderTextProperty); }
            set { SetValue(HeaderTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for HeaderText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HeaderTextProperty =
            DependencyProperty.Register("HeaderText", typeof(string), typeof(MyWindow), new PropertyMetadata(""));

        static MyWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MyWindow), new FrameworkPropertyMetadata(typeof(MyWindow)));
        }
    }
}
