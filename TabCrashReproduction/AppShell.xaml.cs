
namespace TabCrashReproduction {
  public partial class AppShell : Shell {
    public AppShell() {
      BindingContext = this;
      InitializeComponent();
    }
    public Command GoToACommand => new Command( async () => await GoToAsync( "///A" ) );
  }
}
