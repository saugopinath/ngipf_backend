using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("tm_pf_final_payment", Schema = "ngipf")]
[Index("IntRequestId", Name = "uk_tm_gpf_final_payment1", IsUnique = true)]
[Index("SanctionId", Name = "uk_tm_gpf_final_payment2", IsUnique = true)]
[Index("PaymentAuthorityNo", Name = "uk_tm_gpf_final_payment3", IsUnique = true)]
public partial class TmPfFinalPayment
{
    [Key]
    [Column("int_final_payment_id")]
    [StringLength(38)]
    public string IntFinalPaymentId { get; set; } = null!;

    [Column("int_request_id")]
    public long IntRequestId { get; set; }

    [Column("int_employee_id")]
    [StringLength(38)]
    public string IntEmployeeId { get; set; } = null!;

    [Column("int_cessation_type_id")]
    [StringLength(38)]
    public string IntCessationTypeId { get; set; } = null!;

    [Column("cessation_date", TypeName = "timestamp(0) without time zone")]
    public DateTime CessationDate { get; set; }

    [Column("request_type")]
    [MaxLength(1)]
    public char RequestType { get; set; }

    [Column("sanction_id")]
    [StringLength(20)]
    public string? SanctionId { get; set; }

    [Column("sanction_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? SanctionDate { get; set; }

    [Column("sanction_order_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? SanctionOrderDate { get; set; }

    [Column("calculation_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? CalculationDate { get; set; }

    [Column("last_subscrptn_month")]
    public short? LastSubscrptnMonth { get; set; }

    [Column("last_subscrptn_year")]
    public short? LastSubscrptnYear { get; set; }

    [Column("closing_balance")]
    [Precision(14, 2)]
    public decimal? ClosingBalance { get; set; }

    [Column("calculate_upto_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? CalculateUptoDate { get; set; }

    [Column("fin_year_from")]
    public short? FinYearFrom { get; set; }

    [Column("int_treasury_code")]
    [StringLength(5)]
    public string? IntTreasuryCode { get; set; }

    [Column("token_number")]
    public int? TokenNumber { get; set; }

    [Column("voucher_number")]
    [StringLength(9)]
    public string? VoucherNumber { get; set; }

    [Column("voucher_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? VoucherDate { get; set; }

    [Column("ref_no")]
    [Precision(30, 0)]
    public decimal? RefNo { get; set; }

    [Column("close_flag")]
    [MaxLength(1)]
    public char CloseFlag { get; set; }

    [Column("int_cancel_id")]
    [StringLength(38)]
    public string? IntCancelId { get; set; }

    [Column("prev_sanction_id")]
    [StringLength(20)]
    public string? PrevSanctionId { get; set; }

    [Column("dml_status_flag")]
    public short DmlStatusFlag { get; set; }

    [Column("user_id")]
    public int UserId { get; set; }

    [Column("created_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime CreatedTimestamp { get; set; }

    [Column("modified_user_id")]
    public int ModifiedUserId { get; set; }

    [Column("modified_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime ModifiedTimestamp { get; set; }

    [Column("remarks")]
    [StringLength(200)]
    public string? Remarks { get; set; }

    [Column("source_type")]
    [StringLength(1)]
    public string SourceType { get; set; } = null!;

    [Column("int_ddo_id")]
    public int? IntDdoId { get; set; }

    [Column("payment_authority_no")]
    [StringLength(14)]
    public string? PaymentAuthorityNo { get; set; }

    [Column("prev_payment_authority_no")]
    [StringLength(14)]
    public string? PrevPaymentAuthorityNo { get; set; }

    [Column("payment_authority_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? PaymentAuthorityDate { get; set; }

    [Column("office_code")]
    [StringLength(30)]
    public string? OfficeCode { get; set; }

    [Column("prev_int_final_payment_id")]
    [StringLength(38)]
    public string? PrevIntFinalPaymentId { get; set; }

    [Column("s_auth_declaration1")]
    [StringLength(2)]
    public string? SAuthDeclaration1 { get; set; }

    [Column("s_auth_declaration2")]
    [StringLength(2)]
    public string? SAuthDeclaration2 { get; set; }

    [Column("year_closing_balance")]
    [Precision(10, 2)]
    public decimal? YearClosingBalance { get; set; }

    [Column("year_closing_interest")]
    [Precision(10, 2)]
    public decimal? YearClosingInterest { get; set; }

    [Column("year_closing_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? YearClosingDate { get; set; }

    [Column("bill_include_flag")]
    [StringLength(2)]
    public string? BillIncludeFlag { get; set; }

    [Column("bal_cap_reject_id")]
    [StringLength(38)]
    public string? BalCapRejectId { get; set; }
}
