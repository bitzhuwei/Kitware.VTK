using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkChartXY : vtkChart
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkChartXY";

		public new static readonly string MRClassNameKey;

		static vtkChartXY()
		{
			vtkChartXY.MRClassNameKey = "class vtkChartXY";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkChartXY.MRClassNameKey, Type.GetType("Kitware.VTK.vtkChartXY"));
		}

		public vtkChartXY(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkChartXY_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkChartXY New()
		{
			vtkChartXY result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkChartXY.vtkChartXY_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkChartXY)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkChartXY() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkChartXY.vtkChartXY_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkChartXY_AddPlot_01(HandleRef pThis, int type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkPlot AddPlot(int type)
		{
			vtkPlot vtkPlot = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkChartXY.vtkChartXY_AddPlot_01(base.GetCppThis(), type, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern long vtkChartXY_AddPlot_02(HandleRef pThis, HandleRef plot);

		public override long AddPlot(vtkPlot plot)
		{
			return vtkChartXY.vtkChartXY_AddPlot_02(base.GetCppThis(), (plot == null) ? default(HandleRef) : plot.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChartXY_AutoAxesOff_03(HandleRef pThis);

		public virtual void AutoAxesOff()
		{
			vtkChartXY.vtkChartXY_AutoAxesOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChartXY_AutoAxesOn_04(HandleRef pThis);

		public virtual void AutoAxesOn()
		{
			vtkChartXY.vtkChartXY_AutoAxesOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChartXY_ClearPlots_05(HandleRef pThis);

		public override void ClearPlots()
		{
			vtkChartXY.vtkChartXY_ClearPlots_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChartXY_DrawAxesAtOriginOff_06(HandleRef pThis);

		public virtual void DrawAxesAtOriginOff()
		{
			vtkChartXY.vtkChartXY_DrawAxesAtOriginOff_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChartXY_DrawAxesAtOriginOn_07(HandleRef pThis);

		public virtual void DrawAxesAtOriginOn()
		{
			vtkChartXY.vtkChartXY_DrawAxesAtOriginOn_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChartXY_ForceAxesToBoundsOff_08(HandleRef pThis);

		public virtual void ForceAxesToBoundsOff()
		{
			vtkChartXY.vtkChartXY_ForceAxesToBoundsOff_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChartXY_ForceAxesToBoundsOn_09(HandleRef pThis);

		public virtual void ForceAxesToBoundsOn()
		{
			vtkChartXY.vtkChartXY_ForceAxesToBoundsOn_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkChartXY_GetAutoAxes_10(HandleRef pThis);

		public virtual bool GetAutoAxes()
		{
			return vtkChartXY.vtkChartXY_GetAutoAxes_10(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkChartXY_GetAxis_11(HandleRef pThis, int axisIndex, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkAxis GetAxis(int axisIndex)
		{
			vtkAxis vtkAxis = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkChartXY.vtkChartXY_GetAxis_11(base.GetCppThis(), axisIndex, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern float vtkChartXY_GetBarWidthFraction_12(HandleRef pThis);

		public virtual float GetBarWidthFraction()
		{
			return vtkChartXY.vtkChartXY_GetBarWidthFraction_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkChartXY_GetDrawAxesAtOrigin_13(HandleRef pThis);

		public virtual bool GetDrawAxesAtOrigin()
		{
			return vtkChartXY.vtkChartXY_GetDrawAxesAtOrigin_13(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkChartXY_GetForceAxesToBounds_14(HandleRef pThis);

		public virtual bool GetForceAxesToBounds()
		{
			return vtkChartXY.vtkChartXY_GetForceAxesToBounds_14(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkChartXY_GetHiddenAxisBorder_15(HandleRef pThis);

		public virtual int GetHiddenAxisBorder()
		{
			return vtkChartXY.vtkChartXY_GetHiddenAxisBorder_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkChartXY_GetLegend_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkChartLegend GetLegend()
		{
			vtkChartLegend vtkChartLegend = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkChartXY.vtkChartXY_GetLegend_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern long vtkChartXY_GetNumberOfAxes_17(HandleRef pThis);

		public override long GetNumberOfAxes()
		{
			return vtkChartXY.vtkChartXY_GetNumberOfAxes_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern long vtkChartXY_GetNumberOfPlots_18(HandleRef pThis);

		public override long GetNumberOfPlots()
		{
			return vtkChartXY.vtkChartXY_GetNumberOfPlots_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkChartXY_GetPlot_19(HandleRef pThis, long index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkPlot GetPlot(long index)
		{
			vtkPlot vtkPlot = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkChartXY.vtkChartXY_GetPlot_19(base.GetCppThis(), index, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkChartXY_GetPlotCorner_20(HandleRef pThis, HandleRef plot);

		public int GetPlotCorner(vtkPlot plot)
		{
			return vtkChartXY.vtkChartXY_GetPlotCorner_20(base.GetCppThis(), (plot == null) ? default(HandleRef) : plot.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkChartXY_GetTooltip_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTooltipItem GetTooltip()
		{
			vtkTooltipItem vtkTooltipItem = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkChartXY.vtkChartXY_GetTooltip_21(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTooltipItem = (vtkTooltipItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTooltipItem.Register(null);
				}
			}
			return vtkTooltipItem;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkChartXY_IsA_22(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkChartXY.vtkChartXY_IsA_22(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkChartXY_IsTypeOf_23(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkChartXY.vtkChartXY_IsTypeOf_23(type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkChartXY_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkChartXY NewInstance()
		{
			vtkChartXY result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkChartXY.vtkChartXY_NewInstance_25(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkChartXY)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkChartXY_Paint_26(HandleRef pThis, HandleRef painter);

		public override bool Paint(vtkContext2D painter)
		{
			return vtkChartXY.vtkChartXY_Paint_26(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChartXY_RecalculateBounds_27(HandleRef pThis);

		public override void RecalculateBounds()
		{
			vtkChartXY.vtkChartXY_RecalculateBounds_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkChartXY_RemovePlot_28(HandleRef pThis, long index);

		public override bool RemovePlot(long index)
		{
			return vtkChartXY.vtkChartXY_RemovePlot_28(base.GetCppThis(), index) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkChartXY_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkChartXY SafeDownCast(vtkObjectBase o)
		{
			vtkChartXY vtkChartXY = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkChartXY.vtkChartXY_SafeDownCast_29((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkChartXY = (vtkChartXY)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkChartXY.Register(null);
				}
			}
			return vtkChartXY;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChartXY_SetAutoAxes_30(HandleRef pThis, byte _arg);

		public virtual void SetAutoAxes(bool _arg)
		{
			vtkChartXY.vtkChartXY_SetAutoAxes_30(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChartXY_SetBarWidthFraction_31(HandleRef pThis, float _arg);

		public virtual void SetBarWidthFraction(float _arg)
		{
			vtkChartXY.vtkChartXY_SetBarWidthFraction_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChartXY_SetDrawAxesAtOrigin_32(HandleRef pThis, byte _arg);

		public virtual void SetDrawAxesAtOrigin(bool _arg)
		{
			vtkChartXY.vtkChartXY_SetDrawAxesAtOrigin_32(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChartXY_SetForceAxesToBounds_33(HandleRef pThis, byte _arg);

		public virtual void SetForceAxesToBounds(bool _arg)
		{
			vtkChartXY.vtkChartXY_SetForceAxesToBounds_33(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChartXY_SetHiddenAxisBorder_34(HandleRef pThis, int _arg);

		public virtual void SetHiddenAxisBorder(int _arg)
		{
			vtkChartXY.vtkChartXY_SetHiddenAxisBorder_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChartXY_SetPlotCorner_35(HandleRef pThis, HandleRef plot, int corner);

		public void SetPlotCorner(vtkPlot plot, int corner)
		{
			vtkChartXY.vtkChartXY_SetPlotCorner_35(base.GetCppThis(), (plot == null) ? default(HandleRef) : plot.GetCppThis(), corner);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChartXY_SetShowLegend_36(HandleRef pThis, byte visible);

		public override void SetShowLegend(bool visible)
		{
			vtkChartXY.vtkChartXY_SetShowLegend_36(base.GetCppThis(), visible ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChartXY_Update_37(HandleRef pThis);

		public override void Update()
		{
			vtkChartXY.vtkChartXY_Update_37(base.GetCppThis());
		}
	}
}
