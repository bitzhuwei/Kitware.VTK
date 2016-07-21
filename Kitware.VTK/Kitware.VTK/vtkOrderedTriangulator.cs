using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkOrderedTriangulator : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkOrderedTriangulator";

		public new static readonly string MRClassNameKey;

		static vtkOrderedTriangulator()
		{
			vtkOrderedTriangulator.MRClassNameKey = "class vtkOrderedTriangulator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOrderedTriangulator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOrderedTriangulator"));
		}

		public vtkOrderedTriangulator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkOrderedTriangulator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOrderedTriangulator New()
		{
			vtkOrderedTriangulator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOrderedTriangulator.vtkOrderedTriangulator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOrderedTriangulator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkOrderedTriangulator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkOrderedTriangulator.vtkOrderedTriangulator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkOrderedTriangulator_AddTetras_01(HandleRef pThis, int classification, HandleRef ugrid);

		public long AddTetras(int classification, vtkUnstructuredGrid ugrid)
		{
			return vtkOrderedTriangulator.vtkOrderedTriangulator_AddTetras_01(base.GetCppThis(), classification, (ugrid == null) ? default(HandleRef) : ugrid.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkOrderedTriangulator_AddTetras_02(HandleRef pThis, int classification, HandleRef connectivity);

		public long AddTetras(int classification, vtkCellArray connectivity)
		{
			return vtkOrderedTriangulator.vtkOrderedTriangulator_AddTetras_02(base.GetCppThis(), classification, (connectivity == null) ? default(HandleRef) : connectivity.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkOrderedTriangulator_AddTetras_03(HandleRef pThis, int classification, HandleRef locator, HandleRef outConnectivity, HandleRef inPD, HandleRef outPD, HandleRef inCD, long cellId, HandleRef outCD);

		public long AddTetras(int classification, vtkIncrementalPointLocator locator, vtkCellArray outConnectivity, vtkPointData inPD, vtkPointData outPD, vtkCellData inCD, long cellId, vtkCellData outCD)
		{
			return vtkOrderedTriangulator.vtkOrderedTriangulator_AddTetras_03(base.GetCppThis(), classification, (locator == null) ? default(HandleRef) : locator.GetCppThis(), (outConnectivity == null) ? default(HandleRef) : outConnectivity.GetCppThis(), (inPD == null) ? default(HandleRef) : inPD.GetCppThis(), (outPD == null) ? default(HandleRef) : outPD.GetCppThis(), (inCD == null) ? default(HandleRef) : inCD.GetCppThis(), cellId, (outCD == null) ? default(HandleRef) : outCD.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkOrderedTriangulator_AddTetras_04(HandleRef pThis, int classification, HandleRef ptIds, HandleRef pts);

		public long AddTetras(int classification, vtkIdList ptIds, vtkPoints pts)
		{
			return vtkOrderedTriangulator.vtkOrderedTriangulator_AddTetras_04(base.GetCppThis(), classification, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis(), (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkOrderedTriangulator_AddTriangles_05(HandleRef pThis, HandleRef connectivity);

		public long AddTriangles(vtkCellArray connectivity)
		{
			return vtkOrderedTriangulator.vtkOrderedTriangulator_AddTriangles_05(base.GetCppThis(), (connectivity == null) ? default(HandleRef) : connectivity.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkOrderedTriangulator_AddTriangles_06(HandleRef pThis, long id, HandleRef connectivity);

		public long AddTriangles(long id, vtkCellArray connectivity)
		{
			return vtkOrderedTriangulator.vtkOrderedTriangulator_AddTriangles_06(base.GetCppThis(), id, (connectivity == null) ? default(HandleRef) : connectivity.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkOrderedTriangulator_GetNextTetra_07(HandleRef pThis, int classification, HandleRef tet, HandleRef cellScalars, HandleRef tetScalars);

		public int GetNextTetra(int classification, vtkTetra tet, vtkDataArray cellScalars, vtkDoubleArray tetScalars)
		{
			return vtkOrderedTriangulator.vtkOrderedTriangulator_GetNextTetra_07(base.GetCppThis(), classification, (tet == null) ? default(HandleRef) : tet.GetCppThis(), (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (tetScalars == null) ? default(HandleRef) : tetScalars.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkOrderedTriangulator_GetNumberOfPoints_08(HandleRef pThis);

		public virtual int GetNumberOfPoints()
		{
			return vtkOrderedTriangulator.vtkOrderedTriangulator_GetNumberOfPoints_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkOrderedTriangulator_GetPointId_09(HandleRef pThis, long internalId);

		public long GetPointId(long internalId)
		{
			return vtkOrderedTriangulator.vtkOrderedTriangulator_GetPointId_09(base.GetCppThis(), internalId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkOrderedTriangulator_GetPointLocation_10(HandleRef pThis, long internalId);

		public IntPtr GetPointLocation(long internalId)
		{
			return vtkOrderedTriangulator.vtkOrderedTriangulator_GetPointLocation_10(base.GetCppThis(), internalId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkOrderedTriangulator_GetPointPosition_11(HandleRef pThis, long internalId);

		public IntPtr GetPointPosition(long internalId)
		{
			return vtkOrderedTriangulator.vtkOrderedTriangulator_GetPointPosition_11(base.GetCppThis(), internalId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkOrderedTriangulator_GetPreSorted_12(HandleRef pThis);

		public virtual int GetPreSorted()
		{
			return vtkOrderedTriangulator.vtkOrderedTriangulator_GetPreSorted_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkOrderedTriangulator_GetTetras_13(HandleRef pThis, int classification, HandleRef ugrid);

		public long GetTetras(int classification, vtkUnstructuredGrid ugrid)
		{
			return vtkOrderedTriangulator.vtkOrderedTriangulator_GetTetras_13(base.GetCppThis(), classification, (ugrid == null) ? default(HandleRef) : ugrid.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkOrderedTriangulator_GetUseTemplates_14(HandleRef pThis);

		public virtual int GetUseTemplates()
		{
			return vtkOrderedTriangulator.vtkOrderedTriangulator_GetUseTemplates_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkOrderedTriangulator_GetUseTwoSortIds_15(HandleRef pThis);

		public virtual int GetUseTwoSortIds()
		{
			return vtkOrderedTriangulator.vtkOrderedTriangulator_GetUseTwoSortIds_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkOrderedTriangulator_InitTetraTraversal_16(HandleRef pThis);

		public void InitTetraTraversal()
		{
			vtkOrderedTriangulator.vtkOrderedTriangulator_InitTetraTraversal_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkOrderedTriangulator_InitTriangulation_17(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax, int numPts);

		public void InitTriangulation(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax, int numPts)
		{
			vtkOrderedTriangulator.vtkOrderedTriangulator_InitTriangulation_17(base.GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax, numPts);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkOrderedTriangulator_InitTriangulation_18(HandleRef pThis, IntPtr bounds, int numPts);

		public void InitTriangulation(IntPtr bounds, int numPts)
		{
			vtkOrderedTriangulator.vtkOrderedTriangulator_InitTriangulation_18(base.GetCppThis(), bounds, numPts);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkOrderedTriangulator_InsertPoint_19(HandleRef pThis, long id, IntPtr x, IntPtr p, int type);

		public long InsertPoint(long id, IntPtr x, IntPtr p, int type)
		{
			return vtkOrderedTriangulator.vtkOrderedTriangulator_InsertPoint_19(base.GetCppThis(), id, x, p, type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkOrderedTriangulator_InsertPoint_20(HandleRef pThis, long id, long sortid, IntPtr x, IntPtr p, int type);

		public long InsertPoint(long id, long sortid, IntPtr x, IntPtr p, int type)
		{
			return vtkOrderedTriangulator.vtkOrderedTriangulator_InsertPoint_20(base.GetCppThis(), id, sortid, x, p, type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkOrderedTriangulator_InsertPoint_21(HandleRef pThis, long id, long sortid, long sortid2, IntPtr x, IntPtr p, int type);

		public long InsertPoint(long id, long sortid, long sortid2, IntPtr x, IntPtr p, int type)
		{
			return vtkOrderedTriangulator.vtkOrderedTriangulator_InsertPoint_21(base.GetCppThis(), id, sortid, sortid2, x, p, type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkOrderedTriangulator_IsA_22(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkOrderedTriangulator.vtkOrderedTriangulator_IsA_22(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkOrderedTriangulator_IsTypeOf_23(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkOrderedTriangulator.vtkOrderedTriangulator_IsTypeOf_23(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkOrderedTriangulator_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkOrderedTriangulator NewInstance()
		{
			vtkOrderedTriangulator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOrderedTriangulator.vtkOrderedTriangulator_NewInstance_25(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOrderedTriangulator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkOrderedTriangulator_PreSortedOff_26(HandleRef pThis);

		public virtual void PreSortedOff()
		{
			vtkOrderedTriangulator.vtkOrderedTriangulator_PreSortedOff_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkOrderedTriangulator_PreSortedOn_27(HandleRef pThis);

		public virtual void PreSortedOn()
		{
			vtkOrderedTriangulator.vtkOrderedTriangulator_PreSortedOn_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkOrderedTriangulator_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOrderedTriangulator SafeDownCast(vtkObjectBase o)
		{
			vtkOrderedTriangulator vtkOrderedTriangulator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOrderedTriangulator.vtkOrderedTriangulator_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOrderedTriangulator = (vtkOrderedTriangulator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOrderedTriangulator.Register(null);
				}
			}
			return vtkOrderedTriangulator;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkOrderedTriangulator_SetPreSorted_29(HandleRef pThis, int _arg);

		public virtual void SetPreSorted(int _arg)
		{
			vtkOrderedTriangulator.vtkOrderedTriangulator_SetPreSorted_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkOrderedTriangulator_SetUseTemplates_30(HandleRef pThis, int _arg);

		public virtual void SetUseTemplates(int _arg)
		{
			vtkOrderedTriangulator.vtkOrderedTriangulator_SetUseTemplates_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkOrderedTriangulator_SetUseTwoSortIds_31(HandleRef pThis, int _arg);

		public virtual void SetUseTwoSortIds(int _arg)
		{
			vtkOrderedTriangulator.vtkOrderedTriangulator_SetUseTwoSortIds_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkOrderedTriangulator_TemplateTriangulate_32(HandleRef pThis, int cellType, int numPts, int numEdges);

		public void TemplateTriangulate(int cellType, int numPts, int numEdges)
		{
			vtkOrderedTriangulator.vtkOrderedTriangulator_TemplateTriangulate_32(base.GetCppThis(), cellType, numPts, numEdges);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkOrderedTriangulator_Triangulate_33(HandleRef pThis);

		public void Triangulate()
		{
			vtkOrderedTriangulator.vtkOrderedTriangulator_Triangulate_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkOrderedTriangulator_UpdatePointType_34(HandleRef pThis, long internalId, int type);

		public void UpdatePointType(long internalId, int type)
		{
			vtkOrderedTriangulator.vtkOrderedTriangulator_UpdatePointType_34(base.GetCppThis(), internalId, type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkOrderedTriangulator_UseTemplatesOff_35(HandleRef pThis);

		public virtual void UseTemplatesOff()
		{
			vtkOrderedTriangulator.vtkOrderedTriangulator_UseTemplatesOff_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkOrderedTriangulator_UseTemplatesOn_36(HandleRef pThis);

		public virtual void UseTemplatesOn()
		{
			vtkOrderedTriangulator.vtkOrderedTriangulator_UseTemplatesOn_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkOrderedTriangulator_UseTwoSortIdsOff_37(HandleRef pThis);

		public virtual void UseTwoSortIdsOff()
		{
			vtkOrderedTriangulator.vtkOrderedTriangulator_UseTwoSortIdsOff_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkOrderedTriangulator_UseTwoSortIdsOn_38(HandleRef pThis);

		public virtual void UseTwoSortIdsOn()
		{
			vtkOrderedTriangulator.vtkOrderedTriangulator_UseTwoSortIdsOn_38(base.GetCppThis());
		}
	}
}
