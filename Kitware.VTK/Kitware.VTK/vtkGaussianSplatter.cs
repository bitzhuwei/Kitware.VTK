using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGaussianSplatter : vtkImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGaussianSplatter";

		public new static readonly string MRClassNameKey;

		static vtkGaussianSplatter()
		{
			vtkGaussianSplatter.MRClassNameKey = "class vtkGaussianSplatter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGaussianSplatter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGaussianSplatter"));
		}

		public vtkGaussianSplatter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkGaussianSplatter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGaussianSplatter New()
		{
			vtkGaussianSplatter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGaussianSplatter.vtkGaussianSplatter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGaussianSplatter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGaussianSplatter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGaussianSplatter.vtkGaussianSplatter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkGaussianSplatter_CappingOff_01(HandleRef pThis);

		public virtual void CappingOff()
		{
			vtkGaussianSplatter.vtkGaussianSplatter_CappingOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkGaussianSplatter_CappingOn_02(HandleRef pThis);

		public virtual void CappingOn()
		{
			vtkGaussianSplatter.vtkGaussianSplatter_CappingOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkGaussianSplatter_ComputeModelBounds_03(HandleRef pThis, HandleRef input, HandleRef output, HandleRef outInfo);

		public void ComputeModelBounds(vtkDataSet input, vtkImageData output, vtkInformation outInfo)
		{
			vtkGaussianSplatter.vtkGaussianSplatter_ComputeModelBounds_03(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis(), (outInfo == null) ? default(HandleRef) : outInfo.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkGaussianSplatter_GetAccumulationMode_04(HandleRef pThis);

		public virtual int GetAccumulationMode()
		{
			return vtkGaussianSplatter.vtkGaussianSplatter_GetAccumulationMode_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkGaussianSplatter_GetAccumulationModeAsString_05(HandleRef pThis);

		public string GetAccumulationModeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkGaussianSplatter.vtkGaussianSplatter_GetAccumulationModeAsString_05(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkGaussianSplatter_GetAccumulationModeMaxValue_06(HandleRef pThis);

		public virtual int GetAccumulationModeMaxValue()
		{
			return vtkGaussianSplatter.vtkGaussianSplatter_GetAccumulationModeMaxValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkGaussianSplatter_GetAccumulationModeMinValue_07(HandleRef pThis);

		public virtual int GetAccumulationModeMinValue()
		{
			return vtkGaussianSplatter.vtkGaussianSplatter_GetAccumulationModeMinValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkGaussianSplatter_GetCapValue_08(HandleRef pThis);

		public virtual double GetCapValue()
		{
			return vtkGaussianSplatter.vtkGaussianSplatter_GetCapValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkGaussianSplatter_GetCapping_09(HandleRef pThis);

		public virtual int GetCapping()
		{
			return vtkGaussianSplatter.vtkGaussianSplatter_GetCapping_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkGaussianSplatter_GetEccentricity_10(HandleRef pThis);

		public virtual double GetEccentricity()
		{
			return vtkGaussianSplatter.vtkGaussianSplatter_GetEccentricity_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkGaussianSplatter_GetEccentricityMaxValue_11(HandleRef pThis);

		public virtual double GetEccentricityMaxValue()
		{
			return vtkGaussianSplatter.vtkGaussianSplatter_GetEccentricityMaxValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkGaussianSplatter_GetEccentricityMinValue_12(HandleRef pThis);

		public virtual double GetEccentricityMinValue()
		{
			return vtkGaussianSplatter.vtkGaussianSplatter_GetEccentricityMinValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkGaussianSplatter_GetExponentFactor_13(HandleRef pThis);

		public virtual double GetExponentFactor()
		{
			return vtkGaussianSplatter.vtkGaussianSplatter_GetExponentFactor_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkGaussianSplatter_GetModelBounds_14(HandleRef pThis);

		public virtual double[] GetModelBounds()
		{
			IntPtr intPtr = vtkGaussianSplatter.vtkGaussianSplatter_GetModelBounds_14(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkGaussianSplatter_GetModelBounds_15(HandleRef pThis, IntPtr data);

		public virtual void GetModelBounds(IntPtr data)
		{
			vtkGaussianSplatter.vtkGaussianSplatter_GetModelBounds_15(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkGaussianSplatter_GetNormalWarping_16(HandleRef pThis);

		public virtual int GetNormalWarping()
		{
			return vtkGaussianSplatter.vtkGaussianSplatter_GetNormalWarping_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkGaussianSplatter_GetNullValue_17(HandleRef pThis);

		public virtual double GetNullValue()
		{
			return vtkGaussianSplatter.vtkGaussianSplatter_GetNullValue_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkGaussianSplatter_GetRadius_18(HandleRef pThis);

		public virtual double GetRadius()
		{
			return vtkGaussianSplatter.vtkGaussianSplatter_GetRadius_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkGaussianSplatter_GetRadiusMaxValue_19(HandleRef pThis);

		public virtual double GetRadiusMaxValue()
		{
			return vtkGaussianSplatter.vtkGaussianSplatter_GetRadiusMaxValue_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkGaussianSplatter_GetRadiusMinValue_20(HandleRef pThis);

		public virtual double GetRadiusMinValue()
		{
			return vtkGaussianSplatter.vtkGaussianSplatter_GetRadiusMinValue_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkGaussianSplatter_GetSampleDimensions_21(HandleRef pThis);

		public virtual int[] GetSampleDimensions()
		{
			IntPtr intPtr = vtkGaussianSplatter.vtkGaussianSplatter_GetSampleDimensions_21(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkGaussianSplatter_GetSampleDimensions_22(HandleRef pThis, IntPtr data);

		public virtual void GetSampleDimensions(IntPtr data)
		{
			vtkGaussianSplatter.vtkGaussianSplatter_GetSampleDimensions_22(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkGaussianSplatter_GetScalarWarping_23(HandleRef pThis);

		public virtual int GetScalarWarping()
		{
			return vtkGaussianSplatter.vtkGaussianSplatter_GetScalarWarping_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkGaussianSplatter_GetScaleFactor_24(HandleRef pThis);

		public virtual double GetScaleFactor()
		{
			return vtkGaussianSplatter.vtkGaussianSplatter_GetScaleFactor_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkGaussianSplatter_GetScaleFactorMaxValue_25(HandleRef pThis);

		public virtual double GetScaleFactorMaxValue()
		{
			return vtkGaussianSplatter.vtkGaussianSplatter_GetScaleFactorMaxValue_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkGaussianSplatter_GetScaleFactorMinValue_26(HandleRef pThis);

		public virtual double GetScaleFactorMinValue()
		{
			return vtkGaussianSplatter.vtkGaussianSplatter_GetScaleFactorMinValue_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkGaussianSplatter_IsA_27(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGaussianSplatter.vtkGaussianSplatter_IsA_27(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkGaussianSplatter_IsTypeOf_28(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGaussianSplatter.vtkGaussianSplatter_IsTypeOf_28(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkGaussianSplatter_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGaussianSplatter NewInstance()
		{
			vtkGaussianSplatter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGaussianSplatter.vtkGaussianSplatter_NewInstance_30(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGaussianSplatter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkGaussianSplatter_NormalWarpingOff_31(HandleRef pThis);

		public virtual void NormalWarpingOff()
		{
			vtkGaussianSplatter.vtkGaussianSplatter_NormalWarpingOff_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkGaussianSplatter_NormalWarpingOn_32(HandleRef pThis);

		public virtual void NormalWarpingOn()
		{
			vtkGaussianSplatter.vtkGaussianSplatter_NormalWarpingOn_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkGaussianSplatter_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGaussianSplatter SafeDownCast(vtkObjectBase o)
		{
			vtkGaussianSplatter vtkGaussianSplatter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGaussianSplatter.vtkGaussianSplatter_SafeDownCast_33((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGaussianSplatter = (vtkGaussianSplatter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGaussianSplatter.Register(null);
				}
			}
			return vtkGaussianSplatter;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkGaussianSplatter_ScalarWarpingOff_34(HandleRef pThis);

		public virtual void ScalarWarpingOff()
		{
			vtkGaussianSplatter.vtkGaussianSplatter_ScalarWarpingOff_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkGaussianSplatter_ScalarWarpingOn_35(HandleRef pThis);

		public virtual void ScalarWarpingOn()
		{
			vtkGaussianSplatter.vtkGaussianSplatter_ScalarWarpingOn_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkGaussianSplatter_SetAccumulationMode_36(HandleRef pThis, int _arg);

		public virtual void SetAccumulationMode(int _arg)
		{
			vtkGaussianSplatter.vtkGaussianSplatter_SetAccumulationMode_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkGaussianSplatter_SetAccumulationModeToMax_37(HandleRef pThis);

		public void SetAccumulationModeToMax()
		{
			vtkGaussianSplatter.vtkGaussianSplatter_SetAccumulationModeToMax_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkGaussianSplatter_SetAccumulationModeToMin_38(HandleRef pThis);

		public void SetAccumulationModeToMin()
		{
			vtkGaussianSplatter.vtkGaussianSplatter_SetAccumulationModeToMin_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkGaussianSplatter_SetAccumulationModeToSum_39(HandleRef pThis);

		public void SetAccumulationModeToSum()
		{
			vtkGaussianSplatter.vtkGaussianSplatter_SetAccumulationModeToSum_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkGaussianSplatter_SetCapValue_40(HandleRef pThis, double _arg);

		public virtual void SetCapValue(double _arg)
		{
			vtkGaussianSplatter.vtkGaussianSplatter_SetCapValue_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkGaussianSplatter_SetCapping_41(HandleRef pThis, int _arg);

		public virtual void SetCapping(int _arg)
		{
			vtkGaussianSplatter.vtkGaussianSplatter_SetCapping_41(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkGaussianSplatter_SetEccentricity_42(HandleRef pThis, double _arg);

		public virtual void SetEccentricity(double _arg)
		{
			vtkGaussianSplatter.vtkGaussianSplatter_SetEccentricity_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkGaussianSplatter_SetExponentFactor_43(HandleRef pThis, double _arg);

		public virtual void SetExponentFactor(double _arg)
		{
			vtkGaussianSplatter.vtkGaussianSplatter_SetExponentFactor_43(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkGaussianSplatter_SetModelBounds_44(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		public virtual void SetModelBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkGaussianSplatter.vtkGaussianSplatter_SetModelBounds_44(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkGaussianSplatter_SetModelBounds_45(HandleRef pThis, IntPtr _arg);

		public virtual void SetModelBounds(IntPtr _arg)
		{
			vtkGaussianSplatter.vtkGaussianSplatter_SetModelBounds_45(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkGaussianSplatter_SetNormalWarping_46(HandleRef pThis, int _arg);

		public virtual void SetNormalWarping(int _arg)
		{
			vtkGaussianSplatter.vtkGaussianSplatter_SetNormalWarping_46(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkGaussianSplatter_SetNullValue_47(HandleRef pThis, double _arg);

		public virtual void SetNullValue(double _arg)
		{
			vtkGaussianSplatter.vtkGaussianSplatter_SetNullValue_47(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkGaussianSplatter_SetRadius_48(HandleRef pThis, double _arg);

		public virtual void SetRadius(double _arg)
		{
			vtkGaussianSplatter.vtkGaussianSplatter_SetRadius_48(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkGaussianSplatter_SetSampleDimensions_49(HandleRef pThis, int i, int j, int k);

		public void SetSampleDimensions(int i, int j, int k)
		{
			vtkGaussianSplatter.vtkGaussianSplatter_SetSampleDimensions_49(base.GetCppThis(), i, j, k);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkGaussianSplatter_SetSampleDimensions_50(HandleRef pThis, IntPtr dim);

		public void SetSampleDimensions(IntPtr dim)
		{
			vtkGaussianSplatter.vtkGaussianSplatter_SetSampleDimensions_50(base.GetCppThis(), dim);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkGaussianSplatter_SetScalarWarping_51(HandleRef pThis, int _arg);

		public virtual void SetScalarWarping(int _arg)
		{
			vtkGaussianSplatter.vtkGaussianSplatter_SetScalarWarping_51(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkGaussianSplatter_SetScaleFactor_52(HandleRef pThis, double _arg);

		public virtual void SetScaleFactor(double _arg)
		{
			vtkGaussianSplatter.vtkGaussianSplatter_SetScaleFactor_52(base.GetCppThis(), _arg);
		}
	}
}
