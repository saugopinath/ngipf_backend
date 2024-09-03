namespace ngipf_backend.DTOs
{
    public class EmpDTO
    {
        
         public EmpPersonalDTO    EmpPersonal { get; set; }
         public EmpServiceDTO     EmpService { get; set; }
         public EmpAddressDTO     EmpAddress { get; set; }
         public EmpSalaryDTO      EmpSalary { get; set; }
         public EmpOfficeDTO      EmpOffice { get; set; }
         public EmpLFOperatorDTO  EmpLFOperator { get; set; }
         public EmpDdoDTO         EmpDdo { get; set; }
         public EmpBankDTO        EmpBank { get; set; }
    }
}
