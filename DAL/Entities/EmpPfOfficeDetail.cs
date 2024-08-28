using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

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
