using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("pf_tm_tr43_bill_consolidated", Schema = "ngipf")]
public partial class PfTmTr43BillConsolidated
{
    [Key]
    [Column("consolidated_req_id")]
    [StringLength(20)]
    public string ConsolidatedReqId { get; set; } = null!;

    [Column("total_subscribers")]
    public double? TotalSubscribers { get; set; }

    [Column("total_interest_amount")]
    public double? TotalInterestAmount { get; set; }

    [Column("acknowledgement_no")]
    [StringLength(20)]
    public string? AcknowledgementNo { get; set; }

    [Column("acknowledgement_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? AcknowledgementDate { get; set; }

    [Column("processing_flag")]
    public short? ProcessingFlag { get; set; }

    [Column("created_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedTimestamp { get; set; }

    [Column("created_userid")]
    public double? CreatedUserid { get; set; }

    [Column("modified_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime? ModifiedTimestamp { get; set; }

    [Column("modified_userid")]
    public double? ModifiedUserid { get; set; }

    [Column("ag_approved_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? AgApprovedDate { get; set; }

    [Column("ag_approved_by")]
    public double? AgApprovedBy { get; set; }

    [Column("dml_status_flag")]
    public double? DmlStatusFlag { get; set; }

    [Column("module")]
    [StringLength(50)]
    public string? Module { get; set; }

    [Column("fin_year_from")]
    public double? FinYearFrom { get; set; }

    [Column("request_type")]
    [StringLength(500)]
    public string? RequestType { get; set; }

    [Column("total_no_of_statements")]
    public double? TotalNoOfStatements { get; set; }
}
