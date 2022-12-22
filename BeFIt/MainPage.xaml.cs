using System.Collections.ObjectModel;

namespace BeFIt;

public partial class MainPage : ContentPage
{

    private ObservableCollection<WorkoutModel> _workouts;
   

    public MainPage()
    {
        InitializeComponent();
        this._workouts = new ObservableCollection<WorkoutModel>();

    }

    async void OnCounterClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Profile());
    }


}

