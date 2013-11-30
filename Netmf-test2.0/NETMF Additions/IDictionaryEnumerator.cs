using System;
using System.Collections;
using System.Runtime.InteropServices;
using Microsoft.SPOT;

namespace System.Collections
{
    // [ComVisible(true)]
    public interface IDictionaryEnumerator : IEnumerator
    {
        object Key { get; }
        object Value { get; }
        DictionaryEntry Entry { get; }
    }
}
