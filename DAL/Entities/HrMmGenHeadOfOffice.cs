using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("hr_mm_gen_head_of_office", Schema = "ihrms_master")]
public partial class HrMmGenHeadOfOffice
{
    [Column("name_of_office")]
    [StringLength(1000)]
    public string? NameOfOffice { get; set; }

    [Column("office_code")]
    [StringLength(30)]
    public string OfficeCode { get; set; } = null!;

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("approve_flag")]
    [StringLength(1)]
    public string? ApproveFlag { get; set; }

    [Column("approve_date")]
    public DateOnly? ApproveDate { get; set; }

    [Column("demand_no")]
    [StringLength(2)]
    public string? DemandNo { get; set; }

    [Column("govt_header_yes_no")]
    [StringLength(1)]
    public string? GovtHeaderYesNo { get; set; }

    [Column("govt_parastatal_flag")]
    [StringLength(1)]
    public string? GovtParastatalFlag { get; set; }

    [Column("non_salaried_hoo")]
    [StringLength(2)]
    public string? NonSalariedHoo { get; set; }

    [Column("gia_hoo")]
    [StringLength(2)]
    public string? GiaHoo { get; set; }

    [Column("hc_la_flag")]
    [StringLength(1)]
    public string? HcLaFlag { get; set; }

    [Column("ngipf_flag")]
    [StringLength(1)]
    public string? NgipfFlag { get; set; }

    [Column("int_head_of_office_id_old")]
    [StringLength(38)]
    public string? IntHeadOfOfficeIdOld { get; set; }

    [Column("int_dept_id_old")]
    [StringLength(38)]
    public string? IntDeptIdOld { get; set; }

    [Column("int_dept_id")]
    public int? IntDeptId { get; set; }

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

    [Column("dml_status_flag_old")]
    [StringLength(38)]
    public string? DmlStatusFlagOld { get; set; }

    [Column("dml_status_flag")]
    public int? DmlStatusFlag { get; set; }

    [Column("approve_by_old")]
    [StringLength(38)]
    public string? ApproveByOld { get; set; }

    [Column("approve_by")]
    public int? ApproveBy { get; set; }

    [Column("level_id_old")]
    [StringLength(38)]
    public string? LevelIdOld { get; set; }

    [Column("level_id")]
    public int? LevelId { get; set; }

    [Column("int_created_by_ho_old")]
    [StringLength(38)]
    public string? IntCreatedByHoOld { get; set; }

    [Column("int_created_by_ho")]
    public int? IntCreatedByHo { get; set; }

    [Column("int_created_by_pl_old")]
    [StringLength(38)]
    public string? IntCreatedByPlOld { get; set; }

    [Column("int_created_by_pl")]
    public int? IntCreatedByPl { get; set; }

    [Key]
    [Column("int_head_of_office_id")]
    public int IntHeadOfOfficeId { get; set; }

    [InverseProperty("IntOperatorHeadOfOfficeNavigation")]
    public virtual ICollection<EmpPfOfficeDetail> EmpPfOfficeDetailIntOperatorHeadOfOfficeNavigations { get; set; } = new List<EmpPfOfficeDetail>();

    [InverseProperty("IntRecHeadOfOffice")]
    public virtual ICollection<EmpPfOfficeDetail> EmpPfOfficeDetailIntRecHeadOfOffices { get; set; } = new List<EmpPfOfficeDetail>();

    [InverseProperty("IntSancHeadOfOffice")]
    public virtual ICollection<EmpPfOfficeDetail> EmpPfOfficeDetailIntSancHeadOfOffices { get; set; } = new List<EmpPfOfficeDetail>();

    [InverseProperty("IntHeadOfOffice")]
    public virtual ICollection<HrMdEmpWorkingDtl> HrMdEmpWorkingDtls { get; set; } = new List<HrMdEmpWorkingDtl>();

    [InverseProperty("IntHeadOfOffice")]
    public virtual ICollection<MmGenNgipfOffice> MmGenNgipfOffices { get; set; } = new List<MmGenNgipfOffice>();
}
