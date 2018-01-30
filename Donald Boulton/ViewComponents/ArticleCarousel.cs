using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Donald_Boulton.Models.Repository;

namespace Donald_Boulton.ViewComponents
{
    public class ArticleCarouselViewComponent : ViewComponent
    {
        private IPostRepository repository;

        public ArticleCarouselViewComponent(IPostRepository _repository)
        {
            repository = _repository;
        }
        public IViewComponentResult Invoke()
        {
            string Category = RouteData.Values["id"] as string;
            if(Category != null)
            {
                return View(repository.Posts.Where(p => p.Category == Category).ToList());
            }
            else
            {
                return View(repository.Posts);
            }
        }
    }
}
