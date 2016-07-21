using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGenericStreamTracer : vtkPolyDataAlgorithm
	{
		public enum BACKWARD_WrapperEnum
		{
			BACKWARD = 1,
			BOTH,
			FORWARD = 0
		}

		public enum ReasonForTermination
		{
			NOT_INITIALIZED = 2,
			OUT_OF_DOMAIN = 1,
			OUT_OF_STEPS = 5,
			OUT_OF_TIME = 4,
			STAGNATION = 6,
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
			LENGTH_UNIT = 1,
			TIME_UNIT = 0
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericStreamTracer";

		public new static readonly string MRClassNameKey;

		static vtkGenericStreamTracer()
		{
			vtkGenericStreamTracer.MRClassNameKey = "class vtkGenericStreamTracer";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericStreamTracer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericStreamTracer"));
		}

		public vtkGenericStreamTracer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericStreamTracer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGenericStreamTracer New()
		{
			vtkGenericStreamTracer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericStreamTracer.vtkGenericStreamTracer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericStreamTracer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGenericStreamTracer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGenericStreamTracer.vtkGenericStreamTracer_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_AddInput_01(HandleRef pThis, HandleRef arg0);

		public void AddInput(vtkGenericDataSet arg0)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_AddInput_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_ComputeVorticityOff_02(HandleRef pThis);

		public virtual void ComputeVorticityOff()
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_ComputeVorticityOff_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_ComputeVorticityOn_03(HandleRef pThis);

		public virtual void ComputeVorticityOn()
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_ComputeVorticityOn_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericStreamTracer_FillInputPortInformation_04(HandleRef pThis, int port, HandleRef info);

		public virtual int FillInputPortInformation(int port, vtkInformation info)
		{
			return vtkGenericStreamTracer.vtkGenericStreamTracer_FillInputPortInformation_04(base.GetCppThis(), port, (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericStreamTracer_GetComputeVorticity_05(HandleRef pThis);

		public virtual int GetComputeVorticity()
		{
			return vtkGenericStreamTracer.vtkGenericStreamTracer_GetComputeVorticity_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern double vtkGenericStreamTracer_GetInitialIntegrationStep_06(HandleRef pThis);

		public double GetInitialIntegrationStep()
		{
			return vtkGenericStreamTracer.vtkGenericStreamTracer_GetInitialIntegrationStep_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericStreamTracer_GetInitialIntegrationStepUnit_07(HandleRef pThis);

		public int GetInitialIntegrationStepUnit()
		{
			return vtkGenericStreamTracer.vtkGenericStreamTracer_GetInitialIntegrationStepUnit_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericStreamTracer_GetInputVectorsSelection_08(HandleRef pThis);

		public virtual string GetInputVectorsSelection()
		{
			return Marshal.PtrToStringAnsi(vtkGenericStreamTracer.vtkGenericStreamTracer_GetInputVectorsSelection_08(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericStreamTracer_GetIntegrationDirection_09(HandleRef pThis);

		public virtual int GetIntegrationDirection()
		{
			return vtkGenericStreamTracer.vtkGenericStreamTracer_GetIntegrationDirection_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericStreamTracer_GetIntegrationDirectionMaxValue_10(HandleRef pThis);

		public virtual int GetIntegrationDirectionMaxValue()
		{
			return vtkGenericStreamTracer.vtkGenericStreamTracer_GetIntegrationDirectionMaxValue_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericStreamTracer_GetIntegrationDirectionMinValue_11(HandleRef pThis);

		public virtual int GetIntegrationDirectionMinValue()
		{
			return vtkGenericStreamTracer.vtkGenericStreamTracer_GetIntegrationDirectionMinValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericStreamTracer_GetIntegrator_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkInitialValueProblemSolver GetIntegrator()
		{
			vtkInitialValueProblemSolver vtkInitialValueProblemSolver = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericStreamTracer.vtkGenericStreamTracer_GetIntegrator_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericStreamTracer_GetIntegratorType_13(HandleRef pThis);

		public int GetIntegratorType()
		{
			return vtkGenericStreamTracer.vtkGenericStreamTracer_GetIntegratorType_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern double vtkGenericStreamTracer_GetMaximumError_14(HandleRef pThis);

		public virtual double GetMaximumError()
		{
			return vtkGenericStreamTracer.vtkGenericStreamTracer_GetMaximumError_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern double vtkGenericStreamTracer_GetMaximumIntegrationStep_15(HandleRef pThis);

		public double GetMaximumIntegrationStep()
		{
			return vtkGenericStreamTracer.vtkGenericStreamTracer_GetMaximumIntegrationStep_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericStreamTracer_GetMaximumIntegrationStepUnit_16(HandleRef pThis);

		public int GetMaximumIntegrationStepUnit()
		{
			return vtkGenericStreamTracer.vtkGenericStreamTracer_GetMaximumIntegrationStepUnit_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern long vtkGenericStreamTracer_GetMaximumNumberOfSteps_17(HandleRef pThis);

		public virtual long GetMaximumNumberOfSteps()
		{
			return vtkGenericStreamTracer.vtkGenericStreamTracer_GetMaximumNumberOfSteps_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern double vtkGenericStreamTracer_GetMaximumPropagation_18(HandleRef pThis);

		public double GetMaximumPropagation()
		{
			return vtkGenericStreamTracer.vtkGenericStreamTracer_GetMaximumPropagation_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericStreamTracer_GetMaximumPropagationUnit_19(HandleRef pThis);

		public int GetMaximumPropagationUnit()
		{
			return vtkGenericStreamTracer.vtkGenericStreamTracer_GetMaximumPropagationUnit_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern double vtkGenericStreamTracer_GetMinimumIntegrationStep_20(HandleRef pThis);

		public double GetMinimumIntegrationStep()
		{
			return vtkGenericStreamTracer.vtkGenericStreamTracer_GetMinimumIntegrationStep_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericStreamTracer_GetMinimumIntegrationStepUnit_21(HandleRef pThis);

		public int GetMinimumIntegrationStepUnit()
		{
			return vtkGenericStreamTracer.vtkGenericStreamTracer_GetMinimumIntegrationStepUnit_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern double vtkGenericStreamTracer_GetRotationScale_22(HandleRef pThis);

		public virtual double GetRotationScale()
		{
			return vtkGenericStreamTracer.vtkGenericStreamTracer_GetRotationScale_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericStreamTracer_GetSource_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataSet GetSource()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericStreamTracer.vtkGenericStreamTracer_GetSource_23(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericStreamTracer_GetStartPosition_24(HandleRef pThis);

		public virtual double[] GetStartPosition()
		{
			IntPtr intPtr = vtkGenericStreamTracer.vtkGenericStreamTracer_GetStartPosition_24(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_GetStartPosition_25(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetStartPosition(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_GetStartPosition_25(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_GetStartPosition_26(HandleRef pThis, IntPtr _arg);

		public virtual void GetStartPosition(IntPtr _arg)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_GetStartPosition_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern double vtkGenericStreamTracer_GetTerminalSpeed_27(HandleRef pThis);

		public virtual double GetTerminalSpeed()
		{
			return vtkGenericStreamTracer.vtkGenericStreamTracer_GetTerminalSpeed_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericStreamTracer_IsA_28(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGenericStreamTracer.vtkGenericStreamTracer_IsA_28(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericStreamTracer_IsTypeOf_29(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGenericStreamTracer.vtkGenericStreamTracer_IsTypeOf_29(type);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericStreamTracer_NewInstance_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGenericStreamTracer NewInstance()
		{
			vtkGenericStreamTracer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericStreamTracer.vtkGenericStreamTracer_NewInstance_31(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericStreamTracer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericStreamTracer_SafeDownCast_32(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGenericStreamTracer SafeDownCast(vtkObjectBase o)
		{
			vtkGenericStreamTracer vtkGenericStreamTracer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericStreamTracer.vtkGenericStreamTracer_SafeDownCast_32((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericStreamTracer = (vtkGenericStreamTracer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericStreamTracer.Register(null);
				}
			}
			return vtkGenericStreamTracer;
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_SelectInputVectors_33(HandleRef pThis, string fieldName);

		public void SelectInputVectors(string fieldName)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SelectInputVectors_33(base.GetCppThis(), fieldName);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_SetComputeVorticity_34(HandleRef pThis, int _arg);

		public virtual void SetComputeVorticity(int _arg)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetComputeVorticity_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_SetInitialIntegrationStep_35(HandleRef pThis, int unit, double step);

		public void SetInitialIntegrationStep(int unit, double step)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetInitialIntegrationStep_35(base.GetCppThis(), unit, step);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_SetInitialIntegrationStep_36(HandleRef pThis, double step);

		public void SetInitialIntegrationStep(double step)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetInitialIntegrationStep_36(base.GetCppThis(), step);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_SetInitialIntegrationStepUnit_37(HandleRef pThis, int unit);

		public void SetInitialIntegrationStepUnit(int unit)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetInitialIntegrationStepUnit_37(base.GetCppThis(), unit);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_SetInitialIntegrationStepUnitToCellLengthUnit_38(HandleRef pThis);

		public void SetInitialIntegrationStepUnitToCellLengthUnit()
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetInitialIntegrationStepUnitToCellLengthUnit_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_SetInitialIntegrationStepUnitToLengthUnit_39(HandleRef pThis);

		public void SetInitialIntegrationStepUnitToLengthUnit()
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetInitialIntegrationStepUnitToLengthUnit_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_SetInitialIntegrationStepUnitToTimeUnit_40(HandleRef pThis);

		public void SetInitialIntegrationStepUnitToTimeUnit()
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetInitialIntegrationStepUnitToTimeUnit_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_SetIntegrationDirection_41(HandleRef pThis, int _arg);

		public virtual void SetIntegrationDirection(int _arg)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetIntegrationDirection_41(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_SetIntegrationDirectionToBackward_42(HandleRef pThis);

		public void SetIntegrationDirectionToBackward()
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetIntegrationDirectionToBackward_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_SetIntegrationDirectionToBoth_43(HandleRef pThis);

		public void SetIntegrationDirectionToBoth()
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetIntegrationDirectionToBoth_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_SetIntegrationDirectionToForward_44(HandleRef pThis);

		public void SetIntegrationDirectionToForward()
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetIntegrationDirectionToForward_44(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_SetIntegrator_45(HandleRef pThis, HandleRef arg0);

		public void SetIntegrator(vtkInitialValueProblemSolver arg0)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetIntegrator_45(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_SetIntegratorType_46(HandleRef pThis, int type);

		public void SetIntegratorType(int type)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetIntegratorType_46(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_SetIntegratorTypeToRungeKutta2_47(HandleRef pThis);

		public void SetIntegratorTypeToRungeKutta2()
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetIntegratorTypeToRungeKutta2_47(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_SetIntegratorTypeToRungeKutta4_48(HandleRef pThis);

		public void SetIntegratorTypeToRungeKutta4()
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetIntegratorTypeToRungeKutta4_48(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_SetIntegratorTypeToRungeKutta45_49(HandleRef pThis);

		public void SetIntegratorTypeToRungeKutta45()
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetIntegratorTypeToRungeKutta45_49(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_SetInterpolatorPrototype_50(HandleRef pThis, HandleRef ivf);

		public void SetInterpolatorPrototype(vtkGenericInterpolatedVelocityField ivf)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetInterpolatorPrototype_50(base.GetCppThis(), (ivf == null) ? default(HandleRef) : ivf.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_SetMaximumError_51(HandleRef pThis, double _arg);

		public virtual void SetMaximumError(double _arg)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetMaximumError_51(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_SetMaximumIntegrationStep_52(HandleRef pThis, int unit, double step);

		public void SetMaximumIntegrationStep(int unit, double step)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetMaximumIntegrationStep_52(base.GetCppThis(), unit, step);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_SetMaximumIntegrationStep_53(HandleRef pThis, double step);

		public void SetMaximumIntegrationStep(double step)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetMaximumIntegrationStep_53(base.GetCppThis(), step);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_SetMaximumIntegrationStepUnit_54(HandleRef pThis, int unit);

		public void SetMaximumIntegrationStepUnit(int unit)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetMaximumIntegrationStepUnit_54(base.GetCppThis(), unit);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_SetMaximumIntegrationStepUnitToCellLengthUnit_55(HandleRef pThis);

		public void SetMaximumIntegrationStepUnitToCellLengthUnit()
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetMaximumIntegrationStepUnitToCellLengthUnit_55(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_SetMaximumIntegrationStepUnitToLengthUnit_56(HandleRef pThis);

		public void SetMaximumIntegrationStepUnitToLengthUnit()
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetMaximumIntegrationStepUnitToLengthUnit_56(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_SetMaximumIntegrationStepUnitToTimeUnit_57(HandleRef pThis);

		public void SetMaximumIntegrationStepUnitToTimeUnit()
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetMaximumIntegrationStepUnitToTimeUnit_57(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_SetMaximumNumberOfSteps_58(HandleRef pThis, long _arg);

		public virtual void SetMaximumNumberOfSteps(long _arg)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetMaximumNumberOfSteps_58(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_SetMaximumPropagation_59(HandleRef pThis, int unit, double max);

		public void SetMaximumPropagation(int unit, double max)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetMaximumPropagation_59(base.GetCppThis(), unit, max);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_SetMaximumPropagation_60(HandleRef pThis, double max);

		public void SetMaximumPropagation(double max)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetMaximumPropagation_60(base.GetCppThis(), max);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_SetMaximumPropagationUnit_61(HandleRef pThis, int unit);

		public void SetMaximumPropagationUnit(int unit)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetMaximumPropagationUnit_61(base.GetCppThis(), unit);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_SetMaximumPropagationUnitToCellLengthUnit_62(HandleRef pThis);

		public void SetMaximumPropagationUnitToCellLengthUnit()
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetMaximumPropagationUnitToCellLengthUnit_62(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_SetMaximumPropagationUnitToLengthUnit_63(HandleRef pThis);

		public void SetMaximumPropagationUnitToLengthUnit()
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetMaximumPropagationUnitToLengthUnit_63(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_SetMaximumPropagationUnitToTimeUnit_64(HandleRef pThis);

		public void SetMaximumPropagationUnitToTimeUnit()
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetMaximumPropagationUnitToTimeUnit_64(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_SetMinimumIntegrationStep_65(HandleRef pThis, int unit, double step);

		public void SetMinimumIntegrationStep(int unit, double step)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetMinimumIntegrationStep_65(base.GetCppThis(), unit, step);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_SetMinimumIntegrationStep_66(HandleRef pThis, double step);

		public void SetMinimumIntegrationStep(double step)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetMinimumIntegrationStep_66(base.GetCppThis(), step);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_SetMinimumIntegrationStepUnit_67(HandleRef pThis, int unit);

		public void SetMinimumIntegrationStepUnit(int unit)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetMinimumIntegrationStepUnit_67(base.GetCppThis(), unit);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_SetMinimumIntegrationStepUnitToCellLengthUnit_68(HandleRef pThis);

		public void SetMinimumIntegrationStepUnitToCellLengthUnit()
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetMinimumIntegrationStepUnitToCellLengthUnit_68(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_SetMinimumIntegrationStepUnitToLengthUnit_69(HandleRef pThis);

		public void SetMinimumIntegrationStepUnitToLengthUnit()
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetMinimumIntegrationStepUnitToLengthUnit_69(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_SetMinimumIntegrationStepUnitToTimeUnit_70(HandleRef pThis);

		public void SetMinimumIntegrationStepUnitToTimeUnit()
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetMinimumIntegrationStepUnitToTimeUnit_70(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_SetRotationScale_71(HandleRef pThis, double _arg);

		public virtual void SetRotationScale(double _arg)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetRotationScale_71(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_SetSource_72(HandleRef pThis, HandleRef source);

		public void SetSource(vtkDataSet source)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetSource_72(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_SetStartPosition_73(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetStartPosition(double _arg1, double _arg2, double _arg3)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetStartPosition_73(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_SetStartPosition_74(HandleRef pThis, IntPtr _arg);

		public virtual void SetStartPosition(IntPtr _arg)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetStartPosition_74(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGenericFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericStreamTracer_SetTerminalSpeed_75(HandleRef pThis, double _arg);

		public virtual void SetTerminalSpeed(double _arg)
		{
			vtkGenericStreamTracer.vtkGenericStreamTracer_SetTerminalSpeed_75(base.GetCppThis(), _arg);
		}
	}
}
