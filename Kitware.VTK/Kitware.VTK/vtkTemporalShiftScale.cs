using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTemporalShiftScale : vtkTemporalDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTemporalShiftScale";

		public new static readonly string MRClassNameKey;

		static vtkTemporalShiftScale()
		{
			vtkTemporalShiftScale.MRClassNameKey = "class vtkTemporalShiftScale";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTemporalShiftScale.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTemporalShiftScale"));
		}

		public vtkTemporalShiftScale(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkTemporalShiftScale_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTemporalShiftScale New()
		{
			vtkTemporalShiftScale result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTemporalShiftScale.vtkTemporalShiftScale_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTemporalShiftScale)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTemporalShiftScale() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTemporalShiftScale.vtkTemporalShiftScale_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkTemporalShiftScale_GetMaximumNumberOfPeriods_01(HandleRef pThis);

		public virtual double GetMaximumNumberOfPeriods()
		{
			return vtkTemporalShiftScale.vtkTemporalShiftScale_GetMaximumNumberOfPeriods_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkTemporalShiftScale_GetPeriodic_02(HandleRef pThis);

		public virtual int GetPeriodic()
		{
			return vtkTemporalShiftScale.vtkTemporalShiftScale_GetPeriodic_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkTemporalShiftScale_GetPeriodicEndCorrection_03(HandleRef pThis);

		public virtual int GetPeriodicEndCorrection()
		{
			return vtkTemporalShiftScale.vtkTemporalShiftScale_GetPeriodicEndCorrection_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkTemporalShiftScale_GetPostShift_04(HandleRef pThis);

		public virtual double GetPostShift()
		{
			return vtkTemporalShiftScale.vtkTemporalShiftScale_GetPostShift_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkTemporalShiftScale_GetPreShift_05(HandleRef pThis);

		public virtual double GetPreShift()
		{
			return vtkTemporalShiftScale.vtkTemporalShiftScale_GetPreShift_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkTemporalShiftScale_GetScale_06(HandleRef pThis);

		public virtual double GetScale()
		{
			return vtkTemporalShiftScale.vtkTemporalShiftScale_GetScale_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkTemporalShiftScale_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTemporalShiftScale.vtkTemporalShiftScale_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkTemporalShiftScale_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTemporalShiftScale.vtkTemporalShiftScale_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkTemporalShiftScale_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTemporalShiftScale NewInstance()
		{
			vtkTemporalShiftScale result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTemporalShiftScale.vtkTemporalShiftScale_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTemporalShiftScale)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkTemporalShiftScale_PeriodicEndCorrectionOff_11(HandleRef pThis);

		public virtual void PeriodicEndCorrectionOff()
		{
			vtkTemporalShiftScale.vtkTemporalShiftScale_PeriodicEndCorrectionOff_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkTemporalShiftScale_PeriodicEndCorrectionOn_12(HandleRef pThis);

		public virtual void PeriodicEndCorrectionOn()
		{
			vtkTemporalShiftScale.vtkTemporalShiftScale_PeriodicEndCorrectionOn_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkTemporalShiftScale_PeriodicOff_13(HandleRef pThis);

		public virtual void PeriodicOff()
		{
			vtkTemporalShiftScale.vtkTemporalShiftScale_PeriodicOff_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkTemporalShiftScale_PeriodicOn_14(HandleRef pThis);

		public virtual void PeriodicOn()
		{
			vtkTemporalShiftScale.vtkTemporalShiftScale_PeriodicOn_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkTemporalShiftScale_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTemporalShiftScale SafeDownCast(vtkObjectBase o)
		{
			vtkTemporalShiftScale vtkTemporalShiftScale = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTemporalShiftScale.vtkTemporalShiftScale_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTemporalShiftScale = (vtkTemporalShiftScale)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTemporalShiftScale.Register(null);
				}
			}
			return vtkTemporalShiftScale;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkTemporalShiftScale_SetMaximumNumberOfPeriods_16(HandleRef pThis, double _arg);

		public virtual void SetMaximumNumberOfPeriods(double _arg)
		{
			vtkTemporalShiftScale.vtkTemporalShiftScale_SetMaximumNumberOfPeriods_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkTemporalShiftScale_SetPeriodic_17(HandleRef pThis, int _arg);

		public virtual void SetPeriodic(int _arg)
		{
			vtkTemporalShiftScale.vtkTemporalShiftScale_SetPeriodic_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkTemporalShiftScale_SetPeriodicEndCorrection_18(HandleRef pThis, int _arg);

		public virtual void SetPeriodicEndCorrection(int _arg)
		{
			vtkTemporalShiftScale.vtkTemporalShiftScale_SetPeriodicEndCorrection_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkTemporalShiftScale_SetPostShift_19(HandleRef pThis, double _arg);

		public virtual void SetPostShift(double _arg)
		{
			vtkTemporalShiftScale.vtkTemporalShiftScale_SetPostShift_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkTemporalShiftScale_SetPreShift_20(HandleRef pThis, double _arg);

		public virtual void SetPreShift(double _arg)
		{
			vtkTemporalShiftScale.vtkTemporalShiftScale_SetPreShift_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkTemporalShiftScale_SetScale_21(HandleRef pThis, double _arg);

		public virtual void SetScale(double _arg)
		{
			vtkTemporalShiftScale.vtkTemporalShiftScale_SetScale_21(base.GetCppThis(), _arg);
		}
	}
}
