using Microsoft.Maui.Hosting;
using Soenneker.Maui.Firebase.Dtos;

namespace Soenneker.Maui.Firebase.Registrars;

/// <summary>
/// A cross-platform library for adding Firebase to MAUI applications
/// </summary>
public static class FirebaseUtilRegistrar
{
    public static FirebaseMauiBuilder UseFirebase(this MauiAppBuilder builder, FirebaseConfig config)
    {
        return new FirebaseMauiBuilder(builder, config).Initialize();
    }
}
