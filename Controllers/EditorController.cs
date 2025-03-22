using İsTakipSistemi.Models;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using Dapper;

namespace İsTakipSistemi.Controllers
{
    public class EditorController : Controller
    {
        private readonly IDbConnection _connection;

        public EditorController(IDbConnection connection)
        {
            _connection = connection;
        }

        public IActionResult Index()
        {
            var peopleList = _connection.Query<People>("SELECT * FROM People").ToList();
            var statusList = _connection.Query<Status>("SELECT * FROM Status").ToList();

            var model = new PeopleStatusViewModel()
            {
                People = peopleList,
                Status = statusList
            };


            return View(model);
        }

        [HttpPost]
        public IActionResult CreateWork(Works work)
        {
            var date = DateTime.Now;
            var insertWork = _connection.Execute(
            @"INSERT INTO Works
            (Title,StatusId,CalisanId,CreatedDate)
            VALUES
            (@Title,@StatusId,@CalisanId,@CreatedDate)", new
             {
             Title = work.Title,
             StatusId = work.StatusId,
             CalisanId = work.CalisanId,
             CreatedDate = date,
             });
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult CreatePeople(People people)
        {
            var insertPeople = _connection.Execute(
             @"INSERT INTO People
             (AdiSoyadi)
             VALUES
             (@AdiSoyadi)", people
            );
            return RedirectToAction("Index");
        }
    }
}
