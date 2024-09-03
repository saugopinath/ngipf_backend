using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Keyless]
[Table("hr_mm_gen_loan_advance_purpose", Schema = "ihrms_master")]
public partial class HrMmGenLoanAdvancePurpose
{
    [Column("LOAN_ADVANCE_PURPOSE")]
    [StringLength(500)]
    public string? LoanAdvancePurpose { get; set; }

    [Column("REASON_TYPE")]
    [StringLength(1)]
    public string? ReasonType { get; set; }

    [Column("ACTIVE_FLAG")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("CREATED_TIMESTAMP")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("MODIFIED_TIMESTAMP", TypeName = "timestamp without time zone")]
    public DateTime ModifiedTimestamp { get; set; }

    [Column("INT_LOAN_ADVANCE_PURPOSE_ID_old")]
    [StringLength(38)]
    public string? IntLoanAdvancePurposeIdOld { get; set; }

    [Column("INT_LOAN_ADVANCE_PURPOSE_ID")]
    public int? IntLoanAdvancePurposeId { get; set; }

    [Column("INT_LOAN_ADVANCE_TYPE_ID_old")]
    [StringLength(38)]
    public string? IntLoanAdvanceTypeIdOld { get; set; }

    [Column("INT_LOAN_ADVANCE_TYPE_ID")]
    public int? IntLoanAdvanceTypeId { get; set; }

    [Column("INT_LOAN_ADVANCE_INSTALL_ID_old")]
    [StringLength(38)]
    public string? IntLoanAdvanceInstallIdOld { get; set; }

    [Column("INT_LOAN_ADVANCE_INSTALL_ID")]
    public int? IntLoanAdvanceInstallId { get; set; }

    [Column("CREATED_USER_ID_old")]
    [StringLength(38)]
    public string? CreatedUserIdOld { get; set; }

    [Column("CREATED_USER_ID")]
    public int? CreatedUserId { get; set; }

    [Column("MODIFIED_USER_ID_old")]
    [StringLength(38)]
    public string? ModifiedUserIdOld { get; set; }

    [Column("MODIFIED_USER_ID")]
    public int? ModifiedUserId { get; set; }
}
