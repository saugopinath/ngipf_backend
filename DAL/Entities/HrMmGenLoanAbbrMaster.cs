using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Keyless]
[Table("hr_mm_gen_loan_abbr_master", Schema = "ihrms_master")]
public partial class HrMmGenLoanAbbrMaster
{
    [Column("LOAN_DESC_ABBR")]
    [StringLength(10)]
    public string? LoanDescAbbr { get; set; }

    [Column("REQUEST_TYPE")]
    [StringLength(10)]
    public string? RequestType { get; set; }

    [Column("MODIFIED_TIMESTAMP", TypeName = "timestamp without time zone")]
    public DateTime ModifiedTimestamp { get; set; }

    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("LOAN_DESCRIPTION")]
    [StringLength(100)]
    public string? LoanDescription { get; set; }

    [Column("INT_LOAN_ADV_ABBR_ID_old")]
    [StringLength(38)]
    public string? IntLoanAdvAbbrIdOld { get; set; }

    [Column("INT_LOAN_ADV_ABBR_ID")]
    public int? IntLoanAdvAbbrId { get; set; }

    [Column("MODIFIED_USER_ID_old")]
    [StringLength(38)]
    public string? ModifiedUserIdOld { get; set; }

    [Column("MODIFIED_USER_ID")]
    public int? ModifiedUserId { get; set; }
}
