using Student_Manaegement_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Student_Manaegement_System.Controllers
{
    public class HomeController : Controller
    {
        DBStudentManageEntitied db = new DBStudentManageEntitied();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult InsertTBLClassRoom()
        {
            return View();
        }
        [HttpPost]
        public ActionResult InsertTBLClassRoom(TBLClassRoom tBLClassRoom)
        {
            db.TBLClassRooms.Add(tBLClassRoom);
            db.SaveChanges();
            return View();

        }
        public PartialViewResult printTBLClassRoom()
        {
            var listClassRoom = db.TBLClassRooms.ToList();
            return PartialView(listClassRoom);
        }
        public ActionResult DeleteTBLClassRoom(int id)
        {
            try
            {
                var DeleteTBLClassRoom = db.TBLClassRooms.Where(x => x.IdCr == id).FirstOrDefault();
                db.TBLClassRooms.Remove(DeleteTBLClassRoom);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            catch
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult AddTBLStudent(int id)
        {
            ViewBag.Test = id;
            return View();
        }
        [HttpPost]
        public ActionResult AddTBLStudent(TBLStudent tBLStudent)
        {
            db.TBLStudents.Add(tBLStudent);
            db.SaveChanges();
            return View();

        }
        public ActionResult ListTBLSudent(int id)
        {
            var listStudent = (from cr in db.TBLClassRooms
                               from st in db.TBLStudents
                               where cr.IdCr == st.IdCr && id == st.IdCr
                               select st).ToList();
            return View(listStudent);
        }
        public ActionResult DeleteTBLStudent(int id)
        {
            try
            {
                var DeleteTBLStudent = db.TBLStudents.Where(x => x.IdSt == id).FirstOrDefault();
                db.TBLStudents.Remove(DeleteTBLStudent);
                db.SaveChanges();
                return RedirectToAction("ShowAllTBLStudent");
            }

            catch
            {
                return View();
            }
        }

        public ActionResult ShowAllTBLStudent()
        {

            var showAllStudent = db.TBLStudents.ToList();
            return View(showAllStudent);
        }

        public ActionResult OrderByAscId()
        {
            var OrderByAscId = db.TBLStudents.OrderBy(x => x.IdSt).ToList();
            return View(OrderByAscId);
        }
        public ActionResult OrderByDscId()
        {
            var OrderByDscId = db.TBLStudents.OrderByDescending(x => x.IdSt).ToList();
            return View(OrderByDscId);
        }


        [HttpPost]
        public ActionResult SearchByName(FormCollection f)
        {
            String KeySearchName = f["SearchValue"].ToString();
            List<TBLStudent> ListSearch = db.TBLStudents.Where(x => x.NameSt.Contains(KeySearchName)).ToList();
              if(ListSearch.Count == 0)
            {
                ViewBag.Notification = "No Result Found ! Please Try To Search Another Name";
            }
            else
            {
                ViewBag.Notification = "Found " + ListSearch.Count + " Result";
            }
            return View(ListSearch.OrderBy(x=>x.NameSt));
        }
    }
}


