using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTriQuadraticHexahedron : vtkNonLinearCell
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTriQuadraticHexahedron";

		public new static readonly string MRClassNameKey;

		static vtkTriQuadraticHexahedron()
		{
			vtkTriQuadraticHexahedron.MRClassNameKey = "class vtkTriQuadraticHexahedron";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTriQuadraticHexahedron.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTriQuadraticHexahedron"));
		}

		public vtkTriQuadraticHexahedron(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkTriQuadraticHexahedron_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTriQuadraticHexahedron New()
		{
			vtkTriQuadraticHexahedron result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTriQuadraticHexahedron)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTriQuadraticHexahedron() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkTriQuadraticHexahedron_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_CellBoundary_01(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkTriQuadraticHexahedron_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef tetras, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray tetras, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_Clip_02(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (tetras == null) ? default(HandleRef) : tetras.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkTriQuadraticHexahedron_Contour_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_Contour_03(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkTriQuadraticHexahedron_Derivatives_04(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_Derivatives_04(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkTriQuadraticHexahedron_EvaluateLocation_05(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_EvaluateLocation_05(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkTriQuadraticHexahedron_EvaluatePosition_06(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_EvaluatePosition_06(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkTriQuadraticHexahedron_GetCellDimension_07(HandleRef pThis);

		public override int GetCellDimension()
		{
			return vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_GetCellDimension_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkTriQuadraticHexahedron_GetCellType_08(HandleRef pThis);

		public override int GetCellType()
		{
			return vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_GetCellType_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkTriQuadraticHexahedron_GetEdge_09(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkCell GetEdge(int arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_GetEdge_09(base.GetCppThis(), arg0, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkTriQuadraticHexahedron_GetEdgeArray_10(int edgeId);

		public static IntPtr GetEdgeArray(int edgeId)
		{
			return vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_GetEdgeArray_10(edgeId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkTriQuadraticHexahedron_GetFace_11(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkCell GetFace(int arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_GetFace_11(base.GetCppThis(), arg0, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkTriQuadraticHexahedron_GetFaceArray_12(int faceId);

		public static IntPtr GetFaceArray(int faceId)
		{
			return vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_GetFaceArray_12(faceId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkTriQuadraticHexahedron_GetNumberOfEdges_13(HandleRef pThis);

		public override int GetNumberOfEdges()
		{
			return vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_GetNumberOfEdges_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkTriQuadraticHexahedron_GetNumberOfFaces_14(HandleRef pThis);

		public override int GetNumberOfFaces()
		{
			return vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_GetNumberOfFaces_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkTriQuadraticHexahedron_GetParametricCoords_15(HandleRef pThis);

		public override IntPtr GetParametricCoords()
		{
			return vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_GetParametricCoords_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkTriQuadraticHexahedron_InterpolateDerivs_16(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_InterpolateDerivs_16(base.GetCppThis(), pcoords, derivs);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkTriQuadraticHexahedron_InterpolateFunctions_17(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_InterpolateFunctions_17(base.GetCppThis(), pcoords, weights);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkTriQuadraticHexahedron_InterpolationDerivs_18(IntPtr pcoords, IntPtr derivs);

		public static void InterpolationDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_InterpolationDerivs_18(pcoords, derivs);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkTriQuadraticHexahedron_InterpolationFunctions_19(IntPtr pcoords, IntPtr weights);

		public static void InterpolationFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_InterpolationFunctions_19(pcoords, weights);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkTriQuadraticHexahedron_IntersectWithLine_20(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_IntersectWithLine_20(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkTriQuadraticHexahedron_IsA_21(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_IsA_21(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkTriQuadraticHexahedron_IsTypeOf_22(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_IsTypeOf_22(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkTriQuadraticHexahedron_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTriQuadraticHexahedron NewInstance()
		{
			vtkTriQuadraticHexahedron result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_NewInstance_24(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTriQuadraticHexahedron)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkTriQuadraticHexahedron_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTriQuadraticHexahedron SafeDownCast(vtkObjectBase o)
		{
			vtkTriQuadraticHexahedron vtkTriQuadraticHexahedron = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTriQuadraticHexahedron = (vtkTriQuadraticHexahedron)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTriQuadraticHexahedron.Register(null);
				}
			}
			return vtkTriQuadraticHexahedron;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkTriQuadraticHexahedron_Triangulate_26(HandleRef pThis, int index, HandleRef ptIds, HandleRef pts);

		public override int Triangulate(int index, vtkIdList ptIds, vtkPoints pts)
		{
			return vtkTriQuadraticHexahedron.vtkTriQuadraticHexahedron_Triangulate_26(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis(), (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}
	}
}
