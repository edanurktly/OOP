﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore_RelatedDataSave
{
   public class Blog
    {
        public Blog()
        {

            Posts = new HashSet<Post>();

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Post> Posts { get; set; }

    }
}
