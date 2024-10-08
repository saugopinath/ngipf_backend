﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Keyless]
[Table("hr_md_emp_pay_benf_info", Schema = "ihrms_emp_master")]
public partial class HrMdEmpPayBenfInfo
{
    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("last_updated_on", TypeName = "timestamp without time zone")]
    public DateTime LastUpdatedOn { get; set; }

    [Column("benf_id")]
    [StringLength(38)]
    public string? BenfId { get; set; }

    [Column("int_emp_benf_id_old")]
    [StringLength(38)]
    public string? IntEmpBenfIdOld { get; set; }

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
    public int? RequestId { get; set; }

    [Column("int_emp_benf_id")]
    public int IntEmpBenfId { get; set; }
}
