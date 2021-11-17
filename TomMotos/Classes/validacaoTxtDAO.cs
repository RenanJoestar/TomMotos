using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TomMotos.Classes
{
    class validacaoTxtDAO
    {
        #region VALIDAÇÃO DE VALOR
        public static void FormatarValores(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
                {

                    TextBox t = (TextBox)sender;
                    string w = Regex.Replace(t.Text, "[^0-9]", string.Empty);
                    if (w == string.Empty) w = "00";

                    if (e.KeyChar.Equals((char)Keys.Back))
                        w = w.Substring(0, w.Length - 1);
                    else
                        w += e.KeyChar;

                    t.Text = string.Format("{0:#,##0.00}", Double.Parse(w) / 100);
                    t.Select(t.Text.Length, 0);
                }
                e.Handled = true;
            }
            catch (Exception erro) 
            {
                MessageBox.Show(erro.Message);
            }
        }
        #endregion
        #region VALIDAÇÃO DE PORCENTAGEM
        public static void FormatarPorcentagem(object sender, KeyPressEventArgs e)
        {
            try { 
            if (char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
            {

                TextBox t = (TextBox)sender;
                string w = Regex.Replace(t.Text, "[^0-9]", string.Empty);
                if (w == string.Empty) w = "00";

                if (e.KeyChar.Equals((char)Keys.Back))
                    w = w.Substring(0, w.Length - 1);
                else
                    w += e.KeyChar;

                t.Text = string.Format("{0:F2}", Double.Parse(w) / 100);
                t.Select(t.Text.Length, 0);
            }
            e.Handled = true;
          }
            catch (Exception erro) 
            {
                MessageBox.Show(erro.Message);
            }
}
        #endregion


        #region VALIDAR CNPJ

        public static bool validarCnpj(string cnpj)
        {
            try
            {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            int somador, resto;
            string digito, cnpjAux;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(",", "").Replace("/", "").Replace("-", "");
            if (cnpj.Length != 14)
            {
                return false;
            }
            else
            {
               
                    cnpjAux = cnpj.Substring(0, 12);
                somador = 0;
                for (int i = 0; i < 12; i++)
                {
                    somador += int.Parse(cnpjAux[i].ToString()) * multiplicador1[i];
                }
                resto = (somador % 11);
                if (resto < 2) resto = 0;
                else resto = 11 - resto;
                digito = resto.ToString();
                cnpjAux = cnpjAux + digito;
                somador = 0;
                for (int i = 0; i < 13; i++)
                {
                    somador += int.Parse(cnpjAux[i].ToString()) * multiplicador2[i];
                }
                resto = (somador % 11);
                if (resto < 2) resto = 0;
                else resto = 11 - resto;
                digito = digito + resto.ToString();//concatenar o 1º com o 2º "00"
                 return cnpj.EndsWith(digito);//se for igual retorna true se nao false
                }
                
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                return false;
            }


        }

        #endregion

        #region VALIDAÇÃO DE CPF
        public static bool ValidarCPF(string cpf)
        {
            try
            {
                int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                int soma, resto;
                string digito, cpfAux;
                cpf = cpf.Trim();
                cpf = cpf.Replace(",", "").Replace("-", "");
                cpfAux = cpf.Substring(0, 9);
                soma = 0;
                if (cpf.Length != 11)
                {
                    return false;
                }
                else
                {
                    for (int i = 0; i < 9; i++)
                    {
                        soma += int.Parse(cpfAux[i].ToString()) * multiplicador1[i];
                    }
                    resto = soma % 11;
                    if (resto < 2)
                    {
                        resto = 0;
                    }
                    else resto = 11 - resto;
                    digito = resto.ToString();
                    cpfAux = cpfAux + digito;
                    soma = 0;
                    for (int i = 0; i < 10; i++)
                    {
                        soma += int.Parse(cpfAux[i].ToString()) * multiplicador2[i];
                    }
                    resto = soma % 11;
                    if (resto < 2)
                    {
                        resto = 0;
                    }
                    else resto = 11 - resto;
                    digito = digito + resto.ToString();
                    return cpf.EndsWith(digito);
                }
            }
            catch (Exception erro) 
            {
                MessageBox.Show(erro.Message);
                return false;
            }
          }
        
        #endregion
    }

}
