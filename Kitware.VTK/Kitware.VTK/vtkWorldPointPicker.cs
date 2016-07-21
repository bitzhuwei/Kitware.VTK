using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkWorldPointPicker : vtkAbstractPicker
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkWorldPointPicker";

		public new static readonly string MRClassNameKey;

		static vtkWorldPointPicker()
		{
			vtkWorldPointPicker.MRClassNameKey = "class vtkWorldPointPicker";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWorldPointPicker.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWorldPointPicker"));
		}

		public vtkWorldPointPicker(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkWorldPointPicker_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkWorldPointPicker New()
		{
			vtkWorldPointPicker result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWorldPointPicker.vtkWorldPointPicker_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWorldPointPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkWorldPointPicker() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkWorldPointPicker.vtkWorldPointPicker_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkWorldPointPicker_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkWorldPointPicker.vtkWorldPointPicker_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkWorldPointPicker_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkWorldPointPicker.vtkWorldPointPicker_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkWorldPointPicker_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkWorldPointPicker NewInstance()
		{
			vtkWorldPointPicker result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWorldPointPicker.vtkWorldPointPicker_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWorldPointPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkWorldPointPicker_Pick_05(HandleRef pThis, double selectionX, double selectionY, double selectionZ, HandleRef renderer);

		public override int Pick(double selectionX, double selectionY, double selectionZ, vtkRenderer renderer)
		{
			return vtkWorldPointPicker.vtkWorldPointPicker_Pick_05(base.GetCppThis(), selectionX, selectionY, selectionZ, (renderer == null) ? default(HandleRef) : renderer.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkWorldPointPicker_Pick_06(HandleRef pThis, IntPtr selectionPt, HandleRef renderer);

		public new int Pick(IntPtr selectionPt, vtkRenderer renderer)
		{
			return vtkWorldPointPicker.vtkWorldPointPicker_Pick_06(base.GetCppThis(), selectionPt, (renderer == null) ? default(HandleRef) : renderer.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkWorldPointPicker_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkWorldPointPicker SafeDownCast(vtkObjectBase o)
		{
			vtkWorldPointPicker vtkWorldPointPicker = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWorldPointPicker.vtkWorldPointPicker_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWorldPointPicker = (vtkWorldPointPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWorldPointPicker.Register(null);
				}
			}
			return vtkWorldPointPicker;
		}
	}
}
