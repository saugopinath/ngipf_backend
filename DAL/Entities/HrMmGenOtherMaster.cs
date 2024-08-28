using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ngipf_frontend.DAL.Entities;

[Table("hr_mm_gen_other_master", Schema = "ihrms_master")]
public partial class HrMmGenOtherMaster
{
    [Column("master_abbr")]
    [StringLength(12)]
    public string? MasterAbbr { get; set; }

    [Column("master_descr")]
    [StringLength(250)]
    public string? MasterDescr { get; set; }

    [Column("master_type")]
    [StringLength(6)]
    public string? MasterType { get; set; }

    [Column("active_flag")]
    [StringLength(1)]
    public string? ActiveFlag { get; set; }

    [Column("created_timestamp")]
    public DateOnly CreatedTimestamp { get; set; }

    [Column("modified_timestamp")]
    public DateOnly ModifiedTimestamp { get; set; }

    [Column("ta_da_active_flag")]
    [StringLength(1)]
    public string? TaDaActiveFlag { get; set; }

    [Column("payfix_abbr")]
    [StringLength(10)]
    public string? PayfixAbbr { get; set; }

    [Column("confirmation_desc")]
    [StringLength(150)]
    public string? ConfirmationDesc { get; set; }

    [Column("service_book_flag")]
    [StringLength(1)]
    public string? ServiceBookFlag { get; set; }

    [Column("int_other_master_id_old")]
    [StringLength(38)]
    public string? IntOtherMasterIdOld { get; set; }

    [Column("created_user_id_old")]
    [StringLength(38)]
    public string? CreatedUserIdOld { get; set; }

    [Column("created_user_id")]
    public int? CreatedUserId { get; set; }

    [Column("modified_user_id_old")]
    [StringLength(38)]
    public string? ModifiedUserIdOld { get; set; }

    [Column("modified_user_id")]
    public int? ModifiedUserId { get; set; }

    [Column("srl_no_old")]
    [StringLength(38)]
    public string? SrlNoOld { get; set; }

    [Column("srl_no")]
    public int? SrlNo { get; set; }

    [Column("int_business_pk_id_old")]
    [StringLength(38)]
    public string? IntBusinessPkIdOld { get; set; }

    [Column("int_business_pk_id")]
    public int? IntBusinessPkId { get; set; }

    [Column("int_mm_gen_wf_mod_subtype_id_old")]
    [StringLength(38)]
    public string? IntMmGenWfModSubtypeIdOld { get; set; }

    [Column("int_mm_gen_wf_mod_subtype_id")]
    public int? IntMmGenWfModSubtypeId { get; set; }

    [Column("int_mm_gen_wf_mod_type_id_old")]
    [StringLength(38)]
    public string? IntMmGenWfModTypeIdOld { get; set; }

    [Column("int_mm_gen_wf_mod_type_id")]
    public int? IntMmGenWfModTypeId { get; set; }

    [Column("int_dependency_1_old")]
    [StringLength(38)]
    public string? IntDependency1Old { get; set; }

    [Column("int_dependency_1")]
    public int? IntDependency1 { get; set; }

    [Column("int_dependency_2_old")]
    [StringLength(38)]
    public string? IntDependency2Old { get; set; }

    [Column("int_dependency_2")]
    public int? IntDependency2 { get; set; }

    [Column("int_dependency_3_old")]
    [StringLength(38)]
    public string? IntDependency3Old { get; set; }

    [Column("int_dependency_3")]
    public int? IntDependency3 { get; set; }

    [Key]
    [Column("int_other_master_id")]
    public int IntOtherMasterId { get; set; }

    [InverseProperty("IntModeOfRecruitmentNavigation")]
    public virtual ICollection<HrMdAppntDtlsSrvBook> HrMdAppntDtlsSrvBookIntModeOfRecruitmentNavigations { get; set; } = new List<HrMdAppntDtlsSrvBook>();

    [InverseProperty("IntOmiEmploymentTypeNavigation")]
    public virtual ICollection<HrMdAppntDtlsSrvBook> HrMdAppntDtlsSrvBookIntOmiEmploymentTypeNavigations { get; set; } = new List<HrMdAppntDtlsSrvBook>();

    [InverseProperty("IntOmiSrvBookBlock")]
    public virtual ICollection<HrMdAppntDtlsSrvBook> HrMdAppntDtlsSrvBookIntOmiSrvBookBlocks { get; set; } = new List<HrMdAppntDtlsSrvBook>();

