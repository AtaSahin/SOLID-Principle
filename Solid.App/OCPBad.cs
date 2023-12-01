using System;

namespace Solid.App.OCPBad
{
    public class SalaryCalculator
    {
        public decimal Calculate(decimal salary, SalaryType salaryType)
        {
            switch (salaryType)
            {
                case SalaryType.Low:
                    return salary * 1.1m;
                case SalaryType.Middle:
                    return salary * 1.2m;
                case SalaryType.High:
                    return salary * 1.3m;
                default:
                    throw new ArgumentException("Geçersiz maaş tipi");
            }
        }
    }

    public enum SalaryType
    {
        Low,
        Middle,
        High
          
    }
}
