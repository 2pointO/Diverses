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


namespace module3Exercise1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int a;
        int b;
        int c;
        int d;
        int h;
        long timeElapsed;
        long other = 4;

        Algo algo = new Algo();

        public MainWindow()
        {
            InitializeComponent();


        }
        //Drawing not completed
        /*private void DrawGraph(long timeElapsed, long other, Orientation orientation = Orientation.Horizontal,string colorEuclid = "Red",string colorOther = "Blue")
        {
            BrushConverter bc = new BrushConverter();
            Brush bTime = (Brush)bc.ConvertFromString(colorEuclid);
            Brush bOther = (Brush)bc.ConvertFromString(colorOther);

        }*/
        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void calc_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(textBox.Text, out a);
            int.TryParse(textBox1.Text, out b);
            int.TryParse(textBox3.Text, out c);
            int.TryParse(textBox2.Text, out d);
            int.TryParse(textBox4.Text, out h);

            if (!isEmpty(textBox.Text) && !isEmpty(textBox1.Text))
            {         
                Result.Content = string.Format("Euclid GCD is: {0}, elapsed time is: {1}(ms)", algo.FindGCDEuclid(a, b, out timeElapsed), timeElapsed);
                //DrawGraph(timeElapsed,other);
            }

            if (!isEmpty(textBox.Text) && !isEmpty(textBox1.Text) && !isEmpty(textBox3.Text))
            {
                Result.Content = string.Format("Euclid GCD is: {0} elapsed time is: {1}(ms)", algo.FindGCDEuclid(a, b,c, out timeElapsed), timeElapsed);
            }

            if (!isEmpty(textBox.Text) && !isEmpty(textBox1.Text) && !isEmpty(textBox3.Text) && !isEmpty(textBox2.Text))
            {
                Result.Content = string.Format("Euclid GCD is: {0} elapsed time is: {1}(ms)", algo.FindGCDEuclid(a, b,c,d, out timeElapsed), timeElapsed);
            }
            if (!isEmpty(textBox.Text) && !isEmpty(textBox1.Text) && !isEmpty(textBox3.Text) && !isEmpty(textBox2.Text) && !isEmpty(textBox4.Text))
            {
                Result.Content = string.Format("Euclid GCD is: {0} elapsed time is: {1}(ms)", algo.FindGCDEuclid(a, b,c,d,h, out timeElapsed), timeElapsed);
            }
        }

        private bool isEmpty(String o)
        {
            if (String.IsNullOrEmpty(o) == true) return true;
            else return false;
            }
        }
    
}
