using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMatrixToHomogeneousTransform : vtkHomogeneousTransform
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMatrixToHomogeneousTransform";

		public new static readonly string MRClassNameKey;

		static vtkMatrixToHomogeneousTransform()
		{
			vtkMatrixToHomogeneousTransform.MRClassNameKey = "class vtkMatrixToHomogeneousTransform";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMatrixToHomogeneousTransform.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMatrixToHomogeneousTransform"));
		}

		public vtkMatrixToHomogeneousTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkMatrixToHomogeneousTransform_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMatrixToHomogeneousTransform New()
		{
			vtkMatrixToHomogeneousTransform result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMatrixToHomogeneousTransform.vtkMatrixToHomogeneousTransform_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMatrixToHomogeneousTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMatrixToHomogeneousTransform() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMatrixToHomogeneousTransform.vtkMatrixToHomogeneousTransform_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkMatrixToHomogeneousTransform_GetInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMatrix4x4 GetInput()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMatrixToHomogeneousTransform.vtkMatrixToHomogeneousTransform_GetInput_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern uint vtkMatrixToHomogeneousTransform_GetMTime_02(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkMatrixToHomogeneousTransform.vtkMatrixToHomogeneousTransform_GetMTime_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrixToHomogeneousTransform_Inverse_03(HandleRef pThis);

		public override void Inverse()
		{
			vtkMatrixToHomogeneousTransform.vtkMatrixToHomogeneousTransform_Inverse_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkMatrixToHomogeneousTransform_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMatrixToHomogeneousTransform.vtkMatrixToHomogeneousTransform_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkMatrixToHomogeneousTransform_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMatrixToHomogeneousTransform.vtkMatrixToHomogeneousTransform_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkMatrixToHomogeneousTransform_MakeTransform_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkAbstractTransform MakeTransform()
		{
			vtkAbstractTransform result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMatrixToHomogeneousTransform.vtkMatrixToHomogeneousTransform_MakeTransform_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkMatrixToHomogeneousTransform_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMatrixToHomogeneousTransform NewInstance()
		{
			vtkMatrixToHomogeneousTransform result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMatrixToHomogeneousTransform.vtkMatrixToHomogeneousTransform_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMatrixToHomogeneousTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkMatrixToHomogeneousTransform_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMatrixToHomogeneousTransform SafeDownCast(vtkObjectBase o)
		{
			vtkMatrixToHomogeneousTransform vtkMatrixToHomogeneousTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMatrixToHomogeneousTransform.vtkMatrixToHomogeneousTransform_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrixToHomogeneousTransform = (vtkMatrixToHomogeneousTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrixToHomogeneousTransform.Register(null);
				}
			}
			return vtkMatrixToHomogeneousTransform;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkMatrixToHomogeneousTransform_SetInput_10(HandleRef pThis, HandleRef arg0);

		public virtual void SetInput(vtkMatrix4x4 arg0)
		{
			vtkMatrixToHomogeneousTransform.vtkMatrixToHomogeneousTransform_SetInput_10(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
