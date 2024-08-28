using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("md_gen_bco_hoa_map", Schema = "ifmsadmin")]
public partial class MdGenBcoHoaMap
{
    [Column("bco_code")]
    [StringLength(20)]
    public string? BcoCode { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("int_hoa_map_id_old")]
    [StringLength(38)]
    public string? IntHoaMapIdOld { get; set; }

    [Key]
    [Column("int_hoa_map_id")]
    public int IntHoaMapId { get; set; }

    [Column("project_id_old")]
    [StringLength(38)]
    public string? ProjectIdOld { get; set; }

    [Column("project_id")]
    public int? ProjectId { get; set; }

    [Column("hoa_id_old")]
    [StringLength(38)]
    public string? HoaIdOld { get; set; }

    [Column("hoa_id")]
    public int? HoaId { get; set; }

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
}
