using System;
using static HelaMedical.Class.Alco;
using static HelaMedical.Class.Narcoman;
using static HelaMedical.Class.Polizavis;
using HelaMedical.Class;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using System.Windows;
using HelaMedical.Excep;
using System.Data.Entity;
using System.Windows.Controls;

namespace HelaMedical
{
    public class ExcelDataServis
    {
        private static List<Alco> alcos;
        private static List<Narcoman> narcos;
        private static List<Polizavis> polizs;
        //Считаем алкашей
        private static int alco_col = 0;
        //Считаем наркотов 
        private static int narco_col = 0;
        //Считаем полизавис
        private static int poliz_col = 0;

        /// <summary>
        /// Добавляем в массив данных по алкоголикам 
        /// </summary>
        public static void Patient_Сreation_Alco(string fio, string sex, string data, string regionCenterBLR, string raenCenterBLR, string life, string age, string familyStatus,
            string costOfKids, string familyComposition, string education, string profession, string theSkillLevelOfTheProfession, string addressOfRegistration,
            string addressAtTheTimeOfDeath, string dataOfRegistration, string reRegistrationData, string typeOfRegistration, string heredity, string disabilityGroup,
            string disabilityStatus, string reasonForDisability, string socialStatus, string admOtv, string ugOtv, string dlitMLS, string stat0a107, string statUKRB,
            string rodPrav, string nomLTP, string LTPkol, string hosp, string EK, string dateOfDeregistration, string dateOfDead, string placeOfDead,
            string deathCertificate, string causeOfDeat, string deathCategory, string openingPlace, string historyOfParasucicides, string featuresOfObservation,
            string DrugDiagnosisAlc, string experienceAbuse, string AlcoholicDrinks, string IComorbidity, string ageOfDead, string dataInfo, string ageOfRegistration)
        {
            Reader_Excel_Alco();
            Alco newAlcoPerson = new Alco();
            if (alco_col == 1)
            {
                int a = 1;
                newAlcoPerson.Id = Convert.ToString(a);
            }
            else
            {
                newAlcoPerson.Id = Convert.ToString(alco_col-1);

            }
            newAlcoPerson.FIO = fio;
            newAlcoPerson.Sex = sex;
            newAlcoPerson.Date = data;
            newAlcoPerson.RegionCenterBLR = regionCenterBLR;
            newAlcoPerson.RaenCenterBLR = raenCenterBLR;
            newAlcoPerson.Life = life;
            newAlcoPerson.Age = age;
            newAlcoPerson.FamilyStatus = familyStatus;
            newAlcoPerson.CostOfKids = costOfKids;
            newAlcoPerson.FamilyComposition = familyComposition;
            newAlcoPerson.Education = education;
            newAlcoPerson.Profession = profession;
            newAlcoPerson.TheSkillLevelOfTheProfession = theSkillLevelOfTheProfession;
            newAlcoPerson.AddressOfRegistration = addressOfRegistration;
            newAlcoPerson.AddressAtTheTimeOfDeath = addressAtTheTimeOfDeath;
            newAlcoPerson.DataOfRegistration = dataOfRegistration;
            newAlcoPerson.ReRegistrationData = reRegistrationData;
            newAlcoPerson.TypeOfRegistration = typeOfRegistration;
            newAlcoPerson.Heredity = heredity;
            newAlcoPerson.DisabilityGroup = disabilityGroup;
            newAlcoPerson.DisabilityStatus = disabilityStatus;
            newAlcoPerson.ReasonForDisability = reasonForDisability;
            newAlcoPerson.WorksStatus = socialStatus;
            newAlcoPerson.AdmOtv = Convert.ToString(admOtv);
            newAlcoPerson.UgOtv = Convert.ToString(ugOtv);
            newAlcoPerson.DlitsMLS = Convert.ToString(dlitMLS);
            newAlcoPerson.Stat107 = stat0a107;
            newAlcoPerson.StatUKRB = statUKRB;
            newAlcoPerson.RodPrav = rodPrav;
            newAlcoPerson.NomLTP = nomLTP;
            newAlcoPerson.LTPKol = LTPkol;
            newAlcoPerson.Hospitel = hosp;
            newAlcoPerson.EK = EK;
            newAlcoPerson.DateOfDeregistration = dateOfDeregistration;
            newAlcoPerson.DateOfDead = dateOfDead;
            newAlcoPerson.PlaceOfDead = placeOfDead;
            newAlcoPerson.DeathCertificate = deathCertificate;
            newAlcoPerson.CauseOfDead = causeOfDeat;
            newAlcoPerson.DeathCategory = deathCategory;
            newAlcoPerson.OpeningPlace = openingPlace;
            newAlcoPerson.HistoryOfParasucicides = historyOfParasucicides;
            newAlcoPerson.FeaturesOfObservation = featuresOfObservation;
            newAlcoPerson.ExperienceAbuse = experienceAbuse;
            newAlcoPerson.AlcoholicDrinks = AlcoholicDrinks;
            newAlcoPerson.IK = IComorbidity;
            newAlcoPerson.DrugDiagnosisAlc = DrugDiagnosisAlc;
            newAlcoPerson.AgeOfRegistration = ageOfRegistration;
            newAlcoPerson.AgeOfDead = ageOfDead;
            newAlcoPerson.DataInfo = dataInfo;
            newAlcoPerson.Registrotor = Other.Regis.ToString();

            AlcoholismPersona.Add(newAlcoPerson);

            Save_Excel_Alco();
        }

       
        /// <summary>
        /// Сохранение Колекции в Excel алкоголь
        /// </summary>
        public static void Save_Excel_Alco()
        {
            try
            {
                string ExcelFilePath = @"d:\HelaMedical\HelaMedical\File\AlcoDataBase.xlsx";

                Excel.Application excelApp = new Excel.Application();
                Workbook workBook;
                Worksheet workSheet;
                workBook = excelApp.Workbooks.Open(ExcelFilePath);
                workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);

                // Получаем активную таблицу
                for (int i = 0; i < alco_col + 1; i++)
                {
                    if (i == alco_col)
                    {
                        workSheet.Cells[i, 1] = AlcoholismPersona[0].Id;
                        workSheet.Cells[i, 2] = AlcoholismPersona[0].FIO;
                        workSheet.Cells[i, 3] = AlcoholismPersona[0].Sex;
                        workSheet.Cells[i, 4] = AlcoholismPersona[0].Date;
                        workSheet.Cells[i, 5] = AlcoholismPersona[0].RegionCenterBLR;
                        workSheet.Cells[i, 6] = AlcoholismPersona[0].RaenCenterBLR;
                        workSheet.Cells[i, 7] = AlcoholismPersona[0].Life;
                        workSheet.Cells[i, 8] = AlcoholismPersona[0].Age;
                        workSheet.Cells[i, 9] = AlcoholismPersona[0].FamilyStatus;
                        workSheet.Cells[i, 10] = AlcoholismPersona[0].CostOfKids;
                        workSheet.Cells[i, 11] = AlcoholismPersona[0].FamilyComposition;
                        workSheet.Cells[i, 12] = AlcoholismPersona[0].Education;
                        workSheet.Cells[i, 13] = AlcoholismPersona[0].Profession;
                        workSheet.Cells[i, 14] = AlcoholismPersona[0].TheSkillLevelOfTheProfession;
                        workSheet.Cells[i, 15] = AlcoholismPersona[0].AddressOfRegistration;
                        workSheet.Cells[i, 16] = AlcoholismPersona[0].AddressAtTheTimeOfDeath;
                        workSheet.Cells[i, 17] = AlcoholismPersona[0].DataOfRegistration;
                        workSheet.Cells[i, 18] = AlcoholismPersona[0].ReRegistrationData;
                        workSheet.Cells[i, 19] = AlcoholismPersona[0].TypeOfRegistration;
                        workSheet.Cells[i, 20] = AlcoholismPersona[0].Heredity;
                        workSheet.Cells[i, 21] = AlcoholismPersona[0].DisabilityGroup;
                        workSheet.Cells[i, 22] = AlcoholismPersona[0].DisabilityStatus;
                        workSheet.Cells[i, 23] = AlcoholismPersona[0].ReasonForDisability;
                        workSheet.Cells[i, 24] = AlcoholismPersona[0].WorksStatus;
                        workSheet.Cells[i, 25] = AlcoholismPersona[0].AdmOtv;
                        workSheet.Cells[i, 26] = AlcoholismPersona[0].UgOtv;
                        workSheet.Cells[i, 27] = AlcoholismPersona[0].DlitsMLS;
                        workSheet.Cells[i, 28] = AlcoholismPersona[0].Stat107;
                        workSheet.Cells[i, 29] = AlcoholismPersona[0].StatUKRB;
                        workSheet.Cells[i, 30] = AlcoholismPersona[0].RodPrav;
                        workSheet.Cells[i, 31] = AlcoholismPersona[0].NomLTP;
                        workSheet.Cells[i, 32] = AlcoholismPersona[0].LTPKol;
                        workSheet.Cells[i, 33] = AlcoholismPersona[0].Hospitel;
                        workSheet.Cells[i, 34] = AlcoholismPersona[0].EK;
                        workSheet.Cells[i, 35] = AlcoholismPersona[0].DateOfDeregistration;
                        workSheet.Cells[i, 36] = AlcoholismPersona[0].DateOfDead;
                        workSheet.Cells[i, 37] = AlcoholismPersona[0].PlaceOfDead;
                        workSheet.Cells[i, 38] = AlcoholismPersona[0].DeathCertificate;
                        workSheet.Cells[i, 39] = AlcoholismPersona[0].CauseOfDead;
                        workSheet.Cells[i, 40] = AlcoholismPersona[0].DeathCategory;
                        workSheet.Cells[i, 41] = AlcoholismPersona[0].OpeningPlace;
                        workSheet.Cells[i, 42] = AlcoholismPersona[0].HistoryOfParasucicides;
                        workSheet.Cells[i, 43] = AlcoholismPersona[0].FeaturesOfObservation;
                        workSheet.Cells[i, 44] = AlcoholismPersona[0].ExperienceAbuse;
                        workSheet.Cells[i, 45] = AlcoholismPersona[0].AlcoholicDrinks;
                        workSheet.Cells[i, 46] = AlcoholismPersona[0].IK;
                        workSheet.Cells[i, 47] = AlcoholismPersona[0].DrugDiagnosisAlc;
                        workSheet.Cells[i, 48] = AlcoholismPersona[0].AgeOfRegistration;
                        workSheet.Cells[i, 49] = AlcoholismPersona[0].AgeOfDead;
                        workSheet.Cells[i, 50] = AlcoholismPersona[0].DataInfo;
                        workSheet.Cells[i, 51] = AlcoholismPersona[0].Registrotor;

                        
                    }
                }
                workBook.Save();
                workBook.Close();
                excelApp.Quit();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
                Excel.Application excelApp = new Excel.Application();
                excelApp.Quit();
            }
        }

