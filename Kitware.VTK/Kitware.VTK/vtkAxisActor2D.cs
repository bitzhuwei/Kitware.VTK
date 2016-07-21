using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkAxisActor2D : vtkActor2D
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkAxisActor2D";

		public new static readonly string MRClassNameKey;

		static vtkAxisActor2D()
		{
			vtkAxisActor2D.MRClassNameKey = "class vtkAxisActor2D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAxisActor2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAxisActor2D"));
		}

		public vtkAxisActor2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkAxisActor2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAxisActor2D New()
		{
			vtkAxisActor2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxisActor2D.vtkAxisActor2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAxisActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkAxisActor2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkAxisActor2D.vtkAxisActor2D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAxisActor2D_AdjustLabelsOff_01(HandleRef pThis);

		public virtual void AdjustLabelsOff()
		{
			vtkAxisActor2D.vtkAxisActor2D_AdjustLabelsOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAxisActor2D_AdjustLabelsOn_02(HandleRef pThis);

		public virtual void AdjustLabelsOn()
		{
			vtkAxisActor2D.vtkAxisActor2D_AdjustLabelsOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAxisActor2D_AxisVisibilityOff_03(HandleRef pThis);

		public virtual void AxisVisibilityOff()
		{
			vtkAxisActor2D.vtkAxisActor2D_AxisVisibilityOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAxisActor2D_AxisVisibilityOn_04(HandleRef pThis);

		public virtual void AxisVisibilityOn()
		{
			vtkAxisActor2D.vtkAxisActor2D_AxisVisibilityOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAxisActor2D_ComputeRange_05(IntPtr inRange, IntPtr outRange, int inNumTicks, ref int outNumTicks, ref double interval);

		public static void ComputeRange(IntPtr inRange, IntPtr outRange, int inNumTicks, ref int outNumTicks, ref double interval)
		{
			vtkAxisActor2D.vtkAxisActor2D_ComputeRange_05(inRange, outRange, inNumTicks, ref outNumTicks, ref interval);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAxisActor2D_GetAdjustLabels_06(HandleRef pThis);

		public virtual int GetAdjustLabels()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetAdjustLabels_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAxisActor2D_GetAdjustedNumberOfLabels_07(HandleRef pThis);

		public virtual int GetAdjustedNumberOfLabels()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetAdjustedNumberOfLabels_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkAxisActor2D_GetAdjustedRange_08(HandleRef pThis);

		public virtual IntPtr GetAdjustedRange()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetAdjustedRange_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAxisActor2D_GetAdjustedRange_09(HandleRef pThis, ref double _arg1, ref double _arg2);

		public virtual void GetAdjustedRange(ref double _arg1, ref double _arg2)
		{
			vtkAxisActor2D.vtkAxisActor2D_GetAdjustedRange_09(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAxisActor2D_GetAdjustedRange_10(HandleRef pThis, IntPtr _arg);

		public virtual void GetAdjustedRange(IntPtr _arg)
		{
			vtkAxisActor2D.vtkAxisActor2D_GetAdjustedRange_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAxisActor2D_GetAxisVisibility_11(HandleRef pThis);

		public virtual int GetAxisVisibility()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetAxisVisibility_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkAxisActor2D_GetFontFactor_12(HandleRef pThis);

		public virtual double GetFontFactor()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetFontFactor_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkAxisActor2D_GetFontFactorMaxValue_13(HandleRef pThis);

		public virtual double GetFontFactorMaxValue()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetFontFactorMaxValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkAxisActor2D_GetFontFactorMinValue_14(HandleRef pThis);

		public virtual double GetFontFactorMinValue()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetFontFactorMinValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkAxisActor2D_GetLabelFactor_15(HandleRef pThis);

		public virtual double GetLabelFactor()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetLabelFactor_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkAxisActor2D_GetLabelFactorMaxValue_16(HandleRef pThis);

		public virtual double GetLabelFactorMaxValue()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetLabelFactorMaxValue_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkAxisActor2D_GetLabelFactorMinValue_17(HandleRef pThis);

		public virtual double GetLabelFactorMinValue()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetLabelFactorMinValue_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkAxisActor2D_GetLabelFormat_18(HandleRef pThis);

		public virtual string GetLabelFormat()
		{
			return Marshal.PtrToStringAnsi(vtkAxisActor2D.vtkAxisActor2D_GetLabelFormat_18(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkAxisActor2D_GetLabelTextProperty_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetLabelTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxisActor2D.vtkAxisActor2D_GetLabelTextProperty_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAxisActor2D_GetLabelVisibility_20(HandleRef pThis);

		public virtual int GetLabelVisibility()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetLabelVisibility_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAxisActor2D_GetMinorTickLength_21(HandleRef pThis);

		public virtual int GetMinorTickLength()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetMinorTickLength_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAxisActor2D_GetMinorTickLengthMaxValue_22(HandleRef pThis);

		public virtual int GetMinorTickLengthMaxValue()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetMinorTickLengthMaxValue_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAxisActor2D_GetMinorTickLengthMinValue_23(HandleRef pThis);

		public virtual int GetMinorTickLengthMinValue()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetMinorTickLengthMinValue_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAxisActor2D_GetNumberOfLabels_24(HandleRef pThis);

		public virtual int GetNumberOfLabels()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetNumberOfLabels_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAxisActor2D_GetNumberOfLabelsMaxValue_25(HandleRef pThis);

		public virtual int GetNumberOfLabelsMaxValue()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetNumberOfLabelsMaxValue_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAxisActor2D_GetNumberOfLabelsMinValue_26(HandleRef pThis);

		public virtual int GetNumberOfLabelsMinValue()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetNumberOfLabelsMinValue_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAxisActor2D_GetNumberOfMinorTicks_27(HandleRef pThis);

		public virtual int GetNumberOfMinorTicks()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetNumberOfMinorTicks_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAxisActor2D_GetNumberOfMinorTicksMaxValue_28(HandleRef pThis);

		public virtual int GetNumberOfMinorTicksMaxValue()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetNumberOfMinorTicksMaxValue_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAxisActor2D_GetNumberOfMinorTicksMinValue_29(HandleRef pThis);

		public virtual int GetNumberOfMinorTicksMinValue()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetNumberOfMinorTicksMinValue_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkAxisActor2D_GetPoint1_30(HandleRef pThis);

		public virtual IntPtr GetPoint1()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetPoint1_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkAxisActor2D_GetPoint1Coordinate_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCoordinate GetPoint1Coordinate()
		{
			vtkCoordinate vtkCoordinate = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxisActor2D.vtkAxisActor2D_GetPoint1Coordinate_31(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkAxisActor2D_GetPoint2_32(HandleRef pThis);

		public virtual IntPtr GetPoint2()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetPoint2_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkAxisActor2D_GetPoint2Coordinate_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCoordinate GetPoint2Coordinate()
		{
			vtkCoordinate vtkCoordinate = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxisActor2D.vtkAxisActor2D_GetPoint2Coordinate_33(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkAxisActor2D_GetRange_34(HandleRef pThis);

		public virtual double[] GetRange()
		{
			IntPtr intPtr = vtkAxisActor2D.vtkAxisActor2D_GetRange_34(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAxisActor2D_GetRange_35(HandleRef pThis, IntPtr data);

		public virtual void GetRange(IntPtr data)
		{
			vtkAxisActor2D.vtkAxisActor2D_GetRange_35(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkAxisActor2D_GetRulerDistance_36(HandleRef pThis);

		public virtual double GetRulerDistance()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetRulerDistance_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkAxisActor2D_GetRulerDistanceMaxValue_37(HandleRef pThis);

		public virtual double GetRulerDistanceMaxValue()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetRulerDistanceMaxValue_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkAxisActor2D_GetRulerDistanceMinValue_38(HandleRef pThis);

		public virtual double GetRulerDistanceMinValue()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetRulerDistanceMinValue_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAxisActor2D_GetRulerMode_39(HandleRef pThis);

		public virtual int GetRulerMode()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetRulerMode_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAxisActor2D_GetSizeFontRelativeToAxis_40(HandleRef pThis);

		public virtual int GetSizeFontRelativeToAxis()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetSizeFontRelativeToAxis_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAxisActor2D_GetTickLength_41(HandleRef pThis);

		public virtual int GetTickLength()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetTickLength_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAxisActor2D_GetTickLengthMaxValue_42(HandleRef pThis);

		public virtual int GetTickLengthMaxValue()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetTickLengthMaxValue_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAxisActor2D_GetTickLengthMinValue_43(HandleRef pThis);

		public virtual int GetTickLengthMinValue()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetTickLengthMinValue_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAxisActor2D_GetTickOffset_44(HandleRef pThis);

		public virtual int GetTickOffset()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetTickOffset_44(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAxisActor2D_GetTickOffsetMaxValue_45(HandleRef pThis);

		public virtual int GetTickOffsetMaxValue()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetTickOffsetMaxValue_45(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAxisActor2D_GetTickOffsetMinValue_46(HandleRef pThis);

		public virtual int GetTickOffsetMinValue()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetTickOffsetMinValue_46(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAxisActor2D_GetTickVisibility_47(HandleRef pThis);

		public virtual int GetTickVisibility()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetTickVisibility_47(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkAxisActor2D_GetTitle_48(HandleRef pThis);

		public virtual string GetTitle()
		{
			return Marshal.PtrToStringAnsi(vtkAxisActor2D.vtkAxisActor2D_GetTitle_48(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkAxisActor2D_GetTitlePosition_49(HandleRef pThis);

		public virtual double GetTitlePosition()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetTitlePosition_49(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkAxisActor2D_GetTitleTextProperty_50(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetTitleTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxisActor2D.vtkAxisActor2D_GetTitleTextProperty_50(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAxisActor2D_GetTitleVisibility_51(HandleRef pThis);

		public virtual int GetTitleVisibility()
		{
			return vtkAxisActor2D.vtkAxisActor2D_GetTitleVisibility_51(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAxisActor2D_HasTranslucentPolygonalGeometry_52(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkAxisActor2D.vtkAxisActor2D_HasTranslucentPolygonalGeometry_52(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAxisActor2D_IsA_53(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAxisActor2D.vtkAxisActor2D_IsA_53(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAxisActor2D_IsTypeOf_54(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAxisActor2D.vtkAxisActor2D_IsTypeOf_54(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAxisActor2D_LabelVisibilityOff_55(HandleRef pThis);

		public virtual void LabelVisibilityOff()
		{
			vtkAxisActor2D.vtkAxisActor2D_LabelVisibilityOff_55(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAxisActor2D_LabelVisibilityOn_56(HandleRef pThis);

		public virtual void LabelVisibilityOn()
		{
			vtkAxisActor2D.vtkAxisActor2D_LabelVisibilityOn_56(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkAxisActor2D_NewInstance_58(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAxisActor2D NewInstance()
		{
			vtkAxisActor2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxisActor2D.vtkAxisActor2D_NewInstance_58(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAxisActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAxisActor2D_ReleaseGraphicsResources_59(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkAxisActor2D.vtkAxisActor2D_ReleaseGraphicsResources_59(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAxisActor2D_RenderOpaqueGeometry_60(HandleRef pThis, HandleRef viewport);

		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkAxisActor2D.vtkAxisActor2D_RenderOpaqueGeometry_60(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAxisActor2D_RenderOverlay_61(HandleRef pThis, HandleRef viewport);

		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkAxisActor2D.vtkAxisActor2D_RenderOverlay_61(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAxisActor2D_RenderTranslucentPolygonalGeometry_62(HandleRef pThis, HandleRef arg0);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkAxisActor2D.vtkAxisActor2D_RenderTranslucentPolygonalGeometry_62(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAxisActor2D_RulerModeOff_63(HandleRef pThis);

		public virtual void RulerModeOff()
		{
			vtkAxisActor2D.vtkAxisActor2D_RulerModeOff_63(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAxisActor2D_RulerModeOn_64(HandleRef pThis);

		public virtual void RulerModeOn()
		{
			vtkAxisActor2D.vtkAxisActor2D_RulerModeOn_64(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkAxisActor2D_SafeDownCast_65(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAxisActor2D SafeDownCast(vtkObjectBase o)
		{
			vtkAxisActor2D vtkAxisActor2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxisActor2D.vtkAxisActor2D_SafeDownCast_65((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAxisActor2D = (vtkAxisActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAxisActor2D.Register(null);
				}
			}
			return vtkAxisActor2D;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAxisActor2D_SetAdjustLabels_66(HandleRef pThis, int _arg);

		public virtual void SetAdjustLabels(int _arg)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetAdjustLabels_66(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAxisActor2D_SetAxisVisibility_67(HandleRef pThis, int _arg);

		public virtual void SetAxisVisibility(int _arg)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetAxisVisibility_67(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAxisActor2D_SetFontFactor_68(HandleRef pThis, double _arg);

		public virtual void SetFontFactor(double _arg)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetFontFactor_68(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAxisActor2D_SetLabelFactor_69(HandleRef pThis, double _arg);

		public virtual void SetLabelFactor(double _arg)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetLabelFactor_69(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAxisActor2D_SetLabelFormat_70(HandleRef pThis, string _arg);

		public virtual void SetLabelFormat(string _arg)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetLabelFormat_70(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAxisActor2D_SetLabelTextProperty_71(HandleRef pThis, HandleRef p);

		public virtual void SetLabelTextProperty(vtkTextProperty p)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetLabelTextProperty_71(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAxisActor2D_SetLabelVisibility_72(HandleRef pThis, int _arg);

		public virtual void SetLabelVisibility(int _arg)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetLabelVisibility_72(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAxisActor2D_SetMinorTickLength_73(HandleRef pThis, int _arg);

		public virtual void SetMinorTickLength(int _arg)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetMinorTickLength_73(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAxisActor2D_SetNumberOfLabels_74(HandleRef pThis, int _arg);

		public virtual void SetNumberOfLabels(int _arg)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetNumberOfLabels_74(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAxisActor2D_SetNumberOfMinorTicks_75(HandleRef pThis, int _arg);

		public virtual void SetNumberOfMinorTicks(int _arg)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetNumberOfMinorTicks_75(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAxisActor2D_SetPoint1_76(HandleRef pThis, IntPtr x);

		public virtual void SetPoint1(IntPtr x)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetPoint1_76(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAxisActor2D_SetPoint1_77(HandleRef pThis, double x, double y);

		public virtual void SetPoint1(double x, double y)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetPoint1_77(base.GetCppThis(), x, y);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAxisActor2D_SetPoint2_78(HandleRef pThis, IntPtr x);

		public virtual void SetPoint2(IntPtr x)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetPoint2_78(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAxisActor2D_SetPoint2_79(HandleRef pThis, double x, double y);

		public virtual void SetPoint2(double x, double y)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetPoint2_79(base.GetCppThis(), x, y);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAxisActor2D_SetRange_80(HandleRef pThis, double _arg1, double _arg2);

		public virtual void SetRange(double _arg1, double _arg2)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetRange_80(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAxisActor2D_SetRange_81(HandleRef pThis, IntPtr _arg);

		public void SetRange(IntPtr _arg)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetRange_81(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAxisActor2D_SetRulerDistance_82(HandleRef pThis, double _arg);

		public virtual void SetRulerDistance(double _arg)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetRulerDistance_82(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAxisActor2D_SetRulerMode_83(HandleRef pThis, int _arg);

		public virtual void SetRulerMode(int _arg)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetRulerMode_83(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAxisActor2D_SetSizeFontRelativeToAxis_84(HandleRef pThis, int _arg);

		public virtual void SetSizeFontRelativeToAxis(int _arg)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetSizeFontRelativeToAxis_84(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAxisActor2D_SetTickLength_85(HandleRef pThis, int _arg);

		public virtual void SetTickLength(int _arg)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetTickLength_85(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAxisActor2D_SetTickOffset_86(HandleRef pThis, int _arg);

		public virtual void SetTickOffset(int _arg)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetTickOffset_86(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAxisActor2D_SetTickVisibility_87(HandleRef pThis, int _arg);

		public virtual void SetTickVisibility(int _arg)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetTickVisibility_87(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAxisActor2D_SetTitle_88(HandleRef pThis, string _arg);

		public virtual void SetTitle(string _arg)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetTitle_88(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAxisActor2D_SetTitlePosition_89(HandleRef pThis, double _arg);

		public virtual void SetTitlePosition(double _arg)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetTitlePosition_89(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAxisActor2D_SetTitleTextProperty_90(HandleRef pThis, HandleRef p);

		public virtual void SetTitleTextProperty(vtkTextProperty p)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetTitleTextProperty_90(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAxisActor2D_SetTitleVisibility_91(HandleRef pThis, int _arg);

		public virtual void SetTitleVisibility(int _arg)
		{
			vtkAxisActor2D.vtkAxisActor2D_SetTitleVisibility_91(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAxisActor2D_ShallowCopy_92(HandleRef pThis, HandleRef prop);

		public override void ShallowCopy(vtkProp prop)
		{
			vtkAxisActor2D.vtkAxisActor2D_ShallowCopy_92(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAxisActor2D_SizeFontRelativeToAxisOff_93(HandleRef pThis);

		public virtual void SizeFontRelativeToAxisOff()
		{
			vtkAxisActor2D.vtkAxisActor2D_SizeFontRelativeToAxisOff_93(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAxisActor2D_SizeFontRelativeToAxisOn_94(HandleRef pThis);

		public virtual void SizeFontRelativeToAxisOn()
		{
			vtkAxisActor2D.vtkAxisActor2D_SizeFontRelativeToAxisOn_94(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAxisActor2D_TickVisibilityOff_95(HandleRef pThis);

		public virtual void TickVisibilityOff()
		{
			vtkAxisActor2D.vtkAxisActor2D_TickVisibilityOff_95(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAxisActor2D_TickVisibilityOn_96(HandleRef pThis);

		public virtual void TickVisibilityOn()
		{
			vtkAxisActor2D.vtkAxisActor2D_TickVisibilityOn_96(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAxisActor2D_TitleVisibilityOff_97(HandleRef pThis);

		public virtual void TitleVisibilityOff()
		{
			vtkAxisActor2D.vtkAxisActor2D_TitleVisibilityOff_97(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAxisActor2D_TitleVisibilityOn_98(HandleRef pThis);

		public virtual void TitleVisibilityOn()
		{
			vtkAxisActor2D.vtkAxisActor2D_TitleVisibilityOn_98(base.GetCppThis());
		}
	}
}
