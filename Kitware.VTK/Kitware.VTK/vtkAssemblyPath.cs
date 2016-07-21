using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkAssemblyPath : vtkCollection
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkAssemblyPath";

		public new static readonly string MRClassNameKey;

		static vtkAssemblyPath()
		{
			vtkAssemblyPath.MRClassNameKey = "class vtkAssemblyPath";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAssemblyPath.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAssemblyPath"));
		}

		public vtkAssemblyPath(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAssemblyPath_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAssemblyPath New()
		{
			vtkAssemblyPath result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAssemblyPath.vtkAssemblyPath_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAssemblyPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkAssemblyPath() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkAssemblyPath.vtkAssemblyPath_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAssemblyPath_AddNode_01(HandleRef pThis, HandleRef p, HandleRef m);

		public void AddNode(vtkProp p, vtkMatrix4x4 m)
		{
			vtkAssemblyPath.vtkAssemblyPath_AddNode_01(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAssemblyPath_DeleteLastNode_02(HandleRef pThis);

		public void DeleteLastNode()
		{
			vtkAssemblyPath.vtkAssemblyPath_DeleteLastNode_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAssemblyPath_GetFirstNode_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkAssemblyNode GetFirstNode()
		{
			vtkAssemblyNode vtkAssemblyNode = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAssemblyPath.vtkAssemblyPath_GetFirstNode_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkAssemblyPath_GetLastNode_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkAssemblyNode GetLastNode()
		{
			vtkAssemblyNode vtkAssemblyNode = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAssemblyPath.vtkAssemblyPath_GetLastNode_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern uint vtkAssemblyPath_GetMTime_05(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkAssemblyPath.vtkAssemblyPath_GetMTime_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAssemblyPath_GetNextNode_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkAssemblyNode GetNextNode()
		{
			vtkAssemblyNode vtkAssemblyNode = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAssemblyPath.vtkAssemblyPath_GetNextNode_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkAssemblyPath_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAssemblyPath.vtkAssemblyPath_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkAssemblyPath_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAssemblyPath.vtkAssemblyPath_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAssemblyPath_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAssemblyPath NewInstance()
		{
			vtkAssemblyPath result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAssemblyPath.vtkAssemblyPath_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAssemblyPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkAssemblyPath_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAssemblyPath SafeDownCast(vtkObjectBase o)
		{
			vtkAssemblyPath vtkAssemblyPath = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAssemblyPath.vtkAssemblyPath_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAssemblyPath = (vtkAssemblyPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAssemblyPath.Register(null);
				}
			}
			return vtkAssemblyPath;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkAssemblyPath_ShallowCopy_12(HandleRef pThis, HandleRef path);

		public void ShallowCopy(vtkAssemblyPath path)
		{
			vtkAssemblyPath.vtkAssemblyPath_ShallowCopy_12(base.GetCppThis(), (path == null) ? default(HandleRef) : path.GetCppThis());
		}
	}
}
