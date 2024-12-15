using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound.Modelos;

namespace ScreenSound.Banco
{
    internal class MusicaDAL
    {
        private readonly ScreenSoundContext context;

        public MusicaDAL(ScreenSoundContext context)
        {
            this.context = context;
        }

        public IEnumerable<Musica> Listar()
        {
            return context.Musicas.ToList();
        }

        public void Adicionar(Musica Musica)
        {
            context.Musicas.Add(Musica);
            context.SaveChanges();
        }

        public void Atualizar(Musica Musica)
        {
            context.Musicas.Update(Musica);
            context.SaveChanges();
        }

        public void Deletar(Musica Musica)
        {
            context.Musicas.Remove(Musica);
            context.SaveChanges();
        }
    }
}
