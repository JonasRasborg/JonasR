using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CPRUserControl
{
    class DTO
    {
        private string _cpr;
        public DTO(string cpr)
        {
            CPR = cpr;
        }

        public string CPR
        {
            get { return _cpr; }
            set {
                if (value.Length == 10)
                {
                    if (Check11Test(value))
                    {
                        _cpr = value;
                    } 
                }
                else
                {
                    _cpr = "10000001";
                }
            }

        }


        private bool Check11Test(string cprTxt)
        {
            int sum = 0;

            for (int i = 0; i < 3; i++)
            {
                sum += int.Parse(cprTxt.Substring(i, 1)) * (4 - i);
            }
            for (int i = 3; i < 10; i++)
            {
                sum += int.Parse(cprTxt.Substring(i, 1)) * (10 - i);
            }

            if (sum % 11 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
