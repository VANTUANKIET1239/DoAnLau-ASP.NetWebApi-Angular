using DoAnLau_API.Data;
using DoAnLau_API.Interface;
using DoAnLau_API.Responsitory;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//automapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
// responsitory
builder.Services.AddScoped<IAccountResponsitory, AccountResponsitory>();
builder.Services.AddScoped<IMenuResponsitory, MenuResponsitory>();
builder.Services.AddScoped<IMenuCategoryResponsitory, MenuCategoryResponsitory>();
builder.Services.AddScoped<IPageResponsitory, PageResponsitory>();

// khởi tạo service Indentity
builder.Services.AddIdentity<ApplicationUser, IdentityRole>(
    options =>
   options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789 -._@+!*'(),"
    )
    .AddEntityFrameworkStores<DataContext>().AddDefaultTokenProviders();    

// khởi tạo service Authentication
builder.Services.AddAuthentication(options => {
    // khi yêu cầu xác thực thành công 
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    // khi có yêu cầu xác thực 
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    // khi có những yêu cầu không đòi hỏi xác thực 
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options => {
    options.SaveToken = true;
    options.RequireHttpsMetadata = false;
    options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidAudience = builder.Configuration["JWT:ValidAudience"],
        ValidIssuer = builder.Configuration["JWT:ValidIssuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Secret"]))
    };
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngularOrigins",
    builder =>
    {
        builder.WithOrigins(
                            "http://localhost:4200"
                            )
                            .AllowAnyHeader()
                            .AllowAnyMethod();
    });
});

builder.Services.AddDbContext<DataContext>(options =>

    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

var app = builder.Build();
app.UseCors("AllowAngularOrigins");
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
