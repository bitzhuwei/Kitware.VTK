using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTemporalStatistics : vtkPassInputTypeAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTemporalStatistics";

		public new static readonly string MRClassNameKey;

		static vtkTemporalStatistics()
		{
			vtkTemporalStatistics.MRClassNameKey = "class vtkTemporalStatistics";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTemporalStatistics.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTemporalStatistics"));
		}

		public vtkTemporalStatistics(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTemporalStatistics_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTemporalStatistics New()
		{
			vtkTemporalStatistics result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTemporalStatistics.vtkTemporalStatistics_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTemporalStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTemporalStatistics() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTemporalStatistics.vtkTemporalStatistics_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTemporalStatistics_ComputeAverageOff_01(HandleRef pThis);

		public virtual void ComputeAverageOff()
		{
			vtkTemporalStatistics.vtkTemporalStatistics_ComputeAverageOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTemporalStatistics_ComputeAverageOn_02(HandleRef pThis);

		public virtual void ComputeAverageOn()
		{
			vtkTemporalStatistics.vtkTemporalStatistics_ComputeAverageOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTemporalStatistics_ComputeMaximumOff_03(HandleRef pThis);

		public virtual void ComputeMaximumOff()
		{
			vtkTemporalStatistics.vtkTemporalStatistics_ComputeMaximumOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTemporalStatistics_ComputeMaximumOn_04(HandleRef pThis);

		public virtual void ComputeMaximumOn()
		{
			vtkTemporalStatistics.vtkTemporalStatistics_ComputeMaximumOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTemporalStatistics_ComputeMinimumOff_05(HandleRef pThis);

		public virtual void ComputeMinimumOff()
		{
			vtkTemporalStatistics.vtkTemporalStatistics_ComputeMinimumOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTemporalStatistics_ComputeMinimumOn_06(HandleRef pThis);

		public virtual void ComputeMinimumOn()
		{
			vtkTemporalStatistics.vtkTemporalStatistics_ComputeMinimumOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTemporalStatistics_ComputeStandardDeviationOff_07(HandleRef pThis);

		public virtual void ComputeStandardDeviationOff()
		{
			vtkTemporalStatistics.vtkTemporalStatistics_ComputeStandardDeviationOff_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTemporalStatistics_ComputeStandardDeviationOn_08(HandleRef pThis);

		public virtual void ComputeStandardDeviationOn()
		{
			vtkTemporalStatistics.vtkTemporalStatistics_ComputeStandardDeviationOn_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTemporalStatistics_GetComputeAverage_09(HandleRef pThis);

		public virtual int GetComputeAverage()
		{
			return vtkTemporalStatistics.vtkTemporalStatistics_GetComputeAverage_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTemporalStatistics_GetComputeMaximum_10(HandleRef pThis);

		public virtual int GetComputeMaximum()
		{
			return vtkTemporalStatistics.vtkTemporalStatistics_GetComputeMaximum_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTemporalStatistics_GetComputeMinimum_11(HandleRef pThis);

		public virtual int GetComputeMinimum()
		{
			return vtkTemporalStatistics.vtkTemporalStatistics_GetComputeMinimum_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTemporalStatistics_GetComputeStandardDeviation_12(HandleRef pThis);

		public virtual int GetComputeStandardDeviation()
		{
			return vtkTemporalStatistics.vtkTemporalStatistics_GetComputeStandardDeviation_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTemporalStatistics_IsA_13(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTemporalStatistics.vtkTemporalStatistics_IsA_13(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkTemporalStatistics_IsTypeOf_14(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTemporalStatistics.vtkTemporalStatistics_IsTypeOf_14(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTemporalStatistics_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTemporalStatistics NewInstance()
		{
			vtkTemporalStatistics result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTemporalStatistics.vtkTemporalStatistics_NewInstance_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTemporalStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkTemporalStatistics_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTemporalStatistics SafeDownCast(vtkObjectBase o)
		{
			vtkTemporalStatistics vtkTemporalStatistics = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTemporalStatistics.vtkTemporalStatistics_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTemporalStatistics = (vtkTemporalStatistics)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTemporalStatistics.Register(null);
				}
			}
			return vtkTemporalStatistics;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTemporalStatistics_SetComputeAverage_18(HandleRef pThis, int _arg);

		public virtual void SetComputeAverage(int _arg)
		{
			vtkTemporalStatistics.vtkTemporalStatistics_SetComputeAverage_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTemporalStatistics_SetComputeMaximum_19(HandleRef pThis, int _arg);

		public virtual void SetComputeMaximum(int _arg)
		{
			vtkTemporalStatistics.vtkTemporalStatistics_SetComputeMaximum_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTemporalStatistics_SetComputeMinimum_20(HandleRef pThis, int _arg);

		public virtual void SetComputeMinimum(int _arg)
		{
			vtkTemporalStatistics.vtkTemporalStatistics_SetComputeMinimum_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkTemporalStatistics_SetComputeStandardDeviation_21(HandleRef pThis, int _arg);

		public virtual void SetComputeStandardDeviation(int _arg)
		{
			vtkTemporalStatistics.vtkTemporalStatistics_SetComputeStandardDeviation_21(base.GetCppThis(), _arg);
		}
	}
}
