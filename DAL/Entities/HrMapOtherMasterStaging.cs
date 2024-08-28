using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Keyless]
[Table("hr_map_other_master_staging", Schema = "ihrms_master")]
public partial class HrMapOtherMasterStaging
{
    [Column("MASTER_DESCR_COSA")]
    [StringLength(50)]
    public string? MasterDescrCosa { get; set; }

    [Column("MASTER_DESCR_IFMS")]
    [StringLength(50)]
    public string? MasterDescrIfms { get; set; }

    [Column("MASTER_ABBR")]
    [StringLength(10)]
    public string? MasterAbbr { get; set; }

    [Column("INT_OTHER_MASTER_ID_old")]
    [StringLength(38)]
    public string? IntOtherMasterIdOld { get; set; }

    [Column("INT_OTHER_MASTER_ID")]
    public int? IntOtherMasterId { get; set; }
}
