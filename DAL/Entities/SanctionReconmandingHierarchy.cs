using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Keyless]
[Table("sanction_reconmanding_hierarchy", Schema = "ngipf")]
[Index("IntHoaCode", Name = "fki_Gopinath Sau")]
[Index("SanctionNature", Name = "fki_fk")]
[Index("LfPlOperatorId", Name = "fki_fk_lf_pl_operator_id")]
public partial class SanctionReconmandingHierarchy
{
    [Column("lf_pl_operator_id")]
    public int? LfPlOperatorId { get; set; }

    [Column("sanction_nature")]
    public short? SanctionNature { get; set; }

    [Column("sanction_count")]
    public short? SanctionCount { get; set; }

    [Column("sanction_auth_designation")]
    public short? SanctionAuthDesignation { get; set; }

    [Column("recommending_auth_required")]
    public bool? RecommendingAuthRequired { get; set; }

    [Column("recommending_count")]
    public short? RecommendingCount { get; set; }

    [Column("recommending_nature")]
    public short? RecommendingNature { get; set; }

    [Column("int_hoa_code")]
    public int? IntHoaCode { get; set; }
}
