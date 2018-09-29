namespace Employees.Util.Dto
{
    using Employees.Util.Enum;

    public class EmployeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ContractType ContractTypeName { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
    }
}
