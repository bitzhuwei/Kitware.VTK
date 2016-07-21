using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGenericCell : vtkCell
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericCell";

		public new static readonly string MRClassNameKey;

		static vtkGenericCell()
		{
			vtkGenericCell.MRClassNameKey = "class vtkGenericCell";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericCell.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericCell"));
		}

		public vtkGenericCell(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericCell_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGenericCell New()
		{
			vtkGenericCell result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericCell.vtkGenericCell_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericCell)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGenericCell() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGenericCell.vtkGenericCell_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericCell_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkGenericCell.vtkGenericCell_CellBoundary_01(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCell_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef connectivity, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray connectivity, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			vtkGenericCell.vtkGenericCell_Clip_02(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (connectivity == null) ? default(HandleRef) : connectivity.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCell_Contour_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkGenericCell.vtkGenericCell_Contour_03(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCell_DeepCopy_04(HandleRef pThis, HandleRef c);

		public override void DeepCopy(vtkCell c)
		{
			vtkGenericCell.vtkGenericCell_DeepCopy_04(base.GetCppThis(), (c == null) ? default(HandleRef) : c.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCell_Derivatives_05(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkGenericCell.vtkGenericCell_Derivatives_05(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCell_EvaluateLocation_06(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkGenericCell.vtkGenericCell_EvaluateLocation_06(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericCell_EvaluatePosition_07(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkGenericCell.vtkGenericCell_EvaluatePosition_07(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericCell_GetCellDimension_08(HandleRef pThis);

		public override int GetCellDimension()
		{
			return vtkGenericCell.vtkGenericCell_GetCellDimension_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericCell_GetCellType_09(HandleRef pThis);

		public override int GetCellType()
		{
			return vtkGenericCell.vtkGenericCell_GetCellType_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericCell_GetEdge_10(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkCell GetEdge(int edgeId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericCell.vtkGenericCell_GetEdge_10(base.GetCppThis(), edgeId, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkGenericCell_GetFace_11(HandleRef pThis, int faceId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkCell GetFace(int faceId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericCell.vtkGenericCell_GetFace_11(base.GetCppThis(), faceId, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkGenericCell_GetFaces_12(HandleRef pThis);

		public override IntPtr GetFaces()
		{
			return vtkGenericCell.vtkGenericCell_GetFaces_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericCell_GetNumberOfEdges_13(HandleRef pThis);

		public override int GetNumberOfEdges()
		{
			return vtkGenericCell.vtkGenericCell_GetNumberOfEdges_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericCell_GetNumberOfFaces_14(HandleRef pThis);

		public override int GetNumberOfFaces()
		{
			return vtkGenericCell.vtkGenericCell_GetNumberOfFaces_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericCell_GetParametricCenter_15(HandleRef pThis, IntPtr pcoords);

		public override int GetParametricCenter(IntPtr pcoords)
		{
			return vtkGenericCell.vtkGenericCell_GetParametricCenter_15(base.GetCppThis(), pcoords);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericCell_GetParametricCoords_16(HandleRef pThis);

		public override IntPtr GetParametricCoords()
		{
			return vtkGenericCell.vtkGenericCell_GetParametricCoords_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCell_Initialize_17(HandleRef pThis);

		public override void Initialize()
		{
			vtkGenericCell.vtkGenericCell_Initialize_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericCell_InstantiateCell_18(int cellType, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkCell InstantiateCell(int cellType)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericCell.vtkGenericCell_InstantiateCell_18(cellType, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkGenericCell_InterpolateDerivs_19(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkGenericCell.vtkGenericCell_InterpolateDerivs_19(base.GetCppThis(), pcoords, derivs);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCell_InterpolateFunctions_20(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkGenericCell.vtkGenericCell_InterpolateFunctions_20(base.GetCppThis(), pcoords, weights);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericCell_IntersectWithLine_21(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkGenericCell.vtkGenericCell_IntersectWithLine_21(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericCell_IsA_22(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGenericCell.vtkGenericCell_IsA_22(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericCell_IsLinear_23(HandleRef pThis);

		public override int IsLinear()
		{
			return vtkGenericCell.vtkGenericCell_IsLinear_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericCell_IsPrimaryCell_24(HandleRef pThis);

		public override int IsPrimaryCell()
		{
			return vtkGenericCell.vtkGenericCell_IsPrimaryCell_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericCell_IsTypeOf_25(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGenericCell.vtkGenericCell_IsTypeOf_25(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericCell_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGenericCell NewInstance()
		{
			vtkGenericCell result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericCell.vtkGenericCell_NewInstance_27(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericCell)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericCell_RequiresExplicitFaceRepresentation_28(HandleRef pThis);

		public override int RequiresExplicitFaceRepresentation()
		{
			return vtkGenericCell.vtkGenericCell_RequiresExplicitFaceRepresentation_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericCell_RequiresInitialization_29(HandleRef pThis);

		public override int RequiresInitialization()
		{
			return vtkGenericCell.vtkGenericCell_RequiresInitialization_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericCell_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGenericCell SafeDownCast(vtkObjectBase o)
		{
			vtkGenericCell vtkGenericCell = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericCell.vtkGenericCell_SafeDownCast_30((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericCell = (vtkGenericCell)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericCell.Register(null);
				}
			}
			return vtkGenericCell;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCell_SetCellType_31(HandleRef pThis, int cellType);

		public void SetCellType(int cellType)
		{
			vtkGenericCell.vtkGenericCell_SetCellType_31(base.GetCppThis(), cellType);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCell_SetCellTypeToBiQuadraticQuad_32(HandleRef pThis);

		public void SetCellTypeToBiQuadraticQuad()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToBiQuadraticQuad_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCell_SetCellTypeToBiQuadraticQuadraticHexahedron_33(HandleRef pThis);

		public void SetCellTypeToBiQuadraticQuadraticHexahedron()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToBiQuadraticQuadraticHexahedron_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCell_SetCellTypeToBiQuadraticQuadraticWedge_34(HandleRef pThis);

		public void SetCellTypeToBiQuadraticQuadraticWedge()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToBiQuadraticQuadraticWedge_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCell_SetCellTypeToBiQuadraticTriangle_35(HandleRef pThis);

		public void SetCellTypeToBiQuadraticTriangle()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToBiQuadraticTriangle_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCell_SetCellTypeToConvexPointSet_36(HandleRef pThis);

		public void SetCellTypeToConvexPointSet()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToConvexPointSet_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCell_SetCellTypeToCubicLine_37(HandleRef pThis);

		public void SetCellTypeToCubicLine()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToCubicLine_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCell_SetCellTypeToEmptyCell_38(HandleRef pThis);

		public void SetCellTypeToEmptyCell()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToEmptyCell_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCell_SetCellTypeToHexagonalPrism_39(HandleRef pThis);

		public void SetCellTypeToHexagonalPrism()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToHexagonalPrism_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCell_SetCellTypeToHexahedron_40(HandleRef pThis);

		public void SetCellTypeToHexahedron()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToHexahedron_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCell_SetCellTypeToLine_41(HandleRef pThis);

		public void SetCellTypeToLine()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToLine_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCell_SetCellTypeToPentagonalPrism_42(HandleRef pThis);

		public void SetCellTypeToPentagonalPrism()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToPentagonalPrism_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCell_SetCellTypeToPixel_43(HandleRef pThis);

		public void SetCellTypeToPixel()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToPixel_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCell_SetCellTypeToPolyLine_44(HandleRef pThis);

		public void SetCellTypeToPolyLine()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToPolyLine_44(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCell_SetCellTypeToPolyVertex_45(HandleRef pThis);

		public void SetCellTypeToPolyVertex()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToPolyVertex_45(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCell_SetCellTypeToPolygon_46(HandleRef pThis);

		public void SetCellTypeToPolygon()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToPolygon_46(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCell_SetCellTypeToPolyhedron_47(HandleRef pThis);

		public void SetCellTypeToPolyhedron()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToPolyhedron_47(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCell_SetCellTypeToPyramid_48(HandleRef pThis);

		public void SetCellTypeToPyramid()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToPyramid_48(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCell_SetCellTypeToQuad_49(HandleRef pThis);

		public void SetCellTypeToQuad()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToQuad_49(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCell_SetCellTypeToQuadraticEdge_50(HandleRef pThis);

		public void SetCellTypeToQuadraticEdge()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToQuadraticEdge_50(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCell_SetCellTypeToQuadraticHexahedron_51(HandleRef pThis);

		public void SetCellTypeToQuadraticHexahedron()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToQuadraticHexahedron_51(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCell_SetCellTypeToQuadraticLinearQuad_52(HandleRef pThis);

		public void SetCellTypeToQuadraticLinearQuad()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToQuadraticLinearQuad_52(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCell_SetCellTypeToQuadraticLinearWedge_53(HandleRef pThis);

		public void SetCellTypeToQuadraticLinearWedge()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToQuadraticLinearWedge_53(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCell_SetCellTypeToQuadraticPyramid_54(HandleRef pThis);

		public void SetCellTypeToQuadraticPyramid()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToQuadraticPyramid_54(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCell_SetCellTypeToQuadraticQuad_55(HandleRef pThis);

		public void SetCellTypeToQuadraticQuad()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToQuadraticQuad_55(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCell_SetCellTypeToQuadraticTetra_56(HandleRef pThis);

		public void SetCellTypeToQuadraticTetra()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToQuadraticTetra_56(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCell_SetCellTypeToQuadraticTriangle_57(HandleRef pThis);

		public void SetCellTypeToQuadraticTriangle()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToQuadraticTriangle_57(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCell_SetCellTypeToQuadraticWedge_58(HandleRef pThis);

		public void SetCellTypeToQuadraticWedge()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToQuadraticWedge_58(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCell_SetCellTypeToTetra_59(HandleRef pThis);

		public void SetCellTypeToTetra()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToTetra_59(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCell_SetCellTypeToTriQuadraticHexahedron_60(HandleRef pThis);

		public void SetCellTypeToTriQuadraticHexahedron()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToTriQuadraticHexahedron_60(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCell_SetCellTypeToTriangle_61(HandleRef pThis);

		public void SetCellTypeToTriangle()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToTriangle_61(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCell_SetCellTypeToTriangleStrip_62(HandleRef pThis);

		public void SetCellTypeToTriangleStrip()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToTriangleStrip_62(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCell_SetCellTypeToVertex_63(HandleRef pThis);

		public void SetCellTypeToVertex()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToVertex_63(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCell_SetCellTypeToVoxel_64(HandleRef pThis);

		public void SetCellTypeToVoxel()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToVoxel_64(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCell_SetCellTypeToWedge_65(HandleRef pThis);

		public void SetCellTypeToWedge()
		{
			vtkGenericCell.vtkGenericCell_SetCellTypeToWedge_65(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCell_SetFaces_66(HandleRef pThis, IntPtr faces);

		public override void SetFaces(IntPtr faces)
		{
			vtkGenericCell.vtkGenericCell_SetFaces_66(base.GetCppThis(), faces);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericCell_ShallowCopy_67(HandleRef pThis, HandleRef c);

		public override void ShallowCopy(vtkCell c)
		{
			vtkGenericCell.vtkGenericCell_ShallowCopy_67(base.GetCppThis(), (c == null) ? default(HandleRef) : c.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericCell_Triangulate_68(HandleRef pThis, int index, HandleRef ptIds, HandleRef pts);

		public override int Triangulate(int index, vtkIdList ptIds, vtkPoints pts)
		{
			return vtkGenericCell.vtkGenericCell_Triangulate_68(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis(), (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}
	}
}
