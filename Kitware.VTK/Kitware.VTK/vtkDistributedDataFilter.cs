using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDistributedDataFilter : vtkDataObjectAlgorithm
	{
		public enum BoundaryModes
		{
			ASSIGN_TO_ALL_INTERSECTING_REGIONS = 1,
			ASSIGN_TO_ONE_REGION = 0,
			SPLIT_BOUNDARY_CELLS = 2
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkDistributedDataFilter";

		public new static readonly string MRClassNameKey;

		static vtkDistributedDataFilter()
		{
			vtkDistributedDataFilter.MRClassNameKey = "class vtkDistributedDataFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDistributedDataFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDistributedDataFilter"));
		}

		public vtkDistributedDataFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkDistributedDataFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDistributedDataFilter New()
		{
			vtkDistributedDataFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDistributedDataFilter.vtkDistributedDataFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDistributedDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDistributedDataFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDistributedDataFilter.vtkDistributedDataFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkDistributedDataFilter_ClipCellsOff_01(HandleRef pThis);

		public virtual void ClipCellsOff()
		{
			vtkDistributedDataFilter.vtkDistributedDataFilter_ClipCellsOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkDistributedDataFilter_ClipCellsOn_02(HandleRef pThis);

		public virtual void ClipCellsOn()
		{
			vtkDistributedDataFilter.vtkDistributedDataFilter_ClipCellsOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkDistributedDataFilter_GetBoundaryMode_03(HandleRef pThis);

		public int GetBoundaryMode()
		{
			return vtkDistributedDataFilter.vtkDistributedDataFilter_GetBoundaryMode_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkDistributedDataFilter_GetClipCells_04(HandleRef pThis);

		public virtual int GetClipCells()
		{
			return vtkDistributedDataFilter.vtkDistributedDataFilter_GetClipCells_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkDistributedDataFilter_GetController_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDistributedDataFilter.vtkDistributedDataFilter_GetController_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkDistributedDataFilter_GetCuts_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkBSPCuts GetCuts()
		{
			vtkBSPCuts vtkBSPCuts = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDistributedDataFilter.vtkDistributedDataFilter_GetCuts_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkDistributedDataFilter_GetIncludeAllIntersectingCells_07(HandleRef pThis);

		public virtual int GetIncludeAllIntersectingCells()
		{
			return vtkDistributedDataFilter.vtkDistributedDataFilter_GetIncludeAllIntersectingCells_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkDistributedDataFilter_GetKdtree_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPKdTree GetKdtree()
		{
			vtkPKdTree vtkPKdTree = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDistributedDataFilter.vtkDistributedDataFilter_GetKdtree_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkDistributedDataFilter_GetRetainKdtree_09(HandleRef pThis);

		public virtual int GetRetainKdtree()
		{
			return vtkDistributedDataFilter.vtkDistributedDataFilter_GetRetainKdtree_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkDistributedDataFilter_GetTiming_10(HandleRef pThis);

		public virtual int GetTiming()
		{
			return vtkDistributedDataFilter.vtkDistributedDataFilter_GetTiming_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkDistributedDataFilter_GetUseMinimalMemory_11(HandleRef pThis);

		public virtual int GetUseMinimalMemory()
		{
			return vtkDistributedDataFilter.vtkDistributedDataFilter_GetUseMinimalMemory_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkDistributedDataFilter_IncludeAllIntersectingCellsOff_12(HandleRef pThis);

		public virtual void IncludeAllIntersectingCellsOff()
		{
			vtkDistributedDataFilter.vtkDistributedDataFilter_IncludeAllIntersectingCellsOff_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkDistributedDataFilter_IncludeAllIntersectingCellsOn_13(HandleRef pThis);

		public virtual void IncludeAllIntersectingCellsOn()
		{
			vtkDistributedDataFilter.vtkDistributedDataFilter_IncludeAllIntersectingCellsOn_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkDistributedDataFilter_IsA_14(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDistributedDataFilter.vtkDistributedDataFilter_IsA_14(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkDistributedDataFilter_IsTypeOf_15(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDistributedDataFilter.vtkDistributedDataFilter_IsTypeOf_15(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkDistributedDataFilter_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDistributedDataFilter NewInstance()
		{
			vtkDistributedDataFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDistributedDataFilter.vtkDistributedDataFilter_NewInstance_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDistributedDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkDistributedDataFilter_RetainKdtreeOff_18(HandleRef pThis);

		public virtual void RetainKdtreeOff()
		{
			vtkDistributedDataFilter.vtkDistributedDataFilter_RetainKdtreeOff_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkDistributedDataFilter_RetainKdtreeOn_19(HandleRef pThis);

		public virtual void RetainKdtreeOn()
		{
			vtkDistributedDataFilter.vtkDistributedDataFilter_RetainKdtreeOn_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkDistributedDataFilter_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDistributedDataFilter SafeDownCast(vtkObjectBase o)
		{
			vtkDistributedDataFilter vtkDistributedDataFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDistributedDataFilter.vtkDistributedDataFilter_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDistributedDataFilter = (vtkDistributedDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDistributedDataFilter.Register(null);
				}
			}
			return vtkDistributedDataFilter;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkDistributedDataFilter_SetBoundaryMode_21(HandleRef pThis, int mode);

		public void SetBoundaryMode(int mode)
		{
			vtkDistributedDataFilter.vtkDistributedDataFilter_SetBoundaryMode_21(base.GetCppThis(), mode);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkDistributedDataFilter_SetBoundaryModeToAssignToAllIntersectingRegions_22(HandleRef pThis);

		public void SetBoundaryModeToAssignToAllIntersectingRegions()
		{
			vtkDistributedDataFilter.vtkDistributedDataFilter_SetBoundaryModeToAssignToAllIntersectingRegions_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkDistributedDataFilter_SetBoundaryModeToAssignToOneRegion_23(HandleRef pThis);

		public void SetBoundaryModeToAssignToOneRegion()
		{
			vtkDistributedDataFilter.vtkDistributedDataFilter_SetBoundaryModeToAssignToOneRegion_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkDistributedDataFilter_SetBoundaryModeToSplitBoundaryCells_24(HandleRef pThis);

		public void SetBoundaryModeToSplitBoundaryCells()
		{
			vtkDistributedDataFilter.vtkDistributedDataFilter_SetBoundaryModeToSplitBoundaryCells_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkDistributedDataFilter_SetClipCells_25(HandleRef pThis, int _arg);

		public virtual void SetClipCells(int _arg)
		{
			vtkDistributedDataFilter.vtkDistributedDataFilter_SetClipCells_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkDistributedDataFilter_SetController_26(HandleRef pThis, HandleRef c);

		public void SetController(vtkMultiProcessController c)
		{
			vtkDistributedDataFilter.vtkDistributedDataFilter_SetController_26(base.GetCppThis(), (c == null) ? default(HandleRef) : c.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkDistributedDataFilter_SetCuts_27(HandleRef pThis, HandleRef cuts);

		public void SetCuts(vtkBSPCuts cuts)
		{
			vtkDistributedDataFilter.vtkDistributedDataFilter_SetCuts_27(base.GetCppThis(), (cuts == null) ? default(HandleRef) : cuts.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkDistributedDataFilter_SetIncludeAllIntersectingCells_28(HandleRef pThis, int _arg);

		public virtual void SetIncludeAllIntersectingCells(int _arg)
		{
			vtkDistributedDataFilter.vtkDistributedDataFilter_SetIncludeAllIntersectingCells_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkDistributedDataFilter_SetRetainKdtree_29(HandleRef pThis, int _arg);

		public virtual void SetRetainKdtree(int _arg)
		{
			vtkDistributedDataFilter.vtkDistributedDataFilter_SetRetainKdtree_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkDistributedDataFilter_SetTiming_30(HandleRef pThis, int _arg);

		public virtual void SetTiming(int _arg)
		{
			vtkDistributedDataFilter.vtkDistributedDataFilter_SetTiming_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkDistributedDataFilter_SetUseMinimalMemory_31(HandleRef pThis, int _arg);

		public virtual void SetUseMinimalMemory(int _arg)
		{
			vtkDistributedDataFilter.vtkDistributedDataFilter_SetUseMinimalMemory_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkDistributedDataFilter_SetUserRegionAssignments_32(HandleRef pThis, IntPtr map, int numRegions);

		public void SetUserRegionAssignments(IntPtr map, int numRegions)
		{
			vtkDistributedDataFilter.vtkDistributedDataFilter_SetUserRegionAssignments_32(base.GetCppThis(), map, numRegions);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkDistributedDataFilter_TimingOff_33(HandleRef pThis);

		public virtual void TimingOff()
		{
			vtkDistributedDataFilter.vtkDistributedDataFilter_TimingOff_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkDistributedDataFilter_TimingOn_34(HandleRef pThis);

		public virtual void TimingOn()
		{
			vtkDistributedDataFilter.vtkDistributedDataFilter_TimingOn_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkDistributedDataFilter_UseMinimalMemoryOff_35(HandleRef pThis);

		public virtual void UseMinimalMemoryOff()
		{
			vtkDistributedDataFilter.vtkDistributedDataFilter_UseMinimalMemoryOff_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkDistributedDataFilter_UseMinimalMemoryOn_36(HandleRef pThis);

		public virtual void UseMinimalMemoryOn()
		{
			vtkDistributedDataFilter.vtkDistributedDataFilter_UseMinimalMemoryOn_36(base.GetCppThis());
		}
	}
}
