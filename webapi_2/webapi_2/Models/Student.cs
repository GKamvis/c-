using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace webapi_2.Models;

public partial class Student
{

    [Key]
    public int id { get; set; }

    public string? Ad { get; set; }

    public string? Soyad { get; set; }

   // public int? Kart { get; set; }

    public int? problemSolving { get; set; }
    public int? oop { get; set; }

    public int? cleancode { get; set; }

    public int? algorithm { get; set; }

    public int? teamwork { get; set; }




}
