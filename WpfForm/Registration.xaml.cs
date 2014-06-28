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
using System.Windows.Shapes;
using System.IO;

namespace WpfForm {
    /// <summary>
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Window {
        List<string> fields = new List<string>();
        

        public Registration() {
            InitializeComponent();

            }

        private void Submit_Click(object sender, RoutedEventArgs e) {

            //if (Directory.Exists(@"C:\Excel"))
            //{
            //    StreamWriter writer = new StreamWriter(@"C:\Excel\Temp.txt");
            //    foreach (var item in fields)
            //    {
            //        writer.WriteLine(item);
            //    }

            //    writer.Close();
            //}
            //else
            //{
               
            //   Directory.CreateDirectory(@"C:\Excel");
            //    StreamWriter writer = new StreamWriter(@"C:\Excel\Temp.txt");
            //    foreach (var item in fields)
            //    {
            //        writer.WriteLine(item);
            //    }
               
            //    writer.Close();
            //}


        
        File.WriteAllLines(@"C:\Excel\Temp.txt", fields);
       
            }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var t = sender as TextBox;
            fields.Add(t.Text);
            }

        private void RadioButton_Checked(object sender, RoutedEventArgs e) {
            var t = sender as RadioButton;
            fields.Add(t.Content.ToString());

            }

        private void CheckBox_Checked(object sender, RoutedEventArgs e) {
            var t = sender as CheckBox;
            fields.Add(t.Content.ToString());

            }


        private void TextBox_LostFocus_1(object sender, RoutedEventArgs e)
        {
        var t = sender as TextBox;
        if(t != null && !t.Text.Contains("@") && !t.Text.Contains(".")) {
            MessageBox.Show("Please enter a valid email");
            }
        }

        private void TextBox_LostFocus_2(object sender, RoutedEventArgs e)
        {
            var t = sender as TextBox;
            if (t != null && t.Text.Length!=10)
            {
                MessageBox.Show("Phone number must have 10 digits");
            }
            }
    }
    }
