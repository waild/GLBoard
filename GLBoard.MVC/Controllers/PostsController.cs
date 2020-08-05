using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain;
using GLBoard.MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Abstraction;

namespace GLBoard.MVC.Controllers
{
    public class PostsController : Controller
    {
        private readonly IPostsService postsService;
        private readonly IMapper mapper;

        public PostsController(IPostsService postsService, IMapper mapper)
        {
            this.postsService = postsService;
            this.mapper = mapper;
        }
        // GET: PostController
        public async Task<IActionResult> Index()
        {
            var entities = await postsService.List();
            var posts = mapper.Map<IList<Post>, IList<PostViewModel>>(entities);
            return View(posts);
        }

        // GET: PostController/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var entity = await postsService.Get(id);
            var post = mapper.Map<Post, PostViewModel>(entity);
            return View(post);
        }

        // GET: PostController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PostController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PostViewModel post)
        {
            try
            {
                var entity = mapper.Map<PostViewModel, Post>(post);
                await postsService.Insert(entity);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PostController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var entity = await postsService.Get(id);
            var post = mapper.Map<Post, PostViewModel>(entity);
            return View(post);
        }

        // POST: PostController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, PostViewModel post)
        {
            try
            {
                var entity = mapper.Map<PostViewModel, Post>(post);
                await postsService.Insert(entity);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PostController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            return View();
        }

        // POST: PostController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
