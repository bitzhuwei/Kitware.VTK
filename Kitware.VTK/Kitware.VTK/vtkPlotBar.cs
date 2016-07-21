using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPlotBar : vtkPlot
	{
		public enum HORIZONTAL_WrapperEnum
		{
			HORIZONTAL = 1,
			VERTICAL = 0
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkPlotBar";

		public new static readonly string MRClassNameKey;

		static vtkPlotBar()
		{
			vtkPlotBar.MRClassNameKey = "class vtkPlotBar";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPlotBar.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlotBar"));
		}

		public vtkPlotBar(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPlotBar_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPlotBar New()
		{
			vtkPlotBar result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlotBar.vtkPlotBar_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotBar)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPlotBar() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPlotBar.vtkPlotBar_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlotBar_GetBounds_01(HandleRef pThis, IntPtr bounds);

		public override void GetBounds(IntPtr bounds)
		{
			vtkPlotBar.vtkPlotBar_GetBounds_01(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlotBar_GetColor_02(HandleRef pThis, IntPtr rgb);

		public override void GetColor(IntPtr rgb)
		{
			vtkPlotBar.vtkPlotBar_GetColor_02(base.GetCppThis(), rgb);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPlotBar_GetColorSeries_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkColorSeries GetColorSeries()
		{
			vtkColorSeries vtkColorSeries = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlotBar.vtkPlotBar_GetColorSeries_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkColorSeries = (vtkColorSeries)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkColorSeries.Register(null);
				}
			}
			return vtkColorSeries;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPlotBar_GetLabels_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkStringArray GetLabels()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlotBar.vtkPlotBar_GetLabels_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern float vtkPlotBar_GetOffset_05(HandleRef pThis);

		public virtual float GetOffset()
		{
			return vtkPlotBar.vtkPlotBar_GetOffset_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkPlotBar_GetOrientation_06(HandleRef pThis);

		public virtual int GetOrientation()
		{
			return vtkPlotBar.vtkPlotBar_GetOrientation_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern float vtkPlotBar_GetWidth_07(HandleRef pThis);

		public override float GetWidth()
		{
			return vtkPlotBar.vtkPlotBar_GetWidth_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkPlotBar_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPlotBar.vtkPlotBar_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkPlotBar_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPlotBar.vtkPlotBar_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPlotBar_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPlotBar NewInstance()
		{
			vtkPlotBar result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlotBar.vtkPlotBar_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotBar)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkPlotBar_Paint_12(HandleRef pThis, HandleRef painter);

		public override bool Paint(vtkContext2D painter)
		{
			return vtkPlotBar.vtkPlotBar_Paint_12(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPlotBar_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPlotBar SafeDownCast(vtkObjectBase o)
		{
			vtkPlotBar vtkPlotBar = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlotBar.vtkPlotBar_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlotBar = (vtkPlotBar)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlotBar.Register(null);
				}
			}
			return vtkPlotBar;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlotBar_SetColor_14(HandleRef pThis, byte r, byte g, byte b, byte a);

		public override void SetColor(byte r, byte g, byte b, byte a)
		{
			vtkPlotBar.vtkPlotBar_SetColor_14(base.GetCppThis(), r, g, b, a);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlotBar_SetColor_15(HandleRef pThis, double r, double g, double b);

		public override void SetColor(double r, double g, double b)
		{
			vtkPlotBar.vtkPlotBar_SetColor_15(base.GetCppThis(), r, g, b);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlotBar_SetColorSeries_16(HandleRef pThis, HandleRef colorSeries);

		public void SetColorSeries(vtkColorSeries colorSeries)
		{
			vtkPlotBar.vtkPlotBar_SetColorSeries_16(base.GetCppThis(), (colorSeries == null) ? default(HandleRef) : colorSeries.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlotBar_SetOffset_17(HandleRef pThis, float _arg);

		public virtual void SetOffset(float _arg)
		{
			vtkPlotBar.vtkPlotBar_SetOffset_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlotBar_SetOrientation_18(HandleRef pThis, int orientation);

		public virtual void SetOrientation(int orientation)
		{
			vtkPlotBar.vtkPlotBar_SetOrientation_18(base.GetCppThis(), orientation);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlotBar_SetWidth_19(HandleRef pThis, float _arg);

		public override void SetWidth(float _arg)
		{
			vtkPlotBar.vtkPlotBar_SetWidth_19(base.GetCppThis(), _arg);
		}
	}
}
