using System.Data;
using System.Linq;
using System.Web.Mvc;
using PPT.Web.Code;
using PPT.Web.Data;
using PPT.Web.Models;

namespace PPT.Web.Controllers
{ 
    public class ContactsController : Controller
    {
        private readonly ContactApplicationService _contactsService;
        private readonly PPTEntities db = new PPTEntities();

        public ContactsController()
        {
            _contactsService = new ContactApplicationService();
        }

        public ViewResult Index(int pageNumber = 1, int pageSize = 25)
        {
            var pageOfContacts = _contactsService.RetrievePageOfContacts(pageNumber, pageSize);
            return View(pageOfContacts);
        }

        //
        // GET: /Contacts/Details/5

        public ViewResult Details(int id)
        {
            Contact contact = db.Contacts.Single(c => c.Id == id);
            return View(contact);
        }

        //
        // GET: /Contacts/Create

        public ActionResult Create()
        {
            ViewBag.Country = new SelectList(db.Countries, "Id", "Name");
            ViewBag.MailCode = new SelectList(db.MailCodes, "Id", "Name");
            ViewBag.PersonType = new SelectList(db.PersonTypes, "Id", "Name");
            ViewBag.Prison = new SelectList(db.Prisons, "Id", "Name");
            ViewBag.Title = new SelectList(db.Titles, "Id", "Name");
            ViewBag.Town = new SelectList(db.Towns, "Id", "Name");
            ViewBag.Id = new SelectList(db.Corresps, "Corref", "Type");
            return View();
        } 

        //
        // POST: /Contacts/Create

        [HttpPost]
        public ActionResult Create(Contact contact)
        {
            if (ModelState.IsValid)
            {
                db.Contacts.AddObject(contact);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.Country = new SelectList(db.Countries, "Id", "Name", contact.Country);
            ViewBag.MailCode = new SelectList(db.MailCodes, "Id", "Name", contact.MailCode);
            ViewBag.PersonType = new SelectList(db.PersonTypes, "Id", "Name", contact.PersonType);
            ViewBag.Prison = new SelectList(db.Prisons, "Id", "Name", contact.Prison);
            ViewBag.Title = new SelectList(db.Titles, "Id", "Name", contact.Title);
            ViewBag.Town = new SelectList(db.Towns, "Id", "Name", contact.Town);
            ViewBag.Id = new SelectList(db.Corresps, "Corref", "Type", contact.Id);
            return View(contact);
        }
        
        //
        // GET: /Contacts/Edit/5
 
        public ActionResult Edit(int id)
        {
            Contact contact = db.Contacts.Single(c => c.Id == id);
            ViewBag.Country = new SelectList(db.Countries, "Id", "Name", contact.Country);
            ViewBag.MailCode = new SelectList(db.MailCodes, "Id", "Name", contact.MailCode);
            ViewBag.PersonType = new SelectList(db.PersonTypes, "Id", "Name", contact.PersonType);
            ViewBag.Prison = new SelectList(db.Prisons, "Id", "Name", contact.Prison);
            ViewBag.Title = new SelectList(db.Titles, "Id", "Name", contact.Title);
            ViewBag.Town = new SelectList(db.Towns, "Id", "Name", contact.Town);
            ViewBag.Id = new SelectList(db.Corresps, "Corref", "Type", contact.Id);
            return View(contact);
        }

        //
        // POST: /Contacts/Edit/5

        [HttpPost]
        public ActionResult Edit(Contact contact)
        {
            if (ModelState.IsValid)
            {
                db.Contacts.Attach(contact);
                db.ObjectStateManager.ChangeObjectState(contact, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Country = new SelectList(db.Countries, "Id", "Name", contact.Country);
            ViewBag.MailCode = new SelectList(db.MailCodes, "Id", "Name", contact.MailCode);
            ViewBag.PersonType = new SelectList(db.PersonTypes, "Id", "Name", contact.PersonType);
            ViewBag.Prison = new SelectList(db.Prisons, "Id", "Name", contact.Prison);
            ViewBag.Title = new SelectList(db.Titles, "Id", "Name", contact.Title);
            ViewBag.Town = new SelectList(db.Towns, "Id", "Name", contact.Town);
            ViewBag.Id = new SelectList(db.Corresps, "Corref", "Type", contact.Id);
            return View(contact);
        }

        //
        // GET: /Contacts/Delete/5
 
        public ActionResult Delete(int id)
        {
            Contact contact = db.Contacts.Single(c => c.Id == id);
            return View(contact);
        }

        //
        // POST: /Contacts/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Contact contact = db.Contacts.Single(c => c.Id == id);
            db.Contacts.DeleteObject(contact);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}