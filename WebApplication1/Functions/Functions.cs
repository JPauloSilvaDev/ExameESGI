using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TesteAdmissao.Models;
using TesteAdmissao.Repository;

namespace TesteAdmissao.Functions
{
    public class Calculo
    {
        

        public static void fncCalculo(int codigoCargo, Pessoa_Salario pessoa)
        {
            DB db = new DB();
            //Optei por deixar os valores vindo direto do banco para caso houvesse alguma alteração no mesmo não ser necessário alterar na função.

            var vencimento = db.Vencimentos.ToList();
            var planoSaude = vencimento.Where(x=>x.ID == 8).FirstOrDefault().Valor;
            var previdencia = vencimento.Where(x => x.ID == 9).FirstOrDefault().Valor;
            var bonusCoordenador = vencimento.Where(x => x.ID == 6).FirstOrDefault().Valor;
            var bonusGerente = vencimento.Where(x => x.ID == 7).FirstOrDefault().Valor;
            
            var vlrVct = vencimento.Where(x=>x.ID == codigoCargo).FirstOrDefault().Valor;

            switch (codigoCargo)
            {
                case 1:
                    pessoa.Salario += vlrVct;
                    break;
                case 2:
                    pessoa.Salario += vlrVct - previdencia - planoSaude;
                    break;
                case 3:
                    pessoa.Salario += vlrVct - previdencia - planoSaude;
                    break;
                case 4:
                    pessoa.Salario += vlrVct - previdencia - planoSaude + bonusCoordenador;
                    break;
                case 5:
                    pessoa.Salario += vlrVct - previdencia - planoSaude + bonusGerente;
                    break;
                default:
                    break;
            }

            return;
        }
    
    
    }
}