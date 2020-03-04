using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Data.SqlClient;
using System.Data;
using MVCLaboratorio.Utilerias;

namespace MVCLaboratorio.Controllers
{
    public class VideoController : Controller
    {
        //
        // GET: /Video/

        public ActionResult Index()
        {
            ViewData["video"] = BaseHelper.ejecutarConsulta("sp_video_verVideo2", CommandType.StoredProcedure);
            return View();
        }
        //Create
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(int idVideo,string titulo,int repro,string url)
        {
            //guardar datos
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("idVideo", idVideo));
            parametros.Add(new SqlParameter("titulo", titulo));
            parametros.Add(new SqlParameter("repro", repro));
            parametros.Add(new SqlParameter("url", url));

            BaseHelper.ejecutarSentencia("sp_video_insertar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("Index", "Video");
        }
        //Edit
        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(int idVideo,string titulo, int repro,string url)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("titulo", titulo));
            parametros.Add(new SqlParameter("repro", repro));
            parametros.Add(new SqlParameter("url", url));
            parametros.Add(new SqlParameter("idVideo", idVideo));

            BaseHelper.ejecutarSentencia("sp_video_editar2", CommandType.StoredProcedure, parametros);
            return RedirectToAction("Index", "Video");
        }
        //Delete
        public ActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Delete(int idVideo)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("idVideo", idVideo));

            BaseHelper.ejecutarSentencia("sp_video_borrar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("Index", "Video");
        }

    }
}
