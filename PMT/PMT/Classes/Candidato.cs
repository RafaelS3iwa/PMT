using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMT.Classes
{
    public class Candidato
    {
        private int _idCandidato;
        private int _idUsuario;
        private int _idAreaInteresse;
        private string _cpf;
        private string _telefone;
        private string _celular;
        private string _genero;
        private string _experiencia;
        private string _conhecimento;
        private string _biografia;
        private string _escolaridade;
        private string _nacionalidade;
        private string _estadoCivil;
        private byte[] _foto;
        private string _cep;
        private string _logradouro;
        private string _bairro;
        private int _numero;
        private string _cidade;
        private string _estado;

        public Candidato(int idCandidato, int idUsuario, int idAreaInteresse, string cpf, string telefone, string celular, string genero, string experiencia, string conhecimento, string biografia, string escolaridade, string nacionalidade, string estadoCivil, byte[] foto, string cep, string logradouro, string bairro, int numero, string cidade, string estado)
        {
            _idCandidato = idCandidato;
            _idUsuario = idUsuario;
            _idAreaInteresse = idAreaInteresse; 
            _cpf = cpf;
            _telefone = telefone;
            _celular = celular;
            _genero = genero;
            _experiencia = experiencia;
            _conhecimento = conhecimento;
            _biografia = biografia;
            _escolaridade = escolaridade;
            _nacionalidade = nacionalidade;
            _estadoCivil = estadoCivil;
            _foto = foto;
            _cep = cep;
            _logradouro = logradouro;
            _bairro = bairro;
            _numero = numero;
            _cidade = cidade;
            _estado = estado;
        }

        public int getIdCandidato()
        {
            return _idCandidato;
        }

        public int getIdUsuario()
        {
            return _idUsuario;
        }

        public int getAreaInteresse() 
        {
            return _idAreaInteresse; 
        }

        public string getCpf()
        {
            return _cpf;
        }

        public string getTelefone()
        {
            return _telefone;
        }

        public string getCelular()
        {
            return _celular;
        }
        public string getGenero()
        {
            return _genero;
        }

        public string getExperiencia()
        {
            return _experiencia;
        }

        public string getConhecimento()
        {
            return _conhecimento;
        }

        public string getBiografia()
        {
            return _biografia;
        }
        public string getEscolaridade()
        {
            return _escolaridade;
        }

        public string getNacionalidade()
        {
            return _nacionalidade;
        }
        public string getEstadoCivil()
        {
            return _estadoCivil;
        }

        public byte[] getFoto()
        {
            return _foto;
        }

        public string getCep()
        {
            return _cep;
        }

        public string getLogradouro()
        {
            return _logradouro;
        }

        public string getBairro()
        {
            return _bairro;
        }

        public int getNumero()
        {
            return _numero;
        }

        public string getCidade()
        {
            return _cidade;
        }

        public string getEstado()
        {
            return _estado;
        }
    }
}