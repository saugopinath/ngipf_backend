using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("b_td_pay_bill_tr50", Schema = "ionlinebill")]
public partial class BTdPayBillTr50
{
    [Key]
    [Column("int_tr50_id")]
    public long IntTr50Id { get; set; }

    [Column("fin_year_from")]
    public short? FinYearFrom { get; set; }

    [Column("int_treasury_code")]
    [StringLength(5)]
    public string? IntTreasuryCode { get; set; }

    [Column("ref_no")]
    public long? RefNo { get; set; }

    [Column("emp_name")]
    [StringLength(200)]
    public string? EmpName { get; set; }

    [Column("emp_id")]
    [StringLength(50)]
    public string? EmpId { get; set; }

    [Column("designation")]
    [StringLength(300)]
    public string? Designation { get; set; }

    [Column("int_designation_id")]
    public short? IntDesignationId { get; set; }

    [Column("basic_pay")]
    [Precision(14, 2)]
    public decimal? BasicPay { get; set; }

    [Column("cessation_type")]
    [StringLength(1)]
    public string? CessationType { get; set; }

    [Column("cessation_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? CessationDate { get; set; }

    [Column("pf_account_no")]
    [StringLength(50)]
    public string? PfAccountNo { get; set; }

    [Column("sanction_id")]
    public long? SanctionId { get; set; }

    [Column("sanction_number")]
    [StringLength(100)]
    public string? SanctionNumber { get; set; }

    [Column("sanction_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? SanctionDate { get; set; }

    [Column("issuing_authority")]
    [StringLength(100)]
    public string? IssuingAuthority { get; set; }

    [Column("sanction_amount")]
    [Precision(14, 2)]
    public decimal? SanctionAmount { get; set; }

    [Column("gross_amount")]
    [Precision(14, 2)]
    public decimal? GrossAmount { get; set; }

    [Column("net_amount")]
    [Precision(14, 2)]
    public decimal? NetAmount { get; set; }

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

    [Column("save_status")]
    [StringLength(1)]
    public string? SaveStatus { get; set; }

    [Column("sanction_memo_no")]
    [StringLength(100)]
    public string? SanctionMemoNo { get; set; }

    [Column("refundable_flag")]
    [StringLength(1)]
    public string? RefundableFlag { get; set; }

    [Column("loan_type_abbr")]
    [StringLength(10)]
    public string? LoanTypeAbbr { get; set; }
}
