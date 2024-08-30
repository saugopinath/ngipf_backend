using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Keyless]
[Table("emp_withdrawal", Schema = "ngipf")]
public partial class EmpWithdrawal
{
    [Column("int_employee_id")]
    public int? IntEmployeeId { get; set; }

    [Column("voucher_number")]
    [StringLength(9)]
    public string? VoucherNumber { get; set; }

    [Column("voucher_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? VoucherDate { get; set; }

    [Column("fin_year_from")]
    public short? FinYearFrom { get; set; }

    [Column("withdrawal_amt")]
    [Precision(14, 2)]
    public decimal? WithdrawalAmt { get; set; }

    [Column("hoa")]
    [StringLength(21)]
    public string? Hoa { get; set; }

    [Column("trans_type")]
    [StringLength(13)]
    public string? TransType { get; set; }

    [Column("created_by")]
    public int? CreatedBy { get; set; }

    [Column("last_updated_by")]
    public int? LastUpdatedBy { get; set; }

    [Column("deleted_by")]
    public int? DeletedBy { get; set; }

    [Column("created_at", TypeName = "timestamp without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("last_updated_at", TypeName = "timestamp without time zone")]
    public DateTime? LastUpdatedAt { get; set; }

    [Column("deleted_at", TypeName = "timestamp without time zone")]
    public DateTime? DeletedAt { get; set; }

    [Column("active_flag")]
    [MaxLength(1)]
    public char? ActiveFlag { get; set; }

    [ForeignKey("IntEmployeeId")]
    public virtual EmpPfBasicDetail? IntEmployee { get; set; }
}
