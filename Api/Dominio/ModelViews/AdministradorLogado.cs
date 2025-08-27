using MinimalApi.Dominio.Enuns;

namespace MinimalApi.Dominio.ModelViews;

public record AdministradorLogado
{
    public string Email { get;init; } = null!;
    public string Perfil { get;init; } = null!;
    public string Token { get;init; } = null!;
}