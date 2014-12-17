using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SocialNetwork.DAL;
using SocialNetwork.Models;





namespace apl.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/
        private SocialNetworkContext db = new SocialNetworkContext();
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /User/Create
        public ActionResult Create()
        {
           return View();
        }

        //
        // POST: /User/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "ID,Name,Email")] User user)
        {       
            try            
            {
                    User userFromDb = db.Users.Where(p => p.Email == user.Email).FirstOrDefault();
                
                    //if (ModelState.IsValid)
                    //{
                    if (db.Users.Where(p => p.Email == user.Email).FirstOrDefault() == null) 
                        {
                            // if (ModelState.IsValid)
                            // {
                            db.Users.Add(user);
                            db.SaveChanges();
                            userFromDb = user;
                            //  }                     
                        }
                       // else
                          //  return RedirectToAction("Index", "home");
                    //}
                   
                    db.Asparaguses.Add(new Asparagus(userFromDb));
                    db.SaveChanges();
                    return RedirectToAction("Index", "asparagus");                
            }
            catch
            {
                return RedirectToAction("Index", "home");
            }
        }




        //
        // GET: /User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /User/Edit/5
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
        // GET: /User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /User/Delete/5
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
