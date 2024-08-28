using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Keyless]
[Table("hr_mm_gen_bill_type", Schema = "ihrms_master")]
public partial class HrMmGenBillType
{
    [Column("BILL_TYPE_ABBR")]
    [StringLength(50)]
    public string? BillTypeAbbr { get; set; }

    [Column("BILL_TYPE_DESC")]
    [StringLength(50)]
    public string? BillTypeDesc { get; set; }

    [Column("BILL_TYPE_ID_old")]
    [StringLength(38)]
    public string? BillTypeIdOld { get; set; }

    [Column("BILL_TYPE_ID")]
    public int? BillTypeId { get; set; }

    [Column("INT_BILL_TYPE_ID_old")]
    [StringLength(38)]
    public string? IntBillTypeIdOld { get; set; }

    [Column("INT_BILL_TYPE_ID")]
    public int? IntBillTypeId { get; set; }

    [Column("AG_BILL_TYPE_ID_old")]
    [StringLength(38)]
    public string? AgBillTypeIdOld { get; set; }

    [Column("AG_BILL_TYPE_ID")]
    public int? AgBillTypeId { get; set; }
}