        /// <summary>
        /// Сохранение из datagrid в Excel алкоголики
        /// </summary>
        /// <param name="alco"></param>
        public static void Save_Report_Excel_Alco()
        {
            try
            {
                int count = 0;
                for (int i = 0; i < alco_col; i++)
                    count++;
                if (count > 0)
                {
                    string ExcelFilePath = @"D:\HelaMedical\HelaMedical\File\AlcoReport.xlsx";

                    Excel.Application excelApp = new Excel.Application();
                    Workbook workBook;
                    Worksheet workSheet;
                    workBook = excelApp.Workbooks.Open(ExcelFilePath);
                    workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);

                    // Получаем активную таблицу
                    for (int i = 1; i <= AlcoholismPersona.Count; i++)
                    {
                        int j = i - 1;
                        workSheet.Cells[i, 1] = AlcoholismPersona[j].Id;
                        workSheet.Cells[i, 2] = AlcoholismPersona[j].FIO;
                        workSheet.Cells[i, 3] = AlcoholismPersona[j].Sex;
                        workSheet.Cells[i, 4] = AlcoholismPersona[j].Date;
                        workSheet.Cells[i, 5] = AlcoholismPersona[j].RegionCenterBLR;
                        workSheet.Cells[i, 6] = AlcoholismPersona[j].RaenCenterBLR;
                        workSheet.Cells[i, 7] = AlcoholismPersona[j].Life;
                        workSheet.Cells[i, 8] = AlcoholismPersona[j].Age;
                        workSheet.Cells[i, 9] = AlcoholismPersona[j].FamilyStatus;
                        workSheet.Cells[i, 10] = AlcoholismPersona[j].CostOfKids;
                        workSheet.Cells[i, 11] = AlcoholismPersona[j].FamilyComposition;
                        workSheet.Cells[i, 12] = AlcoholismPersona[j].Education;
                        workSheet.Cells[i, 13] = AlcoholismPersona[j].Profession;
                        workSheet.Cells[i, 14] = AlcoholismPersona[j].TheSkillLevelOfTheProfession;
                        workSheet.Cells[i, 15] = AlcoholismPersona[j].AddressOfRegistration;
                        workSheet.Cells[i, 16] = AlcoholismPersona[j].AddressAtTheTimeOfDeath;
                        workSheet.Cells[i, 17] = AlcoholismPersona[j].DataOfRegistration;
                        workSheet.Cells[i, 18] = AlcoholismPersona[j].ReRegistrationData;
                        workSheet.Cells[i, 19] = AlcoholismPersona[j].TypeOfRegistration;
                        workSheet.Cells[i, 20] = AlcoholismPersona[j].Heredity;
                        workSheet.Cells[i, 21] = AlcoholismPersona[j].DisabilityGroup;
                        workSheet.Cells[i, 22] = AlcoholismPersona[j].DisabilityStatus;
                        workSheet.Cells[i, 23] = AlcoholismPersona[j].ReasonForDisability;
                        workSheet.Cells[i, 24] = AlcoholismPersona[j].WorksStatus;
                        workSheet.Cells[i, 25] = AlcoholismPersona[j].AdmOtv;
                        workSheet.Cells[i, 26] = AlcoholismPersona[j].UgOtv;
                        workSheet.Cells[i, 27] = AlcoholismPersona[j].DlitsMLS;
                        workSheet.Cells[i, 28] = AlcoholismPersona[j].Stat107;
                        workSheet.Cells[i, 29] = AlcoholismPersona[j].StatUKRB;
                        workSheet.Cells[i, 30] = AlcoholismPersona[j].RodPrav;
                        workSheet.Cells[i, 31] = AlcoholismPersona[j].NomLTP;
                        workSheet.Cells[i, 32] = AlcoholismPersona[j].LTPKol;
                        workSheet.Cells[i, 33] = AlcoholismPersona[j].Hospitel;
                        workSheet.Cells[i, 34] = AlcoholismPersona[j].EK;
                        workSheet.Cells[i, 35] = AlcoholismPersona[j].DateOfDeregistration;
                        workSheet.Cells[i, 36] = AlcoholismPersona[j].DateOfDead;
                        workSheet.Cells[i, 37] = AlcoholismPersona[j].PlaceOfDead;
                        workSheet.Cells[i, 38] = AlcoholismPersona[j].DeathCertificate;
                        workSheet.Cells[i, 39] = AlcoholismPersona[j].CauseOfDead;
                        workSheet.Cells[i, 40] = AlcoholismPersona[j].DeathCategory;
                        workSheet.Cells[i, 41] = AlcoholismPersona[j].OpeningPlace;
                        workSheet.Cells[i, 42] = AlcoholismPersona[j].HistoryOfParasucicides;
                        workSheet.Cells[i, 43] = AlcoholismPersona[j].FeaturesOfObservation;
                        workSheet.Cells[i, 44] = AlcoholismPersona[j].ExperienceAbuse;
                        workSheet.Cells[i, 45] = AlcoholismPersona[j].AlcoholicDrinks;
                        workSheet.Cells[i, 46] = AlcoholismPersona[j].IK;
                        workSheet.Cells[i, 47] = AlcoholismPersona[j].DrugDiagnosisAlc;
                        workSheet.Cells[i, 48] = AlcoholismPersona[j].AgeOfRegistration;
                        workSheet.Cells[i, 49] = AlcoholismPersona[j].AgeOfDead;
                        workSheet.Cells[i, 50] = AlcoholismPersona[j].DataInfo;
                        workSheet.Cells[i, 51] = AlcoholismPersona[j].Registrotor;
                    }
                    workBook.Save();
                    workBook.Close();
                    excelApp.Quit();
                }
                else
                {
                    MessageBox.Show("Нет информации для создания отчета!!! Сформируйте отчет для записи информации в файл");
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
            }
        }

        /// <summary>
        /// Сохранение колекции по алко по дате
        /// </summary>
        /// <param name="col"></param>        
        public static void Save_Report_Excel_Alco(int col)
        {
            try
            {
                bool check = false;
                string _col = Convert.ToString(col);
                alcos = new List<Alco>();
                for (int i = 0; i < AlcoholismPersona.Count; i++)
                {
                    if (_col == AlcoholismPersona[i].DataInfo)
                    {
                        alcos.Add(AlcoholismPersona[i]);
                    }
                }

                string ExcelFilePath = @"d:\HelaMedical\HelaMedical\File\AlcoDataBaseByDate.xlsx";

                Excel.Application excelApp = new Excel.Application();
                Workbook workBook;
                Worksheet workSheet;
                workBook = excelApp.Workbooks.Open(ExcelFilePath);
                workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);

                // Получаем активную таблицу
                for (int i = 2; i <= alcos.Count+1; i++)
                {
                    int j = i - 2;
                    workSheet.Cells[i, 1] = alcos[j].Id;
                    workSheet.Cells[i, 2] = alcos[j].FIO;
                    workSheet.Cells[i, 3] = alcos[j].Sex;
                    workSheet.Cells[i, 4] = alcos[j].Date;
                    workSheet.Cells[i, 5] = alcos[j].RegionCenterBLR;
                    workSheet.Cells[i, 6] = alcos[j].RaenCenterBLR;
                    workSheet.Cells[i, 7] = alcos[j].Life;
                    workSheet.Cells[i, 8] = alcos[j].Age;
                    workSheet.Cells[i, 9] = alcos[j].FamilyStatus;
                    workSheet.Cells[i, 10] = alcos[j].CostOfKids;
                    workSheet.Cells[i, 11] = alcos[j].FamilyComposition;
                    workSheet.Cells[i, 12] = alcos[j].Education;
                    workSheet.Cells[i, 13] = alcos[j].Profession;
                    workSheet.Cells[i, 14] = alcos[j].TheSkillLevelOfTheProfession;
                    workSheet.Cells[i, 15] = alcos[j].AddressOfRegistration;
                    workSheet.Cells[i, 16] = alcos[j].AddressAtTheTimeOfDeath;
                    workSheet.Cells[i, 17] = alcos[j].DataOfRegistration;
                    workSheet.Cells[i, 18] = alcos[j].ReRegistrationData;
                    workSheet.Cells[i, 19] = alcos[j].TypeOfRegistration;
                    workSheet.Cells[i, 20] = alcos[j].Heredity;
                    workSheet.Cells[i, 21] = alcos[j].DisabilityGroup;
                    workSheet.Cells[i, 22] = alcos[j].DisabilityStatus;
                    workSheet.Cells[i, 23] = alcos[j].ReasonForDisability;
                    workSheet.Cells[i, 24] = alcos[j].WorksStatus;
                    workSheet.Cells[i, 25] = alcos[j].AdmOtv;
                    workSheet.Cells[i, 26] = alcos[j].UgOtv;
                    workSheet.Cells[i, 27] = alcos[j].DlitsMLS;
                    workSheet.Cells[i, 28] = alcos[j].Stat107;
                    workSheet.Cells[i, 29] = alcos[j].StatUKRB;
                    workSheet.Cells[i, 30] = alcos[j].RodPrav;
                    workSheet.Cells[i, 31] = alcos[j].NomLTP;
                    workSheet.Cells[i, 32] = alcos[j].LTPKol;
                    workSheet.Cells[i, 33] = alcos[j].Hospitel;
                    workSheet.Cells[i, 34] = alcos[j].EK;
                    workSheet.Cells[i, 35] = alcos[j].DateOfDeregistration;
                    workSheet.Cells[i, 36] = alcos[j].DateOfDead;
                    workSheet.Cells[i, 37] = alcos[j].PlaceOfDead;
                    workSheet.Cells[i, 38] = alcos[j].DeathCertificate;
                    workSheet.Cells[i, 39] = alcos[j].CauseOfDead;
                    workSheet.Cells[i, 40] = alcos[j].DeathCategory;
                    workSheet.Cells[i, 41] = alcos[j].OpeningPlace;
                    workSheet.Cells[i, 42] = alcos[j].HistoryOfParasucicides;
                    workSheet.Cells[i, 43] = alcos[j].FeaturesOfObservation;
                    workSheet.Cells[i, 44] = alcos[j].ExperienceAbuse;
                    workSheet.Cells[i, 45] = alcos[j].AlcoholicDrinks;
                    workSheet.Cells[i, 46] = alcos[j].IK;
                    workSheet.Cells[i, 47] = alcos[j].DrugDiagnosisAlc;
                    workSheet.Cells[i, 48] = alcos[j].AgeOfRegistration;
                    workSheet.Cells[i, 49] = alcos[j].AgeOfDead;
                    workSheet.Cells[i, 50] = alcos[j].DataInfo;
                    workSheet.Cells[i, 51] = alcos[j].Registrotor;
                }
                workBook.Save();
                workBook.Close();
                excelApp.Quit();
                check = true;
                if (check)
                {
                    MessageBox.Show("Успешно");
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
                Excel.Application excelApp = new Excel.Application();
                excelApp.Quit();
            }
        }

