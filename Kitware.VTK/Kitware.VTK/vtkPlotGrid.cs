using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPlotGrid : vtkContextItem
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPlotGrid";

		public new static readonly string MRClassNameKey;

		static vtkPlotGrid()
		{
			vtkPlotGrid.MRClassNameKey = "class vtkPlotGrid";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPlotGrid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlotGrid"));
		}

		public vtkPlotGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPlotGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPlotGrid New()
		{
			vtkPlotGrid result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlotGrid.vtkPlotGrid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPlotGrid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPlotGrid.vtkPlotGrid_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkPlotGrid_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPlotGrid.vtkPlotGrid_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkPlotGrid_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPlotGrid.vtkPlotGrid_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPlotGrid_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPlotGrid NewInstance()
		{
			vtkPlotGrid result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlotGrid.vtkPlotGrid_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkPlotGrid_Paint_05(HandleRef pThis, HandleRef painter);

		public override bool Paint(vtkContext2D painter)
		{
			return vtkPlotGrid.vtkPlotGrid_Paint_05(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPlotGrid_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPlotGrid SafeDownCast(vtkObjectBase o)
		{
			vtkPlotGrid vtkPlotGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlotGrid.vtkPlotGrid_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlotGrid = (vtkPlotGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlotGrid.Register(null);
				}
			}
			return vtkPlotGrid;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlotGrid_SetXAxis_07(HandleRef pThis, HandleRef axis);

		public virtual void SetXAxis(vtkAxis axis)
		{
			vtkPlotGrid.vtkPlotGrid_SetXAxis_07(base.GetCppThis(), (axis == null) ? default(HandleRef) : axis.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlotGrid_SetYAxis_08(HandleRef pThis, HandleRef axis);

		public virtual void SetYAxis(vtkAxis axis)
		{
			vtkPlotGrid.vtkPlotGrid_SetYAxis_08(base.GetCppThis(), (axis == null) ? default(HandleRef) : axis.GetCppThis());
		}
	}
}
