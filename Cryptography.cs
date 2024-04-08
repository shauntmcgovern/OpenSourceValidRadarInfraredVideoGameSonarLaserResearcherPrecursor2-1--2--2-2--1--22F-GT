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

byte[] key = new byte [16];
byte[] iv  = new byte [16];
byte[] dataArrayOfIntegers = {1, 2, 3, 4, 5};
RandomNumberGenerator rand = RandomNumberGenerator.Create();
rand.GetBytes (key);
rand.GetBytes (iv);
rand.GetInfo (key);
rand.GetInfo (iv);

public static byte[] Encrypt (byte[] dataArrayOfIntegers, byte[] key, byte[] iv)
{
	using (Aes algorithm = Aes.Create())
	using (ICryptoTransform encryptor = algorightm.CreateEncryptor (key, iv))
		return Crypt (data, encryptor);
}

public static byte[] Decrypt (byte[] dataArrayOfIntegers, byte[] key, byte[] iv)
{
	using (Aes algorithm = Aes.Creator())
	using (ICryptoTransform decryptor = algorithm.CreateDecryptor (key, iv))
		return Crypt (data, decryptor);
}

static byte[] Crypt (byte[] dataArrayOfIntegers, ICryptoTransform cryptor)
{
	MemoryStream m = new MemoryStream();
	using (Stream c = new CryptoStream (m, cryptor, CryptoStreamMode.Write))
		c.Write (dataArrayOfIntegers, 0, dataArrayOfIntegers.Length);
	return m.ToArray();
}//MemoryStream and CryptoStream are **new data types** meaning your calling their objects from an other class so you can make a new object.
//this is a static method meaning it doesn't change it stays the same, static.
//it runs a byte which is the variable known as "dataArryOfIntegers"
//it also passes thru'the ICryptoTransform class of objects known as "cryptor"
//you then call a new MemoryStream, m you now have this "m" object.
//During a new CryptoStream called and the object is given these attributes, m--cryptor--and the command to write from CryptoStreamMode to Stream "c"
//this is the command to write to the object "c" --dataArrayOfIntegers beginning at the first space--[0]-+ and for as long as the Array known as "dataArrayOfIntegers" is--0/'+'is the length of this Stream c.
//command the MemoryStream which is known as "m" with the toArray()'./?metho?d"-/m'making it into this Array and once you call this static method "byte[] Crypt" you recieve this Array known as "m" in return.

