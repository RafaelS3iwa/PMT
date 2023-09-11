using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMT.Classes
{
    internal class Usuario
    {
        private int _id;
        private string _nomeCompleto;
        private string _nomeSocial;
        private DateTime _dataNascimento;
        private string _email;
        private string _senha; 

        public Usuario(string nomeCompleto, string nomeSocial, DateTime dataNascimento, string email, string senha)
        {
            _nomeCompleto = nomeCompleto;
            _nomeSocial = nomeSocial;
            _dataNascimento = dataNascimento;
            _email = email;
            _senha = senha;
        }

        public int getId()
        {
            return _id;
        }

        public string getnomeCompleto()
        {
            return _nomeCompleto;
        }

        public string getnomeSocial()
        {
            return _nomeSocial;
        }

        public DateTime getDataNascimento()
        {
            return _dataNascimento;
        }

        public string getEmail()
        {
            return _email;
        }

        public string getSenha()
        {
            return _senha;
        }
    }
}
