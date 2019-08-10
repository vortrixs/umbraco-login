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

            if (!Members.Login(model.Email, model.Password))
            {
                ModelState.AddModelError("", "The email or password provided is incorrect.");
                return CurrentUmbracoPage();
            }

            FormsAuthentication.SetAuthCookie(model.Email, false);

            return Redirect("/");
        }

        public ActionResult SubmitLogout()
        {
            Members.Logout();
            FormsAuthentication.SignOut();
            return RedirectToCurrentUmbracoPage();
        }

        public ActionResult RenderSignup()
        {
            return PartialView("SignUp", new SignupModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitSignup(SignupModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return CurrentUmbracoPage();
            }

            if (null != Membership.GetUserNameByEmail(model.Email))
            {
                ModelState.AddModelError("", "A user with this email already exists.");
                return CurrentUmbracoPage();
            }

            FormsAuthentication.SetAuthCookie(model.Email, false);
            Membership.CreateUser(model.Email, model.Password, model.Email, "", "", true, out _);

            Members.RegisterMember(model.Register(Members), out _, true);
                       
            return Redirect("/");
        }
    }
}