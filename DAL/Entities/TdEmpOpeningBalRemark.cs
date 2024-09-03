using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("td_emp_opening_bal_remarks", Schema = "ngipf")]
public partial class TdEmpOpeningBalRemark
{
    [Key]
    [Column("int_td_emp_open_bal_rem_id")]
    [StringLength(38)]
    public string IntTdEmpOpenBalRemId { get; set; } = null!;

    [Column("int_td_emp_open_bal_id")]
    [StringLength(38)]
    public string IntTdEmpOpenBalId { get; set; } = null!;

    [Column("remarks")]
    [StringLength(500)]
    public string Remarks { get; set; } = null!;

    [Column("dml_ststus_flag")]
    public short DmlStstusFlag { get; set; }

    [Column("created_user_id")]
    public long CreatedUserId { get; set; }

    [Column("created_role_id")]
    public long CreatedRoleId { get; set; }

    [Column("created_date", TypeName = "timestamp(6) without time zone")]
    public DateTime CreatedDate { get; set; }
}
