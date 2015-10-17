using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class pUsuarios
    {
        private String nomeUsuario;
        private String senha;

        public void gravar(String nomeUsuario, String senha)
        {
            String SQL = "INSERT INTO Usuarios(nomeUsuario, senha) VALUES ('" + nomeUsuario + "','" + senha + "')";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }
    }
}
