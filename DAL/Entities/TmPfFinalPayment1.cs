using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("tm_pf_final_payment", Schema = "ingipfund")]
public partial class TmPfFinalPayment1
{
    [Column("pf_closing_balance")]
    [StringLength(30)]
    public string? PfClosingBalance { get; set; }

    [Key]
    [Column("int_final_payment_id")]
    [Precision(38, 0)]
    public decimal IntFinalPaymentId { get; set; }

    [Column("int_request_id")]
    [Precision(15, 0)]
    public decimal? IntRequestId { get; set; }

    [Column("int_employee_id")]
    [Precision(38, 0)]
    public BigInteger? IntEmployeeId { get; set; }

    [Column("int_cessation_type_id")]
    [Precision(38, 0)]
    public decimal? IntCessationTypeId { get; set; }

    [Column("cessation_date")]
    public DateOnly? CessationDate { get; set; }

    [Column("request_type")]
    [MaxLength(1)]
    public char? RequestType { get; set; }

    [Column("sanction_id")]
    [StringLength(20)]
    public string? SanctionId { get; set; }

    [Column("sanction_date")]
    public DateOnly? SanctionDate { get; set; }

    [Column("sanction_order_date")]
    public DateOnly? SanctionOrderDate { get; set; }

    [Column("calculation_date")]
    public DateOnly? CalculationDate { get; set; }

    [Column("last_subscrptn_month")]
    [Precision(2, 0)]
    public decimal? LastSubscrptnMonth { get; set; }

    [Column("last_subscrptn_year")]
    [Precision(4, 0)]
    public decimal? LastSubscrptnYear { get; set; }

    [Column("closing_balance")]
    [Precision(14, 2)]
    public decimal? ClosingBalance { get; set; }

    [Column("calculate_upto_date")]
    public DateOnly? CalculateUptoDate { get; set; }

    [Column("fin_year_from")]
    [Precision(4, 0)]
    public decimal? FinYearFrom { get; set; }

    [Column("int_treasury_code")]
    [StringLength(5)]
    public string? IntTreasuryCode { get; set; }

    [Column("token_number")]
    [Precision(6, 0)]
    public decimal? TokenNumber { get; set; }

    [Column("voucher_number")]
    [StringLength(9)]
    public string? VoucherNumber { get; set; }

    [Column("voucher_date")]
    public DateOnly? VoucherDate { get; set; }

    [Column("ref_no")]
    [Precision(30, 0)]
    public decimal? RefNo { get; set; }

    [Column("close_flag")]
    [MaxLength(1)]
    public char? CloseFlag { get; set; }

    [Column("int_cancel_id")]
    [Precision(38, 0)]
    public decimal? IntCancelId { get; set; }

    [Column("prev_sanction_id")]
    [StringLength(20)]
    public string? PrevSanctionId { get; set; }

    [Column("dml_status_flag")]
    [Precision(1, 0)]
    public decimal? DmlStatusFlag { get; set; }

    [Column("user_id")]
    [Precision(8, 0)]
    public decimal? UserId { get; set; }

    [Column("created_timestamp")]
    public DateOnly? CreatedTimestamp { get; set; }

    [Column("modified_user_id")]
    [Precision(8, 0)]
    public decimal? ModifiedUserId { get; set; }

    [Column("modified_timestamp")]
    public DateOnly? ModifiedTimestamp { get; set; }

    [Column("remarks")]
    [StringLength(200)]
    public string? Remarks { get; set; }

    [Column("source_type")]
    [StringLength(1)]
    public string? SourceType { get; set; }

    [Column("int_ddo_id")]
    public int? IntDdoId { get; set; }

    [Column("payment_authority_no")]
    [StringLength(14)]
    public string? PaymentAuthorityNo { get; set; }

    [Column("prev_payment_authority_no")]
    [StringLength(14)]
    public string? PrevPaymentAuthorityNo { get; set; }

    [Column("payment_authority_date")]
    public DateOnly? PaymentAuthorityDate { get; set; }

    [Column("office_code")]
    [StringLength(30)]
    public string? OfficeCode { get; set; }

    [Column("final_pay_flag")]
    [StringLength(1)]
    public string? FinalPayFlag { get; set; }

    [Column("transfer_to")]
    [StringLength(3)]
    public string? TransferTo { get; set; }

    [Column("transfer_date")]
    public DateOnly? TransferDate { get; set; }

