using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGraphLayoutFilter : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGraphLayoutFilter";

		public new static readonly string MRClassNameKey;

		static vtkGraphLayoutFilter()
		{
			vtkGraphLayoutFilter.MRClassNameKey = "class vtkGraphLayoutFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGraphLayoutFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGraphLayoutFilter"));
		}

		public vtkGraphLayoutFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphLayoutFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGraphLayoutFilter New()
		{
			vtkGraphLayoutFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphLayoutFilter.vtkGraphLayoutFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphLayoutFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGraphLayoutFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGraphLayoutFilter.vtkGraphLayoutFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutFilter_AutomaticBoundsComputationOff_01(HandleRef pThis);

		public virtual void AutomaticBoundsComputationOff()
		{
			vtkGraphLayoutFilter.vtkGraphLayoutFilter_AutomaticBoundsComputationOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutFilter_AutomaticBoundsComputationOn_02(HandleRef pThis);

		public virtual void AutomaticBoundsComputationOn()
		{
			vtkGraphLayoutFilter.vtkGraphLayoutFilter_AutomaticBoundsComputationOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGraphLayoutFilter_GetAutomaticBoundsComputation_03(HandleRef pThis);

		public virtual int GetAutomaticBoundsComputation()
		{
			return vtkGraphLayoutFilter.vtkGraphLayoutFilter_GetAutomaticBoundsComputation_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkGraphLayoutFilter_GetCoolDownRate_04(HandleRef pThis);

		public virtual double GetCoolDownRate()
		{
			return vtkGraphLayoutFilter.vtkGraphLayoutFilter_GetCoolDownRate_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkGraphLayoutFilter_GetCoolDownRateMaxValue_05(HandleRef pThis);

		public virtual double GetCoolDownRateMaxValue()
		{
			return vtkGraphLayoutFilter.vtkGraphLayoutFilter_GetCoolDownRateMaxValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkGraphLayoutFilter_GetCoolDownRateMinValue_06(HandleRef pThis);

		public virtual double GetCoolDownRateMinValue()
		{
			return vtkGraphLayoutFilter.vtkGraphLayoutFilter_GetCoolDownRateMinValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphLayoutFilter_GetGraphBounds_07(HandleRef pThis);

		public virtual double[] GetGraphBounds()
		{
			IntPtr intPtr = vtkGraphLayoutFilter.vtkGraphLayoutFilter_GetGraphBounds_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutFilter_GetGraphBounds_08(HandleRef pThis, IntPtr data);

		public virtual void GetGraphBounds(IntPtr data)
		{
			vtkGraphLayoutFilter.vtkGraphLayoutFilter_GetGraphBounds_08(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGraphLayoutFilter_GetMaxNumberOfIterations_09(HandleRef pThis);

		public virtual int GetMaxNumberOfIterations()
		{
			return vtkGraphLayoutFilter.vtkGraphLayoutFilter_GetMaxNumberOfIterations_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGraphLayoutFilter_GetMaxNumberOfIterationsMaxValue_10(HandleRef pThis);

		public virtual int GetMaxNumberOfIterationsMaxValue()
		{
			return vtkGraphLayoutFilter.vtkGraphLayoutFilter_GetMaxNumberOfIterationsMaxValue_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGraphLayoutFilter_GetMaxNumberOfIterationsMinValue_11(HandleRef pThis);

		public virtual int GetMaxNumberOfIterationsMinValue()
		{
			return vtkGraphLayoutFilter.vtkGraphLayoutFilter_GetMaxNumberOfIterationsMinValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGraphLayoutFilter_GetThreeDimensionalLayout_12(HandleRef pThis);

		public virtual int GetThreeDimensionalLayout()
		{
			return vtkGraphLayoutFilter.vtkGraphLayoutFilter_GetThreeDimensionalLayout_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGraphLayoutFilter_IsA_13(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGraphLayoutFilter.vtkGraphLayoutFilter_IsA_13(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkGraphLayoutFilter_IsTypeOf_14(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGraphLayoutFilter.vtkGraphLayoutFilter_IsTypeOf_14(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphLayoutFilter_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGraphLayoutFilter NewInstance()
		{
			vtkGraphLayoutFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphLayoutFilter.vtkGraphLayoutFilter_NewInstance_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphLayoutFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphLayoutFilter_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGraphLayoutFilter SafeDownCast(vtkObjectBase o)
		{
			vtkGraphLayoutFilter vtkGraphLayoutFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphLayoutFilter.vtkGraphLayoutFilter_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraphLayoutFilter = (vtkGraphLayoutFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraphLayoutFilter.Register(null);
				}
			}
			return vtkGraphLayoutFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutFilter_SetAutomaticBoundsComputation_18(HandleRef pThis, int _arg);

		public virtual void SetAutomaticBoundsComputation(int _arg)
		{
			vtkGraphLayoutFilter.vtkGraphLayoutFilter_SetAutomaticBoundsComputation_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutFilter_SetCoolDownRate_19(HandleRef pThis, double _arg);

		public virtual void SetCoolDownRate(double _arg)
		{
			vtkGraphLayoutFilter.vtkGraphLayoutFilter_SetCoolDownRate_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutFilter_SetGraphBounds_20(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		public virtual void SetGraphBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkGraphLayoutFilter.vtkGraphLayoutFilter_SetGraphBounds_20(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutFilter_SetGraphBounds_21(HandleRef pThis, IntPtr _arg);

		public virtual void SetGraphBounds(IntPtr _arg)
		{
			vtkGraphLayoutFilter.vtkGraphLayoutFilter_SetGraphBounds_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutFilter_SetMaxNumberOfIterations_22(HandleRef pThis, int _arg);

		public virtual void SetMaxNumberOfIterations(int _arg)
		{
			vtkGraphLayoutFilter.vtkGraphLayoutFilter_SetMaxNumberOfIterations_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutFilter_SetThreeDimensionalLayout_23(HandleRef pThis, int _arg);

		public virtual void SetThreeDimensionalLayout(int _arg)
		{
			vtkGraphLayoutFilter.vtkGraphLayoutFilter_SetThreeDimensionalLayout_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutFilter_ThreeDimensionalLayoutOff_24(HandleRef pThis);

		public virtual void ThreeDimensionalLayoutOff()
		{
			vtkGraphLayoutFilter.vtkGraphLayoutFilter_ThreeDimensionalLayoutOff_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkGraphLayoutFilter_ThreeDimensionalLayoutOn_25(HandleRef pThis);

		public virtual void ThreeDimensionalLayoutOn()
		{
			vtkGraphLayoutFilter.vtkGraphLayoutFilter_ThreeDimensionalLayoutOn_25(base.GetCppThis());
		}
	}
}
