﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Dtos
{
    
    public class ListRentalDto
    {        
        public int CustomerId { get; set; }
        
        public List<int> MovieIds { get; set; }
    }
}