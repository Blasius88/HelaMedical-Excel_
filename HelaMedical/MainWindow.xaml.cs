using System;
using System.Data.Entity;
using System.Windows;
using HelaMedical.Class;
using HelaMedical.Excep;
using System.IO;
using System.Data.SqlClient;
using System.Data.Entity.Core.EntityClient;

namespace HelaMedical
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            try
            {
                ReadPerson.Reader_Excel_Person();
                InitializeComponent();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
            }
        }

        /// <summary>
        /// Регистрация нового сотрудника 
        /// </summary>
        public void Button_Registration(object sender, RoutedEventArgs e)
        {
            NewPersonalWindow newPersonal = new NewPersonalWindow();
            newPersonal.Show();
        }

        //public void FileLoad()
        //{
        //    try
        //    {
        //        string path = @"d:\HelaMedical\HelaMedical\File\Person.xcls";
        //        string s = File.ReadAllText(path);
        //        DBConection.Select(s);
        //    }
        //    catch (Exception excep)
        //    {
        //        MessageBox.Show(excep.Message);
        //        ExcepLog.Excep(excep);
        //    }
        //}

        /// <summary>
        /// Вход в систему
        /// </summary>
        private void Button_Entry(object sender, RoutedEventArgs e)
        {
            try
            {
                bool c = false; // Для проверики наличия имени в массиве 
                string a = tb.Text;
                string b = Convert.ToString(pass.Password);
                // проверяем соответствие имени и пароля в системе 
                foreach (var sIncitalization in Person.Persons)
                {
                    if (a == sIncitalization.FIO && b == sIncitalization.Pass)
                    {
                        c = true;
                        Incitalization reg = new Incitalization
                        {

                            Name = a
                        };
                        Incitalization.Registr.Add(reg);
                        Other.Regis = a; // запоминаем имя регистратора данных
                        break;
                    }
                    // имя не найдено 
                    else
                    {
                        c = false;
                    }
                }
                
                // если в массиве нет имени 
                if (c == false)
                {
                    MessageBox.Show("Неправельно введен логин или пароль");
                    tb.Clear(); // очищает поле логин
                    pass.Clear(); // очищает поле пароль
                }

                else
                {
                    Interface iInterface = new Interface();
                    iInterface.Show();
                    Close();
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
                return;
            }
        }
    }
}