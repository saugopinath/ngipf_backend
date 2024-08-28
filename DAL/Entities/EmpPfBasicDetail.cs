using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("emp_pf_basic_details", Schema = "ngipf")]
public partial class EmpPfBasicDetail
{
    [Column("emp_pf_basic_details_id")]
    public int EmpPfBasicDetailsId { get; set; }

    [Key]
    [Column("int_employee_id")]
    public int IntEmployeeId { get; set; }

    [Column("pf_aacount_no")]
    [StringLength(20)]
    public string? PfAacountNo { get; set; }

    [Column("int_employee_id_old")]
    [StringLength(38)]
    public string? IntEmployeeIdOld { get; set; }

    [Column("int_ddo_id")]
    public int? IntDdoId { get; set; }

    [Column("int_operator_id")]
    public int? IntOperatorId { get; set; }

    [Column("int_treasury_code")]
    [StringLength(5)]
    public string? IntTreasuryCode { get; set; }

    [InverseProperty("IntEmployee")]
    public virtual ICollection<EmpArrearDtl> EmpArrearDtls { get; set; } = new List<EmpArrearDtl>();

    [InverseProperty("IntEmployee")]
    public virtual ICollection<EmpOpeningBalanceAccpeted> EmpOpeningBalanceAccpeteds { get; set; } = new List<EmpOpeningBalanceAccpeted>();

    [InverseProperty("IntEmployee")]
    public virtual EmpPfOfficeDetail? EmpPfOfficeDetail { get; set; }

    [ForeignKey("IntDdoId")]
    [InverseProperty("EmpPfBasicDetails")]
    public virtual MmGenDdo? IntDdo { get; set; }

    public virtual HrMmEmpBasicDtl? IntEmployeeIdOldNavigation { get; set; }

    [ForeignKey("IntOperatorId")]
    [InverseProperty("EmpPfBasicDetails")]
    public virtual TMmGenPlOperator? IntOperator { get; set; }

    public virtual MmGenTreasury? IntTreasuryCodeNavigation { get; set; }
}
