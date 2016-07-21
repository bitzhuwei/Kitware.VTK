using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkUnstructuredGridGeometryFilter : vtkUnstructuredGridAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridGeometryFilter";

		public new static readonly string MRClassNameKey;

		static vtkUnstructuredGridGeometryFilter()
		{
			vtkUnstructuredGridGeometryFilter.MRClassNameKey = "class vtkUnstructuredGridGeometryFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnstructuredGridGeometryFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridGeometryFilter"));
		}

		public vtkUnstructuredGridGeometryFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridGeometryFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUnstructuredGridGeometryFilter New()
		{
			vtkUnstructuredGridGeometryFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridGeometryFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkUnstructuredGridGeometryFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridGeometryFilter_CellClippingOff_01(HandleRef pThis);

		public virtual void CellClippingOff()
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_CellClippingOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridGeometryFilter_CellClippingOn_02(HandleRef pThis);

		public virtual void CellClippingOn()
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_CellClippingOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridGeometryFilter_CreateDefaultLocator_03(HandleRef pThis);

		public void CreateDefaultLocator()
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_CreateDefaultLocator_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridGeometryFilter_ExtentClippingOff_04(HandleRef pThis);

		public virtual void ExtentClippingOff()
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_ExtentClippingOff_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridGeometryFilter_ExtentClippingOn_05(HandleRef pThis);

		public virtual void ExtentClippingOn()
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_ExtentClippingOn_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridGeometryFilter_GetCellClipping_06(HandleRef pThis);

		public virtual int GetCellClipping()
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetCellClipping_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkUnstructuredGridGeometryFilter_GetCellMaximum_07(HandleRef pThis);

		public virtual long GetCellMaximum()
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetCellMaximum_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkUnstructuredGridGeometryFilter_GetCellMaximumMaxValue_08(HandleRef pThis);

		public virtual long GetCellMaximumMaxValue()
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetCellMaximumMaxValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkUnstructuredGridGeometryFilter_GetCellMaximumMinValue_09(HandleRef pThis);

		public virtual long GetCellMaximumMinValue()
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetCellMaximumMinValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkUnstructuredGridGeometryFilter_GetCellMinimum_10(HandleRef pThis);

		public virtual long GetCellMinimum()
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetCellMinimum_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkUnstructuredGridGeometryFilter_GetCellMinimumMaxValue_11(HandleRef pThis);

		public virtual long GetCellMinimumMaxValue()
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetCellMinimumMaxValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkUnstructuredGridGeometryFilter_GetCellMinimumMinValue_12(HandleRef pThis);

		public virtual long GetCellMinimumMinValue()
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetCellMinimumMinValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridGeometryFilter_GetExtent_13(HandleRef pThis);

		public IntPtr GetExtent()
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetExtent_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridGeometryFilter_GetExtentClipping_14(HandleRef pThis);

		public virtual int GetExtentClipping()
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetExtentClipping_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridGeometryFilter_GetLocator_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetLocator_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern uint vtkUnstructuredGridGeometryFilter_GetMTime_16(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetMTime_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridGeometryFilter_GetMerging_17(HandleRef pThis);

		public virtual int GetMerging()
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetMerging_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridGeometryFilter_GetOriginalCellIdsName_18(HandleRef pThis);

		public virtual string GetOriginalCellIdsName()
		{
			return Marshal.PtrToStringAnsi(vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetOriginalCellIdsName_18(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridGeometryFilter_GetOriginalPointIdsName_19(HandleRef pThis);

		public virtual string GetOriginalPointIdsName()
		{
			return Marshal.PtrToStringAnsi(vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetOriginalPointIdsName_19(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridGeometryFilter_GetPassThroughCellIds_20(HandleRef pThis);

		public virtual int GetPassThroughCellIds()
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetPassThroughCellIds_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridGeometryFilter_GetPassThroughPointIds_21(HandleRef pThis);

		public virtual int GetPassThroughPointIds()
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetPassThroughPointIds_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridGeometryFilter_GetPointClipping_22(HandleRef pThis);

		public virtual int GetPointClipping()
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetPointClipping_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkUnstructuredGridGeometryFilter_GetPointMaximum_23(HandleRef pThis);

		public virtual long GetPointMaximum()
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetPointMaximum_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkUnstructuredGridGeometryFilter_GetPointMaximumMaxValue_24(HandleRef pThis);

		public virtual long GetPointMaximumMaxValue()
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetPointMaximumMaxValue_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkUnstructuredGridGeometryFilter_GetPointMaximumMinValue_25(HandleRef pThis);

		public virtual long GetPointMaximumMinValue()
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetPointMaximumMinValue_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkUnstructuredGridGeometryFilter_GetPointMinimum_26(HandleRef pThis);

		public virtual long GetPointMinimum()
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetPointMinimum_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkUnstructuredGridGeometryFilter_GetPointMinimumMaxValue_27(HandleRef pThis);

		public virtual long GetPointMinimumMaxValue()
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetPointMinimumMaxValue_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkUnstructuredGridGeometryFilter_GetPointMinimumMinValue_28(HandleRef pThis);

		public virtual long GetPointMinimumMinValue()
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_GetPointMinimumMinValue_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridGeometryFilter_IsA_29(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_IsA_29(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridGeometryFilter_IsTypeOf_30(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_IsTypeOf_30(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridGeometryFilter_MergingOff_31(HandleRef pThis);

		public virtual void MergingOff()
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_MergingOff_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridGeometryFilter_MergingOn_32(HandleRef pThis);

		public virtual void MergingOn()
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_MergingOn_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridGeometryFilter_NewInstance_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkUnstructuredGridGeometryFilter NewInstance()
		{
			vtkUnstructuredGridGeometryFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_NewInstance_34(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridGeometryFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridGeometryFilter_PassThroughCellIdsOff_35(HandleRef pThis);

		public virtual void PassThroughCellIdsOff()
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_PassThroughCellIdsOff_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridGeometryFilter_PassThroughCellIdsOn_36(HandleRef pThis);

		public virtual void PassThroughCellIdsOn()
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_PassThroughCellIdsOn_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridGeometryFilter_PassThroughPointIdsOff_37(HandleRef pThis);

		public virtual void PassThroughPointIdsOff()
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_PassThroughPointIdsOff_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridGeometryFilter_PassThroughPointIdsOn_38(HandleRef pThis);

		public virtual void PassThroughPointIdsOn()
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_PassThroughPointIdsOn_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridGeometryFilter_PointClippingOff_39(HandleRef pThis);

		public virtual void PointClippingOff()
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_PointClippingOff_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridGeometryFilter_PointClippingOn_40(HandleRef pThis);

		public virtual void PointClippingOn()
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_PointClippingOn_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridGeometryFilter_SafeDownCast_41(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUnstructuredGridGeometryFilter SafeDownCast(vtkObjectBase o)
		{
			vtkUnstructuredGridGeometryFilter vtkUnstructuredGridGeometryFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_SafeDownCast_41((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridGeometryFilter = (vtkUnstructuredGridGeometryFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridGeometryFilter.Register(null);
				}
			}
			return vtkUnstructuredGridGeometryFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridGeometryFilter_SetCellClipping_42(HandleRef pThis, int _arg);

		public virtual void SetCellClipping(int _arg)
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_SetCellClipping_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridGeometryFilter_SetCellMaximum_43(HandleRef pThis, long _arg);

		public virtual void SetCellMaximum(long _arg)
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_SetCellMaximum_43(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridGeometryFilter_SetCellMinimum_44(HandleRef pThis, long _arg);

		public virtual void SetCellMinimum(long _arg)
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_SetCellMinimum_44(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridGeometryFilter_SetExtent_45(HandleRef pThis, double xMin, double xMax, double yMin, double yMax, double zMin, double zMax);

		public void SetExtent(double xMin, double xMax, double yMin, double yMax, double zMin, double zMax)
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_SetExtent_45(base.GetCppThis(), xMin, xMax, yMin, yMax, zMin, zMax);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridGeometryFilter_SetExtent_46(HandleRef pThis, IntPtr extent);

		public void SetExtent(IntPtr extent)
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_SetExtent_46(base.GetCppThis(), extent);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridGeometryFilter_SetExtentClipping_47(HandleRef pThis, int _arg);

		public virtual void SetExtentClipping(int _arg)
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_SetExtentClipping_47(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridGeometryFilter_SetLocator_48(HandleRef pThis, HandleRef locator);

		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_SetLocator_48(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridGeometryFilter_SetMerging_49(HandleRef pThis, int _arg);

		public virtual void SetMerging(int _arg)
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_SetMerging_49(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridGeometryFilter_SetOriginalCellIdsName_50(HandleRef pThis, string _arg);

		public virtual void SetOriginalCellIdsName(string _arg)
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_SetOriginalCellIdsName_50(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridGeometryFilter_SetOriginalPointIdsName_51(HandleRef pThis, string _arg);

		public virtual void SetOriginalPointIdsName(string _arg)
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_SetOriginalPointIdsName_51(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridGeometryFilter_SetPassThroughCellIds_52(HandleRef pThis, int _arg);

		public virtual void SetPassThroughCellIds(int _arg)
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_SetPassThroughCellIds_52(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridGeometryFilter_SetPassThroughPointIds_53(HandleRef pThis, int _arg);

		public virtual void SetPassThroughPointIds(int _arg)
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_SetPassThroughPointIds_53(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridGeometryFilter_SetPointClipping_54(HandleRef pThis, int _arg);

		public virtual void SetPointClipping(int _arg)
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_SetPointClipping_54(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridGeometryFilter_SetPointMaximum_55(HandleRef pThis, long _arg);

		public virtual void SetPointMaximum(long _arg)
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_SetPointMaximum_55(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridGeometryFilter_SetPointMinimum_56(HandleRef pThis, long _arg);

		public virtual void SetPointMinimum(long _arg)
		{
			vtkUnstructuredGridGeometryFilter.vtkUnstructuredGridGeometryFilter_SetPointMinimum_56(base.GetCppThis(), _arg);
		}
	}
}