    [InverseProperty("YearOfAllotmentNavigation")]
    public virtual ICollection<HrMdAppntDtlsSrvBook> HrMdAppntDtlsSrvBookYearOfAllotmentNavigations { get; set; } = new List<HrMdAppntDtlsSrvBook>();

    [InverseProperty("IntMaritalStatus")]
    public virtual ICollection<HrMdEmpNomineeDtlWf> HrMdEmpNomineeDtlWfIntMaritalStatuses { get; set; } = new List<HrMdEmpNomineeDtlWf>();

    [InverseProperty("NomIntOmiPhysicChallengedNavigation")]
    public virtual ICollection<HrMdEmpNomineeDtlWf> HrMdEmpNomineeDtlWfNomIntOmiPhysicChallengedNavigations { get; set; } = new List<HrMdEmpNomineeDtlWf>();

    [InverseProperty("IntMaritalStatus")]
    public virtual ICollection<HrMdEmpNomineeDtl> HrMdEmpNomineeDtls { get; set; } = new List<HrMdEmpNomineeDtl>();

    [InverseProperty("IntOmiSrvBookBlock")]
    public virtual ICollection<HrMdEmpPayAndAllowance> HrMdEmpPayAndAllowances { get; set; } = new List<HrMdEmpPayAndAllowance>();

    [InverseProperty("IntOmiSrvBookBlock")]
    public virtual ICollection<HrMdEmpPayInformationWf> HrMdEmpPayInformationWfs { get; set; } = new List<HrMdEmpPayInformationWf>();

    [InverseProperty("IntOmiSrvBookBlock")]
    public virtual ICollection<HrMdEmpPayInformation> HrMdEmpPayInformations { get; set; } = new List<HrMdEmpPayInformation>();

    [InverseProperty("IntRelMaritialStatusNavigation")]
    public virtual ICollection<HrMdEmpRelationship> HrMdEmpRelationshipIntRelMaritialStatusNavigations { get; set; } = new List<HrMdEmpRelationship>();

    [InverseProperty("RelIntOmiRelationshipNavigation")]
    public virtual ICollection<HrMdEmpRelationship> HrMdEmpRelationshipRelIntOmiRelationshipNavigations { get; set; } = new List<HrMdEmpRelationship>();

    [InverseProperty("IntOmiNatureOfReleaseNavigation")]
    public virtual ICollection<HrMdEmpWorkingDtl> HrMdEmpWorkingDtlIntOmiNatureOfReleaseNavigations { get; set; } = new List<HrMdEmpWorkingDtl>();

    [InverseProperty("IntOmiSrvBookBlock")]
    public virtual ICollection<HrMdEmpWorkingDtl> HrMdEmpWorkingDtlIntOmiSrvBookBlocks { get; set; } = new List<HrMdEmpWorkingDtl>();

    [InverseProperty("EmpIntOmiCastNavigation")]
    public virtual ICollection<HrMmEmpBasicDtl> HrMmEmpBasicDtlEmpIntOmiCastNavigations { get; set; } = new List<HrMmEmpBasicDtl>();

    [InverseProperty("EmpIntOmiGenderNavigation")]
    public virtual ICollection<HrMmEmpBasicDtl> HrMmEmpBasicDtlEmpIntOmiGenderNavigations { get; set; } = new List<HrMmEmpBasicDtl>();

    [InverseProperty("EmpIntOmiInitialsNavigation")]
    public virtual ICollection<HrMmEmpBasicDtl> HrMmEmpBasicDtlEmpIntOmiInitialsNavigations { get; set; } = new List<HrMmEmpBasicDtl>();

    [InverseProperty("EmpIntOmiNationalityNavigation")]
    public virtual ICollection<HrMmEmpBasicDtl> HrMmEmpBasicDtlEmpIntOmiNationalityNavigations { get; set; } = new List<HrMmEmpBasicDtl>();

    [InverseProperty("EmpIntOmiPhysicChallengedNavigation")]
    public virtual ICollection<HrMmEmpBasicDtl> HrMmEmpBasicDtlEmpIntOmiPhysicChallengedNavigations { get; set; } = new List<HrMmEmpBasicDtl>();

    [InverseProperty("EmpIntOmiReligionNavigation")]
    public virtual ICollection<HrMmEmpBasicDtl> HrMmEmpBasicDtlEmpIntOmiReligionNavigations { get; set; } = new List<HrMmEmpBasicDtl>();

    [InverseProperty("IntEmpOmiHeightUnitNavigation")]
    public virtual ICollection<HrMmEmpBasicDtl> HrMmEmpBasicDtlIntEmpOmiHeightUnitNavigations { get; set; } = new List<HrMmEmpBasicDtl>();
}
