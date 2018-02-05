using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sdApi.Models;

namespace sdApi.Controllers
{
    // Q1
    [Route("api/[controller]")]
    public class Notas: Controller
    {
        [HttpPost]
        public String post([FromBody]float[] notas)
        {
            var media = (notas[0]*2 + notas[1]*3)/5;
            return (media < 5 ? "Reprovado" : 
                (media < 7 ? "Recuperação" : "Aprovado"));
        }
    }

    // Q2
    [Route("api/[controller]")]
    public class Fumante: Controller
    {
        [HttpPost]
        public float post([FromBody]float[] dados)
        {
            return (
                dados[0] *
                    (dados[2]/
                        (
                            dados[1] == 0 ? 1 : dados[1]
                        )
                    )
                * 365);
        }
    }

    // Q3
    [Route("api/[controller]")]
    public class Numeros: Controller
    {
        [HttpPost]
        public String post([FromBody]int[] dados)
        {
            if(dados[0] < dados[1])
            {
                int qtd = 0, sum = 0;
                for(int i = dados[0]; i <= dados[1]; i+=1, qtd +=1)
                    sum += i;
                return Convert.ToString(sum/qtd);
            }
            if(dados[0] > dados[1])
            {
                int qtd = 0;
                for(int i = dados[0]; i >= dados[1]; i-=1)
                    if(i%2 == 0)
                        qtd += 1;
                return Convert.ToString(qtd);// "Decrescente";
                // Converter a media pra string e retornar.
            }
            return "Iguais";
        }
    }

    // Q4
    [Route("api/[controller]")]
    public class Moedas: Controller
    {
        [HttpPost]
        public int[] post([FromBody]double dinheiro)
        {
            int m50 = 0, m25 = 0, m10 = 0;
            dinheiro *= 100;
            m50 = (int)dinheiro/50;
            dinheiro%=50;
            m25 = (int)dinheiro/25;
            dinheiro%=25;
            m10 = (int)dinheiro/10;

            return new int[3]{m50, m25, m10}; // Acho que isso não funciona.
        }
    }

    // Q5
    [Route("api/[controller]")]
    public class Gasolina: Controller
    {
        [HttpPost]
        public DadosViagem post()
        {
            
        }
        // Definir um objeto pro retorno.
    }
}
