using NPOI.SS.Formula.Functions;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portifolio.Models
{
    public class NotaFiscal
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Numero Nf")]
        public int NumeroNf { get; set; }



        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Serie")]
        public int SerieNf { get; set; }


        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Remetente")]
        public string RemetenteNf { get; set; }


        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Destinatario")]
        public string DestinatarioNf { get; set; }


        [Required(ErrorMessage = "Este campo é obrigatório")]

        [Display(Name = "Data Emissão")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime DataEmissaoNf { get; set; }



        [Range(1, int.MaxValue, ErrorMessage = "O Valor deve ser Maior que zero")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Valor")]
        public Decimal ValorNf { get; set; }



        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Descrição Produto")]
        public string ProdutoNf { get; set; }


        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Peso Liquido")]
        public double PesoNf { get; set; }

        public Agenda Agenda { get; set; }
     


        // (Propriedade de navegação de referencia) Indico que Produtos está ligado a Clientes, e que cada produto precisa ter um cliente vinculado.










    }
}
