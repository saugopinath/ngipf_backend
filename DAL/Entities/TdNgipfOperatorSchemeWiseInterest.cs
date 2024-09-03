using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("td_ngipf_operator_scheme_wise_interest", Schema = "ingipfund")]
public partial class TdNgipfOperatorSchemeWiseInterest
{
    [Key]
    [Column("int_td_ngipf_op_interest_id")]
    [Precision(22, 0)]
    public decimal IntTdNgipfOpInterestId { get; set; }

    [Column("int_scheme_id")]
    public int? IntSchemeId { get; set; }

    [Column("int_pl_operator_id")]
    public int? IntPlOperatorId { get; set; }

    [Column("int_treasury_code")]
    [StringLength(10)]
    public string? IntTreasuryCode { get; set; }

    [Column("scheme_code")]
    [Precision(22, 0)]
    public decimal? SchemeCode { get; set; }

    [Column("interest")]
    [Precision(22, 2)]
    public decimal? Interest { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("dml_status_flag")]
    [Precision(22, 0)]
    public decimal? DmlStatusFlag { get; set; }

    [Column("created_timestamp")]
    public DateOnly? CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly? ModifiedTimestamp { get; set; }

    [Column("int_tr43_bill_group_id")]
    [Precision(22, 0)]
    public decimal? IntTr43BillGroupId { get; set; }

    [Column("interest_year")]
    [Precision(22, 0)]
    public decimal? InterestYear { get; set; }

    [ForeignKey("IntSchemeId")]
    [InverseProperty("TdNgipfOperatorSchemeWiseInterests")]
    public virtual MdGenSchemeHead? IntScheme { get; set; }

    [ForeignKey("IntTr43BillGroupId")]
    [InverseProperty("TdNgipfOperatorSchemeWiseInterests")]
    public virtual PfTmTrBillHdr? IntTr43BillGroup { get; set; }

    public virtual MmGenTreasury? IntTreasuryCodeNavigation { get; set; }
}
