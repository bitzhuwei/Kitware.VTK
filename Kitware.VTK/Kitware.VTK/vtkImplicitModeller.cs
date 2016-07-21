using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImplicitModeller : vtkImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitModeller";

		public new static readonly string MRClassNameKey;

		static vtkImplicitModeller()
		{
			vtkImplicitModeller.MRClassNameKey = "class vtkImplicitModeller";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImplicitModeller.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitModeller"));
		}

		public vtkImplicitModeller(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitModeller_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImplicitModeller New()
		{
			vtkImplicitModeller result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitModeller.vtkImplicitModeller_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitModeller)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImplicitModeller() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImplicitModeller.vtkImplicitModeller_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImplicitModeller_AdjustBoundsOff_01(HandleRef pThis);

		public virtual void AdjustBoundsOff()
		{
			vtkImplicitModeller.vtkImplicitModeller_AdjustBoundsOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImplicitModeller_AdjustBoundsOn_02(HandleRef pThis);

		public virtual void AdjustBoundsOn()
		{
			vtkImplicitModeller.vtkImplicitModeller_AdjustBoundsOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImplicitModeller_Append_03(HandleRef pThis, HandleRef input);

		public void Append(vtkDataSet input)
		{
			vtkImplicitModeller.vtkImplicitModeller_Append_03(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImplicitModeller_CappingOff_04(HandleRef pThis);

		public virtual void CappingOff()
		{
			vtkImplicitModeller.vtkImplicitModeller_CappingOff_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImplicitModeller_CappingOn_05(HandleRef pThis);

		public virtual void CappingOn()
		{
			vtkImplicitModeller.vtkImplicitModeller_CappingOn_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkImplicitModeller_ComputeModelBounds_06(HandleRef pThis, HandleRef input);

		public double ComputeModelBounds(vtkDataSet input)
		{
			return vtkImplicitModeller.vtkImplicitModeller_ComputeModelBounds_06(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImplicitModeller_EndAppend_07(HandleRef pThis);

		public void EndAppend()
		{
			vtkImplicitModeller.vtkImplicitModeller_EndAppend_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkImplicitModeller_GetAdjustBounds_08(HandleRef pThis);

		public virtual int GetAdjustBounds()
		{
			return vtkImplicitModeller.vtkImplicitModeller_GetAdjustBounds_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkImplicitModeller_GetAdjustDistance_09(HandleRef pThis);

		public virtual double GetAdjustDistance()
		{
			return vtkImplicitModeller.vtkImplicitModeller_GetAdjustDistance_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkImplicitModeller_GetAdjustDistanceMaxValue_10(HandleRef pThis);

		public virtual double GetAdjustDistanceMaxValue()
		{
			return vtkImplicitModeller.vtkImplicitModeller_GetAdjustDistanceMaxValue_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkImplicitModeller_GetAdjustDistanceMinValue_11(HandleRef pThis);

		public virtual double GetAdjustDistanceMinValue()
		{
			return vtkImplicitModeller.vtkImplicitModeller_GetAdjustDistanceMinValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkImplicitModeller_GetCapValue_12(HandleRef pThis);

		public virtual double GetCapValue()
		{
			return vtkImplicitModeller.vtkImplicitModeller_GetCapValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkImplicitModeller_GetCapping_13(HandleRef pThis);

		public virtual int GetCapping()
		{
			return vtkImplicitModeller.vtkImplicitModeller_GetCapping_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkImplicitModeller_GetLocatorMaxLevel_14(HandleRef pThis);

		public virtual int GetLocatorMaxLevel()
		{
			return vtkImplicitModeller.vtkImplicitModeller_GetLocatorMaxLevel_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkImplicitModeller_GetMaximumDistance_15(HandleRef pThis);

		public virtual double GetMaximumDistance()
		{
			return vtkImplicitModeller.vtkImplicitModeller_GetMaximumDistance_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkImplicitModeller_GetMaximumDistanceMaxValue_16(HandleRef pThis);

		public virtual double GetMaximumDistanceMaxValue()
		{
			return vtkImplicitModeller.vtkImplicitModeller_GetMaximumDistanceMaxValue_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkImplicitModeller_GetMaximumDistanceMinValue_17(HandleRef pThis);

		public virtual double GetMaximumDistanceMinValue()
		{
			return vtkImplicitModeller.vtkImplicitModeller_GetMaximumDistanceMinValue_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitModeller_GetModelBounds_18(HandleRef pThis);

		public virtual double[] GetModelBounds()
		{
			IntPtr intPtr = vtkImplicitModeller.vtkImplicitModeller_GetModelBounds_18(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImplicitModeller_GetModelBounds_19(HandleRef pThis, IntPtr data);

		public virtual void GetModelBounds(IntPtr data)
		{
			vtkImplicitModeller.vtkImplicitModeller_GetModelBounds_19(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkImplicitModeller_GetNumberOfThreads_20(HandleRef pThis);

		public virtual int GetNumberOfThreads()
		{
			return vtkImplicitModeller.vtkImplicitModeller_GetNumberOfThreads_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkImplicitModeller_GetNumberOfThreadsMaxValue_21(HandleRef pThis);

		public virtual int GetNumberOfThreadsMaxValue()
		{
			return vtkImplicitModeller.vtkImplicitModeller_GetNumberOfThreadsMaxValue_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkImplicitModeller_GetNumberOfThreadsMinValue_22(HandleRef pThis);

		public virtual int GetNumberOfThreadsMinValue()
		{
			return vtkImplicitModeller.vtkImplicitModeller_GetNumberOfThreadsMinValue_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkImplicitModeller_GetOutputScalarType_23(HandleRef pThis);

		public virtual int GetOutputScalarType()
		{
			return vtkImplicitModeller.vtkImplicitModeller_GetOutputScalarType_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkImplicitModeller_GetProcessMode_24(HandleRef pThis);

		public virtual int GetProcessMode()
		{
			return vtkImplicitModeller.vtkImplicitModeller_GetProcessMode_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitModeller_GetProcessModeAsString_25(HandleRef pThis);

		public string GetProcessModeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkImplicitModeller.vtkImplicitModeller_GetProcessModeAsString_25(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkImplicitModeller_GetProcessModeMaxValue_26(HandleRef pThis);

		public virtual int GetProcessModeMaxValue()
		{
			return vtkImplicitModeller.vtkImplicitModeller_GetProcessModeMaxValue_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkImplicitModeller_GetProcessModeMinValue_27(HandleRef pThis);

		public virtual int GetProcessModeMinValue()
		{
			return vtkImplicitModeller.vtkImplicitModeller_GetProcessModeMinValue_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitModeller_GetSampleDimensions_28(HandleRef pThis);

		public virtual int[] GetSampleDimensions()
		{
			IntPtr intPtr = vtkImplicitModeller.vtkImplicitModeller_GetSampleDimensions_28(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImplicitModeller_GetSampleDimensions_29(HandleRef pThis, IntPtr data);

		public virtual void GetSampleDimensions(IntPtr data)
		{
			vtkImplicitModeller.vtkImplicitModeller_GetSampleDimensions_29(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkImplicitModeller_GetScaleToMaximumDistance_30(HandleRef pThis);

		public virtual int GetScaleToMaximumDistance()
		{
			return vtkImplicitModeller.vtkImplicitModeller_GetScaleToMaximumDistance_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkImplicitModeller_IsA_31(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImplicitModeller.vtkImplicitModeller_IsA_31(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkImplicitModeller_IsTypeOf_32(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImplicitModeller.vtkImplicitModeller_IsTypeOf_32(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitModeller_NewInstance_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImplicitModeller NewInstance()
		{
			vtkImplicitModeller result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitModeller.vtkImplicitModeller_NewInstance_34(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitModeller)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitModeller_SafeDownCast_35(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImplicitModeller SafeDownCast(vtkObjectBase o)
		{
			vtkImplicitModeller vtkImplicitModeller = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitModeller.vtkImplicitModeller_SafeDownCast_35((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitModeller = (vtkImplicitModeller)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitModeller.Register(null);
				}
			}
			return vtkImplicitModeller;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImplicitModeller_ScaleToMaximumDistanceOff_36(HandleRef pThis);

		public virtual void ScaleToMaximumDistanceOff()
		{
			vtkImplicitModeller.vtkImplicitModeller_ScaleToMaximumDistanceOff_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImplicitModeller_ScaleToMaximumDistanceOn_37(HandleRef pThis);

		public virtual void ScaleToMaximumDistanceOn()
		{
			vtkImplicitModeller.vtkImplicitModeller_ScaleToMaximumDistanceOn_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImplicitModeller_SetAdjustBounds_38(HandleRef pThis, int _arg);

		public virtual void SetAdjustBounds(int _arg)
		{
			vtkImplicitModeller.vtkImplicitModeller_SetAdjustBounds_38(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImplicitModeller_SetAdjustDistance_39(HandleRef pThis, double _arg);

		public virtual void SetAdjustDistance(double _arg)
		{
			vtkImplicitModeller.vtkImplicitModeller_SetAdjustDistance_39(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImplicitModeller_SetCapValue_40(HandleRef pThis, double value);

		public void SetCapValue(double value)
		{
			vtkImplicitModeller.vtkImplicitModeller_SetCapValue_40(base.GetCppThis(), value);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImplicitModeller_SetCapping_41(HandleRef pThis, int _arg);

		public virtual void SetCapping(int _arg)
		{
			vtkImplicitModeller.vtkImplicitModeller_SetCapping_41(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImplicitModeller_SetLocatorMaxLevel_42(HandleRef pThis, int _arg);

		public virtual void SetLocatorMaxLevel(int _arg)
		{
			vtkImplicitModeller.vtkImplicitModeller_SetLocatorMaxLevel_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImplicitModeller_SetMaximumDistance_43(HandleRef pThis, double _arg);

		public virtual void SetMaximumDistance(double _arg)
		{
			vtkImplicitModeller.vtkImplicitModeller_SetMaximumDistance_43(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImplicitModeller_SetModelBounds_44(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		public virtual void SetModelBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkImplicitModeller.vtkImplicitModeller_SetModelBounds_44(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImplicitModeller_SetModelBounds_45(HandleRef pThis, IntPtr _arg);

		public virtual void SetModelBounds(IntPtr _arg)
		{
			vtkImplicitModeller.vtkImplicitModeller_SetModelBounds_45(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImplicitModeller_SetNumberOfThreads_46(HandleRef pThis, int _arg);

		public virtual void SetNumberOfThreads(int _arg)
		{
			vtkImplicitModeller.vtkImplicitModeller_SetNumberOfThreads_46(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImplicitModeller_SetOutputScalarType_47(HandleRef pThis, int type);

		public void SetOutputScalarType(int type)
		{
			vtkImplicitModeller.vtkImplicitModeller_SetOutputScalarType_47(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImplicitModeller_SetOutputScalarTypeToChar_48(HandleRef pThis);

		public void SetOutputScalarTypeToChar()
		{
			vtkImplicitModeller.vtkImplicitModeller_SetOutputScalarTypeToChar_48(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImplicitModeller_SetOutputScalarTypeToDouble_49(HandleRef pThis);

		public void SetOutputScalarTypeToDouble()
		{
			vtkImplicitModeller.vtkImplicitModeller_SetOutputScalarTypeToDouble_49(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImplicitModeller_SetOutputScalarTypeToFloat_50(HandleRef pThis);

		public void SetOutputScalarTypeToFloat()
		{
			vtkImplicitModeller.vtkImplicitModeller_SetOutputScalarTypeToFloat_50(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImplicitModeller_SetOutputScalarTypeToInt_51(HandleRef pThis);

		public void SetOutputScalarTypeToInt()
		{
			vtkImplicitModeller.vtkImplicitModeller_SetOutputScalarTypeToInt_51(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImplicitModeller_SetOutputScalarTypeToLong_52(HandleRef pThis);

		public void SetOutputScalarTypeToLong()
		{
			vtkImplicitModeller.vtkImplicitModeller_SetOutputScalarTypeToLong_52(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImplicitModeller_SetOutputScalarTypeToShort_53(HandleRef pThis);

		public void SetOutputScalarTypeToShort()
		{
			vtkImplicitModeller.vtkImplicitModeller_SetOutputScalarTypeToShort_53(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImplicitModeller_SetOutputScalarTypeToUnsignedChar_54(HandleRef pThis);

		public void SetOutputScalarTypeToUnsignedChar()
		{
			vtkImplicitModeller.vtkImplicitModeller_SetOutputScalarTypeToUnsignedChar_54(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImplicitModeller_SetOutputScalarTypeToUnsignedInt_55(HandleRef pThis);

		public void SetOutputScalarTypeToUnsignedInt()
		{
			vtkImplicitModeller.vtkImplicitModeller_SetOutputScalarTypeToUnsignedInt_55(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImplicitModeller_SetOutputScalarTypeToUnsignedLong_56(HandleRef pThis);

		public void SetOutputScalarTypeToUnsignedLong()
		{
			vtkImplicitModeller.vtkImplicitModeller_SetOutputScalarTypeToUnsignedLong_56(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImplicitModeller_SetOutputScalarTypeToUnsignedShort_57(HandleRef pThis);

		public void SetOutputScalarTypeToUnsignedShort()
		{
			vtkImplicitModeller.vtkImplicitModeller_SetOutputScalarTypeToUnsignedShort_57(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImplicitModeller_SetProcessMode_58(HandleRef pThis, int _arg);

		public virtual void SetProcessMode(int _arg)
		{
			vtkImplicitModeller.vtkImplicitModeller_SetProcessMode_58(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImplicitModeller_SetProcessModeToPerCell_59(HandleRef pThis);

		public void SetProcessModeToPerCell()
		{
			vtkImplicitModeller.vtkImplicitModeller_SetProcessModeToPerCell_59(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImplicitModeller_SetProcessModeToPerVoxel_60(HandleRef pThis);

		public void SetProcessModeToPerVoxel()
		{
			vtkImplicitModeller.vtkImplicitModeller_SetProcessModeToPerVoxel_60(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImplicitModeller_SetSampleDimensions_61(HandleRef pThis, int i, int j, int k);

		public void SetSampleDimensions(int i, int j, int k)
		{
			vtkImplicitModeller.vtkImplicitModeller_SetSampleDimensions_61(base.GetCppThis(), i, j, k);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImplicitModeller_SetSampleDimensions_62(HandleRef pThis, IntPtr dim);

		public void SetSampleDimensions(IntPtr dim)
		{
			vtkImplicitModeller.vtkImplicitModeller_SetSampleDimensions_62(base.GetCppThis(), dim);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImplicitModeller_SetScaleToMaximumDistance_63(HandleRef pThis, int _arg);

		public virtual void SetScaleToMaximumDistance(int _arg)
		{
			vtkImplicitModeller.vtkImplicitModeller_SetScaleToMaximumDistance_63(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImplicitModeller_StartAppend_64(HandleRef pThis);

		public void StartAppend()
		{
			vtkImplicitModeller.vtkImplicitModeller_StartAppend_64(base.GetCppThis());
		}
	}
}
