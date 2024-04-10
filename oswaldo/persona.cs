namespace oswaldo;

public class persona
{
    protected string foto;
    protected double fome;
    protected double sede;
    protected double felicidade;


    public persona()
    {
        fome = 0;
        sede = 0;
        felicidade = 0;
    }

     public string Getfoto()
    {
        return foto;
    }

    public void Setfome(int f)
    {
        if (f < 0)
            fome = f;
        else if (f > 1)
            fome = 1;
        else
            fome = f;
    }

    public void Setsede(int s)
    {
        if (s < 0)
            sede = s;
        else if (s > 1)
            sede = 1;
        else
            sede = s;
    }

    public void Setfelicidade(int fl)
    {
        if (fl < 0)
            felicidade = fl;
        else if (fl > 1)
            felicidade = 1;
        else
            felicidade = fl;
    }

    public double Getfome()
    {
        return fome;
    }

    public double Getsede()
    {
        return sede;
    }

    public double Getfelicidade()
    {
        return felicidade;
    }
}