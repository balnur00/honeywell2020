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

namespace ZadanieWPF1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string leftop = ""; // Левый операнд
        string operation = ""; // Знак операции
        string rightop = ""; // Правый операнд


        
        bool checkedConv = false;
        double convLeft;
        string firstLength = "";
        string resultLength = "";
        double convAns;

        int num;
        double dNum;
        bool result = false;
        bool resultD = false;

        public MainWindow()
        {
            InitializeComponent();
            // Добавляем обработчик для всех кнопок на гриде
            foreach (UIElement c in LayoutRoot.Children)
            {
                if (c is Button)
                {
                    ((Button)c).Click += Button_Click;
                }
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Получаем текст кнопки
            string s = (string)((Button)e.OriginalSource).Content;
            // Добавляем его в текстовое поле
            
            
            
            

            
            //proverit int ili double
            if (intRB.IsChecked == true)
            {
                // Пытаемся преобразовать его в int число

                result = Int32.TryParse(s, out num);
            }
            else if (doubRB.IsChecked == true)
            {
                // Пытаемся преобразовать его в double число
               // MessageBox.Show("Double");
                resultD = Double.TryParse(s, out dNum);
            }

            
            // Если текст - это число
            if (result == true || resultD == true)
            {
                
                textBlock.Text += s;
                // Если операция не задана
                if (operation == "")
                {
                    // Добавляем к левому операнду
                    leftop += s;
                    
                }
                else
                {
                    // Иначе к правому операнду
                    rightop += s;
                }
            }
            // Если было введено не число
            else
            {
                // Если равно, то выводим результат операции
                if (s == "=")
                {
                    textBlock.Text += s;
                    Update_RightOp();
                    textBlock.Text += rightop;
                    operation = "";
                }
                // Очищаем поле и переменные
                else if (s == "CLEAR")
                {
                    leftop = "";
                    rightop = "";
                    operation = "";
                    textBlock.Text = "";
                }
                else
                {
                    // Если правый операнд уже имеется, то присваиваем его значение левому
                    // операнду, а правый операнд очищаем
                    if (rightop != "")
                    {
                        Update_RightOp();
                        leftop = rightop;
                        rightop = "";
                    }
                    operation = s;
                    if (s != ".")
                    {
                        textBlock.Text += s;
                    }
                }
            }
        }
        // Обновляем значение правого операнда
        private void Update_RightOp()
        {
            int num1 = Int32.Parse(leftop);
            int num2 = Int32.Parse(rightop);
            // И выполняем операцию
            switch (operation)
            {
                case "+":
                    rightop = (num1 + num2).ToString();
                    break;
                case "-":
                    rightop = (num1 - num2).ToString();
                    break;
                case "*":
                    rightop = (num1 * num2).ToString();
                    break;
                case "/":
                    rightop = (num1 / num2).ToString();
                    break;
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            MessageBox.Show($"Enter only {pressed.Content.ToString()} numbers");
        }


        private void ConvertButt_clicked(object sender, RoutedEventArgs e)
        {
            firstLength = from.SelectedValue.ToString().Substring(38);
            resultLength = to.SelectedValue.ToString().Substring(38);
            // System.Windows.MessageBox.Show(leftLen);
            bool res = Double.TryParse(fromNum.Text, out convLeft);
            if (res)
            {
                if (firstLength == "Meters")
                {
                    if (resultLength == "Millimeters")
                    {
                        convAns = convLeft * 1000;
                    }
                    else if (resultLength == "Centimeters")
                    {
                        convAns = convLeft * 100;
                    }
                    else if (resultLength == "Meters")
                    {
                        convAns = convLeft;
                    }
                    else if (resultLength == "Kilometers")
                    {
                        convAns = convLeft / 1000;
                    }
                    else if (resultLength == "Miles")
                    {
                        convAns = convLeft / 1609.34;
                    }
                    else if (resultLength == "Feet")
                    {
                        convAns = convLeft * 3.28084;
                    }

                }
                else if (firstLength == "Millimeters")
                {
                    if (resultLength == "Millimeters")
                    {
                        convAns = convLeft;
                    }
                    else if (resultLength == "Centimeters")
                    {
                        convAns = convLeft / 10;
                    }
                    else if (resultLength == "Meters")
                    {
                        convAns = convLeft / 1000;
                    }
                    else if (resultLength == "Kilometers")
                    {
                        convAns = convLeft / 1000000;
                    }
                    else if (resultLength == "Miles")
                    {
                        convAns = convLeft / 160934000000;
                    }
                    else if (resultLength == "Feet")
                    {
                        convAns = convLeft / 305;
                    }

                }
                else if (firstLength == "Centimeters")
                {
                    if (resultLength == "Millimeters")
                    {
                        convAns = convLeft * 10;
                    }
                    else if (resultLength == "Centimeters")
                    {
                        convAns = convLeft;
                    }
                    else if (resultLength == "Meters")
                    {
                        convAns = convLeft / 100;
                    }
                    else if (resultLength == "Kilometers")
                    {
                        convAns = convLeft / 100000;
                    }
                    else if (resultLength == "Miles")
                    {
                        convAns = convLeft / 16093400000;
                    }
                    else if (resultLength == "Feet")
                    {
                        convAns = convLeft / 30;
                    }
                }
                else if (firstLength == "Kilometers")
                {
                    if (resultLength == "Millimeters")
                    {
                        convAns = convLeft * 1000000;
                    }
                    else if (resultLength == "Centimeters")
                    {
                        convAns = convLeft * 100000;
                    }
                    else if (resultLength == "Meters")
                    {
                        convAns = convLeft * 1000;
                    }
                    else if (resultLength == "Kilometers")
                    {
                        convAns = convLeft;
                    }
                    else if (resultLength == "Miles")
                    {
                        convAns = convLeft / 1.609;
                    }
                    else if (resultLength == "Feet")
                    {
                        convAns = convLeft * 3281;
                    }
                }
                else if (firstLength == "Miles")
                {
                    if (resultLength == "Millimeters")
                    {
                        convAns = convLeft * 1609000;
                    }
                    else if (resultLength == "Centimeters")
                    {
                        convAns = convLeft * 160934;
                    }
                    else if (resultLength == "Meters")
                    {
                        convAns = convLeft * 1609;
                    }
                    else if (resultLength == "Kilometers")
                    {
                        convAns = convLeft * 1.609;
                    }
                    else if (resultLength == "Miles")
                    {
                        convAns = convLeft;
                    }
                    else if (resultLength == "Feet")
                    {
                        convAns = convLeft * 5280;
                    }
                }
                else if (firstLength == "Feet")
                {
                    if (resultLength == "Millimeters")
                    {
                        convAns = convLeft * 305;
                    }
                    else if (resultLength == "Centimeters")
                    {
                        convAns = convLeft * 30.5;
                    }
                    else if (resultLength == "Meters")
                    {
                        convAns = convLeft / 3.281;
                    }
                    else if (resultLength == "Kilometers")
                    {
                        convAns = convLeft / 3281;
                    }
                    else if (resultLength == "Miles")
                    {
                        convAns = convLeft / 5280;
                    }
                    else if (resultLength == "Feet")
                    {
                        convAns = convLeft;
                    }
                }
                answer.Text = convAns.ToString();
                if (checkedConv) System.Windows.MessageBox.Show(answer.Text);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string s = (string)((Button)e.OriginalSource).Content;

            // esli drobnoe chislo
            if (resultD == true && !textBlock.Text.Contains("."))
            {
                
                leftop += s;
                // MessageBox.Show("Tochka");
            }
            else if (result == true)
            {
                MessageBox.Show("Enter only integer numbers");
                
            }
            else if (resultD == true && s == "." && textBlock.Text.Contains("."))
            {
                MessageBox.Show("Please, correct your syntax.");
                leftop = "";
                rightop = "";
                operation = "";
                textBlock.Text = "";
            }
        }
    }
}
