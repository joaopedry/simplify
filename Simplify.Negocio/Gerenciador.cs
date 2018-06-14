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

            if (String.IsNullOrEmpty(clienteAdicionado.Email_contato))
            {
                validacao.Mensagens.Add("Email", "O email não pode ser nulo ou vazio");
            }

            if (!clienteAdicionado.Email_contato.Contains("@") && validacao.Mensagens.Count == 0)
            {
                validacao.Mensagens.Add("Email", "Email no formato inválido");
            }

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
            if ((usuarioBanco != null) && (usuarioBanco.Nome_dados != null))
            {
                ClienteVerificado.CPF_dados = usuarioBanco.CPF_dados;
                ClienteVerificado.Nome_dados = usuarioBanco.Nome_dados;
                ClienteVerificado.Indicacao_dados = usuarioBanco.Indicacao_dados;
                ClienteVerificado.Celular1_contato = usuarioBanco.Celular1_contato;
                ClienteVerificado.Email_contato = usuarioBanco.Email_contato;
                ClienteVerificado.Rua_endereco1 = usuarioBanco.Rua_endereco1;
                ClienteVerificado.Bairro_endereco1 = usuarioBanco.Bairro_endereco1;
                ClienteVerificado.Bairro_endereco1 = usuarioBanco.Bairro_endereco1;
                ClienteVerificado.Complemento_endereco1 = usuarioBanco.Complemento_endereco1;
                ClienteVerificado.Lesao_ocorrencia = usuarioBanco.Lesao_ocorrencia;
                ClienteVerificado.Data_ocorrencia = usuarioBanco.Data_ocorrencia;
                ClienteVerificado.Socorrista_ocorrencia = usuarioBanco.Socorrista_ocorrencia;
                ClienteVerificado.Profissao_dados = usuarioBanco.Profissao_dados;
                ClienteVerificado.Veiculo_ocorrencia = usuarioBanco.Veiculo_ocorrencia;
                ClienteVerificado.Num_endereco1 = usuarioBanco.Num_endereco1;
                ClienteVerificado.Cidade_endereco1 = usuarioBanco.Cidade_endereco1;
                ClienteVerificado.INSS_ocorrencia = usuarioBanco.INSS_ocorrencia;
                ClienteVerificado.Horario_ocorrencia = usuarioBanco.Horario_ocorrencia;
                ClienteVerificado.Hospital_ocorrencia = usuarioBanco.Hospital_ocorrencia;
                ClienteVerificado.Tipo_ocorrencia = usuarioBanco.Tipo_ocorrencia;
                ClienteVerificado.Local_ocorrencia = usuarioBanco.Local_ocorrencia;
                ClienteVerificado.Observacao_observacao = usuarioBanco.Observacao_observacao;
            }
            else
            {
                validacao.Mensagens.Add("cpf_dados", "CPF não encontrado");
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
