using System;
using System.Collections.Generic;
using System.Globalization; //Lembrar de declarar a biblioteca para manipular datas
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulando_datas
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo cultureBr = new CultureInfo(name: "pt-BR"); //Cultura brasileira
            CultureInfo cultureEn = new CultureInfo(name: "en-US"); //Cultura inglesa

            //Console.WriteLine(DateTime.Now.ToString(cultureBr)); //Mostrando a data atual na cultura brasileira
            //Console.WriteLine(DateTime.Now.ToString(cultureEn)); //Mostrando a data atual na cultura inglesa

            //Exemplo:
            //Console.Write("Digite sua data de nascimento(dd/MM/yyyy): ");
            //string date = Console.ReadLine();

            string date = "03/11/2001";

            DateTime dataConvertida = DateTime.ParseExact(date, "d", cultureBr); //Passar o mesmo idioma que está sendo lido pela variável
            
            //Console.WriteLine(dataConvertida.ToString("dd/MM/yyyy")); //Mostrando na cultura brasileira
            Console.WriteLine(dataConvertida.ToString("MM/dd/yyyy")); //Mostrando na cultura inglesa

            Console.ReadKey();
        }
    }
}
