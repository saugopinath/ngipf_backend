using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("tm_pre_challan", Schema = "ngipf")]
public partial class TmPreChallan
{
    [Key]
    [Column("int_tm_pre_challan_id")]
    [StringLength(38)]
    public string IntTmPreChallanId { get; set; } = null!;

    [Column("financial_year")]
    public short FinancialYear { get; set; }

    [Column("int_pl_operator_id")]
    public long IntPlOperatorId { get; set; }

    [Column("hoa_id")]
    public int HoaId { get; set; }

    [Column("request_id")]
    public long RequestId { get; set; }

    [Column("workflow_status_flag")]
    [StringLength(2)]
    public string WorkflowStatusFlag { get; set; } = null!;

    [Column("pre_challan_id")]
    [Precision(20, 0)]
    public decimal PreChallanId { get; set; }

    [Column("pre_challan_date", TypeName = "timestamp(0) without time zone")]
    public DateTime PreChallanDate { get; set; }

    [Column("treasury_challan_no")]
    [StringLength(15)]
    public string? TreasuryChallanNo { get; set; }

    [Column("treasury_challan_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? TreasuryChallanDate { get; set; }

    [Column("int_branch_id")]
    public long IntBranchId { get; set; }

    [Column("created_user_id")]
    public long CreatedUserId { get; set; }

    [Column("created_date", TypeName = "timestamp(0) without time zone")]
    public DateTime CreatedDate { get; set; }

    [Column("modified_user_id")]
    public long ModifiedUserId { get; set; }

    [Column("modified_date", TypeName = "timestamp(0) without time zone")]
    public DateTime ModifiedDate { get; set; }

    /// <summary>
    /// will be &apos;n&apos; for new prechallan, &apos;e for existing challan&apos;
    /// </summary>
    [Column("pre_challan_type")]
    [StringLength(1)]
    public string? PreChallanType { get; set; }

    [Column("salary_month")]
    public short? SalaryMonth { get; set; }

    [Column("salary_year")]
    public short? SalaryYear { get; set; }

    [Column("int_treasury_code")]
    [StringLength(5)]
    public string? IntTreasuryCode { get; set; }
}
