using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPolynomialSolversUnivariate : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolynomialSolversUnivariate";

		public new static readonly string MRClassNameKey;

		static vtkPolynomialSolversUnivariate()
		{
			vtkPolynomialSolversUnivariate.MRClassNameKey = "class vtkPolynomialSolversUnivariate";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolynomialSolversUnivariate.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolynomialSolversUnivariate"));
		}

		public vtkPolynomialSolversUnivariate(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkPolynomialSolversUnivariate_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPolynomialSolversUnivariate New()
		{
			vtkPolynomialSolversUnivariate result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolynomialSolversUnivariate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPolynomialSolversUnivariate() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkPolynomialSolversUnivariate_FerrariSolve_01(IntPtr c, IntPtr r, IntPtr m, double tol);

		public static int FerrariSolve(IntPtr c, IntPtr r, IntPtr m, double tol)
		{
			return vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_FerrariSolve_01(c, r, m, tol);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkPolynomialSolversUnivariate_FilterRoots_02(IntPtr P, int d, IntPtr upperBnds, int rootcount, double diameter);

		public static int FilterRoots(IntPtr P, int d, IntPtr upperBnds, int rootcount, double diameter)
		{
			return vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_FilterRoots_02(P, d, upperBnds, rootcount, diameter);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkPolynomialSolversUnivariate_GetDivisionTolerance_03();

		public static double GetDivisionTolerance()
		{
			return vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_GetDivisionTolerance_03();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkPolynomialSolversUnivariate_HabichtBisectionSolve_04(IntPtr P, int d, IntPtr a, IntPtr upperBnds, double tol);

		public static int HabichtBisectionSolve(IntPtr P, int d, IntPtr a, IntPtr upperBnds, double tol)
		{
			return vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_HabichtBisectionSolve_04(P, d, a, upperBnds, tol);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkPolynomialSolversUnivariate_HabichtBisectionSolve_05(IntPtr P, int d, IntPtr a, IntPtr upperBnds, double tol, int intervalType);

		public static int HabichtBisectionSolve(IntPtr P, int d, IntPtr a, IntPtr upperBnds, double tol, int intervalType)
		{
			return vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_HabichtBisectionSolve_05(P, d, a, upperBnds, tol, intervalType);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkPolynomialSolversUnivariate_HabichtBisectionSolve_06(IntPtr P, int d, IntPtr a, IntPtr upperBnds, double tol, int intervalType, byte divideGCD);

		public static int HabichtBisectionSolve(IntPtr P, int d, IntPtr a, IntPtr upperBnds, double tol, int intervalType, bool divideGCD)
		{
			return vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_HabichtBisectionSolve_06(P, d, a, upperBnds, tol, intervalType, divideGCD ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkPolynomialSolversUnivariate_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkPolynomialSolversUnivariate_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkPolynomialSolversUnivariate_LinBairstowSolve_09(IntPtr c, int d, IntPtr r, ref double tolerance);

		public static int LinBairstowSolve(IntPtr c, int d, IntPtr r, ref double tolerance)
		{
			return vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_LinBairstowSolve_09(c, d, r, ref tolerance);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkPolynomialSolversUnivariate_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPolynomialSolversUnivariate NewInstance()
		{
			vtkPolynomialSolversUnivariate result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolynomialSolversUnivariate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkPolynomialSolversUnivariate_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPolynomialSolversUnivariate SafeDownCast(vtkObjectBase o)
		{
			vtkPolynomialSolversUnivariate vtkPolynomialSolversUnivariate = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolynomialSolversUnivariate = (vtkPolynomialSolversUnivariate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolynomialSolversUnivariate.Register(null);
				}
			}
			return vtkPolynomialSolversUnivariate;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPolynomialSolversUnivariate_SetDivisionTolerance_13(double tol);

		public static void SetDivisionTolerance(double tol)
		{
			vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_SetDivisionTolerance_13(tol);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkPolynomialSolversUnivariate_SolveCubic_14(double c0, double c1, double c2, double c3);

		public static IntPtr SolveCubic(double c0, double c1, double c2, double c3)
		{
			return vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_SolveCubic_14(c0, c1, c2, c3);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkPolynomialSolversUnivariate_SolveCubic_15(double c0, double c1, double c2, double c3, IntPtr r1, IntPtr r2, IntPtr r3, IntPtr num_roots);

		public static int SolveCubic(double c0, double c1, double c2, double c3, IntPtr r1, IntPtr r2, IntPtr r3, IntPtr num_roots)
		{
			return vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_SolveCubic_15(c0, c1, c2, c3, r1, r2, r3, num_roots);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkPolynomialSolversUnivariate_SolveLinear_16(double c0, double c1);

		public static IntPtr SolveLinear(double c0, double c1)
		{
			return vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_SolveLinear_16(c0, c1);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkPolynomialSolversUnivariate_SolveLinear_17(double c0, double c1, IntPtr r1, IntPtr num_roots);

		public static int SolveLinear(double c0, double c1, IntPtr r1, IntPtr num_roots)
		{
			return vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_SolveLinear_17(c0, c1, r1, num_roots);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkPolynomialSolversUnivariate_SolveQuadratic_18(double c0, double c1, double c2);

		public static IntPtr SolveQuadratic(double c0, double c1, double c2)
		{
			return vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_SolveQuadratic_18(c0, c1, c2);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkPolynomialSolversUnivariate_SolveQuadratic_19(double c0, double c1, double c2, IntPtr r1, IntPtr r2, IntPtr num_roots);

		public static int SolveQuadratic(double c0, double c1, double c2, IntPtr r1, IntPtr r2, IntPtr num_roots)
		{
			return vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_SolveQuadratic_19(c0, c1, c2, r1, r2, num_roots);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkPolynomialSolversUnivariate_SolveQuadratic_20(IntPtr c, IntPtr r, IntPtr m);

		public static int SolveQuadratic(IntPtr c, IntPtr r, IntPtr m)
		{
			return vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_SolveQuadratic_20(c, r, m);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkPolynomialSolversUnivariate_SturmBisectionSolve_21(IntPtr P, int d, IntPtr a, IntPtr upperBnds, double tol);

		public static int SturmBisectionSolve(IntPtr P, int d, IntPtr a, IntPtr upperBnds, double tol)
		{
			return vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_SturmBisectionSolve_21(P, d, a, upperBnds, tol);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkPolynomialSolversUnivariate_SturmBisectionSolve_22(IntPtr P, int d, IntPtr a, IntPtr upperBnds, double tol, int intervalType);

		public static int SturmBisectionSolve(IntPtr P, int d, IntPtr a, IntPtr upperBnds, double tol, int intervalType)
		{
			return vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_SturmBisectionSolve_22(P, d, a, upperBnds, tol, intervalType);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkPolynomialSolversUnivariate_SturmBisectionSolve_23(IntPtr P, int d, IntPtr a, IntPtr upperBnds, double tol, int intervalType, byte divideGCD);

		public static int SturmBisectionSolve(IntPtr P, int d, IntPtr a, IntPtr upperBnds, double tol, int intervalType, bool divideGCD)
		{
			return vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_SturmBisectionSolve_23(P, d, a, upperBnds, tol, intervalType, divideGCD ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkPolynomialSolversUnivariate_TartagliaCardanSolve_24(IntPtr c, IntPtr r, IntPtr m, double tol);

		public static int TartagliaCardanSolve(IntPtr c, IntPtr r, IntPtr m, double tol)
		{
			return vtkPolynomialSolversUnivariate.vtkPolynomialSolversUnivariate_TartagliaCardanSolve_24(c, r, m, tol);
		}
	}
}
