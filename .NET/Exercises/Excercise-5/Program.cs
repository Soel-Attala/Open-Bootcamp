//1. Usings to work with EntityFramework
using Microsoft.EntityFrameworkCore;
using Excercise_5.DataAccess;
using Excercise_5.Services;

var builder = WebApplication.CreateBuilder(args);

//2. Conection with database: SQL Server Express
const string CONNECTIONNAME = "ExcerciseDB";
var connectionString = builder.Configuration.GetConnectionString(CONNECTIONNAME);

// 3.  Add context 
builder.Services.AddDbContext<ExcerciseContext>(options => options.UseSqlServer(connectionString));




//4. Add services to the container.
builder.Services.AddControllers();

//4. Add custom services
builder.Services.AddScoped<IStudentServices, StudentService>();
builder.Services.AddScoped<ICourseService, CourseService>();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//5.CORS configuration
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "CorsPolicy", builder =>
    {
        builder.AllowAnyOrigin();
        builder.AllowAnyMethod();
        builder.AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

//6. Tell app to use CORS
app.UseCors("CorsPolicy");

app.Run();
