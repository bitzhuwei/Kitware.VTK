using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTypeInt8Array : vtkCharArray
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTypeInt8Array";

		public new static readonly string MRClassNameKey;

		static vtkTypeInt8Array()
		{
			vtkTypeInt8Array.MRClassNameKey = "class vtkTypeInt8Array";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTypeInt8Array.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTypeInt8Array"));
		}

		public vtkTypeInt8Array(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkTypeInt8Array_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTypeInt8Array New()
		{
			vtkTypeInt8Array result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTypeInt8Array.vtkTypeInt8Array_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTypeInt8Array)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTypeInt8Array() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTypeInt8Array.vtkTypeInt8Array_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkTypeInt8Array_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTypeInt8Array.vtkTypeInt8Array_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkTypeInt8Array_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTypeInt8Array.vtkTypeInt8Array_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkTypeInt8Array_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTypeInt8Array NewInstance()
		{
			vtkTypeInt8Array result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTypeInt8Array.vtkTypeInt8Array_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTypeInt8Array)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkTypeInt8Array_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTypeInt8Array SafeDownCast(vtkObjectBase o)
		{
			vtkTypeInt8Array vtkTypeInt8Array = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTypeInt8Array.vtkTypeInt8Array_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTypeInt8Array = (vtkTypeInt8Array)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTypeInt8Array.Register(null);
				}
			}
			return vtkTypeInt8Array;
		}
	}
}
