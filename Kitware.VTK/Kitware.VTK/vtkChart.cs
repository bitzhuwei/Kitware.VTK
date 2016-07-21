using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkChart : vtkContextItem
	{
		public enum BAR_WrapperEnum
		{
			BAR = 2,
			LINE = 0,
			POINTS,
			STACKED = 3
		}

		public enum NOTIFY_WrapperEnum
		{
			NOTIFY = 3,
			PAN = 0,
			SELECT = 2,
			ZOOM = 1
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkChart";

		public new static readonly string MRClassNameKey;

		static vtkChart()
		{
			vtkChart.MRClassNameKey = "class vtkChart";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkChart.MRClassNameKey, Type.GetType("Kitware.VTK.vtkChart"));
		}

		public vtkChart(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkChart_AddPlot_01(HandleRef pThis, int type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPlot AddPlot(int type)
		{
			vtkPlot vtkPlot = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkChart.vtkChart_AddPlot_01(base.GetCppThis(), type, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlot = (vtkPlot)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlot.Register(null);
				}
			}
			return vtkPlot;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern long vtkChart_AddPlot_02(HandleRef pThis, HandleRef plot);

		public virtual long AddPlot(vtkPlot plot)
		{
			return vtkChart.vtkChart_AddPlot_02(base.GetCppThis(), (plot == null) ? default(HandleRef) : plot.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChart_ClearPlots_03(HandleRef pThis);

		public virtual void ClearPlots()
		{
			vtkChart.vtkChart_ClearPlots_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkChart_GetActionToButton_04(HandleRef pThis, int action);

		public virtual int GetActionToButton(int action)
		{
			return vtkChart.vtkChart_GetActionToButton_04(base.GetCppThis(), action);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkChart_GetAnnotationLink_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAnnotationLink GetAnnotationLink()
		{
			vtkAnnotationLink vtkAnnotationLink = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkChart.vtkChart_GetAnnotationLink_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAnnotationLink = (vtkAnnotationLink)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAnnotationLink.Register(null);
				}
			}
			return vtkAnnotationLink;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkChart_GetAutoSize_06(HandleRef pThis);

		public virtual bool GetAutoSize()
		{
			return vtkChart.vtkChart_GetAutoSize_06(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkChart_GetAxis_07(HandleRef pThis, int axisIndex, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAxis GetAxis(int axisIndex)
		{
			vtkAxis vtkAxis = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkChart.vtkChart_GetAxis_07(base.GetCppThis(), axisIndex, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAxis = (vtkAxis)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAxis.Register(null);
				}
			}
			return vtkAxis;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkChart_GetClickActionToButton_08(HandleRef pThis, int action);

		public virtual int GetClickActionToButton(int action)
		{
			return vtkChart.vtkChart_GetClickActionToButton_08(base.GetCppThis(), action);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkChart_GetGeometry_09(HandleRef pThis);

		public virtual int[] GetGeometry()
		{
			IntPtr intPtr = vtkChart.vtkChart_GetGeometry_09(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChart_GetGeometry_10(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetGeometry(ref int _arg1, ref int _arg2)
		{
			vtkChart.vtkChart_GetGeometry_10(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChart_GetGeometry_11(HandleRef pThis, IntPtr _arg);

		public virtual void GetGeometry(IntPtr _arg)
		{
			vtkChart.vtkChart_GetGeometry_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkChart_GetLegend_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkChartLegend GetLegend()
		{
			vtkChartLegend vtkChartLegend = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkChart.vtkChart_GetLegend_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkChartLegend = (vtkChartLegend)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkChartLegend.Register(null);
				}
			}
			return vtkChartLegend;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern long vtkChart_GetNumberOfAxes_13(HandleRef pThis);

		public virtual long GetNumberOfAxes()
		{
			return vtkChart.vtkChart_GetNumberOfAxes_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern long vtkChart_GetNumberOfPlots_14(HandleRef pThis);

		public virtual long GetNumberOfPlots()
		{
			return vtkChart.vtkChart_GetNumberOfPlots_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkChart_GetPlot_15(HandleRef pThis, long index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPlot GetPlot(long index)
		{
			vtkPlot vtkPlot = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkChart.vtkChart_GetPlot_15(base.GetCppThis(), index, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlot = (vtkPlot)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlot.Register(null);
				}
			}
			return vtkPlot;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkChart_GetPoint1_16(HandleRef pThis);

		public virtual int[] GetPoint1()
		{
			IntPtr intPtr = vtkChart.vtkChart_GetPoint1_16(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChart_GetPoint1_17(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetPoint1(ref int _arg1, ref int _arg2)
		{
			vtkChart.vtkChart_GetPoint1_17(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChart_GetPoint1_18(HandleRef pThis, IntPtr _arg);

		public virtual void GetPoint1(IntPtr _arg)
		{
			vtkChart.vtkChart_GetPoint1_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkChart_GetPoint2_19(HandleRef pThis);

		public virtual int[] GetPoint2()
		{
			IntPtr intPtr = vtkChart.vtkChart_GetPoint2_19(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChart_GetPoint2_20(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetPoint2(ref int _arg1, ref int _arg2)
		{
			vtkChart.vtkChart_GetPoint2_20(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChart_GetPoint2_21(HandleRef pThis, IntPtr _arg);

		public virtual void GetPoint2(IntPtr _arg)
		{
			vtkChart.vtkChart_GetPoint2_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkChart_GetRenderEmpty_22(HandleRef pThis);

		public virtual bool GetRenderEmpty()
		{
			return vtkChart.vtkChart_GetRenderEmpty_22(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkChart_GetShowLegend_23(HandleRef pThis);

		public virtual bool GetShowLegend()
		{
			return vtkChart.vtkChart_GetShowLegend_23(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkChart_GetTitleProperties_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetTitleProperties()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkChart.vtkChart_GetTitleProperties_24(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkChart_IsA_25(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkChart.vtkChart_IsA_25(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkChart_IsTypeOf_26(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkChart.vtkChart_IsTypeOf_26(type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkChart_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkChart NewInstance()
		{
			vtkChart result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkChart.vtkChart_NewInstance_27(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkChart)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkChart_Paint_28(HandleRef pThis, HandleRef painter);

		public override bool Paint(vtkContext2D painter)
		{
			return vtkChart.vtkChart_Paint_28(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChart_RecalculateBounds_29(HandleRef pThis);

		public virtual void RecalculateBounds()
		{
			vtkChart.vtkChart_RecalculateBounds_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkChart_RemovePlot_30(HandleRef pThis, long index);

		public virtual bool RemovePlot(long index)
		{
			return vtkChart.vtkChart_RemovePlot_30(base.GetCppThis(), index) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkChart_RemovePlotInstance_31(HandleRef pThis, HandleRef plot);

		public virtual bool RemovePlotInstance(vtkPlot plot)
		{
			return vtkChart.vtkChart_RemovePlotInstance_31(base.GetCppThis(), (plot == null) ? default(HandleRef) : plot.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkChart_SafeDownCast_32(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkChart SafeDownCast(vtkObjectBase o)
		{
			vtkChart vtkChart = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkChart.vtkChart_SafeDownCast_32((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkChart = (vtkChart)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkChart.Register(null);
				}
			}
			return vtkChart;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChart_SetActionToButton_33(HandleRef pThis, int action, int button);

		public virtual void SetActionToButton(int action, int button)
		{
			vtkChart.vtkChart_SetActionToButton_33(base.GetCppThis(), action, button);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChart_SetAnnotationLink_34(HandleRef pThis, HandleRef link);

		public virtual void SetAnnotationLink(vtkAnnotationLink link)
		{
			vtkChart.vtkChart_SetAnnotationLink_34(base.GetCppThis(), (link == null) ? default(HandleRef) : link.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChart_SetAutoSize_35(HandleRef pThis, byte _arg);

		public virtual void SetAutoSize(bool _arg)
		{
			vtkChart.vtkChart_SetAutoSize_35(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChart_SetBorders_36(HandleRef pThis, int left, int bottom, int right, int top);

		public void SetBorders(int left, int bottom, int right, int top)
		{
			vtkChart.vtkChart_SetBorders_36(base.GetCppThis(), left, bottom, right, top);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChart_SetBottomBorder_37(HandleRef pThis, int border);

		public void SetBottomBorder(int border)
		{
			vtkChart.vtkChart_SetBottomBorder_37(base.GetCppThis(), border);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChart_SetClickActionToButton_38(HandleRef pThis, int action, int button);

		public virtual void SetClickActionToButton(int action, int button)
		{
			vtkChart.vtkChart_SetClickActionToButton_38(base.GetCppThis(), action, button);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChart_SetGeometry_39(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetGeometry(int _arg1, int _arg2)
		{
			vtkChart.vtkChart_SetGeometry_39(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChart_SetGeometry_40(HandleRef pThis, IntPtr _arg);

		public void SetGeometry(IntPtr _arg)
		{
			vtkChart.vtkChart_SetGeometry_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChart_SetLeftBorder_41(HandleRef pThis, int border);

		public void SetLeftBorder(int border)
		{
			vtkChart.vtkChart_SetLeftBorder_41(base.GetCppThis(), border);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChart_SetPoint1_42(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetPoint1(int _arg1, int _arg2)
		{
			vtkChart.vtkChart_SetPoint1_42(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChart_SetPoint1_43(HandleRef pThis, IntPtr _arg);

		public void SetPoint1(IntPtr _arg)
		{
			vtkChart.vtkChart_SetPoint1_43(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChart_SetPoint2_44(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetPoint2(int _arg1, int _arg2)
		{
			vtkChart.vtkChart_SetPoint2_44(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChart_SetPoint2_45(HandleRef pThis, IntPtr _arg);

		public void SetPoint2(IntPtr _arg)
		{
			vtkChart.vtkChart_SetPoint2_45(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChart_SetRenderEmpty_46(HandleRef pThis, byte _arg);

		public virtual void SetRenderEmpty(bool _arg)
		{
			vtkChart.vtkChart_SetRenderEmpty_46(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChart_SetRightBorder_47(HandleRef pThis, int border);

		public void SetRightBorder(int border)
		{
			vtkChart.vtkChart_SetRightBorder_47(base.GetCppThis(), border);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChart_SetShowLegend_48(HandleRef pThis, byte visible);

		public virtual void SetShowLegend(bool visible)
		{
			vtkChart.vtkChart_SetShowLegend_48(base.GetCppThis(), visible ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChart_SetTopBorder_49(HandleRef pThis, int border);

		public void SetTopBorder(int border)
		{
			vtkChart.vtkChart_SetTopBorder_49(base.GetCppThis(), border);
		}
	}
}
