using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("md_gen_level_code", Schema = "ifmsadmin")]
public partial class MdGenLevelCode
{
    [Key]
    [Column("bco_code")]
    [StringLength(15)]
    public string BcoCode { get; set; } = null!;

    [Column("bco_desg")]
    [StringLength(100)]
    public string? BcoDesg { get; set; }

    [Column("address1")]
    [StringLength(200)]
    public string? Address1 { get; set; }

    [Column("phone_no")]
    [StringLength(20)]
    public string? PhoneNo { get; set; }

    [Column("e_mail")]
    [StringLength(50)]
    public string? EMail { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("address2")]
    [StringLength(200)]
    public string? Address2 { get; set; }

    [Column("office_name")]
    [StringLength(200)]
    public string? OfficeName { get; set; }

    [Column("fax_no")]
    [StringLength(20)]
    public string? FaxNo { get; set; }

    [Column("valid_upto")]
    public DateOnly? ValidUpto { get; set; }

    [Column("int_level_id_old")]
    [StringLength(38)]
    public string? IntLevelIdOld { get; set; }

    [Column("int_level_id")]
    public int? IntLevelId { get; set; }

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

    [Column("dml_status_flag_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("dml_status_flag")]
    public int? DmlStatusFlag { get; set; }

    [Column("mobile_no_old")]
    [StringLength(38)]
    public string? MobileNoOld { get; set; }

    [Column("mobile_no")]
    public int? MobileNo { get; set; }

    [Column("pin_old")]
    [StringLength(38)]
    public string? PinOld { get; set; }

    [Column("pin")]
    public int? Pin { get; set; }
}
