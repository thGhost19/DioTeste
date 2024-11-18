using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraService
    {
        private List<string> historico = [];
        public int SomarInteiros(int x, int y){
            historico.Insert(0, $"{x} + {y} = {x+y}");
            return x + y;
        }

        public int SubtrairInteiros(int x, int y){
            historico.Insert(0, $"{x} - {y} = {x-y}");
            return x - y;
        }

        public int MultiplicarInteiros(int x, int y){
            historico.Insert(0, $"{x} * {y} = {x*y}");
            return x * y;
        }

        public int DividirInteiros(int x, int y){
            if (y==0)
            {
                historico.Insert(0, $"{x} * {y} = 0");
                return 0;
            }
            double resultado = (double)x / y;
            historico.Insert(0, $"{x} / {y} = {Math.Ceiling(resultado)}");
            return (int)Math.Ceiling(resultado);
        }

        public List<string> Historico(){
            
            if (historico.Count > 3)
            {
                historico.RemoveRange(3, historico.Count-3);
            }
            return historico;
        }
    }
}