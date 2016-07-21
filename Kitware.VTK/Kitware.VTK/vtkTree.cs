using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTree : vtkDirectedAcyclicGraph
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTree";

		public new static readonly string MRClassNameKey;

		static vtkTree()
		{
			vtkTree.MRClassNameKey = "class vtkTree";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTree.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTree"));
		}

		public vtkTree(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkTree_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTree New()
		{
			vtkTree result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTree.vtkTree_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTree() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTree.vtkTree_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkTree_GetChild_01(HandleRef pThis, long v, long i);

		public long GetChild(long v, long i)
		{
			return vtkTree.vtkTree_GetChild_01(base.GetCppThis(), v, i);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkTree_GetChildren_02(HandleRef pThis, long v, HandleRef it);

		public void GetChildren(long v, vtkAdjacentVertexIterator it)
		{
			vtkTree.vtkTree_GetChildren_02(base.GetCppThis(), v, (it == null) ? default(HandleRef) : it.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkTree_GetData_03(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTree GetData(vtkInformation info)
		{
			vtkTree vtkTree = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTree.vtkTree_GetData_03((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTree = (vtkTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTree.Register(null);
				}
			}
			return vtkTree;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkTree_GetData_04(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTree GetData(vtkInformationVector v, int i)
		{
			vtkTree vtkTree = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTree.vtkTree_GetData_04((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTree = (vtkTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTree.Register(null);
				}
			}
			return vtkTree;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkTree_GetDataObjectType_05(HandleRef pThis);

		public override int GetDataObjectType()
		{
			return vtkTree.vtkTree_GetDataObjectType_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkTree_GetLevel_06(HandleRef pThis, long v);

		public long GetLevel(long v)
		{
			return vtkTree.vtkTree_GetLevel_06(base.GetCppThis(), v);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkTree_GetNumberOfChildren_07(HandleRef pThis, long v);

		public long GetNumberOfChildren(long v)
		{
			return vtkTree.vtkTree_GetNumberOfChildren_07(base.GetCppThis(), v);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkTree_GetParent_08(HandleRef pThis, long v);

		public long GetParent(long v)
		{
			return vtkTree.vtkTree_GetParent_08(base.GetCppThis(), v);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkTree_GetRoot_09(HandleRef pThis);

		public virtual long GetRoot()
		{
			return vtkTree.vtkTree_GetRoot_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkTree_IsA_10(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTree.vtkTree_IsA_10(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern byte vtkTree_IsLeaf_11(HandleRef pThis, long vertex);

		public bool IsLeaf(long vertex)
		{
			return vtkTree.vtkTree_IsLeaf_11(base.GetCppThis(), vertex) != 0;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkTree_IsTypeOf_12(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTree.vtkTree_IsTypeOf_12(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkTree_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTree NewInstance()
		{
			vtkTree result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTree.vtkTree_NewInstance_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkTree_ReorderChildren_15(HandleRef pThis, long parent, HandleRef children);

		public virtual void ReorderChildren(long parent, vtkIdTypeArray children)
		{
			vtkTree.vtkTree_ReorderChildren_15(base.GetCppThis(), parent, (children == null) ? default(HandleRef) : children.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkTree_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTree SafeDownCast(vtkObjectBase o)
		{
			vtkTree vtkTree = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTree.vtkTree_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTree = (vtkTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTree.Register(null);
				}
			}
			return vtkTree;
		}
	}
}
