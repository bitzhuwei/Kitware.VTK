using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPropPicker : vtkAbstractPropPicker
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPropPicker";

		public new static readonly string MRClassNameKey;

		static vtkPropPicker()
		{
			vtkPropPicker.MRClassNameKey = "class vtkPropPicker";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPropPicker.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPropPicker"));
		}

		public vtkPropPicker(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPropPicker_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPropPicker New()
		{
			vtkPropPicker result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPropPicker.vtkPropPicker_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPropPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPropPicker() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPropPicker.vtkPropPicker_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkPropPicker_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPropPicker.vtkPropPicker_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkPropPicker_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPropPicker.vtkPropPicker_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPropPicker_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPropPicker NewInstance()
		{
			vtkPropPicker result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPropPicker.vtkPropPicker_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPropPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkPropPicker_Pick_05(HandleRef pThis, double selectionX, double selectionY, double selectionZ, HandleRef renderer);

		public override int Pick(double selectionX, double selectionY, double selectionZ, vtkRenderer renderer)
		{
			return vtkPropPicker.vtkPropPicker_Pick_05(base.GetCppThis(), selectionX, selectionY, selectionZ, (renderer == null) ? default(HandleRef) : renderer.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkPropPicker_Pick_06(HandleRef pThis, IntPtr selectionPt, HandleRef renderer);

		public new int Pick(IntPtr selectionPt, vtkRenderer renderer)
		{
			return vtkPropPicker.vtkPropPicker_Pick_06(base.GetCppThis(), selectionPt, (renderer == null) ? default(HandleRef) : renderer.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkPropPicker_PickProp_07(HandleRef pThis, double selectionX, double selectionY, HandleRef renderer);

		public int PickProp(double selectionX, double selectionY, vtkRenderer renderer)
		{
			return vtkPropPicker.vtkPropPicker_PickProp_07(base.GetCppThis(), selectionX, selectionY, (renderer == null) ? default(HandleRef) : renderer.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkPropPicker_PickProp_08(HandleRef pThis, double selectionX, double selectionY, HandleRef renderer, HandleRef pickfrom);

		public int PickProp(double selectionX, double selectionY, vtkRenderer renderer, vtkPropCollection pickfrom)
		{
			return vtkPropPicker.vtkPropPicker_PickProp_08(base.GetCppThis(), selectionX, selectionY, (renderer == null) ? default(HandleRef) : renderer.GetCppThis(), (pickfrom == null) ? default(HandleRef) : pickfrom.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPropPicker_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPropPicker SafeDownCast(vtkObjectBase o)
		{
			vtkPropPicker vtkPropPicker = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPropPicker.vtkPropPicker_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPropPicker = (vtkPropPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPropPicker.Register(null);
				}
			}
			return vtkPropPicker;
		}
	}
}
