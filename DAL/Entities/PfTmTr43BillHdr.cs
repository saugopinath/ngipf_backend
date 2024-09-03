using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("pf_tm_tr43_bill_hdr", Schema = "ngipf")]
public partial class PfTmTr43BillHdr
{
    [Key]
    [Column("int_tr43_bill_group_id")]
    [StringLength(38)]
    public string IntTr43BillGroupId { get; set; } = null!;

    [Column("fin_year_from")]
    public short FinYearFrom { get; set; }

    [Column("hoa_id")]
    public int? HoaId { get; set; }

    [Column("int_ddo_id")]
    public int? IntDdoId { get; set; }

    [Column("int_treasury_code")]
    [StringLength(5)]
    public string? IntTreasuryCode { get; set; }

    [Column("bill_number")]
    [StringLength(60)]
    public string BillNumber { get; set; } = null!;

    [Column("bill_date", TypeName = "timestamp(0) without time zone")]
    public DateTime BillDate { get; set; }

    [Column("processing_flag")]
    public short? ProcessingFlag { get; set; }

    [Column("gpf_grp_code")]
    [StringLength(5)]
    public string? GpfGrpCode { get; set; }

    [Column("bill_month")]
    public short BillMonth { get; set; }

    [Column("bill_year")]
    public short BillYear { get; set; }

    [Column("actual_run_month")]
    public short? ActualRunMonth { get; set; }

    [Column("actual_run_year")]
    public short? ActualRunYear { get; set; }

    [Column("int_bill_type_id")]
    public short? IntBillTypeId { get; set; }

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
    public long? RequestId { get; set; }

    [Column("ref_no")]
    [Precision(30, 0)]
    public decimal? RefNo { get; set; }

    [Column("objected_request_id")]
    public long? ObjectedRequestId { get; set; }

    [Column("org_int_tr43_bill_group_id")]
    [StringLength(38)]
    public string? OrgIntTr43BillGroupId { get; set; }

    [Column("bill_gross_amount")]
    public long? BillGrossAmount { get; set; }

    [Column("bill_net_amount")]
    public long? BillNetAmount { get; set; }

    [Column("voucher_number")]
    [StringLength(9)]
    public string? VoucherNumber { get; set; }

    [Column("voucher_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? VoucherDate { get; set; }

    [Column("token_number")]
    public int? TokenNumber { get; set; }

    [Column("token_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? TokenDate { get; set; }

    [Column("dml_status_flag")]
    public short DmlStatusFlag { get; set; }

    [Column("created_by_user")]
    public int CreatedByUser { get; set; }

    [Column("created_by_role")]
    public short CreatedByRole { get; set; }

    [Column("created_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime CreatedTimestamp { get; set; }

    [Column("modified_by_user")]
    public int? ModifiedByUser { get; set; }

    [Column("modified_by_role")]
    public short? ModifiedByRole { get; set; }

    [Column("modified_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime? ModifiedTimestamp { get; set; }

    [Column("sanction_no")]
    [StringLength(100)]
    public string? SanctionNo { get; set; }

    [Column("sanction_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? SanctionDate { get; set; }

    [Column("sanction_amount")]
    public long? SanctionAmount { get; set; }

    [Column("sanction_by")]
    [StringLength(100)]
    public string? SanctionBy { get; set; }

    [Column("ref_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? RefDate { get; set; }

    [Column("bt_hoa_id")]
    [StringLength(30)]
    public string? BtHoaId { get; set; }

    [Column("total_interest_amount")]
    public long? TotalInterestAmount { get; set; }

    [Column("department_code")]
    [StringLength(2)]
    public string DepartmentCode { get; set; } = null!;

    [Column("payment_hoa")]
    [StringLength(30)]
    public string? PaymentHoa { get; set; }

    [Column("total_subscriber_involved")]
    public long? TotalSubscriberInvolved { get; set; }

    [Column("ebill_user_id")]
    public int? EbillUserId { get; set; }

    [Column("ebill_role_id")]
    public short? EbillRoleId { get; set; }

    [Column("year_end_bill_flag")]
    [StringLength(1)]
    public string? YearEndBillFlag { get; set; }

    [Column("dppg_check")]
    [StringLength(1)]
    public string? DppgCheck { get; set; }

    [Column("year_end_finalize_user_id")]
    public int? YearEndFinalizeUserId { get; set; }

    [Column("consolidated_req_id")]
    [StringLength(20)]
    public string? ConsolidatedReqId { get; set; }
}
