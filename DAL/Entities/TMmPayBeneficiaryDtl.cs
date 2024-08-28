using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("t_mm_pay_beneficiary_dtl", Schema = "ionlinebill")]
public partial class TMmPayBeneficiaryDtl
{
    [Key]
    [Column("int_benf_id")]
    [StringLength(38)]
    public string IntBenfId { get; set; } = null!;

    [Column("benf_name")]
    [StringLength(200)]
    public string BenfName { get; set; } = null!;

    [Column("benf_address")]
    [StringLength(200)]
    public string? BenfAddress { get; set; }

    [Column("benf_acct_no")]
    [StringLength(30)]
    public string BenfAcctNo { get; set; } = null!;

    [Column("benf_bank_ifsc_code")]
    [StringLength(15)]
    public string BenfBankIfscCode { get; set; } = null!;

    [Column("benf_email_id")]
    [StringLength(50)]
    public string? BenfEmailId { get; set; }

    [Column("micr_number")]
    [StringLength(15)]
    public string? MicrNumber { get; set; }

    [Column("benf_mobile_number")]
    [StringLength(10)]
    public string? BenfMobileNumber { get; set; }

    [Column("benf_source")]
    [StringLength(100)]
    public string? BenfSource { get; set; }

    [Column("benf_flag")]
    [StringLength(2)]
    public string? BenfFlag { get; set; }

    /// <summary>
    /// s for saving account, c for current account 
    /// </summary>
    [Column("account_type")]
    [StringLength(1)]
    public string AccountType { get; set; } = null!;

    [Column("int_empl_type_id")]
    public short? IntEmplTypeId { get; set; }

    [Column("int_subscriber_id")]
    public long? IntSubscriberId { get; set; }

    [Column("int_gpf_no_id")]
    [StringLength(38)]
    public string? IntGpfNoId { get; set; }

    [Column("srin_tin_reg_flag")]
    [StringLength(1)]
    public string? SrinTinRegFlag { get; set; }

    [Column("srin_tin_reg_no")]
    [StringLength(50)]
    public string? SrinTinRegNo { get; set; }

    [Column("pan")]
    [StringLength(10)]
    public string? Pan { get; set; }

    [Column("dml_status_flag")]
    public short DmlStatusFlag { get; set; }

    [Column("user_id")]
    public int UserId { get; set; }

    [Column("created_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime CreatedTimestamp { get; set; }

    [Column("modified_user_id")]
    public int ModifiedUserId { get; set; }

    [Column("modified_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime ModifiedTimestamp { get; set; }

    [Column("gpf_no")]
    [StringLength(100)]
    public string? GpfNo { get; set; }

    [Column("emp_group")]
    [StringLength(1)]
    public string? EmpGroup { get; set; }

    [Column("adhar_no")]
    [StringLength(20)]
    public string? AdharNo { get; set; }

    [Column("benf_id")]
    [StringLength(20)]
    public string? BenfId { get; set; }

    [Column("tran_status")]
    [StringLength(1)]
    public string? TranStatus { get; set; }

    [Column("int_ddo_id")]
    public int? IntDdoId { get; set; }

    [Column("app_flag")]
    [StringLength(1)]
    public string? AppFlag { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("int_pl_operator_id")]
    public long? IntPlOperatorId { get; set; }

    [Column("stakeholder_type")]
    [StringLength(10)]
    public string? StakeholderType { get; set; }

    [Column("color_code")]
    [StringLength(2)]
    public string? ColorCode { get; set; }

    [Column("int_benf_id1")]
    public long? IntBenfId1 { get; set; }
}
