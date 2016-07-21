using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkBiQuadraticQuadraticWedge : vtkNonLinearCell
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkBiQuadraticQuadraticWedge";

		public new static readonly string MRClassNameKey;

		static vtkBiQuadraticQuadraticWedge()
		{
			vtkBiQuadraticQuadraticWedge.MRClassNameKey = "class vtkBiQuadraticQuadraticWedge";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBiQuadraticQuadraticWedge.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBiQuadraticQuadraticWedge"));
		}

		public vtkBiQuadraticQuadraticWedge(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkBiQuadraticQuadraticWedge_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBiQuadraticQuadraticWedge New()
		{
			vtkBiQuadraticQuadraticWedge result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBiQuadraticQuadraticWedge)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkBiQuadraticQuadraticWedge() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkBiQuadraticQuadraticWedge_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_CellBoundary_01(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkBiQuadraticQuadraticWedge_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef tetras, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray tetras, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_Clip_02(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (tetras == null) ? default(HandleRef) : tetras.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkBiQuadraticQuadraticWedge_Contour_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_Contour_03(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkBiQuadraticQuadraticWedge_Derivatives_04(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_Derivatives_04(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkBiQuadraticQuadraticWedge_EvaluateLocation_05(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_EvaluateLocation_05(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkBiQuadraticQuadraticWedge_EvaluatePosition_06(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_EvaluatePosition_06(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkBiQuadraticQuadraticWedge_GetCellDimension_07(HandleRef pThis);

		public override int GetCellDimension()
		{
			return vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_GetCellDimension_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkBiQuadraticQuadraticWedge_GetCellType_08(HandleRef pThis);

		public override int GetCellType()
		{
			return vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_GetCellType_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkBiQuadraticQuadraticWedge_GetEdge_09(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkCell GetEdge(int edgeId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_GetEdge_09(base.GetCppThis(), edgeId, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkBiQuadraticQuadraticWedge_GetEdgeArray_10(int edgeId);

		public static IntPtr GetEdgeArray(int edgeId)
		{
			return vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_GetEdgeArray_10(edgeId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkBiQuadraticQuadraticWedge_GetFace_11(HandleRef pThis, int faceId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkCell GetFace(int faceId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_GetFace_11(base.GetCppThis(), faceId, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkBiQuadraticQuadraticWedge_GetFaceArray_12(int faceId);

		public static IntPtr GetFaceArray(int faceId)
		{
			return vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_GetFaceArray_12(faceId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkBiQuadraticQuadraticWedge_GetNumberOfEdges_13(HandleRef pThis);

		public override int GetNumberOfEdges()
		{
			return vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_GetNumberOfEdges_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkBiQuadraticQuadraticWedge_GetNumberOfFaces_14(HandleRef pThis);

		public override int GetNumberOfFaces()
		{
			return vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_GetNumberOfFaces_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkBiQuadraticQuadraticWedge_GetParametricCenter_15(HandleRef pThis, IntPtr pcoords);

		public override int GetParametricCenter(IntPtr pcoords)
		{
			return vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_GetParametricCenter_15(base.GetCppThis(), pcoords);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkBiQuadraticQuadraticWedge_GetParametricCoords_16(HandleRef pThis);

		public override IntPtr GetParametricCoords()
		{
			return vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_GetParametricCoords_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkBiQuadraticQuadraticWedge_InterpolateDerivs_17(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_InterpolateDerivs_17(base.GetCppThis(), pcoords, derivs);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkBiQuadraticQuadraticWedge_InterpolateFunctions_18(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_InterpolateFunctions_18(base.GetCppThis(), pcoords, weights);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkBiQuadraticQuadraticWedge_InterpolationDerivs_19(IntPtr pcoords, IntPtr derivs);

		public static void InterpolationDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_InterpolationDerivs_19(pcoords, derivs);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkBiQuadraticQuadraticWedge_InterpolationFunctions_20(IntPtr pcoords, IntPtr weights);

		public static void InterpolationFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_InterpolationFunctions_20(pcoords, weights);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkBiQuadraticQuadraticWedge_IntersectWithLine_21(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_IntersectWithLine_21(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkBiQuadraticQuadraticWedge_IsA_22(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_IsA_22(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkBiQuadraticQuadraticWedge_IsTypeOf_23(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_IsTypeOf_23(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkBiQuadraticQuadraticWedge_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkBiQuadraticQuadraticWedge NewInstance()
		{
			vtkBiQuadraticQuadraticWedge result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_NewInstance_25(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBiQuadraticQuadraticWedge)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkBiQuadraticQuadraticWedge_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBiQuadraticQuadraticWedge SafeDownCast(vtkObjectBase o)
		{
			vtkBiQuadraticQuadraticWedge vtkBiQuadraticQuadraticWedge = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBiQuadraticQuadraticWedge = (vtkBiQuadraticQuadraticWedge)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBiQuadraticQuadraticWedge.Register(null);
				}
			}
			return vtkBiQuadraticQuadraticWedge;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkBiQuadraticQuadraticWedge_Triangulate_27(HandleRef pThis, int index, HandleRef ptIds, HandleRef pts);

		public override int Triangulate(int index, vtkIdList ptIds, vtkPoints pts)
		{
			return vtkBiQuadraticQuadraticWedge.vtkBiQuadraticQuadraticWedge_Triangulate_27(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis(), (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}
	}
}
