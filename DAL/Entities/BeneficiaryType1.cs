﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("beneficiary_type", Schema = "epradan_master")]
public partial class BeneficiaryType1
{
    [Key]
    [Column("id")]
    public short Id { get; set; }

    [Column("desc", TypeName = "character varying")]
    public string? Desc { get; set; }

    [InverseProperty("BeneficiaryTypeNavigation")]
    public virtual ICollection<BeneficiaryMaster> BeneficiaryMasters { get; set; } = new List<BeneficiaryMaster>();
}
