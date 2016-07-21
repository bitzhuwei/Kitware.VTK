using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkQuadric : vtkImplicitFunction
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkQuadric";

		public new static readonly string MRClassNameKey;

		static vtkQuadric()
		{
			vtkQuadric.MRClassNameKey = "class vtkQuadric";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkQuadric.MRClassNameKey, Type.GetType("Kitware.VTK.vtkQuadric"));
		}

		public vtkQuadric(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkQuadric_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkQuadric New()
		{
			vtkQuadric result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkQuadric.vtkQuadric_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkQuadric() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkQuadric.vtkQuadric_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkQuadric_EvaluateFunction_01(HandleRef pThis, IntPtr x);

		public override double EvaluateFunction(IntPtr x)
		{
			return vtkQuadric.vtkQuadric_EvaluateFunction_01(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkQuadric_EvaluateFunction_02(HandleRef pThis, double x, double y, double z);

		public new double EvaluateFunction(double x, double y, double z)
		{
			return vtkQuadric.vtkQuadric_EvaluateFunction_02(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkQuadric_EvaluateGradient_03(HandleRef pThis, IntPtr x, IntPtr g);

		public override void EvaluateGradient(IntPtr x, IntPtr g)
		{
			vtkQuadric.vtkQuadric_EvaluateGradient_03(base.GetCppThis(), x, g);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkQuadric_GetCoefficients_04(HandleRef pThis);

		public virtual double[] GetCoefficients()
		{
			IntPtr intPtr = vtkQuadric.vtkQuadric_GetCoefficients_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[0];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkQuadric_GetCoefficients_05(HandleRef pThis, IntPtr data);

		public virtual void GetCoefficients(IntPtr data)
		{
			vtkQuadric.vtkQuadric_GetCoefficients_05(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkQuadric_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkQuadric.vtkQuadric_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkQuadric_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkQuadric.vtkQuadric_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkQuadric_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkQuadric NewInstance()
		{
			vtkQuadric result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkQuadric.vtkQuadric_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkQuadric_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkQuadric SafeDownCast(vtkObjectBase o)
		{
			vtkQuadric vtkQuadric = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkQuadric.vtkQuadric_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkQuadric = (vtkQuadric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkQuadric.Register(null);
				}
			}
			return vtkQuadric;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkQuadric_SetCoefficients_11(HandleRef pThis, IntPtr a);

		public void SetCoefficients(IntPtr a)
		{
			vtkQuadric.vtkQuadric_SetCoefficients_11(base.GetCppThis(), a);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkQuadric_SetCoefficients_12(HandleRef pThis, double a0, double a1, double a2, double a3, double a4, double a5, double a6, double a7, double a8, double a9);

		public void SetCoefficients(double a0, double a1, double a2, double a3, double a4, double a5, double a6, double a7, double a8, double a9)
		{
			vtkQuadric.vtkQuadric_SetCoefficients_12(base.GetCppThis(), a0, a1, a2, a3, a4, a5, a6, a7, a8, a9);
		}
	}
}
