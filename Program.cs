using Microsoft.EntityFrameworkCore;
using ngipf_backend.DAL;
using ngipf_backend.DAL.Interfaces;
using ngipf_backend.BAL.Interfaces;
using ngipf_backend.BAL;
using ngipf_backend.Middlewares;
using ngipf_backend.Helper.Authentication;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerUI;
using Microsoft.Extensions.FileProviders;
using Microsoft.AspNetCore.Mvc;
using ngipf_backend.Enum;
using ngipf_backend.Helper;
using System.Collections;
using ngipf_backend.DAL.Repositories.main_master;

var builder = WebApplication.CreateBuilder(args);

//Database Connection
builder.Services.AddDbContext<NgIpfDBContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DBConnection"),
    //options => options.CommandTimeout(999)                   
    options => options.EnableRetryOnFailure(10, TimeSpan.FromSeconds(5), null)
), ServiceLifetime.Transient);

//Automapper
builder.Services.AddAutoMapper(typeof(Program));

// Add services to the container.
//Repositories
builder.Services.AddTransient<ITreasuryRepository, TreasuryRepository>();
builder.Services.AddTransient<ILfplopRepository, LfplopRepository>();
builder.Services.AddTransient<INgipfOfficeRepository, NgipfOfficeRepository>();
builder.Services.AddTransient<IHoaRepository, HoaRepository>();
builder.Services.AddTransient<IDdoRepository, DdoRepository>();
builder.Services.AddTransient<IEmpPfBasicRepository, EmpPfBasicRepository>();
builder.Services.AddTransient<IStakeHolderMappingExceptionRepository, StakeHolderMappingExceptionRepository>();
builder.Services.AddTransient<IStakeHolderMappingRepository, StakeHolderMappingRepository>();
builder.Services.AddTransient<IWorkflowFuncTypeRepository, WorkflowFuncTypeRepository>();
builder.Services.AddTransient<IWorkflowOfficeTypeRepository, WorkflowOfficeTypeRepository>();
builder.Services.AddTransient<IWorkflowMasterCodeRepository, WorkflowMasterCodeRepository>();
builder.Services.AddTransient<ILfplDdoMapRepository, LfplDdoMapRepository>();
builder.Services.AddTransient<IWorkflowUserMappingRepository, WorkflowUserMappingRepository>();
builder.Services.AddTransient<IStatusMasterRepository, StatusMasterRepository>();

//Services

builder.Services.AddTransient<ITreasuryService, TreasuryService>();
builder.Services.AddTransient<ILfplopService, LfplopService>();
builder.Services.AddTransient<INgipfOfficeService, NgipfOfficeService>();
builder.Services.AddTransient<IHoaService, HoaService>();
builder.Services.AddTransient<IDdoService, DdoService>();
builder.Services.AddTransient<IEmpPfBasicService, EmpPfBasicService>();
builder.Services.AddTransient<IStakeHolderMappingExceptionService, StakeHolderMappingExceptionService>();
builder.Services.AddTransient<IStakeHolderMappingService, StakeHolderMappingService>();
builder.Services.AddTransient<IWorkflowFuncTypeService, WorkflowFuncTypeService>();
builder.Services.AddTransient<IWorkflowOfficeTypeService, WorkflowOfficeTypeService>();
builder.Services.AddTransient<IWorkflowMasterCodeService, WorkflowMasterCodeService>();
builder.Services.AddTransient<ILfplDdoMapService, LfplDdoMapService>();
builder.Services.AddTransient<IWorkflowUserMappingService, WorkflowUserMappingService>();
builder.Services.AddTransient<IStatusMasterService, StatusMasterService>();


builder.Services.AddTransient<ITokenHelper, TokenHelper>();
builder.Services.AddSingleton<ITokencache, Tokencache>();

builder.Services.AddTransient<IClaimService, ClaimService>();


//builder.Services.AddTransient<ITokenHelper, TokenHelper>();
//builder.Services.AddSingleton<ITokencache, Tokencache>();

//builder.Services.AddTransient<ISixLaborsCaptchaModule, SixLaborsCaptchaModule>();
//builder.Services.AddSixLabCaptcha(x =>
//{
//    // x.FontFamilies = new string[] { "Marlboro" };
//    x.DrawLines = 3;
//    x.FontSize = 35;
//    x.Width = 150;  
//    x.Height = 50;
//    x.NoiseRate = 500;
//});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen(c =>
{
   c.SwaggerDoc("v1", new OpenApiInfo { Title = "Test01", Version = "v1" });

   c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
   {
       Name = "Authorization",
       Type = SecuritySchemeType.ApiKey,
       Scheme = "Bearer",
       BearerFormat = "JWT",
       In = ParameterLocation.Header,
       Description = "JWT Authorization header using the Bearer scheme."

   });
   c.AddSecurityRequirement(new OpenApiSecurityRequirement
               {
                   {
                         new OpenApiSecurityScheme
                         {
                             Reference = new OpenApiReference
                             {
                                 Type = ReferenceType.SecurityScheme,
                                 Id = "Bearer"
                             }
                         },
                        new string[] {}
                   }
               });
});

builder.Services.AddHttpContextAccessor();
builder.Services.Configure<ApiBehaviorOptions>(config =>
{

    config.InvalidModelStateResponseFactory = ctx => new OkObjectResult(new APIResponse<IEnumerable>()
    {
        apiResponseStatus = APIResponseStatus.Error,
        result = ctx.ModelState.Values,
        Message = "DTO validation error :: result field specifies error location." + ctx.ModelState.Values
    }


  // new BaseResponse(
  // success: ctx.ModelState.IsValid,
  // errors: ctx.ModelState.Values
  //     .Where(v => v.ValidationState == ModelValidationState.Invalid)
  //     .SelectMany(v => v.Errors)
  //     .Select(e => new ErrorDetails
  //     {
  //         Code = "ModelError",
  //         Description = e.ErrorMessage
  //     })
  //     .ToList()
  // )

            );
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.EnableFilter();
        options.EnablePersistAuthorization();
        options.EnableValidator();
        options.EnableDeepLinking();
        options.DisplayRequestDuration();
        options.ShowExtensions();
        options.DocExpansion(DocExpansion.None);
    });
}
app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
app.UseHttpsRedirection();

app.UseAuthorization();
app.UseStaticFiles();
app.UseDirectoryBrowser(new DirectoryBrowserOptions
{
    FileProvider = new PhysicalFileProvider(
        Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads")),
    RequestPath = "/uploads"
});

app.UseAuthTokenMiddleware();

app.MapControllers();

app.Run();
