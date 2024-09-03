using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("hr_md_emp_service_exit", Schema = "ihrms")]
public partial class HrMdEmpServiceExit
{
    [Key]
    [Column("int_emp_service_exit")]
    [StringLength(38)]
    public string IntEmpServiceExit { get; set; } = null!;

    [Column("int_employee_id")]
    [Precision(38, 0)]
    public BigInteger? IntEmployeeId { get; set; }

    [Column("int_salary_stop_reason")]
    [StringLength(38)]
    public string? IntSalaryStopReason { get; set; }

    [Column("leaving_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? LeavingDate { get; set; }

    [Column("remarks")]
    [StringLength(200)]
    public string? Remarks { get; set; }

    [Column("office_order_number")]
    [StringLength(100)]
    public string? OfficeOrderNumber { get; set; }

    [Column("office_order_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? OfficeOrderDate { get; set; }

    [Column("house_no_street_lane")]
    [StringLength(100)]
    public string? HouseNoStreetLane { get; set; }

    [Column("city_town_village")]
    [StringLength(100)]
    public string? CityTownVillage { get; set; }

    [Column("post_office")]
    [StringLength(100)]
    public string? PostOffice { get; set; }

    [Column("police_station")]
    [StringLength(100)]
    public string? PoliceStation { get; set; }

    [Column("state_id")]
    public short? StateId { get; set; }

    [Column("int_district_id")]
    public int? IntDistrictId { get; set; }

    [Column("pin")]
    [StringLength(10)]
    public string? Pin { get; set; }

    [Column("request_id")]
    public long? RequestId { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("dml_status_flag")]
    public short? DmlStatusFlag { get; set; }

    [Column("last_updated_by")]
    public int? LastUpdatedBy { get; set; }

    [Column("last_updated_on", TypeName = "timestamp without time zone")]
    public DateTime? LastUpdatedOn { get; set; }

    [Column("workflow_status_flag")]
    [StringLength(2)]
    public string? WorkflowStatusFlag { get; set; }

    [Column("date_of_death", TypeName = "timestamp(0) without time zone")]
    public DateTime? DateOfDeath { get; set; }

    [Column("reject_after_app_flag")]
    [StringLength(1)]
    public string? RejectAfterAppFlag { get; set; }

    [Column("reject_after_app_by")]
    public int? RejectAfterAppBy { get; set; }

    [Column("reject_after_app_on", TypeName = "timestamp(0) without time zone")]
    public DateTime? RejectAfterAppOn { get; set; }

    [Column("reject_after_app_remarks")]
    [StringLength(200)]
    public string? RejectAfterAppRemarks { get; set; }

    [Column("order_issued_by")]
    [StringLength(50)]
    public string? OrderIssuedBy { get; set; }
}
