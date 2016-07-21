using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDisplayListPainter : vtkPainter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDisplayListPainter";

		public new static readonly string MRClassNameKey;

		static vtkDisplayListPainter()
		{
			vtkDisplayListPainter.MRClassNameKey = "class vtkDisplayListPainter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDisplayListPainter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDisplayListPainter"));
		}

		public vtkDisplayListPainter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDisplayListPainter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDisplayListPainter New()
		{
			vtkDisplayListPainter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDisplayListPainter.vtkDisplayListPainter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDisplayListPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDisplayListPainter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDisplayListPainter.vtkDisplayListPainter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkDisplayListPainter_GetTimeToDraw_01(HandleRef pThis);

		public override double GetTimeToDraw()
		{
			return vtkDisplayListPainter.vtkDisplayListPainter_GetTimeToDraw_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDisplayListPainter_IMMEDIATE_MODE_RENDERING_02(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey IMMEDIATE_MODE_RENDERING()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDisplayListPainter.vtkDisplayListPainter_IMMEDIATE_MODE_RENDERING_02(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkDisplayListPainter_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDisplayListPainter.vtkDisplayListPainter_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkDisplayListPainter_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDisplayListPainter.vtkDisplayListPainter_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDisplayListPainter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDisplayListPainter NewInstance()
		{
			vtkDisplayListPainter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDisplayListPainter.vtkDisplayListPainter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDisplayListPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDisplayListPainter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDisplayListPainter SafeDownCast(vtkObjectBase o)
		{
			vtkDisplayListPainter vtkDisplayListPainter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDisplayListPainter.vtkDisplayListPainter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDisplayListPainter = (vtkDisplayListPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDisplayListPainter.Register(null);
				}
			}
			return vtkDisplayListPainter;
		}
	}
}
