using CV.Models;

namespace CV.Services
{
    public static class CreateCVArtenHerasymchuk
    {
        public static CV_Info CreateCVArtemHersymchuk()
        {
            CV_Info newCV = new CV_Info();

            newCV.Name = "Artem";
            newCV.Surname = "Herasymchuk";
            newCV.Photo = "~/photo.jpg";
            newCV.Summary = "I am applied mathematics graduate passionate about programming. " +
                "I am fond of solving different types of problems and taking up challenges. " +
                "I have knowledge in a range of modern technologies including .Net/C#, OOP, MS SQL. " +
                "My university educational background gave me professional qualities and communication skills, which makes me a good specialist and team-player.";


            newCV.Info = CreateInfoArtemHerasymchuk();
            newCV.Skills = CreateSkillsArtemHerasymchuk();
            newCV.Experiances = CreateExperiancesArtemHerasymchuk();
            newCV.Educations = CreateEducationsArtemHerasymchuk();
            newCV.Languages = CreateLanguagesArtemHerasymchuk();


            return newCV;
        }

        private static Info CreateInfoArtemHerasymchuk()
        {
            string position = "С#/.Net developer";
            string phoneNumber = "0961016069";
            string email = "art.gv800@gmail.com";
            string github = "https://github.com/arbrant";

            Info info = new Info(position, phoneNumber, email, github);
            return info;
        }

        private static List<string> CreateSkillsArtemHerasymchuk()
        {
            List<string> skills = new List<string>();

            skills.Add(".NET");
            skills.Add("C#");
            skills.Add("OOP");
            skills.Add("Git");
            skills.Add("Linq");
            skills.Add("ASP.NET MVC");
            skills.Add("MS SQL");
            skills.Add("HTML/CSS/JS");
            skills.Add("Self improvement");
            skills.Add("Flexability");

            return skills;
        }

        private static List<Experiance> CreateExperiancesArtemHerasymchuk()
        {
            List<Experiance> experiances = new List<Experiance>();

            string name, place, location, description;
            DateTime? from, to;

            //experiance #1
            name = "WinDev/WebDev Developer";
            place = "UpInSolutions";
            location = "Lviv";
            description = "I was working as a trainee developer on a project called GreenLightPortal. " +
                "My main responsabilities were developing a software on WinDev and WebDev using HFSQL database, connecting and using MySql database, creating front-end.";
            from = new DateTime(2022, 2, 1);
            to = new DateTime(2023, 2, 1);
            experiances.Add(new Experiance(name, place, location, description, from, to));

            //experiance #2
            name = "FinderApplication";
            place = "";
            location = "";
            description = "It is an university task, console application which allows you to perform basic operations on files as create, fill, append, read, etc txt files. " +
                "It was created for practies of working with txt files. More information on my GitHub.";
            from = null;
            to = null;
            experiances.Add(new Experiance(name, place, location, description, from, to));

            //experiance #3
            name = "ProjectsManager";
            place = "";
            location = "";
            description = "It is my university project, desktop application which allows you to store information about different projects in MS SQL database and to operate them quickly.";
            from = null;
            to = null;
            experiances.Add(new Experiance(name, place, location, description, from, to));

            return experiances;
        }

        private static List<Education> CreateEducationsArtemHerasymchuk()
        {
            List<Education> educations = new List<Education>();

            string field, degree, educationalInstitution;
            DateTime? from, to;

            //education #1
            field = "Applied Mathematics";
            degree = "Bachelor’s";
            educationalInstitution = "Lviv Polytechnic National University";
            from = new DateTime(2019, 9, 1);
            to = null;
            educations.Add(new Education(field, degree, educationalInstitution, from, to));

            return educations;
        }

        private static List<Language> CreateLanguagesArtemHerasymchuk()
        {
            List<Language> languages = new List<Language>();

            string language, level;

            //language #1
            language = "English";
            level = "B2";
            languages.Add(new Language(language, level));

            return languages;
        }

    }
}
