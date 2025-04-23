using Android.App;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Microsoft.Maui;

namespace Calculator_App;

    [Application]
    public class MainApplication : MauiApplication
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership)
            : base(handle, ownership)
        {
            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(Entry), (Handler, view) => 
            {
                if (view is Entry)
                {
                    Handler.PlatformView.BackgroundTintList = ColorStateList.ValueOf(Android.Graphics.Color.Transparent);

                    Handler.PlatformView.ShowSoftInputOnFocus = false;
                }
            });
            
        }

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }

