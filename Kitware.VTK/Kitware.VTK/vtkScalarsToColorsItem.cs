using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkScalarsToColorsItem : vtkPlot
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkScalarsToColorsItem";

		public new static readonly string MRClassNameKey;

		static vtkScalarsToColorsItem()
		{
			vtkScalarsToColorsItem.MRClassNameKey = "class vtkScalarsToColorsItem";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkScalarsToColorsItem.MRClassNameKey, Type.GetType("Kitware.VTK.vtkScalarsToColorsItem"));
		}

		public vtkScalarsToColorsItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkScalarsToColorsItem_GetBounds_01(HandleRef pThis, IntPtr bounds);

		public override void GetBounds(IntPtr bounds)
		{
			vtkScalarsToColorsItem.vtkScalarsToColorsItem_GetBounds_01(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkScalarsToColorsItem_GetMaskAboveCurve_02(HandleRef pThis);

		public virtual bool GetMaskAboveCurve()
		{
			return vtkScalarsToColorsItem.vtkScalarsToColorsItem_GetMaskAboveCurve_02(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkScalarsToColorsItem_GetPolyLinePen_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPen GetPolyLinePen()
		{
			vtkPen vtkPen = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkScalarsToColorsItem.vtkScalarsToColorsItem_GetPolyLinePen_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkScalarsToColorsItem_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkScalarsToColorsItem.vtkScalarsToColorsItem_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkScalarsToColorsItem_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkScalarsToColorsItem.vtkScalarsToColorsItem_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkScalarsToColorsItem_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkScalarsToColorsItem NewInstance()
		{
			vtkScalarsToColorsItem result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkScalarsToColorsItem.vtkScalarsToColorsItem_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkScalarsToColorsItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkScalarsToColorsItem_Paint_07(HandleRef pThis, HandleRef painter);

		public override bool Paint(vtkContext2D painter)
		{
			return vtkScalarsToColorsItem.vtkScalarsToColorsItem_Paint_07(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkScalarsToColorsItem_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkScalarsToColorsItem SafeDownCast(vtkObjectBase o)
		{
			vtkScalarsToColorsItem vtkScalarsToColorsItem = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkScalarsToColorsItem.vtkScalarsToColorsItem_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarsToColorsItem = (vtkScalarsToColorsItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarsToColorsItem.Register(null);
				}
			}
			return vtkScalarsToColorsItem;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkScalarsToColorsItem_SetMaskAboveCurve_09(HandleRef pThis, byte _arg);

		public virtual void SetMaskAboveCurve(bool _arg)
		{
			vtkScalarsToColorsItem.vtkScalarsToColorsItem_SetMaskAboveCurve_09(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}
	}
}
