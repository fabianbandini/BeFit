namespace BeFIt;

public partial class Profile : ContentPage
{
	public Profile()
	{
		InitializeComponent();
	}

	async void OnFAQClicked(Object sender , EventArgs e)
	{

        await Navigation.PushAsync(new FAQ());
    }

    async void OnInfosClicked(Object sender, EventArgs e)
    {

        await Navigation.PushAsync(new Info());
    }

    async void OnContactClicked(Object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Contact());
    }
}