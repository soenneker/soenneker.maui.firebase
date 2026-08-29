[![](https://img.shields.io/nuget/v/soenneker.maui.firebase.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.maui.firebase/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.maui.firebase/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.maui.firebase/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.maui.firebase.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.maui.firebase/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.maui.firebase/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.maui.firebase/actions/workflows/codeql.yml)

# Soenneker.Maui.Firebase

A cross-platform library for adding Firebase to MAUI applications.

## Install

```bash
dotnet add package Soenneker.Maui.Firebase
```

## Quick start

```csharp
using Soenneker.Maui.Firebase.Registrars;

MauiAppBuilder builder = /* obtain from your application */;
var result = builder.UseFirebase(/* supply config */ default!);
```

Adds the use firebase firebase util utility to the class list.

## What you get

- `IFirebaseUtil` — A cross-platform library for adding Firebase to MAUI applications.
- `FirebaseUtilRegistrar` — A cross-platform library for adding Firebase to MAUI applications.
- `FirebaseConfig` — Represents the firebase config.
- `FirebaseMauiBuilder` — Represents the firebase maui builder.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `FirebaseUtilRegistrar.UseFirebase(builder, config)` | Adds the use firebase firebase util utility to the class list. | The same builder instance, so additional classes or variants can be chained. |
| `FirebaseMauiBuilder.Initialize()` | Adds the initialize firebase maui utility to the class list. | The same builder instance, so additional classes or variants can be chained. |
| `FirebaseMauiBuilder.Build()` | Adds the build firebase maui utility to the class list. | The same builder instance, so additional classes or variants can be chained. |
