using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("md_gen_bill_type", Schema = "ifmsadmin")]
[Index("AgBillTypeId", Name = "md_gen_bill_type_ag_bill_type_id_key", IsUnique = true)]
public partial class MdGenBillType
{
    [Column("description")]
    [StringLength(200)]
    public string? Description { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("by_trf_flag")]
    [StringLength(1)]
    public string? ByTrfFlag { get; set; }

    [Column("bill_type_abbr")]
    [StringLength(5)]
    public string? BillTypeAbbr { get; set; }

    [Column("salary_flag")]
    [StringLength(1)]
    public string? SalaryFlag { get; set; }

    [Column("purpose")]
    [StringLength(500)]
    public string? Purpose { get; set; }

    [Column("bill_type_desc")]
    [StringLength(100)]
    public string? BillTypeDesc { get; set; }

    [Column("int_bill_type_id_old")]
    [StringLength(38)]
    public string? IntBillTypeIdOld { get; set; }

    [Key]
    [Column("int_bill_type_id")]
    public int IntBillTypeId { get; set; }

    [Column("bill_type_id_old")]
    [StringLength(38)]
    public string? BillTypeIdOld { get; set; }

    [Column("bill_type_id")]
    public int? BillTypeId { get; set; }

    [Column("ag_bill_type_id_old")]
    [StringLength(38)]
    public string? AgBillTypeIdOld { get; set; }

    [Column("ag_bill_type_id")]
    public int? AgBillTypeId { get; set; }

    [Column("user_id_old")]
    [StringLength(38)]
    public string? UserIdOld { get; set; }

    [Column("user_id")]
    public int? UserId { get; set; }

    [Column("modified_user_id_old")]
    [StringLength(38)]
    public string? ModifiedUserIdOld { get; set; }

    [Column("modified_user_id")]
    public int? ModifiedUserId { get; set; }
}
