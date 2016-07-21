using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkAssemblyNode : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkAssemblyNode";

		public new static readonly string MRClassNameKey;

		static vtkAssemblyNode()
		{
			vtkAssemblyNode.MRClassNameKey = "class vtkAssemblyNode";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAssemblyNode.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAssemblyNode"));
		}

		public vtkAssemblyNode(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAssemblyNode_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAssemblyNode New()
		{
			vtkAssemblyNode result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAssemblyNode.vtkAssemblyNode_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAssemblyNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkAssemblyNode() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkAssemblyNode.vtkAssemblyNode_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern uint vtkAssemblyNode_GetMTime_01(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkAssemblyNode.vtkAssemblyNode_GetMTime_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAssemblyNode_GetMatrix_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMatrix4x4 GetMatrix()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAssemblyNode.vtkAssemblyNode_GetMatrix_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkAssemblyNode_GetViewProp_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProp GetViewProp()
		{
			vtkProp vtkProp = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAssemblyNode.vtkAssemblyNode_GetViewProp_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProp = (vtkProp)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProp.Register(null);
				}
			}
			return vtkProp;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkAssemblyNode_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAssemblyNode.vtkAssemblyNode_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkAssemblyNode_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAssemblyNode.vtkAssemblyNode_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAssemblyNode_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAssemblyNode NewInstance()
		{
			vtkAssemblyNode result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAssemblyNode.vtkAssemblyNode_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAssemblyNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAssemblyNode_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAssemblyNode SafeDownCast(vtkObjectBase o)
		{
			vtkAssemblyNode vtkAssemblyNode = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAssemblyNode.vtkAssemblyNode_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAssemblyNode = (vtkAssemblyNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAssemblyNode.Register(null);
				}
			}
			return vtkAssemblyNode;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAssemblyNode_SetMatrix_09(HandleRef pThis, HandleRef matrix);

		public void SetMatrix(vtkMatrix4x4 matrix)
		{
			vtkAssemblyNode.vtkAssemblyNode_SetMatrix_09(base.GetCppThis(), (matrix == null) ? default(HandleRef) : matrix.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAssemblyNode_SetViewProp_10(HandleRef pThis, HandleRef prop);

		public virtual void SetViewProp(vtkProp prop)
		{
			vtkAssemblyNode.vtkAssemblyNode_SetViewProp_10(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}
	}
}
