using System;
using System.Collections.Generic;
using System.IO;
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

namespace SysProgLesson6_hw
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            _currentWord = string.Empty;
            _acceptableWords = new();

            MessageBox.Show(Directory.GetCurrentDirectory());

        }

        private string _currentWord;
        private List<string> _acceptableWords { get; set; }
        private List<string> _words { get; set; }

        private void txt_baseText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btn_num_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_clear_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_confirm_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
