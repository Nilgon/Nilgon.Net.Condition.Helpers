﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valtion.Core.Utilities.Exceptions.StringExceptions;
using Xunit;

namespace Valtion.Core.Tests.Utilities.Exceptions.StringExceptions
{
    public class StringEmptyException_Tests
    {
        [Fact]
        public void Throw_StringEmptyException_Without_Parameters()
        {
            //Action Throw = () => throw new StringEmptyException();

            //Assert.Throws<StringEmptyException>(Throw);
        }

        [Fact]
        public void Throw_StringEmptyException_With_Message()
        {
            //string message = "String empty exception occurred;";

            //Action Throw = () => throw new StringEmptyException(message);

            //Assert.Throws<StringEmptyException>(Throw);
        }

        [Fact]
        public void Throw_StringEmptyException_With_MessageAndInnerException()
        {
            //try
            //{
            //    throw new StringEmptyException();
            //}
            //catch (StringFullReferenceException innerException)
            //{
            //    string message = "String empty exception occurred;";

            //    Action Throw = () => throw new StringEmptyException(message, innerException);

            //    Assert.Throws<StringEmptyException>(Throw);
            //}
        }
    }
}