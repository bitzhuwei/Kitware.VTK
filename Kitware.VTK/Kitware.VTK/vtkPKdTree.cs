using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPKdTree : vtkKdTree
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPKdTree";

		public new static readonly string MRClassNameKey;

		static vtkPKdTree()
		{
			vtkPKdTree.MRClassNameKey = "class vtkPKdTree";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPKdTree.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPKdTree"));
		}

		public vtkPKdTree(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPKdTree_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPKdTree New()
		{
			vtkPKdTree result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPKdTree.vtkPKdTree_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPKdTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPKdTree() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPKdTree.vtkPKdTree_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPKdTree_AssignRegions_01(HandleRef pThis, IntPtr map, int numRegions);

		public int AssignRegions(IntPtr map, int numRegions)
		{
			return vtkPKdTree.vtkPKdTree_AssignRegions_01(base.GetCppThis(), map, numRegions);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPKdTree_AssignRegionsContiguous_02(HandleRef pThis);

		public int AssignRegionsContiguous()
		{
			return vtkPKdTree.vtkPKdTree_AssignRegionsContiguous_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPKdTree_AssignRegionsRoundRobin_03(HandleRef pThis);

		public int AssignRegionsRoundRobin()
		{
			return vtkPKdTree.vtkPKdTree_AssignRegionsRoundRobin_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPKdTree_BuildLocator_04(HandleRef pThis);

		public override void BuildLocator()
		{
			vtkPKdTree.vtkPKdTree_BuildLocator_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPKdTree_CreateGlobalDataArrayBounds_05(HandleRef pThis);

		public int CreateGlobalDataArrayBounds()
		{
			return vtkPKdTree.vtkPKdTree_CreateGlobalDataArrayBounds_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPKdTree_CreateProcessCellCountData_06(HandleRef pThis);

		public int CreateProcessCellCountData()
		{
			return vtkPKdTree.vtkPKdTree_CreateProcessCellCountData_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPKdTree_GetAllProcessesBorderingOnPoint_07(HandleRef pThis, float x, float y, float z, HandleRef list);

		public void GetAllProcessesBorderingOnPoint(float x, float y, float z, vtkIntArray list)
		{
			vtkPKdTree.vtkPKdTree_GetAllProcessesBorderingOnPoint_07(base.GetCppThis(), x, y, z, (list == null) ? default(HandleRef) : list.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPKdTree_GetCellArrayGlobalRange_08(HandleRef pThis, string name, IntPtr range);

		public int GetCellArrayGlobalRange(string name, IntPtr range)
		{
			return vtkPKdTree.vtkPKdTree_GetCellArrayGlobalRange_08(base.GetCppThis(), name, range);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPKdTree_GetCellArrayGlobalRange_09(HandleRef pThis, int arrayIndex, IntPtr range);

		public int GetCellArrayGlobalRange(int arrayIndex, IntPtr range)
		{
			return vtkPKdTree.vtkPKdTree_GetCellArrayGlobalRange_09(base.GetCppThis(), arrayIndex, range);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern long vtkPKdTree_GetCellListsForProcessRegions_10(HandleRef pThis, int ProcessId, int set, HandleRef inRegionCells, HandleRef onBoundaryCells);

		public long GetCellListsForProcessRegions(int ProcessId, int set, vtkIdList inRegionCells, vtkIdList onBoundaryCells)
		{
			return vtkPKdTree.vtkPKdTree_GetCellListsForProcessRegions_10(base.GetCppThis(), ProcessId, set, (inRegionCells == null) ? default(HandleRef) : inRegionCells.GetCppThis(), (onBoundaryCells == null) ? default(HandleRef) : onBoundaryCells.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern long vtkPKdTree_GetCellListsForProcessRegions_11(HandleRef pThis, int ProcessId, HandleRef set, HandleRef inRegionCells, HandleRef onBoundaryCells);

		public long GetCellListsForProcessRegions(int ProcessId, vtkDataSet set, vtkIdList inRegionCells, vtkIdList onBoundaryCells)
		{
			return vtkPKdTree.vtkPKdTree_GetCellListsForProcessRegions_11(base.GetCppThis(), ProcessId, (set == null) ? default(HandleRef) : set.GetCppThis(), (inRegionCells == null) ? default(HandleRef) : inRegionCells.GetCppThis(), (onBoundaryCells == null) ? default(HandleRef) : onBoundaryCells.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern long vtkPKdTree_GetCellListsForProcessRegions_12(HandleRef pThis, int ProcessId, HandleRef inRegionCells, HandleRef onBoundaryCells);

		public long GetCellListsForProcessRegions(int ProcessId, vtkIdList inRegionCells, vtkIdList onBoundaryCells)
		{
			return vtkPKdTree.vtkPKdTree_GetCellListsForProcessRegions_12(base.GetCppThis(), ProcessId, (inRegionCells == null) ? default(HandleRef) : inRegionCells.GetCppThis(), (onBoundaryCells == null) ? default(HandleRef) : onBoundaryCells.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPKdTree_GetController_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPKdTree.vtkPKdTree_GetController_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiProcessController = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiProcessController.Register(null);
				}
			}
			return vtkMultiProcessController;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPKdTree_GetPointArrayGlobalRange_14(HandleRef pThis, string name, IntPtr range);

		public int GetPointArrayGlobalRange(string name, IntPtr range)
		{
			return vtkPKdTree.vtkPKdTree_GetPointArrayGlobalRange_14(base.GetCppThis(), name, range);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPKdTree_GetPointArrayGlobalRange_15(HandleRef pThis, int arrayIndex, IntPtr range);

		public int GetPointArrayGlobalRange(int arrayIndex, IntPtr range)
		{
			return vtkPKdTree.vtkPKdTree_GetPointArrayGlobalRange_15(base.GetCppThis(), arrayIndex, range);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPKdTree_GetProcessAssignedToRegion_16(HandleRef pThis, int regionId);

		public int GetProcessAssignedToRegion(int regionId)
		{
			return vtkPKdTree.vtkPKdTree_GetProcessAssignedToRegion_16(base.GetCppThis(), regionId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPKdTree_GetProcessCellCountForRegion_17(HandleRef pThis, int processId, int regionId);

		public int GetProcessCellCountForRegion(int processId, int regionId)
		{
			return vtkPKdTree.vtkPKdTree_GetProcessCellCountForRegion_17(base.GetCppThis(), processId, regionId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPKdTree_GetProcessListForRegion_18(HandleRef pThis, int regionId, HandleRef processes);

		public int GetProcessListForRegion(int regionId, vtkIntArray processes)
		{
			return vtkPKdTree.vtkPKdTree_GetProcessListForRegion_18(base.GetCppThis(), regionId, (processes == null) ? default(HandleRef) : processes.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPKdTree_GetProcessesCellCountForRegion_19(HandleRef pThis, int regionId, IntPtr count, int len);

		public int GetProcessesCellCountForRegion(int regionId, IntPtr count, int len)
		{
			return vtkPKdTree.vtkPKdTree_GetProcessesCellCountForRegion_19(base.GetCppThis(), regionId, count, len);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPKdTree_GetRegionAssignment_20(HandleRef pThis);

		public virtual int GetRegionAssignment()
		{
			return vtkPKdTree.vtkPKdTree_GetRegionAssignment_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPKdTree_GetRegionAssignmentList_21(HandleRef pThis, int procId, HandleRef list);

		public int GetRegionAssignmentList(int procId, vtkIntArray list)
		{
			return vtkPKdTree.vtkPKdTree_GetRegionAssignmentList_21(base.GetCppThis(), procId, (list == null) ? default(HandleRef) : list.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPKdTree_GetRegionAssignmentMap_22(HandleRef pThis);

		public IntPtr GetRegionAssignmentMap()
		{
			return vtkPKdTree.vtkPKdTree_GetRegionAssignmentMap_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPKdTree_GetRegionAssignmentMapLength_23(HandleRef pThis);

		public virtual int GetRegionAssignmentMapLength()
		{
			return vtkPKdTree.vtkPKdTree_GetRegionAssignmentMapLength_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPKdTree_GetRegionListForProcess_24(HandleRef pThis, int processId, HandleRef regions);

		public int GetRegionListForProcess(int processId, vtkIntArray regions)
		{
			return vtkPKdTree.vtkPKdTree_GetRegionListForProcess_24(base.GetCppThis(), processId, (regions == null) ? default(HandleRef) : regions.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPKdTree_GetRegionsCellCountForProcess_25(HandleRef pThis, int ProcessId, IntPtr count, int len);

		public int GetRegionsCellCountForProcess(int ProcessId, IntPtr count, int len)
		{
			return vtkPKdTree.vtkPKdTree_GetRegionsCellCountForProcess_25(base.GetCppThis(), ProcessId, count, len);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern long vtkPKdTree_GetTotalNumberOfCells_26(HandleRef pThis);

		public long GetTotalNumberOfCells()
		{
			return vtkPKdTree.vtkPKdTree_GetTotalNumberOfCells_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPKdTree_GetTotalProcessesInRegion_27(HandleRef pThis, int regionId);

		public int GetTotalProcessesInRegion(int regionId)
		{
			return vtkPKdTree.vtkPKdTree_GetTotalProcessesInRegion_27(base.GetCppThis(), regionId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPKdTree_GetTotalRegionsForProcess_28(HandleRef pThis, int processId);

		public int GetTotalRegionsForProcess(int processId)
		{
			return vtkPKdTree.vtkPKdTree_GetTotalRegionsForProcess_28(base.GetCppThis(), processId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPKdTree_HasData_29(HandleRef pThis, int processId, int regionId);

		public int HasData(int processId, int regionId)
		{
			return vtkPKdTree.vtkPKdTree_HasData_29(base.GetCppThis(), processId, regionId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPKdTree_IsA_30(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPKdTree.vtkPKdTree_IsA_30(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPKdTree_IsTypeOf_31(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPKdTree.vtkPKdTree_IsTypeOf_31(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPKdTree_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPKdTree NewInstance()
		{
			vtkPKdTree result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPKdTree.vtkPKdTree_NewInstance_33(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPKdTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPKdTree_SafeDownCast_34(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPKdTree SafeDownCast(vtkObjectBase o)
		{
			vtkPKdTree vtkPKdTree = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPKdTree.vtkPKdTree_SafeDownCast_34((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPKdTree = (vtkPKdTree)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPKdTree.Register(null);
				}
			}
			return vtkPKdTree;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPKdTree_SetController_35(HandleRef pThis, HandleRef c);

		public void SetController(vtkMultiProcessController c)
		{
			vtkPKdTree.vtkPKdTree_SetController_35(base.GetCppThis(), (c == null) ? default(HandleRef) : c.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPKdTree_ViewOrderAllProcessesFromPosition_36(HandleRef pThis, IntPtr cameraPosition, HandleRef orderedList);

		public int ViewOrderAllProcessesFromPosition(IntPtr cameraPosition, vtkIntArray orderedList)
		{
			return vtkPKdTree.vtkPKdTree_ViewOrderAllProcessesFromPosition_36(base.GetCppThis(), cameraPosition, (orderedList == null) ? default(HandleRef) : orderedList.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPKdTree_ViewOrderAllProcessesInDirection_37(HandleRef pThis, IntPtr directionOfProjection, HandleRef orderedList);

		public int ViewOrderAllProcessesInDirection(IntPtr directionOfProjection, vtkIntArray orderedList)
		{
			return vtkPKdTree.vtkPKdTree_ViewOrderAllProcessesInDirection_37(base.GetCppThis(), directionOfProjection, (orderedList == null) ? default(HandleRef) : orderedList.GetCppThis());
		}
	}
}