        /// <summary>
        /// Считываем данные с Excel фаила 
        /// </summary>
        public static void Read_Alco()
        {
            try
            {
                alco_col = 0;
                Alco.AlcoholismPersona.Clear();
                string ExcelFilePath = @"d:\HelaMedical\HelaMedical\File\AlcoDataBase.xlsx";
                Excel.Application excelApp = new Excel.Application();
                Workbook workBook;
                Worksheet workSheet;
                Range range;
                workBook = excelApp.Workbooks.Open(ExcelFilePath);
                workSheet = (Worksheet)workBook.Worksheets.get_Item(1);
                range = workSheet.UsedRange;
                for (int cCnt = 1; cCnt <= range.Rows.Count; cCnt++)
                {
                    Alco alcos = new Alco
                    {
                        Id = Convert.ToString(workSheet.Cells[cCnt, 1].Value),
                        FIO = Convert.ToString(workSheet.Cells[cCnt, 2].Value),
                        Sex = Convert.ToString(workSheet.Cells[cCnt, 3].Value),
                        Date = Convert.ToString(workSheet.Cells[cCnt, 4].Value),
                        RegionCenterBLR = Convert.ToString(workSheet.Cells[cCnt, 5].Value),
                        RaenCenterBLR = Convert.ToString(workSheet.Cells[cCnt, 6].Value),
                        Life = Convert.ToString(workSheet.Cells[cCnt, 7].Value),
                        Age = Convert.ToString(workSheet.Cells[cCnt, 8].Value),
                        FamilyStatus = Convert.ToString(workSheet.Cells[cCnt, 9].Value),
                        CostOfKids = Convert.ToString(workSheet.Cells[cCnt, 10].Value),
                        FamilyComposition = Convert.ToString(workSheet.Cells[cCnt, 11].Value),
                        Education = Convert.ToString(workSheet.Cells[cCnt, 12].Value),
                        Profession = Convert.ToString(workSheet.Cells[cCnt, 13].Value),
                        TheSkillLevelOfTheProfession = Convert.ToString(workSheet.Cells[cCnt, 14].Value),
                        AddressOfRegistration = Convert.ToString(workSheet.Cells[cCnt, 15].Value),
                        AddressAtTheTimeOfDeath = Convert.ToString(workSheet.Cells[cCnt, 16].Value),
                        DataOfRegistration = Convert.ToString(workSheet.Cells[cCnt, 17].Value),
                        ReRegistrationData = Convert.ToString(workSheet.Cells[cCnt, 18].Value),
                        TypeOfRegistration = Convert.ToString(workSheet.Cells[cCnt, 19].Value),
                        Heredity = Convert.ToString(workSheet.Cells[cCnt, 20].Value),
                        DisabilityGroup = Convert.ToString(workSheet.Cells[cCnt, 21].Value),
                        DisabilityStatus = Convert.ToString(workSheet.Cells[cCnt, 22].Value),
                        ReasonForDisability = Convert.ToString(workSheet.Cells[cCnt, 23].Value),
                        WorksStatus = Convert.ToString(workSheet.Cells[cCnt, 24].Value),
                        AdmOtv = Convert.ToString(workSheet.Cells[cCnt, 25].Value),
                        UgOtv = Convert.ToString(workSheet.Cells[cCnt, 26].Value),
                        DlitsMLS = Convert.ToString(workSheet.Cells[cCnt, 27].Value),
                        Stat107 = Convert.ToString(workSheet.Cells[cCnt, 28].Value),
                        StatUKRB = Convert.ToString(workSheet.Cells[cCnt, 29].Value),
                        RodPrav = Convert.ToString(workSheet.Cells[cCnt, 30].Value),
                        NomLTP = Convert.ToString(workSheet.Cells[cCnt, 31].Value),
                        LTPKol = Convert.ToString(workSheet.Cells[cCnt, 32].Value),
                        Hospitel = Convert.ToString(workSheet.Cells[cCnt, 33].Value),
                        EK = Convert.ToString(workSheet.Cells[cCnt, 34].Value),
                        DateOfDeregistration = Convert.ToString(workSheet.Cells[cCnt, 35].Value),
                        DateOfDead = Convert.ToString(workSheet.Cells[cCnt, 36].Value),
                        PlaceOfDead = Convert.ToString(workSheet.Cells[cCnt, 37].Value),
                        DeathCertificate = Convert.ToString(workSheet.Cells[cCnt, 38].Value),
                        CauseOfDead = Convert.ToString(workSheet.Cells[cCnt, 39].Value),
                        DeathCategory = Convert.ToString(workSheet.Cells[cCnt, 40].Value),
                        OpeningPlace = Convert.ToString(workSheet.Cells[cCnt, 41].Value),
                        HistoryOfParasucicides = Convert.ToString(workSheet.Cells[cCnt, 42].Value),
                        FeaturesOfObservation = Convert.ToString(workSheet.Cells[cCnt, 43].Value),
                        ExperienceAbuse = Convert.ToString(workSheet.Cells[cCnt, 44].Value),
                        AlcoholicDrinks = Convert.ToString(workSheet.Cells[cCnt, 45].Value),
                        IK = Convert.ToString(workSheet.Cells[cCnt, 46].Value),
                        DrugDiagnosisAlc = Convert.ToString(workSheet.Cells[cCnt, 47].Value),
                        AgeOfRegistration = Convert.ToString(workSheet.Cells[cCnt, 48].Value),
                        AgeOfDead = Convert.ToString(workSheet.Cells[cCnt, 49].Value),
                        DataInfo = Convert.ToString(workSheet.Cells[cCnt, 50].Value),
                        Registrotor = Convert.ToString(workSheet.Cells[cCnt, 51].Value)
                    };
                    alco_col++;
                    AlcoholismPersona.Add(alcos);
                }
                workBook.Close();
                excelApp.Quit();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
            }
        }

        /// <summary>
        /// плолучение кол-во записей из Excel алкоголь
        /// </ summary>
        /// <Return> </ Return>
        public static void Reader_Excel_Alco()
        {
            try
            {
                Alco.AlcoholismPersona.Clear();
                alco_col = 0;
                string ExcelFilePath = @"d:\HelaMedical\HelaMedical\File\AlcoDataBase.xlsx";
                Excel.Application excelApp = new Excel.Application();
                Workbook workBook;
                Worksheet workSheet;
                Range range;
                workBook = excelApp.Workbooks.Open(ExcelFilePath);
                workSheet = (Worksheet)workBook.Worksheets.get_Item(1);
                range = workSheet.UsedRange;
                for (int cCnt = 0; cCnt <= range.Rows.Count; cCnt++)
                {
                    alco_col++;
                }
                workBook.Close();
                excelApp.Quit();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
            }
        }


        // Наркоты 
        public static void Patient_Сreation_Narco(string fio, string sex, string data, string regionCenterBLR, string raenCenterBLR, string life, string age, string familyStatus,
            string costOfKids, string familyComposition, string education, string profession, string theSkillLevelOfTheProfession, string addressOfRegistration,
            string addressAtTheTimeOfDeath, string dataOfRegistration, string reRegistrationData, string typeOfRegistration, string heredity, string disabilityGroup,
            string disabilityStatus, string reasonForDisability, string socialStatus, string admOtv, string ugOtv, string dlitMLS, string stat0a107, string statUKRB,
            string rodPrav, string nomLTP, string LTPkol, string hosp, string EK, string dateOfDeregistration, string dateOfDead, string placeOfDead, string deathCertificate,
            string causeOfDeat, string deathCategory, string openingPlace, string historyOfParasucicides, string featuresOfObservation, string intranozologicalComorbidity,
            string typeOfDrug, string drugUse, string yearOfFirstUse, string experienceAbuseDrug, string remissions, string remissionNumber, string remissionTimer,
            string drugDiagnosisX, string ageOfDead, string dataIfio, string ageOfRegistration)
        {
            Reader_Excel_Narco();
            Narcoman newNarcoPerson = new Narcoman();
            if (narco_col == 1) newNarcoPerson.Id = Convert.ToString("1");
            newNarcoPerson.Id = Convert.ToString(narco_col - 1);

            newNarcoPerson.FIO = fio;
            newNarcoPerson.Sex = sex;
            newNarcoPerson.Date = data;
            newNarcoPerson.RegionCenterBLR = regionCenterBLR;
            newNarcoPerson.RaenCenterBLR = raenCenterBLR;
            newNarcoPerson.Life = life;
            newNarcoPerson.Age = age;
            newNarcoPerson.FamilyStatus = familyStatus;
            newNarcoPerson.CostOfKids = costOfKids;
            newNarcoPerson.FamilyComposition = familyComposition;
            newNarcoPerson.Education = education;
            newNarcoPerson.Profession = profession;
            newNarcoPerson.TheSkillLevelOfTheProfession = theSkillLevelOfTheProfession;
            newNarcoPerson.AddressOfRegistration = addressOfRegistration;
            newNarcoPerson.AddressAtTheTimeOfDeath = addressAtTheTimeOfDeath;
            newNarcoPerson.DataOfRegistration = dataOfRegistration;
            newNarcoPerson.ReRegistrationData = reRegistrationData;
            newNarcoPerson.TypeOfRegistration = typeOfRegistration;
            newNarcoPerson.Heredity = heredity;
            newNarcoPerson.DisabilityGroup = disabilityGroup;
            newNarcoPerson.DisabilityStatus = disabilityStatus;
            newNarcoPerson.ReasonForDisability = reasonForDisability;
            newNarcoPerson.WorksStatus = socialStatus;
            newNarcoPerson.AdmOtv = Convert.ToString(admOtv);
            newNarcoPerson.UgOtv = Convert.ToString(ugOtv);
            newNarcoPerson.DlitsMLS = Convert.ToString(dlitMLS);
            newNarcoPerson.Stat107 = stat0a107;
            newNarcoPerson.StatUKRB = statUKRB;
            newNarcoPerson.RodPrav = rodPrav;
            newNarcoPerson.NomLTP = nomLTP;
            newNarcoPerson.LTPKol = LTPkol;
            newNarcoPerson.Hospitel = hosp;
            newNarcoPerson.EK = EK;
            newNarcoPerson.DateOfDeregistration = dateOfDeregistration;
            newNarcoPerson.DateOfDead = dateOfDead;
            newNarcoPerson.PlaceOfDead = placeOfDead;
            newNarcoPerson.DeathCertificate = deathCertificate;
            newNarcoPerson.CauseOfDead = causeOfDeat;
            newNarcoPerson.DeathCategory = deathCategory;
            newNarcoPerson.OpeningPlace = openingPlace;
            newNarcoPerson.HistoryOfParasucicides = historyOfParasucicides;
            newNarcoPerson.FeaturesOfObservation = featuresOfObservation;
            newNarcoPerson.IntranozologicalComorbidity = intranozologicalComorbidity;
            newNarcoPerson.TypeOfDrug = typeOfDrug;
            newNarcoPerson.DrugUse = drugUse;
            newNarcoPerson.YearOfFirstUse = yearOfFirstUse;
            newNarcoPerson.ExperienceAbuseDrug = experienceAbuseDrug;
            newNarcoPerson.Remissions = remissions;
            newNarcoPerson.RemissionNumber = remissionNumber;
            newNarcoPerson.RemissionTimer = remissionTimer;
            newNarcoPerson.DrugDiagnosisX = drugDiagnosisX;
            newNarcoPerson.AgeOfDead = ageOfDead;
            newNarcoPerson.AgeOfRegistration = ageOfRegistration;
            newNarcoPerson.DataInfo = dataIfio;
            newNarcoPerson.Registrotor = Other.Regis.ToString();

            Drug_Addiction.Add(newNarcoPerson);


            Save_Excel_Narco();
        }

