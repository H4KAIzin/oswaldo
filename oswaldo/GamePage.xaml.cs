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

	var timer =
	Application.Current.Dispatcher.CreateTimer();
	timer.Interval = TimeSpan.FromSeconds(1);
	timer.Tick += (s,e) => PassouTempo();
	 timer.Start();
}

void PassouTempo()
{
	atual.Setfome(atual.Getfome() - 0.001);
	sifooda.Progress = atual.Getfome();

	atual.Setsede(atual.Getsede() - 0.001);
	siseeda.Progress = atual.Getsede();

	atual.Setfelicidade(atual.Getfelicidade() - 0.001);
	sifeelida.Progress = atual.Getfelicidade();

	dog.Setfome(dog.Getfome() - 0.005);
	dog.Setsede(dog.Getsede() - 0.05);
	dog.Setfelicidade(dog.Getfelicidade() - 0.005);

	elgaton.Setfome(dog.Getfome() - 0.005);
	elgaton.Setsede(dog.Getsede() - 0.05);
	elgaton.Setfelicidade(dog.Getfelicidade() - 0.005);
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