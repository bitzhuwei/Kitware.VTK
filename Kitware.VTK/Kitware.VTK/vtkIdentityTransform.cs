using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkIdentityTransform : vtkLinearTransform
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkIdentityTransform";

		public new static readonly string MRClassNameKey;

		static vtkIdentityTransform()
		{
			vtkIdentityTransform.MRClassNameKey = "class vtkIdentityTransform";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkIdentityTransform.MRClassNameKey, Type.GetType("Kitware.VTK.vtkIdentityTransform"));
		}

		public vtkIdentityTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkIdentityTransform_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkIdentityTransform New()
		{
			vtkIdentityTransform result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkIdentityTransform.vtkIdentityTransform_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIdentityTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkIdentityTransform() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkIdentityTransform.vtkIdentityTransform_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkIdentityTransform_InternalTransformNormal_01(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		public override void InternalTransformNormal(IntPtr arg0, IntPtr arg1)
		{
			vtkIdentityTransform.vtkIdentityTransform_InternalTransformNormal_01(base.GetCppThis(), arg0, arg1);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkIdentityTransform_InternalTransformPoint_02(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		public override void InternalTransformPoint(IntPtr arg0, IntPtr arg1)
		{
			vtkIdentityTransform.vtkIdentityTransform_InternalTransformPoint_02(base.GetCppThis(), arg0, arg1);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkIdentityTransform_InternalTransformVector_03(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		public override void InternalTransformVector(IntPtr arg0, IntPtr arg1)
		{
			vtkIdentityTransform.vtkIdentityTransform_InternalTransformVector_03(base.GetCppThis(), arg0, arg1);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkIdentityTransform_Inverse_04(HandleRef pThis);

		public override void Inverse()
		{
			vtkIdentityTransform.vtkIdentityTransform_Inverse_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkIdentityTransform_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkIdentityTransform.vtkIdentityTransform_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkIdentityTransform_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkIdentityTransform.vtkIdentityTransform_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkIdentityTransform_MakeTransform_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkAbstractTransform MakeTransform()
		{
			vtkAbstractTransform result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkIdentityTransform.vtkIdentityTransform_MakeTransform_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkIdentityTransform_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkIdentityTransform NewInstance()
		{
			vtkIdentityTransform result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkIdentityTransform.vtkIdentityTransform_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIdentityTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkIdentityTransform_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkIdentityTransform SafeDownCast(vtkObjectBase o)
		{
			vtkIdentityTransform vtkIdentityTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkIdentityTransform.vtkIdentityTransform_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdentityTransform = (vtkIdentityTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdentityTransform.Register(null);
				}
			}
			return vtkIdentityTransform;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkIdentityTransform_TransformNormals_11(HandleRef pThis, HandleRef inNms, HandleRef outNms);

		public override void TransformNormals(vtkDataArray inNms, vtkDataArray outNms)
		{
			vtkIdentityTransform.vtkIdentityTransform_TransformNormals_11(base.GetCppThis(), (inNms == null) ? default(HandleRef) : inNms.GetCppThis(), (outNms == null) ? default(HandleRef) : outNms.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkIdentityTransform_TransformPoints_12(HandleRef pThis, HandleRef inPts, HandleRef outPts);

		public override void TransformPoints(vtkPoints inPts, vtkPoints outPts)
		{
			vtkIdentityTransform.vtkIdentityTransform_TransformPoints_12(base.GetCppThis(), (inPts == null) ? default(HandleRef) : inPts.GetCppThis(), (outPts == null) ? default(HandleRef) : outPts.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkIdentityTransform_TransformPointsNormalsVectors_13(HandleRef pThis, HandleRef inPts, HandleRef outPts, HandleRef inNms, HandleRef outNms, HandleRef inVrs, HandleRef outVrs);

		public override void TransformPointsNormalsVectors(vtkPoints inPts, vtkPoints outPts, vtkDataArray inNms, vtkDataArray outNms, vtkDataArray inVrs, vtkDataArray outVrs)
		{
			vtkIdentityTransform.vtkIdentityTransform_TransformPointsNormalsVectors_13(base.GetCppThis(), (inPts == null) ? default(HandleRef) : inPts.GetCppThis(), (outPts == null) ? default(HandleRef) : outPts.GetCppThis(), (inNms == null) ? default(HandleRef) : inNms.GetCppThis(), (outNms == null) ? default(HandleRef) : outNms.GetCppThis(), (inVrs == null) ? default(HandleRef) : inVrs.GetCppThis(), (outVrs == null) ? default(HandleRef) : outVrs.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkIdentityTransform_TransformVectors_14(HandleRef pThis, HandleRef inVrs, HandleRef outVrs);

		public override void TransformVectors(vtkDataArray inVrs, vtkDataArray outVrs)
		{
			vtkIdentityTransform.vtkIdentityTransform_TransformVectors_14(base.GetCppThis(), (inVrs == null) ? default(HandleRef) : inVrs.GetCppThis(), (outVrs == null) ? default(HandleRef) : outVrs.GetCppThis());
		}
	}
}
