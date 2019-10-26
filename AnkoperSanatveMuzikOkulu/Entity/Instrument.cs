﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnkoperSanatveMuzikOkulu.Entity
{
    public class Instrument
    {
        public Instrument()
        {
            _image = new List<Image>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public List<Image> _image { get; set; }

        public string Description { get; set; }

    }
}