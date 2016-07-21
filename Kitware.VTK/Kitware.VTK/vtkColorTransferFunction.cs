using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkColorTransferFunction : vtkScalarsToColors
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkColorTransferFunction";

		public new static readonly string MRClassNameKey;

		static vtkColorTransferFunction()
		{
			vtkColorTransferFunction.MRClassNameKey = "class vtkColorTransferFunction";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkColorTransferFunction.MRClassNameKey, Type.GetType("Kitware.VTK.vtkColorTransferFunction"));
		}

		public vtkColorTransferFunction(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkColorTransferFunction_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkColorTransferFunction New()
		{
			vtkColorTransferFunction result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkColorTransferFunction.vtkColorTransferFunction_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkColorTransferFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkColorTransferFunction() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkColorTransferFunction.vtkColorTransferFunction_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkColorTransferFunction_AddHSVPoint_01(HandleRef pThis, double x, double h, double s, double v);

		public int AddHSVPoint(double x, double h, double s, double v)
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_AddHSVPoint_01(base.GetCppThis(), x, h, s, v);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkColorTransferFunction_AddHSVPoint_02(HandleRef pThis, double x, double h, double s, double v, double midpoint, double sharpness);

		public int AddHSVPoint(double x, double h, double s, double v, double midpoint, double sharpness)
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_AddHSVPoint_02(base.GetCppThis(), x, h, s, v, midpoint, sharpness);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkColorTransferFunction_AddHSVSegment_03(HandleRef pThis, double x1, double h1, double s1, double v1, double x2, double h2, double s2, double v2);

		public void AddHSVSegment(double x1, double h1, double s1, double v1, double x2, double h2, double s2, double v2)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_AddHSVSegment_03(base.GetCppThis(), x1, h1, s1, v1, x2, h2, s2, v2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkColorTransferFunction_AddRGBPoint_04(HandleRef pThis, double x, double r, double g, double b);

		public int AddRGBPoint(double x, double r, double g, double b)
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_AddRGBPoint_04(base.GetCppThis(), x, r, g, b);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkColorTransferFunction_AddRGBPoint_05(HandleRef pThis, double x, double r, double g, double b, double midpoint, double sharpness);

		public int AddRGBPoint(double x, double r, double g, double b, double midpoint, double sharpness)
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_AddRGBPoint_05(base.GetCppThis(), x, r, g, b, midpoint, sharpness);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkColorTransferFunction_AddRGBSegment_06(HandleRef pThis, double x1, double r1, double g1, double b1, double x2, double r2, double g2, double b2);

		public void AddRGBSegment(double x1, double r1, double g1, double b1, double x2, double r2, double g2, double b2)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_AddRGBSegment_06(base.GetCppThis(), x1, r1, g1, b1, x2, r2, g2, b2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkColorTransferFunction_AdjustRange_07(HandleRef pThis, IntPtr range);

		public int AdjustRange(IntPtr range)
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_AdjustRange_07(base.GetCppThis(), range);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkColorTransferFunction_AllowDuplicateScalarsOff_08(HandleRef pThis);

		public virtual void AllowDuplicateScalarsOff()
		{
			vtkColorTransferFunction.vtkColorTransferFunction_AllowDuplicateScalarsOff_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkColorTransferFunction_AllowDuplicateScalarsOn_09(HandleRef pThis);

		public virtual void AllowDuplicateScalarsOn()
		{
			vtkColorTransferFunction.vtkColorTransferFunction_AllowDuplicateScalarsOn_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkColorTransferFunction_BuildFunctionFromTable_10(HandleRef pThis, double x1, double x2, int size, IntPtr table);

		public void BuildFunctionFromTable(double x1, double x2, int size, IntPtr table)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_BuildFunctionFromTable_10(base.GetCppThis(), x1, x2, size, table);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkColorTransferFunction_ClampingOff_11(HandleRef pThis);

		public virtual void ClampingOff()
		{
			vtkColorTransferFunction.vtkColorTransferFunction_ClampingOff_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkColorTransferFunction_ClampingOn_12(HandleRef pThis);

		public virtual void ClampingOn()
		{
			vtkColorTransferFunction.vtkColorTransferFunction_ClampingOn_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkColorTransferFunction_DeepCopy_13(HandleRef pThis, HandleRef f);

		public void DeepCopy(vtkColorTransferFunction f)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_DeepCopy_13(base.GetCppThis(), (f == null) ? default(HandleRef) : f.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkColorTransferFunction_FillFromDataPointer_14(HandleRef pThis, int arg0, IntPtr arg1);

		public void FillFromDataPointer(int arg0, IntPtr arg1)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_FillFromDataPointer_14(base.GetCppThis(), arg0, arg1);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkColorTransferFunction_GetAllowDuplicateScalars_15(HandleRef pThis);

		public virtual int GetAllowDuplicateScalars()
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_GetAllowDuplicateScalars_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkColorTransferFunction_GetBlueValue_16(HandleRef pThis, double x);

		public double GetBlueValue(double x)
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_GetBlueValue_16(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkColorTransferFunction_GetClamping_17(HandleRef pThis);

		public virtual int GetClamping()
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_GetClamping_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkColorTransferFunction_GetClampingMaxValue_18(HandleRef pThis);

		public virtual int GetClampingMaxValue()
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_GetClampingMaxValue_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkColorTransferFunction_GetClampingMinValue_19(HandleRef pThis);

		public virtual int GetClampingMinValue()
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_GetClampingMinValue_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkColorTransferFunction_GetColor_20(HandleRef pThis, double x);

		public new double[] GetColor(double x)
		{
			IntPtr intPtr = vtkColorTransferFunction.vtkColorTransferFunction_GetColor_20(base.GetCppThis(), x);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkColorTransferFunction_GetColor_21(HandleRef pThis, double x, IntPtr rgb);

		public override void GetColor(double x, IntPtr rgb)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_GetColor_21(base.GetCppThis(), x, rgb);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkColorTransferFunction_GetColorSpace_22(HandleRef pThis);

		public virtual int GetColorSpace()
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_GetColorSpace_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkColorTransferFunction_GetColorSpaceMaxValue_23(HandleRef pThis);

		public virtual int GetColorSpaceMaxValue()
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_GetColorSpaceMaxValue_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkColorTransferFunction_GetColorSpaceMinValue_24(HandleRef pThis);

		public virtual int GetColorSpaceMinValue()
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_GetColorSpaceMinValue_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkColorTransferFunction_GetDataPointer_25(HandleRef pThis);

		public IntPtr GetDataPointer()
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_GetDataPointer_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkColorTransferFunction_GetGreenValue_26(HandleRef pThis, double x);

		public double GetGreenValue(double x)
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_GetGreenValue_26(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkColorTransferFunction_GetHSVWrap_27(HandleRef pThis);

		public virtual int GetHSVWrap()
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_GetHSVWrap_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkColorTransferFunction_GetNanColor_28(HandleRef pThis);

		public virtual double[] GetNanColor()
		{
			IntPtr intPtr = vtkColorTransferFunction.vtkColorTransferFunction_GetNanColor_28(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkColorTransferFunction_GetNanColor_29(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetNanColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_GetNanColor_29(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkColorTransferFunction_GetNanColor_30(HandleRef pThis, IntPtr _arg);

		public virtual void GetNanColor(IntPtr _arg)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_GetNanColor_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkColorTransferFunction_GetNodeValue_31(HandleRef pThis, int index, IntPtr val);

		public int GetNodeValue(int index, IntPtr val)
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_GetNodeValue_31(base.GetCppThis(), index, val);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkColorTransferFunction_GetNumberOfAvailableColors_32(HandleRef pThis);

		public override long GetNumberOfAvailableColors()
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_GetNumberOfAvailableColors_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkColorTransferFunction_GetRange_33(HandleRef pThis);

		public override double[] GetRange()
		{
			IntPtr intPtr = vtkColorTransferFunction.vtkColorTransferFunction_GetRange_33(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkColorTransferFunction_GetRange_34(HandleRef pThis, ref double _arg1, ref double _arg2);

		public virtual void GetRange(ref double _arg1, ref double _arg2)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_GetRange_34(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkColorTransferFunction_GetRange_35(HandleRef pThis, IntPtr _arg);

		public virtual void GetRange(IntPtr _arg)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_GetRange_35(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkColorTransferFunction_GetRedValue_36(HandleRef pThis, double x);

		public double GetRedValue(double x)
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_GetRedValue_36(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkColorTransferFunction_GetScale_37(HandleRef pThis);

		public virtual int GetScale()
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_GetScale_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkColorTransferFunction_GetSize_38(HandleRef pThis);

		public int GetSize()
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_GetSize_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkColorTransferFunction_GetTable_39(HandleRef pThis, double x1, double x2, int n, IntPtr table);

		public void GetTable(double x1, double x2, int n, IntPtr table)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_GetTable_39(base.GetCppThis(), x1, x2, n, table);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkColorTransferFunction_GetTable_40(HandleRef pThis, double x1, double x2, int n);

		public IntPtr GetTable(double x1, double x2, int n)
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_GetTable_40(base.GetCppThis(), x1, x2, n);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkColorTransferFunction_HSVWrapOff_41(HandleRef pThis);

		public virtual void HSVWrapOff()
		{
			vtkColorTransferFunction.vtkColorTransferFunction_HSVWrapOff_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkColorTransferFunction_HSVWrapOn_42(HandleRef pThis);

		public virtual void HSVWrapOn()
		{
			vtkColorTransferFunction.vtkColorTransferFunction_HSVWrapOn_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkColorTransferFunction_IsA_43(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_IsA_43(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkColorTransferFunction_IsTypeOf_44(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_IsTypeOf_44(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkColorTransferFunction_MapScalarsThroughTable2_45(HandleRef pThis, IntPtr input, IntPtr output, int inputDataType, int numberOfValues, int inputIncrement, int outputIncrement);

		public override void MapScalarsThroughTable2(IntPtr input, IntPtr output, int inputDataType, int numberOfValues, int inputIncrement, int outputIncrement)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_MapScalarsThroughTable2_45(base.GetCppThis(), input, output, inputDataType, numberOfValues, inputIncrement, outputIncrement);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkColorTransferFunction_MapValue_46(HandleRef pThis, double v);

		public override IntPtr MapValue(double v)
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_MapValue_46(base.GetCppThis(), v);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkColorTransferFunction_NewInstance_48(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkColorTransferFunction NewInstance()
		{
			vtkColorTransferFunction result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkColorTransferFunction.vtkColorTransferFunction_NewInstance_48(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkColorTransferFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkColorTransferFunction_RemoveAllPoints_49(HandleRef pThis);

		public void RemoveAllPoints()
		{
			vtkColorTransferFunction.vtkColorTransferFunction_RemoveAllPoints_49(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkColorTransferFunction_RemovePoint_50(HandleRef pThis, double x);

		public int RemovePoint(double x)
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_RemovePoint_50(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkColorTransferFunction_SafeDownCast_51(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkColorTransferFunction SafeDownCast(vtkObjectBase o)
		{
			vtkColorTransferFunction vtkColorTransferFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkColorTransferFunction.vtkColorTransferFunction_SafeDownCast_51((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkColorTransferFunction = (vtkColorTransferFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkColorTransferFunction.Register(null);
				}
			}
			return vtkColorTransferFunction;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkColorTransferFunction_SetAllowDuplicateScalars_52(HandleRef pThis, int _arg);

		public virtual void SetAllowDuplicateScalars(int _arg)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_SetAllowDuplicateScalars_52(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkColorTransferFunction_SetClamping_53(HandleRef pThis, int _arg);

		public virtual void SetClamping(int _arg)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_SetClamping_53(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkColorTransferFunction_SetColorSpace_54(HandleRef pThis, int _arg);

		public virtual void SetColorSpace(int _arg)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_SetColorSpace_54(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkColorTransferFunction_SetColorSpaceToDiverging_55(HandleRef pThis);

		public void SetColorSpaceToDiverging()
		{
			vtkColorTransferFunction.vtkColorTransferFunction_SetColorSpaceToDiverging_55(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkColorTransferFunction_SetColorSpaceToHSV_56(HandleRef pThis);

		public void SetColorSpaceToHSV()
		{
			vtkColorTransferFunction.vtkColorTransferFunction_SetColorSpaceToHSV_56(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkColorTransferFunction_SetColorSpaceToLab_57(HandleRef pThis);

		public void SetColorSpaceToLab()
		{
			vtkColorTransferFunction.vtkColorTransferFunction_SetColorSpaceToLab_57(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkColorTransferFunction_SetColorSpaceToRGB_58(HandleRef pThis);

		public void SetColorSpaceToRGB()
		{
			vtkColorTransferFunction.vtkColorTransferFunction_SetColorSpaceToRGB_58(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkColorTransferFunction_SetHSVWrap_59(HandleRef pThis, int _arg);

		public virtual void SetHSVWrap(int _arg)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_SetHSVWrap_59(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkColorTransferFunction_SetNanColor_60(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetNanColor(double _arg1, double _arg2, double _arg3)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_SetNanColor_60(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkColorTransferFunction_SetNanColor_61(HandleRef pThis, IntPtr _arg);

		public virtual void SetNanColor(IntPtr _arg)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_SetNanColor_61(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkColorTransferFunction_SetNodeValue_62(HandleRef pThis, int index, IntPtr val);

		public int SetNodeValue(int index, IntPtr val)
		{
			return vtkColorTransferFunction.vtkColorTransferFunction_SetNodeValue_62(base.GetCppThis(), index, val);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkColorTransferFunction_SetScale_63(HandleRef pThis, int _arg);

		public virtual void SetScale(int _arg)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_SetScale_63(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkColorTransferFunction_SetScaleToLinear_64(HandleRef pThis);

		public void SetScaleToLinear()
		{
			vtkColorTransferFunction.vtkColorTransferFunction_SetScaleToLinear_64(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkColorTransferFunction_SetScaleToLog10_65(HandleRef pThis);

		public void SetScaleToLog10()
		{
			vtkColorTransferFunction.vtkColorTransferFunction_SetScaleToLog10_65(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkColorTransferFunction_ShallowCopy_66(HandleRef pThis, HandleRef f);

		public void ShallowCopy(vtkColorTransferFunction f)
		{
			vtkColorTransferFunction.vtkColorTransferFunction_ShallowCopy_66(base.GetCppThis(), (f == null) ? default(HandleRef) : f.GetCppThis());
		}
	}
}
