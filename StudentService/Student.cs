using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentService
{
    public class Student
    {
        private int _id;
        private string _name;
        private string _gender;
        private DateTime _dateofbirth;
        private string _city;
        private string _school;
        private int _fees;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public DateTime BirthDate
        {
            get { return _dateofbirth; }
            set { _dateofbirth = value; }
        }
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        public string School
        {
            get { return _school; }
            set { _school = value; }
        }
        public int Fees
        {
            get { return _fees; }
            set { _fees = value; }
        }
    }
}
