using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTransform : vtkLinearTransform
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTransform";

		public new static readonly string MRClassNameKey;

		static vtkTransform()
		{
			vtkTransform.MRClassNameKey = "class vtkTransform";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTransform.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTransform"));
		}

		public vtkTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkTransform_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTransform New()
		{
			vtkTransform result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransform.vtkTransform_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTransform() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTransform.vtkTransform_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkTransform_CircuitCheck_01(HandleRef pThis, HandleRef transform);

		public override int CircuitCheck(vtkAbstractTransform transform)
		{
			return vtkTransform.vtkTransform_CircuitCheck_01(base.GetCppThis(), (transform == null) ? default(HandleRef) : transform.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTransform_Concatenate_02(HandleRef pThis, HandleRef matrix);

		public void Concatenate(vtkMatrix4x4 matrix)
		{
			vtkTransform.vtkTransform_Concatenate_02(base.GetCppThis(), (matrix == null) ? default(HandleRef) : matrix.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTransform_Concatenate_03(HandleRef pThis, IntPtr elements);

		public void Concatenate(IntPtr elements)
		{
			vtkTransform.vtkTransform_Concatenate_03(base.GetCppThis(), elements);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTransform_Concatenate_04(HandleRef pThis, HandleRef transform);

		public void Concatenate(vtkLinearTransform transform)
		{
			vtkTransform.vtkTransform_Concatenate_04(base.GetCppThis(), (transform == null) ? default(HandleRef) : transform.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkTransform_GetConcatenatedTransform_05(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkLinearTransform GetConcatenatedTransform(int i)
		{
			vtkLinearTransform vtkLinearTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransform.vtkTransform_GetConcatenatedTransform_05(base.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLinearTransform = (vtkLinearTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLinearTransform.Register(null);
				}
			}
			return vtkLinearTransform;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkTransform_GetInput_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkLinearTransform GetInput()
		{
			vtkLinearTransform vtkLinearTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransform.vtkTransform_GetInput_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLinearTransform = (vtkLinearTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLinearTransform.Register(null);
				}
			}
			return vtkLinearTransform;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTransform_GetInverse_07(HandleRef pThis, HandleRef inverse);

		public void GetInverse(vtkMatrix4x4 inverse)
		{
			vtkTransform.vtkTransform_GetInverse_07(base.GetCppThis(), (inverse == null) ? default(HandleRef) : inverse.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkTransform_GetInverse_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAbstractTransform GetInverse()
		{
			vtkAbstractTransform vtkAbstractTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransform.vtkTransform_GetInverse_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkTransform_GetInverseFlag_09(HandleRef pThis);

		public int GetInverseFlag()
		{
			return vtkTransform.vtkTransform_GetInverseFlag_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern uint vtkTransform_GetMTime_10(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkTransform.vtkTransform_GetMTime_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkTransform_GetNumberOfConcatenatedTransforms_11(HandleRef pThis);

		public int GetNumberOfConcatenatedTransforms()
		{
			return vtkTransform.vtkTransform_GetNumberOfConcatenatedTransforms_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTransform_GetOrientation_12(HandleRef pThis, IntPtr orient);

		public void GetOrientation(IntPtr orient)
		{
			vtkTransform.vtkTransform_GetOrientation_12(base.GetCppThis(), orient);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkTransform_GetOrientation_13(HandleRef pThis);

		public double[] GetOrientation()
		{
			IntPtr intPtr = vtkTransform.vtkTransform_GetOrientation_13(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTransform_GetOrientation_14(IntPtr orient, HandleRef matrix);

		public static void GetOrientation(IntPtr orient, vtkMatrix4x4 matrix)
		{
			vtkTransform.vtkTransform_GetOrientation_14(orient, (matrix == null) ? default(HandleRef) : matrix.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTransform_GetOrientationWXYZ_15(HandleRef pThis, IntPtr wxyz);

		public void GetOrientationWXYZ(IntPtr wxyz)
		{
			vtkTransform.vtkTransform_GetOrientationWXYZ_15(base.GetCppThis(), wxyz);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkTransform_GetOrientationWXYZ_16(HandleRef pThis);

		public double[] GetOrientationWXYZ()
		{
			IntPtr intPtr = vtkTransform.vtkTransform_GetOrientationWXYZ_16(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTransform_GetPosition_17(HandleRef pThis, IntPtr pos);

		public void GetPosition(IntPtr pos)
		{
			vtkTransform.vtkTransform_GetPosition_17(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkTransform_GetPosition_18(HandleRef pThis);

		public double[] GetPosition()
		{
			IntPtr intPtr = vtkTransform.vtkTransform_GetPosition_18(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTransform_GetScale_19(HandleRef pThis, IntPtr scale);

		public void GetScale(IntPtr scale)
		{
			vtkTransform.vtkTransform_GetScale_19(base.GetCppThis(), scale);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkTransform_GetScale_20(HandleRef pThis);

		public double[] GetScale()
		{
			IntPtr intPtr = vtkTransform.vtkTransform_GetScale_20(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTransform_GetTranspose_21(HandleRef pThis, HandleRef transpose);

		public void GetTranspose(vtkMatrix4x4 transpose)
		{
			vtkTransform.vtkTransform_GetTranspose_21(base.GetCppThis(), (transpose == null) ? default(HandleRef) : transpose.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTransform_Identity_22(HandleRef pThis);

		public void Identity()
		{
			vtkTransform.vtkTransform_Identity_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTransform_Inverse_23(HandleRef pThis);

		public override void Inverse()
		{
			vtkTransform.vtkTransform_Inverse_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkTransform_IsA_24(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTransform.vtkTransform_IsA_24(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkTransform_IsTypeOf_25(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTransform.vtkTransform_IsTypeOf_25(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkTransform_MakeTransform_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkAbstractTransform MakeTransform()
		{
			vtkAbstractTransform result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransform.vtkTransform_MakeTransform_26(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTransform_MultiplyPoint_27(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		public void MultiplyPoint(IntPtr arg0, IntPtr arg1)
		{
			vtkTransform.vtkTransform_MultiplyPoint_27(base.GetCppThis(), arg0, arg1);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkTransform_NewInstance_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTransform NewInstance()
		{
			vtkTransform result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransform.vtkTransform_NewInstance_29(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTransform_Pop_30(HandleRef pThis);

		public void Pop()
		{
			vtkTransform.vtkTransform_Pop_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTransform_PostMultiply_31(HandleRef pThis);

		public void PostMultiply()
		{
			vtkTransform.vtkTransform_PostMultiply_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTransform_PreMultiply_32(HandleRef pThis);

		public void PreMultiply()
		{
			vtkTransform.vtkTransform_PreMultiply_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTransform_Push_33(HandleRef pThis);

		public void Push()
		{
			vtkTransform.vtkTransform_Push_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTransform_RotateWXYZ_34(HandleRef pThis, double angle, double x, double y, double z);

		public void RotateWXYZ(double angle, double x, double y, double z)
		{
			vtkTransform.vtkTransform_RotateWXYZ_34(base.GetCppThis(), angle, x, y, z);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTransform_RotateWXYZ_35(HandleRef pThis, double angle, IntPtr axis);

		public void RotateWXYZ(double angle, IntPtr axis)
		{
			vtkTransform.vtkTransform_RotateWXYZ_35(base.GetCppThis(), angle, axis);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTransform_RotateX_36(HandleRef pThis, double angle);

		public void RotateX(double angle)
		{
			vtkTransform.vtkTransform_RotateX_36(base.GetCppThis(), angle);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTransform_RotateY_37(HandleRef pThis, double angle);

		public void RotateY(double angle)
		{
			vtkTransform.vtkTransform_RotateY_37(base.GetCppThis(), angle);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTransform_RotateZ_38(HandleRef pThis, double angle);

		public void RotateZ(double angle)
		{
			vtkTransform.vtkTransform_RotateZ_38(base.GetCppThis(), angle);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkTransform_SafeDownCast_39(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTransform SafeDownCast(vtkObjectBase o)
		{
			vtkTransform vtkTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransform.vtkTransform_SafeDownCast_39((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransform = (vtkTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransform.Register(null);
				}
			}
			return vtkTransform;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTransform_Scale_40(HandleRef pThis, double x, double y, double z);

		public void Scale(double x, double y, double z)
		{
			vtkTransform.vtkTransform_Scale_40(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTransform_Scale_41(HandleRef pThis, IntPtr s);

		public void Scale(IntPtr s)
		{
			vtkTransform.vtkTransform_Scale_41(base.GetCppThis(), s);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTransform_SetInput_42(HandleRef pThis, HandleRef input);

		public void SetInput(vtkLinearTransform input)
		{
			vtkTransform.vtkTransform_SetInput_42(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTransform_SetMatrix_43(HandleRef pThis, HandleRef matrix);

		public void SetMatrix(vtkMatrix4x4 matrix)
		{
			vtkTransform.vtkTransform_SetMatrix_43(base.GetCppThis(), (matrix == null) ? default(HandleRef) : matrix.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTransform_SetMatrix_44(HandleRef pThis, IntPtr elements);

		public void SetMatrix(IntPtr elements)
		{
			vtkTransform.vtkTransform_SetMatrix_44(base.GetCppThis(), elements);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTransform_Translate_45(HandleRef pThis, double x, double y, double z);

		public void Translate(double x, double y, double z)
		{
			vtkTransform.vtkTransform_Translate_45(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTransform_Translate_46(HandleRef pThis, IntPtr x);

		public void Translate(IntPtr x)
		{
			vtkTransform.vtkTransform_Translate_46(base.GetCppThis(), x);
		}
	}
}
