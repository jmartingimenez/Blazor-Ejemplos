using BlazorEjemplos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorEjemplos.Repository
{
    public class UsuarioRepository : IDisposable
    {
        private readonly BlazorTestContext _ctx;

        public UsuarioRepository(BlazorTestContext ctx)
        {
            _ctx = ctx;
        }

        public void Dispose()
        {
            _ctx.Dispose();
        }

        public async Task<Usuario[]> GetUsuariosAsync()
        {
            return await _ctx.Usuarios
                .OrderByDescending(o => o.Id)
                .ToArrayAsync();
        }

        public async Task<Usuario> GetUsuario(int id)
        {
            return await _ctx.Usuarios
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Usuario> GetUsuario(string username)
        {
            return await _ctx.Usuarios
                .FirstOrDefaultAsync(x => x.Username == username);
        }

        public async Task<Usuario> GetUsuario(string username, string password)
        {
            return await _ctx.Usuarios
                .FirstOrDefaultAsync(x => x.Username == username && x.Password == password);
        }

        public async Task AddUsuario(Usuario usuario)
        {
            await _ctx.Usuarios.AddAsync(usuario);
            await _ctx.SaveChangesAsync();
        }
    }
}
