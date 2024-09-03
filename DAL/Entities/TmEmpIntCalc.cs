using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("tm_emp_int_calc", Schema = "ingipfund")]
public partial class TmEmpIntCalc
{
    [Key]
    [Column("int_tm_emp_int_cal_id")]
    [Precision(22, 0)]
    public decimal IntTmEmpIntCalId { get; set; }

    [Column("job_id")]
    [Precision(22, 0)]
    public decimal? JobId { get; set; }

    [Column("job_type")]
    [StringLength(2)]
    public string? JobType { get; set; }

    [Column("hoa_id")]
    public int? HoaId { get; set; }

    [Column("int_operator_id")]
    public int? IntOperatorId { get; set; }

    [Column("start_time")]
    public DateOnly? StartTime { get; set; }

    [Column("end_time")]
    public DateOnly? EndTime { get; set; }

    [Column("dml_status_flag")]
    [Precision(22, 0)]
    public decimal? DmlStatusFlag { get; set; }

    [Column("created_user_id")]
    [Precision(22, 0)]
    public decimal? CreatedUserId { get; set; }

    [Column("created_timestamp")]
    public DateOnly? CreatedTimestamp { get; set; }

    [Column("modified_user_id")]
    [Precision(22, 0)]
    public decimal? ModifiedUserId { get; set; }

    [Column("modified_timestamp")]
    public DateOnly? ModifiedTimestamp { get; set; }

    [Column("fin_year")]
    [Precision(22, 0)]
    public decimal? FinYear { get; set; }

    [Column("upto_month")]
    [StringLength(3)]
    public string? UptoMonth { get; set; }

    [Column("status")]
    [StringLength(1)]
    public string? Status { get; set; }

    [Column("int_employee_id")]
    [Precision(22, 0)]
    public BigInteger? IntEmployeeId { get; set; }

    [Column("int_scheme_id")]
    public int? IntSchemeId { get; set; }

    [Column("int_tr43_bill_group_id")]
    [Precision(22, 0)]
    public decimal? IntTr43BillGroupId { get; set; }

    [ForeignKey("HoaId")]
    [InverseProperty("TmEmpIntCalcs")]
    public virtual MmGenHoa? Hoa { get; set; }

    public virtual HrMmEmpBasicDtl? IntEmployee { get; set; }

    [ForeignKey("IntOperatorId")]
    [InverseProperty("TmEmpIntCalcs")]
    public virtual TMmGenPlOperator? IntOperator { get; set; }

    [ForeignKey("IntSchemeId")]
    [InverseProperty("TmEmpIntCalcs")]
    public virtual MdGenSchemeHead? IntScheme { get; set; }

    [ForeignKey("IntTr43BillGroupId")]
    [InverseProperty("TmEmpIntCalcs")]
    public virtual PfTmTrBillHdr? IntTr43BillGroup { get; set; }

    [InverseProperty("IntTmEmpIntCal")]
    public virtual TdEmpIntCalc? TdEmpIntCalc { get; set; }

    [InverseProperty("IntTmEmpIntCal")]
    public virtual ICollection<TdEmpIntCalcDtl> TdEmpIntCalcDtls { get; set; } = new List<TdEmpIntCalcDtl>();

    [InverseProperty("IntTmEmpIntCal")]
    public virtual ICollection<TdEmpIntCalcErrLog> TdEmpIntCalcErrLogs { get; set; } = new List<TdEmpIntCalcErrLog>();

    [InverseProperty("IntTmEmpOpenBal")]
    public virtual ICollection<TdEmpOpeningBalance1> TdEmpOpeningBalance1s { get; set; } = new List<TdEmpOpeningBalance1>();
}
