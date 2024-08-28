using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("hr_md_emp_salary_head_map_aud", Schema = "ihrms")]
[Index("IntEmpSalaryHeadMapId", Name = "ind_hr_md_emp_sal_hd_mp_aud1")]
[Index("IntEmployeeId", Name = "ind_hr_md_emp_sal_hd_mp_aud2")]
[Index("RequestId", Name = "ind_hr_md_emp_sal_hd_mp_aud3")]
public partial class HrMdEmpSalaryHeadMapAud
{
    [Key]
    [Column("int_emp_salary_head_map_aud_id")]
    [StringLength(38)]
    public string IntEmpSalaryHeadMapAudId { get; set; } = null!;

    [Column("int_emp_salary_head_map_id")]
    [StringLength(38)]
    public string? IntEmpSalaryHeadMapId { get; set; }

    [Column("int_employee_id")]
    [Precision(38, 0)]
    public BigInteger? IntEmployeeId { get; set; }

    [Column("int_ddo_salary_head_map_id")]
    [StringLength(38)]
    public string? IntDdoSalaryHeadMapId { get; set; }

    [Column("active_flag")]
    [StringLength(2)]
    public string? ActiveFlag { get; set; }

    [Column("wef", TypeName = "timestamp(0) without time zone")]
    public DateTime? Wef { get; set; }

    [Column("effective_end_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? EffectiveEndDate { get; set; }

    [Column("last_updated_by")]
    public int? LastUpdatedBy { get; set; }

    [Column("last_updated_on", TypeName = "timestamp without time zone")]
    public DateTime? LastUpdatedOn { get; set; }

    [Column("last_updated_by_role")]
    public int? LastUpdatedByRole { get; set; }

    [Column("remarks")]
    [StringLength(300)]
    public string? Remarks { get; set; }

    [Column("request_id")]
    public long? RequestId { get; set; }

    [Column("go_order_number")]
    [StringLength(50)]
    public string? GoOrderNumber { get; set; }

    [Column("go_order_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? GoOrderDate { get; set; }
}
