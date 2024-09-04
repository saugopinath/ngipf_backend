using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("pl_pf_ddo_hoa_map", Schema = "ngipf_master")]
public partial class PlPfDdoHoaMap
{
    [Column("int_operator_id")]
    public int IntOperatorId { get; set; }

    [Column("int_ddo_id")]
    public int IntDdoId { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string ActiveFlag { get; set; } = null!;

    [Column("role_id")]
    public int? RoleId { get; set; }

    [Column("local_global_flag")]
    [StringLength(1)]
    public string? LocalGlobalFlag { get; set; }

    [Column("int_hoa_id")]
    public int IntHoaId { get; set; }

    [Column("created_by")]
    public int? CreatedBy { get; set; }

    [Column("last_updated_by")]
    public int? LastUpdatedBy { get; set; }

    [Column("deleted_by")]
    public int? DeletedBy { get; set; }

    [Column("created_at", TypeName = "timestamp without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("last_updated_at", TypeName = "timestamp without time zone")]
    public DateTime? LastUpdatedAt { get; set; }

    [Column("deleted_at", TypeName = "timestamp without time zone")]
    public DateTime? DeletedAt { get; set; }

    [Column("int_treasury_id")]
    public int IntTreasuryId { get; set; }

    [Column("int_scheme_id")]
    public int IntSchemeId { get; set; }

    [Key]
    [Column("int_pl_pf_ddo_map")]
    public int IntPlPfDdoMap { get; set; }

    [ForeignKey("IntDdoId")]
    [InverseProperty("PlPfDdoHoaMaps")]
    public virtual MmGenDdo IntDdo { get; set; } = null!;

    [ForeignKey("IntHoaId")]
    [InverseProperty("PlPfDdoHoaMaps")]
    public virtual NgipfHoaList IntHoa { get; set; } = null!;

    [ForeignKey("IntOperatorId")]
    [InverseProperty("PlPfDdoHoaMaps")]
    public virtual TMmGenPlOperator IntOperator { get; set; } = null!;

    [ForeignKey("IntSchemeId")]
    [InverseProperty("PlPfDdoHoaMaps")]
    public virtual MdGenSchemeHead IntScheme { get; set; } = null!;

    [ForeignKey("IntTreasuryId")]
    [InverseProperty("PlPfDdoHoaMaps")]
    public virtual MmGenTreasury IntTreasury { get; set; } = null!;
}
