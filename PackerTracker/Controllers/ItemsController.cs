using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PackerTracker.Models;

namespace PackerTracker.Controllers
{
  public class ItemsController : Controller
  {
    [HttpGet("/items")]
    public ActionResult Index()
    {
      List<Item> allItems = Item.GetAll();
      return View(allItems);
    }

    [HttpGet("/items/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/items")]
    public ActionResult Create(string name, double price, string status, double weight, int ready)
    {
      Item myItem = new Item(name, price, status, weight, ready);
      return RedirectToAction("Index");
    }

    [HttpPost("/items/delete")]
    public ActionResult DeleteAll()
    {
      Item.ClearAll();
      return View();
    }

    [HttpGet("/items/{id}")]
    public ActionResult Show(int id)
    {
      Item foundItem = Item.Find(id);
      return View(foundItem);
    }

    [HttpGet("/items/unpacked")]
    public ActionResult Unpacked()
    {
      List<Item> unpackedItems = Item.GetAllNotPacked();
      return View(unpackedItems);
    }

    [HttpPost("/items/checkoff")]
    public ActionResult CheckOff()
    {
      Item.ClearAll();
      return View();
    }

  }
}