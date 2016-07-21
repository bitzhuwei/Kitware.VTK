using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkFixedPointVolumeRayCastMapper : vtkVolumeMapper
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkFixedPointVolumeRayCastMapper";

		public new static readonly string MRClassNameKey;

		static vtkFixedPointVolumeRayCastMapper()
		{
			vtkFixedPointVolumeRayCastMapper.MRClassNameKey = "class vtkFixedPointVolumeRayCastMapper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFixedPointVolumeRayCastMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFixedPointVolumeRayCastMapper"));
		}

		public vtkFixedPointVolumeRayCastMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFixedPointVolumeRayCastMapper New()
		{
			vtkFixedPointVolumeRayCastMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFixedPointVolumeRayCastMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkFixedPointVolumeRayCastMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointVolumeRayCastMapper_AbortRender_01(HandleRef pThis);

		public void AbortRender()
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_AbortRender_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointVolumeRayCastMapper_AutoAdjustSampleDistancesOff_02(HandleRef pThis);

		public virtual void AutoAdjustSampleDistancesOff()
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_AutoAdjustSampleDistancesOff_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointVolumeRayCastMapper_AutoAdjustSampleDistancesOn_03(HandleRef pThis);

		public virtual void AutoAdjustSampleDistancesOn()
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_AutoAdjustSampleDistancesOn_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkFixedPointVolumeRayCastMapper_CheckIfCropped_04(HandleRef pThis, IntPtr pos);

		public int CheckIfCropped(IntPtr pos)
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_CheckIfCropped_04(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkFixedPointVolumeRayCastMapper_CheckMIPMinMaxVolumeFlag_05(HandleRef pThis, IntPtr mmpos, int c, ushort maxIdx, int flip);

		public int CheckMIPMinMaxVolumeFlag(IntPtr mmpos, int c, ushort maxIdx, int flip)
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_CheckMIPMinMaxVolumeFlag_05(base.GetCppThis(), mmpos, c, maxIdx, flip);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkFixedPointVolumeRayCastMapper_CheckMinMaxVolumeFlag_06(HandleRef pThis, IntPtr mmpos, int c);

		public int CheckMinMaxVolumeFlag(IntPtr mmpos, int c)
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_CheckMinMaxVolumeFlag_06(base.GetCppThis(), mmpos, c);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointVolumeRayCastMapper_ComputeRayInfo_07(HandleRef pThis, int x, int y, IntPtr pos, IntPtr dir, IntPtr numSteps);

		public void ComputeRayInfo(int x, int y, IntPtr pos, IntPtr dir, IntPtr numSteps)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_ComputeRayInfo_07(base.GetCppThis(), x, y, pos, dir, numSteps);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkFixedPointVolumeRayCastMapper_ComputeRequiredImageSampleDistance_08(HandleRef pThis, float desiredTime, HandleRef ren);

		public float ComputeRequiredImageSampleDistance(float desiredTime, vtkRenderer ren)
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_ComputeRequiredImageSampleDistance_08(base.GetCppThis(), desiredTime, (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkFixedPointVolumeRayCastMapper_ComputeRequiredImageSampleDistance_09(HandleRef pThis, float desiredTime, HandleRef ren, HandleRef vol);

		public float ComputeRequiredImageSampleDistance(float desiredTime, vtkRenderer ren, vtkVolume vol)
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_ComputeRequiredImageSampleDistance_09(base.GetCppThis(), desiredTime, (ren == null) ? default(HandleRef) : ren.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointVolumeRayCastMapper_CreateCanonicalView_10(HandleRef pThis, HandleRef volume, HandleRef image, int blend_mode, IntPtr viewDirection, IntPtr viewUp);

		public void CreateCanonicalView(vtkVolume volume, vtkImageData image, int blend_mode, IntPtr viewDirection, IntPtr viewUp)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_CreateCanonicalView_10(base.GetCppThis(), (volume == null) ? default(HandleRef) : volume.GetCppThis(), (image == null) ? default(HandleRef) : image.GetCppThis(), blend_mode, viewDirection, viewUp);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointVolumeRayCastMapper_DisplayRenderedImage_11(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		public void DisplayRenderedImage(vtkRenderer arg0, vtkVolume arg1)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_DisplayRenderedImage_11(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointVolumeRayCastMapper_FixedPointIncrement_12(HandleRef pThis, IntPtr position, IntPtr increment);

		public void FixedPointIncrement(IntPtr position, IntPtr increment)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_FixedPointIncrement_12(base.GetCppThis(), position, increment);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkFixedPointVolumeRayCastMapper_GetAutoAdjustSampleDistances_13(HandleRef pThis);

		public virtual int GetAutoAdjustSampleDistances()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetAutoAdjustSampleDistances_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkFixedPointVolumeRayCastMapper_GetAutoAdjustSampleDistancesMaxValue_14(HandleRef pThis);

		public virtual int GetAutoAdjustSampleDistancesMaxValue()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetAutoAdjustSampleDistancesMaxValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkFixedPointVolumeRayCastMapper_GetAutoAdjustSampleDistancesMinValue_15(HandleRef pThis);

		public virtual int GetAutoAdjustSampleDistancesMinValue()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetAutoAdjustSampleDistancesMinValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetColorTable_16(HandleRef pThis, int c);

		public IntPtr GetColorTable(int c)
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetColorTable_16(base.GetCppThis(), c);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetCompositeGOHelper_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkFixedPointVolumeRayCastCompositeGOHelper GetCompositeGOHelper()
		{
			vtkFixedPointVolumeRayCastCompositeGOHelper vtkFixedPointVolumeRayCastCompositeGOHelper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetCompositeGOHelper_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFixedPointVolumeRayCastCompositeGOHelper = (vtkFixedPointVolumeRayCastCompositeGOHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFixedPointVolumeRayCastCompositeGOHelper.Register(null);
				}
			}
			return vtkFixedPointVolumeRayCastCompositeGOHelper;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetCompositeGOShadeHelper_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkFixedPointVolumeRayCastCompositeGOShadeHelper GetCompositeGOShadeHelper()
		{
			vtkFixedPointVolumeRayCastCompositeGOShadeHelper vtkFixedPointVolumeRayCastCompositeGOShadeHelper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetCompositeGOShadeHelper_18(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFixedPointVolumeRayCastCompositeGOShadeHelper = (vtkFixedPointVolumeRayCastCompositeGOShadeHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFixedPointVolumeRayCastCompositeGOShadeHelper.Register(null);
				}
			}
			return vtkFixedPointVolumeRayCastCompositeGOShadeHelper;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetCompositeHelper_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkFixedPointVolumeRayCastCompositeHelper GetCompositeHelper()
		{
			vtkFixedPointVolumeRayCastCompositeHelper vtkFixedPointVolumeRayCastCompositeHelper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetCompositeHelper_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFixedPointVolumeRayCastCompositeHelper = (vtkFixedPointVolumeRayCastCompositeHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFixedPointVolumeRayCastCompositeHelper.Register(null);
				}
			}
			return vtkFixedPointVolumeRayCastCompositeHelper;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetCompositeShadeHelper_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkFixedPointVolumeRayCastCompositeShadeHelper GetCompositeShadeHelper()
		{
			vtkFixedPointVolumeRayCastCompositeShadeHelper vtkFixedPointVolumeRayCastCompositeShadeHelper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetCompositeShadeHelper_20(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFixedPointVolumeRayCastCompositeShadeHelper = (vtkFixedPointVolumeRayCastCompositeShadeHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFixedPointVolumeRayCastCompositeShadeHelper.Register(null);
				}
			}
			return vtkFixedPointVolumeRayCastCompositeShadeHelper;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetCurrentScalars_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDataArray GetCurrentScalars()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetCurrentScalars_21(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetDiffuseShadingTable_22(HandleRef pThis, int c);

		public IntPtr GetDiffuseShadingTable(int c)
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetDiffuseShadingTable_22(base.GetCppThis(), c);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkFixedPointVolumeRayCastMapper_GetEstimatedRenderTime_23(HandleRef pThis, HandleRef ren, HandleRef vol);

		public float GetEstimatedRenderTime(vtkRenderer ren, vtkVolume vol)
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetEstimatedRenderTime_23(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkFixedPointVolumeRayCastMapper_GetEstimatedRenderTime_24(HandleRef pThis, HandleRef ren);

		public float GetEstimatedRenderTime(vtkRenderer ren)
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetEstimatedRenderTime_24(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkFixedPointVolumeRayCastMapper_GetFinalColorLevel_25(HandleRef pThis);

		public virtual float GetFinalColorLevel()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetFinalColorLevel_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkFixedPointVolumeRayCastMapper_GetFinalColorWindow_26(HandleRef pThis);

		public virtual float GetFinalColorWindow()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetFinalColorWindow_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkFixedPointVolumeRayCastMapper_GetFlipMIPComparison_27(HandleRef pThis);

		public virtual int GetFlipMIPComparison()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetFlipMIPComparison_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointVolumeRayCastMapper_GetFloatTripleFromPointer_28(HandleRef pThis, IntPtr v, IntPtr ptr);

		public void GetFloatTripleFromPointer(IntPtr v, IntPtr ptr)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetFloatTripleFromPointer_28(base.GetCppThis(), v, ptr);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkFixedPointVolumeRayCastMapper_GetGradientOpacityRequired_29(HandleRef pThis);

		public virtual int GetGradientOpacityRequired()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetGradientOpacityRequired_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetGradientOpacityTable_30(HandleRef pThis, int c);

		public IntPtr GetGradientOpacityTable(int c)
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetGradientOpacityTable_30(base.GetCppThis(), c);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkFixedPointVolumeRayCastMapper_GetImageSampleDistance_31(HandleRef pThis);

		public virtual float GetImageSampleDistance()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetImageSampleDistance_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkFixedPointVolumeRayCastMapper_GetImageSampleDistanceMaxValue_32(HandleRef pThis);

		public virtual float GetImageSampleDistanceMaxValue()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetImageSampleDistanceMaxValue_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkFixedPointVolumeRayCastMapper_GetImageSampleDistanceMinValue_33(HandleRef pThis);

		public virtual float GetImageSampleDistanceMinValue()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetImageSampleDistanceMinValue_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkFixedPointVolumeRayCastMapper_GetInteractiveSampleDistance_34(HandleRef pThis);

		public virtual float GetInteractiveSampleDistance()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetInteractiveSampleDistance_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkFixedPointVolumeRayCastMapper_GetIntermixIntersectingGeometry_35(HandleRef pThis);

		public virtual int GetIntermixIntersectingGeometry()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetIntermixIntersectingGeometry_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkFixedPointVolumeRayCastMapper_GetIntermixIntersectingGeometryMaxValue_36(HandleRef pThis);

		public virtual int GetIntermixIntersectingGeometryMaxValue()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetIntermixIntersectingGeometryMaxValue_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkFixedPointVolumeRayCastMapper_GetIntermixIntersectingGeometryMinValue_37(HandleRef pThis);

		public virtual int GetIntermixIntersectingGeometryMinValue()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetIntermixIntersectingGeometryMinValue_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkFixedPointVolumeRayCastMapper_GetLockSampleDistanceToInputSpacing_38(HandleRef pThis);

		public virtual int GetLockSampleDistanceToInputSpacing()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetLockSampleDistanceToInputSpacing_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkFixedPointVolumeRayCastMapper_GetLockSampleDistanceToInputSpacingMaxValue_39(HandleRef pThis);

		public virtual int GetLockSampleDistanceToInputSpacingMaxValue()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetLockSampleDistanceToInputSpacingMaxValue_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkFixedPointVolumeRayCastMapper_GetLockSampleDistanceToInputSpacingMinValue_40(HandleRef pThis);

		public virtual int GetLockSampleDistanceToInputSpacingMinValue()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetLockSampleDistanceToInputSpacingMinValue_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetMIPHelper_41(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkFixedPointVolumeRayCastMIPHelper GetMIPHelper()
		{
			vtkFixedPointVolumeRayCastMIPHelper vtkFixedPointVolumeRayCastMIPHelper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetMIPHelper_41(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFixedPointVolumeRayCastMIPHelper = (vtkFixedPointVolumeRayCastMIPHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFixedPointVolumeRayCastMIPHelper.Register(null);
				}
			}
			return vtkFixedPointVolumeRayCastMIPHelper;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkFixedPointVolumeRayCastMapper_GetMaximumImageSampleDistance_42(HandleRef pThis);

		public virtual float GetMaximumImageSampleDistance()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetMaximumImageSampleDistance_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkFixedPointVolumeRayCastMapper_GetMaximumImageSampleDistanceMaxValue_43(HandleRef pThis);

		public virtual float GetMaximumImageSampleDistanceMaxValue()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetMaximumImageSampleDistanceMaxValue_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkFixedPointVolumeRayCastMapper_GetMaximumImageSampleDistanceMinValue_44(HandleRef pThis);

		public virtual float GetMaximumImageSampleDistanceMinValue()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetMaximumImageSampleDistanceMinValue_44(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkFixedPointVolumeRayCastMapper_GetMinimumImageSampleDistance_45(HandleRef pThis);

		public virtual float GetMinimumImageSampleDistance()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetMinimumImageSampleDistance_45(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkFixedPointVolumeRayCastMapper_GetMinimumImageSampleDistanceMaxValue_46(HandleRef pThis);

		public virtual float GetMinimumImageSampleDistanceMaxValue()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetMinimumImageSampleDistanceMaxValue_46(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkFixedPointVolumeRayCastMapper_GetMinimumImageSampleDistanceMinValue_47(HandleRef pThis);

		public virtual float GetMinimumImageSampleDistanceMinValue()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetMinimumImageSampleDistanceMinValue_47(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkFixedPointVolumeRayCastMapper_GetNumberOfThreads_48(HandleRef pThis);

		public int GetNumberOfThreads()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetNumberOfThreads_48(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetPreviousScalars_49(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDataArray GetPreviousScalars()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetPreviousScalars_49(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetRayCastImage_50(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkFixedPointRayCastImage GetRayCastImage()
		{
			vtkFixedPointRayCastImage vtkFixedPointRayCastImage = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetRayCastImage_50(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFixedPointRayCastImage = (vtkFixedPointRayCastImage)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFixedPointRayCastImage.Register(null);
				}
			}
			return vtkFixedPointRayCastImage;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetRenderWindow_51(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkRenderWindow GetRenderWindow()
		{
			vtkRenderWindow vtkRenderWindow = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetRenderWindow_51(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderWindow = (vtkRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderWindow.Register(null);
				}
			}
			return vtkRenderWindow;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetRowBounds_52(HandleRef pThis);

		public IntPtr GetRowBounds()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetRowBounds_52(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkFixedPointVolumeRayCastMapper_GetSampleDistance_53(HandleRef pThis);

		public virtual float GetSampleDistance()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetSampleDistance_53(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetScalarOpacityTable_54(HandleRef pThis, int c);

		public IntPtr GetScalarOpacityTable(int c)
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetScalarOpacityTable_54(base.GetCppThis(), c);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkFixedPointVolumeRayCastMapper_GetShadingRequired_55(HandleRef pThis);

		public virtual int GetShadingRequired()
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetShadingRequired_55(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetSpecularShadingTable_56(HandleRef pThis, int c);

		public IntPtr GetSpecularShadingTable(int c)
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetSpecularShadingTable_56(base.GetCppThis(), c);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetTableScale_57(HandleRef pThis);

		public virtual float[] GetTableScale()
		{
			IntPtr intPtr = vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetTableScale_57(base.GetCppThis());
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointVolumeRayCastMapper_GetTableScale_58(HandleRef pThis, IntPtr data);

		public virtual void GetTableScale(IntPtr data)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetTableScale_58(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetTableShift_59(HandleRef pThis);

		public virtual float[] GetTableShift()
		{
			IntPtr intPtr = vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetTableShift_59(base.GetCppThis());
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointVolumeRayCastMapper_GetTableShift_60(HandleRef pThis, IntPtr data);

		public virtual void GetTableShift(IntPtr data)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetTableShift_60(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointVolumeRayCastMapper_GetUIntTripleFromPointer_61(HandleRef pThis, IntPtr v, IntPtr ptr);

		public void GetUIntTripleFromPointer(IntPtr v, IntPtr ptr)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetUIntTripleFromPointer_61(base.GetCppThis(), v, ptr);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_GetVolume_62(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkVolume GetVolume()
		{
			vtkVolume vtkVolume = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_GetVolume_62(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolume = (vtkVolume)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolume.Register(null);
				}
			}
			return vtkVolume;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointVolumeRayCastMapper_InitializeRayInfo_63(HandleRef pThis, HandleRef vol);

		public void InitializeRayInfo(vtkVolume vol)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_InitializeRayInfo_63(base.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointVolumeRayCastMapper_IntermixIntersectingGeometryOff_64(HandleRef pThis);

		public virtual void IntermixIntersectingGeometryOff()
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_IntermixIntersectingGeometryOff_64(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointVolumeRayCastMapper_IntermixIntersectingGeometryOn_65(HandleRef pThis);

		public virtual void IntermixIntersectingGeometryOn()
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_IntermixIntersectingGeometryOn_65(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkFixedPointVolumeRayCastMapper_IsA_66(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_IsA_66(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkFixedPointVolumeRayCastMapper_IsTypeOf_67(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_IsTypeOf_67(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointVolumeRayCastMapper_LockSampleDistanceToInputSpacingOff_68(HandleRef pThis);

		public virtual void LockSampleDistanceToInputSpacingOff()
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_LockSampleDistanceToInputSpacingOff_68(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointVolumeRayCastMapper_LockSampleDistanceToInputSpacingOn_69(HandleRef pThis);

		public virtual void LockSampleDistanceToInputSpacingOn()
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_LockSampleDistanceToInputSpacingOn_69(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointVolumeRayCastMapper_LookupColorUC_70(HandleRef pThis, IntPtr colorTable, IntPtr scalarOpacityTable, ushort index, IntPtr color);

		public void LookupColorUC(IntPtr colorTable, IntPtr scalarOpacityTable, ushort index, IntPtr color)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_LookupColorUC_70(base.GetCppThis(), colorTable, scalarOpacityTable, index, color);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointVolumeRayCastMapper_LookupDependentColorUC_71(HandleRef pThis, IntPtr colorTable, IntPtr scalarOpacityTable, IntPtr index, int components, IntPtr color);

		public void LookupDependentColorUC(IntPtr colorTable, IntPtr scalarOpacityTable, IntPtr index, int components, IntPtr color)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_LookupDependentColorUC_71(base.GetCppThis(), colorTable, scalarOpacityTable, index, components, color);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_NewInstance_73(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkFixedPointVolumeRayCastMapper NewInstance()
		{
			vtkFixedPointVolumeRayCastMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_NewInstance_73(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFixedPointVolumeRayCastMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkFixedPointVolumeRayCastMapper_PerImageInitialization_74(HandleRef pThis, HandleRef arg0, HandleRef arg1, int arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);

		public int PerImageInitialization(vtkRenderer arg0, vtkVolume arg1, int arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5)
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_PerImageInitialization_74(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis(), arg2, arg3, arg4, arg5);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointVolumeRayCastMapper_PerSubVolumeInitialization_75(HandleRef pThis, HandleRef arg0, HandleRef arg1, int arg2);

		public void PerSubVolumeInitialization(vtkRenderer arg0, vtkVolume arg1, int arg2)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_PerSubVolumeInitialization_75(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis(), arg2);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointVolumeRayCastMapper_PerVolumeInitialization_76(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		public void PerVolumeInitialization(vtkRenderer arg0, vtkVolume arg1)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_PerVolumeInitialization_76(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointVolumeRayCastMapper_Render_77(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		public override void Render(vtkRenderer arg0, vtkVolume arg1)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_Render_77(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointVolumeRayCastMapper_RenderSubVolume_78(HandleRef pThis);

		public void RenderSubVolume()
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_RenderSubVolume_78(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedPointVolumeRayCastMapper_SafeDownCast_79(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFixedPointVolumeRayCastMapper SafeDownCast(vtkObjectBase o)
		{
			vtkFixedPointVolumeRayCastMapper vtkFixedPointVolumeRayCastMapper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_SafeDownCast_79((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFixedPointVolumeRayCastMapper = (vtkFixedPointVolumeRayCastMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFixedPointVolumeRayCastMapper.Register(null);
				}
			}
			return vtkFixedPointVolumeRayCastMapper;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointVolumeRayCastMapper_SetAutoAdjustSampleDistances_80(HandleRef pThis, int _arg);

		public virtual void SetAutoAdjustSampleDistances(int _arg)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_SetAutoAdjustSampleDistances_80(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointVolumeRayCastMapper_SetFinalColorLevel_81(HandleRef pThis, float _arg);

		public virtual void SetFinalColorLevel(float _arg)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_SetFinalColorLevel_81(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointVolumeRayCastMapper_SetFinalColorWindow_82(HandleRef pThis, float _arg);

		public virtual void SetFinalColorWindow(float _arg)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_SetFinalColorWindow_82(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointVolumeRayCastMapper_SetImageSampleDistance_83(HandleRef pThis, float _arg);

		public virtual void SetImageSampleDistance(float _arg)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_SetImageSampleDistance_83(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointVolumeRayCastMapper_SetInteractiveSampleDistance_84(HandleRef pThis, float _arg);

		public virtual void SetInteractiveSampleDistance(float _arg)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_SetInteractiveSampleDistance_84(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointVolumeRayCastMapper_SetIntermixIntersectingGeometry_85(HandleRef pThis, int _arg);

		public virtual void SetIntermixIntersectingGeometry(int _arg)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_SetIntermixIntersectingGeometry_85(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointVolumeRayCastMapper_SetLockSampleDistanceToInputSpacing_86(HandleRef pThis, int _arg);

		public virtual void SetLockSampleDistanceToInputSpacing(int _arg)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_SetLockSampleDistanceToInputSpacing_86(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointVolumeRayCastMapper_SetMaximumImageSampleDistance_87(HandleRef pThis, float _arg);

		public virtual void SetMaximumImageSampleDistance(float _arg)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_SetMaximumImageSampleDistance_87(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointVolumeRayCastMapper_SetMinimumImageSampleDistance_88(HandleRef pThis, float _arg);

		public virtual void SetMinimumImageSampleDistance(float _arg)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_SetMinimumImageSampleDistance_88(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointVolumeRayCastMapper_SetNumberOfThreads_89(HandleRef pThis, int num);

		public void SetNumberOfThreads(int num)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_SetNumberOfThreads_89(base.GetCppThis(), num);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointVolumeRayCastMapper_SetRayCastImage_90(HandleRef pThis, HandleRef arg0);

		public void SetRayCastImage(vtkFixedPointRayCastImage arg0)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_SetRayCastImage_90(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointVolumeRayCastMapper_SetSampleDistance_91(HandleRef pThis, float _arg);

		public virtual void SetSampleDistance(float _arg)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_SetSampleDistance_91(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointVolumeRayCastMapper_ShiftVectorDown_92(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		public void ShiftVectorDown(IntPtr arg0, IntPtr arg1)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_ShiftVectorDown_92(base.GetCppThis(), arg0, arg1);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkFixedPointVolumeRayCastMapper_ShouldUseNearestNeighborInterpolation_93(HandleRef pThis, HandleRef vol);

		public int ShouldUseNearestNeighborInterpolation(vtkVolume vol)
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_ShouldUseNearestNeighborInterpolation_93(base.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern uint vtkFixedPointVolumeRayCastMapper_ToFixedPointDirection_94(HandleRef pThis, float dir);

		public uint ToFixedPointDirection(float dir)
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_ToFixedPointDirection_94(base.GetCppThis(), dir);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointVolumeRayCastMapper_ToFixedPointDirection_95(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		public void ToFixedPointDirection(IntPtr arg0, IntPtr arg1)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_ToFixedPointDirection_95(base.GetCppThis(), arg0, arg1);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern uint vtkFixedPointVolumeRayCastMapper_ToFixedPointPosition_96(HandleRef pThis, float val);

		public uint ToFixedPointPosition(float val)
		{
			return vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_ToFixedPointPosition_96(base.GetCppThis(), val);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointVolumeRayCastMapper_ToFixedPointPosition_97(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		public void ToFixedPointPosition(IntPtr arg0, IntPtr arg1)
		{
			vtkFixedPointVolumeRayCastMapper.vtkFixedPointVolumeRayCastMapper_ToFixedPointPosition_97(base.GetCppThis(), arg0, arg1);
		}
	}
}
