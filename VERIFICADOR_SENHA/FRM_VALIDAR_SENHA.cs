using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VERIFICADOR_SENHA
{
    public partial class FRM_VALIDAR_SENHA : Form
    {
        bool verSenhaTxt = false;

        public FRM_VALIDAR_SENHA()
        {
            InitializeComponent();
        }

        private void TXT_SENHA_KeyDown(object sender, KeyEventArgs e)
        {
            ChecaForcaSenha verifica = new ChecaForcaSenha();
            ChecaForcaSenha.ForcaDaSenha forca = verifica.GetForcaDaSenha(TXT_SENHA.Text);
            LBL_RESULTADO.Text = forca.ToString();

            if (LBL_RESULTADO.Text == "Inaceitavel" || LBL_RESULTADO.Text == "Fraca")
            {
                LBL_RESULTADO.ForeColor = Color.Red;
            }
            if (LBL_RESULTADO.Text == "Aceitavel")
            {
                LBL_RESULTADO.ForeColor = Color.Blue;
            }
            if (LBL_RESULTADO.Text == "Forte" || LBL_RESULTADO.Text == "Segura")
            {
                LBL_RESULTADO.ForeColor = Color.Green;
            }
        }

        private void BTN_RESET_Click(object sender, EventArgs e)
        {
            TXT_SENHA.Text = "";
            LBL_RESULTADO.Text = "";
        }

        private void BTN_VALIDAR_Click(object sender, EventArgs e)
        {
            if (verSenhaTxt == false)
            {
                TXT_SENHA.PasswordChar = '\0';
                verSenhaTxt = true;
                BTN_VALIDAR.Text = "Esconder Senha";
            }
            else
            {
                TXT_SENHA.PasswordChar = '*';
                verSenhaTxt = false;
                BTN_VALIDAR.Text = "Ver Senha";
            }
        }

        public class ChecaForcaSenha
        {

            public enum ForcaDaSenha
            {
                Inaceitavel,
                Fraca,
                Aceitavel,
                Forte,
                Segura
            }

            public int geraPontosSenha(string senha)
            {
                if (senha == null) return 0;
                int pontosPorTamanho = GetPontoPorTamanho(senha);
                int pontosPorMinusculas = GetPontoPorMinusculas(senha);
                int pontosPorMaiusculas = GetPontoPorMaiusculas(senha);
                int pontosPorDigitos = GetPontoPorDigitos(senha);
                int pontosPorSimbolos = GetPontoPorSimbolos(senha);
                int pontosPorRepeticao = GetPontoPorRepeticao(senha);
                return pontosPorTamanho + pontosPorMinusculas +
                    pontosPorMaiusculas + pontosPorDigitos +
                    pontosPorSimbolos - pontosPorRepeticao;
            }

            private int GetPontoPorTamanho(string senha)
            {
                return Math.Min(10, senha.Length) * 7;
            }

            private int GetPontoPorMinusculas(string senha)
            {
                int rawplacar = senha.Length - Regex.Replace(senha, "[a-z]", "").Length;
                return Math.Min(2, rawplacar) * 5;
            }

            private int GetPontoPorMaiusculas(string senha)
            {
                int rawplacar = senha.Length - Regex.Replace(senha, "[A-Z]", "").Length;
                return Math.Min(2, rawplacar) * 5;
            }

            private int GetPontoPorDigitos(string senha)
            {
                int rawplacar = senha.Length - Regex.Replace(senha, "[0-9]", "").Length;
                return Math.Min(2, rawplacar) * 6;
            }

            private int GetPontoPorSimbolos(string senha)
            {
                int rawplacar = Regex.Replace(senha, "[a-zA-Z0-9]", "").Length;
                return Math.Min(2, rawplacar) * 5;
            }

            private int GetPontoPorRepeticao(string senha)
            {
                System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"(\w)*.*\1");
                bool repete = regex.IsMatch(senha);
                if (repete)
                {
                    return 30;
                }
                else
                {
                    return 0;
                }
            }

            public ForcaDaSenha GetForcaDaSenha(string senha)
            {
                int placar = geraPontosSenha(senha);

                if (placar < 50)
                    return ForcaDaSenha.Inaceitavel;
                else if (placar < 60)
                    return ForcaDaSenha.Fraca;
                else if (placar < 80)
                    return ForcaDaSenha.Aceitavel;
                else if (placar < 100)
                    return ForcaDaSenha.Forte;
                else
                    return ForcaDaSenha.Segura;
            }
        }
    }
}
