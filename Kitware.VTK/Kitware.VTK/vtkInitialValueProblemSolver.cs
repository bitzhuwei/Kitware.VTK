using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkInitialValueProblemSolver : vtkObject
	{
		public enum ErrorCodes
		{
			NOT_INITIALIZED = 2,
			OUT_OF_DOMAIN = 1,
			UNEXPECTED_VALUE = 3
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkInitialValueProblemSolver";

		public new static readonly string MRClassNameKey;

		static vtkInitialValueProblemSolver()
		{
			vtkInitialValueProblemSolver.MRClassNameKey = "class vtkInitialValueProblemSolver";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInitialValueProblemSolver.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInitialValueProblemSolver"));
		}

		public vtkInitialValueProblemSolver(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInitialValueProblemSolver_ComputeNextStep_01(HandleRef pThis, IntPtr xprev, IntPtr xnext, double t, ref double delT, double maxError, ref double error);

		public virtual int ComputeNextStep(IntPtr xprev, IntPtr xnext, double t, ref double delT, double maxError, ref double error)
		{
			return vtkInitialValueProblemSolver.vtkInitialValueProblemSolver_ComputeNextStep_01(base.GetCppThis(), xprev, xnext, t, ref delT, maxError, ref error);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInitialValueProblemSolver_ComputeNextStep_02(HandleRef pThis, IntPtr xprev, IntPtr dxprev, IntPtr xnext, double t, ref double delT, double maxError, ref double error);

		public virtual int ComputeNextStep(IntPtr xprev, IntPtr dxprev, IntPtr xnext, double t, ref double delT, double maxError, ref double error)
		{
			return vtkInitialValueProblemSolver.vtkInitialValueProblemSolver_ComputeNextStep_02(base.GetCppThis(), xprev, dxprev, xnext, t, ref delT, maxError, ref error);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInitialValueProblemSolver_ComputeNextStep_03(HandleRef pThis, IntPtr xprev, IntPtr xnext, double t, ref double delT, ref double delTActual, double minStep, double maxStep, double maxError, ref double error);

		public virtual int ComputeNextStep(IntPtr xprev, IntPtr xnext, double t, ref double delT, ref double delTActual, double minStep, double maxStep, double maxError, ref double error)
		{
			return vtkInitialValueProblemSolver.vtkInitialValueProblemSolver_ComputeNextStep_03(base.GetCppThis(), xprev, xnext, t, ref delT, ref delTActual, minStep, maxStep, maxError, ref error);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInitialValueProblemSolver_ComputeNextStep_04(HandleRef pThis, IntPtr xprev, IntPtr dxprev, IntPtr xnext, double t, ref double delT, ref double delTActual, double minStep, double maxStep, double maxError, ref double error);

		public virtual int ComputeNextStep(IntPtr xprev, IntPtr dxprev, IntPtr xnext, double t, ref double delT, ref double delTActual, double minStep, double maxStep, double maxError, ref double error)
		{
			return vtkInitialValueProblemSolver.vtkInitialValueProblemSolver_ComputeNextStep_04(base.GetCppThis(), xprev, dxprev, xnext, t, ref delT, ref delTActual, minStep, maxStep, maxError, ref error);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInitialValueProblemSolver_GetFunctionSet_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkFunctionSet GetFunctionSet()
		{
			vtkFunctionSet vtkFunctionSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInitialValueProblemSolver.vtkInitialValueProblemSolver_GetFunctionSet_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFunctionSet = (vtkFunctionSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFunctionSet.Register(null);
				}
			}
			return vtkFunctionSet;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInitialValueProblemSolver_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkInitialValueProblemSolver.vtkInitialValueProblemSolver_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInitialValueProblemSolver_IsAdaptive_07(HandleRef pThis);

		public virtual int IsAdaptive()
		{
			return vtkInitialValueProblemSolver.vtkInitialValueProblemSolver_IsAdaptive_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInitialValueProblemSolver_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkInitialValueProblemSolver.vtkInitialValueProblemSolver_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInitialValueProblemSolver_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkInitialValueProblemSolver NewInstance()
		{
			vtkInitialValueProblemSolver result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInitialValueProblemSolver.vtkInitialValueProblemSolver_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInitialValueProblemSolver)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInitialValueProblemSolver_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInitialValueProblemSolver SafeDownCast(vtkObjectBase o)
		{
			vtkInitialValueProblemSolver vtkInitialValueProblemSolver = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInitialValueProblemSolver.vtkInitialValueProblemSolver_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInitialValueProblemSolver = (vtkInitialValueProblemSolver)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInitialValueProblemSolver.Register(null);
				}
			}
			return vtkInitialValueProblemSolver;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInitialValueProblemSolver_SetFunctionSet_11(HandleRef pThis, HandleRef functionset);

		public virtual void SetFunctionSet(vtkFunctionSet functionset)
		{
			vtkInitialValueProblemSolver.vtkInitialValueProblemSolver_SetFunctionSet_11(base.GetCppThis(), (functionset == null) ? default(HandleRef) : functionset.GetCppThis());
		}
	}
}
