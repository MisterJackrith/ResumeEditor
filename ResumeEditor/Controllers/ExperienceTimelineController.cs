using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeEditor.EF;

namespace ResumeEditor.Controllers
{
  public class ExperienceTimelineController : Controller
  {
    // GET: ExperienceTimeline
    public ActionResult Index()
    {
      var entities = new ResumeEditorEntities();
      var query = entities.vwExperienceAchievements;
      return View(query);
    }

    public ActionResult ExperienceAchievements()
    {
      var entities = new ResumeEditorEntities();
      var query = entities.vwExperienceAchievements;
      return View(query);
    }

    public ActionResult Timeline()
    {
      return View();
    }

    public ActionResult Timeline21WithImagesAndResponsive()
    {
      return View();
    }

    public ActionResult TwoColumnTimelineNotResponsive()
    {
      return View();
    }

    public ActionResult TimelineResponsive()
    {
      return View();
    }

    public ActionResult BootstrapMegaMenu()
    {
      return View();
    }
  }
}