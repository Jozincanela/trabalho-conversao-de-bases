using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_conversão_de_bases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char Descisao = 'S';
            while (Descisao == 'S')
            {
                Console.Clear();
                Console.WriteLine("qual a base do numero que sera modificado?");
                Console.WriteLine("1- binario 2- decimal 3- octal 4- hexadecimal");
                int base_modificada = int.Parse(Console.ReadLine());

                //hexdecimal
                if (base_modificada == 4)
                {
                    Console.WriteLine("qual o numero nesta base");
                    string numero = Console.ReadLine();
                    Console.WriteLine("qual base esse numero sera convertido");
                    int base_escolhida = int.Parse(Console.ReadLine());
                    Conversor_hex_decimal(numero, base_escolhida);

                }
                //binario-ok
                else if (base_modificada == 1)
                {
                    Console.WriteLine("qual o numero nesta base");
                    string numero = Console.ReadLine();
                    Console.WriteLine("qual base esse numero sera convertido");
                    int base_escolhida = int.Parse(Console.ReadLine());
                    Convertor_binario_decimal(numero, base_escolhida);

                }
                // decimal
                else if (base_modificada == 2)
                {
                    Console.WriteLine("qual o numero nesta base");
                    int numero = int.Parse(Console.ReadLine());
                    Console.WriteLine("qual base esse numero sera convertido");
                    int base_escolhida = int.Parse(Console.ReadLine());

                    if (base_escolhida == 1)
                    {
                        int baseN = 2;
                        Convertor_decimal(numero, baseN, 2);
                    }
                    else if (base_escolhida == 3)
                    {
                        int baseN = 8;
                        Convertor_decimal(numero, baseN, 2);
                    }
                    else if (base_escolhida == 4)
                    {
                        int baseN = 16;
                        Convertor_decimal(numero, baseN, 2);
                    }

                }
                //octal
                else if (base_modificada == 3)
                {
                    Console.WriteLine("qual o numero nesta base");
                    string numero = Console.ReadLine();
                    Console.WriteLine("qual base esse numero sera convertido");
                    int base_escolhida = int.Parse(Console.ReadLine());
                    Convertor_octal_decimal(numero, base_escolhida);

                }
                else
                {
                    Console.WriteLine("base invalida ou inexistente");
                }
                Console.WriteLine("deseja repetir o processo?");
                Console.WriteLine("(S/N)");
                Descisao = char.Parse(Console.ReadLine());

            }

        }





        static void Convertor_decimal(int numero, int base_numerica, int base_conversão)
        {

            int resto;
            string resto1 = "";
            
            

            Console.WriteLine("agora iremos converter o seu numero para a base escolhida");

            while (numero > 1 || numero > 0)
            {
                Console.Write("o resto de " + numero + " dividido por " + base_numerica + " é: ");
                resto = numero % base_numerica;

                Console.WriteLine(resto);
                numero = numero / base_numerica;
                if(resto < 10)
                {
                    resto1 += resto + "";
                }
                else if (resto == 10)
                {
                    
                    resto1 += 'A';
                    Console.WriteLine("por causa das regras da base hexadecimal o resto: " + resto + " foi convertido  para:" + resto1);

                }
                else if (resto== 11)
                {
                    resto1 += 'B';
                    Console.WriteLine("por causa das regras da base hexadecimal o resto: " + resto + " foi convertido  para:" + resto1);
                }
                else if(resto== 12)
                {
                    resto1 += 'C';
                    Console.WriteLine("por causa das regras da base hexadecimal o resto: " + resto + " foi convertido  para:" + resto1);
                }
                else if (resto == 13)
                {
                    resto1 += 'D';
                    Console.WriteLine("por causa das regras da base hexadecimal o resto: " + resto + " foi convertido  para:" + resto1);
                }
                else if (resto == 14)
                {
                    resto1 += 'E';
                    Console.WriteLine("por causa das regras da base hexadecimal o resto: " + resto + " foi convertido  para:" + resto1);
                }
                else if (resto == 15)
                {
                    resto1 += 'F';
                    Console.WriteLine("por causa das regras da base hexadecimal o resto: " + resto + " foi convertido  para:" + resto1);
                }
                

                

            }
            string restoinvertida = string.Join("", resto1.Reverse());
            Console.WriteLine();
            Console.Write("a conversão dará resultado á: ");
            Console.Write(restoinvertida);
            Console.WriteLine();
            if (base_conversão == 1)
            {
                Convertor_binario_decimal(restoinvertida, 0);
            }
            else if (base_conversão == 3)
            {
                Convertor_octal_decimal(restoinvertida, 0);
            }else if(base_conversão== 4)
            {
                Conversor_hex_decimal(restoinvertida , 0);
            }

        }








        static void Convertor_binario_decimal(string binario, int base_escolhida)
        {
            double potencia = 0;
            double x = 0;
            double resultado_total = 0;

            Console.WriteLine();
            Console.WriteLine("agora iremos calcular o numero em binario para decimal ");

            for (int i = binario.Length - 1; i >= 0; i--)
            {

                potencia = Math.Pow(2, x);

                if (binario[i] == '1')
                {
                    Console.WriteLine(" 1  vezes 2  elevado a " + x + " é: " + potencia);
                }
                else if (binario[i] == '0')
                {
                    Console.WriteLine(" 0  vezes 2  elevado a " + x + "é: 0");
                    potencia = 0;

                }
                Console.Write(resultado_total + " + " + potencia + "=");
                resultado_total += potencia;
                Console.Write(resultado_total);
                Console.WriteLine();
                x++;


            }

            if (base_escolhida == 3)
            {
                Convertor_decimal(Convert.ToInt32(resultado_total), 8, 0);
            }
            else if (base_escolhida == 4)
            {
                Convertor_decimal(Convert.ToInt32(resultado_total), 16, 0);
            }
        }



        static void Convertor_octal_decimal(string octal, int base_escolhida)
        {
            double potencia = 0;
            double x = 0;
            double resultado_total = 0;
            double resultado = 0;

            Console.WriteLine();
            Console.WriteLine("agora iremos calcular o numero em octal para decimal");

            for (int i = octal.Length - 1; i >= 0; i--)
            {

                potencia = Math.Pow(8, x);


                if (octal[i] == '1')
                {
                    resultado = 1 * potencia;
                    Console.WriteLine(" 1  vezes 8  elevado a " + x + " é: " + resultado);

                }
                else if (octal[i] == '2')
                {
                    resultado = 2 * potencia;
                    Console.WriteLine(" 2  vezes 8  elevado a " + x + " é: " + resultado);
                }
                else if (octal[i] == '3')
                {
                    resultado = 3 * potencia;
                    Console.WriteLine(" 3  vezes 8 elevado a " + x + " é: " + resultado);
                }
                else if (octal[i] == '4')
                {
                    resultado = 4 * potencia;
                    Console.WriteLine(" 4  vezes 8  elevado a " + x + " é: " + resultado);
                }
                else if (octal[i] == '5')
                {
                    resultado = 5 * potencia;
                    Console.WriteLine(" 5  vezes 8  elevado a " + x + " é: " + resultado);
                }
                else if (octal[i] == '6')
                {
                    resultado = 6 * potencia;
                    Console.WriteLine(" 6  vezes 8  elevado a " + x + " é: " + resultado);
                }
                else if (octal[i] == '7')
                {
                    resultado = 7 * potencia;
                    Console.WriteLine(" 7  vezes 8  elevado a " + x + " é: " + resultado);
                }
                else if (octal[i] == '0')
                {
                    Console.WriteLine(" 0  vezes 8  elevado a " + x + "é: 0");

                    resultado = 0;
                }

                Console.Write(resultado_total + " + " + resultado + "=");
                resultado_total += resultado;
                Console.Write(resultado_total);
                Console.WriteLine();
                x++;

            }
            if (base_escolhida == 1)
            {
                Convertor_decimal(Convert.ToInt32(resultado_total), 2, 0);
            }else if (base_escolhida == 4)
            {
                Convertor_decimal(Convert.ToInt32(resultado_total), 16, 0);
            }
        }
        static void Conversor_hex_decimal(string hex, int base_escolhida)
        {
            double potencia = 0;
            double x = 0;
            double resultado_total = 0;
            double resultado = 0;

            Console.WriteLine();
            Console.WriteLine("agora iremos calcular o numero em hexadecimal para decimal");

            for (int i = hex.Length - 1; i >= 0; i--)
            {

                potencia = Math.Pow(16, x);

                if (hex[i] == '0')
                {
                    Console.WriteLine(" 0  vezes 16  elevado a " + x + "é: 0");

                    resultado = 0;
                }
                else if (hex[i] == '1')
                {
                    resultado = 1 * potencia;
                    Console.WriteLine(" 1  vezes 16  elevado a " + x + " é: " + resultado);

                }
                else if (hex[i] == '2')
                {
                    resultado = 2 * potencia;
                    Console.WriteLine(" 2  vezes 16  elevado a " + x + " é: " + resultado);
                }
                else if (hex[i] == '3')
                {
                    resultado = 3 * potencia;
                    Console.WriteLine(" 3  vezes 16 elevado a " + x + " é: " + resultado);
                }
                else if (hex[i] == '4')
                {
                    resultado = 4 * potencia;
                    Console.WriteLine(" 4  vezes 16  elevado a " + x + " é: " + resultado);
                }
                else if (hex[i] == '5')
                {
                    resultado = 5 * potencia;
                    Console.WriteLine(" 5  vezes 16 elevado a " + x + " é: " + resultado);
                }
                else if (hex[i] == '6')
                {
                    resultado = 6 * potencia;
                    Console.WriteLine(" 6  vezes 16  elevado a " + x + " é: " + resultado);
                }
                else if (hex[i] == '7')
                {
                    resultado = 7 * potencia;
                    Console.WriteLine(" 7  vezes 16  elevado a " + x + " é: " + resultado);
                }
                else if (hex[i] == '8')
                {
                    resultado = 8 * potencia;
                    Console.WriteLine(" 8  vezes 16  elevado a " + x + " é: " + resultado);
                }
                else if (hex[i] == '9')
                {
                    resultado = 9 * potencia;
                    Console.WriteLine(" 9  vezes 16  elevado a " + x + " é: " + resultado);
                }
                else if (hex[i] == 'a' || hex[i] == 'A')
                {
                    resultado = 10 * potencia;
                    Console.WriteLine(" 10  vezes 16  elevado a " + x + " é: " + resultado);
                }
                else if (hex[i] == 'b' || hex[i] == 'B')
                {
                    resultado = 11 * potencia;
                    Console.WriteLine(" 11  vezes 16  elevado a " + x + " é: " + resultado);
                }
                else if (hex[i] == 'c' || hex[i] == 'C')
                {
                    resultado = 12 * potencia;
                    Console.WriteLine(" 12  vezes 16  elevado a " + x + " é: " + resultado);
                }
                else if (hex[i] == 'd' || hex[i] == 'D')
                {
                    resultado = 13 * potencia;
                    Console.WriteLine(" 13  vezes 16  elevado a " + x + " é: " + resultado);
                }
                else if (hex[i] == 'e' || hex[i] == 'E')
                {
                    resultado = 14 * potencia;
                    Console.WriteLine(" 14  vezes 16  elevado a " + x + " é: " + resultado);
                }
                else if (hex[i] == 'f' || hex[i] == 'F')
                {
                    resultado = 15 * potencia;
                    Console.WriteLine(" 15  vezes 16  elevado a " + x + " é: " + resultado);
                }


                Console.Write(resultado_total + " + " + resultado + "=");
                resultado_total += resultado;
                Console.Write(resultado_total);
                Console.WriteLine();
                x++;

            }
            if (base_escolhida == 3)
            {
                Convertor_decimal(Convert.ToInt32(resultado_total), 8, 0);
            }
            else if (base_escolhida == 1)
            {
                Convertor_decimal(Convert.ToInt32(resultado_total), 2, 0);
            }
        }

    }
}



