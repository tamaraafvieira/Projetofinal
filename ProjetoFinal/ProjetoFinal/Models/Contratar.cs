using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Models
{
    public class Contratar
    {
        private readonly string domain = AppDomain.CurrentDomain.BaseDirectory;
        public string Imagem { get; set; }
        public string Titulo { get; set; }
        public string Texto { get; set; }

        public List<Contratar> getCardInfo()
        {
            var json = File.ReadAllText(string.Format("{0}contratar.json", domain));

            var js = new DataContractJsonSerializer(typeof(List<Contratar>));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(json));

            List<Contratar> cardInfo = (List<Contratar>)js.ReadObject(ms);

            return cardInfo;
        }
    }
}
