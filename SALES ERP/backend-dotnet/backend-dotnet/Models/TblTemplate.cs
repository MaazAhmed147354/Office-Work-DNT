using System;
using System.Collections.Generic;

namespace backend_dotnet.Models;

public partial class TblTemplate
{
    public int Id { get; set; }

    public string? Type { get; set; }

    public string? Title { get; set; }

    public string? EmailSubject { get; set; }

    public string? EmailTemplate { get; set; }

    public string? Smstemplate { get; set; }

    public bool? IsEmail { get; set; }

    public bool? IsSms { get; set; }

    public bool? IsReportEmail { get; set; }

    public bool? IsReportSms { get; set; }

    public string? ReportEmails { get; set; }

    public string? ReportSms { get; set; }

    public string? SmsDomain { get; set; }
}
