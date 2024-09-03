using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("lf_pl_op_balance_permission_status_master", Schema = "ngipf_master")]
public partial class LfPlOpBalancePermissionStatusMaster
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(50)]
    public string? Name { get; set; }

    [Column("status")]
    public short? Status { get; set; }

    [InverseProperty("PermissionTypeNavigation")]
    public virtual ICollection<LfPlOpOpeningBalancePermissionStatus> LfPlOpOpeningBalancePermissionStatuses { get; set; } = new List<LfPlOpOpeningBalancePermissionStatus>();
}
