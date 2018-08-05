using ECL.Common.Data;
using ECL.Service;
using ECL.Web.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using System.Web.Mvc;

namespace ECL.Web.Controllers
{
    public class ContactController : Controller
    {
        private IContactService _contactService;
        public ContactController(IContactService contactService)
        {
            this._contactService = contactService;
        }

        //Hosted web API REST Service base url  
        string Baseurl = "http://localhost:4333";
        public async Task<ActionResult> ContactDetails()
        {
            List<ContactModel> contactInfo = new List<ContactModel>();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("api/ContactService/GetContacts");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var contactResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    contactInfo = JsonConvert.DeserializeObject<List<ContactModel>>(contactResponse);

                }
                //returning the employee list to view  
                return View(contactInfo);
            }
        }

        // GET: Contact
        [HttpGet]
        public ActionResult Index()
        {
            IEnumerable<ContactModel> contacts = _contactService.GetContacts().Select(c => new ContactModel
            {
                FirstName = c.FirstName,
                LastName = c.LastName,
                Email = c.Email,
                Phone = c.Phone,
                Status = c.Status,
                ID = c.ID
            });//.Where(r => r.Status == true);
            return View(contacts);
        }
        public ActionResult Details(int? id)
        {
            ContactModel model = new ContactModel();
            if (id.HasValue && id != 0)
            {
                Contact contactEntity = _contactService.GetContact(id.Value);
                // model.ID = contactEntity.ID;
                model.FirstName = contactEntity.FirstName;
                model.LastName = contactEntity.LastName;
                model.Phone = contactEntity.Phone;
                model.Email = contactEntity.Email;
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult CreateEditContact(int? id)
        {
            ContactModel model = new ContactModel();
            if (id.HasValue && id != 0)
            {
                Contact contactEntity = _contactService.GetContact(id.Value);
                model.FirstName = contactEntity.FirstName;
                model.LastName = contactEntity.LastName;
                model.Phone = contactEntity.Phone;
                model.Email = contactEntity.Email;
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult CreateEditContact(ContactModel model)
        {
            if (model.ID == 0)
            {
                Contact contactEntity = new Contact
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Phone = model.Phone,
                    Email = model.Email,
                    Status = true
                };
                _contactService.InsertContact(contactEntity);
                if (contactEntity.ID > 0)
                {
                    return RedirectToAction("index");
                }
            }
            else
            {
                Contact contactEntity = _contactService.GetContact(model.ID);
                contactEntity.FirstName = model.FirstName;
                contactEntity.LastName = model.LastName;
                contactEntity.Phone = model.Phone;
                contactEntity.Email = model.Email;
                _contactService.UpdateContact(contactEntity);
                if (contactEntity.ID > 0)
                {
                    return RedirectToAction("index");
                }

            }
            return View(model);
        }
        public ActionResult DoActiveOrInactiveContact(int id, bool status)
        {
            try
            {
                if (id != 0)
                {
                    Contact contactEntity = _contactService.GetContact(id);
                    contactEntity.Status = status;
                    _contactService.UpdateContact(contactEntity);
                    return RedirectToAction("Index");
                }
                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}