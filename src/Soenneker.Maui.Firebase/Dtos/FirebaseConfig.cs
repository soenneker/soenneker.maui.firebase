#if ANDROID
using Firebase;
#endif

namespace Soenneker.Maui.Firebase.Dtos
{
    public class FirebaseConfig
    {
#if ANDROID
        public FirebaseOptions? Options { get; set; }
#endif

#if IOS
        public global::Firebase.Core.Options Options { get; set; }
#endif
    }
}