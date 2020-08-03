using DbAppTask2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace DbAppTask2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        EmployeeContext db;
        public MainWindow()
        {
            InitializeComponent();

            db = new EmployeeContext();
            db.Employees.Load(); // загружаем данные
            employeesGrid.ItemsSource = db.Employees.Local.ToBindingList(); // устанавливаем привязку к кэшу

            this.Closing += MainWindow_Closing;
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            db.Dispose();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (employeesGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < employeesGrid.SelectedItems.Count; i++)
                {
                    Employee employee = employeesGrid.SelectedItems[i] as Employee;
                    if (employee != null)
                    {
                        db.Employees.Remove(employee);
                    }
                }
            }
            db.SaveChanges();
        }

        private void submitNewEmployee(object sender, RoutedEventArgs e)
        {
            bool success = true;
            try
            {
                Employee newEmp = new Employee();
                this.DataContext = newEmp;

                if (FullName.Text.Length < 255 && FullName.Text.Length > 5 && Regex.IsMatch(FullName.Text, @"^[a-zA-Z]+$"))
                {
                    newEmp.FullName = FullName.Text;
                }
                else
                {
                    success = false;
                    MessageBox.Show("Full Name must be more than 5 characters and mustn't exceed 255 characters  and must contain only latin alphabet.");
                }

                if (Int32.TryParse(Age.Text, out int val))
                {
                    if (val > 15 && val < 64)
                    {
                        newEmp.Age = val;
                    }
                    else
                    {
                        success = false;
                        MessageBox.Show("Employee age must be 15<x<64");
                    }
                    
                }
                else
                {
                    success = false;
                    MessageBox.Show("Correct the Age field");
                }

                newEmp.Position = Position.Text;
                newEmp.Gender = Gender.Text;

                if (IsMarriedCB.IsChecked.Equals(true))
                {
                    newEmp.Married = true;
                }
                else
                {
                    newEmp.Married = false;
                }

                if (success == true)
                {
                    db.Employees.Add(newEmp);
                    db.SaveChanges();
                    MessageBox.Show("New employee is successfully created!");
                    FullName.Text = "";
                    Age.Text = "";
                }
                else
                {
                    MessageBox.Show("Couldnt perform the operation! Check your input, please");
                }
                
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.ToString());
            }

        }
    }
}
