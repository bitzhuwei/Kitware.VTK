using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImplicitSum : vtkImplicitFunction
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitSum";

		public new static readonly string MRClassNameKey;

		static vtkImplicitSum()
		{
			vtkImplicitSum.MRClassNameKey = "class vtkImplicitSum";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImplicitSum.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitSum"));
		}

		public vtkImplicitSum(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitSum_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImplicitSum New()
		{
			vtkImplicitSum result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitSum.vtkImplicitSum_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitSum)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImplicitSum() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImplicitSum.vtkImplicitSum_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitSum_AddFunction_01(HandleRef pThis, HandleRef arg0, double weight);

		public void AddFunction(vtkImplicitFunction arg0, double weight)
		{
			vtkImplicitSum.vtkImplicitSum_AddFunction_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), weight);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitSum_AddFunction_02(HandleRef pThis, HandleRef arg0);

		public void AddFunction(vtkImplicitFunction arg0)
		{
			vtkImplicitSum.vtkImplicitSum_AddFunction_02(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkImplicitSum_EvaluateFunction_03(HandleRef pThis, IntPtr x);

		public override double EvaluateFunction(IntPtr x)
		{
			return vtkImplicitSum.vtkImplicitSum_EvaluateFunction_03(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkImplicitSum_EvaluateFunction_04(HandleRef pThis, double x, double y, double z);

		public new double EvaluateFunction(double x, double y, double z)
		{
			return vtkImplicitSum.vtkImplicitSum_EvaluateFunction_04(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitSum_EvaluateGradient_05(HandleRef pThis, IntPtr x, IntPtr g);

		public override void EvaluateGradient(IntPtr x, IntPtr g)
		{
			vtkImplicitSum.vtkImplicitSum_EvaluateGradient_05(base.GetCppThis(), x, g);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkImplicitSum_GetMTime_06(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkImplicitSum.vtkImplicitSum_GetMTime_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImplicitSum_GetNormalizeByWeight_07(HandleRef pThis);

		public virtual int GetNormalizeByWeight()
		{
			return vtkImplicitSum.vtkImplicitSum_GetNormalizeByWeight_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImplicitSum_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImplicitSum.vtkImplicitSum_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImplicitSum_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImplicitSum.vtkImplicitSum_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitSum_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImplicitSum NewInstance()
		{
			vtkImplicitSum result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitSum.vtkImplicitSum_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitSum)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitSum_NormalizeByWeightOff_12(HandleRef pThis);

		public virtual void NormalizeByWeightOff()
		{
			vtkImplicitSum.vtkImplicitSum_NormalizeByWeightOff_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitSum_NormalizeByWeightOn_13(HandleRef pThis);

		public virtual void NormalizeByWeightOn()
		{
			vtkImplicitSum.vtkImplicitSum_NormalizeByWeightOn_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitSum_RemoveAllFunctions_14(HandleRef pThis);

		public void RemoveAllFunctions()
		{
			vtkImplicitSum.vtkImplicitSum_RemoveAllFunctions_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitSum_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImplicitSum SafeDownCast(vtkObjectBase o)
		{
			vtkImplicitSum vtkImplicitSum = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitSum.vtkImplicitSum_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitSum = (vtkImplicitSum)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitSum.Register(null);
				}
			}
			return vtkImplicitSum;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitSum_SetFunctionWeight_16(HandleRef pThis, HandleRef f, double weight);

		public void SetFunctionWeight(vtkImplicitFunction f, double weight)
		{
			vtkImplicitSum.vtkImplicitSum_SetFunctionWeight_16(base.GetCppThis(), (f == null) ? default(HandleRef) : f.GetCppThis(), weight);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitSum_SetNormalizeByWeight_17(HandleRef pThis, int _arg);

		public virtual void SetNormalizeByWeight(int _arg)
		{
			vtkImplicitSum.vtkImplicitSum_SetNormalizeByWeight_17(base.GetCppThis(), _arg);
		}
	}
}
