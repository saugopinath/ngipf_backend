using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Keyless]
[Table("hr_md_gen_ho_personal_detail", Schema = "ihrms_master")]
public partial class HrMdGenHoPersonalDetail
{
    [Column("HOO_NAME")]
    [StringLength(100)]
    public string? HooName { get; set; }

    [Column("HOO_OFFICE_PH")]
    [StringLength(20)]
    public string? HooOfficePh { get; set; }

    [Column("OFFICE_ORDER_NO")]
    [StringLength(30)]
    public string? OfficeOrderNo { get; set; }

    [Column("OFFICE_ORDER_DATE")]
    public DateOnly? OfficeOrderDate { get; set; }

    [Column("EMAIL_ID")]
    [StringLength(50)]
    public string? EmailId { get; set; }

    [Column("CREATED_TIMESTAMP")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("MODIFIED_TIMESTAMP")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("DEFAULT_OFFICE_ADDRESS")]
    [StringLength(3)]
    public string? DefaultOfficeAddress { get; set; }

    [Column("ACTIVE_FLAG")]
    [StringLength(3)]
    public string? ActiveFlag { get; set; }

    [Column("INT_HO_PERSONAL_ID_old")]
    [StringLength(38)]
    public string? IntHoPersonalIdOld { get; set; }

    [Column("INT_HO_PERSONAL_ID")]
    public int? IntHoPersonalId { get; set; }

    [Column("INT_HEAD_OF_OFFICE_ID_old")]
    [StringLength(38)]
    public string? IntHeadOfOfficeIdOld { get; set; }

    [Column("INT_HEAD_OF_OFFICE_ID")]
    public int? IntHeadOfOfficeId { get; set; }

    [Column("HOO_USER_ID_old")]
    [StringLength(38)]
    public string? HooUserIdOld { get; set; }

    [Column("HOO_USER_ID")]
    public int? HooUserId { get; set; }

    [Column("MOBILE_NO_old")]
    [StringLength(38)]
    public string? MobileNoOld { get; set; }

    [Column("MOBILE_NO")]
    public int? MobileNo { get; set; }

    [Column("DML_STATUS_FLAG_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("DML_STATUS_FLAG")]
    public int? DmlStatusFlag { get; set; }

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