    [Column("prev_int_final_payment_id")]
    [Precision(38, 0)]
    public decimal? PrevIntFinalPaymentId { get; set; }

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

    [Column("year_closing_date")]
    public DateOnly? YearClosingDate { get; set; }

    [Column("bill_include_flag")]
    [StringLength(2)]
    public string? BillIncludeFlag { get; set; }

    [Column("bal_cap_reject_id")]
    [Precision(38, 0)]
    public decimal? BalCapRejectId { get; set; }

    [Column("application_date")]
    public DateOnly? ApplicationDate { get; set; }

    [Column("new_workflow_flag")]
    [StringLength(2)]
    public string? NewWorkflowFlag { get; set; }

    [Column("sqno")]
    [StringLength(30)]
    public string? Sqno { get; set; }

    [Column("confirmed_by")]
    [StringLength(30)]
    public string? ConfirmedBy { get; set; }

    [Column("interest_yearwise_year1")]
    [StringLength(4)]
    public string? InterestYearwiseYear1 { get; set; }

    [Column("interest_yearwise_interest1")]
    [StringLength(20)]
    public string? InterestYearwiseInterest1 { get; set; }

    [Column("interest_yearwise_tilldate1")]
    [StringLength(10)]
    public string? InterestYearwiseTilldate1 { get; set; }

    [Column("interest_yearwise_closebalance1")]
    [StringLength(30)]
    public string? InterestYearwiseClosebalance1 { get; set; }

    [Column("interest_yearwise_year2")]
    [StringLength(4)]
    public string? InterestYearwiseYear2 { get; set; }

    [Column("interest_yearwise_interest2")]
    [StringLength(20)]
    public string? InterestYearwiseInterest2 { get; set; }

    [Column("interest_yearwise_tilldate2")]
    [StringLength(10)]
    public string? InterestYearwiseTilldate2 { get; set; }

    [Column("interest_yearwise_closebalance2")]
    [StringLength(30)]
    public string? InterestYearwiseClosebalance2 { get; set; }

    [Column("total_interest")]
    [StringLength(30)]
    public string? TotalInterest { get; set; }

    [Column("int_pl_operator_id")]
    public int? IntPlOperatorId { get; set; }

    [Column("benf_confirm_flag")]
    [StringLength(1)]
    public string? BenfConfirmFlag { get; set; }

    [Column("hoa_id")]
    public int? HoaId { get; set; }

    [Column("reference_date")]
    public DateOnly? ReferenceDate { get; set; }

    [Column("total_fp_amount")]
    [StringLength(30)]
    public string? TotalFpAmount { get; set; }

    [Column("current_interest")]
    [StringLength(30)]
    public string? CurrentInterest { get; set; }

    [Column("previous_interest")]
    [StringLength(30)]
    public string? PreviousInterest { get; set; }

    [Column("opening_bal_till_tr")]
    [StringLength(30)]
    public string? OpeningBalTillTr { get; set; }

    [Column("total_deposit")]
    [StringLength(30)]
    public string? TotalDeposit { get; set; }

    [Column("total_withdrawal")]
    [StringLength(30)]
    public string? TotalWithdrawal { get; set; }

    [Column("total_recovery")]
    [StringLength(30)]
    public string? TotalRecovery { get; set; }

    [Column("previous_interest_date")]
    [StringLength(30)]
    public string? PreviousInterestDate { get; set; }

    [ForeignKey("HoaId")]
    [InverseProperty("TmPfFinalPayment1s")]
    public virtual MmGenHoa? Hoa { get; set; }

    [ForeignKey("IntDdoId")]
    [InverseProperty("TmPfFinalPayment1s")]
    public virtual MmGenDdo? IntDdo { get; set; }

    public virtual HrMmEmpBasicDtl? IntEmployee { get; set; }

    [ForeignKey("IntPlOperatorId")]
    [InverseProperty("TmPfFinalPayment1s")]
    public virtual TMmGenPlOperator? IntPlOperator { get; set; }

    public virtual MmGenTreasury? IntTreasuryCodeNavigation { get; set; }

    [InverseProperty("IntFinalPayment")]
    public virtual ICollection<TdPfFinalPaymentNomineeBenfDtl> TdPfFinalPaymentNomineeBenfDtls { get; set; } = new List<TdPfFinalPaymentNomineeBenfDtl>();
}
