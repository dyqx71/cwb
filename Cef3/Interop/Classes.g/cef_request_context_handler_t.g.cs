//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Cef3.Interop
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.InteropServices;
    using System.Security;
    
    [StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
    [SuppressMessage("Microsoft.Design", "CA1049:TypesThatOwnNativeResourcesShouldBeDisposable")]
    internal unsafe struct cef_request_context_handler_t
    {
        internal cef_base_t _base;
        internal IntPtr _get_cookie_manager;
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int add_ref_delegate(cef_request_context_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int release_delegate(cef_request_context_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int get_refct_delegate(cef_request_context_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate cef_cookie_manager_t* get_cookie_manager_delegate(cef_request_context_handler_t* self);
        
        private static int _sizeof;
        
        static cef_request_context_handler_t()
        {
            _sizeof = Marshal.SizeOf(typeof(cef_request_context_handler_t));
        }
        
        internal static cef_request_context_handler_t* Alloc()
        {
            var ptr = (cef_request_context_handler_t*)Marshal.AllocHGlobal(_sizeof);
            *ptr = new cef_request_context_handler_t();
            ptr->_base._size = (UIntPtr)_sizeof;
            return ptr;
        }
        
        internal static void Free(cef_request_context_handler_t* ptr)
        {
            Marshal.FreeHGlobal((IntPtr)ptr);
        }
        
    }
}
