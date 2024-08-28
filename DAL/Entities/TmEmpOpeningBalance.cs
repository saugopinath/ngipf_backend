using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("tm_emp_opening_balance", Schema = "ngipf")]
public partial class TmEmpOpeningBalance
{
    [Key]
    [Column("int_tm_emp_open_bal_id")]
    [StringLength(38)]
    public string IntTmEmpOpenBalId { get; set; } = null!;

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

    [Column("sanc_auth_office_id")]
    [StringLength(38)]
    public string SancAuthOfficeId { get; set; } = null!;

    [Column("sub_pre_office_type")]
    [StringLength(10)]
    public string? SubPreOfficeType { get; set; }

    [Column("sub_pre_office_id")]
    [StringLength(38)]
    public string? SubPreOfficeId { get; set; }

    [Column("section_code")]
    [StringLength(25)]
    public string? SectionCode { get; set; }

    [Column("created_user_id")]
    public long CreatedUserId { get; set; }

    [Column("created_date", TypeName = "timestamp(6) without time zone")]
    public DateTime CreatedDate { get; set; }

    [Column("modified_user_id")]
    public long ModifiedUserId { get; set; }

    [Column("modified_date", TypeName = "timestamp(6) without time zone")]
    public DateTime ModifiedDate { get; set; }

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

    [Column("acceptance_date", TypeName = "timestamp(6) without time zone")]
    public DateTime? AcceptanceDate { get; set; }
}
