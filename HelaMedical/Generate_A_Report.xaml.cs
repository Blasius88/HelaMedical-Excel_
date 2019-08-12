using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Windows;
using System.Windows.Controls;
using HelaMedical.Class;
using HelaMedical.Excep;
using HelaMedical.Logic;

namespace HelaMedical
{
    /// <summary>
    /// Логика взаимодействия для Generate_A_Report.xaml
    /// </summary>
    public partial class Generate_A_Report : Window
    {
        public string _typeOfAddiction = "";
        public string _regionCenterBLR = "";
        public string _sex = "";
        public string _familyStatus = "";
        public string _costOfKids = "";
        public string _familyComposition = "";
        public string _education = "";
        public string _periodS = "";
        public string _periodPo = "";

        public static List<Alco> alco = new List<Alco>();

        public static List<Narcoman> narco = new List<Narcoman>();

        public static List<Polizavis> poliz = new List<Polizavis>();

        public Generate_A_Report()
        {
            InitializeComponent();
            this.Closing += Generate_A_Report_Closing;

        }

        /// <summary>
        /// Закрытие окна
        /// </summary>
        private void Generate_A_Report_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
            }
        }

        /// <summary>
        /// Преводим из бд в список 
        /// </summary>
        public void Generate_List_Alco()
        {
            try
            {
                ExcelServis.Read_Alco();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
            }
        }

        /// <summary>
        /// Преводим из бд в список 
        /// </summary>
        public void Generate_List_Narco()
        {
            try
            {
                ExcelServis.Read_Narco();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
            }
        }

        /// <summary>
        /// Преводим из бд в список 
        /// </summary>
        public void Generate_List_Poliz()
        {
            try
            {
                ExcelServis.Read_Poliz();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
            }
        }

        /// <summary>
        /// Создать отчет в DataGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int count = 0;

                string typeOfAddiction = TypeOfAddiction.Text;
                string regionCenterBLR = RegionCenterBLR.Text;
                string sex = Sex.Text;
                string familyStatus = FamilyStatus.Text;
                string costOfKids = CostOfKids.Text;
                string familyComposition = FamilyComposition.Text;
                string education = Education.Text;
                string periodS = PeriodS.Text;
                string periodPo = PeriodPo.Text;

                if (typeOfAddiction == "")
                {
                    MessageBox.Show("Выберите тип зависимости");
                    return;
                }

                if (typeOfAddiction != "") count++;

                if (regionCenterBLR != "") count++;

                if (sex != "") count++;

                if (familyStatus != "") count++;

                if (costOfKids != "") count++;

                if (familyComposition != "") count++;

                if (education != "") count++;

                if (periodS != "") count++;

                if (periodPo != "") count++;

                if (count == 1) One_Params(typeOfAddiction);

                else if (count == 2) Two_Params(typeOfAddiction, regionCenterBLR, sex, familyStatus, costOfKids, familyComposition, education, periodS, periodPo);

                else if (count == 3) Three_Params(typeOfAddiction, regionCenterBLR, sex, familyStatus, costOfKids, familyComposition, education, periodS, periodPo);

                else if (count == 4) Four_Params(typeOfAddiction, regionCenterBLR, sex, familyStatus, costOfKids, familyComposition, education, periodS, periodPo);

                else if (count == 5) Five_Params(typeOfAddiction, regionCenterBLR, sex, familyStatus, costOfKids, familyComposition, education, periodS, periodPo);

                else if (count == 6) Six_Params(typeOfAddiction, regionCenterBLR, sex, familyStatus, costOfKids, familyComposition, education, periodS, periodPo);

                else if (count == 7) Seven_Params(typeOfAddiction, regionCenterBLR, sex, familyStatus, costOfKids, familyComposition, education, periodS, periodPo);

                else if (count == 8) Eight_Params(typeOfAddiction, regionCenterBLR, sex, familyStatus, costOfKids, familyComposition, education, periodS, periodPo);

                else if (count == 9) Nine_Params(typeOfAddiction, regionCenterBLR, sex, familyStatus, costOfKids, familyComposition, education, periodS, periodPo);
            }

            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
            }
        }

        /// <summary>
        /// Передает 1 параметр
        /// </summary>
        public void One_Params(string typeOfAddiction)
        {
            _typeOfAddiction = typeOfAddiction;
            LogicaOne logicaOne = new LogicaOne();
            logicaOne.DataGridFormat(_typeOfAddiction);
        }

        /// <summary>
        /// Передает 2 параметра 
        /// </summary>
        /// <param name="typeOfAddiction"></param>
        /// <param name="regionCenterBLR"></param>
        /// <param name="sex"></param>
        /// <param name="familyStatus"></param>
        /// <param name="costOfKids"></param>
        /// <param name="familyComposition"></param>
        /// <param name="education"></param>
        /// <param name="periodS"></param>
        /// <param name="periodPo"></param>
        public void Two_Params(string typeOfAddiction, string regionCenterBLR, string sex, string familyStatus, string costOfKids, string familyComposition, string education, string periodS, string periodPo)
        {
            if (typeOfAddiction != "" && regionCenterBLR != "" && sex == "" && familyStatus == ""
            && costOfKids == "" && familyComposition == "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _regionCenterBLR);

            }
            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex != "" && familyStatus == ""
            && costOfKids == "" && familyComposition == "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _sex = sex;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _sex);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus != ""
            && costOfKids == "" && familyComposition == "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _familyStatus = familyStatus;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _familyStatus);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids != "" && familyComposition == "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _costOfKids = costOfKids;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _costOfKids);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids == "" && familyComposition != "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _familyComposition = familyComposition;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _familyComposition);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids == "" && familyComposition == "" && education != "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _education = education;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _education);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids == "" && familyComposition == "" && education == "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _periodS = periodS;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids == "" && familyComposition == "" && education == "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _periodPo = periodPo;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _periodPo);
            }
        }

        /// <summary>
        /// Передает 3 параметра 
        /// </summary>
        /// <param name="typeOfAddiction"></param>
        /// <param name="regionCenterBLR"></param>
        /// <param name="sex"></param>
        /// <param name="familyStatus"></param>
        /// <param name="costOfKids"></param>
        /// <param name="familyComposition"></param>
        /// <param name="education"></param>
        /// <param name="periodS"></param>
        /// <param name="periodPo"></param>
        public void Three_Params(string typeOfAddiction, string regionCenterBLR, string sex, string familyStatus, string costOfKids, string familyComposition, string education, string periodS, string periodPo)
        {
            //-------------------------------
            //тип зависимости
            //--------------------------------------------------------------------------------------------------------
            if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus == ""
                   && costOfKids == "" && familyComposition == "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex == "" && familyStatus != ""
            && costOfKids == "" && familyComposition == "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _familyStatus = familyStatus;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _regionCenterBLR, _familyStatus);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex == "" && familyStatus == ""
            && costOfKids != "" && familyComposition == "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _costOfKids = costOfKids;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _regionCenterBLR, _costOfKids);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex == "" && familyStatus == ""
            && costOfKids == "" && familyComposition != "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _familyComposition = familyComposition;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _regionCenterBLR, _familyComposition);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex == "" && familyStatus == ""
            && costOfKids == "" && familyComposition == "" && education != "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _education = education;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _regionCenterBLR, _education);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex == "" && familyStatus == ""
            && costOfKids == "" && familyComposition == "" && education == "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _periodS = periodS;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _regionCenterBLR, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex == "" && familyStatus == ""
            && costOfKids == "" && familyComposition == "" && education == "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _periodPo = periodPo;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _regionCenterBLR, _periodPo);
            }
            //------------------------------------------------------------------
            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex != "" && familyStatus != ""
            && costOfKids == "" && familyComposition == "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _sex = sex;
                _familyStatus = familyStatus;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _sex, _familyStatus);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex != "" && familyStatus == ""
            && costOfKids != "" && familyComposition == "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _sex = sex;
                _costOfKids = costOfKids;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _sex, _costOfKids);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex != "" && familyStatus == ""
            && costOfKids == "" && familyComposition != "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _sex = sex;
                _familyComposition = familyComposition;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _sex, _familyComposition);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex != "" && familyStatus == ""
            && costOfKids == "" && familyComposition == "" && education != "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _sex = sex;
                _education = education;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _sex, _education);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex != "" && familyStatus == ""
            && costOfKids == "" && familyComposition == "" && education == "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _sex = sex;
                _periodS = periodS;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _sex, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex != "" && familyStatus == ""
            && costOfKids == "" && familyComposition == "" && education == "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _sex = sex;
                _periodPo = periodPo;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _sex, _periodPo);
            }
            //---------------------------------------------------------------------------------------------------------
            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus != ""
            && costOfKids != "" && familyComposition == "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _familyStatus, _costOfKids);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus != ""
            && costOfKids == "" && familyComposition != "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _familyStatus = familyStatus;
                _familyComposition = familyComposition;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _familyStatus, _familyComposition);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus != ""
            && costOfKids == "" && familyComposition == "" && education != "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _familyStatus = familyStatus;
                _education = education;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _familyStatus, _education);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus != ""
            && costOfKids == "" && familyComposition == "" && education == "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _familyStatus = familyStatus;
                _periodS = periodS;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _familyStatus, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus != ""
            && costOfKids == "" && familyComposition == "" && education == "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _familyStatus = familyStatus;
                _periodPo = periodPo;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _familyStatus, _periodPo);
            }
            //----------------------------------------------------------------------------------------------------------
            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids != "" && familyComposition != "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _costOfKids, _familyComposition);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids != "" && familyComposition == "" && education != "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _costOfKids = costOfKids;
                _education = education;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _costOfKids, _education);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids != "" && familyComposition == "" && education == "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _costOfKids = costOfKids;
                _periodS = periodS;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _costOfKids, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids != "" && familyComposition == "" && education == "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _costOfKids = costOfKids;
                _periodPo = periodPo;
                LogicaOne logicaOne = new LogicaOne(); logicaOne.DataGridFormat(_typeOfAddiction, _costOfKids, _periodPo);
            }
            //---------------------------------------------------------------------------------------------------------
            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids == "" && familyComposition != "" && education != "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _familyComposition = familyComposition;
                _education = education;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _familyComposition, _education);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids == "" && familyComposition != "" && education == "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _familyComposition = familyComposition;
                _periodS = periodS;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _familyComposition, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids == "" && familyComposition != "" && education == "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _familyComposition = familyComposition;
                _periodPo = periodPo;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _familyComposition, _periodPo);
            }
            //---------------------------------------------------------------------------------------------------------
            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids == "" && familyComposition == "" && education != "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _education = education;
                _periodS = periodS;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _education, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids == "" && familyComposition == "" && education != "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _education = education;
                _periodPo = periodPo;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _education, _periodPo);
            }
            //---------------------------------------------------------------------------------------------------------
            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids == "" && familyComposition == "" && education == "" && periodS != "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _periodS = periodS;
                _periodPo = periodPo;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _periodS, _periodPo);
            }
        }

        /// <summary>
        /// Передает 4 параметра 
        /// </summary>
        /// <param name="typeOfAddiction"></param>
        /// <param name="regionCenterBLR"></param>
        /// <param name="sex"></param>
        /// <param name="familyStatus"></param>
        /// <param name="costOfKids"></param>
        /// <param name="familyComposition"></param>
        /// <param name="education"></param>
        /// <param name="periodS"></param>
        /// <param name="periodPo"></param>
        public void Four_Params(string typeOfAddiction, string regionCenterBLR, string sex, string familyStatus, string costOfKids, string familyComposition, string education, string periodS, string periodPo)
        {
            if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus != ""
            && costOfKids == "" && familyComposition == "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _familyStatus = familyStatus;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _familyStatus);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus == ""
            && costOfKids != "" && familyComposition == "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _costOfKids = costOfKids;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _costOfKids);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus == ""
            && costOfKids == "" && familyComposition != "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _familyComposition = familyComposition;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _familyComposition);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus == ""
            && costOfKids == "" && familyComposition == "" && education != "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _education = education;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _education);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus == ""
            && costOfKids == "" && familyComposition == "" && education == "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _periodS = periodS;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus == ""
            && costOfKids == "" && familyComposition == "" && education == "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _periodPo = periodPo;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _periodPo);
            }
            //---------------------------------------------------------------------------------------------------------
            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex != "" && familyStatus != ""
            && costOfKids != "" && familyComposition == "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _sex, _familyStatus, _costOfKids);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex != "" && familyStatus != ""
            && costOfKids == "" && familyComposition != "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _sex = sex;
                _familyStatus = familyStatus;
                _familyComposition = familyComposition;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _sex, _familyStatus, _familyComposition);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex != "" && familyStatus != ""
            && costOfKids == "" && familyComposition == "" && education != "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _sex = sex;
                _familyStatus = familyStatus;
                _education = education;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _sex, _familyStatus, _education);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex != "" && familyStatus != ""
            && costOfKids == "" && familyComposition == "" && education == "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _sex = sex;
                _familyStatus = familyStatus;
                _periodS = periodS;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _sex, _familyStatus, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex != "" && familyStatus != ""
            && costOfKids == "" && familyComposition == "" && education == "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _sex = sex;
                _familyStatus = familyStatus;
                _periodPo = periodPo;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _sex, _familyStatus, _periodPo);
            }
            //-----------------------------------------------------------------------------------------------------------
            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus != ""
            && costOfKids != "" && familyComposition != "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _familyStatus, _costOfKids, _familyComposition);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus != ""
            && costOfKids != "" && familyComposition == "" && education != "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _education = education;
                LogicaOne logicaOne = new LogicaOne(); logicaOne.DataGridFormat(_typeOfAddiction, _familyStatus, _costOfKids, _education);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus != ""
            && costOfKids != "" && familyComposition == "" && education == "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _periodS = periodS;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _familyStatus, _costOfKids, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus != ""
            && costOfKids != "" && familyComposition == "" && education == "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _periodPo = periodPo;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _familyStatus, _costOfKids, _periodPo);
            }
            //--------------------------------------------------------------------------------------------------------------
            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids != "" && familyComposition != "" && education != "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _education = education;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _costOfKids, _familyComposition, _education);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids != "" && familyComposition != "" && education == "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _periodS = periodS;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _costOfKids, _familyComposition, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids != "" && familyComposition != "" && education == "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _periodPo = periodPo;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _costOfKids, _familyComposition, _periodPo);
            }
            //------------------------------------------------------------------------------------------------------------
            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids == "" && familyComposition != "" && education != "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _familyComposition = familyComposition;
                _education = education;
                _periodS = periodS;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _familyComposition, _education, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids == "" && familyComposition != "" && education != "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _familyComposition = familyComposition;
                _education = education;
                _periodPo = periodPo;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _familyComposition, _education, _periodPo);
            }
            //------------------------------------------------------------------------------------------------------------
            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids == "" && familyComposition == "" && education != "" && periodS != "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _education = education;
                _periodS = periodS;
                _periodPo = periodPo;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _education, _periodS, _periodPo);
            }
        }

        /// <summary>
        /// Передает 5 параметров
        /// </summary>
        /// <param name="typeOfAddiction"></param>
        /// <param name="regionCenterBLR"></param>
        /// <param name="sex"></param>
        /// <param name="familyStatus"></param>
        /// <param name="costOfKids"></param>
        /// <param name="familyComposition"></param>
        /// <param name="education"></param>
        /// <param name="periodS"></param>
        /// <param name="periodPo"></param>
        public void Five_Params(string typeOfAddiction, string regionCenterBLR, string sex, string familyStatus, string costOfKids, string familyComposition, string education, string periodS, string periodPo)
        {
            if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus != ""
            && costOfKids != "" && familyComposition == "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _familyStatus, _costOfKids);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus != ""
            && costOfKids == "" && familyComposition != "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _familyStatus = familyStatus;
                _familyComposition = familyComposition;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _familyStatus, _familyComposition);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus != ""
            && costOfKids == "" && familyComposition == "" && education != "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _familyStatus = familyStatus;
                _education = education;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _familyStatus, _education);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus != ""
            && costOfKids == "" && familyComposition == "" && education == "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _familyStatus = familyStatus;
                _periodS = periodS;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _familyStatus, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus != ""
            && costOfKids == "" && familyComposition == "" && education == "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _familyStatus = familyStatus;
                _periodPo = periodPo;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _familyStatus, _periodPo);
            }
            //---------------------------------------------------------------------------------------------------------
            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex != "" && familyStatus != ""
            && costOfKids != "" && familyComposition != "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _sex, _familyStatus, _costOfKids, _familyComposition);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex != "" && familyStatus != ""
            && costOfKids != "" && familyComposition == "" && education != "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _education = education;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _sex, _familyStatus, _costOfKids, _education);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex != "" && familyStatus != ""
            && costOfKids != "" && familyComposition == "" && education == "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _periodS = periodS;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _sex, _familyStatus, _costOfKids, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex != "" && familyStatus != ""
            && costOfKids != "" && familyComposition == "" && education == "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _periodPo = periodPo;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _sex, _familyStatus, _costOfKids, _periodPo);
            }
            //------------------------------------------------------------------------------------------------------
            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus != ""
            && costOfKids != "" && familyComposition != "" && education != "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _education = education;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _familyStatus, _costOfKids, _familyComposition, _education);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus != ""
            && costOfKids != "" && familyComposition != "" && education == "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _periodS = periodS;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _familyStatus, _costOfKids, _familyComposition, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus != ""
            && costOfKids != "" && familyComposition != "" && education == "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _periodPo = periodPo;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _familyStatus, _costOfKids, _familyComposition, _periodPo);
            }
            //------------------------------------------------------------------------------------------------------
            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids != "" && familyComposition != "" && education != "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _education = education;
                _periodS = periodS;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _costOfKids, _familyComposition, _education, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids != "" && familyComposition != "" && education != "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _education = education;
                _periodPo = periodPo;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _costOfKids, _familyComposition, _education, _periodPo);
            }
            //------------------------------------------------------------------------------------------------------
            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids == "" && familyComposition != "" && education != "" && periodS != "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _familyComposition = familyComposition;
                _education = education;
                _periodS = periodS;
                _periodPo = periodPo;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _familyComposition, _education, _periodS, _periodPo);
            }
        }

        /// <summary>
        /// Передает 6 параметров
        /// </summary>
        /// <param name="typeOfAddiction"></param>
        /// <param name="regionCenterBLR"></param>
        /// <param name="sex"></param>
        /// <param name="familyStatus"></param>
        /// <param name="costOfKids"></param>
        /// <param name="familyComposition"></param>
        /// <param name="education"></param>
        /// <param name="periodS"></param>
        /// <param name="periodPo"></param>
        public void Six_Params(string typeOfAddiction, string regionCenterBLR, string sex, string familyStatus, string costOfKids, string familyComposition, string education, string periodS, string periodPo)
        {
            if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus != ""
           && costOfKids != "" && familyComposition != "" && education == "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _familyStatus, _costOfKids, _familyComposition);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus != ""
            && costOfKids != "" && familyComposition == "" && education != "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _education = education;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _familyStatus, _costOfKids, _education);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus != ""
            && costOfKids != "" && familyComposition == "" && education == "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _periodS = periodS;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _familyStatus, _costOfKids, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus != ""
            && costOfKids != "" && familyComposition == "" && education == "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _periodPo = periodPo;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _familyStatus, _costOfKids, _periodPo);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex != "" && familyStatus != ""
            && costOfKids != "" && familyComposition != "" && education != "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _education = education;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _sex, _familyStatus, _costOfKids, _familyComposition, _education);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex != "" && familyStatus != ""
            && costOfKids != "" && familyComposition != "" && education == "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _periodS = periodS;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _sex, _familyStatus, _costOfKids, _familyComposition, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex != "" && familyStatus != ""
            && costOfKids != "" && familyComposition != "" && education == "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _periodPo = periodPo;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _sex, _familyStatus, _costOfKids, _familyComposition, _periodPo);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus != ""
            && costOfKids != "" && familyComposition != "" && education != "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _education = education;
                _periodS = periodS;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _familyStatus, _costOfKids, _familyComposition, _education, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus != ""
            && costOfKids != "" && familyComposition != "" && education != "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _education = education;
                _periodPo = periodPo;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _familyStatus, _costOfKids, _familyComposition, _education, _periodPo);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex == "" && familyStatus == ""
            && costOfKids != "" && familyComposition != "" && education != "" && periodS != "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _education = education;
                _periodS = periodS;
                _periodPo = periodPo;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _costOfKids, _familyComposition, _education, _periodS, _periodPo);
            }
        }

        /// <summary>
        /// Передает 7 параметров
        /// </summary>
        /// <param name="typeOfAddiction"></param>
        /// <param name="regionCenterBLR"></param>
        /// <param name="sex"></param>
        /// <param name="familyStatus"></param>
        /// <param name="costOfKids"></param>
        /// <param name="familyComposition"></param>
        /// <param name="education"></param>
        /// <param name="periodS"></param>
        /// <param name="periodPo"></param>
        public void Seven_Params(string typeOfAddiction, string regionCenterBLR, string sex, string familyStatus, string costOfKids, string familyComposition, string education, string periodS, string periodPo)
        {
            if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus != ""
            && costOfKids != "" && familyComposition != "" && education != "" && periodS == "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _education = education;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _familyStatus, _costOfKids, _familyComposition, _education);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus != ""
            && costOfKids != "" && familyComposition != "" && education == "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _periodS = periodS;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _familyStatus, _costOfKids, _familyComposition, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus != ""
            && costOfKids != "" && familyComposition != "" && education == "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _periodPo = periodPo;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _familyStatus, _costOfKids, _familyComposition, _periodPo);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus != ""
            && costOfKids != "" && familyComposition == "" && education != "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _education = education;
                _periodS = periodS;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _familyStatus, _costOfKids, _education, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus != ""
            && costOfKids != "" && familyComposition == "" && education != "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _education = education;
                _periodPo = periodPo;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _familyStatus, _costOfKids, _education, _periodPo);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus != ""
            && costOfKids == "" && familyComposition != "" && education != "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _familyStatus = familyStatus;
                _familyComposition = familyComposition;
                _education = education;
                _periodS = periodS;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _familyStatus, _familyComposition, _education, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus != ""
            && costOfKids == "" && familyComposition != "" && education != "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _familyStatus = familyStatus;
                _familyComposition = familyComposition;
                _education = education;
                _periodPo = periodPo;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _familyStatus, _familyComposition, _education, _periodPo);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus == ""
            && costOfKids != "" && familyComposition != "" && education != "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _education = education;
                _periodS = periodS;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _costOfKids, _familyComposition, _education, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus == ""
            && costOfKids != "" && familyComposition != "" && education != "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _education = education;
                _periodPo = periodPo;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _costOfKids, _familyComposition, _education, _periodPo);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex == "" && familyStatus != ""
            && costOfKids != "" && familyComposition != "" && education != "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _education = education;
                _periodS = periodS;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _regionCenterBLR, _familyStatus, _costOfKids, _familyComposition, _education, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex == "" && familyStatus != ""
            && costOfKids != "" && familyComposition != "" && education != "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _education = education;
                _periodPo = periodPo;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _regionCenterBLR, _familyStatus, _costOfKids, _familyComposition, _education, _periodPo);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex != "" && familyStatus != ""
            && costOfKids != "" && familyComposition != "" && education != "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _education = education;
                _periodS = periodS;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _sex, _familyStatus, _costOfKids, _familyComposition, _education, _periodS);
            }

            else if (typeOfAddiction != "" && regionCenterBLR == "" && sex != "" && familyStatus != ""
            && costOfKids != "" && familyComposition != "" && education != "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _education = education;
                _periodPo = periodPo;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _sex, _familyStatus, _costOfKids, _familyComposition, _education, _periodPo);
            }
        }

        /// <summary>
        /// передает 8 параметров пока не дописан 
        /// </summary>
        /// <param name="typeOfAddiction"></param>
        /// <param name="regionCenterBLR"></param>
        /// <param name="sex"></param>
        /// <param name="familyStatus"></param>
        /// <param name="costOfKids"></param>
        /// <param name="familyComposition"></param>
        /// <param name="education"></param>
        /// <param name="periodS"></param>
        /// <param name="periodPo"></param>
        public void Eight_Params(string typeOfAddiction, string regionCenterBLR, string sex, string familyStatus, string costOfKids, string familyComposition, string education, string periodS, string periodPo)
        {
            if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus != ""
            && costOfKids != "" && familyComposition != "" && education != "" && periodS != "" && periodPo == "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _education = education;
                _periodS = periodS;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _familyStatus, _costOfKids, _familyComposition, _education, _periodS);
            }
            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus != ""
            && costOfKids != "" && familyComposition != "" && education != "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _education = education;
                _periodPo = periodPo;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _familyStatus, _costOfKids, _familyComposition, _education, _periodPo);
            }
            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus != ""
            && costOfKids != "" && familyComposition != "" && education != "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _education = education;
                _periodPo = periodPo;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _familyStatus, _costOfKids, _familyComposition, _education, _periodPo);
            }
            else if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus != ""
            && costOfKids != "" && familyComposition != "" && education != "" && periodS == "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _education = education;
                _periodPo = periodPo;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _familyStatus, _costOfKids, _familyComposition, _education, _periodPo);
            }
        }

        /// <summary>
        /// передает 9 параметров 
        /// </summary>
        public void Nine_Params(string typeOfAddiction, string regionCenterBLR, string sex, string familyStatus, string costOfKids, string familyComposition, string education, string periodS, string periodPo)
        {
            if (typeOfAddiction != "" && regionCenterBLR != "" && sex != "" && familyStatus != ""
            && costOfKids != "" && familyComposition != "" && education != "" && periodS != "" && periodPo != "")
            {
                _typeOfAddiction = typeOfAddiction;
                _regionCenterBLR = regionCenterBLR;
                _sex = sex;
                _familyStatus = familyStatus;
                _costOfKids = costOfKids;
                _familyComposition = familyComposition;
                _education = education;
                _periodS = periodS;
                _periodPo = periodPo;
                LogicaOne logicaOne = new LogicaOne();
                logicaOne.DataGridFormat(_typeOfAddiction, _regionCenterBLR, _sex, _familyStatus, _costOfKids, _familyComposition, _education, _periodS, _periodPo);
            }
        }


        /// <summary>
        /// клавиша назад
        /// </summary>
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
            }
        }

        /// <summary>
        /// Сформировать отчет 
        /// </summary>
        private void Excel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //сформировать отчет по алкогольной зависимости
                if (_typeOfAddiction == "Алкогольная")
                {
                    ExcelServis.Save_Report_Excel_Alco(alco);
                }
                //сформировать отчет по наркозависимости
                else if (_typeOfAddiction == "Наркотическая")
                {
                    ExcelServis.Save_Report_Excel_Narco(narco);
                }
                //сформировать отчет по полизависимости
                else if (_typeOfAddiction == "Полизависимость")
                {
                    ExcelServis.Save_Report_Excel_Poliz(poliz);
                }

                Close();
            }

            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                ExcepLog.Excep(excep);
            }
        }

        /// <summary>
        /// Клавиша выгрузки по дате учета 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int col = 0;
                //сформировать отчет по алкогольной зависимости
                if (_typeOfAddiction == "Алкогольная")
                {
                    ExcelServis.Read_Alco();
                    List<Alco> alcot = new List<Alco>();
                    for (int i = 0; i < Alco.AlcoholismPersona.Count; i++)
                    {
                        if (Alco.AlcoholismPersona[i].DataInfo == downlReg.Text)
                        {
                            alcot.Add(Alco.AlcoholismPersona[i]);
                            col++;
                        }
                    }
                    ExcelDataServis.Save_Report_Excel_Alco(alcot, col);
                }
                //сформировать отчет по наркозависимости
                else if (_typeOfAddiction == "Наркотическая")
                {
                    ExcelServis.Read_Narco();
                    List<Narcoman> narcot = new List<Narcoman>();
                    for (int i = 0; i < Narcoman.Drug_Addiction.Count; i++)
                    {
                        if (Narcoman.Drug_Addiction[i].DataInfo == downlReg.Text)
                        {
                            narcot.Add(Narcoman.Drug_Addiction[i]);
                            col++;
                        }
                    }
                    ExcelDataServis.Save_Report_Excel_Narco(narcot, col);
                }
                //сформировать отчет по полизависимости
                else if (_typeOfAddiction == "Полизависимость")
                {
                    ExcelServis.Read_Poliz();
                    List<Polizavis> polizt = new List<Polizavis>();
                    for (int i = 0; i < Polizavis.Alco_Narco_Person.Count; i++)
                    {
                        if (Polizavis.Alco_Narco_Person[i].DataInfo == downlReg.Text)
                        {
                            polizt.Add(Polizavis.Alco_Narco_Person[i]);
                            col++;
                        }
                    }
                    ExcelDataServis.Save_Report_Excel_Poliz(polizt, col);
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