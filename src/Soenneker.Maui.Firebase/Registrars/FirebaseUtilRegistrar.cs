using Microsoft.Maui.Hosting;
using Soenneker.Maui.Firebase.Dtos;

namespace Soenneker.Maui.Firebase.Registrars;

/// <summary>
/// A cross-platform library for adding Firebase to MAUI applications
/// </summary>
public static class FirebaseUtilRegistrar
{
    /// <summary>
    /// Starts Firebase configuration for the MAUI application.
    /// </summary>
    /// <param name="builder">Builder to configure.</param>
    /// <param name="config">Config for the use firebase operation.</param>
    /// <returns>The same builder instance, so additional classes or variants can be chained.</returns>
    public static FirebaseMauiBuilder UseFirebase(this MauiAppBuilder builder, FirebaseConfig config)
    {
        return new FirebaseMauiBuilder(builder, config).Initialize();
    }
}
