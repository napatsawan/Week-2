using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab201
{
    class Student
    {
        public string Name;
        public string StudentID;       
        public bool isActive;
        private int ole;

        public int YearOfBirth
        {

            get { return ole; }
            set
            {
                if (value >= 1950 && value <= 2000)
                {
                    ole = value;

                }
                else
                {
                    Console.WriteLine("57005: error try setting invalid year-of-birth value!");
                }
            }

        }

        public Student()
        {
            Name = "John Doe";
            StudentID = "Unknown";
            YearOfBirth = 1995;
            isActive = false;
        }
        public Student(string name, string id)
        {
            Name = name;
            StudentID = id;
            YearOfBirth = 1995;
            isActive = true;
        }
        public Student(string name, string id, int y)
        {
            Name = name;
            StudentID = id;
            YearOfBirth = y;
            isActive = true;
        }
        public Student(string name, string id, int y, bool ia)
        {
            Name = name;
            StudentID = id;
            YearOfBirth = y;
            isActive = true;
        }
        public string getName()
        {
            return Name;
        }
        public void setName(string name)
        {
            this.Name = name;
        }
        public string getStudentID()
        {
            return StudentID;
        }
        public void setStudentID(string id)
        {
            this.StudentID = id;
        }
        public int getYearOfBirth()
        {
            return YearOfBirth;
        }

        public void setYearOfBirth(int o)
        {
            this.YearOfBirth = o;
        }
        public int getAge()
        {
            return DateTime.Now.Year - YearOfBirth;

        }
        public override string ToString()
        {

            string check;
            if (isActive == true)
            {
                check = "is active student";

            }
            else
            {

                check = "is NOT active student";
            }
            return string.Format("[Student : {0} ({1}),age = {2},{3}]", Name, StudentID, getAge(), check);
        }
    }
}