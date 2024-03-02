namespace DDD.Domain.Models;

public abstract class BaseModel
{
    public int GerarIdAleatorio()
    {
        Random random = new Random();
        return random.Next(1000, 10000); // Altere os valores conforme necessário para o intervalo desejado
    }
}