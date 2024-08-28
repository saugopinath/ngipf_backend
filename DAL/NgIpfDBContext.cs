using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using NGIPF_BE.DAL.Entities;

namespace NGIPF_BE.DAL;

public partial class NgIpfDBContext : DbContext
{
    public NgIpfDBContext()
    {
    }

    public NgIpfDBContext(DbContextOptions<NgIpfDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DeptHoaMapping> DeptHoaMappings { get; set; }

    public virtual DbSet<EmpArrearDtl> EmpArrearDtls { get; set; }

    public virtual DbSet<EmpOpeningBalanceAccpeted> EmpOpeningBalanceAccpeteds { get; set; }

    public virtual DbSet<EmpOpeningBalanceRemark> EmpOpeningBalanceRemarks { get; set; }

    public virtual DbSet<EmpOpeningBalanceTemp> EmpOpeningBalanceTemps { get; set; }

    public virtual DbSet<EmpPfBasicDetail> EmpPfBasicDetails { get; set; }

    public virtual DbSet<EmpPfOfficeDetail> EmpPfOfficeDetails { get; set; }

    public virtual DbSet<EmpSubscription> EmpSubscriptions { get; set; }

    public virtual DbSet<EmpWithdrawal> EmpWithdrawals { get; set; }

    public virtual DbSet<HoaPlpfOperatorMap> HoaPlpfOperatorMaps { get; set; }

    public virtual DbSet<HrDetailsEmpStaging> HrDetailsEmpStagings { get; set; }

    public virtual DbSet<HrFixedComponent> HrFixedComponents { get; set; }

    public virtual DbSet<HrLegacyDataTemp> HrLegacyDataTemps { get; set; }

    public virtual DbSet<HrMapDepartmentStaging> HrMapDepartmentStagings { get; set; }

    public virtual DbSet<HrMapDesignationStaging> HrMapDesignationStagings { get; set; }

    public virtual DbSet<HrMapOtherMasterStaging> HrMapOtherMasterStagings { get; set; }

    public virtual DbSet<HrMapQualificationStaging> HrMapQualificationStagings { get; set; }

    public virtual DbSet<HrMdAppntDtlsSrvBook> HrMdAppntDtlsSrvBooks { get; set; }

    public virtual DbSet<HrMdConfDtlsSrvBook> HrMdConfDtlsSrvBooks { get; set; }

    public virtual DbSet<HrMdEmpAddress> HrMdEmpAddresses { get; set; }

    public virtual DbSet<HrMdEmpAddressWf> HrMdEmpAddressWfs { get; set; }

    public virtual DbSet<HrMdEmpNomineeDtl> HrMdEmpNomineeDtls { get; set; }

    public virtual DbSet<HrMdEmpNomineeDtlWf> HrMdEmpNomineeDtlWfs { get; set; }

    public virtual DbSet<HrMdEmpOtherDtl> HrMdEmpOtherDtls { get; set; }

    public virtual DbSet<HrMdEmpOtherDtlsSrvBook> HrMdEmpOtherDtlsSrvBooks { get; set; }

    public virtual DbSet<HrMdEmpOtherDtlsWf> HrMdEmpOtherDtlsWfs { get; set; }

    public virtual DbSet<HrMdEmpPayAndAllowance> HrMdEmpPayAndAllowances { get; set; }

    public virtual DbSet<HrMdEmpPayAndAllownceWf> HrMdEmpPayAndAllownceWfs { get; set; }

    public virtual DbSet<HrMdEmpPayBenfInfo> HrMdEmpPayBenfInfos { get; set; }

    public virtual DbSet<HrMdEmpPayBenfWf> HrMdEmpPayBenfWfs { get; set; }

    public virtual DbSet<HrMdEmpPayInfoSrvBook> HrMdEmpPayInfoSrvBooks { get; set; }

    public virtual DbSet<HrMdEmpPayInformation> HrMdEmpPayInformations { get; set; }

    public virtual DbSet<HrMdEmpPayInformationWf> HrMdEmpPayInformationWfs { get; set; }

    public virtual DbSet<HrMdEmpPayScaleBandInfo> HrMdEmpPayScaleBandInfos { get; set; }

    public virtual DbSet<HrMdEmpPayScaleBandWf> HrMdEmpPayScaleBandWfs { get; set; }

    public virtual DbSet<HrMdEmpQualifiSrvBook> HrMdEmpQualifiSrvBooks { get; set; }

    public virtual DbSet<HrMdEmpQualification> HrMdEmpQualifications { get; set; }

    public virtual DbSet<HrMdEmpQualificationWf> HrMdEmpQualificationWfs { get; set; }

    public virtual DbSet<HrMdEmpRelationAddress> HrMdEmpRelationAddresses { get; set; }

    public virtual DbSet<HrMdEmpRelationAddressWf> HrMdEmpRelationAddressWfs { get; set; }

    public virtual DbSet<HrMdEmpRelationship> HrMdEmpRelationships { get; set; }

    public virtual DbSet<HrMdEmpRelationshipSrvBk> HrMdEmpRelationshipSrvBks { get; set; }

    public virtual DbSet<HrMdEmpRelationshipWf> HrMdEmpRelationshipWfs { get; set; }

    public virtual DbSet<HrMdEmpSalaryHeadMap> HrMdEmpSalaryHeadMaps { get; set; }

    public virtual DbSet<HrMdEmpSalaryHeadMapWf> HrMdEmpSalaryHeadMapWfs { get; set; }

    public virtual DbSet<HrMdEmpSrvBookRequest> HrMdEmpSrvBookRequests { get; set; }

    public virtual DbSet<HrMdEmpWorkingDtl> HrMdEmpWorkingDtls { get; set; }

    public virtual DbSet<HrMdEmpWorkingDtlsWf> HrMdEmpWorkingDtlsWfs { get; set; }

    public virtual DbSet<HrMdGenAaOfficeAddress> HrMdGenAaOfficeAddresses { get; set; }

    public virtual DbSet<HrMdGenAaPersonalAddress> HrMdGenAaPersonalAddresses { get; set; }

    public virtual DbSet<HrMdGenAaPersonalDetail> HrMdGenAaPersonalDetails { get; set; }

    public virtual DbSet<HrMdGenAppAuthority> HrMdGenAppAuthorities { get; set; }

    public virtual DbSet<HrMdGenAppAuthorityPost> HrMdGenAppAuthorityPosts { get; set; }

    public virtual DbSet<HrMdGenCadreDeptMap> HrMdGenCadreDeptMaps { get; set; }

    public virtual DbSet<HrMdGenDdoAddress> HrMdGenDdoAddresses { get; set; }

    public virtual DbSet<HrMdGenDdoSalaryHeadMap> HrMdGenDdoSalaryHeadMaps { get; set; }

    public virtual DbSet<HrMdGenHeadOfOffice> HrMdGenHeadOfOffices { get; set; }

    public virtual DbSet<HrMdGenHoGroupAddress> HrMdGenHoGroupAddresses { get; set; }

    public virtual DbSet<HrMdGenHoGroupAddressWf> HrMdGenHoGroupAddressWfs { get; set; }

    public virtual DbSet<HrMdGenHoOfficeAddress> HrMdGenHoOfficeAddresses { get; set; }

    public virtual DbSet<HrMdGenHoOtherOfficeMap> HrMdGenHoOtherOfficeMaps { get; set; }

    public virtual DbSet<HrMdGenHoPersonalAddress> HrMdGenHoPersonalAddresses { get; set; }

    public virtual DbSet<HrMdGenHoPersonalDetail> HrMdGenHoPersonalDetails { get; set; }

    public virtual DbSet<HrMdGenHoSancAuthDet> HrMdGenHoSancAuthDets { get; set; }

    public virtual DbSet<HrMdGenHoSancAuthDetWf> HrMdGenHoSancAuthDetWfs { get; set; }

    public virtual DbSet<HrMdGenHoSancAuthMst> HrMdGenHoSancAuthMsts { get; set; }

    public virtual DbSet<HrMdGenHoSancAuthMstWf> HrMdGenHoSancAuthMstWfs { get; set; }

    public virtual DbSet<HrMdGenHoSancAuthPstcode> HrMdGenHoSancAuthPstcodes { get; set; }

    public virtual DbSet<HrMdGenHooGroup> HrMdGenHooGroups { get; set; }

    public virtual DbSet<HrMdGenHooGroupWf> HrMdGenHooGroupWfs { get; set; }

    public virtual DbSet<HrMdGenNdoEmpMapCur> HrMdGenNdoEmpMapCurs { get; set; }

    public virtual DbSet<HrMdGenNdoEmpMapWf> HrMdGenNdoEmpMapWfs { get; set; }

    public virtual DbSet<HrMdGenNodalOfficer> HrMdGenNodalOfficers { get; set; }

    public virtual DbSet<HrMdGenPaRatetype> HrMdGenPaRatetypes { get; set; }

    public virtual DbSet<HrMdGenPost> HrMdGenPosts { get; set; }

    public virtual DbSet<HrMdGenRevPayAllwOrder> HrMdGenRevPayAllwOrders { get; set; }

    public virtual DbSet<HrMdGenRopaMap> HrMdGenRopaMaps { get; set; }

    public virtual DbSet<HrMdGenRule> HrMdGenRules { get; set; }

    public virtual DbSet<HrMdGenSectionUserMap> HrMdGenSectionUserMaps { get; set; }

    public virtual DbSet<HrMdModuleApptAuthMap> HrMdModuleApptAuthMaps { get; set; }

    public virtual DbSet<HrMdPayAllowanceSrvBook> HrMdPayAllowanceSrvBooks { get; set; }

    public virtual DbSet<HrMdPayScaleBandSrvBook> HrMdPayScaleBandSrvBooks { get; set; }

    public virtual DbSet<HrMdPayfixCadreToolMap> HrMdPayfixCadreToolMaps { get; set; }

    public virtual DbSet<HrMdPostDtlsSrvBook> HrMdPostDtlsSrvBooks { get; set; }

    public virtual DbSet<HrMmDdoTransCollegeMap> HrMmDdoTransCollegeMaps { get; set; }

    public virtual DbSet<HrMmDdoTransHeadMap> HrMmDdoTransHeadMaps { get; set; }

    public virtual DbSet<HrMmDdoTransHooMap> HrMmDdoTransHooMaps { get; set; }

    public virtual DbSet<HrMmEmpBasicDtl> HrMmEmpBasicDtls { get; set; }

    public virtual DbSet<HrMmGenAppAuthority> HrMmGenAppAuthorities { get; set; }

    public virtual DbSet<HrMmGenBillType> HrMmGenBillTypes { get; set; }

    public virtual DbSet<HrMmGenBuisnessPkTypeMst> HrMmGenBuisnessPkTypeMsts { get; set; }

    public virtual DbSet<HrMmGenCadre> HrMmGenCadres { get; set; }

    public virtual DbSet<HrMmGenComponent> HrMmGenComponents { get; set; }

    public virtual DbSet<HrMmGenComponentMap> HrMmGenComponentMaps { get; set; }

    public virtual DbSet<HrMmGenCountry> HrMmGenCountries { get; set; }

    public virtual DbSet<HrMmGenCurHooEmpMap> HrMmGenCurHooEmpMaps { get; set; }

    public virtual DbSet<HrMmGenDdoHooMap> HrMmGenDdoHooMaps { get; set; }

    public virtual DbSet<HrMmGenDeptStakeLevel> HrMmGenDeptStakeLevels { get; set; }

    public virtual DbSet<HrMmGenDesignation> HrMmGenDesignations { get; set; }

    public virtual DbSet<HrMmGenEmpAppAuthMap> HrMmGenEmpAppAuthMaps { get; set; }

    public virtual DbSet<HrMmGenEmploymentType> HrMmGenEmploymentTypes { get; set; }

    public virtual DbSet<HrMmGenGradePay> HrMmGenGradePays { get; set; }

    public virtual DbSet<HrMmGenGroup> HrMmGenGroups { get; set; }

    public virtual DbSet<HrMmGenHeadOfDept> HrMmGenHeadOfDepts { get; set; }

    public virtual DbSet<HrMmGenHeadOfOffice> HrMmGenHeadOfOffices { get; set; }

    public virtual DbSet<HrMmGenHeadOfOfficeWf> HrMmGenHeadOfOfficeWfs { get; set; }

    public virtual DbSet<HrMmGenHoaMap> HrMmGenHoaMaps { get; set; }

    public virtual DbSet<HrMmGenHooAaMap> HrMmGenHooAaMaps { get; set; }

    public virtual DbSet<HrMmGenHooAaMapWf> HrMmGenHooAaMapWfs { get; set; }

    public virtual DbSet<HrMmGenHooEmpMap> HrMmGenHooEmpMaps { get; set; }

    public virtual DbSet<HrMmGenLoanAbbrMaster> HrMmGenLoanAbbrMasters { get; set; }

    public virtual DbSet<HrMmGenLoanAdvanceInstall> HrMmGenLoanAdvanceInstalls { get; set; }

    public virtual DbSet<HrMmGenLoanAdvancePurpose> HrMmGenLoanAdvancePurposes { get; set; }

    public virtual DbSet<HrMmGenLoanAdvanceRoi> HrMmGenLoanAdvanceRois { get; set; }

    public virtual DbSet<HrMmGenLoanAdvanceType> HrMmGenLoanAdvanceTypes { get; set; }

    public virtual DbSet<HrMmGenModule> HrMmGenModules { get; set; }

    public virtual DbSet<HrMmGenModuleFieldMap> HrMmGenModuleFieldMaps { get; set; }

    public virtual DbSet<HrMmGenModulePurposeMap> HrMmGenModulePurposeMaps { get; set; }

    public virtual DbSet<HrMmGenModuleReqtypeMap> HrMmGenModuleReqtypeMaps { get; set; }

    public virtual DbSet<HrMmGenModuleTableMap> HrMmGenModuleTableMaps { get; set; }

    public virtual DbSet<HrMmGenNodalOfficer> HrMmGenNodalOfficers { get; set; }

    public virtual DbSet<HrMmGenOadSocietyBank> HrMmGenOadSocietyBanks { get; set; }

    public virtual DbSet<HrMmGenOffice> HrMmGenOffices { get; set; }

    public virtual DbSet<HrMmGenOfficeType> HrMmGenOfficeTypes { get; set; }

    public virtual DbSet<HrMmGenOtherMapMaster> HrMmGenOtherMapMasters { get; set; }

    public virtual DbSet<HrMmGenOtherMaster> HrMmGenOtherMasters { get; set; }

    public virtual DbSet<HrMmGenPaRatetype> HrMmGenPaRatetypes { get; set; }

    public virtual DbSet<HrMmGenPayBand> HrMmGenPayBands { get; set; }

    public virtual DbSet<HrMmGenPayHeadMap> HrMmGenPayHeadMaps { get; set; }

    public virtual DbSet<HrMmGenPayScale> HrMmGenPayScales { get; set; }

    public virtual DbSet<HrMmGenPlPfDdoMap> HrMmGenPlPfDdoMaps { get; set; }

    public virtual DbSet<HrMmGenPost> HrMmGenPosts { get; set; }

    public virtual DbSet<HrMmGenPostType> HrMmGenPostTypes { get; set; }

    public virtual DbSet<HrMmGenPostcode> HrMmGenPostcodes { get; set; }

    public virtual DbSet<HrMmGenQualification> HrMmGenQualifications { get; set; }

    public virtual DbSet<HrMmGenQuarterType> HrMmGenQuarterTypes { get; set; }

    public virtual DbSet<HrMmGenRecruitmentMaster> HrMmGenRecruitmentMasters { get; set; }

    public virtual DbSet<HrMmGenRevPayAllwOrder> HrMmGenRevPayAllwOrders { get; set; }

    public virtual DbSet<HrMmGenRopaMap> HrMmGenRopaMaps { get; set; }

    public virtual DbSet<HrMmGenSection> HrMmGenSections { get; set; }

    public virtual DbSet<HrMmGenService> HrMmGenServices { get; set; }

    public virtual DbSet<HrMmGenStakeLevel> HrMmGenStakeLevels { get; set; }

    public virtual DbSet<HrMmGenWorkflow> HrMmGenWorkflows { get; set; }

    public virtual DbSet<HrMmGenWorkflowMaster> HrMmGenWorkflowMasters { get; set; }

    public virtual DbSet<HrMmGenWorkflowModSubtype> HrMmGenWorkflowModSubtypes { get; set; }

    public virtual DbSet<HrMmGenWorkflowModType> HrMmGenWorkflowModTypes { get; set; }

    public virtual DbSet<HrMmPayfixRopaOption> HrMmPayfixRopaOptions { get; set; }

    public virtual DbSet<HrMmPayfixTool> HrMmPayfixTools { get; set; }

    public virtual DbSet<HrMmPayfixType> HrMmPayfixTypes { get; set; }

    public virtual DbSet<HrTdEmpIncrement> HrTdEmpIncrements { get; set; }

    public virtual DbSet<HrTdHooSecEmpMap> HrTdHooSecEmpMaps { get; set; }

    public virtual DbSet<HrTdPayfix> HrTdPayfixes { get; set; }

    public virtual DbSet<HrTdPayfixDtl> HrTdPayfixDtls { get; set; }

    public virtual DbSet<HrTmPayfix> HrTmPayfixes { get; set; }

    public virtual DbSet<HrTmSrvBookRequestInit> HrTmSrvBookRequestInits { get; set; }

    public virtual DbSet<LfPlInterestCreditedBillDetail> LfPlInterestCreditedBillDetails { get; set; }

    public virtual DbSet<LfPlOpBalancePermissionStatusMaster> LfPlOpBalancePermissionStatusMasters { get; set; }

    public virtual DbSet<LfPlOpInterestCreditedStatus> LfPlOpInterestCreditedStatuses { get; set; }

    public virtual DbSet<LfPlOpInterestDateException> LfPlOpInterestDateExceptions { get; set; }

    public virtual DbSet<LfPlOpInterestGenerationList> LfPlOpInterestGenerationLists { get; set; }

    public virtual DbSet<LfPlOpInterestRateException> LfPlOpInterestRateExceptions { get; set; }

    public virtual DbSet<LfPlOpOpeningBalancePermissionStatus> LfPlOpOpeningBalancePermissionStatuses { get; set; }

    public virtual DbSet<LfPlOpReconciliationStatus> LfPlOpReconciliationStatuses { get; set; }

    public virtual DbSet<MdGenBcoHoaMap> MdGenBcoHoaMaps { get; set; }

    public virtual DbSet<MdGenBillType> MdGenBillTypes { get; set; }

    public virtual DbSet<MdGenBlock> MdGenBlocks { get; set; }

    public virtual DbSet<MdGenDdoEmail> MdGenDdoEmails { get; set; }

    public virtual DbSet<MdGenDdoSection> MdGenDdoSections { get; set; }

    public virtual DbSet<MdGenDepartment> MdGenDepartments { get; set; }

    public virtual DbSet<MdGenIntraBcoMap> MdGenIntraBcoMaps { get; set; }

    public virtual DbSet<MdGenLevelCode> MdGenLevelCodes { get; set; }

    public virtual DbSet<MdGenMinorhead> MdGenMinorheads { get; set; }

    public virtual DbSet<MdGenModuleRoleMap> MdGenModuleRoleMaps { get; set; }

    public virtual DbSet<MdGenPanchayat> MdGenPanchayats { get; set; }

    public virtual DbSet<MdGenRoleMenu> MdGenRoleMenus { get; set; }

    public virtual DbSet<MdGenSchemeHead> MdGenSchemeHeads { get; set; }

    public virtual DbSet<MdGenSchemePaymentCode> MdGenSchemePaymentCodes { get; set; }

    public virtual DbSet<MdGenSchemeReceiptCode> MdGenSchemeReceiptCodes { get; set; }

    public virtual DbSet<MdGenSubdetailedHead> MdGenSubdetailedHeads { get; set; }

    public virtual DbSet<MdGenSubmajorhead> MdGenSubmajorheads { get; set; }

    public virtual DbSet<MdGenSubsysModMap> MdGenSubsysModMaps { get; set; }

    public virtual DbSet<MdGenUserRole> MdGenUserRoles { get; set; }

    public virtual DbSet<MdGenUserSection> MdGenUserSections { get; set; }

    public virtual DbSet<MdGenUserSubsystemMenu> MdGenUserSubsystemMenus { get; set; }

    public virtual DbSet<MdGenZillaParisad> MdGenZillaParisads { get; set; }

    public virtual DbSet<MmGenBankArea> MmGenBankAreas { get; set; }

    public virtual DbSet<MmGenBankBranchIfsc> MmGenBankBranchIfscs { get; set; }

    public virtual DbSet<MmGenBankBranchMapping> MmGenBankBranchMappings { get; set; }

    public virtual DbSet<MmGenBankName> MmGenBankNames { get; set; }

    public virtual DbSet<MmGenBillSource> MmGenBillSources { get; set; }

    public virtual DbSet<MmGenBillType> MmGenBillTypes { get; set; }

    public virtual DbSet<MmGenChallanMajorhead> MmGenChallanMajorheads { get; set; }

    public virtual DbSet<MmGenDdo> MmGenDdos { get; set; }

    public virtual DbSet<MmGenDepartment> MmGenDepartments { get; set; }

    public virtual DbSet<MmGenDepositType> MmGenDepositTypes { get; set; }

    public virtual DbSet<MmGenDetailedHead> MmGenDetailedHeads { get; set; }

    public virtual DbSet<MmGenDistrict> MmGenDistricts { get; set; }

    public virtual DbSet<MmGenFinancialYear> MmGenFinancialYears { get; set; }

    public virtual DbSet<MmGenHoa> MmGenHoas { get; set; }

    public virtual DbSet<MmGenHrmsUserType> MmGenHrmsUserTypes { get; set; }

    public virtual DbSet<MmGenInTransferMaster> MmGenInTransferMasters { get; set; }

    public virtual DbSet<MmGenInstitution> MmGenInstitutions { get; set; }

    public virtual DbSet<MmGenInterestDateMaster> MmGenInterestDateMasters { get; set; }

    public virtual DbSet<MmGenInterestGenerationMaster> MmGenInterestGenerationMasters { get; set; }

    public virtual DbSet<MmGenInterestRateMaster> MmGenInterestRateMasters { get; set; }

    public virtual DbSet<MmGenLevelCode> MmGenLevelCodes { get; set; }

    public virtual DbSet<MmGenLevelCodeMap> MmGenLevelCodeMaps { get; set; }

    public virtual DbSet<MmGenMajorhead> MmGenMajorheads { get; set; }

    public virtual DbSet<MmGenMenu> MmGenMenus { get; set; }

    public virtual DbSet<MmGenNgipfOffice> MmGenNgipfOffices { get; set; }

    public virtual DbSet<MmGenPfmsCode> MmGenPfmsCodes { get; set; }

    public virtual DbSet<MmGenPlScheme> MmGenPlSchemes { get; set; }

    public virtual DbSet<MmGenPlanStatus> MmGenPlanStatuses { get; set; }

    public virtual DbSet<MmGenRole> MmGenRoles { get; set; }

    public virtual DbSet<MmGenSchemeCode> MmGenSchemeCodes { get; set; }

    public virtual DbSet<MmGenSchemeType> MmGenSchemeTypes { get; set; }

    public virtual DbSet<MmGenSection> MmGenSections { get; set; }

    public virtual DbSet<MmGenState> MmGenStates { get; set; }

    public virtual DbSet<MmGenSubclass> MmGenSubclasses { get; set; }

    public virtual DbSet<MmGenSubclassHoaMap> MmGenSubclassHoaMaps { get; set; }

    public virtual DbSet<MmGenSubsystem> MmGenSubsystems { get; set; }

    public virtual DbSet<MmGenTreasury> MmGenTreasuries { get; set; }

    public virtual DbSet<MmGenUser> MmGenUsers { get; set; }

    public virtual DbSet<MmGenUserType> MmGenUserTypes { get; set; }

    public virtual DbSet<MmPayBytransferHead> MmPayBytransferHeads { get; set; }

    public virtual DbSet<MmPayProcessingFlag> MmPayProcessingFlags { get; set; }

    public virtual DbSet<MmPenCategory> MmPenCategories { get; set; }

    public virtual DbSet<MmPenCertificateType> MmPenCertificateTypes { get; set; }

    public virtual DbSet<MmPenClassification> MmPenClassifications { get; set; }

    public virtual DbSet<MmPenNomineeType> MmPenNomineeTypes { get; set; }

    public virtual DbSet<MmPenPrimaryCategory> MmPenPrimaryCategories { get; set; }

    public virtual DbSet<MmPenSubCategory> MmPenSubCategories { get; set; }

    public virtual DbSet<OpeningBalanceType> OpeningBalanceTypes { get; set; }

    public virtual DbSet<PlPfDdoHoaMap> PlPfDdoHoaMaps { get; set; }

    public virtual DbSet<RecomandingAuthorityNatureCountMaster> RecomandingAuthorityNatureCountMasters { get; set; }

    public virtual DbSet<RecomandingAuthorityNatureMaster> RecomandingAuthorityNatureMasters { get; set; }

    public virtual DbSet<SancctionAuthorityNatureCountMaster> SancctionAuthorityNatureCountMasters { get; set; }

    public virtual DbSet<SancctionAuthorityNatureMaster> SancctionAuthorityNatureMasters { get; set; }

    public virtual DbSet<StakeHolderMapping> StakeHolderMappings { get; set; }

    public virtual DbSet<TMmGenPlOperator> TMmGenPlOperators { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5433;Database=ngipf;Username=postgres;Password=1234");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DeptHoaMapping>(entity =>
        {
            entity.HasKey(e => e.IntDeptHoaId).HasName("dept_hoa_mapping_pkey");

            entity.Property(e => e.IntDeptHoaId).ValueGeneratedNever();
            entity.Property(e => e.ActiveFlag).HasDefaultValueSql("'Y'::character varying");
            entity.Property(e => e.CreatedTimestamp).HasDefaultValueSql("CURRENT_TIMESTAMP(0)");
            entity.Property(e => e.ModifiedTimestamp).HasDefaultValueSql("CURRENT_TIMESTAMP(0)");
            entity.Property(e => e.ModifiedUserId).HasDefaultValueSql("0");
            entity.Property(e => e.UserId).HasDefaultValueSql("0");

            entity.HasOne(d => d.DeptCodeNavigation).WithMany(p => p.DeptHoaMappings)
                .HasPrincipalKey(p => p.DepartmentCode)
                .HasForeignKey(d => d.DeptCode)
                .HasConstraintName("fk_dept_hoa_mapping_department");

            entity.HasOne(d => d.IntScheme).WithMany(p => p.DeptHoaMappings).HasConstraintName("fk_dept_hoa_mapping_scheme");
        });

        modelBuilder.Entity<EmpArrearDtl>(entity =>
        {
            entity.HasKey(e => e.IntArrearDtlsId).HasName("pk_emp_arrear_dtls");

            entity.Property(e => e.ActiveFlag).HasDefaultValueSql("'N'::character varying");
            entity.Property(e => e.CreatedTimestamp).HasDefaultValueSql("CURRENT_TIMESTAMP");
            entity.Property(e => e.ModifiedTimestamp).HasDefaultValueSql("CURRENT_TIMESTAMP");

            entity.HasOne(d => d.IntEmployee).WithMany(p => p.EmpArrearDtls).HasConstraintName("fk_emp_arrear_dtls_ep");
        });

        modelBuilder.Entity<EmpOpeningBalanceAccpeted>(entity =>
        {
            entity.HasKey(e => new { e.IntEmployeeId, e.FinancialYear }).HasName("emp_opening_balance_accpeted_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("nextval('ngipf.emp_opening_balance_id_seq'::regclass)");

            entity.HasOne(d => d.FinancialYearNavigation).WithMany(p => p.EmpOpeningBalanceAccpeteds)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_emp_opening_balance_accpeted_finyeaar");

            entity.HasOne(d => d.IntEmployee).WithMany(p => p.EmpOpeningBalanceAccpeteds)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_emp_opening_balance_accpeted_ep");

            entity.HasOne(d => d.IntOperator).WithMany(p => p.EmpOpeningBalanceAccpeteds).HasConstraintName("fk_lf_pl_op_interest_credited_status_op_code");

            entity.HasOne(d => d.OpTypeNavigation).WithMany(p => p.EmpOpeningBalanceAccpeteds).HasConstraintName("fk_emp_opening_balance_accpeted_op_type");
        });

        modelBuilder.Entity<EmpOpeningBalanceRemark>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<EmpOpeningBalanceTemp>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("nextval('ngipf.emp_opening_balance_temmp_id_seq'::regclass)");

            entity.HasOne(d => d.IntEmployee).WithMany().HasConstraintName("fk_emp_opening_balance_temp_ep");
        });

