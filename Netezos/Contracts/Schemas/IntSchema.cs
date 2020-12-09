﻿using System.Text.Json;
using Netezos.Encoding;

namespace Netezos.Contracts
{
    public sealed class IntSchema : Schema, IFlat
    {
        public override PrimType Prim => PrimType.@int;

        public IntSchema(MichelinePrim micheline) : base(micheline) { }

        internal override void WriteValue(Utf8JsonWriter writer, IMicheline value)
        {
            writer.WriteStringValue(Flatten(value));
        }

        public string Flatten(IMicheline value)
        {
            if (value is MichelineInt micheInt)
                return micheInt.Value.ToString();

            throw FormatException(value);
        }
    }
}
