using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Keyless]
[Table("hr_mm_gen_loan_advance_install", Schema = "ihrms_master")]
public partial class HrMmGenLoanAdvanceInstall
{
    [Column("WEF_DATE")]
    public DateOnly WefDate { get; set; }

    [Column("EFFECTIVE_END_DATE")]
    public DateOnly? EffectiveEndDate { get; set; }

    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("CREATED_TIMESTAMP", TypeName = "timestamp without time zone")]
    public DateTime CreatedTimestamp { get; set; }

    [Column("MODIFIED_TIMESTAMP", TypeName = "timestamp without time zone")]
    public DateTime ModifiedTimestamp { get; set; }

    [Column("NEW_OLD_FLAG")]
    [StringLength(1)]
    public string? NewOldFlag { get; set; }

    [Column("REFUNDABLE_FLAG")]
    [StringLength(1)]
    public string? RefundableFlag { get; set; }

    [Column("INTEREST_APPLICABLE")]
    [StringLength(10)]
    public string? InterestApplicable { get; set; }

    [Column("INSTALL_GOV_ORDER_NO")]
    [StringLength(500)]
    public string? InstallGovOrderNo { get; set; }

    [Column("INSTALL_GOV_ORDER_DATE")]
    public DateOnly? InstallGovOrderDate { get; set; }

    [Column("INT_LOAN_ADVANCE_INSTALL_ID_old")]
    [StringLength(38)]
    public string? IntLoanAdvanceInstallIdOld { get; set; }

    [Column("INT_LOAN_ADVANCE_INSTALL_ID")]
    public int? IntLoanAdvanceInstallId { get; set; }

    [Column("INT_LOAN_ADVANCE_TYPE_ID_old")]
    [StringLength(38)]
    public string? IntLoanAdvanceTypeIdOld { get; set; }

    [Column("INT_LOAN_ADVANCE_TYPE_ID")]
    public int? IntLoanAdvanceTypeId { get; set; }

    [Column("MAX_LOAN_AMT_old")]
    [StringLength(38)]
    public string? MaxLoanAmtOld { get; set; }

    [Column("MAX_LOAN_AMT")]
    public int? MaxLoanAmt { get; set; }

    [Column("MAX_LOAN_AMT_OF_MONTH_BASIC_old")]
    [StringLength(38)]
    public string? MaxLoanAmtOfMonthBasicOld { get; set; }

    [Column("MAX_LOAN_AMT_OF_MONTH_BASIC")]
    public int? MaxLoanAmtOfMonthBasic { get; set; }

    [Column("EMP_MIN_BASIC_AMT_old")]
    [StringLength(38)]
    public string? EmpMinBasicAmtOld { get; set; }

    [Column("EMP_MIN_BASIC_AMT")]
    public int? EmpMinBasicAmt { get; set; }

    [Column("EMP_MAX_BASIC_AMT_old")]
    [StringLength(38)]
    public string? EmpMaxBasicAmtOld { get; set; }

    [Column("EMP_MAX_BASIC_AMT")]
    public int? EmpMaxBasicAmt { get; set; }

    [Column("INSTALLMENT_PRIN_NO_old")]
    [StringLength(38)]
    public string? InstallmentPrinNoOld { get; set; }

    [Column("INSTALLMENT_PRIN_NO")]
    public int? InstallmentPrinNo { get; set; }

    [Column("INSTALLMENT_INT_NO_old")]
    [StringLength(38)]
    public string? InstallmentIntNoOld { get; set; }

    [Column("INSTALLMENT_INT_NO")]
    public int? InstallmentIntNo { get; set; }

    [Column("CREATED_USER_ID_old")]
    [StringLength(38)]
    public string? CreatedUserIdOld { get; set; }

    [Column("CREATED_USER_ID")]
    public int? CreatedUserId { get; set; }

    [Column("MODIFIED_USER_ID_old")]
    [StringLength(38)]
    public string? ModifiedUserIdOld { get; set; }

    [Column("MODIFIED_USER_ID")]
    public int? ModifiedUserId { get; set; }

    [Column("MOTOR_CYCLE_ADVANCE_SL_NO_old")]
    [StringLength(38)]
    public string? MotorCycleAdvanceSlNoOld { get; set; }

    [Column("MOTOR_CYCLE_ADVANCE_SL_NO")]
    public int? MotorCycleAdvanceSlNo { get; set; }

    [Column("INT_GRP_ID_old")]
    [StringLength(38)]
    public string? IntGrpIdOld { get; set; }

    [Column("INT_GRP_ID")]
    public int? IntGrpId { get; set; }

    [Column("INT_SRV_ID_old")]
    [StringLength(38)]
    public string? IntSrvIdOld { get; set; }

    [Column("INT_SRV_ID")]
    public int? IntSrvId { get; set; }

    [Column("INT_EMPLOYMENT_TYPE_old")]
    [StringLength(38)]
    public string? IntEmploymentTypeOld { get; set; }

    [Column("INT_EMPLOYMENT_TYPE")]
    public int? IntEmploymentType { get; set; }

    [Column("MIN_SERVICE_COMPLETED_IN_MONTH_old")]
    [StringLength(38)]
    public string? MinServiceCompletedInMonthOld { get; set; }

    [Column("MIN_SERVICE_COMPLETED_IN_MONTH")]
    public int? MinServiceCompletedInMonth { get; set; }

    [Column("MIN_SERVICE_LEFT_IN_MONTH_old")]
    [StringLength(38)]
    public string? MinServiceLeftInMonthOld { get; set; }

    [Column("MIN_SERVICE_LEFT_IN_MONTH")]
    public int? MinServiceLeftInMonth { get; set; }

    [Column("DIFF_BETW_PREV_REC_IN_MONTH_old")]
    [StringLength(38)]
    public string? DiffBetwPrevRecInMonthOld { get; set; }

    [Column("DIFF_BETW_PREV_REC_IN_MONTH")]
    public int? DiffBetwPrevRecInMonth { get; set; }
}
