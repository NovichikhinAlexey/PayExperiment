using System.IO;

namespace Lykke.Service.PayMock.PayAuth.RSA
{
    public static class DemoRsa
    {
        public static string DemoPublicKey { get; }

        public static string DemoPrivateKey { get; }

        public static string DemoApiKey = "demo-api-key";

        static DemoRsa()
        {
            using (var reader = new StreamReader("PublicKey.txt"))
            {
                DemoPublicKey = reader.ReadToEnd();
            }

            using (var reader = new StreamReader("PrivateKey.txt"))
            {
                DemoPrivateKey = reader.ReadToEnd();
            }
        }
    }
}
