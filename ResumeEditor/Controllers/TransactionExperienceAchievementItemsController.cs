using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ResumeEditor.EF;

namespace ResumeEditor.Controllers
{
    public class TransactionExperienceAchievementItemsController : Controller
    {
        private ResumeEditorEntities db = new ResumeEditorEntities();

        // GET: TransactionExperienceAchievementItems
        public async Task<ActionResult> Index()
        {
            var transactionExperienceAchievementItems = db.TransactionExperienceAchievementItems.Include(t => t.TransactionExperienceAchievement);
            return View(await transactionExperienceAchievementItems.ToListAsync());
        }

        // GET: TransactionExperienceAchievementItems/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TransactionExperienceAchievementItem transactionExperienceAchievementItem = await db.TransactionExperienceAchievementItems.FindAsync(id);
            if (transactionExperienceAchievementItem == null)
            {
                return HttpNotFound();
            }
            return View(transactionExperienceAchievementItem);
        }

        // GET: TransactionExperienceAchievementItems/Create
        public ActionResult Create()
        {
            ViewBag.OwnerId = new SelectList(db.TransactionExperienceAchievements, "OwnerId", "AchievementTitle");
            return View();
        }

        // POST: TransactionExperienceAchievementItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,OwnerId,ExperienceId,AchievementId,ItemId,Description,TagSkills")] TransactionExperienceAchievementItem transactionExperienceAchievementItem)
        {
            if (ModelState.IsValid)
            {
                db.TransactionExperienceAchievementItems.Add(transactionExperienceAchievementItem);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.OwnerId = new SelectList(db.TransactionExperienceAchievements, "OwnerId", "AchievementTitle", transactionExperienceAchievementItem.OwnerId);
            return View(transactionExperienceAchievementItem);
        }

        // GET: TransactionExperienceAchievementItems/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TransactionExperienceAchievementItem transactionExperienceAchievementItem = await db.TransactionExperienceAchievementItems.FindAsync(id);
            if (transactionExperienceAchievementItem == null)
            {
                return HttpNotFound();
            }
            ViewBag.OwnerId = new SelectList(db.TransactionExperienceAchievements, "OwnerId", "AchievementTitle", transactionExperienceAchievementItem.OwnerId);
            return View(transactionExperienceAchievementItem);
        }

        // POST: TransactionExperienceAchievementItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,OwnerId,ExperienceId,AchievementId,ItemId,Description,TagSkills")] TransactionExperienceAchievementItem transactionExperienceAchievementItem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(transactionExperienceAchievementItem).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.OwnerId = new SelectList(db.TransactionExperienceAchievements, "OwnerId", "AchievementTitle", transactionExperienceAchievementItem.OwnerId);
            return View(transactionExperienceAchievementItem);
        }

        // GET: TransactionExperienceAchievementItems/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TransactionExperienceAchievementItem transactionExperienceAchievementItem = await db.TransactionExperienceAchievementItems.FindAsync(id);
            if (transactionExperienceAchievementItem == null)
            {
                return HttpNotFound();
            }
            return View(transactionExperienceAchievementItem);
        }

        // POST: TransactionExperienceAchievementItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            TransactionExperienceAchievementItem transactionExperienceAchievementItem = await db.TransactionExperienceAchievementItems.FindAsync(id);
            db.TransactionExperienceAchievementItems.Remove(transactionExperienceAchievementItem);
            await db.SaveChangesAsync();
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
