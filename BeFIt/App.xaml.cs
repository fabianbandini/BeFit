namespace BeFIt;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
		Routing.RegisterRoute("ProfilePage", typeof(Profile));

	}
}
