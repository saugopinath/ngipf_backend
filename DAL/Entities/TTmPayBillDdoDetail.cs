using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[PrimaryKey("FinYearFrom", "IntTreasuryCode", "RefNo")]
[Table("t_tm_pay_bill_ddo_details", Schema = "ionlinebill")]
[Index("FinYearFrom", "RefNo", Name = "u_t_tm_pay_bill_ddo_dtl2", IsUnique = true)]
public partial class TTmPayBillDdoDetail
{
    [Key]
    [Column("fin_year_from")]
    public short FinYearFrom { get; set; }

    [Key]
    [Column("int_treasury_code")]
    [StringLength(5)]
    public string IntTreasuryCode { get; set; } = null!;

    [Key]
    [Column("ref_no")]
    [Precision(30, 0)]
    public decimal RefNo { get; set; }

    [Column("int_stakeholder_id")]
    public int IntStakeholderId { get; set; }

    [Column("stakeholder_type")]
    [StringLength(3)]
    public string StakeholderType { get; set; } = null!;

    [Column("bill_number")]
    [StringLength(60)]
    public string? BillNumber { get; set; }

    [Column("bill_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? BillDate { get; set; }

    [Column("gross_amount")]
    [Precision(17, 2)]
    public decimal GrossAmount { get; set; }

    [Column("net_amount")]
    [Precision(17, 2)]
    public decimal NetAmount { get; set; }

    [Column("hoa_id")]
    public int? HoaId { get; set; }

    [Column("pay_mode")]
    [StringLength(1)]
    public string PayMode { get; set; } = null!;

    [Column("token_number")]
    public int? TokenNumber { get; set; }

    [Column("org_ref_no")]
    [Precision(30, 0)]
    public decimal? OrgRefNo { get; set; }

    [Column("refund_status")]
    [StringLength(1)]
    public string? RefundStatus { get; set; }

    /// <summary>
    /// y - submitted, n - not submitted
    /// </summary>
    [Column("submit_status")]
    [StringLength(1)]
    public string? SubmitStatus { get; set; }

    [Column("cosa_type")]
    public int? CosaType { get; set; }

    /// <summary>
    /// 1 for treasury drawl, 2 for cheque drawl (lc), 3 for pension edisb
    /// </summary>
    [Column("module_type_flag")]
    public short ModuleTypeFlag { get; set; }

    [Column("dml_status_flag")]
    public short DmlStatusFlag { get; set; }

    [Column("user_id")]
    public int UserId { get; set; }

    [Column("created_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime CreatedTimestamp { get; set; }

    [Column("modified_user_id")]
    public int ModifiedUserId { get; set; }

    [Column("modified_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime ModifiedTimestamp { get; set; }

    [Column("ag_bill_type_id")]
    public short? AgBillTypeId { get; set; }

    [Column("ecs_amount")]
    [Precision(17, 2)]
    public decimal? EcsAmount { get; set; }

    [Column("chq_amount")]
    [Precision(17, 2)]
    public decimal? ChqAmount { get; set; }

    [Column("processing_flag")]
    public short ProcessingFlag { get; set; }

    [Column("advice_id")]
    public int? AdviceId { get; set; }

    [Column("advice_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? AdviceDate { get; set; }

    [Column("bill_type_id")]
    public short? BillTypeId { get; set; }

    [Column("payee_dept")]
    [StringLength(4)]
    public string PayeeDept { get; set; } = null!;

    [Column("operator_remarks")]
    [StringLength(250)]
    public string? OperatorRemarks { get; set; }

    [Column("approver_remarks")]
    [StringLength(250)]
    public string? ApproverRemarks { get; set; }

    [Column("e_billing_flag")]
    [StringLength(1)]
    public string? EBillingFlag { get; set; }

    [Column("int_bill_type_id")]
    public short? IntBillTypeId { get; set; }

    [Column("submit_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? SubmitDate { get; set; }

    [Column("subclass_id")]
    public short? SubclassId { get; set; }

    [Column("salary_hoa_id")]
    public int? SalaryHoaId { get; set; }

    [Column("scheme_name")]
    [StringLength(4)]
    public string? SchemeName { get; set; }

    [Column("payment_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? PaymentDate { get; set; }

    [Column("bulk_benf_flag")]
    [StringLength(2)]
    public string? BulkBenfFlag { get; set; }

    [Column("emp_flag")]
    [StringLength(2)]
    public string? EmpFlag { get; set; }

    [Column("sal_from_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? SalFromDate { get; set; }

    [Column("sal_to_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? SalToDate { get; set; }

    [Column("sal_arr_flag")]
    [StringLength(1)]
    public string? SalArrFlag { get; set; }

    [Column("active_user_id")]
    public int? ActiveUserId { get; set; }

    [Column("service_code")]
    [StringLength(10)]
    public string? ServiceCode { get; set; }

    [Column("hrms_flag")]
    [StringLength(1)]
    public string? HrmsFlag { get; set; }

    [Column("int_sub_project_id")]
    [StringLength(38)]
    public string? IntSubProjectId { get; set; }

    [Column("grant_type")]
    [StringLength(5)]
    public string? GrantType { get; set; }

    [Column("payment_type")]
    [StringLength(2)]
    public string? PaymentType { get; set; }

    [Column("project_mode")]
    [StringLength(1)]
    public string? ProjectMode { get; set; }

    [Column("pfms_flag")]
    [StringLength(1)]
    public string? PfmsFlag { get; set; }
}
