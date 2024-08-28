using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("mm_gen_ngipf_office", Schema = "ngipf_master")]
public partial class MmGenNgipfOffice
{
    [Column("hoo_type")]
    [StringLength(1)]
    public string? HooType { get; set; }

    [Column("int_pl_operator_id")]
    public int? IntPlOperatorId { get; set; }

    [Column("wef")]
    public DateOnly Wef { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("dml_status_flag")]
    [Precision(1, 0)]
    public decimal? DmlStatusFlag { get; set; }

    [Column("created_user_id")]
    [Precision(8, 0)]
    public decimal? CreatedUserId { get; set; }

    [Column("modified_user_id")]
    [Precision(8, 0)]
    public decimal? ModifiedUserId { get; set; }

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("int_gen_ngipf_office_id_old")]
    [StringLength(38)]
    public string? IntGenNgipfOfficeIdOld { get; set; }

    [Column("int_head_of_office_id_old")]
    [StringLength(38)]
    public string? IntHeadOfOfficeIdOld { get; set; }

    [Column("int_head_of_office_id")]
    public int? IntHeadOfOfficeId { get; set; }

    [Column("parent_int_hoo_id_old")]
    [StringLength(38)]
    public string? ParentIntHooIdOld { get; set; }

    [Column("parent_int_hoo_id")]
    public int? ParentIntHooId { get; set; }

    [Column("office_type_master_id_old")]
    [StringLength(38)]
    public string? OfficeTypeMasterIdOld { get; set; }

    [Column("office_type_master_id")]
    public int? OfficeTypeMasterId { get; set; }

    [Column("reporting_int_gen_ngipf_office_id_old")]
    [StringLength(38)]
    public string? ReportingIntGenNgipfOfficeIdOld { get; set; }

    [Column("reporting_int_gen_ngipf_office_id")]
    public int? ReportingIntGenNgipfOfficeId { get; set; }

    [Key]
    [Column("int_gen_ngipf_office_id")]
    public int IntGenNgipfOfficeId { get; set; }

    [Column("int_pl_operator_id_old")]
    [StringLength(38)]
    public string? IntPlOperatorIdOld { get; set; }

    [ForeignKey("IntHeadOfOfficeId")]
    [InverseProperty("MmGenNgipfOffices")]
    public virtual HrMmGenHeadOfOffice? IntHeadOfOffice { get; set; }

    [ForeignKey("IntPlOperatorId")]
    [InverseProperty("MmGenNgipfOffices")]
    public virtual TMmGenPlOperator? IntPlOperator { get; set; }
}
