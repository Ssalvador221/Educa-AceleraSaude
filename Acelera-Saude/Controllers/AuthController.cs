using Acelera_Saude.Models;
using Firebase.Auth;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Acelera_Saude.Controllers
{
    public class AuthController : Controller
    {

        FirebaseAuthProvider firebaseAuthProvider;

        public AuthController()
        {
            firebaseAuthProvider = new FirebaseAuthProvider(new FirebaseConfig("AIzaSyAYDIeVWAsPPKRCMkJU-YfK8TxpCG_zh8c"));
        }


        public IActionResult Index()
        {
            return View();  
        }


        public IActionResult Login()
        {

            LoginModel model = new LoginModel();
            return View("Login", model);

        }

        


        [HttpPost]
        public async Task<IActionResult> Registro(LoginModel loginModel)
        {
            try
            {
                await firebaseAuthProvider.CreateUserWithEmailAndPasswordAsync(loginModel.Email, loginModel.Password);
                var fbAuthLink = await firebaseAuthProvider.SignInWithEmailAndPasswordAsync(loginModel.Email, loginModel.Password);
                string token = fbAuthLink.FirebaseToken;
                

                if (token != null)
                {
                    HttpContext.Session.SetString("_UserToken", token);

                    return RedirectToAction("Index");
                }
            }
            catch (FirebaseAuthException execption)
            {
                var firebaseExecption = JsonConvert.DeserializeObject<FirebaseError.FirebaseErro>(execption.ResponseData);
                ModelState.AddModelError(string.Empty, firebaseExecption.Error.Message);
                return View(loginModel);
            }
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            try
            {
                var fbAuthLink = await firebaseAuthProvider
                                .SignInWithEmailAndPasswordAsync(loginModel.Email, loginModel.Password);

                
                string token = fbAuthLink.FirebaseToken;

                if (token != null)
                {
                    HttpContext.Session.SetString("_UserToken", token); 

                    return RedirectToAction("Index", "Home");
                }

            }
            catch (FirebaseAuthException ex)
            {
                var firebaseEx = JsonConvert.DeserializeObject<FirebaseError.FirebaseErro>(ex.ResponseData);
                ModelState.AddModelError(string.Empty, firebaseEx.Error.Message);
                return View(loginModel);
            }

            return View();
        }













    }
}
