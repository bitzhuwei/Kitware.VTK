using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkAbstractCellLocator : vtkLocator
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractCellLocator";

		public new static readonly string MRClassNameKey;

		static vtkAbstractCellLocator()
		{
			vtkAbstractCellLocator.MRClassNameKey = "class vtkAbstractCellLocator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAbstractCellLocator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractCellLocator"));
		}

		public vtkAbstractCellLocator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAbstractCellLocator_CacheCellBoundsOff_01(HandleRef pThis);

		public virtual void CacheCellBoundsOff()
		{
			vtkAbstractCellLocator.vtkAbstractCellLocator_CacheCellBoundsOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAbstractCellLocator_CacheCellBoundsOn_02(HandleRef pThis);

		public virtual void CacheCellBoundsOn()
		{
			vtkAbstractCellLocator.vtkAbstractCellLocator_CacheCellBoundsOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkAbstractCellLocator_FindCell_03(HandleRef pThis, IntPtr x);

		public virtual long FindCell(IntPtr x)
		{
			return vtkAbstractCellLocator.vtkAbstractCellLocator_FindCell_03(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkAbstractCellLocator_FindCell_04(HandleRef pThis, IntPtr x, double tol2, HandleRef GenCell, IntPtr pcoords, IntPtr weights);

		public virtual long FindCell(IntPtr x, double tol2, vtkGenericCell GenCell, IntPtr pcoords, IntPtr weights)
		{
			return vtkAbstractCellLocator.vtkAbstractCellLocator_FindCell_04(base.GetCppThis(), x, tol2, (GenCell == null) ? default(HandleRef) : GenCell.GetCppThis(), pcoords, weights);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAbstractCellLocator_FindCellsAlongLine_05(HandleRef pThis, IntPtr p1, IntPtr p2, double tolerance, HandleRef cells);

		public virtual void FindCellsAlongLine(IntPtr p1, IntPtr p2, double tolerance, vtkIdList cells)
		{
			vtkAbstractCellLocator.vtkAbstractCellLocator_FindCellsAlongLine_05(base.GetCppThis(), p1, p2, tolerance, (cells == null) ? default(HandleRef) : cells.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAbstractCellLocator_FindCellsWithinBounds_06(HandleRef pThis, IntPtr bbox, HandleRef cells);

		public virtual void FindCellsWithinBounds(IntPtr bbox, vtkIdList cells)
		{
			vtkAbstractCellLocator.vtkAbstractCellLocator_FindCellsWithinBounds_06(base.GetCppThis(), bbox, (cells == null) ? default(HandleRef) : cells.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAbstractCellLocator_FindClosestPoint_07(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref long cellId, ref int subId, ref double dist2);

		public virtual void FindClosestPoint(IntPtr x, IntPtr closestPoint, ref long cellId, ref int subId, ref double dist2)
		{
			vtkAbstractCellLocator.vtkAbstractCellLocator_FindClosestPoint_07(base.GetCppThis(), x, closestPoint, ref cellId, ref subId, ref dist2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAbstractCellLocator_FindClosestPoint_08(HandleRef pThis, IntPtr x, IntPtr closestPoint, HandleRef cell, ref long cellId, ref int subId, ref double dist2);

		public virtual void FindClosestPoint(IntPtr x, IntPtr closestPoint, vtkGenericCell cell, ref long cellId, ref int subId, ref double dist2)
		{
			vtkAbstractCellLocator.vtkAbstractCellLocator_FindClosestPoint_08(base.GetCppThis(), x, closestPoint, (cell == null) ? default(HandleRef) : cell.GetCppThis(), ref cellId, ref subId, ref dist2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkAbstractCellLocator_FindClosestPointWithinRadius_09(HandleRef pThis, IntPtr x, double radius, IntPtr closestPoint, ref long cellId, ref int subId, ref double dist2);

		public virtual long FindClosestPointWithinRadius(IntPtr x, double radius, IntPtr closestPoint, ref long cellId, ref int subId, ref double dist2)
		{
			return vtkAbstractCellLocator.vtkAbstractCellLocator_FindClosestPointWithinRadius_09(base.GetCppThis(), x, radius, closestPoint, ref cellId, ref subId, ref dist2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkAbstractCellLocator_FindClosestPointWithinRadius_10(HandleRef pThis, IntPtr x, double radius, IntPtr closestPoint, HandleRef cell, ref long cellId, ref int subId, ref double dist2);

		public virtual long FindClosestPointWithinRadius(IntPtr x, double radius, IntPtr closestPoint, vtkGenericCell cell, ref long cellId, ref int subId, ref double dist2)
		{
			return vtkAbstractCellLocator.vtkAbstractCellLocator_FindClosestPointWithinRadius_10(base.GetCppThis(), x, radius, closestPoint, (cell == null) ? default(HandleRef) : cell.GetCppThis(), ref cellId, ref subId, ref dist2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkAbstractCellLocator_FindClosestPointWithinRadius_11(HandleRef pThis, IntPtr x, double radius, IntPtr closestPoint, HandleRef cell, ref long cellId, ref int subId, ref double dist2, ref int inside);

		public virtual long FindClosestPointWithinRadius(IntPtr x, double radius, IntPtr closestPoint, vtkGenericCell cell, ref long cellId, ref int subId, ref double dist2, ref int inside)
		{
			return vtkAbstractCellLocator.vtkAbstractCellLocator_FindClosestPointWithinRadius_11(base.GetCppThis(), x, radius, closestPoint, (cell == null) ? default(HandleRef) : cell.GetCppThis(), ref cellId, ref subId, ref dist2, ref inside);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAbstractCellLocator_GetCacheCellBounds_12(HandleRef pThis);

		public virtual int GetCacheCellBounds()
		{
			return vtkAbstractCellLocator.vtkAbstractCellLocator_GetCacheCellBounds_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAbstractCellLocator_GetLazyEvaluation_13(HandleRef pThis);

		public virtual int GetLazyEvaluation()
		{
			return vtkAbstractCellLocator.vtkAbstractCellLocator_GetLazyEvaluation_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAbstractCellLocator_GetNumberOfCellsPerNode_14(HandleRef pThis);

		public virtual int GetNumberOfCellsPerNode()
		{
			return vtkAbstractCellLocator.vtkAbstractCellLocator_GetNumberOfCellsPerNode_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAbstractCellLocator_GetNumberOfCellsPerNodeMaxValue_15(HandleRef pThis);

		public virtual int GetNumberOfCellsPerNodeMaxValue()
		{
			return vtkAbstractCellLocator.vtkAbstractCellLocator_GetNumberOfCellsPerNodeMaxValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAbstractCellLocator_GetNumberOfCellsPerNodeMinValue_16(HandleRef pThis);

		public virtual int GetNumberOfCellsPerNodeMinValue()
		{
			return vtkAbstractCellLocator.vtkAbstractCellLocator_GetNumberOfCellsPerNodeMinValue_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAbstractCellLocator_GetRetainCellLists_17(HandleRef pThis);

		public virtual int GetRetainCellLists()
		{
			return vtkAbstractCellLocator.vtkAbstractCellLocator_GetRetainCellLists_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAbstractCellLocator_GetUseExistingSearchStructure_18(HandleRef pThis);

		public virtual int GetUseExistingSearchStructure()
		{
			return vtkAbstractCellLocator.vtkAbstractCellLocator_GetUseExistingSearchStructure_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern byte vtkAbstractCellLocator_InsideCellBounds_19(HandleRef pThis, IntPtr x, long cell_ID);

		public virtual bool InsideCellBounds(IntPtr x, long cell_ID)
		{
			return vtkAbstractCellLocator.vtkAbstractCellLocator_InsideCellBounds_19(base.GetCppThis(), x, cell_ID) != 0;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAbstractCellLocator_IntersectWithLine_20(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		public virtual int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkAbstractCellLocator.vtkAbstractCellLocator_IntersectWithLine_20(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAbstractCellLocator_IntersectWithLine_21(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId);

		public virtual int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId)
		{
			return vtkAbstractCellLocator.vtkAbstractCellLocator_IntersectWithLine_21(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId, ref cellId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAbstractCellLocator_IntersectWithLine_22(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId, HandleRef cell);

		public virtual int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId, vtkGenericCell cell)
		{
			return vtkAbstractCellLocator.vtkAbstractCellLocator_IntersectWithLine_22(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId, ref cellId, (cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAbstractCellLocator_IntersectWithLine_23(HandleRef pThis, IntPtr p1, IntPtr p2, HandleRef points, HandleRef cellIds);

		public virtual int IntersectWithLine(IntPtr p1, IntPtr p2, vtkPoints points, vtkIdList cellIds)
		{
			return vtkAbstractCellLocator.vtkAbstractCellLocator_IntersectWithLine_23(base.GetCppThis(), p1, p2, (points == null) ? default(HandleRef) : points.GetCppThis(), (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAbstractCellLocator_IsA_24(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAbstractCellLocator.vtkAbstractCellLocator_IsA_24(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAbstractCellLocator_IsTypeOf_25(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAbstractCellLocator.vtkAbstractCellLocator_IsTypeOf_25(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAbstractCellLocator_LazyEvaluationOff_26(HandleRef pThis);

		public virtual void LazyEvaluationOff()
		{
			vtkAbstractCellLocator.vtkAbstractCellLocator_LazyEvaluationOff_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAbstractCellLocator_LazyEvaluationOn_27(HandleRef pThis);

		public virtual void LazyEvaluationOn()
		{
			vtkAbstractCellLocator.vtkAbstractCellLocator_LazyEvaluationOn_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractCellLocator_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAbstractCellLocator NewInstance()
		{
			vtkAbstractCellLocator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractCellLocator.vtkAbstractCellLocator_NewInstance_28(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractCellLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAbstractCellLocator_RetainCellListsOff_29(HandleRef pThis);

		public virtual void RetainCellListsOff()
		{
			vtkAbstractCellLocator.vtkAbstractCellLocator_RetainCellListsOff_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAbstractCellLocator_RetainCellListsOn_30(HandleRef pThis);

		public virtual void RetainCellListsOn()
		{
			vtkAbstractCellLocator.vtkAbstractCellLocator_RetainCellListsOn_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractCellLocator_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAbstractCellLocator SafeDownCast(vtkObjectBase o)
		{
			vtkAbstractCellLocator vtkAbstractCellLocator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractCellLocator.vtkAbstractCellLocator_SafeDownCast_31((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractCellLocator = (vtkAbstractCellLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractCellLocator.Register(null);
				}
			}
			return vtkAbstractCellLocator;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAbstractCellLocator_SetCacheCellBounds_32(HandleRef pThis, int _arg);

		public virtual void SetCacheCellBounds(int _arg)
		{
			vtkAbstractCellLocator.vtkAbstractCellLocator_SetCacheCellBounds_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAbstractCellLocator_SetLazyEvaluation_33(HandleRef pThis, int _arg);

		public virtual void SetLazyEvaluation(int _arg)
		{
			vtkAbstractCellLocator.vtkAbstractCellLocator_SetLazyEvaluation_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAbstractCellLocator_SetNumberOfCellsPerNode_34(HandleRef pThis, int _arg);

		public virtual void SetNumberOfCellsPerNode(int _arg)
		{
			vtkAbstractCellLocator.vtkAbstractCellLocator_SetNumberOfCellsPerNode_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAbstractCellLocator_SetRetainCellLists_35(HandleRef pThis, int _arg);

		public virtual void SetRetainCellLists(int _arg)
		{
			vtkAbstractCellLocator.vtkAbstractCellLocator_SetRetainCellLists_35(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAbstractCellLocator_SetUseExistingSearchStructure_36(HandleRef pThis, int _arg);

		public virtual void SetUseExistingSearchStructure(int _arg)
		{
			vtkAbstractCellLocator.vtkAbstractCellLocator_SetUseExistingSearchStructure_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAbstractCellLocator_UseExistingSearchStructureOff_37(HandleRef pThis);

		public virtual void UseExistingSearchStructureOff()
		{
			vtkAbstractCellLocator.vtkAbstractCellLocator_UseExistingSearchStructureOff_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAbstractCellLocator_UseExistingSearchStructureOn_38(HandleRef pThis);

		public virtual void UseExistingSearchStructureOn()
		{
			vtkAbstractCellLocator.vtkAbstractCellLocator_UseExistingSearchStructureOn_38(base.GetCppThis());
		}
	}
}
