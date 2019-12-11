// Copyright (c) 2014, David Slayton <slaytonrnd@outlook.com>
// All rights reserved.
//
// Redistribution and use in source and binary forms, with or without
// modification, are permitted provided that the following conditions are met:
//     * Redistributions of source code must retain the above copyright
//       notice, this list of conditions and the following disclaimer.
//     * Redistributions in binary form must reproduce the above copyright
//       notice, this list of conditions and the following disclaimer in the
//       documentation and/or other materials provided with the distribution.
//     * Neither the name of the <organization> nor the
//       names of its contributors may be used to endorse or promote products
//       derived from this software without specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
// ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
// WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
// DISCLAIMED. IN NO EVENT SHALL <DAVID SLAYTON> BE LIABLE FOR ANY
// DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
// (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
// LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
// ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
// (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
// SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

using System;

namespace CartridgeWriterExtensions
{
    public static class ByteExtensions
    {
        private const string DefaultCartridgeString = "00-00-00-84-D2-D7-91-41-00-00-00-00-00-C0-51-40-45-4D-50-54-59-00-F1-49-04-F9-5B-63-F0-CC-60-1E-A4-41-93-0E-01-00-A1-05-6E-00-06-15-0E-27-2F-00-6E-00-06-15-0E-27-2F-00-14-AE-47-E1-7A-54-4D-40-5A-3D-00-00-00-00-02-19-55-AA-55-EB-2A-10-68-BE-41-76-00-00-00-00-00-00-14-AE-47-E1-7A-54-4D-40-45-99-90-3C-00-00-00-00-53-54-52-41-54-41-53-59-53-56-47-B7-0D-0D-58-50-C7-31-93-64-31-27-64-94-5E-CD-85-FF-1B-56-3D-4A-C4-43-79-1E-74-53-0C-9D-05-45-0D-0E-95-BB-EE-11-9F-30-27-07-BC-C7-48-7E-76-7B-EF-14-40-57-4E-79-0A-B8-5C-A7-20-AF-51-26-63-FA-6C-7A-AA-BF-85-BA-BF-82-26-CC-69-24-2A-EE-AB-F8-A9-23-38-0A-66-85-C2-80-AF-C3-DB-3A-F2-6D-AD-F2-78-EF-BD-1A-E3-56-EA-77-78-92-CD-79-37-BF-E5-22-72-C8-D5-7E-1E-41-BF-13-0F-6A-25-8F-62-BA-CB-9D-CD-B1-81-86-CF-79-DF-F4-AB-58-30-57-21-49-68-A5-20-E4-B5-C6-60-E3-2E-E7-A8-7A-3F-FE-F2-98-A6-24-3A-D0-43-04-1B-87-D0-68-6A-02-30-ED-0C-AA-76-2E-D6-F1-D9-8B-95-E1-16-A3-BD-08-F8-57-AD-B0-D2-D1-FB-5A-21-01-54-0E-AF-3B-6F-8C-8E-8E-EB-51-91-A0-A2-91-51-E5-DB-1D-00-03-09-EF-6A-E2-37-4B-EC-70-B9-1E-25-16-9B-E9-C1-DA-56-61-14-AE-54-B2-6B-D8-35-67-3B-6C-91-40-24-9F-AF-15-45-3B-FE-5E-0E-35-B7-5B-43-23-30-D4-31-34-2D-C1-D9-15-34-CC-A2-32-F6-A7-1D-2C-98-74-82-34-E0-63-24-C8-81-C0-9B-DE-2A-4A-0D-A7-DF-5A-EF-1D-FD-B5-DA-11-DA-F8-32-B6-19-2B-BD-F2-2D-50-68-EB-9A-37-3E-60-EB-CD-C5-40-2D-E7-EE-5C-1E-E7-4F-20-B2-E6-F2-53-6F-05-09-7D-F5-BB-BB-91-C7-2E-6C-68-4B-D6-6D-36-C3-A9-4B-D6-B5-E7-55-A4-8B-77-C0-C1-D2-08-36-A1-71-1D-76-2D-2E-E0-8C-65-B4-55-65-FF-93-5E-B6-61-6B-45-2D-02-9E-3D-D6-B4-4D-21-50-F0-70-42-8C-DC-B7-C4";

        public static byte[] Reverse(this byte[] bytes)
        {
            int len = bytes.Length;
            byte[] reversed = new byte[len];

            for (int i = 0; i < len; i++)
                reversed[len - i - 1] = bytes[i];

            return reversed;
        }

        public static string HexString(this byte[] bytes)
        {
            string hexString = string.Empty;

            foreach (byte b in bytes)
                hexString = hexString + b.ToString("x2");

            return hexString;
        }

        public static byte[] DefaultDecrypted(byte[] keyFragment)
        {
            var arr = DefaultCartridgeString.Split('-');
            byte[] array = new byte[arr.Length];
            for (int i = 0; i < arr.Length; i++)
                array[i] = Convert.ToByte(arr[i], 16);
            Buffer.BlockCopy(keyFragment, 0, array, 0x48, 8);
            return array;
        }
    }
}
