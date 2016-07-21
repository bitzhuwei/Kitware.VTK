using Kitware.mummy.Runtime;
using System;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkObjectMarshaler : ICustomMarshaler
	{
		private static ICustomMarshaler TheInstance = new vtkObjectMarshaler();

		void ICustomMarshaler.CleanUpManagedData(object ManagedObj)
		{
		}

		void ICustomMarshaler.CleanUpNativeData(IntPtr pNativeData)
		{
		}

		int ICustomMarshaler.GetNativeDataSize()
		{
			return IntPtr.Size;
		}

		IntPtr ICustomMarshaler.MarshalManagedToNative(object ManagedObj)
		{
			return ((vtkObject)ManagedObj).GetCppThis().Handle;
		}

		object ICustomMarshaler.MarshalNativeToManaged(IntPtr pNativeData)
		{
			bool flag;
			object obj = Methods.CreateWrappedObject(0u, 4294967295u, 4294967208u, pNativeData, true, out flag);
			if (obj == null)
			{
				Console.Error.WriteLine("error: *DID NOT FIND* o in MarshalNativeToManaged");
				obj = new vtkObject(pNativeData, false, false);
			}
			return obj;
		}

		public static ICustomMarshaler GetInstance(string cookie)
		{
			return vtkObjectMarshaler.TheInstance;
		}
	}
}
