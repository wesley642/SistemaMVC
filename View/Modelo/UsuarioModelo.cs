﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using View.Entidades;
using View.DAO;

namespace View.Modelo
{
    class UsuarioModelo
    {
        internal static int Inserir(UsuarioEnt objTabela)
        {
            return new UsuarioDAO().Inserir(objTabela);
        }

        internal List<UsuarioEnt> Lista()
        {
            return new UsuarioDAO().Lista();
        }

        internal List<UsuarioEnt> Consulta(UsuarioEnt objTabela)
        {
            return new UsuarioDAO().Consulta(objTabela);
        }

        internal static int Alterar(UsuarioEnt objTabela)
        {
            return new UsuarioDAO().Alterar(objTabela);
        }

        internal static int Deletar(UsuarioEnt objTabela)
        {
            return new UsuarioDAO().Deletar(objTabela);
        }
    }
}
