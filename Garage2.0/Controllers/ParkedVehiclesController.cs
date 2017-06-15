using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Garage2._0.DataAccess;
using Garage2._0.Models;
using static Garage2._0.Enum.TypeOfVehicle;

namespace Garage2._0.Controllers
{
    public class ParkedVehiclesController : Controller
    {
        private GarageContext db = new GarageContext();

        // GET: ParkedVehicles

        public ActionResult Index(string searchNumberPlate)
        {
            var parkedVehicle = from p in db.ParkedVehicles select p;

            if (!String.IsNullOrEmpty(searchNumberPlate))
            {
                parkedVehicle = parkedVehicle.Where(p => p.RegNumber.Equals(searchNumberPlate));
                return View(parkedVehicle);
            }
            return View(db.ParkedVehicles.ToList());
        }

        // GET: Sort parkedVehicles
        public ActionResult IndexSort(string typeOfVehicle = "", string orderBy = "")
        {
            var parkedVehicles = db.ParkedVehicles.Select(pv => pv);

            ViewBag.Fordon = "fordon";
            ViewBag.TypeOfVehicle = typeOfVehicle;

            if (typeOfVehicle != "")
            {
                switch (typeOfVehicle.ToUpper())
                {
                    case "CAR":
                        parkedVehicles = parkedVehicles.Where(pv => pv.TypeOfVehicle == Car); ViewBag.Fordon = "bilar"; ViewBag.TypeOfVehicle = "Car"; break;
                    case "BUS":
                        parkedVehicles = parkedVehicles.Where(pv => pv.TypeOfVehicle == Bus); ViewBag.Fordon = "bussar"; ViewBag.TypeOfVehicle = "Bus"; break;
                    case "BOAT":
                        parkedVehicles = parkedVehicles.Where(pv => pv.TypeOfVehicle == Boat); ViewBag.Fordon = "båtar"; ViewBag.TypeOfVehicle = "Boat"; break;
                    case "AIRPLANE":
                        parkedVehicles = parkedVehicles.Where(pv => pv.TypeOfVehicle == Airplane); ViewBag.Fordon = "flygplan"; ViewBag.TypeOfVehicle = "Airplane"; break;
                    case "MOTORCYCLE":
                        parkedVehicles = parkedVehicles.Where(pv => pv.TypeOfVehicle == Motorcycle); ViewBag.Fordon = "motorcyklar"; ViewBag.TypeOfVehicle = "Motorcycle"; break;
                }
                if (parkedVehicles.Count() == 0) return HttpNotFound();
            }

            if (orderBy != "")
                switch (orderBy.ToUpper())
                {
                    case "TYPEOFVEHICLE": parkedVehicles = parkedVehicles.OrderBy(pv => pv.TypeOfVehicle); break;
                    case "REGNUMBER": parkedVehicles = parkedVehicles.OrderBy(pv => pv.RegNumber); break;
                    case "COLOR": parkedVehicles = parkedVehicles.OrderBy(pv => pv.Color); break;
                    case "NOOFWHEELS": parkedVehicles = parkedVehicles.OrderBy(pv => pv.NoOfWheels); break;
                    case "BRAND": parkedVehicles = parkedVehicles.OrderBy(pv => pv.Brand); break;
                    case "MODEL": parkedVehicles = parkedVehicles.OrderBy(pv => pv.Model); break;
                }

            return View(parkedVehicles.ToList());
        }
        
        // GET: ParkedVehicles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ParkedVehicle parkedVehicle = db.ParkedVehicles.Find(id);
            if (parkedVehicle == null)
            {
                return HttpNotFound();
            }
            return View(parkedVehicle);
        }

        // GET: ParkedVehicles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ParkedVehicles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,TypeOfVehicle,RegNumber,Color,NoOfWheels,Brand,Model,CheckInTime,CheckOutTime,ParkingDuration,ParkingFee")] ParkedVehicle parkedVehicle)
        {
            if (ModelState.IsValid)
            {
                db.ParkedVehicles.Add(parkedVehicle);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(parkedVehicle);
        }

        // GET: ParkedVehicles/Park
        public ActionResult Park()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Park([Bind(Include = "Id,TypeOfVehicle,RegNumber,Color,NoOfWheels,Brand,Model")] ParkedVehicle parkedVehicle)
        {
            if (ModelState.IsValid)
            {
                db.ParkedVehicles.Add(parkedVehicle);
                db.SaveChanges();
                return RedirectToAction("IndexSort");
            }

            return View(parkedVehicle);
        }

        // GET: ParkedVehicles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ParkedVehicle parkedVehicle = db.ParkedVehicles.Find(id);
            if (parkedVehicle == null)
            {
                return HttpNotFound();
            }
            return View(parkedVehicle);
        }

        // POST: ParkedVehicles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,TypeOfVehicle,RegNumber,Color,NoOfWheels,Brand,Model,CheckInTime,CheckOutTime,ParkingDuration,ParkingFee")] ParkedVehicle parkedVehicle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(parkedVehicle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(parkedVehicle);
        }

        // GET: ParkedVehicles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ParkedVehicle parkedVehicle = db.ParkedVehicles.Find(id);
            if (parkedVehicle == null)
            {
                return HttpNotFound();
            }
            return View(parkedVehicle);
        }

        // POST: ParkedVehicles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ParkedVehicle parkedVehicle = db.ParkedVehicles.Find(id);
            var checkOutTime = DateTime.Now;
            TimeSpan parkingDuration = checkOutTime - parkedVehicle.CheckInTime;
            ViewBag.CheckOutTime = checkOutTime;

            ViewBag.ParkingFee = Fee(parkingDuration);
            string pDuration;
            if (parkingDuration.Days > 0)
            {
                pDuration = $"{parkingDuration:dd} dygn {parkingDuration:hh\\:mm\\:ss} (tt:mm:ss)";
            }
            else pDuration = $"{parkingDuration:hh\\:mm\\:ss} (tt:mm:ss)";
            ViewBag.ParkingDuration = pDuration;

            db.ParkedVehicles.Remove(parkedVehicle);
            db.SaveChanges();
            return View("Receipt", parkedVehicle);
        }

        private decimal Fee(TimeSpan parkingDuration)
        {
            if ((parkingDuration.Minutes % 10) > 0 || ((parkingDuration.Minutes % 10 == 0) && (parkingDuration.Seconds > 0)))
            {
                return 10 * ((parkingDuration.Days * 144) + (parkingDuration.Hours * 6) + (parkingDuration.Minutes / 10) + 1);
            }
            return 10 * ((parkingDuration.Days * 144) + (parkingDuration.Hours * 6) + (parkingDuration.Minutes / 10));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
