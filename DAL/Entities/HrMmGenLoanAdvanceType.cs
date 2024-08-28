using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("hr_mm_gen_loan_advance_type", Schema = "ihrms_master")]
public partial class HrMmGenLoanAdvanceType
{
    [Column("LOAN_DESC")]
    [StringLength(200)]
    public string? LoanDesc { get; set; }

    [Column("LOAN_DESC_ABBR")]
    [StringLength(10)]
    public string? LoanDescAbbr { get; set; }

    [Column("INTEREST_APPLICABLE")]
    [StringLength(10)]
    public string? InterestApplicable { get; set; }

    [Column("WEF_DATE")]
    public DateOnly? WefDate { get; set; }

    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("DEMAND_NO")]
    [StringLength(2)]
    public string? DemandNo { get; set; }

    [Column("MAJOR_HEAD")]
    [StringLength(4)]
    public string? MajorHead { get; set; }

    [Column("SUBMAJOR_HEAD")]
    [StringLength(2)]
    public string? SubmajorHead { get; set; }

    [Column("MINOR_HEAD")]
    [StringLength(3)]
    public string? MinorHead { get; set; }

    [Column("PLAN_STATUS")]
    [StringLength(2)]
    public string? PlanStatus { get; set; }

    [Column("SCHEME_HEAD")]
    [StringLength(3)]
    public string? SchemeHead { get; set; }

    [Column("DETAIL_HEAD")]
    [StringLength(2)]
    public string? DetailHead { get; set; }

    [Column("SUBDETAIL_HEAD")]
    [StringLength(2)]
    public string? SubdetailHead { get; set; }

    [Column("CHARGED_VOTED")]
    [StringLength(1)]
    public string? ChargedVoted { get; set; }

    [Column("CREATED_TIMESTAMP", TypeName = "timestamp without time zone")]
    public DateTime CreatedTimestamp { get; set; }

    [Column("MODIFIED_TIMESTAMP", TypeName = "timestamp without time zone")]
    public DateTime ModifiedTimestamp { get; set; }

    [Column("MORTGAGE_REQUIRED")]
    [StringLength(1)]
    public string? MortgageRequired { get; set; }

    [Column("REFUNDABLE_FLAG")]
    [StringLength(1)]
    public string? RefundableFlag { get; set; }

    [Column("REQUEST_TYPE")]
    [StringLength(10)]
    public string? RequestType { get; set; }

    [Column("EFFECTIVE_END_DATE")]
    public DateOnly? EffectiveEndDate { get; set; }

    [Column("SANCTIONING_AUTHORITY")]
    [StringLength(4)]
    public string? SanctioningAuthority { get; set; }

    [Column("MOTOR_CYCLE_OLD_NEW_FLAG")]
    [StringLength(1)]
    public string? MotorCycleOldNewFlag { get; set; }

    [Column("INT_LOAN_ADVANCE_TYPE_ID_old")]
    [StringLength(38)]
    public string? IntLoanAdvanceTypeIdOld { get; set; }

    [Column("INT_LOAN_ADVANCE_TYPE_ID")]
    public int? IntLoanAdvanceTypeId { get; set; }

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

    [Column("INT_LOAN_HOA_old")]
    [StringLength(38)]
    public string? IntLoanHoaOld { get; set; }

    [Column("INT_LOAN_HOA")]
    public int? IntLoanHoa { get; set; }

    [Column("INT_LOAN_ADV_ABBR_ID_old")]
    [StringLength(38)]
    public string? IntLoanAdvAbbrIdOld { get; set; }

    [Column("INT_LOAN_ADV_ABBR_ID")]
    public int? IntLoanAdvAbbrId { get; set; }
}
