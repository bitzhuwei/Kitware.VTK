using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkKdTree : vtkLocator
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkKdTree";

		public new static readonly string MRClassNameKey;

		static vtkKdTree()
		{
			vtkKdTree.MRClassNameKey = "class vtkKdTree";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkKdTree.MRClassNameKey, Type.GetType("Kitware.VTK.vtkKdTree"));
		}

		public vtkKdTree(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkKdTree_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkKdTree New()
		{
			vtkKdTree result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkKdTree.vtkKdTree_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkKdTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkKdTree() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkKdTree.vtkKdTree_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_AddDataSet_01(HandleRef pThis, HandleRef set);

		public virtual void AddDataSet(vtkDataSet set)
		{
			vtkKdTree.vtkKdTree_AddDataSet_01(base.GetCppThis(), (set == null) ? default(HandleRef) : set.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkKdTree_AllGetRegionContainingCell_02(HandleRef pThis);

		public IntPtr AllGetRegionContainingCell()
		{
			return vtkKdTree.vtkKdTree_AllGetRegionContainingCell_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_BuildLocator_03(HandleRef pThis);

		public override void BuildLocator()
		{
			vtkKdTree.vtkKdTree_BuildLocator_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_BuildLocatorFromPoints_04(HandleRef pThis, HandleRef pointset);

		public void BuildLocatorFromPoints(vtkPointSet pointset)
		{
			vtkKdTree.vtkKdTree_BuildLocatorFromPoints_04(base.GetCppThis(), (pointset == null) ? default(HandleRef) : pointset.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_BuildLocatorFromPoints_05(HandleRef pThis, HandleRef ptArray);

		public void BuildLocatorFromPoints(vtkPoints ptArray)
		{
			vtkKdTree.vtkKdTree_BuildLocatorFromPoints_05(base.GetCppThis(), (ptArray == null) ? default(HandleRef) : ptArray.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkKdTree_BuildMapForDuplicatePoints_06(HandleRef pThis, float tolerance, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkIdTypeArray BuildMapForDuplicatePoints(float tolerance)
		{
			vtkIdTypeArray vtkIdTypeArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkKdTree.vtkKdTree_BuildMapForDuplicatePoints_06(base.GetCppThis(), tolerance, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdTypeArray = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdTypeArray.Register(null);
				}
			}
			return vtkIdTypeArray;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkKdTree_CopyTree_07(HandleRef kd, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkKdNode CopyTree(vtkKdNode kd)
		{
			vtkKdNode vtkKdNode = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkKdTree.vtkKdTree_CopyTree_07((kd == null) ? default(HandleRef) : kd.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkKdNode = (vtkKdNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkKdNode.Register(null);
				}
			}
			return vtkKdNode;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_CreateCellLists_08(HandleRef pThis, int dataSetIndex, IntPtr regionReqList, int reqListSize);

		public void CreateCellLists(int dataSetIndex, IntPtr regionReqList, int reqListSize)
		{
			vtkKdTree.vtkKdTree_CreateCellLists_08(base.GetCppThis(), dataSetIndex, regionReqList, reqListSize);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_CreateCellLists_09(HandleRef pThis, HandleRef set, IntPtr regionReqList, int reqListSize);

		public void CreateCellLists(vtkDataSet set, IntPtr regionReqList, int reqListSize)
		{
			vtkKdTree.vtkKdTree_CreateCellLists_09(base.GetCppThis(), (set == null) ? default(HandleRef) : set.GetCppThis(), regionReqList, reqListSize);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_CreateCellLists_10(HandleRef pThis, IntPtr regionReqList, int listSize);

		public void CreateCellLists(IntPtr regionReqList, int listSize)
		{
			vtkKdTree.vtkKdTree_CreateCellLists_10(base.GetCppThis(), regionReqList, listSize);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_CreateCellLists_11(HandleRef pThis);

		public void CreateCellLists()
		{
			vtkKdTree.vtkKdTree_CreateCellLists_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_DeleteCellLists_12(HandleRef pThis);

		public void DeleteCellLists()
		{
			vtkKdTree.vtkKdTree_DeleteCellLists_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_FindClosestNPoints_13(HandleRef pThis, int N, IntPtr x, HandleRef result);

		public void FindClosestNPoints(int N, IntPtr x, vtkIdList result)
		{
			vtkKdTree.vtkKdTree_FindClosestNPoints_13(base.GetCppThis(), N, x, (result == null) ? default(HandleRef) : result.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkKdTree_FindClosestPoint_14(HandleRef pThis, IntPtr x, ref double dist2);

		public long FindClosestPoint(IntPtr x, ref double dist2)
		{
			return vtkKdTree.vtkKdTree_FindClosestPoint_14(base.GetCppThis(), x, ref dist2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkKdTree_FindClosestPoint_15(HandleRef pThis, double x, double y, double z, ref double dist2);

		public long FindClosestPoint(double x, double y, double z, ref double dist2)
		{
			return vtkKdTree.vtkKdTree_FindClosestPoint_15(base.GetCppThis(), x, y, z, ref dist2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkKdTree_FindClosestPointInRegion_16(HandleRef pThis, int regionId, IntPtr x, ref double dist2);

		public long FindClosestPointInRegion(int regionId, IntPtr x, ref double dist2)
		{
			return vtkKdTree.vtkKdTree_FindClosestPointInRegion_16(base.GetCppThis(), regionId, x, ref dist2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkKdTree_FindClosestPointInRegion_17(HandleRef pThis, int regionId, double x, double y, double z, ref double dist2);

		public long FindClosestPointInRegion(int regionId, double x, double y, double z, ref double dist2)
		{
			return vtkKdTree.vtkKdTree_FindClosestPointInRegion_17(base.GetCppThis(), regionId, x, y, z, ref dist2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkKdTree_FindClosestPointWithinRadius_18(HandleRef pThis, double radius, IntPtr x, ref double dist2);

		public long FindClosestPointWithinRadius(double radius, IntPtr x, ref double dist2)
		{
			return vtkKdTree.vtkKdTree_FindClosestPointWithinRadius_18(base.GetCppThis(), radius, x, ref dist2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkKdTree_FindPoint_19(HandleRef pThis, IntPtr x);

		public long FindPoint(IntPtr x)
		{
			return vtkKdTree.vtkKdTree_FindPoint_19(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkKdTree_FindPoint_20(HandleRef pThis, double x, double y, double z);

		public long FindPoint(double x, double y, double z)
		{
			return vtkKdTree.vtkKdTree_FindPoint_20(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_FindPointsInArea_21(HandleRef pThis, IntPtr area, HandleRef ids, byte clearArray);

		public void FindPointsInArea(IntPtr area, vtkIdTypeArray ids, bool clearArray)
		{
			vtkKdTree.vtkKdTree_FindPointsInArea_21(base.GetCppThis(), area, (ids == null) ? default(HandleRef) : ids.GetCppThis(), clearArray ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_FindPointsWithinRadius_22(HandleRef pThis, double R, IntPtr x, HandleRef result);

		public void FindPointsWithinRadius(double R, IntPtr x, vtkIdList result)
		{
			vtkKdTree.vtkKdTree_FindPointsWithinRadius_22(base.GetCppThis(), R, x, (result == null) ? default(HandleRef) : result.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_FreeSearchStructure_23(HandleRef pThis);

		public override void FreeSearchStructure()
		{
			vtkKdTree.vtkKdTree_FreeSearchStructure_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_GenerateRepresentation_24(HandleRef pThis, int level, HandleRef pd);

		public override void GenerateRepresentation(int level, vtkPolyData pd)
		{
			vtkKdTree.vtkKdTree_GenerateRepresentation_24(base.GetCppThis(), level, (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_GenerateRepresentation_25(HandleRef pThis, IntPtr regionList, int len, HandleRef pd);

		public void GenerateRepresentation(IntPtr regionList, int len, vtkPolyData pd)
		{
			vtkKdTree.vtkKdTree_GenerateRepresentation_25(base.GetCppThis(), regionList, len, (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_GenerateRepresentationUsingDataBoundsOff_26(HandleRef pThis);

		public virtual void GenerateRepresentationUsingDataBoundsOff()
		{
			vtkKdTree.vtkKdTree_GenerateRepresentationUsingDataBoundsOff_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_GenerateRepresentationUsingDataBoundsOn_27(HandleRef pThis);

		public virtual void GenerateRepresentationUsingDataBoundsOn()
		{
			vtkKdTree.vtkKdTree_GenerateRepresentationUsingDataBoundsOn_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkKdTree_GetBoundaryCellList_28(HandleRef pThis, int regionID, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkIdList GetBoundaryCellList(int regionID)
		{
			vtkIdList vtkIdList = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkKdTree.vtkKdTree_GetBoundaryCellList_28(base.GetCppThis(), regionID, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdList = (vtkIdList)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdList.Register(null);
				}
			}
			return vtkIdList;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_GetBounds_29(HandleRef pThis, IntPtr bounds);

		public void GetBounds(IntPtr bounds)
		{
			vtkKdTree.vtkKdTree_GetBounds_29(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkKdTree_GetCellList_30(HandleRef pThis, int regionID, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkIdList GetCellList(int regionID)
		{
			vtkIdList vtkIdList = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkKdTree.vtkKdTree_GetCellList_30(base.GetCppThis(), regionID, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdList = (vtkIdList)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdList.Register(null);
				}
			}
			return vtkIdList;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkKdTree_GetCellLists_31(HandleRef pThis, HandleRef regions, int set, HandleRef inRegionCells, HandleRef onBoundaryCells);

		public long GetCellLists(vtkIntArray regions, int set, vtkIdList inRegionCells, vtkIdList onBoundaryCells)
		{
			return vtkKdTree.vtkKdTree_GetCellLists_31(base.GetCppThis(), (regions == null) ? default(HandleRef) : regions.GetCppThis(), set, (inRegionCells == null) ? default(HandleRef) : inRegionCells.GetCppThis(), (onBoundaryCells == null) ? default(HandleRef) : onBoundaryCells.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkKdTree_GetCellLists_32(HandleRef pThis, HandleRef regions, HandleRef set, HandleRef inRegionCells, HandleRef onBoundaryCells);

		public long GetCellLists(vtkIntArray regions, vtkDataSet set, vtkIdList inRegionCells, vtkIdList onBoundaryCells)
		{
			return vtkKdTree.vtkKdTree_GetCellLists_32(base.GetCppThis(), (regions == null) ? default(HandleRef) : regions.GetCppThis(), (set == null) ? default(HandleRef) : set.GetCppThis(), (inRegionCells == null) ? default(HandleRef) : inRegionCells.GetCppThis(), (onBoundaryCells == null) ? default(HandleRef) : onBoundaryCells.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkKdTree_GetCellLists_33(HandleRef pThis, HandleRef regions, HandleRef inRegionCells, HandleRef onBoundaryCells);

		public long GetCellLists(vtkIntArray regions, vtkIdList inRegionCells, vtkIdList onBoundaryCells)
		{
			return vtkKdTree.vtkKdTree_GetCellLists_33(base.GetCppThis(), (regions == null) ? default(HandleRef) : regions.GetCppThis(), (inRegionCells == null) ? default(HandleRef) : inRegionCells.GetCppThis(), (onBoundaryCells == null) ? default(HandleRef) : onBoundaryCells.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkKdTree_GetCuts_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkBSPCuts GetCuts()
		{
			vtkBSPCuts vtkBSPCuts = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkKdTree.vtkKdTree_GetCuts_34(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBSPCuts = (vtkBSPCuts)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBSPCuts.Register(null);
				}
			}
			return vtkBSPCuts;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkKdTree_GetDataSet_35(HandleRef pThis, int n, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataSet GetDataSet(int n)
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkKdTree.vtkKdTree_GetDataSet_35(base.GetCppThis(), n, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkKdTree_GetDataSet_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkDataSet GetDataSet()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkKdTree.vtkKdTree_GetDataSet_36(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkKdTree_GetDataSetIndex_37(HandleRef pThis, HandleRef set);

		public int GetDataSetIndex(vtkDataSet set)
		{
			return vtkKdTree.vtkKdTree_GetDataSetIndex_37(base.GetCppThis(), (set == null) ? default(HandleRef) : set.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkKdTree_GetDataSets_38(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDataSetCollection GetDataSets()
		{
			vtkDataSetCollection vtkDataSetCollection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkKdTree.vtkKdTree_GetDataSets_38(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetCollection = (vtkDataSetCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetCollection.Register(null);
				}
			}
			return vtkDataSetCollection;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkKdTree_GetFudgeFactor_39(HandleRef pThis);

		public virtual double GetFudgeFactor()
		{
			return vtkKdTree.vtkKdTree_GetFudgeFactor_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkKdTree_GetGenerateRepresentationUsingDataBounds_40(HandleRef pThis);

		public virtual int GetGenerateRepresentationUsingDataBounds()
		{
			return vtkKdTree.vtkKdTree_GetGenerateRepresentationUsingDataBounds_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkKdTree_GetIncludeRegionBoundaryCells_41(HandleRef pThis);

		public virtual int GetIncludeRegionBoundaryCells()
		{
			return vtkKdTree.vtkKdTree_GetIncludeRegionBoundaryCells_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkKdTree_GetMinCells_42(HandleRef pThis);

		public virtual int GetMinCells()
		{
			return vtkKdTree.vtkKdTree_GetMinCells_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkKdTree_GetNumberOfDataSets_43(HandleRef pThis);

		public int GetNumberOfDataSets()
		{
			return vtkKdTree.vtkKdTree_GetNumberOfDataSets_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkKdTree_GetNumberOfRegions_44(HandleRef pThis);

		public virtual int GetNumberOfRegions()
		{
			return vtkKdTree.vtkKdTree_GetNumberOfRegions_44(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkKdTree_GetNumberOfRegionsOrLess_45(HandleRef pThis);

		public virtual int GetNumberOfRegionsOrLess()
		{
			return vtkKdTree.vtkKdTree_GetNumberOfRegionsOrLess_45(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkKdTree_GetNumberOfRegionsOrMore_46(HandleRef pThis);

		public virtual int GetNumberOfRegionsOrMore()
		{
			return vtkKdTree.vtkKdTree_GetNumberOfRegionsOrMore_46(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkKdTree_GetPointsInRegion_47(HandleRef pThis, int regionId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkIdTypeArray GetPointsInRegion(int regionId)
		{
			vtkIdTypeArray vtkIdTypeArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkKdTree.vtkKdTree_GetPointsInRegion_47(base.GetCppThis(), regionId, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdTypeArray = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdTypeArray.Register(null);
				}
			}
			return vtkIdTypeArray;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_GetRegionBounds_48(HandleRef pThis, int regionID, IntPtr bounds);

		public void GetRegionBounds(int regionID, IntPtr bounds)
		{
			vtkKdTree.vtkKdTree_GetRegionBounds_48(base.GetCppThis(), regionID, bounds);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkKdTree_GetRegionContainingCell_49(HandleRef pThis, HandleRef set, long cellID);

		public int GetRegionContainingCell(vtkDataSet set, long cellID)
		{
			return vtkKdTree.vtkKdTree_GetRegionContainingCell_49(base.GetCppThis(), (set == null) ? default(HandleRef) : set.GetCppThis(), cellID);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkKdTree_GetRegionContainingCell_50(HandleRef pThis, int set, long cellID);

		public int GetRegionContainingCell(int set, long cellID)
		{
			return vtkKdTree.vtkKdTree_GetRegionContainingCell_50(base.GetCppThis(), set, cellID);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkKdTree_GetRegionContainingCell_51(HandleRef pThis, long cellID);

		public int GetRegionContainingCell(long cellID)
		{
			return vtkKdTree.vtkKdTree_GetRegionContainingCell_51(base.GetCppThis(), cellID);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkKdTree_GetRegionContainingPoint_52(HandleRef pThis, double x, double y, double z);

		public int GetRegionContainingPoint(double x, double y, double z)
		{
			return vtkKdTree.vtkKdTree_GetRegionContainingPoint_52(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_GetRegionDataBounds_53(HandleRef pThis, int regionID, IntPtr bounds);

		public void GetRegionDataBounds(int regionID, IntPtr bounds)
		{
			vtkKdTree.vtkKdTree_GetRegionDataBounds_53(base.GetCppThis(), regionID, bounds);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkKdTree_GetTiming_54(HandleRef pThis);

		public virtual int GetTiming()
		{
			return vtkKdTree.vtkKdTree_GetTiming_54(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_IncludeRegionBoundaryCellsOff_55(HandleRef pThis);

		public virtual void IncludeRegionBoundaryCellsOff()
		{
			vtkKdTree.vtkKdTree_IncludeRegionBoundaryCellsOff_55(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_IncludeRegionBoundaryCellsOn_56(HandleRef pThis);

		public virtual void IncludeRegionBoundaryCellsOn()
		{
			vtkKdTree.vtkKdTree_IncludeRegionBoundaryCellsOn_56(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_InvalidateGeometry_57(HandleRef pThis);

		public virtual void InvalidateGeometry()
		{
			vtkKdTree.vtkKdTree_InvalidateGeometry_57(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkKdTree_IsA_58(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkKdTree.vtkKdTree_IsA_58(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkKdTree_IsTypeOf_59(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkKdTree.vtkKdTree_IsTypeOf_59(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkKdTree_NewGeometry_61(HandleRef pThis);

		public virtual int NewGeometry()
		{
			return vtkKdTree.vtkKdTree_NewGeometry_61(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkKdTree_NewInstance_62(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkKdTree NewInstance()
		{
			vtkKdTree result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkKdTree.vtkKdTree_NewInstance_62(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkKdTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_OmitNoPartitioning_63(HandleRef pThis);

		public void OmitNoPartitioning()
		{
			vtkKdTree.vtkKdTree_OmitNoPartitioning_63(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_OmitXPartitioning_64(HandleRef pThis);

		public void OmitXPartitioning()
		{
			vtkKdTree.vtkKdTree_OmitXPartitioning_64(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_OmitXYPartitioning_65(HandleRef pThis);

		public void OmitXYPartitioning()
		{
			vtkKdTree.vtkKdTree_OmitXYPartitioning_65(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_OmitYPartitioning_66(HandleRef pThis);

		public void OmitYPartitioning()
		{
			vtkKdTree.vtkKdTree_OmitYPartitioning_66(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_OmitYZPartitioning_67(HandleRef pThis);

		public void OmitYZPartitioning()
		{
			vtkKdTree.vtkKdTree_OmitYZPartitioning_67(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_OmitZPartitioning_68(HandleRef pThis);

		public void OmitZPartitioning()
		{
			vtkKdTree.vtkKdTree_OmitZPartitioning_68(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_OmitZXPartitioning_69(HandleRef pThis);

		public void OmitZXPartitioning()
		{
			vtkKdTree.vtkKdTree_OmitZXPartitioning_69(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_PrintRegion_70(HandleRef pThis, int id);

		public void PrintRegion(int id)
		{
			vtkKdTree.vtkKdTree_PrintRegion_70(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_PrintTree_71(HandleRef pThis);

		public void PrintTree()
		{
			vtkKdTree.vtkKdTree_PrintTree_71(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_PrintVerboseTree_72(HandleRef pThis);

		public void PrintVerboseTree()
		{
			vtkKdTree.vtkKdTree_PrintVerboseTree_72(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_RemoveAllDataSets_73(HandleRef pThis);

		public virtual void RemoveAllDataSets()
		{
			vtkKdTree.vtkKdTree_RemoveAllDataSets_73(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_RemoveDataSet_74(HandleRef pThis, int index);

		public virtual void RemoveDataSet(int index)
		{
			vtkKdTree.vtkKdTree_RemoveDataSet_74(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_RemoveDataSet_75(HandleRef pThis, HandleRef set);

		public virtual void RemoveDataSet(vtkDataSet set)
		{
			vtkKdTree.vtkKdTree_RemoveDataSet_75(base.GetCppThis(), (set == null) ? default(HandleRef) : set.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkKdTree_SafeDownCast_76(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkKdTree SafeDownCast(vtkObjectBase o)
		{
			vtkKdTree vtkKdTree = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkKdTree.vtkKdTree_SafeDownCast_76((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkKdTree = (vtkKdTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkKdTree.Register(null);
				}
			}
			return vtkKdTree;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_SetCuts_77(HandleRef pThis, HandleRef cuts);

		public void SetCuts(vtkBSPCuts cuts)
		{
			vtkKdTree.vtkKdTree_SetCuts_77(base.GetCppThis(), (cuts == null) ? default(HandleRef) : cuts.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_SetDataSet_78(HandleRef pThis, HandleRef set);

		public override void SetDataSet(vtkDataSet set)
		{
			vtkKdTree.vtkKdTree_SetDataSet_78(base.GetCppThis(), (set == null) ? default(HandleRef) : set.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_SetFudgeFactor_79(HandleRef pThis, double _arg);

		public virtual void SetFudgeFactor(double _arg)
		{
			vtkKdTree.vtkKdTree_SetFudgeFactor_79(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_SetGenerateRepresentationUsingDataBounds_80(HandleRef pThis, int _arg);

		public virtual void SetGenerateRepresentationUsingDataBounds(int _arg)
		{
			vtkKdTree.vtkKdTree_SetGenerateRepresentationUsingDataBounds_80(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_SetIncludeRegionBoundaryCells_81(HandleRef pThis, int _arg);

		public virtual void SetIncludeRegionBoundaryCells(int _arg)
		{
			vtkKdTree.vtkKdTree_SetIncludeRegionBoundaryCells_81(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_SetMinCells_82(HandleRef pThis, int _arg);

		public virtual void SetMinCells(int _arg)
		{
			vtkKdTree.vtkKdTree_SetMinCells_82(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_SetNewBounds_83(HandleRef pThis, IntPtr bounds);

		public void SetNewBounds(IntPtr bounds)
		{
			vtkKdTree.vtkKdTree_SetNewBounds_83(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_SetNumberOfRegionsOrLess_84(HandleRef pThis, int _arg);

		public virtual void SetNumberOfRegionsOrLess(int _arg)
		{
			vtkKdTree.vtkKdTree_SetNumberOfRegionsOrLess_84(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_SetNumberOfRegionsOrMore_85(HandleRef pThis, int _arg);

		public virtual void SetNumberOfRegionsOrMore(int _arg)
		{
			vtkKdTree.vtkKdTree_SetNumberOfRegionsOrMore_85(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_SetTiming_86(HandleRef pThis, int _arg);

		public virtual void SetTiming(int _arg)
		{
			vtkKdTree.vtkKdTree_SetTiming_86(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_TimingOff_87(HandleRef pThis);

		public virtual void TimingOff()
		{
			vtkKdTree.vtkKdTree_TimingOff_87(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkKdTree_TimingOn_88(HandleRef pThis);

		public virtual void TimingOn()
		{
			vtkKdTree.vtkKdTree_TimingOn_88(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkKdTree_ViewOrderAllRegionsFromPosition_89(HandleRef pThis, IntPtr directionOfProjection, HandleRef orderedList);

		public int ViewOrderAllRegionsFromPosition(IntPtr directionOfProjection, vtkIntArray orderedList)
		{
			return vtkKdTree.vtkKdTree_ViewOrderAllRegionsFromPosition_89(base.GetCppThis(), directionOfProjection, (orderedList == null) ? default(HandleRef) : orderedList.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkKdTree_ViewOrderAllRegionsInDirection_90(HandleRef pThis, IntPtr directionOfProjection, HandleRef orderedList);

		public int ViewOrderAllRegionsInDirection(IntPtr directionOfProjection, vtkIntArray orderedList)
		{
			return vtkKdTree.vtkKdTree_ViewOrderAllRegionsInDirection_90(base.GetCppThis(), directionOfProjection, (orderedList == null) ? default(HandleRef) : orderedList.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkKdTree_ViewOrderRegionsFromPosition_91(HandleRef pThis, HandleRef regionIds, IntPtr directionOfProjection, HandleRef orderedList);

		public int ViewOrderRegionsFromPosition(vtkIntArray regionIds, IntPtr directionOfProjection, vtkIntArray orderedList)
		{
			return vtkKdTree.vtkKdTree_ViewOrderRegionsFromPosition_91(base.GetCppThis(), (regionIds == null) ? default(HandleRef) : regionIds.GetCppThis(), directionOfProjection, (orderedList == null) ? default(HandleRef) : orderedList.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkKdTree_ViewOrderRegionsInDirection_92(HandleRef pThis, HandleRef regionIds, IntPtr directionOfProjection, HandleRef orderedList);

		public int ViewOrderRegionsInDirection(vtkIntArray regionIds, IntPtr directionOfProjection, vtkIntArray orderedList)
		{
			return vtkKdTree.vtkKdTree_ViewOrderRegionsInDirection_92(base.GetCppThis(), (regionIds == null) ? default(HandleRef) : regionIds.GetCppThis(), directionOfProjection, (orderedList == null) ? default(HandleRef) : orderedList.GetCppThis());
		}
	}
}
