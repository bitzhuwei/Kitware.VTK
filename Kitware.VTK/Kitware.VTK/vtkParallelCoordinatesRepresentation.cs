using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkParallelCoordinatesRepresentation : vtkRenderedRepresentation
	{
		public enum InputPorts
		{
			INPUT_DATA,
			INPUT_TITLES,
			NUM_INPUT_PORTS
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkParallelCoordinatesRepresentation";

		public new static readonly string MRClassNameKey;

		static vtkParallelCoordinatesRepresentation()
		{
			vtkParallelCoordinatesRepresentation.MRClassNameKey = "class vtkParallelCoordinatesRepresentation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParallelCoordinatesRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParallelCoordinatesRepresentation"));
		}

		public vtkParallelCoordinatesRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelCoordinatesRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkParallelCoordinatesRepresentation New()
		{
			vtkParallelCoordinatesRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParallelCoordinatesRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkParallelCoordinatesRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesRepresentation_AngleSelect_01(HandleRef pThis, int brushClass, int brushOperator, IntPtr p1, IntPtr p2);

		public virtual void AngleSelect(int brushClass, int brushOperator, IntPtr p1, IntPtr p2)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_AngleSelect_01(base.GetCppThis(), brushClass, brushOperator, p1, p2);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesRepresentation_ApplyViewTheme_02(HandleRef pThis, HandleRef theme);

		public override void ApplyViewTheme(vtkViewTheme theme)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_ApplyViewTheme_02(base.GetCppThis(), (theme == null) ? default(HandleRef) : theme.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesRepresentation_FunctionSelect_03(HandleRef pThis, int brushClass, int brushOperator, IntPtr p1, IntPtr p2, IntPtr q1, IntPtr q2);

		public virtual void FunctionSelect(int brushClass, int brushOperator, IntPtr p1, IntPtr p2, IntPtr q1, IntPtr q2)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_FunctionSelect_03(base.GetCppThis(), brushClass, brushOperator, p1, p2, q1, q2);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern double vtkParallelCoordinatesRepresentation_GetAngleBrushThreshold_04(HandleRef pThis);

		public virtual double GetAngleBrushThreshold()
		{
			return vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetAngleBrushThreshold_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelCoordinatesRepresentation_GetAxisColor_05(HandleRef pThis);

		public virtual double[] GetAxisColor()
		{
			IntPtr intPtr = vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetAxisColor_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesRepresentation_GetAxisColor_06(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetAxisColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetAxisColor_06(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesRepresentation_GetAxisColor_07(HandleRef pThis, IntPtr _arg);

		public virtual void GetAxisColor(IntPtr _arg)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetAxisColor_07(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelCoordinatesRepresentation_GetAxisLabelColor_08(HandleRef pThis);

		public virtual double[] GetAxisLabelColor()
		{
			IntPtr intPtr = vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetAxisLabelColor_08(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesRepresentation_GetAxisLabelColor_09(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetAxisLabelColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetAxisLabelColor_09(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesRepresentation_GetAxisLabelColor_10(HandleRef pThis, IntPtr _arg);

		public virtual void GetAxisLabelColor(IntPtr _arg)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetAxisLabelColor_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkParallelCoordinatesRepresentation_GetCurveResolution_11(HandleRef pThis);

		public virtual int GetCurveResolution()
		{
			return vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetCurveResolution_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern double vtkParallelCoordinatesRepresentation_GetFontSize_12(HandleRef pThis);

		public virtual double GetFontSize()
		{
			return vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetFontSize_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern double vtkParallelCoordinatesRepresentation_GetFunctionBrushThreshold_13(HandleRef pThis);

		public virtual double GetFunctionBrushThreshold()
		{
			return vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetFunctionBrushThreshold_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelCoordinatesRepresentation_GetHoverText_14(HandleRef pThis, HandleRef view, int x, int y);

		public virtual string GetHoverText(vtkView view, int x, int y)
		{
			return Marshal.PtrToStringAnsi(vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetHoverText_14(base.GetCppThis(), (view == null) ? default(HandleRef) : view.GetCppThis(), x, y));
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelCoordinatesRepresentation_GetLineColor_15(HandleRef pThis);

		public virtual double[] GetLineColor()
		{
			IntPtr intPtr = vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetLineColor_15(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesRepresentation_GetLineColor_16(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetLineColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetLineColor_16(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesRepresentation_GetLineColor_17(HandleRef pThis, IntPtr _arg);

		public virtual void GetLineColor(IntPtr _arg)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetLineColor_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern double vtkParallelCoordinatesRepresentation_GetLineOpacity_18(HandleRef pThis);

		public virtual double GetLineOpacity()
		{
			return vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetLineOpacity_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkParallelCoordinatesRepresentation_GetNumberOfAxes_19(HandleRef pThis);

		public virtual int GetNumberOfAxes()
		{
			return vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetNumberOfAxes_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkParallelCoordinatesRepresentation_GetNumberOfAxisLabels_20(HandleRef pThis);

		public virtual int GetNumberOfAxisLabels()
		{
			return vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetNumberOfAxisLabels_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkParallelCoordinatesRepresentation_GetNumberOfSamples_21(HandleRef pThis);

		public virtual int GetNumberOfSamples()
		{
			return vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetNumberOfSamples_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkParallelCoordinatesRepresentation_GetPositionAndSize_22(HandleRef pThis, IntPtr position, IntPtr size);

		public int GetPositionAndSize(IntPtr position, IntPtr size)
		{
			return vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetPositionAndSize_22(base.GetCppThis(), position, size);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkParallelCoordinatesRepresentation_GetPositionNearXCoordinate_23(HandleRef pThis, double xcoord);

		public int GetPositionNearXCoordinate(double xcoord)
		{
			return vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetPositionNearXCoordinate_23(base.GetCppThis(), xcoord);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkParallelCoordinatesRepresentation_GetRangeAtPosition_24(HandleRef pThis, int position, IntPtr range);

		public int GetRangeAtPosition(int position, IntPtr range)
		{
			return vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetRangeAtPosition_24(base.GetCppThis(), position, range);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkParallelCoordinatesRepresentation_GetUseCurves_25(HandleRef pThis);

		public virtual int GetUseCurves()
		{
			return vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetUseCurves_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern double vtkParallelCoordinatesRepresentation_GetXCoordinateOfPosition_26(HandleRef pThis, int axis);

		public double GetXCoordinateOfPosition(int axis)
		{
			return vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetXCoordinateOfPosition_26(base.GetCppThis(), axis);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesRepresentation_GetXCoordinatesOfPositions_27(HandleRef pThis, IntPtr coords);

		public void GetXCoordinatesOfPositions(IntPtr coords)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_GetXCoordinatesOfPositions_27(base.GetCppThis(), coords);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkParallelCoordinatesRepresentation_IsA_28(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_IsA_28(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkParallelCoordinatesRepresentation_IsTypeOf_29(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_IsTypeOf_29(type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesRepresentation_LassoSelect_30(HandleRef pThis, int brushClass, int brushOperator, HandleRef brushPoints);

		public virtual void LassoSelect(int brushClass, int brushOperator, vtkPoints brushPoints)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_LassoSelect_30(base.GetCppThis(), brushClass, brushOperator, (brushPoints == null) ? default(HandleRef) : brushPoints.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelCoordinatesRepresentation_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkParallelCoordinatesRepresentation NewInstance()
		{
			vtkParallelCoordinatesRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_NewInstance_32(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParallelCoordinatesRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesRepresentation_RangeSelect_33(HandleRef pThis, int brushClass, int brushOperator, IntPtr p1, IntPtr p2);

		public virtual void RangeSelect(int brushClass, int brushOperator, IntPtr p1, IntPtr p2)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_RangeSelect_33(base.GetCppThis(), brushClass, brushOperator, p1, p2);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesRepresentation_ResetAxes_34(HandleRef pThis);

		public void ResetAxes()
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_ResetAxes_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelCoordinatesRepresentation_SafeDownCast_35(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkParallelCoordinatesRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkParallelCoordinatesRepresentation vtkParallelCoordinatesRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_SafeDownCast_35((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParallelCoordinatesRepresentation = (vtkParallelCoordinatesRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParallelCoordinatesRepresentation.Register(null);
				}
			}
			return vtkParallelCoordinatesRepresentation;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesRepresentation_SetAngleBrushThreshold_36(HandleRef pThis, double _arg);

		public virtual void SetAngleBrushThreshold(double _arg)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_SetAngleBrushThreshold_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesRepresentation_SetAxisColor_37(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetAxisColor(double _arg1, double _arg2, double _arg3)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_SetAxisColor_37(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesRepresentation_SetAxisColor_38(HandleRef pThis, IntPtr _arg);

		public virtual void SetAxisColor(IntPtr _arg)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_SetAxisColor_38(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesRepresentation_SetAxisLabelColor_39(HandleRef pThis, IntPtr _arg);

		public virtual void SetAxisLabelColor(IntPtr _arg)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_SetAxisLabelColor_39(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesRepresentation_SetAxisLabelColor_40(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetAxisLabelColor(double _arg1, double _arg2, double _arg3)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_SetAxisLabelColor_40(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesRepresentation_SetAxisTitles_41(HandleRef pThis, HandleRef arg0);

		public void SetAxisTitles(vtkStringArray arg0)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_SetAxisTitles_41(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesRepresentation_SetAxisTitles_42(HandleRef pThis, HandleRef arg0);

		public void SetAxisTitles(vtkAlgorithmOutput arg0)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_SetAxisTitles_42(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesRepresentation_SetCurveResolution_43(HandleRef pThis, int _arg);

		public virtual void SetCurveResolution(int _arg)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_SetCurveResolution_43(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesRepresentation_SetFontSize_44(HandleRef pThis, double _arg);

		public virtual void SetFontSize(double _arg)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_SetFontSize_44(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesRepresentation_SetFunctionBrushThreshold_45(HandleRef pThis, double _arg);

		public virtual void SetFunctionBrushThreshold(double _arg)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_SetFunctionBrushThreshold_45(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesRepresentation_SetLineColor_46(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetLineColor(double _arg1, double _arg2, double _arg3)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_SetLineColor_46(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesRepresentation_SetLineColor_47(HandleRef pThis, IntPtr _arg);

		public virtual void SetLineColor(IntPtr _arg)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_SetLineColor_47(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesRepresentation_SetLineOpacity_48(HandleRef pThis, double _arg);

		public virtual void SetLineOpacity(double _arg)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_SetLineOpacity_48(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesRepresentation_SetNumberOfAxisLabels_49(HandleRef pThis, int num);

		public void SetNumberOfAxisLabels(int num)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_SetNumberOfAxisLabels_49(base.GetCppThis(), num);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesRepresentation_SetPlotTitle_50(HandleRef pThis, string arg0);

		public void SetPlotTitle(string arg0)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_SetPlotTitle_50(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkParallelCoordinatesRepresentation_SetPositionAndSize_51(HandleRef pThis, IntPtr position, IntPtr size);

		public int SetPositionAndSize(IntPtr position, IntPtr size)
		{
			return vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_SetPositionAndSize_51(base.GetCppThis(), position, size);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkParallelCoordinatesRepresentation_SetRangeAtPosition_52(HandleRef pThis, int position, IntPtr range);

		public virtual int SetRangeAtPosition(int position, IntPtr range)
		{
			return vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_SetRangeAtPosition_52(base.GetCppThis(), position, range);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesRepresentation_SetUseCurves_53(HandleRef pThis, int _arg);

		public virtual void SetUseCurves(int _arg)
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_SetUseCurves_53(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkParallelCoordinatesRepresentation_SetXCoordinateOfPosition_54(HandleRef pThis, int position, double xcoord);

		public int SetXCoordinateOfPosition(int position, double xcoord)
		{
			return vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_SetXCoordinateOfPosition_54(base.GetCppThis(), position, xcoord);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkParallelCoordinatesRepresentation_SwapAxisPositions_55(HandleRef pThis, int position1, int position2);

		public virtual int SwapAxisPositions(int position1, int position2)
		{
			return vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_SwapAxisPositions_55(base.GetCppThis(), position1, position2);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesRepresentation_UseCurvesOff_56(HandleRef pThis);

		public virtual void UseCurvesOff()
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_UseCurvesOff_56(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkParallelCoordinatesRepresentation_UseCurvesOn_57(HandleRef pThis);

		public virtual void UseCurvesOn()
		{
			vtkParallelCoordinatesRepresentation.vtkParallelCoordinatesRepresentation_UseCurvesOn_57(base.GetCppThis());
		}
	}
}
