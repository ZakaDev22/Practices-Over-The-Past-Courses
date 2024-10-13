using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Introduction_to_Cryptography_In_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Input data
            string data = "Mohammed Abu-Hadhoud";

            string data2 = "1234";

            // Compute the SHA-256 hash of the input data
            string hashedData = ComputeHash(data);

            // Compute the SHA-256 hash of the input data
            string hashedDat2a = ComputeHash(data2);

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;

            // Display the original data and its hash
            Console.WriteLine("\n Data 1 Information :");
            Console.WriteLine($"\nOriginal Data: {data}");
            Console.WriteLine($"\nHashed Data: {hashedData}");
            Console.WriteLine($"\nHashed Data Length : {hashedData.Length}");

            // Display the original data and its hash
            Console.WriteLine("\n Data 2 Information :");
            Console.WriteLine($"\nOriginal Data: {data2}");
            Console.WriteLine($"\nHashed Data: {hashedDat2a}");
            Console.WriteLine($"\nHashed Data Length : {hashedDat2a.Length}");

            if (hashedData == hashedDat2a)
            {
                Console.WriteLine("\n User Password is Correct");
            }
            else
            {
                Console.WriteLine("\n User Password is Not Correct");
            }

            Console.WriteLine("\n\n======================= Symmetric Encryption ============================\n\n");

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            // Original data
            string originalData = "Sensitive information";


            // Key for AES encryption (128-bit key)
            string key = "1234567890123456";


            // Encrypt the original data
            string encryptedData = Encrypt(originalData, key);


            // Decrypt the encrypted data
            string decryptedData = Decrypt(encryptedData, key);


            // Display results
            Console.WriteLine($"Original Data: {originalData}");
            Console.WriteLine($"Encrypted Data: {encryptedData}");
            Console.WriteLine($"Decrypted Data: {decryptedData}");

            Console.WriteLine("\n\n ===========================  Asymmetric Encryption =============================================");

            try
            {
                // Generate public and private key pair
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    // Get the public key
                    /*
                     When exporting the public key, ToXmlString(false) is used with the argument set 
                     to false to indicate that only the public parameters should be included in the XML string.
                     */
                    string publicKey = rsa.ToXmlString(false);


                    // Get the private key
                    string privateKey = rsa.ToXmlString(true);


                    // Original message
                    string originalMessage = "Hello, this is a secret message!";


                    // Encrypt using the public key
                    string encryptedMessage = EncryptUsingRSA(originalMessage, publicKey);


                    // Decrypt using the private key
                    string decryptedMessage = DecryptUsingRSA(encryptedMessage, privateKey);


                    // Display the results
                    Console.WriteLine($"\n\nPublic Key:\n {publicKey}");
                    Console.WriteLine($"\n\nPrivate Key:\n {privateKey}");
                    Console.WriteLine($"\nOriginal Message:\n {originalMessage}");
                    Console.WriteLine($"\nEncrypted Message:\n {encryptedMessage}");
                    Console.WriteLine($"\nDecrypted Message:\n {decryptedMessage}");


                    // Wait for user input before closing the console window
                    Console.WriteLine("\nPress any key to exit...");
                    Console.ReadKey();
                }
            }
            catch (CryptographicException ex)
            {
                Console.WriteLine($"Encryption/Decryption error: {ex.Message}");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                Console.ReadKey();
            }

            // Pause to keep the console window open for viewing the results
            Console.ReadKey();
        }

        // Hash method
        static string ComputeHash(string input)
        {
            //SHA is Secutred Hash Algorithm.
            // Create an instance of the SHA-256 algorithm
            using (SHA256 sha256 = SHA256.Create())
            {
                // Compute the hash value from the UTF-8 encoded input string
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));


                // Convert the byte array to a lowercase hexadecimal string
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }

        }

        // Symmetric Encryption 
        static string Encrypt(string plainText, string key)
        {
            using (Aes aesAlg = Aes.Create())
            {
                // Set the key and IV for AES encryption
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = new byte[aesAlg.BlockSize / 8];


                // Create an encryptor
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);


                // Encrypt the data
                using (MemoryStream msEncrypt = new System.IO.MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))

                    using (StreamWriter swEncrypt = new System.IO.StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(plainText);
                    }


                    // Return the encrypted data as a Base64-encoded string
                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }

        // Symmetric Encryption 
        static string Decrypt(string cipherText, string key)
        {
            using (Aes aesAlg = Aes.Create())
            {
                // Set the key and IV for AES decryption
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = new byte[aesAlg.BlockSize / 8];


                // Create a decryptor
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);


                // Decrypt the data
                using (var msDecrypt = new System.IO.MemoryStream(Convert.FromBase64String(cipherText)))
                using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                using (var srDecrypt = new System.IO.StreamReader(csDecrypt))
                {
                    // Read the decrypted data from the StreamReader
                    return srDecrypt.ReadToEnd();
                }
            }
        }

        // Asymmetric Encryption Method
        static string EncryptUsingRSA(string plainText, string publicKey)
        {
            try
            {
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    rsa.FromXmlString(publicKey);


                    byte[] encryptedData = rsa.Encrypt(Encoding.UTF8.GetBytes(plainText), false);
                    return Convert.ToBase64String(encryptedData);
                }
            }
            catch (CryptographicException ex)
            {
                Console.WriteLine($"Encryption error: {ex.Message}");
                throw; // Rethrow the exception to be caught in the Main method
            }
        }

        // Asymmetric Encryption Method
        static string DecryptUsingRSA(string cipherText, string privateKey)
        {
            try
            {
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    rsa.FromXmlString(privateKey);


                    byte[] encryptedData = Convert.FromBase64String(cipherText);
                    byte[] decryptedData = rsa.Decrypt(encryptedData, false);


                    return Encoding.UTF8.GetString(decryptedData);
                }
            }
            catch (CryptographicException ex)
            {
                Console.WriteLine($"Decryption error: {ex.Message}");
                throw; // Rethrow the exception to be caught in the Main method
            }
        }
    }
}
