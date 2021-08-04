using ExemploWeb_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExemploWeb_API.Controllers
{
    public class ClientesController : ApiController
    {
        private static List<Cliente> clientes = new List<Cliente>();

        //listar clientes...
        public List<Cliente> Get()
        {
            return clientes;
        }

        //adicionar um novo cliente...
        public void Post(string nome)
        {
            if (!string.IsNullOrEmpty(nome))
                clientes.Add(new Cliente(nome));
        }

        //remover cliente...
        public void Delete(string nome)
        {
            clientes.RemoveAt(clientes.IndexOf(clientes.First(x => x.Nome.Equals(nome))));
        }
    }
}
