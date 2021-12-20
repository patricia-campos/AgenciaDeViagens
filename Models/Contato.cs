using System.ComponentModel.DataAnnotations;

namespace AgenciaDeViagens.Models
{
    public class Contato
    {
        [Key]
        public int num_contato { get; set; }
        public DateTime data_contato { get; set; }
        public string nome_cliente { get; set; }
        public string email_cliente { get; set; }
        public string destino { get; set; }
        public string mensagem { get; set; }

    }
}
