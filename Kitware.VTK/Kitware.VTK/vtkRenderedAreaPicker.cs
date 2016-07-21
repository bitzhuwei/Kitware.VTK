using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkRenderedAreaPicker : vtkAreaPicker
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkRenderedAreaPicker";

		public new static readonly string MRClassNameKey;

		static vtkRenderedAreaPicker()
		{
			vtkRenderedAreaPicker.MRClassNameKey = "class vtkRenderedAreaPicker";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRenderedAreaPicker.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRenderedAreaPicker"));
		}

		public vtkRenderedAreaPicker(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedAreaPicker_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRenderedAreaPicker New()
		{
			vtkRenderedAreaPicker result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderedAreaPicker.vtkRenderedAreaPicker_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderedAreaPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkRenderedAreaPicker() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkRenderedAreaPicker.vtkRenderedAreaPicker_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderedAreaPicker_AreaPick_01(HandleRef pThis, double x0, double y0, double x1, double y1, HandleRef renderer);

		public override int AreaPick(double x0, double y0, double x1, double y1, vtkRenderer renderer)
		{
			return vtkRenderedAreaPicker.vtkRenderedAreaPicker_AreaPick_01(base.GetCppThis(), x0, y0, x1, y1, (renderer == null) ? default(HandleRef) : renderer.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderedAreaPicker_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkRenderedAreaPicker.vtkRenderedAreaPicker_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderedAreaPicker_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkRenderedAreaPicker.vtkRenderedAreaPicker_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedAreaPicker_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRenderedAreaPicker NewInstance()
		{
			vtkRenderedAreaPicker result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderedAreaPicker.vtkRenderedAreaPicker_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderedAreaPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderedAreaPicker_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRenderedAreaPicker SafeDownCast(vtkObjectBase o)
		{
			vtkRenderedAreaPicker vtkRenderedAreaPicker = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderedAreaPicker.vtkRenderedAreaPicker_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderedAreaPicker = (vtkRenderedAreaPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderedAreaPicker.Register(null);
				}
			}
			return vtkRenderedAreaPicker;
		}
	}
}
