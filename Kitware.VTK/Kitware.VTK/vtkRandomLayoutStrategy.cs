using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkRandomLayoutStrategy : vtkGraphLayoutStrategy
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkRandomLayoutStrategy";

		public new static readonly string MRClassNameKey;

		static vtkRandomLayoutStrategy()
		{
			vtkRandomLayoutStrategy.MRClassNameKey = "class vtkRandomLayoutStrategy";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRandomLayoutStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRandomLayoutStrategy"));
		}

		public vtkRandomLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkRandomLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRandomLayoutStrategy New()
		{
			vtkRandomLayoutStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRandomLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkRandomLayoutStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkRandomLayoutStrategy_AutomaticBoundsComputationOff_01(HandleRef pThis);

		public virtual void AutomaticBoundsComputationOff()
		{
			vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_AutomaticBoundsComputationOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkRandomLayoutStrategy_AutomaticBoundsComputationOn_02(HandleRef pThis);

		public virtual void AutomaticBoundsComputationOn()
		{
			vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_AutomaticBoundsComputationOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkRandomLayoutStrategy_GetAutomaticBoundsComputation_03(HandleRef pThis);

		public virtual int GetAutomaticBoundsComputation()
		{
			return vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_GetAutomaticBoundsComputation_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkRandomLayoutStrategy_GetGraphBounds_04(HandleRef pThis);

		public virtual double[] GetGraphBounds()
		{
			IntPtr intPtr = vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_GetGraphBounds_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkRandomLayoutStrategy_GetGraphBounds_05(HandleRef pThis, IntPtr data);

		public virtual void GetGraphBounds(IntPtr data)
		{
			vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_GetGraphBounds_05(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkRandomLayoutStrategy_GetRandomSeed_06(HandleRef pThis);

		public virtual int GetRandomSeed()
		{
			return vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_GetRandomSeed_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkRandomLayoutStrategy_GetRandomSeedMaxValue_07(HandleRef pThis);

		public virtual int GetRandomSeedMaxValue()
		{
			return vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_GetRandomSeedMaxValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkRandomLayoutStrategy_GetRandomSeedMinValue_08(HandleRef pThis);

		public virtual int GetRandomSeedMinValue()
		{
			return vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_GetRandomSeedMinValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkRandomLayoutStrategy_GetThreeDimensionalLayout_09(HandleRef pThis);

		public virtual int GetThreeDimensionalLayout()
		{
			return vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_GetThreeDimensionalLayout_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkRandomLayoutStrategy_IsA_10(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_IsA_10(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkRandomLayoutStrategy_IsTypeOf_11(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_IsTypeOf_11(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkRandomLayoutStrategy_Layout_12(HandleRef pThis);

		public override void Layout()
		{
			vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_Layout_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkRandomLayoutStrategy_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRandomLayoutStrategy NewInstance()
		{
			vtkRandomLayoutStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_NewInstance_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRandomLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkRandomLayoutStrategy_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRandomLayoutStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkRandomLayoutStrategy vtkRandomLayoutStrategy = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRandomLayoutStrategy = (vtkRandomLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRandomLayoutStrategy.Register(null);
				}
			}
			return vtkRandomLayoutStrategy;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkRandomLayoutStrategy_SetAutomaticBoundsComputation_16(HandleRef pThis, int _arg);

		public virtual void SetAutomaticBoundsComputation(int _arg)
		{
			vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_SetAutomaticBoundsComputation_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkRandomLayoutStrategy_SetGraph_17(HandleRef pThis, HandleRef graph);

		public override void SetGraph(vtkGraph graph)
		{
			vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_SetGraph_17(base.GetCppThis(), (graph == null) ? default(HandleRef) : graph.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkRandomLayoutStrategy_SetGraphBounds_18(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		public virtual void SetGraphBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_SetGraphBounds_18(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkRandomLayoutStrategy_SetGraphBounds_19(HandleRef pThis, IntPtr _arg);

		public virtual void SetGraphBounds(IntPtr _arg)
		{
			vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_SetGraphBounds_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkRandomLayoutStrategy_SetRandomSeed_20(HandleRef pThis, int _arg);

		public virtual void SetRandomSeed(int _arg)
		{
			vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_SetRandomSeed_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkRandomLayoutStrategy_SetThreeDimensionalLayout_21(HandleRef pThis, int _arg);

		public virtual void SetThreeDimensionalLayout(int _arg)
		{
			vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_SetThreeDimensionalLayout_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkRandomLayoutStrategy_ThreeDimensionalLayoutOff_22(HandleRef pThis);

		public virtual void ThreeDimensionalLayoutOff()
		{
			vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_ThreeDimensionalLayoutOff_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkRandomLayoutStrategy_ThreeDimensionalLayoutOn_23(HandleRef pThis);

		public virtual void ThreeDimensionalLayoutOn()
		{
			vtkRandomLayoutStrategy.vtkRandomLayoutStrategy_ThreeDimensionalLayoutOn_23(base.GetCppThis());
		}
	}
}
