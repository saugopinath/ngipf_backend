using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Keyless]
[Table("td_pf_res_payee_dtls", Schema = "ngipf")]
public partial class TdPfResPayeeDtl
{
    [Column("int_payee_id")]
    [StringLength(38)]
    public string IntPayeeId { get; set; } = null!;

    [Column("int_final_payment_id")]
    [StringLength(38)]
    public string IntFinalPaymentId { get; set; } = null!;

    [Column("int_payee_type_id")]
    [StringLength(38)]
    public string? IntPayeeTypeId { get; set; }

    [Column("payee_name")]
    [StringLength(100)]
    public string PayeeName { get; set; } = null!;

    [Column("int_nom_id")]
    [StringLength(38)]
    public string? IntNomId { get; set; }

    [Column("int_benf_id")]
    [StringLength(38)]
    public string? IntBenfId { get; set; }

    [Column("benf_acct_no")]
    [StringLength(30)]
    public string? BenfAcctNo { get; set; }

    [Column("benf_bank_ifsc_code")]
    [StringLength(15)]
    public string? BenfBankIfscCode { get; set; }

    [Column("benf_id")]
    [StringLength(20)]
    public string? BenfId { get; set; }

    [Column("confirm_flag")]
    [MaxLength(1)]
    public char ConfirmFlag { get; set; }

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

    [Column("account_type")]
    [StringLength(1)]
    public string AccountType { get; set; } = null!;

    [Column("adhar_no")]
    [StringLength(20)]
    public string? AdharNo { get; set; }

    [Column("pan")]
    [StringLength(10)]
    public string? Pan { get; set; }

    [Column("benf_address")]
    [StringLength(200)]
    public string? BenfAddress { get; set; }

    [Column("benf_mobile_number")]
    public long? BenfMobileNumber { get; set; }

    [Column("benf_email_id")]
    [StringLength(50)]
    public string? BenfEmailId { get; set; }

    [Column("death_date", TypeName = "timestamp(0) without time zone")]
    public DateTime? DeathDate { get; set; }

    [Column("cessation_age")]
    public short? CessationAge { get; set; }

    [Column("adult_minor_flag")]
    [StringLength(10)]
    public string AdultMinorFlag { get; set; } = null!;

    [Column("gender")]
    [StringLength(150)]
    public string? Gender { get; set; }

    [Column("martial_status")]
    [StringLength(150)]
    public string? MartialStatus { get; set; }

    [Column("nominee_death_flag")]
    [MaxLength(1)]
    public char? NomineeDeathFlag { get; set; }

    [Column("amount")]
    public long? Amount { get; set; }

    [Column("share_percentage")]
    public int SharePercentage { get; set; }

    [Column("org_nom_id_for_alternate")]
    [StringLength(38)]
    public string? OrgNomIdForAlternate { get; set; }

    [Column("nominee_type")]
    [MaxLength(1)]
    public char? NomineeType { get; set; }

    [Column("int_relationship_type_id")]
    [StringLength(38)]
    public string? IntRelationshipTypeId { get; set; }
}
