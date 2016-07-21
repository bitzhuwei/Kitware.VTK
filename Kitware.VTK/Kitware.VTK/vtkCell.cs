using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkCell : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCell";

		public new static readonly string MRClassNameKey;

		static vtkCell()
		{
			vtkCell.MRClassNameKey = "class vtkCell";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCell.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCell"));
		}

		public vtkCell(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCell_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		public virtual int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkCell.vtkCell_CellBoundary_01(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCell_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef connectivity, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		public virtual void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray connectivity, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			vtkCell.vtkCell_Clip_02(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (connectivity == null) ? default(HandleRef) : connectivity.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCell_Contour_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		public virtual void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkCell.vtkCell_Contour_03(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCell_DeepCopy_04(HandleRef pThis, HandleRef c);

		public virtual void DeepCopy(vtkCell c)
		{
			vtkCell.vtkCell_DeepCopy_04(base.GetCppThis(), (c == null) ? default(HandleRef) : c.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCell_Derivatives_05(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		public virtual void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkCell.vtkCell_Derivatives_05(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCell_EvaluateLocation_06(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		public virtual void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkCell.vtkCell_EvaluateLocation_06(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCell_EvaluatePosition_07(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		public virtual int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkCell.vtkCell_EvaluatePosition_07(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCell_GetBounds_08(HandleRef pThis, IntPtr bounds);

		public void GetBounds(IntPtr bounds)
		{
			vtkCell.vtkCell_GetBounds_08(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCell_GetBounds_09(HandleRef pThis);

		public double[] GetBounds()
		{
			IntPtr intPtr = vtkCell.vtkCell_GetBounds_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCell_GetCellDimension_10(HandleRef pThis);

		public virtual int GetCellDimension()
		{
			return vtkCell.vtkCell_GetCellDimension_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCell_GetCellType_11(HandleRef pThis);

		public virtual int GetCellType()
		{
			return vtkCell.vtkCell_GetCellType_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCell_GetEdge_12(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCell GetEdge(int edgeId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCell.vtkCell_GetEdge_12(base.GetCppThis(), edgeId, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkCell_GetFace_13(HandleRef pThis, int faceId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCell GetFace(int faceId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCell.vtkCell_GetFace_13(base.GetCppThis(), faceId, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkCell_GetFaces_14(HandleRef pThis);

		public virtual IntPtr GetFaces()
		{
			return vtkCell.vtkCell_GetFaces_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkCell_GetLength2_15(HandleRef pThis);

		public double GetLength2()
		{
			return vtkCell.vtkCell_GetLength2_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCell_GetNumberOfEdges_16(HandleRef pThis);

		public virtual int GetNumberOfEdges()
		{
			return vtkCell.vtkCell_GetNumberOfEdges_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCell_GetNumberOfFaces_17(HandleRef pThis);

		public virtual int GetNumberOfFaces()
		{
			return vtkCell.vtkCell_GetNumberOfFaces_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkCell_GetNumberOfPoints_18(HandleRef pThis);

		public long GetNumberOfPoints()
		{
			return vtkCell.vtkCell_GetNumberOfPoints_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCell_GetParametricCenter_19(HandleRef pThis, IntPtr pcoords);

		public virtual int GetParametricCenter(IntPtr pcoords)
		{
			return vtkCell.vtkCell_GetParametricCenter_19(base.GetCppThis(), pcoords);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCell_GetParametricCoords_20(HandleRef pThis);

		public virtual IntPtr GetParametricCoords()
		{
			return vtkCell.vtkCell_GetParametricCoords_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkCell_GetParametricDistance_21(HandleRef pThis, IntPtr pcoords);

		public virtual double GetParametricDistance(IntPtr pcoords)
		{
			return vtkCell.vtkCell_GetParametricDistance_21(base.GetCppThis(), pcoords);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkCell_GetPointId_22(HandleRef pThis, int ptId);

		public long GetPointId(int ptId)
		{
			return vtkCell.vtkCell_GetPointId_22(base.GetCppThis(), ptId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCell_GetPointIds_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkIdList GetPointIds()
		{
			vtkIdList vtkIdList = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCell.vtkCell_GetPointIds_23(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkCell_GetPoints_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPoints GetPoints()
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCell.vtkCell_GetPoints_24(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPoints = (vtkPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPoints.Register(null);
				}
			}
			return vtkPoints;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCell_Initialize_25(HandleRef pThis, int npts, IntPtr pts, HandleRef p);

		public void Initialize(int npts, IntPtr pts, vtkPoints p)
		{
			vtkCell.vtkCell_Initialize_25(base.GetCppThis(), npts, pts, (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCell_Initialize_26(HandleRef pThis);

		public virtual void Initialize()
		{
			vtkCell.vtkCell_Initialize_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCell_InterpolateDerivs_27(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		public virtual void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkCell.vtkCell_InterpolateDerivs_27(base.GetCppThis(), pcoords, derivs);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCell_InterpolateFunctions_28(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		public virtual void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkCell.vtkCell_InterpolateFunctions_28(base.GetCppThis(), pcoords, weights);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCell_IntersectWithLine_29(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		public virtual int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkCell.vtkCell_IntersectWithLine_29(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCell_IsA_30(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCell.vtkCell_IsA_30(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCell_IsExplicitCell_31(HandleRef pThis);

		public virtual int IsExplicitCell()
		{
			return vtkCell.vtkCell_IsExplicitCell_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCell_IsLinear_32(HandleRef pThis);

		public virtual int IsLinear()
		{
			return vtkCell.vtkCell_IsLinear_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCell_IsPrimaryCell_33(HandleRef pThis);

		public virtual int IsPrimaryCell()
		{
			return vtkCell.vtkCell_IsPrimaryCell_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCell_IsTypeOf_34(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCell.vtkCell_IsTypeOf_34(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCell_NewInstance_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCell NewInstance()
		{
			vtkCell result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCell.vtkCell_NewInstance_35(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCell)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCell_RequiresExplicitFaceRepresentation_36(HandleRef pThis);

		public virtual int RequiresExplicitFaceRepresentation()
		{
			return vtkCell.vtkCell_RequiresExplicitFaceRepresentation_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCell_RequiresInitialization_37(HandleRef pThis);

		public virtual int RequiresInitialization()
		{
			return vtkCell.vtkCell_RequiresInitialization_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkCell_SafeDownCast_38(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCell SafeDownCast(vtkObjectBase o)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCell.vtkCell_SafeDownCast_38((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkCell_SetFaces_39(HandleRef pThis, IntPtr arg0);

		public virtual void SetFaces(IntPtr arg0)
		{
			vtkCell.vtkCell_SetFaces_39(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkCell_ShallowCopy_40(HandleRef pThis, HandleRef c);

		public virtual void ShallowCopy(vtkCell c)
		{
			vtkCell.vtkCell_ShallowCopy_40(base.GetCppThis(), (c == null) ? default(HandleRef) : c.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkCell_Triangulate_41(HandleRef pThis, int index, HandleRef ptIds, HandleRef pts);

		public virtual int Triangulate(int index, vtkIdList ptIds, vtkPoints pts)
		{
			return vtkCell.vtkCell_Triangulate_41(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis(), (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}
	}
}
