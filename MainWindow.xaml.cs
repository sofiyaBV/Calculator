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

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string number1 = null;
        string number2 = null;
        char option ='!';
        public MainWindow()
        {
            InitializeComponent();
        }

        private void options(char o)
        {
            double d = 0;
            if(o =='+') 
            {
               d = Convert.ToDouble(number1) + Convert.ToDouble(number2);
            }
            else if (o =='-')
            {
                d = Convert.ToDouble(number1) - Convert.ToDouble(number2);
            }
            else if (o =='*')
            {
                d = Convert.ToDouble(number1) * Convert.ToDouble(number2);
            }
            else if (o =='/')
            {
                if (number1 != "0")
                {
                   d = Convert.ToDouble(number1) / Convert.ToDouble(number2);
                }
            }
            TBlock_Sum.Text = "0";
            number1 = d.ToString();
            //if (TBlock_Operations.Text == null)
            //{ number = res_number; }
            //double d = Convert.ToDouble(number) + Convert.ToDouble(res_number);
            //res_number = d.ToString();
            //number = res_number;
            //TBlock_Operations.Text = number + " + ";
        }

        private void Button_0_Click(object sender, RoutedEventArgs e)
        {
            if (TBlock_Sum.Text != "0")
            {
               number2 += "0";
                TBlock_Sum.Text += "0";
            }
        }
        private void Button_1_Click(object sender, RoutedEventArgs e)
        {
            number2 += "1";
            if (TBlock_Sum.Text == "0")
            { TBlock_Sum.Text = "1"; }
            else
            { TBlock_Sum.Text += "1"; }
        }
        private void Button_2_Click(object sender, RoutedEventArgs e)
        {
            number2 += "2";
            if (TBlock_Sum.Text == "0")
            { TBlock_Sum.Text = "2"; }
            else
            { TBlock_Sum.Text += "2"; }
        }
        private void Button_3_Click(object sender, RoutedEventArgs e)
        {
            number2 += "3";
            if (TBlock_Sum.Text == "0")
            { TBlock_Sum.Text = "3"; }
            else
            { TBlock_Sum.Text += "3"; }
        }
        private void Button_4_Click(object sender, RoutedEventArgs e)
        {
            number2 += "4";
            if (TBlock_Sum.Text == "0")
            { TBlock_Sum.Text = "4"; }
            else
            { TBlock_Sum.Text += "4"; }
        }
        private void Button_5_Click(object sender, RoutedEventArgs e)
        {
            number2 += "5";
            if (TBlock_Sum.Text == "0")
            { TBlock_Sum.Text = "5"; }
            else
            { TBlock_Sum.Text += "5"; }
        }
        private void Button_6_Click(object sender, RoutedEventArgs e)
        {
            number2 += "6";
            if (TBlock_Sum.Text == "0")
            { TBlock_Sum.Text = "6"; }
            else
            { TBlock_Sum.Text += "6"; }
        }
        private void Button_7_Click(object sender, RoutedEventArgs e)
        {
            number2 += "7";
            if (TBlock_Sum.Text == "0")
            { TBlock_Sum.Text = "7"; }
            else
            { TBlock_Sum.Text += "7"; }
        }
        private void Button_8_Click(object sender, RoutedEventArgs e)
        {
            number2 += "8";
            if (TBlock_Sum.Text == "0")
            { TBlock_Sum.Text = "8"; }
            else
            { TBlock_Sum.Text += "8"; }
        }
        private void Button_9_Click(object sender, RoutedEventArgs e)
        {
            number2 += "9";
            if (TBlock_Sum.Text == "0")
            { TBlock_Sum.Text = "9"; }
            else
            { TBlock_Sum.Text += "9"; }
        }
        private void Button_Clear_Click(object sender, RoutedEventArgs e)
        {
            if (TBlock_Sum.Text != "0")
            {
                number2 =  number2.Remove( number2.Length - 1);
                TBlock_Sum.Text =  number2;
                if(TBlock_Sum.Text == "") 
                { 
                    TBlock_Sum.Text = "0";
                    number2 = null;
                }
            }   
        }
        private void Button_C_Click(object sender, RoutedEventArgs e)
        {
            number2 = null;
            number1 = null;
            TBlock_Operations.Text = null;
            TBlock_Sum.Text = "0";
        }
        private void Button_CE_Click(object sender, RoutedEventArgs e)
        {
            number2 = null;
            TBlock_Sum.Text = "0";
        }

        private void Button_Addition_Click(object sender, RoutedEventArgs e)
        {
            if(option == '!')
            {
               
                if(number1 == null)
                {
                    number1 = number2;
                }
            }
            else 
            { 
                options(option); 
            }
            TBlock_Operations.Text = number1 + " + ";
            option = '+';
            Button_CE_Click(sender, e);
        }

        private void Button_TakingAway_Click(object sender, RoutedEventArgs e)
        {
            if (option == '!')
            {
                if (number1 == null)
                {
                    number1 = number2;
                }
            }
            else
            {
                options(option);
            }
            TBlock_Operations.Text = number1 + " - ";
            option = '-';
            Button_CE_Click(sender, e);
        }

        private void Button_Equals_Click(object sender, RoutedEventArgs e)
        {  
            if (option != '!')
            {
                TBlock_Operations.Text = number1 + option + number2 + " = ";
                if (number1 == null)
                {
                    number1 = number2;
                }
                options(option);
                TBlock_Sum.Text = number1;
                number1 = number2 = null;
            }
        }

        private void Button_x_Click(object sender, RoutedEventArgs e)
        {
            if (option == '!')
            {

                if (number1 == null)
                {
                    number1 = number2;
                }
            }
            else
            {
                options(option);
            }
            TBlock_Operations.Text = number1 + " x ";
            option = '*';
            Button_CE_Click(sender, e);
        }

        private void Button_Division_Click(object sender, RoutedEventArgs e)
        {
            if (option == '!')
            {

                if (number1 == null)
                {
                    number1 = number2;
                }
            }
            else
            {
                options(option);
            }
            TBlock_Operations.Text = number1 + " : ";
            option = '/';
            Button_CE_Click(sender, e);
        }

        private void Button_Percent_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_Comma_Click(object sender, RoutedEventArgs e)
        {
            number2 += ",";
            TBlock_Sum.Text += ","; 
        }
    }
}
