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

            // -- CAMPO NOME OBRIGATÓRIO -- //
            if (String.IsNullOrEmpty(clienteAdicionado.Nome_dados))
            {
                validacao.Mensagens.Add("Nome_dados", "Campo nome é obrigatório");
            }

            // -- CAMPO INDICAÇÃO OBRIGATÓRIO -- //
            /*if (String.IsNullOrEmpty(clienteAdicionado.Indicacao_dados))
            {
                validacao.Mensagens.Add("Indicacao_dados", "Campo indicação é obrigatório");
            }*/

            // -- CAMPO NASCIMENTO OBRIGATÓRIO -- //
            if (String.IsNullOrEmpty(clienteAdicionado.Nascimento_dados))
            {
                validacao.Mensagens.Add("Nascimento_dados", "Campo nascimento é obrigatório");
            }
            if (validacao.Valido)

            // -- CAMPO CPF OBRIGATÓRIO -- //
            if (String.IsNullOrEmpty(clienteAdicionado.CPF_dados))
            {
                validacao.Mensagens.Add("CPF_dados", "Campo CPF é obrigatório");
            }
            if (validacao.Valido)

            // -- CAMPO RG OBRIGATÓRIO -- //
            if (String.IsNullOrEmpty(clienteAdicionado.RG_dados))
            {
                validacao.Mensagens.Add("RG_dados", "Campo RG obrigatório");
            }
            if (validacao.Valido)

            // -- CAMPO PROFISSÃO OBRIGATÓRIO -- //
            if (String.IsNullOrEmpty(clienteAdicionado.Profissao_dados))
            {
                validacao.Mensagens.Add("Profissao_dados", "Campo profissão é obrigatório");
            }
            if (validacao.Valido)

            // -- CAMPO SEXO OBRIGATÓRIO -- //
            if (String.IsNullOrEmpty(clienteAdicionado.Sexo_dados))
            {
                validacao.Mensagens.Add("Sexo_dados", "Campo sexo é obrigatório");
            }

            // -- CAMPO ESTADO CIVIL OBRIGATÓRIO -- //
            if (String.IsNullOrEmpty(clienteAdicionado.EstadoCivil_dados))
            {
                validacao.Mensagens.Add("EstadoCivil_dados", "Campo estado civil é obrigatório");
            }

            // -- CAMPO ENDEREÇO1 OBRIGATÓRIO -- //
            if (String.IsNullOrEmpty(clienteAdicionado.Endereco_endereco1))
            {
                validacao.Mensagens.Add("Endereco_endereco1", "Campo endereço é obrigatório");
            }

            // -- CAMPO RUA1 OBRIGATÓRIO -- //
            if (String.IsNullOrEmpty(clienteAdicionado.Rua_endereco1))
            {
                validacao.Mensagens.Add("Rua_endereco1", "Campo rua é obrigatório");
            }

            // -- CAMPO NUMERO1 OBRIGATÓRIO -- //
            if (String.IsNullOrEmpty(Convert.ToString(clienteAdicionado.Num_endereco1)))
            {
                validacao.Mensagens.Add("Num_endereco1", "Campo número é obrigatório");
            }

            // -- CAMPO COMPLEMENTO1 OBRIGATÓRIO -- //
            /*if (String.IsNullOrEmpty(clienteAdicionado.Complemento_endereco1))
            {
                validacao.Mensagens.Add("Complemento_endereco1", "Campo complemento é obrigatório");
            }*/

            // -- CAMPO CEP1 OBRIGATÓRIO -- //
            if (String.IsNullOrEmpty(clienteAdicionado.CEP_endereco1))
            {
                validacao.Mensagens.Add("CEP_endereco1", "Campo CEP é obrigatório");
            }

            // -- CAMPO BAIRRO1 OBRIGATÓRIO -- //
            if (String.IsNullOrEmpty(clienteAdicionado.Bairro_endereco1))
            {
                validacao.Mensagens.Add("Bairro_endereco1", "Campo bairro é obrigatório");
            }

            // -- CAMPO CIDADE1 OBRIGATÓRIO -- //
            if (String.IsNullOrEmpty(clienteAdicionado.Cidade_endereco1))
            {
                validacao.Mensagens.Add("Cidade_endereco1", "Campo cidade é obrigatório");
            }

            /*if (String.IsNullOrEmpty(clienteAdicionado.Email_contato))
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
            }*/
            
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

        public List<Cliente> BuscaProcessos(String StatusRecebido)
        {
            return this.banco.Clientes.Where(c => c.Status == StatusRecebido).ToList();
        }
    }
}
