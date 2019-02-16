using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadawansTask13
{
    class Employee
    {
        private int _age;
        private string _surname;

        public Employee() { }
        public Employee(string surname, int age)
        {
            this._surname = surname;
            this._age = age;
        }

        private string GetAge()
        {
            return _age.ToString();
        }

        public void SetSurname(string surname)
        {
            this._surname = surname;
        }

        public string EmployeeInfo()
        {
            return $"Surname: {this._surname}, Age: {this._age}";
        }
    }
}
