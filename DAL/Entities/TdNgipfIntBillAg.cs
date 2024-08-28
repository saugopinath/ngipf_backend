using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("td_ngipf_int_bill_ag", Schema = "ingipfund")]
public partial class TdNgipfIntBillAg
{
    [Key]
    [Column("int_td_ngipf_int_bill_ag_id")]
    [Precision(22, 0)]
    public decimal IntTdNgipfIntBillAgId { get; set; }

    [Column("int_tr43_bill_group_id")]
    [Precision(22, 0)]
    public decimal? IntTr43BillGroupId { get; set; }

    [Column("interest_year")]
    [Precision(22, 0)]
    public decimal? InterestYear { get; set; }

    [Column("financial_year")]
    [Precision(22, 0)]
    public decimal? FinancialYear { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("dml_status_flag")]
    [Precision(22, 0)]
    public decimal? DmlStatusFlag { get; set; }

    [Column("created_user")]
    [Precision(22, 0)]
    public decimal? CreatedUser { get; set; }

    [Column("created_role")]
    [Precision(22, 0)]
    public decimal? CreatedRole { get; set; }

    [Column("created_time", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedTime { get; set; }

    [Column("modified_user")]
    [Precision(22, 0)]
    public decimal? ModifiedUser { get; set; }

    [Column("modified_role")]
    [Precision(22, 0)]
    public decimal? ModifiedRole { get; set; }

    [Column("modified_time", TypeName = "timestamp(0) without time zone")]
    public DateTime? ModifiedTime { get; set; }

    [Column("ag_memo_no")]
    [StringLength(20)]
    public string? AgMemoNo { get; set; }

    [Column("ag_memo_date")]
    public DateOnly? AgMemoDate { get; set; }

    [Column("status")]
    [StringLength(2)]
    public string? Status { get; set; }

    [Column("dppg_memo_date")]
    public DateOnly? DppgMemoDate { get; set; }

    [Column("dppg_memo_no")]
    [StringLength(20)]
    public string? DppgMemoNo { get; set; }

    [ForeignKey("IntTr43BillGroupId")]
    [InverseProperty("TdNgipfIntBillAgs")]
    public virtual PfTmTrBillHdr? IntTr43BillGroup { get; set; }
}
