using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Inventory.Models;
using System.Linq;

namespace Inventory.Controllers
{
    public class CategoriesController : Controller
  {
    private readonly InventoryContext _db;
    public CategoriesController(InventoryContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Categories> allCategories = _db.categories.ToList();
      return View(allCategories);
    }
    public ActionResult Create(string categoryName)
    {
      Category newCategory = new Category(categoryName);
      return RedirectToAction("Index");
    }
    
  }
}