﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("cheque_invoice", Schema = "cts")]
[Index("ChequeIndentId", Name = "fki_cheque_invoice_cheque_indent_id_fkey")]
[Index("Status", Name = "fki_cheque_invoice_status_fkey")]
public partial class ChequeInvoice
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("invoice_id")]
    public int? InvoiceId { get; set; }

    [Column("invoice_date")]
    public DateOnly? InvoiceDate { get; set; }

    [Column("invoice_number")]
    [StringLength(50)]
    public string? InvoiceNumber { get; set; }

    [Column("cheque_indent_id")]
    public long? ChequeIndentId { get; set; }

    [Column("created_by")]
    public long? CreatedBy { get; set; }

    [Column("created_at", TypeName = "timestamp without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("status")]
    public int? Status { get; set; }

    [ForeignKey("ChequeIndentId")]
    [InverseProperty("ChequeInvoices")]
    public virtual ChequeIndent? ChequeIndent { get; set; }

    [InverseProperty("ChequeInvoice")]
    public virtual ICollection<ChequeInvoiceDetail> ChequeInvoiceDetails { get; set; } = new List<ChequeInvoiceDetail>();

    [ForeignKey("Status")]
    [InverseProperty("ChequeInvoices")]
    public virtual Status? StatusNavigation { get; set; }
}
