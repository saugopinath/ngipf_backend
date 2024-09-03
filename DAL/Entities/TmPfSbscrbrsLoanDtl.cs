using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("tm_pf_sbscrbrs_loan_dtls", Schema = "ngipf")]
public partial class TmPfSbscrbrsLoanDtl
{
    [Key]
    [Column("int_sbscrbrs_loan_id")]
    [StringLength(38)]
    public string IntSbscrbrsLoanId { get; set; } = null!;

    [Column("fin_year_from")]
    public short? FinYearFrom { get; set; }

    [Column("int_treasury_code")]
    [StringLength(5)]
    public string? IntTreasuryCode { get; set; }

    [Column("int_employee_id")]
    [StringLength(38)]
    public string? IntEmployeeId { get; set; }

    [Column("int_group_id")]
    [StringLength(38)]
    public string? IntGroupId { get; set; }

    [Column("int_tr50_id")]
    public long? IntTr50Id { get; set; }

    [Column("int_gpf_vou_id")]
    [StringLength(38)]
    public string? IntGpfVouId { get; set; }

    [Column("int_request_id")]
    [StringLength(38)]
    public string? IntRequestId { get; set; }

    [Column("sanction_no")]
    [StringLength(100)]
    public string? SanctionNo { get; set; }

    [Column("sanction_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? SanctionDate { get; set; }

    [Column("subclass_id")]
    public short? SubclassId { get; set; }

    [Column("contribution_year")]
    public short? ContributionYear { get; set; }

    [Column("contribution_month")]
    public short? ContributionMonth { get; set; }

    [Column("posting_month")]
    public short? PostingMonth { get; set; }

    [Column("posting_year")]
    public short? PostingYear { get; set; }

    [Column("remarks")]
    [StringLength(300)]
    public string? Remarks { get; set; }

    [Column("amount")]
    public int? Amount { get; set; }

    [Column("int_final_payment_id")]
    [StringLength(38)]
    public string? IntFinalPaymentId { get; set; }

    [Column("int_balance_id")]
    [StringLength(38)]
    public string? IntBalanceId { get; set; }

    [Column("status")]
    [MaxLength(1)]
    public char? Status { get; set; }

    [Column("posting_flag")]
    [MaxLength(1)]
    public char? PostingFlag { get; set; }

    [Column("confirm_flag")]
    [MaxLength(1)]
    public char? ConfirmFlag { get; set; }

    [Column("enter_flag")]
    [MaxLength(1)]
    public char? EnterFlag { get; set; }

    [Column("dml_status_flag")]
    public short? DmlStatusFlag { get; set; }

    [Column("user_id")]
    public int? UserId { get; set; }

    [Column("created_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedTimestamp { get; set; }

    [Column("modified_user_id")]
    public int? ModifiedUserId { get; set; }

    [Column("modified_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime? ModifiedTimestamp { get; set; }

    [Column("system_posted_flag")]
    [MaxLength(1)]
    public char? SystemPostedFlag { get; set; }

    [Column("adjust_year")]
    public short? AdjustYear { get; set; }
}
