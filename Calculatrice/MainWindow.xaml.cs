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

namespace Calculatrice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        string bufferNumber1, bufferNumber2, transaction;
        double MemoryPlus = 0;
        double result, bufferNumberString, convertNumber1, convertNumber2;

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            bufferNumber1 = DisplayPrint.Text;
            DisplayResult.Text = bufferNumber1;
            transaction = "+";
            DisplayPrint.Text += " + ";
            DisplayResult.Text += " + ";
            DisplayPrint.Clear();
        }

        private void BtnSub_Click(object sender, RoutedEventArgs e)
        {
            bufferNumber1 = DisplayPrint.Text;
            DisplayResult.Text = bufferNumber1;
            transaction = "-";
            DisplayPrint.Text += " - ";
            DisplayResult.Text += " - ";
            DisplayPrint.Clear();
        }

        private void BtnTimes_Click(object sender, RoutedEventArgs e)
        {
            bufferNumber1 = DisplayPrint.Text;
            DisplayResult.Text = bufferNumber1;
            transaction = "x";
            DisplayPrint.Text += " x ";
            DisplayResult.Text += " x ";
            DisplayPrint.Clear();
        }

        private void BtnDivide_Click(object sender, RoutedEventArgs e)
        {
            bufferNumber1 = DisplayPrint.Text;
            DisplayResult.Text = bufferNumber1;
            transaction = "/";
            DisplayPrint.Text += " / ";
            DisplayResult.Text += " / ";
            DisplayPrint.Clear();
        }
        private void BtnMod_Click(object sender, RoutedEventArgs e)
        {
            bufferNumber1 = DisplayPrint.Text;
            DisplayResult.Text = bufferNumber1;
            transaction = "mod";
            DisplayPrint.Text += " mod ";
            DisplayResult.Text += " mod ";
            DisplayPrint.Clear();
        }

        private void BtnResult_Click(object sender, RoutedEventArgs e)
        {
            if(transaction == "+")
            {
                bufferNumber2 = DisplayPrint.Text;
                DisplayResult.Text += bufferNumber2 + " = ";
                convertNumber1 = Convert.ToDouble(bufferNumber1);
                convertNumber2 = Convert.ToDouble(bufferNumber2);
                result = convertNumber1 + convertNumber2;
                DisplayResult.Text += result;
                DisplayPrint.Text = Convert.ToString(result);
                convertNumber1 = result;
            }
            else if(transaction == "-")
            {
                bufferNumber2 = DisplayPrint.Text;
                DisplayResult.Text += bufferNumber2 + " = ";
                convertNumber1 = Convert.ToDouble(bufferNumber1);
                convertNumber2 = Convert.ToDouble(bufferNumber2);
                result = convertNumber1 - convertNumber2;
                DisplayResult.Text += result;
                DisplayPrint.Text = Convert.ToString(result);
                convertNumber1 = result;
            }
            else if (transaction == "x")
            {
                bufferNumber2 = DisplayPrint.Text;
                DisplayResult.Text += bufferNumber2 + " = ";
                convertNumber1 = Convert.ToDouble(bufferNumber1);
                convertNumber2 = Convert.ToDouble(bufferNumber2);
                result = convertNumber1 * convertNumber2;
                DisplayResult.Text += result;
                DisplayPrint.Text = Convert.ToString(result);
                convertNumber1 = result;
            }
            else if(transaction == "/")
            {
                bufferNumber2 = DisplayPrint.Text;
                DisplayResult.Text += bufferNumber2 + " = ";
                convertNumber1 = Convert.ToDouble(bufferNumber1);
                convertNumber2 = Convert.ToDouble(bufferNumber2);
                result = convertNumber1 / convertNumber2;
                DisplayResult.Text += result;
                DisplayPrint.Text = Convert.ToString(result);
                convertNumber1 = result;
            }
            else if(transaction == "mod")
            {
                bufferNumber2 = DisplayPrint.Text;
                DisplayResult.Text += bufferNumber2 + " = ";
                convertNumber1 = Convert.ToDouble(bufferNumber1);
                convertNumber2 = Convert.ToDouble(bufferNumber2);
                result = convertNumber1 % convertNumber2;
                DisplayResult.Text += result;
                DisplayPrint.Text = Convert.ToString(result);
                convertNumber1 = result;
            }
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            DisplayPrint.Clear();
            DisplayResult.Clear();
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            DisplayPrint.Text += 6;
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            DisplayPrint.Text += 7;
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            DisplayPrint.Text += 8;
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            DisplayPrint.Text += 9;
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            DisplayPrint.Text += 0;
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            DisplayPrint.Text += 5;
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            DisplayPrint.Text += 4;
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            DisplayPrint.Text += 3;
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            DisplayPrint.Text += 2;
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            DisplayPrint.Text += 1;
        }
        private void BtnComa_Click(object sender, RoutedEventArgs e)
        {
            DisplayPrint.Text += ",";
        }

    }
}
