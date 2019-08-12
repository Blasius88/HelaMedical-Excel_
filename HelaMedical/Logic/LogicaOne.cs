using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using HelaMedical.Class;
using HelaMedical.Excep;

namespace HelaMedical.Logic
{
    public class LogicaOne : Generate_A_Report
    {
        /// <summary>
        /// Принемает 1 параметр
        /// </summary>
        public void DataGridFormat (string a)
        {
            if (a == "Алкогольная")
            {
                Generate_List_Alco();
                for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                {
                        alco.Add(Alco.AlcoholismPersona[i]);
                }
                DataGrid.ItemsSource = alco;
            }

            else if (a == "Наркотическая")
            {
                Generate_List_Narco();
                for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                {
                    narco.Add(Narcoman.Drug_Addiction[i]);
                }
                DataGrid.ItemsSource = narco;
            }

            else if (a == "Полизависимость")
            {
                Generate_List_Poliz();
                for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                {
                    poliz.Add(Polizavis.Alco_Narco_Person[i]);
                }
                DataGrid.ItemsSource = poliz;
            }
        }

        /// <summary>
        /// Принемает 2 параметра 
        /// </summary>
        public void DataGridFormat(string a, string b)
        {
            try
            {
                if (a == "Алкогольная")
                {

                    Generate_List_Alco();
                   
                    if (_regionCenterBLR == b)
                    {
                        for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                        {
                            if (Alco.AlcoholismPersona[i].RegionCenterBLR == b)
                            {
                                alco.Add(Alco.AlcoholismPersona[i]);
                            }
                        }
                    }

                    else if (_sex == b)
                    {
                        for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                        {
                            if (Alco.AlcoholismPersona[i].Sex == b)
                            {
                                alco.Add(Alco.AlcoholismPersona[i]);
                            }
                        }
                    }

                    else if (_familyStatus == b)
                    {
                        for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                        {
                            if (Alco.AlcoholismPersona[i].FamilyStatus == b)
                            {
                                alco.Add(Alco.AlcoholismPersona[i]);
                            }
                        }
                    }

                    else if (_costOfKids == b)
                    {

                        for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                        {
                            if (Alco.AlcoholismPersona[i].CostOfKids == b)
                            {
                                alco.Add(Alco.AlcoholismPersona[i]);
                            }
                        }
                    }

                    else if (_familyComposition == b)
                    {

                        for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                        {
                            if (Alco.AlcoholismPersona[i].FamilyComposition == b)
                            {
                                alco.Add(Alco.AlcoholismPersona[i]);
                            }
                        }
                    }

                    else if (_education == b)
                    {
                        for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                        {
                            if (Alco.AlcoholismPersona[i].Education == b)
                            {
                                alco.Add(Alco.AlcoholismPersona[i]);
                            }
                        }
                    }

                    else if (_periodS == b)
                    {
                        for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                        {
                            string[] mas = Alco.AlcoholismPersona[i].DateOfDeregistration.Split('.', ',', '/');
                            string data = mas[2];
                            if (data == b)
                            {
                                alco.Add(Alco.AlcoholismPersona[i]);
                            }
                        }
                    }

                    else if (_periodPo == b)
                    {
                        for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                        {
                            string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split(',', '.', '/');
                            string data = mas[2];
                            if (data == b)
                            {
                                alco.Add(Alco.AlcoholismPersona[i]);
                            }
                        }
                    }

                    DataGrid.ItemsSource = alco;

                }

                else if (a == "Наркотическая")
                {
                    Generate_List_Narco();
                    if (_regionCenterBLR == b)
                    {
                        for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                        {
                            if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b)
                            {
                                narco.Add(Narcoman.Drug_Addiction[i]);
                            }
                        }
                    }

                    else if (_sex == b)
                    {
                        for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                        {
                            if (Narcoman.Drug_Addiction[i].Sex == b)
                            {
                                narco.Add(Narcoman.Drug_Addiction[i]);
                            }
                        }
                    }

                    else if (_familyStatus == b)
                    {
                        for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                        {
                            if (Narcoman.Drug_Addiction[i].FamilyStatus == b)
                            {
                                narco.Add(Narcoman.Drug_Addiction[i]);
                            }
                        }
                    }

                    else if (_costOfKids == b)
                    {
                        for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                        {
                            if (Narcoman.Drug_Addiction[i].CostOfKids == b)
                            {
                                narco.Add(Narcoman.Drug_Addiction[i]);
                            }
                        }
                    }

                    else if (_familyComposition == b)
                    {
                        for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                        {
                            if (Narcoman.Drug_Addiction[i].FamilyComposition == b)
                            {
                                narco.Add(Narcoman.Drug_Addiction[i]);
                            }
                        }
                    }

                    else if (_education == b)
                    {
                        for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                        {
                            if (Narcoman.Drug_Addiction[i].Education == b)
                            {
                                narco.Add(Narcoman.Drug_Addiction[i]);
                            }
                        }
                    }

                    else if (_periodS == b)
                    {
                        for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                        {
                            string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split(',', '.', '/');
                            string data = mas[2];
                            if (data == b)
                            {
                                narco.Add(Narcoman.Drug_Addiction[i]);
                            }
                        }
                    }

                    else if (_periodPo == b)
                    {
                        for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                        {
                            string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split(',', '.', '/');
                            string data = mas[2];
                            if (data == b)
                            {
                                narco.Add(Narcoman.Drug_Addiction[i]);
                            }
                        }
                    }

                    DataGrid.ItemsSource = narco;
                }

                else if (a == "Полизависимость")
                {
                    Generate_List_Poliz();
                    if (_regionCenterBLR == b)
                    {
                        for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                        {
                            if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b)
                            {
                                poliz.Add(Polizavis.Alco_Narco_Person[i]);
                            }
                        }
                    }

                    else if (_sex == b)
                    {
                        for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                        {
                            if (Polizavis.Alco_Narco_Person[i].Sex == b)
                            {
                                poliz.Add(Polizavis.Alco_Narco_Person[i]);
                            }
                        }
                    }

                    else if (_familyStatus == b)
                    {
                        for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                        {
                            if (Polizavis.Alco_Narco_Person[i].FamilyStatus == b)
                            {
                                poliz.Add(Polizavis.Alco_Narco_Person[i]);
                            }
                        }
                    }

                    else if (_costOfKids == b)
                    {
                        for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                        {
                            if (Polizavis.Alco_Narco_Person[i].CostOfKids == b)
                            {
                                poliz.Add(Polizavis.Alco_Narco_Person[i]);
                            }
                        }
                    }

                    else if (_familyComposition == b)
                    {
                        for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                        {
                            if (Polizavis.Alco_Narco_Person[i].FamilyComposition == b)
                            {
                                poliz.Add(Polizavis.Alco_Narco_Person[i]);
                            }
                        }
                    }

                    else if (_education == b)
                    {
                        for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                        {
                            if (Polizavis.Alco_Narco_Person[i].Education == b)
                            {
                                poliz.Add(Polizavis.Alco_Narco_Person[i]);
                            }
                        }
                    }

                    else if (_periodS == b)
                    {
                        for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                        {
                            string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split(',', '.', '/');
                            string data = mas[2];
                            if (data == b)
                            {
                                poliz.Add(Polizavis.Alco_Narco_Person[i]);
                            }
                        }
                    }

                    else if (_periodPo == b)
                    {
                        for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                        {
                            string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split(',', '.', '/');
                            string data = mas[2];
                            if (data == b)
                            {
                                poliz.Add(Polizavis.Alco_Narco_Person[i]);
                            }
                        }
                    }

                    DataGrid.ItemsSource = poliz;

                }

            }
             catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
            }
        }

        /// <summary>
        /// обрабатывает 3 параметра 
        /// </summary>
        public void DataGridFormat(string a, string b, string c)
        {
            if (a == "Алкогольная")
            {
                Generate_List_Alco();
                if (_regionCenterBLR == b && _sex == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b && Alco.AlcoholismPersona[i].Sex == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b && Alco.AlcoholismPersona[i].FamilyStatus == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b && Alco.AlcoholismPersona[i].CostOfKids == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyComposition == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b && Alco.AlcoholismPersona[i].FamilyComposition == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _education == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b && Alco.AlcoholismPersona[i].Education == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c)
                {

                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].Sex == b && Alco.AlcoholismPersona[i].FamilyStatus == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c)
                {

                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].Sex == b && Alco.AlcoholismPersona[i].CostOfKids == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _familyComposition == c)
                {

                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].Sex == b && Alco.AlcoholismPersona[i].FamilyComposition == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _education == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].Sex == b && Alco.AlcoholismPersona[i].Education == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _costOfKids == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].FamilyStatus == b && Alco.AlcoholismPersona[i].CostOfKids == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _familyComposition == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].FamilyStatus == b && Alco.AlcoholismPersona[i].FamilyComposition == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _education == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].FamilyStatus == b && Alco.AlcoholismPersona[i].Education == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _familyComposition == c)
                {

                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].CostOfKids == b && Alco.AlcoholismPersona[i].FamilyComposition == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _education == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].CostOfKids == b && Alco.AlcoholismPersona[i].Education == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_familyComposition == b && _education == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].FamilyComposition == b && Alco.AlcoholismPersona[i].Education == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_education == b)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].FamilyComposition == b)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }
                // По датам 
                else if (_regionCenterBLR == b && _periodS == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b && data == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _periodPo == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b && data == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _periodS == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Sex == b && data == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _periodPo == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Sex == b && data == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _periodS == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].FamilyStatus == b && data == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _periodPo == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].FamilyStatus == b && data == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _periodS == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].CostOfKids == b && data == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _periodPo == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].CostOfKids == b && data == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_familyComposition == b && _periodS == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].FamilyComposition == b && data == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_familyComposition == b && _periodPo == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].FamilyComposition == b && data == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_education == b && _periodS == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Education == b && data == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_education == b && _periodPo == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Education == b && data == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_periodS == b && _periodPo == c)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (data == b && data1 == c)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                DataGrid.ItemsSource = alco;
            }

            else if (a == "Наркотическая")
            {
                Generate_List_Narco();
                if (_regionCenterBLR == b && _sex == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b && Narcoman.Drug_Addiction[i].Sex == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b && Narcoman.Drug_Addiction[i].FamilyStatus == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b && Narcoman.Drug_Addiction[i].CostOfKids == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyComposition == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b && Narcoman.Drug_Addiction[i].FamilyComposition == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _education == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b && Narcoman.Drug_Addiction[i].Education == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].Sex == b && Narcoman.Drug_Addiction[i].FamilyStatus == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].Sex == b && Narcoman.Drug_Addiction[i].CostOfKids == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _familyComposition == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].Sex == b && Narcoman.Drug_Addiction[i].FamilyComposition == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _education == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].Sex == b && Narcoman.Drug_Addiction[i].Education == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _costOfKids == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].FamilyStatus == b && Narcoman.Drug_Addiction[i].CostOfKids == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _familyComposition == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].FamilyStatus == b && Narcoman.Drug_Addiction[i].FamilyComposition == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _education == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].FamilyStatus == b && Narcoman.Drug_Addiction[i].Education == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _familyComposition == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].CostOfKids == b && Narcoman.Drug_Addiction[i].FamilyComposition == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _education == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].CostOfKids == b && Narcoman.Drug_Addiction[i].Education == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_familyComposition == b && _education == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].FamilyComposition == b && Narcoman.Drug_Addiction[i].Education == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_education == b)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].FamilyComposition == b)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }
                //Используется дата 
                else if (_regionCenterBLR == b && _periodS == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b && data == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _periodPo == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b && data == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _periodS == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Sex == b && data == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _periodPo == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Sex == b && data == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _periodS == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].FamilyStatus == b && data == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _periodPo == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].FamilyStatus == b && data == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _periodS == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].CostOfKids == b && data == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _periodPo == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].CostOfKids == b && data == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_familyComposition == b && _periodS == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].FamilyComposition == b && data == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_familyComposition == b && _periodPo == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].FamilyComposition == b && data == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_education == b && _periodS == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Education == b && data == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_education == b && _periodPo == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Education == b && data == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_periodS == b && _periodPo == c)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (data == b && data1 == c)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                DataGrid.ItemsSource = narco;
            }

            else if (a == "Полизависимость")
            {
                Generate_List_Poliz();
                if (_regionCenterBLR == b && _sex == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b && Polizavis.Alco_Narco_Person[i].Sex == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b && Polizavis.Alco_Narco_Person[i].FamilyStatus == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b && Polizavis.Alco_Narco_Person[i].CostOfKids == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyComposition == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b && Polizavis.Alco_Narco_Person[i].FamilyComposition == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _education == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b && Polizavis.Alco_Narco_Person[i].Education == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].Sex == b && Polizavis.Alco_Narco_Person[i].FamilyStatus == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].Sex == b && Polizavis.Alco_Narco_Person[i].CostOfKids == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyComposition == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].Sex == b && Polizavis.Alco_Narco_Person[i].FamilyComposition == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _education == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].Sex == b && Polizavis.Alco_Narco_Person[i].Education == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _costOfKids == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].FamilyStatus == b && Polizavis.Alco_Narco_Person[i].CostOfKids == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _familyComposition == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].FamilyStatus == b && Polizavis.Alco_Narco_Person[i].FamilyComposition == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _education == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].FamilyStatus == b && Polizavis.Alco_Narco_Person[i].Education == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _familyComposition == c)
                {

                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].CostOfKids == b && Polizavis.Alco_Narco_Person[i].FamilyComposition == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _education == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].CostOfKids == b && Polizavis.Alco_Narco_Person[i].Education == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_familyComposition == b && _education == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].FamilyComposition == b && Polizavis.Alco_Narco_Person[i].Education == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }
                //по дате 
                else if (_regionCenterBLR == b && _periodS == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b && data == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _periodPo == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b && data == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _periodS == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Sex == b && data == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _periodPo == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Sex == b && data == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _periodS == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].FamilyStatus == b && data == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _periodPo == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].FamilyStatus == b && data == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _periodS == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].CostOfKids == b && data == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _periodPo == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].CostOfKids == b && data == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_familyComposition == b && _periodS == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].FamilyComposition == b && data == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_familyComposition == b && _periodPo == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].FamilyComposition == b && data == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_education == b && _periodS == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Education == b && data == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_education == b && _periodPo == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Education == b && data == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_periodS == b && _periodPo == c)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (data == b && data1 == c)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                DataGrid.ItemsSource = poliz;
            }
        }

        /// <summary>
        /// Принемает 4 параметра  
        /// </summary>
        public void DataGridFormat(string a, string b, string c, string d)
        {
            if (a == "Алкогольная")
            {
                Generate_List_Alco();
                if (_regionCenterBLR == b && _sex == c && _familyStatus == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyStatus == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].CostOfKids == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyComposition == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyComposition == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _education == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].Education == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _costOfKids == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].CostOfKids == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _familyComposition == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].FamilyComposition == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _education == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].Education == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c && _familyComposition == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].CostOfKids == c
                            && Alco.AlcoholismPersona[i].FamilyComposition == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c && _education == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].CostOfKids == c
                            && Alco.AlcoholismPersona[i].Education == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyComposition == c && _education == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].FamilyComposition == c
                            && Alco.AlcoholismPersona[i].Education == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].Sex == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].CostOfKids == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _familyComposition == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].Sex == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].FamilyComposition == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _education == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].Sex == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].Education == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c && _familyComposition == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].Sex == b
                            && Alco.AlcoholismPersona[i].CostOfKids == c
                            && Alco.AlcoholismPersona[i].FamilyComposition == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c && _education == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].Sex == b
                            && Alco.AlcoholismPersona[i].CostOfKids == c
                            && Alco.AlcoholismPersona[i].Education == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _familyComposition == c && _education == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].Sex == b
                            && Alco.AlcoholismPersona[i].FamilyComposition == c
                            && Alco.AlcoholismPersona[i].Education == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _costOfKids == c && _familyComposition == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].FamilyStatus == b
                            && Alco.AlcoholismPersona[i].CostOfKids == c
                            && Alco.AlcoholismPersona[i].FamilyComposition == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _costOfKids == c && _education == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].FamilyStatus == b
                            && Alco.AlcoholismPersona[i].CostOfKids == c
                            && Alco.AlcoholismPersona[i].Education == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _familyComposition == c && _education == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].FamilyStatus == b
                            && Alco.AlcoholismPersona[i].FamilyComposition == c
                            && Alco.AlcoholismPersona[i].Education == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _familyComposition == c && _education == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].CostOfKids == b
                            && Alco.AlcoholismPersona[i].FamilyComposition == c
                            && Alco.AlcoholismPersona[i].Education == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                // Дата----------------------------------------------------------------------------------------------------------------------------------
                else if (_regionCenterBLR == b && _sex == c && _periodS == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Education == b 
                            && Alco.AlcoholismPersona[i].Sex == c
                            && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Education == b && Alco.AlcoholismPersona[i].Sex == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _periodS == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Education == b && Alco.AlcoholismPersona[i].FamilyStatus == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Education == b 
                            && Alco.AlcoholismPersona[i].FamilyStatus == c 
                            && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c && _periodS == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Education == b && Alco.AlcoholismPersona[i].CostOfKids == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Education == b 
                            && Alco.AlcoholismPersona[i].CostOfKids == c 
                            && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyComposition == c && _periodS == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Education == b && Alco.AlcoholismPersona[i].FamilyComposition == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyComposition == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Education == b && Alco.AlcoholismPersona[i].FamilyComposition == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _education == c && _periodS == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Education == b && Alco.AlcoholismPersona[i].Education == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _education == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Education == b && Alco.AlcoholismPersona[i].Education == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                //-----------------------------------------------------------------------------------------------------------------------------------
                else if (_sex == b && _familyStatus == c && _periodS == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Sex == b && Alco.AlcoholismPersona[i].FamilyStatus == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Sex == b && Alco.AlcoholismPersona[i].FamilyStatus == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c && _periodS == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Sex == b && Alco.AlcoholismPersona[i].CostOfKids == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Sex == b && Alco.AlcoholismPersona[i].CostOfKids == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _familyComposition == c && _periodS == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Sex == b && Alco.AlcoholismPersona[i].FamilyComposition == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _familyComposition == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Sex == b && Alco.AlcoholismPersona[i].FamilyComposition == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _education == c && _periodS == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Sex == b && Alco.AlcoholismPersona[i].Education == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _education == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Sex == b && Alco.AlcoholismPersona[i].Education == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }
                //-------------------------------------------------------------------------------------------------------------------------------------
                else if (_familyStatus == b && _costOfKids == c && _periodS == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].FamilyStatus == b && Alco.AlcoholismPersona[i].CostOfKids == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _costOfKids == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].FamilyStatus == b && Alco.AlcoholismPersona[i].CostOfKids == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _familyComposition == c && _periodS == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].FamilyStatus == b && Alco.AlcoholismPersona[i].FamilyComposition == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _familyComposition == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].FamilyStatus == b && Alco.AlcoholismPersona[i].FamilyComposition == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _education == c && _periodS == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].FamilyStatus == b && Alco.AlcoholismPersona[i].Education == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _education == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].FamilyStatus == b && Alco.AlcoholismPersona[i].Education == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                //----------------------------------------------------------------------------------------------------------------------------------------
                else if (_costOfKids == b && _familyComposition == c && _periodS == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].CostOfKids == b && Alco.AlcoholismPersona[i].FamilyComposition == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _familyComposition == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].CostOfKids == b && Alco.AlcoholismPersona[i].FamilyComposition == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _education == c && _periodS == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].CostOfKids == b && Alco.AlcoholismPersona[i].Education == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _education == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].CostOfKids == b && Alco.AlcoholismPersona[i].Education == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }
                //-----------------------------------------------------------------------------------------------------------------------------------------------
                else if (_familyComposition == b && _education == c && _periodS == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].FamilyComposition == b && Alco.AlcoholismPersona[i].Education == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_familyComposition == b && _education == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].FamilyComposition == b && Alco.AlcoholismPersona[i].Education == c && data == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }
                //----------------------------------------------------------------------------------------------------------------------------------------------
                else if (_regionCenterBLR == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.',',','/');
                        string data = mas[2];
                        string[] mas1 = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b && data == c && data1 == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Alco.AlcoholismPersona[i].Sex == b && data == c && data1 == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Alco.AlcoholismPersona[i].FamilyStatus == b && data == c && data1 == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Alco.AlcoholismPersona[i].CostOfKids == b && data == c && data1 == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_familyComposition == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Alco.AlcoholismPersona[i].FamilyComposition == b && data == c && data1 == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_education == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Alco.AlcoholismPersona[i].Education == b && data == c && data1 == d)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                DataGrid.ItemsSource = alco;
            }

            else if (a == "Наркотическая")
            {
                Generate_List_Narco();
                if (_regionCenterBLR == b && _sex == c && _familyStatus == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyStatus == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].CostOfKids == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyComposition == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyComposition == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _education == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].Education == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _costOfKids == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].CostOfKids == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _familyComposition == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].FamilyComposition == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _education == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].Education == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c && _familyComposition == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].CostOfKids == c
                            && Narcoman.Drug_Addiction[i].FamilyComposition == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c && _education == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].CostOfKids == c
                            && Narcoman.Drug_Addiction[i].Education == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyComposition == c && _education == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].FamilyComposition == c
                            && Narcoman.Drug_Addiction[i].Education == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].Sex == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].CostOfKids == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _familyComposition == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].Sex == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].FamilyComposition == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _education == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].Sex == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].Education == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c && _familyComposition == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].Sex == b
                            && Narcoman.Drug_Addiction[i].CostOfKids == c
                            && Narcoman.Drug_Addiction[i].FamilyComposition == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c && _education == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].Sex == b
                            && Narcoman.Drug_Addiction[i].CostOfKids == c
                            && Narcoman.Drug_Addiction[i].Education == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _familyComposition == c && _education == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].Sex == b
                            && Narcoman.Drug_Addiction[i].FamilyComposition == c
                            && Narcoman.Drug_Addiction[i].Education == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _costOfKids == c && _familyComposition == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].FamilyStatus == b
                            && Narcoman.Drug_Addiction[i].CostOfKids == c
                            && Narcoman.Drug_Addiction[i].FamilyComposition == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _costOfKids == c && _education == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].FamilyStatus == b
                            && Narcoman.Drug_Addiction[i].CostOfKids == c
                            && Narcoman.Drug_Addiction[i].Education == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _familyComposition == c && _education == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].FamilyStatus == b
                            && Narcoman.Drug_Addiction[i].FamilyComposition == c
                            && Narcoman.Drug_Addiction[i].Education == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _familyComposition == c && _education == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].CostOfKids == b
                            && Narcoman.Drug_Addiction[i].FamilyComposition == c
                            && Narcoman.Drug_Addiction[i].Education == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                // Дата----------------------------------------------------------------------------------------------------------------------------------
                else if (_regionCenterBLR == b && _sex == c && _periodS == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Education == b && Narcoman.Drug_Addiction[i].Sex == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _periodPo == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Education == b && Narcoman.Drug_Addiction[i].Sex == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _periodS == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Education == b && Narcoman.Drug_Addiction[i].FamilyStatus == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _periodPo == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Education == b && Narcoman.Drug_Addiction[i].FamilyStatus == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c && _periodS == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Education == b && Narcoman.Drug_Addiction[i].CostOfKids == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c && _periodPo == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Education == b && Narcoman.Drug_Addiction[i].CostOfKids == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyComposition == c && _periodS == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Education == b && Narcoman.Drug_Addiction[i].FamilyComposition == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyComposition == c && _periodPo == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Education == b && Narcoman.Drug_Addiction[i].FamilyComposition == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _education == c && _periodS == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Education == b && Narcoman.Drug_Addiction[i].Education == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _education == c && _periodPo == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Education == b && Narcoman.Drug_Addiction[i].Education == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                //-----------------------------------------------------------------------------------------------------------------------------------
                else if (_sex == b && _familyStatus == c && _periodS == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Sex == b && Narcoman.Drug_Addiction[i].FamilyStatus == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _periodPo == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Sex == b && Narcoman.Drug_Addiction[i].FamilyStatus == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c && _periodS == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Sex == b && Narcoman.Drug_Addiction[i].CostOfKids == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c && _periodPo == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Sex == b && Narcoman.Drug_Addiction[i].CostOfKids == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _familyComposition == c && _periodS == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Sex == b && Narcoman.Drug_Addiction[i].FamilyComposition == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _familyComposition == c && _periodPo == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Sex == b && Narcoman.Drug_Addiction[i].FamilyComposition == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _education == c && _periodS == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Sex == b && Narcoman.Drug_Addiction[i].Education == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _education == c && _periodPo == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Sex == b && Narcoman.Drug_Addiction[i].Education == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }
                //-------------------------------------------------------------------------------------------------------------------------------------
                else if (_familyStatus == b && _costOfKids == c && _periodS == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].FamilyStatus == b && Narcoman.Drug_Addiction[i].CostOfKids == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _costOfKids == c && _periodPo == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].FamilyStatus == b && Narcoman.Drug_Addiction[i].CostOfKids == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _familyComposition == c && _periodS == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].FamilyStatus == b && Narcoman.Drug_Addiction[i].FamilyComposition == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _familyComposition == c && _periodPo == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].FamilyStatus == b && Narcoman.Drug_Addiction[i].FamilyComposition == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _education == c && _periodS == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].FamilyStatus == b && Narcoman.Drug_Addiction[i].Education == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _education == c && _periodPo == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].FamilyStatus == b && Narcoman.Drug_Addiction[i].Education == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                //----------------------------------------------------------------------------------------------------------------------------------------
                else if (_costOfKids == b && _familyComposition == c && _periodS == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].CostOfKids == b && Narcoman.Drug_Addiction[i].FamilyComposition == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _familyComposition == c && _periodPo == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].CostOfKids == b && Narcoman.Drug_Addiction[i].FamilyComposition == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _education == c && _periodS == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].CostOfKids == b && Narcoman.Drug_Addiction[i].Education == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _education == c && _periodPo == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].CostOfKids == b && Narcoman.Drug_Addiction[i].Education == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }
                //-----------------------------------------------------------------------------------------------------------------------------------------------
                else if (_familyComposition == b && _education == c && _periodS == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].FamilyComposition == b && Narcoman.Drug_Addiction[i].Education == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_familyComposition == b && _education == c && _periodPo == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].FamilyComposition == b && Narcoman.Drug_Addiction[i].Education == c && data == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }
                //----------------------------------------------------------------------------------------------------------------------------------------------
                else if (_regionCenterBLR == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b && data == c && data1 == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Narcoman.Drug_Addiction[i].Sex == b && data == c && data1 == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Narcoman.Drug_Addiction[i].FamilyStatus == b && data == c && data1 == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Narcoman.Drug_Addiction[i].CostOfKids == b && data == c && data1 == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_familyComposition == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Narcoman.Drug_Addiction[i].FamilyComposition == b && data == c && data1 == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_education == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Narcoman.Drug_Addiction[i].Education == b && data == c && data1 == d)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                DataGrid.ItemsSource = narco;
            }

            else if (a == "Полизависимость")
            {
                Generate_List_Poliz();
                if (_regionCenterBLR == b && _sex == c && _familyStatus == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyComposition == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _education == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].Education == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _costOfKids == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _familyComposition == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _education == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].Education == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c && _familyComposition == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == c
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c && _education == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == c
                            && Polizavis.Alco_Narco_Person[i].Education == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyComposition == c && _education == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == c
                            && Polizavis.Alco_Narco_Person[i].Education == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].Sex == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _familyComposition == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].Sex == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _education == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].Sex == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].Education == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c && _familyComposition == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].Sex == b
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == c
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c && _education == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].Sex == b
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == c
                            && Polizavis.Alco_Narco_Person[i].Education == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyComposition == c && _education == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].Sex == b
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == c
                            && Polizavis.Alco_Narco_Person[i].Education == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _costOfKids == c && _familyComposition == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].FamilyStatus == b
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == c
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _costOfKids == c && _education == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].FamilyStatus == b
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == c
                            && Polizavis.Alco_Narco_Person[i].Education == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _familyComposition == c && _education == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].FamilyStatus == b
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == c
                            && Polizavis.Alco_Narco_Person[i].Education == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _familyComposition == c && _education == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].CostOfKids == b
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == c
                            && Polizavis.Alco_Narco_Person[i].Education == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                // Дата----------------------------------------------------------------------------------------------------------------------------------
                else if (_regionCenterBLR == b && _sex == c && _periodS == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Education == b && Polizavis.Alco_Narco_Person[i].Sex == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _periodPo == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Education == b && Polizavis.Alco_Narco_Person[i].Sex == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _periodS == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Education == b && Polizavis.Alco_Narco_Person[i].FamilyStatus == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _periodPo == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Education == b && Polizavis.Alco_Narco_Person[i].FamilyStatus == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c && _periodS == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Education == b && Polizavis.Alco_Narco_Person[i].CostOfKids == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c && _periodPo == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Education == b && Polizavis.Alco_Narco_Person[i].CostOfKids == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyComposition == c && _periodS == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Education == b && Polizavis.Alco_Narco_Person[i].FamilyComposition == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyComposition == c && _periodPo == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Education == b && Polizavis.Alco_Narco_Person[i].FamilyComposition == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _education == c && _periodS == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Education == b && Polizavis.Alco_Narco_Person[i].Education == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _education == c && _periodPo == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Education == b && Polizavis.Alco_Narco_Person[i].Education == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                //-----------------------------------------------------------------------------------------------------------------------------------
                else if (_sex == b && _familyStatus == c && _periodS == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Sex == b && Polizavis.Alco_Narco_Person[i].FamilyStatus == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _periodPo == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Sex == b && Polizavis.Alco_Narco_Person[i].FamilyStatus == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c && _periodS == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Sex == b && Polizavis.Alco_Narco_Person[i].CostOfKids == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c && _periodPo == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Sex == b && Polizavis.Alco_Narco_Person[i].CostOfKids == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyComposition == c && _periodS == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Sex == b && Polizavis.Alco_Narco_Person[i].FamilyComposition == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyComposition == c && _periodPo == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Sex == b && Polizavis.Alco_Narco_Person[i].FamilyComposition == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _education == c && _periodS == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Sex == b && Polizavis.Alco_Narco_Person[i].Education == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _education == c && _periodPo == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Sex == b && Polizavis.Alco_Narco_Person[i].Education == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }
                //-------------------------------------------------------------------------------------------------------------------------------------
                else if (_familyStatus == b && _costOfKids == c && _periodS == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].FamilyStatus == b && Polizavis.Alco_Narco_Person[i].CostOfKids == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _costOfKids == c && _periodPo == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].FamilyStatus == b && Polizavis.Alco_Narco_Person[i].CostOfKids == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _familyComposition == c && _periodS == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].FamilyStatus == b && Polizavis.Alco_Narco_Person[i].FamilyComposition == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _familyComposition == c && _periodPo == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].FamilyStatus == b && Polizavis.Alco_Narco_Person[i].FamilyComposition == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _education == c && _periodS == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].FamilyStatus == b && Polizavis.Alco_Narco_Person[i].Education == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _education == c && _periodPo == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].FamilyStatus == b && Polizavis.Alco_Narco_Person[i].Education == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                //----------------------------------------------------------------------------------------------------------------------------------------
                else if (_costOfKids == b && _familyComposition == c && _periodS == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].CostOfKids == b && Polizavis.Alco_Narco_Person[i].FamilyComposition == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _familyComposition == c && _periodPo == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].CostOfKids == b && Polizavis.Alco_Narco_Person[i].FamilyComposition == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _education == c && _periodS == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].CostOfKids == b && Polizavis.Alco_Narco_Person[i].Education == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _education == c && _periodPo == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].CostOfKids == b && Polizavis.Alco_Narco_Person[i].Education == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }
                //-----------------------------------------------------------------------------------------------------------------------------------------------
                else if (_familyComposition == b && _education == c && _periodS == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].FamilyComposition == b && Polizavis.Alco_Narco_Person[i].Education == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_familyComposition == b && _education == c && _periodPo == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].FamilyComposition == b && Polizavis.Alco_Narco_Person[i].Education == c && data == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }
                //----------------------------------------------------------------------------------------------------------------------------------------------
                else if (_regionCenterBLR == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b && data == c && data1 == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Polizavis.Alco_Narco_Person[i].Sex == b && data == c && data1 == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Polizavis.Alco_Narco_Person[i].FamilyStatus == b && data == c && data1 == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Polizavis.Alco_Narco_Person[i].CostOfKids == b && data == c && data1 == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_familyComposition == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Polizavis.Alco_Narco_Person[i].FamilyComposition == b && data == c && data1 == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_education == b && _periodS == c && _periodPo == d)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Polizavis.Alco_Narco_Person[i].Education == b && data == c && data1 == d)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }
                DataGrid.ItemsSource = poliz;
            }
        }

        /// <summary>
        /// Принемает 5 параметров 
        /// </summary>
        public void DataGridFormat(string a, string b, string c, string d, string e)
        {
            if (a == "Алкогольная")
            {
                Generate_List_Alco();
                if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyStatus == d
                            && Alco.AlcoholismPersona[i].CostOfKids == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _familyComposition == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyStatus == d
                            && Alco.AlcoholismPersona[i].FamilyComposition == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _education == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyStatus == d
                            && Alco.AlcoholismPersona[i].Education == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _familyComposition == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].CostOfKids == d
                            && Alco.AlcoholismPersona[i].FamilyComposition == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _education == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].CostOfKids == d
                            && Alco.AlcoholismPersona[i].Education == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyComposition == d
                            && Alco.AlcoholismPersona[i].Education == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _costOfKids == d && _familyComposition == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].CostOfKids == d
                            && Alco.AlcoholismPersona[i].FamilyComposition == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _costOfKids == d && _education == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].CostOfKids == d
                            && Alco.AlcoholismPersona[i].Education == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].FamilyComposition == d
                            && Alco.AlcoholismPersona[i].Education == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _costOfKids == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].CostOfKids == c
                            && Alco.AlcoholismPersona[i].FamilyComposition == d
                            && Alco.AlcoholismPersona[i].Education == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _familyComposition == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].Sex == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].CostOfKids == d
                            && Alco.AlcoholismPersona[i].FamilyComposition == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _education == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].Sex == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].CostOfKids == d
                            && Alco.AlcoholismPersona[i].Education == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].Sex == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].FamilyComposition == d
                            && Alco.AlcoholismPersona[i].Education == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _costOfKids == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].Sex == b
                            && Alco.AlcoholismPersona[i].CostOfKids == c
                            && Alco.AlcoholismPersona[i].FamilyComposition == d
                            && Alco.AlcoholismPersona[i].Education == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _costOfKids == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].FamilyStatus == b
                            && Alco.AlcoholismPersona[i].CostOfKids == c
                            && Alco.AlcoholismPersona[i].FamilyComposition == d
                            && Alco.AlcoholismPersona[i].Education == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }
                
                //дата -------------------------------------------------------------------------------------------------------------------------------------------
                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _periodS == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyStatus == d
                            && data == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus== d &&_periodPo == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b 
                            && Alco.AlcoholismPersona[i].Sex == c 
                            && Alco.AlcoholismPersona[i].FamilyStatus == d
                            && data == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _periodS == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].CostOfKids == d
                            && data == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _periodPo == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].CostOfKids == d
                            && data == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyComposition == d && _periodS == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyComposition == d
                            && data == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyComposition == d && _periodPo == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyComposition == d
                            && data == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _periodS == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].CostOfKids == d
                            && data == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _periodPo == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].CostOfKids == d
                            && data == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _education == d && _periodS == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].Education == d
                            && data == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                    
                }

                else if (_regionCenterBLR == b && _sex == c && _education == d && _periodPo == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].Education == d
                            && data == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                    
                }

                else if (_regionCenterBLR == b && _sex == c && _periodS == d && _periodPo == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && data == d
                            && data1 == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                    
                }
                //-----------------------------------------------------------------------------------------------
                else if (_sex == b && _familyStatus == c && _costOfKids == d && _periodS == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Sex == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].CostOfKids == d
                            && data == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                    
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _periodPo == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Sex == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].CostOfKids == d
                            && data == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                    
                }

                else if (_sex == b && _familyStatus == c && _familyComposition == d && _periodS == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Sex == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].FamilyComposition == d
                            && data == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                    
                }

                else if (_sex == b && _familyStatus == c && _familyComposition == d && _periodPo == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Sex == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].FamilyComposition == d
                            && data == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                    
                }

                else if (_sex == b && _familyStatus == c && _education == d && _periodS == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Sex == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].Education == d
                            && data == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                    
                }

                else if (_sex == b && _familyStatus == c && _education == d && _periodPo == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Sex == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].Education == d
                            && data == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                    
                }

                else if (_sex == b && _familyStatus == c && _education == d && _periodS == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Alco.AlcoholismPersona[i].Sex == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && data == d
                            && data1 == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                    
                }
                //------------------------------------------------------------------------------------------------------------------------
                else if (_familyStatus == b && _costOfKids == c && _familyComposition == d && _periodS == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].FamilyStatus == b
                            && Alco.AlcoholismPersona[i].CostOfKids == c
                            && Alco.AlcoholismPersona[i].FamilyComposition == d
                            && data == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                    
                }

                else if (_familyStatus == b && _costOfKids == c && _familyComposition == d && _periodPo == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].FamilyStatus == b
                            && Alco.AlcoholismPersona[i].CostOfKids == c
                            && Alco.AlcoholismPersona[i].FamilyComposition == d
                            && data == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                    
                }

                else if (_familyStatus == b && _costOfKids == c && _education == d && _periodS == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].FamilyStatus == b
                            && Alco.AlcoholismPersona[i].CostOfKids == c
                            && Alco.AlcoholismPersona[i].Education == d
                            && data == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                    
                }

                else if (_familyStatus == b && _costOfKids == c && _education == d && _periodPo == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].FamilyStatus == b
                            && Alco.AlcoholismPersona[i].CostOfKids == c
                            && Alco.AlcoholismPersona[i].Education == d
                            && data == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                    
                }

                else if (_familyStatus == b && _costOfKids == c && _periodS == d && _periodPo == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Alco.AlcoholismPersona[i].FamilyStatus == b
                            && Alco.AlcoholismPersona[i].CostOfKids == c
                            && data == d
                            && data1 == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                    
                }
                //-----------------------------------------------------------------------------------------------------
                else if (_costOfKids == b && _familyComposition == c && _education == d && _periodS == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].CostOfKids == b
                            && Alco.AlcoholismPersona[i].FamilyComposition == c
                            && Alco.AlcoholismPersona[i].Education == d
                            && data == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                    
                }

                else if (_costOfKids == b && _familyComposition == c && _education == d && _periodPo == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].CostOfKids == b
                            && Alco.AlcoholismPersona[i].FamilyComposition == c
                            && Alco.AlcoholismPersona[i].Education == d
                            && data == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _familyComposition == c && _periodS == d && _periodPo == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Alco.AlcoholismPersona[i].CostOfKids == b
                            && Alco.AlcoholismPersona[i].FamilyComposition == c
                            && data == d
                            && data1 == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }
                //-----------------------------------------------------------------------------------------------------------------------------------
                else if (_familyComposition == b && _education == c && _periodS == d && _periodPo == e)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Alco.AlcoholismPersona[i].FamilyComposition == b
                            && Alco.AlcoholismPersona[i].Education == c
                            && data == d
                            && data1 == e)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }
                DataGrid.ItemsSource = alco;

            }

            else if (a == "Наркотическая")
            {
                Generate_List_Narco();
                if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyStatus == d
                            && Narcoman.Drug_Addiction[i].CostOfKids == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                   
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _familyComposition == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyStatus == d
                            && Narcoman.Drug_Addiction[i].FamilyComposition == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                   
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _education == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyStatus == d
                            && Narcoman.Drug_Addiction[i].Education == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                   
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _familyComposition == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].CostOfKids == d
                            && Narcoman.Drug_Addiction[i].FamilyComposition == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                   
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _education == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].CostOfKids == d
                            && Narcoman.Drug_Addiction[i].Education == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                   
                }

                else if (_regionCenterBLR == b && _sex == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyComposition == d
                            && Narcoman.Drug_Addiction[i].Education == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                   
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _costOfKids == d && _familyComposition == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].CostOfKids == d
                            && Narcoman.Drug_Addiction[i].FamilyComposition == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                   
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _costOfKids == d && _education == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].CostOfKids == d
                            && Narcoman.Drug_Addiction[i].Education == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                   
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].FamilyComposition == d
                            && Narcoman.Drug_Addiction[i].Education == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                   
                }

                else if (_regionCenterBLR == b && _costOfKids == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].CostOfKids == c
                            && Narcoman.Drug_Addiction[i].FamilyComposition == d
                            && Narcoman.Drug_Addiction[i].Education == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                   
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _familyComposition == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].Sex == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].CostOfKids == d
                            && Narcoman.Drug_Addiction[i].FamilyComposition == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                   
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _education == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].Sex == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].CostOfKids == d
                            && Narcoman.Drug_Addiction[i].Education == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                   
                }

                else if (_sex == b && _familyStatus == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].Sex == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].FamilyComposition == d
                            && Narcoman.Drug_Addiction[i].Education == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                   
                }

                else if (_sex == b && _costOfKids == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].Sex == b
                            && Narcoman.Drug_Addiction[i].CostOfKids == c
                            && Narcoman.Drug_Addiction[i].FamilyComposition == d
                            && Narcoman.Drug_Addiction[i].Education == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                   
                }

                else if (_familyStatus == b && _costOfKids == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].FamilyStatus == b
                            && Narcoman.Drug_Addiction[i].CostOfKids == c
                            && Narcoman.Drug_Addiction[i].FamilyComposition == d
                            && Narcoman.Drug_Addiction[i].Education == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                   
                }

                //дата -------------------------------------------------------------------------------------------------------------------------------------------
                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _periodS == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyStatus == d
                            && data == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                   
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _periodPo == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyStatus == d
                            && data == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                   
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _periodS == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].CostOfKids == d
                            && data == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                   
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _periodPo == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].CostOfKids == d
                            && data == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                   
                }

                else if (_regionCenterBLR == b && _sex == c && _familyComposition == d && _periodS == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyComposition == d
                            && data == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                   
                }

                else if (_regionCenterBLR == b && _sex == c && _familyComposition == d && _periodPo == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyComposition == d
                            && data == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                   
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _periodS == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].CostOfKids == d
                            && data == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                   
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _periodPo == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].CostOfKids == d
                            && data == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                   
                }

                else if (_regionCenterBLR == b && _sex == c && _education == d && _periodS == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].Education == d
                            && data == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                   
                }

                else if (_regionCenterBLR == b && _sex == c && _education == d && _periodPo == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].Education == d
                            && data == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                   
                }

                else if (_regionCenterBLR == b && _sex == c && _periodS == d && _periodPo == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && data == d
                            && data1 == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                   
                }
                //-----------------------------------------------------------------------------------------------
                else if (_sex == b && _familyStatus == c && _costOfKids == d && _periodS == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Sex == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].CostOfKids == d
                            && data == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                   
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _periodPo == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Sex == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].CostOfKids == d
                            && data == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                   
                }

                else if (_sex == b && _familyStatus == c && _familyComposition == d && _periodS == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Sex == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].FamilyComposition == d
                            && data == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                   
                }

                else if (_sex == b && _familyStatus == c && _familyComposition == d && _periodPo == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Sex == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].FamilyComposition == d
                            && data == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                   
                }

                else if (_sex == b && _familyStatus == c && _education == d && _periodS == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Sex == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].Education == d
                            && data == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                   
                }

                else if (_sex == b && _familyStatus == c && _education == d && _periodPo == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Sex == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].Education == d
                            && data == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                   
                }

                else if (_sex == b && _familyStatus == c && _education == d && _periodS == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Narcoman.Drug_Addiction[i].Sex == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && data == d
                            && data1 == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                   
                }
                //------------------------------------------------------------------------------------------------------------------------
                else if (_familyStatus == b && _costOfKids == c && _familyComposition == d && _periodS == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].FamilyStatus == b
                            && Narcoman.Drug_Addiction[i].CostOfKids == c
                            && Narcoman.Drug_Addiction[i].FamilyComposition == d
                            && data == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                   
                }

                else if (_familyStatus == b && _costOfKids == c && _familyComposition == d && _periodPo == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].FamilyStatus == b
                            && Narcoman.Drug_Addiction[i].CostOfKids == c
                            && Narcoman.Drug_Addiction[i].FamilyComposition == d
                            && data == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                   
                }

                else if (_familyStatus == b && _costOfKids == c && _education == d && _periodS == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].FamilyStatus == b
                            && Narcoman.Drug_Addiction[i].CostOfKids == c
                            && Narcoman.Drug_Addiction[i].Education == d
                            && data == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                   
                }

                else if (_familyStatus == b && _costOfKids == c && _education == d && _periodPo == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].FamilyStatus == b
                            && Narcoman.Drug_Addiction[i].CostOfKids == c
                            && Narcoman.Drug_Addiction[i].Education == d
                            && data == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                   
                }

                else if (_familyStatus == b && _costOfKids == c && _periodS == d && _periodPo == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Narcoman.Drug_Addiction[i].FamilyStatus == b
                            && Narcoman.Drug_Addiction[i].CostOfKids == c
                            && data == d
                            && data1 == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                   
                }
                //-----------------------------------------------------------------------------------------------------
                else if (_costOfKids == b && _familyComposition == c && _education == d && _periodS == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].CostOfKids == b
                            && Narcoman.Drug_Addiction[i].FamilyComposition == c
                            && Narcoman.Drug_Addiction[i].Education == d
                            && data == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                   
                }

                else if (_costOfKids == b && _familyComposition == c && _education == d && _periodPo == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].CostOfKids == b
                            && Narcoman.Drug_Addiction[i].FamilyComposition == c
                            && Narcoman.Drug_Addiction[i].Education == d
                            && data == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                   
                }

                else if (_costOfKids == b && _familyComposition == c && _periodS == d && _periodPo == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Narcoman.Drug_Addiction[i].CostOfKids == b
                            && Narcoman.Drug_Addiction[i].FamilyComposition == c
                            && data == d
                            && data1 == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }
                //-----------------------------------------------------------------------------------------------------------------------------------
                else if (_familyComposition == b && _education == c && _periodS == d && _periodPo == e)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Narcoman.Drug_Addiction[i].FamilyComposition == b
                            && Narcoman.Drug_Addiction[i].Education == c
                            && data == d
                            && data1 == e)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                   
                }
                DataGrid.ItemsSource = narco;
            }

            else if (a == "Полизависимость")
            {
                Generate_List_Poliz();
                if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == d
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                    DataGrid.ItemsSource = poliz;
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _familyComposition == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == d
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                 
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _education == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == d
                            && Polizavis.Alco_Narco_Person[i].Education == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                 
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _familyComposition == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == d
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                 
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _education == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == d
                            && Polizavis.Alco_Narco_Person[i].Education == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                 
                }

                else if (_regionCenterBLR == b && _sex == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == d
                            && Polizavis.Alco_Narco_Person[i].Education == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                 
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _costOfKids == d && _familyComposition == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == d
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                 
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _costOfKids == d && _education == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == d
                            && Polizavis.Alco_Narco_Person[i].Education == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                 
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == d
                            && Polizavis.Alco_Narco_Person[i].Education == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                 
                }

                else if (_regionCenterBLR == b && _costOfKids == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == c
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == d
                            && Polizavis.Alco_Narco_Person[i].Education == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                 
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _familyComposition == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].Sex == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == d
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                 
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _education == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].Sex == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == d
                            && Polizavis.Alco_Narco_Person[i].Education == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                 
                }

                else if (_sex == b && _familyStatus == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].Sex == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == d
                            && Polizavis.Alco_Narco_Person[i].Education == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                 
                }

                else if (_sex == b && _costOfKids == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].Sex == b
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == c
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == d
                            && Polizavis.Alco_Narco_Person[i].Education == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                 
                }

                else if (_familyStatus == b && _costOfKids == c && _familyComposition == d && _education == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].FamilyStatus == b
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == c
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == d
                            && Polizavis.Alco_Narco_Person[i].Education == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                 
                }

                //дата -------------------------------------------------------------------------------------------------------------------------------------------
                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _periodS == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == d
                            && data == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                 
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _periodPo == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == d
                            && data == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                 
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _periodS == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == d
                            && data == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                 
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _periodPo == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == d
                            && data == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                 
                }

                else if (_regionCenterBLR == b && _sex == c && _familyComposition == d && _periodS == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == d
                            && data == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                 
                }

                else if (_regionCenterBLR == b && _sex == c && _familyComposition == d && _periodPo == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == d
                            && data == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                 
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _periodS == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == d
                            && data == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                 
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _periodPo == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == d
                            && data == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                 
                }

                else if (_regionCenterBLR == b && _sex == c && _education == d && _periodS == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].Education == d
                            && data == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                 
                }

                else if (_regionCenterBLR == b && _sex == c && _education == d && _periodPo == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].Education == d
                            && data == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                 
                }

                else if (_regionCenterBLR == b && _sex == c && _periodS == d && _periodPo == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && data == d
                            && data1 == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                 
                }
                //-----------------------------------------------------------------------------------------------
                else if (_sex == b && _familyStatus == c && _costOfKids == d && _periodS == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Sex == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == d
                            && data == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                 
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _periodPo == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Sex == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == d
                            && data == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                 
                }

                else if (_sex == b && _familyStatus == c && _familyComposition == d && _periodS == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Sex == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == d
                            && data == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                 
                }

                else if (_sex == b && _familyStatus == c && _familyComposition == d && _periodPo == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Sex == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == d
                            && data == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                 
                }

                else if (_sex == b && _familyStatus == c && _education == d && _periodS == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Sex == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].Education == d
                            && data == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                 
                }

                else if (_sex == b && _familyStatus == c && _education == d && _periodPo == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Sex == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].Education == d
                            && data == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                 
                }

                else if (_sex == b && _familyStatus == c && _education == d && _periodS == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Polizavis.Alco_Narco_Person[i].Sex == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && data == d
                            && data1 == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                 
                }
                //------------------------------------------------------------------------------------------------------------------------
                else if (_familyStatus == b && _costOfKids == c && _familyComposition == d && _periodS == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].FamilyStatus == b
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == c
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == d
                            && data == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                 
                }

                else if (_familyStatus == b && _costOfKids == c && _familyComposition == d && _periodPo == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].FamilyStatus == b
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == c
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == d
                            && data == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                 
                }

                else if (_familyStatus == b && _costOfKids == c && _education == d && _periodS == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].FamilyStatus == b
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == c
                            && Polizavis.Alco_Narco_Person[i].Education == d
                            && data == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                 
                }

                else if (_familyStatus == b && _costOfKids == c && _education == d && _periodPo == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].FamilyStatus == b
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == c
                            && Polizavis.Alco_Narco_Person[i].Education == d
                            && data == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                 
                }

                else if (_familyStatus == b && _costOfKids == c && _periodS == d && _periodPo == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Polizavis.Alco_Narco_Person[i].FamilyStatus == b
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == c
                            && data == d
                            && data1 == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                 
                }
                //-----------------------------------------------------------------------------------------------------
                else if (_costOfKids == b && _familyComposition == c && _education == d && _periodS == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].CostOfKids == b
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == c
                            && Polizavis.Alco_Narco_Person[i].Education == d
                            && data == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                 
                }

                else if (_costOfKids == b && _familyComposition == c && _education == d && _periodPo == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].CostOfKids == b
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == c
                            && Polizavis.Alco_Narco_Person[i].Education == d
                            && data == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                 
                }

                else if (_costOfKids == b && _familyComposition == c && _periodS == d && _periodPo == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Polizavis.Alco_Narco_Person[i].CostOfKids == b
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == c
                            && data == d
                            && data1 == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }
                //-----------------------------------------------------------------------------------------------------------------------------------
                else if (_familyComposition == b && _education == c && _periodS == d && _periodPo == e)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Polizavis.Alco_Narco_Person[i].FamilyComposition == b
                            && Polizavis.Alco_Narco_Person[i].Education == c
                            && data == d
                            && data1 == e)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }
                DataGrid.ItemsSource = poliz;
            }
           

        }
       
        /// <summary>
        /// Принемает 6 параметров
        /// </summary>
        public void DataGridFormat(string a, string b, string c, string d, string e, string f)
        {
            if (a == "Алкогольная")
            {
                Generate_List_Alco();
                if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyStatus == d
                            && Alco.AlcoholismPersona[i].CostOfKids == e
                            && Alco.AlcoholismPersona[i].FamilyComposition == f)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _education == f)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyStatus == d
                            && Alco.AlcoholismPersona[i].CostOfKids == e
                            && Alco.AlcoholismPersona[i].Education == f)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _costOfKids == d && _familyComposition == e && _education == f)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].CostOfKids == d
                            && Alco.AlcoholismPersona[i].FamilyComposition == e
                            && Alco.AlcoholismPersona[i].Education == f)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                    
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _familyComposition == e && _education == f)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].CostOfKids == d
                            && Alco.AlcoholismPersona[i].FamilyComposition == e
                            && Alco.AlcoholismPersona[i].Education == f)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _familyComposition == e && _education == f)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyStatus == d
                            && Alco.AlcoholismPersona[i].FamilyComposition == e
                            && Alco.AlcoholismPersona[i].Education == f)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _familyComposition == e && _education == f)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].Sex == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].CostOfKids == d
                            && Alco.AlcoholismPersona[i].FamilyComposition == e
                            && Alco.AlcoholismPersona[i].Education == f)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }
                //дата ------------------------------------------------------------------------------------------------------------------------
                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _periodS == f)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyStatus == d
                            && Alco.AlcoholismPersona[i].CostOfKids == e
                            && data == f)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _periodPo == f)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyStatus == d
                            && Alco.AlcoholismPersona[i].CostOfKids == e
                            && data == f)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _familyComposition == e && _periodS == f)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyStatus == d
                            && Alco.AlcoholismPersona[i].FamilyComposition == e
                            && data == f)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _familyComposition == e && _periodPo == f)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyStatus == d
                            && Alco.AlcoholismPersona[i].FamilyComposition == e
                            && data == f)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _education == e && _periodS == f)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyStatus == d
                            && Alco.AlcoholismPersona[i].Education == e
                            && data == f)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _education == e && _periodPo == f)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyStatus == d
                            && Alco.AlcoholismPersona[i].Education == e
                            && data == f)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _periodS == e && _periodPo == f)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {

                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyStatus == d
                            && data == e
                            && data1 == f)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }
                //-------------------------------------------------------------------------------------------------------------------------------
                else if (_sex == b && _familyStatus == c && _costOfKids == d && _familyComposition == e && _periodS == f)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Sex == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].CostOfKids == d
                            && Alco.AlcoholismPersona[i].FamilyComposition == e
                            && data == f)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _familyComposition == e && _periodPo == f)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Sex == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].CostOfKids == d
                            && Alco.AlcoholismPersona[i].FamilyComposition == e
                            && data == f)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _education == e && _periodS == f)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Sex == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].CostOfKids == d
                            && Alco.AlcoholismPersona[i].Education == e
                            && data == f)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _education == e && _periodPo == f)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].Sex == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].CostOfKids == d
                            && Alco.AlcoholismPersona[i].Education == e
                            && data == f)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _periodS == e && _periodPo == f)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Alco.AlcoholismPersona[i].Sex == b
                            && Alco.AlcoholismPersona[i].FamilyStatus == c
                            && Alco.AlcoholismPersona[i].CostOfKids == d
                            && data == e
                            && data1 == f)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_familyStatus == b && _costOfKids == c && _familyComposition == d && _education == e && _periodS == f)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].FamilyStatus == b
                            && Alco.AlcoholismPersona[i].CostOfKids == c
                            && Alco.AlcoholismPersona[i].FamilyComposition == d
                            && Alco.AlcoholismPersona[i].Education == e
                            && data == f)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_costOfKids == b && _familyComposition == c && _education == d && _periodS == e && _periodPo == f)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Alco.AlcoholismPersona[i].CostOfKids == b
                            && Alco.AlcoholismPersona[i].FamilyComposition == c
                            && Alco.AlcoholismPersona[i].Education == d
                            && data == e
                            && data1 == f)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                DataGrid.ItemsSource = alco;
            }

            else if (a == "Наркотическая")
            {
                Generate_List_Narco();
                if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyStatus == d
                            && Narcoman.Drug_Addiction[i].CostOfKids == e
                            && Narcoman.Drug_Addiction[i].FamilyComposition == f)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _education == f)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyStatus == d
                            && Narcoman.Drug_Addiction[i].CostOfKids == e
                            && Narcoman.Drug_Addiction[i].Education == f)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _costOfKids == d && _familyComposition == e && _education == f)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].CostOfKids == d
                            && Narcoman.Drug_Addiction[i].FamilyComposition == e
                            && Narcoman.Drug_Addiction[i].Education == f)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _familyComposition == e && _education == f)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].CostOfKids == d
                            && Narcoman.Drug_Addiction[i].FamilyComposition == e
                            && Narcoman.Drug_Addiction[i].Education == f)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _familyComposition == e && _education == f)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyStatus == d
                            && Narcoman.Drug_Addiction[i].FamilyComposition == e
                            && Narcoman.Drug_Addiction[i].Education == f)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _familyComposition == e && _education == f)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].Sex == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].CostOfKids == d
                            && Narcoman.Drug_Addiction[i].FamilyComposition == e
                            && Narcoman.Drug_Addiction[i].Education == f)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }
                //дата ---------------------------------------------------------------------------------------------------------------------------
                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _periodS == f)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyStatus == d
                            && Narcoman.Drug_Addiction[i].CostOfKids == e
                            && data == f)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _periodPo == f)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyStatus == d
                            && Narcoman.Drug_Addiction[i].CostOfKids == e
                            && data == f)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _familyComposition == e && _periodS == f)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyStatus == d
                            && Narcoman.Drug_Addiction[i].FamilyComposition == e
                            && data == f)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _familyComposition == e && _periodPo == f)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyStatus == d
                            && Narcoman.Drug_Addiction[i].FamilyComposition == e
                            && data == f)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _education == e && _periodS == f)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyStatus == d
                            && Narcoman.Drug_Addiction[i].Education == e
                            && data == f)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _education == e && _periodPo == f)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyStatus == d
                            && Narcoman.Drug_Addiction[i].Education == e
                            && data == f)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _periodS == e && _periodPo == f)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {

                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyStatus == d
                            && data == e
                            && data1 == f)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }
                //-------------------------------------------------------------------------------------------------------------------------------
                else if (_sex == b && _familyStatus == c && _costOfKids == d && _familyComposition == e && _periodS == f)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Sex == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].CostOfKids == d
                            && Narcoman.Drug_Addiction[i].FamilyComposition == e
                            && data == f)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _familyComposition == e && _periodPo == f)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Sex == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].CostOfKids == d
                            && Narcoman.Drug_Addiction[i].FamilyComposition == e
                            && data == f)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _education == e && _periodS == f)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Sex == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].CostOfKids == d
                            && Narcoman.Drug_Addiction[i].Education == e
                            && data == f)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _education == e && _periodPo == f)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].Sex == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].CostOfKids == d
                            && Narcoman.Drug_Addiction[i].Education == e
                            && data == f)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _periodS == e && _periodPo == f)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Narcoman.Drug_Addiction[i].Sex == b
                            && Narcoman.Drug_Addiction[i].FamilyStatus == c
                            && Narcoman.Drug_Addiction[i].CostOfKids == d
                            && data == e
                            && data1 == f)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }
                //-------------------------------------------------------------------------------------------------------------------------------
                else if (_familyStatus == b && _costOfKids == c && _familyComposition == d && _education == e && _periodS == f)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].FamilyStatus == b
                            && Narcoman.Drug_Addiction[i].CostOfKids == c
                            && Narcoman.Drug_Addiction[i].FamilyComposition == d
                            && Narcoman.Drug_Addiction[i].Education == e
                            && data == f)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }
                //------------------------------------------------------------------------------------------------------------------------------
                else if (_costOfKids == b && _familyComposition == c && _education == d && _periodS == e && _periodPo == f)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Narcoman.Drug_Addiction[i].CostOfKids == b
                            && Narcoman.Drug_Addiction[i].FamilyComposition == c
                            && Narcoman.Drug_Addiction[i].Education == d
                            && data == e
                            && data1 == f)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                DataGrid.ItemsSource = narco;
            }

            else if (a == "Полизависимость")
            {
                Generate_List_Poliz();
                if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == d
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == e
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == f)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _education == f)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == d
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == e
                            && Polizavis.Alco_Narco_Person[i].Education == f)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _familyStatus == c && _costOfKids == d && _familyComposition == e && _education == f)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == d
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == e
                            && Polizavis.Alco_Narco_Person[i].Education == f)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _costOfKids == d && _familyComposition == e && _education == f)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == d
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == e
                            && Polizavis.Alco_Narco_Person[i].Education == f)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _familyComposition == e && _education == f)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == d
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == e
                            && Polizavis.Alco_Narco_Person[i].Education == f)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _familyComposition == e && _education == f)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].Sex == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == d
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == e
                            && Polizavis.Alco_Narco_Person[i].Education == f)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }
                //Дата-------------------------------------------------------------------------------------------------------------------------------
                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _periodS == f)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == d
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == e
                            && data == f)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _periodPo == f)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == d
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == e
                            && data == f)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _familyComposition == e && _periodS == f)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == d
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == e
                            && data == f)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _familyComposition == e && _periodPo == f)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == d
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == e
                            && data == f)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _education == e && _periodS == f)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == d
                            && Polizavis.Alco_Narco_Person[i].Education == e
                            && data == f)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _education == e && _periodPo == f)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == d
                            && Polizavis.Alco_Narco_Person[i].Education == e
                            && data == f)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _periodS == e && _periodPo == f)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {

                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == d
                            && data == e
                            && data1 == f)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }
                //-------------------------------------------------------------------------------------------------------------------------------
                else if (_sex == b && _familyStatus == c && _costOfKids == d && _familyComposition == e && _periodS == f)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Sex == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == d
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == e
                            && data == f)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _familyComposition == e && _periodPo == f)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Sex == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == d
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == e
                            && data == f)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _education == e && _periodS == f)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Sex == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == d
                            && Polizavis.Alco_Narco_Person[i].Education == e
                            && data == f)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _education == e && _periodPo == f)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].Sex == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == d
                            && Polizavis.Alco_Narco_Person[i].Education == e
                            && data == f)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_sex == b && _familyStatus == c && _costOfKids == d && _periodS == e && _periodPo == f)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Polizavis.Alco_Narco_Person[i].Sex == b
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == c
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == d
                            && data == e
                            && data1 == f)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }
                //-------------------------------------------------------------------------------------------------------------------------------
                else if (_familyStatus == b && _costOfKids == c && _familyComposition == d && _education == e && _periodS == f)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].FamilyStatus == b
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == c
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == d
                            && Polizavis.Alco_Narco_Person[i].Education == e
                            && data == f)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }
                //------------------------------------------------------------------------------------------------------------------------------
                else if (_costOfKids == b && _familyComposition == c && _education == d && _periodS == e && _periodPo == f)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Polizavis.Alco_Narco_Person[i].CostOfKids == b
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == c
                            && Polizavis.Alco_Narco_Person[i].Education == d
                            && data == e
                            && data1 == f)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                DataGrid.ItemsSource = poliz;

            }
        }

        /// <summary>
        /// принемает 7 параметров 
        /// </summary>
        public void DataGridFormat(string a, string b, string c, string d, string e, string f, string g)
        {
            if (a == "Алкогольная")
            {
                Generate_List_Alco();
                if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f && _education == g)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyStatus == d
                            && Alco.AlcoholismPersona[i].CostOfKids == e
                            && Alco.AlcoholismPersona[i].FamilyComposition == f
                            && Alco.AlcoholismPersona[i].Education == g)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f && _periodS == g)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyStatus == d
                            && Alco.AlcoholismPersona[i].CostOfKids == e
                            && Alco.AlcoholismPersona[i].FamilyComposition == f
                            && data == g)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f && _periodPo == g)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyStatus == d
                            && Alco.AlcoholismPersona[i].CostOfKids == e
                            && Alco.AlcoholismPersona[i].FamilyComposition == f
                            && data == g)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                DataGrid.ItemsSource = alco;
            }

            else if (a == "Наркотическая")
            {
                Generate_List_Narco();
                if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f && _education == g)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyStatus == d
                            && Narcoman.Drug_Addiction[i].CostOfKids == e
                            && Narcoman.Drug_Addiction[i].FamilyComposition == f
                            && Narcoman.Drug_Addiction[i].Education == g)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f && _periodS == g)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyStatus == d
                            && Narcoman.Drug_Addiction[i].CostOfKids == e
                            && Narcoman.Drug_Addiction[i].FamilyComposition == f
                            && data == g)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f && _periodPo == g)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyStatus == d
                            && Narcoman.Drug_Addiction[i].CostOfKids == e
                            && Narcoman.Drug_Addiction[i].FamilyComposition == f
                            && data == g)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                DataGrid.ItemsSource = narco;
            }

            else if (a == "Полизависимость")
            {
                Generate_List_Poliz();
                if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f && _education == g)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == d
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == e
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == f
                            && Polizavis.Alco_Narco_Person[i].Education == g)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f && _periodS == g)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == d
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == e
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == f
                            && data == g)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f && _periodPo == g)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == d
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == e
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == f
                            && data == g)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                DataGrid.ItemsSource = poliz;
            }
        }

        /// <summary>
        /// Принемает 8 параметров 
        /// </summary>
        public void DataGridFormat(string a, string b, string c, string d, string e, string f, string g, string h)
        {
            if (a == "Алкогольная")
            {
                Generate_List_Alco();
                if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f && _education == g && _periodS == h)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyStatus == d
                            && Alco.AlcoholismPersona[i].CostOfKids == e
                            && Alco.AlcoholismPersona[i].FamilyComposition == f
                            && Alco.AlcoholismPersona[i].Education == g
                            && data == h)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f && _education == g && _periodPo == h)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyStatus == d
                            && Alco.AlcoholismPersona[i].CostOfKids == e
                            && Alco.AlcoholismPersona[i].FamilyComposition == f
                            && Alco.AlcoholismPersona[i].Education == g
                            && data == h)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                DataGrid.ItemsSource = alco;
            }

            else if (a == "Наркотическая")
            {
                Generate_List_Narco();
                if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f && _education == g && _periodS == h)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyStatus == d
                            && Narcoman.Drug_Addiction[i].CostOfKids == e
                            && Narcoman.Drug_Addiction[i].FamilyComposition == f
                            && Narcoman.Drug_Addiction[i].Education == g
                            && data == h)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f && _education == g && _periodPo == h)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyStatus == d
                            && Narcoman.Drug_Addiction[i].CostOfKids == e
                            && Narcoman.Drug_Addiction[i].FamilyComposition == f
                            && Narcoman.Drug_Addiction[i].Education == g
                            && data == h)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                DataGrid.ItemsSource = narco;
            }

            else if (a == "Полизависимость")
            {
                Generate_List_Poliz();
                if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f && _education == g && _periodS == h)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DataOfRegistration.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == d
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == e
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == f
                            && Polizavis.Alco_Narco_Person[i].Education == g
                            && data == h)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                else if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f && _education == g && _periodPo == h)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == d
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == e
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == f
                            && Polizavis.Alco_Narco_Person[i].Education == g
                            && data == h)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                DataGrid.ItemsSource = poliz;
            }
        }

        /// <summary>
        /// Принемает 9 параметров 
        /// </summary>
        public void DataGridFormat(string a, string b, string c, string d, string e, string f, string g, string h, string k)
        {
            if (a == "Алкогольная")
            {
                Generate_List_Alco();
                if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f && _education == g && _periodS == h && _periodPo == k)
                {
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        string[] mas = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Alco.AlcoholismPersona[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Alco.AlcoholismPersona[i].RegionCenterBLR == b
                            && Alco.AlcoholismPersona[i].Sex == c
                            && Alco.AlcoholismPersona[i].FamilyStatus == d
                            && Alco.AlcoholismPersona[i].CostOfKids == e
                            && Alco.AlcoholismPersona[i].FamilyComposition == f
                            && Alco.AlcoholismPersona[i].Education == g
                            && data == h
                            && data1 == k)
                        {
                            alco.Add(Alco.AlcoholismPersona[i]);
                        }
                    }
                }

                DataGrid.ItemsSource = alco;
            }

            else if (a == "Наркотическая")
            {
                Generate_List_Narco();
                if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f && _education == g && _periodS == h && _periodPo == k)
                {
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        string[] mas = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Narcoman.Drug_Addiction[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Narcoman.Drug_Addiction[i].RegionCenterBLR == b
                            && Narcoman.Drug_Addiction[i].Sex == c
                            && Narcoman.Drug_Addiction[i].FamilyStatus == d
                            && Narcoman.Drug_Addiction[i].CostOfKids == e
                            && Narcoman.Drug_Addiction[i].FamilyComposition == f
                            && Narcoman.Drug_Addiction[i].Education == g
                            && data == h
                            && data1 == k)
                        {
                            narco.Add(Narcoman.Drug_Addiction[i]);
                        }
                    }
                }

                DataGrid.ItemsSource = narco;
            }

            else if (a == "Полизависимость")
            {
                Generate_List_Poliz();
                if (_regionCenterBLR == b && _sex == c && _familyStatus == d && _costOfKids == e && _familyComposition == f && _education == g && _periodS == h && _periodPo == k)
                {
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        string[] mas = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data = mas[2];
                        string[] mas1 = Polizavis.Alco_Narco_Person[i].DateOfDead.Split('.', ',', '/');
                        string data1 = mas1[2];
                        if (Polizavis.Alco_Narco_Person[i].RegionCenterBLR == b
                            && Polizavis.Alco_Narco_Person[i].Sex == c
                            && Polizavis.Alco_Narco_Person[i].FamilyStatus == d
                            && Polizavis.Alco_Narco_Person[i].CostOfKids == e
                            && Polizavis.Alco_Narco_Person[i].FamilyComposition == f
                            && Polizavis.Alco_Narco_Person[i].Education == g
                            && data == h
                            && data1 == k)
                        {
                            poliz.Add(Polizavis.Alco_Narco_Person[i]);
                        }
                    }
                }

                DataGrid.ItemsSource = poliz;
            }
        }

    }
}
