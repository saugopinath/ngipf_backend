using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("tm_pf_revised_dr_cr_det", Schema = "ngipf")]
public partial class TmPfRevisedDrCrDet
{
    [Column("fin_year_from")]
    public short? FinYearFrom { get; set; }

    [Column("int_employee_id")]
    [StringLength(38)]
    public string? IntEmployeeId { get; set; }

    [Column("balmod_amount")]
    public long? BalmodAmount { get; set; }

    [Column("balmod_diff")]
    public long? BalmodDiff { get; set; }

    [Column("balmod_int")]
    public int? BalmodInt { get; set; }

    [Column("miss_cred_month")]
    public short? MissCredMonth { get; set; }

    [Column("miss_cred_amount")]
    public long? MissCredAmount { get; set; }

    [Column("miss_cred_int")]
    public int? MissCredInt { get; set; }

    [Column("debit_vou_month")]
    public short? DebitVouMonth { get; set; }

    [Column("debit_vou_amount")]
    public int? DebitVouAmount { get; set; }

    [Column("debit_vou_int")]
    public int? DebitVouInt { get; set; }

    [Column("credit_vou_month")]
    public short? CreditVouMonth { get; set; }

    [Column("credit_vou_amount")]
    public int? CreditVouAmount { get; set; }

    [Column("credit_vou_int")]
    public int? CreditVouInt { get; set; }

    [Column("dml_status_flag")]
    public short? DmlStatusFlag { get; set; }

    [Column("created_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedTimestamp { get; set; }

    [Column("user_id")]
    public long? UserId { get; set; }

    [Column("miss_cred_year")]
    public short? MissCredYear { get; set; }

    [Column("debit_vou_year")]
    public short? DebitVouYear { get; set; }

    [Column("credit_vou_year")]
    public short? CreditVouYear { get; set; }

    [Column("request_type")]
    [StringLength(4)]
    public string? RequestType { get; set; }

    [Column("voucher_number")]
    [StringLength(9)]
    public string? VoucherNumber { get; set; }

    [Column("voucher_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? VoucherDate { get; set; }

    [Column("int_treasury_code")]
    [StringLength(5)]
    public string? IntTreasuryCode { get; set; }

    [Column("int_ddo_id")]
    public long? IntDdoId { get; set; }
}
