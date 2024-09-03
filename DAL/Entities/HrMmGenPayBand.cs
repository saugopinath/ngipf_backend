using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("hr_mm_gen_pay_band", Schema = "ihrms_master")]
public partial class HrMmGenPayBand
{
    [Column("pay_band")]
    [StringLength(10)]
    public string? PayBand { get; set; }

    [Column("wef_date", TypeName = "timestamp without time zone")]
    public DateTime? WefDate { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("int_payb_id_old")]
    [StringLength(38)]
    public string? IntPaybIdOld { get; set; }

    [Column("payb_id_old")]
    [StringLength(38)]
    public string? PaybIdOld { get; set; }

    [Column("payb_id")]
    public int? PaybId { get; set; }

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

    [Column("min_amt_old")]
    [StringLength(38)]
    public string? MinAmtOld { get; set; }

    [Column("min_amt")]
    public int? MinAmt { get; set; }

    [Column("max_amt_old")]
    [StringLength(38)]
    public string? MaxAmtOld { get; set; }

    [Column("max_amt")]
    public int? MaxAmt { get; set; }

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

    [Column("int_rev_pay_allowance_id_old")]
    [StringLength(38)]
    public string? IntRevPayAllowanceIdOld { get; set; }

    [Column("int_rev_pay_allowance_id")]
    public int? IntRevPayAllowanceId { get; set; }

    [Column("entry_point_minimum_pay_old")]
    [StringLength(38)]
    public string? EntryPointMinimumPayOld { get; set; }

    [Column("entry_point_minimum_pay")]
    public int? EntryPointMinimumPay { get; set; }

    [Column("prev_int_payb_id_old")]
    [StringLength(38)]
    public string? PrevIntPaybIdOld { get; set; }

    [Column("prev_int_payb_id")]
    public int? PrevIntPaybId { get; set; }

    [Key]
    [Column("int_payb_id")]
    public int IntPaybId { get; set; }

    [InverseProperty("IntPaybIdObsNavigation")]
    public virtual ICollection<HrMdEmpPayInformationWf> HrMdEmpPayInformationWfs { get; set; } = new List<HrMdEmpPayInformationWf>();

    [InverseProperty("IntPaybIdObsNavigation")]
    public virtual ICollection<HrMdEmpPayInformation> HrMdEmpPayInformations { get; set; } = new List<HrMdEmpPayInformation>();
}
