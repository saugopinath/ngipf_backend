using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("status_master", Schema = "ngipf_master")]
public partial class StatusMaster
{
    [Column("master_abbr")]
    [StringLength(12)]
    public string? MasterAbbr { get; set; }

    [Column("master_descr")]
    [StringLength(250)]
    public string? MasterDescr { get; set; }

    [Column("master_type")]
    [StringLength(20)]
    public string? MasterType { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("created_timestamp")]
    public DateOnly? CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly? ModifiedTimestamp { get; set; }

    [Key]
    [Column("int_master_id")]
    public short IntMasterId { get; set; }

    [InverseProperty("IntSalarySourceNavigation")]
    public virtual ICollection<EmpPfBasicDetail> EmpPfBasicDetailIntSalarySourceNavigations { get; set; } = new List<EmpPfBasicDetail>();

    [InverseProperty("StatusNavigation")]
    public virtual ICollection<EmpPfBasicDetail> EmpPfBasicDetailStatusNavigations { get; set; } = new List<EmpPfBasicDetail>();
}
