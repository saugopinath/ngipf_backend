using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("tm_pf_vou_dtls", Schema = "ngipf")]
[Index("IntTreasuryCode", Name = "uk_tm_gpf_vou_dtls1")]
public partial class TmPfVouDtl
{
    [Key]
    [Column("int_gpf_vou_id")]
    [StringLength(38)]
    public string IntGpfVouId { get; set; } = null!;

    [Column("fin_year_from")]
    public short? FinYearFrom { get; set; }

    [Column("int_treasury_code")]
    [StringLength(5)]
    public string? IntTreasuryCode { get; set; }

    [Column("int_ddo_id")]
    public int? IntDdoId { get; set; }

    [Column("token_number")]
    public int? TokenNumber { get; set; }

    [Column("voucher_challan_flag")]
    [StringLength(1)]
    public string? VoucherChallanFlag { get; set; }

    [Column("voucher_number")]
    [StringLength(12)]
    public string? VoucherNumber { get; set; }

    [Column("voucher_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? VoucherDate { get; set; }

    [Column("voucher_amount")]
    [Precision(14, 2)]
    public decimal? VoucherAmount { get; set; }

    [Column("challan_number")]
    [StringLength(12)]
    public string? ChallanNumber { get; set; }

    [Column("challan_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? ChallanDate { get; set; }

    [Column("challan_amount")]
    [Precision(14, 2)]
    public decimal? ChallanAmount { get; set; }

    [Column("voucher_challan_month")]
    public short? VoucherChallanMonth { get; set; }

    [Column("voucher_challan_year")]
    public short? VoucherChallanYear { get; set; }

    [Column("hoa_id")]
    public int? HoaId { get; set; }

    [Column("adjusted_amount")]
    [Precision(14, 2)]
    public decimal? AdjustedAmount { get; set; }

    [Column("salary_month")]
    public short? SalaryMonth { get; set; }

    [Column("salary_year")]
    public short? SalaryYear { get; set; }

    [Column("dr_cr_flag")]
    [MaxLength(1)]
    public char? DrCrFlag { get; set; }

    [Column("challan_type")]
    [MaxLength(1)]
    public char? ChallanType { get; set; }

    [Column("legacy_flag")]
    [MaxLength(1)]
    public char? LegacyFlag { get; set; }

    [Column("adjusted_flag")]
    [MaxLength(1)]
    public char? AdjustedFlag { get; set; }

    [Column("sent_flag")]
    [MaxLength(1)]
    public char? SentFlag { get; set; }

    [Column("int_batch_id")]
    [StringLength(38)]
    public string? IntBatchId { get; set; }

    [Column("remarks")]
    [StringLength(400)]
    public string? Remarks { get; set; }

    [Column("int_pl_operator_id")]
    public int? IntPlOperatorId { get; set; }

    [Column("hrms_flag")]
    [MaxLength(1)]
    public char? HrmsFlag { get; set; }

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

    [Column("ref_no")]
    [StringLength(38)]
    public string? RefNo { get; set; }

    [Column("bt_serial_number")]
    public int? BtSerialNumber { get; set; }
}
