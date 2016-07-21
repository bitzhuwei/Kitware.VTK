using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCellLocator : vtkAbstractCellLocator
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellLocator";

		public new static readonly string MRClassNameKey;

		static vtkCellLocator()
		{
			vtkCellLocator.MRClassNameKey = "class vtkCellLocator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellLocator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellLocator"));
		}

		public vtkCellLocator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCellLocator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCellLocator New()
		{
			vtkCellLocator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCellLocator.vtkCellLocator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCellLocator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCellLocator.vtkCellLocator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCellLocator_BuildLocator_01(HandleRef pThis);

		public override void BuildLocator()
		{
			vtkCellLocator.vtkCellLocator_BuildLocator_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCellLocator_BuildLocatorIfNeeded_02(HandleRef pThis);

		public virtual void BuildLocatorIfNeeded()
		{
			vtkCellLocator.vtkCellLocator_BuildLocatorIfNeeded_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCellLocator_BuildLocatorInternal_03(HandleRef pThis);

		public virtual void BuildLocatorInternal()
		{
			vtkCellLocator.vtkCellLocator_BuildLocatorInternal_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkCellLocator_FindCell_04(HandleRef pThis, IntPtr x);

		public override long FindCell(IntPtr x)
		{
			return vtkCellLocator.vtkCellLocator_FindCell_04(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkCellLocator_FindCell_05(HandleRef pThis, IntPtr x, double tol2, HandleRef GenCell, IntPtr pcoords, IntPtr weights);

		public override long FindCell(IntPtr x, double tol2, vtkGenericCell GenCell, IntPtr pcoords, IntPtr weights)
		{
			return vtkCellLocator.vtkCellLocator_FindCell_05(base.GetCppThis(), x, tol2, (GenCell == null) ? default(HandleRef) : GenCell.GetCppThis(), pcoords, weights);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCellLocator_FindCellsAlongLine_06(HandleRef pThis, IntPtr p1, IntPtr p2, double tolerance, HandleRef cells);

		public override void FindCellsAlongLine(IntPtr p1, IntPtr p2, double tolerance, vtkIdList cells)
		{
			vtkCellLocator.vtkCellLocator_FindCellsAlongLine_06(base.GetCppThis(), p1, p2, tolerance, (cells == null) ? default(HandleRef) : cells.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCellLocator_FindCellsWithinBounds_07(HandleRef pThis, IntPtr bbox, HandleRef cells);

		public override void FindCellsWithinBounds(IntPtr bbox, vtkIdList cells)
		{
			vtkCellLocator.vtkCellLocator_FindCellsWithinBounds_07(base.GetCppThis(), bbox, (cells == null) ? default(HandleRef) : cells.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCellLocator_FindClosestPoint_08(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref long cellId, ref int subId, ref double dist2);

		public override void FindClosestPoint(IntPtr x, IntPtr closestPoint, ref long cellId, ref int subId, ref double dist2)
		{
			vtkCellLocator.vtkCellLocator_FindClosestPoint_08(base.GetCppThis(), x, closestPoint, ref cellId, ref subId, ref dist2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCellLocator_FindClosestPoint_09(HandleRef pThis, IntPtr x, IntPtr closestPoint, HandleRef cell, ref long cellId, ref int subId, ref double dist2);

		public override void FindClosestPoint(IntPtr x, IntPtr closestPoint, vtkGenericCell cell, ref long cellId, ref int subId, ref double dist2)
		{
			vtkCellLocator.vtkCellLocator_FindClosestPoint_09(base.GetCppThis(), x, closestPoint, (cell == null) ? default(HandleRef) : cell.GetCppThis(), ref cellId, ref subId, ref dist2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkCellLocator_FindClosestPointWithinRadius_10(HandleRef pThis, IntPtr x, double radius, IntPtr closestPoint, ref long cellId, ref int subId, ref double dist2);

		public override long FindClosestPointWithinRadius(IntPtr x, double radius, IntPtr closestPoint, ref long cellId, ref int subId, ref double dist2)
		{
			return vtkCellLocator.vtkCellLocator_FindClosestPointWithinRadius_10(base.GetCppThis(), x, radius, closestPoint, ref cellId, ref subId, ref dist2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkCellLocator_FindClosestPointWithinRadius_11(HandleRef pThis, IntPtr x, double radius, IntPtr closestPoint, HandleRef cell, ref long cellId, ref int subId, ref double dist2);

		public override long FindClosestPointWithinRadius(IntPtr x, double radius, IntPtr closestPoint, vtkGenericCell cell, ref long cellId, ref int subId, ref double dist2)
		{
			return vtkCellLocator.vtkCellLocator_FindClosestPointWithinRadius_11(base.GetCppThis(), x, radius, closestPoint, (cell == null) ? default(HandleRef) : cell.GetCppThis(), ref cellId, ref subId, ref dist2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkCellLocator_FindClosestPointWithinRadius_12(HandleRef pThis, IntPtr x, double radius, IntPtr closestPoint, HandleRef cell, ref long cellId, ref int subId, ref double dist2, ref int inside);

		public override long FindClosestPointWithinRadius(IntPtr x, double radius, IntPtr closestPoint, vtkGenericCell cell, ref long cellId, ref int subId, ref double dist2, ref int inside)
		{
			return vtkCellLocator.vtkCellLocator_FindClosestPointWithinRadius_12(base.GetCppThis(), x, radius, closestPoint, (cell == null) ? default(HandleRef) : cell.GetCppThis(), ref cellId, ref subId, ref dist2, ref inside);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCellLocator_ForceBuildLocator_13(HandleRef pThis);

		public virtual void ForceBuildLocator()
		{
			vtkCellLocator.vtkCellLocator_ForceBuildLocator_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCellLocator_FreeSearchStructure_14(HandleRef pThis);

		public override void FreeSearchStructure()
		{
			vtkCellLocator.vtkCellLocator_FreeSearchStructure_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCellLocator_GenerateRepresentation_15(HandleRef pThis, int level, HandleRef pd);

		public override void GenerateRepresentation(int level, vtkPolyData pd)
		{
			vtkCellLocator.vtkCellLocator_GenerateRepresentation_15(base.GetCppThis(), level, (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCellLocator_GetCells_16(HandleRef pThis, int bucket, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkIdList GetCells(int bucket)
		{
			vtkIdList vtkIdList = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCellLocator.vtkCellLocator_GetCells_16(base.GetCppThis(), bucket, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkCellLocator_GetNumberOfBuckets_17(HandleRef pThis);

		public virtual int GetNumberOfBuckets()
		{
			return vtkCellLocator.vtkCellLocator_GetNumberOfBuckets_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCellLocator_GetNumberOfCellsPerBucket_18(HandleRef pThis);

		public int GetNumberOfCellsPerBucket()
		{
			return vtkCellLocator.vtkCellLocator_GetNumberOfCellsPerBucket_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCellLocator_IntersectWithLine_19(HandleRef pThis, IntPtr a0, IntPtr a1, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		public override int IntersectWithLine(IntPtr a0, IntPtr a1, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkCellLocator.vtkCellLocator_IntersectWithLine_19(base.GetCppThis(), a0, a1, tol, ref t, x, pcoords, ref subId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCellLocator_IntersectWithLine_20(HandleRef pThis, IntPtr a0, IntPtr a1, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId);

		public override int IntersectWithLine(IntPtr a0, IntPtr a1, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId)
		{
			return vtkCellLocator.vtkCellLocator_IntersectWithLine_20(base.GetCppThis(), a0, a1, tol, ref t, x, pcoords, ref subId, ref cellId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCellLocator_IntersectWithLine_21(HandleRef pThis, IntPtr a0, IntPtr a1, HandleRef points, HandleRef cellIds);

		public override int IntersectWithLine(IntPtr a0, IntPtr a1, vtkPoints points, vtkIdList cellIds)
		{
			return vtkCellLocator.vtkCellLocator_IntersectWithLine_21(base.GetCppThis(), a0, a1, (points == null) ? default(HandleRef) : points.GetCppThis(), (cellIds == null) ? default(HandleRef) : cellIds.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCellLocator_IntersectWithLine_22(HandleRef pThis, IntPtr a0, IntPtr a1, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId, HandleRef cell);

		public override int IntersectWithLine(IntPtr a0, IntPtr a1, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId, ref long cellId, vtkGenericCell cell)
		{
			return vtkCellLocator.vtkCellLocator_IntersectWithLine_22(base.GetCppThis(), a0, a1, tol, ref t, x, pcoords, ref subId, ref cellId, (cell == null) ? default(HandleRef) : cell.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCellLocator_IsA_23(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCellLocator.vtkCellLocator_IsA_23(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCellLocator_IsTypeOf_24(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCellLocator.vtkCellLocator_IsTypeOf_24(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCellLocator_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCellLocator NewInstance()
		{
			vtkCellLocator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCellLocator.vtkCellLocator_NewInstance_26(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCellLocator_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCellLocator SafeDownCast(vtkObjectBase o)
		{
			vtkCellLocator vtkCellLocator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCellLocator.vtkCellLocator_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellLocator = (vtkCellLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellLocator.Register(null);
				}
			}
			return vtkCellLocator;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCellLocator_SetNumberOfCellsPerBucket_28(HandleRef pThis, int N);

		public void SetNumberOfCellsPerBucket(int N)
		{
			vtkCellLocator.vtkCellLocator_SetNumberOfCellsPerBucket_28(base.GetCppThis(), N);
		}
	}
}
