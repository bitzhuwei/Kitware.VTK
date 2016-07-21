using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDecimatePolylineFilter : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDecimatePolylineFilter";

		public new static readonly string MRClassNameKey;

		static vtkDecimatePolylineFilter()
		{
			vtkDecimatePolylineFilter.MRClassNameKey = "class vtkDecimatePolylineFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDecimatePolylineFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDecimatePolylineFilter"));
		}

		public vtkDecimatePolylineFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDecimatePolylineFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDecimatePolylineFilter New()
		{
			vtkDecimatePolylineFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDecimatePolylineFilter.vtkDecimatePolylineFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDecimatePolylineFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDecimatePolylineFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDecimatePolylineFilter.vtkDecimatePolylineFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDecimatePolylineFilter_GetTargetReduction_01(HandleRef pThis);

		public virtual double GetTargetReduction()
		{
			return vtkDecimatePolylineFilter.vtkDecimatePolylineFilter_GetTargetReduction_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDecimatePolylineFilter_GetTargetReductionMaxValue_02(HandleRef pThis);

		public virtual double GetTargetReductionMaxValue()
		{
			return vtkDecimatePolylineFilter.vtkDecimatePolylineFilter_GetTargetReductionMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDecimatePolylineFilter_GetTargetReductionMinValue_03(HandleRef pThis);

		public virtual double GetTargetReductionMinValue()
		{
			return vtkDecimatePolylineFilter.vtkDecimatePolylineFilter_GetTargetReductionMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDecimatePolylineFilter_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDecimatePolylineFilter.vtkDecimatePolylineFilter_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDecimatePolylineFilter_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDecimatePolylineFilter.vtkDecimatePolylineFilter_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDecimatePolylineFilter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDecimatePolylineFilter NewInstance()
		{
			vtkDecimatePolylineFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDecimatePolylineFilter.vtkDecimatePolylineFilter_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDecimatePolylineFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDecimatePolylineFilter_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDecimatePolylineFilter SafeDownCast(vtkObjectBase o)
		{
			vtkDecimatePolylineFilter vtkDecimatePolylineFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDecimatePolylineFilter.vtkDecimatePolylineFilter_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDecimatePolylineFilter = (vtkDecimatePolylineFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDecimatePolylineFilter.Register(null);
				}
			}
			return vtkDecimatePolylineFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDecimatePolylineFilter_SetTargetReduction_09(HandleRef pThis, double _arg);

		public virtual void SetTargetReduction(double _arg)
		{
			vtkDecimatePolylineFilter.vtkDecimatePolylineFilter_SetTargetReduction_09(base.GetCppThis(), _arg);
		}
	}
}
