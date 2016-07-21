using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPlotPoints : vtkPlot
	{
		public enum CIRCLE_WrapperEnum
		{
			CIRCLE = 4,
			CROSS = 1,
			DIAMOND = 5,
			NONE = 0,
			PLUS = 2,
			SQUARE
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkPlotPoints";

		public new static readonly string MRClassNameKey;

		static vtkPlotPoints()
		{
			vtkPlotPoints.MRClassNameKey = "class vtkPlotPoints";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPlotPoints.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlotPoints"));
		}

		public vtkPlotPoints(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPlotPoints_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPlotPoints New()
		{
			vtkPlotPoints result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlotPoints.vtkPlotPoints_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPlotPoints() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPlotPoints.vtkPlotPoints_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlotPoints_CreateDefaultLookupTable_01(HandleRef pThis);

		public virtual void CreateDefaultLookupTable()
		{
			vtkPlotPoints.vtkPlotPoints_CreateDefaultLookupTable_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlotPoints_GetBounds_02(HandleRef pThis, IntPtr bounds);

		public override void GetBounds(IntPtr bounds)
		{
			vtkPlotPoints.vtkPlotPoints_GetBounds_02(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPlotPoints_GetLookupTable_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkScalarsToColors GetLookupTable()
		{
			vtkScalarsToColors vtkScalarsToColors = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlotPoints.vtkPlotPoints_GetLookupTable_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern float vtkPlotPoints_GetMarkerSize_04(HandleRef pThis);

		public virtual float GetMarkerSize()
		{
			return vtkPlotPoints.vtkPlotPoints_GetMarkerSize_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkPlotPoints_GetMarkerStyle_05(HandleRef pThis);

		public virtual int GetMarkerStyle()
		{
			return vtkPlotPoints.vtkPlotPoints_GetMarkerStyle_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkPlotPoints_GetScalarVisibility_06(HandleRef pThis);

		public virtual int GetScalarVisibility()
		{
			return vtkPlotPoints.vtkPlotPoints_GetScalarVisibility_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkPlotPoints_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPlotPoints.vtkPlotPoints_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkPlotPoints_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPlotPoints.vtkPlotPoints_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPlotPoints_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPlotPoints NewInstance()
		{
			vtkPlotPoints result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlotPoints.vtkPlotPoints_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkPlotPoints_Paint_11(HandleRef pThis, HandleRef painter);

		public override bool Paint(vtkContext2D painter)
		{
			return vtkPlotPoints.vtkPlotPoints_Paint_11(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPlotPoints_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPlotPoints SafeDownCast(vtkObjectBase o)
		{
			vtkPlotPoints vtkPlotPoints = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlotPoints.vtkPlotPoints_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlotPoints = (vtkPlotPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlotPoints.Register(null);
				}
			}
			return vtkPlotPoints;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlotPoints_ScalarVisibilityOff_13(HandleRef pThis);

		public virtual void ScalarVisibilityOff()
		{
			vtkPlotPoints.vtkPlotPoints_ScalarVisibilityOff_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlotPoints_ScalarVisibilityOn_14(HandleRef pThis);

		public virtual void ScalarVisibilityOn()
		{
			vtkPlotPoints.vtkPlotPoints_ScalarVisibilityOn_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlotPoints_SelectColorArray_15(HandleRef pThis, long arrayNum);

		public void SelectColorArray(long arrayNum)
		{
			vtkPlotPoints.vtkPlotPoints_SelectColorArray_15(base.GetCppThis(), arrayNum);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlotPoints_SetLookupTable_16(HandleRef pThis, HandleRef lut);

		public void SetLookupTable(vtkScalarsToColors lut)
		{
			vtkPlotPoints.vtkPlotPoints_SetLookupTable_16(base.GetCppThis(), (lut == null) ? default(HandleRef) : lut.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlotPoints_SetMarkerSize_17(HandleRef pThis, float _arg);

		public virtual void SetMarkerSize(float _arg)
		{
			vtkPlotPoints.vtkPlotPoints_SetMarkerSize_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlotPoints_SetMarkerStyle_18(HandleRef pThis, int _arg);

		public virtual void SetMarkerStyle(int _arg)
		{
			vtkPlotPoints.vtkPlotPoints_SetMarkerStyle_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlotPoints_SetScalarVisibility_19(HandleRef pThis, int _arg);

		public virtual void SetScalarVisibility(int _arg)
		{
			vtkPlotPoints.vtkPlotPoints_SetScalarVisibility_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlotPoints_Update_20(HandleRef pThis);

		public override void Update()
		{
			vtkPlotPoints.vtkPlotPoints_Update_20(base.GetCppThis());
		}
	}
}
