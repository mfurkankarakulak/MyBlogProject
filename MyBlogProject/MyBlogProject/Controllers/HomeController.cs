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
    public class HomeController : Controller
    {
        // GET: Home
        private MyBlogContext _dbContext;
        private IUnitOfWork _uow;

        private IRepository<Country> _countryRepository;

        public HomeController()
        {
            _dbContext = new MyBlogContext();
            _uow = new DataBaseUnitOfWork(_dbContext);

            _countryRepository = new DataBaseRepository<Country>(_dbContext);
        }


        // GET: Home
        public ActionResult Index()
        {

            //Country country = new Country();
            //country.CoutryName = "Mustafa";

            //MyBlogContext a = new MyBlogContext();
            //a.Country.Add(country);

            //a.SaveChanges();

            //_countryRepository.Add(country);
            //int process = _uow.SaveChanges();


            return View();
        }
    }
}