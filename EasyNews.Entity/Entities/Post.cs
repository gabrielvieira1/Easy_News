﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyNews.Entity.Entities
{
  public class Post
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public bool Active { get; set; }
    public string Tags { get; set; }
    public int IdAddress { get; set; }
    public Address Address { get; set; }
  }
}
