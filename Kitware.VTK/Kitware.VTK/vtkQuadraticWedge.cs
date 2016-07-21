using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkQuadraticWedge : vtkNonLinearCell
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkQuadraticWedge";

		public new static readonly string MRClassNameKey;

		static vtkQuadraticWedge()
		{
			vtkQuadraticWedge.MRClassNameKey = "class vtkQuadraticWedge";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkQuadraticWedge.MRClassNameKey, Type.GetType("Kitware.VTK.vtkQuadraticWedge"));
		}

		public vtkQuadraticWedge(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkQuadraticWedge_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkQuadraticWedge New()
		{
			vtkQuadraticWedge result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkQuadraticWedge.vtkQuadraticWedge_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadraticWedge)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkQuadraticWedge() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkQuadraticWedge.vtkQuadraticWedge_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkQuadraticWedge_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkQuadraticWedge.vtkQuadraticWedge_CellBoundary_01(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkQuadraticWedge_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef tetras, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray tetras, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			vtkQuadraticWedge.vtkQuadraticWedge_Clip_02(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (tetras == null) ? default(HandleRef) : tetras.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkQuadraticWedge_Contour_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkQuadraticWedge.vtkQuadraticWedge_Contour_03(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkQuadraticWedge_Derivatives_04(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkQuadraticWedge.vtkQuadraticWedge_Derivatives_04(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkQuadraticWedge_EvaluateLocation_05(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkQuadraticWedge.vtkQuadraticWedge_EvaluateLocation_05(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkQuadraticWedge_EvaluatePosition_06(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkQuadraticWedge.vtkQuadraticWedge_EvaluatePosition_06(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkQuadraticWedge_GetCellDimension_07(HandleRef pThis);

		public override int GetCellDimension()
		{
			return vtkQuadraticWedge.vtkQuadraticWedge_GetCellDimension_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkQuadraticWedge_GetCellType_08(HandleRef pThis);

		public override int GetCellType()
		{
			return vtkQuadraticWedge.vtkQuadraticWedge_GetCellType_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkQuadraticWedge_GetEdge_09(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkCell GetEdge(int edgeId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkQuadraticWedge.vtkQuadraticWedge_GetEdge_09(base.GetCppThis(), edgeId, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkQuadraticWedge_GetEdgeArray_10(int edgeId);

		public static IntPtr GetEdgeArray(int edgeId)
		{
			return vtkQuadraticWedge.vtkQuadraticWedge_GetEdgeArray_10(edgeId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkQuadraticWedge_GetFace_11(HandleRef pThis, int faceId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkCell GetFace(int faceId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkQuadraticWedge.vtkQuadraticWedge_GetFace_11(base.GetCppThis(), faceId, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkQuadraticWedge_GetFaceArray_12(int faceId);

		public static IntPtr GetFaceArray(int faceId)
		{
			return vtkQuadraticWedge.vtkQuadraticWedge_GetFaceArray_12(faceId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkQuadraticWedge_GetNumberOfEdges_13(HandleRef pThis);

		public override int GetNumberOfEdges()
		{
			return vtkQuadraticWedge.vtkQuadraticWedge_GetNumberOfEdges_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkQuadraticWedge_GetNumberOfFaces_14(HandleRef pThis);

		public override int GetNumberOfFaces()
		{
			return vtkQuadraticWedge.vtkQuadraticWedge_GetNumberOfFaces_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkQuadraticWedge_GetParametricCenter_15(HandleRef pThis, IntPtr pcoords);

		public override int GetParametricCenter(IntPtr pcoords)
		{
			return vtkQuadraticWedge.vtkQuadraticWedge_GetParametricCenter_15(base.GetCppThis(), pcoords);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkQuadraticWedge_GetParametricCoords_16(HandleRef pThis);

		public override IntPtr GetParametricCoords()
		{
			return vtkQuadraticWedge.vtkQuadraticWedge_GetParametricCoords_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkQuadraticWedge_InterpolateDerivs_17(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkQuadraticWedge.vtkQuadraticWedge_InterpolateDerivs_17(base.GetCppThis(), pcoords, derivs);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkQuadraticWedge_InterpolateFunctions_18(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkQuadraticWedge.vtkQuadraticWedge_InterpolateFunctions_18(base.GetCppThis(), pcoords, weights);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkQuadraticWedge_InterpolationDerivs_19(IntPtr pcoords, IntPtr derivs);

		public static void InterpolationDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkQuadraticWedge.vtkQuadraticWedge_InterpolationDerivs_19(pcoords, derivs);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkQuadraticWedge_InterpolationFunctions_20(IntPtr pcoords, IntPtr weights);

		public static void InterpolationFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkQuadraticWedge.vtkQuadraticWedge_InterpolationFunctions_20(pcoords, weights);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkQuadraticWedge_IntersectWithLine_21(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkQuadraticWedge.vtkQuadraticWedge_IntersectWithLine_21(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkQuadraticWedge_IsA_22(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkQuadraticWedge.vtkQuadraticWedge_IsA_22(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkQuadraticWedge_IsTypeOf_23(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkQuadraticWedge.vtkQuadraticWedge_IsTypeOf_23(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkQuadraticWedge_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkQuadraticWedge NewInstance()
		{
			vtkQuadraticWedge result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkQuadraticWedge.vtkQuadraticWedge_NewInstance_25(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadraticWedge)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkQuadraticWedge_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkQuadraticWedge SafeDownCast(vtkObjectBase o)
		{
			vtkQuadraticWedge vtkQuadraticWedge = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkQuadraticWedge.vtkQuadraticWedge_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkQuadraticWedge = (vtkQuadraticWedge)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkQuadraticWedge.Register(null);
				}
			}
			return vtkQuadraticWedge;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkQuadraticWedge_Triangulate_27(HandleRef pThis, int index, HandleRef ptIds, HandleRef pts);

		public override int Triangulate(int index, vtkIdList ptIds, vtkPoints pts)
		{
			return vtkQuadraticWedge.vtkQuadraticWedge_Triangulate_27(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis(), (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}
	}
}
