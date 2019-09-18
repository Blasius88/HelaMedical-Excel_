﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using HelaMedical.Class;
using HelaMedical.Excep;
using System.Data.Entity;
using System.Windows.Controls;

namespace HelaMedical
{
    /// <summary>
    /// Логика взаимодействия для Interface.xaml
    /// </summary>
    public partial class Interface : Window
    {
        public List<Alco> alcoFindPerson = new List<Alco>();
        public List<Narcoman> narcoFindPerson = new List<Narcoman>();
        public List<Polizavis> polizFindPerson = new List<Polizavis>();

        public Interface()
        {
            InitializeComponent();
        }

        /// <summary>
        /// открыть окно с алкоголиками 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_Order(object sender, RoutedEventArgs e)
        {
            MainDataWindow mainDataWindow = new MainDataWindow();
            mainDataWindow.Show();
        }

        /// <summary>
        /// открыть окно с наркоманами 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Edit_Order(object sender, RoutedEventArgs e)
        {
            MainDataWindow2 mainDataWindow2 = new MainDataWindow2();
            mainDataWindow2.Show();
        }

        /// <summary>
        /// открыть окно с полизависимыми 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Del_Order(object sender, RoutedEventArgs e)
        {
            MainDataWindow3 mainDataWindow3 = new MainDataWindow3();
            mainDataWindow3.Show();
        }

        /// <summary>
        /// Создать отчет по определенным критериям 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Generate_A_Report(object sender, RoutedEventArgs e)
        {
            Generate_A_Report generate_A_Report = new Generate_A_Report();
            generate_A_Report.Show();
        }

        /// <summary>
        /// Выбрать Область и регион
        /// </summary>
        private void MenuItem_OblReg_Click(object sender, RoutedEventArgs e)
        {
            OblReg oblReg = new OblReg();
            oblReg.Show();
        }

        /// <summary>
        /// Поиск карты пациента 
        /// </summary>
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            bool check_alco = false;
            bool check_narco = false;
            bool check_poliz = false;

            string findperson = FindPerson.Text;
            bool check = false;

            //Очищаем память перед записью новой информации 
            alcoFindPerson.Clear();
            narcoFindPerson.Clear();
            polizFindPerson.Clear();
            ExcelDataServis.Read_Alco();
            //Ищим инфу в колекциях
            for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
            {
                if (findperson == Alco.AlcoholismPersona[i].FIO)
                {
                    check_alco = true;
                    check = true;
                    alcoFindPerson.Add(Alco.AlcoholismPersona[i]);
                }
            }
            if (check == false)
            {
                ExcelDataServis.Read_Narco();
                for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                {
                    if (findperson == Narcoman.Drug_Addiction[i].FIO)
                    {
                        check_narco = true;
                        check = true;
                        narcoFindPerson.Add(Narcoman.Drug_Addiction[i]);
                    }
                }
            }
            else
            {
                ExcelDataServis.Read_Poliz();
                for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                {
                    if (findperson == Polizavis.Alco_Narco_Person[i].FIO)
                    {
                        check = true;
                        check_poliz = true;
                        polizFindPerson.Add(Polizavis.Alco_Narco_Person[i]);
                    }
                }
            }
            if (check == true)
            {
                if (check_alco == true)
                {
                    //Выводим инфу на экран 
                    ListOrder.ItemsSource = alcoFindPerson;

                }
                else if (check_narco == true)
                {
                    ListOrder.ItemsSource = narcoFindPerson;

                }
                else if (check_poliz == true)
                {
                    ListOrder.ItemsSource = polizFindPerson;
                }
            }
            else if (check == false)
            {
                MessageBox.Show("Данный пациент не найдено");
            }
        }
    }
}
