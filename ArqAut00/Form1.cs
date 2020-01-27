using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Word = Microsoft.Office.Interop.Word;

namespace ArqAut00
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_CarregaArq_Click(object sender, EventArgs e)
        {
            string caminhoArquivoEntrada;

            try
            {                
                //CRIA OBJETO
                OpenFileDialog ofd = new OpenFileDialog();

                //DEFINE AS PROPRIEDADES DE CONTROLE           
                ofd.Multiselect = false;
                ofd.Title = "Selecionar Arquivo";
                ofd.InitialDirectory = @"C:/Users/Public/Documents";
                ofd.Filter = "All files (*.*)|*.*";
                ofd.CheckFileExists = true;
                ofd.CheckPathExists = true;
                ofd.RestoreDirectory = true;
                ofd.ReadOnlyChecked = true;
                ofd.ShowReadOnly = true;

                //ABRE CAIXA DE SELEÇAO
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    caminhoArquivoEntrada = ofd.FileName;
                    //nomeBASELINE = System.IO.Path.GetFileName(caminhoArquivoEntrada);
                }
                else
                    caminhoArquivoEntrada = "";

                //tb_caminhoBS.Text = caminhoArquivoEntrada;

                //VERIFICA SE CAMINHO FOI PREENCHIDO CORRETAMENTE
                if (!String.IsNullOrEmpty(caminhoArquivoEntrada))
                    if (File.Exists(caminhoArquivoEntrada))
                        montaAqrSaida(caminhoArquivoEntrada);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void montaAqrSaida(string caminhoArquivo)
        {

        }        

    }
}
