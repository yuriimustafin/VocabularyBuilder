﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities;
public class Sense
{
    public required string Definition { get; set; }
    public required IEnumerable<string> Examples { get; set; }
}
