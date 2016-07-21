using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkVolumeRayCastMapper : vtkVolumeMapper
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkVolumeRayCastMapper";

		public new static readonly string MRClassNameKey;

		static vtkVolumeRayCastMapper()
		{
			vtkVolumeRayCastMapper.MRClassNameKey = "class vtkVolumeRayCastMapper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVolumeRayCastMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVolumeRayCastMapper"));
		}

		public vtkVolumeRayCastMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeRayCastMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVolumeRayCastMapper New()
		{
			vtkVolumeRayCastMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeRayCastMapper.vtkVolumeRayCastMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeRayCastMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkVolumeRayCastMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkVolumeRayCastMapper.vtkVolumeRayCastMapper_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastMapper_AutoAdjustSampleDistancesOff_01(HandleRef pThis);

		public virtual void AutoAdjustSampleDistancesOff()
		{
			vtkVolumeRayCastMapper.vtkVolumeRayCastMapper_AutoAdjustSampleDistancesOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastMapper_AutoAdjustSampleDistancesOn_02(HandleRef pThis);

		public virtual void AutoAdjustSampleDistancesOn()
		{
			vtkVolumeRayCastMapper.vtkVolumeRayCastMapper_AutoAdjustSampleDistancesOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeRayCastMapper_GetAutoAdjustSampleDistances_03(HandleRef pThis);

		public virtual int GetAutoAdjustSampleDistances()
		{
			return vtkVolumeRayCastMapper.vtkVolumeRayCastMapper_GetAutoAdjustSampleDistances_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeRayCastMapper_GetAutoAdjustSampleDistancesMaxValue_04(HandleRef pThis);

		public virtual int GetAutoAdjustSampleDistancesMaxValue()
		{
			return vtkVolumeRayCastMapper.vtkVolumeRayCastMapper_GetAutoAdjustSampleDistancesMaxValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeRayCastMapper_GetAutoAdjustSampleDistancesMinValue_05(HandleRef pThis);

		public virtual int GetAutoAdjustSampleDistancesMinValue()
		{
			return vtkVolumeRayCastMapper.vtkVolumeRayCastMapper_GetAutoAdjustSampleDistancesMinValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeRayCastMapper_GetGradientEstimator_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkEncodedGradientEstimator GetGradientEstimator()
		{
			vtkEncodedGradientEstimator vtkEncodedGradientEstimator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeRayCastMapper.vtkVolumeRayCastMapper_GetGradientEstimator_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEncodedGradientEstimator = (vtkEncodedGradientEstimator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEncodedGradientEstimator.Register(null);
				}
			}
			return vtkEncodedGradientEstimator;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkVolumeRayCastMapper_GetGradientMagnitudeBias_07(HandleRef pThis);

		public override float GetGradientMagnitudeBias()
		{
			return vtkVolumeRayCastMapper.vtkVolumeRayCastMapper_GetGradientMagnitudeBias_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkVolumeRayCastMapper_GetGradientMagnitudeBias_08(HandleRef pThis, int arg0);

		public override float GetGradientMagnitudeBias(int arg0)
		{
			return vtkVolumeRayCastMapper.vtkVolumeRayCastMapper_GetGradientMagnitudeBias_08(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkVolumeRayCastMapper_GetGradientMagnitudeScale_09(HandleRef pThis, int arg0);

		public override float GetGradientMagnitudeScale(int arg0)
		{
			return vtkVolumeRayCastMapper.vtkVolumeRayCastMapper_GetGradientMagnitudeScale_09(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkVolumeRayCastMapper_GetGradientMagnitudeScale_10(HandleRef pThis);

		public override float GetGradientMagnitudeScale()
		{
			return vtkVolumeRayCastMapper.vtkVolumeRayCastMapper_GetGradientMagnitudeScale_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeRayCastMapper_GetGradientShader_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkEncodedGradientShader GetGradientShader()
		{
			vtkEncodedGradientShader vtkEncodedGradientShader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeRayCastMapper.vtkVolumeRayCastMapper_GetGradientShader_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEncodedGradientShader = (vtkEncodedGradientShader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEncodedGradientShader.Register(null);
				}
			}
			return vtkEncodedGradientShader;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern double vtkVolumeRayCastMapper_GetImageSampleDistance_12(HandleRef pThis);

		public virtual double GetImageSampleDistance()
		{
			return vtkVolumeRayCastMapper.vtkVolumeRayCastMapper_GetImageSampleDistance_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern double vtkVolumeRayCastMapper_GetImageSampleDistanceMaxValue_13(HandleRef pThis);

		public virtual double GetImageSampleDistanceMaxValue()
		{
			return vtkVolumeRayCastMapper.vtkVolumeRayCastMapper_GetImageSampleDistanceMaxValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern double vtkVolumeRayCastMapper_GetImageSampleDistanceMinValue_14(HandleRef pThis);

		public virtual double GetImageSampleDistanceMinValue()
		{
			return vtkVolumeRayCastMapper.vtkVolumeRayCastMapper_GetImageSampleDistanceMinValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeRayCastMapper_GetIntermixIntersectingGeometry_15(HandleRef pThis);

		public virtual int GetIntermixIntersectingGeometry()
		{
			return vtkVolumeRayCastMapper.vtkVolumeRayCastMapper_GetIntermixIntersectingGeometry_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeRayCastMapper_GetIntermixIntersectingGeometryMaxValue_16(HandleRef pThis);

		public virtual int GetIntermixIntersectingGeometryMaxValue()
		{
			return vtkVolumeRayCastMapper.vtkVolumeRayCastMapper_GetIntermixIntersectingGeometryMaxValue_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeRayCastMapper_GetIntermixIntersectingGeometryMinValue_17(HandleRef pThis);

		public virtual int GetIntermixIntersectingGeometryMinValue()
		{
			return vtkVolumeRayCastMapper.vtkVolumeRayCastMapper_GetIntermixIntersectingGeometryMinValue_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern double vtkVolumeRayCastMapper_GetMaximumImageSampleDistance_18(HandleRef pThis);

		public virtual double GetMaximumImageSampleDistance()
		{
			return vtkVolumeRayCastMapper.vtkVolumeRayCastMapper_GetMaximumImageSampleDistance_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern double vtkVolumeRayCastMapper_GetMaximumImageSampleDistanceMaxValue_19(HandleRef pThis);

		public virtual double GetMaximumImageSampleDistanceMaxValue()
		{
			return vtkVolumeRayCastMapper.vtkVolumeRayCastMapper_GetMaximumImageSampleDistanceMaxValue_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern double vtkVolumeRayCastMapper_GetMaximumImageSampleDistanceMinValue_20(HandleRef pThis);

		public virtual double GetMaximumImageSampleDistanceMinValue()
		{
			return vtkVolumeRayCastMapper.vtkVolumeRayCastMapper_GetMaximumImageSampleDistanceMinValue_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern double vtkVolumeRayCastMapper_GetMinimumImageSampleDistance_21(HandleRef pThis);

		public virtual double GetMinimumImageSampleDistance()
		{
			return vtkVolumeRayCastMapper.vtkVolumeRayCastMapper_GetMinimumImageSampleDistance_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern double vtkVolumeRayCastMapper_GetMinimumImageSampleDistanceMaxValue_22(HandleRef pThis);

		public virtual double GetMinimumImageSampleDistanceMaxValue()
		{
			return vtkVolumeRayCastMapper.vtkVolumeRayCastMapper_GetMinimumImageSampleDistanceMaxValue_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern double vtkVolumeRayCastMapper_GetMinimumImageSampleDistanceMinValue_23(HandleRef pThis);

		public virtual double GetMinimumImageSampleDistanceMinValue()
		{
			return vtkVolumeRayCastMapper.vtkVolumeRayCastMapper_GetMinimumImageSampleDistanceMinValue_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeRayCastMapper_GetNumberOfThreads_24(HandleRef pThis);

		public int GetNumberOfThreads()
		{
			return vtkVolumeRayCastMapper.vtkVolumeRayCastMapper_GetNumberOfThreads_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern double vtkVolumeRayCastMapper_GetSampleDistance_25(HandleRef pThis);

		public virtual double GetSampleDistance()
		{
			return vtkVolumeRayCastMapper.vtkVolumeRayCastMapper_GetSampleDistance_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeRayCastMapper_GetVolumeRayCastFunction_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkVolumeRayCastFunction GetVolumeRayCastFunction()
		{
			vtkVolumeRayCastFunction vtkVolumeRayCastFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeRayCastMapper.vtkVolumeRayCastMapper_GetVolumeRayCastFunction_26(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolumeRayCastFunction = (vtkVolumeRayCastFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolumeRayCastFunction.Register(null);
				}
			}
			return vtkVolumeRayCastFunction;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkVolumeRayCastMapper_GetZeroOpacityThreshold_27(HandleRef pThis, HandleRef vol);

		public float GetZeroOpacityThreshold(vtkVolume vol)
		{
			return vtkVolumeRayCastMapper.vtkVolumeRayCastMapper_GetZeroOpacityThreshold_27(base.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastMapper_IntermixIntersectingGeometryOff_28(HandleRef pThis);

		public virtual void IntermixIntersectingGeometryOff()
		{
			vtkVolumeRayCastMapper.vtkVolumeRayCastMapper_IntermixIntersectingGeometryOff_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastMapper_IntermixIntersectingGeometryOn_29(HandleRef pThis);

		public virtual void IntermixIntersectingGeometryOn()
		{
			vtkVolumeRayCastMapper.vtkVolumeRayCastMapper_IntermixIntersectingGeometryOn_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeRayCastMapper_IsA_30(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkVolumeRayCastMapper.vtkVolumeRayCastMapper_IsA_30(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeRayCastMapper_IsTypeOf_31(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkVolumeRayCastMapper.vtkVolumeRayCastMapper_IsTypeOf_31(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeRayCastMapper_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkVolumeRayCastMapper NewInstance()
		{
			vtkVolumeRayCastMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeRayCastMapper.vtkVolumeRayCastMapper_NewInstance_33(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeRayCastMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastMapper_ReleaseGraphicsResources_34(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkVolumeRayCastMapper.vtkVolumeRayCastMapper_ReleaseGraphicsResources_34(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastMapper_Render_35(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		public override void Render(vtkRenderer arg0, vtkVolume arg1)
		{
			vtkVolumeRayCastMapper.vtkVolumeRayCastMapper_Render_35(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeRayCastMapper_SafeDownCast_36(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVolumeRayCastMapper SafeDownCast(vtkObjectBase o)
		{
			vtkVolumeRayCastMapper vtkVolumeRayCastMapper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeRayCastMapper.vtkVolumeRayCastMapper_SafeDownCast_36((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolumeRayCastMapper = (vtkVolumeRayCastMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolumeRayCastMapper.Register(null);
				}
			}
			return vtkVolumeRayCastMapper;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastMapper_SetAutoAdjustSampleDistances_37(HandleRef pThis, int _arg);

		public virtual void SetAutoAdjustSampleDistances(int _arg)
		{
			vtkVolumeRayCastMapper.vtkVolumeRayCastMapper_SetAutoAdjustSampleDistances_37(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastMapper_SetGradientEstimator_38(HandleRef pThis, HandleRef gradest);

		public virtual void SetGradientEstimator(vtkEncodedGradientEstimator gradest)
		{
			vtkVolumeRayCastMapper.vtkVolumeRayCastMapper_SetGradientEstimator_38(base.GetCppThis(), (gradest == null) ? default(HandleRef) : gradest.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastMapper_SetImageSampleDistance_39(HandleRef pThis, double _arg);

		public virtual void SetImageSampleDistance(double _arg)
		{
			vtkVolumeRayCastMapper.vtkVolumeRayCastMapper_SetImageSampleDistance_39(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastMapper_SetIntermixIntersectingGeometry_40(HandleRef pThis, int _arg);

		public virtual void SetIntermixIntersectingGeometry(int _arg)
		{
			vtkVolumeRayCastMapper.vtkVolumeRayCastMapper_SetIntermixIntersectingGeometry_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastMapper_SetMaximumImageSampleDistance_41(HandleRef pThis, double _arg);

		public virtual void SetMaximumImageSampleDistance(double _arg)
		{
			vtkVolumeRayCastMapper.vtkVolumeRayCastMapper_SetMaximumImageSampleDistance_41(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastMapper_SetMinimumImageSampleDistance_42(HandleRef pThis, double _arg);

		public virtual void SetMinimumImageSampleDistance(double _arg)
		{
			vtkVolumeRayCastMapper.vtkVolumeRayCastMapper_SetMinimumImageSampleDistance_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastMapper_SetNumberOfThreads_43(HandleRef pThis, int num);

		public void SetNumberOfThreads(int num)
		{
			vtkVolumeRayCastMapper.vtkVolumeRayCastMapper_SetNumberOfThreads_43(base.GetCppThis(), num);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastMapper_SetSampleDistance_44(HandleRef pThis, double _arg);

		public virtual void SetSampleDistance(double _arg)
		{
			vtkVolumeRayCastMapper.vtkVolumeRayCastMapper_SetSampleDistance_44(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeRayCastMapper_SetVolumeRayCastFunction_45(HandleRef pThis, HandleRef arg0);

		public virtual void SetVolumeRayCastFunction(vtkVolumeRayCastFunction arg0)
		{
			vtkVolumeRayCastMapper.vtkVolumeRayCastMapper_SetVolumeRayCastFunction_45(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
