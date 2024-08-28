using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Keyless]
[Table("pf_tm_balance_memo", Schema = "ngipf")]
public partial class PfTmBalanceMemo
{
    [Column("request_id")]
    public long RequestId { get; set; }

    [Column("int_emp_id")]
    [StringLength(38)]
    public string? IntEmpId { get; set; }

    [Column("memo_no")]
    [StringLength(100)]
    public string MemoNo { get; set; } = null!;

    [Column("memo_date", TypeName = "timestamp(0) without time zone")]
    public DateTime MemoDate { get; set; }

    [Column("dml_status_flag")]
    public short DmlStatusFlag { get; set; }
}
