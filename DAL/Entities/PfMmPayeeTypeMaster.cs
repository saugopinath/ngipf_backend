using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("pf_mm_payee_type_master", Schema = "ngipf")]
public partial class PfMmPayeeTypeMaster
{
    [Key]
    [Column("int_payee_type_id")]
    public short IntPayeeTypeId { get; set; }

    [Column("payee_desc")]
    [StringLength(100)]
    public string? PayeeDesc { get; set; }

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
