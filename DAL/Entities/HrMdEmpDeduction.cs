using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("hr_md_emp_deduction", Schema = "ihrms")]
[Index("IntEmployeeId", Name = "ind_hr_md_emp_deduction1")]
[Index("IntCompId", Name = "ind_hr_md_emp_deduction2")]
[Index("RequestId", Name = "ind_hr_md_emp_deduction3")]
public partial class HrMdEmpDeduction
{
    [Key]
    [Column("int_emp_deduction_id")]
    [StringLength(38)]
    public string IntEmpDeductionId { get; set; } = null!;

    [Column("int_employee_id")]
    [Precision(38, 0)]
    public BigInteger? IntEmployeeId { get; set; }

    [Column("int_comp_id")]
    [StringLength(38)]
    public string? IntCompId { get; set; }

    [Column("deduction_amount")]
    public int? DeductionAmount { get; set; }

    [Column("wef", TypeName = "timestamp(0) without time zone")]
    public DateTime? Wef { get; set; }

    [Column("effective_end_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? EffectiveEndDate { get; set; }

    [Column("last_updated_by")]
    public int? LastUpdatedBy { get; set; }

    [Column("last_updated_on", TypeName = "timestamp without time zone")]
    public DateTime? LastUpdatedOn { get; set; }

    [Column("request_id")]
    public long? RequestId { get; set; }

    [Column("remarks")]
    [StringLength(200)]
    public string? Remarks { get; set; }

    [Column("modifiable_flag")]
    [StringLength(1)]
    public string? ModifiableFlag { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("tot_no_of_arrears")]
    public long? TotNoOfArrears { get; set; }

    [Column("arrears_already_paid")]
    public long? ArrearsAlreadyPaid { get; set; }

    [Column("arrear_from_month")]
    public short? ArrearFromMonth { get; set; }

    [Column("arrear_from_year")]
    public short? ArrearFromYear { get; set; }

    [Column("arrear_to_month")]
    public short? ArrearToMonth { get; set; }

    [Column("arrear_to_year")]
    public short? ArrearToYear { get; set; }

    [Column("pli_premium")]
    [Precision(7, 2)]
    public decimal? PliPremium { get; set; }

    [Column("pli_policy_no")]
    [StringLength(50)]
    public string? PliPolicyNo { get; set; }

    [Column("int_emp_quarter_id_for_ded")]
    [StringLength(38)]
    public string? IntEmpQuarterIdForDed { get; set; }

    [Column("int_pl_pf_ddo_map")]
    [StringLength(38)]
    public string? IntPlPfDdoMap { get; set; }

    [Column("ded_abbr_master_abbr")]
    [StringLength(10)]
    public string? DedAbbrMasterAbbr { get; set; }

    [Column("arrear_from_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? ArrearFromDate { get; set; }

    [Column("arrear_to_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? ArrearToDate { get; set; }

    [Column("deleted_frm_srv_bk")]
    [StringLength(1)]
    public string? DeletedFrmSrvBk { get; set; }

    [Column("int_omi_srv_book_block_id")]
    [StringLength(38)]
    public string? IntOmiSrvBookBlockId { get; set; }

    [Column("inserted_flag")]
    [StringLength(1)]
    public string? InsertedFlag { get; set; }

    [Column("int_rev_pay_allowance_id")]
    [StringLength(38)]
    public string? IntRevPayAllowanceId { get; set; }

    [Column("int_payb_id")]
    [StringLength(38)]
    public string? IntPaybId { get; set; }

    [Column("int_pay_scale_id")]
    [StringLength(38)]
    public string? IntPayScaleId { get; set; }

    [Column("int_omi_giss_type")]
    [StringLength(38)]
    public string? IntOmiGissType { get; set; }

    [Column("int_appnt_dtls_srv_book_s")]
    [StringLength(38)]
    public string? IntAppntDtlsSrvBookS { get; set; }

    [Column("memo_number")]
    [StringLength(100)]
    public string? MemoNumber { get; set; }

    [Column("memo_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? MemoDate { get; set; }

    [Column("int_emp_giss_srv_book_id")]
    [StringLength(38)]
    public string? IntEmpGissSrvBookId { get; set; }
}
