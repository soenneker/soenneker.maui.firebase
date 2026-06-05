using System;
using System.Collections.Generic;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.LifecycleEvents;
using Soenneker.Maui.Firebase.Dtos;

#if ANDROID
using Firebase;
using Android.App;
#endif

#if IOS
using Firebase.Core;
using Foundation;
#endif

namespace Soenneker.Maui.Firebase;

/// <summary>
/// Represents the firebase maui builder.
/// </summary>
public class FirebaseMauiBuilder
{
    private readonly MauiAppBuilder _builder;
    private readonly FirebaseConfig _config;
    private readonly List<Action<object?, FirebaseConfig>> _serviceConfigurations = [];
    private bool _firebaseInitialized = false;

    public FirebaseMauiBuilder(MauiAppBuilder builder, FirebaseConfig config)
    {
        _builder = builder;
        _config = config;
    }

    /// <summary>
    /// Executes the initialize operation.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public FirebaseMauiBuilder Initialize()
    {
        if (_firebaseInitialized)
            return this;

        _builder.ConfigureLifecycleEvents(events =>
        {
#if ANDROID
            events.AddAndroid(android => android.OnApplicationCreate(app =>
            {
                FirebaseApp firebaseApp = _config.Options != null
                    ? FirebaseApp.InitializeApp(app, _config.Options)
                    : FirebaseApp.InitializeApp(app);

                foreach (var configure in _serviceConfigurations)
                {
                    configure(firebaseApp, _config);
                }

                _firebaseInitialized = true;
            }));
#endif

#if IOS
            events.AddiOS(ios => ios.FinishedLaunching((app, options) =>
            {
                if (_config.Options != null)
                {
                    global::Firebase.Core.App.Configure(_config.Options);
                }
                else
                {
                    global::Firebase.Core.App.Configure(_config.Options);
                }
                foreach (var configure in _serviceConfigurations)
                {
                    configure(null, _config);
                }

                _firebaseInitialized = true;
                return true;
            }));
#endif
        });

        return this;
    }

    /// <summary>
    /// Adds service.
    /// </summary>
    /// <param name="configureService">The configure service.</param>
    /// <returns>The result of the operation.</returns>
    public FirebaseMauiBuilder AddService(Action<object?, FirebaseConfig> configureService)
    {
        _serviceConfigurations.Add(configureService);
        return this;
    }

    /// <summary>
    /// Executes the build operation.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    public MauiAppBuilder Build()
    {
        Initialize();
        return _builder;
    }
}