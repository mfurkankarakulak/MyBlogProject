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

        private IRepository<Country> _countryRepository;
        private IRepository<City> _cityRepository;

        public UserLoginController()
        {
            _dbContext = new MyBlogContext();
            _uow = new DataBaseUnitOfWork(_dbContext);

            _countryRepository = new DataBaseRepository<Country>(_dbContext);
            _cityRepository = new DataBaseRepository<City>(_dbContext);
        }

        // GET: UserLogin
        public ActionResult UserSignIn()
        {
            return View();
        }

        public ActionResult UserSignUp()
        {
          
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