using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkColorLegend : vtkChartLegend
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkColorLegend";

		public new static readonly string MRClassNameKey;

		static vtkColorLegend()
		{
			vtkColorLegend.MRClassNameKey = "class vtkColorLegend";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkColorLegend.MRClassNameKey, Type.GetType("Kitware.VTK.vtkColorLegend"));
		}

		public vtkColorLegend(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkColorLegend_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkColorLegend New()
		{
			vtkColorLegend result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkColorLegend.vtkColorLegend_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkColorLegend)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkColorLegend() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkColorLegend.vtkColorLegend_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkColorLegend_GetBounds_01(HandleRef pThis, IntPtr bounds);

		public virtual void GetBounds(IntPtr bounds)
		{
			vtkColorLegend.vtkColorLegend_GetBounds_01(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkColorLegend_GetTransferFunction_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkScalarsToColors GetTransferFunction()
		{
			vtkScalarsToColors vtkScalarsToColors = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkColorLegend.vtkColorLegend_GetTransferFunction_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkColorLegend_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkColorLegend.vtkColorLegend_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkColorLegend_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkColorLegend.vtkColorLegend_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkColorLegend_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkColorLegend NewInstance()
		{
			vtkColorLegend result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkColorLegend.vtkColorLegend_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkColorLegend)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkColorLegend_Paint_07(HandleRef pThis, HandleRef painter);

		public override bool Paint(vtkContext2D painter)
		{
			return vtkColorLegend.vtkColorLegend_Paint_07(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkColorLegend_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkColorLegend SafeDownCast(vtkObjectBase o)
		{
			vtkColorLegend vtkColorLegend = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkColorLegend.vtkColorLegend_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkColorLegend = (vtkColorLegend)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkColorLegend.Register(null);
				}
			}
			return vtkColorLegend;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkColorLegend_SetTransferFunction_09(HandleRef pThis, HandleRef transfer);

		public virtual void SetTransferFunction(vtkScalarsToColors transfer)
		{
			vtkColorLegend.vtkColorLegend_SetTransferFunction_09(base.GetCppThis(), (transfer == null) ? default(HandleRef) : transfer.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkColorLegend_Update_10(HandleRef pThis);

		public override void Update()
		{
			vtkColorLegend.vtkColorLegend_Update_10(base.GetCppThis());
		}
	}
}
