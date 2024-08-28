using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("hr_md_cgm_appt_auth_map", Schema = "ihrms")]
[Index("IntDeptId", "IntCadreId", "IntGrpId", "IntAppAuthorityId", "MappByAppAuthorityId", Name = "pk_hr_md_gen_cgm_map_uk", IsUnique = true)]
public partial class HrMdCgmApptAuthMap
{
    [Key]
    [Column("md_cgm_appt_auth_map_id")]
    [Precision(38, 0)]
    public decimal MdCgmApptAuthMapId { get; set; }

    [Column("int_app_authority_id")]
    [Precision(38, 0)]
    public decimal IntAppAuthorityId { get; set; }

    [Column("int_cadre_id")]
    [Precision(38, 0)]
    public decimal IntCadreId { get; set; }

    [Column("int_grp_id")]
    [Precision(38, 0)]
    public decimal IntGrpId { get; set; }

    [Column("int_module_id")]
    [Precision(38, 0)]
    public decimal? IntModuleId { get; set; }

    [Column("module_flag")]
    public short ModuleFlag { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("dml_status_flag")]
    public short DmlStatusFlag { get; set; }

    [Column("created_user_id")]
    public int CreatedUserId { get; set; }

    [Column("modified_user_id")]
    public int ModifiedUserId { get; set; }

    [Column("created_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime CreatedTimestamp { get; set; }

    [Column("modified_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime ModifiedTimestamp { get; set; }

    [Column("int_dept_id")]
    public short? IntDeptId { get; set; }

    [Column("demand_no")]
    [StringLength(2)]
    public string? DemandNo { get; set; }

    [Column("mapp_by_app_authority_id")]
    [Precision(38, 0)]
    public decimal? MappByAppAuthorityId { get; set; }

    [Column("own_flag")]
    [StringLength(2)]
    public string? OwnFlag { get; set; }
}
