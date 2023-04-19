using System.Collections.Generic;
using Pacoco.Domain;
namespace Pacoco.Domain.Evento
{
    public class Evento
    {
        public int Id { get; set; }
        public string Local { get; set; }
        public string DataEvento { get; set; }
        public string TemaEvento { get; set; }
        public int QntPessoas { get; set; }   
        public string Lote { get; set; }  
        public string ImgEvento { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public IEnumerable<Lote> Lotes { get; set; }
        public IEnumerable<RedeSocial> RedesSociais { get; set; }
    }
}