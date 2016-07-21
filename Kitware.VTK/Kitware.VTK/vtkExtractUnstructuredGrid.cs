using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkExtractUnstructuredGrid : vtkUnstructuredGridAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractUnstructuredGrid";

		public new static readonly string MRClassNameKey;

		static vtkExtractUnstructuredGrid()
		{
			vtkExtractUnstructuredGrid.MRClassNameKey = "class vtkExtractUnstructuredGrid";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractUnstructuredGrid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractUnstructuredGrid"));
		}

		public vtkExtractUnstructuredGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractUnstructuredGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractUnstructuredGrid New()
		{
			vtkExtractUnstructuredGrid result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkExtractUnstructuredGrid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractUnstructuredGrid_CellClippingOff_01(HandleRef pThis);

		public virtual void CellClippingOff()
		{
			vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_CellClippingOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractUnstructuredGrid_CellClippingOn_02(HandleRef pThis);

		public virtual void CellClippingOn()
		{
			vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_CellClippingOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractUnstructuredGrid_CreateDefaultLocator_03(HandleRef pThis);

		public void CreateDefaultLocator()
		{
			vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_CreateDefaultLocator_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractUnstructuredGrid_ExtentClippingOff_04(HandleRef pThis);

		public virtual void ExtentClippingOff()
		{
			vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_ExtentClippingOff_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractUnstructuredGrid_ExtentClippingOn_05(HandleRef pThis);

		public virtual void ExtentClippingOn()
		{
			vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_ExtentClippingOn_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractUnstructuredGrid_GetCellClipping_06(HandleRef pThis);

		public virtual int GetCellClipping()
		{
			return vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_GetCellClipping_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkExtractUnstructuredGrid_GetCellMaximum_07(HandleRef pThis);

		public virtual long GetCellMaximum()
		{
			return vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_GetCellMaximum_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkExtractUnstructuredGrid_GetCellMaximumMaxValue_08(HandleRef pThis);

		public virtual long GetCellMaximumMaxValue()
		{
			return vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_GetCellMaximumMaxValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkExtractUnstructuredGrid_GetCellMaximumMinValue_09(HandleRef pThis);

		public virtual long GetCellMaximumMinValue()
		{
			return vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_GetCellMaximumMinValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkExtractUnstructuredGrid_GetCellMinimum_10(HandleRef pThis);

		public virtual long GetCellMinimum()
		{
			return vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_GetCellMinimum_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkExtractUnstructuredGrid_GetCellMinimumMaxValue_11(HandleRef pThis);

		public virtual long GetCellMinimumMaxValue()
		{
			return vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_GetCellMinimumMaxValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkExtractUnstructuredGrid_GetCellMinimumMinValue_12(HandleRef pThis);

		public virtual long GetCellMinimumMinValue()
		{
			return vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_GetCellMinimumMinValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractUnstructuredGrid_GetExtent_13(HandleRef pThis);

		public double[] GetExtent()
		{
			IntPtr intPtr = vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_GetExtent_13(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractUnstructuredGrid_GetExtentClipping_14(HandleRef pThis);

		public virtual int GetExtentClipping()
		{
			return vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_GetExtentClipping_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractUnstructuredGrid_GetLocator_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_GetLocator_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIncrementalPointLocator = (vtkIncrementalPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIncrementalPointLocator.Register(null);
				}
			}
			return vtkIncrementalPointLocator;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern uint vtkExtractUnstructuredGrid_GetMTime_16(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_GetMTime_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractUnstructuredGrid_GetMerging_17(HandleRef pThis);

		public virtual int GetMerging()
		{
			return vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_GetMerging_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractUnstructuredGrid_GetPointClipping_18(HandleRef pThis);

		public virtual int GetPointClipping()
		{
			return vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_GetPointClipping_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkExtractUnstructuredGrid_GetPointMaximum_19(HandleRef pThis);

		public virtual long GetPointMaximum()
		{
			return vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_GetPointMaximum_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkExtractUnstructuredGrid_GetPointMaximumMaxValue_20(HandleRef pThis);

		public virtual long GetPointMaximumMaxValue()
		{
			return vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_GetPointMaximumMaxValue_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkExtractUnstructuredGrid_GetPointMaximumMinValue_21(HandleRef pThis);

		public virtual long GetPointMaximumMinValue()
		{
			return vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_GetPointMaximumMinValue_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkExtractUnstructuredGrid_GetPointMinimum_22(HandleRef pThis);

		public virtual long GetPointMinimum()
		{
			return vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_GetPointMinimum_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkExtractUnstructuredGrid_GetPointMinimumMaxValue_23(HandleRef pThis);

		public virtual long GetPointMinimumMaxValue()
		{
			return vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_GetPointMinimumMaxValue_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkExtractUnstructuredGrid_GetPointMinimumMinValue_24(HandleRef pThis);

		public virtual long GetPointMinimumMinValue()
		{
			return vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_GetPointMinimumMinValue_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractUnstructuredGrid_IsA_25(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_IsA_25(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractUnstructuredGrid_IsTypeOf_26(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_IsTypeOf_26(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractUnstructuredGrid_MergingOff_27(HandleRef pThis);

		public virtual void MergingOff()
		{
			vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_MergingOff_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractUnstructuredGrid_MergingOn_28(HandleRef pThis);

		public virtual void MergingOn()
		{
			vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_MergingOn_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractUnstructuredGrid_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkExtractUnstructuredGrid NewInstance()
		{
			vtkExtractUnstructuredGrid result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_NewInstance_30(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractUnstructuredGrid_PointClippingOff_31(HandleRef pThis);

		public virtual void PointClippingOff()
		{
			vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_PointClippingOff_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractUnstructuredGrid_PointClippingOn_32(HandleRef pThis);

		public virtual void PointClippingOn()
		{
			vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_PointClippingOn_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractUnstructuredGrid_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractUnstructuredGrid SafeDownCast(vtkObjectBase o)
		{
			vtkExtractUnstructuredGrid vtkExtractUnstructuredGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_SafeDownCast_33((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractUnstructuredGrid = (vtkExtractUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractUnstructuredGrid.Register(null);
				}
			}
			return vtkExtractUnstructuredGrid;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractUnstructuredGrid_SetCellClipping_34(HandleRef pThis, int _arg);

		public virtual void SetCellClipping(int _arg)
		{
			vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_SetCellClipping_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractUnstructuredGrid_SetCellMaximum_35(HandleRef pThis, long _arg);

		public virtual void SetCellMaximum(long _arg)
		{
			vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_SetCellMaximum_35(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractUnstructuredGrid_SetCellMinimum_36(HandleRef pThis, long _arg);

		public virtual void SetCellMinimum(long _arg)
		{
			vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_SetCellMinimum_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractUnstructuredGrid_SetExtent_37(HandleRef pThis, double xMin, double xMax, double yMin, double yMax, double zMin, double zMax);

		public void SetExtent(double xMin, double xMax, double yMin, double yMax, double zMin, double zMax)
		{
			vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_SetExtent_37(base.GetCppThis(), xMin, xMax, yMin, yMax, zMin, zMax);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractUnstructuredGrid_SetExtent_38(HandleRef pThis, IntPtr extent);

		public void SetExtent(IntPtr extent)
		{
			vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_SetExtent_38(base.GetCppThis(), extent);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractUnstructuredGrid_SetExtentClipping_39(HandleRef pThis, int _arg);

		public virtual void SetExtentClipping(int _arg)
		{
			vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_SetExtentClipping_39(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractUnstructuredGrid_SetLocator_40(HandleRef pThis, HandleRef locator);

		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_SetLocator_40(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractUnstructuredGrid_SetMerging_41(HandleRef pThis, int _arg);

		public virtual void SetMerging(int _arg)
		{
			vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_SetMerging_41(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractUnstructuredGrid_SetPointClipping_42(HandleRef pThis, int _arg);

		public virtual void SetPointClipping(int _arg)
		{
			vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_SetPointClipping_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractUnstructuredGrid_SetPointMaximum_43(HandleRef pThis, long _arg);

		public virtual void SetPointMaximum(long _arg)
		{
			vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_SetPointMaximum_43(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractUnstructuredGrid_SetPointMinimum_44(HandleRef pThis, long _arg);

		public virtual void SetPointMinimum(long _arg)
		{
			vtkExtractUnstructuredGrid.vtkExtractUnstructuredGrid_SetPointMinimum_44(base.GetCppThis(), _arg);
		}
	}
}
