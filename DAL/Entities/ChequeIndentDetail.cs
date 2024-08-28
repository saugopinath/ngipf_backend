﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("cheque_indent_details", Schema = "cts")]
[Index("ChequeIndentId", Name = "fki_cheque_indent_details-cheque_indent_id-fkey")]
public partial class ChequeIndentDetail
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("cheque_indent_id")]
    public long ChequeIndentId { get; set; }

    /// <summary>
    /// 1= treasury 2= others
    /// </summary>
    [Column("cheque_type")]
    public short ChequeType { get; set; }

    [Column("micr_code")]
    [StringLength(9)]
    public string MicrCode { get; set; } = null!;

    [Column("quantity")]
    public int Quantity { get; set; }

    [Column("approved_quantity")]
    public int ApprovedQuantity { get; set; }

    [Column("approved_micr_code")]
    [StringLength(9)]
    public string? ApprovedMicrCode { get; set; }

    [ForeignKey("ChequeIndentId")]
    [InverseProperty("ChequeIndentDetails")]
    public virtual ChequeIndent ChequeIndent { get; set; } = null!;

    [InverseProperty("ChequeIndentDetail")]
    public virtual ICollection<ChequeInvoiceDetail> ChequeInvoiceDetails { get; set; } = new List<ChequeInvoiceDetail>();
}
