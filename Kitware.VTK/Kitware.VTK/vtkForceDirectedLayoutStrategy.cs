using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkForceDirectedLayoutStrategy : vtkGraphLayoutStrategy
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkForceDirectedLayoutStrategy";

		public new static readonly string MRClassNameKey;

		static vtkForceDirectedLayoutStrategy()
		{
			vtkForceDirectedLayoutStrategy.MRClassNameKey = "class vtkForceDirectedLayoutStrategy";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkForceDirectedLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkForceDirectedLayoutStrategy"));
		}

		public vtkForceDirectedLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkForceDirectedLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkForceDirectedLayoutStrategy New()
		{
			vtkForceDirectedLayoutStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkForceDirectedLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkForceDirectedLayoutStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkForceDirectedLayoutStrategy_AutomaticBoundsComputationOff_01(HandleRef pThis);

		public virtual void AutomaticBoundsComputationOff()
		{
			vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_AutomaticBoundsComputationOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkForceDirectedLayoutStrategy_AutomaticBoundsComputationOn_02(HandleRef pThis);

		public virtual void AutomaticBoundsComputationOn()
		{
			vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_AutomaticBoundsComputationOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkForceDirectedLayoutStrategy_GetAutomaticBoundsComputation_03(HandleRef pThis);

		public virtual int GetAutomaticBoundsComputation()
		{
			return vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_GetAutomaticBoundsComputation_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkForceDirectedLayoutStrategy_GetCoolDownRate_04(HandleRef pThis);

		public virtual double GetCoolDownRate()
		{
			return vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_GetCoolDownRate_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkForceDirectedLayoutStrategy_GetCoolDownRateMaxValue_05(HandleRef pThis);

		public virtual double GetCoolDownRateMaxValue()
		{
			return vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_GetCoolDownRateMaxValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkForceDirectedLayoutStrategy_GetCoolDownRateMinValue_06(HandleRef pThis);

		public virtual double GetCoolDownRateMinValue()
		{
			return vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_GetCoolDownRateMinValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkForceDirectedLayoutStrategy_GetGraphBounds_07(HandleRef pThis);

		public virtual double[] GetGraphBounds()
		{
			IntPtr intPtr = vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_GetGraphBounds_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkForceDirectedLayoutStrategy_GetGraphBounds_08(HandleRef pThis, IntPtr data);

		public virtual void GetGraphBounds(IntPtr data)
		{
			vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_GetGraphBounds_08(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern float vtkForceDirectedLayoutStrategy_GetInitialTemperature_09(HandleRef pThis);

		public virtual float GetInitialTemperature()
		{
			return vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_GetInitialTemperature_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern float vtkForceDirectedLayoutStrategy_GetInitialTemperatureMaxValue_10(HandleRef pThis);

		public virtual float GetInitialTemperatureMaxValue()
		{
			return vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_GetInitialTemperatureMaxValue_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern float vtkForceDirectedLayoutStrategy_GetInitialTemperatureMinValue_11(HandleRef pThis);

		public virtual float GetInitialTemperatureMinValue()
		{
			return vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_GetInitialTemperatureMinValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkForceDirectedLayoutStrategy_GetIterationsPerLayout_12(HandleRef pThis);

		public virtual int GetIterationsPerLayout()
		{
			return vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_GetIterationsPerLayout_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkForceDirectedLayoutStrategy_GetIterationsPerLayoutMaxValue_13(HandleRef pThis);

		public virtual int GetIterationsPerLayoutMaxValue()
		{
			return vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_GetIterationsPerLayoutMaxValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkForceDirectedLayoutStrategy_GetIterationsPerLayoutMinValue_14(HandleRef pThis);

		public virtual int GetIterationsPerLayoutMinValue()
		{
			return vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_GetIterationsPerLayoutMinValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkForceDirectedLayoutStrategy_GetMaxNumberOfIterations_15(HandleRef pThis);

		public virtual int GetMaxNumberOfIterations()
		{
			return vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_GetMaxNumberOfIterations_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkForceDirectedLayoutStrategy_GetMaxNumberOfIterationsMaxValue_16(HandleRef pThis);

		public virtual int GetMaxNumberOfIterationsMaxValue()
		{
			return vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_GetMaxNumberOfIterationsMaxValue_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkForceDirectedLayoutStrategy_GetMaxNumberOfIterationsMinValue_17(HandleRef pThis);

		public virtual int GetMaxNumberOfIterationsMinValue()
		{
			return vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_GetMaxNumberOfIterationsMinValue_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkForceDirectedLayoutStrategy_GetRandomInitialPoints_18(HandleRef pThis);

		public virtual int GetRandomInitialPoints()
		{
			return vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_GetRandomInitialPoints_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkForceDirectedLayoutStrategy_GetRandomSeed_19(HandleRef pThis);

		public virtual int GetRandomSeed()
		{
			return vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_GetRandomSeed_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkForceDirectedLayoutStrategy_GetRandomSeedMaxValue_20(HandleRef pThis);

		public virtual int GetRandomSeedMaxValue()
		{
			return vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_GetRandomSeedMaxValue_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkForceDirectedLayoutStrategy_GetRandomSeedMinValue_21(HandleRef pThis);

		public virtual int GetRandomSeedMinValue()
		{
			return vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_GetRandomSeedMinValue_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkForceDirectedLayoutStrategy_GetThreeDimensionalLayout_22(HandleRef pThis);

		public virtual int GetThreeDimensionalLayout()
		{
			return vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_GetThreeDimensionalLayout_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkForceDirectedLayoutStrategy_Initialize_23(HandleRef pThis);

		public override void Initialize()
		{
			vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_Initialize_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkForceDirectedLayoutStrategy_IsA_24(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_IsA_24(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkForceDirectedLayoutStrategy_IsLayoutComplete_25(HandleRef pThis);

		public override int IsLayoutComplete()
		{
			return vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_IsLayoutComplete_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkForceDirectedLayoutStrategy_IsTypeOf_26(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_IsTypeOf_26(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkForceDirectedLayoutStrategy_Layout_27(HandleRef pThis);

		public override void Layout()
		{
			vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_Layout_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkForceDirectedLayoutStrategy_NewInstance_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkForceDirectedLayoutStrategy NewInstance()
		{
			vtkForceDirectedLayoutStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_NewInstance_29(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkForceDirectedLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkForceDirectedLayoutStrategy_RandomInitialPointsOff_30(HandleRef pThis);

		public virtual void RandomInitialPointsOff()
		{
			vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_RandomInitialPointsOff_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkForceDirectedLayoutStrategy_RandomInitialPointsOn_31(HandleRef pThis);

		public virtual void RandomInitialPointsOn()
		{
			vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_RandomInitialPointsOn_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkForceDirectedLayoutStrategy_SafeDownCast_32(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkForceDirectedLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkForceDirectedLayoutStrategy vtkForceDirectedLayoutStrategy = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_SafeDownCast_32((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkForceDirectedLayoutStrategy = (vtkForceDirectedLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkForceDirectedLayoutStrategy.Register(null);
				}
			}
			return vtkForceDirectedLayoutStrategy;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkForceDirectedLayoutStrategy_SetAutomaticBoundsComputation_33(HandleRef pThis, int _arg);

		public virtual void SetAutomaticBoundsComputation(int _arg)
		{
			vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_SetAutomaticBoundsComputation_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkForceDirectedLayoutStrategy_SetCoolDownRate_34(HandleRef pThis, double _arg);

		public virtual void SetCoolDownRate(double _arg)
		{
			vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_SetCoolDownRate_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkForceDirectedLayoutStrategy_SetGraphBounds_35(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		public virtual void SetGraphBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_SetGraphBounds_35(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkForceDirectedLayoutStrategy_SetGraphBounds_36(HandleRef pThis, IntPtr _arg);

		public virtual void SetGraphBounds(IntPtr _arg)
		{
			vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_SetGraphBounds_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkForceDirectedLayoutStrategy_SetInitialTemperature_37(HandleRef pThis, float _arg);

		public virtual void SetInitialTemperature(float _arg)
		{
			vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_SetInitialTemperature_37(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkForceDirectedLayoutStrategy_SetIterationsPerLayout_38(HandleRef pThis, int _arg);

		public virtual void SetIterationsPerLayout(int _arg)
		{
			vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_SetIterationsPerLayout_38(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkForceDirectedLayoutStrategy_SetMaxNumberOfIterations_39(HandleRef pThis, int _arg);

		public virtual void SetMaxNumberOfIterations(int _arg)
		{
			vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_SetMaxNumberOfIterations_39(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkForceDirectedLayoutStrategy_SetRandomInitialPoints_40(HandleRef pThis, int _arg);

		public virtual void SetRandomInitialPoints(int _arg)
		{
			vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_SetRandomInitialPoints_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkForceDirectedLayoutStrategy_SetRandomSeed_41(HandleRef pThis, int _arg);

		public virtual void SetRandomSeed(int _arg)
		{
			vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_SetRandomSeed_41(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkForceDirectedLayoutStrategy_SetThreeDimensionalLayout_42(HandleRef pThis, int _arg);

		public virtual void SetThreeDimensionalLayout(int _arg)
		{
			vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_SetThreeDimensionalLayout_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkForceDirectedLayoutStrategy_ThreeDimensionalLayoutOff_43(HandleRef pThis);

		public virtual void ThreeDimensionalLayoutOff()
		{
			vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_ThreeDimensionalLayoutOff_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkForceDirectedLayoutStrategy_ThreeDimensionalLayoutOn_44(HandleRef pThis);

		public virtual void ThreeDimensionalLayoutOn()
		{
			vtkForceDirectedLayoutStrategy.vtkForceDirectedLayoutStrategy_ThreeDimensionalLayoutOn_44(base.GetCppThis());
		}
	}
}
