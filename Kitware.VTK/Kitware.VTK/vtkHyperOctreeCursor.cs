using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkHyperOctreeCursor : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkHyperOctreeCursor";

		public new static readonly string MRClassNameKey;

		static vtkHyperOctreeCursor()
		{
			vtkHyperOctreeCursor.MRClassNameKey = "class vtkHyperOctreeCursor";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHyperOctreeCursor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHyperOctreeCursor"));
		}

		public vtkHyperOctreeCursor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeCursor_Clone_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkHyperOctreeCursor Clone()
		{
			vtkHyperOctreeCursor vtkHyperOctreeCursor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctreeCursor.vtkHyperOctreeCursor_Clone_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHyperOctreeCursor = (vtkHyperOctreeCursor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHyperOctreeCursor.Register(null);
				}
			}
			return vtkHyperOctreeCursor;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeCursor_CurrentIsLeaf_02(HandleRef pThis);

		public virtual int CurrentIsLeaf()
		{
			return vtkHyperOctreeCursor.vtkHyperOctreeCursor_CurrentIsLeaf_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeCursor_CurrentIsRoot_03(HandleRef pThis);

		public virtual int CurrentIsRoot()
		{
			return vtkHyperOctreeCursor.vtkHyperOctreeCursor_CurrentIsRoot_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeCursor_CurrentIsTerminalNode_04(HandleRef pThis);

		public virtual int CurrentIsTerminalNode()
		{
			return vtkHyperOctreeCursor.vtkHyperOctreeCursor_CurrentIsTerminalNode_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeCursor_Found_05(HandleRef pThis);

		public virtual int Found()
		{
			return vtkHyperOctreeCursor.vtkHyperOctreeCursor_Found_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeCursor_GetChildIndex_06(HandleRef pThis);

		public virtual int GetChildIndex()
		{
			return vtkHyperOctreeCursor.vtkHyperOctreeCursor_GetChildIndex_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeCursor_GetCurrentLevel_07(HandleRef pThis);

		public virtual int GetCurrentLevel()
		{
			return vtkHyperOctreeCursor.vtkHyperOctreeCursor_GetCurrentLevel_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeCursor_GetDimension_08(HandleRef pThis);

		public virtual int GetDimension()
		{
			return vtkHyperOctreeCursor.vtkHyperOctreeCursor_GetDimension_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeCursor_GetIndex_09(HandleRef pThis, int d);

		public virtual int GetIndex(int d)
		{
			return vtkHyperOctreeCursor.vtkHyperOctreeCursor_GetIndex_09(base.GetCppThis(), d);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeCursor_GetLeafId_10(HandleRef pThis);

		public virtual int GetLeafId()
		{
			return vtkHyperOctreeCursor.vtkHyperOctreeCursor_GetLeafId_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeCursor_GetNumberOfChildren_11(HandleRef pThis);

		public virtual int GetNumberOfChildren()
		{
			return vtkHyperOctreeCursor.vtkHyperOctreeCursor_GetNumberOfChildren_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeCursor_IsA_12(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkHyperOctreeCursor.vtkHyperOctreeCursor_IsA_12(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeCursor_IsEqual_13(HandleRef pThis, HandleRef other);

		public virtual int IsEqual(vtkHyperOctreeCursor other)
		{
			return vtkHyperOctreeCursor.vtkHyperOctreeCursor_IsEqual_13(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeCursor_IsTypeOf_14(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkHyperOctreeCursor.vtkHyperOctreeCursor_IsTypeOf_14(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeCursor_MoveToNode_15(HandleRef pThis, IntPtr indices, int level);

		public virtual void MoveToNode(IntPtr indices, int level)
		{
			vtkHyperOctreeCursor.vtkHyperOctreeCursor_MoveToNode_15(base.GetCppThis(), indices, level);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeCursor_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkHyperOctreeCursor NewInstance()
		{
			vtkHyperOctreeCursor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctreeCursor.vtkHyperOctreeCursor_NewInstance_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHyperOctreeCursor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeCursor_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHyperOctreeCursor SafeDownCast(vtkObjectBase o)
		{
			vtkHyperOctreeCursor vtkHyperOctreeCursor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctreeCursor.vtkHyperOctreeCursor_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHyperOctreeCursor = (vtkHyperOctreeCursor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHyperOctreeCursor.Register(null);
				}
			}
			return vtkHyperOctreeCursor;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeCursor_SameTree_18(HandleRef pThis, HandleRef other);

		public virtual int SameTree(vtkHyperOctreeCursor other)
		{
			return vtkHyperOctreeCursor.vtkHyperOctreeCursor_SameTree_18(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeCursor_ToChild_19(HandleRef pThis, int child);

		public virtual void ToChild(int child)
		{
			vtkHyperOctreeCursor.vtkHyperOctreeCursor_ToChild_19(base.GetCppThis(), child);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeCursor_ToParent_20(HandleRef pThis);

		public virtual void ToParent()
		{
			vtkHyperOctreeCursor.vtkHyperOctreeCursor_ToParent_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeCursor_ToRoot_21(HandleRef pThis);

		public virtual void ToRoot()
		{
			vtkHyperOctreeCursor.vtkHyperOctreeCursor_ToRoot_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeCursor_ToSameNode_22(HandleRef pThis, HandleRef other);

		public virtual void ToSameNode(vtkHyperOctreeCursor other)
		{
			vtkHyperOctreeCursor.vtkHyperOctreeCursor_ToSameNode_22(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis());
		}
	}
}
