using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMatrix4x4 : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMatrix4x4";

		public new static readonly string MRClassNameKey;

		static vtkMatrix4x4()
		{
			vtkMatrix4x4.MRClassNameKey = "class vtkMatrix4x4";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMatrix4x4.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMatrix4x4"));
		}

		public vtkMatrix4x4(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkMatrix4x4_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMatrix4x4 New()
		{
			vtkMatrix4x4 result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMatrix4x4.vtkMatrix4x4_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMatrix4x4() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMatrix4x4.vtkMatrix4x4_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrix4x4_Adjoint_01(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		public void Adjoint(vtkMatrix4x4 arg0, vtkMatrix4x4 arg1)
		{
			vtkMatrix4x4.vtkMatrix4x4_Adjoint_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrix4x4_Adjoint_02(IntPtr inElements, IntPtr outElements);

		public static void Adjoint(IntPtr inElements, IntPtr outElements)
		{
			vtkMatrix4x4.vtkMatrix4x4_Adjoint_02(inElements, outElements);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrix4x4_DeepCopy_03(HandleRef pThis, HandleRef source);

		public void DeepCopy(vtkMatrix4x4 source)
		{
			vtkMatrix4x4.vtkMatrix4x4_DeepCopy_03(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrix4x4_DeepCopy_04(IntPtr Elements, HandleRef source);

		public static void DeepCopy(IntPtr Elements, vtkMatrix4x4 source)
		{
			vtkMatrix4x4.vtkMatrix4x4_DeepCopy_04(Elements, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrix4x4_DeepCopy_05(IntPtr Elements, IntPtr newElements);

		public static void DeepCopy(IntPtr Elements, IntPtr newElements)
		{
			vtkMatrix4x4.vtkMatrix4x4_DeepCopy_05(Elements, newElements);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrix4x4_DeepCopy_06(HandleRef pThis, IntPtr Elements);

		public void DeepCopy(IntPtr Elements)
		{
			vtkMatrix4x4.vtkMatrix4x4_DeepCopy_06(base.GetCppThis(), Elements);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkMatrix4x4_Determinant_07(HandleRef pThis);

		public double Determinant()
		{
			return vtkMatrix4x4.vtkMatrix4x4_Determinant_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkMatrix4x4_Determinant_08(IntPtr Elements);

		public static double Determinant(IntPtr Elements)
		{
			return vtkMatrix4x4.vtkMatrix4x4_Determinant_08(Elements);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkMatrix4x4_Determinant_09(HandleRef pThis, vtkMatrix4x4 arg0);

		public double Determinant(vtkMatrix4x4 arg0)
		{
			return vtkMatrix4x4.vtkMatrix4x4_Determinant_09(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkMatrix4x4_GetElement_10(HandleRef pThis, int i, int j);

		public double GetElement(int i, int j)
		{
			return vtkMatrix4x4.vtkMatrix4x4_GetElement_10(base.GetCppThis(), i, j);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrix4x4_Identity_11(HandleRef pThis);

		public void Identity()
		{
			vtkMatrix4x4.vtkMatrix4x4_Identity_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrix4x4_Identity_12(IntPtr Elements);

		public static void Identity(IntPtr Elements)
		{
			vtkMatrix4x4.vtkMatrix4x4_Identity_12(Elements);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrix4x4_Invert_13(HandleRef arg0, HandleRef arg1);

		public static void Invert(vtkMatrix4x4 arg0, vtkMatrix4x4 arg1)
		{
			vtkMatrix4x4.vtkMatrix4x4_Invert_13((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrix4x4_Invert_14(HandleRef pThis);

		public void Invert()
		{
			vtkMatrix4x4.vtkMatrix4x4_Invert_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrix4x4_Invert_15(IntPtr inElements, IntPtr outElements);

		public static void Invert(IntPtr inElements, IntPtr outElements)
		{
			vtkMatrix4x4.vtkMatrix4x4_Invert_15(inElements, outElements);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkMatrix4x4_IsA_16(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMatrix4x4.vtkMatrix4x4_IsA_16(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkMatrix4x4_IsTypeOf_17(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMatrix4x4.vtkMatrix4x4_IsTypeOf_17(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrix4x4_Multiply4x4_18(HandleRef a, HandleRef b, HandleRef c);

		public static void Multiply4x4(vtkMatrix4x4 a, vtkMatrix4x4 b, vtkMatrix4x4 c)
		{
			vtkMatrix4x4.vtkMatrix4x4_Multiply4x4_18((a == null) ? default(HandleRef) : a.GetCppThis(), (b == null) ? default(HandleRef) : b.GetCppThis(), (c == null) ? default(HandleRef) : c.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrix4x4_Multiply4x4_19(IntPtr a, IntPtr b, IntPtr c);

		public static void Multiply4x4(IntPtr a, IntPtr b, IntPtr c)
		{
			vtkMatrix4x4.vtkMatrix4x4_Multiply4x4_19(a, b, c);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkMatrix4x4_MultiplyDoublePoint_20(HandleRef pThis, IntPtr arg0);

		public double[] MultiplyDoublePoint(IntPtr arg0)
		{
			IntPtr intPtr = vtkMatrix4x4.vtkMatrix4x4_MultiplyDoublePoint_20(base.GetCppThis(), arg0);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkMatrix4x4_MultiplyFloatPoint_21(HandleRef pThis, IntPtr arg0);

		public float[] MultiplyFloatPoint(IntPtr arg0)
		{
			IntPtr intPtr = vtkMatrix4x4.vtkMatrix4x4_MultiplyFloatPoint_21(base.GetCppThis(), arg0);
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrix4x4_MultiplyPoint_22(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		public void MultiplyPoint(IntPtr arg0, IntPtr arg1)
		{
			vtkMatrix4x4.vtkMatrix4x4_MultiplyPoint_22(base.GetCppThis(), arg0, arg1);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrix4x4_MultiplyPoint_23(IntPtr Elements, IntPtr arg1, IntPtr arg2);

		public static void MultiplyPoint(IntPtr Elements, IntPtr arg1, IntPtr arg2)
		{
			vtkMatrix4x4.vtkMatrix4x4_MultiplyPoint_23(Elements, arg1, arg2);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkMatrix4x4_MultiplyPoint_24(HandleRef pThis, IntPtr arg0);

		public float[] MultiplyPoint(IntPtr arg0)
		{
			IntPtr intPtr = vtkMatrix4x4.vtkMatrix4x4_MultiplyPoint_24(base.GetCppThis(), arg0);
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkMatrix4x4_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMatrix4x4 NewInstance()
		{
			vtkMatrix4x4 result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMatrix4x4.vtkMatrix4x4_NewInstance_26(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrix4x4_PointMultiply_27(IntPtr Elements, IntPtr arg1, IntPtr arg2);

		public static void PointMultiply(IntPtr Elements, IntPtr arg1, IntPtr arg2)
		{
			vtkMatrix4x4.vtkMatrix4x4_PointMultiply_27(Elements, arg1, arg2);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkMatrix4x4_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMatrix4x4 SafeDownCast(vtkObjectBase o)
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMatrix4x4.vtkMatrix4x4_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix4x = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix4x.Register(null);
				}
			}
			return vtkMatrix4x;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrix4x4_SetElement_29(HandleRef pThis, int i, int j, double value);

		public void SetElement(int i, int j, double value)
		{
			vtkMatrix4x4.vtkMatrix4x4_SetElement_29(base.GetCppThis(), i, j, value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrix4x4_Transpose_30(HandleRef arg0, HandleRef arg1);

		public static void Transpose(vtkMatrix4x4 arg0, vtkMatrix4x4 arg1)
		{
			vtkMatrix4x4.vtkMatrix4x4_Transpose_30((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrix4x4_Transpose_31(HandleRef pThis);

		public void Transpose()
		{
			vtkMatrix4x4.vtkMatrix4x4_Transpose_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrix4x4_Transpose_32(IntPtr inElements, IntPtr outElements);

		public static void Transpose(IntPtr inElements, IntPtr outElements)
		{
			vtkMatrix4x4.vtkMatrix4x4_Transpose_32(inElements, outElements);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrix4x4_Zero_33(HandleRef pThis);

		public void Zero()
		{
			vtkMatrix4x4.vtkMatrix4x4_Zero_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrix4x4_Zero_34(IntPtr Elements);

		public static void Zero(IntPtr Elements)
		{
			vtkMatrix4x4.vtkMatrix4x4_Zero_34(Elements);
		}
	}
}
