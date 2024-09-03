using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("hr_md_emp_quarter_occupanc_aud", Schema = "ihrms")]
[Index("IntEmployeeId", Name = "ind_hr_md_emp_qtr_ocu_aud1")]
[Index("StateId", Name = "ind_hr_md_emp_qtr_ocu_aud2")]
[Index("IntDistrictId", Name = "ind_hr_md_emp_qtr_ocu_aud3")]
[Index("IntResidentialTypeId", Name = "ind_hr_md_emp_qtr_ocu_aud4")]
[Index("IntOmiQuarterTypeId", Name = "ind_hr_md_emp_qtr_ocu_aud5")]
[Index("RequestId", Name = "ind_hr_md_emp_qtr_ocu_aud7")]
public partial class HrMdEmpQuarterOccupancAud
{
    private BigInteger? intEmployeeId;

    [Key]
    [Column("int_qua_occu_id_aud")]
    [StringLength(38)]
    public string IntQuaOccuIdAud { get; set; } = null!;

    [Column("int_qua_occu_id")]
    [StringLength(38)]
    public string? IntQuaOccuId { get; set; }

    [Column("int_employee_id")]
    [Precision(38, 0)]
    public BigInteger? IntEmployeeId { get => intEmployeeId; set => intEmployeeId = value; }

    [Column("querter_number")]
    [StringLength(30)]
    public string? QuerterNumber { get; set; }

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

    [Column("wef", TypeName = "timestamp(0) without time zone")]
    public DateTime? Wef { get; set; }

    [Column("occupancy_end_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? OccupancyEndDate { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("int_residential_type_id")]
    [StringLength(38)]
    public string? IntResidentialTypeId { get; set; }

    [Column("effective_end_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? EffectiveEndDate { get; set; }

    [Column("prev_int_qua_occu_id")]
    [StringLength(38)]
    public string? PrevIntQuaOccuId { get; set; }

    [Column("dml_status_flag")]
    public short? DmlStatusFlag { get; set; }

    [Column("workflow_status_flag")]
    [StringLength(2)]
    public string? WorkflowStatusFlag { get; set; }

    [Column("last_updated_by")]
    public int? LastUpdatedBy { get; set; }

    [Column("last_updated_on", TypeName = "timestamp without time zone")]
    public DateTime? LastUpdatedOn { get; set; }

    [Column("last_updated_by_role")]
    public int? LastUpdatedByRole { get; set; }

    [Column("int_omi_quarter_type_id")]
    [StringLength(38)]
    public string? IntOmiQuarterTypeId { get; set; }

    [Column("request_id")]
    public long? RequestId { get; set; }

    [Column("querter_rent_amount")]
    public int? QuerterRentAmount { get; set; }

    [Column("go_order_number")]
    [StringLength(50)]
    public string? GoOrderNumber { get; set; }

    [Column("go_order_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? GoOrderDate { get; set; }
}
