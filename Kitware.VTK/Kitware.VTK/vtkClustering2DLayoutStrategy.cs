using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkClustering2DLayoutStrategy : vtkGraphLayoutStrategy
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkClustering2DLayoutStrategy";

		public new static readonly string MRClassNameKey;

		static vtkClustering2DLayoutStrategy()
		{
			vtkClustering2DLayoutStrategy.MRClassNameKey = "class vtkClustering2DLayoutStrategy";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkClustering2DLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkClustering2DLayoutStrategy"));
		}

		public vtkClustering2DLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkClustering2DLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkClustering2DLayoutStrategy New()
		{
			vtkClustering2DLayoutStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClustering2DLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkClustering2DLayoutStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkClustering2DLayoutStrategy_GetCoolDownRate_01(HandleRef pThis);

		public virtual double GetCoolDownRate()
		{
			return vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_GetCoolDownRate_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkClustering2DLayoutStrategy_GetCoolDownRateMaxValue_02(HandleRef pThis);

		public virtual double GetCoolDownRateMaxValue()
		{
			return vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_GetCoolDownRateMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkClustering2DLayoutStrategy_GetCoolDownRateMinValue_03(HandleRef pThis);

		public virtual double GetCoolDownRateMinValue()
		{
			return vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_GetCoolDownRateMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern float vtkClustering2DLayoutStrategy_GetInitialTemperature_04(HandleRef pThis);

		public virtual float GetInitialTemperature()
		{
			return vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_GetInitialTemperature_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern float vtkClustering2DLayoutStrategy_GetInitialTemperatureMaxValue_05(HandleRef pThis);

		public virtual float GetInitialTemperatureMaxValue()
		{
			return vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_GetInitialTemperatureMaxValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern float vtkClustering2DLayoutStrategy_GetInitialTemperatureMinValue_06(HandleRef pThis);

		public virtual float GetInitialTemperatureMinValue()
		{
			return vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_GetInitialTemperatureMinValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkClustering2DLayoutStrategy_GetIterationsPerLayout_07(HandleRef pThis);

		public virtual int GetIterationsPerLayout()
		{
			return vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_GetIterationsPerLayout_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkClustering2DLayoutStrategy_GetIterationsPerLayoutMaxValue_08(HandleRef pThis);

		public virtual int GetIterationsPerLayoutMaxValue()
		{
			return vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_GetIterationsPerLayoutMaxValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkClustering2DLayoutStrategy_GetIterationsPerLayoutMinValue_09(HandleRef pThis);

		public virtual int GetIterationsPerLayoutMinValue()
		{
			return vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_GetIterationsPerLayoutMinValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkClustering2DLayoutStrategy_GetMaxNumberOfIterations_10(HandleRef pThis);

		public virtual int GetMaxNumberOfIterations()
		{
			return vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_GetMaxNumberOfIterations_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkClustering2DLayoutStrategy_GetMaxNumberOfIterationsMaxValue_11(HandleRef pThis);

		public virtual int GetMaxNumberOfIterationsMaxValue()
		{
			return vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_GetMaxNumberOfIterationsMaxValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkClustering2DLayoutStrategy_GetMaxNumberOfIterationsMinValue_12(HandleRef pThis);

		public virtual int GetMaxNumberOfIterationsMinValue()
		{
			return vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_GetMaxNumberOfIterationsMinValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkClustering2DLayoutStrategy_GetRandomSeed_13(HandleRef pThis);

		public virtual int GetRandomSeed()
		{
			return vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_GetRandomSeed_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkClustering2DLayoutStrategy_GetRandomSeedMaxValue_14(HandleRef pThis);

		public virtual int GetRandomSeedMaxValue()
		{
			return vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_GetRandomSeedMaxValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkClustering2DLayoutStrategy_GetRandomSeedMinValue_15(HandleRef pThis);

		public virtual int GetRandomSeedMinValue()
		{
			return vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_GetRandomSeedMinValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern float vtkClustering2DLayoutStrategy_GetRestDistance_16(HandleRef pThis);

		public virtual float GetRestDistance()
		{
			return vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_GetRestDistance_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkClustering2DLayoutStrategy_Initialize_17(HandleRef pThis);

		public override void Initialize()
		{
			vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_Initialize_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkClustering2DLayoutStrategy_IsA_18(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_IsA_18(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkClustering2DLayoutStrategy_IsLayoutComplete_19(HandleRef pThis);

		public override int IsLayoutComplete()
		{
			return vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_IsLayoutComplete_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkClustering2DLayoutStrategy_IsTypeOf_20(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_IsTypeOf_20(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkClustering2DLayoutStrategy_Layout_21(HandleRef pThis);

		public override void Layout()
		{
			vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_Layout_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkClustering2DLayoutStrategy_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkClustering2DLayoutStrategy NewInstance()
		{
			vtkClustering2DLayoutStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_NewInstance_23(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClustering2DLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkClustering2DLayoutStrategy_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkClustering2DLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkClustering2DLayoutStrategy vtkClustering2DLayoutStrategy = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkClustering2DLayoutStrategy = (vtkClustering2DLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkClustering2DLayoutStrategy.Register(null);
				}
			}
			return vtkClustering2DLayoutStrategy;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkClustering2DLayoutStrategy_SetCoolDownRate_25(HandleRef pThis, double _arg);

		public virtual void SetCoolDownRate(double _arg)
		{
			vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_SetCoolDownRate_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkClustering2DLayoutStrategy_SetInitialTemperature_26(HandleRef pThis, float _arg);

		public virtual void SetInitialTemperature(float _arg)
		{
			vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_SetInitialTemperature_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkClustering2DLayoutStrategy_SetIterationsPerLayout_27(HandleRef pThis, int _arg);

		public virtual void SetIterationsPerLayout(int _arg)
		{
			vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_SetIterationsPerLayout_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkClustering2DLayoutStrategy_SetMaxNumberOfIterations_28(HandleRef pThis, int _arg);

		public virtual void SetMaxNumberOfIterations(int _arg)
		{
			vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_SetMaxNumberOfIterations_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkClustering2DLayoutStrategy_SetRandomSeed_29(HandleRef pThis, int _arg);

		public virtual void SetRandomSeed(int _arg)
		{
			vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_SetRandomSeed_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkClustering2DLayoutStrategy_SetRestDistance_30(HandleRef pThis, float _arg);

		public virtual void SetRestDistance(float _arg)
		{
			vtkClustering2DLayoutStrategy.vtkClustering2DLayoutStrategy_SetRestDistance_30(base.GetCppThis(), _arg);
		}
	}
}
