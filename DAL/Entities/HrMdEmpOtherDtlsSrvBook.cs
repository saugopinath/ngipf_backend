using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("hr_md_emp_other_dtls_srv_book", Schema = "ihrms_emp_master")]
public partial class HrMdEmpOtherDtlsSrvBook
{
    [Column("information1")]
    [StringLength(500)]
    public string? Information1 { get; set; }

    [Column("information2")]
    [StringLength(50)]
    public string? Information2 { get; set; }

    [Column("information3")]
    [StringLength(50)]
    public string? Information3 { get; set; }

    [Column("wef")]
    public DateOnly? Wef { get; set; }

    [Column("master_abbr")]
    [StringLength(10)]
    public string? MasterAbbr { get; set; }

    [Column("master_type")]
    [StringLength(5)]
    public string? MasterType { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("effective_end_date")]
    public DateOnly? EffectiveEndDate { get; set; }

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("go_order_number")]
    [StringLength(50)]
    public string? GoOrderNumber { get; set; }

    [Column("go_order_date")]
    public DateOnly? GoOrderDate { get; set; }

    [Column("int_emp_other_dtls_srv_book_id_old")]
    [StringLength(38)]
    public string? IntEmpOtherDtlsSrvBookIdOld { get; set; }

    [Column("int_other_contr_dtls_old")]
    [StringLength(38)]
    public string? IntOtherContrDtlsOld { get; set; }

    [Column("int_other_contr_dtls")]
    public int? IntOtherContrDtls { get; set; }

    [Column("int_employee_id_old")]
    [StringLength(38)]
    public string? IntEmployeeIdOld { get; set; }

    [Column("int_employee_id")]
    public int? IntEmployeeId { get; set; }

    [Column("int_omi_other_dtls_old")]
    [StringLength(38)]
    public string? IntOmiOtherDtlsOld { get; set; }

    [Column("int_omi_other_dtls")]
    public int? IntOmiOtherDtls { get; set; }

    [Column("prev_int_other_contr_dtls_old")]
    [StringLength(38)]
    public string? PrevIntOtherContrDtlsOld { get; set; }

    [Column("prev_int_other_contr_dtls")]
    public int? PrevIntOtherContrDtls { get; set; }

    [Column("dml_status_flag_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("dml_status_flag")]
    public int? DmlStatusFlag { get; set; }

    [Column("created_user_id_old")]
    [StringLength(38)]
    public string? CreatedUserIdOld { get; set; }

    [Column("created_user_id")]
    public int? CreatedUserId { get; set; }

    [Column("modified_user_id_old")]
    [StringLength(38)]
    public string? ModifiedUserIdOld { get; set; }

    [Column("modified_user_id")]
    public int? ModifiedUserId { get; set; }

    [Column("request_id_old")]
    [StringLength(38)]
    public string? RequestIdOld { get; set; }

    [Column("request_id")]
    public int? RequestId { get; set; }

    [Column("srv_book_request_init_old")]
    [StringLength(38)]
    public string? SrvBookRequestInitOld { get; set; }

    [Column("srv_book_request_init")]
    public int? SrvBookRequestInit { get; set; }

    [Key]
    [Column("int_emp_other_dtls_srv_book_id")]
    public int IntEmpOtherDtlsSrvBookId { get; set; }
}
