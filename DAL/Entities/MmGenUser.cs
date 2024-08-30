using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("mm_gen_user", Schema = "ifmsadmin")]
public partial class MmGenUser
{
    [Column("login_id")]
    [StringLength(100)]
    public string? LoginId { get; set; }

    [Column("mobile_no")]
    [StringLength(13)]
    public string? MobileNo { get; set; }

    [Column("email_id")]
    [StringLength(100)]
    public string? EmailId { get; set; }

    [Column("office_code")]
    [StringLength(10)]
    public string? OfficeCode { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("user_name")]
    [StringLength(300)]
    public string? UserName { get; set; }

    [Column("expire_flag")]
    [StringLength(1)]
    public string? ExpireFlag { get; set; }

    [Column("effective_date")]
    public DateOnly? EffectiveDate { get; set; }

    [Column("expire_date")]
    public DateOnly? ExpireDate { get; set; }

    [Column("user_desg")]
    [StringLength(300)]
    public string? UserDesg { get; set; }

    [Column("own_user_flag")]
    [StringLength(1)]
    public string? OwnUserFlag { get; set; }

    [Column("otp_enabled")]
    [StringLength(1)]
    public string? OtpEnabled { get; set; }

    [Column("otp_valid_date")]
    public DateOnly? OtpValidDate { get; set; }

    [Column("employee_no")]
    [StringLength(50)]
    public string? EmployeeNo { get; set; }

    [Column("super_user_flag")]
    [StringLength(1)]
    public string? SuperUserFlag { get; set; }

    [Column("user_id_old")]
    [StringLength(38)]
    public string? UserIdOld { get; set; }

    [Column("establishment_id_old")]
    [StringLength(38)]
    public string? EstablishmentIdOld { get; set; }

    [Column("establishment_id")]
    public int? EstablishmentId { get; set; }

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

    [Key]
    [Column("user_id")]
    public int UserId { get; set; }

    [InverseProperty("IntUser")]
    public virtual ICollection<WorkflowUserMapping> WorkflowUserMappings { get; set; } = new List<WorkflowUserMapping>();
}
