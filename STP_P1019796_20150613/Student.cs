using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STP_P1019796_20150613
{
    public class Student
    {
        private int id;
        private string firstName;
        private string lastName;
        private string studentNumber;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string StudentNumber
        {
            get { return studentNumber; }
            set { studentNumber = value; }
        }
    }
}
