﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Parsers;
public interface IWordReferenceParser
{
    // TODO: change return type to DictWord
    Task<IEnumerable<Word>> GetWords(IEnumerable<string> searchedWords);
}
