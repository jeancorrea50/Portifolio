using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portifolio.Models
{
    public class Motorista
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Nome Completo")]
        public string NomeCompletoMot { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Cpf")]

        public int CpfMot { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Telefone")]
        [Phone]
        public int TelefoneMot { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Email")]
        [EmailAddress]
        public string EmailMot { get; set; }





        [Display(Name = "Data Nascimento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]

        public DateTime? DataNascimentoMot { get; set; }

        public Veiculo Veiculo { get; set; }
        public int VeiculoId { get; set; }

        // (Propriedade de navegação de coleção) Estou indicando que o Motorista pode possuir varias V




    }

}



