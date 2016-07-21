using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkAmoebaMinimizer : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkAmoebaMinimizer";

		public new static readonly string MRClassNameKey;

		static vtkAmoebaMinimizer()
		{
			vtkAmoebaMinimizer.MRClassNameKey = "class vtkAmoebaMinimizer";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAmoebaMinimizer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAmoebaMinimizer"));
		}

		public vtkAmoebaMinimizer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAmoebaMinimizer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAmoebaMinimizer New()
		{
			vtkAmoebaMinimizer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAmoebaMinimizer.vtkAmoebaMinimizer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAmoebaMinimizer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkAmoebaMinimizer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkAmoebaMinimizer.vtkAmoebaMinimizer_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAmoebaMinimizer_EvaluateFunction_01(HandleRef pThis);

		public void EvaluateFunction()
		{
			vtkAmoebaMinimizer.vtkAmoebaMinimizer_EvaluateFunction_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkAmoebaMinimizer_GetFunctionEvaluations_02(HandleRef pThis);

		public virtual int GetFunctionEvaluations()
		{
			return vtkAmoebaMinimizer.vtkAmoebaMinimizer_GetFunctionEvaluations_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkAmoebaMinimizer_GetFunctionValue_03(HandleRef pThis);

		public double GetFunctionValue()
		{
			return vtkAmoebaMinimizer.vtkAmoebaMinimizer_GetFunctionValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkAmoebaMinimizer_GetIterations_04(HandleRef pThis);

		public virtual int GetIterations()
		{
			return vtkAmoebaMinimizer.vtkAmoebaMinimizer_GetIterations_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkAmoebaMinimizer_GetMaxIterations_05(HandleRef pThis);

		public virtual int GetMaxIterations()
		{
			return vtkAmoebaMinimizer.vtkAmoebaMinimizer_GetMaxIterations_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkAmoebaMinimizer_GetNumberOfParameters_06(HandleRef pThis);

		public int GetNumberOfParameters()
		{
			return vtkAmoebaMinimizer.vtkAmoebaMinimizer_GetNumberOfParameters_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAmoebaMinimizer_GetParameterName_07(HandleRef pThis, int i);

		public string GetParameterName(int i)
		{
			return Marshal.PtrToStringAnsi(vtkAmoebaMinimizer.vtkAmoebaMinimizer_GetParameterName_07(base.GetCppThis(), i));
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkAmoebaMinimizer_GetParameterScale_08(HandleRef pThis, string name);

		public double GetParameterScale(string name)
		{
			return vtkAmoebaMinimizer.vtkAmoebaMinimizer_GetParameterScale_08(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkAmoebaMinimizer_GetParameterScale_09(HandleRef pThis, int i);

		public double GetParameterScale(int i)
		{
			return vtkAmoebaMinimizer.vtkAmoebaMinimizer_GetParameterScale_09(base.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkAmoebaMinimizer_GetParameterValue_10(HandleRef pThis, string name);

		public double GetParameterValue(string name)
		{
			return vtkAmoebaMinimizer.vtkAmoebaMinimizer_GetParameterValue_10(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkAmoebaMinimizer_GetParameterValue_11(HandleRef pThis, int i);

		public double GetParameterValue(int i)
		{
			return vtkAmoebaMinimizer.vtkAmoebaMinimizer_GetParameterValue_11(base.GetCppThis(), i);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkAmoebaMinimizer_GetTolerance_12(HandleRef pThis);

		public virtual double GetTolerance()
		{
			return vtkAmoebaMinimizer.vtkAmoebaMinimizer_GetTolerance_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAmoebaMinimizer_Initialize_13(HandleRef pThis);

		public void Initialize()
		{
			vtkAmoebaMinimizer.vtkAmoebaMinimizer_Initialize_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkAmoebaMinimizer_IsA_14(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAmoebaMinimizer.vtkAmoebaMinimizer_IsA_14(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkAmoebaMinimizer_IsTypeOf_15(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAmoebaMinimizer.vtkAmoebaMinimizer_IsTypeOf_15(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkAmoebaMinimizer_Iterate_16(HandleRef pThis);

		public virtual int Iterate()
		{
			return vtkAmoebaMinimizer.vtkAmoebaMinimizer_Iterate_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAmoebaMinimizer_Minimize_17(HandleRef pThis);

		public virtual void Minimize()
		{
			vtkAmoebaMinimizer.vtkAmoebaMinimizer_Minimize_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAmoebaMinimizer_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAmoebaMinimizer NewInstance()
		{
			vtkAmoebaMinimizer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAmoebaMinimizer.vtkAmoebaMinimizer_NewInstance_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAmoebaMinimizer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAmoebaMinimizer_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAmoebaMinimizer SafeDownCast(vtkObjectBase o)
		{
			vtkAmoebaMinimizer vtkAmoebaMinimizer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAmoebaMinimizer.vtkAmoebaMinimizer_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAmoebaMinimizer = (vtkAmoebaMinimizer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAmoebaMinimizer.Register(null);
				}
			}
			return vtkAmoebaMinimizer;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAmoebaMinimizer_SetFunctionValue_21(HandleRef pThis, double _arg);

		public virtual void SetFunctionValue(double _arg)
		{
			vtkAmoebaMinimizer.vtkAmoebaMinimizer_SetFunctionValue_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAmoebaMinimizer_SetMaxIterations_22(HandleRef pThis, int _arg);

		public virtual void SetMaxIterations(int _arg)
		{
			vtkAmoebaMinimizer.vtkAmoebaMinimizer_SetMaxIterations_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAmoebaMinimizer_SetParameterScale_23(HandleRef pThis, string name, double scale);

		public void SetParameterScale(string name, double scale)
		{
			vtkAmoebaMinimizer.vtkAmoebaMinimizer_SetParameterScale_23(base.GetCppThis(), name, scale);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAmoebaMinimizer_SetParameterScale_24(HandleRef pThis, int i, double scale);

		public void SetParameterScale(int i, double scale)
		{
			vtkAmoebaMinimizer.vtkAmoebaMinimizer_SetParameterScale_24(base.GetCppThis(), i, scale);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAmoebaMinimizer_SetParameterValue_25(HandleRef pThis, string name, double value);

		public void SetParameterValue(string name, double value)
		{
			vtkAmoebaMinimizer.vtkAmoebaMinimizer_SetParameterValue_25(base.GetCppThis(), name, value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAmoebaMinimizer_SetParameterValue_26(HandleRef pThis, int i, double value);

		public void SetParameterValue(int i, double value)
		{
			vtkAmoebaMinimizer.vtkAmoebaMinimizer_SetParameterValue_26(base.GetCppThis(), i, value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAmoebaMinimizer_SetTolerance_27(HandleRef pThis, double _arg);

		public virtual void SetTolerance(double _arg)
		{
			vtkAmoebaMinimizer.vtkAmoebaMinimizer_SetTolerance_27(base.GetCppThis(), _arg);
		}
	}
}
