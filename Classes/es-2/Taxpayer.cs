using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Taxpayer
    {
        public string Ssn {get; private set;}
        public double YearlyGrossIncome {get; private set;}
        private double TaxOwed;

        public Taxpayer(string ssn, double income)
        {
            Ssn = ssn;
            YearlyGrossIncome = income;
            CalculateTaxOwed();
            
        }

        private void CalculateTaxOwed()
        {
            if (YearlyGrossIncome < 15000)
            {
                // Calc 15%
                this.TaxOwed = YearlyGrossIncome * 0.15;
            }
            else 
            {
                // Calc 28%
                this.TaxOwed = YearlyGrossIncome * 0.28;
            }
        }

        public void Print()
        {
            Console.WriteLine(
                "SSN: {0} | Yearly Gross Income: {1} | Tax owed: {2}", 
                Ssn,
                string.Format("{0:N2}", YearlyGrossIncome),
                string.Format("{0:N2}", this.TaxOwed));
        }
    }
}