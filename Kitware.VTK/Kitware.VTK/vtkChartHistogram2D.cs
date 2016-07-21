using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkChartHistogram2D : vtkChartXY
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkChartHistogram2D";

		public new static readonly string MRClassNameKey;

		static vtkChartHistogram2D()
		{
			vtkChartHistogram2D.MRClassNameKey = "class vtkChartHistogram2D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkChartHistogram2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkChartHistogram2D"));
		}

		public vtkChartHistogram2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkChartHistogram2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkChartHistogram2D New()
		{
			vtkChartHistogram2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkChartHistogram2D.vtkChartHistogram2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkChartHistogram2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkChartHistogram2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkChartHistogram2D.vtkChartHistogram2D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkChartHistogram2D_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkChartHistogram2D.vtkChartHistogram2D_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern int vtkChartHistogram2D_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkChartHistogram2D.vtkChartHistogram2D_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkChartHistogram2D_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkChartHistogram2D NewInstance()
		{
			vtkChartHistogram2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkChartHistogram2D.vtkChartHistogram2D_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkChartHistogram2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern IntPtr vtkChartHistogram2D_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkChartHistogram2D SafeDownCast(vtkObjectBase o)
		{
			vtkChartHistogram2D vtkChartHistogram2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkChartHistogram2D.vtkChartHistogram2D_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkChartHistogram2D = (vtkChartHistogram2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkChartHistogram2D.Register(null);
				}
			}
			return vtkChartHistogram2D;
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChartHistogram2D_SetInput_06(HandleRef pThis, HandleRef data, long z);

		public virtual void SetInput(vtkImageData data, long z)
		{
			vtkChartHistogram2D.vtkChartHistogram2D_SetInput_06(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), z);
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChartHistogram2D_SetTransferFunction_07(HandleRef pThis, HandleRef function);

		public virtual void SetTransferFunction(vtkScalarsToColors function)
		{
			vtkChartHistogram2D.vtkChartHistogram2D_SetTransferFunction_07(base.GetCppThis(), (function == null) ? default(HandleRef) : function.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCharts.Unmanaged.dll")]
		internal static extern void vtkChartHistogram2D_Update_08(HandleRef pThis);

		public override void Update()
		{
			vtkChartHistogram2D.vtkChartHistogram2D_Update_08(base.GetCppThis());
		}
	}
}
