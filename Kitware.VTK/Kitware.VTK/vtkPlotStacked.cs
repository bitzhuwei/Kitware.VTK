using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPlotStacked : vtkPlot
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPlotStacked";

		public new static readonly string MRClassNameKey;

		static vtkPlotStacked()
		{
			vtkPlotStacked.MRClassNameKey = "class vtkPlotStacked";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPlotStacked.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlotStacked"));
		}

		public vtkPlotStacked(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPlotStacked_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPlotStacked New()
		{
			vtkPlotStacked result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlotStacked.vtkPlotStacked_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotStacked)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPlotStacked() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPlotStacked.vtkPlotStacked_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlotStacked_GetBounds_01(HandleRef pThis, IntPtr bounds);

		public override void GetBounds(IntPtr bounds)
		{
			vtkPlotStacked.vtkPlotStacked_GetBounds_01(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlotStacked_GetColor_02(HandleRef pThis, IntPtr rgb);

		public override void GetColor(IntPtr rgb)
		{
			vtkPlotStacked.vtkPlotStacked_GetColor_02(base.GetCppThis(), rgb);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPlotStacked_GetColorSeries_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkColorSeries GetColorSeries()
		{
			vtkColorSeries vtkColorSeries = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlotStacked.vtkPlotStacked_GetColorSeries_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkPlotStacked_GetLabels_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkStringArray GetLabels()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlotStacked.vtkPlotStacked_GetLabels_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkPlotStacked_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPlotStacked.vtkPlotStacked_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkPlotStacked_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPlotStacked.vtkPlotStacked_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPlotStacked_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPlotStacked NewInstance()
		{
			vtkPlotStacked result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlotStacked.vtkPlotStacked_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotStacked)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkPlotStacked_Paint_09(HandleRef pThis, HandleRef painter);

		public override bool Paint(vtkContext2D painter)
		{
			return vtkPlotStacked.vtkPlotStacked_Paint_09(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPlotStacked_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPlotStacked SafeDownCast(vtkObjectBase o)
		{
			vtkPlotStacked vtkPlotStacked = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlotStacked.vtkPlotStacked_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlotStacked = (vtkPlotStacked)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlotStacked.Register(null);
				}
			}
			return vtkPlotStacked;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlotStacked_SetColor_11(HandleRef pThis, byte r, byte g, byte b, byte a);

		public override void SetColor(byte r, byte g, byte b, byte a)
		{
			vtkPlotStacked.vtkPlotStacked_SetColor_11(base.GetCppThis(), r, g, b, a);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlotStacked_SetColor_12(HandleRef pThis, double r, double g, double b);

		public override void SetColor(double r, double g, double b)
		{
			vtkPlotStacked.vtkPlotStacked_SetColor_12(base.GetCppThis(), r, g, b);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlotStacked_SetColorSeries_13(HandleRef pThis, HandleRef colorSeries);

		public void SetColorSeries(vtkColorSeries colorSeries)
		{
			vtkPlotStacked.vtkPlotStacked_SetColorSeries_13(base.GetCppThis(), (colorSeries == null) ? default(HandleRef) : colorSeries.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlotStacked_Update_14(HandleRef pThis);

		public override void Update()
		{
			vtkPlotStacked.vtkPlotStacked_Update_14(base.GetCppThis());
		}
	}
}
