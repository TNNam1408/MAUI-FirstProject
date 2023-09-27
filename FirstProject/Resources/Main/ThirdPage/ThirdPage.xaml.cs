namespace FirstProject;

public partial class ThirdPage : ContentPage
{
	public ThirdPage()
	{
        InitializeComponent();
	}

    private void OnBackMainPage(object sender, EventArgs e)
	{
		Navigation.PopAsync();
	}
}