        /// <summary>
        /// Сохранение Колекции в Excel наркоман
        /// </summary>
        public static void Save_Excel_Narco()
        {
            string ExcelFilePath = @"d:\HelaMedical\HelaMedical\File\NarcoDataBase.xlsx";

            Excel.Application excelApp = new Excel.Application();
            Workbook workBook;
            Worksheet workSheet;
            workBook = excelApp.Workbooks.Open(ExcelFilePath);
            workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);

            // Получаем активную таблицу
            for (int i = 0; i < narco_col + 1; i++)
            {
                if (i == narco_col)
                {
                    workSheet.Cells[i, 1] = Drug_Addiction[0].Id;
                    workSheet.Cells[i, 2] = Drug_Addiction[0].FIO;
                    workSheet.Cells[i, 3] = Drug_Addiction[0].Sex;
                    workSheet.Cells[i, 4] = Drug_Addiction[0].Date;
                    workSheet.Cells[i, 5] = Drug_Addiction[0].RegionCenterBLR;
                    workSheet.Cells[i, 6] = Drug_Addiction[0].RaenCenterBLR;
                    workSheet.Cells[i, 7] = Drug_Addiction[0].Life;
                    workSheet.Cells[i, 8] = Drug_Addiction[0].Age;
                    workSheet.Cells[i, 9] = Drug_Addiction[0].FamilyStatus;
                    workSheet.Cells[i, 10] = Drug_Addiction[0].CostOfKids;
                    workSheet.Cells[i, 11] = Drug_Addiction[0].FamilyComposition;
                    workSheet.Cells[i, 12] = Drug_Addiction[0].Education;
                    workSheet.Cells[i, 13] = Drug_Addiction[0].Profession;
                    workSheet.Cells[i, 14] = Drug_Addiction[0].TheSkillLevelOfTheProfession;
                    workSheet.Cells[i, 15] = Drug_Addiction[0].AddressOfRegistration;
                    workSheet.Cells[i, 16] = Drug_Addiction[0].AddressAtTheTimeOfDeath;
                    workSheet.Cells[i, 17] = Drug_Addiction[0].DataOfRegistration;
                    workSheet.Cells[i, 18] = Drug_Addiction[0].ReRegistrationData;
                    workSheet.Cells[i, 19] = Drug_Addiction[0].TypeOfRegistration;
                    workSheet.Cells[i, 20] = Drug_Addiction[0].Heredity;
                    workSheet.Cells[i, 21] = Drug_Addiction[0].DisabilityGroup;
                    workSheet.Cells[i, 22] = Drug_Addiction[0].DisabilityStatus;
                    workSheet.Cells[i, 23] = Drug_Addiction[0].ReasonForDisability;
                    workSheet.Cells[i, 24] = Drug_Addiction[0].WorksStatus;
                    workSheet.Cells[i, 25] = Drug_Addiction[0].AdmOtv;
                    workSheet.Cells[i, 26] = Drug_Addiction[0].UgOtv;
                    workSheet.Cells[i, 27] = Drug_Addiction[0].DlitsMLS;
                    workSheet.Cells[i, 28] = Drug_Addiction[0].Stat107;
                    workSheet.Cells[i, 29] = Drug_Addiction[0].StatUKRB;
                    workSheet.Cells[i, 30] = Drug_Addiction[0].RodPrav;
                    workSheet.Cells[i, 31] = Drug_Addiction[0].NomLTP;
                    workSheet.Cells[i, 32] = Drug_Addiction[0].LTPKol;
                    workSheet.Cells[i, 33] = Drug_Addiction[0].Hospitel;
                    workSheet.Cells[i, 34] = Drug_Addiction[0].EK;
                    workSheet.Cells[i, 35] = Drug_Addiction[0].DateOfDeregistration;
                    workSheet.Cells[i, 36] = Drug_Addiction[0].DateOfDead;
                    workSheet.Cells[i, 37] = Drug_Addiction[0].PlaceOfDead;
                    workSheet.Cells[i, 38] = Drug_Addiction[0].DeathCertificate;
                    workSheet.Cells[i, 39] = Drug_Addiction[0].CauseOfDead;
                    workSheet.Cells[i, 40] = Drug_Addiction[0].DeathCategory;
                    workSheet.Cells[i, 41] = Drug_Addiction[0].OpeningPlace;
                    workSheet.Cells[i, 42] = Drug_Addiction[0].HistoryOfParasucicides;
                    workSheet.Cells[i, 43] = Drug_Addiction[0].FeaturesOfObservation;
                    workSheet.Cells[i, 44] = Drug_Addiction[0].IntranozologicalComorbidity;
                    workSheet.Cells[i, 45] = Drug_Addiction[0].TypeOfDrug;
                    workSheet.Cells[i, 46] = Drug_Addiction[0].DrugUse;
                    workSheet.Cells[i, 47] = Drug_Addiction[0].YearOfFirstUse;
                    workSheet.Cells[i, 48] = Drug_Addiction[0].ExperienceAbuseDrug;
                    workSheet.Cells[i, 49] = Drug_Addiction[0].Remissions;
                    workSheet.Cells[i, 50] = Drug_Addiction[0].RemissionNumber;
                    workSheet.Cells[i, 51] = Drug_Addiction[0].RemissionTimer;
                    workSheet.Cells[i, 52] = Drug_Addiction[0].DrugDiagnosisX;
                    workSheet.Cells[i, 53] = Drug_Addiction[0].AgeOfRegistration;
                    workSheet.Cells[i, 54] = Drug_Addiction[0].AgeOfDead;
                    workSheet.Cells[i, 55] = Drug_Addiction[0].DataInfo;
                    workSheet.Cells[i, 56] = Drug_Addiction[0].Registrotor;
                }
            }
            workBook.Save();
            workBook.Close();
            excelApp.Quit();
        }

        /// <summary>
        /// Сохранение колекции по алко по дате
        /// </summary>
        /// <param name="narcos"></param>
        /// <param name="col"></param>        
        public static void Save_Report_Excel_Narco(int col)
        {
            try
            {
                bool check = false;
                string _col = Convert.ToString(col);
                narcos = new List<Narcoman>();
                for (int i = 0; i < Drug_Addiction.Count; i++)
                {
                    if (_col == Drug_Addiction[i].DataInfo)
                    {
                        narcos.Add(Drug_Addiction[i]);
                    }
                }
                string ExcelFilePath = @"d:\HelaMedical\HelaMedical\File\NarcoDataBaseByDate.xlsx";

                Excel.Application excelApp = new Excel.Application();
                Workbook workBook;
                Worksheet workSheet;
                workBook = excelApp.Workbooks.Open(ExcelFilePath);
                workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);

                // Получаем активную таблицу
                for (int i = 2; i <= narcos.Count + 1; i++)
                {
                    int j = i - 2;
                    workSheet.Cells[i, 1] = narcos[j].Id;
                    workSheet.Cells[i, 2] = narcos[j].FIO;
                    workSheet.Cells[i, 3] = narcos[j].Sex;
                    workSheet.Cells[i, 4] = narcos[j].Date;
                    workSheet.Cells[i, 5] = narcos[j].RegionCenterBLR;
                    workSheet.Cells[i, 6] = narcos[j].RaenCenterBLR;
                    workSheet.Cells[i, 7] = narcos[j].Life;
                    workSheet.Cells[i, 8] = narcos[j].Age;
                    workSheet.Cells[i, 9] = narcos[j].FamilyStatus;
                    workSheet.Cells[i, 10] = narcos[j].CostOfKids;
                    workSheet.Cells[i, 11] = narcos[j].FamilyComposition;
                    workSheet.Cells[i, 12] = narcos[j].Education;
                    workSheet.Cells[i, 13] = narcos[j].Profession;
                    workSheet.Cells[i, 14] = narcos[j].TheSkillLevelOfTheProfession;
                    workSheet.Cells[i, 15] = narcos[j].AddressOfRegistration;
                    workSheet.Cells[i, 16] = narcos[j].AddressAtTheTimeOfDeath;
                    workSheet.Cells[i, 17] = narcos[j].DataOfRegistration;
                    workSheet.Cells[i, 18] = narcos[j].ReRegistrationData;
                    workSheet.Cells[i, 19] = narcos[j].TypeOfRegistration;
                    workSheet.Cells[i, 20] = narcos[j].Heredity;
                    workSheet.Cells[i, 21] = narcos[j].DisabilityGroup;
                    workSheet.Cells[i, 22] = narcos[j].DisabilityStatus;
                    workSheet.Cells[i, 23] = narcos[j].ReasonForDisability;
                    workSheet.Cells[i, 24] = narcos[j].WorksStatus;
                    workSheet.Cells[i, 25] = narcos[j].AdmOtv;
                    workSheet.Cells[i, 26] = narcos[j].UgOtv;
                    workSheet.Cells[i, 27] = narcos[j].DlitsMLS;
                    workSheet.Cells[i, 28] = narcos[j].Stat107;
                    workSheet.Cells[i, 29] = narcos[j].StatUKRB;
                    workSheet.Cells[i, 30] = narcos[j].RodPrav;
                    workSheet.Cells[i, 31] = narcos[j].NomLTP;
                    workSheet.Cells[i, 32] = narcos[j].LTPKol;
                    workSheet.Cells[i, 33] = narcos[j].Hospitel;
                    workSheet.Cells[i, 34] = narcos[j].EK;
                    workSheet.Cells[i, 35] = narcos[j].DateOfDeregistration;
                    workSheet.Cells[i, 36] = narcos[j].DateOfDead;
                    workSheet.Cells[i, 37] = narcos[j].PlaceOfDead;
                    workSheet.Cells[i, 38] = narcos[j].DeathCertificate;
                    workSheet.Cells[i, 39] = narcos[j].CauseOfDead;
                    workSheet.Cells[i, 40] = narcos[j].DeathCategory;
                    workSheet.Cells[i, 41] = narcos[j].OpeningPlace;
                    workSheet.Cells[i, 42] = narcos[j].HistoryOfParasucicides;
                    workSheet.Cells[i, 43] = narcos[j].FeaturesOfObservation;
                    workSheet.Cells[i, 44] = narcos[j].IntranozologicalComorbidity;
                    workSheet.Cells[i, 45] = narcos[j].TypeOfDrug;
                    workSheet.Cells[i, 46] = narcos[j].DrugUse;
                    workSheet.Cells[i, 47] = narcos[j].YearOfFirstUse;
                    workSheet.Cells[i, 48] = narcos[j].ExperienceAbuseDrug;
                    workSheet.Cells[i, 49] = narcos[j].Remissions;
                    workSheet.Cells[i, 50] = narcos[j].RemissionNumber;
                    workSheet.Cells[i, 51] = narcos[j].RemissionTimer;
                    workSheet.Cells[i, 52] = narcos[j].DrugDiagnosisX;
                    workSheet.Cells[i, 53] = narcos[j].AgeOfRegistration;
                    workSheet.Cells[i, 54] = narcos[j].AgeOfDead;
                    workSheet.Cells[i, 55] = narcos[j].DataInfo;
                    workSheet.Cells[i, 56] = narcos[j].Registrotor;
                }
                workBook.Save();
                workBook.Close();
                excelApp.Quit();
                check = true;
                if (check)
                {
                    MessageBox.Show("Успешно");
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
                Excel.Application excelApp = new Excel.Application();
                excelApp.Quit();
            }
        }

        /// <summary>
        /// Сохранение информации по выборке из отчета по наркотической зависимости
        /// </summary>
        public static void Save_Report_Excel_Narco()
        {
            int count = 0;
            for (int i = 0; i < narco_col; i++)
                count++;
            if (count > 0)
            {
                string ExcelFilePath = @"D:\HelaMedical\HelaMedical\File\NarcoReport.xlsx";

                Excel.Application excelApp = new Excel.Application();
                Workbook workBook;
                Worksheet workSheet;
                workBook = excelApp.Workbooks.Open(ExcelFilePath);
                workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);

                // Получаем активную таблицу
                for (int i = 1; i <= Drug_Addiction.Count; i++)
                {
                    int j = i - 1;
                    workSheet.Cells[i, 1] = Drug_Addiction[j].Id;
                    workSheet.Cells[i, 2] = Drug_Addiction[j].FIO;
                    workSheet.Cells[i, 3] = Drug_Addiction[j].Sex;
                    workSheet.Cells[i, 4] = Drug_Addiction[j].Date;
                    workSheet.Cells[i, 5] = Drug_Addiction[j].RegionCenterBLR;
                    workSheet.Cells[i, 6] = Drug_Addiction[j].RaenCenterBLR;
                    workSheet.Cells[i, 7] = Drug_Addiction[j].Life;
                    workSheet.Cells[i, 8] = Drug_Addiction[j].Age;
                    workSheet.Cells[i, 9] = Drug_Addiction[j].FamilyStatus;
                    workSheet.Cells[i, 10] = Drug_Addiction[j].CostOfKids;
                    workSheet.Cells[i, 11] = Drug_Addiction[j].FamilyComposition;
                    workSheet.Cells[i, 12] = Drug_Addiction[j].Education;
                    workSheet.Cells[i, 13] = Drug_Addiction[j].Profession;
                    workSheet.Cells[i, 14] = Drug_Addiction[j].TheSkillLevelOfTheProfession;
                    workSheet.Cells[i, 15] = Drug_Addiction[j].AddressOfRegistration;
                    workSheet.Cells[i, 16] = Drug_Addiction[j].AddressAtTheTimeOfDeath;
                    workSheet.Cells[i, 17] = Drug_Addiction[j].DataOfRegistration;
                    workSheet.Cells[i, 18] = Drug_Addiction[j].ReRegistrationData;
                    workSheet.Cells[i, 19] = Drug_Addiction[j].TypeOfRegistration;
                    workSheet.Cells[i, 20] = Drug_Addiction[j].Heredity;
                    workSheet.Cells[i, 21] = Drug_Addiction[j].DisabilityGroup;
                    workSheet.Cells[i, 22] = Drug_Addiction[j].DisabilityStatus;
                    workSheet.Cells[i, 23] = Drug_Addiction[j].ReasonForDisability;
                    workSheet.Cells[i, 24] = Drug_Addiction[j].WorksStatus;
                    workSheet.Cells[i, 25] = Drug_Addiction[j].AdmOtv;
                    workSheet.Cells[i, 26] = Drug_Addiction[j].UgOtv;
                    workSheet.Cells[i, 27] = Drug_Addiction[j].DlitsMLS;
                    workSheet.Cells[i, 28] = Drug_Addiction[j].Stat107;
                    workSheet.Cells[i, 29] = Drug_Addiction[j].StatUKRB;
                    workSheet.Cells[i, 30] = Drug_Addiction[j].RodPrav;
                    workSheet.Cells[i, 31] = Drug_Addiction[j].NomLTP;
                    workSheet.Cells[i, 32] = Drug_Addiction[j].LTPKol;
                    workSheet.Cells[i, 33] = Drug_Addiction[j].Hospitel;
                    workSheet.Cells[i, 34] = Drug_Addiction[j].EK;
                    workSheet.Cells[i, 35] = Drug_Addiction[j].DateOfDeregistration;
                    workSheet.Cells[i, 36] = Drug_Addiction[j].DateOfDead;
                    workSheet.Cells[i, 37] = Drug_Addiction[j].PlaceOfDead;
                    workSheet.Cells[i, 38] = Drug_Addiction[j].DeathCertificate;
                    workSheet.Cells[i, 39] = Drug_Addiction[j].CauseOfDead;
                    workSheet.Cells[i, 40] = Drug_Addiction[j].DeathCategory;
                    workSheet.Cells[i, 41] = Drug_Addiction[j].OpeningPlace;
                    workSheet.Cells[i, 42] = Drug_Addiction[j].HistoryOfParasucicides;
                    workSheet.Cells[i, 43] = Drug_Addiction[j].FeaturesOfObservation;
                    workSheet.Cells[i, 44] = Drug_Addiction[j].IntranozologicalComorbidity;
                    workSheet.Cells[i, 45] = Drug_Addiction[j].TypeOfDrug;
                    workSheet.Cells[i, 46] = Drug_Addiction[j].DrugUse;
                    workSheet.Cells[i, 47] = Drug_Addiction[j].YearOfFirstUse;
                    workSheet.Cells[i, 48] = Drug_Addiction[j].ExperienceAbuseDrug;
                    workSheet.Cells[i, 49] = Drug_Addiction[j].Remissions;
                    workSheet.Cells[i, 50] = Drug_Addiction[j].RemissionNumber;
                    workSheet.Cells[i, 51] = Drug_Addiction[j].RemissionTimer;
                    workSheet.Cells[i, 52] = Drug_Addiction[j].DrugDiagnosisX;
                    workSheet.Cells[i, 53] = Drug_Addiction[j].AgeOfRegistration;
                    workSheet.Cells[i, 54] = Drug_Addiction[j].AgeOfDead;
                    workSheet.Cells[i, 55] = Drug_Addiction[j].DataInfo;
                    workSheet.Cells[i, 56] = Drug_Addiction[j].Registrotor;
                }
                workBook.Save();
                workBook.Close();
                excelApp.Quit();
            }
            else
            {
                MessageBox.Show("Нет информации для создания отчета!!! Сформируйте отчет для записи информации в файл");
            }
        }

        /// <summary>
        /// Считывает базу по наркотам
        /// </summary>
        public static void Read_Narco()
        {
            Narcoman.Drug_Addiction.Clear();
            narco_col = 0;
            string ExcelFilePath = @"d:\HelaMedical\HelaMedical\File\NarcoDataBase.xlsx";
            Excel.Application excelApp = new Excel.Application();
            Workbook workBook;
            Worksheet workSheet;
            Range range;
            workBook = excelApp.Workbooks.Open(ExcelFilePath);
            workSheet = (Worksheet)workBook.Worksheets.get_Item(1);
            range = workSheet.UsedRange;
            for (int cCnt = 1; cCnt <= range.Rows.Count; cCnt++)
            {
                Narcoman narcoman = new Narcoman
                {
                    Id = Convert.ToString(workSheet.Cells[cCnt, 1].Value),
                    FIO = Convert.ToString(workSheet.Cells[cCnt, 2].Value),
                    Sex = Convert.ToString(workSheet.Cells[cCnt, 3].Value),
                    Date = Convert.ToString(workSheet.Cells[cCnt, 4].Value),
                    RegionCenterBLR = Convert.ToString(workSheet.Cells[cCnt, 5].Value),
                    RaenCenterBLR = Convert.ToString(workSheet.Cells[cCnt, 6].Value),
                    Life = Convert.ToString(workSheet.Cells[cCnt, 7].Value),
                    Age = Convert.ToString(workSheet.Cells[cCnt, 8].Value),
                    FamilyStatus = Convert.ToString(workSheet.Cells[cCnt, 9].Value),
                    CostOfKids = Convert.ToString(workSheet.Cells[cCnt, 10].Value),
                    FamilyComposition = Convert.ToString(workSheet.Cells[cCnt, 11].Value),
                    Education = Convert.ToString(workSheet.Cells[cCnt, 12].Value),
                    Profession = Convert.ToString(workSheet.Cells[cCnt, 13].Value),
                    TheSkillLevelOfTheProfession = Convert.ToString(workSheet.Cells[cCnt, 14].Value),
                    AddressOfRegistration = Convert.ToString(workSheet.Cells[cCnt, 15].Value),
                    AddressAtTheTimeOfDeath = Convert.ToString(workSheet.Cells[cCnt, 16].Value),
                    DataOfRegistration = Convert.ToString(workSheet.Cells[cCnt, 17].Value),
                    ReRegistrationData = Convert.ToString(workSheet.Cells[cCnt, 18].Value),
                    TypeOfRegistration = Convert.ToString(workSheet.Cells[cCnt, 19].Value),
                    Heredity = Convert.ToString(workSheet.Cells[cCnt, 20].Value),
                    DisabilityGroup = Convert.ToString(workSheet.Cells[cCnt, 21].Value),
                    DisabilityStatus = Convert.ToString(workSheet.Cells[cCnt, 22].Value),
                    ReasonForDisability = Convert.ToString(workSheet.Cells[cCnt, 23].Value),
                    WorksStatus = Convert.ToString(workSheet.Cells[cCnt, 24].Value),
                    AdmOtv = Convert.ToString(workSheet.Cells[cCnt, 25].Value),
                    UgOtv = Convert.ToString(workSheet.Cells[cCnt, 26].Value),
                    DlitsMLS = Convert.ToString(workSheet.Cells[cCnt, 27].Value),
                    Stat107 = Convert.ToString(workSheet.Cells[cCnt, 28].Value),
                    StatUKRB = Convert.ToString(workSheet.Cells[cCnt, 29].Value),
                    RodPrav = Convert.ToString(workSheet.Cells[cCnt, 30].Value),
                    NomLTP = Convert.ToString(workSheet.Cells[cCnt, 31].Value),
                    LTPKol = Convert.ToString(workSheet.Cells[cCnt, 32].Value),
                    Hospitel = Convert.ToString(workSheet.Cells[cCnt, 33].Value),
                    EK = Convert.ToString(workSheet.Cells[cCnt, 34].Value),
                    DateOfDeregistration = Convert.ToString(workSheet.Cells[cCnt, 35].Value),
                    DateOfDead = Convert.ToString(workSheet.Cells[cCnt, 36].Value),
                    PlaceOfDead = Convert.ToString(workSheet.Cells[cCnt, 37].Value),
                    DeathCertificate = Convert.ToString(workSheet.Cells[cCnt, 38].Value),
                    CauseOfDead = Convert.ToString(workSheet.Cells[cCnt, 39].Value),
                    DeathCategory = Convert.ToString(workSheet.Cells[cCnt, 40].Value),
                    OpeningPlace = Convert.ToString(workSheet.Cells[cCnt, 41].Value),
                    HistoryOfParasucicides = Convert.ToString(workSheet.Cells[cCnt, 42].Value),
                    FeaturesOfObservation = Convert.ToString(workSheet.Cells[cCnt, 43].Value),
                    IntranozologicalComorbidity = Convert.ToString(workSheet.Cells[cCnt, 44].Value),
                    TypeOfDrug = Convert.ToString(workSheet.Cells[cCnt, 45].Value),
                    DrugUse = Convert.ToString(workSheet.Cells[cCnt, 46].Value),
                    YearOfFirstUse = Convert.ToString(workSheet.Cells[cCnt, 47].Value),
                    ExperienceAbuseDrug = Convert.ToString(workSheet.Cells[cCnt, 48].Value),
                    Remissions = Convert.ToString(workSheet.Cells[cCnt, 49].Value),
                    RemissionNumber = Convert.ToString(workSheet.Cells[cCnt, 50].Value),
                    RemissionTimer = Convert.ToString(workSheet.Cells[cCnt, 51].Value),
                    DrugDiagnosisX = Convert.ToString(workSheet.Cells[cCnt, 52].Value),
                    AgeOfRegistration = Convert.ToString(workSheet.Cells[cCnt, 53].Value),
                    AgeOfDead = Convert.ToString(workSheet.Cells[cCnt, 54].Value),
                    DataInfo = Convert.ToString(workSheet.Cells[cCnt, 55].Value),
                    Registrotor = Convert.ToString(workSheet.Cells[cCnt, 56].Value)
                };
                narco_col++;
                Drug_Addiction.Add(narcoman);
            }
            workBook.Close();
            excelApp.Quit();
        }
       
        /// <summary>
        /// Способ получить все записи из Excel наркоман
        /// </ summary>
        /// <Return> </ Return>
        public static void Reader_Excel_Narco()
        {
            Narcoman.Drug_Addiction.Clear();
            narco_col = 0;
            string ExcelFilePath = @"d:\HelaMedical\HelaMedical\File\NarcoDataBase.xlsx";
            Excel.Application excelApp = new Excel.Application();
            Workbook workBook;
            Worksheet workSheet;
            Range range;
            workBook = excelApp.Workbooks.Open(ExcelFilePath);
            workSheet = (Worksheet)workBook.Worksheets.get_Item(1);
            range = workSheet.UsedRange;
            for (int cCnt = 0; cCnt <= range.Rows.Count; cCnt++)
            {
                narco_col++;
            }
            workBook.Close();
            excelApp.Quit();
        }


        //полизависимость 
        public static void Patient_Сreation_Alco_Narco(string fio, string sex, string data, string regionCenterBLR, string raenCentrBLR,  string life, string age, string familyStatus,
            string costOfKids, string familyComposition, string education, string profession, string theSkillLevelOfTheProfession, string addressOfRegistration,
            string addressAtTheTimeOfDeath, string dataOfRegistration, string reRegistrationData, string typeOfRegistration, string heredity, string disabilityGroup,
            string disabilityStatus, string reasonForDisability, string socialStatus, string admOtv, string ugOtv, string dlitMLS, string stat0a107, string statUKRB,
            string rodPrav, string nomLTP, string LTPkol, string hosp, string EK, string dateOfDeregistration, string dateOfDead, string placeOfDead,
            string deathCertificate, string causeOfDeat, string deathCategory, string openingPlace, string historyOfParasucicides, string featuresOfObservation,
            string DrugDiagnosisAlc, string experienceAbuse, string AlcoholicDrinks, string intranozologicalComorbidity, string typeOfDrug, string drugUse,
            string yearOfFirstUse, string experienceAbuseDrug, string remissions, string remissionNumber, string remissionTimer, string drugDiagnosisX, string ageOfDead, string dataInfo,
            string ageOfRegistration)
        {
            Reader_Excel_Alco_Narco_Person();
            Polizavis newPolizavis = new Polizavis();
            if (poliz_col == 1) newPolizavis.Id = Convert.ToString("1");

            newPolizavis.Id = Convert.ToString(poliz_col-1);

            newPolizavis.FIO = fio;
            newPolizavis.Sex = sex;
            newPolizavis.Date = data;
            newPolizavis.RegionCenterBLR = regionCenterBLR;
            newPolizavis.RaenCentrBLR = raenCentrBLR;
            newPolizavis.Life = life;
            newPolizavis.Age = age;
            newPolizavis.FamilyStatus = familyStatus;
            newPolizavis.CostOfKids = costOfKids;
            newPolizavis.FamilyComposition = familyComposition;
            newPolizavis.Education = education;
            newPolizavis.Profession = profession;
            newPolizavis.TheSkillLevelOfTheProfession = theSkillLevelOfTheProfession;
            newPolizavis.AddressOfRegistration = addressOfRegistration;
            newPolizavis.AddressAtTheTimeOfDeath = addressAtTheTimeOfDeath;
            newPolizavis.DataOfRegistration = dataOfRegistration;
            newPolizavis.ReRegistrationData = reRegistrationData;
            newPolizavis.TypeOfRegistration = typeOfRegistration;
            newPolizavis.Heredity = heredity;
            newPolizavis.DisabilityGroup = disabilityGroup;
            newPolizavis.DisabilityStatus = disabilityStatus;
            newPolizavis.ReasonForDisability = reasonForDisability;
            newPolizavis.WorksStatus = socialStatus;
            newPolizavis.AdmOtv = Convert.ToString(admOtv);
            newPolizavis.UgOtv = Convert.ToString(ugOtv);
            newPolizavis.DlitsMLS = Convert.ToString(dlitMLS);
            newPolizavis.Stat107 = stat0a107;
            newPolizavis.StatUKRB = statUKRB;
            newPolizavis.RodPrav = rodPrav;
            newPolizavis.NomLTP = nomLTP;
            newPolizavis.LTPKol = LTPkol;
            newPolizavis.Hospitel = hosp;
            newPolizavis.EK = EK;
            newPolizavis.DateOfDeregistration = dateOfDeregistration;
            newPolizavis.DateOfDead = dateOfDead;
            newPolizavis.PlaceOfDead = placeOfDead;
            newPolizavis.DeathCertificate = deathCertificate;
            newPolizavis.CauseOfDead = causeOfDeat;
            newPolizavis.DeathCategory = deathCategory;
            newPolizavis.OpeningPlace = openingPlace;
            newPolizavis.HistoryOfParasucicides = historyOfParasucicides;
            newPolizavis.FeaturesOfObservation = featuresOfObservation;
            newPolizavis.ExperienceAbuse = experienceAbuse;
            newPolizavis.AlcoholicDrinks = AlcoholicDrinks;
            newPolizavis.DrugDiagnosisAlc = DrugDiagnosisAlc;
            newPolizavis.IntranozologicalComorbidity = intranozologicalComorbidity;
            newPolizavis.TypeOfDrug = typeOfDrug;
            newPolizavis.DrugUse = drugUse;
            newPolizavis.YearOfFirstUse = yearOfFirstUse;
            newPolizavis.ExperienceAbuseDrug = experienceAbuseDrug;
            newPolizavis.Remissions = remissions;
            newPolizavis.RemissionNumber = remissionNumber;
            newPolizavis.RemissionTimer = remissionTimer;
            newPolizavis.DrugDiagnosisX = drugDiagnosisX;
            newPolizavis.AgeOfDead = ageOfDead;
            newPolizavis.AgeOfRegistration = ageOfRegistration;
            newPolizavis.DataInfo = dataInfo;
            newPolizavis.Registrotor =Other.Regis.ToString();


            Alco_Narco_Person.Add(newPolizavis);

            Save_ExcelAlco_Narco_Person();
        }

        /// <summary>
        /// Сохранение Колекции в Excel полизависимые
        /// </summary>
        public static void Save_ExcelAlco_Narco_Person()
        {
            string ExcelFilePath = @"d:\HelaMedical\HelaMedical\File\PolizavisDataBase.xlsx";

            Excel.Application excelApp = new Excel.Application();
            Workbook workBook;
            Worksheet workSheet;
            workBook = excelApp.Workbooks.Open(ExcelFilePath);
            workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);

            // Получаем активную таблицу
            for (int i = 0; i < poliz_col + 1; i++)
            {
                if (i == poliz_col)
                {
                    workSheet.Cells[i, 1] = Alco_Narco_Person[0].Id;
                    workSheet.Cells[i, 2] = Alco_Narco_Person[0].FIO;
                    workSheet.Cells[i, 3] = Alco_Narco_Person[0].Sex;
                    workSheet.Cells[i, 4] = Alco_Narco_Person[0].Date;
                    workSheet.Cells[i, 5] = Alco_Narco_Person[0].RegionCenterBLR;
                    workSheet.Cells[i, 6] = Alco_Narco_Person[0].RaenCentrBLR;
                    workSheet.Cells[i, 7] = Alco_Narco_Person[0].Life;
                    workSheet.Cells[i, 8] = Alco_Narco_Person[0].Age;
                    workSheet.Cells[i, 9] = Alco_Narco_Person[0].FamilyStatus;
                    workSheet.Cells[i, 10] = Alco_Narco_Person[0].CostOfKids;
                    workSheet.Cells[i, 11] = Alco_Narco_Person[0].FamilyComposition;
                    workSheet.Cells[i, 12] = Alco_Narco_Person[0].Education;
                    workSheet.Cells[i, 13] = Alco_Narco_Person[0].Profession;
                    workSheet.Cells[i, 14] = Alco_Narco_Person[0].TheSkillLevelOfTheProfession;
                    workSheet.Cells[i, 15] = Alco_Narco_Person[0].AddressOfRegistration;
                    workSheet.Cells[i, 16] = Alco_Narco_Person[0].AddressAtTheTimeOfDeath;
                    workSheet.Cells[i, 17] = Alco_Narco_Person[0].DataOfRegistration;
                    workSheet.Cells[i, 18] = Alco_Narco_Person[0].ReRegistrationData;
                    workSheet.Cells[i, 19] = Alco_Narco_Person[0].TypeOfRegistration;
                    workSheet.Cells[i, 20] = Alco_Narco_Person[0].Heredity;
                    workSheet.Cells[i, 21] = Alco_Narco_Person[0].DisabilityGroup;
                    workSheet.Cells[i, 22] = Alco_Narco_Person[0].DisabilityStatus;
                    workSheet.Cells[i, 23] = Alco_Narco_Person[0].ReasonForDisability;
                    workSheet.Cells[i, 24] = Alco_Narco_Person[0].WorksStatus;
                    workSheet.Cells[i, 25] = Alco_Narco_Person[0].AdmOtv;
                    workSheet.Cells[i, 26] = Alco_Narco_Person[0].UgOtv;
                    workSheet.Cells[i, 27] = Alco_Narco_Person[0].DlitsMLS;
                    workSheet.Cells[i, 28] = Alco_Narco_Person[0].Stat107;
                    workSheet.Cells[i, 29] = Alco_Narco_Person[0].StatUKRB;
                    workSheet.Cells[i, 30] = Alco_Narco_Person[0].RodPrav;
                    workSheet.Cells[i, 31] = Alco_Narco_Person[0].NomLTP;
                    workSheet.Cells[i, 32] = Alco_Narco_Person[0].LTPKol;
                    workSheet.Cells[i, 33] = Alco_Narco_Person[0].Hospitel;
                    workSheet.Cells[i, 34] = Alco_Narco_Person[0].EK;
                    workSheet.Cells[i, 35] = Alco_Narco_Person[0].DateOfDeregistration;
                    workSheet.Cells[i, 36] = Alco_Narco_Person[0].DateOfDead;
                    workSheet.Cells[i, 37] = Alco_Narco_Person[0].PlaceOfDead;
                    workSheet.Cells[i, 38] = Alco_Narco_Person[0].DeathCertificate;
                    workSheet.Cells[i, 39] = Alco_Narco_Person[0].CauseOfDead;
                    workSheet.Cells[i, 40] = Alco_Narco_Person[0].DeathCategory;
                    workSheet.Cells[i, 41] = Alco_Narco_Person[0].OpeningPlace;
                    workSheet.Cells[i, 42] = Alco_Narco_Person[0].HistoryOfParasucicides;
                    workSheet.Cells[i, 43] = Alco_Narco_Person[0].FeaturesOfObservation;
                    workSheet.Cells[i, 44] = Alco_Narco_Person[0].ExperienceAbuse;
                    workSheet.Cells[i, 45] = Alco_Narco_Person[0].AlcoholicDrinks;
                    workSheet.Cells[i, 46] = Alco_Narco_Person[0].IK;
                    workSheet.Cells[i, 47] = Alco_Narco_Person[0].DrugDiagnosisAlc;
                    workSheet.Cells[i, 48] = Alco_Narco_Person[0].IntranozologicalComorbidity;
                    workSheet.Cells[i, 49] = Alco_Narco_Person[0].TypeOfDrug;
                    workSheet.Cells[i, 50] = Alco_Narco_Person[0].DrugUse;
                    workSheet.Cells[i, 51] = Alco_Narco_Person[0].YearOfFirstUse;
                    workSheet.Cells[i, 52] = Alco_Narco_Person[0].ExperienceAbuseDrug;
                    workSheet.Cells[i, 53] = Alco_Narco_Person[0].Remissions;
                    workSheet.Cells[i, 54] = Alco_Narco_Person[0].RemissionNumber;
                    workSheet.Cells[i, 55] = Alco_Narco_Person[0].RemissionTimer;
                    workSheet.Cells[i, 56] = Alco_Narco_Person[0].DrugDiagnosisX;
                    workSheet.Cells[i, 57] = Alco_Narco_Person[0].AgeOfRegistration;
                    workSheet.Cells[i, 58] = Alco_Narco_Person[0].AgeOfDead;
                    workSheet.Cells[i, 59] = Alco_Narco_Person[0].DataInfo;
                    workSheet.Cells[i, 60] = Alco_Narco_Person[0].Registrotor;
                }
            }
            workBook.Save();
            workBook.Close();
            excelApp.Quit();
        }

        /// <summary>
        /// запись данных по дате 
        /// </summary>
        /// <param name="col"></param>        
        public static void Save_Report_Excel_Poliz(int col)
        {
            try
            {
                bool check = false;
                string _col = Convert.ToString(col);
                polizs = new List<Polizavis>();
                for (int i = 0; i < Alco_Narco_Person.Count; i++)
                {
                    if (_col == Alco_Narco_Person[i].DataInfo)
                    {
                        polizs.Add(Alco_Narco_Person[i]);
                    }
                }

                string ExcelFilePath = @"d:\HelaMedical\HelaMedical\File\NarcoDataBaseByDate.xlsx";

                Excel.Application excelApp = new Excel.Application();
                Workbook workBook;
                Worksheet workSheet;
                workBook = excelApp.Workbooks.Open(ExcelFilePath);
                workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);

                // Получаем активную таблицу
                for (int i = 0; i <= polizs.Count; i++)
                {
                    workSheet.Cells[i, 1] = polizs[i].Id;
                    workSheet.Cells[i, 2] = polizs[i].FIO;
                    workSheet.Cells[i, 3] = polizs[i].Sex;
                    workSheet.Cells[i, 4] = polizs[i].Date;
                    workSheet.Cells[i, 5] = polizs[i].RegionCenterBLR;
                    workSheet.Cells[i, 6] = polizs[i].RaenCentrBLR;
                    workSheet.Cells[i, 7] = polizs[i].Life;
                    workSheet.Cells[i, 8] = polizs[i].Age;
                    workSheet.Cells[i, 9] = polizs[i].FamilyStatus;
                    workSheet.Cells[i, 10] = polizs[i].CostOfKids;
                    workSheet.Cells[i, 11] = polizs[i].FamilyComposition;
                    workSheet.Cells[i, 12] = polizs[i].Education;
                    workSheet.Cells[i, 13] = polizs[i].Profession;
                    workSheet.Cells[i, 14] = polizs[i].TheSkillLevelOfTheProfession;
                    workSheet.Cells[i, 15] = polizs[i].AddressOfRegistration;
                    workSheet.Cells[i, 16] = polizs[i].AddressAtTheTimeOfDeath;
                    workSheet.Cells[i, 17] = polizs[i].DataOfRegistration;
                    workSheet.Cells[i, 18] = polizs[i].ReRegistrationData;
                    workSheet.Cells[i, 19] = polizs[i].TypeOfRegistration;
                    workSheet.Cells[i, 20] = polizs[i].Heredity;
                    workSheet.Cells[i, 21] = polizs[i].DisabilityGroup;
                    workSheet.Cells[i, 22] = polizs[i].DisabilityStatus;
                    workSheet.Cells[i, 23] = polizs[i].ReasonForDisability;
                    workSheet.Cells[i, 24] = polizs[i].WorksStatus;
                    workSheet.Cells[i, 25] = polizs[i].AdmOtv;
                    workSheet.Cells[i, 26] = polizs[i].UgOtv;
                    workSheet.Cells[i, 27] = polizs[i].DlitsMLS;
                    workSheet.Cells[i, 28] = polizs[i].Stat107;
                    workSheet.Cells[i, 29] = polizs[i].StatUKRB;
                    workSheet.Cells[i, 30] = polizs[i].RodPrav;
                    workSheet.Cells[i, 31] = polizs[i].NomLTP;
                    workSheet.Cells[i, 32] = polizs[i].LTPKol;
                    workSheet.Cells[i, 33] = polizs[i].Hospitel;
                    workSheet.Cells[i, 34] = polizs[i].EK;
                    workSheet.Cells[i, 35] = polizs[i].DateOfDeregistration;
                    workSheet.Cells[i, 36] = polizs[i].DateOfDead;
                    workSheet.Cells[i, 37] = polizs[i].PlaceOfDead;
                    workSheet.Cells[i, 38] = polizs[i].DeathCertificate;
                    workSheet.Cells[i, 39] = polizs[i].CauseOfDead;
                    workSheet.Cells[i, 40] = polizs[i].DeathCategory;
                    workSheet.Cells[i, 41] = polizs[i].OpeningPlace;
                    workSheet.Cells[i, 42] = polizs[i].HistoryOfParasucicides;
                    workSheet.Cells[i, 43] = polizs[i].FeaturesOfObservation;
                    workSheet.Cells[i, 44] = polizs[i].ExperienceAbuse;
                    workSheet.Cells[i, 45] = polizs[i].AlcoholicDrinks;
                    workSheet.Cells[i, 46] = polizs[i].IK;
                    workSheet.Cells[i, 47] = polizs[i].DrugDiagnosisAlc;
                    workSheet.Cells[i, 48] = polizs[i].IntranozologicalComorbidity;
                    workSheet.Cells[i, 49] = polizs[i].TypeOfDrug;
                    workSheet.Cells[i, 50] = polizs[i].DrugUse;
                    workSheet.Cells[i, 51] = polizs[i].YearOfFirstUse;
                    workSheet.Cells[i, 52] = polizs[i].ExperienceAbuseDrug;
                    workSheet.Cells[i, 53] = polizs[i].Remissions;
                    workSheet.Cells[i, 54] = polizs[i].RemissionNumber;
                    workSheet.Cells[i, 55] = polizs[i].RemissionTimer;
                    workSheet.Cells[i, 56] = polizs[i].DrugDiagnosisX;
                    workSheet.Cells[i, 57] = polizs[i].AgeOfRegistration;
                    workSheet.Cells[i, 58] = polizs[i].AgeOfDead;
                    workSheet.Cells[i, 59] = polizs[i].DataInfo;
                    workSheet.Cells[i, 60] = polizs[i].Registrotor;
                }
                workBook.Save();
                workBook.Close();
                excelApp.Quit();
                check = true;
                if (check)
                {
                    MessageBox.Show("Успешно");
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
                Excel.Application excelApp = new Excel.Application();
                excelApp.Quit();
            }
        }

        /// <summary>
        /// Сохранение информации по выборке из отчета по полизависимости
        /// </summary>
        public static void Save_Report_Excel_Poliz()
        {
            int count = 0;
            for (int i = 0; i < poliz_col; i++)
                count++;
            if (count > 0)
            {
                string ExcelFilePath = @"D:\HelaMedical\HelaMedical\File\PolizavisReport.xlsx";

                Excel.Application excelApp = new Excel.Application();
                Workbook workBook;
                Worksheet workSheet;
                workBook = excelApp.Workbooks.Open(ExcelFilePath);
                workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);

                // Получаем активную таблицу
                for (int i = 1; i <= Alco_Narco_Person.Count; i++)
                {
                    int j = i - 1;
                    workSheet.Cells[i, 1] = Alco_Narco_Person[j].Id;
                    workSheet.Cells[i, 2] = Alco_Narco_Person[j].FIO;
                    workSheet.Cells[i, 3] = Alco_Narco_Person[j].Sex;
                    workSheet.Cells[i, 4] = Alco_Narco_Person[j].Date;
                    workSheet.Cells[i, 5] = Alco_Narco_Person[j].RegionCenterBLR;
                    workSheet.Cells[i, 6] = Alco_Narco_Person[j].RaenCentrBLR;
                    workSheet.Cells[i, 7] = Alco_Narco_Person[j].Life;
                    workSheet.Cells[i, 8] = Alco_Narco_Person[j].Age;
                    workSheet.Cells[i, 9] = Alco_Narco_Person[j].FamilyStatus;
                    workSheet.Cells[i, 10] = Alco_Narco_Person[j].CostOfKids;
                    workSheet.Cells[i, 11] = Alco_Narco_Person[j].FamilyComposition;
                    workSheet.Cells[i, 12] = Alco_Narco_Person[j].Education;
                    workSheet.Cells[i, 13] = Alco_Narco_Person[j].Profession;
                    workSheet.Cells[i, 14] = Alco_Narco_Person[j].TheSkillLevelOfTheProfession;
                    workSheet.Cells[i, 15] = Alco_Narco_Person[j].AddressOfRegistration;
                    workSheet.Cells[i, 16] = Alco_Narco_Person[j].AddressAtTheTimeOfDeath;
                    workSheet.Cells[i, 17] = Alco_Narco_Person[j].DataOfRegistration;
                    workSheet.Cells[i, 18] = Alco_Narco_Person[j].ReRegistrationData;
                    workSheet.Cells[i, 19] = Alco_Narco_Person[j].TypeOfRegistration;
                    workSheet.Cells[i, 20] = Alco_Narco_Person[j].Heredity;
                    workSheet.Cells[i, 21] = Alco_Narco_Person[j].DisabilityGroup;
                    workSheet.Cells[i, 22] = Alco_Narco_Person[j].DisabilityStatus;
                    workSheet.Cells[i, 23] = Alco_Narco_Person[j].ReasonForDisability;
                    workSheet.Cells[i, 24] = Alco_Narco_Person[j].WorksStatus;
                    workSheet.Cells[i, 25] = Alco_Narco_Person[j].AdmOtv;
                    workSheet.Cells[i, 26] = Alco_Narco_Person[j].UgOtv;
                    workSheet.Cells[i, 27] = Alco_Narco_Person[j].DlitsMLS;
                    workSheet.Cells[i, 28] = Alco_Narco_Person[j].Stat107;
                    workSheet.Cells[i, 29] = Alco_Narco_Person[j].StatUKRB;
                    workSheet.Cells[i, 30] = Alco_Narco_Person[j].RodPrav;
                    workSheet.Cells[i, 31] = Alco_Narco_Person[j].NomLTP;
                    workSheet.Cells[i, 32] = Alco_Narco_Person[j].LTPKol;
                    workSheet.Cells[i, 33] = Alco_Narco_Person[j].Hospitel;
                    workSheet.Cells[i, 34] = Alco_Narco_Person[j].EK;
                    workSheet.Cells[i, 35] = Alco_Narco_Person[j].DateOfDeregistration;
                    workSheet.Cells[i, 36] = Alco_Narco_Person[j].DateOfDead;
                    workSheet.Cells[i, 37] = Alco_Narco_Person[j].PlaceOfDead;
                    workSheet.Cells[i, 38] = Alco_Narco_Person[j].DeathCertificate;
                    workSheet.Cells[i, 39] = Alco_Narco_Person[j].CauseOfDead;
                    workSheet.Cells[i, 40] = Alco_Narco_Person[j].DeathCategory;
                    workSheet.Cells[i, 41] = Alco_Narco_Person[j].OpeningPlace;
                    workSheet.Cells[i, 42] = Alco_Narco_Person[j].HistoryOfParasucicides;
                    workSheet.Cells[i, 43] = Alco_Narco_Person[j].FeaturesOfObservation;
                    workSheet.Cells[i, 44] = Alco_Narco_Person[j].ExperienceAbuse;
                    workSheet.Cells[i, 45] = Alco_Narco_Person[j].AlcoholicDrinks;
                    workSheet.Cells[i, 46] = Alco_Narco_Person[j].IK;
                    workSheet.Cells[i, 47] = Alco_Narco_Person[j].DrugDiagnosisAlc;
                    workSheet.Cells[i, 48] = Alco_Narco_Person[j].IntranozologicalComorbidity;
                    workSheet.Cells[i, 49] = Alco_Narco_Person[j].TypeOfDrug;
                    workSheet.Cells[i, 50] = Alco_Narco_Person[j].DrugUse;
                    workSheet.Cells[i, 51] = Alco_Narco_Person[j].YearOfFirstUse;
                    workSheet.Cells[i, 52] = Alco_Narco_Person[j].ExperienceAbuseDrug;
                    workSheet.Cells[i, 53] = Alco_Narco_Person[j].Remissions;
                    workSheet.Cells[i, 54] = Alco_Narco_Person[j].RemissionNumber;
                    workSheet.Cells[i, 55] = Alco_Narco_Person[j].RemissionTimer;
                    workSheet.Cells[i, 56] = Alco_Narco_Person[j].DrugDiagnosisX;
                    workSheet.Cells[i, 57] = Alco_Narco_Person[j].AgeOfRegistration;
                    workSheet.Cells[i, 58] = Alco_Narco_Person[j].AgeOfDead;
                    workSheet.Cells[i, 59] = Alco_Narco_Person[j].DataInfo;
                    workSheet.Cells[i, 60] = Alco_Narco_Person[j].Registrotor;
                }
                workBook.Save();
                workBook.Close();
                excelApp.Quit();
            }
            else
            {
                MessageBox.Show("Нет информации для создания отчета!!! Сформируйте отчет для записи информации в файл");
            }
        }

        /// <summary>
        /// Способ посчитать все записи из Excel полизависимых
        /// </ summary>
        /// <Return> </ Return>
        public static void Reader_Excel_Alco_Narco_Person()
        {
            Polizavis.Alco_Narco_Person.Clear();
            poliz_col = 0;
            string ExcelFilePath = @"d:\HelaMedical\HelaMedical\File\PolizavisDataBase.xlsx";
            Excel.Application excelApp = new Excel.Application();
            Workbook workBook;
            Worksheet workSheet;
            Range range;
            workBook = excelApp.Workbooks.Open(ExcelFilePath);
            workSheet = (Worksheet)workBook.Worksheets.get_Item(1);
            range = workSheet.UsedRange;
            for (int cCnt = 0; cCnt <= range.Rows.Count; cCnt++)
            {
                poliz_col++;
            }
            workBook.Close();
            excelApp.Quit();
        }

        /// <summary>
        /// Считывать фаил по полизависимости
        /// </summary>
        public static void Read_Poliz()
        {
            Polizavis.Alco_Narco_Person.Clear();
            poliz_col = 0;
            string ExcelFilePath = @"d:\HelaMedical\HelaMedical\File\PolizavisDataBase.xlsx";
            Excel.Application excelApp = new Excel.Application();
            Workbook workBook;
            Worksheet workSheet;
            Range range;
            workBook = excelApp.Workbooks.Open(ExcelFilePath);
            workSheet = (Worksheet)workBook.Worksheets.get_Item(1);
            range = workSheet.UsedRange;
            for (int cCnt = 1; cCnt <= range.Rows.Count; cCnt++)
            {
                Polizavis polizavis = new Polizavis
                {
                    Id = Convert.ToString(workSheet.Cells[cCnt, 1].Value),
                    FIO = Convert.ToString(workSheet.Cells[cCnt, 2].Value),
                    Sex = Convert.ToString(workSheet.Cells[cCnt, 3].Value),
                    Date = Convert.ToString(workSheet.Cells[cCnt, 4].Value),
                    RegionCenterBLR = Convert.ToString(workSheet.Cells[cCnt, 5].Value),
                    RaenCentrBLR = Convert.ToString(workSheet.Cells[cCnt, 6].Value),
                    Life = Convert.ToString(workSheet.Cells[cCnt, 7].Value),
                    Age = Convert.ToString(workSheet.Cells[cCnt, 8].Value),
                    FamilyStatus = Convert.ToString(workSheet.Cells[cCnt, 9].Value),
                    CostOfKids = Convert.ToString(workSheet.Cells[cCnt, 10].Value),
                    FamilyComposition = Convert.ToString(workSheet.Cells[cCnt, 11].Value),
                    Education = Convert.ToString(workSheet.Cells[cCnt, 12].Value),
                    Profession = Convert.ToString(workSheet.Cells[cCnt, 13].Value),
                    TheSkillLevelOfTheProfession = Convert.ToString(workSheet.Cells[cCnt, 14].Value),
                    AddressOfRegistration = Convert.ToString(workSheet.Cells[cCnt, 15].Value),
                    AddressAtTheTimeOfDeath = Convert.ToString(workSheet.Cells[cCnt, 16].Value),
                    DataOfRegistration = Convert.ToString(workSheet.Cells[cCnt, 17].Value),
                    ReRegistrationData = Convert.ToString(workSheet.Cells[cCnt, 18].Value),
                    TypeOfRegistration = Convert.ToString(workSheet.Cells[cCnt, 19].Value),
                    Heredity = Convert.ToString(workSheet.Cells[cCnt, 20].Value),
                    DisabilityGroup = Convert.ToString(workSheet.Cells[cCnt, 21].Value),
                    DisabilityStatus = Convert.ToString(workSheet.Cells[cCnt, 22].Value),
                    ReasonForDisability = Convert.ToString(workSheet.Cells[cCnt, 23].Value),
                    WorksStatus = Convert.ToString(workSheet.Cells[cCnt, 24].Value),
                    AdmOtv = Convert.ToString(workSheet.Cells[cCnt, 25].Value),
                    UgOtv = Convert.ToString(workSheet.Cells[cCnt, 26].Value),
                    DlitsMLS = Convert.ToString(workSheet.Cells[cCnt, 27].Value),
                    Stat107 = Convert.ToString(workSheet.Cells[cCnt, 28].Value),
                    StatUKRB = Convert.ToString(workSheet.Cells[cCnt, 29].Value),
                    RodPrav = Convert.ToString(workSheet.Cells[cCnt, 30].Value),
                    NomLTP = Convert.ToString(workSheet.Cells[cCnt, 31].Value),
                    LTPKol = Convert.ToString(workSheet.Cells[cCnt, 32].Value),
                    Hospitel = Convert.ToString(workSheet.Cells[cCnt, 33].Value),
                    EK = Convert.ToString(workSheet.Cells[cCnt, 34].Value),
                    DateOfDeregistration = Convert.ToString(workSheet.Cells[cCnt, 35].Value),
                    DateOfDead = Convert.ToString(workSheet.Cells[cCnt, 36].Value),
                    PlaceOfDead = Convert.ToString(workSheet.Cells[cCnt, 37].Value),
                    DeathCertificate = Convert.ToString(workSheet.Cells[cCnt, 38].Value),
                    CauseOfDead = Convert.ToString(workSheet.Cells[cCnt, 39].Value),
                    DeathCategory = Convert.ToString(workSheet.Cells[cCnt, 40].Value),
                    OpeningPlace = Convert.ToString(workSheet.Cells[cCnt, 41].Value),
                    HistoryOfParasucicides = Convert.ToString(workSheet.Cells[cCnt, 42].Value),
                    FeaturesOfObservation = Convert.ToString(workSheet.Cells[cCnt, 43].Value),
                    ExperienceAbuse = Convert.ToString(workSheet.Cells[cCnt, 44].Value),
                    AlcoholicDrinks = Convert.ToString(workSheet.Cells[cCnt, 45].Value),
                    IK = Convert.ToString(workSheet.Cells[cCnt, 46].Value),
                    DrugDiagnosisAlc = Convert.ToString(workSheet.Cells[cCnt, 47].Value),
                    IntranozologicalComorbidity = Convert.ToString(workSheet.Cells[cCnt, 48].Value),
                    TypeOfDrug = Convert.ToString(workSheet.Cells[cCnt, 49].Value),
                    DrugUse = Convert.ToString(workSheet.Cells[cCnt, 50].Value),
                    YearOfFirstUse = Convert.ToString(workSheet.Cells[cCnt, 51].Value),
                    ExperienceAbuseDrug = Convert.ToString(workSheet.Cells[cCnt, 52].Value),
                    Remissions = Convert.ToString(workSheet.Cells[cCnt, 53].Value),
                    RemissionNumber = Convert.ToString(workSheet.Cells[cCnt, 54].Value),
                    RemissionTimer = Convert.ToString(workSheet.Cells[cCnt, 55].Value),
                    DrugDiagnosisX = Convert.ToString(workSheet.Cells[cCnt, 56].Value),
                    AgeOfRegistration = Convert.ToString(workSheet.Cells[cCnt, 57].Value),
                    AgeOfDead = Convert.ToString(workSheet.Cells[cCnt, 58].Value),
                    DataInfo = Convert.ToString(workSheet.Cells[cCnt, 59].Value),
                    Registrotor = Convert.ToString(workSheet.Cells[cCnt, 60].Value)
                };
                Alco_Narco_Person.Add(polizavis);
                poliz_col++;
            }
            workBook.Close();
            excelApp.Quit();
        }

 
    }
}

