﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valtion.Core.Utilities.Exceptions.StringExceptions
{
    public class StringEmptyException : Exception
    {
        /// <summary>
        /// Contractor <see cref="StringEmptyException"/> without parameters
        /// </summary>
        public StringEmptyException() : base() { }

        /// <summary>
        /// Contractor <see cref="StringEmptyException"/> with <paramref name="message"/>
        /// </summary>
        /// <param name="Message"></param>
        public StringEmptyException(string message) : base(message) { }
    }
}