using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPlotParallelCoordinates : vtkPlot
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPlotParallelCoordinates";

		public new static readonly string MRClassNameKey;

		static vtkPlotParallelCoordinates()
		{
			vtkPlotParallelCoordinates.MRClassNameKey = "class vtkPlotParallelCoordinates";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPlotParallelCoordinates.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlotParallelCoordinates"));
		}

		public vtkPlotParallelCoordinates(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPlotParallelCoordinates_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPlotParallelCoordinates New()
		{
			vtkPlotParallelCoordinates result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotParallelCoordinates)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPlotParallelCoordinates() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlotParallelCoordinates_CreateDefaultLookupTable_01(HandleRef pThis);

		public virtual void CreateDefaultLookupTable()
		{
			vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_CreateDefaultLookupTable_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlotParallelCoordinates_GetBounds_02(HandleRef pThis, IntPtr bounds);

		public override void GetBounds(IntPtr bounds)
		{
			vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_GetBounds_02(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPlotParallelCoordinates_GetLookupTable_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkScalarsToColors GetLookupTable()
		{
			vtkScalarsToColors vtkScalarsToColors = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_GetLookupTable_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarsToColors = (vtkScalarsToColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarsToColors.Register(null);
				}
			}
			return vtkScalarsToColors;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkPlotParallelCoordinates_GetScalarVisibility_04(HandleRef pThis);

		public virtual int GetScalarVisibility()
		{
			return vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_GetScalarVisibility_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkPlotParallelCoordinates_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkPlotParallelCoordinates_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPlotParallelCoordinates_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPlotParallelCoordinates NewInstance()
		{
			vtkPlotParallelCoordinates result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotParallelCoordinates)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkPlotParallelCoordinates_Paint_09(HandleRef pThis, HandleRef painter);

		public override bool Paint(vtkContext2D painter)
		{
			return vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_Paint_09(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkPlotParallelCoordinates_ResetSelectionRange_10(HandleRef pThis);

		public bool ResetSelectionRange()
		{
			return vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_ResetSelectionRange_10(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPlotParallelCoordinates_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPlotParallelCoordinates SafeDownCast(vtkObjectBase o)
		{
			vtkPlotParallelCoordinates vtkPlotParallelCoordinates = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlotParallelCoordinates = (vtkPlotParallelCoordinates)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlotParallelCoordinates.Register(null);
				}
			}
			return vtkPlotParallelCoordinates;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlotParallelCoordinates_ScalarVisibilityOff_12(HandleRef pThis);

		public virtual void ScalarVisibilityOff()
		{
			vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_ScalarVisibilityOff_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlotParallelCoordinates_ScalarVisibilityOn_13(HandleRef pThis);

		public virtual void ScalarVisibilityOn()
		{
			vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_ScalarVisibilityOn_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlotParallelCoordinates_SelectColorArray_14(HandleRef pThis, long arrayNum);

		public void SelectColorArray(long arrayNum)
		{
			vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_SelectColorArray_14(base.GetCppThis(), arrayNum);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlotParallelCoordinates_SetInput_15(HandleRef pThis, HandleRef table);

		public override void SetInput(vtkTable table)
		{
			vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_SetInput_15(base.GetCppThis(), (table == null) ? default(HandleRef) : table.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlotParallelCoordinates_SetLookupTable_16(HandleRef pThis, HandleRef lut);

		public void SetLookupTable(vtkScalarsToColors lut)
		{
			vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_SetLookupTable_16(base.GetCppThis(), (lut == null) ? default(HandleRef) : lut.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlotParallelCoordinates_SetScalarVisibility_17(HandleRef pThis, int _arg);

		public virtual void SetScalarVisibility(int _arg)
		{
			vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_SetScalarVisibility_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkPlotParallelCoordinates_SetSelectionRange_18(HandleRef pThis, int Axis, float low, float high);

		public bool SetSelectionRange(int Axis, float low, float high)
		{
			return vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_SetSelectionRange_18(base.GetCppThis(), Axis, low, high) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlotParallelCoordinates_Update_19(HandleRef pThis);

		public override void Update()
		{
			vtkPlotParallelCoordinates.vtkPlotParallelCoordinates_Update_19(base.GetCppThis());
		}
	}
}
