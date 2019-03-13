using CCC.Validations;
using FluentValidation.Results;
using MyBlogProject.Business;
using MyBlogProject.Dal.Context;
using MyBlogProject.Dal.Repositories;
using MyBlogProject.Dal.UnitOfWork;
using MyBlogProject.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MyBlogProject.Controllers
{
    public class UserLoginController : Controller
    {
        private MyBlogContext _dbContext;
        private IUnitOfWork _uow;
        private string _email;
        private IRepository<Country> _countryRepository;
        private IRepository<City> _cityRepository;
        private IRepository<User> _userRepository;

        public UserLoginController()
        {
            _dbContext = new MyBlogContext();
            _uow = new DataBaseUnitOfWork(_dbContext);

            _countryRepository = new DataBaseRepository<Country>(_dbContext);
            _cityRepository = new DataBaseRepository<City>(_dbContext);
            _userRepository = new DataBaseRepository<User>(_dbContext);
        }

        // GET: UserLogin
        public ActionResult UserSignIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UserSignIn(User user)
        {
            try
            {
                var ExistUser = _userRepository.GetAll(x => x.EMailAdress == user.EMailAdress).SingleOrDefault();

                if (ExistUser != null)
                {
                    if (ExistUser.Password.Equals(user.Password))
                    {
                        return RedirectToAction("Home", "MainPage");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Kullanıcı ismi yada parola hatalı.");
                    }
                }
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }

            return View();
        }

        public ActionResult UserSignUp()
        {
            ViewBag.CitiesData =_cityRepository.GetAll();
            ViewBag.CountriesData = _countryRepository.GetAll();

            return View();
        }
        [HttpPost]
        public ActionResult UserSignUp(User newUser)
        {
            ViewBag.CitiesData = _cityRepository.GetAll();
            ViewBag.CountriesData = _countryRepository.GetAll();
            UserValidator userValidator = new UserValidator();

            ValidationResult result = userValidator.Validate(newUser);
            
            if (result.IsValid == false)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
                return View();
            }
            else
            {
                try
                {
                    newUser.RegisterTime = DateTime.Now;
                    newUser.TryPasswordCount = 0;

                    _userRepository.Add(newUser);
                    _uow.SaveChanges();
                }
                catch(Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
               
            }
            return View();
        }
        public ActionResult ChancePassword()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ChancePassword(User user)
        {
            try
            {
                var ExistUser = _userRepository.GetAll(x => x.EMailAdress == user.EMailAdress).SingleOrDefault();

                if (ExistUser != null)
                {
                    ModelState.AddModelError("CPas", "Şifrenizi Yenilemeniz için E-Posta Gönderildi");
                    SendMail.SendMailUser("Şifrenizi Yenileme Linki  http://localhost:21936/UserLogin/NewPaspport?id=", ExistUser.EMailAdress, "Şifre Yenileme");
                    
                }
                else
                {
                    ModelState.AddModelError("", "E-Posta Geçersiz");
                }
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }

            return View();
        }
        public ActionResult NewPaspport(string id)//linke birden fazla tıklanma durumu kontrol edilmeli
        {
            _email = id;
            return View();
        }
        [HttpPost]
        public ActionResult NewPaspport(User user)
        {

            try
            {
                var ExistUser = _userRepository.GetAll(x => x.EMailAdress == user.EMailAdress).SingleOrDefault();

                if (ExistUser != null && ExistUser.Password == user.Name)
                {
                   

                }
                else
                {
                    
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }

            return View();
        }
        public JsonResult GetCitiesByCountry(int id)
        {
            int countryId = id;
            
            List<City> result = _cityRepository.GetAll(x => x.CountryId == countryId).ToList();

            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}