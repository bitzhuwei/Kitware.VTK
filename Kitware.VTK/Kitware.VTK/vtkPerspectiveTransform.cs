using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPerspectiveTransform : vtkHomogeneousTransform
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPerspectiveTransform";

		public new static readonly string MRClassNameKey;

		static vtkPerspectiveTransform()
		{
			vtkPerspectiveTransform.MRClassNameKey = "class vtkPerspectiveTransform";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPerspectiveTransform.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPerspectiveTransform"));
		}

		public vtkPerspectiveTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkPerspectiveTransform_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPerspectiveTransform New()
		{
			vtkPerspectiveTransform result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPerspectiveTransform.vtkPerspectiveTransform_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPerspectiveTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPerspectiveTransform() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPerspectiveTransform.vtkPerspectiveTransform_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPerspectiveTransform_AdjustViewport_01(HandleRef pThis, double oldXMin, double oldXMax, double oldYMin, double oldYMax, double newXMin, double newXMax, double newYMin, double newYMax);

		public void AdjustViewport(double oldXMin, double oldXMax, double oldYMin, double oldYMax, double newXMin, double newXMax, double newYMin, double newYMax)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_AdjustViewport_01(base.GetCppThis(), oldXMin, oldXMax, oldYMin, oldYMax, newXMin, newXMax, newYMin, newYMax);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPerspectiveTransform_AdjustZBuffer_02(HandleRef pThis, double oldNearZ, double oldFarZ, double newNearZ, double newFarZ);

		public void AdjustZBuffer(double oldNearZ, double oldFarZ, double newNearZ, double newFarZ)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_AdjustZBuffer_02(base.GetCppThis(), oldNearZ, oldFarZ, newNearZ, newFarZ);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkPerspectiveTransform_CircuitCheck_03(HandleRef pThis, HandleRef transform);

		public override int CircuitCheck(vtkAbstractTransform transform)
		{
			return vtkPerspectiveTransform.vtkPerspectiveTransform_CircuitCheck_03(base.GetCppThis(), (transform == null) ? default(HandleRef) : transform.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPerspectiveTransform_Concatenate_04(HandleRef pThis, HandleRef matrix);

		public void Concatenate(vtkMatrix4x4 matrix)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_Concatenate_04(base.GetCppThis(), (matrix == null) ? default(HandleRef) : matrix.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPerspectiveTransform_Concatenate_05(HandleRef pThis, IntPtr elements);

		public void Concatenate(IntPtr elements)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_Concatenate_05(base.GetCppThis(), elements);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPerspectiveTransform_Concatenate_06(HandleRef pThis, HandleRef transform);

		public void Concatenate(vtkHomogeneousTransform transform)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_Concatenate_06(base.GetCppThis(), (transform == null) ? default(HandleRef) : transform.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPerspectiveTransform_Frustum_07(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double znear, double zfar);

		public void Frustum(double xmin, double xmax, double ymin, double ymax, double znear, double zfar)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_Frustum_07(base.GetCppThis(), xmin, xmax, ymin, ymax, znear, zfar);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkPerspectiveTransform_GetConcatenatedTransform_08(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkHomogeneousTransform GetConcatenatedTransform(int i)
		{
			vtkHomogeneousTransform vtkHomogeneousTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPerspectiveTransform.vtkPerspectiveTransform_GetConcatenatedTransform_08(base.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHomogeneousTransform = (vtkHomogeneousTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHomogeneousTransform.Register(null);
				}
			}
			return vtkHomogeneousTransform;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkPerspectiveTransform_GetInput_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkHomogeneousTransform GetInput()
		{
			vtkHomogeneousTransform vtkHomogeneousTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPerspectiveTransform.vtkPerspectiveTransform_GetInput_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHomogeneousTransform = (vtkHomogeneousTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHomogeneousTransform.Register(null);
				}
			}
			return vtkHomogeneousTransform;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkPerspectiveTransform_GetInverseFlag_10(HandleRef pThis);

		public int GetInverseFlag()
		{
			return vtkPerspectiveTransform.vtkPerspectiveTransform_GetInverseFlag_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern uint vtkPerspectiveTransform_GetMTime_11(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkPerspectiveTransform.vtkPerspectiveTransform_GetMTime_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkPerspectiveTransform_GetNumberOfConcatenatedTransforms_12(HandleRef pThis);

		public int GetNumberOfConcatenatedTransforms()
		{
			return vtkPerspectiveTransform.vtkPerspectiveTransform_GetNumberOfConcatenatedTransforms_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPerspectiveTransform_Identity_13(HandleRef pThis);

		public void Identity()
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_Identity_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPerspectiveTransform_Inverse_14(HandleRef pThis);

		public override void Inverse()
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_Inverse_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkPerspectiveTransform_IsA_15(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPerspectiveTransform.vtkPerspectiveTransform_IsA_15(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkPerspectiveTransform_IsTypeOf_16(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPerspectiveTransform.vtkPerspectiveTransform_IsTypeOf_16(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkPerspectiveTransform_MakeTransform_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkAbstractTransform MakeTransform()
		{
			vtkAbstractTransform result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPerspectiveTransform.vtkPerspectiveTransform_MakeTransform_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkPerspectiveTransform_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPerspectiveTransform NewInstance()
		{
			vtkPerspectiveTransform result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPerspectiveTransform.vtkPerspectiveTransform_NewInstance_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPerspectiveTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPerspectiveTransform_Ortho_20(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double znear, double zfar);

		public void Ortho(double xmin, double xmax, double ymin, double ymax, double znear, double zfar)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_Ortho_20(base.GetCppThis(), xmin, xmax, ymin, ymax, znear, zfar);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPerspectiveTransform_Perspective_21(HandleRef pThis, double angle, double aspect, double znear, double zfar);

		public void Perspective(double angle, double aspect, double znear, double zfar)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_Perspective_21(base.GetCppThis(), angle, aspect, znear, zfar);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPerspectiveTransform_Pop_22(HandleRef pThis);

		public void Pop()
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_Pop_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPerspectiveTransform_PostMultiply_23(HandleRef pThis);

		public void PostMultiply()
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_PostMultiply_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPerspectiveTransform_PreMultiply_24(HandleRef pThis);

		public void PreMultiply()
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_PreMultiply_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPerspectiveTransform_Push_25(HandleRef pThis);

		public void Push()
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_Push_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPerspectiveTransform_RotateWXYZ_26(HandleRef pThis, double angle, double x, double y, double z);

		public void RotateWXYZ(double angle, double x, double y, double z)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_RotateWXYZ_26(base.GetCppThis(), angle, x, y, z);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPerspectiveTransform_RotateWXYZ_27(HandleRef pThis, double angle, IntPtr axis);

		public void RotateWXYZ(double angle, IntPtr axis)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_RotateWXYZ_27(base.GetCppThis(), angle, axis);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPerspectiveTransform_RotateX_28(HandleRef pThis, double angle);

		public void RotateX(double angle)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_RotateX_28(base.GetCppThis(), angle);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPerspectiveTransform_RotateY_29(HandleRef pThis, double angle);

		public void RotateY(double angle)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_RotateY_29(base.GetCppThis(), angle);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPerspectiveTransform_RotateZ_30(HandleRef pThis, double angle);

		public void RotateZ(double angle)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_RotateZ_30(base.GetCppThis(), angle);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkPerspectiveTransform_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPerspectiveTransform SafeDownCast(vtkObjectBase o)
		{
			vtkPerspectiveTransform vtkPerspectiveTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPerspectiveTransform.vtkPerspectiveTransform_SafeDownCast_31((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPerspectiveTransform = (vtkPerspectiveTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPerspectiveTransform.Register(null);
				}
			}
			return vtkPerspectiveTransform;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPerspectiveTransform_Scale_32(HandleRef pThis, double x, double y, double z);

		public void Scale(double x, double y, double z)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_Scale_32(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPerspectiveTransform_Scale_33(HandleRef pThis, IntPtr s);

		public void Scale(IntPtr s)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_Scale_33(base.GetCppThis(), s);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPerspectiveTransform_SetInput_34(HandleRef pThis, HandleRef input);

		public void SetInput(vtkHomogeneousTransform input)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_SetInput_34(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPerspectiveTransform_SetMatrix_35(HandleRef pThis, HandleRef matrix);

		public void SetMatrix(vtkMatrix4x4 matrix)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_SetMatrix_35(base.GetCppThis(), (matrix == null) ? default(HandleRef) : matrix.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPerspectiveTransform_SetMatrix_36(HandleRef pThis, IntPtr elements);

		public void SetMatrix(IntPtr elements)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_SetMatrix_36(base.GetCppThis(), elements);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPerspectiveTransform_SetupCamera_37(HandleRef pThis, IntPtr position, IntPtr focalpoint, IntPtr viewup);

		public void SetupCamera(IntPtr position, IntPtr focalpoint, IntPtr viewup)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_SetupCamera_37(base.GetCppThis(), position, focalpoint, viewup);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPerspectiveTransform_SetupCamera_38(HandleRef pThis, double p0, double p1, double p2, double fp0, double fp1, double fp2, double vup0, double vup1, double vup2);

		public void SetupCamera(double p0, double p1, double p2, double fp0, double fp1, double fp2, double vup0, double vup1, double vup2)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_SetupCamera_38(base.GetCppThis(), p0, p1, p2, fp0, fp1, fp2, vup0, vup1, vup2);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPerspectiveTransform_Shear_39(HandleRef pThis, double dxdz, double dydz, double zplane);

		public void Shear(double dxdz, double dydz, double zplane)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_Shear_39(base.GetCppThis(), dxdz, dydz, zplane);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPerspectiveTransform_Stereo_40(HandleRef pThis, double angle, double focaldistance);

		public void Stereo(double angle, double focaldistance)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_Stereo_40(base.GetCppThis(), angle, focaldistance);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPerspectiveTransform_Translate_41(HandleRef pThis, double x, double y, double z);

		public void Translate(double x, double y, double z)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_Translate_41(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkPerspectiveTransform_Translate_42(HandleRef pThis, IntPtr x);

		public void Translate(IntPtr x)
		{
			vtkPerspectiveTransform.vtkPerspectiveTransform_Translate_42(base.GetCppThis(), x);
		}
	}
}
