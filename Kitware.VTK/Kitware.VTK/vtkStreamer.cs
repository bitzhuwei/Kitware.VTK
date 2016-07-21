using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkStreamer : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkStreamer";

		public new static readonly string MRClassNameKey;

		static vtkStreamer()
		{
			vtkStreamer.MRClassNameKey = "class vtkStreamer";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStreamer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStreamer"));
		}

		public vtkStreamer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkStreamer_GetEpsilon_01(HandleRef pThis);

		public virtual double GetEpsilon()
		{
			return vtkStreamer.vtkStreamer_GetEpsilon_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkStreamer_GetIntegrationDirection_02(HandleRef pThis);

		public virtual int GetIntegrationDirection()
		{
			return vtkStreamer.vtkStreamer_GetIntegrationDirection_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamer_GetIntegrationDirectionAsString_03(HandleRef pThis);

		public string GetIntegrationDirectionAsString()
		{
			return Marshal.PtrToStringAnsi(vtkStreamer.vtkStreamer_GetIntegrationDirectionAsString_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkStreamer_GetIntegrationDirectionMaxValue_04(HandleRef pThis);

		public virtual int GetIntegrationDirectionMaxValue()
		{
			return vtkStreamer.vtkStreamer_GetIntegrationDirectionMaxValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkStreamer_GetIntegrationDirectionMinValue_05(HandleRef pThis);

		public virtual int GetIntegrationDirectionMinValue()
		{
			return vtkStreamer.vtkStreamer_GetIntegrationDirectionMinValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkStreamer_GetIntegrationStepLength_06(HandleRef pThis);

		public virtual double GetIntegrationStepLength()
		{
			return vtkStreamer.vtkStreamer_GetIntegrationStepLength_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkStreamer_GetIntegrationStepLengthMaxValue_07(HandleRef pThis);

		public virtual double GetIntegrationStepLengthMaxValue()
		{
			return vtkStreamer.vtkStreamer_GetIntegrationStepLengthMaxValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkStreamer_GetIntegrationStepLengthMinValue_08(HandleRef pThis);

		public virtual double GetIntegrationStepLengthMinValue()
		{
			return vtkStreamer.vtkStreamer_GetIntegrationStepLengthMinValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamer_GetIntegrator_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkInitialValueProblemSolver GetIntegrator()
		{
			vtkInitialValueProblemSolver vtkInitialValueProblemSolver = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamer.vtkStreamer_GetIntegrator_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern double vtkStreamer_GetMaximumPropagationTime_10(HandleRef pThis);

		public virtual double GetMaximumPropagationTime()
		{
			return vtkStreamer.vtkStreamer_GetMaximumPropagationTime_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkStreamer_GetMaximumPropagationTimeMaxValue_11(HandleRef pThis);

		public virtual double GetMaximumPropagationTimeMaxValue()
		{
			return vtkStreamer.vtkStreamer_GetMaximumPropagationTimeMaxValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkStreamer_GetMaximumPropagationTimeMinValue_12(HandleRef pThis);

		public virtual double GetMaximumPropagationTimeMinValue()
		{
			return vtkStreamer.vtkStreamer_GetMaximumPropagationTimeMinValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkStreamer_GetNumberOfThreads_13(HandleRef pThis);

		public virtual int GetNumberOfThreads()
		{
			return vtkStreamer.vtkStreamer_GetNumberOfThreads_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkStreamer_GetOrientationScalars_14(HandleRef pThis);

		public virtual int GetOrientationScalars()
		{
			return vtkStreamer.vtkStreamer_GetOrientationScalars_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkStreamer_GetSavePointInterval_15(HandleRef pThis);

		public virtual double GetSavePointInterval()
		{
			return vtkStreamer.vtkStreamer_GetSavePointInterval_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamer_GetSource_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataSet GetSource()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamer.vtkStreamer_GetSource_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkStreamer_GetSpeedScalars_17(HandleRef pThis);

		public virtual int GetSpeedScalars()
		{
			return vtkStreamer.vtkStreamer_GetSpeedScalars_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkStreamer_GetStartLocation_18(HandleRef pThis, ref int subId, IntPtr pcoords);

		public long GetStartLocation(ref int subId, IntPtr pcoords)
		{
			return vtkStreamer.vtkStreamer_GetStartLocation_18(base.GetCppThis(), ref subId, pcoords);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamer_GetStartPosition_19(HandleRef pThis);

		public double[] GetStartPosition()
		{
			IntPtr intPtr = vtkStreamer.vtkStreamer_GetStartPosition_19(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkStreamer_GetTerminalSpeed_20(HandleRef pThis);

		public virtual double GetTerminalSpeed()
		{
			return vtkStreamer.vtkStreamer_GetTerminalSpeed_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkStreamer_GetTerminalSpeedMaxValue_21(HandleRef pThis);

		public virtual double GetTerminalSpeedMaxValue()
		{
			return vtkStreamer.vtkStreamer_GetTerminalSpeedMaxValue_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkStreamer_GetTerminalSpeedMinValue_22(HandleRef pThis);

		public virtual double GetTerminalSpeedMinValue()
		{
			return vtkStreamer.vtkStreamer_GetTerminalSpeedMinValue_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkStreamer_GetVorticity_23(HandleRef pThis);

		public virtual int GetVorticity()
		{
			return vtkStreamer.vtkStreamer_GetVorticity_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkStreamer_IsA_24(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkStreamer.vtkStreamer_IsA_24(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkStreamer_IsTypeOf_25(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkStreamer.vtkStreamer_IsTypeOf_25(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamer_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkStreamer NewInstance()
		{
			vtkStreamer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamer.vtkStreamer_NewInstance_26(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStreamer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamer_OrientationScalarsOff_27(HandleRef pThis);

		public virtual void OrientationScalarsOff()
		{
			vtkStreamer.vtkStreamer_OrientationScalarsOff_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamer_OrientationScalarsOn_28(HandleRef pThis);

		public virtual void OrientationScalarsOn()
		{
			vtkStreamer.vtkStreamer_OrientationScalarsOn_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamer_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStreamer SafeDownCast(vtkObjectBase o)
		{
			vtkStreamer vtkStreamer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamer.vtkStreamer_SafeDownCast_29((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStreamer = (vtkStreamer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStreamer.Register(null);
				}
			}
			return vtkStreamer;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamer_SetEpsilon_30(HandleRef pThis, double _arg);

		public virtual void SetEpsilon(double _arg)
		{
			vtkStreamer.vtkStreamer_SetEpsilon_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamer_SetIntegrationDirection_31(HandleRef pThis, int _arg);

		public virtual void SetIntegrationDirection(int _arg)
		{
			vtkStreamer.vtkStreamer_SetIntegrationDirection_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamer_SetIntegrationDirectionToBackward_32(HandleRef pThis);

		public void SetIntegrationDirectionToBackward()
		{
			vtkStreamer.vtkStreamer_SetIntegrationDirectionToBackward_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamer_SetIntegrationDirectionToForward_33(HandleRef pThis);

		public void SetIntegrationDirectionToForward()
		{
			vtkStreamer.vtkStreamer_SetIntegrationDirectionToForward_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamer_SetIntegrationDirectionToIntegrateBothDirections_34(HandleRef pThis);

		public void SetIntegrationDirectionToIntegrateBothDirections()
		{
			vtkStreamer.vtkStreamer_SetIntegrationDirectionToIntegrateBothDirections_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamer_SetIntegrationStepLength_35(HandleRef pThis, double _arg);

		public virtual void SetIntegrationStepLength(double _arg)
		{
			vtkStreamer.vtkStreamer_SetIntegrationStepLength_35(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamer_SetIntegrator_36(HandleRef pThis, HandleRef arg0);

		public void SetIntegrator(vtkInitialValueProblemSolver arg0)
		{
			vtkStreamer.vtkStreamer_SetIntegrator_36(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamer_SetMaximumPropagationTime_37(HandleRef pThis, double _arg);

		public virtual void SetMaximumPropagationTime(double _arg)
		{
			vtkStreamer.vtkStreamer_SetMaximumPropagationTime_37(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamer_SetNumberOfThreads_38(HandleRef pThis, int _arg);

		public virtual void SetNumberOfThreads(int _arg)
		{
			vtkStreamer.vtkStreamer_SetNumberOfThreads_38(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamer_SetOrientationScalars_39(HandleRef pThis, int _arg);

		public virtual void SetOrientationScalars(int _arg)
		{
			vtkStreamer.vtkStreamer_SetOrientationScalars_39(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamer_SetSavePointInterval_40(HandleRef pThis, double _arg);

		public virtual void SetSavePointInterval(double _arg)
		{
			vtkStreamer.vtkStreamer_SetSavePointInterval_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamer_SetSource_41(HandleRef pThis, HandleRef source);

		public void SetSource(vtkDataSet source)
		{
			vtkStreamer.vtkStreamer_SetSource_41(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamer_SetSpeedScalars_42(HandleRef pThis, int _arg);

		public virtual void SetSpeedScalars(int _arg)
		{
			vtkStreamer.vtkStreamer_SetSpeedScalars_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamer_SetStartLocation_43(HandleRef pThis, long cellId, int subId, IntPtr pcoords);

		public void SetStartLocation(long cellId, int subId, IntPtr pcoords)
		{
			vtkStreamer.vtkStreamer_SetStartLocation_43(base.GetCppThis(), cellId, subId, pcoords);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamer_SetStartLocation_44(HandleRef pThis, long cellId, int subId, double r, double s, double t);

		public void SetStartLocation(long cellId, int subId, double r, double s, double t)
		{
			vtkStreamer.vtkStreamer_SetStartLocation_44(base.GetCppThis(), cellId, subId, r, s, t);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamer_SetStartPosition_45(HandleRef pThis, IntPtr x);

		public void SetStartPosition(IntPtr x)
		{
			vtkStreamer.vtkStreamer_SetStartPosition_45(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamer_SetStartPosition_46(HandleRef pThis, double x, double y, double z);

		public void SetStartPosition(double x, double y, double z)
		{
			vtkStreamer.vtkStreamer_SetStartPosition_46(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamer_SetTerminalSpeed_47(HandleRef pThis, double _arg);

		public virtual void SetTerminalSpeed(double _arg)
		{
			vtkStreamer.vtkStreamer_SetTerminalSpeed_47(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamer_SetVorticity_48(HandleRef pThis, int _arg);

		public virtual void SetVorticity(int _arg)
		{
			vtkStreamer.vtkStreamer_SetVorticity_48(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamer_SpeedScalarsOff_49(HandleRef pThis);

		public virtual void SpeedScalarsOff()
		{
			vtkStreamer.vtkStreamer_SpeedScalarsOff_49(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamer_SpeedScalarsOn_50(HandleRef pThis);

		public virtual void SpeedScalarsOn()
		{
			vtkStreamer.vtkStreamer_SpeedScalarsOn_50(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamer_VorticityOff_51(HandleRef pThis);

		public virtual void VorticityOff()
		{
			vtkStreamer.vtkStreamer_VorticityOff_51(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamer_VorticityOn_52(HandleRef pThis);

		public virtual void VorticityOn()
		{
			vtkStreamer.vtkStreamer_VorticityOn_52(base.GetCppThis());
		}
	}
}
