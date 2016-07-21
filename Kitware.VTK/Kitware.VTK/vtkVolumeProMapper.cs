using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkVolumeProMapper : vtkVolumeMapper
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkVolumeProMapper";

		public new static readonly string MRClassNameKey;

		static vtkVolumeProMapper()
		{
			vtkVolumeProMapper.MRClassNameKey = "class vtkVolumeProMapper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVolumeProMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVolumeProMapper"));
		}

		public vtkVolumeProMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeProMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVolumeProMapper New()
		{
			vtkVolumeProMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeProMapper.vtkVolumeProMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeProMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkVolumeProMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkVolumeProMapper.vtkVolumeProMapper_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_AutoAdjustMipmapLevelsOff_01(HandleRef pThis);

		public virtual void AutoAdjustMipmapLevelsOff()
		{
			vtkVolumeProMapper.vtkVolumeProMapper_AutoAdjustMipmapLevelsOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_AutoAdjustMipmapLevelsOn_02(HandleRef pThis);

		public virtual void AutoAdjustMipmapLevelsOn()
		{
			vtkVolumeProMapper.vtkVolumeProMapper_AutoAdjustMipmapLevelsOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_CursorOff_03(HandleRef pThis);

		public virtual void CursorOff()
		{
			vtkVolumeProMapper.vtkVolumeProMapper_CursorOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_CursorOn_04(HandleRef pThis);

		public virtual void CursorOn()
		{
			vtkVolumeProMapper.vtkVolumeProMapper_CursorOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_CutPlaneOff_05(HandleRef pThis);

		public virtual void CutPlaneOff()
		{
			vtkVolumeProMapper.vtkVolumeProMapper_CutPlaneOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_CutPlaneOn_06(HandleRef pThis);

		public virtual void CutPlaneOn()
		{
			vtkVolumeProMapper.vtkVolumeProMapper_CutPlaneOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetAutoAdjustMipmapLevels_07(HandleRef pThis);

		public virtual int GetAutoAdjustMipmapLevels()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetAutoAdjustMipmapLevels_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetAutoAdjustMipmapLevelsMaxValue_08(HandleRef pThis);

		public virtual int GetAutoAdjustMipmapLevelsMaxValue()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetAutoAdjustMipmapLevelsMaxValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetAutoAdjustMipmapLevelsMinValue_09(HandleRef pThis);

		public virtual int GetAutoAdjustMipmapLevelsMinValue()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetAutoAdjustMipmapLevelsMinValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetAvailableBoardMemory_10(HandleRef pThis);

		public virtual int GetAvailableBoardMemory()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetAvailableBoardMemory_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetBlendMode_11(HandleRef pThis);

		public override int GetBlendMode()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetBlendMode_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeProMapper_GetBlendModeAsString_12(HandleRef pThis);

		public string GetBlendModeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkVolumeProMapper.vtkVolumeProMapper_GetBlendModeAsString_12(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetBlendModeMaxValue_13(HandleRef pThis);

		public virtual int GetBlendModeMaxValue()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetBlendModeMaxValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetBlendModeMinValue_14(HandleRef pThis);

		public virtual int GetBlendModeMinValue()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetBlendModeMinValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetCursor_15(HandleRef pThis);

		public virtual int GetCursor()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetCursor_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetCursorMaxValue_16(HandleRef pThis);

		public virtual int GetCursorMaxValue()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetCursorMaxValue_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetCursorMinValue_17(HandleRef pThis);

		public virtual int GetCursorMinValue()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetCursorMinValue_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeProMapper_GetCursorPosition_18(HandleRef pThis);

		public virtual double[] GetCursorPosition()
		{
			IntPtr intPtr = vtkVolumeProMapper.vtkVolumeProMapper_GetCursorPosition_18(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_GetCursorPosition_19(HandleRef pThis, IntPtr data);

		public virtual void GetCursorPosition(IntPtr data)
		{
			vtkVolumeProMapper.vtkVolumeProMapper_GetCursorPosition_19(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetCursorType_20(HandleRef pThis);

		public virtual int GetCursorType()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetCursorType_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeProMapper_GetCursorTypeAsString_21(HandleRef pThis);

		public string GetCursorTypeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkVolumeProMapper.vtkVolumeProMapper_GetCursorTypeAsString_21(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetCursorTypeMaxValue_22(HandleRef pThis);

		public virtual int GetCursorTypeMaxValue()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetCursorTypeMaxValue_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetCursorTypeMinValue_23(HandleRef pThis);

		public virtual int GetCursorTypeMinValue()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetCursorTypeMinValue_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_GetCursorXAxisColor_24(HandleRef pThis, IntPtr data);

		public virtual void GetCursorXAxisColor(IntPtr data)
		{
			vtkVolumeProMapper.vtkVolumeProMapper_GetCursorXAxisColor_24(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeProMapper_GetCursorXAxisColor_25(HandleRef pThis);

		public virtual double[] GetCursorXAxisColor()
		{
			IntPtr intPtr = vtkVolumeProMapper.vtkVolumeProMapper_GetCursorXAxisColor_25(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeProMapper_GetCursorYAxisColor_26(HandleRef pThis);

		public virtual double[] GetCursorYAxisColor()
		{
			IntPtr intPtr = vtkVolumeProMapper.vtkVolumeProMapper_GetCursorYAxisColor_26(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_GetCursorYAxisColor_27(HandleRef pThis, IntPtr data);

		public virtual void GetCursorYAxisColor(IntPtr data)
		{
			vtkVolumeProMapper.vtkVolumeProMapper_GetCursorYAxisColor_27(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeProMapper_GetCursorZAxisColor_28(HandleRef pThis);

		public virtual double[] GetCursorZAxisColor()
		{
			IntPtr intPtr = vtkVolumeProMapper.vtkVolumeProMapper_GetCursorZAxisColor_28(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_GetCursorZAxisColor_29(HandleRef pThis, IntPtr data);

		public virtual void GetCursorZAxisColor(IntPtr data)
		{
			vtkVolumeProMapper.vtkVolumeProMapper_GetCursorZAxisColor_29(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetCutPlane_30(HandleRef pThis);

		public virtual int GetCutPlane()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetCutPlane_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeProMapper_GetCutPlaneEquation_31(HandleRef pThis);

		public virtual double[] GetCutPlaneEquation()
		{
			IntPtr intPtr = vtkVolumeProMapper.vtkVolumeProMapper_GetCutPlaneEquation_31(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_GetCutPlaneEquation_32(HandleRef pThis, IntPtr data);

		public virtual void GetCutPlaneEquation(IntPtr data)
		{
			vtkVolumeProMapper.vtkVolumeProMapper_GetCutPlaneEquation_32(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetCutPlaneFallOffDistance_33(HandleRef pThis);

		public virtual int GetCutPlaneFallOffDistance()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetCutPlaneFallOffDistance_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetCutPlaneFallOffDistanceMaxValue_34(HandleRef pThis);

		public virtual int GetCutPlaneFallOffDistanceMaxValue()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetCutPlaneFallOffDistanceMaxValue_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetCutPlaneFallOffDistanceMinValue_35(HandleRef pThis);

		public virtual int GetCutPlaneFallOffDistanceMinValue()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetCutPlaneFallOffDistanceMinValue_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetCutPlaneMaxValue_36(HandleRef pThis);

		public virtual int GetCutPlaneMaxValue()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetCutPlaneMaxValue_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetCutPlaneMinValue_37(HandleRef pThis);

		public virtual int GetCutPlaneMinValue()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetCutPlaneMinValue_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern double vtkVolumeProMapper_GetCutPlaneThickness_38(HandleRef pThis);

		public virtual double GetCutPlaneThickness()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetCutPlaneThickness_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern double vtkVolumeProMapper_GetCutPlaneThicknessMaxValue_39(HandleRef pThis);

		public virtual double GetCutPlaneThicknessMaxValue()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetCutPlaneThicknessMaxValue_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern double vtkVolumeProMapper_GetCutPlaneThicknessMinValue_40(HandleRef pThis);

		public virtual double GetCutPlaneThicknessMinValue()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetCutPlaneThicknessMinValue_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetGradientDiffuseModulation_41(HandleRef pThis);

		public virtual int GetGradientDiffuseModulation()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetGradientDiffuseModulation_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetGradientDiffuseModulationMaxValue_42(HandleRef pThis);

		public virtual int GetGradientDiffuseModulationMaxValue()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetGradientDiffuseModulationMaxValue_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetGradientDiffuseModulationMinValue_43(HandleRef pThis);

		public virtual int GetGradientDiffuseModulationMinValue()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetGradientDiffuseModulationMinValue_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetGradientOpacityModulation_44(HandleRef pThis);

		public virtual int GetGradientOpacityModulation()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetGradientOpacityModulation_44(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetGradientOpacityModulationMaxValue_45(HandleRef pThis);

		public virtual int GetGradientOpacityModulationMaxValue()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetGradientOpacityModulationMaxValue_45(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetGradientOpacityModulationMinValue_46(HandleRef pThis);

		public virtual int GetGradientOpacityModulationMinValue()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetGradientOpacityModulationMinValue_46(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetGradientSpecularModulation_47(HandleRef pThis);

		public virtual int GetGradientSpecularModulation()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetGradientSpecularModulation_47(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetGradientSpecularModulationMaxValue_48(HandleRef pThis);

		public virtual int GetGradientSpecularModulationMaxValue()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetGradientSpecularModulationMaxValue_48(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetGradientSpecularModulationMinValue_49(HandleRef pThis);

		public virtual int GetGradientSpecularModulationMinValue()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetGradientSpecularModulationMinValue_49(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetIntermixIntersectingGeometry_50(HandleRef pThis);

		public virtual int GetIntermixIntersectingGeometry()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetIntermixIntersectingGeometry_50(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetIntermixIntersectingGeometryMaxValue_51(HandleRef pThis);

		public virtual int GetIntermixIntersectingGeometryMaxValue()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetIntermixIntersectingGeometryMaxValue_51(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetIntermixIntersectingGeometryMinValue_52(HandleRef pThis);

		public virtual int GetIntermixIntersectingGeometryMinValue()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetIntermixIntersectingGeometryMinValue_52(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_GetLockSizesForBoardMemory_53(HandleRef pThis, uint arg0, IntPtr arg1, IntPtr arg2, IntPtr arg3);

		public virtual void GetLockSizesForBoardMemory(uint arg0, IntPtr arg1, IntPtr arg2, IntPtr arg3)
		{
			vtkVolumeProMapper.vtkVolumeProMapper_GetLockSizesForBoardMemory_53(base.GetCppThis(), arg0, arg1, arg2, arg3);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetMajorBoardVersion_54(HandleRef pThis);

		public virtual int GetMajorBoardVersion()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetMajorBoardVersion_54(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetMaximumMipmapLevel_55(HandleRef pThis);

		public virtual int GetMaximumMipmapLevel()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetMaximumMipmapLevel_55(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetMaximumMipmapLevelMaxValue_56(HandleRef pThis);

		public virtual int GetMaximumMipmapLevelMaxValue()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetMaximumMipmapLevelMaxValue_56(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetMaximumMipmapLevelMinValue_57(HandleRef pThis);

		public virtual int GetMaximumMipmapLevelMinValue()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetMaximumMipmapLevelMinValue_57(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetMinimumMipmapLevel_58(HandleRef pThis);

		public virtual int GetMinimumMipmapLevel()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetMinimumMipmapLevel_58(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetMinimumMipmapLevelMaxValue_59(HandleRef pThis);

		public virtual int GetMinimumMipmapLevelMaxValue()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetMinimumMipmapLevelMaxValue_59(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetMinimumMipmapLevelMinValue_60(HandleRef pThis);

		public virtual int GetMinimumMipmapLevelMinValue()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetMinimumMipmapLevelMinValue_60(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetMinorBoardVersion_61(HandleRef pThis);

		public virtual int GetMinorBoardVersion()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetMinorBoardVersion_61(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetMipmapLevel_62(HandleRef pThis);

		public virtual int GetMipmapLevel()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetMipmapLevel_62(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetMipmapLevelMaxValue_63(HandleRef pThis);

		public virtual int GetMipmapLevelMaxValue()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetMipmapLevelMaxValue_63(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetMipmapLevelMinValue_64(HandleRef pThis);

		public virtual int GetMipmapLevelMinValue()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetMipmapLevelMinValue_64(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetNoHardware_65(HandleRef pThis);

		public virtual int GetNoHardware()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetNoHardware_65(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetNumberOfBoards_66(HandleRef pThis);

		public virtual int GetNumberOfBoards()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetNumberOfBoards_66(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeProMapper_GetSubVolume_67(HandleRef pThis);

		public virtual int[] GetSubVolume()
		{
			IntPtr intPtr = vtkVolumeProMapper.vtkVolumeProMapper_GetSubVolume_67(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_GetSubVolume_68(HandleRef pThis, IntPtr data);

		public virtual void GetSubVolume(IntPtr data)
		{
			vtkVolumeProMapper.vtkVolumeProMapper_GetSubVolume_68(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetSuperSampling_69(HandleRef pThis);

		public virtual int GetSuperSampling()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetSuperSampling_69(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeProMapper_GetSuperSamplingFactor_70(HandleRef pThis);

		public virtual double[] GetSuperSamplingFactor()
		{
			IntPtr intPtr = vtkVolumeProMapper.vtkVolumeProMapper_GetSuperSamplingFactor_70(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_GetSuperSamplingFactor_71(HandleRef pThis, IntPtr data);

		public virtual void GetSuperSamplingFactor(IntPtr data)
		{
			vtkVolumeProMapper.vtkVolumeProMapper_GetSuperSamplingFactor_71(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetSuperSamplingMaxValue_72(HandleRef pThis);

		public virtual int GetSuperSamplingMaxValue()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetSuperSamplingMaxValue_72(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetSuperSamplingMinValue_73(HandleRef pThis);

		public virtual int GetSuperSamplingMinValue()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetSuperSamplingMinValue_73(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_GetWrongVLIVersion_74(HandleRef pThis);

		public virtual int GetWrongVLIVersion()
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_GetWrongVLIVersion_74(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_GradientDiffuseModulationOff_75(HandleRef pThis);

		public virtual void GradientDiffuseModulationOff()
		{
			vtkVolumeProMapper.vtkVolumeProMapper_GradientDiffuseModulationOff_75(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_GradientDiffuseModulationOn_76(HandleRef pThis);

		public virtual void GradientDiffuseModulationOn()
		{
			vtkVolumeProMapper.vtkVolumeProMapper_GradientDiffuseModulationOn_76(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_GradientOpacityModulationOff_77(HandleRef pThis);

		public virtual void GradientOpacityModulationOff()
		{
			vtkVolumeProMapper.vtkVolumeProMapper_GradientOpacityModulationOff_77(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_GradientOpacityModulationOn_78(HandleRef pThis);

		public virtual void GradientOpacityModulationOn()
		{
			vtkVolumeProMapper.vtkVolumeProMapper_GradientOpacityModulationOn_78(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_GradientSpecularModulationOff_79(HandleRef pThis);

		public virtual void GradientSpecularModulationOff()
		{
			vtkVolumeProMapper.vtkVolumeProMapper_GradientSpecularModulationOff_79(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_GradientSpecularModulationOn_80(HandleRef pThis);

		public virtual void GradientSpecularModulationOn()
		{
			vtkVolumeProMapper.vtkVolumeProMapper_GradientSpecularModulationOn_80(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_IntermixIntersectingGeometryOff_81(HandleRef pThis);

		public virtual void IntermixIntersectingGeometryOff()
		{
			vtkVolumeProMapper.vtkVolumeProMapper_IntermixIntersectingGeometryOff_81(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_IntermixIntersectingGeometryOn_82(HandleRef pThis);

		public virtual void IntermixIntersectingGeometryOn()
		{
			vtkVolumeProMapper.vtkVolumeProMapper_IntermixIntersectingGeometryOn_82(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_IsA_83(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_IsA_83(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProMapper_IsTypeOf_84(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkVolumeProMapper.vtkVolumeProMapper_IsTypeOf_84(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeProMapper_NewInstance_86(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkVolumeProMapper NewInstance()
		{
			vtkVolumeProMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeProMapper.vtkVolumeProMapper_NewInstance_86(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeProMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_Render_87(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		public override void Render(vtkRenderer arg0, vtkVolume arg1)
		{
			vtkVolumeProMapper.vtkVolumeProMapper_Render_87(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeProMapper_SafeDownCast_88(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVolumeProMapper SafeDownCast(vtkObjectBase o)
		{
			vtkVolumeProMapper vtkVolumeProMapper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeProMapper.vtkVolumeProMapper_SafeDownCast_88((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolumeProMapper = (vtkVolumeProMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolumeProMapper.Register(null);
				}
			}
			return vtkVolumeProMapper;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_SetAutoAdjustMipmapLevels_89(HandleRef pThis, int _arg);

		public virtual void SetAutoAdjustMipmapLevels(int _arg)
		{
			vtkVolumeProMapper.vtkVolumeProMapper_SetAutoAdjustMipmapLevels_89(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_SetBlendMode_90(HandleRef pThis, int _arg);

		public override void SetBlendMode(int _arg)
		{
			vtkVolumeProMapper.vtkVolumeProMapper_SetBlendMode_90(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_SetBlendModeToComposite_91(HandleRef pThis);

		public new void SetBlendModeToComposite()
		{
			vtkVolumeProMapper.vtkVolumeProMapper_SetBlendModeToComposite_91(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_SetBlendModeToMaximumIntensity_92(HandleRef pThis);

		public new void SetBlendModeToMaximumIntensity()
		{
			vtkVolumeProMapper.vtkVolumeProMapper_SetBlendModeToMaximumIntensity_92(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_SetBlendModeToMinimumIntensity_93(HandleRef pThis);

		public new void SetBlendModeToMinimumIntensity()
		{
			vtkVolumeProMapper.vtkVolumeProMapper_SetBlendModeToMinimumIntensity_93(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_SetCursor_94(HandleRef pThis, int _arg);

		public virtual void SetCursor(int _arg)
		{
			vtkVolumeProMapper.vtkVolumeProMapper_SetCursor_94(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_SetCursorPosition_95(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetCursorPosition(double _arg1, double _arg2, double _arg3)
		{
			vtkVolumeProMapper.vtkVolumeProMapper_SetCursorPosition_95(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_SetCursorPosition_96(HandleRef pThis, IntPtr _arg);

		public virtual void SetCursorPosition(IntPtr _arg)
		{
			vtkVolumeProMapper.vtkVolumeProMapper_SetCursorPosition_96(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_SetCursorType_97(HandleRef pThis, int _arg);

		public virtual void SetCursorType(int _arg)
		{
			vtkVolumeProMapper.vtkVolumeProMapper_SetCursorType_97(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_SetCursorTypeToCrossHair_98(HandleRef pThis);

		public void SetCursorTypeToCrossHair()
		{
			vtkVolumeProMapper.vtkVolumeProMapper_SetCursorTypeToCrossHair_98(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_SetCursorTypeToPlane_99(HandleRef pThis);

		public void SetCursorTypeToPlane()
		{
			vtkVolumeProMapper.vtkVolumeProMapper_SetCursorTypeToPlane_99(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_SetCursorXAxisColor_100(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetCursorXAxisColor(double _arg1, double _arg2, double _arg3)
		{
			vtkVolumeProMapper.vtkVolumeProMapper_SetCursorXAxisColor_100(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_SetCursorXAxisColor_101(HandleRef pThis, IntPtr _arg);

		public virtual void SetCursorXAxisColor(IntPtr _arg)
		{
			vtkVolumeProMapper.vtkVolumeProMapper_SetCursorXAxisColor_101(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_SetCursorYAxisColor_102(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetCursorYAxisColor(double _arg1, double _arg2, double _arg3)
		{
			vtkVolumeProMapper.vtkVolumeProMapper_SetCursorYAxisColor_102(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_SetCursorYAxisColor_103(HandleRef pThis, IntPtr _arg);

		public virtual void SetCursorYAxisColor(IntPtr _arg)
		{
			vtkVolumeProMapper.vtkVolumeProMapper_SetCursorYAxisColor_103(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_SetCursorZAxisColor_104(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetCursorZAxisColor(double _arg1, double _arg2, double _arg3)
		{
			vtkVolumeProMapper.vtkVolumeProMapper_SetCursorZAxisColor_104(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_SetCursorZAxisColor_105(HandleRef pThis, IntPtr _arg);

		public virtual void SetCursorZAxisColor(IntPtr _arg)
		{
			vtkVolumeProMapper.vtkVolumeProMapper_SetCursorZAxisColor_105(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_SetCutPlane_106(HandleRef pThis, int _arg);

		public virtual void SetCutPlane(int _arg)
		{
			vtkVolumeProMapper.vtkVolumeProMapper_SetCutPlane_106(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_SetCutPlaneEquation_107(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

		public virtual void SetCutPlaneEquation(double _arg1, double _arg2, double _arg3, double _arg4)
		{
			vtkVolumeProMapper.vtkVolumeProMapper_SetCutPlaneEquation_107(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_SetCutPlaneEquation_108(HandleRef pThis, IntPtr _arg);

		public virtual void SetCutPlaneEquation(IntPtr _arg)
		{
			vtkVolumeProMapper.vtkVolumeProMapper_SetCutPlaneEquation_108(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_SetCutPlaneFallOffDistance_109(HandleRef pThis, int _arg);

		public virtual void SetCutPlaneFallOffDistance(int _arg)
		{
			vtkVolumeProMapper.vtkVolumeProMapper_SetCutPlaneFallOffDistance_109(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_SetCutPlaneThickness_110(HandleRef pThis, double _arg);

		public virtual void SetCutPlaneThickness(double _arg)
		{
			vtkVolumeProMapper.vtkVolumeProMapper_SetCutPlaneThickness_110(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_SetGradientDiffuseModulation_111(HandleRef pThis, int _arg);

		public virtual void SetGradientDiffuseModulation(int _arg)
		{
			vtkVolumeProMapper.vtkVolumeProMapper_SetGradientDiffuseModulation_111(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_SetGradientOpacityModulation_112(HandleRef pThis, int _arg);

		public virtual void SetGradientOpacityModulation(int _arg)
		{
			vtkVolumeProMapper.vtkVolumeProMapper_SetGradientOpacityModulation_112(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_SetGradientSpecularModulation_113(HandleRef pThis, int _arg);

		public virtual void SetGradientSpecularModulation(int _arg)
		{
			vtkVolumeProMapper.vtkVolumeProMapper_SetGradientSpecularModulation_113(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_SetIntermixIntersectingGeometry_114(HandleRef pThis, int _arg);

		public virtual void SetIntermixIntersectingGeometry(int _arg)
		{
			vtkVolumeProMapper.vtkVolumeProMapper_SetIntermixIntersectingGeometry_114(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_SetMaximumMipmapLevel_115(HandleRef pThis, int _arg);

		public virtual void SetMaximumMipmapLevel(int _arg)
		{
			vtkVolumeProMapper.vtkVolumeProMapper_SetMaximumMipmapLevel_115(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_SetMinimumMipmapLevel_116(HandleRef pThis, int _arg);

		public virtual void SetMinimumMipmapLevel(int _arg)
		{
			vtkVolumeProMapper.vtkVolumeProMapper_SetMinimumMipmapLevel_116(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_SetMipmapLevel_117(HandleRef pThis, int _arg);

		public virtual void SetMipmapLevel(int _arg)
		{
			vtkVolumeProMapper.vtkVolumeProMapper_SetMipmapLevel_117(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_SetSubVolume_118(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		public virtual void SetSubVolume(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkVolumeProMapper.vtkVolumeProMapper_SetSubVolume_118(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_SetSubVolume_119(HandleRef pThis, IntPtr _arg);

		public virtual void SetSubVolume(IntPtr _arg)
		{
			vtkVolumeProMapper.vtkVolumeProMapper_SetSubVolume_119(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_SetSuperSampling_120(HandleRef pThis, int _arg);

		public virtual void SetSuperSampling(int _arg)
		{
			vtkVolumeProMapper.vtkVolumeProMapper_SetSuperSampling_120(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_SetSuperSamplingFactor_121(HandleRef pThis, double x, double y, double z);

		public virtual void SetSuperSamplingFactor(double x, double y, double z)
		{
			vtkVolumeProMapper.vtkVolumeProMapper_SetSuperSamplingFactor_121(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_SetSuperSamplingFactor_122(HandleRef pThis, IntPtr f);

		public void SetSuperSamplingFactor(IntPtr f)
		{
			vtkVolumeProMapper.vtkVolumeProMapper_SetSuperSamplingFactor_122(base.GetCppThis(), f);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_SuperSamplingOff_123(HandleRef pThis);

		public virtual void SuperSamplingOff()
		{
			vtkVolumeProMapper.vtkVolumeProMapper_SuperSamplingOff_123(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProMapper_SuperSamplingOn_124(HandleRef pThis);

		public virtual void SuperSamplingOn()
		{
			vtkVolumeProMapper.vtkVolumeProMapper_SuperSamplingOn_124(base.GetCppThis());
		}
	}
}
