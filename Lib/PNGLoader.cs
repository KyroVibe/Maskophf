using System;
using System.IO;

namespace Maskophf_Lib {
    public class PNG {

        private byte[] _raw;

        public Color[][] Pixels;

        public PNG(string path)
            => LoadFrom(File.ReadAllBytes(path));

        public PNG(byte[] data)
            => LoadFrom(data);

        private void LoadFrom(byte[] data) {
            _raw = data;
        }

        public void WriteTo(string path)
            => WriteTo(File.Create(path));

        public void WriteTo(Stream s) {
            var sw = new StreamWriter(s);
            // TODO
            sw.Flush();
            sw.Close();
        }
    }

    public struct Header {
        
    }

    public struct Color {
        public int R, G, B, A;
    }
}
