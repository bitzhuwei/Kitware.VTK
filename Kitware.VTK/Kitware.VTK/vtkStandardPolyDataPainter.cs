using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkStandardPolyDataPainter : vtkPolyDataPainter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkStandardPolyDataPainter";

		public new static readonly string MRClassNameKey;

		static vtkStandardPolyDataPainter()
		{
			vtkStandardPolyDataPainter.MRClassNameKey = "class vtkStandardPolyDataPainter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStandardPolyDataPainter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStandardPolyDataPainter"));
		}

		public vtkStandardPolyDataPainter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkStandardPolyDataPainter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStandardPolyDataPainter New()
		{
			vtkStandardPolyDataPainter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStandardPolyDataPainter.vtkStandardPolyDataPainter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStandardPolyDataPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkStandardPolyDataPainter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkStandardPolyDataPainter.vtkStandardPolyDataPainter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkStandardPolyDataPainter_AddMultiTextureCoordsArray_01(HandleRef pThis, HandleRef array);

		public void AddMultiTextureCoordsArray(vtkDataArray array)
		{
			vtkStandardPolyDataPainter.vtkStandardPolyDataPainter_AddMultiTextureCoordsArray_01(base.GetCppThis(), (array == null) ? default(HandleRef) : array.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkStandardPolyDataPainter_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkStandardPolyDataPainter.vtkStandardPolyDataPainter_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkStandardPolyDataPainter_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkStandardPolyDataPainter.vtkStandardPolyDataPainter_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkStandardPolyDataPainter_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkStandardPolyDataPainter NewInstance()
		{
			vtkStandardPolyDataPainter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStandardPolyDataPainter.vtkStandardPolyDataPainter_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStandardPolyDataPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkStandardPolyDataPainter_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStandardPolyDataPainter SafeDownCast(vtkObjectBase o)
		{
			vtkStandardPolyDataPainter vtkStandardPolyDataPainter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStandardPolyDataPainter.vtkStandardPolyDataPainter_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStandardPolyDataPainter = (vtkStandardPolyDataPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStandardPolyDataPainter.Register(null);
				}
			}
			return vtkStandardPolyDataPainter;
		}
	}
}
