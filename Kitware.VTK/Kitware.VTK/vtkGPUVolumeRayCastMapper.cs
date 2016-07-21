using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkGPUVolumeRayCastMapper : vtkVolumeMapper
	{
		public enum BinaryMaskType_WrapperEnum
		{
			BinaryMaskType,
			LabelMapMaskType
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkGPUVolumeRayCastMapper";

		public new static readonly string MRClassNameKey;

		static vtkGPUVolumeRayCastMapper()
		{
			vtkGPUVolumeRayCastMapper.MRClassNameKey = "class vtkGPUVolumeRayCastMapper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGPUVolumeRayCastMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGPUVolumeRayCastMapper"));
		}

		public vtkGPUVolumeRayCastMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGPUVolumeRayCastMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGPUVolumeRayCastMapper New()
		{
			vtkGPUVolumeRayCastMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGPUVolumeRayCastMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGPUVolumeRayCastMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkGPUVolumeRayCastMapper_AutoAdjustSampleDistancesOff_01(HandleRef pThis);

		public virtual void AutoAdjustSampleDistancesOff()
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_AutoAdjustSampleDistancesOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkGPUVolumeRayCastMapper_AutoAdjustSampleDistancesOn_02(HandleRef pThis);

		public virtual void AutoAdjustSampleDistancesOn()
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_AutoAdjustSampleDistancesOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkGPUVolumeRayCastMapper_CreateCanonicalView_03(HandleRef pThis, HandleRef ren, HandleRef volume, HandleRef image, int blend_mode, IntPtr viewDirection, IntPtr viewUp);

		public void CreateCanonicalView(vtkRenderer ren, vtkVolume volume, vtkImageData image, int blend_mode, IntPtr viewDirection, IntPtr viewUp)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_CreateCanonicalView_03(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (volume == null) ? default(HandleRef) : volume.GetCppThis(), (image == null) ? default(HandleRef) : image.GetCppThis(), blend_mode, viewDirection, viewUp);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkGPUVolumeRayCastMapper_GPURender_04(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		public virtual void GPURender(vtkRenderer arg0, vtkVolume arg1)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GPURender_04(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkGPUVolumeRayCastMapper_GetAutoAdjustSampleDistances_05(HandleRef pThis);

		public virtual int GetAutoAdjustSampleDistances()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetAutoAdjustSampleDistances_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkGPUVolumeRayCastMapper_GetAutoAdjustSampleDistancesMaxValue_06(HandleRef pThis);

		public virtual int GetAutoAdjustSampleDistancesMaxValue()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetAutoAdjustSampleDistancesMaxValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkGPUVolumeRayCastMapper_GetAutoAdjustSampleDistancesMinValue_07(HandleRef pThis);

		public virtual int GetAutoAdjustSampleDistancesMinValue()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetAutoAdjustSampleDistancesMinValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkGPUVolumeRayCastMapper_GetFinalColorLevel_08(HandleRef pThis);

		public virtual float GetFinalColorLevel()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetFinalColorLevel_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkGPUVolumeRayCastMapper_GetFinalColorWindow_09(HandleRef pThis);

		public virtual float GetFinalColorWindow()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetFinalColorWindow_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkGPUVolumeRayCastMapper_GetImageSampleDistance_10(HandleRef pThis);

		public virtual float GetImageSampleDistance()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetImageSampleDistance_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkGPUVolumeRayCastMapper_GetImageSampleDistanceMaxValue_11(HandleRef pThis);

		public virtual float GetImageSampleDistanceMaxValue()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetImageSampleDistanceMaxValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkGPUVolumeRayCastMapper_GetImageSampleDistanceMinValue_12(HandleRef pThis);

		public virtual float GetImageSampleDistanceMinValue()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetImageSampleDistanceMinValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkGPUVolumeRayCastMapper_GetMaskBlendFactor_13(HandleRef pThis);

		public virtual float GetMaskBlendFactor()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetMaskBlendFactor_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkGPUVolumeRayCastMapper_GetMaskBlendFactorMaxValue_14(HandleRef pThis);

		public virtual float GetMaskBlendFactorMaxValue()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetMaskBlendFactorMaxValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkGPUVolumeRayCastMapper_GetMaskBlendFactorMinValue_15(HandleRef pThis);

		public virtual float GetMaskBlendFactorMinValue()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetMaskBlendFactorMinValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGPUVolumeRayCastMapper_GetMaskInput_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImageData GetMaskInput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetMaskInput_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkGPUVolumeRayCastMapper_GetMaskType_17(HandleRef pThis);

		public virtual int GetMaskType()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetMaskType_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkGPUVolumeRayCastMapper_GetMaxMemoryFraction_18(HandleRef pThis);

		public virtual float GetMaxMemoryFraction()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetMaxMemoryFraction_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkGPUVolumeRayCastMapper_GetMaxMemoryFractionMaxValue_19(HandleRef pThis);

		public virtual float GetMaxMemoryFractionMaxValue()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetMaxMemoryFractionMaxValue_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkGPUVolumeRayCastMapper_GetMaxMemoryFractionMinValue_20(HandleRef pThis);

		public virtual float GetMaxMemoryFractionMinValue()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetMaxMemoryFractionMinValue_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern long vtkGPUVolumeRayCastMapper_GetMaxMemoryInBytes_21(HandleRef pThis);

		public virtual long GetMaxMemoryInBytes()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetMaxMemoryInBytes_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkGPUVolumeRayCastMapper_GetMaximumImageSampleDistance_22(HandleRef pThis);

		public virtual float GetMaximumImageSampleDistance()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetMaximumImageSampleDistance_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkGPUVolumeRayCastMapper_GetMaximumImageSampleDistanceMaxValue_23(HandleRef pThis);

		public virtual float GetMaximumImageSampleDistanceMaxValue()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetMaximumImageSampleDistanceMaxValue_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkGPUVolumeRayCastMapper_GetMaximumImageSampleDistanceMinValue_24(HandleRef pThis);

		public virtual float GetMaximumImageSampleDistanceMinValue()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetMaximumImageSampleDistanceMinValue_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkGPUVolumeRayCastMapper_GetMinimumImageSampleDistance_25(HandleRef pThis);

		public virtual float GetMinimumImageSampleDistance()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetMinimumImageSampleDistance_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkGPUVolumeRayCastMapper_GetMinimumImageSampleDistanceMaxValue_26(HandleRef pThis);

		public virtual float GetMinimumImageSampleDistanceMaxValue()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetMinimumImageSampleDistanceMaxValue_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkGPUVolumeRayCastMapper_GetMinimumImageSampleDistanceMinValue_27(HandleRef pThis);

		public virtual float GetMinimumImageSampleDistanceMinValue()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetMinimumImageSampleDistanceMinValue_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkGPUVolumeRayCastMapper_GetReductionRatio_28(HandleRef pThis, IntPtr ratio);

		public virtual void GetReductionRatio(IntPtr ratio)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetReductionRatio_28(base.GetCppThis(), ratio);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern byte vtkGPUVolumeRayCastMapper_GetReportProgress_29(HandleRef pThis);

		public virtual bool GetReportProgress()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetReportProgress_29(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkGPUVolumeRayCastMapper_GetSampleDistance_30(HandleRef pThis);

		public virtual float GetSampleDistance()
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_GetSampleDistance_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkGPUVolumeRayCastMapper_IsA_31(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_IsA_31(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkGPUVolumeRayCastMapper_IsRenderSupported_32(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		public virtual int IsRenderSupported(vtkRenderWindow arg0, vtkVolumeProperty arg1)
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_IsRenderSupported_32(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkGPUVolumeRayCastMapper_IsTypeOf_33(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_IsTypeOf_33(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGPUVolumeRayCastMapper_NewInstance_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGPUVolumeRayCastMapper NewInstance()
		{
			vtkGPUVolumeRayCastMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_NewInstance_35(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGPUVolumeRayCastMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkGPUVolumeRayCastMapper_ReleaseGraphicsResources_36(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_ReleaseGraphicsResources_36(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkGPUVolumeRayCastMapper_Render_37(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		public override void Render(vtkRenderer arg0, vtkVolume arg1)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_Render_37(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGPUVolumeRayCastMapper_SafeDownCast_38(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGPUVolumeRayCastMapper SafeDownCast(vtkObjectBase o)
		{
			vtkGPUVolumeRayCastMapper vtkGPUVolumeRayCastMapper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SafeDownCast_38((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGPUVolumeRayCastMapper = (vtkGPUVolumeRayCastMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGPUVolumeRayCastMapper.Register(null);
				}
			}
			return vtkGPUVolumeRayCastMapper;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkGPUVolumeRayCastMapper_SetAutoAdjustSampleDistances_39(HandleRef pThis, int _arg);

		public virtual void SetAutoAdjustSampleDistances(int _arg)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SetAutoAdjustSampleDistances_39(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkGPUVolumeRayCastMapper_SetFinalColorLevel_40(HandleRef pThis, float _arg);

		public virtual void SetFinalColorLevel(float _arg)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SetFinalColorLevel_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkGPUVolumeRayCastMapper_SetFinalColorWindow_41(HandleRef pThis, float _arg);

		public virtual void SetFinalColorWindow(float _arg)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SetFinalColorWindow_41(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkGPUVolumeRayCastMapper_SetImageSampleDistance_42(HandleRef pThis, float _arg);

		public virtual void SetImageSampleDistance(float _arg)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SetImageSampleDistance_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkGPUVolumeRayCastMapper_SetMaskBlendFactor_43(HandleRef pThis, float _arg);

		public virtual void SetMaskBlendFactor(float _arg)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SetMaskBlendFactor_43(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkGPUVolumeRayCastMapper_SetMaskInput_44(HandleRef pThis, HandleRef mask);

		public void SetMaskInput(vtkImageData mask)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SetMaskInput_44(base.GetCppThis(), (mask == null) ? default(HandleRef) : mask.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkGPUVolumeRayCastMapper_SetMaskType_45(HandleRef pThis, int _arg);

		public virtual void SetMaskType(int _arg)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SetMaskType_45(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkGPUVolumeRayCastMapper_SetMaskTypeToBinary_46(HandleRef pThis);

		public void SetMaskTypeToBinary()
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SetMaskTypeToBinary_46(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkGPUVolumeRayCastMapper_SetMaskTypeToLabelMap_47(HandleRef pThis);

		public void SetMaskTypeToLabelMap()
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SetMaskTypeToLabelMap_47(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkGPUVolumeRayCastMapper_SetMaxMemoryFraction_48(HandleRef pThis, float _arg);

		public virtual void SetMaxMemoryFraction(float _arg)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SetMaxMemoryFraction_48(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkGPUVolumeRayCastMapper_SetMaxMemoryInBytes_49(HandleRef pThis, long _arg);

		public virtual void SetMaxMemoryInBytes(long _arg)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SetMaxMemoryInBytes_49(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkGPUVolumeRayCastMapper_SetMaximumImageSampleDistance_50(HandleRef pThis, float _arg);

		public virtual void SetMaximumImageSampleDistance(float _arg)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SetMaximumImageSampleDistance_50(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkGPUVolumeRayCastMapper_SetMinimumImageSampleDistance_51(HandleRef pThis, float _arg);

		public virtual void SetMinimumImageSampleDistance(float _arg)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SetMinimumImageSampleDistance_51(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkGPUVolumeRayCastMapper_SetReportProgress_52(HandleRef pThis, byte _arg);

		public virtual void SetReportProgress(bool _arg)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SetReportProgress_52(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkGPUVolumeRayCastMapper_SetSampleDistance_53(HandleRef pThis, float _arg);

		public virtual void SetSampleDistance(float _arg)
		{
			vtkGPUVolumeRayCastMapper.vtkGPUVolumeRayCastMapper_SetSampleDistance_53(base.GetCppThis(), _arg);
		}
	}
}
