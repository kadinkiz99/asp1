using asp1.Models;
using asp1.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp1.Controllers
{
	public class ProductController : Controller
	{
		public IActionResult Index()
		{
			var products = new List<Product>
			{
				new Product{ id = 1 , ProductName= "A P" , Quantity = 10},
				new Product{ id = 2 , ProductName= "B P" , Quantity = 20},
				new Product{ id = 3 , ProductName= "C P" , Quantity = 30},
				new Product{ id = 4 , ProductName= "D P" , Quantity = 40},
				new Product{ id = 5 , ProductName= "E P" , Quantity = 50}

			};
			#region Model bazlı veri gönderimi 
			//			return View(products);
			#endregion

			#region veri taşıma kontrolleri  ViewBag
			// View e taşınacak datayı dynamic şekilde tanımlanan bir değişkenle taşımamızı sağlayan bir veri taşıma kontroludur 

			//	ViewBag.products = products;
			#endregion

			#region View Data
			//View bag de olduğu gibi aksiyondaki datayı viewe taşımamızı sağlar 
			// actionlar arasında tempdata ile veri gönderimi yapılır 
			ViewData["products"] = products;
			return View();
			#endregion


		}

		
		//Tuple 
		public IActionResult GetProducts()
		{
			Product product = new Product
			{
				id=1,
				ProductName = "A P ",
				Quantity = 15
			};


			User users = new User
			{
				id = 1,
				Name = "A",
				LastName= "La"
			};

			//UserProdacts userProducts = new UserProdacts
			//{
			//	Product = product,
			//	User = users
			//};

			//return View(userProducts);

			var userProduct = (product, users);






			return View(userProduct);
		}

		// get isteği gelirse bunu tetikler 
		public IActionResult CreateProduct()
		{
			// get yapılmasını sağlayacak olan fonsksiyon 




			return View();
		}
		// post ile gelirse burayı tetikler 
		[HttpPost] // post ile gelen requestler üzerinden tetiklenmesini istiyor 
				   //public IActionResult CreateProduct(string txtProductName , string txtQuantity)
		public IActionResult CreateProduct(Product product)

		{
			// get yapılmasını sağlayacak olan fonsksiyon 




			return View();
		}
	}
}
