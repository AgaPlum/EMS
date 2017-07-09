using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesTesting
{
    public delegate double Fee(double itemPrice);
    class Challenge
    {
        public double Zone1(double itemPrice)
        {
            double fees = itemPrice * 0.25;
                return fees;
        }
        public double Zone2(double itemPrice)
        {
            double fees = itemPrice * 0.12;
            fees += 25;//hight risk destination
            return fees;
        }
        public double Zone3(double itemPrice)
        {
            double fees = itemPrice * 0.08;
            return fees;
        }
        public double Zone4(double itemPrice)
        {
            double fees = itemPrice * 0.04;
            fees += 25;//hight risk destination
            return fees; 
        }
    }
}
