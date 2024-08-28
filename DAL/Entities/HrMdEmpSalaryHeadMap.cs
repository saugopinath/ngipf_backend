using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Keyless]
[Table("hr_md_emp_salary_head_map", Schema = "ihrms_emp_master")]
public partial class HrMdEmpSalaryHeadMap
{
    [Column("remarks")]
    [StringLength(300)]
    public string? Remarks { get; set; }

    [Column("active_flag")]
    [StringLength(2)]
    public string? ActiveFlag { get; set; }

    [Column("wef")]
    public DateOnly? Wef { get; set; }

    [Column("effective_end_date")]
    public DateOnly? EffectiveEndDate { get; set; }

    [Column("last_updated_on", TypeName = "timestamp without time zone")]
    public DateTime? LastUpdatedOn { get; set; }

    [Column("go_order_number")]
    [StringLength(50)]
    public string? GoOrderNumber { get; set; }

    [Column("go_order_date")]
    public DateOnly? GoOrderDate { get; set; }

    [Column("int_emp_salary_head_map_id_old")]
    [StringLength(38)]
    public string? IntEmpSalaryHeadMapIdOld { get; set; }

    [Column("int_ddo_salary_head_map_id_old")]
    [StringLength(38)]
    public string? IntDdoSalaryHeadMapIdOld { get; set; }

    [Column("int_employee_id_old")]
    [StringLength(38)]
    public string? IntEmployeeIdOld { get; set; }

    [Column("int_employee_id")]
    public int? IntEmployeeId { get; set; }

    [Column("last_updated_by_old")]
    [StringLength(38)]
    public string? LastUpdatedByOld { get; set; }

    [Column("last_updated_by")]
    public int? LastUpdatedBy { get; set; }

    [Column("last_updated_by_role_old")]
    [StringLength(38)]
    public string? LastUpdatedByRoleOld { get; set; }

    [Column("last_updated_by_role")]
    public int? LastUpdatedByRole { get; set; }

    [Column("request_id_old")]
    [StringLength(38)]
    public string? RequestIdOld { get; set; }

    [Column("request_id")]
    public long? RequestId { get; set; }

    [Column("int_ddo_salary_head_map_id")]
    public int? IntDdoSalaryHeadMapId { get; set; }

    [Column("int_emp_salary_head_map_id")]
    public int IntEmpSalaryHeadMapId { get; set; }

    [ForeignKey("IntDdoSalaryHeadMapId")]
    public virtual HrMdGenDdoSalaryHeadMap? IntDdoSalaryHeadMap { get; set; }

    [ForeignKey("IntEmployeeId")]
    public virtual HrMmEmpBasicDtl? IntEmployee { get; set; }

    [ForeignKey("RequestId")]
    public virtual HrMmGenWorkflowMaster? Request { get; set; }
}
