using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("hr_md_emp_pay_benf_aud", Schema = "ihrms")]
public partial class HrMdEmpPayBenfAud
{
    [Key]
    [Column("int_emp_benf_aud_id")]
    [StringLength(38)]
    public string IntEmpBenfAudId { get; set; } = null!;

    [Column("int_emp_benf_id")]
    [StringLength(38)]
    public string IntEmpBenfId { get; set; } = null!;

    [Column("int_employee_id")]
    [Precision(38, 0)]
    public BigInteger IntEmployeeId { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string ActiveFlag { get; set; } = null!;

    [Column("last_updated_by")]
    public int LastUpdatedBy { get; set; }

    [Column("last_updated_on", TypeName = "timestamp(6) without time zone")]
    public DateTime LastUpdatedOn { get; set; }

    [Column("last_updated_by_role")]
    public int? LastUpdatedByRole { get; set; }

    [Column("benf_id")]
    [StringLength(38)]
    public string BenfId { get; set; } = null!;

    [Column("request_id")]
    public long RequestId { get; set; }
}
