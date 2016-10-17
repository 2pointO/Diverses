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
using static StressTest.StressTestType;


namespace StressTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        int index = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
            label3.Content=(comboBox.Text + " " + comboBox1.Text + " " + comboBox2.Text);

            addToEntry(comboBox2.Text);
            textBox.Clear();
            foreach (String entry in result)
            {
                if (entry != null)
                {
                    
                    textBox.AppendText(entry+"\n");
                }
            }
        }
        private String[] result = new String[10];

        private void addToEntry(String entry)
        {
            
            if (index > 9) {
                String[] newAr = new String[result.Length];
                for (int i = 1; i < result.Length; i++)
                {
                    newAr[i - 1] = result[i];
                }
                result = newAr;
                index = index -1;
            }
            result[index] = entry;
            index++;
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
