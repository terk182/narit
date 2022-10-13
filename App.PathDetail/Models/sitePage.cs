using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.PathDetail.Models
{
    public class sitePage
    {
     
            public string? th_title { get; set; }
            public string? en_title { get; set; }
            public string? description { get; set; }
            public string? url { get; set; }
            public string? roles { get; set; }
            public List<SiteMapNode>? siteMapNode { get; set; }
    }
        // Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
        public class Item
    {
        public string? comment { get; set; }
        //public string? comment1 { get; set; }
        //public string? comment2 { get; set; }
        //public string? comment3 { get; set; }
        //public string? comment4 { get; set; }
        //public string? comment5 { get; set; }
        //public string? comment6 { get; set; }
        //public string? comment7 { get; set; }
        //public string? comment8 { get; set; }
        //public string? comment9 { get; set; }
        //public string? comment10 { get; set; }
        //public string? comment11 { get; set; }
        //public string? comment12 { get; set; }
        //public string? comment13 { get; set; }
        //public string? comment14 { get; set; }
        //public string? comment15 { get; set; }
        //public string? comment16 { get; set; }
    }



    public class SiteMapNode
    {
        public string? th_title { get; set; }
        public string? eh_title { get; set; }
        public string? url { get; set; }
        public string? roles { get; set; }
        public string? comment { get; set; }
        public string? comment1 { get; set; }
        public string? comment2 { get; set; }
        public string? comment3 { get; set; }
        public string? comment4 { get; set; }
        public string? comment5 { get; set; }
        public string? comment6 { get; set; }
        public string? comment7 { get; set; }
        public string? comment8 { get; set; }
        public string? comment9 { get; set; }
        public string? comment10 { get; set; }
        public string? comment11 { get; set; }
        public string? comment12 { get; set; }
        public string? comment13 { get; set; }
        public string? comment14 { get; set; }
        public string? comment15 { get; set; }
        public string? comment16 { get; set; }
        public List<SiteMapNode>? siteMapNode { get; set; }

        
        public bool? SelfClosing { get; set; }
        public Item? item { get; set; }
    }


}
