using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[PrimaryKey("IntOperatorId", "FinancialYearCodeUpto")]
[Table("lf_pl_op_interest_credited_status", Schema = "ngipf")]
public partial class LfPlOpInterestCreditedStatus
{
    [Column("id")]
    public int Id { get; set; }

    [Key]
    [Column("int_operator_id")]
    public int IntOperatorId { get; set; }

    [Column("status")]
    public short? Status { get; set; }

    [Key]
    [Column("financial_year_code_upto")]
    public int FinancialYearCodeUpto { get; set; }

    [Column("in_transfer_code")]
    public int? InTransferCode { get; set; }

    [Column("int_bill_no")]
    public int? IntBillNo { get; set; }

    [ForeignKey("FinancialYearCodeUpto")]
    [InverseProperty("LfPlOpInterestCreditedStatuses")]
    public virtual MmGenFinancialYear FinancialYearCodeUptoNavigation { get; set; } = null!;

    [ForeignKey("InTransferCode")]
    [InverseProperty("LfPlOpInterestCreditedStatuses")]
    public virtual MmGenInTransferMaster? InTransferCodeNavigation { get; set; }

    [ForeignKey("IntBillNo")]
    [InverseProperty("LfPlOpInterestCreditedStatuses")]
    public virtual LfPlInterestCreditedBillDetail? IntBillNoNavigation { get; set; }

    [ForeignKey("IntOperatorId")]
    [InverseProperty("LfPlOpInterestCreditedStatuses")]
    public virtual TMmGenPlOperator IntOperator { get; set; } = null!;
}
