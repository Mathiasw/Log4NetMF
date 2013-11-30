using System;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.SPOT;

namespace System.IO
{
    //[ComVisible(true)]
    //[Serializable]
    public class StringWriter : TextWriter
    {
        private StringBuilder _sb;

        public StringWriter()
        {
            
        }
        public StringWriter(IFormatProvider formatProvider)
        {
            
        }
        public StringWriter(StringBuilder sb)
        {
            _sb = sb;
        }
        public StringWriter(StringBuilder sb, IFormatProvider formatProvider)
        {
            _sb = sb;
        }
        //public override Encoding Encoding { get; }
        public override void Close()
        {
            
        }
        protected override void Dispose(bool disposing)
        {
            
        }
        public virtual StringBuilder GetStringBuilder()
        {
            return _sb;
        }

        //public override void Write(char value);
        //public override void Write(char[] buffer, int index, int count);
        //public override void Write(string value);
        //public override string ToString();
    }
}
