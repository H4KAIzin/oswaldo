namespace oswaldo;

public class persona
{
    protected string Foto;
    protected double Fome;
    protected double Sede;
    protected double Felicidade;


    public persona()
    {
        Fome = 0;
        Sede = 0;
        Felicidade = 0;
    }

     public string GetFoto()
    {
        return Foto;
    }

    public void SetFome(double f)
    {
        if (f < 0)
            Fome = 0;
        else if (f > 1)
            Fome = 1;
        else
            Fome = f;
    }

    public void SetSede(double s)
    {
        if (s < 0)
            Sede = 0;
        else if (s > 1)
            Sede = 1;
        else
            Sede = s;
    }

    public void SetFelicidade(double fe)
    {
        if (fe < 0)
            Felicidade = 0;
        else if (fe > 1)
            Felicidade = 1;
        else
            Felicidade = fe;
    }

    public double GetFome()
    {
        return Fome;
    }

    public double GetSede()
    {
        return Sede;
    }

    public double GetFelicidade()
    {
        return Felicidade;
    }
}