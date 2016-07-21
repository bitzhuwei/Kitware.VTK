using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTriangle : vtkCell
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTriangle";

		public new static readonly string MRClassNameKey;

		static vtkTriangle()
		{
			vtkTriangle.MRClassNameKey = "class vtkTriangle";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTriangle.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTriangle"));
		}

		public vtkTriangle(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkTriangle_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTriangle New()
		{
			vtkTriangle result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTriangle.vtkTriangle_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTriangle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTriangle() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTriangle.vtkTriangle_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkTriangle_BarycentricCoords_01(IntPtr x, IntPtr x1, IntPtr x2, IntPtr x3, IntPtr bcoords);

		public static int BarycentricCoords(IntPtr x, IntPtr x1, IntPtr x2, IntPtr x3, IntPtr bcoords)
		{
			return vtkTriangle.vtkTriangle_BarycentricCoords_01(x, x1, x2, x3, bcoords);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkTriangle_CellBoundary_02(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkTriangle.vtkTriangle_CellBoundary_02(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkTriangle_Circumcircle_03(IntPtr p1, IntPtr p2, IntPtr p3, IntPtr center);

		public static double Circumcircle(IntPtr p1, IntPtr p2, IntPtr p3, IntPtr center)
		{
			return vtkTriangle.vtkTriangle_Circumcircle_03(p1, p2, p3, center);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkTriangle_Clip_04(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			vtkTriangle.vtkTriangle_Clip_04(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkTriangle_ComputeArea_05(HandleRef pThis);

		public double ComputeArea()
		{
			return vtkTriangle.vtkTriangle_ComputeArea_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkTriangle_ComputeNormal_06(HandleRef p, int numPts, IntPtr pts, IntPtr n);

		public static void ComputeNormal(vtkPoints p, int numPts, IntPtr pts, IntPtr n)
		{
			vtkTriangle.vtkTriangle_ComputeNormal_06((p == null) ? default(HandleRef) : p.GetCppThis(), numPts, pts, n);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkTriangle_ComputeNormal_07(IntPtr v1, IntPtr v2, IntPtr v3, IntPtr n);

		public static void ComputeNormal(IntPtr v1, IntPtr v2, IntPtr v3, IntPtr n)
		{
			vtkTriangle.vtkTriangle_ComputeNormal_07(v1, v2, v3, n);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkTriangle_ComputeNormalDirection_08(IntPtr v1, IntPtr v2, IntPtr v3, IntPtr n);

		public static void ComputeNormalDirection(IntPtr v1, IntPtr v2, IntPtr v3, IntPtr n)
		{
			vtkTriangle.vtkTriangle_ComputeNormalDirection_08(v1, v2, v3, n);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkTriangle_ComputeQuadric_09(IntPtr x1, IntPtr x2, IntPtr x3, HandleRef quadric);

		public static void ComputeQuadric(IntPtr x1, IntPtr x2, IntPtr x3, vtkQuadric quadric)
		{
			vtkTriangle.vtkTriangle_ComputeQuadric_09(x1, x2, x3, (quadric == null) ? default(HandleRef) : quadric.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkTriangle_Contour_10(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkTriangle.vtkTriangle_Contour_10(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkTriangle_Derivatives_11(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkTriangle.vtkTriangle_Derivatives_11(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkTriangle_EvaluateLocation_12(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkTriangle.vtkTriangle_EvaluateLocation_12(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkTriangle_EvaluatePosition_13(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkTriangle.vtkTriangle_EvaluatePosition_13(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkTriangle_GetCellDimension_14(HandleRef pThis);

		public override int GetCellDimension()
		{
			return vtkTriangle.vtkTriangle_GetCellDimension_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkTriangle_GetCellType_15(HandleRef pThis);

		public override int GetCellType()
		{
			return vtkTriangle.vtkTriangle_GetCellType_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkTriangle_GetEdge_16(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkCell GetEdge(int edgeId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTriangle.vtkTriangle_GetEdge_16(base.GetCppThis(), edgeId, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkTriangle_GetEdgeArray_17(HandleRef pThis, int edgeId);

		public IntPtr GetEdgeArray(int edgeId)
		{
			return vtkTriangle.vtkTriangle_GetEdgeArray_17(base.GetCppThis(), edgeId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkTriangle_GetFace_18(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkCell GetFace(int arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTriangle.vtkTriangle_GetFace_18(base.GetCppThis(), arg0, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkTriangle_GetNumberOfEdges_19(HandleRef pThis);

		public override int GetNumberOfEdges()
		{
			return vtkTriangle.vtkTriangle_GetNumberOfEdges_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkTriangle_GetNumberOfFaces_20(HandleRef pThis);

		public override int GetNumberOfFaces()
		{
			return vtkTriangle.vtkTriangle_GetNumberOfFaces_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkTriangle_GetParametricCenter_21(HandleRef pThis, IntPtr pcoords);

		public override int GetParametricCenter(IntPtr pcoords)
		{
			return vtkTriangle.vtkTriangle_GetParametricCenter_21(base.GetCppThis(), pcoords);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkTriangle_GetParametricCoords_22(HandleRef pThis);

		public override IntPtr GetParametricCoords()
		{
			return vtkTriangle.vtkTriangle_GetParametricCoords_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkTriangle_GetParametricDistance_23(HandleRef pThis, IntPtr pcoords);

		public override double GetParametricDistance(IntPtr pcoords)
		{
			return vtkTriangle.vtkTriangle_GetParametricDistance_23(base.GetCppThis(), pcoords);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkTriangle_InterpolateDerivs_24(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkTriangle.vtkTriangle_InterpolateDerivs_24(base.GetCppThis(), pcoords, derivs);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkTriangle_InterpolateFunctions_25(HandleRef pThis, IntPtr pcoords, IntPtr sf);

		public override void InterpolateFunctions(IntPtr pcoords, IntPtr sf)
		{
			vtkTriangle.vtkTriangle_InterpolateFunctions_25(base.GetCppThis(), pcoords, sf);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkTriangle_InterpolationDerivs_26(IntPtr pcoords, IntPtr derivs);

		public static void InterpolationDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkTriangle.vtkTriangle_InterpolationDerivs_26(pcoords, derivs);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkTriangle_InterpolationFunctions_27(IntPtr pcoords, IntPtr sf);

		public static void InterpolationFunctions(IntPtr pcoords, IntPtr sf)
		{
			vtkTriangle.vtkTriangle_InterpolationFunctions_27(pcoords, sf);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkTriangle_IntersectWithLine_28(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkTriangle.vtkTriangle_IntersectWithLine_28(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkTriangle_IsA_29(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTriangle.vtkTriangle_IsA_29(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkTriangle_IsTypeOf_30(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTriangle.vtkTriangle_IsTypeOf_30(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkTriangle_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTriangle NewInstance()
		{
			vtkTriangle result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTriangle.vtkTriangle_NewInstance_32(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTriangle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkTriangle_PointInTriangle_33(IntPtr x, IntPtr x1, IntPtr x2, IntPtr x3, double tol2);

		public static int PointInTriangle(IntPtr x, IntPtr x1, IntPtr x2, IntPtr x3, double tol2)
		{
			return vtkTriangle.vtkTriangle_PointInTriangle_33(x, x1, x2, x3, tol2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkTriangle_ProjectTo2D_34(IntPtr x1, IntPtr x2, IntPtr x3, IntPtr v1, IntPtr v2, IntPtr v3);

		public static int ProjectTo2D(IntPtr x1, IntPtr x2, IntPtr x3, IntPtr v1, IntPtr v2, IntPtr v3)
		{
			return vtkTriangle.vtkTriangle_ProjectTo2D_34(x1, x2, x3, v1, v2, v3);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkTriangle_SafeDownCast_35(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTriangle SafeDownCast(vtkObjectBase o)
		{
			vtkTriangle vtkTriangle = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTriangle.vtkTriangle_SafeDownCast_35((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTriangle = (vtkTriangle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTriangle.Register(null);
				}
			}
			return vtkTriangle;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkTriangle_TriangleArea_36(IntPtr p1, IntPtr p2, IntPtr p3);

		public static double TriangleArea(IntPtr p1, IntPtr p2, IntPtr p3)
		{
			return vtkTriangle.vtkTriangle_TriangleArea_36(p1, p2, p3);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkTriangle_TriangleCenter_37(IntPtr p1, IntPtr p2, IntPtr p3, IntPtr center);

		public static void TriangleCenter(IntPtr p1, IntPtr p2, IntPtr p3, IntPtr center)
		{
			vtkTriangle.vtkTriangle_TriangleCenter_37(p1, p2, p3, center);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkTriangle_Triangulate_38(HandleRef pThis, int index, HandleRef ptIds, HandleRef pts);

		public override int Triangulate(int index, vtkIdList ptIds, vtkPoints pts)
		{
			return vtkTriangle.vtkTriangle_Triangulate_38(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis(), (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}
	}
}
