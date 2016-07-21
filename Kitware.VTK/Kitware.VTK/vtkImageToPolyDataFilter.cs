using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageToPolyDataFilter : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageToPolyDataFilter";

		public new static readonly string MRClassNameKey;

		static vtkImageToPolyDataFilter()
		{
			vtkImageToPolyDataFilter.MRClassNameKey = "class vtkImageToPolyDataFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageToPolyDataFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageToPolyDataFilter"));
		}

		public vtkImageToPolyDataFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkImageToPolyDataFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageToPolyDataFilter New()
		{
			vtkImageToPolyDataFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageToPolyDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageToPolyDataFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImageToPolyDataFilter_DecimationOff_01(HandleRef pThis);

		public virtual void DecimationOff()
		{
			vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_DecimationOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImageToPolyDataFilter_DecimationOn_02(HandleRef pThis);

		public virtual void DecimationOn()
		{
			vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_DecimationOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkImageToPolyDataFilter_GetColorMode_03(HandleRef pThis);

		public virtual int GetColorMode()
		{
			return vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_GetColorMode_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkImageToPolyDataFilter_GetColorModeMaxValue_04(HandleRef pThis);

		public virtual int GetColorModeMaxValue()
		{
			return vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_GetColorModeMaxValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkImageToPolyDataFilter_GetColorModeMinValue_05(HandleRef pThis);

		public virtual int GetColorModeMinValue()
		{
			return vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_GetColorModeMinValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkImageToPolyDataFilter_GetDecimation_06(HandleRef pThis);

		public virtual int GetDecimation()
		{
			return vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_GetDecimation_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkImageToPolyDataFilter_GetDecimationError_07(HandleRef pThis);

		public virtual double GetDecimationError()
		{
			return vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_GetDecimationError_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkImageToPolyDataFilter_GetDecimationErrorMaxValue_08(HandleRef pThis);

		public virtual double GetDecimationErrorMaxValue()
		{
			return vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_GetDecimationErrorMaxValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkImageToPolyDataFilter_GetDecimationErrorMinValue_09(HandleRef pThis);

		public virtual double GetDecimationErrorMinValue()
		{
			return vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_GetDecimationErrorMinValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkImageToPolyDataFilter_GetError_10(HandleRef pThis);

		public virtual int GetError()
		{
			return vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_GetError_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkImageToPolyDataFilter_GetErrorMaxValue_11(HandleRef pThis);

		public virtual int GetErrorMaxValue()
		{
			return vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_GetErrorMaxValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkImageToPolyDataFilter_GetErrorMinValue_12(HandleRef pThis);

		public virtual int GetErrorMinValue()
		{
			return vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_GetErrorMinValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkImageToPolyDataFilter_GetLookupTable_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkScalarsToColors GetLookupTable()
		{
			vtkScalarsToColors vtkScalarsToColors = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_GetLookupTable_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarsToColors = (vtkScalarsToColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarsToColors.Register(null);
				}
			}
			return vtkScalarsToColors;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkImageToPolyDataFilter_GetNumberOfSmoothingIterations_14(HandleRef pThis);

		public virtual int GetNumberOfSmoothingIterations()
		{
			return vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_GetNumberOfSmoothingIterations_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkImageToPolyDataFilter_GetNumberOfSmoothingIterationsMaxValue_15(HandleRef pThis);

		public virtual int GetNumberOfSmoothingIterationsMaxValue()
		{
			return vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_GetNumberOfSmoothingIterationsMaxValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkImageToPolyDataFilter_GetNumberOfSmoothingIterationsMinValue_16(HandleRef pThis);

		public virtual int GetNumberOfSmoothingIterationsMinValue()
		{
			return vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_GetNumberOfSmoothingIterationsMinValue_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkImageToPolyDataFilter_GetOutputStyle_17(HandleRef pThis);

		public virtual int GetOutputStyle()
		{
			return vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_GetOutputStyle_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkImageToPolyDataFilter_GetOutputStyleMaxValue_18(HandleRef pThis);

		public virtual int GetOutputStyleMaxValue()
		{
			return vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_GetOutputStyleMaxValue_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkImageToPolyDataFilter_GetOutputStyleMinValue_19(HandleRef pThis);

		public virtual int GetOutputStyleMinValue()
		{
			return vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_GetOutputStyleMinValue_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkImageToPolyDataFilter_GetSmoothing_20(HandleRef pThis);

		public virtual int GetSmoothing()
		{
			return vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_GetSmoothing_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkImageToPolyDataFilter_GetSubImageSize_21(HandleRef pThis);

		public virtual int GetSubImageSize()
		{
			return vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_GetSubImageSize_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkImageToPolyDataFilter_GetSubImageSizeMaxValue_22(HandleRef pThis);

		public virtual int GetSubImageSizeMaxValue()
		{
			return vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_GetSubImageSizeMaxValue_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkImageToPolyDataFilter_GetSubImageSizeMinValue_23(HandleRef pThis);

		public virtual int GetSubImageSizeMinValue()
		{
			return vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_GetSubImageSizeMinValue_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkImageToPolyDataFilter_IsA_24(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_IsA_24(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkImageToPolyDataFilter_IsTypeOf_25(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_IsTypeOf_25(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkImageToPolyDataFilter_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageToPolyDataFilter NewInstance()
		{
			vtkImageToPolyDataFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_NewInstance_27(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageToPolyDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkImageToPolyDataFilter_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageToPolyDataFilter SafeDownCast(vtkObjectBase o)
		{
			vtkImageToPolyDataFilter vtkImageToPolyDataFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageToPolyDataFilter = (vtkImageToPolyDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageToPolyDataFilter.Register(null);
				}
			}
			return vtkImageToPolyDataFilter;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImageToPolyDataFilter_SetColorMode_29(HandleRef pThis, int _arg);

		public virtual void SetColorMode(int _arg)
		{
			vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_SetColorMode_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImageToPolyDataFilter_SetColorModeToLUT_30(HandleRef pThis);

		public void SetColorModeToLUT()
		{
			vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_SetColorModeToLUT_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImageToPolyDataFilter_SetColorModeToLinear256_31(HandleRef pThis);

		public void SetColorModeToLinear256()
		{
			vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_SetColorModeToLinear256_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImageToPolyDataFilter_SetDecimation_32(HandleRef pThis, int _arg);

		public virtual void SetDecimation(int _arg)
		{
			vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_SetDecimation_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImageToPolyDataFilter_SetDecimationError_33(HandleRef pThis, double _arg);

		public virtual void SetDecimationError(double _arg)
		{
			vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_SetDecimationError_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImageToPolyDataFilter_SetError_34(HandleRef pThis, int _arg);

		public virtual void SetError(int _arg)
		{
			vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_SetError_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImageToPolyDataFilter_SetLookupTable_35(HandleRef pThis, HandleRef arg0);

		public virtual void SetLookupTable(vtkScalarsToColors arg0)
		{
			vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_SetLookupTable_35(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImageToPolyDataFilter_SetNumberOfSmoothingIterations_36(HandleRef pThis, int _arg);

		public virtual void SetNumberOfSmoothingIterations(int _arg)
		{
			vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_SetNumberOfSmoothingIterations_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImageToPolyDataFilter_SetOutputStyle_37(HandleRef pThis, int _arg);

		public virtual void SetOutputStyle(int _arg)
		{
			vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_SetOutputStyle_37(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImageToPolyDataFilter_SetOutputStyleToPixelize_38(HandleRef pThis);

		public void SetOutputStyleToPixelize()
		{
			vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_SetOutputStyleToPixelize_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImageToPolyDataFilter_SetOutputStyleToPolygonalize_39(HandleRef pThis);

		public void SetOutputStyleToPolygonalize()
		{
			vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_SetOutputStyleToPolygonalize_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImageToPolyDataFilter_SetOutputStyleToRunLength_40(HandleRef pThis);

		public void SetOutputStyleToRunLength()
		{
			vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_SetOutputStyleToRunLength_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImageToPolyDataFilter_SetSmoothing_41(HandleRef pThis, int _arg);

		public virtual void SetSmoothing(int _arg)
		{
			vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_SetSmoothing_41(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImageToPolyDataFilter_SetSubImageSize_42(HandleRef pThis, int _arg);

		public virtual void SetSubImageSize(int _arg)
		{
			vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_SetSubImageSize_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImageToPolyDataFilter_SmoothingOff_43(HandleRef pThis);

		public virtual void SmoothingOff()
		{
			vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_SmoothingOff_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImageToPolyDataFilter_SmoothingOn_44(HandleRef pThis);

		public virtual void SmoothingOn()
		{
			vtkImageToPolyDataFilter.vtkImageToPolyDataFilter_SmoothingOn_44(base.GetCppThis());
		}
	}
}
