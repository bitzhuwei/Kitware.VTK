using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTemporalSnapToTimeStep : vtkTemporalDataSetAlgorithm
	{
		public enum VTK_SNAP_NEAREST_WrapperEnum
		{
			VTK_SNAP_NEAREST,
			VTK_SNAP_NEXTABOVE_OR_EQUAL = 2,
			VTK_SNAP_NEXTBELOW_OR_EQUAL = 1
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkTemporalSnapToTimeStep";

		public new static readonly string MRClassNameKey;

		static vtkTemporalSnapToTimeStep()
		{
			vtkTemporalSnapToTimeStep.MRClassNameKey = "class vtkTemporalSnapToTimeStep";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTemporalSnapToTimeStep.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTemporalSnapToTimeStep"));
		}

		public vtkTemporalSnapToTimeStep(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkTemporalSnapToTimeStep_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTemporalSnapToTimeStep New()
		{
			vtkTemporalSnapToTimeStep result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTemporalSnapToTimeStep.vtkTemporalSnapToTimeStep_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTemporalSnapToTimeStep)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTemporalSnapToTimeStep() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTemporalSnapToTimeStep.vtkTemporalSnapToTimeStep_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkTemporalSnapToTimeStep_GetSnapMode_01(HandleRef pThis);

		public virtual int GetSnapMode()
		{
			return vtkTemporalSnapToTimeStep.vtkTemporalSnapToTimeStep_GetSnapMode_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkTemporalSnapToTimeStep_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTemporalSnapToTimeStep.vtkTemporalSnapToTimeStep_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkTemporalSnapToTimeStep_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTemporalSnapToTimeStep.vtkTemporalSnapToTimeStep_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkTemporalSnapToTimeStep_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTemporalSnapToTimeStep NewInstance()
		{
			vtkTemporalSnapToTimeStep result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTemporalSnapToTimeStep.vtkTemporalSnapToTimeStep_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTemporalSnapToTimeStep)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkTemporalSnapToTimeStep_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTemporalSnapToTimeStep SafeDownCast(vtkObjectBase o)
		{
			vtkTemporalSnapToTimeStep vtkTemporalSnapToTimeStep = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTemporalSnapToTimeStep.vtkTemporalSnapToTimeStep_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTemporalSnapToTimeStep = (vtkTemporalSnapToTimeStep)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTemporalSnapToTimeStep.Register(null);
				}
			}
			return vtkTemporalSnapToTimeStep;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkTemporalSnapToTimeStep_SetSnapMode_07(HandleRef pThis, int _arg);

		public virtual void SetSnapMode(int _arg)
		{
			vtkTemporalSnapToTimeStep.vtkTemporalSnapToTimeStep_SetSnapMode_07(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkTemporalSnapToTimeStep_SetSnapModeToNearest_08(HandleRef pThis);

		public void SetSnapModeToNearest()
		{
			vtkTemporalSnapToTimeStep.vtkTemporalSnapToTimeStep_SetSnapModeToNearest_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkTemporalSnapToTimeStep_SetSnapModeToNextAboveOrEqual_09(HandleRef pThis);

		public void SetSnapModeToNextAboveOrEqual()
		{
			vtkTemporalSnapToTimeStep.vtkTemporalSnapToTimeStep_SetSnapModeToNextAboveOrEqual_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkTemporalSnapToTimeStep_SetSnapModeToNextBelowOrEqual_10(HandleRef pThis);

		public void SetSnapModeToNextBelowOrEqual()
		{
			vtkTemporalSnapToTimeStep.vtkTemporalSnapToTimeStep_SetSnapModeToNextBelowOrEqual_10(base.GetCppThis());
		}
	}
}
