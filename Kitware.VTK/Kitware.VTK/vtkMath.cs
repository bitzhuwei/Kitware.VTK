using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMath : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMath";

		public new static readonly string MRClassNameKey;

		static vtkMath()
		{
			vtkMath.MRClassNameKey = "class vtkMath";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMath.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMath"));
		}

		public vtkMath(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkMath_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMath New()
		{
			vtkMath result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMath.vtkMath_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMath() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMath.vtkMath_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMath_Add_01(IntPtr a, IntPtr b, IntPtr c);

		public static void Add(IntPtr a, IntPtr b, IntPtr c)
		{
			vtkMath.vtkMath_Add_01(a, b, c);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkMath_AreBoundsInitialized_02(IntPtr bounds);

		public static int AreBoundsInitialized(IntPtr bounds)
		{
			return vtkMath.vtkMath_AreBoundsInitialized_02(bounds);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkMath_BeginCombination_03(int m, int n);

		public static IntPtr BeginCombination(int m, int n)
		{
			return vtkMath.vtkMath_BeginCombination_03(m, n);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkMath_Binomial_04(int m, int n);

		public static long Binomial(int m, int n)
		{
			return vtkMath.vtkMath_Binomial_04(m, n);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkMath_BoundsIsWithinOtherBounds_05(IntPtr bounds1, IntPtr bounds2, IntPtr delta);

		public static int BoundsIsWithinOtherBounds(IntPtr bounds1, IntPtr bounds2, IntPtr delta)
		{
			return vtkMath.vtkMath_BoundsIsWithinOtherBounds_05(bounds1, bounds2, delta);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkMath_Ceil_06(double x);

		public static int Ceil(double x)
		{
			return vtkMath.vtkMath_Ceil_06(x);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkMath_ClampAndNormalizeValue_07(double value, IntPtr range);

		public static double ClampAndNormalizeValue(double value, IntPtr range)
		{
			return vtkMath.vtkMath_ClampAndNormalizeValue_07(value, range);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMath_ClampValue_08(IntPtr value, IntPtr range);

		public static void ClampValue(IntPtr value, IntPtr range)
		{
			vtkMath.vtkMath_ClampValue_08(value, range);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMath_ClampValue_09(double value, IntPtr range, IntPtr clamped_value);

		public static void ClampValue(double value, IntPtr range, IntPtr clamped_value)
		{
			vtkMath.vtkMath_ClampValue_09(value, range, clamped_value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMath_ClampValues_10(IntPtr values, int nb_values, IntPtr range);

		public static void ClampValues(IntPtr values, int nb_values, IntPtr range)
		{
			vtkMath.vtkMath_ClampValues_10(values, nb_values, range);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMath_ClampValues_11(IntPtr values, int nb_values, IntPtr range, IntPtr clamped_values);

		public static void ClampValues(IntPtr values, int nb_values, IntPtr range, IntPtr clamped_values)
		{
			vtkMath.vtkMath_ClampValues_11(values, nb_values, range, clamped_values);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMath_Cross_12(IntPtr x, IntPtr y, IntPtr z);

		public static void Cross(IntPtr x, IntPtr y, IntPtr z)
		{
			vtkMath.vtkMath_Cross_12(x, y, z);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern float vtkMath_DegreesFromRadians_13(float x);

		public static float DegreesFromRadians(float x)
		{
			return vtkMath.vtkMath_DegreesFromRadians_13(x);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkMath_DegreesFromRadians_14(double x);

		public static double DegreesFromRadians(double x)
		{
			return vtkMath.vtkMath_DegreesFromRadians_14(x);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern float vtkMath_Determinant2x2_15(IntPtr c1, IntPtr c2);

		public static float Determinant2x2(IntPtr c1, IntPtr c2)
		{
			return vtkMath.vtkMath_Determinant2x2_15(c1, c2);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkMath_Determinant2x2_16(double a, double b, double c, double d);

		public static double Determinant2x2(double a, double b, double c, double d)
		{
			return vtkMath.vtkMath_Determinant2x2_16(a, b, c, d);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern float vtkMath_Determinant3x3_17(IntPtr c1, IntPtr c2, IntPtr c3);

		public static float Determinant3x3(IntPtr c1, IntPtr c2, IntPtr c3)
		{
			return vtkMath.vtkMath_Determinant3x3_17(c1, c2, c3);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkMath_Determinant3x3_18(double a1, double a2, double a3, double b1, double b2, double b3, double c1, double c2, double c3);

		public static double Determinant3x3(double a1, double a2, double a3, double b1, double b2, double b3, double c1, double c2, double c3)
		{
			return vtkMath.vtkMath_Determinant3x3_18(a1, a2, a3, b1, b2, b3, c1, c2, c3);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern float vtkMath_Distance2BetweenPoints_19(IntPtr x, IntPtr y);

		public static float Distance2BetweenPoints(IntPtr x, IntPtr y)
		{
			return vtkMath.vtkMath_Distance2BetweenPoints_19(x, y);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern float vtkMath_Dot_20(IntPtr x, IntPtr y);

		public static float Dot(IntPtr x, IntPtr y)
		{
			return vtkMath.vtkMath_Dot_20(x, y);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern float vtkMath_Dot2D_21(IntPtr x, IntPtr y);

		public static float Dot2D(IntPtr x, IntPtr y)
		{
			return vtkMath.vtkMath_Dot2D_21(x, y);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkMath_DoublePi_22();

		public static double DoublePi()
		{
			return vtkMath.vtkMath_DoublePi_22();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkMath_DoubleTwoPi_23();

		public static double DoubleTwoPi()
		{
			return vtkMath.vtkMath_DoubleTwoPi_23();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkMath_ExtentIsWithinOtherExtent_24(IntPtr extent1, IntPtr extent2);

		public static int ExtentIsWithinOtherExtent(IntPtr extent1, IntPtr extent2)
		{
			return vtkMath.vtkMath_ExtentIsWithinOtherExtent_24(extent1, extent2);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern long vtkMath_Factorial_25(int N);

		public static long Factorial(int N)
		{
			return vtkMath.vtkMath_Factorial_25(N);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkMath_Floor_26(double x);

		public static int Floor(double x)
		{
			return vtkMath.vtkMath_Floor_26(x);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMath_FreeCombination_27(IntPtr combination);

		public static void FreeCombination(IntPtr combination)
		{
			vtkMath.vtkMath_FreeCombination_27(combination);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkMath_Gaussian_28();

		public static double Gaussian()
		{
			return vtkMath.vtkMath_Gaussian_28();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkMath_Gaussian_29(double mean, double std);

		public static double Gaussian(double mean, double std)
		{
			return vtkMath.vtkMath_Gaussian_29(mean, std);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkMath_GaussianAmplitude_30(double variance, double distanceFromMean);

		public static double GaussianAmplitude(double variance, double distanceFromMean)
		{
			return vtkMath.vtkMath_GaussianAmplitude_30(variance, distanceFromMean);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkMath_GaussianAmplitude_31(double mean, double variance, double position);

		public static double GaussianAmplitude(double mean, double variance, double position)
		{
			return vtkMath.vtkMath_GaussianAmplitude_31(mean, variance, position);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkMath_GaussianWeight_32(double variance, double distanceFromMean);

		public static double GaussianWeight(double variance, double distanceFromMean)
		{
			return vtkMath.vtkMath_GaussianWeight_32(variance, distanceFromMean);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkMath_GaussianWeight_33(double mean, double variance, double position);

		public static double GaussianWeight(double mean, double variance, double position)
		{
			return vtkMath.vtkMath_GaussianWeight_33(mean, variance, position);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkMath_GetAdjustedScalarRange_34(HandleRef array, int comp, IntPtr range);

		public static int GetAdjustedScalarRange(vtkDataArray array, int comp, IntPtr range)
		{
			return vtkMath.vtkMath_GetAdjustedScalarRange_34((array == null) ? default(HandleRef) : array.GetCppThis(), comp, range);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkMath_GetScalarTypeFittingRange_35(double range_min, double range_max, double scale, double shift);

		public static int GetScalarTypeFittingRange(double range_min, double range_max, double scale, double shift)
		{
			return vtkMath.vtkMath_GetScalarTypeFittingRange_35(range_min, range_max, scale, shift);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkMath_GetSeed_36();

		public static int GetSeed()
		{
			return vtkMath.vtkMath_GetSeed_36();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMath_HSVToRGB_37(IntPtr hsv, IntPtr rgb);

		public static void HSVToRGB(IntPtr hsv, IntPtr rgb)
		{
			vtkMath.vtkMath_HSVToRGB_37(hsv, rgb);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMath_HSVToRGB_38(float h, float s, float v, IntPtr r, IntPtr g, IntPtr b);

		public static void HSVToRGB(float h, float s, float v, IntPtr r, IntPtr g, IntPtr b)
		{
			vtkMath.vtkMath_HSVToRGB_38(h, s, v, r, g, b);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkMath_HSVToRGB_39(IntPtr hsv);

		public static double[] HSVToRGB(IntPtr hsv)
		{
			IntPtr intPtr = vtkMath.vtkMath_HSVToRGB_39(hsv);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkMath_HSVToRGB_40(double h, double s, double v);

		public static double[] HSVToRGB(double h, double s, double v)
		{
			IntPtr intPtr = vtkMath.vtkMath_HSVToRGB_40(h, s, v);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMath_HSVToRGB_41(double h, double s, double v, IntPtr r, IntPtr g, IntPtr b);

		public static void HSVToRGB(double h, double s, double v, IntPtr r, IntPtr g, IntPtr b)
		{
			vtkMath.vtkMath_HSVToRGB_41(h, s, v, r, g, b);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkMath_Inf_42();

		public static double Inf()
		{
			return vtkMath.vtkMath_Inf_42();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkMath_IsA_43(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMath.vtkMath_IsA_43(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkMath_IsInf_44(double x);

		public static int IsInf(double x)
		{
			return vtkMath.vtkMath_IsInf_44(x);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkMath_IsNan_45(double x);

		public static int IsNan(double x)
		{
			return vtkMath.vtkMath_IsNan_45(x);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkMath_IsTypeOf_46(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMath.vtkMath_IsTypeOf_46(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMath_LabToRGB_47(IntPtr lab, IntPtr rgb);

		public static void LabToRGB(IntPtr lab, IntPtr rgb)
		{
			vtkMath.vtkMath_LabToRGB_47(lab, rgb);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMath_LabToRGB_48(double L, double a, double b, IntPtr red, IntPtr green, IntPtr blue);

		public static void LabToRGB(double L, double a, double b, IntPtr red, IntPtr green, IntPtr blue)
		{
			vtkMath.vtkMath_LabToRGB_48(L, a, b, red, green, blue);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkMath_LabToRGB_49(IntPtr lab);

		public static IntPtr LabToRGB(IntPtr lab)
		{
			return vtkMath.vtkMath_LabToRGB_49(lab);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMath_LabToXYZ_50(IntPtr lab, IntPtr xyz);

		public static void LabToXYZ(IntPtr lab, IntPtr xyz)
		{
			vtkMath.vtkMath_LabToXYZ_50(lab, xyz);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMath_LabToXYZ_51(double L, double a, double b, IntPtr x, IntPtr y, IntPtr z);

		public static void LabToXYZ(double L, double a, double b, IntPtr x, IntPtr y, IntPtr z)
		{
			vtkMath.vtkMath_LabToXYZ_51(L, a, b, x, y, z);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkMath_LabToXYZ_52(IntPtr lab);

		public static IntPtr LabToXYZ(IntPtr lab)
		{
			return vtkMath.vtkMath_LabToXYZ_52(lab);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMath_MultiplyScalar_53(IntPtr a, float s);

		public static void MultiplyScalar(IntPtr a, float s)
		{
			vtkMath.vtkMath_MultiplyScalar_53(a, s);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMath_MultiplyScalar_54(IntPtr a, double s);

		public static void MultiplyScalar(IntPtr a, double s)
		{
			vtkMath.vtkMath_MultiplyScalar_54(a, s);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMath_MultiplyScalar2D_55(IntPtr a, float s);

		public static void MultiplyScalar2D(IntPtr a, float s)
		{
			vtkMath.vtkMath_MultiplyScalar2D_55(a, s);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMath_MultiplyScalar2D_56(IntPtr a, double s);

		public static void MultiplyScalar2D(IntPtr a, double s)
		{
			vtkMath.vtkMath_MultiplyScalar2D_56(a, s);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkMath_Nan_57();

		public static double Nan()
		{
			return vtkMath.vtkMath_Nan_57();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkMath_NegInf_58();

		public static double NegInf()
		{
			return vtkMath.vtkMath_NegInf_58();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkMath_NewInstance_60(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMath NewInstance()
		{
			vtkMath result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMath.vtkMath_NewInstance_60(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkMath_NextCombination_61(int m, int n, IntPtr combination);

		public static int NextCombination(int m, int n, IntPtr combination)
		{
			return vtkMath.vtkMath_NextCombination_61(m, n, combination);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern float vtkMath_Norm_62(IntPtr x, int n);

		public static float Norm(IntPtr x, int n)
		{
			return vtkMath.vtkMath_Norm_62(x, n);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern float vtkMath_Norm_63(IntPtr x);

		public static float Norm(IntPtr x)
		{
			return vtkMath.vtkMath_Norm_63(x);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern float vtkMath_Norm2D_64(IntPtr x);

		public static float Norm2D(IntPtr x)
		{
			return vtkMath.vtkMath_Norm2D_64(x);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern float vtkMath_Normalize_65(IntPtr x);

		public static float Normalize(IntPtr x)
		{
			return vtkMath.vtkMath_Normalize_65(x);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern float vtkMath_Normalize2D_66(IntPtr x);

		public static float Normalize2D(IntPtr x)
		{
			return vtkMath.vtkMath_Normalize2D_66(x);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMath_Perpendiculars_67(IntPtr x, IntPtr y, IntPtr z, double theta);

		public static void Perpendiculars(IntPtr x, IntPtr y, IntPtr z, double theta)
		{
			vtkMath.vtkMath_Perpendiculars_67(x, y, z, theta);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern float vtkMath_Pi_68();

		public static float Pi()
		{
			return vtkMath.vtkMath_Pi_68();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkMath_PointIsWithinBounds_69(IntPtr point, IntPtr bounds, IntPtr delta);

		public static int PointIsWithinBounds(IntPtr point, IntPtr bounds, IntPtr delta)
		{
			return vtkMath.vtkMath_PointIsWithinBounds_69(point, bounds, delta);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern byte vtkMath_ProjectVector_70(IntPtr a, IntPtr b, IntPtr projection);

		public static bool ProjectVector(IntPtr a, IntPtr b, IntPtr projection)
		{
			return vtkMath.vtkMath_ProjectVector_70(a, b, projection) != 0;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern byte vtkMath_ProjectVector2D_71(IntPtr a, IntPtr b, IntPtr projection);

		public static bool ProjectVector2D(IntPtr a, IntPtr b, IntPtr projection)
		{
			return vtkMath.vtkMath_ProjectVector2D_71(a, b, projection) != 0;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMath_RGBToHSV_72(IntPtr rgb, IntPtr hsv);

		public static void RGBToHSV(IntPtr rgb, IntPtr hsv)
		{
			vtkMath.vtkMath_RGBToHSV_72(rgb, hsv);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMath_RGBToHSV_73(float r, float g, float b, IntPtr h, IntPtr s, IntPtr v);

		public static void RGBToHSV(float r, float g, float b, IntPtr h, IntPtr s, IntPtr v)
		{
			vtkMath.vtkMath_RGBToHSV_73(r, g, b, h, s, v);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkMath_RGBToHSV_74(IntPtr rgb);

		public static double[] RGBToHSV(IntPtr rgb)
		{
			IntPtr intPtr = vtkMath.vtkMath_RGBToHSV_74(rgb);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkMath_RGBToHSV_75(double r, double g, double b);

		public static double[] RGBToHSV(double r, double g, double b)
		{
			IntPtr intPtr = vtkMath.vtkMath_RGBToHSV_75(r, g, b);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMath_RGBToHSV_76(double r, double g, double b, IntPtr h, IntPtr s, IntPtr v);

		public static void RGBToHSV(double r, double g, double b, IntPtr h, IntPtr s, IntPtr v)
		{
			vtkMath.vtkMath_RGBToHSV_76(r, g, b, h, s, v);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMath_RGBToLab_77(IntPtr rgb, IntPtr lab);

		public static void RGBToLab(IntPtr rgb, IntPtr lab)
		{
			vtkMath.vtkMath_RGBToLab_77(rgb, lab);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMath_RGBToLab_78(double red, double green, double blue, IntPtr L, IntPtr a, IntPtr b);

		public static void RGBToLab(double red, double green, double blue, IntPtr L, IntPtr a, IntPtr b)
		{
			vtkMath.vtkMath_RGBToLab_78(red, green, blue, L, a, b);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkMath_RGBToLab_79(IntPtr rgb);

		public static IntPtr RGBToLab(IntPtr rgb)
		{
			return vtkMath.vtkMath_RGBToLab_79(rgb);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMath_RGBToXYZ_80(IntPtr rgb, IntPtr xyz);

		public static void RGBToXYZ(IntPtr rgb, IntPtr xyz)
		{
			vtkMath.vtkMath_RGBToXYZ_80(rgb, xyz);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMath_RGBToXYZ_81(double r, double g, double b, IntPtr x, IntPtr y, IntPtr z);

		public static void RGBToXYZ(double r, double g, double b, IntPtr x, IntPtr y, IntPtr z)
		{
			vtkMath.vtkMath_RGBToXYZ_81(r, g, b, x, y, z);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkMath_RGBToXYZ_82(IntPtr rgb);

		public static IntPtr RGBToXYZ(IntPtr rgb)
		{
			return vtkMath.vtkMath_RGBToXYZ_82(rgb);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern float vtkMath_RadiansFromDegrees_83(float x);

		public static float RadiansFromDegrees(float x)
		{
			return vtkMath.vtkMath_RadiansFromDegrees_83(x);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkMath_RadiansFromDegrees_84(double x);

		public static double RadiansFromDegrees(double x)
		{
			return vtkMath.vtkMath_RadiansFromDegrees_84(x);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkMath_Random_85();

		public static double Random()
		{
			return vtkMath.vtkMath_Random_85();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkMath_Random_86(double min, double max);

		public static double Random(double min, double max)
		{
			return vtkMath.vtkMath_Random_86(min, max);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMath_RandomSeed_87(int s);

		public static void RandomSeed(int s)
		{
			vtkMath.vtkMath_RandomSeed_87(s);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkMath_Round_88(float f);

		public static int Round(float f)
		{
			return vtkMath.vtkMath_Round_88(f);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkMath_Round_89(double f);

		public static int Round(double f)
		{
			return vtkMath.vtkMath_Round_89(f);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkMath_SafeDownCast_90(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMath SafeDownCast(vtkObjectBase o)
		{
			vtkMath vtkMath = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMath.vtkMath_SafeDownCast_90((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMath = (vtkMath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMath.Register(null);
				}
			}
			return vtkMath;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkMath_Solve3PointCircle_91(IntPtr p1, IntPtr p2, IntPtr p3, IntPtr center);

		public static double Solve3PointCircle(IntPtr p1, IntPtr p2, IntPtr p3, IntPtr center)
		{
			return vtkMath.vtkMath_Solve3PointCircle_91(p1, p2, p3, center);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMath_Subtract_92(IntPtr a, IntPtr b, IntPtr c);

		public static void Subtract(IntPtr a, IntPtr b, IntPtr c)
		{
			vtkMath.vtkMath_Subtract_92(a, b, c);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMath_UninitializeBounds_93(IntPtr bounds);

		public static void UninitializeBounds(IntPtr bounds)
		{
			vtkMath.vtkMath_UninitializeBounds_93(bounds);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMath_XYZToLab_94(IntPtr xyz, IntPtr lab);

		public static void XYZToLab(IntPtr xyz, IntPtr lab)
		{
			vtkMath.vtkMath_XYZToLab_94(xyz, lab);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMath_XYZToLab_95(double x, double y, double z, IntPtr L, IntPtr a, IntPtr b);

		public static void XYZToLab(double x, double y, double z, IntPtr L, IntPtr a, IntPtr b)
		{
			vtkMath.vtkMath_XYZToLab_95(x, y, z, L, a, b);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkMath_XYZToLab_96(IntPtr xyz);

		public static IntPtr XYZToLab(IntPtr xyz)
		{
			return vtkMath.vtkMath_XYZToLab_96(xyz);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMath_XYZToRGB_97(IntPtr xyz, IntPtr rgb);

		public static void XYZToRGB(IntPtr xyz, IntPtr rgb)
		{
			vtkMath.vtkMath_XYZToRGB_97(xyz, rgb);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMath_XYZToRGB_98(double x, double y, double z, IntPtr r, IntPtr g, IntPtr b);

		public static void XYZToRGB(double x, double y, double z, IntPtr r, IntPtr g, IntPtr b)
		{
			vtkMath.vtkMath_XYZToRGB_98(x, y, z, r, g, b);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkMath_XYZToRGB_99(IntPtr xyz);

		public static IntPtr XYZToRGB(IntPtr xyz)
		{
			return vtkMath.vtkMath_XYZToRGB_99(xyz);
		}
	}
}
