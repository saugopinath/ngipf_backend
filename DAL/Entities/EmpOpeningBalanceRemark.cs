using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Keyless]
[Table("emp_opening_balance_remarks", Schema = "ngipf")]
public partial class EmpOpeningBalanceRemark
{
    [Column("id")]
    public int Id { get; set; }

    [Column("op_balance_id")]
    public int? OpBalanceId { get; set; }

    [Column("remarks")]
    public string? Remarks { get; set; }

    [Column("is_temp")]
    public int? IsTemp { get; set; }
}
