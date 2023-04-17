using Exam_3.Entities;
using Exam_3.Services;
using Microsoft.EntityFrameworkCore;
using OpenIddict.Validation.AspNetCore;
using Microsoft.AspNetCore.DataProtection;
using static OpenIddict.Abstractions.OpenIddictConstants;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddRazorPages();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContextPool<AppDbContext>(Q =>
{
    Q.UseSqlite("Data Source=local.db");
    Q.UseOpenIddict();
});

builder.Services.AddAuthentication()
    .AddCookie(options =>
    {
        options.LoginPath = "/Auth/SignIn";
        options.LogoutPath = "/connect/logout";
    });

builder.Services.AddAuthorization(options => {
    options.AddPolicy("api", p =>
    {
        p.AddAuthenticationSchemes(OpenIddictValidationAspNetCoreDefaults.AuthenticationScheme);
        p.RequireClaim(Claims.Private.Scope, "api");
    });
});

builder.Services.AddDataProtection().PersistKeysToDbContext<AppDbContext>();

builder.Services.AddOpenIddict()
    
    .AddCore(options =>
    {
        options.UseEntityFrameworkCore().UseDbContext<AppDbContext>();
    })
    
    .AddServer(options =>
    {
        options.SetAuthorizationEndpointUris(OpenIdSettings.Endpoints.Authorization)
                .SetTokenEndpointUris(OpenIdSettings.Endpoints.Token)
                .SetIntrospectionEndpointUris(OpenIdSettings.Endpoints.Introspection)
                .SetUserinfoEndpointUris(OpenIdSettings.Endpoints.Userinfo)
                .SetRevocationEndpointUris(OpenIdSettings.Endpoints.Revoke)
                .SetLogoutEndpointUris(OpenIdSettings.Endpoints.Logout);

        
        options.AllowClientCredentialsFlow();

        
        options.AllowAuthorizationCodeFlow();
        options.AllowRefreshTokenFlow();

        
        options.RegisterClaims(OpenIdSettings.Claims);

       
        options.RegisterScopes(OpenIdSettings.Scopes);

       
        options.AddDevelopmentEncryptionCertificate();
        options.AddDevelopmentSigningCertificate();

        
        options.UseAspNetCore()
                .DisableTransportSecurityRequirement()
                .EnableAuthorizationEndpointPassthrough()
                .EnableTokenEndpointPassthrough()
                .EnableUserinfoEndpointPassthrough()
                .EnableLogoutEndpointPassthrough();

        
        options.UseDataProtection();

        
        options.UseReferenceAccessTokens()
            .UseReferenceRefreshTokens();

        options.SetAccessTokenLifetime(TimeSpan.FromHours(24));
        options.SetRefreshTokenLifetime(TimeSpan.FromDays(30));
        options.SetRefreshTokenReuseLeeway(TimeSpan.FromSeconds(60));
    })
    
    .AddValidation(options =>
    {
        
        options.UseLocalServer();

        
        options.EnableAuthorizationEntryValidation();

        
        options.EnableTokenEntryValidation();

        options.UseAspNetCore();
        options.UseDataProtection();
    });



if (builder.Environment.IsDevelopment())
{
    builder.Services.AddScoped<AutomaticMigrationService>();
    builder.Services.AddHostedService<SetupDevelopmentEnvironmentHostedService>();
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseStaticFiles();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapRazorPages();

app.Run();
