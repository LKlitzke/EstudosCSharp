﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1.Entities
{
    class Comment
    {
        public string Text { get; set; }

        public Comment()
        {

        }
        public Comment(string text)
        {
            Text = text;
        }

    }
}
