// <copyright file="InvalidPropertyTest.cs" company="Thuzi, LLC">Microsoft Public License (Ms-PL)</copyright>
using System;
using Facebook;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Facebook
{
    /// <summary>This class contains parameterized unit tests for InvalidProperty</summary>
    [PexClass(typeof(InvalidProperty))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class InvalidPropertyTest
    {
        /// <summary>Test stub for Equals(InvalidProperty)</summary>
        [PexMethod]
        public bool Equals01(
            [PexAssumeUnderTest]InvalidProperty target,
            InvalidProperty other
        )
        {
            bool result = target.Equals(other);
            return result;
            // TODO: add assertions to method InvalidPropertyTest.Equals01(InvalidProperty, InvalidProperty)
        }

        /// <summary>Test stub for op_Explicit(InvalidProperty)</summary>
        [PexMethod]
        public bool Explicit(InvalidProperty invalidProperty)
        {
            bool result = (bool)invalidProperty;
            return result;
            // TODO: add assertions to method InvalidPropertyTest.Explicit(InvalidProperty)
        }

        /// <summary>Test stub for op_Explicit(InvalidProperty)</summary>
        [PexMethod]
        public int Explicit01(InvalidProperty invalidProperty)
        {
            int result = (int)invalidProperty;
            return result;
            // TODO: add assertions to method InvalidPropertyTest.Explicit01(InvalidProperty)
        }

        /// <summary>Test stub for op_Explicit(InvalidProperty)</summary>
        [PexMethod]
        public long Explicit02(InvalidProperty invalidProperty)
        {
            long result = (long)invalidProperty;
            return result;
            // TODO: add assertions to method InvalidPropertyTest.Explicit02(InvalidProperty)
        }

        /// <summary>Test stub for op_Implicit(InvalidProperty)</summary>
        [PexMethod]
        public string Implicit(InvalidProperty invalidProperty)
        {
            string result = (string)invalidProperty;
            return result;
            // TODO: add assertions to method InvalidPropertyTest.Implicit(InvalidProperty)
        }

        /// <summary>Test stub for Instance</summary>
        [PexMethod]
        public void InstanceGet()
        {
            InvalidProperty result = InvalidProperty.Instance;
            // TODO: add assertions to method InvalidPropertyTest.InstanceGet()
        }

        /// <summary>Test stub for ToString()</summary>
        [PexMethod]
        public string ToString01([PexAssumeUnderTest]InvalidProperty target)
        {
            string result = target.ToString();
            return result;
            // TODO: add assertions to method InvalidPropertyTest.ToString01(InvalidProperty)
        }
    }
}
