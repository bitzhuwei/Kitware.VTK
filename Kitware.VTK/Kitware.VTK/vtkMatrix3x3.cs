using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMatrix3x3 : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMatrix3x3";

		public new static readonly string MRClassNameKey;

		static vtkMatrix3x3()
		{
			vtkMatrix3x3.MRClassNameKey = "class vtkMatrix3x3";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMatrix3x3.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMatrix3x3"));
		}

		public vtkMatrix3x3(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkMatrix3x3_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMatrix3x3 New()
		{
			vtkMatrix3x3 result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMatrix3x3.vtkMatrix3x3_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMatrix3x3)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMatrix3x3() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMatrix3x3.vtkMatrix3x3_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrix3x3_Adjoint_01(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		public void Adjoint(vtkMatrix3x3 arg0, vtkMatrix3x3 arg1)
		{
			vtkMatrix3x3.vtkMatrix3x3_Adjoint_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrix3x3_Adjoint_02(IntPtr inElements, IntPtr outElements);

		public static void Adjoint(IntPtr inElements, IntPtr outElements)
		{
			vtkMatrix3x3.vtkMatrix3x3_Adjoint_02(inElements, outElements);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrix3x3_DeepCopy_03(HandleRef pThis, HandleRef source);

		public void DeepCopy(vtkMatrix3x3 source)
		{
			vtkMatrix3x3.vtkMatrix3x3_DeepCopy_03(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrix3x3_DeepCopy_04(IntPtr Elements, HandleRef source);

		public static void DeepCopy(IntPtr Elements, vtkMatrix3x3 source)
		{
			vtkMatrix3x3.vtkMatrix3x3_DeepCopy_04(Elements, (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrix3x3_DeepCopy_05(IntPtr Elements, IntPtr newElements);

		public static void DeepCopy(IntPtr Elements, IntPtr newElements)
		{
			vtkMatrix3x3.vtkMatrix3x3_DeepCopy_05(Elements, newElements);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrix3x3_DeepCopy_06(HandleRef pThis, IntPtr Elements);

		public void DeepCopy(IntPtr Elements)
		{
			vtkMatrix3x3.vtkMatrix3x3_DeepCopy_06(base.GetCppThis(), Elements);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkMatrix3x3_Determinant_07(HandleRef pThis);

		public double Determinant()
		{
			return vtkMatrix3x3.vtkMatrix3x3_Determinant_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkMatrix3x3_Determinant_08(IntPtr Elements);

		public static double Determinant(IntPtr Elements)
		{
			return vtkMatrix3x3.vtkMatrix3x3_Determinant_08(Elements);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkMatrix3x3_Determinant_09(HandleRef pThis, vtkMatrix3x3 arg0);

		public double Determinant(vtkMatrix3x3 arg0)
		{
			return vtkMatrix3x3.vtkMatrix3x3_Determinant_09(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkMatrix3x3_GetData_10(HandleRef pThis);

		public IntPtr GetData()
		{
			return vtkMatrix3x3.vtkMatrix3x3_GetData_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkMatrix3x3_GetElement_11(HandleRef pThis, int i, int j);

		public double GetElement(int i, int j)
		{
			return vtkMatrix3x3.vtkMatrix3x3_GetElement_11(base.GetCppThis(), i, j);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrix3x3_Identity_12(HandleRef pThis);

		public void Identity()
		{
			vtkMatrix3x3.vtkMatrix3x3_Identity_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrix3x3_Identity_13(IntPtr Elements);

		public static void Identity(IntPtr Elements)
		{
			vtkMatrix3x3.vtkMatrix3x3_Identity_13(Elements);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrix3x3_Invert_14(HandleRef arg0, HandleRef arg1);

		public static void Invert(vtkMatrix3x3 arg0, vtkMatrix3x3 arg1)
		{
			vtkMatrix3x3.vtkMatrix3x3_Invert_14((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrix3x3_Invert_15(HandleRef pThis);

		public void Invert()
		{
			vtkMatrix3x3.vtkMatrix3x3_Invert_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrix3x3_Invert_16(IntPtr inElements, IntPtr outElements);

		public static void Invert(IntPtr inElements, IntPtr outElements)
		{
			vtkMatrix3x3.vtkMatrix3x3_Invert_16(inElements, outElements);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkMatrix3x3_IsA_17(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMatrix3x3.vtkMatrix3x3_IsA_17(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern byte vtkMatrix3x3_IsIdentity_18(HandleRef pThis);

		public bool IsIdentity()
		{
			return vtkMatrix3x3.vtkMatrix3x3_IsIdentity_18(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkMatrix3x3_IsTypeOf_19(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMatrix3x3.vtkMatrix3x3_IsTypeOf_19(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrix3x3_Multiply3x3_20(HandleRef a, HandleRef b, HandleRef c);

		public static void Multiply3x3(vtkMatrix3x3 a, vtkMatrix3x3 b, vtkMatrix3x3 c)
		{
			vtkMatrix3x3.vtkMatrix3x3_Multiply3x3_20((a == null) ? default(HandleRef) : a.GetCppThis(), (b == null) ? default(HandleRef) : b.GetCppThis(), (c == null) ? default(HandleRef) : c.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrix3x3_Multiply3x3_21(IntPtr a, IntPtr b, IntPtr c);

		public static void Multiply3x3(IntPtr a, IntPtr b, IntPtr c)
		{
			vtkMatrix3x3.vtkMatrix3x3_Multiply3x3_21(a, b, c);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrix3x3_MultiplyPoint_22(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		public void MultiplyPoint(IntPtr arg0, IntPtr arg1)
		{
			vtkMatrix3x3.vtkMatrix3x3_MultiplyPoint_22(base.GetCppThis(), arg0, arg1);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrix3x3_MultiplyPoint_23(IntPtr Elements, IntPtr arg1, IntPtr arg2);

		public static void MultiplyPoint(IntPtr Elements, IntPtr arg1, IntPtr arg2)
		{
			vtkMatrix3x3.vtkMatrix3x3_MultiplyPoint_23(Elements, arg1, arg2);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkMatrix3x3_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMatrix3x3 NewInstance()
		{
			vtkMatrix3x3 result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMatrix3x3.vtkMatrix3x3_NewInstance_25(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMatrix3x3)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrix3x3_PointMultiply_26(IntPtr Elements, IntPtr arg1, IntPtr arg2);

		public static void PointMultiply(IntPtr Elements, IntPtr arg1, IntPtr arg2)
		{
			vtkMatrix3x3.vtkMatrix3x3_PointMultiply_26(Elements, arg1, arg2);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkMatrix3x3_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMatrix3x3 SafeDownCast(vtkObjectBase o)
		{
			vtkMatrix3x3 vtkMatrix3x = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMatrix3x3.vtkMatrix3x3_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix3x = (vtkMatrix3x3)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix3x.Register(null);
				}
			}
			return vtkMatrix3x;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrix3x3_SetElement_28(HandleRef pThis, int i, int j, double value);

		public void SetElement(int i, int j, double value)
		{
			vtkMatrix3x3.vtkMatrix3x3_SetElement_28(base.GetCppThis(), i, j, value);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrix3x3_Transpose_29(HandleRef arg0, HandleRef arg1);

		public static void Transpose(vtkMatrix3x3 arg0, vtkMatrix3x3 arg1)
		{
			vtkMatrix3x3.vtkMatrix3x3_Transpose_29((arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrix3x3_Transpose_30(HandleRef pThis);

		public void Transpose()
		{
			vtkMatrix3x3.vtkMatrix3x3_Transpose_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrix3x3_Transpose_31(IntPtr inElements, IntPtr outElements);

		public static void Transpose(IntPtr inElements, IntPtr outElements)
		{
			vtkMatrix3x3.vtkMatrix3x3_Transpose_31(inElements, outElements);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrix3x3_Zero_32(HandleRef pThis);

		public void Zero()
		{
			vtkMatrix3x3.vtkMatrix3x3_Zero_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrix3x3_Zero_33(IntPtr Elements);

		public static void Zero(IntPtr Elements)
		{
			vtkMatrix3x3.vtkMatrix3x3_Zero_33(Elements);
		}
	}
}
