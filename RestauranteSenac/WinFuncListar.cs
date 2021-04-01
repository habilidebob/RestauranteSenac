using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace RestauranteSenac
{
    public partial class WinFuncListar : Form
    {
        // Variáveis globais: 
        int idUsuario = 0;
        // bandeira para sinalizar quando o editar ou o apagar podem ser invocados:
        bool podeEditarApagar = false;
        public WinFuncListar()
        {
            InitializeComponent();
        }
        private void atualizardados()
        {
            // Puxar os dados provindos da FuncionarioDAO.listar():

            // Modo 1 (mais legível):
            //   DataTable tabela = new DataTable();
            //   tabela = db.FuncionarioDAO.listar();
            //   dgvFuncionarios.DataSource = tabela;
            // Modo 2 (mais simples):
            dgvFuncionarios.DataSource = db.FuncionarioDAO.listar();
        }
        //oq será executado quando a janela for exibida:
        private void WinFuncListar_Load(object sender, EventArgs e)
        {
            atualizardados();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Criar um obj do tipo Funcionario:
            Funcionario func = new Funcionario();
            func.Nome = txbNomeCad.Text;
            func.Email = txbEmailCad.Text;
            func.Funcao = txbFuncaoCad.Text;
            func.Setor = int.Parse(txbSetorCad.Text);
            func.Telefone = txbTelCad.Text;
            // Passar o funcionário pro .cadastrar e obter o resultado (true ou false):
            var resultado = db.FuncionarioDAO.cadastrar(func);
            if (resultado == true)
            {
                MessageBox.Show("Funcionário cadastrado com sucesso!");
                // Limpar os campos do formulário:
                txbNomeCad.Clear();
                txbSetorCad.Clear();
                txbEmailCad.Clear();
                txbTelCad.Clear();
                txbFuncaoCad.Clear();
                atualizardados();
                
            }
            else
            {
                MessageBox.Show("Erro! Verifique os dados informados!");
            }
        }

        private void dgvFuncionarios_SelectionChanged(object sender, EventArgs e)
        {
            // Garantir que a pessoa selecionou alguma linha:
            var dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if(contLinhas > 0)
            {
                // Declarar um DataTable para obter a resposta de um consulta:
                DataTable dt = new DataTable();
                // Obter o id do usuário selecionado:
                idUsuario = int.Parse(dgv.SelectedRows[0].Cells[0].Value.ToString());
                // Buscar o usuário com base no ID:
                // Obter o resultado da consulta no nosso datatable local:
                dt = db.FuncionarioDAO.buscarUsuario(idUsuario);
                // obter linha 0:
                var linha = dt.Rows[0];
                // Preencher os campos do editar:
                txbNomeEd.Text = linha.Field<string>("Nome").ToString();
                txbEmailEd.Text = linha.Field<string>("Email").ToString();
                txbTelEd.Text = linha.Field<string>("Telefone").ToString();
                txbFuncaoEd.Text = linha.Field<string>("Funcao").ToString();
                txbSetorEd.Text = linha.Field<Int32>("Setor").ToString();
                // Atribuir true na podeEditar:
                podeEditarApagar = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (podeEditarApagar)
            {
                // Instanciar o objeto Funcionario:
                Funcionario func = new Funcionario();
                // Inserir os dados dos campos nos atributos do obj:
                func.Nome = txbNomeEd.Text;
                func.Email = txbEmailEd.Text;
                func.Setor = int.Parse(txbSetorEd.Text);
                func.Telefone = txbTelEd.Text;
                func.Funcao = txbFuncaoEd.Text;
                // Sabemos que o ID a editar está no iUsuario global!
                // Chamamos nosso método de editar os dados, passando nosso obj e o id do funcionario selecionado
                var resultado = db.FuncionarioDAO.editar(func, idUsuario);
                // Deu certo?
                if (resultado == true)
                {
                    MessageBox.Show("Informações modificadas!");
                    txbNomeEd.Clear();
                    txbSetorEd.Clear();
                    txbEmailEd.Clear();
                    txbTelEd.Clear();
                    txbFuncaoEd.Clear();
                    atualizardados();
                    podeEditarApagar = false;
                }
                // Deu errado?
                else
                {
                    MessageBox.Show("Erro! Verifique os dados informados!");
                }
            }
            else
            {
                MessageBox.Show("Erro! Não existem dados a serem editados!");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (podeEditarApagar)
            {
                // chamar o método excluir do DAO já dentro do IF:
                if (db.FuncionarioDAO.excluir(idUsuario))
                {
                    // Deu certo?
                    MessageBox.Show("Usuário excluído!");
                    txbNomeEd.Clear();
                    txbSetorEd.Clear();
                    txbEmailEd.Clear();
                    txbTelEd.Clear();
                    txbFuncaoEd.Clear();
                    atualizardados();
                    podeEditarApagar = false;
                }
                // Deu errado?
                else
                {
                    MessageBox.Show("Erro! Verifique os dados informados!");
                }
            }
            else
            {
                MessageBox.Show("Erro! Não existem dados a serem removidos!");
            }
        }

        private void dgvFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            // Verificar se existem registros no dgv:
            if(dgvFuncionarios.Rows.Count > 0)
            {
                // Instanciar a janela de salvamento de arquivo:
                SaveFileDialog janelaSalvar = new SaveFileDialog();
                // Definir filtro do SFD:
                janelaSalvar.Filter = "PDF (*.pdf)|*.pdf";
                // Definir o nome do arquivo:
                string nomeArq = "Relatorio_" + DateTime.Now.ToString() + ".pdf";
                // Apagar as barras do nome:
                nomeArq = nomeArq.Replace("/", "").Replace(":","");
                janelaSalvar.FileName = nomeArq;

                // Exibir a janela de salvar e obter o resultado:
                var resultadoSalvar = janelaSalvar.ShowDialog();
                // Verificar se o usuário confirmou o salvamento:
                if(resultadoSalvar == DialogResult.OK)
                {
                    // *********************************************
                    // Opcionalmente, verificar se o arquivo existe.
                    // Mas não faremos isso ;)
                    // *********************************************

                    // Iniciar a parte de escrita:
                    // Criar a tabela PDF:
                    PdfPTable tabelaPDF = new PdfPTable(dgvFuncionarios.Columns.Count);
                    // Definir o espaçamento da célula:
                    tabelaPDF.DefaultCell.Padding = 2;
                    // Definir a largura da tabela na página:
                    tabelaPDF.WidthPercentage = 100;
                    // Definir o alinhamento:
                    tabelaPDF.HorizontalAlignment = Element.ALIGN_LEFT;

                    // Popular o cabeçalho da tabelaPDF:
                    foreach (DataGridViewColumn coluna in dgvFuncionarios.Columns)
                    {
                        // Criar um obj do tipo célula, definir como texto do cabeçalho, setar o texto da coluna do dgv:
                        PdfPCell celula = new PdfPCell(new Phrase(coluna.HeaderText));
                        // Adicionar essa célula de cabeçalho na nossa tabelaPDF
                        tabelaPDF.AddCell(celula);
                    }

                    // Popular as linhas da tabelaPDF:
                    foreach (DataGridViewRow linha in dgvFuncionarios.Rows)
                    {
                        // Pegar cada célula da linha e adicionar na linha atual da tabelaPDF:
                        foreach (DataGridViewCell celula in linha.Cells)
                        {
                            // Adicionar a célula na linha atual:
                            tabelaPDF.AddCell(celula.Value.ToString());
                        }
                    }

                    // Escrever esse arquivo no HD:
                    using (FileStream arquivo = new FileStream(janelaSalvar.FileName, FileMode.Create))
                    {
                        // Definir a propriedades do documento
                        Document documento = new Document(PageSize.A4, 10f, 10f, 20f, 20f);
                        // Associar as propriedades com o arquivo (caminho)
                        PdfWriter.GetInstance(documento, arquivo);
                        // Abrir a escrita:
                        documento.Open();
                        // Adicionar a tabela no documento:
                        documento.Add(tabelaPDF);
                        // Fechar a escrita:
                        documento.Close();
                        arquivo.Close();
                    }
                    MessageBox.Show("Sucesso! Relatório exportado!");
                }
            }
            else
            {
                MessageBox.Show("Não existem registros no relatório!");
            }
        }
    }
}
