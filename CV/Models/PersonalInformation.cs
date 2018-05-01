using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace CV.Models
{
    public class PersonalInformation
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public string DateOfBirth { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public long PhoneNumber { get; set; }
        public string Education { get; set; }
        public float YearsOfExperience { get; set; }

        public static List<Education> EducationInfo()
        {
            List<Education> listOfEducation = new List<Models.Education>();
            //ADDS EDUCATION TO listOfEducation
            listOfEducation.Add(new Education { School = "EC Utbildning", Course = "Webbutveckling inom .NET", Date = "Sept, 2015 — Juni, 2017", Skills = "C# Programmering, Analys och Design (UML), Databaser (Microsoft SQL Server Management Studio 2014), .NET Framework, ADO.NET, HTML 5, MVC och Entity Framework." });
            listOfEducation.Add(new Education { School = "Kista Gymnasium", Course = "Handels- och Administrationsprogrammet", Date = "Sept, 2009 — Juni, 2012", Skills = "C# Programmering, Analys och Design (UML), Databaser (Microsoft SQL Server Management Studio 2014), .NET Framework, ADO.NET, HTML 5, MVC och Entity Framework." });
            listOfEducation.Add(new Education { School = "Komvux Stockholm", Course = "Webbutveckling inom .NET", Date = "Jan, 2013 — Juli, 2015", Skills = "Spanska 1, Psykologi 1, Programmering 1, Programmering 2, Engelska 7, Italienska 1, Matematik 2a och Matematik 3b." });
            //RETURNS THE LIST OF EDUCATION
            return listOfEducation;
        }
        public static List<WorkExperience> WorkExperience()
        {
            List<WorkExperience> listOfWorkExperience = new List<Models.WorkExperience>();
            //ADDS WORKEXPERIENCE TO listOfWorkExperience
            listOfWorkExperience.Add(new WorkExperience { Job = "PostNord AB", Date = "8 Nov, 2017 — Pågående", Tasks = "Paketsortering, avgång (fylla på lastbilar med paket), lossning." });
            listOfWorkExperience.Add(new WorkExperience { Job = "Coder Dojo, (LIA - Front/Backend Utveckling)", Date = "26 Sept, 2016 — 9 Dec, 2016 & 20 Mars, 2017 — 6 Juni, 2017", Tasks = "Utveckling av ett webbaserat medlemsregister i ASP.NET MVC med C#, SQL, HTML, JavaScript/jQuery, CSS & Bootstrap. Webbapplikation riktade sig till att föreningen (Coder Dojo) skulle användas för att registrera nya medlemmar samt administrera existerande medlemmar." });
            listOfWorkExperience.Add(new WorkExperience { Job = "They Care Hammarbygården AB", Date = "Okt, 2014 — Aug, 2015", Tasks = "Serverat mat, städat, gett medicin och hållt dom sällskap." });
            listOfWorkExperience.Add(new WorkExperience { Job = "Willys, Personal (Praktik - Tredje Året i Gymnasiet)", Date = "Nov , 2011 — Feb, 2012", Tasks = "Varuplockning och påfyllning av hyllor och kylar med mejeri osv." });
            listOfWorkExperience.Add(new WorkExperience { Job = "Stockholms Län Landsting (Sommarjobb - Lokalvårdare)", Date = "Juni, 2010 — Juli, 2010", Tasks = "Hålla rent genom att rengöra golv, fönster, dörrar m.m stärkte mitt sinne för att arbeta hårt, arbeta med ett team, vara noggrann och metodiskt." });
            listOfWorkExperience.Add(new WorkExperience { Job = "Kista Bibliotek, Personal (Praktik - Andra Året i Gymnasiet)", Date = "Feb, 2010 — April, 2010", Tasks = "Organisera böcker i hyllor efter bokstavsordning samt genre. Hjälpa besökare med datorer, lämna tillbaka böcker, skicka brev(ifall dom har lånat för länge), samt att lokalisera böcker." });
            listOfWorkExperience.Add(new WorkExperience { Job = "Lidl, Personal (Praktik - Första Året i Gymnasiet)", Date = "Okt, 2009 — Dec, 2009", Tasks = "Varuplockning, bemöta kunder, påfyllning och kassa." });
            listOfWorkExperience.Add(new WorkExperience { Job = "Ica, Personal (Praktik - Årskurs 9)", Date = "Feb, 2008 — Mars, 2008", Tasks = "Hur man jobbar i ett lager, påfyllning av varor i hyllor, stärkt kvalitetsmedvetenhet och vanan av arbete med färskvaror." });
            //RETURNS THE LIST OF WORK EXPERIENCES
            return listOfWorkExperience;
        }
        public static PersonalInformation PersonalInfo()
        {
            //ALL OF THE CODE IS HARDCODED, BUT IF YOU CHOOSES TO SELECT DATEOFBIRTH WITH A DATE INPUT 
            //(YOU WILL GET A DATE SIMILAR TO THE ONE UNDERNEATH) THATS WHY THERE IS A DATE METHOD CALLED: Date(ref dateofbirth, date), WHICH WILL CONVERT THE VALUE
            var date = Convert.ToDateTime("1993-05-06");
            //SO IT SHOWS MORE CLEARLY THE DATE OF BIRTH, IN THIS CASE, IT WILL BE "MAY 6TH, 1993" INSTEAD OF "1993-05-06"
            string dateofbirth = "";
            Date(ref dateofbirth, date);
            PersonalInformation MyPersonalInfo = new PersonalInformation
            {
                Name = "William Johansson",
                Education = "EC Utbildning, Webbutveckling inom .NET",
                Location = "Stockholm, Sweden",
                DateOfBirth = dateofbirth,
                Email = "WilliamJohansson93@hotmail.com",
                PhoneNumber = +46760000000,
                Profession = "Webbutvecklare",
                YearsOfExperience = 0.5f
            };
            return MyPersonalInfo;
        }
        public static void Date(ref string result, DateTime date)
        {
            var month = date.ToString("MMMM", CultureInfo.InvariantCulture);
            var year = date.ToString("yyyy");
            var day = date.ToString("dd");
            month = char.ToUpper(month[0]) + month.ToLower().Substring(1);
            if (day.Equals("01") || day.Equals("21"))
            {
                if (day.Equals("01"))
                    result = month + " " + day.Remove(0, 1) + "st, " + year; //REMOVE THE FIRST CHAR (SO ITS NOT - EXAMPLE: 01ST - INSTEAD, IT WILL BE 1ST)
                else
                    result = month + " " + day + "st, " + year; //IF ITS NOT 1ST - THEN IT WILL BE 21ST AND THEREFOR, THERE IS NO NEED TO REMOVE THE FIRST CHAR
            }
            else if (day.Equals("02") || day.Equals("22"))
            {
                if (day.Equals("02"))
                    result = month + " " + day.Remove(0, 1) + "nd, " + year; //REMOVE THE FIRST CHAR (SO ITS NOT - EXAMPLE: 02ND - INSTEAD, IT WILL BE 2ND)
                else
                    result = month + " " + day + "nd, " + year; //IF ITS NOT 2ND - THEN IT WILL BE 22ND AND THEREFOR, THERE IS NO NEED TO REMOVE THE FIRST CHAR
            }
            else if (day.Equals("03") || day.Equals("23"))
            {
                if (day.Equals("03"))
                    result = month + " " + day.Remove(0, 1) + "rd, " + year; //REMOVE THE FIRST CHAR (SO ITS NOT - EXAMPLE: 03RD - INSTEAD, IT WILL BE 3RD)
                else
                    result = month + " " + day + "rd, " + year; //IF ITS NOT 3RD - THEN IT WILL BE 23RD AND THEREFOR, THERE IS NO NEED TO REMOVE THE FIRST CHAR
            }
            else
            {
                if (Convert.ToInt32(day) <= 9 && Convert.ToInt32(day) >= 4) //IF THE DAY IS EQUAL/MORE THAN 4 OR EQUAL/LESS THAN 9 (NUMBERS 4 TO 9 BECAUSE ALL OF THESE NUMBERS ENDS WITH 'TH' - EXAMPLE: 4TH TO 9TH)
                    result = month + " " + day.Remove(0, 1) + "th, " + year; //REMOVE THE FIRST CHAR (SO ITS NOT - EXAMPLE: 06TH - INSTEAD, IT WILL BE 6TH)
                else
                {
                    result = month + " " + day + "th, " + year; //ANY DAY BETWEEN 10 TO 20 AND 24 TO 30 - BECAUSE THEY ALL END WITH 'TH'
                }
            }
        }
    }
}