
// Src Credit:
// https://www.c-sharpcorner.com/article/encryption-and-decryption-using-a-symmetric-key-in-c-sharp/

namespace DotNetEncrypt;

public interface IEncryptionService
{
    string EncryptString(string key, string plainText);

    string DecryptString(string key, string cipherText);
}