using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portifolio.Models
{
    public class Veiculo
    {
        public int ID { get; set; }


        
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Placa Cavalo")]
        public string PlacaVeic { get; set; }


        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Placa Carreta 1")]
        public string PlacaCarre1Veic { get; set; }


       
        [Display(Name = "Placa Carreta 2")]
        public string PlacaCarre2Veic{ get; set; }




        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Modelo Veiculo")]
        public string ModeloVeic { get; set; }



        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Marca Veiculo")]
        public string MarcaVeic { get; set; }



        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Capacidade Peso")]
        public double CapacidadeVeic { get; set; }


        // (Propriedade de navegação de coleção) Estou indicando que o Veiculo pode possuir varias notas fiscais
        
        public ICollection<NotaFiscal> NotaFiscal { get; set; }
    }
}
