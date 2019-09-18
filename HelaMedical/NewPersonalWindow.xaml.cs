using System;
using System.Windows;
using System.IO;
using System.Windows.Media;
using HelaMedical.Class;
using static HelaMedical.Incitalization;
using HelaMedical.Excep;
using System.Data.Entity;

namespace HelaMedical
{
    /// <summary>
    /// Логика взаимодействия для NewPersonalWindow.xaml
    /// </summary>
    public partial class NewPersonalWindow : Window
    {
        public NewPersonalWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// закрытие окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewPersonalClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Добавление нового персонала
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewPersonalAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int a = 0;
                string fio = NewPersonalFIO.Text;
                //проверяем пустое ли поле
                if (fio == "")
                {
                    NewPersonalFIO.BorderThickness = new Thickness(3);
                    NewPersonalFIO.BorderBrush = Brushes.Red;
                    MessageBox.Show("Не ввели ФИО");
                    return;
                }
                else a++;
                string position = NewPersonalPosition.Text;
                if (position == "")
                {
                    NewPersonalPosition.BorderThickness = new Thickness(3);
                    NewPersonalPosition.BorderBrush = Brushes.Red;
                    MessageBox.Show("Не ввели должность");
                    return;
                }
                else a++;
                string pass = NewPersonalPassword.Text;
                if (pass == "")
                {
                    NewPersonalPassword.BorderThickness = new Thickness(3);
                    NewPersonalPassword.BorderBrush = Brushes.Red;
                    MessageBox.Show("Не ввели пароль");
                    return;
                }
                else a++;

                string pass1 = NewPersonalPassword1.Text;
                if (pass == "")
                {
                    NewPersonalPassword1.BorderThickness = new Thickness(3);
                    NewPersonalPassword1.BorderBrush = Brushes.Red;
                    MessageBox.Show("Не ввели повторно пароль");
                    return;
                }
                else a++;

                //Проверяем на наличие данного имени в базе 
                for (int i = 0; i < Person.Persons.Count; i++)
                {
                    if (fio == Person.Persons[i].FIO)
                    {
                        NewPersonalFIO.BorderThickness = new Thickness(3);
                        NewPersonalFIO.BorderBrush = Brushes.Red;
                        MessageBox.Show("Такой пользователь уже существует");
                        return;
                    }
                }
                if (NewPersonalPassword.Text != NewPersonalPassword1.Text)
                {
                    NewPersonalPassword.BorderThickness = new Thickness(3);
                    NewPersonalPassword1.BorderThickness = new Thickness(3);
                    NewPersonalPassword.BorderBrush = Brushes.Red;
                    NewPersonalPassword1.BorderBrush = Brushes.Red;
                    MessageBox.Show("Пароли не совпадают");
                    return;
                }

                if (a <= 3) return;
                else
                {
                    ReadPerson.Patient_Сreation_Person(fio, pass, position);
                    Close();
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
            }
        }
    }
}
