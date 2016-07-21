using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkStreamTracer : vtkPolyDataAlgorithm
	{
		public enum BACKWARD_WrapperEnum
		{
			BACKWARD = 1,
			BOTH,
			FORWARD = 0
		}

		public enum INTERPOLATOR_WITH_CELL_LOCATOR_WrapperEnum
		{
			INTERPOLATOR_WITH_CELL_LOCATOR = 1,
			INTERPOLATOR_WITH_DATASET_POINT_LOCATOR = 0
		}

		public enum ReasonForTermination
		{
			NOT_INITIALIZED = 2,
			OUT_OF_DOMAIN = 1,
			OUT_OF_LENGTH = 4,
			OUT_OF_STEPS,
			STAGNATION,
			UNEXPECTED_VALUE = 3
		}

		public enum Solvers
		{
			NONE = 3,
			RUNGE_KUTTA2 = 0,
			RUNGE_KUTTA4,
			RUNGE_KUTTA45,
			UNKNOWN = 4
		}

		public enum Units
		{
			CELL_LENGTH_UNIT = 2,
			LENGTH_UNIT = 1
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkStreamTracer";

		public new static readonly string MRClassNameKey;

		static vtkStreamTracer()
		{
			vtkStreamTracer.MRClassNameKey = "class vtkStreamTracer";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStreamTracer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStreamTracer"));
		}

		public vtkStreamTracer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamTracer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStreamTracer New()
		{
			vtkStreamTracer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamTracer.vtkStreamTracer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStreamTracer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkStreamTracer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkStreamTracer.vtkStreamTracer_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern byte vtkStreamTracer_GetComputeVorticity_01(HandleRef pThis);

		public virtual bool GetComputeVorticity()
		{
			return vtkStreamTracer.vtkStreamTracer_GetComputeVorticity_01(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkStreamTracer_GetInitialIntegrationStep_02(HandleRef pThis);

		public virtual double GetInitialIntegrationStep()
		{
			return vtkStreamTracer.vtkStreamTracer_GetInitialIntegrationStep_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkStreamTracer_GetIntegrationDirection_03(HandleRef pThis);

		public virtual int GetIntegrationDirection()
		{
			return vtkStreamTracer.vtkStreamTracer_GetIntegrationDirection_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkStreamTracer_GetIntegrationDirectionMaxValue_04(HandleRef pThis);

		public virtual int GetIntegrationDirectionMaxValue()
		{
			return vtkStreamTracer.vtkStreamTracer_GetIntegrationDirectionMaxValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkStreamTracer_GetIntegrationDirectionMinValue_05(HandleRef pThis);

		public virtual int GetIntegrationDirectionMinValue()
		{
			return vtkStreamTracer.vtkStreamTracer_GetIntegrationDirectionMinValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkStreamTracer_GetIntegrationStepUnit_06(HandleRef pThis);

		public int GetIntegrationStepUnit()
		{
			return vtkStreamTracer.vtkStreamTracer_GetIntegrationStepUnit_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamTracer_GetIntegrator_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkInitialValueProblemSolver GetIntegrator()
		{
			vtkInitialValueProblemSolver vtkInitialValueProblemSolver = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamTracer.vtkStreamTracer_GetIntegrator_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkStreamTracer_GetIntegratorType_08(HandleRef pThis);

		public int GetIntegratorType()
		{
			return vtkStreamTracer.vtkStreamTracer_GetIntegratorType_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkStreamTracer_GetMaximumError_09(HandleRef pThis);

		public virtual double GetMaximumError()
		{
			return vtkStreamTracer.vtkStreamTracer_GetMaximumError_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkStreamTracer_GetMaximumIntegrationStep_10(HandleRef pThis);

		public virtual double GetMaximumIntegrationStep()
		{
			return vtkStreamTracer.vtkStreamTracer_GetMaximumIntegrationStep_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkStreamTracer_GetMaximumNumberOfSteps_11(HandleRef pThis);

		public virtual long GetMaximumNumberOfSteps()
		{
			return vtkStreamTracer.vtkStreamTracer_GetMaximumNumberOfSteps_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkStreamTracer_GetMaximumPropagation_12(HandleRef pThis);

		public virtual double GetMaximumPropagation()
		{
			return vtkStreamTracer.vtkStreamTracer_GetMaximumPropagation_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkStreamTracer_GetMinimumIntegrationStep_13(HandleRef pThis);

		public virtual double GetMinimumIntegrationStep()
		{
			return vtkStreamTracer.vtkStreamTracer_GetMinimumIntegrationStep_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkStreamTracer_GetRotationScale_14(HandleRef pThis);

		public virtual double GetRotationScale()
		{
			return vtkStreamTracer.vtkStreamTracer_GetRotationScale_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamTracer_GetSource_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataSet GetSource()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamTracer.vtkStreamTracer_GetSource_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamTracer_GetStartPosition_16(HandleRef pThis);

		public virtual double[] GetStartPosition()
		{
			IntPtr intPtr = vtkStreamTracer.vtkStreamTracer_GetStartPosition_16(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamTracer_GetStartPosition_17(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetStartPosition(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkStreamTracer.vtkStreamTracer_GetStartPosition_17(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamTracer_GetStartPosition_18(HandleRef pThis, IntPtr _arg);

		public virtual void GetStartPosition(IntPtr _arg)
		{
			vtkStreamTracer.vtkStreamTracer_GetStartPosition_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkStreamTracer_GetTerminalSpeed_19(HandleRef pThis);

		public virtual double GetTerminalSpeed()
		{
			return vtkStreamTracer.vtkStreamTracer_GetTerminalSpeed_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkStreamTracer_IsA_20(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkStreamTracer.vtkStreamTracer_IsA_20(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkStreamTracer_IsTypeOf_21(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkStreamTracer.vtkStreamTracer_IsTypeOf_21(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamTracer_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkStreamTracer NewInstance()
		{
			vtkStreamTracer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamTracer.vtkStreamTracer_NewInstance_23(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStreamTracer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamTracer_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStreamTracer SafeDownCast(vtkObjectBase o)
		{
			vtkStreamTracer vtkStreamTracer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamTracer.vtkStreamTracer_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStreamTracer = (vtkStreamTracer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStreamTracer.Register(null);
				}
			}
			return vtkStreamTracer;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamTracer_SetComputeVorticity_25(HandleRef pThis, byte _arg);

		public virtual void SetComputeVorticity(bool _arg)
		{
			vtkStreamTracer.vtkStreamTracer_SetComputeVorticity_25(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamTracer_SetInitialIntegrationStep_26(HandleRef pThis, double _arg);

		public virtual void SetInitialIntegrationStep(double _arg)
		{
			vtkStreamTracer.vtkStreamTracer_SetInitialIntegrationStep_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamTracer_SetIntegrationDirection_27(HandleRef pThis, int _arg);

		public virtual void SetIntegrationDirection(int _arg)
		{
			vtkStreamTracer.vtkStreamTracer_SetIntegrationDirection_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamTracer_SetIntegrationDirectionToBackward_28(HandleRef pThis);

		public void SetIntegrationDirectionToBackward()
		{
			vtkStreamTracer.vtkStreamTracer_SetIntegrationDirectionToBackward_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamTracer_SetIntegrationDirectionToBoth_29(HandleRef pThis);

		public void SetIntegrationDirectionToBoth()
		{
			vtkStreamTracer.vtkStreamTracer_SetIntegrationDirectionToBoth_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamTracer_SetIntegrationDirectionToForward_30(HandleRef pThis);

		public void SetIntegrationDirectionToForward()
		{
			vtkStreamTracer.vtkStreamTracer_SetIntegrationDirectionToForward_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamTracer_SetIntegrationStepUnit_31(HandleRef pThis, int unit);

		public void SetIntegrationStepUnit(int unit)
		{
			vtkStreamTracer.vtkStreamTracer_SetIntegrationStepUnit_31(base.GetCppThis(), unit);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamTracer_SetIntegrator_32(HandleRef pThis, HandleRef arg0);

		public void SetIntegrator(vtkInitialValueProblemSolver arg0)
		{
			vtkStreamTracer.vtkStreamTracer_SetIntegrator_32(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamTracer_SetIntegratorType_33(HandleRef pThis, int type);

		public void SetIntegratorType(int type)
		{
			vtkStreamTracer.vtkStreamTracer_SetIntegratorType_33(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamTracer_SetIntegratorTypeToRungeKutta2_34(HandleRef pThis);

		public void SetIntegratorTypeToRungeKutta2()
		{
			vtkStreamTracer.vtkStreamTracer_SetIntegratorTypeToRungeKutta2_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamTracer_SetIntegratorTypeToRungeKutta4_35(HandleRef pThis);

		public void SetIntegratorTypeToRungeKutta4()
		{
			vtkStreamTracer.vtkStreamTracer_SetIntegratorTypeToRungeKutta4_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamTracer_SetIntegratorTypeToRungeKutta45_36(HandleRef pThis);

		public void SetIntegratorTypeToRungeKutta45()
		{
			vtkStreamTracer.vtkStreamTracer_SetIntegratorTypeToRungeKutta45_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamTracer_SetInterpolatorPrototype_37(HandleRef pThis, HandleRef ivf);

		public void SetInterpolatorPrototype(vtkAbstractInterpolatedVelocityField ivf)
		{
			vtkStreamTracer.vtkStreamTracer_SetInterpolatorPrototype_37(base.GetCppThis(), (ivf == null) ? default(HandleRef) : ivf.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamTracer_SetInterpolatorType_38(HandleRef pThis, int interpType);

		public void SetInterpolatorType(int interpType)
		{
			vtkStreamTracer.vtkStreamTracer_SetInterpolatorType_38(base.GetCppThis(), interpType);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamTracer_SetInterpolatorTypeToCellLocator_39(HandleRef pThis);

		public void SetInterpolatorTypeToCellLocator()
		{
			vtkStreamTracer.vtkStreamTracer_SetInterpolatorTypeToCellLocator_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamTracer_SetInterpolatorTypeToDataSetPointLocator_40(HandleRef pThis);

		public void SetInterpolatorTypeToDataSetPointLocator()
		{
			vtkStreamTracer.vtkStreamTracer_SetInterpolatorTypeToDataSetPointLocator_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamTracer_SetMaximumError_41(HandleRef pThis, double _arg);

		public virtual void SetMaximumError(double _arg)
		{
			vtkStreamTracer.vtkStreamTracer_SetMaximumError_41(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamTracer_SetMaximumIntegrationStep_42(HandleRef pThis, double _arg);

		public virtual void SetMaximumIntegrationStep(double _arg)
		{
			vtkStreamTracer.vtkStreamTracer_SetMaximumIntegrationStep_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamTracer_SetMaximumNumberOfSteps_43(HandleRef pThis, long _arg);

		public virtual void SetMaximumNumberOfSteps(long _arg)
		{
			vtkStreamTracer.vtkStreamTracer_SetMaximumNumberOfSteps_43(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamTracer_SetMaximumPropagation_44(HandleRef pThis, double _arg);

		public virtual void SetMaximumPropagation(double _arg)
		{
			vtkStreamTracer.vtkStreamTracer_SetMaximumPropagation_44(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamTracer_SetMinimumIntegrationStep_45(HandleRef pThis, double _arg);

		public virtual void SetMinimumIntegrationStep(double _arg)
		{
			vtkStreamTracer.vtkStreamTracer_SetMinimumIntegrationStep_45(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamTracer_SetRotationScale_46(HandleRef pThis, double _arg);

		public virtual void SetRotationScale(double _arg)
		{
			vtkStreamTracer.vtkStreamTracer_SetRotationScale_46(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamTracer_SetSource_47(HandleRef pThis, HandleRef source);

		public void SetSource(vtkDataSet source)
		{
			vtkStreamTracer.vtkStreamTracer_SetSource_47(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamTracer_SetSourceConnection_48(HandleRef pThis, HandleRef algOutput);

		public void SetSourceConnection(vtkAlgorithmOutput algOutput)
		{
			vtkStreamTracer.vtkStreamTracer_SetSourceConnection_48(base.GetCppThis(), (algOutput == null) ? default(HandleRef) : algOutput.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamTracer_SetStartPosition_49(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetStartPosition(double _arg1, double _arg2, double _arg3)
		{
			vtkStreamTracer.vtkStreamTracer_SetStartPosition_49(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamTracer_SetStartPosition_50(HandleRef pThis, IntPtr _arg);

		public virtual void SetStartPosition(IntPtr _arg)
		{
			vtkStreamTracer.vtkStreamTracer_SetStartPosition_50(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamTracer_SetTerminalSpeed_51(HandleRef pThis, double _arg);

		public virtual void SetTerminalSpeed(double _arg)
		{
			vtkStreamTracer.vtkStreamTracer_SetTerminalSpeed_51(base.GetCppThis(), _arg);
		}
	}
}
