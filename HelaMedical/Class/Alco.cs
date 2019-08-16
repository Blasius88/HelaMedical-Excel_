using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HelaMedical.Class
{
    public class Alco : INotifyPropertyChanged
    {
        public string Id { get; set; } // Id 1 
        public string FIO { get; set; } // фамилия 2
        public string Sex { get; set; } // пол 3
        public string Date { get; set; } // дата рождения 4
        public string RegionCenterBLR { get; set; } // облостной центр 5
        public string RaenCenterBLR { get; set; } // раенный центр 6
        public string Life { get; set; } // Место проживания 7
        public string Age { get; set; } // Адрес проживания 8
        public string FamilyStatus { get; set; } // Семейный статус 9 
        public string CostOfKids { get; set; } // Количество детей 10
        public string FamilyComposition { get; set; } // Состав семьи 11 
        public string Education { get; set; } // Уровень образование 12
        public string Profession { get; set; } // Профессия /должность 13
        public string TheSkillLevelOfTheProfession { get; set; } // Уровень квалификации профессии 14


        //Постановка на учет

        public string AddressOfRegistration { get; set; } //Адрес постановки на учет 15
        public string AddressAtTheTimeOfDeath { get; set; } // Адрес на момент смерти 16
        public string DataOfRegistration { get; set; } // Дата постановки на учет 17
        public string ReRegistrationData { get; set; } // Дата повторной постановки на учет 18 
        public string TypeOfRegistration { get; set; } // Вид постановки на учет 19
        public string Heredity { get; set; } // Наследственность 20


        //Инвалидность 


        public string DisabilityGroup { get; set; } // Группа инвалидности 21
        public string DisabilityStatus { get; set; } // Статус инвалидности 22
        public string ReasonForDisability { get; set; } // Основание для инвалидности 23 


        // Социально - экономический статус

        public string WorksStatus { get; set; } // Социально - Экономический статус 24
        public string AdmOtv { get; set; } // Привлечение к адм. ответствености (кол) 25
        public string UgOtv { get; set; } // Привлечение к угл. ответственности 26
        public string DlitsMLS { get; set; } // Длительность пребывание в МЛС 27
        public string Stat107 { get; set; } // Статья 107 28
        public string StatUKRB { get; set; } // Номер статей УК РБ 29
        public string RodPrav { get; set; } // Лишение родительских прав 30 
        public string NomLTP { get; set; } // Номер ЛТП 31
        public string LTPKol { get; set; } //ЛТП количество 32  
        public string Hospitel { get; set; } // Больницы 33


        //Экстранозологическая коморбидность

        public string EK { get; set; } //Экстранозологическая коморбидность 34


        //Дата снятия с учета 

        public string DateOfDeregistration { get; set; } // Дата снятия с учета 35 


        //Данные о смерти 

        public string DateOfDead { get; set; } // дата смерти 36
        public string PlaceOfDead { get; set; } // Место смерти 37
        public string DeathCertificate { get; set; } // № Свидетельсва о смерти 38
        public string CauseOfDead { get; set; } // Причина смерти 39
        public string DeathCategory { get; set; } // Категория и род смерти 40 
        public string OpeningPlace { get; set; } // Место вскрытия трупа 41
        public string HistoryOfParasucicides { get; set; } // Парасуициды в анамнезе 42
        public string FeaturesOfObservation { get; set; } // особенности наблюдения 43


        //Алкоголизм 
        // Стаж злоупотребления 

        public string ExperienceAbuse { get; set; } //Стаж злоупотребления 44


        //Алкогольные напитки 

        public string AlcoholicDrinks { get; set; } // Алкогольные напитки 45


        //Интранозологическая  коморбидность 

        public string IK { get; set; } // Интранозологическая  коморбидность 46


        // Наркодиагноз алко

        public string DrugDiagnosisAlc { get; set; } // Наркодиагноз алко 47


        public string AgeOfDead { get; set; } // Возраст на момент смерти 48
        public string AgeOfRegistration { get; set; } // возраст на момент постановки на учет 49

        public string DataInfo { get; set; } // Год учета 50

        public string Registrotor { get; set; } // регистратор 51 

        public static List<Alco> AlcoholismPersona = new List<Alco>();



        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
