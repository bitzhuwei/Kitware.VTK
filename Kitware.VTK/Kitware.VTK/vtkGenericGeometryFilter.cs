using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGenericGeometryFilter : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericGeometryFilter";

		public new static readonly string MRClassNameKey;

		static vtkGenericGeometryFilter()
		{
			vtkGenericGeometryFilter.MRClassNameKey = "class vtkGenericGeometryFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericGeometryFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericGeometryFilter"));
		}

		public vtkGenericGeometryFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericGeometryFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGenericGeometryFilter New()
		{
			vtkGenericGeometryFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericGeometryFilter.vtkGenericGeometryFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericGeometryFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGenericGeometryFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGenericGeometryFilter.vtkGenericGeometryFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGeometryFilter_CellClippingOff_01(HandleRef pThis);

		public virtual void CellClippingOff()
		{
			vtkGenericGeometryFilter.vtkGenericGeometryFilter_CellClippingOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGeometryFilter_CellClippingOn_02(HandleRef pThis);

		public virtual void CellClippingOn()
		{
			vtkGenericGeometryFilter.vtkGenericGeometryFilter_CellClippingOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGeometryFilter_CreateDefaultLocator_03(HandleRef pThis);

		public void CreateDefaultLocator()
		{
			vtkGenericGeometryFilter.vtkGenericGeometryFilter_CreateDefaultLocator_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGeometryFilter_ExtentClippingOff_04(HandleRef pThis);

		public virtual void ExtentClippingOff()
		{
			vtkGenericGeometryFilter.vtkGenericGeometryFilter_ExtentClippingOff_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGeometryFilter_ExtentClippingOn_05(HandleRef pThis);

		public virtual void ExtentClippingOn()
		{
			vtkGenericGeometryFilter.vtkGenericGeometryFilter_ExtentClippingOn_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericGeometryFilter_GetCellClipping_06(HandleRef pThis);

		public virtual int GetCellClipping()
		{
			return vtkGenericGeometryFilter.vtkGenericGeometryFilter_GetCellClipping_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern long vtkGenericGeometryFilter_GetCellMaximum_07(HandleRef pThis);

		public virtual long GetCellMaximum()
		{
			return vtkGenericGeometryFilter.vtkGenericGeometryFilter_GetCellMaximum_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern long vtkGenericGeometryFilter_GetCellMaximumMaxValue_08(HandleRef pThis);

		public virtual long GetCellMaximumMaxValue()
		{
			return vtkGenericGeometryFilter.vtkGenericGeometryFilter_GetCellMaximumMaxValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern long vtkGenericGeometryFilter_GetCellMaximumMinValue_09(HandleRef pThis);

		public virtual long GetCellMaximumMinValue()
		{
			return vtkGenericGeometryFilter.vtkGenericGeometryFilter_GetCellMaximumMinValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern long vtkGenericGeometryFilter_GetCellMinimum_10(HandleRef pThis);

		public virtual long GetCellMinimum()
		{
			return vtkGenericGeometryFilter.vtkGenericGeometryFilter_GetCellMinimum_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern long vtkGenericGeometryFilter_GetCellMinimumMaxValue_11(HandleRef pThis);

		public virtual long GetCellMinimumMaxValue()
		{
			return vtkGenericGeometryFilter.vtkGenericGeometryFilter_GetCellMinimumMaxValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern long vtkGenericGeometryFilter_GetCellMinimumMinValue_12(HandleRef pThis);

		public virtual long GetCellMinimumMinValue()
		{
			return vtkGenericGeometryFilter.vtkGenericGeometryFilter_GetCellMinimumMinValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericGeometryFilter_GetExtent_13(HandleRef pThis);

		public IntPtr GetExtent()
		{
			return vtkGenericGeometryFilter.vtkGenericGeometryFilter_GetExtent_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericGeometryFilter_GetExtentClipping_14(HandleRef pThis);

		public virtual int GetExtentClipping()
		{
			return vtkGenericGeometryFilter.vtkGenericGeometryFilter_GetExtentClipping_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericGeometryFilter_GetLocator_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericGeometryFilter.vtkGenericGeometryFilter_GetLocator_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern uint vtkGenericGeometryFilter_GetMTime_16(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkGenericGeometryFilter.vtkGenericGeometryFilter_GetMTime_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericGeometryFilter_GetMerging_17(HandleRef pThis);

		public virtual int GetMerging()
		{
			return vtkGenericGeometryFilter.vtkGenericGeometryFilter_GetMerging_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericGeometryFilter_GetPassThroughCellIds_18(HandleRef pThis);

		public virtual int GetPassThroughCellIds()
		{
			return vtkGenericGeometryFilter.vtkGenericGeometryFilter_GetPassThroughCellIds_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericGeometryFilter_GetPointClipping_19(HandleRef pThis);

		public virtual int GetPointClipping()
		{
			return vtkGenericGeometryFilter.vtkGenericGeometryFilter_GetPointClipping_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern long vtkGenericGeometryFilter_GetPointMaximum_20(HandleRef pThis);

		public virtual long GetPointMaximum()
		{
			return vtkGenericGeometryFilter.vtkGenericGeometryFilter_GetPointMaximum_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern long vtkGenericGeometryFilter_GetPointMaximumMaxValue_21(HandleRef pThis);

		public virtual long GetPointMaximumMaxValue()
		{
			return vtkGenericGeometryFilter.vtkGenericGeometryFilter_GetPointMaximumMaxValue_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern long vtkGenericGeometryFilter_GetPointMaximumMinValue_22(HandleRef pThis);

		public virtual long GetPointMaximumMinValue()
		{
			return vtkGenericGeometryFilter.vtkGenericGeometryFilter_GetPointMaximumMinValue_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern long vtkGenericGeometryFilter_GetPointMinimum_23(HandleRef pThis);

		public virtual long GetPointMinimum()
		{
			return vtkGenericGeometryFilter.vtkGenericGeometryFilter_GetPointMinimum_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern long vtkGenericGeometryFilter_GetPointMinimumMaxValue_24(HandleRef pThis);

		public virtual long GetPointMinimumMaxValue()
		{
			return vtkGenericGeometryFilter.vtkGenericGeometryFilter_GetPointMinimumMaxValue_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern long vtkGenericGeometryFilter_GetPointMinimumMinValue_25(HandleRef pThis);

		public virtual long GetPointMinimumMinValue()
		{
			return vtkGenericGeometryFilter.vtkGenericGeometryFilter_GetPointMinimumMinValue_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericGeometryFilter_IsA_26(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGenericGeometryFilter.vtkGenericGeometryFilter_IsA_26(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericGeometryFilter_IsTypeOf_27(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGenericGeometryFilter.vtkGenericGeometryFilter_IsTypeOf_27(type);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGeometryFilter_MergingOff_28(HandleRef pThis);

		public virtual void MergingOff()
		{
			vtkGenericGeometryFilter.vtkGenericGeometryFilter_MergingOff_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGeometryFilter_MergingOn_29(HandleRef pThis);

		public virtual void MergingOn()
		{
			vtkGenericGeometryFilter.vtkGenericGeometryFilter_MergingOn_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericGeometryFilter_NewInstance_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGenericGeometryFilter NewInstance()
		{
			vtkGenericGeometryFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericGeometryFilter.vtkGenericGeometryFilter_NewInstance_31(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericGeometryFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGeometryFilter_PassThroughCellIdsOff_32(HandleRef pThis);

		public virtual void PassThroughCellIdsOff()
		{
			vtkGenericGeometryFilter.vtkGenericGeometryFilter_PassThroughCellIdsOff_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGeometryFilter_PassThroughCellIdsOn_33(HandleRef pThis);

		public virtual void PassThroughCellIdsOn()
		{
			vtkGenericGeometryFilter.vtkGenericGeometryFilter_PassThroughCellIdsOn_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGeometryFilter_PointClippingOff_34(HandleRef pThis);

		public virtual void PointClippingOff()
		{
			vtkGenericGeometryFilter.vtkGenericGeometryFilter_PointClippingOff_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGeometryFilter_PointClippingOn_35(HandleRef pThis);

		public virtual void PointClippingOn()
		{
			vtkGenericGeometryFilter.vtkGenericGeometryFilter_PointClippingOn_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericGeometryFilter_SafeDownCast_36(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGenericGeometryFilter SafeDownCast(vtkObjectBase o)
		{
			vtkGenericGeometryFilter vtkGenericGeometryFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericGeometryFilter.vtkGenericGeometryFilter_SafeDownCast_36((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericGeometryFilter = (vtkGenericGeometryFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericGeometryFilter.Register(null);
				}
			}
			return vtkGenericGeometryFilter;
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGeometryFilter_SetCellClipping_37(HandleRef pThis, int _arg);

		public virtual void SetCellClipping(int _arg)
		{
			vtkGenericGeometryFilter.vtkGenericGeometryFilter_SetCellClipping_37(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGeometryFilter_SetCellMaximum_38(HandleRef pThis, long _arg);

		public virtual void SetCellMaximum(long _arg)
		{
			vtkGenericGeometryFilter.vtkGenericGeometryFilter_SetCellMaximum_38(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGeometryFilter_SetCellMinimum_39(HandleRef pThis, long _arg);

		public virtual void SetCellMinimum(long _arg)
		{
			vtkGenericGeometryFilter.vtkGenericGeometryFilter_SetCellMinimum_39(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGeometryFilter_SetExtent_40(HandleRef pThis, double xMin, double xMax, double yMin, double yMax, double zMin, double zMax);

		public void SetExtent(double xMin, double xMax, double yMin, double yMax, double zMin, double zMax)
		{
			vtkGenericGeometryFilter.vtkGenericGeometryFilter_SetExtent_40(base.GetCppThis(), xMin, xMax, yMin, yMax, zMin, zMax);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGeometryFilter_SetExtent_41(HandleRef pThis, IntPtr extent);

		public void SetExtent(IntPtr extent)
		{
			vtkGenericGeometryFilter.vtkGenericGeometryFilter_SetExtent_41(base.GetCppThis(), extent);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGeometryFilter_SetExtentClipping_42(HandleRef pThis, int _arg);

		public virtual void SetExtentClipping(int _arg)
		{
			vtkGenericGeometryFilter.vtkGenericGeometryFilter_SetExtentClipping_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGeometryFilter_SetLocator_43(HandleRef pThis, HandleRef locator);

		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkGenericGeometryFilter.vtkGenericGeometryFilter_SetLocator_43(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGeometryFilter_SetMerging_44(HandleRef pThis, int _arg);

		public virtual void SetMerging(int _arg)
		{
			vtkGenericGeometryFilter.vtkGenericGeometryFilter_SetMerging_44(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGeometryFilter_SetPassThroughCellIds_45(HandleRef pThis, int _arg);

		public virtual void SetPassThroughCellIds(int _arg)
		{
			vtkGenericGeometryFilter.vtkGenericGeometryFilter_SetPassThroughCellIds_45(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGeometryFilter_SetPointClipping_46(HandleRef pThis, int _arg);

		public virtual void SetPointClipping(int _arg)
		{
			vtkGenericGeometryFilter.vtkGenericGeometryFilter_SetPointClipping_46(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGeometryFilter_SetPointMaximum_47(HandleRef pThis, long _arg);

		public virtual void SetPointMaximum(long _arg)
		{
			vtkGenericGeometryFilter.vtkGenericGeometryFilter_SetPointMaximum_47(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericGeometryFilter_SetPointMinimum_48(HandleRef pThis, long _arg);

		public virtual void SetPointMinimum(long _arg)
		{
			vtkGenericGeometryFilter.vtkGenericGeometryFilter_SetPointMinimum_48(base.GetCppThis(), _arg);
		}
	}
}
