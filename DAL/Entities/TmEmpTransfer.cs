using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("tm_emp_transfer", Schema = "ingipfund")]
public partial class TmEmpTransfer
{
    [Key]
    [Column("int_tm_emp_trans_id")]
    [Precision(22, 0)]
    public decimal IntTmEmpTransId { get; set; }

    [Column("int_employee_id")]
    [Precision(22, 0)]
    public BigInteger? IntEmployeeId { get; set; }

    [Column("request_id")]
    [Precision(22, 0)]
    public decimal? RequestId { get; set; }

    [Column("op_hoo_id_from")]
    public int? OpHooIdFrom { get; set; }

    [Column("sec_hoo_id_from")]
    public int? SecHooIdFrom { get; set; }

    [Column("rec_hoo_id_from")]
    public int? RecHooIdFrom { get; set; }

    [Column("op_hoo_id_to")]
    public int? OpHooIdTo { get; set; }

    [Column("sec_hoo_id_to")]
    public int? SecHooIdTo { get; set; }

    [Column("rec_hoo_id_to")]
    public int? RecHooIdTo { get; set; }

    [Column("workflow_status_flag")]
    [StringLength(2)]
    public string? WorkflowStatusFlag { get; set; }

    [Column("fin_year_from")]
    [Precision(22, 0)]
    public decimal? FinYearFrom { get; set; }

    [Column("int_treasury_code")]
    [StringLength(5)]
    public string? IntTreasuryCode { get; set; }

    [Column("ref_no")]
    [Precision(22, 0)]
    public decimal? RefNo { get; set; }

    [Column("voucher_gen_flag")]
    [StringLength(1)]
    public string? VoucherGenFlag { get; set; }

    [Column("dml_status_flag")]
    [Precision(22, 0)]
    public decimal? DmlStatusFlag { get; set; }

    [Column("created_user_id")]
    [Precision(22, 0)]
    public decimal? CreatedUserId { get; set; }

    [Column("created_timestamp")]
    public DateOnly? CreatedTimestamp { get; set; }

    [Column("modified_user_id")]
    [Precision(22, 0)]
    public decimal? ModifiedUserId { get; set; }

    [Column("modified_timestamp")]
    public DateOnly? ModifiedTimestamp { get; set; }

    [Column("transfer_no")]
    [StringLength(20)]
    public string? TransferNo { get; set; }

    [Column("transfer_date")]
    public DateOnly? TransferDate { get; set; }

    [Column("joining_date")]
    public DateOnly? JoiningDate { get; set; }

    [Column("remarks")]
    [StringLength(1000)]
    public string? Remarks { get; set; }

    [Column("emp_send_back")]
    [StringLength(2)]
    public string? EmpSendBack { get; set; }

    [Column("int_treasury_code_from")]
    [StringLength(5)]
    public string? IntTreasuryCodeFrom { get; set; }

    [Column("ref_date")]
    public DateOnly? RefDate { get; set; }

    [Column("pf_balance")]
    [Precision(22, 2)]
    public decimal? PfBalance { get; set; }

    [Column("section_code_from")]
    [StringLength(50)]
    public string? SectionCodeFrom { get; set; }

    [Column("section_code_to")]
    [StringLength(50)]
    public string? SectionCodeTo { get; set; }

    [Column("transfered_by")]
    [Precision(22, 0)]
    public decimal? TransferedBy { get; set; }

    public virtual HrMmEmpBasicDtl? IntEmployee { get; set; }

    public virtual MmGenTreasury? IntTreasuryCodeNavigation { get; set; }

    [ForeignKey("OpHooIdFrom")]
    [InverseProperty("TmEmpTransferOpHooIdFromNavigations")]
    public virtual MmGenHoa? OpHooIdFromNavigation { get; set; }

    [ForeignKey("OpHooIdTo")]
    [InverseProperty("TmEmpTransferOpHooIdToNavigations")]
    public virtual MmGenHoa? OpHooIdToNavigation { get; set; }

    [ForeignKey("RecHooIdFrom")]
    [InverseProperty("TmEmpTransferRecHooIdFromNavigations")]
    public virtual MmGenHoa? RecHooIdFromNavigation { get; set; }

    [ForeignKey("RecHooIdTo")]
    [InverseProperty("TmEmpTransferRecHooIdToNavigations")]
    public virtual MmGenHoa? RecHooIdToNavigation { get; set; }

    [ForeignKey("SecHooIdTo")]
    [InverseProperty("TmEmpTransferSecHooIdToNavigations")]
    public virtual MmGenHoa? SecHooIdToNavigation { get; set; }
}
