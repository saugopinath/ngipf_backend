using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("hr_md_emp_working_dtls_audit", Schema = "ihrms")]
[Index("IntEmployeeId", "IntBusinessPk", Name = "hr_md_emp_working_dtls_2")]
public partial class HrMdEmpWorkingDtlsAudit
{
    [Key]
    [Column("int_emp_working_dtls_id_aud")]
    [StringLength(38)]
    public string IntEmpWorkingDtlsIdAud { get; set; } = null!;

    [Column("int_emp_working_dtls_id")]
    [StringLength(38)]
    public string? IntEmpWorkingDtlsId { get; set; }

    [Column("int_employee_id")]
    [Precision(38, 0)]
    public BigInteger? IntEmployeeId { get; set; }

    [Column("int_business_pk")]
    [StringLength(38)]
    public string? IntBusinessPk { get; set; }

    [Column("parent_flag")]
    [StringLength(1)]
    public string? ParentFlag { get; set; }

    [Column("wef", TypeName = "timestamp(0) without time zone")]
    public DateTime? Wef { get; set; }

    [Column("business_pk_type")]
    [StringLength(5)]
    public string? BusinessPkType { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("effective_end_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? EffectiveEndDate { get; set; }

    [Column("last_updated_by")]
    public int? LastUpdatedBy { get; set; }

    [Column("last_updated_on", TypeName = "timestamp without time zone")]
    public DateTime? LastUpdatedOn { get; set; }

    [Column("go_order_number")]
    [StringLength(500)]
    public string? GoOrderNumber { get; set; }

    [Column("go_order_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? GoOrderDate { get; set; }

    [Column("reason")]
    [StringLength(300)]
    public string? Reason { get; set; }

    [Column("request_id")]
    public long? RequestId { get; set; }

    [Column("fore_or_after_noon")]
    public short? ForeOrAfterNoon { get; set; }

    [Column("joining_order_no")]
    [StringLength(500)]
    public string? JoiningOrderNo { get; set; }

    [Column("joining_order_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? JoiningOrderDate { get; set; }

    [Column("substantive_additional_flag")]
    [StringLength(2)]
    public string? SubstantiveAdditionalFlag { get; set; }

    [Column("date_of_release", TypeName = "timestamp(0) without time zone")]
    public DateTime? DateOfRelease { get; set; }

    [Column("release_order_no")]
    [StringLength(500)]
    public string? ReleaseOrderNo { get; set; }

    [Column("release_order_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? ReleaseOrderDate { get; set; }

    [Column("int_omi_reason_for_changes")]
    [StringLength(38)]
    public string? IntOmiReasonForChanges { get; set; }

    [Column("modifiable_flag")]
    [StringLength(1)]
    public string? ModifiableFlag { get; set; }

    [Column("service_book_flag")]
    [StringLength(1)]
    public string? ServiceBookFlag { get; set; }

    [Column("out_side_hrms_master")]
    [StringLength(1)]
    public string? OutSideHrmsMaster { get; set; }

    [Column("int_head_of_office_id")]
    [StringLength(38)]
    public string? IntHeadOfOfficeId { get; set; }

    [Column("head_of_office_description")]
    [StringLength(500)]
    public string? HeadOfOfficeDescription { get; set; }

    [Column("remarks")]
    [StringLength(1000)]
    public string? Remarks { get; set; }

    [Column("release_fore_aft_noon")]
    public short? ReleaseForeAftNoon { get; set; }

    [Column("srv_book_request_init")]
    [StringLength(38)]
    public string? SrvBookRequestInit { get; set; }

    [Column("int_appnt_dtls_srv_book")]
    [StringLength(38)]
    public string? IntAppntDtlsSrvBook { get; set; }

    [Column("int_omi_srv_book_block_id")]
    [StringLength(38)]
    public string? IntOmiSrvBookBlockId { get; set; }
}
