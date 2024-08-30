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

    [Column("created_by")]
    public int? CreatedBy { get; set; }

    [Column("last_updated_by")]
    public int? LastUpdatedBy { get; set; }

    [Column("deleted_by")]
    public int? DeletedBy { get; set; }

    [Column("created_at", TypeName = "timestamp without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("last_updated_at", TypeName = "timestamp without time zone")]
    public DateTime? LastUpdatedAt { get; set; }

    [Column("deleted_at", TypeName = "timestamp without time zone")]
    public DateTime? DeletedAt { get; set; }

    [ForeignKey("IntHeadOfOfficeId")]
    [InverseProperty("MmGenNgipfOffices")]
    public virtual HrMmGenHeadOfOffice? IntHeadOfOffice { get; set; }

    [ForeignKey("IntPlOperatorId")]
    [InverseProperty("MmGenNgipfOffices")]
    public virtual TMmGenPlOperator? IntPlOperator { get; set; }
}
