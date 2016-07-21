using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkModifiedBSPTree : vtkAbstractCellLocator
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkModifiedBSPTree";

		public new static readonly string MRClassNameKey;

		static vtkModifiedBSPTree()
		{
			vtkModifiedBSPTree.MRClassNameKey = "class vtkModifiedBSPTree";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkModifiedBSPTree.MRClassNameKey, Type.GetType("Kitware.VTK.vtkModifiedBSPTree"));
		}

		public vtkModifiedBSPTree(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkModifiedBSPTree_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkModifiedBSPTree New()
		{
			vtkModifiedBSPTree result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkModifiedBSPTree.vtkModifiedBSPTree_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkModifiedBSPTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkModifiedBSPTree() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkModifiedBSPTree.vtkModifiedBSPTree_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkModifiedBSPTree_BuildLocator_01(HandleRef pThis);

		public override void BuildLocator()
		{
			vtkModifiedBSPTree.vtkModifiedBSPTree_BuildLocator_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkModifiedBSPTree_FindCell_02(HandleRef pThis, IntPtr x);

		public override long FindCell(IntPtr x)
		{
			return vtkModifiedBSPTree.vtkModifiedBSPTree_FindCell_02(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkModifiedBSPTree_FindCell_03(HandleRef pThis, IntPtr x, double tol2, HandleRef GenCell, IntPtr pcoords, IntPtr weights);

		public override long FindCell(IntPtr x, double tol2, vtkGenericCell GenCell, IntPtr pcoords, IntPtr weights)
		{
			return vtkModifiedBSPTree.vtkModifiedBSPTree_FindCell_03(base.GetCppThis(), x, tol2, (GenCell == null) ? default(HandleRef) : GenCell.GetCppThis(), pcoords, weights);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkModifiedBSPTree_FreeSearchStructure_04(HandleRef pThis);

		public override void FreeSearchStructure()
		{
			vtkModifiedBSPTree.vtkModifiedBSPTree_FreeSearchStructure_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkModifiedBSPTree_GenerateRepresentation_05(HandleRef pThis, int level, HandleRef pd);

		public override void GenerateRepresentation(int level, vtkPolyData pd)
		{
			vtkModifiedBSPTree.vtkModifiedBSPTree_GenerateRepresentation_05(base.GetCppThis(), level, (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkModifiedBSPTree_GenerateRepresentationLeafs_06(HandleRef pThis, HandleRef pd);

		public virtual void GenerateRepresentationLeafs(vtkPolyData pd)
		{
			vtkModifiedBSPTree.vtkModifiedBSPTree_GenerateRepresentationLeafs_06(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkModifiedBSPTree_GetLeafNodeCellInformation_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkIdListCollection GetLeafNodeCellInformation()
		{
			vtkIdListCollection vtkIdListCollection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkModifiedBSPTree.vtkModifiedBSPTree_GetLeafNodeCellInformation_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdListCollection = (vtkIdListCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdListCollection.Register(null);
				}
			}
			return vtkIdListCollection;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern byte vtkModifiedBSPTree_InsideCellBounds_08(HandleRef pThis, IntPtr x, long cell_ID);

		public override bool InsideCellBounds(IntPtr x, long cell_ID)
		{
			return vtkModifiedBSPTree.vtkModifiedBSPTree_InsideCellBounds_08(base.GetCppThis(), x, cell_ID) != 0;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModifiedBSPTree_IntersectWithLine_09(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkModifiedBSPTree.vtkModifiedBSPTree_IntersectWithLine_09(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModifiedBSPTree_IntersectWithLine_10(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId);

		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId)
		{
			return vtkModifiedBSPTree.vtkModifiedBSPTree_IntersectWithLine_10(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId, ref cellId);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModifiedBSPTree_IntersectWithLine_11(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId, HandleRef cell);

		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId, vtkGenericCell cell)
		{
			return vtkModifiedBSPTree.vtkModifiedBSPTree_IntersectWithLine_11(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId, ref cellId, (cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModifiedBSPTree_IntersectWithLine_12(HandleRef pThis, IntPtr p1, IntPtr p2, HandleRef points, HandleRef cellIds);

		public override int IntersectWithLine(IntPtr p1, IntPtr p2, vtkPoints points, vtkIdList cellIds)
		{
			return vtkModifiedBSPTree.vtkModifiedBSPTree_IntersectWithLine_12(base.GetCppThis(), p1, p2, (points == null) ? default(HandleRef) : points.GetCppThis(), (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModifiedBSPTree_IntersectWithLine_13(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, HandleRef points, HandleRef cellIds);

		public virtual int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, vtkPoints points, vtkIdList cellIds)
		{
			return vtkModifiedBSPTree.vtkModifiedBSPTree_IntersectWithLine_13(base.GetCppThis(), p1, p2, tol, (points == null) ? default(HandleRef) : points.GetCppThis(), (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModifiedBSPTree_IsA_14(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkModifiedBSPTree.vtkModifiedBSPTree_IsA_14(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkModifiedBSPTree_IsTypeOf_15(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkModifiedBSPTree.vtkModifiedBSPTree_IsTypeOf_15(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkModifiedBSPTree_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkModifiedBSPTree NewInstance()
		{
			vtkModifiedBSPTree result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkModifiedBSPTree.vtkModifiedBSPTree_NewInstance_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkModifiedBSPTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkModifiedBSPTree_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkModifiedBSPTree SafeDownCast(vtkObjectBase o)
		{
			vtkModifiedBSPTree vtkModifiedBSPTree = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkModifiedBSPTree.vtkModifiedBSPTree_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkModifiedBSPTree = (vtkModifiedBSPTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkModifiedBSPTree.Register(null);
				}
			}
			return vtkModifiedBSPTree;
		}
	}
}
