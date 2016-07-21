using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPlot : vtkContextItem
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPlot";

		public new static readonly string MRClassNameKey;

		static vtkPlot()
		{
			vtkPlot.MRClassNameKey = "class vtkPlot";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPlot.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlot"));
		}

		public vtkPlot(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlot_GetBounds_01(HandleRef pThis, IntPtr bounds);

		public virtual void GetBounds(IntPtr bounds)
		{
			vtkPlot.vtkPlot_GetBounds_01(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPlot_GetBrush_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkBrush GetBrush()
		{
			vtkBrush vtkBrush = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlot.vtkPlot_GetBrush_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkPlot_GetColor_03(HandleRef pThis, IntPtr rgb);

		public virtual void GetColor(IntPtr rgb)
		{
			vtkPlot.vtkPlot_GetColor_03(base.GetCppThis(), rgb);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPlot_GetData_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkContextMapper2D GetData()
		{
			vtkContextMapper2D vtkContextMapper2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlot.vtkPlot_GetData_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContextMapper2D = (vtkContextMapper2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContextMapper2D.Register(null);
				}
			}
			return vtkContextMapper2D;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPlot_GetIndexedLabels_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkStringArray GetIndexedLabels()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlot.vtkPlot_GetIndexedLabels_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkPlot_GetInput_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTable GetInput()
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlot.vtkPlot_GetInput_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTable = (vtkTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTable.Register(null);
				}
			}
			return vtkTable;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPlot_GetLabels_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkStringArray GetLabels()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlot.vtkPlot_GetLabels_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkPlot_GetNumberOfLabels_08(HandleRef pThis);

		public virtual int GetNumberOfLabels()
		{
			return vtkPlot.vtkPlot_GetNumberOfLabels_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPlot_GetPen_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPen GetPen()
		{
			vtkPen vtkPen = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlot.vtkPlot_GetPen_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkPlot_GetSelection_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkIdTypeArray GetSelection()
		{
			vtkIdTypeArray vtkIdTypeArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlot.vtkPlot_GetSelection_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdTypeArray = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdTypeArray.Register(null);
				}
			}
			return vtkIdTypeArray;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkPlot_GetUseIndexForXSeries_11(HandleRef pThis);

		public virtual bool GetUseIndexForXSeries()
		{
			return vtkPlot.vtkPlot_GetUseIndexForXSeries_11(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern float vtkPlot_GetWidth_12(HandleRef pThis);

		public virtual float GetWidth()
		{
			return vtkPlot.vtkPlot_GetWidth_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPlot_GetXAxis_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAxis GetXAxis()
		{
			vtkAxis vtkAxis = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlot.vtkPlot_GetXAxis_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkPlot_GetYAxis_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAxis GetYAxis()
		{
			vtkAxis vtkAxis = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlot.vtkPlot_GetYAxis_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkPlot_IsA_15(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPlot.vtkPlot_IsA_15(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkPlot_IsTypeOf_16(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPlot.vtkPlot_IsTypeOf_16(type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPlot_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPlot NewInstance()
		{
			vtkPlot result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlot.vtkPlot_NewInstance_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlot)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPlot_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPlot SafeDownCast(vtkObjectBase o)
		{
			vtkPlot vtkPlot = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlot.vtkPlot_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkPlot_SetColor_19(HandleRef pThis, byte r, byte g, byte b, byte a);

		public virtual void SetColor(byte r, byte g, byte b, byte a)
		{
			vtkPlot.vtkPlot_SetColor_19(base.GetCppThis(), r, g, b, a);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlot_SetColor_20(HandleRef pThis, double r, double g, double b);

		public virtual void SetColor(double r, double g, double b)
		{
			vtkPlot.vtkPlot_SetColor_20(base.GetCppThis(), r, g, b);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlot_SetIndexedLabels_21(HandleRef pThis, HandleRef labels);

		public void SetIndexedLabels(vtkStringArray labels)
		{
			vtkPlot.vtkPlot_SetIndexedLabels_21(base.GetCppThis(), (labels == null) ? default(HandleRef) : labels.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlot_SetInput_22(HandleRef pThis, HandleRef table);

		public virtual void SetInput(vtkTable table)
		{
			vtkPlot.vtkPlot_SetInput_22(base.GetCppThis(), (table == null) ? default(HandleRef) : table.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlot_SetInput_23(HandleRef pThis, HandleRef table, long xColumn, long yColumn);

		public void SetInput(vtkTable table, long xColumn, long yColumn)
		{
			vtkPlot.vtkPlot_SetInput_23(base.GetCppThis(), (table == null) ? default(HandleRef) : table.GetCppThis(), xColumn, yColumn);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlot_SetLabels_24(HandleRef pThis, HandleRef labels);

		public virtual void SetLabels(vtkStringArray labels)
		{
			vtkPlot.vtkPlot_SetLabels_24(base.GetCppThis(), (labels == null) ? default(HandleRef) : labels.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlot_SetSelection_25(HandleRef pThis, HandleRef id);

		public virtual void SetSelection(vtkIdTypeArray id)
		{
			vtkPlot.vtkPlot_SetSelection_25(base.GetCppThis(), (id == null) ? default(HandleRef) : id.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlot_SetUseIndexForXSeries_26(HandleRef pThis, byte _arg);

		public virtual void SetUseIndexForXSeries(bool _arg)
		{
			vtkPlot.vtkPlot_SetUseIndexForXSeries_26(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlot_SetWidth_27(HandleRef pThis, float width);

		public virtual void SetWidth(float width)
		{
			vtkPlot.vtkPlot_SetWidth_27(base.GetCppThis(), width);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlot_SetXAxis_28(HandleRef pThis, HandleRef axis);

		public virtual void SetXAxis(vtkAxis axis)
		{
			vtkPlot.vtkPlot_SetXAxis_28(base.GetCppThis(), (axis == null) ? default(HandleRef) : axis.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlot_SetYAxis_29(HandleRef pThis, HandleRef axis);

		public virtual void SetYAxis(vtkAxis axis)
		{
			vtkPlot.vtkPlot_SetYAxis_29(base.GetCppThis(), (axis == null) ? default(HandleRef) : axis.GetCppThis());
		}
	}
}
