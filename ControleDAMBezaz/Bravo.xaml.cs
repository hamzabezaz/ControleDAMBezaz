namespace ControleDAMBezaz;

public partial class Bravo : ContentPage
{
	public Bravo()
	{
		InitializeComponent();
	}

    

    private void Bra_Clicked(object sender, EventArgs e)
    {
        this.Navigation.PushAsync(new Hello());
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        this.Navigation.PushAsync(new Hello());

    }
}