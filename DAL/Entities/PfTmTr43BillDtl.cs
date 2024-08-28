using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("pf_tm_tr43_bill_dtls", Schema = "ngipf")]
public partial class PfTmTr43BillDtl
{
    [Key]
    [Column("int_tr43_bill_dtls_id")]
    [StringLength(38)]
    public string IntTr43BillDtlsId { get; set; } = null!;

    [Column("int_tr43_bill_group_id")]
    [StringLength(38)]
    public string IntTr43BillGroupId { get; set; } = null!;

    [Column("int_employee_id")]
    [StringLength(38)]
    public string IntEmployeeId { get; set; } = null!;

    [Column("balance_amt")]
    public long BalanceAmt { get; set; }

    [Column("interest_amt")]
    public long InterestAmt { get; set; }

    [Column("gross_amt")]
    public long GrossAmt { get; set; }

    [Column("unauthorised_amt")]
    public long? UnauthorisedAmt { get; set; }

    [Column("dml_status_flag")]
    public short DmlStatusFlag { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string ActiveFlag { get; set; } = null!;

    [Column("created_by_user")]
    public int CreatedByUser { get; set; }

    [Column("created_by_role")]
    public short CreatedByRole { get; set; }

    [Column("created_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime CreatedTimestamp { get; set; }

    [Column("modified_by_user")]
    public int? ModifiedByUser { get; set; }

    [Column("modified_by_role")]
    public short? ModifiedByRole { get; set; }

    [Column("modified_timestamp", TypeName = "timestamp(0) without time zone")]
    public DateTime? ModifiedTimestamp { get; set; }

    [Column("remarks")]
    [StringLength(100)]
    public string? Remarks { get; set; }

    [Column("interest_upto", TypeName = "timestamp(0) without time zone")]
    public DateTime? InterestUpto { get; set; }

    [Column("sanction_id")]
    [StringLength(20)]
    public string? SanctionId { get; set; }

    [Column("payment_authority_id")]
    [StringLength(14)]
    public string? PaymentAuthorityId { get; set; }

    [Column("payment_authority_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? PaymentAuthorityDate { get; set; }

    [Column("hoo_code")]
    [StringLength(30)]
    public string? HooCode { get; set; }

    [Column("exclude_flag")]
    [StringLength(1)]
    public string? ExcludeFlag { get; set; }

    [Column("verified_by")]
    public int? VerifiedBy { get; set; }

    [Column("interest_verified_status")]
    [StringLength(1)]
    public string? InterestVerifiedStatus { get; set; }

    [Column("verified_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? VerifiedDate { get; set; }

    [Column("emp_working_ddo_id")]
    public int? EmpWorkingDdoId { get; set; }
}
