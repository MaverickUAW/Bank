using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProgram
{
    class Obcyj
    {
        public string name
        {
            get;
            set;
        }
        public string credit
        {
            get;
            set;
        }
        public int procent
        {
            get;
            set;
        }
        public string city
        {
            get;
            set;
        }
        public int date
        {
            get;
            set;
        }
        public Obcyj(string name_, string credit_, int procent_, string city_, int date_)
        {
            name = name_;
            credit = credit_;
            date = date_;
            procent = procent_;
            city = city_;
        }
    }
}
