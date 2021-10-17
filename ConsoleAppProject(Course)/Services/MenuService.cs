using ConsoleAppProject_Course_.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject_Course_.Services
{
    static class MenuService
    {
        public static CourseService courseService = new CourseService();
         public static void CreateGroupMenu()
        {
            Console.WriteLine("Please choose the category");
            foreach (var c in Enum.GetValues(typeof(ClassCategory)))
            {
                Console.WriteLine($"{(int)c}.{c}");
            }
            int category;
            string categoryStr = Console.ReadLine();
            bool categoryResult = int.TryParse(categoryStr, out category);
            if (categoryResult)
            {
                switch (category)
                {
                    case 1:
                        string No = courseService.CreateGroup(ClassCategory.Programming);
                        Console.WriteLine($"{No} group has  created");
                        break;
                    case 2:
                         No = courseService.CreateGroup(ClassCategory.Design);
                        Console.WriteLine($"{No} group has  created");
                        break;
                    case 3:
                         No = courseService.CreateGroup(ClassCategory.SystemAdminstration);
                        Console.WriteLine($"{No} group has  created");
                        break;
                    default:
                        break;
                }
            }
          
        }
        public static void EditGroupsMenu()
        {
            Console.WriteLine("Please enter group number that you want to change:");
            string groupNo = Console.ReadLine();
            Console.WriteLine("Please enter new group number:");
            string newgroupNo = Console.ReadLine();
            courseService.EditGroups(groupNo, newgroupNo);

        }
        public static void GetGroupsMenu()
        {
            courseService.GetGroups();
        }
        public static void CreateStudenMenu()
        {
            Console.WriteLine("Please enter students informations");
            string studfullname = Console.ReadLine();

            foreach (var e in Enum.GetValues(typeof(EducationType)))
            {
                Console.WriteLine($"{(int)e}.{e}");
            }

            int edutype;
            string edutyoeStr = Console.ReadLine();
            bool eduResult = int.TryParse(edutyoeStr, out edutype);

            foreach (var e in Enum.GetValues(typeof(Line)))
            {
                Console.WriteLine($"{(int)e}.{e}");

            }

            int onofflines;
            string onofflineStr = Console.ReadLine();
            bool onofflineResult = int.TryParse(onofflineStr, out onofflines);




            if (eduResult && onofflineResult)
            {
                switch (edutype)
                {
                    case 1:
                        Console.WriteLine(courseService.CreateStudent(studfullname, EducationType.Zemanetli));
                        break;
                    case 2:
                        Console.WriteLine(courseService.CreateStudent(studfullname, EducationType.Zemanetsiz));
                        break;
                    default:
                        break;
                }
                switch (onofflines)
                {
                    case 1:
                        Console.WriteLine(courseService.CreateStudentonoff(Line.Online));
                        break;
                    case 2:
                        Console.WriteLine(courseService.CreateStudentonoff(Line.Offline));
                        break;
                    default:
                        break;
                }

            }


        }
        public static void GetGroupsStudentsMenu()
        {
            Console.WriteLine("Please enter group number");
            string groupno = Console.ReadLine();
            courseService.GetGroupStudent(groupno);
        }
        public static void  GetAllStudentsMenu()
        {
            courseService.GetAllStdents();
        }
    }
}