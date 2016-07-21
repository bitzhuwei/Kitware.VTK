using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTypeUInt8Array : vtkUnsignedCharArray
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTypeUInt8Array";

		public new static readonly string MRClassNameKey;

		static vtkTypeUInt8Array()
		{
			vtkTypeUInt8Array.MRClassNameKey = "class vtkTypeUInt8Array";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTypeUInt8Array.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTypeUInt8Array"));
		}

		public vtkTypeUInt8Array(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkTypeUInt8Array_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTypeUInt8Array New()
		{
			vtkTypeUInt8Array result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTypeUInt8Array.vtkTypeUInt8Array_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTypeUInt8Array)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTypeUInt8Array() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTypeUInt8Array.vtkTypeUInt8Array_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkTypeUInt8Array_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTypeUInt8Array.vtkTypeUInt8Array_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkTypeUInt8Array_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTypeUInt8Array.vtkTypeUInt8Array_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkTypeUInt8Array_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTypeUInt8Array NewInstance()
		{
			vtkTypeUInt8Array result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTypeUInt8Array.vtkTypeUInt8Array_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTypeUInt8Array)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkTypeUInt8Array_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTypeUInt8Array SafeDownCast(vtkObjectBase o)
		{
			vtkTypeUInt8Array vtkTypeUInt8Array = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTypeUInt8Array.vtkTypeUInt8Array_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTypeUInt8Array = (vtkTypeUInt8Array)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTypeUInt8Array.Register(null);
				}
			}
			return vtkTypeUInt8Array;
		}
	}
}
