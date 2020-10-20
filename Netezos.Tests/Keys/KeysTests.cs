using System;
using System.Threading.Tasks;
using Netezos.Keys;
using Xunit;

namespace Netezos.Tests.Keys
{
    public class KeysTests
    {
        [Fact]
        public void TestKey()
        {
            var key1 = new Key(ECKind.Ed25519);
            var key2 = new Key(ECKind.NistP256);
            var key3 = new Key(ECKind.Secp256k1);

            var hdKey1 = new HDKey(HDStandardKind.Bip32, ECKind.Secp256k1);
            var hdKey2 = new HDKey(HDStandardKind.Slip10, ECKind.Ed25519);

            var childKey1 = hdKey1.Derive(0).Derive(1, true).Derive(257);
            var childKey2 = hdKey2.Derive(0).Derive(1, true).Derive(257);
        }
    }
}
