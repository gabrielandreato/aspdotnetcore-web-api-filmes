using System.ComponentModel.DataAnnotations;

namespace ApiFilmes.Models;

public class Cinema
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required(ErrorMessage = "O Campo de nome é obrigatório.")] 
    public string Nome { get; set; }
    
}