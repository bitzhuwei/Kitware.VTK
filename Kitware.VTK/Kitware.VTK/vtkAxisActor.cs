using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkAxisActor : vtkActor
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkAxisActor";

		public new static readonly string MRClassNameKey;

		static vtkAxisActor()
		{
			vtkAxisActor.MRClassNameKey = "class vtkAxisActor";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAxisActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAxisActor"));
		}

		public vtkAxisActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAxisActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAxisActor New()
		{
			vtkAxisActor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxisActor.vtkAxisActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAxisActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkAxisActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkAxisActor.vtkAxisActor_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_AxisVisibilityOff_01(HandleRef pThis);

		public virtual void AxisVisibilityOff()
		{
			vtkAxisActor.vtkAxisActor_AxisVisibilityOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_AxisVisibilityOn_02(HandleRef pThis);

		public virtual void AxisVisibilityOn()
		{
			vtkAxisActor.vtkAxisActor_AxisVisibilityOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_BuildAxis_03(HandleRef pThis, HandleRef viewport, byte arg1);

		public void BuildAxis(vtkViewport viewport, bool arg1)
		{
			vtkAxisActor.vtkAxisActor_BuildAxis_03(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis(), arg1 ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkAxisActor_ComputeMaxLabelLength_04(HandleRef pThis, IntPtr arg0);

		public double ComputeMaxLabelLength(IntPtr arg0)
		{
			return vtkAxisActor.vtkAxisActor_ComputeMaxLabelLength_04(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkAxisActor_ComputeTitleLength_05(HandleRef pThis, IntPtr arg0);

		public double ComputeTitleLength(IntPtr arg0)
		{
			return vtkAxisActor.vtkAxisActor_ComputeTitleLength_05(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_DrawGridlinesOff_06(HandleRef pThis);

		public virtual void DrawGridlinesOff()
		{
			vtkAxisActor.vtkAxisActor_DrawGridlinesOff_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_DrawGridlinesOn_07(HandleRef pThis);

		public virtual void DrawGridlinesOn()
		{
			vtkAxisActor.vtkAxisActor_DrawGridlinesOn_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkAxisActor_GetAxisPosition_08(HandleRef pThis);

		public virtual int GetAxisPosition()
		{
			return vtkAxisActor.vtkAxisActor_GetAxisPosition_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkAxisActor_GetAxisPositionMaxValue_09(HandleRef pThis);

		public virtual int GetAxisPositionMaxValue()
		{
			return vtkAxisActor.vtkAxisActor_GetAxisPositionMaxValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkAxisActor_GetAxisPositionMinValue_10(HandleRef pThis);

		public virtual int GetAxisPositionMinValue()
		{
			return vtkAxisActor.vtkAxisActor_GetAxisPositionMinValue_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkAxisActor_GetAxisType_11(HandleRef pThis);

		public virtual int GetAxisType()
		{
			return vtkAxisActor.vtkAxisActor_GetAxisType_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkAxisActor_GetAxisTypeMaxValue_12(HandleRef pThis);

		public virtual int GetAxisTypeMaxValue()
		{
			return vtkAxisActor.vtkAxisActor_GetAxisTypeMaxValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkAxisActor_GetAxisTypeMinValue_13(HandleRef pThis);

		public virtual int GetAxisTypeMinValue()
		{
			return vtkAxisActor.vtkAxisActor_GetAxisTypeMinValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkAxisActor_GetAxisVisibility_14(HandleRef pThis);

		public virtual int GetAxisVisibility()
		{
			return vtkAxisActor.vtkAxisActor_GetAxisVisibility_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAxisActor_GetBounds_15(HandleRef pThis);

		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkAxisActor.vtkAxisActor_GetBounds_15(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_GetBounds_16(HandleRef pThis, IntPtr bounds);

		public new void GetBounds(IntPtr bounds)
		{
			vtkAxisActor.vtkAxisActor_GetBounds_16(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAxisActor_GetCamera_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCamera GetCamera()
		{
			vtkCamera vtkCamera = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxisActor.vtkAxisActor_GetCamera_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCamera = (vtkCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCamera.Register(null);
				}
			}
			return vtkCamera;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkAxisActor_GetDeltaMajor_18(HandleRef pThis);

		public virtual double GetDeltaMajor()
		{
			return vtkAxisActor.vtkAxisActor_GetDeltaMajor_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkAxisActor_GetDeltaMinor_19(HandleRef pThis);

		public virtual double GetDeltaMinor()
		{
			return vtkAxisActor.vtkAxisActor_GetDeltaMinor_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkAxisActor_GetDeltaRangeMajor_20(HandleRef pThis);

		public virtual double GetDeltaRangeMajor()
		{
			return vtkAxisActor.vtkAxisActor_GetDeltaRangeMajor_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkAxisActor_GetDeltaRangeMinor_21(HandleRef pThis);

		public virtual double GetDeltaRangeMinor()
		{
			return vtkAxisActor.vtkAxisActor_GetDeltaRangeMinor_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkAxisActor_GetDrawGridlines_22(HandleRef pThis);

		public virtual int GetDrawGridlines()
		{
			return vtkAxisActor.vtkAxisActor_GetDrawGridlines_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkAxisActor_GetGridlineXLength_23(HandleRef pThis);

		public virtual double GetGridlineXLength()
		{
			return vtkAxisActor.vtkAxisActor_GetGridlineXLength_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkAxisActor_GetGridlineYLength_24(HandleRef pThis);

		public virtual double GetGridlineYLength()
		{
			return vtkAxisActor.vtkAxisActor_GetGridlineYLength_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkAxisActor_GetGridlineZLength_25(HandleRef pThis);

		public virtual double GetGridlineZLength()
		{
			return vtkAxisActor.vtkAxisActor_GetGridlineZLength_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAxisActor_GetLabelFormat_26(HandleRef pThis);

		public virtual string GetLabelFormat()
		{
			return Marshal.PtrToStringAnsi(vtkAxisActor.vtkAxisActor_GetLabelFormat_26(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkAxisActor_GetLabelVisibility_27(HandleRef pThis);

		public virtual int GetLabelVisibility()
		{
			return vtkAxisActor.vtkAxisActor_GetLabelVisibility_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkAxisActor_GetMajorRangeStart_28(HandleRef pThis);

		public virtual double GetMajorRangeStart()
		{
			return vtkAxisActor.vtkAxisActor_GetMajorRangeStart_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkAxisActor_GetMajorStart_29(HandleRef pThis);

		public virtual double GetMajorStart()
		{
			return vtkAxisActor.vtkAxisActor_GetMajorStart_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkAxisActor_GetMajorTickSize_30(HandleRef pThis);

		public virtual double GetMajorTickSize()
		{
			return vtkAxisActor.vtkAxisActor_GetMajorTickSize_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkAxisActor_GetMinorRangeStart_31(HandleRef pThis);

		public virtual double GetMinorRangeStart()
		{
			return vtkAxisActor.vtkAxisActor_GetMinorRangeStart_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkAxisActor_GetMinorStart_32(HandleRef pThis);

		public virtual double GetMinorStart()
		{
			return vtkAxisActor.vtkAxisActor_GetMinorStart_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkAxisActor_GetMinorTickSize_33(HandleRef pThis);

		public virtual double GetMinorTickSize()
		{
			return vtkAxisActor.vtkAxisActor_GetMinorTickSize_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkAxisActor_GetMinorTicksVisible_34(HandleRef pThis);

		public virtual int GetMinorTicksVisible()
		{
			return vtkAxisActor.vtkAxisActor_GetMinorTicksVisible_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAxisActor_GetPoint1_35(HandleRef pThis);

		public virtual IntPtr GetPoint1()
		{
			return vtkAxisActor.vtkAxisActor_GetPoint1_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAxisActor_GetPoint1Coordinate_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCoordinate GetPoint1Coordinate()
		{
			vtkCoordinate vtkCoordinate = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxisActor.vtkAxisActor_GetPoint1Coordinate_36(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCoordinate = (vtkCoordinate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCoordinate.Register(null);
				}
			}
			return vtkCoordinate;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAxisActor_GetPoint2_37(HandleRef pThis);

		public virtual IntPtr GetPoint2()
		{
			return vtkAxisActor.vtkAxisActor_GetPoint2_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAxisActor_GetPoint2Coordinate_38(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCoordinate GetPoint2Coordinate()
		{
			vtkCoordinate vtkCoordinate = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxisActor.vtkAxisActor_GetPoint2Coordinate_38(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCoordinate = (vtkCoordinate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCoordinate.Register(null);
				}
			}
			return vtkCoordinate;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAxisActor_GetRange_39(HandleRef pThis);

		public virtual double[] GetRange()
		{
			IntPtr intPtr = vtkAxisActor.vtkAxisActor_GetRange_39(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_GetRange_40(HandleRef pThis, IntPtr data);

		public virtual void GetRange(IntPtr data)
		{
			vtkAxisActor.vtkAxisActor_GetRange_40(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkAxisActor_GetTickLocation_41(HandleRef pThis);

		public virtual int GetTickLocation()
		{
			return vtkAxisActor.vtkAxisActor_GetTickLocation_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkAxisActor_GetTickLocationMaxValue_42(HandleRef pThis);

		public virtual int GetTickLocationMaxValue()
		{
			return vtkAxisActor.vtkAxisActor_GetTickLocationMaxValue_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkAxisActor_GetTickLocationMinValue_43(HandleRef pThis);

		public virtual int GetTickLocationMinValue()
		{
			return vtkAxisActor.vtkAxisActor_GetTickLocationMinValue_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkAxisActor_GetTickVisibility_44(HandleRef pThis);

		public virtual int GetTickVisibility()
		{
			return vtkAxisActor.vtkAxisActor_GetTickVisibility_44(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAxisActor_GetTitle_45(HandleRef pThis);

		public virtual string GetTitle()
		{
			return Marshal.PtrToStringAnsi(vtkAxisActor.vtkAxisActor_GetTitle_45(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkAxisActor_GetTitleVisibility_46(HandleRef pThis);

		public virtual int GetTitleVisibility()
		{
			return vtkAxisActor.vtkAxisActor_GetTitleVisibility_46(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkAxisActor_IsA_47(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAxisActor.vtkAxisActor_IsA_47(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkAxisActor_IsTypeOf_48(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAxisActor.vtkAxisActor_IsTypeOf_48(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_LabelVisibilityOff_49(HandleRef pThis);

		public virtual void LabelVisibilityOff()
		{
			vtkAxisActor.vtkAxisActor_LabelVisibilityOff_49(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_LabelVisibilityOn_50(HandleRef pThis);

		public virtual void LabelVisibilityOn()
		{
			vtkAxisActor.vtkAxisActor_LabelVisibilityOn_50(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_MinorTicksVisibleOff_51(HandleRef pThis);

		public virtual void MinorTicksVisibleOff()
		{
			vtkAxisActor.vtkAxisActor_MinorTicksVisibleOff_51(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_MinorTicksVisibleOn_52(HandleRef pThis);

		public virtual void MinorTicksVisibleOn()
		{
			vtkAxisActor.vtkAxisActor_MinorTicksVisibleOn_52(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAxisActor_NewInstance_54(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAxisActor NewInstance()
		{
			vtkAxisActor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxisActor.vtkAxisActor_NewInstance_54(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAxisActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_ReleaseGraphicsResources_55(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkAxisActor.vtkAxisActor_ReleaseGraphicsResources_55(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkAxisActor_RenderOpaqueGeometry_56(HandleRef pThis, HandleRef viewport);

		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkAxisActor.vtkAxisActor_RenderOpaqueGeometry_56(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkAxisActor_RenderTranslucentGeometry_57(HandleRef pThis, HandleRef arg0);

		public virtual int RenderTranslucentGeometry(vtkViewport arg0)
		{
			return vtkAxisActor.vtkAxisActor_RenderTranslucentGeometry_57(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkAxisActor_SafeDownCast_58(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAxisActor SafeDownCast(vtkObjectBase o)
		{
			vtkAxisActor vtkAxisActor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxisActor.vtkAxisActor_SafeDownCast_58((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAxisActor = (vtkAxisActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAxisActor.Register(null);
				}
			}
			return vtkAxisActor;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_SetAxisPosition_59(HandleRef pThis, int _arg);

		public virtual void SetAxisPosition(int _arg)
		{
			vtkAxisActor.vtkAxisActor_SetAxisPosition_59(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_SetAxisPositionToMaxMax_60(HandleRef pThis);

		public void SetAxisPositionToMaxMax()
		{
			vtkAxisActor.vtkAxisActor_SetAxisPositionToMaxMax_60(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_SetAxisPositionToMaxMin_61(HandleRef pThis);

		public void SetAxisPositionToMaxMin()
		{
			vtkAxisActor.vtkAxisActor_SetAxisPositionToMaxMin_61(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_SetAxisPositionToMinMax_62(HandleRef pThis);

		public void SetAxisPositionToMinMax()
		{
			vtkAxisActor.vtkAxisActor_SetAxisPositionToMinMax_62(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_SetAxisPositionToMinMin_63(HandleRef pThis);

		public void SetAxisPositionToMinMin()
		{
			vtkAxisActor.vtkAxisActor_SetAxisPositionToMinMin_63(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_SetAxisType_64(HandleRef pThis, int _arg);

		public virtual void SetAxisType(int _arg)
		{
			vtkAxisActor.vtkAxisActor_SetAxisType_64(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_SetAxisTypeToX_65(HandleRef pThis);

		public void SetAxisTypeToX()
		{
			vtkAxisActor.vtkAxisActor_SetAxisTypeToX_65(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_SetAxisTypeToY_66(HandleRef pThis);

		public void SetAxisTypeToY()
		{
			vtkAxisActor.vtkAxisActor_SetAxisTypeToY_66(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_SetAxisTypeToZ_67(HandleRef pThis);

		public void SetAxisTypeToZ()
		{
			vtkAxisActor.vtkAxisActor_SetAxisTypeToZ_67(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_SetAxisVisibility_68(HandleRef pThis, int _arg);

		public virtual void SetAxisVisibility(int _arg)
		{
			vtkAxisActor.vtkAxisActor_SetAxisVisibility_68(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_SetBounds_69(HandleRef pThis, IntPtr bounds);

		public void SetBounds(IntPtr bounds)
		{
			vtkAxisActor.vtkAxisActor_SetBounds_69(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_SetBounds_70(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

		public void SetBounds(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
		{
			vtkAxisActor.vtkAxisActor_SetBounds_70(base.GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_SetCamera_71(HandleRef pThis, HandleRef arg0);

		public virtual void SetCamera(vtkCamera arg0)
		{
			vtkAxisActor.vtkAxisActor_SetCamera_71(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_SetDeltaMajor_72(HandleRef pThis, double _arg);

		public virtual void SetDeltaMajor(double _arg)
		{
			vtkAxisActor.vtkAxisActor_SetDeltaMajor_72(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_SetDeltaMinor_73(HandleRef pThis, double _arg);

		public virtual void SetDeltaMinor(double _arg)
		{
			vtkAxisActor.vtkAxisActor_SetDeltaMinor_73(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_SetDeltaRangeMajor_74(HandleRef pThis, double _arg);

		public virtual void SetDeltaRangeMajor(double _arg)
		{
			vtkAxisActor.vtkAxisActor_SetDeltaRangeMajor_74(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_SetDeltaRangeMinor_75(HandleRef pThis, double _arg);

		public virtual void SetDeltaRangeMinor(double _arg)
		{
			vtkAxisActor.vtkAxisActor_SetDeltaRangeMinor_75(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_SetDrawGridlines_76(HandleRef pThis, int _arg);

		public virtual void SetDrawGridlines(int _arg)
		{
			vtkAxisActor.vtkAxisActor_SetDrawGridlines_76(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_SetGridlineXLength_77(HandleRef pThis, double _arg);

		public virtual void SetGridlineXLength(double _arg)
		{
			vtkAxisActor.vtkAxisActor_SetGridlineXLength_77(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_SetGridlineYLength_78(HandleRef pThis, double _arg);

		public virtual void SetGridlineYLength(double _arg)
		{
			vtkAxisActor.vtkAxisActor_SetGridlineYLength_78(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_SetGridlineZLength_79(HandleRef pThis, double _arg);

		public virtual void SetGridlineZLength(double _arg)
		{
			vtkAxisActor.vtkAxisActor_SetGridlineZLength_79(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_SetLabelFormat_80(HandleRef pThis, string _arg);

		public virtual void SetLabelFormat(string _arg)
		{
			vtkAxisActor.vtkAxisActor_SetLabelFormat_80(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_SetLabelScale_81(HandleRef pThis, double arg0);

		public void SetLabelScale(double arg0)
		{
			vtkAxisActor.vtkAxisActor_SetLabelScale_81(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_SetLabelVisibility_82(HandleRef pThis, int _arg);

		public virtual void SetLabelVisibility(int _arg)
		{
			vtkAxisActor.vtkAxisActor_SetLabelVisibility_82(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_SetLabels_83(HandleRef pThis, HandleRef labels);

		public void SetLabels(vtkStringArray labels)
		{
			vtkAxisActor.vtkAxisActor_SetLabels_83(base.GetCppThis(), (labels == null) ? default(HandleRef) : labels.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_SetMajorRangeStart_84(HandleRef pThis, double _arg);

		public virtual void SetMajorRangeStart(double _arg)
		{
			vtkAxisActor.vtkAxisActor_SetMajorRangeStart_84(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_SetMajorStart_85(HandleRef pThis, double _arg);

		public virtual void SetMajorStart(double _arg)
		{
			vtkAxisActor.vtkAxisActor_SetMajorStart_85(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_SetMajorTickSize_86(HandleRef pThis, double _arg);

		public virtual void SetMajorTickSize(double _arg)
		{
			vtkAxisActor.vtkAxisActor_SetMajorTickSize_86(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_SetMinorRangeStart_87(HandleRef pThis, double _arg);

		public virtual void SetMinorRangeStart(double _arg)
		{
			vtkAxisActor.vtkAxisActor_SetMinorRangeStart_87(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_SetMinorStart_88(HandleRef pThis, double _arg);

		public virtual void SetMinorStart(double _arg)
		{
			vtkAxisActor.vtkAxisActor_SetMinorStart_88(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_SetMinorTickSize_89(HandleRef pThis, double _arg);

		public virtual void SetMinorTickSize(double _arg)
		{
			vtkAxisActor.vtkAxisActor_SetMinorTickSize_89(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_SetMinorTicksVisible_90(HandleRef pThis, int _arg);

		public virtual void SetMinorTicksVisible(int _arg)
		{
			vtkAxisActor.vtkAxisActor_SetMinorTicksVisible_90(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_SetPoint1_91(HandleRef pThis, IntPtr x);

		public virtual void SetPoint1(IntPtr x)
		{
			vtkAxisActor.vtkAxisActor_SetPoint1_91(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_SetPoint1_92(HandleRef pThis, double x, double y, double z);

		public virtual void SetPoint1(double x, double y, double z)
		{
			vtkAxisActor.vtkAxisActor_SetPoint1_92(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_SetPoint2_93(HandleRef pThis, IntPtr x);

		public virtual void SetPoint2(IntPtr x)
		{
			vtkAxisActor.vtkAxisActor_SetPoint2_93(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_SetPoint2_94(HandleRef pThis, double x, double y, double z);

		public virtual void SetPoint2(double x, double y, double z)
		{
			vtkAxisActor.vtkAxisActor_SetPoint2_94(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_SetRange_95(HandleRef pThis, double _arg1, double _arg2);

		public virtual void SetRange(double _arg1, double _arg2)
		{
			vtkAxisActor.vtkAxisActor_SetRange_95(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_SetRange_96(HandleRef pThis, IntPtr _arg);

		public void SetRange(IntPtr _arg)
		{
			vtkAxisActor.vtkAxisActor_SetRange_96(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_SetTickLocation_97(HandleRef pThis, int _arg);

		public virtual void SetTickLocation(int _arg)
		{
			vtkAxisActor.vtkAxisActor_SetTickLocation_97(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_SetTickLocationToBoth_98(HandleRef pThis);

		public void SetTickLocationToBoth()
		{
			vtkAxisActor.vtkAxisActor_SetTickLocationToBoth_98(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_SetTickLocationToInside_99(HandleRef pThis);

		public void SetTickLocationToInside()
		{
			vtkAxisActor.vtkAxisActor_SetTickLocationToInside_99(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_SetTickLocationToOutside_100(HandleRef pThis);

		public void SetTickLocationToOutside()
		{
			vtkAxisActor.vtkAxisActor_SetTickLocationToOutside_100(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_SetTickVisibility_101(HandleRef pThis, int _arg);

		public virtual void SetTickVisibility(int _arg)
		{
			vtkAxisActor.vtkAxisActor_SetTickVisibility_101(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_SetTitle_102(HandleRef pThis, string t);

		public void SetTitle(string t)
		{
			vtkAxisActor.vtkAxisActor_SetTitle_102(base.GetCppThis(), t);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_SetTitleScale_103(HandleRef pThis, double arg0);

		public void SetTitleScale(double arg0)
		{
			vtkAxisActor.vtkAxisActor_SetTitleScale_103(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_SetTitleVisibility_104(HandleRef pThis, int _arg);

		public virtual void SetTitleVisibility(int _arg)
		{
			vtkAxisActor.vtkAxisActor_SetTitleVisibility_104(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_ShallowCopy_105(HandleRef pThis, HandleRef prop);

		public override void ShallowCopy(vtkProp prop)
		{
			vtkAxisActor.vtkAxisActor_ShallowCopy_105(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_TickVisibilityOff_106(HandleRef pThis);

		public virtual void TickVisibilityOff()
		{
			vtkAxisActor.vtkAxisActor_TickVisibilityOff_106(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_TickVisibilityOn_107(HandleRef pThis);

		public virtual void TickVisibilityOn()
		{
			vtkAxisActor.vtkAxisActor_TickVisibilityOn_107(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_TitleVisibilityOff_108(HandleRef pThis);

		public virtual void TitleVisibilityOff()
		{
			vtkAxisActor.vtkAxisActor_TitleVisibilityOff_108(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkAxisActor_TitleVisibilityOn_109(HandleRef pThis);

		public virtual void TitleVisibilityOn()
		{
			vtkAxisActor.vtkAxisActor_TitleVisibilityOn_109(base.GetCppThis());
		}
	}
}
