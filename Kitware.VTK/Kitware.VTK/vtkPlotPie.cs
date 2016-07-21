using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPlotPie : vtkPlot
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPlotPie";

		public new static readonly string MRClassNameKey;

		static vtkPlotPie()
		{
			vtkPlotPie.MRClassNameKey = "class vtkPlotPie";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPlotPie.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlotPie"));
		}

		public vtkPlotPie(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPlotPie_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPlotPie New()
		{
			vtkPlotPie result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlotPie.vtkPlotPie_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotPie)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPlotPie() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPlotPie.vtkPlotPie_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPlotPie_GetColorSeries_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkColorSeries GetColorSeries()
		{
			vtkColorSeries vtkColorSeries = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlotPie.vtkPlotPie_GetColorSeries_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkPlotPie_GetDimensions_02(HandleRef pThis);

		public virtual int[] GetDimensions()
		{
			IntPtr intPtr = vtkPlotPie.vtkPlotPie_GetDimensions_02(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlotPie_GetDimensions_03(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4);

		public virtual void GetDimensions(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4)
		{
			vtkPlotPie.vtkPlotPie_GetDimensions_03(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlotPie_GetDimensions_04(HandleRef pThis, IntPtr _arg);

		public virtual void GetDimensions(IntPtr _arg)
		{
			vtkPlotPie.vtkPlotPie_GetDimensions_04(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkPlotPie_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPlotPie.vtkPlotPie_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkPlotPie_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPlotPie.vtkPlotPie_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPlotPie_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPlotPie NewInstance()
		{
			vtkPlotPie result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlotPie.vtkPlotPie_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotPie)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkPlotPie_Paint_09(HandleRef pThis, HandleRef painter);

		public override bool Paint(vtkContext2D painter)
		{
			return vtkPlotPie.vtkPlotPie_Paint_09(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPlotPie_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPlotPie SafeDownCast(vtkObjectBase o)
		{
			vtkPlotPie vtkPlotPie = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlotPie.vtkPlotPie_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlotPie = (vtkPlotPie)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlotPie.Register(null);
				}
			}
			return vtkPlotPie;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlotPie_SetColorSeries_11(HandleRef pThis, HandleRef colorSeries);

		public void SetColorSeries(vtkColorSeries colorSeries)
		{
			vtkPlotPie.vtkPlotPie_SetColorSeries_11(base.GetCppThis(), (colorSeries == null) ? default(HandleRef) : colorSeries.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlotPie_SetDimensions_12(HandleRef pThis, int arg1, int arg2, int arg3, int arg4);

		public void SetDimensions(int arg1, int arg2, int arg3, int arg4)
		{
			vtkPlotPie.vtkPlotPie_SetDimensions_12(base.GetCppThis(), arg1, arg2, arg3, arg4);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlotPie_SetDimensions_13(HandleRef pThis, IntPtr arg);

		public void SetDimensions(IntPtr arg)
		{
			vtkPlotPie.vtkPlotPie_SetDimensions_13(base.GetCppThis(), arg);
		}
	}
}
