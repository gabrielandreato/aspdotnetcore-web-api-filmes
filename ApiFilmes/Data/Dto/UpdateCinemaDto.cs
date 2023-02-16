using System.ComponentModel.DataAnnotations;

namespace ApiFilmes.Data.Dto;

public class UpdateCinemaDto
{
    [Required(ErrorMessage = "O Campo de nome é obrigatório.")] 
    public string Nome { get; set; }
}