using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImplicitWindowFunction : vtkImplicitFunction
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitWindowFunction";

		public new static readonly string MRClassNameKey;

		static vtkImplicitWindowFunction()
		{
			vtkImplicitWindowFunction.MRClassNameKey = "class vtkImplicitWindowFunction";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImplicitWindowFunction.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitWindowFunction"));
		}

		public vtkImplicitWindowFunction(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitWindowFunction_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImplicitWindowFunction New()
		{
			vtkImplicitWindowFunction result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitWindowFunction.vtkImplicitWindowFunction_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitWindowFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImplicitWindowFunction() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImplicitWindowFunction.vtkImplicitWindowFunction_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitWindowFunction_Register_14(HandleRef pThis, HandleRef o);

		public override void Register(vtkObjectBase o)
		{
			vtkImplicitWindowFunction.vtkImplicitWindowFunction_Register_14(base.GetCppThis(), (o == null) ? default(HandleRef) : o.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitWindowFunction_UnRegister_21(HandleRef pThis, HandleRef o);

		protected override void Dispose(bool disposing)
		{
			try
			{
				if (base.GetCallDisposalMethod())
				{
					vtkImplicitWindowFunction.vtkImplicitWindowFunction_UnRegister_21(base.GetCppThis(), default(HandleRef));
					base.ClearCppThis();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkImplicitWindowFunction_EvaluateFunction_01(HandleRef pThis, IntPtr x);

		public override double EvaluateFunction(IntPtr x)
		{
			return vtkImplicitWindowFunction.vtkImplicitWindowFunction_EvaluateFunction_01(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkImplicitWindowFunction_EvaluateFunction_02(HandleRef pThis, double x, double y, double z);

		public new double EvaluateFunction(double x, double y, double z)
		{
			return vtkImplicitWindowFunction.vtkImplicitWindowFunction_EvaluateFunction_02(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitWindowFunction_EvaluateGradient_03(HandleRef pThis, IntPtr x, IntPtr n);

		public override void EvaluateGradient(IntPtr x, IntPtr n)
		{
			vtkImplicitWindowFunction.vtkImplicitWindowFunction_EvaluateGradient_03(base.GetCppThis(), x, n);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitWindowFunction_GetImplicitFunction_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImplicitFunction GetImplicitFunction()
		{
			vtkImplicitFunction vtkImplicitFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitWindowFunction.vtkImplicitWindowFunction_GetImplicitFunction_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkImplicitWindowFunction_GetMTime_05(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkImplicitWindowFunction.vtkImplicitWindowFunction_GetMTime_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitWindowFunction_GetWindowRange_06(HandleRef pThis);

		public virtual double[] GetWindowRange()
		{
			IntPtr intPtr = vtkImplicitWindowFunction.vtkImplicitWindowFunction_GetWindowRange_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitWindowFunction_GetWindowRange_07(HandleRef pThis, IntPtr data);

		public virtual void GetWindowRange(IntPtr data)
		{
			vtkImplicitWindowFunction.vtkImplicitWindowFunction_GetWindowRange_07(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitWindowFunction_GetWindowValues_08(HandleRef pThis);

		public virtual double[] GetWindowValues()
		{
			IntPtr intPtr = vtkImplicitWindowFunction.vtkImplicitWindowFunction_GetWindowValues_08(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitWindowFunction_GetWindowValues_09(HandleRef pThis, IntPtr data);

		public virtual void GetWindowValues(IntPtr data)
		{
			vtkImplicitWindowFunction.vtkImplicitWindowFunction_GetWindowValues_09(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImplicitWindowFunction_IsA_10(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImplicitWindowFunction.vtkImplicitWindowFunction_IsA_10(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImplicitWindowFunction_IsTypeOf_11(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImplicitWindowFunction.vtkImplicitWindowFunction_IsTypeOf_11(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitWindowFunction_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImplicitWindowFunction NewInstance()
		{
			vtkImplicitWindowFunction result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitWindowFunction.vtkImplicitWindowFunction_NewInstance_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitWindowFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitWindowFunction_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImplicitWindowFunction SafeDownCast(vtkObjectBase o)
		{
			vtkImplicitWindowFunction vtkImplicitWindowFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitWindowFunction.vtkImplicitWindowFunction_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitWindowFunction = (vtkImplicitWindowFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitWindowFunction.Register(null);
				}
			}
			return vtkImplicitWindowFunction;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitWindowFunction_SetImplicitFunction_16(HandleRef pThis, HandleRef arg0);

		public virtual void SetImplicitFunction(vtkImplicitFunction arg0)
		{
			vtkImplicitWindowFunction.vtkImplicitWindowFunction_SetImplicitFunction_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitWindowFunction_SetWindowRange_17(HandleRef pThis, double _arg1, double _arg2);

		public virtual void SetWindowRange(double _arg1, double _arg2)
		{
			vtkImplicitWindowFunction.vtkImplicitWindowFunction_SetWindowRange_17(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitWindowFunction_SetWindowRange_18(HandleRef pThis, IntPtr _arg);

		public void SetWindowRange(IntPtr _arg)
		{
			vtkImplicitWindowFunction.vtkImplicitWindowFunction_SetWindowRange_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitWindowFunction_SetWindowValues_19(HandleRef pThis, double _arg1, double _arg2);

		public virtual void SetWindowValues(double _arg1, double _arg2)
		{
			vtkImplicitWindowFunction.vtkImplicitWindowFunction_SetWindowValues_19(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkImplicitWindowFunction_SetWindowValues_20(HandleRef pThis, IntPtr _arg);

		public void SetWindowValues(IntPtr _arg)
		{
			vtkImplicitWindowFunction.vtkImplicitWindowFunction_SetWindowValues_20(base.GetCppThis(), _arg);
		}
	}
}
