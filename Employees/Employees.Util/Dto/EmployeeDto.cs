namespace Employees.Util.Dto
{
    using Employees.Util.Enums;

    public class EmployeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ContractTypeName ContractTypeName { get; set; }
        public string ContractTypeDescription { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public double HourlySalary { get; set; }
        public double MonthlySalary { get; set; }
        public double Salary { get; set; }
    }
}
