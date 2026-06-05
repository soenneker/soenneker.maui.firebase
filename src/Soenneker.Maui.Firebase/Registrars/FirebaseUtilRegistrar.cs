using Microsoft.Maui.Hosting;
using Soenneker.Maui.Firebase.Dtos;

namespace Soenneker.Maui.Firebase.Registrars;

/// <summary>
/// A cross-platform library for adding Firebase to MAUI applications
/// </summary>
public static class FirebaseUtilRegistrar
{
    /// <summary>
    /// Executes the use firebase operation.
    /// </summary>
    /// <param name="builder">The builder.</param>
    /// <param name="config">The configuration.</param>
    /// <returns>The result of the operation.</returns>
    public static FirebaseMauiBuilder UseFirebase(this MauiAppBuilder builder, FirebaseConfig config)
    {
        return new FirebaseMauiBuilder(builder, config).Initialize();
    }
}
