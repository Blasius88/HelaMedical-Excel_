using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using HelaMedical.Class;
using HelaMedical.Excep;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace HelaMedical
{
    public class ReadPerson
    {
        /// <summary>
        /// Добавляем в массив данных по персонал
        /// </summary>
        public static void Patient_Сreation_Person(string fio, string pass, string position)
        {
            try
            {
                Person newPerson = new Person();
                if (Person.Persons.Count == 0)
                {
                    int a = 1;
                    newPerson.Id = a;
                }
                for (int i = 0; i <= Person.Persons.Count; i++)
                {
                    newPerson.Id = i + 1;

                }
                newPerson.FIO = fio;
                newPerson.Pass = pass;
                newPerson.Position = position;

                Person.Persons.Add(newPerson);

                Save_Excel_Person();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
            }
        }

        /// <summary>
        /// Сохранение Колекции в Excel персонал
        /// </summary>
        public static void Save_Excel_Person()
        {
            try
            {
                string ExcelFilePath = @"D:\HelaMedical\HelaMedical\File\Person.xlsx";

                Excel.Application excelApp = new Excel.Application();
                Workbook workBook;
                Worksheet workSheet;
                workBook = excelApp.Workbooks.Open(ExcelFilePath);
                workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);

                // Получаем активную таблицу
                for (int i = 0; i < Person.Persons.Count + 1; i++)
                {
                    if (i == Person.Persons.Count)
                    {
                        int j = i-1;
                        workSheet.Cells[i, 1] = Person.Persons[j].Id;
                        workSheet.Cells[i, 2] = Person.Persons[j].FIO;
                        workSheet.Cells[i, 3] = Person.Persons[j].Pass;
                        workSheet.Cells[i, 4] = Person.Persons[j].Position;
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
            }
        }

        /// <summary>
        /// Способ получить все записи из Excel персоналу
        /// </ summary>
        /// <Return> </ Return>
        public static void Reader_Excel_Person()
        {
            try
            {
                string ExcelFilePath = @"D:\HelaMedical\HelaMedical\File\Person.xlsx";
                Excel.Application excelApp = new Excel.Application();
                Workbook workBook;
                Worksheet workSheet;
                Range range;
                workBook = excelApp.Workbooks.Open(ExcelFilePath);
                workSheet = (Worksheet)workBook.Worksheets.get_Item(1);
                range = workSheet.UsedRange;
                for (int cCnt = 1; cCnt <= range.Rows.Count; cCnt++)
                {
                    Person persons = new Person();
                    persons.Id = Convert.ToInt32(workSheet.Cells[cCnt, 1].Value);
                    persons.FIO = Convert.ToString(workSheet.Cells[cCnt, 2].Value);
                    persons.Pass = Convert.ToString(workSheet.Cells[cCnt, 3].Value);
                    persons.Position = Convert.ToString(workSheet.Cells[cCnt, 4].Value);

                    Person.Persons.Add(persons);
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
    }
}
