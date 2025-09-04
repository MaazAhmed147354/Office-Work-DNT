using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblBranchUserInfo
{
    public int Id { get; set; }

    public int? EmployeeId { get; set; }

    public int? EmployeeCode { get; set; }

    public int? Designation { get; set; }

    public string? JoiningDate { get; set; }

    public decimal? BasicSalary { get; set; }

    public decimal? ConveyanceAllowance { get; set; }

    public decimal? HouseRentAllowance { get; set; }

    public decimal? MedicalAllowance { get; set; }

    public decimal? EducationAllowance { get; set; }

    public decimal? MobileAllowance { get; set; }

    public string? BankName { get; set; }

    public string? AccountNumber { get; set; }

    public string? Image { get; set; }
}
