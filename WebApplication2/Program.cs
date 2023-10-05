using FileBaseContext.Abstractions.Models.FileContext;
using FileBaseContext.Context.Models.Configurations;

var builder = WebApplication.CreateBuilder(args);

var fileOptions = new FileContextOptions<AppFileContext>(Path.Combine(builder.Environment.ContentRootPath, "Data", "DataStorage"));

builder.Services.AddSingleton<IFileContextOptions<IFileContext>>(fileOptions);














