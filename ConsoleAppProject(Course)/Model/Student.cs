using ConsoleAppProject_Course_.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject_Course_.Model
{
    class Student
    {
        public string FullName { get; set; }
        public EducationType EduType { get; set; }
        public Line OnOffline { get; set; }
        public Group GroupNo { get; set; }
        public Student(string fullname, EducationType edutype)
        {
            FullName = fullname;
            EduType = edutype;

        }
        public Student(Line onoffline)
        {
            OnOffline = onoffline;
        }

        public override string ToString()
        {
            return $"{FullName}-{EduType}-{OnOffline}";
        }
    }
}