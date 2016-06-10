using Mensagem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mensagem.Controllers
{
    public class EDisciplinasController : Controller
    {
        [HttpGet]
        public ActionResult Mensagem(long idT, long idD)
        {
            var mensagem = new DMensagensMetadado
            {
                idtopico = idT,
                idlogin = idD
            };

            return View(mensagem);
        }

        [ValidateInput(false)]
        [HttpPost]
        public ActionResult Mensagem(DMensagensMetadado mensagem)
        {

            if (ModelState.IsValid)
            {
               // var retorno = mensagemAplicacao.SalvaMensagem(mensagem.idtopico, mensagem.idlogin, mensagem.fptg_mensagem).ToString(); 
                var retorno = true;

                if (!retorno)
                {
                    return View(mensagem);
                }

                return Json(new { success = true }, JsonRequestBehavior.AllowGet); 
            }

            return View(mensagem);
        }
    }
}