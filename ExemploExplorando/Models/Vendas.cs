using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Models
{
    public class Vendas
    {
        public int ID { get; set; }

        // usar essa propriedade quando vim com um formato diferente do que se usa no dotnet por exemplo.
        [JsonProperty("Nome_Produto")]
        public string Produto { get; set; }
        
        public decimal Preço { get; set; }
        public DateTime DataVenda { get; set; }

        public decimal? Desconto { get; set; }
    }
}