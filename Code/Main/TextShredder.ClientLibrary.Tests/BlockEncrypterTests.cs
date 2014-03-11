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
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace HauntedHouseSoftware.TextShredder.ClientLibrary.Tests
{
    [TestClass]
    public class BlockEncrypterTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "textToEncrypt")]
        public void EncryptBlockThrowsArgumentNullExceptionIfTextToEncryptIsNull()
        {
            BlockEncrypter.EncryptBlock(null, null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "password")]
        public void EncryptBlockThrowsArgumentNullExceptionIfPasswordIsNull()
        {
            BlockEncrypter.EncryptBlock("blah blah blah blah blah blah", null);
        }

        [TestMethod]        
        public void EncryptBlockEncryptsTextWithAPasswordAndResultIsNotNull()
        {
            string encrypted = BlockEncrypter.EncryptBlock("This is my message to encrypt.", Encoding.ASCII.GetBytes("Pa55w0rd"));
            Assert.IsNotNull(encrypted);
        }
       
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "textToEncrypt")]
        public void DecryptBlockThrowsArgumentNullExceptionIfTextToDecryptIsNull()
        {
            BlockEncrypter.DecryptBlock(null, null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "password")]
        public void DecryptBlockThrowsArgumentNullExceptionIfPasswordIsNull()
        {
            BlockEncrypter.DecryptBlock("blah blah blah blah blah blah", null);
        }

        [TestMethod]        
        public void DecryptBlockDecryptsBlockBackToOriginalPlainText()
        {
            string originalMessage = "This is my message to encrypt.";

            string encrypted = BlockEncrypter.EncryptBlock(originalMessage, Encoding.ASCII.GetBytes("Pa55w0rd"));
            string decrypted = BlockEncrypter.DecryptBlock(encrypted, Encoding.ASCII.GetBytes("Pa55w0rd"));

            Assert.AreEqual(originalMessage, decrypted);
        }
    }
}
