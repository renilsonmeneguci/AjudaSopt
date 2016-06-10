using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mensagem.Models
{
    public class DMensagensMetadado
    {
        public long idtopico { get; set; }
        public long idlogin { get; set; }
        public long iddisc { get; set; }
        [AllowHtml]
        public String fptg_mensagem { get; set; }
    }
}