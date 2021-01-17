using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BIPIT_10.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        бипит3Entities1 db = new бипит3Entities1();
        

        public ActionResult Oboryd()
        {
            IEnumerable<Oboryd> oboryd = db.Oboryd;
            ViewBag.Oboryd = oboryd;
            return View("oboryd");
        }

        [HttpGet]
        public ActionResult oboryd_add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult oboryd_add(Oboryd s)
        {
            db.Oboryd.Add(s);
            db.SaveChanges();
            return RedirectToAction("oboryd");
        }
        public ActionResult oboryd_delete(int id)
        {
            Oboryd s = new Oboryd { Id = id };
            db.Entry(s).State = EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("oboryd");
        }

        [HttpGet]
        public ActionResult oboryd_edit(int? id)
        {
            if (id == null)
                return HttpNotFound();
            Oboryd s = db.Oboryd.Find(id);
            if (s != null)
                return View(s);
            return HttpNotFound();
        }

        [HttpPost]
        public ActionResult oboryd_edit(Oboryd s)
        {
            db.Entry(s).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("oboryd");
        }

        public ActionResult Vid_rabot()
        {
            IEnumerable<Vid_rabot> vid_rabot = db.Vid_rabot;
            ViewBag.Vid_rabot = vid_rabot;
            return View("vid_rabot");
        }
        [HttpGet]
        public ActionResult vid_rabot_add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult vid_rabot_add(Vid_rabot s)
        {
            db.Vid_rabot.Add(s);
            db.SaveChanges();
            return RedirectToAction("vid_rabot");
        }
        public ActionResult vid_rabot_delete(int id)
        {
            Vid_rabot s = new Vid_rabot { Id = id };
            db.Entry(s).State = EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("vid_rabot");
        }

        [HttpGet]
        public ActionResult vid_rabot_edit(int? id)
        {
            if (id == null)
                return HttpNotFound();
            Vid_rabot s = db.Vid_rabot.Find(id);
            if (s != null)
                return View(s);
            return HttpNotFound();
        }

        [HttpPost]
        public ActionResult vid_rabot_edit(Vid_rabot s)
        {
            db.Entry(s).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("vid_rabot");
        }



        public ActionResult Rabot()
        {
            IEnumerable<Rabot> rabot = db.Rabot;
            ViewBag.Rabot = rabot;
            return View("rabot");
        }


        [HttpGet]
        public ActionResult rabot_add()
        {
            SelectList Oboryd = new SelectList(db.Oboryd, "Id", "Model_oboryd");
            ViewBag.Oboryd = Oboryd;
            SelectList Vid_rabot = new SelectList(db.Vid_rabot, "Id", "Name_vid_rabot");
            ViewBag.Vid_rabot = Vid_rabot;
            return View();
        }

        [HttpPost]
        public ActionResult rabot_add(Rabot a)
        {
            db.Rabot.Add(a);
            db.SaveChanges();
            return RedirectToAction("Rabot");
        }

        [HttpGet]
        public ActionResult rabot_edit(int? id)
        {
            if (id == null)
                return HttpNotFound();
            Rabot app = db.Rabot.Find(id);
            if (app != null)
            {
                SelectList Oboryd = new SelectList(db.Oboryd, "Id", "Model_oboryd");
                ViewBag.Oboryd = Oboryd;
                SelectList Vid_rabot = new SelectList(db.Vid_rabot, "Id", "Name_vid_rabot");
                ViewBag.Vid_rabot = Vid_rabot;
                return View(app);
            }

            return HttpNotFound();
        }

        [HttpPost]
        public ActionResult rabot_edit(Rabot a)
        {
            db.Entry(a).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Rabot");
        }

        public ActionResult rabot_delete(int id)
        {
            Rabot a = new Rabot { Id = id };
            db.Entry(a).State = EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("Rabot");
        }
    }
}