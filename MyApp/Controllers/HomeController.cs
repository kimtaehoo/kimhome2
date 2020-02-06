using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyApp.Model;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyApp.Controllers
{
    public class HomeController : Controller //접미사를 꼭 붙혀야 한다.
    {
        // GET: /<controller>/
        public IActionResult Student() //함수가 View를 리턴 레이저파일을 추가 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Student([Bind("Name, Age")] Student model)
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
