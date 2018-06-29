using Simplify.Negocio;
using Simplify.Negocio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simplify.Negocio.Persistencia;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Security;
using static System.Net.Mime.MediaTypeNames;

namespace Simplify.Negocio
{
    public class Gerenciador
    {
        private Banco banco = new Banco();
        public int i;
        public int negados;

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

            // -- CAMPO CPF OBRIGATÓRIO -- //
            if (String.IsNullOrEmpty(clienteAdicionado.CPF_dados))
            {
                validacao.Mensagens.Add("CPF_dados", "Campo CPF é obrigatório");
            }

            // -- CAMPO RG OBRIGATÓRIO -- //
            if (String.IsNullOrEmpty(clienteAdicionado.RG_dados))
            {
                validacao.Mensagens.Add("RG_dados", "Campo RG obrigatório");
            }

            // -- CAMPO PROFISSÃO OBRIGATÓRIO -- //
            if (String.IsNullOrEmpty(clienteAdicionado.Profissao_dados))
            {
                validacao.Mensagens.Add("Profissao_dados", "Campo profissão é obrigatório");
            }

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
            
            // -- CAMPO EMAIL OBRIGATÓRIO -- //
            if (String.IsNullOrEmpty(clienteAdicionado.Email_contato))
            {
                validacao.Mensagens.Add("Email_contato", "O email não pode ser nulo ou vazio");
            }

            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (!rg.IsMatch(clienteAdicionado.Email_contato))
            {
                validacao.Mensagens.Add("Email_contato", "Email no formato inválido");
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
            Cliente clienteBanco = BuscaClientePorCPF(clienteAlterado.CPF_dados);
            
            /*Dados Pessoais*/
            clienteBanco.Nome_dados = clienteAlterado.Nome_dados;
            clienteBanco.Indicacao_dados = clienteAlterado.Indicacao_dados;
            clienteBanco.Nascimento_dados = clienteAlterado.Nascimento_dados;
            clienteBanco.CPF_dados = clienteAlterado.CPF_dados;
            clienteBanco.RG_dados = clienteAlterado.RG_dados;
            clienteBanco.Profissao_dados = clienteAlterado.Profissao_dados;
            clienteBanco.Sexo_dados = clienteAlterado.Sexo_dados;
            clienteBanco.EstadoCivil_dados = clienteAlterado.EstadoCivil_dados;
            //Endereço1
            clienteBanco.Endereco_endereco1 = clienteAlterado.Endereco_endereco1;
            clienteBanco.Rua_endereco1 = clienteAlterado.Rua_endereco1;
            clienteBanco.Num_endereco1 = clienteAlterado.Num_endereco1;
            clienteBanco.Complemento_endereco1 = clienteAlterado.Complemento_endereco1;
            clienteBanco.CEP_endereco1 = clienteAlterado.CEP_endereco1;
            clienteBanco.Bairro_endereco1 = clienteAlterado.Bairro_endereco1;
            clienteBanco.Cidade_endereco1 = clienteAlterado.Cidade_endereco1;
            //Endereço2
            clienteBanco.Endereco_endereco2 = clienteAlterado.Endereco_endereco2;
            clienteBanco.Rua_endereco2 = clienteAlterado.Rua_endereco2;
            clienteBanco.Num_endereco2 = clienteAlterado.Num_endereco2;
            clienteBanco.Complemento_endereco2 = clienteAlterado.Complemento_endereco2;
            clienteBanco.CEP_endereco2 = clienteAlterado.CEP_endereco2;
            clienteBanco.Bairro_endereco2 = clienteAlterado.Bairro_endereco2;
            clienteBanco.Cidade_endereco2 = clienteAlterado.Cidade_endereco2;
            //Contato
            clienteBanco.Residencial_contato = clienteAlterado.Residencial_contato;
            clienteBanco.Celular1_contato = clienteAlterado.Celular1_contato;
            clienteBanco.Celular2_contato = clienteAlterado.Celular2_contato;
            clienteBanco.TelTrabalho_contato = clienteAlterado.TelTrabalho_contato;
            clienteBanco.Email_contato = clienteAlterado.Email_contato;
            clienteBanco.Facebook_contato = clienteAlterado.Facebook_contato;
            clienteBanco.NomeRecado_contato = clienteAlterado.NomeRecado_contato;
            clienteBanco.TelefoneRecado_contato = clienteAlterado.TelefoneRecado_contato;
            //Ocorrencia
            clienteBanco.Data_ocorrencia = clienteAlterado.Data_ocorrencia;
            clienteBanco.Local_ocorrencia = clienteAlterado.Local_ocorrencia;
            clienteBanco.Veiculo_ocorrencia = clienteAlterado.Veiculo_ocorrencia;
            clienteBanco.Tipo_ocorrencia = clienteAlterado.Tipo_ocorrencia;
            clienteBanco.INSS_ocorrencia = clienteAlterado.INSS_ocorrencia;
            clienteBanco.Horario_ocorrencia = clienteAlterado.Horario_ocorrencia;
            clienteBanco.Lesao_ocorrencia = clienteAlterado.Lesao_ocorrencia;
            clienteBanco.Socorrista_ocorrencia = clienteAlterado.Socorrista_ocorrencia;
            clienteBanco.Hospital_ocorrencia = clienteAlterado.Hospital_ocorrencia;
            clienteBanco.Observacao_ocorrencia = clienteAlterado.Observacao_ocorrencia;
            //Observaçoes
            clienteBanco.Observacao_observacao = clienteAlterado.Observacao_observacao;
            //status
            clienteBanco.Status = clienteAlterado.Status;
            //caminho arquivo
            clienteBanco.caminhoBoletim_anexos = clienteAlterado.caminhoBoletim_anexos;
            clienteBanco.caminhoProntuario_anexos = clienteAlterado.caminhoProntuario_anexos;
            clienteBanco.caminhoComprovanteResidencia_anexos = clienteAlterado.caminhoComprovanteResidencia_anexos;
            clienteBanco.caminhoCartaoBanco_anexos = clienteAlterado.caminhoCartaoBanco_anexos;
            clienteBanco.caminhoRG_anexos = clienteAlterado.caminhoRG_anexos;
            clienteBanco.caminhoCPF_anexos = clienteAlterado.caminhoCPF_anexos;
            clienteBanco.caminhoCNH_anexos = clienteAlterado.caminhoCNH_anexos;
            clienteBanco.caminhoDOCVeiculo_anexos = clienteAlterado.caminhoDOCVeiculo_anexos;
            this.banco.SaveChanges();

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
            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
      
            Validacao validacao = new Validacao();

            if (!rg.IsMatch(UsuarioAdicionado.Email_usuario))
            {
                validacao.Mensagens.Add("Email_contato", "Email no formato inválido");
            }
            
            if (String.IsNullOrEmpty(UsuarioAdicionado.Nome_usuario))
            {
                validacao.Mensagens.Add("Nome_usuario", "Campo nome é obrigatório");
            }

            if (String.IsNullOrEmpty(UsuarioAdicionado.Login_usuario))
            {
                validacao.Mensagens.Add("Login_usuario", "Login não pode ser nulo");
            }

            if (String.IsNullOrEmpty(UsuarioAdicionado.Password_usuario))
            {
                validacao.Mensagens.Add("Password_usuario", "Senha não pode ser nulo");
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
            usuarioBanco.Funcao_usuario = usuarioAlterado.Funcao_usuario;
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

        public Validacao VerificaUsuario2(Usuario usuarioVerificado)
        {
            Validacao validacao = new Validacao();
            Usuario usuarioBanco = BuscaUsuarioPorLogin(usuarioVerificado.Login_usuario);
            if (usuarioBanco != null)
            {

                if (usuarioBanco.Login_usuario == usuarioVerificado.Login_usuario)
                {
                    if (usuarioBanco.Password_usuario == usuarioVerificado.Password_usuario)
                    {
                        if (usuarioBanco.Funcao_usuario == "Administrador")
                        {

                        }
                        else
                        {
                            validacao.Mensagens.Add("!", "Acesso Negado");
                        }
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
                ClienteVerificado.caminhoBoletim_anexos = usuarioBanco.caminhoBoletim_anexos;
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

        public Cliente BuscaClientePorId(long id)
        {
            return this.banco.Clientes.Where(c => c.Id == id).FirstOrDefault();
        }

        public Usuario BuscaUsuarioAdminPorLogin(String Login_usuario)
        {
            return this.banco.Usuarios.Where(c => c.Login_usuario == Login_usuario).FirstOrDefault();
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

        public List<Cliente> CountEnviado(string CountEnviado)
        {
            DateTime newDate = DateTime.Now.AddDays(-30);
            return this.banco.Clientes.Where(c => c.Status == "Enviado")
                                      .Where(d => d.DTCriacao >= newDate)
                                      .ToList();
        }

        public List<Cliente> CountPendente(string CountEnviado)
        {
            DateTime newDate = DateTime.Now.AddDays(-30);
            return this.banco.Clientes.Where(c => c.Status == "Pendente")
                                      .Where(d => d.DTCriacao >= newDate)
                                      .ToList();
        }

        public List<Cliente> CountNegado(string CountEnviado)
        {
            DateTime newDate = DateTime.Now.AddDays(-30);
            return this.banco.Clientes.Where(c => c.Status == "Negado")
                                      .Where(d => d.DTCriacao >= newDate)
                                      .ToList();
        }

        public List<Cliente> CountAprovado(string CountEnviado)
        {
            DateTime newDate = DateTime.Now.AddDays(-30);
            return this.banco.Clientes.Where(c => c.Status == "Aprovado")
                                      .Where(d => d.DTCriacao >= newDate)
                                      .ToList();
        }
        public List<Cliente> TodosOsClientes()
        {
            return this.banco.Clientes.ToList();
        }
    }
}
