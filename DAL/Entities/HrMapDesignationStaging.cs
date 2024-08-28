using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("hr_map_designation_staging", Schema = "ihrms_master")]
public partial class HrMapDesignationStaging
{
    [Column("MASTER_DESCR_COSA")]
    [StringLength(500)]
    public string? MasterDescrCosa { get; set; }

    [Column("DESIGNATION_IFMS")]
    [StringLength(500)]
    public string? DesignationIfms { get; set; }

    [Column("INT_OTHER_MASTER_ID_old")]
    [StringLength(38)]
    public string? IntOtherMasterIdOld { get; set; }

    [Column("INT_OTHER_MASTER_ID")]
    public int? IntOtherMasterId { get; set; }
}
