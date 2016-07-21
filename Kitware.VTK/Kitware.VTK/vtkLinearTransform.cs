using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkLinearTransform : vtkHomogeneousTransform
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkLinearTransform";

		public new static readonly string MRClassNameKey;

		static vtkLinearTransform()
		{
			vtkLinearTransform.MRClassNameKey = "class vtkLinearTransform";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLinearTransform.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLinearTransform"));
		}

		public vtkLinearTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkLinearTransform_GetLinearInverse_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkLinearTransform GetLinearInverse()
		{
			vtkLinearTransform vtkLinearTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLinearTransform.vtkLinearTransform_GetLinearInverse_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkLinearTransform_InternalTransformNormal_02(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		public virtual void InternalTransformNormal(IntPtr arg0, IntPtr arg1)
		{
			vtkLinearTransform.vtkLinearTransform_InternalTransformNormal_02(base.GetCppThis(), arg0, arg1);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLinearTransform_InternalTransformPoint_03(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		public override void InternalTransformPoint(IntPtr arg0, IntPtr arg1)
		{
			vtkLinearTransform.vtkLinearTransform_InternalTransformPoint_03(base.GetCppThis(), arg0, arg1);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLinearTransform_InternalTransformVector_04(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		public virtual void InternalTransformVector(IntPtr arg0, IntPtr arg1)
		{
			vtkLinearTransform.vtkLinearTransform_InternalTransformVector_04(base.GetCppThis(), arg0, arg1);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkLinearTransform_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkLinearTransform.vtkLinearTransform_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkLinearTransform_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkLinearTransform.vtkLinearTransform_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkLinearTransform_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkLinearTransform NewInstance()
		{
			vtkLinearTransform result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLinearTransform.vtkLinearTransform_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLinearTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkLinearTransform_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLinearTransform SafeDownCast(vtkObjectBase o)
		{
			vtkLinearTransform vtkLinearTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLinearTransform.vtkLinearTransform_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkLinearTransform_TransformDoubleNormal_09(HandleRef pThis, double x, double y, double z);

		public double[] TransformDoubleNormal(double x, double y, double z)
		{
			IntPtr intPtr = vtkLinearTransform.vtkLinearTransform_TransformDoubleNormal_09(base.GetCppThis(), x, y, z);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkLinearTransform_TransformDoubleNormal_10(HandleRef pThis, IntPtr normal);

		public double[] TransformDoubleNormal(IntPtr normal)
		{
			IntPtr intPtr = vtkLinearTransform.vtkLinearTransform_TransformDoubleNormal_10(base.GetCppThis(), normal);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkLinearTransform_TransformDoubleVector_11(HandleRef pThis, double x, double y, double z);

		public double[] TransformDoubleVector(double x, double y, double z)
		{
			IntPtr intPtr = vtkLinearTransform.vtkLinearTransform_TransformDoubleVector_11(base.GetCppThis(), x, y, z);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkLinearTransform_TransformDoubleVector_12(HandleRef pThis, IntPtr vec);

		public double[] TransformDoubleVector(IntPtr vec)
		{
			IntPtr intPtr = vtkLinearTransform.vtkLinearTransform_TransformDoubleVector_12(base.GetCppThis(), vec);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkLinearTransform_TransformFloatNormal_13(HandleRef pThis, float x, float y, float z);

		public float[] TransformFloatNormal(float x, float y, float z)
		{
			IntPtr intPtr = vtkLinearTransform.vtkLinearTransform_TransformFloatNormal_13(base.GetCppThis(), x, y, z);
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkLinearTransform_TransformFloatNormal_14(HandleRef pThis, IntPtr normal);

		public float[] TransformFloatNormal(IntPtr normal)
		{
			IntPtr intPtr = vtkLinearTransform.vtkLinearTransform_TransformFloatNormal_14(base.GetCppThis(), normal);
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkLinearTransform_TransformFloatVector_15(HandleRef pThis, float x, float y, float z);

		public float[] TransformFloatVector(float x, float y, float z)
		{
			IntPtr intPtr = vtkLinearTransform.vtkLinearTransform_TransformFloatVector_15(base.GetCppThis(), x, y, z);
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkLinearTransform_TransformFloatVector_16(HandleRef pThis, IntPtr vec);

		public float[] TransformFloatVector(IntPtr vec)
		{
			IntPtr intPtr = vtkLinearTransform.vtkLinearTransform_TransformFloatVector_16(base.GetCppThis(), vec);
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLinearTransform_TransformNormal_17(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		public void TransformNormal(IntPtr arg0, IntPtr arg1)
		{
			vtkLinearTransform.vtkLinearTransform_TransformNormal_17(base.GetCppThis(), arg0, arg1);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkLinearTransform_TransformNormal_18(HandleRef pThis, double x, double y, double z);

		public double[] TransformNormal(double x, double y, double z)
		{
			IntPtr intPtr = vtkLinearTransform.vtkLinearTransform_TransformNormal_18(base.GetCppThis(), x, y, z);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkLinearTransform_TransformNormal_19(HandleRef pThis, IntPtr normal);

		public double[] TransformNormal(IntPtr normal)
		{
			IntPtr intPtr = vtkLinearTransform.vtkLinearTransform_TransformNormal_19(base.GetCppThis(), normal);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLinearTransform_TransformNormals_20(HandleRef pThis, HandleRef inNms, HandleRef outNms);

		public virtual void TransformNormals(vtkDataArray inNms, vtkDataArray outNms)
		{
			vtkLinearTransform.vtkLinearTransform_TransformNormals_20(base.GetCppThis(), (inNms == null) ? default(HandleRef) : inNms.GetCppThis(), (outNms == null) ? default(HandleRef) : outNms.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLinearTransform_TransformPoints_21(HandleRef pThis, HandleRef inPts, HandleRef outPts);

		public override void TransformPoints(vtkPoints inPts, vtkPoints outPts)
		{
			vtkLinearTransform.vtkLinearTransform_TransformPoints_21(base.GetCppThis(), (inPts == null) ? default(HandleRef) : inPts.GetCppThis(), (outPts == null) ? default(HandleRef) : outPts.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLinearTransform_TransformPointsNormalsVectors_22(HandleRef pThis, HandleRef inPts, HandleRef outPts, HandleRef inNms, HandleRef outNms, HandleRef inVrs, HandleRef outVrs);

		public override void TransformPointsNormalsVectors(vtkPoints inPts, vtkPoints outPts, vtkDataArray inNms, vtkDataArray outNms, vtkDataArray inVrs, vtkDataArray outVrs)
		{
			vtkLinearTransform.vtkLinearTransform_TransformPointsNormalsVectors_22(base.GetCppThis(), (inPts == null) ? default(HandleRef) : inPts.GetCppThis(), (outPts == null) ? default(HandleRef) : outPts.GetCppThis(), (inNms == null) ? default(HandleRef) : inNms.GetCppThis(), (outNms == null) ? default(HandleRef) : outNms.GetCppThis(), (inVrs == null) ? default(HandleRef) : inVrs.GetCppThis(), (outVrs == null) ? default(HandleRef) : outVrs.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkLinearTransform_TransformVector_23(HandleRef pThis, double x, double y, double z);

		public double[] TransformVector(double x, double y, double z)
		{
			IntPtr intPtr = vtkLinearTransform.vtkLinearTransform_TransformVector_23(base.GetCppThis(), x, y, z);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkLinearTransform_TransformVector_24(HandleRef pThis, IntPtr normal);

		public double[] TransformVector(IntPtr normal)
		{
			IntPtr intPtr = vtkLinearTransform.vtkLinearTransform_TransformVector_24(base.GetCppThis(), normal);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLinearTransform_TransformVector_25(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		public void TransformVector(IntPtr arg0, IntPtr arg1)
		{
			vtkLinearTransform.vtkLinearTransform_TransformVector_25(base.GetCppThis(), arg0, arg1);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkLinearTransform_TransformVectors_26(HandleRef pThis, HandleRef inVrs, HandleRef outVrs);

		public virtual void TransformVectors(vtkDataArray inVrs, vtkDataArray outVrs)
		{
			vtkLinearTransform.vtkLinearTransform_TransformVectors_26(base.GetCppThis(), (inVrs == null) ? default(HandleRef) : inVrs.GetCppThis(), (outVrs == null) ? default(HandleRef) : outVrs.GetCppThis());
		}
	}
}