        modelBuilder.Entity<EmpPfBasicDetail>(entity =>
        {
            entity.HasKey(e => e.IntEmployeeId).HasName("emp_pf_basic_details_pkey");

            entity.Property(e => e.IntEmployeeId).ValueGeneratedNever();
            entity.Property(e => e.EmpPfBasicDetailsId).ValueGeneratedOnAdd();

            entity.HasOne(d => d.IntDdo).WithMany(p => p.EmpPfBasicDetails).HasConstraintName("fk_emp_pf_basic_details_ddo");

            entity.HasOne(d => d.IntEmployeeIdOldNavigation).WithMany(p => p.EmpPfBasicDetails)
                .HasPrincipalKey(p => p.IntEmployeeIdOld)
                .HasForeignKey(d => d.IntEmployeeIdOld)
                .HasConstraintName("fk_emp_pf_basic_details_emp");

            entity.HasOne(d => d.IntOperator).WithMany(p => p.EmpPfBasicDetails).HasConstraintName("fk_emp_pf_basic_details_op_code");

            entity.HasOne(d => d.IntTreasuryCodeNavigation).WithMany(p => p.EmpPfBasicDetails)
                .HasPrincipalKey(p => p.IntTreasuryCode)
                .HasForeignKey(d => d.IntTreasuryCode)
                .HasConstraintName("fk_emp_pf_basic_details_trasury");
        });

