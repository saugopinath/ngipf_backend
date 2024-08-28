using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Keyless]
[Table("hr_mm_gen_buisness_pk_type_mst", Schema = "ihrms_master")]
public partial class HrMmGenBuisnessPkTypeMst
{
    [Column("int_business_pk_type_id")]
    public int? IntBusinessPkTypeId { get; set; }

    [Column("business_pk_type_desc")]
    [StringLength(100)]
    public string? BusinessPkTypeDesc { get; set; }

    [Column("business_pk_type_abbr")]
    [StringLength(100)]
    public string? BusinessPkTypeAbbr { get; set; }

    [Column("int_business_pk_type_id_old")]
    [StringLength(38)]
    public string? IntBusinessPkTypeIdOld { get; set; }
}
