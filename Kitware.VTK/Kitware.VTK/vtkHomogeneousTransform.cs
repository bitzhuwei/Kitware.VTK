using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkHomogeneousTransform : vtkAbstractTransform
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkHomogeneousTransform";

		public new static readonly string MRClassNameKey;

		static vtkHomogeneousTransform()
		{
			vtkHomogeneousTransform.MRClassNameKey = "class vtkHomogeneousTransform";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHomogeneousTransform.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHomogeneousTransform"));
		}

		public vtkHomogeneousTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkHomogeneousTransform_GetHomogeneousInverse_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkHomogeneousTransform GetHomogeneousInverse()
		{
			vtkHomogeneousTransform vtkHomogeneousTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHomogeneousTransform.vtkHomogeneousTransform_GetHomogeneousInverse_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkHomogeneousTransform_GetMatrix_02(HandleRef pThis, HandleRef m);

		public void GetMatrix(vtkMatrix4x4 m)
		{
			vtkHomogeneousTransform.vtkHomogeneousTransform_GetMatrix_02(base.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkHomogeneousTransform_GetMatrix_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkMatrix4x4 GetMatrix()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHomogeneousTransform.vtkHomogeneousTransform_GetMatrix_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkHomogeneousTransform_InternalTransformPoint_04(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		public override void InternalTransformPoint(IntPtr arg0, IntPtr arg1)
		{
			vtkHomogeneousTransform.vtkHomogeneousTransform_InternalTransformPoint_04(base.GetCppThis(), arg0, arg1);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkHomogeneousTransform_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkHomogeneousTransform.vtkHomogeneousTransform_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkHomogeneousTransform_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkHomogeneousTransform.vtkHomogeneousTransform_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkHomogeneousTransform_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkHomogeneousTransform NewInstance()
		{
			vtkHomogeneousTransform result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHomogeneousTransform.vtkHomogeneousTransform_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHomogeneousTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkHomogeneousTransform_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHomogeneousTransform SafeDownCast(vtkObjectBase o)
		{
			vtkHomogeneousTransform vtkHomogeneousTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHomogeneousTransform.vtkHomogeneousTransform_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkHomogeneousTransform_TransformPoints_09(HandleRef pThis, HandleRef inPts, HandleRef outPts);

		public override void TransformPoints(vtkPoints inPts, vtkPoints outPts)
		{
			vtkHomogeneousTransform.vtkHomogeneousTransform_TransformPoints_09(base.GetCppThis(), (inPts == null) ? default(HandleRef) : inPts.GetCppThis(), (outPts == null) ? default(HandleRef) : outPts.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkHomogeneousTransform_TransformPointsNormalsVectors_10(HandleRef pThis, HandleRef inPts, HandleRef outPts, HandleRef inNms, HandleRef outNms, HandleRef inVrs, HandleRef outVrs);

		public override void TransformPointsNormalsVectors(vtkPoints inPts, vtkPoints outPts, vtkDataArray inNms, vtkDataArray outNms, vtkDataArray inVrs, vtkDataArray outVrs)
		{
			vtkHomogeneousTransform.vtkHomogeneousTransform_TransformPointsNormalsVectors_10(base.GetCppThis(), (inPts == null) ? default(HandleRef) : inPts.GetCppThis(), (outPts == null) ? default(HandleRef) : outPts.GetCppThis(), (inNms == null) ? default(HandleRef) : inNms.GetCppThis(), (outNms == null) ? default(HandleRef) : outNms.GetCppThis(), (inVrs == null) ? default(HandleRef) : inVrs.GetCppThis(), (outVrs == null) ? default(HandleRef) : outVrs.GetCppThis());
		}
	}
}
