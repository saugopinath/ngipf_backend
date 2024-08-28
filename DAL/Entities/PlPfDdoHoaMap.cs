using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("pl_pf_ddo_hoa_map", Schema = "ngipf_master")]
public partial class PlPfDdoHoaMap
{
    [Key]
    [Column("int_pl_pf_ddo_map_old")]
    [StringLength(38)]
    public string IntPlPfDdoMapOld { get; set; } = null!;

    [Column("int_operator_id")]
    public int IntOperatorId { get; set; }

    [Column("int_ddo_id")]
    public int IntDdoId { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string ActiveFlag { get; set; } = null!;

    [Column("created_time_stamp", TypeName = "timestamp(6) without time zone")]
    public DateTime CreatedTimeStamp { get; set; }

    [Column("created_user_id")]
    [StringLength(6)]
    public string CreatedUserId { get; set; } = null!;

    [Column("modified_time_stamp", TypeName = "timestamp(6) without time zone")]
    public DateTime? ModifiedTimeStamp { get; set; }

    [Column("modified_user_id")]
    [StringLength(6)]
    public string? ModifiedUserId { get; set; }

    [Column("dml_status_flag")]
    public short DmlStatusFlag { get; set; }

    [Column("role_id")]
    public int? RoleId { get; set; }

    [Column("local_global_flag")]
    [StringLength(1)]
    public string LocalGlobalFlag { get; set; } = null!;

    [Column("hoa_id")]
    public int HoaId { get; set; }

    [ForeignKey("HoaId")]
    [InverseProperty("PlPfDdoHoaMaps")]
    public virtual MmGenHoa Hoa { get; set; } = null!;

    [ForeignKey("IntDdoId")]
    [InverseProperty("PlPfDdoHoaMaps")]
    public virtual MmGenDdo IntDdo { get; set; } = null!;

    [ForeignKey("IntOperatorId")]
    [InverseProperty("PlPfDdoHoaMaps")]
    public virtual TMmGenPlOperator IntOperator { get; set; } = null!;
}
