using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMatrixToLinearTransform : vtkLinearTransform
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMatrixToLinearTransform";

		public new static readonly string MRClassNameKey;

		static vtkMatrixToLinearTransform()
		{
			vtkMatrixToLinearTransform.MRClassNameKey = "class vtkMatrixToLinearTransform";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMatrixToLinearTransform.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMatrixToLinearTransform"));
		}

		public vtkMatrixToLinearTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkMatrixToLinearTransform_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMatrixToLinearTransform New()
		{
			vtkMatrixToLinearTransform result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMatrixToLinearTransform.vtkMatrixToLinearTransform_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMatrixToLinearTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMatrixToLinearTransform() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMatrixToLinearTransform.vtkMatrixToLinearTransform_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkMatrixToLinearTransform_GetInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMatrix4x4 GetInput()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMatrixToLinearTransform.vtkMatrixToLinearTransform_GetInput_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern uint vtkMatrixToLinearTransform_GetMTime_02(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkMatrixToLinearTransform.vtkMatrixToLinearTransform_GetMTime_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrixToLinearTransform_Inverse_03(HandleRef pThis);

		public override void Inverse()
		{
			vtkMatrixToLinearTransform.vtkMatrixToLinearTransform_Inverse_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkMatrixToLinearTransform_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMatrixToLinearTransform.vtkMatrixToLinearTransform_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkMatrixToLinearTransform_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMatrixToLinearTransform.vtkMatrixToLinearTransform_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkMatrixToLinearTransform_MakeTransform_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkAbstractTransform MakeTransform()
		{
			vtkAbstractTransform result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMatrixToLinearTransform.vtkMatrixToLinearTransform_MakeTransform_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkMatrixToLinearTransform_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMatrixToLinearTransform NewInstance()
		{
			vtkMatrixToLinearTransform result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMatrixToLinearTransform.vtkMatrixToLinearTransform_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMatrixToLinearTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkMatrixToLinearTransform_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMatrixToLinearTransform SafeDownCast(vtkObjectBase o)
		{
			vtkMatrixToLinearTransform vtkMatrixToLinearTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMatrixToLinearTransform.vtkMatrixToLinearTransform_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrixToLinearTransform = (vtkMatrixToLinearTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrixToLinearTransform.Register(null);
				}
			}
			return vtkMatrixToLinearTransform;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrixToLinearTransform_SetInput_10(HandleRef pThis, HandleRef arg0);

		public virtual void SetInput(vtkMatrix4x4 arg0)
		{
			vtkMatrixToLinearTransform.vtkMatrixToLinearTransform_SetInput_10(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
