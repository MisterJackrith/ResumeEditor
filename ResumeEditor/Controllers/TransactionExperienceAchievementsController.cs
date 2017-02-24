using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ResumeEditor.EF;

namespace ResumeEditor.Controllers
{
    public class TransactionExperienceAchievementsController : Controller
    {
        private ResumeEditorEntities db = new ResumeEditorEntities();

        // GET: TransactionExperienceAchievements
        public ActionResult Index()
        {
            var transactionExperienceAchievements = db.TransactionExperienceAchievements.Include(t => t.TransactionExperienceTimeline);
            return View(transactionExperienceAchievements.ToList());
        }

        // GET: TransactionExperienceAchievements/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TransactionExperienceAchievement transactionExperienceAchievement = db.TransactionExperienceAchievements.Find(id);
            if (transactionExperienceAchievement == null)
            {
                return HttpNotFound();
            }
            return View(transactionExperienceAchievement);
        }

        // GET: TransactionExperienceAchievements/Create
        public ActionResult Create()
        {
            ViewBag.OwnerId = new SelectList(db.TransactionExperienceTimelines, "OwnerId", "ExperienceType");
            return View();
        }

        // POST: TransactionExperienceAchievements/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,OwnerId,ExperienceId,AchievementId,AchievementTitle,AchievementDescription,AchievementSequence,StartDate,EndDate")] TransactionExperienceAchievement transactionExperienceAchievement)
        {
            if (ModelState.IsValid)
            {
                db.TransactionExperienceAchievements.Add(transactionExperienceAchievement);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.OwnerId = new SelectList(db.TransactionExperienceTimelines, "OwnerId", "ExperienceType", transactionExperienceAchievement.OwnerId);
            return View(transactionExperienceAchievement);
        }

        // GET: TransactionExperienceAchievements/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TransactionExperienceAchievement transactionExperienceAchievement = db.TransactionExperienceAchievements.Find(id);
            if (transactionExperienceAchievement == null)
            {
                return HttpNotFound();
            }
            ViewBag.OwnerId = new SelectList(db.TransactionExperienceTimelines, "OwnerId", "ExperienceType", transactionExperienceAchievement.OwnerId);
            return View(transactionExperienceAchievement);
        }

        // POST: TransactionExperienceAchievements/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,OwnerId,ExperienceId,AchievementId,AchievementTitle,AchievementDescription,AchievementSequence,StartDate,EndDate")] TransactionExperienceAchievement transactionExperienceAchievement)
        {
            if (ModelState.IsValid)
            {
                db.Entry(transactionExperienceAchievement).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.OwnerId = new SelectList(db.TransactionExperienceTimelines, "OwnerId", "ExperienceType", transactionExperienceAchievement.OwnerId);
            return View(transactionExperienceAchievement);
        }

        // GET: TransactionExperienceAchievements/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TransactionExperienceAchievement transactionExperienceAchievement = db.TransactionExperienceAchievements.Find(id);
            if (transactionExperienceAchievement == null)
            {
                return HttpNotFound();
            }
            return View(transactionExperienceAchievement);
        }

        // POST: TransactionExperienceAchievements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            TransactionExperienceAchievement transactionExperienceAchievement = db.TransactionExperienceAchievements.Find(id);
            db.TransactionExperienceAchievements.Remove(transactionExperienceAchievement);
            db.SaveChanges();
            return RedirectToAction("Index");
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
