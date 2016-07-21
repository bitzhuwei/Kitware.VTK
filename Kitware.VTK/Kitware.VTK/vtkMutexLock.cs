using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMutexLock : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMutexLock";

		public new static readonly string MRClassNameKey;

		static vtkMutexLock()
		{
			vtkMutexLock.MRClassNameKey = "class vtkMutexLock";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMutexLock.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMutexLock"));
		}

		public vtkMutexLock(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkMutexLock_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMutexLock New()
		{
			vtkMutexLock result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMutexLock.vtkMutexLock_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMutexLock)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMutexLock() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMutexLock.vtkMutexLock_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkMutexLock_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMutexLock.vtkMutexLock_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkMutexLock_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMutexLock.vtkMutexLock_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMutexLock_Lock_03(HandleRef pThis);

		public void Lock()
		{
			vtkMutexLock.vtkMutexLock_Lock_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkMutexLock_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMutexLock NewInstance()
		{
			vtkMutexLock result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMutexLock.vtkMutexLock_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMutexLock)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkMutexLock_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMutexLock SafeDownCast(vtkObjectBase o)
		{
			vtkMutexLock vtkMutexLock = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMutexLock.vtkMutexLock_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMutexLock = (vtkMutexLock)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMutexLock.Register(null);
				}
			}
			return vtkMutexLock;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMutexLock_Unlock_07(HandleRef pThis);

		public void Unlock()
		{
			vtkMutexLock.vtkMutexLock_Unlock_07(base.GetCppThis());
		}
	}
}
