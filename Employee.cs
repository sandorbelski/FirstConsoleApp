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

        public int getIncomeSum(int startIncome) {
            int resultIncome = 0;
            if (this.experienceYears > 5) {
                resultIncome = startIncome + startIncome / 100 * 10;
            }
            if (this.numberOfPassedExams > 10) {
                resultIncome = resultIncome / 100 * 15;
            }
            return resultIncome;
        }

    }
}