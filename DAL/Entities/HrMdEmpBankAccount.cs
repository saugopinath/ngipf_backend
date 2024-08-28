using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("hr_md_emp_bank_account", Schema = "ihrms")]
public partial class HrMdEmpBankAccount
{
    [Key]
    [Column("int_md_emp_bank_ac_id")]
    [StringLength(38)]
    public string IntMdEmpBankAcId { get; set; } = null!;

    [Column("int_employee_id")]
    [Precision(38, 0)]
    public BigInteger IntEmployeeId { get; set; }

    [Column("account_holder_name")]
    [StringLength(200)]
    public string AccountHolderName { get; set; } = null!;

    [Column("account_no")]
    [StringLength(30)]
    public string AccountNo { get; set; } = null!;

    [Column("ifsc_code")]
    [StringLength(15)]
    public string IfscCode { get; set; } = null!;

    [Column("account_type")]
    [StringLength(1)]
    public string AccountType { get; set; } = null!;

    [Column("wef_date", TypeName = "timestamp(0) without time zone")]
    public DateTime WefDate { get; set; }

    [Column("micr_number")]
    [StringLength(15)]
    public string? MicrNumber { get; set; }

    [Column("address")]
    [StringLength(200)]
    public string? Address { get; set; }

    [Column("email_id")]
    [StringLength(50)]
    public string? EmailId { get; set; }

    [Column("mobile_number")]
    public long? MobileNumber { get; set; }

    [Column("request_id")]
    [Precision(20, 0)]
    public decimal RequestId { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string ActiveFlag { get; set; } = null!;

    [Column("dml_status_flag")]
    public short DmlStatusFlag { get; set; }

    [Column("created_user_id")]
    public long CreatedUserId { get; set; }

    [Column("created_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime CreatedTimestamp { get; set; }

    [Column("modified_user_id")]
    public long ModifiedUserId { get; set; }

    [Column("modified_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime ModifiedTimestamp { get; set; }
}
