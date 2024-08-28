using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("hr_md_emp_out_of_act_ded_aud", Schema = "ihrms")]
[Index("IntCompId", Name = "ind_hr_md_emp_out_of_act_aud3")]
[Index("IntEmployeeId", Name = "ind_hr_md_empo_act_de_au2")]
[Index("RequestId", Name = "ind_hr_md_empo_act_de_au3")]
public partial class HrMdEmpOutOfActDedAud
{
    [Key]
    [Column("int_out_of_act_ded_id_aud")]
    [StringLength(38)]
    public string IntOutOfActDedIdAud { get; set; } = null!;

    [Column("int_out_of_act_ded_id")]
    [StringLength(38)]
    public string? IntOutOfActDedId { get; set; }

    [Column("int_employee_id")]
    [Precision(38, 0)]
    public BigInteger? IntEmployeeId { get; set; }

    [Column("int_comp_id")]
    [StringLength(38)]
    public string? IntCompId { get; set; }

    [Column("amount")]
    public int? Amount { get; set; }

    [Column("pay_mode")]
    [StringLength(1)]
    public string? PayMode { get; set; }

    [Column("benf_acct_no")]
    [StringLength(30)]
    public string? BenfAcctNo { get; set; }

    [Column("benf_bank_ifsc_code")]
    [StringLength(15)]
    public string? BenfBankIfscCode { get; set; }

    [Column("wef", TypeName = "timestamp(0) without time zone")]
    public DateTime? Wef { get; set; }

    [Column("effective_end_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? EffectiveEndDate { get; set; }

    [Column("request_id")]
    public long? RequestId { get; set; }

    [Column("modifiable_flag")]
    [StringLength(1)]
    public string? ModifiableFlag { get; set; }

    [Column("remarks")]
    [StringLength(200)]
    public string? Remarks { get; set; }

    [Column("last_updated_by")]
    public int? LastUpdatedBy { get; set; }

    [Column("last_updated_on", TypeName = "timestamp without time zone")]
    public DateTime? LastUpdatedOn { get; set; }

    [Column("dml_status_flag")]
    public short? DmlStatusFlag { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("org_effective_end_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? OrgEffectiveEndDate { get; set; }

    [Column("int_oad_society_bank_id")]
    [StringLength(38)]
    public string? IntOadSocietyBankId { get; set; }

    [Column("tieup_loan")]
    [StringLength(1)]
    public string? TieupLoan { get; set; }

    [Column("third_party_loan_act_no")]
    [StringLength(70)]
    public string? ThirdPartyLoanActNo { get; set; }
}
