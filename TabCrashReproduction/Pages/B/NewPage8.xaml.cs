namespace TabCrashReproduction.Pages.B;

public partial class NewPage8 : ContentPage {
  public NewPage8() {
    BindingContext = this;
    InitializeComponent();
  }

  public Command GoBackCommand => new Command( async () => await AppShell.Current.GoToAsync( "///A" ) );
}