using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("t_mm_gen_pl_operator", Schema = "ifmsadmin")]
public partial class TMmGenPlOperator
{
    [Column("operator_type")]
    [StringLength(1)]
    public string? OperatorType { get; set; }

    [Column("govt_nongovt_flag")]
    [StringLength(1)]
    public string? GovtNongovtFlag { get; set; }

    [Column("operator_name")]
    [StringLength(100)]
    public string? OperatorName { get; set; }

    [Column("address")]
    [StringLength(200)]
    public string? Address { get; set; }

    [Column("phone_no1")]
    [StringLength(20)]
    public string? PhoneNo1 { get; set; }

    [Column("phone_no2")]
    [StringLength(20)]
    public string? PhoneNo2 { get; set; }

    [Column("fax")]
    [StringLength(20)]
    public string? Fax { get; set; }

    [Column("e_mail")]
    [StringLength(50)]
    public string? EMail { get; set; }

    [Column("pin")]
    [StringLength(6)]
    public string? Pin { get; set; }

    [Column("int_bearing_flag")]
    [StringLength(1)]
    public string? IntBearingFlag { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("ao_no")]
    [StringLength(200)]
    public string? AoNo { get; set; }

    [Column("ao_date")]
    public DateOnly? AoDate { get; set; }

    [Column("admin_dept")]
    [StringLength(2)]
    public string? AdminDept { get; set; }

    [Column("pan")]
    [StringLength(20)]
    public string? Pan { get; set; }

    [Column("internal_deposit_code")]
    [StringLength(9)]
    public string? InternalDepositCode { get; set; }

    [Column("salary_source")]
    [StringLength(1)]
    public string? SalarySource { get; set; }

    [Column("balance_capture_from")]
    [StringLength(100)]
    public string? BalanceCaptureFrom { get; set; }

    [Column("balance_capture_remarks")]
    [StringLength(2000)]
    public string? BalanceCaptureRemarks { get; set; }

    [Column("balance_capture_status")]
    [StringLength(100)]
    public string? BalanceCaptureStatus { get; set; }

    [Column("balance_capture_memo_no")]
    [StringLength(200)]
    public string? BalanceCaptureMemoNo { get; set; }

    [Column("balance_capture_permission_date")]
    public DateOnly? BalanceCapturePermissionDate { get; set; }

    [Column("user_id_old")]
    [StringLength(38)]
    public string? UserIdOld { get; set; }

    [Column("user_id")]
    public int? UserId { get; set; }

    [Column("operator_id_old")]
    [StringLength(38)]
    public string? OperatorIdOld { get; set; }

    [Column("operator_id")]
    public int? OperatorId { get; set; }

    [Column("modified_user_id_old")]
    [StringLength(38)]
    public string? ModifiedUserIdOld { get; set; }

    [Column("modified_user_id")]
    public int? ModifiedUserId { get; set; }

    [Column("int_pl_operator_id_old")]
    [StringLength(38)]
    public string? IntPlOperatorIdOld { get; set; }

    [Column("int_ddo_id_old")]
    [StringLength(38)]
    public string? IntDdoIdOld { get; set; }

    [Key]
    [Column("int_pl_operator_id")]
    public int IntPlOperatorId { get; set; }

    [InverseProperty("IntOperator")]
    public virtual ICollection<AdvanceAmountEligibilityMst> AdvanceAmountEligibilityMsts { get; set; } = new List<AdvanceAmountEligibilityMst>();

    [InverseProperty("IntOperator")]
    public virtual ICollection<AdvancePurposeAdvanceMapping> AdvancePurposeAdvanceMappings { get; set; } = new List<AdvancePurposeAdvanceMapping>();

    [InverseProperty("IntOperator")]
    public virtual ICollection<AdvanceRecoveryDurationEligibilityMst> AdvanceRecoveryDurationEligibilityMsts { get; set; } = new List<AdvanceRecoveryDurationEligibilityMst>();

    [InverseProperty("IntOperator")]
    public virtual ICollection<AdvanceServiceDurationEligibilityMst> AdvanceServiceDurationEligibilityMsts { get; set; } = new List<AdvanceServiceDurationEligibilityMst>();

    [InverseProperty("IntOperator")]
    public virtual ICollection<EmpOpeningBalanceAccpeted> EmpOpeningBalanceAccpeteds { get; set; } = new List<EmpOpeningBalanceAccpeted>();

    [InverseProperty("IntOperator")]
    public virtual ICollection<EmpPfBasicDetail> EmpPfBasicDetails { get; set; } = new List<EmpPfBasicDetail>();

    [InverseProperty("IntOperator")]
    public virtual ICollection<EmpPfOfficeDetail> EmpPfOfficeDetails { get; set; } = new List<EmpPfOfficeDetail>();

    [InverseProperty("IntOperator")]
    public virtual ICollection<LfPlOpInterestCreditedStatus> LfPlOpInterestCreditedStatuses { get; set; } = new List<LfPlOpInterestCreditedStatus>();

    [InverseProperty("IntOperator")]
    public virtual LfPlOpOpeningBalancePermissionStatus? LfPlOpOpeningBalancePermissionStatus { get; set; }

    [InverseProperty("IntOperator")]
    public virtual LfPlOpReconciliationStatus? LfPlOpReconciliationStatus { get; set; }

    [InverseProperty("IntPlOperator")]
    public virtual ICollection<MmGenNgipfOffice> MmGenNgipfOffices { get; set; } = new List<MmGenNgipfOffice>();

    [InverseProperty("IntOperator")]
    public virtual ICollection<PlPfDdoHoaMap> PlPfDdoHoaMaps { get; set; } = new List<PlPfDdoHoaMap>();

    [InverseProperty("IntOperator")]
    public virtual ICollection<WorkflowMasterCode> WorkflowMasterCodes { get; set; } = new List<WorkflowMasterCode>();
}
