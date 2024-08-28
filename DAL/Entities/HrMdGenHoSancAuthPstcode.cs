using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Keyless]
[Table("hr_md_gen_ho_sanc_auth_pstcode", Schema = "ihrms_master")]
public partial class HrMdGenHoSancAuthPstcode
{
    [Column("TRANSFER_FLAG")]
    [StringLength(5)]
    public string? TransferFlag { get; set; }

    [Column("STATUS_FLAG")]
    [StringLength(5)]
    public string? StatusFlag { get; set; }

    [Column("WEF", TypeName = "timestamp without time zone")]
    public DateTime Wef { get; set; }

    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("CREATED_ON", TypeName = "timestamp without time zone")]
    public DateTime CreatedOn { get; set; }

    [Column("LAST_UPDATED_ON", TypeName = "timestamp without time zone")]
    public DateTime? LastUpdatedOn { get; set; }

    [Column("SENDER_FLAG")]
    [StringLength(50)]
    public string? SenderFlag { get; set; }

    [Column("RECEIVER_FLAG")]
    [StringLength(50)]
    public string? ReceiverFlag { get; set; }

    [Column("IS_APPROVED")]
    [StringLength(1)]
    public string? IsApproved { get; set; }

    [Column("FROM_HOO_FLAG")]
    [StringLength(1)]
    public string? FromHooFlag { get; set; }

    [Column("FROM_HOO_IS_APPROVED")]
    [StringLength(1)]
    public string? FromHooIsApproved { get; set; }

    [Column("INT_HO_SANC_AUTH_PSTCODE_ID_old")]
    [StringLength(38)]
    public string? IntHoSancAuthPstcodeIdOld { get; set; }

    [Column("INT_HO_SANC_AUTH_PSTCODE_ID")]
    public int? IntHoSancAuthPstcodeId { get; set; }

    [Column("INT_HO_DEC_SANC_AUTH_MST_ID_old")]
    [StringLength(38)]
    public string? IntHoDecSancAuthMstIdOld { get; set; }

    [Column("INT_HO_DEC_SANC_AUTH_MST_ID")]
    public int? IntHoDecSancAuthMstId { get; set; }

    [Column("INT_HO_DEC_SANC_AUTH_DET_ID_old")]
    [StringLength(38)]
    public string? IntHoDecSancAuthDetIdOld { get; set; }

    [Column("INT_HO_DEC_SANC_AUTH_DET_ID")]
    public int? IntHoDecSancAuthDetId { get; set; }

    [Column("INT_POST_CODE_old")]
    [StringLength(38)]
    public string? IntPostCodeOld { get; set; }

    [Column("INT_POST_CODE")]
    public int? IntPostCode { get; set; }

    [Column("INT_EMPLOYEE_ID_old")]
    [StringLength(38)]
    public string? IntEmployeeIdOld { get; set; }

    [Column("INT_EMPLOYEE_ID")]
    public int? IntEmployeeId { get; set; }

    [Column("DISTRIBUTION_FLAG_old")]
    [StringLength(38)]
    public string? DistributionFlagOld { get; set; }

    [Column("DISTRIBUTION_FLAG")]
    public int? DistributionFlag { get; set; }

    [Column("DML_STATUS_FLAG_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("DML_STATUS_FLAG")]
    public int? DmlStatusFlag { get; set; }

    [Column("CREATED_BY_old")]
    [StringLength(38)]
    public string? CreatedByOld { get; set; }

    [Column("CREATED_BY")]
    public int? CreatedBy { get; set; }

    [Column("CREATED_ROLE_old")]
    [StringLength(38)]
    public string? CreatedRoleOld { get; set; }

    [Column("CREATED_ROLE")]
    public int? CreatedRole { get; set; }

    [Column("LAST_UPDATED_BY_old")]
    [StringLength(38)]
    public string? LastUpdatedByOld { get; set; }

    [Column("LAST_UPDATED_BY")]
    public int? LastUpdatedBy { get; set; }

    [Column("LAST_UPDATED_ROLE_old")]
    [StringLength(38)]
    public string? LastUpdatedRoleOld { get; set; }

    [Column("LAST_UPDATED_ROLE")]
    public int? LastUpdatedRole { get; set; }

    [Column("INT_SENDER_ID_old")]
    [StringLength(38)]
    public string? IntSenderIdOld { get; set; }

    [Column("INT_SENDER_ID")]
    public int? IntSenderId { get; set; }

    [Column("INT_RECEIVER_ID_old")]
    [StringLength(38)]
    public string? IntReceiverIdOld { get; set; }

    [Column("INT_RECEIVER_ID")]
    public int? IntReceiverId { get; set; }

    [Column("INT_ACTIVITY_DONE_ID_old")]
    [StringLength(38)]
    public string? IntActivityDoneIdOld { get; set; }

    [Column("INT_ACTIVITY_DONE_ID")]
    public int? IntActivityDoneId { get; set; }

    [Column("INT_ACTIVITY_DONE_BY_USER_old")]
    [StringLength(38)]
    public string? IntActivityDoneByUserOld { get; set; }

    [Column("INT_ACTIVITY_DONE_BY_USER")]
    public int? IntActivityDoneByUser { get; set; }

    [Column("INT_ACTIVITY_DONE_BY_ROLE_old")]
    [StringLength(38)]
    public string? IntActivityDoneByRoleOld { get; set; }

    [Column("INT_ACTIVITY_DONE_BY_ROLE")]
    public int? IntActivityDoneByRole { get; set; }

    [Column("INT_HO_SANC_PREV_PSTCODE_ID_old")]
    [StringLength(38)]
    public string? IntHoSancPrevPstcodeIdOld { get; set; }

    [Column("INT_HO_SANC_PREV_PSTCODE_ID")]
    public int? IntHoSancPrevPstcodeId { get; set; }

    [Column("SERIAL_NO_old")]
    [StringLength(38)]
    public string? SerialNoOld { get; set; }

    [Column("SERIAL_NO")]
    public int? SerialNo { get; set; }

    [Column("INT_MM_GEN_WF_MOD_SUBTYPE_ID_old")]
    [StringLength(38)]
    public string? IntMmGenWfModSubtypeIdOld { get; set; }

    [Column("INT_MM_GEN_WF_MOD_SUBTYPE_ID")]
    public int? IntMmGenWfModSubtypeId { get; set; }

    [Column("INT_MM_GEN_WF_MOD_TYPE_ID_old")]
    [StringLength(38)]
    public string? IntMmGenWfModTypeIdOld { get; set; }

    [Column("INT_MM_GEN_WF_MOD_TYPE_ID")]
    public int? IntMmGenWfModTypeId { get; set; }
}
