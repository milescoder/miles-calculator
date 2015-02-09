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

namespace calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        decimal _value2 = 0;
        decimal _value = 0;
        char _operation;

        public MainWindow()
        {
            InitializeComponent();
            textbox.Text = _value.ToString();
        }
     
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)e.Source;
            var number = (string)button.Content;
            textbox.Text = number;
            var value = int.Parse(number);

            if (_value == 0)
            {
                _value = value;
            }
            else
            {
                _value2 = value; 
            }
        }

        private void Button_Click_Equals(object sender, RoutedEventArgs e)
        {
            decimal sum = 0;
            if (_operation == '+') 
            {
                sum = _value + _value2 ;
            }
            else if (_operation == '-')
            {
                sum = _value - _value2;
            }
            else if (_operation == '*') {
                sum = _value * _value2;
            }
            else if (_operation == '/') {
                sum = decimal.Divide(_value, _value2);         
            }


            textbox.Text = sum.ToString();
        }

        private void Button_Click_Operator(object sender, RoutedEventArgs e)
        {
            var button = (Button)e.Source;
            var value = (string)button.Content;
            textbox.Text = value;
            _operation= value[0]; 
        }

        private void Button_Click_Clear(object sender, RoutedEventArgs e) 
        {
            _value = 0;
            _value2 = 0;
            textbox.Text = "0";

        }
    }
}
