using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPointPicker : vtkPicker
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPointPicker";

		public new static readonly string MRClassNameKey;

		static vtkPointPicker()
		{
			vtkPointPicker.MRClassNameKey = "class vtkPointPicker";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPointPicker.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointPicker"));
		}

		public vtkPointPicker(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPointPicker_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPointPicker New()
		{
			vtkPointPicker result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPointPicker.vtkPointPicker_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPointPicker() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPointPicker.vtkPointPicker_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern long vtkPointPicker_GetPointId_01(HandleRef pThis);

		public virtual long GetPointId()
		{
			return vtkPointPicker.vtkPointPicker_GetPointId_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkPointPicker_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPointPicker.vtkPointPicker_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkPointPicker_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPointPicker.vtkPointPicker_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPointPicker_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPointPicker NewInstance()
		{
			vtkPointPicker result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPointPicker.vtkPointPicker_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPointPicker_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPointPicker SafeDownCast(vtkObjectBase o)
		{
			vtkPointPicker vtkPointPicker = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPointPicker.vtkPointPicker_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointPicker = (vtkPointPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointPicker.Register(null);
				}
			}
			return vtkPointPicker;
		}
	}
}