        modelBuilder.Entity<EmpPfOfficeDetail>(entity =>
        {
            entity.HasKey(e => e.IntEmployeeId).HasName("emp_lfpl_details_pkey");

            entity.Property(e => e.IntEmployeeId).ValueGeneratedNever();
            entity.Property(e => e.EmpLfplDetailsId).HasDefaultValueSql("nextval('ngipf.emp_lfpl_details_emp_lfpl_details_id_seq'::regclass)");

            entity.HasOne(d => d.IntEmployee).WithOne(p => p.EmpPfOfficeDetail)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_emp_pf_office_details_emp");

            entity.HasOne(d => d.IntOperatorHeadOfOfficeNavigation).WithMany(p => p.EmpPfOfficeDetailIntOperatorHeadOfOfficeNavigations).HasConstraintName("fk_emp_pf_office_details_op_office");

            entity.HasOne(d => d.IntOperator).WithMany(p => p.EmpPfOfficeDetails).HasConstraintName("fk_emp_pf_office_details_op_code");

            entity.HasOne(d => d.IntRecHeadOfOffice).WithMany(p => p.EmpPfOfficeDetailIntRecHeadOfOffices).HasConstraintName("fk_emp_pf_office_details_re_office");

            entity.HasOne(d => d.IntSancHeadOfOffice).WithMany(p => p.EmpPfOfficeDetailIntSancHeadOfOffices).HasConstraintName("fk_emp_pf_office_details_san_office");
        });

