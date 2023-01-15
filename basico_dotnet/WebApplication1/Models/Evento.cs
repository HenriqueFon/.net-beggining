namespace WebApplication1.Models
{
    public class Evento
    {
        public int EventoId { get; set; }
        
        public string Local { get; set; }

        public string DataEvento { get; set; }

        public string Tema { get; set; }

        public int QtdPessoas { get; set; }

        public String Lote { get; set;}

        public String ImagemURL { get; set;}
    }
}
