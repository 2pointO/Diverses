using System;
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
using Microsoft.Win32;
namespace ReadFile
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string fileName;

        public MainWindow()
        {
            InitializeComponent();
        }

        public string GetFileName()
        {
            string fname = String.Empty;
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.InitialDirectory = @"H:\";
            openFileDlg.DefaultExt = ".txt";
            openFileDlg.Filter = "Text Document (.txt)|*.txt";
            bool? result = openFileDlg.ShowDialog();

            if (result == true)
            {
                fname = openFileDlg.FileName;
            }

            return fname;
        }

        private void open_Click(object sender, RoutedEventArgs e)
        {
            fileName = GetFileName();
            if (fileName != String.Empty)
            {
                // input.Text = TextFileOperations.ReadTextFileContents(fileName);
                input.Text = TextFileOperations.ReadAndFilterTextFileContents(fileName);
            }
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            if (fileName != String.Empty)
            {
                TextFileOperations.WriteTextFileContents(fileName, input.Text);
            }
        }
    }
}
