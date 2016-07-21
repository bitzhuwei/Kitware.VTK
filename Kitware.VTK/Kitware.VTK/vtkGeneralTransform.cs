using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGeneralTransform : vtkAbstractTransform
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGeneralTransform";

		public new static readonly string MRClassNameKey;

		static vtkGeneralTransform()
		{
			vtkGeneralTransform.MRClassNameKey = "class vtkGeneralTransform";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGeneralTransform.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGeneralTransform"));
		}

		public vtkGeneralTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkGeneralTransform_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeneralTransform New()
		{
			vtkGeneralTransform result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeneralTransform.vtkGeneralTransform_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeneralTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGeneralTransform() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGeneralTransform.vtkGeneralTransform_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkGeneralTransform_CircuitCheck_01(HandleRef pThis, HandleRef transform);

		public override int CircuitCheck(vtkAbstractTransform transform)
		{
			return vtkGeneralTransform.vtkGeneralTransform_CircuitCheck_01(base.GetCppThis(), (transform == null) ? default(HandleRef) : transform.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkGeneralTransform_Concatenate_02(HandleRef pThis, HandleRef matrix);

		public void Concatenate(vtkMatrix4x4 matrix)
		{
			vtkGeneralTransform.vtkGeneralTransform_Concatenate_02(base.GetCppThis(), (matrix == null) ? default(HandleRef) : matrix.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkGeneralTransform_Concatenate_03(HandleRef pThis, IntPtr elements);

		public void Concatenate(IntPtr elements)
		{
			vtkGeneralTransform.vtkGeneralTransform_Concatenate_03(base.GetCppThis(), elements);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkGeneralTransform_Concatenate_04(HandleRef pThis, HandleRef transform);

		public void Concatenate(vtkAbstractTransform transform)
		{
			vtkGeneralTransform.vtkGeneralTransform_Concatenate_04(base.GetCppThis(), (transform == null) ? default(HandleRef) : transform.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkGeneralTransform_GetConcatenatedTransform_05(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkAbstractTransform GetConcatenatedTransform(int i)
		{
			vtkAbstractTransform vtkAbstractTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeneralTransform.vtkGeneralTransform_GetConcatenatedTransform_05(base.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkGeneralTransform_GetInput_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkAbstractTransform GetInput()
		{
			vtkAbstractTransform vtkAbstractTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeneralTransform.vtkGeneralTransform_GetInput_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkGeneralTransform_GetInverseFlag_07(HandleRef pThis);

		public int GetInverseFlag()
		{
			return vtkGeneralTransform.vtkGeneralTransform_GetInverseFlag_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern uint vtkGeneralTransform_GetMTime_08(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkGeneralTransform.vtkGeneralTransform_GetMTime_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkGeneralTransform_GetNumberOfConcatenatedTransforms_09(HandleRef pThis);

		public int GetNumberOfConcatenatedTransforms()
		{
			return vtkGeneralTransform.vtkGeneralTransform_GetNumberOfConcatenatedTransforms_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkGeneralTransform_Identity_10(HandleRef pThis);

		public void Identity()
		{
			vtkGeneralTransform.vtkGeneralTransform_Identity_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkGeneralTransform_InternalTransformPoint_11(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		public override void InternalTransformPoint(IntPtr arg0, IntPtr arg1)
		{
			vtkGeneralTransform.vtkGeneralTransform_InternalTransformPoint_11(base.GetCppThis(), arg0, arg1);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkGeneralTransform_Inverse_12(HandleRef pThis);

		public override void Inverse()
		{
			vtkGeneralTransform.vtkGeneralTransform_Inverse_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkGeneralTransform_IsA_13(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGeneralTransform.vtkGeneralTransform_IsA_13(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkGeneralTransform_IsTypeOf_14(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGeneralTransform.vtkGeneralTransform_IsTypeOf_14(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkGeneralTransform_MakeTransform_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkAbstractTransform MakeTransform()
		{
			vtkAbstractTransform result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeneralTransform.vtkGeneralTransform_MakeTransform_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkGeneralTransform_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGeneralTransform NewInstance()
		{
			vtkGeneralTransform result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeneralTransform.vtkGeneralTransform_NewInstance_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeneralTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkGeneralTransform_Pop_18(HandleRef pThis);

		public void Pop()
		{
			vtkGeneralTransform.vtkGeneralTransform_Pop_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkGeneralTransform_PostMultiply_19(HandleRef pThis);

		public void PostMultiply()
		{
			vtkGeneralTransform.vtkGeneralTransform_PostMultiply_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkGeneralTransform_PreMultiply_20(HandleRef pThis);

		public void PreMultiply()
		{
			vtkGeneralTransform.vtkGeneralTransform_PreMultiply_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkGeneralTransform_Push_21(HandleRef pThis);

		public void Push()
		{
			vtkGeneralTransform.vtkGeneralTransform_Push_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkGeneralTransform_RotateWXYZ_22(HandleRef pThis, double angle, double x, double y, double z);

		public void RotateWXYZ(double angle, double x, double y, double z)
		{
			vtkGeneralTransform.vtkGeneralTransform_RotateWXYZ_22(base.GetCppThis(), angle, x, y, z);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkGeneralTransform_RotateWXYZ_23(HandleRef pThis, double angle, IntPtr axis);

		public void RotateWXYZ(double angle, IntPtr axis)
		{
			vtkGeneralTransform.vtkGeneralTransform_RotateWXYZ_23(base.GetCppThis(), angle, axis);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkGeneralTransform_RotateX_24(HandleRef pThis, double angle);

		public void RotateX(double angle)
		{
			vtkGeneralTransform.vtkGeneralTransform_RotateX_24(base.GetCppThis(), angle);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkGeneralTransform_RotateY_25(HandleRef pThis, double angle);

		public void RotateY(double angle)
		{
			vtkGeneralTransform.vtkGeneralTransform_RotateY_25(base.GetCppThis(), angle);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkGeneralTransform_RotateZ_26(HandleRef pThis, double angle);

		public void RotateZ(double angle)
		{
			vtkGeneralTransform.vtkGeneralTransform_RotateZ_26(base.GetCppThis(), angle);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkGeneralTransform_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeneralTransform SafeDownCast(vtkObjectBase o)
		{
			vtkGeneralTransform vtkGeneralTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeneralTransform.vtkGeneralTransform_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeneralTransform = (vtkGeneralTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeneralTransform.Register(null);
				}
			}
			return vtkGeneralTransform;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkGeneralTransform_Scale_28(HandleRef pThis, double x, double y, double z);

		public void Scale(double x, double y, double z)
		{
			vtkGeneralTransform.vtkGeneralTransform_Scale_28(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkGeneralTransform_Scale_29(HandleRef pThis, IntPtr s);

		public void Scale(IntPtr s)
		{
			vtkGeneralTransform.vtkGeneralTransform_Scale_29(base.GetCppThis(), s);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkGeneralTransform_SetInput_30(HandleRef pThis, HandleRef input);

		public void SetInput(vtkAbstractTransform input)
		{
			vtkGeneralTransform.vtkGeneralTransform_SetInput_30(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkGeneralTransform_Translate_31(HandleRef pThis, double x, double y, double z);

		public void Translate(double x, double y, double z)
		{
			vtkGeneralTransform.vtkGeneralTransform_Translate_31(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkGeneralTransform_Translate_32(HandleRef pThis, IntPtr x);

		public void Translate(IntPtr x)
		{
			vtkGeneralTransform.vtkGeneralTransform_Translate_32(base.GetCppThis(), x);
		}
	}
}
