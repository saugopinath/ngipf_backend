using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("hr_mm_gen_employment_type", Schema = "ihrms_master")]
public partial class HrMmGenEmploymentType
{
    [Column("EMP_TYPE_CODE")]
    [StringLength(2)]
    public string? EmpTypeCode { get; set; }

    [Column("EMP_TYPE_DESC")]
    [StringLength(50)]
    public string? EmpTypeDesc { get; set; }

    [Column("WEF_DATE", TypeName = "timestamp without time zone")]
    public DateTime? WefDate { get; set; }

    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("CREATED_TIMESTAMP")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("MODIFIED_TIMESTAMP")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("INT_EMP_TYPE_ID_old")]
    [StringLength(38)]
    public string? IntEmpTypeIdOld { get; set; }

    [Column("INT_EMP_TYPE_ID")]
    public int? IntEmpTypeId { get; set; }

    [Column("EMP_TYPE_ID_old")]
    [StringLength(38)]
    public string? EmpTypeIdOld { get; set; }

    [Column("EMP_TYPE_ID")]
    public int? EmpTypeId { get; set; }

    [Column("CREATED_USER_ID_old")]
    [StringLength(38)]
    public string? CreatedUserIdOld { get; set; }

    [Column("CREATED_USER_ID")]
    public int? CreatedUserId { get; set; }

    [Column("MODIFIED_USER_ID_old")]
    [StringLength(38)]
    public string? ModifiedUserIdOld { get; set; }

    [Column("MODIFIED_USER_ID")]
    public int? ModifiedUserId { get; set; }
}
