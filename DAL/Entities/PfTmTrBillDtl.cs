using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("pf_tm_tr_bill_dtls", Schema = "ingipfund")]
public partial class PfTmTrBillDtl
{
    [Key]
    [Column("int_tr43_bill_dtls_id")]
    [Precision(22, 0)]
    public decimal IntTr43BillDtlsId { get; set; }

    [Column("int_tr43_bill_group_id")]
    [Precision(22, 0)]
    public decimal? IntTr43BillGroupId { get; set; }

    [Column("int_employee_id")]
    [Precision(22, 0)]
    public BigInteger? IntEmployeeId { get; set; }

    [Column("balance_amt")]
    [Precision(22, 0)]
    public decimal? BalanceAmt { get; set; }

    [Column("interest_amt")]
    [Precision(22, 2)]
    public decimal? InterestAmt { get; set; }

    [Column("gross_amt")]
    [Precision(22, 0)]
    public decimal? GrossAmt { get; set; }

    [Column("unauthorised_amt")]
    [Precision(22, 0)]
    public decimal? UnauthorisedAmt { get; set; }

    [Column("dml_status_flag")]
    [Precision(22, 0)]
    public decimal? DmlStatusFlag { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("created_by_user")]
    [Precision(22, 0)]
    public decimal? CreatedByUser { get; set; }

    [Column("created_by_role")]
    [Precision(22, 0)]
    public decimal? CreatedByRole { get; set; }

    [Column("created_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedTimestamp { get; set; }

    [Column("modified_by_user")]
    [Precision(22, 0)]
    public decimal? ModifiedByUser { get; set; }

    [Column("modified_by_role")]
    [Precision(22, 0)]
    public decimal? ModifiedByRole { get; set; }

    [Column("modified_timestamp")]
    public DateOnly? ModifiedTimestamp { get; set; }

    [Column("remarks")]
    [StringLength(100)]
    public string? Remarks { get; set; }

    [Column("interest_upto")]
    public DateOnly? InterestUpto { get; set; }

    [Column("sanction_id")]
    [StringLength(20)]
    public string? SanctionId { get; set; }

    [Column("payment_authority_id")]
    [StringLength(14)]
    public string? PaymentAuthorityId { get; set; }

    [Column("payment_authority_date")]
    public DateOnly? PaymentAuthorityDate { get; set; }

    [Column("hoo_code")]
    [StringLength(30)]
    public string? HooCode { get; set; }

    [Column("interest_verified_status")]
    [StringLength(1)]
    public string? InterestVerifiedStatus { get; set; }

    [Column("verified_by")]
    [StringLength(100)]
    public string? VerifiedBy { get; set; }

    [Column("verified_date")]
    public DateOnly? VerifiedDate { get; set; }

    [Column("exclude_flag")]
    [StringLength(1)]
    public string? ExcludeFlag { get; set; }

    [Column("emp_working_pl_id")]
    [Precision(22, 0)]
    public decimal? EmpWorkingPlId { get; set; }

    [Column("int_pl_operator_id")]
    public int? IntPlOperatorId { get; set; }

    [Column("int_treasury_code")]
    [StringLength(7)]
    public string? IntTreasuryCode { get; set; }

    public virtual HrMmEmpBasicDtl? IntEmployee { get; set; }

    [ForeignKey("IntPlOperatorId")]
    [InverseProperty("PfTmTrBillDtls")]
    public virtual TMmGenPlOperator? IntPlOperator { get; set; }

    public virtual MmGenTreasury? IntTreasuryCodeNavigation { get; set; }
}
