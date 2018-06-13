using Simplify.Negocio;
using Simplify.Negocio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simplify.Negocio.Persistencia;
using System.Windows.Forms;

namespace Simplify.Negocio
{
    public class Gerenciador
    {
        private Banco banco = new Banco();
        public int i;

        //public String i;
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
            if (String.IsNullOrEmpty(clienteAdicionado.Nome_dados))
            {
                validacao.Mensagens.Add("Nome_dados", "Campo nome é obrigatório");
            }
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

        public Validacao AdicionarUsuario(Usuario UsuarioAdicionado)
        {
            Validacao validacao = new Validacao();

            
            if (String.IsNullOrEmpty(UsuarioAdicionado.Nome_usuario))
            {
                validacao.Mensagens.Add("Nome_usuario", "Campo nome é obrigatório");
            }
            if (validacao.Valido)
            {
                this.banco.Usuarios.Add(UsuarioAdicionado);
                this.banco.SaveChanges();
            }

            return validacao;
        }

        public Validacao RemoverUsuario(Usuario usuario)
        {
            Validacao validacao = new Validacao();
            banco.Usuarios.Remove(usuario);
            banco.SaveChanges();
            return validacao;
        }

        public Validacao AlterarUsuario(Usuario usuarioAlterado)
        {
            Validacao validacao = new Validacao();
            Usuario usuarioBanco = BuscaUsuarioPorId(usuarioAlterado.Id);
            usuarioBanco.Nome_usuario = usuarioAlterado.Nome_usuario;
            usuarioBanco.Email_usuario = usuarioAlterado.Email_usuario;
            usuarioBanco.Login_usuario = usuarioAlterado.Login_usuario;
            usuarioBanco.Password_usuario = usuarioAlterado.Password_usuario;
            usuarioBanco.Administrador_usuario = usuarioAlterado.Administrador_usuario;
            this.banco.SaveChanges();
            return validacao;
        }

        public Validacao VerificaUsuario(Usuario usuarioVerificado)
        {
            Validacao validacao = new Validacao();
            Usuario usuarioBanco = BuscaUsuarioPorLogin(usuarioVerificado.Login_usuario);
            if (usuarioBanco != null) {

                if (usuarioBanco.Login_usuario == usuarioVerificado.Login_usuario)
                {
                    if (usuarioBanco.Password_usuario == usuarioVerificado.Password_usuario)
                    {                        
                    }
                    else
                    {
                        validacao.Mensagens.Add("Password_usuario", "Incorreto"); 
                    }
                }
                else
                {
                    validacao.Mensagens.Add("Login_usuario", "Incorreto");
                }
            }
            else
            {
                validacao.Mensagens.Add("Login_usuario", "Campo nome é obrigatório");               
            }
            return validacao;
        }


        public Validacao BuscaCliente(Cliente ClienteVerificado)
        {
            Validacao validacao = new Validacao();
            Cliente usuarioBanco = BuscaClientePorCPF(ClienteVerificado.CPF_dados);
            if (usuarioBanco != null)
            {
                ClienteVerificado.CPF_dados = usuarioBanco.CPF_dados;
                ClienteVerificado.Nome_dados = usuarioBanco.Nome_dados;
                ClienteVerificado.Indicacao_dados = usuarioBanco.Indicacao_dados;
                ClienteVerificado.Celular1_contato = usuarioBanco.Celular1_contato;
                ClienteVerificado.Email_contato = usuarioBanco.Email_contato;
                ClienteVerificado.Endereco_endereco1 = usuarioBanco.Endereco_endereco1;
                ClienteVerificado.Bairro_endereco1 = usuarioBanco.Bairro_endereco1;
            }
            else
            {
                MessageBox.Show("Não Buscou", "!",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return validacao;
        }


        public Usuario BuscaUsuarioPorId(long id)
        {
            return this.banco.Usuarios.Where(c => c.Id == id).FirstOrDefault();
        }

        public Cliente BuscaClientePorCPF(String CPF_dados)
        {
            return this.banco.Clientes.Where(c => c.CPF_dados == CPF_dados).FirstOrDefault();
        }

        public Usuario BuscaUsuarioPorLogin(String Login_usuario)
        {
            return this.banco.Usuarios.Where(c => c.Login_usuario == Login_usuario).FirstOrDefault();
        }

        public List<Usuario> TodosOsUsuarios()
        {
            return this.banco.Usuarios.ToList();
        }
    }
}
