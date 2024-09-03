using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Keyless]
[Table("hr_mm_gen_oad_society_bank", Schema = "ihrms_master")]
public partial class HrMmGenOadSocietyBank
{
    [Column("BANK_OR_COOP_SOCY_FLAG")]
    [StringLength(1)]
    public string? BankOrCoopSocyFlag { get; set; }

    [Column("NAME_OF_SOCIETY_BANK")]
    [StringLength(100)]
    public string? NameOfSocietyBank { get; set; }

    [Column("IFSC_CODE")]
    [StringLength(90)]
    public string? IfscCode { get; set; }

    [Column("REGISTRATION_NUMBER")]
    [StringLength(100)]
    public string? RegistrationNumber { get; set; }

    [Column("REGISTRATION_DATE")]
    public DateOnly? RegistrationDate { get; set; }

    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("CREATED_TIMESTAMP", TypeName = "timestamp without time zone")]
    public DateTime? CreatedTimestamp { get; set; }

    [Column("APPROVAL_FLAG")]
    [StringLength(1)]
    public string? ApprovalFlag { get; set; }

    [Column("MODIFIED_TIMESTAMP", TypeName = "timestamp without time zone")]
    public DateTime? ModifiedTimestamp { get; set; }

    [Column("APPROVAL_TIME", TypeName = "timestamp without time zone")]
    public DateTime? ApprovalTime { get; set; }

    [Column("BENF_ID")]
    [StringLength(20)]
    public string? BenfId { get; set; }

    [Column("CHEQUE_ECS_MODE")]
    [StringLength(1)]
    public string? ChequeEcsMode { get; set; }

    [Column("INT_OAD_SOCIETY_BANK_ID_old")]
    [StringLength(38)]
    public string? IntOadSocietyBankIdOld { get; set; }

    [Column("INT_OAD_SOCIETY_BANK_ID")]
    public int? IntOadSocietyBankId { get; set; }

    [Column("INT_DISTRICT_ID_old")]
    [StringLength(38)]
    public string? IntDistrictIdOld { get; set; }

    [Column("INT_DISTRICT_ID")]
    public int? IntDistrictId { get; set; }

    [Column("USER_ID_old")]
    [StringLength(38)]
    public string? UserIdOld { get; set; }

    [Column("USER_ID")]
    public int? UserId { get; set; }

    [Column("INT_DDO_ID_old")]
    [StringLength(38)]
    public string? IntDdoIdOld { get; set; }

    [Column("INT_DDO_ID")]
    public int? IntDdoId { get; set; }

    [Column("MODIFIED_USER_ID_old")]
    [StringLength(38)]
    public string? ModifiedUserIdOld { get; set; }

    [Column("MODIFIED_USER_ID")]
    public int? ModifiedUserId { get; set; }

    [Column("APPROVED_BY_old")]
    [StringLength(38)]
    public string? ApprovedByOld { get; set; }

    [Column("APPROVED_BY")]
    public int? ApprovedBy { get; set; }
}
