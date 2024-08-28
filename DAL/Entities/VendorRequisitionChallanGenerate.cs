﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("vendor_requisition_challan_generate", Schema = "cts")]
public partial class VendorRequisitionChallanGenerate
{
    [Key]
    [Column("vendor_requisition_challan_generate_id")]
    public long VendorRequisitionChallanGenerateId { get; set; }

    [Column("vendor_requisition_staging_id")]
    public long VendorRequisitionStagingId { get; set; }

    [Column("sheet_by_to")]
    public short SheetByTo { get; set; }

    [Column("label_by_to")]
    public short LabelByTo { get; set; }

    [Column("discounted_amount")]
    [Precision(10, 2)]
    public decimal DiscountedAmount { get; set; }

    [Column("tax_amount")]
    [Precision(10, 2)]
    public decimal TaxAmount { get; set; }

    [Column("challan_amount")]
    [Precision(10, 2)]
    public decimal ChallanAmount { get; set; }

    [Column("hoa", TypeName = "character varying")]
    public string? Hoa { get; set; }

    [Column("requisition_no", TypeName = "character varying")]
    public string? RequisitionNo { get; set; }

    [Column("hoa_id")]
    public long? HoaId { get; set; }

    [ForeignKey("VendorRequisitionStagingId")]
    [InverseProperty("VendorRequisitionChallanGenerates")]
    public virtual VendorRequisitionStaging VendorRequisitionStaging { get; set; } = null!;

    [InverseProperty("VendorRequisitionChallanGenerate")]
    public virtual ICollection<VendorStampRequisition> VendorStampRequisitions { get; set; } = new List<VendorStampRequisition>();
}
