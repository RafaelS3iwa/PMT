using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMT.Classes
{
    internal static class SessaoUsuario
    {
        public static Usuario UsuarioAtual { get; private set; }
        public static Candidato CandidatoAtual { get; private set; }

        public static void DefiniroUsuarioAtual(Usuario usuario)
        {
            UsuarioAtual = usuario;
        }

        public static void DefinirCandidatoAtual(Candidato candidato)
        {
            CandidatoAtual = candidato;
        }
    }
}
