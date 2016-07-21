using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkChartParallelCoordinates : vtkChart
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkChartParallelCoordinates";

		public new static readonly string MRClassNameKey;

		static vtkChartParallelCoordinates()
		{
			vtkChartParallelCoordinates.MRClassNameKey = "class vtkChartParallelCoordinates";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkChartParallelCoordinates.MRClassNameKey, Type.GetType("Kitware.VTK.vtkChartParallelCoordinates"));
		}

		public vtkChartParallelCoordinates(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkChartParallelCoordinates_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkChartParallelCoordinates New()
		{
			vtkChartParallelCoordinates result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkChartParallelCoordinates.vtkChartParallelCoordinates_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkChartParallelCoordinates)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkChartParallelCoordinates() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkChartParallelCoordinates.vtkChartParallelCoordinates_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkChartParallelCoordinates_GetAxis_01(HandleRef pThis, int axisIndex, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkAxis GetAxis(int axisIndex)
		{
			vtkAxis vtkAxis = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkChartParallelCoordinates.vtkChartParallelCoordinates_GetAxis_01(base.GetCppThis(), axisIndex, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern long vtkChartParallelCoordinates_GetNumberOfAxes_02(HandleRef pThis);

		public override long GetNumberOfAxes()
		{
			return vtkChartParallelCoordinates.vtkChartParallelCoordinates_GetNumberOfAxes_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern long vtkChartParallelCoordinates_GetNumberOfPlots_03(HandleRef pThis);

		public override long GetNumberOfPlots()
		{
			return vtkChartParallelCoordinates.vtkChartParallelCoordinates_GetNumberOfPlots_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkChartParallelCoordinates_GetPlot_04(HandleRef pThis, long index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkPlot GetPlot(long index)
		{
			vtkPlot vtkPlot = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkChartParallelCoordinates.vtkChartParallelCoordinates_GetPlot_04(base.GetCppThis(), index, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkChartParallelCoordinates_GetVisibleColumns_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkStringArray GetVisibleColumns()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkChartParallelCoordinates.vtkChartParallelCoordinates_GetVisibleColumns_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringArray = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringArray.Register(null);
				}
			}
			return vtkStringArray;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkChartParallelCoordinates_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkChartParallelCoordinates.vtkChartParallelCoordinates_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkChartParallelCoordinates_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkChartParallelCoordinates.vtkChartParallelCoordinates_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkChartParallelCoordinates_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkChartParallelCoordinates NewInstance()
		{
			vtkChartParallelCoordinates result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkChartParallelCoordinates.vtkChartParallelCoordinates_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkChartParallelCoordinates)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkChartParallelCoordinates_Paint_10(HandleRef pThis, HandleRef painter);

		public override bool Paint(vtkContext2D painter)
		{
			return vtkChartParallelCoordinates.vtkChartParallelCoordinates_Paint_10(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChartParallelCoordinates_RecalculateBounds_11(HandleRef pThis);

		public override void RecalculateBounds()
		{
			vtkChartParallelCoordinates.vtkChartParallelCoordinates_RecalculateBounds_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkChartParallelCoordinates_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkChartParallelCoordinates SafeDownCast(vtkObjectBase o)
		{
			vtkChartParallelCoordinates vtkChartParallelCoordinates = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkChartParallelCoordinates.vtkChartParallelCoordinates_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkChartParallelCoordinates = (vtkChartParallelCoordinates)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkChartParallelCoordinates.Register(null);
				}
			}
			return vtkChartParallelCoordinates;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChartParallelCoordinates_SetColumnVisibilityAll_13(HandleRef pThis, byte visible);

		public void SetColumnVisibilityAll(bool visible)
		{
			vtkChartParallelCoordinates.vtkChartParallelCoordinates_SetColumnVisibilityAll_13(base.GetCppThis(), visible ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChartParallelCoordinates_SetPlot_14(HandleRef pThis, HandleRef plot);

		public virtual void SetPlot(vtkPlotParallelCoordinates plot)
		{
			vtkChartParallelCoordinates.vtkChartParallelCoordinates_SetPlot_14(base.GetCppThis(), (plot == null) ? default(HandleRef) : plot.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChartParallelCoordinates_Update_15(HandleRef pThis);

		public override void Update()
		{
			vtkChartParallelCoordinates.vtkChartParallelCoordinates_Update_15(base.GetCppThis());
		}
	}
}
