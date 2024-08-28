using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("tm_emp_opening_balance", Schema = "ingipfund")]
public partial class TmEmpOpeningBalance1
{
    [Column("created_date", TypeName = "timestamp(6) without time zone")]
    public DateTime? CreatedDate { get; set; }

    [Column("sub_pre_office_id")]
    [Precision(22, 0)]
    public decimal? SubPreOfficeId { get; set; }

    [Key]
    [Column("int_tm_emp_open_bal_id")]
    [Precision(22, 0)]
    public decimal IntTmEmpOpenBalId { get; set; }

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

    [Column("sanc_auth_office_id")]
    [Precision(22, 0)]
    public decimal? SancAuthOfficeId { get; set; }

    [Column("sub_pre_office_type")]
    [StringLength(10)]
    public string? SubPreOfficeType { get; set; }

    [Column("section_code")]
    [StringLength(25)]
    public string? SectionCode { get; set; }

    [Column("created_user_id")]
    [Precision(22, 0)]
    public decimal? CreatedUserId { get; set; }

    [Column("modified_user_id")]
    [Precision(22, 0)]
    public decimal? ModifiedUserId { get; set; }

    [Column("modified_date", TypeName = "timestamp(6) without time zone")]
    public DateTime? ModifiedDate { get; set; }

    [Column("pre_challan_type")]
    [StringLength(1)]
    public string? PreChallanType { get; set; }

    [Column("final_sub_status")]
    [StringLength(5)]
    public string? FinalSubStatus { get; set; }

    [Column("checked_flag")]
    [StringLength(2)]
    public string? CheckedFlag { get; set; }

    [Column("forward_with_objection_flag")]
    [StringLength(5)]
    public string? ForwardWithObjectionFlag { get; set; }

    [Column("forward_with_objection_type")]
    [StringLength(50)]
    public string? ForwardWithObjectionType { get; set; }

    [Column("sanc_send_back")]
    [StringLength(2)]
    public string? SancSendBack { get; set; }

    [Column("dml_status_flag")]
    [StringLength(1)]
    public string? DmlStatusFlag { get; set; }

    [Column("int_treasury_code")]
    [StringLength(5)]
    public string? IntTreasuryCode { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("acceptance_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? AcceptanceDate { get; set; }

    [Column("unsettled_amount")]
    [Precision(22, 2)]
    public decimal? UnsettledAmount { get; set; }

    [ForeignKey("HoaId")]
    [InverseProperty("TmEmpOpeningBalance1s")]
    public virtual MmGenHoa? Hoa { get; set; }

    [ForeignKey("IntPlOperatorId")]
    [InverseProperty("TmEmpOpeningBalance1s")]
    public virtual TMmGenPlOperator? IntPlOperator { get; set; }

    public virtual MmGenTreasury? IntTreasuryCodeNavigation { get; set; }
}
