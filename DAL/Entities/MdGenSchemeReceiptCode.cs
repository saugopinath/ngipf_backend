using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Keyless]
[Table("md_gen_scheme_receipt_code", Schema = "ifmsadmin")]
[Index("SchemeCode", "DeptCode", "DemandNo", "MajorHead", "SubmajorHead", "MinorHead", "PlanStatus", "SchemeHead", "DetailHead", "SubdetailHead", "ChargedVoted", Name = "md_gen_scheme_receipt_code_scheme_code_dept_code_demand_no__key", IsUnique = true)]
public partial class MdGenSchemeReceiptCode
{
    [Column("financial_year")]
    [StringLength(9)]
    public string? FinancialYear { get; set; }

    [Column("int_rct_map")]
    [StringLength(10)]
    public string? IntRctMap { get; set; }

    [Column("scheme_code")]
    [StringLength(3)]
    public string? SchemeCode { get; set; }

    [Column("dept_code")]
    [StringLength(2)]
    public string? DeptCode { get; set; }

    [Column("demand_no")]
    [StringLength(2)]
    public string? DemandNo { get; set; }

    [Column("major_head")]
    [StringLength(4)]
    public string? MajorHead { get; set; }

    [Column("submajor_head")]
    [StringLength(2)]
    public string? SubmajorHead { get; set; }

    [Column("minor_head")]
    [StringLength(3)]
    public string? MinorHead { get; set; }

    [Column("plan_status")]
    [StringLength(2)]
    public string? PlanStatus { get; set; }

    [Column("scheme_head")]
    [StringLength(3)]
    public string? SchemeHead { get; set; }

    [Column("detail_head")]
    [StringLength(2)]
    public string? DetailHead { get; set; }

    [Column("subdetail_head")]
    [StringLength(2)]
    public string? SubdetailHead { get; set; }

    [Column("charged_voted")]
    [StringLength(1)]
    public string? ChargedVoted { get; set; }

    [Column("scheme_type")]
    [StringLength(2)]
    public string? SchemeType { get; set; }

    [Column("receipt_type")]
    [StringLength(9)]
    public string? ReceiptType { get; set; }

    [Column("receipt_scheme_desc")]
    [StringLength(1000)]
    public string? ReceiptSchemeDesc { get; set; }

    [Column("status")]
    [StringLength(1)]
    public string? Status { get; set; }

    [Column("created_timestamp")]
    public DateOnly? CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly? ModifiedTimestamp { get; set; }

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
}
