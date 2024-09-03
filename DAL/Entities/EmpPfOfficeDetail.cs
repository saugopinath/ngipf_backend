using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("emp_pf_office_details", Schema = "ngipf")]
public partial class EmpPfOfficeDetail
{
    [Column("emp_lfpl_details_id")]
    public int EmpLfplDetailsId { get; set; }

    [Key]
    [Column("int_employee_id")]
    public int IntEmployeeId { get; set; }

    [Column("int_employee_id_old")]
    [StringLength(38)]
    public string? IntEmployeeIdOld { get; set; }

    [Column("int_sanc_head_of_office_id")]
    public int? IntSancHeadOfOfficeId { get; set; }

    [Column("int_rec_head_of_office_id")]
    public int? IntRecHeadOfOfficeId { get; set; }

    [Column("int_section_head_of_office_id")]
    public int? IntSectionHeadOfOfficeId { get; set; }

    [Column("int_operator_head_of_office")]
    public int? IntOperatorHeadOfOffice { get; set; }

    [Column("int_operator_id")]
    public int? IntOperatorId { get; set; }

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

    [Column("active_flag")]
    [MaxLength(1)]
    public char? ActiveFlag { get; set; }

    [ForeignKey("IntEmployeeId")]
    [InverseProperty("EmpPfOfficeDetail")]
    public virtual EmpPfBasicDetail IntEmployee { get; set; } = null!;

    [ForeignKey("IntOperatorId")]
    [InverseProperty("EmpPfOfficeDetails")]
    public virtual TMmGenPlOperator? IntOperator { get; set; }

    [ForeignKey("IntOperatorHeadOfOffice")]
    [InverseProperty("EmpPfOfficeDetailIntOperatorHeadOfOfficeNavigations")]
    public virtual HrMmGenHeadOfOffice? IntOperatorHeadOfOfficeNavigation { get; set; }

    [ForeignKey("IntRecHeadOfOfficeId")]
    [InverseProperty("EmpPfOfficeDetailIntRecHeadOfOffices")]
    public virtual HrMmGenHeadOfOffice? IntRecHeadOfOffice { get; set; }

    [ForeignKey("IntSancHeadOfOfficeId")]
    [InverseProperty("EmpPfOfficeDetailIntSancHeadOfOffices")]
    public virtual HrMmGenHeadOfOffice? IntSancHeadOfOffice { get; set; }
}
