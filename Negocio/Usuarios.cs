using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

namespace Negocio
{
    public class Usuario
    {
        private String nomeUsuario;
        private String senha;

        public void gravar(String nomeUsuario, String senha)
        {
            pUsuarios oUsuario = new pUsuarios();
            oUsuario.gravar(nomeUsuario, senha);
        }
    }
}
