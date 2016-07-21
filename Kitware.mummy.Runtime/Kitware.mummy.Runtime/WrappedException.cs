using System;
using System.Runtime.InteropServices;

namespace Kitware.mummy.Runtime
{
	public class WrappedException : Exception, IDisposable
	{
		public const string MRFullTypeName = "Kitware.mummy.Runtime.WrappedException";

		public static readonly string MRClassNameKey;

		private HandleRef CppThis;

		private bool CallDisposalMethod;

		static WrappedException()
		{
			WrappedException.MRClassNameKey = "no equivalent unmanaged class";
		}

		protected WrappedException(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		{
			this.SetCppThis(rawCppThis, callDisposalMethod, strong);
		}

		~WrappedException()
		{
			this.Dispose(false);
		}

		public HandleRef GetCppThis()
		{
			return this.CppThis;
		}

		protected void SetCppThis(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		{
			this.CppThis = new HandleRef(this, rawCppThis);
			this.CallDisposalMethod = callDisposalMethod;
			if (rawCppThis != IntPtr.Zero)
			{
				Methods.AddTableReference(rawCppThis, this, strong);
			}
		}

		protected void ClearCppThis()
		{
			if (this.CppThis.Handle != IntPtr.Zero)
			{
				Methods.RemoveTableReference(this.CppThis.Handle);
			}
			this.CppThis = default(HandleRef);
			this.CallDisposalMethod = false;
		}

		protected bool GetCallDisposalMethod()
		{
			return this.CallDisposalMethod;
		}

		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
		}
	}
}
