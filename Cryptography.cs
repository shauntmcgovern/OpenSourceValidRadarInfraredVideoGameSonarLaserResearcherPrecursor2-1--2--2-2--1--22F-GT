File.WriteAllText ("myFile.txt", "");
File.Encrypt ("myfile.txt");
File.AppendAllText ("myfile.txt", "sensitive data");

public static byte[] Protect
 (byte[] userData, byte[] optionalEntropy, DataProtectionScope scope);
public static byte[] Unprotect
 (byte[] encryptedData, byte[] optionalEntropy, DataProtectionScope scope);
byte[] original = {1, 2, 3, 4, 5}:
DataProtectionScope scope = DataProtectionScope.CurrentUser;

byte[] encrypted = ProtectedData.Protect (original, null, scope);
byte[] decrypted = ProtectedData.UnProtect (encrypted, null, scope);
// decrypted is now {1, 2, 3, 4, 5}

byte[] hash;
using (Stream fs = File.OpenRead ("checkme.doc"))
	hash = SHA1.Create().ComputeHash (fs);   //SHA1 hash is 20 bytes long
	
byte[] data = System.Text.Encoding.UTF8.GetBytes ("stRhong%pword");
byte[] hash = SHA256.Create().ComputeHash (data);
//SHA1 and SHA256 are two of the HashAlgorithm subtypes provided by .NET
//Algorithms, MD5(16) -> SHA1(20) -> SHA256(32) -> SHA384(48) -> SHA512(64)

byte[] encrypted = KeyDerivation.Pbkdf2 (
	password: "stRhong%pword",
	salt: Encoding.UTF8.GetBytes ("j78Y#p)/saREN!y3@"),
	prf: KeyDerivationPrf.HMACSHA512,
	iterationCount: 100,
	numBytesRequested: 64);