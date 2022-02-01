namespace SuggestionAppUI;

public static class RegisterServices
{
   public static void ConfigureSertvices(this WebApplicationBuilder builder)
   {
      builder.Services.AddRazorPages();
      builder.Services.AddServerSideBlazor();
      builder.Services.AddMemoryCache();
   }
}
