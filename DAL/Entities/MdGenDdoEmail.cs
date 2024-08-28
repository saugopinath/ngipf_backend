using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NGIPF_BE.DAL.Entities;

[Keyless]
[Table("md_gen_ddo_email", Schema = "ifmsadmin")]
public partial class MdGenDdoEmail
{
    [Column("ddo_fname")]
    [StringLength(200)]
    public string? DdoFname { get; set; }

    [Column("ddo_code")]
    [StringLength(9)]
    public string? DdoCode { get; set; }

    [Column("e_mail")]
    [StringLength(50)]
    public string? EMail { get; set; }

    [Column("login")]
    [StringLength(50)]
    public string? Login { get; set; }

    [Column("ddo_lname")]
    [StringLength(200)]
    public string? DdoLname { get; set; }

    [Column("phone_old")]
    [StringLength(38)]
    public string? PhoneOld { get; set; }

    [Column("phone")]
    public int? Phone { get; set; }
}
