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
	
	AnimalImg.Source = atual.GetFoto();

	var timer =
	Application.Current.Dispatcher.CreateTimer();
	timer.Interval = TimeSpan.FromSeconds(1);
	timer.Tick += (s,e) => PassouTempo();
	 timer.Start();
}

void PassouTempo()
{
	atual.SetFome(atual.GetFome() - 0.001);
	sifooda.Progress = atual.GetFome();

	atual.SetSede(atual.GetSede() - 0.001);
	siseeda.Progress = atual.GetSede();

	atual.SetFelicidade(atual.GetFelicidade() - 0.001);
	sifeelida.Progress = atual.GetFelicidade();

	dog.SetFome(dog.GetFome() - 0.005);
	dog.SetSede(dog.GetSede() - 0.05);
	dog.SetFelicidade(dog.GetFelicidade() - 0.005);

	elgaton.SetFome(dog.GetFome() - 0.005);
	elgaton.SetSede(dog.GetSede() - 0.05);
	elgaton.SetFelicidade(dog.GetFelicidade() - 0.005);
}

	void ClicouBotaoComida(object sender, EventArgs args)
	{
		atual.SetFome(atual.GetFome() + 0.1);
		sifooda.Progress = atual.GetFome();
	}

	void ClicouBotaoSede(object sender, EventArgs args)
	{
		atual.SetSede(atual.GetSede() + 0.1);
		siseeda.Progress = atual.GetSede();
	}

	void ClicouBotaoFelicidade(object sender, EventArgs args)
	{
		atual.SetFelicidade(atual.GetFelicidade() + 0.1);
		sifeelida.Progress = atual.GetFelicidade();
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


		AnimalImg.Source = atual.GetFoto();
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


		AnimalImg.Source = atual.GetFoto();
	}	    
}