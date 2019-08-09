using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HelaMedical.Class
{
    public class Person : INotifyPropertyChanged
    {
        public int Id { get; set; }//ID
        public string FIO {get; set; }//ФИО
        public string Pass { get; set; }//Пароль
        public string Position { get; set; }//Должность

        public static List<Person> Persons = new List<Person>();

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
