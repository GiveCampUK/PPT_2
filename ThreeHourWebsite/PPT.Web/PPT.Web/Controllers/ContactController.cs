using System;
using System.Web.Mvc;
using NHibernate;
using PPT.Web.Code.DataAccess.Queries;
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

        public ActionResult Index(int pageNumber = 1, int pageSize = 25, bool filterInvalidNames = true)
        {
            var query = new RetrievePageOfContacts(_session);
            var results = query.Execute(pageNumber, pageSize, filterInvalidNames);
            return View(results);
        }

        public ActionResult Details(int id)
        {
            return View(_session.Load<Contact>(id));
        }

        public ActionResult Create()
        {
            return View();
        } 

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
        
        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(Contact contact)
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
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (var tx = _session.BeginTransaction())
                {
                    var item = _session.Get<Contact>(id);
                    _session.Delete(item);
                    tx.Commit();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
