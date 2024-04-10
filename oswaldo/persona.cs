namespace oswaldo;

public class persona
{
    protected string foto;
    protected int fome;
    protected int sede;
    protected int felicidade;


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
        if (f <= 10 || f >= 0)
            fome = f;
        else if (f > 10)
            fome = 10;
        else
            fome = 0;
    }

    public void Setsede(int s)
    {
        if (s <= 10 || s >= 0)
            sede = s;
        else if (s > 10)
            sede = 10;
        else
            sede = 0;
    }

    public void Setfelicidade(int fl)
    {
        if (fl <= 10 || fl >= 0)
            felicidade = fl;
        else if (fl > 10)
            felicidade = 10;
        else
            felicidade = 0;
    }

    public int Getfome()
    {
        return fome;
    }

    public int Getsede()
    {
        return sede;
    }

    public int Getfelicidade()
    {
        return felicidade;
    }
}