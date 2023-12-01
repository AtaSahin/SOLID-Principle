using System;

namespace Solid.App.OCPGood
{
    public class SalaryCalculator2
    {
        public interface ISalaryCalculate
        {
            decimal Calculate(decimal salary);
        }

        public class LowSalaryCalculate : ISalaryCalculate
        {
            public decimal Calculate(decimal salary)
            {
                return salary * 1;
            }
        }

        public class MiddleSalaryCalculate : ISalaryCalculate
        {
            public decimal Calculate(decimal salary)
            {
                return salary * 2;
            }
        }

        public class HighSalaryCalculate : ISalaryCalculate
        {
            public decimal Calculate(decimal salary)
            {
                return salary * 4;
            }
        }
        public class ExtraSalaryCalculate : ISalaryCalculate
        {
            public decimal Calculate(decimal salary)
            {
                return salary * 5;
            }
        }
        private readonly ISalaryCalculate _salaryCalculate;

        public SalaryCalculator2(ISalaryCalculate salaryCalculate)
        {
            _salaryCalculate = salaryCalculate;
        }

        public decimal Calculate(decimal salary)
        {
            return _salaryCalculate.Calculate(salary);
        }
    }
}
