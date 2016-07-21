using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCommunity2DLayoutStrategy : vtkGraphLayoutStrategy
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCommunity2DLayoutStrategy";

		public new static readonly string MRClassNameKey;

		static vtkCommunity2DLayoutStrategy()
		{
			vtkCommunity2DLayoutStrategy.MRClassNameKey = "class vtkCommunity2DLayoutStrategy";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCommunity2DLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCommunity2DLayoutStrategy"));
		}

		public vtkCommunity2DLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkCommunity2DLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCommunity2DLayoutStrategy New()
		{
			vtkCommunity2DLayoutStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCommunity2DLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCommunity2DLayoutStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkCommunity2DLayoutStrategy_GetCommunityArrayName_01(HandleRef pThis);

		public virtual string GetCommunityArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_GetCommunityArrayName_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern float vtkCommunity2DLayoutStrategy_GetCommunityStrength_02(HandleRef pThis);

		public virtual float GetCommunityStrength()
		{
			return vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_GetCommunityStrength_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern float vtkCommunity2DLayoutStrategy_GetCommunityStrengthMaxValue_03(HandleRef pThis);

		public virtual float GetCommunityStrengthMaxValue()
		{
			return vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_GetCommunityStrengthMaxValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern float vtkCommunity2DLayoutStrategy_GetCommunityStrengthMinValue_04(HandleRef pThis);

		public virtual float GetCommunityStrengthMinValue()
		{
			return vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_GetCommunityStrengthMinValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkCommunity2DLayoutStrategy_GetCoolDownRate_05(HandleRef pThis);

		public virtual double GetCoolDownRate()
		{
			return vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_GetCoolDownRate_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkCommunity2DLayoutStrategy_GetCoolDownRateMaxValue_06(HandleRef pThis);

		public virtual double GetCoolDownRateMaxValue()
		{
			return vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_GetCoolDownRateMaxValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkCommunity2DLayoutStrategy_GetCoolDownRateMinValue_07(HandleRef pThis);

		public virtual double GetCoolDownRateMinValue()
		{
			return vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_GetCoolDownRateMinValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern float vtkCommunity2DLayoutStrategy_GetInitialTemperature_08(HandleRef pThis);

		public virtual float GetInitialTemperature()
		{
			return vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_GetInitialTemperature_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern float vtkCommunity2DLayoutStrategy_GetInitialTemperatureMaxValue_09(HandleRef pThis);

		public virtual float GetInitialTemperatureMaxValue()
		{
			return vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_GetInitialTemperatureMaxValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern float vtkCommunity2DLayoutStrategy_GetInitialTemperatureMinValue_10(HandleRef pThis);

		public virtual float GetInitialTemperatureMinValue()
		{
			return vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_GetInitialTemperatureMinValue_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkCommunity2DLayoutStrategy_GetIterationsPerLayout_11(HandleRef pThis);

		public virtual int GetIterationsPerLayout()
		{
			return vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_GetIterationsPerLayout_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkCommunity2DLayoutStrategy_GetIterationsPerLayoutMaxValue_12(HandleRef pThis);

		public virtual int GetIterationsPerLayoutMaxValue()
		{
			return vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_GetIterationsPerLayoutMaxValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkCommunity2DLayoutStrategy_GetIterationsPerLayoutMinValue_13(HandleRef pThis);

		public virtual int GetIterationsPerLayoutMinValue()
		{
			return vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_GetIterationsPerLayoutMinValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkCommunity2DLayoutStrategy_GetMaxNumberOfIterations_14(HandleRef pThis);

		public virtual int GetMaxNumberOfIterations()
		{
			return vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_GetMaxNumberOfIterations_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkCommunity2DLayoutStrategy_GetMaxNumberOfIterationsMaxValue_15(HandleRef pThis);

		public virtual int GetMaxNumberOfIterationsMaxValue()
		{
			return vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_GetMaxNumberOfIterationsMaxValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkCommunity2DLayoutStrategy_GetMaxNumberOfIterationsMinValue_16(HandleRef pThis);

		public virtual int GetMaxNumberOfIterationsMinValue()
		{
			return vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_GetMaxNumberOfIterationsMinValue_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkCommunity2DLayoutStrategy_GetRandomSeed_17(HandleRef pThis);

		public virtual int GetRandomSeed()
		{
			return vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_GetRandomSeed_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkCommunity2DLayoutStrategy_GetRandomSeedMaxValue_18(HandleRef pThis);

		public virtual int GetRandomSeedMaxValue()
		{
			return vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_GetRandomSeedMaxValue_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkCommunity2DLayoutStrategy_GetRandomSeedMinValue_19(HandleRef pThis);

		public virtual int GetRandomSeedMinValue()
		{
			return vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_GetRandomSeedMinValue_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern float vtkCommunity2DLayoutStrategy_GetRestDistance_20(HandleRef pThis);

		public virtual float GetRestDistance()
		{
			return vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_GetRestDistance_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkCommunity2DLayoutStrategy_Initialize_21(HandleRef pThis);

		public override void Initialize()
		{
			vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_Initialize_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkCommunity2DLayoutStrategy_IsA_22(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_IsA_22(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkCommunity2DLayoutStrategy_IsLayoutComplete_23(HandleRef pThis);

		public override int IsLayoutComplete()
		{
			return vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_IsLayoutComplete_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkCommunity2DLayoutStrategy_IsTypeOf_24(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_IsTypeOf_24(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkCommunity2DLayoutStrategy_Layout_25(HandleRef pThis);

		public override void Layout()
		{
			vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_Layout_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkCommunity2DLayoutStrategy_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCommunity2DLayoutStrategy NewInstance()
		{
			vtkCommunity2DLayoutStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_NewInstance_27(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCommunity2DLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkCommunity2DLayoutStrategy_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCommunity2DLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkCommunity2DLayoutStrategy vtkCommunity2DLayoutStrategy = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCommunity2DLayoutStrategy = (vtkCommunity2DLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCommunity2DLayoutStrategy.Register(null);
				}
			}
			return vtkCommunity2DLayoutStrategy;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkCommunity2DLayoutStrategy_SetCommunityArrayName_29(HandleRef pThis, string _arg);

		public virtual void SetCommunityArrayName(string _arg)
		{
			vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_SetCommunityArrayName_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkCommunity2DLayoutStrategy_SetCommunityStrength_30(HandleRef pThis, float _arg);

		public virtual void SetCommunityStrength(float _arg)
		{
			vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_SetCommunityStrength_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkCommunity2DLayoutStrategy_SetCoolDownRate_31(HandleRef pThis, double _arg);

		public virtual void SetCoolDownRate(double _arg)
		{
			vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_SetCoolDownRate_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkCommunity2DLayoutStrategy_SetInitialTemperature_32(HandleRef pThis, float _arg);

		public virtual void SetInitialTemperature(float _arg)
		{
			vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_SetInitialTemperature_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkCommunity2DLayoutStrategy_SetIterationsPerLayout_33(HandleRef pThis, int _arg);

		public virtual void SetIterationsPerLayout(int _arg)
		{
			vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_SetIterationsPerLayout_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkCommunity2DLayoutStrategy_SetMaxNumberOfIterations_34(HandleRef pThis, int _arg);

		public virtual void SetMaxNumberOfIterations(int _arg)
		{
			vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_SetMaxNumberOfIterations_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkCommunity2DLayoutStrategy_SetRandomSeed_35(HandleRef pThis, int _arg);

		public virtual void SetRandomSeed(int _arg)
		{
			vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_SetRandomSeed_35(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkCommunity2DLayoutStrategy_SetRestDistance_36(HandleRef pThis, float _arg);

		public virtual void SetRestDistance(float _arg)
		{
			vtkCommunity2DLayoutStrategy.vtkCommunity2DLayoutStrategy_SetRestDistance_36(base.GetCppThis(), _arg);
		}
	}
}
