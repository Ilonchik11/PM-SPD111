using System;
using System.Collections.Generic;
using System.Data;
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

namespace Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            foreach (UIElement item in MainRoot.Children)
            {
                if (item is Button)
                {
                    ((Button)item).Click += Button_Click; 
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;

            if (str == "CE")
            {
                result.Text = string.Empty;
                operating.Text = string.Empty;
            }
            else if (str == "=")
            {
                string value = new DataTable().Compute(operating.Text, null).ToString();
                result.Text = value;
            }
            else
            {
                result.Text = string.Empty;
                operating.Text += str;
            }
        }
    }
}
