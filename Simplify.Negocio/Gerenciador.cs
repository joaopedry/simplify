using Simplify.Negocio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simplify.Negocio.Persistencia;

namespace Simplify.Negocio
{
    public class Gerenciador
    {
        private Banco banco = new Banco();

        // ADICIONAR CLIENTE //
        public Validacao AdicionarCliente(Cliente clienteAdicionado)
        {
            Validacao validacao = new Validacao();

            /* CPF deve conter exatamente 11 NÚMEROS 
            if (clienteAdicionado.CPF = 11)
            {
                validacao.Mensagens.Add("CPF", "O CPF deve conter 11 números");
            }

            // Verifica existência do CPF já cadastado no sistema //
            if (this.banco.Clientes.Where(c => c.CPF == clienteAdicionado.CPF).Any() && validacao.Mensagens.Count == 0)
            {
                validacao.Mensagens.Add("CPF", "Cliente já cadastrado no sistema");
            }

            // Campo nome é obrigatório //
            if (String.IsNullOrEmpty(clienteAdicionado.Nome))
            {
                validacao.Mensagens.Add("Nome", "O campo nome é obrigatório");
            }

            // Campo email é obrigatório//
            if (String.IsNullOrEmpty(clienteAdicionado.Email))
            {
                validacao.Mensagens.Add("Email", "O campo email é obrigatório");
            }


            // Campo email, inválido //
            if (!clienteAdicionado.Email.Contains("@") && validacao.Mensagens.Count == 0)
            {
                validacao.Mensagens.Add("Email", "Email inválido");
            }

            // Verifica existência do email já cadastrado no sistema //
            if (this.banco.Clientes.Where(c => c.Email == clienteAdicionado.Email).Any() && validacao.Mensagens.Count == 0)
            {
                validacao.Mensagens.Add("Email", "Email já cadastrado no sistema");
            }

            // Campo telefone é obrigatório //
            if (String.IsNullOrEmpty(clienteAdicionado.Telefone))
            {
                validacao.Mensagens.Add("Telefone", "Campo telefone é obrigatório");
            }

            // Telefone deve conter 10 NÚMEROS //
            if (clienteAdicionado.Telefone = 10)
            {
                validacao.Mensagens.Add("Telefone", "O telefone deve conter 12 números");
            }
            */
            if (validacao.Valido)
            {
                this.banco.Clientes.Add(clienteAdicionado);
                this.banco.SaveChanges();
            }

            return validacao;
        }

        // ALTERAR CLIENTE //
        public Validacao AlterarCliente(Cliente clienteAlterado)
        {
            Validacao validacao = new Validacao();

            return validacao;
        }

        // REMOVER CLIENTE//
        public Validacao RemoverCliente(Cliente cliente)
        {
            Validacao validacao = new Validacao();
            banco.Clientes.Remove(cliente);
            banco.SaveChanges();

            return validacao;
        }
    }
}
