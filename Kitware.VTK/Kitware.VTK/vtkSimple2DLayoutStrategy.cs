using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSimple2DLayoutStrategy : vtkGraphLayoutStrategy
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSimple2DLayoutStrategy";

		public new static readonly string MRClassNameKey;

		static vtkSimple2DLayoutStrategy()
		{
			vtkSimple2DLayoutStrategy.MRClassNameKey = "class vtkSimple2DLayoutStrategy";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSimple2DLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSimple2DLayoutStrategy"));
		}

		public vtkSimple2DLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSimple2DLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSimple2DLayoutStrategy New()
		{
			vtkSimple2DLayoutStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSimple2DLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSimple2DLayoutStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkSimple2DLayoutStrategy_GetCoolDownRate_01(HandleRef pThis);

		public virtual double GetCoolDownRate()
		{
			return vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_GetCoolDownRate_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkSimple2DLayoutStrategy_GetCoolDownRateMaxValue_02(HandleRef pThis);

		public virtual double GetCoolDownRateMaxValue()
		{
			return vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_GetCoolDownRateMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkSimple2DLayoutStrategy_GetCoolDownRateMinValue_03(HandleRef pThis);

		public virtual double GetCoolDownRateMinValue()
		{
			return vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_GetCoolDownRateMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern float vtkSimple2DLayoutStrategy_GetInitialTemperature_04(HandleRef pThis);

		public virtual float GetInitialTemperature()
		{
			return vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_GetInitialTemperature_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern float vtkSimple2DLayoutStrategy_GetInitialTemperatureMaxValue_05(HandleRef pThis);

		public virtual float GetInitialTemperatureMaxValue()
		{
			return vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_GetInitialTemperatureMaxValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern float vtkSimple2DLayoutStrategy_GetInitialTemperatureMinValue_06(HandleRef pThis);

		public virtual float GetInitialTemperatureMinValue()
		{
			return vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_GetInitialTemperatureMinValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkSimple2DLayoutStrategy_GetIterationsPerLayout_07(HandleRef pThis);

		public virtual int GetIterationsPerLayout()
		{
			return vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_GetIterationsPerLayout_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkSimple2DLayoutStrategy_GetIterationsPerLayoutMaxValue_08(HandleRef pThis);

		public virtual int GetIterationsPerLayoutMaxValue()
		{
			return vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_GetIterationsPerLayoutMaxValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkSimple2DLayoutStrategy_GetIterationsPerLayoutMinValue_09(HandleRef pThis);

		public virtual int GetIterationsPerLayoutMinValue()
		{
			return vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_GetIterationsPerLayoutMinValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkSimple2DLayoutStrategy_GetJitter_10(HandleRef pThis);

		public virtual bool GetJitter()
		{
			return vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_GetJitter_10(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkSimple2DLayoutStrategy_GetMaxNumberOfIterations_11(HandleRef pThis);

		public virtual int GetMaxNumberOfIterations()
		{
			return vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_GetMaxNumberOfIterations_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkSimple2DLayoutStrategy_GetMaxNumberOfIterationsMaxValue_12(HandleRef pThis);

		public virtual int GetMaxNumberOfIterationsMaxValue()
		{
			return vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_GetMaxNumberOfIterationsMaxValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkSimple2DLayoutStrategy_GetMaxNumberOfIterationsMinValue_13(HandleRef pThis);

		public virtual int GetMaxNumberOfIterationsMinValue()
		{
			return vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_GetMaxNumberOfIterationsMinValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkSimple2DLayoutStrategy_GetRandomSeed_14(HandleRef pThis);

		public virtual int GetRandomSeed()
		{
			return vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_GetRandomSeed_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkSimple2DLayoutStrategy_GetRandomSeedMaxValue_15(HandleRef pThis);

		public virtual int GetRandomSeedMaxValue()
		{
			return vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_GetRandomSeedMaxValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkSimple2DLayoutStrategy_GetRandomSeedMinValue_16(HandleRef pThis);

		public virtual int GetRandomSeedMinValue()
		{
			return vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_GetRandomSeedMinValue_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern float vtkSimple2DLayoutStrategy_GetRestDistance_17(HandleRef pThis);

		public virtual float GetRestDistance()
		{
			return vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_GetRestDistance_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSimple2DLayoutStrategy_Initialize_18(HandleRef pThis);

		public override void Initialize()
		{
			vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_Initialize_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkSimple2DLayoutStrategy_IsA_19(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_IsA_19(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkSimple2DLayoutStrategy_IsLayoutComplete_20(HandleRef pThis);

		public override int IsLayoutComplete()
		{
			return vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_IsLayoutComplete_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkSimple2DLayoutStrategy_IsTypeOf_21(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_IsTypeOf_21(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSimple2DLayoutStrategy_Layout_22(HandleRef pThis);

		public override void Layout()
		{
			vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_Layout_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSimple2DLayoutStrategy_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSimple2DLayoutStrategy NewInstance()
		{
			vtkSimple2DLayoutStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_NewInstance_24(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSimple2DLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSimple2DLayoutStrategy_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSimple2DLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkSimple2DLayoutStrategy vtkSimple2DLayoutStrategy = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSimple2DLayoutStrategy = (vtkSimple2DLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSimple2DLayoutStrategy.Register(null);
				}
			}
			return vtkSimple2DLayoutStrategy;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSimple2DLayoutStrategy_SetCoolDownRate_26(HandleRef pThis, double _arg);

		public virtual void SetCoolDownRate(double _arg)
		{
			vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_SetCoolDownRate_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSimple2DLayoutStrategy_SetInitialTemperature_27(HandleRef pThis, float _arg);

		public virtual void SetInitialTemperature(float _arg)
		{
			vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_SetInitialTemperature_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSimple2DLayoutStrategy_SetIterationsPerLayout_28(HandleRef pThis, int _arg);

		public virtual void SetIterationsPerLayout(int _arg)
		{
			vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_SetIterationsPerLayout_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSimple2DLayoutStrategy_SetJitter_29(HandleRef pThis, byte _arg);

		public virtual void SetJitter(bool _arg)
		{
			vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_SetJitter_29(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSimple2DLayoutStrategy_SetMaxNumberOfIterations_30(HandleRef pThis, int _arg);

		public virtual void SetMaxNumberOfIterations(int _arg)
		{
			vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_SetMaxNumberOfIterations_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSimple2DLayoutStrategy_SetRandomSeed_31(HandleRef pThis, int _arg);

		public virtual void SetRandomSeed(int _arg)
		{
			vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_SetRandomSeed_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSimple2DLayoutStrategy_SetRestDistance_32(HandleRef pThis, float _arg);

		public virtual void SetRestDistance(float _arg)
		{
			vtkSimple2DLayoutStrategy.vtkSimple2DLayoutStrategy_SetRestDistance_32(base.GetCppThis(), _arg);
		}
	}
}
