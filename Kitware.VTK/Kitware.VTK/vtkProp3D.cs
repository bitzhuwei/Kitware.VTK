using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkProp3D : vtkProp
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkProp3D";

		public new static readonly string MRClassNameKey;

		static vtkProp3D()
		{
			vtkProp3D.MRClassNameKey = "class vtkProp3D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProp3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProp3D"));
		}

		public vtkProp3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProp3D_AddOrientation_01(HandleRef pThis, double arg0, double arg1, double arg2);

		public void AddOrientation(double arg0, double arg1, double arg2)
		{
			vtkProp3D.vtkProp3D_AddOrientation_01(base.GetCppThis(), arg0, arg1, arg2);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProp3D_AddOrientation_02(HandleRef pThis, IntPtr a);

		public void AddOrientation(IntPtr a)
		{
			vtkProp3D.vtkProp3D_AddOrientation_02(base.GetCppThis(), a);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProp3D_AddPosition_03(HandleRef pThis, IntPtr deltaPosition);

		public void AddPosition(IntPtr deltaPosition)
		{
			vtkProp3D.vtkProp3D_AddPosition_03(base.GetCppThis(), deltaPosition);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProp3D_AddPosition_04(HandleRef pThis, double deltaX, double deltaY, double deltaZ);

		public void AddPosition(double deltaX, double deltaY, double deltaZ)
		{
			vtkProp3D.vtkProp3D_AddPosition_04(base.GetCppThis(), deltaX, deltaY, deltaZ);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProp3D_ComputeMatrix_05(HandleRef pThis);

		public virtual void ComputeMatrix()
		{
			vtkProp3D.vtkProp3D_ComputeMatrix_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProp3D_GetBounds_06(HandleRef pThis, IntPtr bounds);

		public void GetBounds(IntPtr bounds)
		{
			vtkProp3D.vtkProp3D_GetBounds_06(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkProp3D_GetBounds_07(HandleRef pThis);

		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkProp3D.vtkProp3D_GetBounds_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkProp3D_GetCenter_08(HandleRef pThis);

		public double[] GetCenter()
		{
			IntPtr intPtr = vtkProp3D.vtkProp3D_GetCenter_08(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkProp3D_GetIsIdentity_09(HandleRef pThis);

		public virtual int GetIsIdentity()
		{
			return vtkProp3D.vtkProp3D_GetIsIdentity_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkProp3D_GetLength_10(HandleRef pThis);

		public double GetLength()
		{
			return vtkProp3D.vtkProp3D_GetLength_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkProp3D_GetMTime_11(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkProp3D.vtkProp3D_GetMTime_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProp3D_GetMatrix_12(HandleRef pThis, HandleRef m);

		public virtual void GetMatrix(vtkMatrix4x4 m)
		{
			vtkProp3D.vtkProp3D_GetMatrix_12(base.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProp3D_GetMatrix_13(HandleRef pThis, IntPtr m);

		public virtual void GetMatrix(IntPtr m)
		{
			vtkProp3D.vtkProp3D_GetMatrix_13(base.GetCppThis(), m);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkProp3D_GetMatrix_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkMatrix4x4 GetMatrix()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProp3D.vtkProp3D_GetMatrix_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkProp3D_GetOrientation_15(HandleRef pThis);

		public double[] GetOrientation()
		{
			IntPtr intPtr = vtkProp3D.vtkProp3D_GetOrientation_15(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProp3D_GetOrientation_16(HandleRef pThis, IntPtr o);

		public void GetOrientation(IntPtr o)
		{
			vtkProp3D.vtkProp3D_GetOrientation_16(base.GetCppThis(), o);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkProp3D_GetOrientationWXYZ_17(HandleRef pThis);

		public double[] GetOrientationWXYZ()
		{
			IntPtr intPtr = vtkProp3D.vtkProp3D_GetOrientationWXYZ_17(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkProp3D_GetOrigin_18(HandleRef pThis);

		public virtual double[] GetOrigin()
		{
			IntPtr intPtr = vtkProp3D.vtkProp3D_GetOrigin_18(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProp3D_GetOrigin_19(HandleRef pThis, IntPtr data);

		public virtual void GetOrigin(IntPtr data)
		{
			vtkProp3D.vtkProp3D_GetOrigin_19(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkProp3D_GetPosition_20(HandleRef pThis);

		public virtual double[] GetPosition()
		{
			IntPtr intPtr = vtkProp3D.vtkProp3D_GetPosition_20(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProp3D_GetPosition_21(HandleRef pThis, IntPtr data);

		public virtual void GetPosition(IntPtr data)
		{
			vtkProp3D.vtkProp3D_GetPosition_21(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkProp3D_GetScale_22(HandleRef pThis);

		public virtual double[] GetScale()
		{
			IntPtr intPtr = vtkProp3D.vtkProp3D_GetScale_22(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProp3D_GetScale_23(HandleRef pThis, IntPtr data);

		public virtual void GetScale(IntPtr data)
		{
			vtkProp3D.vtkProp3D_GetScale_23(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkProp3D_GetUserMatrix_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkMatrix4x4 GetUserMatrix()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProp3D.vtkProp3D_GetUserMatrix_24(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkProp3D_GetUserTransform_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkLinearTransform GetUserTransform()
		{
			vtkLinearTransform vtkLinearTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProp3D.vtkProp3D_GetUserTransform_25(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkProp3D_GetUserTransformMatrixMTime_26(HandleRef pThis);

		public uint GetUserTransformMatrixMTime()
		{
			return vtkProp3D.vtkProp3D_GetUserTransformMatrixMTime_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkProp3D_GetXRange_27(HandleRef pThis);

		public double[] GetXRange()
		{
			IntPtr intPtr = vtkProp3D.vtkProp3D_GetXRange_27(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkProp3D_GetYRange_28(HandleRef pThis);

		public double[] GetYRange()
		{
			IntPtr intPtr = vtkProp3D.vtkProp3D_GetYRange_28(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkProp3D_GetZRange_29(HandleRef pThis);

		public double[] GetZRange()
		{
			IntPtr intPtr = vtkProp3D.vtkProp3D_GetZRange_29(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProp3D_InitPathTraversal_30(HandleRef pThis);

		public override void InitPathTraversal()
		{
			vtkProp3D.vtkProp3D_InitPathTraversal_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkProp3D_IsA_31(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkProp3D.vtkProp3D_IsA_31(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkProp3D_IsTypeOf_32(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkProp3D.vtkProp3D_IsTypeOf_32(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkProp3D_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkProp3D NewInstance()
		{
			vtkProp3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProp3D.vtkProp3D_NewInstance_33(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProp3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProp3D_PokeMatrix_34(HandleRef pThis, HandleRef matrix);

		public override void PokeMatrix(vtkMatrix4x4 matrix)
		{
			vtkProp3D.vtkProp3D_PokeMatrix_34(base.GetCppThis(), (matrix == null) ? default(HandleRef) : matrix.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProp3D_RotateWXYZ_35(HandleRef pThis, double arg0, double arg1, double arg2, double arg3);

		public void RotateWXYZ(double arg0, double arg1, double arg2, double arg3)
		{
			vtkProp3D.vtkProp3D_RotateWXYZ_35(base.GetCppThis(), arg0, arg1, arg2, arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProp3D_RotateX_36(HandleRef pThis, double arg0);

		public void RotateX(double arg0)
		{
			vtkProp3D.vtkProp3D_RotateX_36(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProp3D_RotateY_37(HandleRef pThis, double arg0);

		public void RotateY(double arg0)
		{
			vtkProp3D.vtkProp3D_RotateY_37(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProp3D_RotateZ_38(HandleRef pThis, double arg0);

		public void RotateZ(double arg0)
		{
			vtkProp3D.vtkProp3D_RotateZ_38(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkProp3D_SafeDownCast_39(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkProp3D SafeDownCast(vtkObjectBase o)
		{
			vtkProp3D vtkProp3D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProp3D.vtkProp3D_SafeDownCast_39((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProp3D = (vtkProp3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProp3D.Register(null);
				}
			}
			return vtkProp3D;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProp3D_SetOrientation_40(HandleRef pThis, double arg0, double arg1, double arg2);

		public void SetOrientation(double arg0, double arg1, double arg2)
		{
			vtkProp3D.vtkProp3D_SetOrientation_40(base.GetCppThis(), arg0, arg1, arg2);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProp3D_SetOrientation_41(HandleRef pThis, IntPtr a);

		public void SetOrientation(IntPtr a)
		{
			vtkProp3D.vtkProp3D_SetOrientation_41(base.GetCppThis(), a);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProp3D_SetOrigin_42(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkProp3D.vtkProp3D_SetOrigin_42(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProp3D_SetOrigin_43(HandleRef pThis, IntPtr _arg);

		public virtual void SetOrigin(IntPtr _arg)
		{
			vtkProp3D.vtkProp3D_SetOrigin_43(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProp3D_SetPosition_44(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetPosition(double _arg1, double _arg2, double _arg3)
		{
			vtkProp3D.vtkProp3D_SetPosition_44(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProp3D_SetPosition_45(HandleRef pThis, IntPtr _arg);

		public virtual void SetPosition(IntPtr _arg)
		{
			vtkProp3D.vtkProp3D_SetPosition_45(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProp3D_SetScale_46(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetScale(double _arg1, double _arg2, double _arg3)
		{
			vtkProp3D.vtkProp3D_SetScale_46(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProp3D_SetScale_47(HandleRef pThis, IntPtr _arg);

		public virtual void SetScale(IntPtr _arg)
		{
			vtkProp3D.vtkProp3D_SetScale_47(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProp3D_SetScale_48(HandleRef pThis, double s);

		public void SetScale(double s)
		{
			vtkProp3D.vtkProp3D_SetScale_48(base.GetCppThis(), s);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProp3D_SetUserMatrix_49(HandleRef pThis, HandleRef matrix);

		public void SetUserMatrix(vtkMatrix4x4 matrix)
		{
			vtkProp3D.vtkProp3D_SetUserMatrix_49(base.GetCppThis(), (matrix == null) ? default(HandleRef) : matrix.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProp3D_SetUserTransform_50(HandleRef pThis, HandleRef transform);

		public void SetUserTransform(vtkLinearTransform transform)
		{
			vtkProp3D.vtkProp3D_SetUserTransform_50(base.GetCppThis(), (transform == null) ? default(HandleRef) : transform.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkProp3D_ShallowCopy_51(HandleRef pThis, HandleRef prop);

		public override void ShallowCopy(vtkProp prop)
		{
			vtkProp3D.vtkProp3D_ShallowCopy_51(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}
	}
}
