using Azure.Core;
using LONE.Data; //for LONEDbContext
using LONE.Models; // for AddRequestViewModel
using LONE.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace LONE.Controllers
{
    public class RequestsController : Controller
    {
        private readonly LONEDbContext loneDbContext; // private field 'this' to talk to LONE Db

        public RequestsController(LONEDbContext loneDbContext) //service injection from program.cs for constructor
        {
            this.loneDbContext = loneDbContext;
        }

        [HttpGet]
        public IActionResult Add() 
        {
            return View();
        }

        [HttpPost] // asynchronous post method wrapped inside a task
        public async Task<IActionResult> Add(AddRequestViewModel addRequest)
        {
            var request = new Models.Domain.Request() //new Request() similar to Azure.Domain.Request so Models.Domain.Request 
            {
                Id = Guid.NewGuid(),
                SubjectFirstName = addRequest.SubjectFirstName,
                SubjectLastName = addRequest.SubjectLastName,
                SubjectAltFirstName = addRequest.SubjectAltFirstName,
                SubjectAltLastName = addRequest.SubjectAltLastName,
                SubjectDateofBirth = addRequest.SubjectDateofBirth,
                SubjectDateOfDeath = addRequest.SubjectDateOfDeath,
                SubjectCountryOfBirth = addRequest.SubjectCountryOfBirth,
                UserTitle = addRequest.UserTitle,
                UserFirstName = addRequest.UserFirstName,
                UserLastName = addRequest.UserLastName,
                UserEmailAddress = addRequest.UserEmailAddress,
                UserRetypeEmailAddress = addRequest.UserRetypeEmailAddress,
                UserAddressLine1 = addRequest.UserAddressLine1,
                UserAddressLine2 = addRequest.UserAddressLine2,
                UserTownOrCity = addRequest.UserTownOrCity,
                UserCounty = addRequest.UserCounty,
                UserPostcode = addRequest.UserPostcode,
                UserCountry = addRequest.UserCountry
            };

            await loneDbContext.Requests.AddAsync(request); //await used because of aysnc method
            await loneDbContext.SaveChangesAsync(); //save to LONE Db
            return RedirectToAction("Add"); //returns view to the add method
        }


    }
}
