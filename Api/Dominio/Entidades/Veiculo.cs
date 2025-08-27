using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinimalApi.Dominio.Entidades;

public class Veiculo
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get;init; } = 0!;

    [Required]
    [StringLength(150)]
    public string Nome { get;set; } = null!;

    [Required]
    [StringLength(100)]
    public string Marca { get;set; } = null!;

    [Required]
    public int Ano { get;set; } = 0!;
}