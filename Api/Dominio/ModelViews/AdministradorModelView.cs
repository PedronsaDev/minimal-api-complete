using MinimalApi.Dominio.Enuns;

namespace MinimalApi.Dominio.ModelViews;

public record AdministradorModelView
{
    public int Id { get;set; } = 0!;
    public string Email { get;set; } = null!;
    public string Perfil { get;set; } = null!;
}