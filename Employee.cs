using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    public class Employee
    {
        public string firstName;
        public string lastName;
        int experienceYears;
        int numberOfPassedExams;
        
        public Employee(string fn, string ln, int eY, int nopex) {
            this.firstName = fn;
            this.lastName = ln;
            this.experienceYears = eY;
            this.numberOfPassedExams = nopex;
        }


        // TODO: Add Description for the method
        public int getIncomeSum(int startIncome)
        {
            int resultIncome = 0;
            if (this.experienceYears > 5) {
                resultIncome = startIncome + startIncome / 100 * 10;
            }
            if (this.numberOfPassedExams > 10) {
                resultIncome = resultIncome / 100 * 15;
            }
            if (startIncome <= 0) {
                resultIncome = -1;
            }
            if (this.experienceYears <= 0) {
                resultIncome = -1;
            }
            if (this.numberOfPassedExams <= 0) {
                resultIncome = -1;
            }
            return resultIncome;
        }

    }
}