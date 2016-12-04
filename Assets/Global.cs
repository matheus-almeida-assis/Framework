using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Assets.Global
{
    public class Global
    {
        public object IfElse(bool Acondicao, object Avalor1, object Avalor2)
        {
            if (Acondicao)
            {
                return Avalor1;
            }
            else
            {
                return Avalor2;
            }
        }

        public int IfElse(bool Acondicao, int Avalor1, int Avalor2)
        {
            if (Acondicao)
            {
                return Avalor1;
            }
            else
            {
                return Avalor2;
            }
        }

        public float IfElse(bool Acondicao, float Avalor1, float Avalor2)
        {
            if (Acondicao)
            {
                return Avalor1;
            }
            else
            {
                return Avalor2;
            }
        }


        public double IfElse(bool Acondicao, double Avalor1, double Avalor2)
        {
            if (Acondicao)
            {
                return Avalor1;
            }
            else
            {
                return Avalor2;
            }
        }


        public string IfElse(bool Acondicao, string Avalor1, string Avalor2)
        {
            if (Acondicao)
            {
                return Avalor1;
            }
            else
            {
                return Avalor2;
            }
        }

        public string IfElse(bool Acondicao, string Avalor1, string Avalor2, object[] Aargs1, object[] Aargs2)
        {
            if (Aargs1.Length > 0)
            {
                Avalor1 = string.Format(Avalor1, Aargs1);
            }
            if (Aargs2.Length > 0)
            {
                Avalor1 = string.Format(Avalor2, Aargs2);
            }
            return IfElse(Acondicao, Avalor1, Avalor2);
        }

        public char IfElse(bool Acondicao, char Avalor1, char Avalor2)
        {
            if (Acondicao)
            {
                return Avalor1;
            }
            else
            {
                return Avalor2;
            }
        }

        public string IfEmpty(string AseqBase, string AseqIfEmpty, bool AusarTrim)
        {
            if (AusarTrim)
            {
                AseqBase = AseqBase.Trim();
                AseqIfEmpty = AseqIfEmpty.Trim();
            }
            return IfElse(string.IsNullOrEmpty(AseqBase), AseqIfEmpty, AseqBase);
        }

        public int IfEmpty(int AnumBase, int AnumIfEmpty)
        {
            return IfElse(AnumBase == 0, AnumIfEmpty, AnumBase);
        }

        public string IfEmpty(int AnumBase, string AnumIfEmpty)
        {
            return IfElse(AnumBase == 0, AnumIfEmpty, Convert.ToString(AnumBase));
        }

        public float IfEmpty(float AnumBase, float AnumIfEmpty)
        {
            return IfElse(AnumBase == 0, AnumIfEmpty, AnumBase);
        }

        public double IfEmpty(double AnumBase, double AnumIfEmpty)
        {
            return IfElse(AnumBase == 0, AnumIfEmpty, AnumBase);
        }

        public int IfMax(int AnumBase, int Amax)
        {
            return IfElse(AnumBase > Amax, AnumBase, Amax);
        }

        public float IfMax(float AnumBase, float Amax)
        {
            return IfElse(AnumBase > Amax, AnumBase, Amax);
        }

        public double IfMax(double AnumBase, double Amax)
        {
            return IfElse(AnumBase > Amax, AnumBase, Amax);
        }

        public double IfMin(double AnumBase, double Amin)
        {
            return IfElse(AnumBase < Amin, Amin, AnumBase);
        }

        public int IfMin(int AnumBase, int Amin)
        {
            return IfElse(AnumBase < Amin, Amin, AnumBase);
        }

        public float IfMin(float AnumBase, float Amin)
        {
            return IfElse(AnumBase < Amin, Amin, AnumBase);
        }

        public string IfnEmpty(string Aseq, string Aprefixo = "", string Asufixo = "", bool Afomatar = true)
        {
            var minhaCultura = new CultureInfo("pt-BR"); //pt-BR usada como base
            minhaCultura.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            minhaCultura.DateTimeFormat.ShortTimePattern = "HH:mm";
            minhaCultura.NumberFormat.NumberDecimalDigits = 2;
            minhaCultura.NumberFormat.NumberGroupSeparator = "_";
            minhaCultura.NumberFormat.NumberDecimalSeparator = ",";
            minhaCultura.NumberFormat.NumberGroupSeparator = ".";
            return IfElse(!string.IsNullOrEmpty(Aseq.Trim()), IfElse(Afomatar, string.Format(minhaCultura, Aprefixo) + string.Format(minhaCultura, Aseq) + string.Format(minhaCultura, Asufixo), Aprefixo + Aseq + Asufixo), "");
        }

        public bool ValorEntre(int Avalor, int Amin, int Amax)
        {
            return (Avalor >= Amin) && (Avalor <= Amax);
        }

        public bool ValorEntre(double Avalor, double Amin, double Amax)
        {
            return (Avalor >= Amin) && (Avalor <= Amax);
        }

        public bool ValorEntre(float Avalor, float Amin, float Amax)
        {
            return (Avalor >= Amin) && (Avalor <= Amax);
        }

        public bool MesmoValor(int Avalor1, int Avalor2)
        {
            return Avalor1 == Avalor2;
        }

        public bool MesmoValor(float Avalor1, float Avalor2)
        {
            return Avalor1 == Avalor2;
        }

        public bool MesmoValor(double Avalor1, double Avalor2)
        {
            return Avalor1 == Avalor2;
        }

        public float Maior(float[] Avalores)
        {
            if (Avalores.Length > 0)
            {
                float maior = Avalores[0];
                for (int i = 1; i < Avalores.Length; i++)
                {
                    if (Avalores[i] > maior)
                    {
                        maior = Avalores[i];
                    }
                }
                return maior;
            }
            else
            {
                return 0;
            }
        }

        public double Maior(double[] Avalores)
        {
            if (Avalores.Length > 0)
            {
                double maior = Avalores[0];
                for (int i = 1; i < Avalores.Length; i++)
                {
                    if (Avalores[i] > maior)
                    {
                        maior = Avalores[i];
                    }
                }
                return maior;
            }
            else
            {
                return 0;
            }
        }

        public int Maior(int[] Avalores)
        {
            if (Avalores.Length > 0)
            {
                int maior = Avalores[0];
                for (int i = 1; i < Avalores.Length; i++)
                {
                    if (Avalores[i] > maior)
                    {
                        maior = Avalores[i];
                    }
                }
                return maior;
            }
            else
            {
                return 0;
            }
        }

        public float Menor(float[] Avalores)
        {
            if (Avalores.Length > 0)
            {
                float menor = Avalores[0];
                for (int i = 1; i < Avalores.Length; i++)
                {
                    if (Avalores[i] < menor)
                    {
                        menor = Avalores[i];
                    }
                }
                return menor;
            }
            else
            {
                return 0;
            }
        }

        public int Menor(int[] Avalores)
        {
            if (Avalores.Length > 0)
            {
                int menor = Avalores[0];
                for (int i = 1; i < Avalores.Length; i++)
                {
                    if (Avalores[i] < menor)
                    {
                        menor = Avalores[i];
                    }
                }
                return menor;
            }
            else
            {
                return 0;
            }
        }

        public double Menor(double[] Avalores)
        {
            if (Avalores.Length > 0)
            {
                double menor = Avalores[0];
                for (int i = 1; i < Avalores.Length; i++)
                {
                    if (Avalores[i] < menor)
                    {
                        menor = Avalores[i];
                    }
                }
                return menor;
            }
            else
            {
                return 0;
            }
        }

        public string NomeMaquina()
        {
            return Environment.MachineName;
        }

        public string NomeUsuario()
        {
            return Environment.UserName;
        }

        public string Prencher(string Atexto, int Aqtd, string Aencher = " ", bool Adireita = true)
        {
            string saida = "";

            for (int i = 0; i < Aqtd - Atexto.Length; i++)
            {
                saida += Aencher;
            }
            if (Adireita)
            {
                return saida + Aencher;
            }
            else
            {
                return Aencher + saida;
            }
        }

        public bool SomenteNumeros(string ATexto)
        {
            char[] ArrayValor = ATexto.ToCharArray();

            foreach (var valor in ArrayValor)
            {
                if (!char.IsDigit(valor))
                {
                    return false;
                }
            }
            return true;
        }

        public bool EhCnpj(string Acnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            Acnpj = Acnpj.Trim();
            Acnpj = Acnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (Acnpj.Length != 14)
                return false;
            tempCnpj = Acnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return Acnpj.EndsWith(digito);
        }

        public static bool EhCpf(string Acpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            Acpf = Acpf.Trim();
            Acpf = Acpf.Replace(".", "").Replace("-", "");
            if (Acpf.Length != 11)
                return false;
            tempCpf = Acpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return Acpf.EndsWith(digito);
        }

        public bool EhPis(string Apis)
        {
            int[] multiplicador = new int[10] { 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            if (Apis.Trim().Length != 11)
                return false;
            Apis = Apis.Trim();
            Apis = Apis.Replace("-", "").Replace(".", "").PadLeft(11, '0');

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(Apis[i].ToString()) * multiplicador[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            return Apis.EndsWith(resto.ToString());
        }

        public string AddSep(string Atexto, string Aseq, string Asep = ",")
        {
            return IfElse(string.IsNullOrEmpty(Atexto.Trim()), Atexto + Aseq, Atexto + Asep + Aseq);
        }

        public string PadraoMaiusculo(string Atexto)
        {
            char[] array = Atexto.Trim().ToCharArray();
            if (array.Length >= 1)
            {
                if (char.IsLower(array[0]))
                {
                    array[0] = char.ToUpper(array[0]);
                }
            }
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == ' ')
                {
                    if (char.IsLower(array[i]))
                    {
                        array[i] = char.ToUpper(array[i]);
                    }
                }
            }
            return new string(array);
        }
    }
}
