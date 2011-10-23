using System;
using System.Web.Mvc;
using NHibernate;
using PPT.Web.Code.Domain;

namespace PPT.Web.Controllers
{
    public class ContactController : Controller
    {
        private readonly ISession _session;

        public ContactController(ISession session)
        {
            _session = session;
        }

        public ActionResult Index(int pageNumber = 1, int pageSize = 25)
        {
            var page = _session.QueryOver<Contact>()
                                .Skip((pageNumber - 1)*pageSize)
                                .Take(pageSize)
                                .List();

            return View(page);
        }

        //
        // GET: /Contact/Details/5

        public ActionResult Details(int id)
        {
            return View(_session.Load<Contact>(id));
        }

        //
        // GET: /Contact/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Contact/Create

        [HttpPost]
        public ActionResult Create(Contact contact)
        {
            try
            {
                using (var tx = _session.BeginTransaction())
                {
                    _session.SaveOrUpdate(contact);
                    tx.Commit();
                }

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("contact", ex.ToString());
                return View();
            }
        }
        
        //
        // GET: /Contact/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Contact/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Contact/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Contact/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
