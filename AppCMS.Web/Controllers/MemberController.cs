using System.Web.Mvc;
using System.Web.Security;
using Umbraco.Web.Mvc;
using AppCMS.Web.Models;

namespace AppCMS.Web.Controllers
{
    public class MemberController : SurfaceController
    {
        public ActionResult RenderLogin()
        {
            return PartialView("Login", new LoginModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitLogin(LoginModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return CurrentUmbracoPage();
            }

            if (!Membership.ValidateUser(model.Email, model.Password))
            {
                ModelState.AddModelError("", "The email or password provided is incorrect.");
                return CurrentUmbracoPage();
            }

            FormsAuthentication.SetAuthCookie(model.Email, false);

            return Redirect("/");
        }

        public ActionResult SubmitLogout()
        {
            TempData.Clear();
            Session.Clear();
            FormsAuthentication.SignOut();
            return RedirectToCurrentUmbracoPage();
        }
    }
}