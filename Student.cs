using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    internal class Student
    {
        private string name;
        private string surname;
        private string faculty;
        private bool is_magistr;
        private string bachelor_degree;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Faculty
        {
            get { return faculty; }
            set { faculty = value; }
        }

        public bool IsMagistr
        {
            get { return is_magistr; }
            set { is_magistr = value; }
        }

        public string BachelorDegree
        {
            get { return bachelor_degree;}
            set { bachelor_degree = value; }
        }

        public Student()
        {
            name = "";
            surname = "";
            faculty = "";
            is_magistr = false;
            bachelor_degree = "";
        }
    }
}
