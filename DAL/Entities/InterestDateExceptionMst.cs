using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_backend.DAL.Entities;

[Table("interest_date_exception_mst", Schema = "ngipf_master")]
public partial class InterestDateExceptionMst
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("day_of_month")]
    [StringLength(50)]
    public string? DayOfMonth { get; set; }

    [Column("int_hoa_id")]
    public int? IntHoaId { get; set; }

    [Column("active_flag")]
    [MaxLength(1)]
    public char? ActiveFlag { get; set; }

    [Column("int_go_id")]
    public int? IntGoId { get; set; }

    [Column("created_by")]
    public int? CreatedBy { get; set; }

    [Column("last_updated_by")]
    public int? LastUpdatedBy { get; set; }

    [Column("deleted_by")]
    public int? DeletedBy { get; set; }

    [Column("created_at", TypeName = "timestamp without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("last_updated_at", TypeName = "timestamp without time zone")]
    public DateTime? LastUpdatedAt { get; set; }

    [Column("deleted_at", TypeName = "timestamp without time zone")]
    public DateTime? DeletedAt { get; set; }

    [ForeignKey("IntGoId")]
    [InverseProperty("InterestDateExceptionMsts")]
    public virtual GoDetailsMst? IntGo { get; set; }

    [ForeignKey("IntHoaId")]
    [InverseProperty("InterestDateExceptionMsts")]
    public virtual NgipfHoaList? IntHoa { get; set; }
}
