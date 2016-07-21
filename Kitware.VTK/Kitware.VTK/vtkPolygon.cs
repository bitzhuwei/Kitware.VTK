using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPolygon : vtkCell
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolygon";

		public new static readonly string MRClassNameKey;

		static vtkPolygon()
		{
			vtkPolygon.MRClassNameKey = "class vtkPolygon";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolygon.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolygon"));
		}

		public vtkPolygon(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolygon_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPolygon New()
		{
			vtkPolygon result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolygon.vtkPolygon_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolygon)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPolygon() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPolygon.vtkPolygon_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPolygon_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkPolygon.vtkPolygon_CellBoundary_01(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolygon_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef tris, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray tris, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			vtkPolygon.vtkPolygon_Clip_02(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (tris == null) ? default(HandleRef) : tris.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkPolygon_ComputeArea_03(HandleRef pThis);

		public double ComputeArea()
		{
			return vtkPolygon.vtkPolygon_ComputeArea_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkPolygon_ComputeArea_04(HandleRef p, long numPts, IntPtr pts, IntPtr normal);

		public static double ComputeArea(vtkPoints p, long numPts, IntPtr pts, IntPtr normal)
		{
			return vtkPolygon.vtkPolygon_ComputeArea_04((p == null) ? default(HandleRef) : p.GetCppThis(), numPts, pts, normal);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolygon_ComputeCentroid_05(HandleRef ids, HandleRef pts, IntPtr centroid);

		public static void ComputeCentroid(vtkIdTypeArray ids, vtkPoints pts, IntPtr centroid)
		{
			vtkPolygon.vtkPolygon_ComputeCentroid_05((ids == null) ? default(HandleRef) : ids.GetCppThis(), (pts == null) ? default(HandleRef) : pts.GetCppThis(), centroid);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolygon_ComputeNormal_06(HandleRef p, int numPts, IntPtr pts, IntPtr n);

		public static void ComputeNormal(vtkPoints p, int numPts, IntPtr pts, IntPtr n)
		{
			vtkPolygon.vtkPolygon_ComputeNormal_06((p == null) ? default(HandleRef) : p.GetCppThis(), numPts, pts, n);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolygon_ComputeNormal_07(HandleRef p, IntPtr n);

		public static void ComputeNormal(vtkPoints p, IntPtr n)
		{
			vtkPolygon.vtkPolygon_ComputeNormal_07((p == null) ? default(HandleRef) : p.GetCppThis(), n);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolygon_ComputeNormal_08(HandleRef ids, HandleRef pts, IntPtr n);

		public static void ComputeNormal(vtkIdTypeArray ids, vtkPoints pts, IntPtr n)
		{
			vtkPolygon.vtkPolygon_ComputeNormal_08((ids == null) ? default(HandleRef) : ids.GetCppThis(), (pts == null) ? default(HandleRef) : pts.GetCppThis(), n);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolygon_ComputeNormal_09(int numPts, IntPtr pts, IntPtr n);

		public static void ComputeNormal(int numPts, IntPtr pts, IntPtr n)
		{
			vtkPolygon.vtkPolygon_ComputeNormal_09(numPts, pts, n);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolygon_Contour_10(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkPolygon.vtkPolygon_Contour_10(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolygon_Derivatives_11(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkPolygon.vtkPolygon_Derivatives_11(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkPolygon_DistanceToPolygon_12(IntPtr x, int numPts, IntPtr pts, IntPtr bounds, IntPtr closest);

		public static double DistanceToPolygon(IntPtr x, int numPts, IntPtr pts, IntPtr bounds, IntPtr closest)
		{
			return vtkPolygon.vtkPolygon_DistanceToPolygon_12(x, numPts, pts, bounds, closest);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolygon_EvaluateLocation_13(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkPolygon.vtkPolygon_EvaluateLocation_13(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPolygon_EvaluatePosition_14(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkPolygon.vtkPolygon_EvaluatePosition_14(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPolygon_GetCellDimension_15(HandleRef pThis);

		public override int GetCellDimension()
		{
			return vtkPolygon.vtkPolygon_GetCellDimension_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPolygon_GetCellType_16(HandleRef pThis);

		public override int GetCellType()
		{
			return vtkPolygon.vtkPolygon_GetCellType_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolygon_GetEdge_17(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkCell GetEdge(int edgeId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolygon.vtkPolygon_GetEdge_17(base.GetCppThis(), edgeId, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkPolygon_GetFace_18(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkCell GetFace(int arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolygon.vtkPolygon_GetFace_18(base.GetCppThis(), arg0, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkPolygon_GetNumberOfEdges_19(HandleRef pThis);

		public override int GetNumberOfEdges()
		{
			return vtkPolygon.vtkPolygon_GetNumberOfEdges_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPolygon_GetNumberOfFaces_20(HandleRef pThis);

		public override int GetNumberOfFaces()
		{
			return vtkPolygon.vtkPolygon_GetNumberOfFaces_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern byte vtkPolygon_GetUseMVCInterpolation_21(HandleRef pThis);

		public virtual bool GetUseMVCInterpolation()
		{
			return vtkPolygon.vtkPolygon_GetUseMVCInterpolation_21(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolygon_InterpolateDerivs_22(HandleRef pThis, IntPtr x, IntPtr derivs);

		public override void InterpolateDerivs(IntPtr x, IntPtr derivs)
		{
			vtkPolygon.vtkPolygon_InterpolateDerivs_22(base.GetCppThis(), x, derivs);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolygon_InterpolateFunctions_23(HandleRef pThis, IntPtr x, IntPtr sf);

		public override void InterpolateFunctions(IntPtr x, IntPtr sf)
		{
			vtkPolygon.vtkPolygon_InterpolateFunctions_23(base.GetCppThis(), x, sf);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPolygon_IntersectConvex2DCells_24(HandleRef cell1, HandleRef cell2, double tol, IntPtr p0, IntPtr p1);

		public static int IntersectConvex2DCells(vtkCell cell1, vtkCell cell2, double tol, IntPtr p0, IntPtr p1)
		{
			return vtkPolygon.vtkPolygon_IntersectConvex2DCells_24((cell1 == null) ? default(HandleRef) : cell1.GetCppThis(), (cell2 == null) ? default(HandleRef) : cell2.GetCppThis(), tol, p0, p1);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPolygon_IntersectPolygonWithPolygon_25(int npts, IntPtr pts, IntPtr bounds, int npts2, IntPtr pts2, IntPtr bounds2, double tol, IntPtr x);

		public static int IntersectPolygonWithPolygon(int npts, IntPtr pts, IntPtr bounds, int npts2, IntPtr pts2, IntPtr bounds2, double tol, IntPtr x)
		{
			return vtkPolygon.vtkPolygon_IntersectPolygonWithPolygon_25(npts, pts, bounds, npts2, pts2, bounds2, tol, x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPolygon_IntersectWithLine_26(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkPolygon.vtkPolygon_IntersectWithLine_26(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPolygon_IsA_27(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPolygon.vtkPolygon_IsA_27(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPolygon_IsPrimaryCell_28(HandleRef pThis);

		public override int IsPrimaryCell()
		{
			return vtkPolygon.vtkPolygon_IsPrimaryCell_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPolygon_IsTypeOf_29(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPolygon.vtkPolygon_IsTypeOf_29(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolygon_NewInstance_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPolygon NewInstance()
		{
			vtkPolygon result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolygon.vtkPolygon_NewInstance_31(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolygon)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPolygon_NonDegenerateTriangulate_32(HandleRef pThis, HandleRef outTris);

		public int NonDegenerateTriangulate(vtkIdList outTris)
		{
			return vtkPolygon.vtkPolygon_NonDegenerateTriangulate_32(base.GetCppThis(), (outTris == null) ? default(HandleRef) : outTris.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPolygon_ParameterizePolygon_33(HandleRef pThis, IntPtr p0, IntPtr p10, ref double l10, IntPtr p20, ref double l20, IntPtr n);

		public int ParameterizePolygon(IntPtr p0, IntPtr p10, ref double l10, IntPtr p20, ref double l20, IntPtr n)
		{
			return vtkPolygon.vtkPolygon_ParameterizePolygon_33(base.GetCppThis(), p0, p10, ref l10, p20, ref l20, n);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPolygon_PointInPolygon_34(IntPtr x, int numPts, IntPtr pts, IntPtr bounds, IntPtr n);

		public static int PointInPolygon(IntPtr x, int numPts, IntPtr pts, IntPtr bounds, IntPtr n)
		{
			return vtkPolygon.vtkPolygon_PointInPolygon_34(x, numPts, pts, bounds, n);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolygon_SafeDownCast_35(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPolygon SafeDownCast(vtkObjectBase o)
		{
			vtkPolygon vtkPolygon = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolygon.vtkPolygon_SafeDownCast_35((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolygon = (vtkPolygon)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolygon.Register(null);
				}
			}
			return vtkPolygon;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkPolygon_SetUseMVCInterpolation_36(HandleRef pThis, byte _arg);

		public virtual void SetUseMVCInterpolation(bool _arg)
		{
			vtkPolygon.vtkPolygon_SetUseMVCInterpolation_36(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPolygon_Triangulate_37(HandleRef pThis, int index, HandleRef ptIds, HandleRef pts);

		public override int Triangulate(int index, vtkIdList ptIds, vtkPoints pts)
		{
			return vtkPolygon.vtkPolygon_Triangulate_37(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis(), (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkPolygon_Triangulate_38(HandleRef pThis, HandleRef outTris);

		public int Triangulate(vtkIdList outTris)
		{
			return vtkPolygon.vtkPolygon_Triangulate_38(base.GetCppThis(), (outTris == null) ? default(HandleRef) : outTris.GetCppThis());
		}
	}
}
