using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMT.Classes
{
    public class Candidato : Usuario
    {
        public Candidato(string nomeCompleto, string nomeSocial, DateTime dataNascimento, string email, string senha) : base(nomeCompleto, nomeSocial, dataNascimento, email, senha)
        {
        }
    }
}
