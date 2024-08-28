using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Keyless]
[Table("tm_subs_withd_exclusion", Schema = "ngipf")]
public partial class TmSubsWithdExclusion
{
    [Column("for_fin_year")]
    public short? ForFinYear { get; set; }

    [Column("in_fin_year")]
    public short? InFinYear { get; set; }

    [Column("int_treasury_code")]
    [StringLength(5)]
    public string? IntTreasuryCode { get; set; }

    [Column("ref_no")]
    [StringLength(38)]
    public string? RefNo { get; set; }

    [Column("int_employee_id")]
    [StringLength(38)]
    public string? IntEmployeeId { get; set; }

    [Column("int_pay_bill_dtls_id")]
    [StringLength(38)]
    public string? IntPayBillDtlsId { get; set; }

    [Column("salary_month")]
    public short? SalaryMonth { get; set; }

    [Column("salary_year")]
    public short? SalaryYear { get; set; }

    [Column("voucher_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? VoucherDate { get; set; }

    [Column("adjust_in_tr43_year")]
    public short? AdjustInTr43Year { get; set; }

    [Column("dml_status_flag")]
    public short? DmlStatusFlag { get; set; }

    [Column("created_timestamp", TypeName = "timestamp(6) without time zone")]
    public DateTime? CreatedTimestamp { get; set; }

    [Column("modified_timestamp", TypeName = "timestamp(6) without time zone")]
    public DateTime? ModifiedTimestamp { get; set; }

    [Column("amount")]
    [Precision(14, 2)]
    public decimal? Amount { get; set; }

    [Column("voucher_number")]
    [StringLength(9)]
    public string? VoucherNumber { get; set; }

    [Column("txn_type")]
    [StringLength(1)]
    public string? TxnType { get; set; }

    [Column("int_comp_id")]
    [StringLength(38)]
    public string? IntCompId { get; set; }
}
