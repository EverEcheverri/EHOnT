namespace Employees.Util.Enums
{
    using System.ComponentModel;

    public enum ContractTypeName
    {
        [Description("Hourly Salary")]
        HourlySalaryEmployee = 1,
        [Description("Monthly Salary")]
        MonthlySalaryEmployee = 2

    }
}
