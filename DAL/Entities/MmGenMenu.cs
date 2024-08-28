using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Keyless]
[Table("mm_gen_menu", Schema = "ifmsadmin")]
public partial class MmGenMenu
{
    [Column("menu_label")]
    [StringLength(100)]
    public string? MenuLabel { get; set; }

    [Column("link_url")]
    [StringLength(200)]
    public string? LinkUrl { get; set; }

    [Column("link_target")]
    [StringLength(10)]
    public string? LinkTarget { get; set; }

    [Column("menu_label_other")]
    [StringLength(120)]
    public string? MenuLabelOther { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("created_timestamp")]
    public DateOnly? CreatedTimestamp { get; set; }

    [Column("modifed_timestamp")]
    public DateOnly? ModifedTimestamp { get; set; }

    [Column("app_url_flag")]
    [StringLength(1)]
    public string? AppUrlFlag { get; set; }

    [Column("app_url_is_report_flag")]
    [StringLength(1)]
    public string? AppUrlIsReportFlag { get; set; }

    [Column("app_menu_id")]
    [StringLength(50)]
    public string? AppMenuId { get; set; }

    [Column("app_menu_label")]
    [StringLength(100)]
    public string? AppMenuLabel { get; set; }

    [Column("angular_app")]
    [StringLength(1)]
    public string? AngularApp { get; set; }

    [Column("menu_name")]
    [StringLength(100)]
    public string? MenuName { get; set; }

    [Column("menu_description")]
    [StringLength(500)]
    public string? MenuDescription { get; set; }

    [Column("menu_icon_id")]
    [StringLength(50)]
    public string? MenuIconId { get; set; }

    [Column("additional_data")]
    [StringLength(4000)]
    public string? AdditionalData { get; set; }

    [Column("sub_system_id_old")]
    [StringLength(38)]
    public string? SubSystemIdOld { get; set; }

    [Column("sub_system_id")]
    public int? SubSystemId { get; set; }

    [Column("parent_menu_id_old")]
    [StringLength(38)]
    public string? ParentMenuIdOld { get; set; }

    [Column("parent_menu_id")]
    public int? ParentMenuId { get; set; }

    [Column("menu_id_old")]
    [StringLength(38)]
    public string? MenuIdOld { get; set; }

    [Column("menu_id")]
    public int? MenuId { get; set; }

    [Column("activity_id_old")]
    [StringLength(38)]
    public string? ActivityIdOld { get; set; }

    [Column("activity_id")]
    public int? ActivityId { get; set; }

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

    [Column("app_url_security_level_old")]
    [StringLength(38)]
    public string? AppUrlSecurityLevelOld { get; set; }

    [Column("app_url_security_level")]
    public int? AppUrlSecurityLevel { get; set; }

    [Column("parent_menu_structure_old")]
    [StringLength(38)]
    public string? ParentMenuStructureOld { get; set; }

    [Column("parent_menu_structure")]
    public int? ParentMenuStructure { get; set; }

    [Column("menu_structure_old")]
    [StringLength(38)]
    public string? MenuStructureOld { get; set; }

    [Column("menu_structure")]
    public int? MenuStructure { get; set; }

    [Column("menu_slno_old")]
    [StringLength(38)]
    public string? MenuSlnoOld { get; set; }

    [Column("menu_slno")]
    public int? MenuSlno { get; set; }
}
