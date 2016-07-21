using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCompositeDataIterator : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCompositeDataIterator";

		public new static readonly string MRClassNameKey;

		static vtkCompositeDataIterator()
		{
			vtkCompositeDataIterator.MRClassNameKey = "class vtkCompositeDataIterator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCompositeDataIterator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompositeDataIterator"));
		}

		public vtkCompositeDataIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCompositeDataIterator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCompositeDataIterator New()
		{
			vtkCompositeDataIterator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompositeDataIterator.vtkCompositeDataIterator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositeDataIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCompositeDataIterator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCompositeDataIterator.vtkCompositeDataIterator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCompositeDataIterator_GetCurrentDataObject_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDataObject GetCurrentDataObject()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompositeDataIterator.vtkCompositeDataIterator_GetCurrentDataObject_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkCompositeDataIterator_GetCurrentFlatIndex_02(HandleRef pThis);

		public uint GetCurrentFlatIndex()
		{
			return vtkCompositeDataIterator.vtkCompositeDataIterator_GetCurrentFlatIndex_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCompositeDataIterator_GetCurrentMetaData_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkInformation GetCurrentMetaData()
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompositeDataIterator.vtkCompositeDataIterator_GetCurrentMetaData_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformation = (vtkInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformation.Register(null);
				}
			}
			return vtkInformation;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCompositeDataIterator_GetDataSet_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCompositeDataSet GetDataSet()
		{
			vtkCompositeDataSet vtkCompositeDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompositeDataIterator.vtkCompositeDataIterator_GetDataSet_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeDataSet = (vtkCompositeDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeDataSet.Register(null);
				}
			}
			return vtkCompositeDataSet;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCompositeDataIterator_GetReverse_05(HandleRef pThis);

		public virtual int GetReverse()
		{
			return vtkCompositeDataIterator.vtkCompositeDataIterator_GetReverse_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCompositeDataIterator_GetSkipEmptyNodes_06(HandleRef pThis);

		public virtual int GetSkipEmptyNodes()
		{
			return vtkCompositeDataIterator.vtkCompositeDataIterator_GetSkipEmptyNodes_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCompositeDataIterator_GetTraverseSubTree_07(HandleRef pThis);

		public virtual int GetTraverseSubTree()
		{
			return vtkCompositeDataIterator.vtkCompositeDataIterator_GetTraverseSubTree_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCompositeDataIterator_GetVisitOnlyLeaves_08(HandleRef pThis);

		public virtual int GetVisitOnlyLeaves()
		{
			return vtkCompositeDataIterator.vtkCompositeDataIterator_GetVisitOnlyLeaves_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCompositeDataIterator_GoToFirstItem_09(HandleRef pThis);

		public virtual void GoToFirstItem()
		{
			vtkCompositeDataIterator.vtkCompositeDataIterator_GoToFirstItem_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCompositeDataIterator_GoToNextItem_10(HandleRef pThis);

		public virtual void GoToNextItem()
		{
			vtkCompositeDataIterator.vtkCompositeDataIterator_GoToNextItem_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCompositeDataIterator_HasCurrentMetaData_11(HandleRef pThis);

		public virtual int HasCurrentMetaData()
		{
			return vtkCompositeDataIterator.vtkCompositeDataIterator_HasCurrentMetaData_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCompositeDataIterator_InitReverseTraversal_12(HandleRef pThis);

		public virtual void InitReverseTraversal()
		{
			vtkCompositeDataIterator.vtkCompositeDataIterator_InitReverseTraversal_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCompositeDataIterator_InitTraversal_13(HandleRef pThis);

		public virtual void InitTraversal()
		{
			vtkCompositeDataIterator.vtkCompositeDataIterator_InitTraversal_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCompositeDataIterator_IsA_14(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCompositeDataIterator.vtkCompositeDataIterator_IsA_14(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCompositeDataIterator_IsDoneWithTraversal_15(HandleRef pThis);

		public virtual int IsDoneWithTraversal()
		{
			return vtkCompositeDataIterator.vtkCompositeDataIterator_IsDoneWithTraversal_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCompositeDataIterator_IsTypeOf_16(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCompositeDataIterator.vtkCompositeDataIterator_IsTypeOf_16(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCompositeDataIterator_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCompositeDataIterator NewInstance()
		{
			vtkCompositeDataIterator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompositeDataIterator.vtkCompositeDataIterator_NewInstance_18(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositeDataIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCompositeDataIterator_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCompositeDataIterator SafeDownCast(vtkObjectBase o)
		{
			vtkCompositeDataIterator vtkCompositeDataIterator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompositeDataIterator.vtkCompositeDataIterator_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeDataIterator = (vtkCompositeDataIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeDataIterator.Register(null);
				}
			}
			return vtkCompositeDataIterator;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCompositeDataIterator_SetDataSet_20(HandleRef pThis, HandleRef ds);

		public virtual void SetDataSet(vtkCompositeDataSet ds)
		{
			vtkCompositeDataIterator.vtkCompositeDataIterator_SetDataSet_20(base.GetCppThis(), (ds == null) ? default(HandleRef) : ds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCompositeDataIterator_SetSkipEmptyNodes_21(HandleRef pThis, int _arg);

		public virtual void SetSkipEmptyNodes(int _arg)
		{
			vtkCompositeDataIterator.vtkCompositeDataIterator_SetSkipEmptyNodes_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCompositeDataIterator_SetTraverseSubTree_22(HandleRef pThis, int _arg);

		public virtual void SetTraverseSubTree(int _arg)
		{
			vtkCompositeDataIterator.vtkCompositeDataIterator_SetTraverseSubTree_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCompositeDataIterator_SetVisitOnlyLeaves_23(HandleRef pThis, int _arg);

		public virtual void SetVisitOnlyLeaves(int _arg)
		{
			vtkCompositeDataIterator.vtkCompositeDataIterator_SetVisitOnlyLeaves_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCompositeDataIterator_SkipEmptyNodesOff_24(HandleRef pThis);

		public virtual void SkipEmptyNodesOff()
		{
			vtkCompositeDataIterator.vtkCompositeDataIterator_SkipEmptyNodesOff_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCompositeDataIterator_SkipEmptyNodesOn_25(HandleRef pThis);

		public virtual void SkipEmptyNodesOn()
		{
			vtkCompositeDataIterator.vtkCompositeDataIterator_SkipEmptyNodesOn_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCompositeDataIterator_TraverseSubTreeOff_26(HandleRef pThis);

		public virtual void TraverseSubTreeOff()
		{
			vtkCompositeDataIterator.vtkCompositeDataIterator_TraverseSubTreeOff_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCompositeDataIterator_TraverseSubTreeOn_27(HandleRef pThis);

		public virtual void TraverseSubTreeOn()
		{
			vtkCompositeDataIterator.vtkCompositeDataIterator_TraverseSubTreeOn_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCompositeDataIterator_VisitOnlyLeavesOff_28(HandleRef pThis);

		public virtual void VisitOnlyLeavesOff()
		{
			vtkCompositeDataIterator.vtkCompositeDataIterator_VisitOnlyLeavesOff_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCompositeDataIterator_VisitOnlyLeavesOn_29(HandleRef pThis);

		public virtual void VisitOnlyLeavesOn()
		{
			vtkCompositeDataIterator.vtkCompositeDataIterator_VisitOnlyLeavesOn_29(base.GetCppThis());
		}
	}
}
