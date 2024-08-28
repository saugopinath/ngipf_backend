using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("hr_md_gen_rev_pay_allw_order", Schema = "ihrms_master")]
public partial class HrMdGenRevPayAllwOrder
{
    [Column("INCREMENT_INTERVAL")]
    [StringLength(1)]
    public string? IncrementInterval { get; set; }

    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("CREATED_TIMESTAMP")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("MODIFIED_TIMESTAMP")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("INT_TD_REV_PAY_ALLOWANCE_ID_old")]
    [StringLength(38)]
    public string? IntTdRevPayAllowanceIdOld { get; set; }

    [Column("INT_TD_REV_PAY_ALLOWANCE_ID")]
    public int? IntTdRevPayAllowanceId { get; set; }

    [Column("INT_REV_PAY_ALLOWANCE_ID_old")]
    [StringLength(38)]
    public string? IntRevPayAllowanceIdOld { get; set; }

    [Column("INT_REV_PAY_ALLOWANCE_ID")]
    public int? IntRevPayAllowanceId { get; set; }

    [Column("INCREMENT_MONTH_old")]
    [StringLength(38)]
    public string? IncrementMonthOld { get; set; }

    [Column("INCREMENT_MONTH")]
    public int? IncrementMonth { get; set; }

    [Column("INCREMENT_DAY_old")]
    [StringLength(38)]
    public string? IncrementDayOld { get; set; }

    [Column("INCREMENT_DAY")]
    public int? IncrementDay { get; set; }

    [Column("INCREMENT_FREQUENCY_old")]
    [StringLength(38)]
    public string? IncrementFrequencyOld { get; set; }

    [Column("INCREMENT_FREQUENCY")]
    public int? IncrementFrequency { get; set; }

    [Column("INCREMENT_PERCENTAGE_old")]
    [StringLength(38)]
    public string? IncrementPercentageOld { get; set; }

    [Column("INCREMENT_PERCENTAGE")]
    public int? IncrementPercentage { get; set; }

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
}
