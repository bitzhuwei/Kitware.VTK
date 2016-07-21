using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkChartLegend : vtkContextItem
	{
		public enum BOTTOM_WrapperEnum
		{
			BOTTOM = 4,
			CENTER = 1,
			CUSTOM = 5,
			LEFT = 0,
			RIGHT = 2,
			TOP
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkChartLegend";

		public new static readonly string MRClassNameKey;

		static vtkChartLegend()
		{
			vtkChartLegend.MRClassNameKey = "class vtkChartLegend";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkChartLegend.MRClassNameKey, Type.GetType("Kitware.VTK.vtkChartLegend"));
		}

		public vtkChartLegend(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkChartLegend_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkChartLegend New()
		{
			vtkChartLegend result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkChartLegend.vtkChartLegend_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkChartLegend)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkChartLegend() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkChartLegend.vtkChartLegend_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkChartLegend_GetBrush_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkBrush GetBrush()
		{
			vtkBrush vtkBrush = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkChartLegend.vtkChartLegend_GetBrush_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBrush = (vtkBrush)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBrush.Register(null);
				}
			}
			return vtkBrush;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkChartLegend_GetChart_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkChart GetChart()
		{
			vtkChart vtkChart = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkChartLegend.vtkChartLegend_GetChart_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern byte vtkChartLegend_GetDragEnabled_03(HandleRef pThis);

		public virtual bool GetDragEnabled()
		{
			return vtkChartLegend.vtkChartLegend_GetDragEnabled_03(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkChartLegend_GetHorizontalAlignment_04(HandleRef pThis);

		public virtual int GetHorizontalAlignment()
		{
			return vtkChartLegend.vtkChartLegend_GetHorizontalAlignment_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkChartLegend_GetInline_05(HandleRef pThis);

		public virtual bool GetInline()
		{
			return vtkChartLegend.vtkChartLegend_GetInline_05(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkChartLegend_GetLabelProperties_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkTextProperty GetLabelProperties()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkChartLegend.vtkChartLegend_GetLabelProperties_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkChartLegend_GetLabelSize_07(HandleRef pThis);

		public virtual int GetLabelSize()
		{
			return vtkChartLegend.vtkChartLegend_GetLabelSize_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkChartLegend_GetPadding_08(HandleRef pThis);

		public virtual int GetPadding()
		{
			return vtkChartLegend.vtkChartLegend_GetPadding_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkChartLegend_GetPen_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPen GetPen()
		{
			vtkPen vtkPen = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkChartLegend.vtkChartLegend_GetPen_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPen = (vtkPen)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPen.Register(null);
				}
			}
			return vtkPen;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkChartLegend_GetPoint_10(HandleRef pThis);

		public virtual float[] GetPoint()
		{
			IntPtr intPtr = vtkChartLegend.vtkChartLegend_GetPoint_10(base.GetCppThis());
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChartLegend_GetPoint_11(HandleRef pThis, ref float _arg1, ref float _arg2);

		public virtual void GetPoint(ref float _arg1, ref float _arg2)
		{
			vtkChartLegend.vtkChartLegend_GetPoint_11(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChartLegend_GetPoint_12(HandleRef pThis, IntPtr _arg);

		public virtual void GetPoint(IntPtr _arg)
		{
			vtkChartLegend.vtkChartLegend_GetPoint_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkChartLegend_GetSymbolWidth_13(HandleRef pThis);

		public virtual int GetSymbolWidth()
		{
			return vtkChartLegend.vtkChartLegend_GetSymbolWidth_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkChartLegend_GetVerticalAlignment_14(HandleRef pThis);

		public virtual int GetVerticalAlignment()
		{
			return vtkChartLegend.vtkChartLegend_GetVerticalAlignment_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkChartLegend_IsA_15(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkChartLegend.vtkChartLegend_IsA_15(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkChartLegend_IsTypeOf_16(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkChartLegend.vtkChartLegend_IsTypeOf_16(type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkChartLegend_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkChartLegend NewInstance()
		{
			vtkChartLegend result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkChartLegend.vtkChartLegend_NewInstance_18(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkChartLegend)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkChartLegend_Paint_19(HandleRef pThis, HandleRef painter);

		public override bool Paint(vtkContext2D painter)
		{
			return vtkChartLegend.vtkChartLegend_Paint_19(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkChartLegend_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkChartLegend SafeDownCast(vtkObjectBase o)
		{
			vtkChartLegend vtkChartLegend = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkChartLegend.vtkChartLegend_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkChartLegend_SetChart_21(HandleRef pThis, HandleRef chart);

		public void SetChart(vtkChart chart)
		{
			vtkChartLegend.vtkChartLegend_SetChart_21(base.GetCppThis(), (chart == null) ? default(HandleRef) : chart.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChartLegend_SetDragEnabled_22(HandleRef pThis, byte _arg);

		public virtual void SetDragEnabled(bool _arg)
		{
			vtkChartLegend.vtkChartLegend_SetDragEnabled_22(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChartLegend_SetHorizontalAlignment_23(HandleRef pThis, int _arg);

		public virtual void SetHorizontalAlignment(int _arg)
		{
			vtkChartLegend.vtkChartLegend_SetHorizontalAlignment_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChartLegend_SetInline_24(HandleRef pThis, byte _arg);

		public virtual void SetInline(bool _arg)
		{
			vtkChartLegend.vtkChartLegend_SetInline_24(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChartLegend_SetLabelSize_25(HandleRef pThis, int size);

		public virtual void SetLabelSize(int size)
		{
			vtkChartLegend.vtkChartLegend_SetLabelSize_25(base.GetCppThis(), size);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChartLegend_SetPadding_26(HandleRef pThis, int _arg);

		public virtual void SetPadding(int _arg)
		{
			vtkChartLegend.vtkChartLegend_SetPadding_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChartLegend_SetPoint_27(HandleRef pThis, float _arg1, float _arg2);

		public virtual void SetPoint(float _arg1, float _arg2)
		{
			vtkChartLegend.vtkChartLegend_SetPoint_27(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChartLegend_SetPoint_28(HandleRef pThis, IntPtr _arg);

		public void SetPoint(IntPtr _arg)
		{
			vtkChartLegend.vtkChartLegend_SetPoint_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChartLegend_SetSymbolWidth_29(HandleRef pThis, int _arg);

		public virtual void SetSymbolWidth(int _arg)
		{
			vtkChartLegend.vtkChartLegend_SetSymbolWidth_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChartLegend_SetVerticalAlignment_30(HandleRef pThis, int _arg);

		public virtual void SetVerticalAlignment(int _arg)
		{
			vtkChartLegend.vtkChartLegend_SetVerticalAlignment_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChartLegend_Update_31(HandleRef pThis);

		public override void Update()
		{
			vtkChartLegend.vtkChartLegend_Update_31(base.GetCppThis());
		}
	}
}
