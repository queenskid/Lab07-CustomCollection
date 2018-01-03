using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionList
{
    class Product
    {
        public string ProductName { get; set; }
        public JerseyID Category { get; set; }
    }

    enum JerseyID : int
    {
        JerseyNFL = 1,
        JerseyNBA,
        JerseyMLS,
        JerseyMLB,
        JerserNHL
    }
}

