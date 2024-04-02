namespace oswaldo;

public class persona
{
    protected int fome;
    protected int sede;
    protected int felicidade;


    public persona()
    {
        fome = 0;
        sede = 0;
        felicidade = 0;
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
}