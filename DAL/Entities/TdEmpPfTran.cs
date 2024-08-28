using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("td_emp_pf_trans", Schema = "ngipf")]
public partial class TdEmpPfTran
{
    [Key]
    [Column("int_emp_pf_trans_id")]
    [StringLength(38)]
    public string IntEmpPfTransId { get; set; } = null!;

    [Column("int_employee_id")]
    [StringLength(38)]
    public string IntEmployeeId { get; set; } = null!;

    [Column("tranaction_date", TypeName = "timestamp(0) without time zone")]
    public DateTime TranactionDate { get; set; }

    [Column("debit_credit_flag")]
    [StringLength(6)]
    public string DebitCreditFlag { get; set; } = null!;

    [Column("amount")]
    [Precision(20, 2)]
    public decimal Amount { get; set; }

    [Column("salary_month")]
    public short? SalaryMonth { get; set; }

    [Column("salary_year")]
    public short? SalaryYear { get; set; }

    [Column("subscription_month")]
    public short? SubscriptionMonth { get; set; }

    [Column("subscription_year")]
    public short? SubscriptionYear { get; set; }

    [Column("basic")]
    [Precision(10, 2)]
    public decimal? Basic { get; set; }

    [Column("grade_pay")]
    [Precision(10, 2)]
    public decimal? GradePay { get; set; }

    [Column("int_rev_pay_allowance_id")]
    [StringLength(38)]
    public string? IntRevPayAllowanceId { get; set; }

    [Column("transation_type")]
    [StringLength(6)]
    public string TransationType { get; set; } = null!;

    [Column("transation_source")]
    [StringLength(6)]
    public string TransationSource { get; set; } = null!;

    [Column("fin_year_from")]
    public short? FinYearFrom { get; set; }

    [Column("int_treasury_code")]
    [StringLength(5)]
    public string? IntTreasuryCode { get; set; }

    [Column("ref_no")]
    [Precision(30, 0)]
    public decimal? RefNo { get; set; }

    [Column("voucher_number")]
    [StringLength(8)]
    public string? VoucherNumber { get; set; }

    [Column("voucher_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? VoucherDate { get; set; }

    [Column("challan_number")]
    [StringLength(8)]
    public string? ChallanNumber { get; set; }

    [Column("challan_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? ChallanDate { get; set; }

    [Column("wef_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? WefDate { get; set; }

    [Column("int_comp_id")]
    [StringLength(38)]
    public string? IntCompId { get; set; }

    [Column("drn_no")]
    [StringLength(20)]
    public string? DrnNo { get; set; }

    [Column("hoa_id")]
    public int? HoaId { get; set; }

    [Column("bt_serial_number")]
    public int? BtSerialNumber { get; set; }

    [Column("arrear_from", TypeName = "timestamp(0) without time zone")]
    public DateTime? ArrearFrom { get; set; }

    [Column("arrear_to", TypeName = "timestamp(0) without time zone")]
    public DateTime? ArrearTo { get; set; }

    [Column("current_installment")]
    public short? CurrentInstallment { get; set; }

    [Column("total_installment")]
    public short? TotalInstallment { get; set; }

    [Column("int_pl_op_id_sal")]
    public int? IntPlOpIdSal { get; set; }

    [Column("scheme_id_sal")]
    public int? SchemeIdSal { get; set; }

    [Column("int_pl_op_id_pf")]
    public int? IntPlOpIdPf { get; set; }

    [Column("scheme_id_pf")]
    public int? SchemeIdPf { get; set; }

    [Column("int_pl_pf_ddo_map")]
    [StringLength(38)]
    public string? IntPlPfDdoMap { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string ActiveFlag { get; set; } = null!;

    [Column("dml_status_flag")]
    public short DmlStatusFlag { get; set; }

    [Column("created_user")]
    public int CreatedUser { get; set; }

    [Column("created_timestamp", TypeName = "timestamp(6) without time zone")]
    public DateTime CreatedTimestamp { get; set; }

    [Column("modified_user")]
    public int? ModifiedUser { get; set; }

    [Column("modified_timestamp", TypeName = "timestamp(6) without time zone")]
    public DateTime? ModifiedTimestamp { get; set; }

    [Column("employer_subscription")]
    [Precision(10, 2)]
    public decimal? EmployerSubscription { get; set; }

    [Column("workflow_status_flag")]
    [StringLength(2)]
    public string? WorkflowStatusFlag { get; set; }

    [Column("request_id")]
    public long? RequestId { get; set; }
}
