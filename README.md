# Soenneker.Maui.Firebase
[![](https://img.shields.io/nuget/v/soenneker.maui.firebase.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.maui.firebase/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.maui.firebase/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.maui.firebase/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.maui.firebase.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.maui.firebase/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.maui.firebase/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.maui.firebase/actions/workflows/codeql.yml)

Initializes the native Firebase SDK during the Android and iOS application lifecycle and provides the builder used by Soenneker's MAUI Firebase integrations.

## Installation

```bash
dotnet add package Soenneker.Maui.Firebase
```

## Native Firebase configuration

Add the Firebase configuration downloaded for each app:

- Android: add `google-services.json` to the app project with the `GoogleServicesJson` build action.
- iOS: add `GoogleService-Info.plist` to the app bundle with the `BundleResource` build action.

The package calls the platform SDK's default initialization when `FirebaseConfig.Options` is not set. You can instead populate `Options` with the platform-specific Firebase options when configuration must be supplied in code.

## Registration

Configure Firebase in `MauiProgram.CreateMauiApp` before the final MAUI build:

```csharp
using Soenneker.Maui.Firebase.Dtos;
using Soenneker.Maui.Firebase.Registrars;

MauiAppBuilder builder = MauiApp.CreateBuilder()
    .UseMauiApp<App>();

builder.UseFirebase(new FirebaseConfig())
       .Build();

return builder.Build();
```

`FirebaseMauiBuilder.Build()` completes Firebase registration and returns the original `MauiAppBuilder`; the final `builder.Build()` still creates the `MauiApp`.

Additional integrations such as Crashlytics attach to the Firebase builder before its `Build()` call:

```csharp
builder.UseFirebase(new FirebaseConfig())
       .AddCrashlytics()
       .Build();
```

Import the registrar namespace supplied by each integration for its extension method. The base package performs initialization only; it does not register analytics or performance service abstractions by itself.
