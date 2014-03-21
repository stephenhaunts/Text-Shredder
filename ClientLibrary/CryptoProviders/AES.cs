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
using System.IO;
using System.Security.Cryptography;
using HauntedHouseSoftware.TextShredder.ClientLibrary;

namespace HauntedHouseSoftware.TextShredder.CryptoProviders
{
    public class AES : IAES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
        public byte[] Encrypt(byte[] dataToEncrypt, string password, byte[] salt, int pbkdfRounds)
        {
            if (dataToEncrypt == null)
            {
                throw new ArgumentNullException("dataToEncrypt");
            }

            if (dataToEncrypt.Length == 0)
            {
                throw new InvalidOperationException("dataToEncrypt");
            }

            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentNullException("password");
            }

            try
            {
                using (var rfc2898 = new Rfc2898DeriveBytes(password, salt, pbkdfRounds))
                {
                    using (var aes = new AesCryptoServiceProvider())
                    {
                        aes.Mode = CipherMode.CBC;
                        aes.Padding = PaddingMode.PKCS7;

                        aes.Key = rfc2898.GetBytes(32);
                        aes.IV = rfc2898.GetBytes(16);
                       
                        using (var memoryStream = new MemoryStream())
                        {                                                      
                            var cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write);
                            cryptoStream.Write(dataToEncrypt, 0, dataToEncrypt.Length);
                            cryptoStream.FlushFinalBlock();

                            var encryptedMessage = memoryStream.ToArray();

                            byte[] hmac = CreateHMAC(salt, aes, encryptedMessage);

                            var messagePlusHMAC = ByteHelpers.CreateSpecialByteArray(encryptedMessage.Length + 32);
                            messagePlusHMAC = ByteHelpers.Combine(hmac, encryptedMessage);
                            return messagePlusHMAC;                          
                        }
                    }
                }
            }
            catch
            {
                return null;
            }           
        }

        private static byte[] CreateHMAC(byte[] salt, AesCryptoServiceProvider aes, byte[] encryptedMessage)
        {
            using (var hmacsha256 = new HMACSHA256(aes.Key))
            {
                var messagePlusSALT = ByteHelpers.CreateSpecialByteArray(encryptedMessage.Length + 32);
                messagePlusSALT = ByteHelpers.Combine(encryptedMessage, salt);

                return hmacsha256.ComputeHash(messagePlusSALT);
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
        public byte[] Decrypt(byte[] dataToDecrypt, string password, byte[] salt, int pbkdfRounds)
        {
            if (dataToDecrypt == null)
            {
                throw new ArgumentNullException("dataToDecrypt");
            }

            if (dataToDecrypt.Length == 0)
            {
                throw new InvalidOperationException("dataToDecrypt");
            }

            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentNullException("password");
            }
        
            try
            {
                using (var rfc2898 = new Rfc2898DeriveBytes(password, salt, pbkdfRounds))
                {
                    using (var aes = new AesCryptoServiceProvider())
                    {
                        aes.Mode = CipherMode.CBC;
                        aes.Padding = PaddingMode.PKCS7;

                        aes.Key = rfc2898.GetBytes(32);
                        aes.IV = rfc2898.GetBytes(16);

                        using (var memoryStream = new MemoryStream())
                        {
                            var encryptedData = CheckHMAC(dataToDecrypt, salt, aes);
                                           
                            var cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Write);

                            cryptoStream.Write(encryptedData, 0, encryptedData.Length);
                            cryptoStream.FlushFinalBlock();

                            var decryptBytes = memoryStream.ToArray();                          

                            return decryptBytes;                            
                        }
                    }
                }
            }
            catch (CryptographicException ex)
            {
                throw new CryptographicException(ex.Message);
            }
            catch
            {
                return null;
            }           
        }

        private static byte[] CheckHMAC(byte[] dataToDecrypt, byte[] salt, AesCryptoServiceProvider aes)
        {            
            var hmac = ByteHelpers.CreateSpecialByteArray(32);
            var encryptedData = ByteHelpers.CreateSpecialByteArray(dataToDecrypt.Length - 32);

            Buffer.BlockCopy(dataToDecrypt, 0, hmac, 0, 32);
            Buffer.BlockCopy(dataToDecrypt, 32, encryptedData, 0, dataToDecrypt.Length - 32);
            
            var newHMAC = CreateHMAC(salt, aes, encryptedData);
                        
            if (!ByteHelpers.ByteArrayCompare(hmac, newHMAC))
            {
                throw new CryptographicException("The authenticated message code doesn't match. \n\nThe message may have been corrupted or tampered with.");
            }

            return encryptedData;
        }       
    }
}