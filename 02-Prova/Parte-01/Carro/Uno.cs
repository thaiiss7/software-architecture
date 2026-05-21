public class Uno : ICarroBasico, IRadio
{
    private PneuDeEstrada pneu = new();
    private Placa placa = new("Paraná", "Curitiba");

    public void Acelerar() 
    => Console.WriteLine("Acelerando..");
    public void AlterarJanela()
    => Console.WriteLine("Abrindo/Fechando janela");
    public void AlterarPorta()
    => Console.WriteLine("Abrindo/Fechando Porta");
    public void AlterarPortaMalas()
    => Console.WriteLine("Abrindo/Fechando PortaMalas");
    public void Buzinar()
    => Console.WriteLine("Bip Bip!!");
    public void Desligar()
    => Console.WriteLine("Zzz...");
    public void Estacionar()
    => Console.WriteLine("Estacionando.");
    public void Frear()
    => Console.WriteLine("Freando");
    public void Ligar()
    => Console.WriteLine("VROOOMM VROOOOMM");
    public void VerificarGasolina()
    => Console.WriteLine("Tanque na metade");
    public void Viajar(string local)
    => Console.WriteLine($"Viajando até {local}");
    public string CidadeDeOrigem()
    => placa.Cidade;

    public void LigarRadio()
    => Console.WriteLine("Radio ligado");
    public void DesligarRadio()
    => Console.WriteLine("Radio desligado");
    public void AlterarEstacaoRadio(string estacao)
    => Console.WriteLine("Estacao alt... 98 FM");
    public void AumentarVolumeRadio()
        => Console.WriteLine("Volume +1");
    public void DiminuirVolumeRadio()
        => Console.WriteLine("Volume -1");

}