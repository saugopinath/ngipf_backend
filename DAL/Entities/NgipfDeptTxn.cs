using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("ngipf_dept_txn", Schema = "ingipfund")]
public partial class NgipfDeptTxn
{
    [Key]
    [Column("id")]
    [StringLength(50)]
    public string Id { get; set; } = null!;

    [Column("fin_year")]
    [StringLength(10)]
    public string? FinYear { get; set; }

    [Column("data_pkt")]
    public byte[]? DataPkt { get; set; }

    [Column("txn_type")]
    [StringLength(50)]
    public string? TxnType { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("txn_date")]
    public DateOnly? TxnDate { get; set; }

    [Column("status")]
    [StringLength(20)]
    public string? Status { get; set; }

    [Column("iosms_emp_id")]
    [StringLength(15)]
    public string? IosmsEmpId { get; set; }

    [Column("portal")]
    [StringLength(50)]
    public string? Portal { get; set; }

    [Column("portal_ip")]
    [StringLength(250)]
    public string? PortalIp { get; set; }

    [Column("success_flag")]
    [StringLength(2)]
    public string? SuccessFlag { get; set; }

    [Column("error_code")]
    [StringLength(10)]
    public string? ErrorCode { get; set; }

    [Column("error_desc")]
    [StringLength(250)]
    public string? ErrorDesc { get; set; }

    [Column("pf_acc_no")]
    [StringLength(50)]
    public string? PfAccNo { get; set; }

    [Column("send_to_api_flag")]
    [StringLength(2)]
    public string? SendToApiFlag { get; set; }

    [Column("dml_status_flag")]
    [StringLength(2)]
    public string? DmlStatusFlag { get; set; }

    [Column("api_resp_status")]
    [StringLength(2)]
    public string? ApiRespStatus { get; set; }

    [Column("api_resp_gentime")]
    [StringLength(50)]
    public string? ApiRespGentime { get; set; }

    [Column("api_resp_msg")]
    [StringLength(100)]
    public string? ApiRespMsg { get; set; }

    [Column("data_pkt_decrypt")]
    public byte[]? DataPktDecrypt { get; set; }
}
