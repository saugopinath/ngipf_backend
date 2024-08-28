using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("td_pf_final_payment_nominee_benf_dtls", Schema = "ingipfund")]
public partial class TdPfFinalPaymentNomineeBenfDtl
{
    [Key]
    [Column("int_td_pf_final_payment_nominee_benf_dtls_id")]
    [StringLength(38)]
    public string IntTdPfFinalPaymentNomineeBenfDtlsId { get; set; } = null!;

    [Column("int_final_payment_id")]
    [Precision(38, 0)]
    public decimal? IntFinalPaymentId { get; set; }

    [Column("int_employee_id")]
    [Precision(38, 0)]
    public BigInteger? IntEmployeeId { get; set; }

    [Column("request_id")]
    [StringLength(20)]
    public string? RequestId { get; set; }

    [Column("nominee_name")]
    [StringLength(100)]
    public string? NomineeName { get; set; }

    [Column("nominee_type")]
    [StringLength(20)]
    public string? NomineeType { get; set; }

    [Column("nominee_gender")]
    [StringLength(20)]
    public string? NomineeGender { get; set; }

    [Column("nominee_relationship")]
    [StringLength(20)]
    public string? NomineeRelationship { get; set; }

    [Column("nominee_ifsc")]
    [StringLength(20)]
    public string? NomineeIfsc { get; set; }

    [Column("nominee_account_no")]
    [StringLength(30)]
    public string? NomineeAccountNo { get; set; }

    [Column("nominee_percentage")]
    [StringLength(30)]
    public string? NomineePercentage { get; set; }

    [Column("nominee_amount")]
    [StringLength(30)]
    public string? NomineeAmount { get; set; }

    [Column("dml_status_flag")]
    [StringLength(1)]
    public string? DmlStatusFlag { get; set; }

    [Column("created_userid")]
    [StringLength(30)]
    public string? CreatedUserid { get; set; }

    [Column("modified_userid")]
    [StringLength(30)]
    public string? ModifiedUserid { get; set; }

    [Column("created_roleid")]
    [StringLength(30)]
    public string? CreatedRoleid { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    public virtual HrMmEmpBasicDtl? IntEmployee { get; set; }

    [ForeignKey("IntFinalPaymentId")]
    [InverseProperty("TdPfFinalPaymentNomineeBenfDtls")]
    public virtual TmPfFinalPayment1? IntFinalPayment { get; set; }
}
