using System;
using System.Collections.Generic;
using System.Text;

namespace PropApp
{
    class Employee
    {
        private int _Id;
        private string _Name;
        private double _Salary;

        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Negative numbers not allowed");
                }
                else
                {
                    this._Id = value;
                }
            }
        }
        public string Name {
            get
            {
                return string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Please enter name");
                }
                else
                {
                    this._Name = value;
                }

            }
        }

        public double Salary
        {
            get
            {
                return this._Salary;
            }
            set
            {
                this._Salary = value;
            }
        }
    }
}
