using System;
using System.Runtime.InteropServices;

namespace Tubumu.Libuv
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct uv_stream_t
    {
        public IntPtr write_queue_size;
        public IntPtr alloc_cb;
        public IntPtr read_cb;
        public IntPtr read2_cb;
    }
}
