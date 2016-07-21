using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkLookupTable : vtkScalarsToColors
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkLookupTable";

		public new static readonly string MRClassNameKey;

		static vtkLookupTable()
		{
			vtkLookupTable.MRClassNameKey = "class vtkLookupTable";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLookupTable.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLookupTable"));
		}

		public vtkLookupTable(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkLookupTable_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLookupTable New()
		{
			vtkLookupTable result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLookupTable.vtkLookupTable_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLookupTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkLookupTable() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkLookupTable.vtkLookupTable_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkLookupTable_Allocate_01(HandleRef pThis, int sz, int ext);

		public int Allocate(int sz, int ext)
		{
			return vtkLookupTable.vtkLookupTable_Allocate_01(base.GetCppThis(), sz, ext);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkLookupTable_ApplyLogScale_02(double v, IntPtr range, IntPtr log_range);

		public static double ApplyLogScale(double v, IntPtr range, IntPtr log_range)
		{
			return vtkLookupTable.vtkLookupTable_ApplyLogScale_02(v, range, log_range);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLookupTable_Build_03(HandleRef pThis);

		public override void Build()
		{
			vtkLookupTable.vtkLookupTable_Build_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLookupTable_DeepCopy_04(HandleRef pThis, HandleRef lut);

		public void DeepCopy(vtkLookupTable lut)
		{
			vtkLookupTable.vtkLookupTable_DeepCopy_04(base.GetCppThis(), (lut == null) ? default(HandleRef) : lut.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLookupTable_ForceBuild_05(HandleRef pThis);

		public virtual void ForceBuild()
		{
			vtkLookupTable.vtkLookupTable_ForceBuild_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkLookupTable_GetAlphaRange_06(HandleRef pThis);

		public virtual double[] GetAlphaRange()
		{
			IntPtr intPtr = vtkLookupTable.vtkLookupTable_GetAlphaRange_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLookupTable_GetAlphaRange_07(HandleRef pThis, ref double _arg1, ref double _arg2);

		public virtual void GetAlphaRange(ref double _arg1, ref double _arg2)
		{
			vtkLookupTable.vtkLookupTable_GetAlphaRange_07(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLookupTable_GetAlphaRange_08(HandleRef pThis, IntPtr _arg);

		public virtual void GetAlphaRange(IntPtr _arg)
		{
			vtkLookupTable.vtkLookupTable_GetAlphaRange_08(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLookupTable_GetColor_09(HandleRef pThis, double x, IntPtr rgb);

		public override void GetColor(double x, IntPtr rgb)
		{
			vtkLookupTable.vtkLookupTable_GetColor_09(base.GetCppThis(), x, rgb);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkLookupTable_GetHueRange_10(HandleRef pThis);

		public virtual double[] GetHueRange()
		{
			IntPtr intPtr = vtkLookupTable.vtkLookupTable_GetHueRange_10(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLookupTable_GetHueRange_11(HandleRef pThis, ref double _arg1, ref double _arg2);

		public virtual void GetHueRange(ref double _arg1, ref double _arg2)
		{
			vtkLookupTable.vtkLookupTable_GetHueRange_11(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLookupTable_GetHueRange_12(HandleRef pThis, IntPtr _arg);

		public virtual void GetHueRange(IntPtr _arg)
		{
			vtkLookupTable.vtkLookupTable_GetHueRange_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkLookupTable_GetIndex_13(HandleRef pThis, double v);

		public virtual long GetIndex(double v)
		{
			return vtkLookupTable.vtkLookupTable_GetIndex_13(base.GetCppThis(), v);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLookupTable_GetLogRange_14(IntPtr range, IntPtr log_range);

		public static void GetLogRange(IntPtr range, IntPtr log_range)
		{
			vtkLookupTable.vtkLookupTable_GetLogRange_14(range, log_range);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkLookupTable_GetNanColor_15(HandleRef pThis);

		public virtual double[] GetNanColor()
		{
			IntPtr intPtr = vtkLookupTable.vtkLookupTable_GetNanColor_15(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLookupTable_GetNanColor_16(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

		public virtual void GetNanColor(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
		{
			vtkLookupTable.vtkLookupTable_GetNanColor_16(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLookupTable_GetNanColor_17(HandleRef pThis, IntPtr _arg);

		public virtual void GetNanColor(IntPtr _arg)
		{
			vtkLookupTable.vtkLookupTable_GetNanColor_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkLookupTable_GetNumberOfAvailableColors_18(HandleRef pThis);

		public override long GetNumberOfAvailableColors()
		{
			return vtkLookupTable.vtkLookupTable_GetNumberOfAvailableColors_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkLookupTable_GetNumberOfColors_19(HandleRef pThis);

		public virtual long GetNumberOfColors()
		{
			return vtkLookupTable.vtkLookupTable_GetNumberOfColors_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkLookupTable_GetNumberOfColorsMaxValue_20(HandleRef pThis);

		public virtual long GetNumberOfColorsMaxValue()
		{
			return vtkLookupTable.vtkLookupTable_GetNumberOfColorsMaxValue_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkLookupTable_GetNumberOfColorsMinValue_21(HandleRef pThis);

		public virtual long GetNumberOfColorsMinValue()
		{
			return vtkLookupTable.vtkLookupTable_GetNumberOfColorsMinValue_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkLookupTable_GetNumberOfTableValues_22(HandleRef pThis);

		public long GetNumberOfTableValues()
		{
			return vtkLookupTable.vtkLookupTable_GetNumberOfTableValues_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkLookupTable_GetOpacity_23(HandleRef pThis, double v);

		public override double GetOpacity(double v)
		{
			return vtkLookupTable.vtkLookupTable_GetOpacity_23(base.GetCppThis(), v);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkLookupTable_GetPointer_24(HandleRef pThis, long id);

		public IntPtr GetPointer(long id)
		{
			return vtkLookupTable.vtkLookupTable_GetPointer_24(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkLookupTable_GetRamp_25(HandleRef pThis);

		public virtual int GetRamp()
		{
			return vtkLookupTable.vtkLookupTable_GetRamp_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkLookupTable_GetRange_26(HandleRef pThis);

		public override double[] GetRange()
		{
			IntPtr intPtr = vtkLookupTable.vtkLookupTable_GetRange_26(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkLookupTable_GetSaturationRange_27(HandleRef pThis);

		public virtual double[] GetSaturationRange()
		{
			IntPtr intPtr = vtkLookupTable.vtkLookupTable_GetSaturationRange_27(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLookupTable_GetSaturationRange_28(HandleRef pThis, ref double _arg1, ref double _arg2);

		public virtual void GetSaturationRange(ref double _arg1, ref double _arg2)
		{
			vtkLookupTable.vtkLookupTable_GetSaturationRange_28(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLookupTable_GetSaturationRange_29(HandleRef pThis, IntPtr _arg);

		public virtual void GetSaturationRange(IntPtr _arg)
		{
			vtkLookupTable.vtkLookupTable_GetSaturationRange_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkLookupTable_GetScale_30(HandleRef pThis);

		public virtual int GetScale()
		{
			return vtkLookupTable.vtkLookupTable_GetScale_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkLookupTable_GetTable_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkUnsignedCharArray GetTable()
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLookupTable.vtkLookupTable_GetTable_31(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedCharArray = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedCharArray.Register(null);
				}
			}
			return vtkUnsignedCharArray;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkLookupTable_GetTableRange_32(HandleRef pThis);

		public virtual double[] GetTableRange()
		{
			IntPtr intPtr = vtkLookupTable.vtkLookupTable_GetTableRange_32(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLookupTable_GetTableRange_33(HandleRef pThis, IntPtr data);

		public virtual void GetTableRange(IntPtr data)
		{
			vtkLookupTable.vtkLookupTable_GetTableRange_33(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkLookupTable_GetTableValue_34(HandleRef pThis, long id);

		public double[] GetTableValue(long id)
		{
			IntPtr intPtr = vtkLookupTable.vtkLookupTable_GetTableValue_34(base.GetCppThis(), id);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLookupTable_GetTableValue_35(HandleRef pThis, long id, IntPtr rgba);

		public void GetTableValue(long id, IntPtr rgba)
		{
			vtkLookupTable.vtkLookupTable_GetTableValue_35(base.GetCppThis(), id, rgba);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkLookupTable_GetValueRange_36(HandleRef pThis);

		public virtual double[] GetValueRange()
		{
			IntPtr intPtr = vtkLookupTable.vtkLookupTable_GetValueRange_36(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLookupTable_GetValueRange_37(HandleRef pThis, ref double _arg1, ref double _arg2);

		public virtual void GetValueRange(ref double _arg1, ref double _arg2)
		{
			vtkLookupTable.vtkLookupTable_GetValueRange_37(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLookupTable_GetValueRange_38(HandleRef pThis, IntPtr _arg);

		public virtual void GetValueRange(IntPtr _arg)
		{
			vtkLookupTable.vtkLookupTable_GetValueRange_38(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkLookupTable_IsA_39(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkLookupTable.vtkLookupTable_IsA_39(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkLookupTable_IsOpaque_40(HandleRef pThis);

		public override int IsOpaque()
		{
			return vtkLookupTable.vtkLookupTable_IsOpaque_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkLookupTable_IsTypeOf_41(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkLookupTable.vtkLookupTable_IsTypeOf_41(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLookupTable_MapScalarsThroughTable2_42(HandleRef pThis, IntPtr input, IntPtr output, int inputDataType, int numberOfValues, int inputIncrement, int outputIncrement);

		public override void MapScalarsThroughTable2(IntPtr input, IntPtr output, int inputDataType, int numberOfValues, int inputIncrement, int outputIncrement)
		{
			vtkLookupTable.vtkLookupTable_MapScalarsThroughTable2_42(base.GetCppThis(), input, output, inputDataType, numberOfValues, inputIncrement, outputIncrement);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkLookupTable_MapValue_43(HandleRef pThis, double v);

		public override IntPtr MapValue(double v)
		{
			return vtkLookupTable.vtkLookupTable_MapValue_43(base.GetCppThis(), v);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkLookupTable_NewInstance_45(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkLookupTable NewInstance()
		{
			vtkLookupTable result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLookupTable.vtkLookupTable_NewInstance_45(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLookupTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkLookupTable_SafeDownCast_46(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLookupTable SafeDownCast(vtkObjectBase o)
		{
			vtkLookupTable vtkLookupTable = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLookupTable.vtkLookupTable_SafeDownCast_46((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLookupTable = (vtkLookupTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLookupTable.Register(null);
				}
			}
			return vtkLookupTable;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLookupTable_SetAlphaRange_47(HandleRef pThis, double _arg1, double _arg2);

		public virtual void SetAlphaRange(double _arg1, double _arg2)
		{
			vtkLookupTable.vtkLookupTable_SetAlphaRange_47(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLookupTable_SetAlphaRange_48(HandleRef pThis, IntPtr _arg);

		public void SetAlphaRange(IntPtr _arg)
		{
			vtkLookupTable.vtkLookupTable_SetAlphaRange_48(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLookupTable_SetHueRange_49(HandleRef pThis, double _arg1, double _arg2);

		public virtual void SetHueRange(double _arg1, double _arg2)
		{
			vtkLookupTable.vtkLookupTable_SetHueRange_49(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLookupTable_SetHueRange_50(HandleRef pThis, IntPtr _arg);

		public void SetHueRange(IntPtr _arg)
		{
			vtkLookupTable.vtkLookupTable_SetHueRange_50(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLookupTable_SetNanColor_51(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

		public virtual void SetNanColor(double _arg1, double _arg2, double _arg3, double _arg4)
		{
			vtkLookupTable.vtkLookupTable_SetNanColor_51(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLookupTable_SetNanColor_52(HandleRef pThis, IntPtr _arg);

		public virtual void SetNanColor(IntPtr _arg)
		{
			vtkLookupTable.vtkLookupTable_SetNanColor_52(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLookupTable_SetNumberOfColors_53(HandleRef pThis, long _arg);

		public virtual void SetNumberOfColors(long _arg)
		{
			vtkLookupTable.vtkLookupTable_SetNumberOfColors_53(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLookupTable_SetNumberOfTableValues_54(HandleRef pThis, long number);

		public void SetNumberOfTableValues(long number)
		{
			vtkLookupTable.vtkLookupTable_SetNumberOfTableValues_54(base.GetCppThis(), number);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLookupTable_SetRamp_55(HandleRef pThis, int _arg);

		public virtual void SetRamp(int _arg)
		{
			vtkLookupTable.vtkLookupTable_SetRamp_55(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLookupTable_SetRampToLinear_56(HandleRef pThis);

		public void SetRampToLinear()
		{
			vtkLookupTable.vtkLookupTable_SetRampToLinear_56(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLookupTable_SetRampToSCurve_57(HandleRef pThis);

		public void SetRampToSCurve()
		{
			vtkLookupTable.vtkLookupTable_SetRampToSCurve_57(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLookupTable_SetRampToSQRT_58(HandleRef pThis);

		public void SetRampToSQRT()
		{
			vtkLookupTable.vtkLookupTable_SetRampToSQRT_58(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLookupTable_SetRange_59(HandleRef pThis, double min, double max);

		public override void SetRange(double min, double max)
		{
			vtkLookupTable.vtkLookupTable_SetRange_59(base.GetCppThis(), min, max);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLookupTable_SetRange_60(HandleRef pThis, IntPtr rng);

		public new void SetRange(IntPtr rng)
		{
			vtkLookupTable.vtkLookupTable_SetRange_60(base.GetCppThis(), rng);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLookupTable_SetSaturationRange_61(HandleRef pThis, double _arg1, double _arg2);

		public virtual void SetSaturationRange(double _arg1, double _arg2)
		{
			vtkLookupTable.vtkLookupTable_SetSaturationRange_61(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLookupTable_SetSaturationRange_62(HandleRef pThis, IntPtr _arg);

		public void SetSaturationRange(IntPtr _arg)
		{
			vtkLookupTable.vtkLookupTable_SetSaturationRange_62(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLookupTable_SetScale_63(HandleRef pThis, int scale);

		public void SetScale(int scale)
		{
			vtkLookupTable.vtkLookupTable_SetScale_63(base.GetCppThis(), scale);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLookupTable_SetScaleToLinear_64(HandleRef pThis);

		public void SetScaleToLinear()
		{
			vtkLookupTable.vtkLookupTable_SetScaleToLinear_64(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLookupTable_SetScaleToLog10_65(HandleRef pThis);

		public void SetScaleToLog10()
		{
			vtkLookupTable.vtkLookupTable_SetScaleToLog10_65(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLookupTable_SetTable_66(HandleRef pThis, HandleRef arg0);

		public void SetTable(vtkUnsignedCharArray arg0)
		{
			vtkLookupTable.vtkLookupTable_SetTable_66(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLookupTable_SetTableRange_67(HandleRef pThis, IntPtr r);

		public void SetTableRange(IntPtr r)
		{
			vtkLookupTable.vtkLookupTable_SetTableRange_67(base.GetCppThis(), r);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLookupTable_SetTableRange_68(HandleRef pThis, double min, double max);

		public virtual void SetTableRange(double min, double max)
		{
			vtkLookupTable.vtkLookupTable_SetTableRange_68(base.GetCppThis(), min, max);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLookupTable_SetTableValue_69(HandleRef pThis, long indx, IntPtr rgba);

		public void SetTableValue(long indx, IntPtr rgba)
		{
			vtkLookupTable.vtkLookupTable_SetTableValue_69(base.GetCppThis(), indx, rgba);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLookupTable_SetTableValue_70(HandleRef pThis, long indx, double r, double g, double b, double a);

		public void SetTableValue(long indx, double r, double g, double b, double a)
		{
			vtkLookupTable.vtkLookupTable_SetTableValue_70(base.GetCppThis(), indx, r, g, b, a);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLookupTable_SetValueRange_71(HandleRef pThis, double _arg1, double _arg2);

		public virtual void SetValueRange(double _arg1, double _arg2)
		{
			vtkLookupTable.vtkLookupTable_SetValueRange_71(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLookupTable_SetValueRange_72(HandleRef pThis, IntPtr _arg);

		public void SetValueRange(IntPtr _arg)
		{
			vtkLookupTable.vtkLookupTable_SetValueRange_72(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkLookupTable_UsingLogScale_73(HandleRef pThis);

		public override int UsingLogScale()
		{
			return vtkLookupTable.vtkLookupTable_UsingLogScale_73(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkLookupTable_WritePointer_74(HandleRef pThis, long id, int number);

		public IntPtr WritePointer(long id, int number)
		{
			return vtkLookupTable.vtkLookupTable_WritePointer_74(base.GetCppThis(), id, number);
		}
	}
}
