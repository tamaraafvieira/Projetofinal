using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Models
{
    public class Categories
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public  string Area { get; set; }

        public List<Categories> GetJsonInfo()
        {
            var json = File.ReadAllText(string.Format("{0}categories.json", AppDomain.CurrentDomain.BaseDirectory));

            var js = new DataContractJsonSerializer(typeof(List<Categories>));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(json));

            List<Categories> jsonInfo = (List<Categories>)js.ReadObject(ms);

            return jsonInfo;
        }
    }
}
