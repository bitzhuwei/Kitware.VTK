using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkChooserPainter : vtkPolyDataPainter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkChooserPainter";

		public new static readonly string MRClassNameKey;

		static vtkChooserPainter()
		{
			vtkChooserPainter.MRClassNameKey = "class vtkChooserPainter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkChooserPainter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkChooserPainter"));
		}

		public vtkChooserPainter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkChooserPainter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkChooserPainter New()
		{
			vtkChooserPainter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkChooserPainter.vtkChooserPainter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkChooserPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkChooserPainter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkChooserPainter.vtkChooserPainter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkChooserPainter_GetUseLinesPainterForWireframes_01(HandleRef pThis);

		public virtual int GetUseLinesPainterForWireframes()
		{
			return vtkChooserPainter.vtkChooserPainter_GetUseLinesPainterForWireframes_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkChooserPainter_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkChooserPainter.vtkChooserPainter_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkChooserPainter_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkChooserPainter.vtkChooserPainter_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkChooserPainter_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkChooserPainter NewInstance()
		{
			vtkChooserPainter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkChooserPainter.vtkChooserPainter_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkChooserPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkChooserPainter_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkChooserPainter SafeDownCast(vtkObjectBase o)
		{
			vtkChooserPainter vtkChooserPainter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkChooserPainter.vtkChooserPainter_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkChooserPainter = (vtkChooserPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkChooserPainter.Register(null);
				}
			}
			return vtkChooserPainter;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkChooserPainter_SetLinePainter_07(HandleRef pThis, HandleRef arg0);

		public void SetLinePainter(vtkPolyDataPainter arg0)
		{
			vtkChooserPainter.vtkChooserPainter_SetLinePainter_07(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkChooserPainter_SetPolyPainter_08(HandleRef pThis, HandleRef arg0);

		public void SetPolyPainter(vtkPolyDataPainter arg0)
		{
			vtkChooserPainter.vtkChooserPainter_SetPolyPainter_08(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkChooserPainter_SetStripPainter_09(HandleRef pThis, HandleRef arg0);

		public void SetStripPainter(vtkPolyDataPainter arg0)
		{
			vtkChooserPainter.vtkChooserPainter_SetStripPainter_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkChooserPainter_SetUseLinesPainterForWireframes_10(HandleRef pThis, int _arg);

		public virtual void SetUseLinesPainterForWireframes(int _arg)
		{
			vtkChooserPainter.vtkChooserPainter_SetUseLinesPainterForWireframes_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkChooserPainter_SetVertPainter_11(HandleRef pThis, HandleRef arg0);

		public void SetVertPainter(vtkPolyDataPainter arg0)
		{
			vtkChooserPainter.vtkChooserPainter_SetVertPainter_11(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkChooserPainter_UseLinesPainterForWireframesOff_12(HandleRef pThis);

		public virtual void UseLinesPainterForWireframesOff()
		{
			vtkChooserPainter.vtkChooserPainter_UseLinesPainterForWireframesOff_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkChooserPainter_UseLinesPainterForWireframesOn_13(HandleRef pThis);

		public virtual void UseLinesPainterForWireframesOn()
		{
			vtkChooserPainter.vtkChooserPainter_UseLinesPainterForWireframesOn_13(base.GetCppThis());
		}
	}
}
