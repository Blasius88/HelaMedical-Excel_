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
        //Считаем алкашей
        public static int alco_col = 0;
        //Считаем наркотов 
        public static int narco_col = 0;
        //Считаем полизавис
        public static int poliz_col = 0;

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
                newAlcoPerson.Id = a;
            }
            else
            {
                newAlcoPerson.Id = alco_col-1;

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

        //Сохранение колекции по алко по дате 
        public static void Save_Report_Excel_Alco(List<Alco> alcos, int col)
        {
            try
            {
                string ExcelFilePath = @"d:\HelaMedical\HelaMedical\File\AlcoDataBaseByDate.xlsx";

                Excel.Application excelApp = new Excel.Application();
                Workbook workBook;
                Worksheet workSheet;
                workBook = excelApp.Workbooks.Open(ExcelFilePath);
                workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);

                // Получаем активную таблицу
                for (int i = 0; i < col+1; i++)
                {
                    workSheet.Cells[i, 1] = alcos[i].Id;
                    workSheet.Cells[i, 2] = alcos[i].FIO;
                    workSheet.Cells[i, 3] = alcos[i].Sex;
                    workSheet.Cells[i, 4] = alcos[i].Date;
                    workSheet.Cells[i, 5] = alcos[i].RegionCenterBLR;
                    workSheet.Cells[i, 6] = alcos[i].RaenCenterBLR;
                    workSheet.Cells[i, 7] = alcos[i].Life;
                    workSheet.Cells[i, 8] = alcos[i].Age;
                    workSheet.Cells[i, 9] = alcos[i].FamilyStatus;
                    workSheet.Cells[i, 10] = alcos[i].CostOfKids;
                    workSheet.Cells[i, 11] = alcos[i].FamilyComposition;
                    workSheet.Cells[i, 12] = alcos[i].Education;
                    workSheet.Cells[i, 13] = alcos[i].Profession;
                    workSheet.Cells[i, 14] = alcos[i].TheSkillLevelOfTheProfession;
                    workSheet.Cells[i, 15] = alcos[i].AddressOfRegistration;
                    workSheet.Cells[i, 16] = alcos[i].AddressAtTheTimeOfDeath;
                    workSheet.Cells[i, 17] = alcos[i].DataOfRegistration;
                    workSheet.Cells[i, 18] = alcos[i].ReRegistrationData;
                    workSheet.Cells[i, 19] = alcos[i].TypeOfRegistration;
                    workSheet.Cells[i, 20] = alcos[i].Heredity;
                    workSheet.Cells[i, 21] = alcos[i].DisabilityGroup;
                    workSheet.Cells[i, 22] = alcos[i].DisabilityStatus;
                    workSheet.Cells[i, 23] = alcos[i].ReasonForDisability;
                    workSheet.Cells[i, 24] = alcos[i].WorksStatus;
                    workSheet.Cells[i, 25] = alcos[i].AdmOtv;
                    workSheet.Cells[i, 26] = alcos[i].UgOtv;
                    workSheet.Cells[i, 27] = alcos[i].DlitsMLS;
                    workSheet.Cells[i, 28] = alcos[i].Stat107;
                    workSheet.Cells[i, 29] = alcos[i].StatUKRB;
                    workSheet.Cells[i, 30] = alcos[i].RodPrav;
                    workSheet.Cells[i, 31] = alcos[i].NomLTP;
                    workSheet.Cells[i, 32] = alcos[i].LTPKol;
                    workSheet.Cells[i, 33] = alcos[i].Hospitel;
                    workSheet.Cells[i, 34] = alcos[i].EK;
                    workSheet.Cells[i, 35] = alcos[i].DateOfDeregistration;
                    workSheet.Cells[i, 36] = alcos[i].DateOfDead;
                    workSheet.Cells[i, 37] = alcos[i].PlaceOfDead;
                    workSheet.Cells[i, 38] = alcos[i].DeathCertificate;
                    workSheet.Cells[i, 39] = alcos[i].CauseOfDead;
                    workSheet.Cells[i, 40] = alcos[i].DeathCategory;
                    workSheet.Cells[i, 41] = alcos[i].OpeningPlace;
                    workSheet.Cells[i, 42] = alcos[i].HistoryOfParasucicides;
                    workSheet.Cells[i, 43] = alcos[i].FeaturesOfObservation;
                    workSheet.Cells[i, 44] = alcos[i].ExperienceAbuse;
                    workSheet.Cells[i, 45] = alcos[i].AlcoholicDrinks;
                    workSheet.Cells[i, 46] = alcos[i].IK;
                    workSheet.Cells[i, 47] = alcos[i].DrugDiagnosisAlc;
                    workSheet.Cells[i, 48] = alcos[i].AgeOfRegistration;
                    workSheet.Cells[i, 49] = alcos[i].AgeOfDead;
                    workSheet.Cells[i, 50] = alcos[i].DataInfo;
                    workSheet.Cells[i, 51] = alcos[i].Registrotor;
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
            if (narco_col == 1) newNarcoPerson.Id = 1;
            newNarcoPerson.Id = narco_col - 1;

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


        //Сохранение колекции по алко по дате 
        public static void Save_Report_Excel_Narco(List<Narcoman> narcos, int col)
        {
            try
            {
                string ExcelFilePath = @"d:\HelaMedical\HelaMedical\File\NarcoDataBaseByDate.xlsx";

                Excel.Application excelApp = new Excel.Application();
                Workbook workBook;
                Worksheet workSheet;
                workBook = excelApp.Workbooks.Open(ExcelFilePath);
                workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);

                // Получаем активную таблицу
                for (int i = 0; i < col + 1; i++)
                {
                    workSheet.Cells[i, 1] = narcos[i].Id;
                    workSheet.Cells[i, 2] = narcos[i].FIO;
                    workSheet.Cells[i, 3] = narcos[i].Sex;
                    workSheet.Cells[i, 4] = narcos[i].Date;
                    workSheet.Cells[i, 5] = narcos[i].RegionCenterBLR;
                    workSheet.Cells[i, 6] = narcos[i].RaenCenterBLR;
                    workSheet.Cells[i, 7] = narcos[i].Life;
                    workSheet.Cells[i, 8] = narcos[i].Age;
                    workSheet.Cells[i, 9] = narcos[i].FamilyStatus;
                    workSheet.Cells[i, 10] = narcos[i].CostOfKids;
                    workSheet.Cells[i, 11] = narcos[i].FamilyComposition;
                    workSheet.Cells[i, 12] = narcos[i].Education;
                    workSheet.Cells[i, 13] = narcos[i].Profession;
                    workSheet.Cells[i, 14] = narcos[i].TheSkillLevelOfTheProfession;
                    workSheet.Cells[i, 15] = narcos[i].AddressOfRegistration;
                    workSheet.Cells[i, 16] = narcos[i].AddressAtTheTimeOfDeath;
                    workSheet.Cells[i, 17] = narcos[i].DataOfRegistration;
                    workSheet.Cells[i, 18] = narcos[i].ReRegistrationData;
                    workSheet.Cells[i, 19] = narcos[i].TypeOfRegistration;
                    workSheet.Cells[i, 20] = narcos[i].Heredity;
                    workSheet.Cells[i, 21] = narcos[i].DisabilityGroup;
                    workSheet.Cells[i, 22] = narcos[i].DisabilityStatus;
                    workSheet.Cells[i, 23] = narcos[i].ReasonForDisability;
                    workSheet.Cells[i, 24] = narcos[i].WorksStatus;
                    workSheet.Cells[i, 25] = narcos[i].AdmOtv;
                    workSheet.Cells[i, 26] = narcos[i].UgOtv;
                    workSheet.Cells[i, 27] = narcos[i].DlitsMLS;
                    workSheet.Cells[i, 28] = narcos[i].Stat107;
                    workSheet.Cells[i, 29] = narcos[i].StatUKRB;
                    workSheet.Cells[i, 30] = narcos[i].RodPrav;
                    workSheet.Cells[i, 31] = narcos[i].NomLTP;
                    workSheet.Cells[i, 32] = narcos[i].LTPKol;
                    workSheet.Cells[i, 33] = narcos[i].Hospitel;
                    workSheet.Cells[i, 34] = narcos[i].EK;
                    workSheet.Cells[i, 35] = narcos[i].DateOfDeregistration;
                    workSheet.Cells[i, 36] = narcos[i].DateOfDead;
                    workSheet.Cells[i, 37] = narcos[i].PlaceOfDead;
                    workSheet.Cells[i, 38] = narcos[i].DeathCertificate;
                    workSheet.Cells[i, 39] = narcos[i].CauseOfDead;
                    workSheet.Cells[i, 40] = narcos[i].DeathCategory;
                    workSheet.Cells[i, 41] = narcos[i].OpeningPlace;
                    workSheet.Cells[i, 42] = narcos[i].HistoryOfParasucicides;
                    workSheet.Cells[i, 43] = narcos[i].FeaturesOfObservation;
                    workSheet.Cells[i, 44] = narcos[i].IntranozologicalComorbidity;
                    workSheet.Cells[i, 45] = narcos[i].TypeOfDrug;
                    workSheet.Cells[i, 46] = narcos[i].DrugUse;
                    workSheet.Cells[i, 47] = narcos[i].YearOfFirstUse;
                    workSheet.Cells[i, 48] = narcos[i].ExperienceAbuseDrug;
                    workSheet.Cells[i, 49] = narcos[i].Remissions;
                    workSheet.Cells[i, 50] = narcos[i].RemissionNumber;
                    workSheet.Cells[i, 51] = narcos[i].RemissionTimer;
                    workSheet.Cells[i, 52] = narcos[i].DrugDiagnosisX;
                    workSheet.Cells[i, 53] = narcos[i].AgeOfRegistration;
                    workSheet.Cells[i, 54] = narcos[i].AgeOfDead;
                    workSheet.Cells[i, 55] = narcos[i].DataInfo;
                    workSheet.Cells[i, 56] = narcos[i].Registrotor;
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
            if (poliz_col == 1) newPolizavis.Id = 1;

            newPolizavis.Id = poliz_col-1;

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

        //запись данных по выбору 
        public static void Save_Report_Excel_Poliz(List<Polizavis> poliz, int col)
        {
            try
            {
                string ExcelFilePath = @"d:\HelaMedical\HelaMedical\File\NarcoDataBaseByDate.xlsx";

                Excel.Application excelApp = new Excel.Application();
                Workbook workBook;
                Worksheet workSheet;
                workBook = excelApp.Workbooks.Open(ExcelFilePath);
                workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);

                // Получаем активную таблицу
                for (int i = 0; i < col + 1; i++)
                {
                    workSheet.Cells[i, 1] = poliz[i].Id;
                    workSheet.Cells[i, 2] = poliz[i].FIO;
                    workSheet.Cells[i, 3] = poliz[i].Sex;
                    workSheet.Cells[i, 4] = poliz[i].Date;
                    workSheet.Cells[i, 5] = poliz[i].RegionCenterBLR;
                    workSheet.Cells[i, 6] = poliz[i].RaenCentrBLR;
                    workSheet.Cells[i, 7] = poliz[i].Life;
                    workSheet.Cells[i, 8] = poliz[i].Age;
                    workSheet.Cells[i, 9] = poliz[i].FamilyStatus;
                    workSheet.Cells[i, 10] = poliz[i].CostOfKids;
                    workSheet.Cells[i, 11] = poliz[i].FamilyComposition;
                    workSheet.Cells[i, 12] = poliz[i].Education;
                    workSheet.Cells[i, 13] = poliz[i].Profession;
                    workSheet.Cells[i, 14] = poliz[i].TheSkillLevelOfTheProfession;
                    workSheet.Cells[i, 15] = poliz[i].AddressOfRegistration;
                    workSheet.Cells[i, 16] = poliz[i].AddressAtTheTimeOfDeath;
                    workSheet.Cells[i, 17] = poliz[i].DataOfRegistration;
                    workSheet.Cells[i, 18] = poliz[i].ReRegistrationData;
                    workSheet.Cells[i, 19] = poliz[i].TypeOfRegistration;
                    workSheet.Cells[i, 20] = poliz[i].Heredity;
                    workSheet.Cells[i, 21] = poliz[i].DisabilityGroup;
                    workSheet.Cells[i, 22] = poliz[i].DisabilityStatus;
                    workSheet.Cells[i, 23] = poliz[i].ReasonForDisability;
                    workSheet.Cells[i, 24] = poliz[i].WorksStatus;
                    workSheet.Cells[i, 25] = poliz[i].AdmOtv;
                    workSheet.Cells[i, 26] = poliz[i].UgOtv;
                    workSheet.Cells[i, 27] = poliz[i].DlitsMLS;
                    workSheet.Cells[i, 28] = poliz[i].Stat107;
                    workSheet.Cells[i, 29] = poliz[i].StatUKRB;
                    workSheet.Cells[i, 30] = poliz[i].RodPrav;
                    workSheet.Cells[i, 31] = poliz[i].NomLTP;
                    workSheet.Cells[i, 32] = poliz[i].LTPKol;
                    workSheet.Cells[i, 33] = poliz[i].Hospitel;
                    workSheet.Cells[i, 34] = poliz[i].EK;
                    workSheet.Cells[i, 35] = poliz[i].DateOfDeregistration;
                    workSheet.Cells[i, 36] = poliz[i].DateOfDead;
                    workSheet.Cells[i, 37] = poliz[i].PlaceOfDead;
                    workSheet.Cells[i, 38] = poliz[i].DeathCertificate;
                    workSheet.Cells[i, 39] = poliz[i].CauseOfDead;
                    workSheet.Cells[i, 40] = poliz[i].DeathCategory;
                    workSheet.Cells[i, 41] = poliz[i].OpeningPlace;
                    workSheet.Cells[i, 42] = poliz[i].HistoryOfParasucicides;
                    workSheet.Cells[i, 43] = poliz[i].FeaturesOfObservation;
                    workSheet.Cells[i, 44] = poliz[i].ExperienceAbuse;
                    workSheet.Cells[i, 45] = poliz[i].AlcoholicDrinks;
                    workSheet.Cells[i, 46] = poliz[i].IK;
                    workSheet.Cells[i, 47] = poliz[i].DrugDiagnosisAlc;
                    workSheet.Cells[i, 48] = poliz[i].IntranozologicalComorbidity;
                    workSheet.Cells[i, 49] = poliz[i].TypeOfDrug;
                    workSheet.Cells[i, 50] = poliz[i].DrugUse;
                    workSheet.Cells[i, 51] = poliz[i].YearOfFirstUse;
                    workSheet.Cells[i, 52] = poliz[i].ExperienceAbuseDrug;
                    workSheet.Cells[i, 53] = poliz[i].Remissions;
                    workSheet.Cells[i, 54] = poliz[i].RemissionNumber;
                    workSheet.Cells[i, 55] = poliz[i].RemissionTimer;
                    workSheet.Cells[i, 56] = poliz[i].DrugDiagnosisX;
                    workSheet.Cells[i, 57] = poliz[i].AgeOfRegistration;
                    workSheet.Cells[i, 58] = poliz[i].AgeOfDead;
                    workSheet.Cells[i, 59] = poliz[i].DataInfo;
                    workSheet.Cells[i, 60] = poliz[i].Registrotor;
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
        /// Способ получить все записи из Excel полизависимых
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

      }
}

