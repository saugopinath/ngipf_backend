﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("treasury", Schema = "master")]
[Index("Code", Name = "treasury_code_key", IsUnique = true)]
public partial class Treasury
{
    [Key]
    [Column("id")]
    public short Id { get; set; }

    [Column("district_name")]
    [StringLength(30)]
    public string? DistrictName { get; set; }

    [Column("district_code")]
    public short? DistrictCode { get; set; }

    [Column("code")]
    [StringLength(3)]
    public string Code { get; set; } = null!;

    [Column("name")]
    [StringLength(100)]
    public string? Name { get; set; }

    public virtual ICollection<BillBtdetail> BillBtdetails { get; set; } = new List<BillBtdetail>();

    public virtual ICollection<BillDetail> BillDetails { get; set; } = new List<BillDetail>();

    public virtual ICollection<BillSubdetailInfo> BillSubdetailInfos { get; set; } = new List<BillSubdetailInfo>();

    public virtual ICollection<DdoAllotmentActual> DdoAllotmentActuals { get; set; } = new List<DdoAllotmentActual>();

    public virtual ICollection<DdoAllotmentBookedBill> DdoAllotmentBookedBills { get; set; } = new List<DdoAllotmentBookedBill>();

    public virtual ICollection<DdoAllotmentProvisional> DdoAllotmentProvisionals { get; set; } = new List<DdoAllotmentProvisional>();

    public virtual ICollection<DdoWalletActual> DdoWalletActuals { get; set; } = new List<DdoWalletActual>();

    public virtual ICollection<DdoWalletProvisional> DdoWalletProvisionals { get; set; } = new List<DdoWalletProvisional>();

    public virtual ICollection<StampWalletTransaction> StampWalletTransactions { get; set; } = new List<StampWalletTransaction>();

    [InverseProperty("Treasury")]
    public virtual ICollection<TreasuryHasBranch> TreasuryHasBranches { get; set; } = new List<TreasuryHasBranch>();

    public virtual ICollection<VendorStampRequisition> VendorStampRequisitions { get; set; } = new List<VendorStampRequisition>();
}
