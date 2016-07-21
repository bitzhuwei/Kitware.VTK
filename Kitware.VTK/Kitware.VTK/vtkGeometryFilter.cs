using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGeometryFilter : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGeometryFilter";

		public new static readonly string MRClassNameKey;

		static vtkGeometryFilter()
		{
			vtkGeometryFilter.MRClassNameKey = "class vtkGeometryFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGeometryFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGeometryFilter"));
		}

		public vtkGeometryFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkGeometryFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeometryFilter New()
		{
			vtkGeometryFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeometryFilter.vtkGeometryFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeometryFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGeometryFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGeometryFilter.vtkGeometryFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGeometryFilter_CellClippingOff_01(HandleRef pThis);

		public virtual void CellClippingOff()
		{
			vtkGeometryFilter.vtkGeometryFilter_CellClippingOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGeometryFilter_CellClippingOn_02(HandleRef pThis);

		public virtual void CellClippingOn()
		{
			vtkGeometryFilter.vtkGeometryFilter_CellClippingOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGeometryFilter_CreateDefaultLocator_03(HandleRef pThis);

		public void CreateDefaultLocator()
		{
			vtkGeometryFilter.vtkGeometryFilter_CreateDefaultLocator_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGeometryFilter_ExtentClippingOff_04(HandleRef pThis);

		public virtual void ExtentClippingOff()
		{
			vtkGeometryFilter.vtkGeometryFilter_ExtentClippingOff_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGeometryFilter_ExtentClippingOn_05(HandleRef pThis);

		public virtual void ExtentClippingOn()
		{
			vtkGeometryFilter.vtkGeometryFilter_ExtentClippingOn_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGeometryFilter_GetCellClipping_06(HandleRef pThis);

		public virtual int GetCellClipping()
		{
			return vtkGeometryFilter.vtkGeometryFilter_GetCellClipping_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkGeometryFilter_GetCellMaximum_07(HandleRef pThis);

		public virtual long GetCellMaximum()
		{
			return vtkGeometryFilter.vtkGeometryFilter_GetCellMaximum_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkGeometryFilter_GetCellMaximumMaxValue_08(HandleRef pThis);

		public virtual long GetCellMaximumMaxValue()
		{
			return vtkGeometryFilter.vtkGeometryFilter_GetCellMaximumMaxValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkGeometryFilter_GetCellMaximumMinValue_09(HandleRef pThis);

		public virtual long GetCellMaximumMinValue()
		{
			return vtkGeometryFilter.vtkGeometryFilter_GetCellMaximumMinValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkGeometryFilter_GetCellMinimum_10(HandleRef pThis);

		public virtual long GetCellMinimum()
		{
			return vtkGeometryFilter.vtkGeometryFilter_GetCellMinimum_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkGeometryFilter_GetCellMinimumMaxValue_11(HandleRef pThis);

		public virtual long GetCellMinimumMaxValue()
		{
			return vtkGeometryFilter.vtkGeometryFilter_GetCellMinimumMaxValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkGeometryFilter_GetCellMinimumMinValue_12(HandleRef pThis);

		public virtual long GetCellMinimumMinValue()
		{
			return vtkGeometryFilter.vtkGeometryFilter_GetCellMinimumMinValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkGeometryFilter_GetExtent_13(HandleRef pThis);

		public double[] GetExtent()
		{
			IntPtr intPtr = vtkGeometryFilter.vtkGeometryFilter_GetExtent_13(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGeometryFilter_GetExtentClipping_14(HandleRef pThis);

		public virtual int GetExtentClipping()
		{
			return vtkGeometryFilter.vtkGeometryFilter_GetExtentClipping_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkGeometryFilter_GetLocator_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeometryFilter.vtkGeometryFilter_GetLocator_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern uint vtkGeometryFilter_GetMTime_16(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkGeometryFilter.vtkGeometryFilter_GetMTime_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGeometryFilter_GetMerging_17(HandleRef pThis);

		public virtual int GetMerging()
		{
			return vtkGeometryFilter.vtkGeometryFilter_GetMerging_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGeometryFilter_GetPointClipping_18(HandleRef pThis);

		public virtual int GetPointClipping()
		{
			return vtkGeometryFilter.vtkGeometryFilter_GetPointClipping_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkGeometryFilter_GetPointMaximum_19(HandleRef pThis);

		public virtual long GetPointMaximum()
		{
			return vtkGeometryFilter.vtkGeometryFilter_GetPointMaximum_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkGeometryFilter_GetPointMaximumMaxValue_20(HandleRef pThis);

		public virtual long GetPointMaximumMaxValue()
		{
			return vtkGeometryFilter.vtkGeometryFilter_GetPointMaximumMaxValue_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkGeometryFilter_GetPointMaximumMinValue_21(HandleRef pThis);

		public virtual long GetPointMaximumMinValue()
		{
			return vtkGeometryFilter.vtkGeometryFilter_GetPointMaximumMinValue_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkGeometryFilter_GetPointMinimum_22(HandleRef pThis);

		public virtual long GetPointMinimum()
		{
			return vtkGeometryFilter.vtkGeometryFilter_GetPointMinimum_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkGeometryFilter_GetPointMinimumMaxValue_23(HandleRef pThis);

		public virtual long GetPointMinimumMaxValue()
		{
			return vtkGeometryFilter.vtkGeometryFilter_GetPointMinimumMaxValue_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkGeometryFilter_GetPointMinimumMinValue_24(HandleRef pThis);

		public virtual long GetPointMinimumMinValue()
		{
			return vtkGeometryFilter.vtkGeometryFilter_GetPointMinimumMinValue_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGeometryFilter_IsA_25(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGeometryFilter.vtkGeometryFilter_IsA_25(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGeometryFilter_IsTypeOf_26(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGeometryFilter.vtkGeometryFilter_IsTypeOf_26(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGeometryFilter_MergingOff_27(HandleRef pThis);

		public virtual void MergingOff()
		{
			vtkGeometryFilter.vtkGeometryFilter_MergingOff_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGeometryFilter_MergingOn_28(HandleRef pThis);

		public virtual void MergingOn()
		{
			vtkGeometryFilter.vtkGeometryFilter_MergingOn_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkGeometryFilter_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGeometryFilter NewInstance()
		{
			vtkGeometryFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeometryFilter.vtkGeometryFilter_NewInstance_30(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeometryFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGeometryFilter_PointClippingOff_31(HandleRef pThis);

		public virtual void PointClippingOff()
		{
			vtkGeometryFilter.vtkGeometryFilter_PointClippingOff_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGeometryFilter_PointClippingOn_32(HandleRef pThis);

		public virtual void PointClippingOn()
		{
			vtkGeometryFilter.vtkGeometryFilter_PointClippingOn_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkGeometryFilter_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeometryFilter SafeDownCast(vtkObjectBase o)
		{
			vtkGeometryFilter vtkGeometryFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeometryFilter.vtkGeometryFilter_SafeDownCast_33((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeometryFilter = (vtkGeometryFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeometryFilter.Register(null);
				}
			}
			return vtkGeometryFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGeometryFilter_SetCellClipping_34(HandleRef pThis, int _arg);

		public virtual void SetCellClipping(int _arg)
		{
			vtkGeometryFilter.vtkGeometryFilter_SetCellClipping_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGeometryFilter_SetCellMaximum_35(HandleRef pThis, long _arg);

		public virtual void SetCellMaximum(long _arg)
		{
			vtkGeometryFilter.vtkGeometryFilter_SetCellMaximum_35(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGeometryFilter_SetCellMinimum_36(HandleRef pThis, long _arg);

		public virtual void SetCellMinimum(long _arg)
		{
			vtkGeometryFilter.vtkGeometryFilter_SetCellMinimum_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGeometryFilter_SetExtent_37(HandleRef pThis, double xMin, double xMax, double yMin, double yMax, double zMin, double zMax);

		public void SetExtent(double xMin, double xMax, double yMin, double yMax, double zMin, double zMax)
		{
			vtkGeometryFilter.vtkGeometryFilter_SetExtent_37(base.GetCppThis(), xMin, xMax, yMin, yMax, zMin, zMax);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGeometryFilter_SetExtent_38(HandleRef pThis, IntPtr extent);

		public void SetExtent(IntPtr extent)
		{
			vtkGeometryFilter.vtkGeometryFilter_SetExtent_38(base.GetCppThis(), extent);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGeometryFilter_SetExtentClipping_39(HandleRef pThis, int _arg);

		public virtual void SetExtentClipping(int _arg)
		{
			vtkGeometryFilter.vtkGeometryFilter_SetExtentClipping_39(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGeometryFilter_SetLocator_40(HandleRef pThis, HandleRef locator);

		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkGeometryFilter.vtkGeometryFilter_SetLocator_40(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGeometryFilter_SetMerging_41(HandleRef pThis, int _arg);

		public virtual void SetMerging(int _arg)
		{
			vtkGeometryFilter.vtkGeometryFilter_SetMerging_41(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGeometryFilter_SetPointClipping_42(HandleRef pThis, int _arg);

		public virtual void SetPointClipping(int _arg)
		{
			vtkGeometryFilter.vtkGeometryFilter_SetPointClipping_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGeometryFilter_SetPointMaximum_43(HandleRef pThis, long _arg);

		public virtual void SetPointMaximum(long _arg)
		{
			vtkGeometryFilter.vtkGeometryFilter_SetPointMaximum_43(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGeometryFilter_SetPointMinimum_44(HandleRef pThis, long _arg);

		public virtual void SetPointMinimum(long _arg)
		{
			vtkGeometryFilter.vtkGeometryFilter_SetPointMinimum_44(base.GetCppThis(), _arg);
		}
	}
}
