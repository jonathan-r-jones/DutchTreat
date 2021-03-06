﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DutchTreat.Data;
using DutchTreat.Services;
using DutchTreat.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DutchTreat.Controllers
{
  public class AppController : Controller
  {
    private readonly IMailService _mailService;
    private readonly IDutchRepository _repository;
    private readonly DutchContext _dutchContext;

    public AppController(IMailService mailService, IDutchRepository repository, DutchContext dutchContext)
    {
      _mailService = mailService;
      _repository = repository;
      _dutchContext = dutchContext;
    }

    public IActionResult Index()
    {
      var results = _dutchContext.Products.ToList();
      return View();
    }

    [HttpGet("contact")]
    public IActionResult Contact()
    {
      return View();
    }

    [HttpPost("contact")]
    public IActionResult Contact(ContactViewModel model)
    {
      if (ModelState.IsValid)
      {
        // Send the email
        _mailService.SendMessage("shawn@wildermuth.com", model.Subject, $"From: {model.Name} - {model.Email}, Message: {model.Message}");
        ViewBag.UserMessage = "Mail Sent";
        ModelState.Clear();
      }

      return View();
    }

    public IActionResult About()
    {
      ViewBag.Title = "About Us";

      return View();
    }

    public IActionResult Shop()
    {
      var results = _repository.GetAllProducts();

      return View(results);
    }

  }
}
