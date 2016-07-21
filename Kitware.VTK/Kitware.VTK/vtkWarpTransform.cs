using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkWarpTransform : vtkAbstractTransform
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkWarpTransform";

		public new static readonly string MRClassNameKey;

		static vtkWarpTransform()
		{
			vtkWarpTransform.MRClassNameKey = "class vtkWarpTransform";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWarpTransform.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWarpTransform"));
		}

		public vtkWarpTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkWarpTransform_GetInverseFlag_01(HandleRef pThis);

		public virtual int GetInverseFlag()
		{
			return vtkWarpTransform.vtkWarpTransform_GetInverseFlag_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkWarpTransform_GetInverseIterations_02(HandleRef pThis);

		public virtual int GetInverseIterations()
		{
			return vtkWarpTransform.vtkWarpTransform_GetInverseIterations_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern double vtkWarpTransform_GetInverseTolerance_03(HandleRef pThis);

		public virtual double GetInverseTolerance()
		{
			return vtkWarpTransform.vtkWarpTransform_GetInverseTolerance_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWarpTransform_InternalTransformPoint_04(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		public override void InternalTransformPoint(IntPtr arg0, IntPtr arg1)
		{
			vtkWarpTransform.vtkWarpTransform_InternalTransformPoint_04(base.GetCppThis(), arg0, arg1);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWarpTransform_Inverse_05(HandleRef pThis);

		public override void Inverse()
		{
			vtkWarpTransform.vtkWarpTransform_Inverse_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkWarpTransform_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkWarpTransform.vtkWarpTransform_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkWarpTransform_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkWarpTransform.vtkWarpTransform_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkWarpTransform_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkWarpTransform NewInstance()
		{
			vtkWarpTransform result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWarpTransform.vtkWarpTransform_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWarpTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkWarpTransform_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkWarpTransform SafeDownCast(vtkObjectBase o)
		{
			vtkWarpTransform vtkWarpTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWarpTransform.vtkWarpTransform_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWarpTransform = (vtkWarpTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWarpTransform.Register(null);
				}
			}
			return vtkWarpTransform;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWarpTransform_SetInverseIterations_10(HandleRef pThis, int _arg);

		public virtual void SetInverseIterations(int _arg)
		{
			vtkWarpTransform.vtkWarpTransform_SetInverseIterations_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWarpTransform_SetInverseTolerance_11(HandleRef pThis, double _arg);

		public virtual void SetInverseTolerance(double _arg)
		{
			vtkWarpTransform.vtkWarpTransform_SetInverseTolerance_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWarpTransform_TemplateTransformInverse_12(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		public void TemplateTransformInverse(IntPtr arg0, IntPtr arg1)
		{
			vtkWarpTransform.vtkWarpTransform_TemplateTransformInverse_12(base.GetCppThis(), arg0, arg1);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWarpTransform_TemplateTransformPoint_13(HandleRef pThis, IntPtr arg0, IntPtr arg1);

		public void TemplateTransformPoint(IntPtr arg0, IntPtr arg1)
		{
			vtkWarpTransform.vtkWarpTransform_TemplateTransformPoint_13(base.GetCppThis(), arg0, arg1);
		}
	}
}
