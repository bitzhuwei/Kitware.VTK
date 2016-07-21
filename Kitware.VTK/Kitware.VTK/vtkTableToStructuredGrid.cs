using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTableToStructuredGrid : vtkStructuredGridAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTableToStructuredGrid";

		public new static readonly string MRClassNameKey;

		static vtkTableToStructuredGrid()
		{
			vtkTableToStructuredGrid.MRClassNameKey = "class vtkTableToStructuredGrid";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTableToStructuredGrid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTableToStructuredGrid"));
		}

		public vtkTableToStructuredGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTableToStructuredGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTableToStructuredGrid New()
		{
			vtkTableToStructuredGrid result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTableToStructuredGrid.vtkTableToStructuredGrid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTableToStructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTableToStructuredGrid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTableToStructuredGrid.vtkTableToStructuredGrid_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTableToStructuredGrid_GetWholeExtent_01(HandleRef pThis);

		public virtual int[] GetWholeExtent()
		{
			IntPtr intPtr = vtkTableToStructuredGrid.vtkTableToStructuredGrid_GetWholeExtent_01(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTableToStructuredGrid_GetWholeExtent_02(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		public virtual void GetWholeExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkTableToStructuredGrid.vtkTableToStructuredGrid_GetWholeExtent_02(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTableToStructuredGrid_GetWholeExtent_03(HandleRef pThis, IntPtr _arg);

		public virtual void GetWholeExtent(IntPtr _arg)
		{
			vtkTableToStructuredGrid.vtkTableToStructuredGrid_GetWholeExtent_03(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTableToStructuredGrid_GetXColumn_04(HandleRef pThis);

		public virtual string GetXColumn()
		{
			return Marshal.PtrToStringAnsi(vtkTableToStructuredGrid.vtkTableToStructuredGrid_GetXColumn_04(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTableToStructuredGrid_GetXComponent_05(HandleRef pThis);

		public virtual int GetXComponent()
		{
			return vtkTableToStructuredGrid.vtkTableToStructuredGrid_GetXComponent_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTableToStructuredGrid_GetXComponentMaxValue_06(HandleRef pThis);

		public virtual int GetXComponentMaxValue()
		{
			return vtkTableToStructuredGrid.vtkTableToStructuredGrid_GetXComponentMaxValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTableToStructuredGrid_GetXComponentMinValue_07(HandleRef pThis);

		public virtual int GetXComponentMinValue()
		{
			return vtkTableToStructuredGrid.vtkTableToStructuredGrid_GetXComponentMinValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTableToStructuredGrid_GetYColumn_08(HandleRef pThis);

		public virtual string GetYColumn()
		{
			return Marshal.PtrToStringAnsi(vtkTableToStructuredGrid.vtkTableToStructuredGrid_GetYColumn_08(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTableToStructuredGrid_GetYComponent_09(HandleRef pThis);

		public virtual int GetYComponent()
		{
			return vtkTableToStructuredGrid.vtkTableToStructuredGrid_GetYComponent_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTableToStructuredGrid_GetYComponentMaxValue_10(HandleRef pThis);

		public virtual int GetYComponentMaxValue()
		{
			return vtkTableToStructuredGrid.vtkTableToStructuredGrid_GetYComponentMaxValue_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTableToStructuredGrid_GetYComponentMinValue_11(HandleRef pThis);

		public virtual int GetYComponentMinValue()
		{
			return vtkTableToStructuredGrid.vtkTableToStructuredGrid_GetYComponentMinValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTableToStructuredGrid_GetZColumn_12(HandleRef pThis);

		public virtual string GetZColumn()
		{
			return Marshal.PtrToStringAnsi(vtkTableToStructuredGrid.vtkTableToStructuredGrid_GetZColumn_12(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTableToStructuredGrid_GetZComponent_13(HandleRef pThis);

		public virtual int GetZComponent()
		{
			return vtkTableToStructuredGrid.vtkTableToStructuredGrid_GetZComponent_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTableToStructuredGrid_GetZComponentMaxValue_14(HandleRef pThis);

		public virtual int GetZComponentMaxValue()
		{
			return vtkTableToStructuredGrid.vtkTableToStructuredGrid_GetZComponentMaxValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTableToStructuredGrid_GetZComponentMinValue_15(HandleRef pThis);

		public virtual int GetZComponentMinValue()
		{
			return vtkTableToStructuredGrid.vtkTableToStructuredGrid_GetZComponentMinValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTableToStructuredGrid_IsA_16(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTableToStructuredGrid.vtkTableToStructuredGrid_IsA_16(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTableToStructuredGrid_IsTypeOf_17(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTableToStructuredGrid.vtkTableToStructuredGrid_IsTypeOf_17(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTableToStructuredGrid_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTableToStructuredGrid NewInstance()
		{
			vtkTableToStructuredGrid result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTableToStructuredGrid.vtkTableToStructuredGrid_NewInstance_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTableToStructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTableToStructuredGrid_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTableToStructuredGrid SafeDownCast(vtkObjectBase o)
		{
			vtkTableToStructuredGrid vtkTableToStructuredGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTableToStructuredGrid.vtkTableToStructuredGrid_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTableToStructuredGrid = (vtkTableToStructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTableToStructuredGrid.Register(null);
				}
			}
			return vtkTableToStructuredGrid;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTableToStructuredGrid_SetWholeExtent_21(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		public virtual void SetWholeExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkTableToStructuredGrid.vtkTableToStructuredGrid_SetWholeExtent_21(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTableToStructuredGrid_SetWholeExtent_22(HandleRef pThis, IntPtr _arg);

		public virtual void SetWholeExtent(IntPtr _arg)
		{
			vtkTableToStructuredGrid.vtkTableToStructuredGrid_SetWholeExtent_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTableToStructuredGrid_SetXColumn_23(HandleRef pThis, string _arg);

		public virtual void SetXColumn(string _arg)
		{
			vtkTableToStructuredGrid.vtkTableToStructuredGrid_SetXColumn_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTableToStructuredGrid_SetXComponent_24(HandleRef pThis, int _arg);

		public virtual void SetXComponent(int _arg)
		{
			vtkTableToStructuredGrid.vtkTableToStructuredGrid_SetXComponent_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTableToStructuredGrid_SetYColumn_25(HandleRef pThis, string _arg);

		public virtual void SetYColumn(string _arg)
		{
			vtkTableToStructuredGrid.vtkTableToStructuredGrid_SetYColumn_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTableToStructuredGrid_SetYComponent_26(HandleRef pThis, int _arg);

		public virtual void SetYComponent(int _arg)
		{
			vtkTableToStructuredGrid.vtkTableToStructuredGrid_SetYComponent_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTableToStructuredGrid_SetZColumn_27(HandleRef pThis, string _arg);

		public virtual void SetZColumn(string _arg)
		{
			vtkTableToStructuredGrid.vtkTableToStructuredGrid_SetZColumn_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTableToStructuredGrid_SetZComponent_28(HandleRef pThis, int _arg);

		public virtual void SetZComponent(int _arg)
		{
			vtkTableToStructuredGrid.vtkTableToStructuredGrid_SetZComponent_28(base.GetCppThis(), _arg);
		}
	}
}
