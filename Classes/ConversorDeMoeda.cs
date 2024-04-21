class ConversorDeMoeda
{
    private readonly double cotacaoDolar;
    private readonly double cotacaoEuro;
    private const double IOF = 0.0438;

    public ConversorDeMoeda(double cotacaoDolar, double cotacaoEuro)
    {
        this.cotacaoDolar = cotacaoDolar;
        this.cotacaoEuro = cotacaoEuro;
    }

    public double ConverterDolarParaReais(double valorDolar, double cotacaoDolar)
    {
        double valorReais = valorDolar * cotacaoDolar;
        double valorReaisTotal = Math.Round(valorReais * IOF, 2) + valorReais;
        return valorReaisTotal;
    }

    public double ConverterEuroParaReais(double valorEuro, double cotacaoEuro)
    {
        double valorReais = valorEuro * cotacaoEuro;
        double valorReaisTotal = valorReais * IOF + valorReais;
        return valorReaisTotal;
    }
}

