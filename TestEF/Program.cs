using Microsoft.EntityFrameworkCore;
using TESTEF;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// builder.Services.AddDbContext<TestSimpleDbContext>(otp =>{
//     otp.UseSqlServer(builder.Configuration.GetConnectionString("local"));
// });

builder.Services.AddDbContextPool<TestIdentityDbContext>(opt =>{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("local"));
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.Run();
