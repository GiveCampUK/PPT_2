using System;
using System.Linq.Expressions;
using System.Web.Mvc;
using NHibernate;
using PPT.Web.Code.Domain;
using PPT.Web.Models;

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
            var countQuery = _session.QueryOver<Contact>();
            var resultsQuery = _session.QueryOver<Contact>();

            if (filterInvalidNames)
            {
                countQuery = ApplyInvalidNameFilter(countQuery);
                resultsQuery = ApplyInvalidNameFilter(resultsQuery);
            } 

            var count = countQuery.OrderBy(x => x.Surname).Asc
                                  .OrderBy(x => x.Forename).Asc
                                  .RowCount();

            var results = resultsQuery.OrderBy(x => x.Surname).Asc
                                      .OrderBy(x => x.Forename).Asc.Skip((pageNumber - 1)*pageSize)
                                      .Take(pageSize)
                                      .List();

            var aPageOfData = new PageOf<Contact>(results, pageSize, pageNumber){TotalResults = count};

            return View(aPageOfData);
        }

        private static IQueryOver<Contact, Contact> ApplyInvalidNameFilter(IQueryOver<Contact, Contact> q1)
        {
            return q1.Where(x => x.Surname != null && x.Forename != null);
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
