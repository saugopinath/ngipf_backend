using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Table("td_emp_opening_balance", Schema = "ngipf")]
public partial class TdEmpOpeningBalance
{
    [Key]
    [Column("int_td_emp_open_bal_id")]
    [StringLength(38)]
    public string IntTdEmpOpenBalId { get; set; } = null!;

    [Column("int_tm_emp_open_bal_id")]
    [StringLength(38)]
    public string IntTmEmpOpenBalId { get; set; } = null!;

    [Column("int_employee_id")]
    [StringLength(38)]
    public string IntEmployeeId { get; set; } = null!;

    [Column("amount")]
    [Precision(10, 2)]
    public decimal Amount { get; set; }

    [Column("remarks")]
    [StringLength(500)]
    public string? Remarks { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string ActiveFlag { get; set; } = null!;

    [Column("dml_ststus_flag")]
    public short DmlStstusFlag { get; set; }

    [Column("created_user_id")]
    public long CreatedUserId { get; set; }

    [Column("created_date", TypeName = "timestamp(6) without time zone")]
    public DateTime CreatedDate { get; set; }

    [Column("modified_user_id")]
    public long ModifiedUserId { get; set; }

    [Column("modified_date", TypeName = "timestamp(6) without time zone")]
    public DateTime ModifiedDate { get; set; }

    [Column("status_flag")]
    [StringLength(2)]
    public string StatusFlag { get; set; } = null!;

    [Column("checked_flag")]
    [StringLength(2)]
    public string? CheckedFlag { get; set; }

    [Column("sub_pre_office_type")]
    [StringLength(20)]
    public string? SubPreOfficeType { get; set; }

    [Column("sub_pre_office_id")]
    [StringLength(38)]
    public string? SubPreOfficeId { get; set; }

    [Column("emp_send_back")]
    [StringLength(5)]
    public string? EmpSendBack { get; set; }

    [Column("section_code")]
    [StringLength(25)]
    public string? SectionCode { get; set; }
}
