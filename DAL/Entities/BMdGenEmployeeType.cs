using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("b_md_gen_employee_type", Schema = "ionlinebill")]
[Index("EmplTypeAbbr", Name = "uk_b_md_gen_empl_type", IsUnique = true)]
public partial class BMdGenEmployeeType
{
    [Key]
    [Column("int_empl_type_id")]
    public short IntEmplTypeId { get; set; }

    [Column("empl_type_desc")]
    [StringLength(200)]
    public string EmplTypeDesc { get; set; } = null!;

    [Column("active_flag")]
    [StringLength(1)]
    public string ActiveFlag { get; set; } = null!;

    [Column("empl_type_abbr")]
    [StringLength(6)]
    public string EmplTypeAbbr { get; set; } = null!;

    [Column("dml_status_flag")]
    public short DmlStatusFlag { get; set; }

    [Column("user_id")]
    public int UserId { get; set; }

    [Column("created_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime CreatedTimestamp { get; set; }

    [Column("modified_user_id")]
    public int ModifiedUserId { get; set; }

    [Column("modified_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime ModifiedTimestamp { get; set; }
}
