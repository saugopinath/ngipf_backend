using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("pf_interest_credit_master", Schema = "ngipf")]
public partial class PfInterestCreditMaster
{
    [Column("int_hoa_code")]
    public int? IntHoaCode { get; set; }

    [Column("int_treasury_id")]
    public int? IntTreasuryId { get; set; }

    [Column("lf_pl_operator_id")]
    public int? LfPlOperatorId { get; set; }

    [Column("go_no")]
    [StringLength(20)]
    public string? GoNo { get; set; }

    [Column("go_date")]
    public DateOnly? GoDate { get; set; }

    [Column("interest_through")]
    public short? InterestThrough { get; set; }
}
