using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Keyless]
[Table("mm_gen_scheme_code", Schema = "ifmsadmin")]
public partial class MmGenSchemeCode
{
    [Column("scheme_code")]
    [StringLength(5)]
    public string? SchemeCode { get; set; }

    [Column("scheme_desc")]
    [StringLength(400)]
    public string? SchemeDesc { get; set; }

    [Column("scheme_type")]
    [StringLength(2)]
    public string? SchemeType { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("go_number")]
    [StringLength(200)]
    public string? GoNumber { get; set; }

    [Column("go_date")]
    public DateOnly? GoDate { get; set; }

    [Column("ministry_code")]
    [StringLength(5)]
    public string? MinistryCode { get; set; }

    [Column("commencement_date")]
    public DateOnly? CommencementDate { get; set; }

    [Column("end_date")]
    public DateOnly? EndDate { get; set; }

    [Column("remarks")]
    [StringLength(200)]
    public string? Remarks { get; set; }

    [Column("pfms_code")]
    [StringLength(5)]
    public string? PfmsCode { get; set; }

    [Column("department_code")]
    [StringLength(2)]
    public string? DepartmentCode { get; set; }

    [Column("int_scheme_code_old")]
    [StringLength(38)]
    public string? IntSchemeCodeOld { get; set; }

    [Column("int_scheme_code")]
    public int? IntSchemeCode { get; set; }

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
}
