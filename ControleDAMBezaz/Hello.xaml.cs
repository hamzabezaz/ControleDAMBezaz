namespace ControleDAMBezaz;

public partial class Hello : ContentPage
{
	public Hello()
	{
		InitializeComponent();
	}
   
    
    private void Hel_Clickd(object sender, EventArgs e)
    {
        if (passwordEntry.Text == "DAM2024")
        {
            this.Navigation.PushAsync(new Bravo());

        }
       
    }
}