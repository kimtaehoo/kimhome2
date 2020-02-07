using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyApp.Model;
using MyApp.Models;
using MyApp.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyApp.Controllers
{
    public class HomeController : Controller //접미사를 꼭 붙혀야 한다.
    {
        public IActionResult Index()
        {
            return View();
        }
        // GET: /<controller>/
        public IActionResult Student() //함수가 View를 리턴 레이저파일을 추가 
        {
            List<teacher> teachers = new List<teacher>()
            {
                new teacher() { Name = "세종대왕", Class = "한글"},
                new teacher() { Name = "이순신", Class = "해상전략"},
                new teacher() { Name = "제갈량", Class = "지략"},
                new teacher() { Name = "을지문덕", Class = "지상전략"}
            };

            var viewModel = new StudentTeacherViewModel()
            {
                Student = new Student(),
                Teachers = teachers
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Student(StudentTeacherViewModel model)
        {
            if (ModelState.IsValid) //유효성 검사
            {
                //Model 데이터를 Student 테이블에 저장
            }
            else
            {
                //에러를 보여준다.
            }

            return View();
        }
    }
}
