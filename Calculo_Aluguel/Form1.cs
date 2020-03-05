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

namespace Calculo_Aluguel
{
    public partial class calculoAluguel : Form
    {
        public calculoAluguel()
        {
            InitializeComponent();
        }

        string[] aluguel;
        string[] locadora = new string[2];
        private void txtDiretorio_MouseClick(object sender, MouseEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string caminho = openFileDialog1.FileName;

                StreamReader x;

                x = File.OpenText(openFileDialog1.FileName);
                var qtdLinhas = File.ReadLines(openFileDialog1.FileName).Count() - 11;
                string[] dia = new string[qtdLinhas];
                string[] semana = new string[qtdLinhas];
                int i = 0, diasS = 0, diasFs = 0;
                txtDiretorio.Text = openFileDialog1.FileName;
                string totalDias = "", qtdPessoas = "", nome = "", categoriaCliente = "";
                Boolean locadoraS = false, locadoraW = false, locadoraN = false;
                double valorS = 1, valorFs = 1, valorT = 0;

                while (x.EndOfStream != true)
                {
                    string cartao = "";
                    string linha = x.ReadLine();
                    int pessoas = 0;

                    if (linha != "")
                    {
                        string[] busca = linha.Split(':');

                        switch (busca[0])
                        {
                            case "Total de dias do Aluguel":
                                totalDias = busca[1];
                                lblDiasAluguel.Text = totalDias;
                                aluguel = new string[int.Parse(lblDiasAluguel.Text)];
                                break;

                            case "Cartão Fidelidade":
                                cartao = busca[1];
                                if (cartao == " Sim")
                                {
                                    ckCartao.Checked = true;
                                    categoriaCliente = "Premium";
                                }
                                if (cartao == " Não")
                                {
                                    categoriaCliente = "Normal";
                                }
                                break;

                            case "Nome do Cliente":
                                nome = busca[1];
                                lblNome.Text = nome;
                                break;

                            case "Data":
                                dia[i] = busca[1].Substring(1, 10);
                                semana[i] = busca[2];
                                string teste = semana[i];
                                if (semana[i] == " Sábado" || semana[i] == " Domingo")
                                {
                                    diasFs++;
                                }
                                else
                                {
                                    diasS++;
                                }
                                string data = dia[i] + semana[i];
                                aluguel[i] = dia[i] + "      " + semana[i]; 
                                datasAluguel.Items.Add(data);
                                i++;
                                break;

                            case "Quantidade de Pessoas":
                                qtdPessoas = busca[1];
                                lblQtdPessoas.Text = qtdPessoas;
                                pessoas = int.Parse(qtdPessoas);

                                if (pessoas <= 2)
                                {
                                    locadoraW = true;
                                }
                                if (pessoas <= 4)
                                {
                                    locadoraS = true;
                                }
                                if (pessoas <= 7)
                                {
                                    locadoraN = true;
                                }
                                break;
                        }
                    }
                }

                melhorCarro.Items.Add("Categoria do Cliente: " + categoriaCliente);
                melhorCarro.Items.Add("");
                int y = 0;
                switch (categoriaCliente)
                {
                    case "Premium":
                        if (locadoraS)
                        {
                            valorFs = diasFs * 90;
                            valorS = diasS * 150;
                            valorT = valorS + valorFs;
                            melhorCarro.Items.Add("Locadora: SouthCar");
                            melhorCarro.Items.Add("Valor total do Aluguel: " + valorT.ToString());
                            melhorCarro.Items.Add("Tipo do Automóvel: Compactos");
                            melhorCarro.Items.Add("");
                        }
                        if (locadoraW)
                        {
                            valorFs = diasFs * 90;
                            valorS = diasS * 150;
                            valorT = valorS + valorFs;
                            melhorCarro.Items.Add("Locadora: WestCar");
                            melhorCarro.Items.Add("Valor total do Aluguel: " + valorT.ToString());
                            melhorCarro.Items.Add("Tipo do Automóvel: Esportivos");
                            melhorCarro.Items.Add("");
                        }
                        if (locadoraN)
                        {
                            valorFs = diasFs * 590;
                            valorS = diasS * 580;
                            valorT = valorS + valorFs;
                            melhorCarro.Items.Add("Locadora: NorthCar");
                            melhorCarro.Items.Add("Valor total do Aluguel: " + valorT.ToString());
                            melhorCarro.Items.Add("Tipo do Automóvel: SUVs");
                            melhorCarro.Items.Add("");
                        }
                        y++;
                        break;

                    case "Normal":
                        if (locadoraS)
                        {
                            valorFs = diasFs * 200;
                            valorS = diasS * 210;
                            valorT = valorS + valorFs;
                            melhorCarro.Items.Add("Locadora: SouthCar");
                            melhorCarro.Items.Add("Valor total do Aluguel: " + valorT.ToString());
                            melhorCarro.Items.Add("Tipo do Automóvel: Compactos" );
                            melhorCarro.Items.Add("");
                        }
                        if (locadoraW)
                        {
                            valorFs = diasFs * 200;
                            valorS = diasS * 530;
                            valorT = valorS + valorFs;
                            melhorCarro.Items.Add("Locadora: WestCar");
                            melhorCarro.Items.Add("Valor total do Aluguel: " + valorT.ToString());
                            melhorCarro.Items.Add("Tipo do Automóvel: Esportivos");
                            melhorCarro.Items.Add("");
                        }
                        if (locadoraN)
                        {
                            valorFs = diasFs * 600;
                            valorS = diasS * 630;
                            valorT = valorS + valorFs;
                            melhorCarro.Items.Add("Locadora: NorthCar");
                            melhorCarro.Items.Add("Valor total do Aluguel: " + valorT.ToString());
                            melhorCarro.Items.Add("Tipo do Automóvel: SUVs");
                            melhorCarro.Items.Add("");
                        }
                        y++;
                        break;

                }

                x.Close();
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Selecione a pasta onde será criado o arquivo:";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamWriter x;

                x = File.CreateText(System.IO.Path.Combine(dialog.SelectedPath, "Proposta de Aluguel do Cliente " + lblNome.Text + ".txt"));

                x.WriteLine("Proposta de Aluguel do Cliente" + lblNome.Text);
                x.WriteLine();
                x.WriteLine("Nome do Cliente: " + lblNome.Text);
                x.WriteLine("===========================================");
                if (ckCartao.Checked == true)
                {
                    x.WriteLine("Cartão Fidelidade: Sim");
                }
                else
                {
                    x.WriteLine("Cartão Fidelidade: Não");
                }
                x.WriteLine("===========================================");
                x.WriteLine("Quantidade de Pessoas: " + lblQtdPessoas.Text);
                x.WriteLine("===========================================");
                x.WriteLine("Total de dias do Aluguel: " + lblDiasAluguel.Text);
                x.WriteLine("===========================================");
                x.WriteLine("Dias do Aluguel  Dia da Semana do Aluguel");
                for (int i = 0; i < int.Parse(lblDiasAluguel.Text); i++)
                {
                    x.WriteLine(aluguel[i]);
                }
                x.WriteLine("===========================================");
                int vt = melhorCarro.Items.Count;
                for(int i = 0; i < vt; i++)
                {
                    var teste = melhorCarro.Items[i];
                    if(teste == "" && i < 2)
                    {
                        x.WriteLine("===========================================");
                    }
                    x.WriteLine(teste);
                }

                x.Close();

                Application.Exit();
            }
        }
    }
}


