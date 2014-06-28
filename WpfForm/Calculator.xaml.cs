using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfForm {
    /// <summary>
    /// Interaction logic for Calculator.xaml
    /// </summary>
    public partial class Calculator : Window
    {
        private Double value = 0;
        private String operation = "";
        private bool operator_pressed = false;
        public Calculator() {
            InitializeComponent();
            }

        private void Button_Click_1(object sender, RoutedEventArgs e) {
        if(operator_pressed) {
            Screen.Clear();
     
            }
            var b = (Button)sender;
            Screen.Text += b.Content; 
            }

        private void Button_Click_2(object sender, RoutedEventArgs e) {
            var b = (Button)sender;
            operation = b.Name;
            value = Double.Parse(Screen.Text);
            operator_pressed = true;
            }
              
        private void Result_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (operation)
                {
                    case "Plus":
                        Screen.Text = (value + Double.Parse(Screen.Text)).ToString();
                        break;
                    case "Minus":
                        Screen.Text = (value - Double.Parse(Screen.Text)).ToString();
                        break;
                    case "Multiply":
                        Screen.Text = (value * Double.Parse(Screen.Text)).ToString();
                        break;
                    case "Divide":
                        Screen.Text = (value / Double.Parse(Screen.Text)).ToString();
                        break;
                    default:
                        break;
                }
                operator_pressed = false;



            }
            catch (Exception exc)
            {
                Screen.Text = "Error!";
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e) {
        Screen.Text = "";


            }



        private void Back_Click(object sender, RoutedEventArgs e) {
            if(Screen.Text != "") {
                Screen.Text = Screen.Text.Remove(Screen.Text.Length - 1);
                }
            }


    }
    }
