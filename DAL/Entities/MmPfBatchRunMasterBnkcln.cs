using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("mm_pf_batch_run_master_bnkcln", Schema = "ngipf")]
public partial class MmPfBatchRunMasterBnkcln
{
    [Key]
    [Column("int_batch_id")]
    [StringLength(38)]
    public string IntBatchId { get; set; } = null!;

    [Column("processing_starttime", TypeName = "timestamp(0) without time zone")]
    public DateTime ProcessingStarttime { get; set; }

    [Column("cr_treasury_processed")]
    public long? CrTreasuryProcessed { get; set; }

    [Column("cr_challan_voucher_processed")]
    public long? CrChallanVoucherProcessed { get; set; }

    [Column("dr_treasury_processed")]
    public long? DrTreasuryProcessed { get; set; }

    [Column("dr_challan_voucher_processed")]
    public long? DrChallanVoucherProcessed { get; set; }

    [Column("processing_endtime", TypeName = "timestamp(0) without time zone")]
    public DateTime? ProcessingEndtime { get; set; }
}
