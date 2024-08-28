using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("hr_mm_gen_component", Schema = "ihrms_master")]
public partial class HrMmGenComponent
{
    [Column("component_name")]
    [StringLength(200)]
    public string? ComponentName { get; set; }

    [Column("component_abbr")]
    [StringLength(15)]
    public string? ComponentAbbr { get; set; }

    [Column("demand_no")]
    [StringLength(2)]
    public string? DemandNo { get; set; }

    [Column("major_head")]
    [StringLength(4)]
    public string? MajorHead { get; set; }

    [Column("submajor_head")]
    [StringLength(2)]
    public string? SubmajorHead { get; set; }

    [Column("minor_head")]
    [StringLength(3)]
    public string? MinorHead { get; set; }

    [Column("plan_status")]
    [StringLength(2)]
    public string? PlanStatus { get; set; }

    [Column("scheme_head")]
    [StringLength(3)]
    public string? SchemeHead { get; set; }

    [Column("detail_head")]
    [StringLength(2)]
    public string? DetailHead { get; set; }

    [Column("subdetail_head")]
    [StringLength(2)]
    public string? SubdetailHead { get; set; }

    [Column("charged_voted")]
    [StringLength(1)]
    public string? ChargedVoted { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("modifiable_yes_no")]
    [StringLength(2)]
    public string? ModifiableYesNo { get; set; }

    [Column("positive_negative_flag")]
    [StringLength(1)]
    public string? PositiveNegativeFlag { get; set; }

    [Column("changable_in_employee_master")]
    [StringLength(1)]
    public string? ChangableInEmployeeMaster { get; set; }

    [Column("principal_interest_component")]
    [StringLength(1)]
    public string? PrincipalInterestComponent { get; set; }

    [Column("bulk_upd")]
    [StringLength(1)]
    public string? BulkUpd { get; set; }

    [Column("arrear_flag")]
    [StringLength(1)]
    public string? ArrearFlag { get; set; }

    [Column("daily_allowance")]
    [StringLength(1)]
    public string? DailyAllowance { get; set; }

    [Column("service_book_flag_yes_no")]
    [StringLength(1)]
    public string? ServiceBookFlagYesNo { get; set; }

    [Column("pay_component_pen")]
    [StringLength(1)]
    public string? PayComponentPen { get; set; }

    [Column("spcl_pay_component_pen")]
    [StringLength(1)]
    public string? SpclPayComponentPen { get; set; }

    [Column("int_comp_id_old")]
    [StringLength(38)]
    public string? IntCompIdOld { get; set; }

    [Column("int_omi_component_code_old")]
    [StringLength(38)]
    public string? IntOmiComponentCodeOld { get; set; }

    [Column("int_omi_component_code")]
    public int? IntOmiComponentCode { get; set; }

    [Column("int_omi_component_type_id_old")]
    [StringLength(38)]
    public string? IntOmiComponentTypeIdOld { get; set; }

    [Column("int_omi_component_type_id")]
    public int? IntOmiComponentTypeId { get; set; }

    [Column("created_user_id_old")]
    [StringLength(38)]
    public string? CreatedUserIdOld { get; set; }

    [Column("created_user_id")]
    public int? CreatedUserId { get; set; }

    [Column("modified_user_id_old")]
    [StringLength(38)]
    public string? ModifiedUserIdOld { get; set; }

    [Column("modified_user_id")]
    public int? ModifiedUserId { get; set; }

    [Column("int_omi_optional_mandatory_id_old")]
    [StringLength(38)]
    public string? IntOmiOptionalMandatoryIdOld { get; set; }

    [Column("int_omi_optional_mandatory_id")]
    public int? IntOmiOptionalMandatoryId { get; set; }

    [Column("int_omi_recovery_type_id_old")]
    [StringLength(38)]
    public string? IntOmiRecoveryTypeIdOld { get; set; }

    [Column("int_omi_recovery_type_id")]
    public int? IntOmiRecoveryTypeId { get; set; }

    [Column("int_fixed_component_id_old")]
    [StringLength(38)]
    public string? IntFixedComponentIdOld { get; set; }

    [Column("int_fixed_component_id")]
    public int? IntFixedComponentId { get; set; }

    [Column("int_omi_frequency_old")]
    [StringLength(38)]
    public string? IntOmiFrequencyOld { get; set; }

    [Column("int_omi_frequency")]
    public int? IntOmiFrequency { get; set; }

    [Column("interval_old")]
    [StringLength(38)]
    public string? IntervalOld { get; set; }

    [Column("interval")]
    public int? Interval { get; set; }

    [Column("int_loan_advance_type_id_old")]
    [StringLength(38)]
    public string? IntLoanAdvanceTypeIdOld { get; set; }

    [Column("int_loan_advance_type_id")]
    public int? IntLoanAdvanceTypeId { get; set; }

    [Column("bt_serial_number_old")]
    [StringLength(38)]
    public string? BtSerialNumberOld { get; set; }

    [Column("bt_serial_number")]
    public int? BtSerialNumber { get; set; }

    [Column("reffered_int_comp_id_old")]
    [StringLength(38)]
    public string? RefferedIntCompIdOld { get; set; }

    [Column("reffered_int_comp_id")]
    public int? RefferedIntCompId { get; set; }

    [Column("int_omi_deduction_id_old")]
    [StringLength(38)]
    public string? IntOmiDeductionIdOld { get; set; }

    [Column("int_omi_deduction_id")]
    public int? IntOmiDeductionId { get; set; }

    [Column("old_int_comp_id_old")]
    [StringLength(38)]
    public string? OldIntCompIdOld { get; set; }

    [Column("old_int_comp_id")]
    public int? OldIntCompId { get; set; }

    [Column("order_by_srl_no_old")]
    [StringLength(38)]
    public string? OrderBySrlNoOld { get; set; }

    [Column("order_by_srl_no")]
    public int? OrderBySrlNo { get; set; }

    [Key]
    [Column("int_comp_id")]
    public int IntCompId { get; set; }

    [InverseProperty("IntComp")]
    public virtual ICollection<HrMdEmpPayAndAllowance> HrMdEmpPayAndAllowances { get; set; } = new List<HrMdEmpPayAndAllowance>();

    [InverseProperty("IntComp")]
    public virtual ICollection<HrMdEmpPayAndAllownceWf> HrMdEmpPayAndAllownceWfs { get; set; } = new List<HrMdEmpPayAndAllownceWf>();
}
