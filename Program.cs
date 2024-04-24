// Src Credit:
// https://www.c-sharpcorner.com/article/encryption-and-decryption-using-a-symmetric-key-in-c-sharp/

// See https://aka.ms/new-console-template for more information
using DotNetEncrypt;

IEncryptionService encryption = new EncryptionService();


// var key = "b14ca5898a4e4133bbce2ea2315a1916";

Console.WriteLine("Please enter a secret key for the symmetric algorithm.");
var key = Console.ReadLine();

Console.WriteLine("Please enter a string for encryption");
var str = Console.ReadLine() ?? "Some crazy text to encrypt because not value was entered.";
var encryptedString = encryption.EncryptString(key, str);
Console.WriteLine($"encrypted string = {encryptedString}");

var decryptedString = encryption.DecryptString(key, encryptedString);
Console.WriteLine($"decrypted string = {decryptedString}");

Console.ReadKey();