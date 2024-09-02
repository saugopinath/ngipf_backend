using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("ngipf_hoa_list", Schema = "ngipf_master")]
public partial class NgipfHoaList
{
    [Key]
    [Column("int_hoa_id")]
    public int IntHoaId { get; set; }

    [Column("hoa")]
    [StringLength(50)]
    public string Hoa { get; set; } = null!;

    [Column("active_flag")]
    [StringLength(2)]
    public string? ActiveFlag { get; set; }

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

    [Column("int_scheme_id")]
    public int? IntSchemeId { get; set; }

    [ForeignKey("IntSchemeId")]
    [InverseProperty("NgipfHoaLists")]
    public virtual MdGenSchemeHead? IntScheme { get; set; }

    [InverseProperty("IntHoa")]
    public virtual ICollection<InterestDateExceptionMst> InterestDateExceptionMsts { get; set; } = new List<InterestDateExceptionMst>();

    [InverseProperty("IntHoa")]
    public virtual ICollection<InterestRateExceptionMst> InterestRateExceptionMsts { get; set; } = new List<InterestRateExceptionMst>();

    [InverseProperty("IntHoa")]
    public virtual ICollection<PlPfDdoHoaMap> PlPfDdoHoaMaps { get; set; } = new List<PlPfDdoHoaMap>();

    [InverseProperty("IntHoa")]
    public virtual StakeHolderMapping? StakeHolderMapping { get; set; }

    [InverseProperty("IntHoa")]
    public virtual ICollection<WorkflowMasterCode> WorkflowMasterCodes { get; set; } = new List<WorkflowMasterCode>();
}
