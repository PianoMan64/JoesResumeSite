using JoeResumeWebsite.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddRazorPages();
builder.Services.AddScoped<IResumeContentService, ResumeContentService>();

var app = builder.Build();

// Configure pipeline for static generation
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapRazorPages();
app.MapFallbackToPage("/Index");

app.Run();
