using System.Collections.Generic;

namespace NEWSLETTER.Models
{
    public static class BaseDados
    {
        private static List<Usuario> dados = null;

        public static void Incluir(Usuario u)
        {
            dados.Add(u);
        }

        public static List<Usuario> Listar()
        {
            return dados;
        }
    }
}