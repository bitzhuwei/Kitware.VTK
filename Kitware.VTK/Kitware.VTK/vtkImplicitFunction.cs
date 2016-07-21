using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkImplicitFunction : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitFunction";

		public new static readonly string MRClassNameKey;

		static vtkImplicitFunction()
		{
			vtkImplicitFunction.MRClassNameKey = "class vtkImplicitFunction";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImplicitFunction.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitFunction"));
		}

		public vtkImplicitFunction(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		private static extern IntPtr vtkImplicitFunctionShadow_CreateShadow(IntPtr primary);

		public vtkImplicitFunction() : this(IntPtr.Zero, false, false)
		{
			IntPtr iDispatchForObject = Marshal.GetIDispatchForObject(this);
			base.SetCppThis(vtkImplicitFunction.vtkImplicitFunctionShadow_CreateShadow(iDispatchForObject), true, false);
			Marshal.Release(iDispatchForObject);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkImplicitFunction_EvaluateFunction_01(HandleRef pThis, IntPtr x);

		public virtual double EvaluateFunction(IntPtr x)
		{
			return vtkImplicitFunction.vtkImplicitFunction_EvaluateFunction_01(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkImplicitFunction_EvaluateFunction_02(HandleRef pThis, double x, double y, double z);

		public double EvaluateFunction(double x, double y, double z)
		{
			return vtkImplicitFunction.vtkImplicitFunction_EvaluateFunction_02(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkImplicitFunction_EvaluateGradient_03(HandleRef pThis, IntPtr x, IntPtr g);

		public virtual void EvaluateGradient(IntPtr x, IntPtr g)
		{
			vtkImplicitFunction.vtkImplicitFunction_EvaluateGradient_03(base.GetCppThis(), x, g);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkImplicitFunction_FunctionGradient_04(HandleRef pThis, IntPtr x, IntPtr g);

		public void FunctionGradient(IntPtr x, IntPtr g)
		{
			vtkImplicitFunction.vtkImplicitFunction_FunctionGradient_04(base.GetCppThis(), x, g);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitFunction_FunctionGradient_05(HandleRef pThis, IntPtr x);

		public double[] FunctionGradient(IntPtr x)
		{
			IntPtr intPtr = vtkImplicitFunction.vtkImplicitFunction_FunctionGradient_05(base.GetCppThis(), x);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitFunction_FunctionGradient_06(HandleRef pThis, double x, double y, double z);

		public double[] FunctionGradient(double x, double y, double z)
		{
			IntPtr intPtr = vtkImplicitFunction.vtkImplicitFunction_FunctionGradient_06(base.GetCppThis(), x, y, z);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkImplicitFunction_FunctionValue_07(HandleRef pThis, IntPtr x);

		public double FunctionValue(IntPtr x)
		{
			return vtkImplicitFunction.vtkImplicitFunction_FunctionValue_07(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkImplicitFunction_FunctionValue_08(HandleRef pThis, double x, double y, double z);

		public double FunctionValue(double x, double y, double z)
		{
			return vtkImplicitFunction.vtkImplicitFunction_FunctionValue_08(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern uint vtkImplicitFunction_GetMTime_09(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkImplicitFunction.vtkImplicitFunction_GetMTime_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitFunction_GetTransform_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAbstractTransform GetTransform()
		{
			vtkAbstractTransform vtkAbstractTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitFunction.vtkImplicitFunction_GetTransform_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractTransform = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractTransform.Register(null);
				}
			}
			return vtkAbstractTransform;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkImplicitFunction_IsA_11(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImplicitFunction.vtkImplicitFunction_IsA_11(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkImplicitFunction_IsTypeOf_12(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImplicitFunction.vtkImplicitFunction_IsTypeOf_12(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitFunction_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImplicitFunction NewInstance()
		{
			vtkImplicitFunction result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitFunction.vtkImplicitFunction_NewInstance_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitFunction_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImplicitFunction SafeDownCast(vtkObjectBase o)
		{
			vtkImplicitFunction vtkImplicitFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitFunction.vtkImplicitFunction_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitFunction = (vtkImplicitFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitFunction.Register(null);
				}
			}
			return vtkImplicitFunction;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkImplicitFunction_SetTransform_15(HandleRef pThis, HandleRef arg0);

		public virtual void SetTransform(vtkAbstractTransform arg0)
		{
			vtkImplicitFunction.vtkImplicitFunction_SetTransform_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkImplicitFunction_SetTransform_16(HandleRef pThis, IntPtr elements);

		public virtual void SetTransform(IntPtr elements)
		{
			vtkImplicitFunction.vtkImplicitFunction_SetTransform_16(base.GetCppThis(), elements);
		}
	}
}
