using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkAbstractTransform : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractTransform";

		public new static readonly string MRClassNameKey;

		static vtkAbstractTransform()
		{
			vtkAbstractTransform.MRClassNameKey = "class vtkAbstractTransform";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAbstractTransform.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractTransform"));
		}

		public vtkAbstractTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAbstractTransform_UnRegister_30(HandleRef pThis, HandleRef O);

		protected override void Dispose(bool disposing)
		{
			try
			{
				if (base.GetCallDisposalMethod())
				{
					vtkAbstractTransform.vtkAbstractTransform_UnRegister_30(base.GetCppThis(), default(HandleRef));
					base.ClearCppThis();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkAbstractTransform_CircuitCheck_01(HandleRef pThis, HandleRef transform);

		public virtual int CircuitCheck(vtkAbstractTransform transform)
		{
			return vtkAbstractTransform.vtkAbstractTransform_CircuitCheck_01(base.GetCppThis(), (transform == null) ? default(HandleRef) : transform.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAbstractTransform_DeepCopy_02(HandleRef pThis, HandleRef arg0);

		public void DeepCopy(vtkAbstractTransform arg0)
		{
			vtkAbstractTransform.vtkAbstractTransform_DeepCopy_02(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractTransform_GetInverse_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkAbstractTransform GetInverse()
		{
			vtkAbstractTransform vtkAbstractTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractTransform.vtkAbstractTransform_GetInverse_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern uint vtkAbstractTransform_GetMTime_04(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkAbstractTransform.vtkAbstractTransform_GetMTime_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAbstractTransform_InternalTransformPoint_05(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		public virtual void InternalTransformPoint(IntPtr arg0, IntPtr arg1)
		{
			vtkAbstractTransform.vtkAbstractTransform_InternalTransformPoint_05(base.GetCppThis(), arg0, arg1);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAbstractTransform_Inverse_06(HandleRef pThis);

		public virtual void Inverse()
		{
			vtkAbstractTransform.vtkAbstractTransform_Inverse_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkAbstractTransform_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAbstractTransform.vtkAbstractTransform_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkAbstractTransform_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAbstractTransform.vtkAbstractTransform_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractTransform_MakeTransform_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAbstractTransform MakeTransform()
		{
			vtkAbstractTransform result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractTransform.vtkAbstractTransform_MakeTransform_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractTransform_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAbstractTransform NewInstance()
		{
			vtkAbstractTransform result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractTransform.vtkAbstractTransform_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractTransform_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAbstractTransform SafeDownCast(vtkObjectBase o)
		{
			vtkAbstractTransform vtkAbstractTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractTransform.vtkAbstractTransform_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkAbstractTransform_SetInverse_12(HandleRef pThis, HandleRef transform);

		public void SetInverse(vtkAbstractTransform transform)
		{
			vtkAbstractTransform.vtkAbstractTransform_SetInverse_12(base.GetCppThis(), (transform == null) ? default(HandleRef) : transform.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractTransform_TransformDoubleNormalAtPoint_13(HandleRef pThis, IntPtr point, IntPtr normal);

		public double[] TransformDoubleNormalAtPoint(IntPtr point, IntPtr normal)
		{
			IntPtr intPtr = vtkAbstractTransform.vtkAbstractTransform_TransformDoubleNormalAtPoint_13(base.GetCppThis(), point, normal);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractTransform_TransformDoublePoint_14(HandleRef pThis, double x, double y, double z);

		public double[] TransformDoublePoint(double x, double y, double z)
		{
			IntPtr intPtr = vtkAbstractTransform.vtkAbstractTransform_TransformDoublePoint_14(base.GetCppThis(), x, y, z);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractTransform_TransformDoublePoint_15(HandleRef pThis, IntPtr point);

		public double[] TransformDoublePoint(IntPtr point)
		{
			IntPtr intPtr = vtkAbstractTransform.vtkAbstractTransform_TransformDoublePoint_15(base.GetCppThis(), point);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractTransform_TransformDoubleVectorAtPoint_16(HandleRef pThis, IntPtr point, IntPtr vector);

		public double[] TransformDoubleVectorAtPoint(IntPtr point, IntPtr vector)
		{
			IntPtr intPtr = vtkAbstractTransform.vtkAbstractTransform_TransformDoubleVectorAtPoint_16(base.GetCppThis(), point, vector);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractTransform_TransformFloatNormalAtPoint_17(HandleRef pThis, IntPtr point, IntPtr normal);

		public float[] TransformFloatNormalAtPoint(IntPtr point, IntPtr normal)
		{
			IntPtr intPtr = vtkAbstractTransform.vtkAbstractTransform_TransformFloatNormalAtPoint_17(base.GetCppThis(), point, normal);
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractTransform_TransformFloatPoint_18(HandleRef pThis, float x, float y, float z);

		public float[] TransformFloatPoint(float x, float y, float z)
		{
			IntPtr intPtr = vtkAbstractTransform.vtkAbstractTransform_TransformFloatPoint_18(base.GetCppThis(), x, y, z);
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractTransform_TransformFloatPoint_19(HandleRef pThis, IntPtr point);

		public float[] TransformFloatPoint(IntPtr point)
		{
			IntPtr intPtr = vtkAbstractTransform.vtkAbstractTransform_TransformFloatPoint_19(base.GetCppThis(), point);
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractTransform_TransformFloatVectorAtPoint_20(HandleRef pThis, IntPtr point, IntPtr vector);

		public float[] TransformFloatVectorAtPoint(IntPtr point, IntPtr vector)
		{
			IntPtr intPtr = vtkAbstractTransform.vtkAbstractTransform_TransformFloatVectorAtPoint_20(base.GetCppThis(), point, vector);
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAbstractTransform_TransformNormalAtPoint_21(HandleRef pThis, IntPtr point, IntPtr arg1, IntPtr arg2);

		public void TransformNormalAtPoint(IntPtr point, IntPtr arg1, IntPtr arg2)
		{
			vtkAbstractTransform.vtkAbstractTransform_TransformNormalAtPoint_21(base.GetCppThis(), point, arg1, arg2);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractTransform_TransformNormalAtPoint_22(HandleRef pThis, IntPtr point, IntPtr normal);

		public double[] TransformNormalAtPoint(IntPtr point, IntPtr normal)
		{
			IntPtr intPtr = vtkAbstractTransform.vtkAbstractTransform_TransformNormalAtPoint_22(base.GetCppThis(), point, normal);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAbstractTransform_TransformPoint_23(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		public void TransformPoint(IntPtr arg0, IntPtr arg1)
		{
			vtkAbstractTransform.vtkAbstractTransform_TransformPoint_23(base.GetCppThis(), arg0, arg1);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractTransform_TransformPoint_24(HandleRef pThis, double x, double y, double z);

		public double[] TransformPoint(double x, double y, double z)
		{
			IntPtr intPtr = vtkAbstractTransform.vtkAbstractTransform_TransformPoint_24(base.GetCppThis(), x, y, z);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractTransform_TransformPoint_25(HandleRef pThis, IntPtr point);

		public double[] TransformPoint(IntPtr point)
		{
			IntPtr intPtr = vtkAbstractTransform.vtkAbstractTransform_TransformPoint_25(base.GetCppThis(), point);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAbstractTransform_TransformPoints_26(HandleRef pThis, HandleRef inPts, HandleRef outPts);

		public virtual void TransformPoints(vtkPoints inPts, vtkPoints outPts)
		{
			vtkAbstractTransform.vtkAbstractTransform_TransformPoints_26(base.GetCppThis(), (inPts == null) ? default(HandleRef) : inPts.GetCppThis(), (outPts == null) ? default(HandleRef) : outPts.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAbstractTransform_TransformPointsNormalsVectors_27(HandleRef pThis, HandleRef inPts, HandleRef outPts, HandleRef inNms, HandleRef outNms, HandleRef inVrs, HandleRef outVrs);

		public virtual void TransformPointsNormalsVectors(vtkPoints inPts, vtkPoints outPts, vtkDataArray inNms, vtkDataArray outNms, vtkDataArray inVrs, vtkDataArray outVrs)
		{
			vtkAbstractTransform.vtkAbstractTransform_TransformPointsNormalsVectors_27(base.GetCppThis(), (inPts == null) ? default(HandleRef) : inPts.GetCppThis(), (outPts == null) ? default(HandleRef) : outPts.GetCppThis(), (inNms == null) ? default(HandleRef) : inNms.GetCppThis(), (outNms == null) ? default(HandleRef) : outNms.GetCppThis(), (inVrs == null) ? default(HandleRef) : inVrs.GetCppThis(), (outVrs == null) ? default(HandleRef) : outVrs.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAbstractTransform_TransformVectorAtPoint_28(HandleRef pThis, IntPtr point, IntPtr arg1, IntPtr arg2);

		public void TransformVectorAtPoint(IntPtr point, IntPtr arg1, IntPtr arg2)
		{
			vtkAbstractTransform.vtkAbstractTransform_TransformVectorAtPoint_28(base.GetCppThis(), point, arg1, arg2);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractTransform_TransformVectorAtPoint_29(HandleRef pThis, IntPtr point, IntPtr vector);

		public double[] TransformVectorAtPoint(IntPtr point, IntPtr vector)
		{
			IntPtr intPtr = vtkAbstractTransform.vtkAbstractTransform_TransformVectorAtPoint_29(base.GetCppThis(), point, vector);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAbstractTransform_Update_31(HandleRef pThis);

		public void Update()
		{
			vtkAbstractTransform.vtkAbstractTransform_Update_31(base.GetCppThis());
		}
	}
}
