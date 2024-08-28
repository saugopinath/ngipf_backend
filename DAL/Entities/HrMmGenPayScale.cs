using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("hr_mm_gen_pay_scale", Schema = "ihrms_master")]
public partial class HrMmGenPayScale
{
    [Column("pay_scale_number")]
    [StringLength(100)]
    public string? PayScaleNumber { get; set; }

    [Column("wef_date", TypeName = "timestamp without time zone")]
    public DateTime? WefDate { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("created_timestamp", TypeName = "timestamp without time zone")]
    public DateTime CreatedTimestamp { get; set; }

    [Column("modified_timestamp", TypeName = "timestamp without time zone")]
    public DateTime? ModifiedTimestamp { get; set; }

    [Column("stagnation_incr_flag")]
    [StringLength(1)]
    public string? StagnationIncrFlag { get; set; }

    [Column("int_pay_scale_id_old")]
    [StringLength(38)]
    public string? IntPayScaleIdOld { get; set; }

    [Column("int_grp_id_old")]
    [StringLength(38)]
    public string? IntGrpIdOld { get; set; }

    [Column("int_grp_id")]
    public int? IntGrpId { get; set; }

    [Column("int_srv_id_old")]
    [StringLength(38)]
    public string? IntSrvIdOld { get; set; }

    [Column("int_srv_id")]
    public int? IntSrvId { get; set; }

    [Column("pay_scale_start_amt_old")]
    [StringLength(38)]
    public string? PayScaleStartAmtOld { get; set; }

    [Column("pay_scale_start_amt")]
    public int? PayScaleStartAmt { get; set; }

    [Column("pay_scale_increaese_amt_old")]
    [StringLength(38)]
    public string? PayScaleIncreaeseAmtOld { get; set; }

    [Column("pay_scale_increaese_amt")]
    public int? PayScaleIncreaeseAmt { get; set; }

    [Column("pay_scale_end_amt_old")]
    [StringLength(38)]
    public string? PayScaleEndAmtOld { get; set; }

    [Column("pay_scale_end_amt")]
    public int? PayScaleEndAmt { get; set; }

    [Column("int_rev_pay_allowance_id_old")]
    [StringLength(38)]
    public string? IntRevPayAllowanceIdOld { get; set; }

    [Column("int_rev_pay_allowance_id")]
    public int? IntRevPayAllowanceId { get; set; }

    [Column("sequence_number_old")]
    [StringLength(38)]
    public string? SequenceNumberOld { get; set; }

    [Column("sequence_number")]
    public int? SequenceNumber { get; set; }

    [Column("dml_status_flag_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("dml_status_flag")]
    public int? DmlStatusFlag { get; set; }

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

    [Column("entry_point_minimum_pay_old")]
    [StringLength(38)]
    public string? EntryPointMinimumPayOld { get; set; }

    [Column("entry_point_minimum_pay")]
    public int? EntryPointMinimumPay { get; set; }

    [Column("int_gis_grp_id_old")]
    [StringLength(38)]
    public string? IntGisGrpIdOld { get; set; }

    [Column("int_gis_grp_id")]
    public int? IntGisGrpId { get; set; }

    [Key]
    [Column("int_pay_scale_id")]
    public int IntPayScaleId { get; set; }

    [InverseProperty("IntPayScaleIdObsNavigation")]
    public virtual ICollection<HrMdEmpPayInformationWf> HrMdEmpPayInformationWfs { get; set; } = new List<HrMdEmpPayInformationWf>();

    [InverseProperty("IntPayScaleIdObsNavigation")]
    public virtual ICollection<HrMdEmpPayInformation> HrMdEmpPayInformations { get; set; } = new List<HrMdEmpPayInformation>();
}
