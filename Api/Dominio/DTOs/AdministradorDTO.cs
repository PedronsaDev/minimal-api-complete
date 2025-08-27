
using MinimalApi.Dominio.Enuns;

namespace MinimalApi.DTOs;
public class AdministradorDTO
{
    public string Email { get;set; } = null!;
    public string Senha { get;set; } = null!;
    public Perfil? Perfil { get;set; } = null!;
}