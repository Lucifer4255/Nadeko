﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NadekoBot.Modules.Searches.Commands.Models
{
    public class WikipediaApiModel
    {
        public WikipediaQuery Query { get; set; }

        public class WikipediaQuery
        {
            public WikipediaPage[] Pages { get; set; }

            public class WikipediaPage
            {
                public bool Missing { get; set; } = false;
                public string FullUrl { get; set; }
            }
        }
    }
}