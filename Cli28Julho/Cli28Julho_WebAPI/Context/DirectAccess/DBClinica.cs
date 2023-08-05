using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cli28Julho_WebAPI.Context.DirectAccess
{
    public class DBClinica
    {
        private String _stringConexao;
        private SqlConnection _conexao;

        public DBClinica(String dadosConexao)
        {
            _conexao = new SqlConnection();
            StringConexao = dadosConexao;
            _conexao.ConnectionString = dadosConexao;
        }

        public String StringConexao
        {
            get { return this._stringConexao; }
            set { this._stringConexao = value; }
        }

        public SqlConnection ObjetoConexao
        {
            get { return this._conexao; }
            set { this._conexao = value; }

        }
        public void Conectar()
        {
            this._conexao.Open();
        }

        public void Desconectar()
        {
            this._conexao.Close();
        }
    }

}
