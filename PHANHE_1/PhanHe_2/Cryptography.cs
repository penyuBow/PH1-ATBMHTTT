using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace PHANHE_1.PhanHe_2
{
    internal class Cryptography
    {
        static string AES_key_string = "w8axzmjhO2+LdlX4n8fUV0l0tSPnRK645iRHuhsJtYk=";
        static string AES_iv_string = "oLuwkGTF+25hMvEsmA6bZg==";
        static byte[] AES_key = Convert.FromBase64String(Cryptography.AES_key_string);
        static byte[] AES_iv = Convert.FromBase64String(Cryptography.AES_iv_string);
        static string RSA_publicKey = "<RSAKeyValue><Modulus>1vpO3Iu7L0Nz8/8VXBx3q7Mk8j2MjdzN5sqJrhr8pCKTVK7zLH83+AFUlPgqzTgRI2TU9dWXMn58dXP43iq9Kwg/l8kTP7CxbxEffDVGdAVJDpQSlzH2/KW/CJF1P0EVP3dAqVcu08LieXmwME0DDRDB7qQfUpuG0VJQ1UqFF40=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
        static string RSA_privateKey = "<RSAKeyValue><Modulus>1vpO3Iu7L0Nz8/8VXBx3q7Mk8j2MjdzN5sqJrhr8pCKTVK7zLH83+AFUlPgqzTgRI2TU9dWXMn58dXP43iq9Kwg/l8kTP7CxbxEffDVGdAVJDpQSlzH2/KW/CJF1P0EVP3dAqVcu08LieXmwME0DDRDB7qQfUpuG0VJQ1UqFF40=</Modulus><Exponent>AQAB</Exponent><P>4aqCqVzXetlQgPn4FhmNFcBmpir+4+rLkVkqRrOHG7fAA1De4zYg32zi5+HGOd5JTHsBzqsaAxE6W62RYSMSrw==</P><Q>89//lwPMMzznHB23VPEX5zIMbiFVP9+UhVEVwqu+ksiQ4k2JpBLSNcZ355Rhu9CGA7UujwnfXXiB1bMhXlf4gw==</Q><DP>3lKUQ7LZ/4fVjhu21F775jAVcSPu1jBduaa0xc7dDuuq2hl0XTjYjgXCTlzaY+yhHh4Zm7hp+heg/O00yxQ4tQ==</DP><DQ>CSSXt3ir+ivJWlN+4Q9c3w0QTDyxroBaWBkvIKpBrc0ZKXLQuzb9bIixTBxTAbCSpabwROqQ1jdDXtilYp0Xsw==</DQ><InverseQ>DK2qD8sT26FWZt+D/zYraOq7KcVQznSqmfYGbjrkF4fFJCYXN++ZRqeNn/jaNtCf+Votj6XGeTQHCN/VAd0BFg==</InverseQ><D>VqXXCV+sl7U5VDwZMOIsfeEb4CNctoUr3H0AF1O7RrDE71oAm4u/VE+89ro8DjEt/zUR/PAVG/4NTg3rXiidy7Arer15OBZ411YGGs3cY2r59Xz/vWFGK+gjuVvYd5pUOwAqBLOG9RMsRVDZSSlhw+4NEEMzdDmpbk2zXEjsSOU=</D></RSAKeyValue>";


        public static string SHA512_ComputeHash(string input)
        {
            string output;
            var inputBytes = System.Text.Encoding.UTF8.GetBytes(input);
            using (var sha512 = System.Security.Cryptography.SHA512.Create())
            {
                var hashedInputBytes = sha512.ComputeHash(inputBytes);

                // Convert to text
                // StringBuilder Capacity is 128, because 512 bits / 8 bits in byte * 2 symbols for byte 
                var hashedInputString = new System.Text.StringBuilder(128);
                foreach (var b in hashedInputBytes)
                    hashedInputString.Append(b.ToString("X2"));
                
                return hashedInputString.ToString();
            }
        }

        public static string MD5_ComputeHash(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string prior to .NET 5
                StringBuilder sb = new System.Text.StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        public static byte[] AES_EncryptStringToBytes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            // Return the encrypted bytes from the memory stream.
            return encrypted;
        }

        public static string AES_DecryptStringFromBytes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }

        public static string RSA_Encrypt(string plainText, string publicKey)
        {
            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
            byte[] encryptedData;
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(publicKey);
                encryptedData = rsa.Encrypt(plainBytes, false);
            }
            return Convert.ToBase64String(encryptedData);
        }

        public static string RSA_Decrypt(string cipherText, string privateKey)
        {
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            byte[] decryptedData;
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(privateKey);
                decryptedData = rsa.Decrypt(cipherBytes, false);
            }
            return Encoding.UTF8.GetString(decryptedData);
        }

        public static (string saltedString, string salt) addSalt(string input, string salt)
        {
            return (input + salt, salt);
        }
    }
}
