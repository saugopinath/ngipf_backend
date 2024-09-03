using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("mm_hoa_pf_admin", Schema = "ingipfund")]
public partial class MmHoaPfAdmin
{
    [Key]
    [Column("int_hoa_pf_admin_id")]
    [Precision(22, 0)]
    public decimal IntHoaPfAdminId { get; set; }

    [Column("functionality_type")]
    [StringLength(30)]
    public string? FunctionalityType { get; set; }

    [Column("int_scheme_id")]
    public int? IntSchemeId { get; set; }

    [Column("int_pl_operator_id")]
    public int? IntPlOperatorId { get; set; }

    [Column("sanc_auth_count")]
    public short? SancAuthCount { get; set; }

    [Column("recom_auth_count")]
    public short? RecomAuthCount { get; set; }

    [Column("parent_id")]
    [Precision(22, 0)]
    public decimal? ParentId { get; set; }

    [Column("wef")]
    public DateOnly? Wef { get; set; }

    [Column("active_flag")]
    [MaxLength(1)]
    public char? ActiveFlag { get; set; }

    [Column("dml_status_flag")]
    [Precision(22, 0)]
    public decimal? DmlStatusFlag { get; set; }

    [Column("created_user_id")]
    [Precision(22, 0)]
    public decimal? CreatedUserId { get; set; }

    [Column("created_date")]
    public DateOnly? CreatedDate { get; set; }

    [Column("modified_user_id")]
    [Precision(22, 0)]
    public decimal? ModifiedUserId { get; set; }

    [Column("modified_date")]
    public DateOnly? ModifiedDate { get; set; }

    [Column("sanc_office_type_id")]
    [Precision(38, 0)]
    public decimal? SancOfficeTypeId { get; set; }

    [Column("recom_office_type_id")]
    [Precision(38, 0)]
    public decimal? RecomOfficeTypeId { get; set; }

    [Column("sanction_auth_nature")]
    public short? SanctionAuthNature { get; set; }

    [Column("reco_auth_nature")]
    public short? RecoAuthNature { get; set; }

    [Column("reco_auth_required")]
    public bool? RecoAuthRequired { get; set; }

    [ForeignKey("IntPlOperatorId")]
    [InverseProperty("MmHoaPfAdmins")]
    public virtual TMmGenPlOperator? IntPlOperator { get; set; }

    [ForeignKey("IntSchemeId")]
    [InverseProperty("MmHoaPfAdmins")]
    public virtual MdGenSchemeHead? IntScheme { get; set; }

    [ForeignKey("RecoAuthNature")]
    [InverseProperty("MmHoaPfAdmins")]
    public virtual RecomandingAuthorityNatureMaster? RecoAuthNatureNavigation { get; set; }

    [ForeignKey("RecomAuthCount")]
    [InverseProperty("MmHoaPfAdmins")]
    public virtual RecomandingAuthorityNatureCountMaster? RecomAuthCountNavigation { get; set; }

    [ForeignKey("RecomOfficeTypeId")]
    [InverseProperty("MmHoaPfAdminRecomOfficeTypes")]
    public virtual MmGenNgipfOffice? RecomOfficeType { get; set; }

    [ForeignKey("SancAuthCount")]
    [InverseProperty("MmHoaPfAdmins")]
    public virtual SancctionAuthorityNatureCountMaster? SancAuthCountNavigation { get; set; }

    [ForeignKey("SancOfficeTypeId")]
    [InverseProperty("MmHoaPfAdminSancOfficeTypes")]
    public virtual MmGenNgipfOffice? SancOfficeType { get; set; }

    [ForeignKey("SanctionAuthNature")]
    [InverseProperty("MmHoaPfAdmins")]
    public virtual SancctionAuthorityNatureMaster? SanctionAuthNatureNavigation { get; set; }
}
