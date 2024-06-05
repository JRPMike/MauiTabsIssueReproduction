namespace TabCrashReproduction.Pages.A;

public partial class NewPage1 : ContentPage {
  public NewPage1() {
    BindingContext = this;
    InitializeComponent();
  }
  public Command GoToBCommand => new Command( async () =>
  await AppShell.Current.GoToAsync( "///B" )
  );

}