        modelBuilder.Entity<EmpSubscription>(entity =>
        {
            entity.HasOne(d => d.IntEmployee).WithMany().HasConstraintName("fk_emp_subscription_ep");
        });

        modelBuilder.Entity<EmpWithdrawal>(entity =>
        {
            entity.HasOne(d => d.IntEmployee).WithMany().HasConstraintName("fk_emp_withdrawal_ep");
        });

        modelBuilder.Entity<HoaPlpfOperatorMap>(entity =>
        {
            entity.Property(e => e.ActiveFlag).HasDefaultValueSql("'y'::character varying");
            entity.Property(e => e.CreatedTimeStamp).HasDefaultValueSql("CURRENT_TIMESTAMP");

            entity.HasOne(d => d.DeptHoadMapping).WithMany().HasConstraintName("fk_hoa_plpf_operator_map_dept_hoa_mappin");

            entity.HasOne(d => d.Hoa).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_hoa_plpf_operator_map_hoa_id");

            entity.HasOne(d => d.IntOperator).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_hoa_plpf_operator_map_op_code");
        });

        modelBuilder.Entity<HrDetailsEmpStaging>(entity =>
        {
            entity.HasKey(e => e.IntEmpDetailsStagingId).HasName("hr_details_emp_staging_pkey");

            entity.Property(e => e.CreatedTimestamp).HasDefaultValueSql("CURRENT_TIMESTAMP(0)");
            entity.Property(e => e.CreatedUserId).HasDefaultValueSql("0");
            entity.Property(e => e.DmlStatusFlag).HasDefaultValueSql("0");
            entity.Property(e => e.ModifiedTimestamp).HasDefaultValueSql("CURRENT_TIMESTAMP(0)");
            entity.Property(e => e.ModifiedUserId).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<HrMdAppntDtlsSrvBook>(entity =>
        {
            entity.HasKey(e => e.IntAppntDtlsSrvBook).HasName("hr_md_appnt_dtls_srv_book_pkey");

            entity.HasOne(d => d.IntEmpWorkingDtls).WithMany(p => p.HrMdAppntDtlsSrvBooks).HasConstraintName("fk_hr_md_appnt_dtls_srv_book2");

            entity.HasOne(d => d.IntModeOfRecruitmentNavigation).WithMany(p => p.HrMdAppntDtlsSrvBookIntModeOfRecruitmentNavigations).HasConstraintName("fk_hr_md_appnt_dtls_srv_book4");

            entity.HasOne(d => d.IntOmiEmploymentTypeNavigation).WithMany(p => p.HrMdAppntDtlsSrvBookIntOmiEmploymentTypeNavigations).HasConstraintName("fk_hr_md_appnt_dtls_srv_book7");

            entity.HasOne(d => d.IntOmiSrvBookBlock).WithMany(p => p.HrMdAppntDtlsSrvBookIntOmiSrvBookBlocks).HasConstraintName("fk_hr_md_appnt_dtls_srv_book5");

            entity.HasOne(d => d.Request).WithMany(p => p.HrMdAppntDtlsSrvBooks).HasConstraintName("fk_hr_md_appnt_dtls_srv_book3");

            entity.HasOne(d => d.SrvBookRequestInitNavigation).WithMany(p => p.HrMdAppntDtlsSrvBooks).HasConstraintName("fk_hr_md_appnt_dtls_srv_book1");

            entity.HasOne(d => d.YearOfAllotmentNavigation).WithMany(p => p.HrMdAppntDtlsSrvBookYearOfAllotmentNavigations).HasConstraintName("fk_hr_md_appnt_dtls_srv_book6");
        });

        modelBuilder.Entity<HrMdConfDtlsSrvBook>(entity =>
        {
            entity.HasKey(e => e.IntConfDtlsSrvBook).HasName("pk_conf_dtls_srv_book");

            entity.HasOne(d => d.IntAppntDtlsSrvBookNavigation).WithMany(p => p.HrMdConfDtlsSrvBooks).HasConstraintName("fk_conf_dtls_srv_book5");

            entity.HasOne(d => d.IntEmpWorkingDtls).WithMany(p => p.HrMdConfDtlsSrvBooks).HasConstraintName("fk_conf_dtls_srv_book3");

            entity.HasOne(d => d.IntEmployee).WithMany(p => p.HrMdConfDtlsSrvBooks).HasConstraintName("fk_conf_dtls_srv_book2");

            entity.HasOne(d => d.Request).WithMany(p => p.HrMdConfDtlsSrvBooks).HasConstraintName("fk_conf_dtls_srv_book4");

            entity.HasOne(d => d.SrvBookRequestInitNavigation).WithMany(p => p.HrMdConfDtlsSrvBooks).HasConstraintName("fk_conf_dtls_srv_book1");
        });

        modelBuilder.Entity<HrMdEmpAddress>(entity =>
        {
            entity.HasKey(e => e.IntEmpAddrId).HasName("pk_hr_md_emp_address");

            entity.HasOne(d => d.Country).WithMany(p => p.HrMdEmpAddresses).HasConstraintName("fk_hr_md_emp_address6");

            entity.HasOne(d => d.IntDistrict).WithMany(p => p.HrMdEmpAddresses).HasConstraintName("fk_hr_md_emp_address3");

            entity.HasOne(d => d.IntEmployee).WithMany(p => p.HrMdEmpAddresses).HasConstraintName("fk_hr_md_emp_address1");

            entity.HasOne(d => d.Request).WithMany(p => p.HrMdEmpAddresses).HasConstraintName("fk_hr_md_emp_address5");

            entity.HasOne(d => d.State).WithMany(p => p.HrMdEmpAddresses).HasConstraintName("fk_hr_md_emp_address2");
        });

        modelBuilder.Entity<HrMdEmpAddressWf>(entity =>
        {
            entity.HasKey(e => e.IntEmpAddrIdWf).HasName("pk_hr_md_emp_address_wf");

            entity.HasOne(d => d.IntEmpAddr).WithMany(p => p.HrMdEmpAddressWfs).HasConstraintName("fk_hr_md_emp_address_wf_emp_addres_id");

            entity.HasOne(d => d.IntEmployee).WithMany(p => p.HrMdEmpAddressWfs).HasConstraintName("fk_hr_md_emp_address_wf1");
        });

        modelBuilder.Entity<HrMdEmpNomineeDtl>(entity =>
        {
            entity.HasKey(e => e.IntNomId).HasName("pk_hr_md_emp_nominee_dtl");

            entity.HasOne(d => d.IfscCodeNavigation).WithMany(p => p.HrMdEmpNomineeDtls).HasConstraintName("fk_hr_md_emp_nominee_dtl2");

            entity.HasOne(d => d.IntEmpRelationship).WithMany(p => p.HrMdEmpNomineeDtls).HasConstraintName("fk_hr_md_emp_nominee_dtl4");

            entity.HasOne(d => d.IntEmployee).WithMany(p => p.HrMdEmpNomineeDtls).HasConstraintName("fk_hr_md_emp_nominee_dtl");

            entity.HasOne(d => d.IntMaritalStatus).WithMany(p => p.HrMdEmpNomineeDtls).HasConstraintName("fk_hr_md_emp_nominee_dtl1");

            entity.HasOne(d => d.IntRelationAddr).WithMany(p => p.HrMdEmpNomineeDtls).HasConstraintName("fk_hr_md_emp_nominee_dtl5");

            entity.HasOne(d => d.OrgNomIdForAlternateNavigation).WithMany(p => p.InverseOrgNomIdForAlternateNavigation).HasConstraintName("fk_hr_md_emp_nominee_dtl6");
        });

        modelBuilder.Entity<HrMdEmpNomineeDtlWf>(entity =>
        {
            entity.HasKey(e => e.IntNomIdWf).HasName("pk_hr_md_emp_nominee_dtl_wf");

            entity.HasOne(d => d.IntEmployee).WithMany(p => p.HrMdEmpNomineeDtlWfs).HasConstraintName("pk_hr_md_emp_nominee_dtl_wf2");

            entity.HasOne(d => d.IntMaritalStatus).WithMany(p => p.HrMdEmpNomineeDtlWfIntMaritalStatuses).HasConstraintName("pk_hr_md_emp_nominee_dtl_wf3");

            entity.HasOne(d => d.NomIntOmiPhysicChallengedNavigation).WithMany(p => p.HrMdEmpNomineeDtlWfNomIntOmiPhysicChallengedNavigations).HasConstraintName("pk_hr_md_emp_nominee_dtl_wf1");
        });

        modelBuilder.Entity<HrMdEmpOtherDtl>(entity =>
        {
            entity.HasOne(d => d.IntEmployee).WithMany().HasConstraintName("fk_hr_md_emp_oth_con_dtls1");

            entity.HasOne(d => d.Request).WithMany().HasConstraintName("fk_hr_md_emp_oth_con_dtls3");
        });

        modelBuilder.Entity<HrMdEmpOtherDtlsSrvBook>(entity =>
        {
            entity.HasKey(e => e.IntEmpOtherDtlsSrvBookId).HasName("hr_md_emp_other_dtls_srv_book_pkey");

            entity.Property(e => e.IntEmpOtherDtlsSrvBookId).HasDefaultValueSql("nextval('ihrms_emp_master.hr_md_emp_other_dtls_srv_book_int_emp_other_dtls_srv_book_i_seq'::regclass)");
        });

        modelBuilder.Entity<HrMdEmpOtherDtlsWf>(entity =>
        {
            entity.HasOne(d => d.IntEmployee).WithMany().HasConstraintName("fk_hr_md_emp_other_dtls_wf2");

            entity.HasOne(d => d.Request).WithMany().HasConstraintName("fk_hr_md_emp_other_dtls_wf3");
        });

        modelBuilder.Entity<HrMdEmpPayAndAllowance>(entity =>
        {
            entity.HasKey(e => e.IntEmpPayAndAllowanceId).HasName("hr_md_emp_pay_and_allowance_pkey");

            entity.HasOne(d => d.IntComp).WithMany(p => p.HrMdEmpPayAndAllowances).HasConstraintName("fk_hr_md_emp_pay_and_allow2");

            entity.HasOne(d => d.IntEmpPayInformation).WithMany(p => p.HrMdEmpPayAndAllowances).HasConstraintName("fk_hr_md_emp_pay_and_allow9");

            entity.HasOne(d => d.IntEmployee).WithMany(p => p.HrMdEmpPayAndAllowances).HasConstraintName("fk_hr_md_emp_pay_and_allow1");

            entity.HasOne(d => d.IntOmiSrvBookBlock).WithMany(p => p.HrMdEmpPayAndAllowances).HasConstraintName("fk_hr_md_emp_pay_and_allow5");

            entity.HasOne(d => d.IntPayAllowDtlsSrvBookNavigation).WithMany(p => p.HrMdEmpPayAndAllowances).HasConstraintName("fk_hr_md_emp_pay_and_allow7");

            entity.HasOne(d => d.IntPayInfoDtlsSrvBookNavigation).WithMany(p => p.HrMdEmpPayAndAllowances).HasConstraintName("fk_hr_md_emp_pay_and_allow8");

            entity.HasOne(d => d.IntTdIncement).WithMany(p => p.HrMdEmpPayAndAllowances).HasConstraintName("fk_hr_md_emp_pay_and_allow12");

            entity.HasOne(d => d.IntTdPayfixDtl).WithMany(p => p.HrMdEmpPayAndAllowances).HasConstraintName("fk_hr_md_emp_pay_and_allow4");

            entity.HasOne(d => d.IntTmPayfix).WithMany(p => p.HrMdEmpPayAndAllowances).HasConstraintName("fk_hr_md_emp_pay_and_allow11");

            entity.HasOne(d => d.Request).WithMany(p => p.HrMdEmpPayAndAllowances).HasConstraintName("fk_hr_md_emp_pay_and_allow3");

            entity.HasOne(d => d.SrvBookRequestInitNavigation).WithMany(p => p.HrMdEmpPayAndAllowances).HasConstraintName("fk_hr_md_emp_pay_and_allow6");
        });

        modelBuilder.Entity<HrMdEmpPayAndAllownceWf>(entity =>
        {
            entity.HasKey(e => e.IntEmpPayAndAllowIdWf).HasName("hr_md_emp_pay_and_allownce_wf_pkey");

            entity.HasOne(d => d.IntComp).WithMany(p => p.HrMdEmpPayAndAllownceWfs).HasConstraintName("fk_hr_md_emp_pay_and_allow_wf2");

            entity.HasOne(d => d.IntEmployee).WithMany(p => p.HrMdEmpPayAndAllownceWfs).HasConstraintName("fk_hr_md_emp_pay_and_allow_wf1");

            entity.HasOne(d => d.Request).WithMany(p => p.HrMdEmpPayAndAllownceWfs).HasConstraintName("fk_hr_md_emp_pay_and_allow_wf3");
        });

        modelBuilder.Entity<HrMdEmpPayBenfInfo>(entity =>
        {
            entity.Property(e => e.IntEmpBenfId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrMdEmpPayBenfWf>(entity =>
        {
            entity.Property(e => e.IntEmpBenfIdWf).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrMdEmpPayInfoSrvBook>(entity =>
        {
            entity.HasKey(e => e.IntPayInfoSrvBookId).HasName("hr_md_emp_pay_info_srv_book_pkey");
        });

        modelBuilder.Entity<HrMdEmpPayInformation>(entity =>
        {
            entity.HasKey(e => e.IntEmpPayInformationId).HasName("hr_md_emp_pay_information_pkey");

            entity.Property(e => e.IntEmpPayInformationId).HasDefaultValueSql("nextval('ihrms_emp_master.hr_md_emp_pay_information_int_emp_pay_information_seq'::regclass)");

            entity.HasOne(d => d.IntEmployee).WithMany(p => p.HrMdEmpPayInformations).HasConstraintName("fk_hr_md_emp_pay_info_basic");

            entity.HasOne(d => d.IntGradePayIdObsNavigation).WithMany(p => p.HrMdEmpPayInformations).HasConstraintName("fk_hr_md_emp_pay_info_gradpay");

            entity.HasOne(d => d.IntOmiSrvBookBlock).WithMany(p => p.HrMdEmpPayInformations).HasConstraintName("fk_hr_md_emp_pay_info_srv_book_block_id");

            entity.HasOne(d => d.IntPayInfoDtlsSrvBookNavigation).WithMany(p => p.HrMdEmpPayInformations).HasConstraintName("fk_hr_md_emp_pay_info_pay_scale_s_book");

            entity.HasOne(d => d.IntPayInfoSrvBook).WithMany(p => p.HrMdEmpPayInformations).HasConstraintName("fk_hr_md_emp_pay_info_pay_info_s_book");

            entity.HasOne(d => d.IntPayScaleIdObsNavigation).WithMany(p => p.HrMdEmpPayInformations).HasConstraintName("fk_hr_md_emp_pay_info_pay_scale");

            entity.HasOne(d => d.IntPaybIdObsNavigation).WithMany(p => p.HrMdEmpPayInformations).HasConstraintName("fk_hr_md_emp_pay_info_payband");

            entity.HasOne(d => d.IntRevPayAllowance).WithMany(p => p.HrMdEmpPayInformations).HasConstraintName("fk_hr_md_emp_pay_info_rpay");

            entity.HasOne(d => d.Request).WithMany(p => p.HrMdEmpPayInformations).HasConstraintName("fk_hr_md_emp_pay_info_reuest_id");

            entity.HasOne(d => d.SrvBookRequestInitNavigation).WithMany(p => p.HrMdEmpPayInformations).HasConstraintName("fk_hr_md_emp_pay_info_sr_request");
        });

        modelBuilder.Entity<HrMdEmpPayInformationWf>(entity =>
        {
            entity.HasKey(e => e.IntEmpPayInformationIdWf).HasName("pk_hr_md_emp_pay_info_wf");

            entity.HasOne(d => d.IntEmployee).WithMany(p => p.HrMdEmpPayInformationWfs).HasConstraintName("fk_hr_md_emp_pay_info_wf");

            entity.HasOne(d => d.IntGradePayIdObsNavigation).WithMany(p => p.HrMdEmpPayInformationWfs).HasConstraintName("fk_hr_md_emp_pay_info_wf8");

            entity.HasOne(d => d.IntOmiSrvBookBlock).WithMany(p => p.HrMdEmpPayInformationWfs).HasConstraintName("fk_hr_md_emp_pay_info_wf9");

            entity.HasOne(d => d.IntPayInfoDtlsSrvBookNavigation).WithMany(p => p.HrMdEmpPayInformationWfs).HasConstraintName("fk_hr_md_emp_pay_info_wf12");

            entity.HasOne(d => d.IntPayInfoSrvBook).WithMany(p => p.HrMdEmpPayInformationWfs).HasConstraintName("fk_hr_md_emp_pay_info_wf11");

            entity.HasOne(d => d.IntPayScaleIdObsNavigation).WithMany(p => p.HrMdEmpPayInformationWfs).HasConstraintName("fk_hr_md_emp_pay_info_wf3");

            entity.HasOne(d => d.IntPaybIdObsNavigation).WithMany(p => p.HrMdEmpPayInformationWfs).HasConstraintName("fk_hr_md_emp_pay_info_wf2");

            entity.HasOne(d => d.IntRevPayAllowance).WithMany(p => p.HrMdEmpPayInformationWfs).HasConstraintName("fk_hr_md_emp_pay_info_wf1");

            entity.HasOne(d => d.Request).WithMany(p => p.HrMdEmpPayInformationWfs).HasConstraintName("fk_hr_md_emp_pay_info_wf5");

            entity.HasOne(d => d.SrvBookRequestInitNavigation).WithMany(p => p.HrMdEmpPayInformationWfs).HasConstraintName("fk_hr_md_emp_pay_info_wf10");
        });

        modelBuilder.Entity<HrMdEmpPayScaleBandInfo>(entity =>
        {
            entity.HasKey(e => e.IntEmpPayScaleBandInfo).HasName("hr_md_emp_pay_scale_band_info_pkey");
        });

        modelBuilder.Entity<HrMdEmpPayScaleBandWf>(entity =>
        {
            entity.Property(e => e.CreatedTimestamp).HasDefaultValueSql("CURRENT_TIMESTAMP(0)");
            entity.Property(e => e.CreatedUserId).HasDefaultValueSql("0");
            entity.Property(e => e.InsertedFlag).HasDefaultValueSql("'S'::character varying");
            entity.Property(e => e.IntEmpPayScaleBandWf).ValueGeneratedOnAdd();
            entity.Property(e => e.ModifiedTimestamp).HasDefaultValueSql("CURRENT_TIMESTAMP(0)");
            entity.Property(e => e.ModifiedUserId).HasDefaultValueSql("0");
        });

        modelBuilder.Entity<HrMdEmpQualifiSrvBook>(entity =>
        {
            entity.Property(e => e.IntEmpQualifiSrvBookId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrMdEmpQualification>(entity =>
        {
            entity.HasKey(e => e.IntEmpQualificationId).HasName("hr_md_emp_qualification_pkey");

            entity.HasOne(d => d.IntEmployee).WithMany(p => p.HrMdEmpQualifications).HasConstraintName("fk_hr_md_emp_qualification");

            entity.HasOne(d => d.IntQualification).WithMany(p => p.HrMdEmpQualifications).HasConstraintName("fk_hr_md_emp_qualification1");

            entity.HasOne(d => d.Request).WithMany(p => p.HrMdEmpQualifications).HasConstraintName("fk_hr_md_emp_qualification3");
        });

        modelBuilder.Entity<HrMdEmpQualificationWf>(entity =>
        {
            entity.Property(e => e.IntEmpQualificationIdWf).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrMdEmpRelationAddress>(entity =>
        {
            entity.HasKey(e => e.IntRelationAddrId).HasName("hr_md_emp_relation_address_pkey");
        });

        modelBuilder.Entity<HrMdEmpRelationAddressWf>(entity =>
        {
            entity.Property(e => e.IntRelationAddrIdWf).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrMdEmpRelationship>(entity =>
        {
            entity.HasKey(e => e.IntEmpRelationshipId).HasName("hr_md_emp_relationship_pkey");

            entity.HasOne(d => d.IntRelMaritialStatusNavigation).WithMany(p => p.HrMdEmpRelationshipIntRelMaritialStatusNavigations).HasConstraintName("fk_hr_md_emp_relationship5");

            entity.HasOne(d => d.RelIntOmiRelationshipNavigation).WithMany(p => p.HrMdEmpRelationshipRelIntOmiRelationshipNavigations).HasConstraintName("fk_hr_md_emp_relationship2");

            entity.HasOne(d => d.Request).WithMany(p => p.HrMdEmpRelationships).HasConstraintName("fk_hr_md_emp_relationship4");
        });

        modelBuilder.Entity<HrMdEmpRelationshipSrvBk>(entity =>
        {
            entity.Property(e => e.IntEmpRelationshipSrvBook).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrMdEmpRelationshipWf>(entity =>
        {
            entity.Property(e => e.IntEmpRelationshipIdWf).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrMdEmpSalaryHeadMap>(entity =>
        {
            entity.Property(e => e.IntEmpSalaryHeadMapId).ValueGeneratedOnAdd();

            entity.HasOne(d => d.IntDdoSalaryHeadMap).WithMany().HasConstraintName("fk_hr_md_emp_sal_head_map1");

            entity.HasOne(d => d.IntEmployee).WithMany().HasConstraintName("fk_hr_md_emp_sal_head_map2");

            entity.HasOne(d => d.Request).WithMany().HasConstraintName("fk_hr_md_emp_sal_head_map3");
        });

        modelBuilder.Entity<HrMdEmpSalaryHeadMapWf>(entity =>
        {
            entity.Property(e => e.IntEmpSalaryHeadMapIdWf).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrMdEmpSrvBookRequest>(entity =>
        {
            entity.Property(e => e.IntEmpSrvBookRequest).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrMdEmpWorkingDtl>(entity =>
        {
            entity.HasKey(e => e.IntEmpWorkingDtlsId).HasName("hr_md_emp_working_dtls_pkey");

            entity.HasOne(d => d.IntAppntDtlsSrvBookNavigation).WithMany(p => p.HrMdEmpWorkingDtls).HasConstraintName("fk_hr_md_emp_working_dtls10");

            entity.HasOne(d => d.IntEmployee).WithMany(p => p.HrMdEmpWorkingDtls).HasConstraintName("fk_hr_md_emp_working_dtls1");

            entity.HasOne(d => d.IntHeadOfOffice).WithMany(p => p.HrMdEmpWorkingDtls).HasConstraintName("fk_hr_md_emp_working_dtls4");

            entity.HasOne(d => d.IntOmiNatureOfReleaseNavigation).WithMany(p => p.HrMdEmpWorkingDtlIntOmiNatureOfReleaseNavigations).HasConstraintName("fk_hr_md_emp_working_dtls7");

            entity.HasOne(d => d.IntOmiSrvBookBlock).WithMany(p => p.HrMdEmpWorkingDtlIntOmiSrvBookBlocks).HasConstraintName("fk_hr_md_emp_working_dtls11");

            entity.HasOne(d => d.IntPostDtlsSrvBookNavigation).WithMany(p => p.HrMdEmpWorkingDtls).HasConstraintName("fk_hr_md_emp_working_dtls6");

            entity.HasOne(d => d.PrevIntEmpWorkingDtls).WithMany(p => p.InversePrevIntEmpWorkingDtls).HasConstraintName("fk_hr_md_emp_working_dtls2");

            entity.HasOne(d => d.Request).WithMany(p => p.HrMdEmpWorkingDtls).HasConstraintName("fk_hr_md_emp_working_dtls3");
        });

        modelBuilder.Entity<HrMdEmpWorkingDtlsWf>(entity =>
        {
            entity.Property(e => e.IntEmpWorkingDtlsIdWf).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrMdGenDdoSalaryHeadMap>(entity =>
        {
            entity.HasKey(e => e.IntDdoSalaryHeadMapId).HasName("hr_md_gen_ddo_salary_head_map_pkey");

            entity.HasOne(d => d.IntDdo).WithMany(p => p.HrMdGenDdoSalaryHeadMaps).HasConstraintName("fk_ihrms_master.hr_md_gen_ddo_salary_head_map_ddo");
        });

        modelBuilder.Entity<HrMdPayAllowanceSrvBook>(entity =>
        {
            entity.HasKey(e => e.IntPayAllowDtlsSrvBook).HasName("hr_md_pay_allowance_srv_book_pkey");
        });

        modelBuilder.Entity<HrMdPayScaleBandSrvBook>(entity =>
        {
            entity.HasKey(e => e.IntPayInfoDtlsSrvBook).HasName("hr_md_pay_scale_band_srv_book_pkey");
        });

        modelBuilder.Entity<HrMdPostDtlsSrvBook>(entity =>
        {
            entity.HasKey(e => e.IntPostDtlsSrvBook).HasName("hr_md_post_dtls_srv_book_pkey");
        });

        modelBuilder.Entity<HrMmEmpBasicDtl>(entity =>
        {
            entity.HasKey(e => e.IntEmployeeId).HasName("pk_tm_sr_emp_basic_dtls");

            entity.HasOne(d => d.EmpIntOmiCastNavigation).WithMany(p => p.HrMmEmpBasicDtlEmpIntOmiCastNavigations).HasConstraintName("fk_tm_sr_emp_basic_dtls2");

            entity.HasOne(d => d.EmpIntOmiGenderNavigation).WithMany(p => p.HrMmEmpBasicDtlEmpIntOmiGenderNavigations).HasConstraintName("fk_tm_sr_emp_basic_dtls1");

            entity.HasOne(d => d.EmpIntOmiInitialsNavigation).WithMany(p => p.HrMmEmpBasicDtlEmpIntOmiInitialsNavigations).HasConstraintName("fk_tm_sr_emp_basic_dtls");

            entity.HasOne(d => d.EmpIntOmiNationalityNavigation).WithMany(p => p.HrMmEmpBasicDtlEmpIntOmiNationalityNavigations).HasConstraintName("fk_tm_sr_emp_basic_dtls3");

            entity.HasOne(d => d.EmpIntOmiPhysicChallengedNavigation).WithMany(p => p.HrMmEmpBasicDtlEmpIntOmiPhysicChallengedNavigations).HasConstraintName("fk_tm_sr_emp_basic_dtls8");

            entity.HasOne(d => d.EmpIntOmiReligionNavigation).WithMany(p => p.HrMmEmpBasicDtlEmpIntOmiReligionNavigations).HasConstraintName("fk_tm_sr_emp_basic_dtls7");

            entity.HasOne(d => d.IntEmpDetailsStaging).WithMany(p => p.HrMmEmpBasicDtls).HasConstraintName("fk_tm_sr_emp_basic_dtls15");

            entity.HasOne(d => d.IntEmpOmiHeightUnitNavigation).WithMany(p => p.HrMmEmpBasicDtlIntEmpOmiHeightUnitNavigations).HasConstraintName("fk_tm_sr_emp_basic_dtls16");
        });

        modelBuilder.Entity<HrMmGenComponent>(entity =>
        {
            entity.HasKey(e => e.IntCompId).HasName("hr_mm_gen_component_pkey");
        });

        modelBuilder.Entity<HrMmGenCountry>(entity =>
        {
            entity.HasKey(e => e.CountryId).HasName("hr_mm_gen_country_pkey");

            entity.Property(e => e.CountryId).ValueGeneratedNever();
        });

        modelBuilder.Entity<HrMmGenGradePay>(entity =>
        {
            entity.HasKey(e => e.IntGradePayId).HasName("hr_mm_gen_grade_pay_pkey");
        });

        modelBuilder.Entity<HrMmGenHeadOfOffice>(entity =>
        {
            entity.HasKey(e => e.IntHeadOfOfficeId).HasName("hr_mm_gen_head_of_office_pkey");
        });

        modelBuilder.Entity<HrMmGenOtherMaster>(entity =>
        {
            entity.HasKey(e => e.IntOtherMasterId).HasName("hr_mm_gen_other_master_pkey");
        });

        modelBuilder.Entity<HrMmGenPayBand>(entity =>
        {
            entity.HasKey(e => e.IntPaybId).HasName("hr_mm_gen_pay_band_pkey");
        });

        modelBuilder.Entity<HrMmGenPayScale>(entity =>
        {
            entity.HasKey(e => e.IntPayScaleId).HasName("hr_mm_gen_pay_scale_pkey");
        });

        modelBuilder.Entity<HrMmGenQualification>(entity =>
        {
            entity.HasKey(e => e.IntQualificationId).HasName("hr_mm_gen_qualification_pkey");
        });

        modelBuilder.Entity<HrMmGenRevPayAllwOrder>(entity =>
        {
            entity.HasKey(e => e.IntRevPayAllowanceId).HasName("hr_mm_gen_rev_pay_allw_order_pkey");
        });

        modelBuilder.Entity<HrMmGenWorkflowMaster>(entity =>
        {
            entity.HasKey(e => e.RequestId).HasName("pk_hr_mm_gen_workflow_master1");

            entity.Property(e => e.RequestId).ValueGeneratedNever();
        });

        modelBuilder.Entity<HrTdEmpIncrement>(entity =>
        {
            entity.HasKey(e => e.IntTdIncementId).HasName("hr_td_emp_increment_pkey");
        });

        modelBuilder.Entity<HrTdPayfix>(entity =>
        {
            entity.HasKey(e => e.IntTdPayfixId).HasName("hr_td_payfix_pkey");
        });

        modelBuilder.Entity<HrTdPayfixDtl>(entity =>
        {
            entity.HasKey(e => e.IntTdPayfixDtlId).HasName("hr_td_payfix_dtl_pkey");
        });

        modelBuilder.Entity<HrTmPayfix>(entity =>
        {
            entity.HasKey(e => e.IntTmPayfixId).HasName("hr_tm_payfix_pkey");

            entity.Property(e => e.CreatedTimestamp).HasDefaultValueSql("CURRENT_TIMESTAMP(0)");
            entity.Property(e => e.ModifiedTimestamp).HasDefaultValueSql("CURRENT_TIMESTAMP(0)");
        });

        modelBuilder.Entity<HrTmSrvBookRequestInit>(entity =>
        {
            entity.HasKey(e => e.SrvBookRequestInit).HasName("hr_tm_srv_book_request_init_pkey");
        });

        modelBuilder.Entity<LfPlInterestCreditedBillDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("lf_pl_interest_credited_bill_details_pkey");

            entity.HasOne(d => d.IntBillSourceNavigation).WithMany(p => p.LfPlInterestCreditedBillDetails).HasConstraintName("fk_lf_pl_interest_credited_bill_details_bill_source");
        });

        modelBuilder.Entity<LfPlOpBalancePermissionStatusMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("lf_pl_op_balance_permission_status_master_pkey");
        });

        modelBuilder.Entity<LfPlOpInterestCreditedStatus>(entity =>
        {
            entity.HasKey(e => new { e.IntOperatorId, e.FinancialYearCodeUpto }).HasName("lf_pl_op_interest_credited_status_pkey");

            entity.Property(e => e.Id).HasDefaultValueSql("nextval('ngipf.lf_pl_op_reconciliation_status_id_seq'::regclass)");

            entity.HasOne(d => d.FinancialYearCodeUptoNavigation).WithMany(p => p.LfPlOpInterestCreditedStatuses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_lf_pl_op_interest_credited_status_year_code");

            entity.HasOne(d => d.InTransferCodeNavigation).WithMany(p => p.LfPlOpInterestCreditedStatuses).HasConstraintName("fk_lf_pl_op_interest_credited_status_in_transfer_code");

            entity.HasOne(d => d.IntBillNoNavigation).WithMany(p => p.LfPlOpInterestCreditedStatuses).HasConstraintName("fk_lf_pl_op_interest_credited_status_bill");

            entity.HasOne(d => d.IntOperator).WithMany(p => p.LfPlOpInterestCreditedStatuses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_lf_pl_op_interest_credited_status_op_code");
        });

        modelBuilder.Entity<LfPlOpInterestDateException>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.IntOperator).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_lf_pl_op_interest_date_exception_op_code");
        });

        modelBuilder.Entity<LfPlOpInterestGenerationList>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("nextval('ngipf.lf_pl_op_interest_generation_master_id_seq'::regclass)");

            entity.HasOne(d => d.IntGenerationTypeNavigation).WithMany().HasConstraintName("fk_lf_pl_op_interest_generation_list_generation_type");

            entity.HasOne(d => d.IntOperator).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_lf_pl_op_interest_generation_master_op_code");
        });

        modelBuilder.Entity<LfPlOpInterestRateException>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.IntOperator).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_lf_pl_op_interest_rate_exception_op_code");
        });

        modelBuilder.Entity<LfPlOpOpeningBalancePermissionStatus>(entity =>
        {
            entity.HasKey(e => e.IntOperatorId).HasName("lf_pl_op_opening_balance_permission_status_pkey");

            entity.Property(e => e.IntOperatorId).ValueGeneratedNever();
            entity.Property(e => e.Id).HasDefaultValueSql("nextval('ngipf.lf_pl_op_permission_status_id_seq'::regclass)");

            entity.HasOne(d => d.IntOperator).WithOne(p => p.LfPlOpOpeningBalancePermissionStatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_lf_pl_op_permission_status_op_code");

            entity.HasOne(d => d.PermissionTypeNavigation).WithMany(p => p.LfPlOpOpeningBalancePermissionStatuses).HasConstraintName("fk_lf_pl_op_permission_status_permission_type");
        });

        modelBuilder.Entity<LfPlOpReconciliationStatus>(entity =>
        {
            entity.HasKey(e => e.IntOperatorId).HasName("lf_pl_op_reconciliation_status_pkey");

            entity.Property(e => e.IntOperatorId).ValueGeneratedNever();
            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.IntOperator).WithOne(p => p.LfPlOpReconciliationStatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_lf_pl_op_reconciliation_status_op_code");
        });

        modelBuilder.Entity<MdGenBcoHoaMap>(entity =>
        {
            entity.HasKey(e => e.IntHoaMapId).HasName("md_gen_bco_hoa_map_pkey");

            entity.Property(e => e.IntHoaMapId).ValueGeneratedNever();
        });

        modelBuilder.Entity<MdGenBillType>(entity =>
        {
            entity.HasKey(e => e.IntBillTypeId).HasName("md_gen_bill_type_pkey");

            entity.Property(e => e.IntBillTypeId).ValueGeneratedNever();
        });

        modelBuilder.Entity<MdGenBlock>(entity =>
        {
            entity.HasKey(e => e.IntBlockId).HasName("md_gen_block_pkey");
        });

        modelBuilder.Entity<MdGenDdoSection>(entity =>
        {
            entity.HasKey(e => new { e.IntDdoId, e.SectionCode, e.EffectiveFrom }).HasName("md_gen_ddo_section_pkey");
        });

        modelBuilder.Entity<MdGenDepartment>(entity =>
        {
            entity.Property(e => e.IntDeptId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MdGenIntraBcoMap>(entity =>
        {
            entity.HasKey(e => new { e.BcoCode, e.MapBcoCode }).HasName("md_gen_intra_bco_map_pkey");
        });

        modelBuilder.Entity<MdGenLevelCode>(entity =>
        {
            entity.HasKey(e => e.BcoCode).HasName("md_gen_level_code_pkey");
        });

        modelBuilder.Entity<MdGenMinorhead>(entity =>
        {
            entity.HasKey(e => new { e.MajorHead, e.SubmajorHead, e.MinorHead }).HasName("md_gen_minorhead_pkey");
        });

        modelBuilder.Entity<MdGenModuleRoleMap>(entity =>
        {
            entity.HasKey(e => e.MdGenModuleRoleMapId).HasName("md_gen_module_role_map_pkey");
        });

        modelBuilder.Entity<MdGenPanchayat>(entity =>
        {
            entity.HasKey(e => e.IntGpId).HasName("md_gen_panchayat_pkey");
        });

        modelBuilder.Entity<MdGenRoleMenu>(entity =>
        {
            entity.HasKey(e => new { e.RoleId, e.MenuId }).HasName("md_gen_role_menu_pkey");
        });

        modelBuilder.Entity<MdGenSchemeHead>(entity =>
        {
            entity.HasKey(e => e.IntSchemeId).HasName("md_gen_scheme_head_pkey");

            entity.Property(e => e.IntSchemeId).ValueGeneratedNever();
        });

        modelBuilder.Entity<MdGenSubdetailedHead>(entity =>
        {
            entity.HasKey(e => new { e.DetailedHead, e.SubdetailedHead }).HasName("md_gen_subdetailed_head_pkey");
        });

        modelBuilder.Entity<MdGenSubmajorhead>(entity =>
        {
            entity.HasKey(e => new { e.MajorHead, e.SubmajorHead }).HasName("md_gen_submajorhead_pkey");
        });

        modelBuilder.Entity<MdGenSubsysModMap>(entity =>
        {
            entity.HasKey(e => new { e.IntRfpSubsysId, e.IntSubsystemId }).HasName("md_gen_subsys_mod_map_pkey");
        });

        modelBuilder.Entity<MdGenUserRole>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.RoleId, e.SubSystemId }).HasName("md_gen_user_role_pkey");
        });

        modelBuilder.Entity<MmGenBankBranchIfsc>(entity =>
        {
            entity.HasKey(e => e.IfscCode).HasName("mm_gen_bank_branch_ifsc_pkey");
        });

        modelBuilder.Entity<MmGenBillSource>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mm_gen_bill_source_pkey");
        });

        modelBuilder.Entity<MmGenDdo>(entity =>
        {
            entity.HasKey(e => e.IntDdoId).HasName("mm_gen_ddo_pkey");

            entity.Property(e => e.IntDdoId).ValueGeneratedNever();

            entity.HasOne(d => d.IntTreasuryCodeNavigation).WithMany(p => p.MmGenDdos)
                .HasPrincipalKey(p => p.IntTreasuryCode)
                .HasForeignKey(d => d.IntTreasuryCode)
                .HasConstraintName("fk_mm_gen_ddo_tresuary");
        });

        modelBuilder.Entity<MmGenDepartment>(entity =>
        {
            entity.HasKey(e => e.IntDeptId).HasName("mm_gen_department_pkey");

            entity.Property(e => e.IntDeptId).ValueGeneratedNever();
        });

        modelBuilder.Entity<MmGenDistrict>(entity =>
        {
            entity.HasKey(e => e.IntDistrictId).HasName("mm_gen_district_pkey");

            entity.Property(e => e.IntDistrictId).ValueGeneratedNever();
        });

        modelBuilder.Entity<MmGenFinancialYear>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mm_gen_financial_year_pkey");
        });

        modelBuilder.Entity<MmGenHoa>(entity =>
        {
            entity.HasKey(e => e.HoaId).HasName("mm_gen_hoa_pkey");
        });

        modelBuilder.Entity<MmGenInTransferMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mm_gen_in_transfer_master_pkey");
        });

        modelBuilder.Entity<MmGenInterestDateMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mm_gen_interest_date_master_pkey");
        });

        modelBuilder.Entity<MmGenInterestGenerationMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mm_gen_interest_generation_master_pkey");
        });

        modelBuilder.Entity<MmGenInterestRateMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mm_gen_interest_rate_master_pkey");
        });

        modelBuilder.Entity<MmGenMajorhead>(entity =>
        {
            entity.HasKey(e => e.MajorHead).HasName("mm_gen_majorhead_pkey");
        });

        modelBuilder.Entity<MmGenNgipfOffice>(entity =>
        {
            entity.HasKey(e => e.IntGenNgipfOfficeId).HasName("mm_gen_ngipf_office_pkey");

            entity.HasOne(d => d.IntHeadOfOffice).WithMany(p => p.MmGenNgipfOffices).HasConstraintName("fk_mm_gen_ngipf_office_office_id");

            entity.HasOne(d => d.IntPlOperator).WithMany(p => p.MmGenNgipfOffices).HasConstraintName("fk_mm_gen_ngipf_office_lfpl");
        });

        modelBuilder.Entity<MmGenState>(entity =>
        {
            entity.HasKey(e => e.StateId).HasName("mm_gen_state_pkey");

            entity.Property(e => e.StateId).ValueGeneratedNever();
        });

        modelBuilder.Entity<MmGenTreasury>(entity =>
        {
            entity.HasKey(e => e.IntTreasuryId).HasName("mm_gen_treasury_pkey");

            entity.Property(e => e.IntTreasuryId).ValueGeneratedNever();
        });

        modelBuilder.Entity<OpeningBalanceType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("opening_balance_type_pkey");
        });

