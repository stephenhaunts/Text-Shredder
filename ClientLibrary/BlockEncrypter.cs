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
using System.Security.Cryptography;
using Aes = HauntedHouseSoftware.TextShredder.ClientLibrary.CryptoProviders.Aes;

namespace HauntedHouseSoftware.TextShredder.ClientLibrary
{
    public static class BlockEncrypter
    {
        private readonly static ICompression Compressor = new GZipCompression();

        public static string EncryptBlock(string textToEncrypt, byte [] password)
        {       
            if (string.IsNullOrEmpty(textToEncrypt))
            {
                throw new ArgumentNullException("textToEncrypt");
            }

            if (password == null)
            {
                throw new ArgumentNullException("password");
            }

            var aes = new Aes();

            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                var salt = new byte[32];
                rngCsp.GetBytes(salt);

                var compressed = Compressor.Compress(ByteHelpers.GetBytes(textToEncrypt));

                var encrpytedMessage = aes.Encrypt(compressed, Convert.ToBase64String(password), salt, 70000);
                byte[] fullMessage = ByteHelpers.Combine(salt, encrpytedMessage);

                return Convert.ToBase64String(fullMessage);
            }                     
        }

        public static string DecryptBlock(string textToDecrypt, byte [] password)
        {
            if (string.IsNullOrEmpty(textToDecrypt))
            {
                throw new ArgumentNullException("textToDecrypt");
            }

            if (password == null)
            {
                throw new ArgumentNullException("password");
            }

            var aes = new Aes();

            var convertFromBase64String = Convert.FromBase64String(textToDecrypt);

            var salt = ByteHelpers.CreateSpecialByteArray(32);
            var message = ByteHelpers.CreateSpecialByteArray(convertFromBase64String.Length - 32);
            Buffer.BlockCopy(convertFromBase64String, 0, salt, 0, 32);
            Buffer.BlockCopy(convertFromBase64String, 32, message, 0, convertFromBase64String.Length - 32);

            var deCompressed = Compressor.Decompress(aes.Decrypt(message, Convert.ToBase64String(password), salt, 70000));

            return ByteHelpers.GetString(deCompressed);           
        }
    }
}
