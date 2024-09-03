using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("tm_pre_challan", Schema = "ingipfund")]
public partial class TmPreChallan1
{
    [Column("treasury_challan_no")]
    [StringLength(15)]
    public string? TreasuryChallanNo { get; set; }

    [Key]
    [Column("int_tm_pre_challan_id")]
    [Precision(22, 0)]
    public decimal IntTmPreChallanId { get; set; }

    [Column("financial_year")]
    [Precision(22, 0)]
    public decimal? FinancialYear { get; set; }

    [Column("int_pl_operator_id")]
    public int? IntPlOperatorId { get; set; }

    [Column("hoa_id")]
    public int? HoaId { get; set; }

    [Column("request_id")]
    [Precision(22, 0)]
    public decimal? RequestId { get; set; }

    [Column("workflow_status_flag")]
    [StringLength(2)]
    public string? WorkflowStatusFlag { get; set; }

    [Column("pre_challan_id")]
    [Precision(22, 0)]
    public decimal? PreChallanId { get; set; }

    [Column("pre_challan_date")]
    public DateOnly? PreChallanDate { get; set; }

    [Column("treasury_challan_date")]
    public DateOnly? TreasuryChallanDate { get; set; }

    [Column("int_branch_id")]
    [Precision(22, 0)]
    public decimal? IntBranchId { get; set; }

    [Column("created_user_id")]
    [Precision(22, 0)]
    public decimal? CreatedUserId { get; set; }

    [Column("created_date", TypeName = "timestamp(6) without time zone")]
    public DateTime? CreatedDate { get; set; }

    [Column("modified_user_id")]
    [Precision(22, 0)]
    public decimal? ModifiedUserId { get; set; }

    [Column("modified_date", TypeName = "timestamp(6) without time zone")]
    public DateTime? ModifiedDate { get; set; }

    [Column("pre_challan_type")]
    [StringLength(1)]
    public string? PreChallanType { get; set; }

    [Column("salary_month")]
    [Precision(22, 0)]
    public decimal? SalaryMonth { get; set; }

    [Column("salary_year")]
    [Precision(22, 0)]
    public decimal? SalaryYear { get; set; }

    [Column("int_treasury_code")]
    [StringLength(5)]
    public string? IntTreasuryCode { get; set; }

    [ForeignKey("HoaId")]
    [InverseProperty("TmPreChallan1s")]
    public virtual MmGenHoa? Hoa { get; set; }

    [ForeignKey("IntPlOperatorId")]
    [InverseProperty("TmPreChallan1s")]
    public virtual TMmGenPlOperator? IntPlOperator { get; set; }

    public virtual MmGenTreasury? IntTreasuryCodeNavigation { get; set; }

    [InverseProperty("IntTmPreChallan")]
    public virtual ICollection<TdEmpPreChallan1> TdEmpPreChallan1s { get; set; } = new List<TdEmpPreChallan1>();
}
