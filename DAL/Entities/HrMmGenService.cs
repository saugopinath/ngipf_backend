using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("hr_mm_gen_service", Schema = "ihrms_master")]
public partial class HrMmGenService
{
    [Column("SERVICE_TYPE")]
    [StringLength(50)]
    public string? ServiceType { get; set; }

    [Column("SERVICE_DESCRIPTION")]
    [StringLength(50)]
    public string? ServiceDescription { get; set; }

    [Column("WEF_DATE", TypeName = "timestamp without time zone")]
    public DateTime? WefDate { get; set; }

    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("CREATED_TIMESTAMP")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("MODIFIED_TIMESTAMP")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("CITY_GRADE_APPLICABLE")]
    [StringLength(1)]
    public string? CityGradeApplicable { get; set; }

    [Column("WAGES")]
    [StringLength(2)]
    public string? Wages { get; set; }

    [Column("LEGACY_ENTRY_REQUIRED")]
    [StringLength(1)]
    public string? LegacyEntryRequired { get; set; }

    [Column("BONUS_APPLICABLE")]
    [StringLength(1)]
    public string? BonusApplicable { get; set; }

    [Column("PAY_DETAIL_HEAD")]
    [StringLength(2)]
    public string? PayDetailHead { get; set; }

    [Column("ATTENDANCE_REQUIRED")]
    [StringLength(1)]
    public string? AttendanceRequired { get; set; }

    [Column("ROPA_UPDATION_STOP_BY_DDO")]
    [StringLength(1)]
    public string? RopaUpdationStopByDdo { get; set; }

    [Column("SALARY_BILL_STOP_REQUIRED")]
    [StringLength(1)]
    public string? SalaryBillStopRequired { get; set; }

    [Column("SMS_GROUP")]
    [StringLength(5)]
    public string? SmsGroup { get; set; }

    [Column("PAY_UPDATION_FLAG")]
    [StringLength(1)]
    public string? PayUpdationFlag { get; set; }

    [Column("APPLICABLE_FOR_ESS")]
    [StringLength(1)]
    public string? ApplicableForEss { get; set; }

    [Column("APPLICABLE_FOR_WORKFLOW")]
    [StringLength(2)]
    public string? ApplicableForWorkflow { get; set; }

    [Column("INT_SRV_ID_old")]
    [StringLength(38)]
    public string? IntSrvIdOld { get; set; }

    [Column("INT_SRV_ID")]
    public int? IntSrvId { get; set; }

    [Column("SRV_ID_old")]
    [StringLength(38)]
    public string? SrvIdOld { get; set; }

    [Column("SRV_ID")]
    public int? SrvId { get; set; }

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
