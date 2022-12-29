namespace BeFIt;

public partial class Workout : ContentPage
{
	public Workout(Object model)
	{
		InitializeComponent();
		WorkoutModel workotu = (WorkoutModel)model;
		TestLabel.Text = $"{workotu.Name}";

    }
}