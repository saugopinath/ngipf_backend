using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("pf_tm_tr_bill_hdr", Schema = "ingipfund")]
public partial class PfTmTrBillHdr
{
    [Key]
    [Column("int_tr43_bill_group_id")]
    [Precision(22, 0)]
    public decimal IntTr43BillGroupId { get; set; }

    [Column("fin_year_from")]
    [Precision(22, 0)]
    public decimal? FinYearFrom { get; set; }

    [Column("int_pl_id")]
    [Precision(22, 0)]
    public decimal? IntPlId { get; set; }

    [Column("int_treasury_code")]
    [StringLength(5)]
    public string? IntTreasuryCode { get; set; }

    [Column("bill_number")]
    [StringLength(60)]
    public string? BillNumber { get; set; }

    [Column("bill_date")]
    public DateOnly? BillDate { get; set; }

    [Column("processing_flag")]
    [Precision(22, 0)]
    public decimal? ProcessingFlag { get; set; }

    [Column("gpf_grp_code")]
    [StringLength(5)]
    public string? GpfGrpCode { get; set; }

    [Column("bill_month")]
    [Precision(22, 0)]
    public decimal? BillMonth { get; set; }

    [Column("bill_year")]
    [Precision(22, 0)]
    public decimal? BillYear { get; set; }

    [Column("actual_run_month")]
    [Precision(22, 0)]
    public decimal? ActualRunMonth { get; set; }

    [Column("actual_run_year")]
    [Precision(22, 0)]
    public decimal? ActualRunYear { get; set; }

    [Column("int_bill_type_id")]
    [Precision(22, 0)]
    public decimal? IntBillTypeId { get; set; }

    [Column("bill_type_flag")]
    [StringLength(40)]
    public string? BillTypeFlag { get; set; }

    [Column("job_status")]
    [StringLength(20)]
    public string? JobStatus { get; set; }

    [Column("job_exception_msg_usr")]
    [StringLength(1000)]
    public string? JobExceptionMsgUsr { get; set; }

    [Column("job_exception_msg_ora")]
    [StringLength(1000)]
    public string? JobExceptionMsgOra { get; set; }

    [Column("job_start_on", TypeName = "timestamp(0) without time zone")]
    public DateTime? JobStartOn { get; set; }

    [Column("job_end_on", TypeName = "timestamp(0) without time zone")]
    public DateTime? JobEndOn { get; set; }

    [Column("request_id")]
    [Precision(22, 0)]
    public decimal? RequestId { get; set; }

    [Column("ref_no")]
    [Precision(22, 0)]
    public decimal? RefNo { get; set; }

    [Column("objected_request_id")]
    [Precision(22, 0)]
    public decimal? ObjectedRequestId { get; set; }

    [Column("org_int_tr43_bill_group_id")]
    [Precision(22, 0)]
    public decimal? OrgIntTr43BillGroupId { get; set; }

    [Column("bill_gross_amount")]
    [Precision(22, 0)]
    public decimal? BillGrossAmount { get; set; }

    [Column("bill_net_amount")]
    [Precision(22, 0)]
    public decimal? BillNetAmount { get; set; }

    [Column("voucher_number")]
    [StringLength(9)]
    public string? VoucherNumber { get; set; }

    [Column("voucher_date")]
    public DateOnly? VoucherDate { get; set; }

    [Column("token_number")]
    [Precision(22, 0)]
    public decimal? TokenNumber { get; set; }

    [Column("token_date")]
    public DateOnly? TokenDate { get; set; }

    [Column("dml_status_flag")]
    [Precision(22, 0)]
    public decimal? DmlStatusFlag { get; set; }

    [Column("created_by_user")]
    [Precision(22, 0)]
    public decimal? CreatedByUser { get; set; }

    [Column("created_by_role")]
    [Precision(22, 0)]
    public decimal? CreatedByRole { get; set; }

    [Column("created_timestamp", TypeName = "timestamp(6) without time zone")]
    public DateTime? CreatedTimestamp { get; set; }

    [Column("modified_by_user")]
    [Precision(22, 0)]
    public decimal? ModifiedByUser { get; set; }

    [Column("modified_by_role")]
    [Precision(22, 0)]
    public decimal? ModifiedByRole { get; set; }

    [Column("modified_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime? ModifiedTimestamp { get; set; }

    [Column("sanction_no")]
    [StringLength(100)]
    public string? SanctionNo { get; set; }

    [Column("sanction_date")]
    public DateOnly? SanctionDate { get; set; }

    [Column("sanction_amount")]
    [Precision(22, 0)]
    public decimal? SanctionAmount { get; set; }

    [Column("sanction_by")]
    [StringLength(100)]
    public string? SanctionBy { get; set; }

    [Column("ref_date")]
    public DateOnly? RefDate { get; set; }

    [Column("bt_hoa_id")]
    [StringLength(30)]
    public string? BtHoaId { get; set; }

    [Column("total_interest_amount")]
    [Precision(22, 0)]
    public decimal? TotalInterestAmount { get; set; }

    [Column("department_code")]
    [StringLength(2)]
    public string? DepartmentCode { get; set; }

    [Column("payment_hoa")]
    [StringLength(30)]
    public string? PaymentHoa { get; set; }

    [Column("total_subscriber_involved")]
    [Precision(22, 0)]
    public decimal? TotalSubscriberInvolved { get; set; }

    [Column("ebill_user_id")]
    [Precision(22, 0)]
    public decimal? EbillUserId { get; set; }

    [Column("ebill_role_id")]
    [Precision(22, 0)]
    public decimal? EbillRoleId { get; set; }

    [Column("year_end_bill_flag")]
    [StringLength(1)]
    public string? YearEndBillFlag { get; set; }

    [Column("dppg_check")]
    [StringLength(1)]
    public string? DppgCheck { get; set; }

    [Column("year_end_finalize_user_id")]
    [Precision(22, 0)]
    public decimal? YearEndFinalizeUserId { get; set; }

    [Column("consolidated_req_id")]
    [StringLength(20)]
    public string? ConsolidatedReqId { get; set; }

    [Column("int_scheme_id")]
    public int? IntSchemeId { get; set; }

    [Column("memo_no")]
    [StringLength(60)]
    public string? MemoNo { get; set; }

    [Column("memo_date")]
    public DateOnly? MemoDate { get; set; }

    [Column("bill_type_abbr")]
    [StringLength(2)]
    public string? BillTypeAbbr { get; set; }

    [Column("hoa_id")]
    public int? HoaId { get; set; }

    [ForeignKey("HoaId")]
    [InverseProperty("PfTmTrBillHdrs")]
    public virtual MmGenHoa? Hoa { get; set; }

    [ForeignKey("IntSchemeId")]
    [InverseProperty("PfTmTrBillHdrs")]
    public virtual MdGenSchemeHead? IntScheme { get; set; }

    public virtual MmGenTreasury? IntTreasuryCodeNavigation { get; set; }

    [InverseProperty("IntTr43BillGroup")]
    public virtual ICollection<TdNgipfIntBillAg> TdNgipfIntBillAgs { get; set; } = new List<TdNgipfIntBillAg>();

    [InverseProperty("IntTr43BillGroup")]
    public virtual ICollection<TdNgipfOperatorSchemeWiseInterest> TdNgipfOperatorSchemeWiseInterests { get; set; } = new List<TdNgipfOperatorSchemeWiseInterest>();

    [InverseProperty("IntTr43BillGroup")]
    public virtual ICollection<TmEmpIntCalc> TmEmpIntCalcs { get; set; } = new List<TmEmpIntCalc>();
}
