using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[PrimaryKey("HoaId", "OperatorType", "OperatorSubType", "PayRecFlag")]
[Table("t_mm_gen_pl_operator_hoa", Schema = "icts")]
public partial class TMmGenPlOperatorHoa
{
    [Key]
    [Column("hoa_id")]
    public long HoaId { get; set; }

    /// <summary>
    /// p - pl/lf/pf/od operator, w - works operator, f - forest operator
    /// </summary>
    [Key]
    [Column("operator_type")]
    [StringLength(1)]
    public string OperatorType { get; set; } = null!;

    /// <summary>
    /// pl - private ledger(8443), lf - local funds(8448), pf - provident fund(8336), pd - personal/other deposit(8449): only for p type operators.
    /// nd - normal deposit, sd - security deposit, md - miscellaneous deposit: for w or f type operators.
    /// </summary>
    [Key]
    [Column("operator_sub_type")]
    [StringLength(2)]
    public string OperatorSubType { get; set; } = null!;

    /// <summary>
    /// p - payment head, r - receipt head
    /// </summary>
    [Key]
    [Column("pay_rec_flag")]
    [StringLength(1)]
    public string PayRecFlag { get; set; } = null!;

    [Column("active_flag")]
    [StringLength(1)]
    public string ActiveFlag { get; set; } = null!;

    [Column("user_id")]
    public int UserId { get; set; }

    [Column("created_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime CreatedTimestamp { get; set; }

    [Column("modified_user_id")]
    public int ModifiedUserId { get; set; }

    [Column("modified_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime ModifiedTimestamp { get; set; }
}
