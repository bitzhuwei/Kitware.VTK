using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkHyperOctree : vtkDataSet
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkHyperOctree";

		public new static readonly string MRClassNameKey;

		static vtkHyperOctree()
		{
			vtkHyperOctree.MRClassNameKey = "class vtkHyperOctree";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHyperOctree.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHyperOctree"));
		}

		public vtkHyperOctree(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctree_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHyperOctree New()
		{
			vtkHyperOctree result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctree.vtkHyperOctree_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHyperOctree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkHyperOctree() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkHyperOctree.vtkHyperOctree_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHyperOctree_CollapseTerminalNode_01(HandleRef pThis, HandleRef node);

		public void CollapseTerminalNode(vtkHyperOctreeCursor node)
		{
			vtkHyperOctree.vtkHyperOctree_CollapseTerminalNode_01(base.GetCppThis(), (node == null) ? default(HandleRef) : node.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHyperOctree_CopyStructure_02(HandleRef pThis, HandleRef ds);

		public override void CopyStructure(vtkDataSet ds)
		{
			vtkHyperOctree.vtkHyperOctree_CopyStructure_02(base.GetCppThis(), (ds == null) ? default(HandleRef) : ds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctree_DIMENSION_03(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey DIMENSION()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctree.vtkHyperOctree_DIMENSION_03(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHyperOctree_DeepCopy_04(HandleRef pThis, HandleRef src);

		public override void DeepCopy(vtkDataObject src)
		{
			vtkHyperOctree.vtkHyperOctree_DeepCopy_04(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkHyperOctree_FindCell_05(HandleRef pThis, IntPtr x, HandleRef cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights);

		public override long FindCell(IntPtr x, vtkCell cell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
		{
			return vtkHyperOctree.vtkHyperOctree_FindCell_05(base.GetCppThis(), x, (cell == null) ? default(HandleRef) : cell.GetCppThis(), cellId, tol2, ref subId, pcoords, weights);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkHyperOctree_FindCell_06(HandleRef pThis, IntPtr x, HandleRef cell, HandleRef gencell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights);

		public override long FindCell(IntPtr x, vtkCell cell, vtkGenericCell gencell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
		{
			return vtkHyperOctree.vtkHyperOctree_FindCell_06(base.GetCppThis(), x, (cell == null) ? default(HandleRef) : cell.GetCppThis(), (gencell == null) ? default(HandleRef) : gencell.GetCppThis(), cellId, tol2, ref subId, pcoords, weights);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkHyperOctree_FindPoint_07(HandleRef pThis, IntPtr x);

		public override long FindPoint(IntPtr x)
		{
			return vtkHyperOctree.vtkHyperOctree_FindPoint_07(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkHyperOctree_GetActualMemorySize_08(HandleRef pThis);

		public override uint GetActualMemorySize()
		{
			return vtkHyperOctree.vtkHyperOctree_GetActualMemorySize_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctree_GetCell_09(HandleRef pThis, long cellId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkCell GetCell(long cellId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctree.vtkHyperOctree_GetCell_09(base.GetCppThis(), cellId, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCell = (vtkCell)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCell.Register(null);
				}
			}
			return vtkCell;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHyperOctree_GetCell_10(HandleRef pThis, long cellId, HandleRef cell);

		public override void GetCell(long cellId, vtkGenericCell cell)
		{
			vtkHyperOctree.vtkHyperOctree_GetCell_10(base.GetCppThis(), cellId, (cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHyperOctree_GetCellNeighbors_11(HandleRef pThis, long cellId, HandleRef ptIds, HandleRef cellIds);

		public override void GetCellNeighbors(long cellId, vtkIdList ptIds, vtkIdList cellIds)
		{
			vtkHyperOctree.vtkHyperOctree_GetCellNeighbors_11(base.GetCppThis(), cellId, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis(), (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHyperOctree_GetCellPoints_12(HandleRef pThis, long cellId, HandleRef ptIds);

		public override void GetCellPoints(long cellId, vtkIdList ptIds)
		{
			vtkHyperOctree.vtkHyperOctree_GetCellPoints_12(base.GetCppThis(), cellId, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHyperOctree_GetCellType_13(HandleRef pThis, long cellId);

		public override int GetCellType(long cellId)
		{
			return vtkHyperOctree.vtkHyperOctree_GetCellType_13(base.GetCppThis(), cellId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctree_GetData_14(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHyperOctree GetData(vtkInformation info)
		{
			vtkHyperOctree vtkHyperOctree = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctree.vtkHyperOctree_GetData_14((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHyperOctree = (vtkHyperOctree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHyperOctree.Register(null);
				}
			}
			return vtkHyperOctree;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctree_GetData_15(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHyperOctree GetData(vtkInformationVector v, int i)
		{
			vtkHyperOctree vtkHyperOctree = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctree.vtkHyperOctree_GetData_15((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHyperOctree = (vtkHyperOctree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHyperOctree.Register(null);
				}
			}
			return vtkHyperOctree;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHyperOctree_GetDataObjectType_16(HandleRef pThis);

		public override int GetDataObjectType()
		{
			return vtkHyperOctree.vtkHyperOctree_GetDataObjectType_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHyperOctree_GetDimension_17(HandleRef pThis);

		public int GetDimension()
		{
			return vtkHyperOctree.vtkHyperOctree_GetDimension_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHyperOctree_GetDualGridFlag_18(HandleRef pThis);

		public virtual int GetDualGridFlag()
		{
			return vtkHyperOctree.vtkHyperOctree_GetDualGridFlag_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctree_GetLeafData_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataSetAttributes GetLeafData()
		{
			vtkDataSetAttributes vtkDataSetAttributes = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctree.vtkHyperOctree_GetLeafData_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetAttributes = (vtkDataSetAttributes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetAttributes.Register(null);
				}
			}
			return vtkDataSetAttributes;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHyperOctree_GetMaxCellSize_20(HandleRef pThis);

		public override int GetMaxCellSize()
		{
			return vtkHyperOctree.vtkHyperOctree_GetMaxCellSize_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkHyperOctree_GetMaxNumberOfCellsOnBoundary_21(HandleRef pThis, int level);

		public long GetMaxNumberOfCellsOnBoundary(int level)
		{
			return vtkHyperOctree.vtkHyperOctree_GetMaxNumberOfCellsOnBoundary_21(base.GetCppThis(), level);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkHyperOctree_GetMaxNumberOfPoints_22(HandleRef pThis, int level);

		public long GetMaxNumberOfPoints(int level)
		{
			return vtkHyperOctree.vtkHyperOctree_GetMaxNumberOfPoints_22(base.GetCppThis(), level);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkHyperOctree_GetMaxNumberOfPointsOnBoundary_23(HandleRef pThis, int level);

		public long GetMaxNumberOfPointsOnBoundary(int level)
		{
			return vtkHyperOctree.vtkHyperOctree_GetMaxNumberOfPointsOnBoundary_23(base.GetCppThis(), level);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkHyperOctree_GetNumberOfCells_24(HandleRef pThis);

		public override long GetNumberOfCells()
		{
			return vtkHyperOctree.vtkHyperOctree_GetNumberOfCells_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkHyperOctree_GetNumberOfLeaves_25(HandleRef pThis);

		public long GetNumberOfLeaves()
		{
			return vtkHyperOctree.vtkHyperOctree_GetNumberOfLeaves_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkHyperOctree_GetNumberOfLevels_26(HandleRef pThis);

		public long GetNumberOfLevels()
		{
			return vtkHyperOctree.vtkHyperOctree_GetNumberOfLevels_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkHyperOctree_GetNumberOfPoints_27(HandleRef pThis);

		public override long GetNumberOfPoints()
		{
			return vtkHyperOctree.vtkHyperOctree_GetNumberOfPoints_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctree_GetOrigin_28(HandleRef pThis);

		public virtual double[] GetOrigin()
		{
			IntPtr intPtr = vtkHyperOctree.vtkHyperOctree_GetOrigin_28(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHyperOctree_GetOrigin_29(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkHyperOctree.vtkHyperOctree_GetOrigin_29(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHyperOctree_GetOrigin_30(HandleRef pThis, IntPtr _arg);

		public virtual void GetOrigin(IntPtr _arg)
		{
			vtkHyperOctree.vtkHyperOctree_GetOrigin_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctree_GetPoint_31(HandleRef pThis, long ptId);

		public override double[] GetPoint(long ptId)
		{
			IntPtr intPtr = vtkHyperOctree.vtkHyperOctree_GetPoint_31(base.GetCppThis(), ptId);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHyperOctree_GetPoint_32(HandleRef pThis, long id, IntPtr x);

		public override void GetPoint(long id, IntPtr x)
		{
			vtkHyperOctree.vtkHyperOctree_GetPoint_32(base.GetCppThis(), id, x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHyperOctree_GetPointCells_33(HandleRef pThis, long ptId, HandleRef cellIds);

		public override void GetPointCells(long ptId, vtkIdList cellIds)
		{
			vtkHyperOctree.vtkHyperOctree_GetPointCells_33(base.GetCppThis(), ptId, (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHyperOctree_GetPointsOnEdge_34(HandleRef pThis, HandleRef sibling, int level, int axis, int k, int j, HandleRef grabber);

		public void GetPointsOnEdge(vtkHyperOctreeCursor sibling, int level, int axis, int k, int j, vtkHyperOctreePointsGrabber grabber)
		{
			vtkHyperOctree.vtkHyperOctree_GetPointsOnEdge_34(base.GetCppThis(), (sibling == null) ? default(HandleRef) : sibling.GetCppThis(), level, axis, k, j, (grabber == null) ? default(HandleRef) : grabber.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHyperOctree_GetPointsOnEdge2D_35(HandleRef pThis, HandleRef sibling, int edge, int level, HandleRef grabber);

		public void GetPointsOnEdge2D(vtkHyperOctreeCursor sibling, int edge, int level, vtkHyperOctreePointsGrabber grabber)
		{
			vtkHyperOctree.vtkHyperOctree_GetPointsOnEdge2D_35(base.GetCppThis(), (sibling == null) ? default(HandleRef) : sibling.GetCppThis(), edge, level, (grabber == null) ? default(HandleRef) : grabber.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHyperOctree_GetPointsOnFace_36(HandleRef pThis, HandleRef sibling, int face, int level, HandleRef grabber);

		public void GetPointsOnFace(vtkHyperOctreeCursor sibling, int face, int level, vtkHyperOctreePointsGrabber grabber)
		{
			vtkHyperOctree.vtkHyperOctree_GetPointsOnFace_36(base.GetCppThis(), (sibling == null) ? default(HandleRef) : sibling.GetCppThis(), face, level, (grabber == null) ? default(HandleRef) : grabber.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHyperOctree_GetPointsOnParentEdge_37(HandleRef pThis, HandleRef cursor, int level, int axis, int k, int j, HandleRef grabber);

		public void GetPointsOnParentEdge(vtkHyperOctreeCursor cursor, int level, int axis, int k, int j, vtkHyperOctreePointsGrabber grabber)
		{
			vtkHyperOctree.vtkHyperOctree_GetPointsOnParentEdge_37(base.GetCppThis(), (cursor == null) ? default(HandleRef) : cursor.GetCppThis(), level, axis, k, j, (grabber == null) ? default(HandleRef) : grabber.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHyperOctree_GetPointsOnParentEdge2D_38(HandleRef pThis, HandleRef cursor, int edge, int level, HandleRef grabber);

		public void GetPointsOnParentEdge2D(vtkHyperOctreeCursor cursor, int edge, int level, vtkHyperOctreePointsGrabber grabber)
		{
			vtkHyperOctree.vtkHyperOctree_GetPointsOnParentEdge2D_38(base.GetCppThis(), (cursor == null) ? default(HandleRef) : cursor.GetCppThis(), edge, level, (grabber == null) ? default(HandleRef) : grabber.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHyperOctree_GetPointsOnParentFaces_39(HandleRef pThis, IntPtr faces, int level, HandleRef cursor, HandleRef grabber);

		public void GetPointsOnParentFaces(IntPtr faces, int level, vtkHyperOctreeCursor cursor, vtkHyperOctreePointsGrabber grabber)
		{
			vtkHyperOctree.vtkHyperOctree_GetPointsOnParentFaces_39(base.GetCppThis(), faces, level, (cursor == null) ? default(HandleRef) : cursor.GetCppThis(), (grabber == null) ? default(HandleRef) : grabber.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctree_GetSize_40(HandleRef pThis);

		public virtual double[] GetSize()
		{
			IntPtr intPtr = vtkHyperOctree.vtkHyperOctree_GetSize_40(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHyperOctree_GetSize_41(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetSize(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkHyperOctree.vtkHyperOctree_GetSize_41(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHyperOctree_GetSize_42(HandleRef pThis, IntPtr _arg);

		public virtual void GetSize(IntPtr _arg)
		{
			vtkHyperOctree.vtkHyperOctree_GetSize_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHyperOctree_Initialize_43(HandleRef pThis);

		public override void Initialize()
		{
			vtkHyperOctree.vtkHyperOctree_Initialize_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHyperOctree_IsA_44(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkHyperOctree.vtkHyperOctree_IsA_44(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHyperOctree_IsTypeOf_45(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkHyperOctree.vtkHyperOctree_IsTypeOf_45(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctree_LEVELS_46(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationIntegerKey LEVELS()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctree.vtkHyperOctree_LEVELS_46(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctree_NewCellCursor_48(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkHyperOctreeCursor NewCellCursor()
		{
			vtkHyperOctreeCursor vtkHyperOctreeCursor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctree.vtkHyperOctree_NewCellCursor_48(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkHyperOctree_NewInstance_49(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkHyperOctree NewInstance()
		{
			vtkHyperOctree result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctree.vtkHyperOctree_NewInstance_49(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHyperOctree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctree_SIZES_50(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkInformationDoubleVectorKey SIZES()
		{
			vtkInformationDoubleVectorKey vtkInformationDoubleVectorKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctree.vtkHyperOctree_SIZES_50(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationDoubleVectorKey = (vtkInformationDoubleVectorKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationDoubleVectorKey.Register(null);
				}
			}
			return vtkInformationDoubleVectorKey;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctree_SafeDownCast_51(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHyperOctree SafeDownCast(vtkObjectBase o)
		{
			vtkHyperOctree vtkHyperOctree = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctree.vtkHyperOctree_SafeDownCast_51((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHyperOctree = (vtkHyperOctree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHyperOctree.Register(null);
				}
			}
			return vtkHyperOctree;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHyperOctree_SetDimension_52(HandleRef pThis, int dim);

		public void SetDimension(int dim)
		{
			vtkHyperOctree.vtkHyperOctree_SetDimension_52(base.GetCppThis(), dim);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHyperOctree_SetDualGridFlag_53(HandleRef pThis, int flag);

		public void SetDualGridFlag(int flag)
		{
			vtkHyperOctree.vtkHyperOctree_SetDualGridFlag_53(base.GetCppThis(), flag);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHyperOctree_SetOrigin_54(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkHyperOctree.vtkHyperOctree_SetOrigin_54(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHyperOctree_SetOrigin_55(HandleRef pThis, IntPtr _arg);

		public virtual void SetOrigin(IntPtr _arg)
		{
			vtkHyperOctree.vtkHyperOctree_SetOrigin_55(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHyperOctree_SetSize_56(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetSize(double _arg1, double _arg2, double _arg3)
		{
			vtkHyperOctree.vtkHyperOctree_SetSize_56(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHyperOctree_SetSize_57(HandleRef pThis, IntPtr _arg);

		public virtual void SetSize(IntPtr _arg)
		{
			vtkHyperOctree.vtkHyperOctree_SetSize_57(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHyperOctree_ShallowCopy_58(HandleRef pThis, HandleRef src);

		public override void ShallowCopy(vtkDataObject src)
		{
			vtkHyperOctree.vtkHyperOctree_ShallowCopy_58(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHyperOctree_SubdivideLeaf_59(HandleRef pThis, HandleRef leaf);

		public void SubdivideLeaf(vtkHyperOctreeCursor leaf)
		{
			vtkHyperOctree.vtkHyperOctree_SubdivideLeaf_59(base.GetCppThis(), (leaf == null) ? default(HandleRef) : leaf.GetCppThis());
		}
	}
}
