/**
* Text Shredder : A personal message encryption tool.
* 
* Copyright (C) 2014 Stephen Haunts
* http://www.stephenhaunts.com
* 
* This file is part of Text Shredder.
* 
* Text Shredder is free software: you can redistribute it and/or modify it under the terms of the
* GNU General Public License as published by the Free Software Foundation, either version 2 of the
* License, or (at your option) any later version.
* 
* Text Shredder is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY;
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* 
* See the GNU General Public License for more details <http://www.gnu.org/licenses/>.
* 
* Authors: Stephen Haunts
*/

using HauntedHouseSoftware.TextShredder.ClientLibrary.CryptoProviders;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;

namespace HauntedHouseSoftware.TextShredder.ClientLibrary.Tests
{
    [TestClass]
    public class SecureHashTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "toBeHashed")]
        public void ComputeHashThrowsArgumentNullExceptionIfDataToHashedIsNull()
        {
            ISecureHash hash = new SecureHash();
            hash.ComputeHash(null);
        }

        [TestMethod]        
        public void ComputeHashCreatesHashOfSomeInputData()
        {
            var data = new byte[] {1, 2, 3, 4, 5, 6, 7, 8};

            ISecureHash hash = new SecureHash();
            byte[] hashedData = hash.ComputeHash(data);

            Assert.IsNotNull(hashedData);
        }

        [TestMethod]
        public void ComputeHashCreatesHashOfSomeInputDataAndItIsDifferentToInputData()
        {
            var data = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            ISecureHash hash = new SecureHash();
            var hashedData = hash.ComputeHash(data);

            Assert.IsTrue(ByteArrayCompare(data, hashedData));
        }

        [TestMethod]
        public void ComputeHashCreatesHashOfSomeInputDataAndItIs256BitsInLength()
        {
            var data = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            ISecureHash hash = new SecureHash();
            var hashedData = hash.ComputeHash(data);

            Assert.AreEqual(32, hashedData.Length);
        }

        private static bool ByteArrayCompare(byte[] a1, byte[] a2)
        {
            IStructuralEquatable eqa1 = a1;
            return !eqa1.Equals(a2, StructuralComparisons.StructuralEqualityComparer);
        }
    }
}
