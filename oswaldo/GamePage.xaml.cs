namespace oswaldo;

public partial class GamePage : ContentPage
{

	dog dog;

	elgaton elgaton;
	persona atual;
public GamePage()
{
    InitializeComponent();
	elgaton = new elgaton();
	dog = new dog();
	atual = dog;
	
	AnimalImg.Source = atual.Getfoto();
	
}

void Right(object sender, EventArgs args)
	{


		if (atual == dog)
		{
			atual = elgaton;
		}
		else if (atual == elgaton)
		{
			atual = dog;
		}


		AnimalImg.Source = atual.Getfoto();
	}	

void Left(object sender, EventArgs args)
	{
		if (atual == elgaton)
		{
			atual = dog;
		}
		else if (atual == dog)
		{
			atual = elgaton;
		}


		AnimalImg.Source = atual.Getfoto();
	}	    
}