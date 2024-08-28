using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("emp_monthly_salary_temp", Schema = "ngipf")]
public partial class EmpMonthlySalaryTemp
{
    [Column("xmldata", TypeName = "xml")]
    public string? Xmldata { get; set; }

    [Column("source")]
    public int? Source { get; set; }

    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("createdAt")]
    public DateTime CreatedAt { get; set; }

    [Column("ip_address", TypeName = "character varying")]
    public string? IpAddress { get; set; }

    [Column("jsondata", TypeName = "jsonb")]
    public string? Jsondata { get; set; }
}
