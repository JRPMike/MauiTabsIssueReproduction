using Foundation;

namespace TabCrashReproduction {
  [Register( "AppDelegate" )]
  public class AppDelegate : MauiUIApplicationDelegate {
    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
  }
}
