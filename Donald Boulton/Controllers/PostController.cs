using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mansbooks.Models.Repository;

namespace Mansbooks.Controllers
{
    public class PostController : Controller
    {
        private IPostRepository repositoryPost;

        public PostController(IPostRepository _repositoryPost)
        {
            repositoryPost = _repositoryPost;
        }

        public ViewResult Index() => View(repositoryPost.Posts.Select(p => p.Category).Distinct());

        public ViewResult List(string id) => View(repositoryPost.Posts.Where(p => p.Category == id).ToList());

    }
}