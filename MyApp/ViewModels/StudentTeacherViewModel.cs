﻿using MyApp.Model;
using MyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.ViewModels
{
    public class StudentTeacherViewModel
    {
        public Student Student { get; set; }
        public List<teacher> Teachers { get; set; }

    }
}