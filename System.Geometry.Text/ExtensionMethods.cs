using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace System.Geometry.Text
{
    internal static class ExtensionMethods
    {
        public static void Skip(this BinaryReader br, int count) => br.ReadBytes(count);
        public static void Seek(this BinaryReader br, int count) => br.BaseStream.Seek(count, SeekOrigin.Current);
        public static void Seek(this BinaryReader br, uint count) => br.BaseStream.Seek(count, SeekOrigin.Begin);
        public static short ReadInt16BE(this BinaryReader br) => (short)htons(br.ReadUInt16());
        public static int ReadInt32BE(this BinaryReader br) => (int)htonl(br.ReadUInt32());
        public static uint Position(this BinaryReader br) => (uint)br.BaseStream.Position;
        public static ushort ReadUInt16BE(this BinaryReader br) => htons(br.ReadUInt16());
        public static uint ReadUInt32BE(this BinaryReader br) => htonl(br.ReadUInt32());



        static uint htonl(uint value)
        {
            // this branch is constant at JIT time and will be optimized out
            if (!BitConverter.IsLittleEndian)
            {
                return value;
            }

            var ptr = BitConverter.GetBytes(value);
            return (uint)(ptr[0] << 24 | ptr[1] << 16 | ptr[2] << 8 | ptr[3]);
        }

        static ushort htons(ushort value)
        {
            // this branch is constant at JIT time and will be optimized out
            if (!BitConverter.IsLittleEndian)
            {
                return value;
            }

            var ptr = BitConverter.GetBytes(value);
            return (ushort)(ptr[0] << 8 | ptr[1]);
        }
    }
}