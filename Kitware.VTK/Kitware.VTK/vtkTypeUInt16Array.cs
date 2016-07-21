using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTypeUInt16Array : vtkUnsignedShortArray
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTypeUInt16Array";

		public new static readonly string MRClassNameKey;

		static vtkTypeUInt16Array()
		{
			vtkTypeUInt16Array.MRClassNameKey = "class vtkTypeUInt16Array";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTypeUInt16Array.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTypeUInt16Array"));
		}

		public vtkTypeUInt16Array(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkTypeUInt16Array_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTypeUInt16Array New()
		{
			vtkTypeUInt16Array result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTypeUInt16Array.vtkTypeUInt16Array_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTypeUInt16Array)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTypeUInt16Array() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTypeUInt16Array.vtkTypeUInt16Array_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkTypeUInt16Array_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTypeUInt16Array.vtkTypeUInt16Array_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkTypeUInt16Array_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTypeUInt16Array.vtkTypeUInt16Array_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkTypeUInt16Array_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTypeUInt16Array NewInstance()
		{
			vtkTypeUInt16Array result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTypeUInt16Array.vtkTypeUInt16Array_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTypeUInt16Array)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkTypeUInt16Array_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTypeUInt16Array SafeDownCast(vtkObjectBase o)
		{
			vtkTypeUInt16Array vtkTypeUInt16Array = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTypeUInt16Array.vtkTypeUInt16Array_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTypeUInt16Array = (vtkTypeUInt16Array)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTypeUInt16Array.Register(null);
				}
			}
			return vtkTypeUInt16Array;
		}
	}
}
