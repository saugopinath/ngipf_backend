using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("mm_gen_department", Schema = "ifmsadmin")]
[Index("DepartmentCode", Name = "mm_gen_department_department_code_key", IsUnique = true)]
public partial class MmGenDepartment
{
    [Column("department_code")]
    [StringLength(2)]
    public string DepartmentCode { get; set; } = null!;

    [Column("description")]
    [StringLength(200)]
    public string? Description { get; set; }

    [Column("demand_no")]
    [StringLength(2)]
    public string? DemandNo { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("dept_code")]
    [StringLength(60)]
    public string? DeptCode { get; set; }

    [Column("int_dept_id_old")]
    [StringLength(38)]
    public string? IntDeptIdOld { get; set; }

    [Key]
    [Column("int_dept_id")]
    public int IntDeptId { get; set; }

    [Column("created_user_id_old")]
    [StringLength(38)]
    public string? CreatedUserIdOld { get; set; }

    [Column("created_user_id")]
    public int? CreatedUserId { get; set; }

    [Column("modified_user_id_old")]
    [StringLength(38)]
    public string? ModifiedUserIdOld { get; set; }

    [Column("modified_user_id")]
    public int? ModifiedUserId { get; set; }

    public virtual ICollection<DeptHoaMapping> DeptHoaMappings { get; set; } = new List<DeptHoaMapping>();
}
