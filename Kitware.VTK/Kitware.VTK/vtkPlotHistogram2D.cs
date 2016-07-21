using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPlotHistogram2D : vtkPlot
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPlotHistogram2D";

		public new static readonly string MRClassNameKey;

		static vtkPlotHistogram2D()
		{
			vtkPlotHistogram2D.MRClassNameKey = "class vtkPlotHistogram2D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPlotHistogram2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlotHistogram2D"));
		}

		public vtkPlotHistogram2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPlotHistogram2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPlotHistogram2D New()
		{
			vtkPlotHistogram2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlotHistogram2D.vtkPlotHistogram2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotHistogram2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPlotHistogram2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPlotHistogram2D.vtkPlotHistogram2D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlotHistogram2D_GetBounds_01(HandleRef pThis, IntPtr bounds);

		public override void GetBounds(IntPtr bounds)
		{
			vtkPlotHistogram2D.vtkPlotHistogram2D_GetBounds_01(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPlotHistogram2D_GetInputImageData_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkImageData GetInputImageData()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlotHistogram2D.vtkPlotHistogram2D_GetInputImageData_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPlotHistogram2D_GetTransferFunction_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkScalarsToColors GetTransferFunction()
		{
			vtkScalarsToColors vtkScalarsToColors = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlotHistogram2D.vtkPlotHistogram2D_GetTransferFunction_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkPlotHistogram2D_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPlotHistogram2D.vtkPlotHistogram2D_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkPlotHistogram2D_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPlotHistogram2D.vtkPlotHistogram2D_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPlotHistogram2D_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPlotHistogram2D NewInstance()
		{
			vtkPlotHistogram2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlotHistogram2D.vtkPlotHistogram2D_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPlotHistogram2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern byte vtkPlotHistogram2D_Paint_08(HandleRef pThis, HandleRef painter);

		public override bool Paint(vtkContext2D painter)
		{
			return vtkPlotHistogram2D.vtkPlotHistogram2D_Paint_08(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkPlotHistogram2D_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPlotHistogram2D SafeDownCast(vtkObjectBase o)
		{
			vtkPlotHistogram2D vtkPlotHistogram2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPlotHistogram2D.vtkPlotHistogram2D_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlotHistogram2D = (vtkPlotHistogram2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlotHistogram2D.Register(null);
				}
			}
			return vtkPlotHistogram2D;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlotHistogram2D_SetInput_10(HandleRef pThis, HandleRef data, long z);

		public virtual void SetInput(vtkImageData data, long z)
		{
			vtkPlotHistogram2D.vtkPlotHistogram2D_SetInput_10(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), z);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlotHistogram2D_SetInput_11(HandleRef pThis, HandleRef arg0);

		public override void SetInput(vtkTable arg0)
		{
			vtkPlotHistogram2D.vtkPlotHistogram2D_SetInput_11(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlotHistogram2D_SetTransferFunction_12(HandleRef pThis, HandleRef transfer);

		public void SetTransferFunction(vtkScalarsToColors transfer)
		{
			vtkPlotHistogram2D.vtkPlotHistogram2D_SetTransferFunction_12(base.GetCppThis(), (transfer == null) ? default(HandleRef) : transfer.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkPlotHistogram2D_Update_13(HandleRef pThis);

		public override void Update()
		{
			vtkPlotHistogram2D.vtkPlotHistogram2D_Update_13(base.GetCppThis());
		}
	}
}
