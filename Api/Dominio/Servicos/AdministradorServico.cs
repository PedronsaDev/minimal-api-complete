using MinimalApi.Dominio.Entidades;
using MinimalApi.DTOs;
using MinimalApi.Infraestrutura.Db;
using MinimalApi.Dominio.Interfaces;

namespace MinimalApi.Dominio.Servicos;

public class AdministradorServico : IAdministradorServico
{
    private readonly DbContexto _contexto;
    public AdministradorServico(DbContexto contexto)
    {
        _contexto = contexto;
    }

    public Administrador? BuscaPorId(int id)
    {
        return _contexto.Administradores.FirstOrDefault(v => v.Id == id);
    }

    public Administrador Incluir(Administrador administrador)
    {
        _contexto.Administradores.Add(administrador);
        _contexto.SaveChanges();

        return administrador;
    }

    public Administrador? Login(LoginDTO loginDTO)
    {
        Administrador? adm = _contexto.Administradores.FirstOrDefault(a => a.Email == loginDTO.Email && a.Senha == loginDTO.Senha);
        return adm;
    }

    public List<Administrador> Todos(int? pagina)
    {
        IQueryable<Administrador> query = _contexto.Administradores.AsQueryable();

        int itensPorPagina = 10;

        if (pagina != null)
            query = query.Skip(((int)pagina - 1)*itensPorPagina).Take(itensPorPagina);

        return query.ToList();
    }
}
