namespace BeFIt;

public partial class Contact : ContentPage
{
	public Contact()
	{
		InitializeComponent();
	}

    void OnEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        if(e.NewTextValue == "")
        {

        }
    }

    void OnEntryTextChanged2(object sender, TextChangedEventArgs e)
    {
        string oldText = e.OldTextValue;
        string newText = e.NewTextValue;
    }
}