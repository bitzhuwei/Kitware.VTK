using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkConstrained2DLayoutStrategy : vtkGraphLayoutStrategy
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkConstrained2DLayoutStrategy";

		public new static readonly string MRClassNameKey;

		static vtkConstrained2DLayoutStrategy()
		{
			vtkConstrained2DLayoutStrategy.MRClassNameKey = "class vtkConstrained2DLayoutStrategy";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkConstrained2DLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkConstrained2DLayoutStrategy"));
		}

		public vtkConstrained2DLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkConstrained2DLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkConstrained2DLayoutStrategy New()
		{
			vtkConstrained2DLayoutStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkConstrained2DLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkConstrained2DLayoutStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkConstrained2DLayoutStrategy_GetCoolDownRate_01(HandleRef pThis);

		public virtual double GetCoolDownRate()
		{
			return vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_GetCoolDownRate_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkConstrained2DLayoutStrategy_GetCoolDownRateMaxValue_02(HandleRef pThis);

		public virtual double GetCoolDownRateMaxValue()
		{
			return vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_GetCoolDownRateMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkConstrained2DLayoutStrategy_GetCoolDownRateMinValue_03(HandleRef pThis);

		public virtual double GetCoolDownRateMinValue()
		{
			return vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_GetCoolDownRateMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern float vtkConstrained2DLayoutStrategy_GetInitialTemperature_04(HandleRef pThis);

		public virtual float GetInitialTemperature()
		{
			return vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_GetInitialTemperature_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern float vtkConstrained2DLayoutStrategy_GetInitialTemperatureMaxValue_05(HandleRef pThis);

		public virtual float GetInitialTemperatureMaxValue()
		{
			return vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_GetInitialTemperatureMaxValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern float vtkConstrained2DLayoutStrategy_GetInitialTemperatureMinValue_06(HandleRef pThis);

		public virtual float GetInitialTemperatureMinValue()
		{
			return vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_GetInitialTemperatureMinValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkConstrained2DLayoutStrategy_GetInputArrayName_07(HandleRef pThis);

		public virtual string GetInputArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_GetInputArrayName_07(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkConstrained2DLayoutStrategy_GetIterationsPerLayout_08(HandleRef pThis);

		public virtual int GetIterationsPerLayout()
		{
			return vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_GetIterationsPerLayout_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkConstrained2DLayoutStrategy_GetIterationsPerLayoutMaxValue_09(HandleRef pThis);

		public virtual int GetIterationsPerLayoutMaxValue()
		{
			return vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_GetIterationsPerLayoutMaxValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkConstrained2DLayoutStrategy_GetIterationsPerLayoutMinValue_10(HandleRef pThis);

		public virtual int GetIterationsPerLayoutMinValue()
		{
			return vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_GetIterationsPerLayoutMinValue_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkConstrained2DLayoutStrategy_GetMaxNumberOfIterations_11(HandleRef pThis);

		public virtual int GetMaxNumberOfIterations()
		{
			return vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_GetMaxNumberOfIterations_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkConstrained2DLayoutStrategy_GetMaxNumberOfIterationsMaxValue_12(HandleRef pThis);

		public virtual int GetMaxNumberOfIterationsMaxValue()
		{
			return vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_GetMaxNumberOfIterationsMaxValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkConstrained2DLayoutStrategy_GetMaxNumberOfIterationsMinValue_13(HandleRef pThis);

		public virtual int GetMaxNumberOfIterationsMinValue()
		{
			return vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_GetMaxNumberOfIterationsMinValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkConstrained2DLayoutStrategy_GetRandomSeed_14(HandleRef pThis);

		public virtual int GetRandomSeed()
		{
			return vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_GetRandomSeed_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkConstrained2DLayoutStrategy_GetRandomSeedMaxValue_15(HandleRef pThis);

		public virtual int GetRandomSeedMaxValue()
		{
			return vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_GetRandomSeedMaxValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkConstrained2DLayoutStrategy_GetRandomSeedMinValue_16(HandleRef pThis);

		public virtual int GetRandomSeedMinValue()
		{
			return vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_GetRandomSeedMinValue_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern float vtkConstrained2DLayoutStrategy_GetRestDistance_17(HandleRef pThis);

		public virtual float GetRestDistance()
		{
			return vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_GetRestDistance_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkConstrained2DLayoutStrategy_Initialize_18(HandleRef pThis);

		public override void Initialize()
		{
			vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_Initialize_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkConstrained2DLayoutStrategy_IsA_19(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_IsA_19(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkConstrained2DLayoutStrategy_IsLayoutComplete_20(HandleRef pThis);

		public override int IsLayoutComplete()
		{
			return vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_IsLayoutComplete_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkConstrained2DLayoutStrategy_IsTypeOf_21(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_IsTypeOf_21(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkConstrained2DLayoutStrategy_Layout_22(HandleRef pThis);

		public override void Layout()
		{
			vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_Layout_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkConstrained2DLayoutStrategy_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkConstrained2DLayoutStrategy NewInstance()
		{
			vtkConstrained2DLayoutStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_NewInstance_24(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkConstrained2DLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkConstrained2DLayoutStrategy_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkConstrained2DLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkConstrained2DLayoutStrategy vtkConstrained2DLayoutStrategy = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkConstrained2DLayoutStrategy = (vtkConstrained2DLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkConstrained2DLayoutStrategy.Register(null);
				}
			}
			return vtkConstrained2DLayoutStrategy;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkConstrained2DLayoutStrategy_SetCoolDownRate_26(HandleRef pThis, double _arg);

		public virtual void SetCoolDownRate(double _arg)
		{
			vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_SetCoolDownRate_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkConstrained2DLayoutStrategy_SetInitialTemperature_27(HandleRef pThis, float _arg);

		public virtual void SetInitialTemperature(float _arg)
		{
			vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_SetInitialTemperature_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkConstrained2DLayoutStrategy_SetInputArrayName_28(HandleRef pThis, string _arg);

		public virtual void SetInputArrayName(string _arg)
		{
			vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_SetInputArrayName_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkConstrained2DLayoutStrategy_SetIterationsPerLayout_29(HandleRef pThis, int _arg);

		public virtual void SetIterationsPerLayout(int _arg)
		{
			vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_SetIterationsPerLayout_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkConstrained2DLayoutStrategy_SetMaxNumberOfIterations_30(HandleRef pThis, int _arg);

		public virtual void SetMaxNumberOfIterations(int _arg)
		{
			vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_SetMaxNumberOfIterations_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkConstrained2DLayoutStrategy_SetRandomSeed_31(HandleRef pThis, int _arg);

		public virtual void SetRandomSeed(int _arg)
		{
			vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_SetRandomSeed_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkConstrained2DLayoutStrategy_SetRestDistance_32(HandleRef pThis, float _arg);

		public virtual void SetRestDistance(float _arg)
		{
			vtkConstrained2DLayoutStrategy.vtkConstrained2DLayoutStrategy_SetRestDistance_32(base.GetCppThis(), _arg);
		}
	}
}
