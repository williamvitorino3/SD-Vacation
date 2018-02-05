using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

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
                int media = 0;
                for(int i = dados[0]; i <= dados[1]; i+=1)
                    media += i;
                return "Crescente";
                // Converter a media pra string e retornar.
            }
            if(dados[0] > dados[1])
            {
                int media = 0;
                for(int i = dados[0]; i <= dados[1] && i%2 == 0; i+=1)
                    media += i;
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
        public double[] post([FromBody]double dinheiro)
        {
            double m50 = 0, m25 = 0, m10 = 0;
            
            m50 = dinheiro/0.5;
            m25 = (dinheiro%0.5)/0.25;
            m10 = ((dinheiro%0.5)%0.25)/0.1;

            return new double[3]{m50, m25, m10}; // Acho que isso não funciona.
        }
    }

    // Q5
    // [Route("api/[controller]")]
    // public class Gasolina: Controller
    // {
    //     private class Response
    //     {
    //         private float velocidade = {get; set;};
    //         private float tempo = {get; set;};
    //         private float distancia = {get; set;};
    //         private float litros = {get; set;};
    //     }
    //     // [HttpPost]
    //     // Definir um objeto pro retorno.
    // }
}
