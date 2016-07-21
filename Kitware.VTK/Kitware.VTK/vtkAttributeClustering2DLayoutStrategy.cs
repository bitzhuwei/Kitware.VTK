using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkAttributeClustering2DLayoutStrategy : vtkGraphLayoutStrategy
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkAttributeClustering2DLayoutStrategy";

		public new static readonly string MRClassNameKey;

		static vtkAttributeClustering2DLayoutStrategy()
		{
			vtkAttributeClustering2DLayoutStrategy.MRClassNameKey = "class vtkAttributeClustering2DLayoutStrategy";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAttributeClustering2DLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAttributeClustering2DLayoutStrategy"));
		}

		public vtkAttributeClustering2DLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkAttributeClustering2DLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAttributeClustering2DLayoutStrategy New()
		{
			vtkAttributeClustering2DLayoutStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAttributeClustering2DLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkAttributeClustering2DLayoutStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkAttributeClustering2DLayoutStrategy_GetCoolDownRate_01(HandleRef pThis);

		public virtual double GetCoolDownRate()
		{
			return vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_GetCoolDownRate_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkAttributeClustering2DLayoutStrategy_GetCoolDownRateMaxValue_02(HandleRef pThis);

		public virtual double GetCoolDownRateMaxValue()
		{
			return vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_GetCoolDownRateMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkAttributeClustering2DLayoutStrategy_GetCoolDownRateMinValue_03(HandleRef pThis);

		public virtual double GetCoolDownRateMinValue()
		{
			return vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_GetCoolDownRateMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern float vtkAttributeClustering2DLayoutStrategy_GetInitialTemperature_04(HandleRef pThis);

		public virtual float GetInitialTemperature()
		{
			return vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_GetInitialTemperature_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern float vtkAttributeClustering2DLayoutStrategy_GetInitialTemperatureMaxValue_05(HandleRef pThis);

		public virtual float GetInitialTemperatureMaxValue()
		{
			return vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_GetInitialTemperatureMaxValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern float vtkAttributeClustering2DLayoutStrategy_GetInitialTemperatureMinValue_06(HandleRef pThis);

		public virtual float GetInitialTemperatureMinValue()
		{
			return vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_GetInitialTemperatureMinValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkAttributeClustering2DLayoutStrategy_GetIterationsPerLayout_07(HandleRef pThis);

		public virtual int GetIterationsPerLayout()
		{
			return vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_GetIterationsPerLayout_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkAttributeClustering2DLayoutStrategy_GetIterationsPerLayoutMaxValue_08(HandleRef pThis);

		public virtual int GetIterationsPerLayoutMaxValue()
		{
			return vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_GetIterationsPerLayoutMaxValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkAttributeClustering2DLayoutStrategy_GetIterationsPerLayoutMinValue_09(HandleRef pThis);

		public virtual int GetIterationsPerLayoutMinValue()
		{
			return vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_GetIterationsPerLayoutMinValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkAttributeClustering2DLayoutStrategy_GetMaxNumberOfIterations_10(HandleRef pThis);

		public virtual int GetMaxNumberOfIterations()
		{
			return vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_GetMaxNumberOfIterations_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkAttributeClustering2DLayoutStrategy_GetMaxNumberOfIterationsMaxValue_11(HandleRef pThis);

		public virtual int GetMaxNumberOfIterationsMaxValue()
		{
			return vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_GetMaxNumberOfIterationsMaxValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkAttributeClustering2DLayoutStrategy_GetMaxNumberOfIterationsMinValue_12(HandleRef pThis);

		public virtual int GetMaxNumberOfIterationsMinValue()
		{
			return vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_GetMaxNumberOfIterationsMinValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkAttributeClustering2DLayoutStrategy_GetRandomSeed_13(HandleRef pThis);

		public virtual int GetRandomSeed()
		{
			return vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_GetRandomSeed_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkAttributeClustering2DLayoutStrategy_GetRandomSeedMaxValue_14(HandleRef pThis);

		public virtual int GetRandomSeedMaxValue()
		{
			return vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_GetRandomSeedMaxValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkAttributeClustering2DLayoutStrategy_GetRandomSeedMinValue_15(HandleRef pThis);

		public virtual int GetRandomSeedMinValue()
		{
			return vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_GetRandomSeedMinValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern float vtkAttributeClustering2DLayoutStrategy_GetRestDistance_16(HandleRef pThis);

		public virtual float GetRestDistance()
		{
			return vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_GetRestDistance_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkAttributeClustering2DLayoutStrategy_GetVertexAttribute_17(HandleRef pThis);

		public virtual string GetVertexAttribute()
		{
			return Marshal.PtrToStringAnsi(vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_GetVertexAttribute_17(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkAttributeClustering2DLayoutStrategy_Initialize_18(HandleRef pThis);

		public override void Initialize()
		{
			vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_Initialize_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkAttributeClustering2DLayoutStrategy_IsA_19(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_IsA_19(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkAttributeClustering2DLayoutStrategy_IsLayoutComplete_20(HandleRef pThis);

		public override int IsLayoutComplete()
		{
			return vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_IsLayoutComplete_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkAttributeClustering2DLayoutStrategy_IsTypeOf_21(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_IsTypeOf_21(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkAttributeClustering2DLayoutStrategy_Layout_22(HandleRef pThis);

		public override void Layout()
		{
			vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_Layout_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkAttributeClustering2DLayoutStrategy_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAttributeClustering2DLayoutStrategy NewInstance()
		{
			vtkAttributeClustering2DLayoutStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_NewInstance_24(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAttributeClustering2DLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkAttributeClustering2DLayoutStrategy_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAttributeClustering2DLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkAttributeClustering2DLayoutStrategy vtkAttributeClustering2DLayoutStrategy = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAttributeClustering2DLayoutStrategy = (vtkAttributeClustering2DLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAttributeClustering2DLayoutStrategy.Register(null);
				}
			}
			return vtkAttributeClustering2DLayoutStrategy;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkAttributeClustering2DLayoutStrategy_SetCoolDownRate_26(HandleRef pThis, double _arg);

		public virtual void SetCoolDownRate(double _arg)
		{
			vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_SetCoolDownRate_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkAttributeClustering2DLayoutStrategy_SetInitialTemperature_27(HandleRef pThis, float _arg);

		public virtual void SetInitialTemperature(float _arg)
		{
			vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_SetInitialTemperature_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkAttributeClustering2DLayoutStrategy_SetIterationsPerLayout_28(HandleRef pThis, int _arg);

		public virtual void SetIterationsPerLayout(int _arg)
		{
			vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_SetIterationsPerLayout_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkAttributeClustering2DLayoutStrategy_SetMaxNumberOfIterations_29(HandleRef pThis, int _arg);

		public virtual void SetMaxNumberOfIterations(int _arg)
		{
			vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_SetMaxNumberOfIterations_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkAttributeClustering2DLayoutStrategy_SetRandomSeed_30(HandleRef pThis, int _arg);

		public virtual void SetRandomSeed(int _arg)
		{
			vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_SetRandomSeed_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkAttributeClustering2DLayoutStrategy_SetRestDistance_31(HandleRef pThis, float _arg);

		public virtual void SetRestDistance(float _arg)
		{
			vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_SetRestDistance_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkAttributeClustering2DLayoutStrategy_SetVertexAttribute_32(HandleRef pThis, string arg0);

		public void SetVertexAttribute(string arg0)
		{
			vtkAttributeClustering2DLayoutStrategy.vtkAttributeClustering2DLayoutStrategy_SetVertexAttribute_32(base.GetCppThis(), arg0);
		}
	}
}
