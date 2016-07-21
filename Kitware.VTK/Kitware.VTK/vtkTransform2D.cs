using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTransform2D : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTransform2D";

		public new static readonly string MRClassNameKey;

		static vtkTransform2D()
		{
			vtkTransform2D.MRClassNameKey = "class vtkTransform2D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTransform2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTransform2D"));
		}

		public vtkTransform2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkTransform2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTransform2D New()
		{
			vtkTransform2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransform2D.vtkTransform2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransform2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTransform2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTransform2D.vtkTransform2D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTransform2D_GetInverse_01(HandleRef pThis, HandleRef inverse);

		public void GetInverse(vtkMatrix3x3 inverse)
		{
			vtkTransform2D.vtkTransform2D_GetInverse_01(base.GetCppThis(), (inverse == null) ? default(HandleRef) : inverse.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern uint vtkTransform2D_GetMTime_02(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkTransform2D.vtkTransform2D_GetMTime_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkTransform2D_GetMatrix_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMatrix3x3 GetMatrix()
		{
			vtkMatrix3x3 vtkMatrix3x = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransform2D.vtkTransform2D_GetMatrix_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkTransform2D_GetMatrix_04(HandleRef pThis, HandleRef matrix);

		public void GetMatrix(vtkMatrix3x3 matrix)
		{
			vtkTransform2D.vtkTransform2D_GetMatrix_04(base.GetCppThis(), (matrix == null) ? default(HandleRef) : matrix.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTransform2D_GetPosition_05(HandleRef pThis, IntPtr pos);

		public void GetPosition(IntPtr pos)
		{
			vtkTransform2D.vtkTransform2D_GetPosition_05(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTransform2D_GetTranspose_06(HandleRef pThis, HandleRef transpose);

		public void GetTranspose(vtkMatrix3x3 transpose)
		{
			vtkTransform2D.vtkTransform2D_GetTranspose_06(base.GetCppThis(), (transpose == null) ? default(HandleRef) : transpose.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTransform2D_Identity_07(HandleRef pThis);

		public void Identity()
		{
			vtkTransform2D.vtkTransform2D_Identity_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTransform2D_Inverse_08(HandleRef pThis);

		public void Inverse()
		{
			vtkTransform2D.vtkTransform2D_Inverse_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTransform2D_InverseTransformPoints_09(HandleRef pThis, IntPtr inPts, IntPtr outPts, int n);

		public void InverseTransformPoints(IntPtr inPts, IntPtr outPts, int n)
		{
			vtkTransform2D.vtkTransform2D_InverseTransformPoints_09(base.GetCppThis(), inPts, outPts, n);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTransform2D_InverseTransformPoints_10(HandleRef pThis, HandleRef inPts, HandleRef outPts);

		public void InverseTransformPoints(vtkPoints2D inPts, vtkPoints2D outPts)
		{
			vtkTransform2D.vtkTransform2D_InverseTransformPoints_10(base.GetCppThis(), (inPts == null) ? default(HandleRef) : inPts.GetCppThis(), (outPts == null) ? default(HandleRef) : outPts.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkTransform2D_IsA_11(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTransform2D.vtkTransform2D_IsA_11(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkTransform2D_IsTypeOf_12(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTransform2D.vtkTransform2D_IsTypeOf_12(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTransform2D_MultiplyPoint_13(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		public void MultiplyPoint(IntPtr arg0, IntPtr arg1)
		{
			vtkTransform2D.vtkTransform2D_MultiplyPoint_13(base.GetCppThis(), arg0, arg1);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkTransform2D_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTransform2D NewInstance()
		{
			vtkTransform2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransform2D.vtkTransform2D_NewInstance_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransform2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTransform2D_Rotate_16(HandleRef pThis, double angle);

		public void Rotate(double angle)
		{
			vtkTransform2D.vtkTransform2D_Rotate_16(base.GetCppThis(), angle);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkTransform2D_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTransform2D SafeDownCast(vtkObjectBase o)
		{
			vtkTransform2D vtkTransform2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTransform2D.vtkTransform2D_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransform2D = (vtkTransform2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransform2D.Register(null);
				}
			}
			return vtkTransform2D;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTransform2D_Scale_18(HandleRef pThis, double x, double y);

		public void Scale(double x, double y)
		{
			vtkTransform2D.vtkTransform2D_Scale_18(base.GetCppThis(), x, y);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTransform2D_Scale_19(HandleRef pThis, IntPtr s);

		public void Scale(IntPtr s)
		{
			vtkTransform2D.vtkTransform2D_Scale_19(base.GetCppThis(), s);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTransform2D_SetMatrix_20(HandleRef pThis, HandleRef matrix);

		public void SetMatrix(vtkMatrix3x3 matrix)
		{
			vtkTransform2D.vtkTransform2D_SetMatrix_20(base.GetCppThis(), (matrix == null) ? default(HandleRef) : matrix.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTransform2D_SetMatrix_21(HandleRef pThis, IntPtr elements);

		public void SetMatrix(IntPtr elements)
		{
			vtkTransform2D.vtkTransform2D_SetMatrix_21(base.GetCppThis(), elements);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTransform2D_TransformPoints_22(HandleRef pThis, IntPtr inPts, IntPtr outPts, int n);

		public void TransformPoints(IntPtr inPts, IntPtr outPts, int n)
		{
			vtkTransform2D.vtkTransform2D_TransformPoints_22(base.GetCppThis(), inPts, outPts, n);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTransform2D_TransformPoints_23(HandleRef pThis, HandleRef inPts, HandleRef outPts);

		public void TransformPoints(vtkPoints2D inPts, vtkPoints2D outPts)
		{
			vtkTransform2D.vtkTransform2D_TransformPoints_23(base.GetCppThis(), (inPts == null) ? default(HandleRef) : inPts.GetCppThis(), (outPts == null) ? default(HandleRef) : outPts.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTransform2D_Translate_24(HandleRef pThis, double x, double y);

		public void Translate(double x, double y)
		{
			vtkTransform2D.vtkTransform2D_Translate_24(base.GetCppThis(), x, y);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkTransform2D_Translate_25(HandleRef pThis, IntPtr x);

		public void Translate(IntPtr x)
		{
			vtkTransform2D.vtkTransform2D_Translate_25(base.GetCppThis(), x);
		}
	}
}
