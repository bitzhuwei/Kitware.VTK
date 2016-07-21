using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkHardwareSelectionPolyDataPainter : vtkStandardPolyDataPainter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkHardwareSelectionPolyDataPainter";

		public new static readonly string MRClassNameKey;

		static vtkHardwareSelectionPolyDataPainter()
		{
			vtkHardwareSelectionPolyDataPainter.MRClassNameKey = "class vtkHardwareSelectionPolyDataPainter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHardwareSelectionPolyDataPainter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHardwareSelectionPolyDataPainter"));
		}

		public vtkHardwareSelectionPolyDataPainter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkHardwareSelectionPolyDataPainter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHardwareSelectionPolyDataPainter New()
		{
			vtkHardwareSelectionPolyDataPainter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHardwareSelectionPolyDataPainter.vtkHardwareSelectionPolyDataPainter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHardwareSelectionPolyDataPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkHardwareSelectionPolyDataPainter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkHardwareSelectionPolyDataPainter.vtkHardwareSelectionPolyDataPainter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkHardwareSelectionPolyDataPainter_EnableSelectionOff_01(HandleRef pThis);

		public virtual void EnableSelectionOff()
		{
			vtkHardwareSelectionPolyDataPainter.vtkHardwareSelectionPolyDataPainter_EnableSelectionOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkHardwareSelectionPolyDataPainter_EnableSelectionOn_02(HandleRef pThis);

		public virtual void EnableSelectionOn()
		{
			vtkHardwareSelectionPolyDataPainter.vtkHardwareSelectionPolyDataPainter_EnableSelectionOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkHardwareSelectionPolyDataPainter_GetEnableSelection_03(HandleRef pThis);

		public virtual int GetEnableSelection()
		{
			return vtkHardwareSelectionPolyDataPainter.vtkHardwareSelectionPolyDataPainter_GetEnableSelection_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkHardwareSelectionPolyDataPainter_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkHardwareSelectionPolyDataPainter.vtkHardwareSelectionPolyDataPainter_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkHardwareSelectionPolyDataPainter_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkHardwareSelectionPolyDataPainter.vtkHardwareSelectionPolyDataPainter_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkHardwareSelectionPolyDataPainter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkHardwareSelectionPolyDataPainter NewInstance()
		{
			vtkHardwareSelectionPolyDataPainter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHardwareSelectionPolyDataPainter.vtkHardwareSelectionPolyDataPainter_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHardwareSelectionPolyDataPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkHardwareSelectionPolyDataPainter_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHardwareSelectionPolyDataPainter SafeDownCast(vtkObjectBase o)
		{
			vtkHardwareSelectionPolyDataPainter vtkHardwareSelectionPolyDataPainter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHardwareSelectionPolyDataPainter.vtkHardwareSelectionPolyDataPainter_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHardwareSelectionPolyDataPainter = (vtkHardwareSelectionPolyDataPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHardwareSelectionPolyDataPainter.Register(null);
				}
			}
			return vtkHardwareSelectionPolyDataPainter;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkHardwareSelectionPolyDataPainter_SetEnableSelection_09(HandleRef pThis, int _arg);

		public virtual void SetEnableSelection(int _arg)
		{
			vtkHardwareSelectionPolyDataPainter.vtkHardwareSelectionPolyDataPainter_SetEnableSelection_09(base.GetCppThis(), _arg);
		}
	}
}
