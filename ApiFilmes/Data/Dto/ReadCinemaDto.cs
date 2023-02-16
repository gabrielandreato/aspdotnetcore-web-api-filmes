namespace ApiFilmes.Data.Dto;

public class ReadCinemaDto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public DateTime HoraDaConsulta { get; set; } = DateTime.Now;
}