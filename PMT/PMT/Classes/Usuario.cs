using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMT.Classes
{
    public class Usuario
    {
        protected int _id;
        protected string _nomeCompleto;
        protected string _nomeSocial;
        protected DateTime _dataNascimento;
        protected string _email;
        protected string _senha; 

        public Usuario(int id, string nomeCompleto, string nomeSocial, DateTime dataNascimento, string email, string senha)
        {
            _id = id;
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
