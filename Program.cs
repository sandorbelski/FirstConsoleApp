// See https://aka.ms/new-console-template for more information


using FirstConsoleApp;


Console.WriteLine(">>>>>>>> hello, welcome to the program version 0.0.3 <<<<<<<<<");

string? employeerFNLN;

Console.WriteLine("enter employeer's first & last name: ");

employeerFNLN = Console.ReadLine();
string[] fnlnArr = employeerFNLN!.Split(" ");



Console.WriteLine("income");

int startIncome = Convert.ToInt32(Console.ReadLine());

Employee epl = new Employee(fnlnArr[0], fnlnArr[1], 7, 10);

int income = epl.getIncomeSum(startIncome);

int incomeTax;
int socialinsurance;
int additionalMedicalinsurance;
int pensionFund;
int charityFees;

incomeTax = 5;

additionalMedicalinsurance = 10;
pensionFund = 5;
charityFees = 1;

socialinsurance = getSocialInsurance(income);

int incomeTaxSum = income / 100 * incomeTax;
int socialinsuranceSum = income / 100 * socialinsurance;
int additionalMedicalinsuranceSum = income / 100 * additionalMedicalinsurance;
int pensionFundSum = income / 100 * pensionFund;
int charityFeeSum = income / 100 * charityFees;

int totalFees = sumAllFees(incomeTaxSum, socialinsuranceSum,
                            additionalMedicalinsuranceSum, pensionFundSum,
                            charityFeeSum);

int salarynetto = income - totalFees;

printInfo(epl.firstName, epl.lastName, totalFees, salarynetto);

static int sumAllFees(int incomeTaxSum, int socialinsuranceSum, int additionalMedicalinsuranceSum, int pensionFundSum, int charityFeeSum)
{
    return incomeTaxSum + socialinsuranceSum + additionalMedicalinsuranceSum + pensionFundSum + charityFeeSum;
}

static int getSocialInsurance(int income)
{
    int socialinsurance;
    if (income < 2000)
    {
        socialinsurance = 5;
    }
    else if (income >= 2000 && income < 5000)
    {
        socialinsurance = 10;
    }
    else
    {
        socialinsurance = 35;
    }

    return socialinsurance;
}

static void printInfo(string? employeerFN, string? employeerLN, int totalFees, int salarynetto)
{
    System.Console.WriteLine("Fees" + totalFees);
    System.Console.WriteLine("salary" + employeerFN + " " + employeerLN + "is" + salarynetto);
}