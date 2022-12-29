using System.Collections.ObjectModel;

namespace BeFIt;

public partial class MainPage : ContentPage
{

    public static ObservableCollection<WorkoutModel> meineListenElemente;
    public int _index = 0;
   

    public MainPage()
    {
        InitializeComponent();
        meineListenElemente = new ObservableCollection<WorkoutModel>();
        WorkoutModel a = new WorkoutModel()
        {
            Id = 1,
            Name = "Pull",
            Sets = 18,
            Desc = "Description",
        };

        WorkoutModel b = new WorkoutModel()
        {
            Id = 1,
            Name = "Push",
            Sets = 20,
            Desc = "Description",
        };


        meineListenElemente.Add(a);
        meineListenElemente.Add(b);

        workoutsView.SetBinding(ItemsView.ItemsSourceProperty, "WorkoutModel");
        workoutsView.ItemsSource = meineListenElemente;
        workoutsView.SelectedItem = a;

    }

    async void OnCounterClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Profile());
    }


}

