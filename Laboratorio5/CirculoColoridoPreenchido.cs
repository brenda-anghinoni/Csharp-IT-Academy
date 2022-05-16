using System.Drawing;
public class CirculoColoridoPreenchido : CirculoColorido
{
    private Color corPreenchimento;
    public string CorPreenchimento
    {
        get => corPreenchimento.Name;
        set => corPreenchimento = Color.FromName(value);
    }

    public CirculoColoridoPreenchido()
    {
        corPreenchimento =  Color.FromName("red");
    }
    public CirculoColoridoPreenchido(double x, double y, double r, string cc, string cp)
                              : base(x,y,r, cc)
    {
        CorPreenchimento = cp;
    }

    public override string ToString()
    {
        return base.ToString() + " preenchimento="+corPreenchimento.Name+" RGB=("+corPreenchimento.R+","+corPreenchimento.G+","+corPreenchimento.B+")";
    }
}