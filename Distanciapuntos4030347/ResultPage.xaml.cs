namespace Distanciapuntos4030347;

public partial class ResultPage : ContentPage
{
    public ResultPage(double result)
    {
        InitializeComponent();
        ResultLabel.Text = $"Distancia Calculada: {result:F2}";
    }
}