        modelBuilder.Entity<PlPfDdoHoaMap>(entity =>
        {
            entity.HasKey(e => e.IntPlPfDdoMapOld).HasName("pk_hr_mm_gen_pl_pf_ddo_map");

            entity.Property(e => e.ActiveFlag).HasDefaultValueSql("'y'::character varying");
            entity.Property(e => e.CreatedTimeStamp).HasDefaultValueSql("CURRENT_TIMESTAMP");

            entity.HasOne(d => d.Hoa).WithMany(p => p.PlPfDdoHoaMaps)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pl_pf_ddo_hoa_map_hoa");

            entity.HasOne(d => d.IntDdo).WithMany(p => p.PlPfDdoHoaMaps)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pl_pf_ddo_hoa_map_ddo");

            entity.HasOne(d => d.IntOperator).WithMany(p => p.PlPfDdoHoaMaps)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pl_pf_ddo_hoa_map_op_code");
        });

        modelBuilder.Entity<RecomandingAuthorityNatureCountMaster>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("recomanding_authority_nature_count_master_pkey");
        });

        modelBuilder.Entity<RecomandingAuthorityNatureMaster>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("recomanding_authority_nature_master_pkey");
        });

        modelBuilder.Entity<SancctionAuthorityNatureCountMaster>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("sancction_authority_nature_count_master_pkey");
        });

        modelBuilder.Entity<SancctionAuthorityNatureMaster>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("sancction_authority_nature_master_pkey");
        });

        modelBuilder.Entity<StakeHolderMapping>(entity =>
        {
            entity.Property(e => e.IntStakeHolderMapping).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TMmGenPlOperator>(entity =>
        {
            entity.HasKey(e => e.IntPlOperatorId).HasName("t_mm_gen_pl_operator_pkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
