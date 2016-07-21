using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkHexagonalPrism : vtkCell3D
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkHexagonalPrism";

		public new static readonly string MRClassNameKey;

		static vtkHexagonalPrism()
		{
			vtkHexagonalPrism.MRClassNameKey = "class vtkHexagonalPrism";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHexagonalPrism.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHexagonalPrism"));
		}

		public vtkHexagonalPrism(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHexagonalPrism_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHexagonalPrism New()
		{
			vtkHexagonalPrism result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHexagonalPrism.vtkHexagonalPrism_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHexagonalPrism)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkHexagonalPrism() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkHexagonalPrism.vtkHexagonalPrism_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHexagonalPrism_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkHexagonalPrism.vtkHexagonalPrism_CellBoundary_01(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHexagonalPrism_Derivatives_02(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkHexagonalPrism.vtkHexagonalPrism_Derivatives_02(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHexagonalPrism_EvaluateLocation_03(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkHexagonalPrism.vtkHexagonalPrism_EvaluateLocation_03(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHexagonalPrism_EvaluatePosition_04(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkHexagonalPrism.vtkHexagonalPrism_EvaluatePosition_04(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHexagonalPrism_GetCellDimension_05(HandleRef pThis);

		public override int GetCellDimension()
		{
			return vtkHexagonalPrism.vtkHexagonalPrism_GetCellDimension_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHexagonalPrism_GetCellType_06(HandleRef pThis);

		public override int GetCellType()
		{
			return vtkHexagonalPrism.vtkHexagonalPrism_GetCellType_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHexagonalPrism_GetEdge_07(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkCell GetEdge(int edgeId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHexagonalPrism.vtkHexagonalPrism_GetEdge_07(base.GetCppThis(), edgeId, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkHexagonalPrism_GetEdgeArray_08(int edgeId);

		public static IntPtr GetEdgeArray(int edgeId)
		{
			return vtkHexagonalPrism.vtkHexagonalPrism_GetEdgeArray_08(edgeId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHexagonalPrism_GetFace_09(HandleRef pThis, int faceId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkCell GetFace(int faceId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHexagonalPrism.vtkHexagonalPrism_GetFace_09(base.GetCppThis(), faceId, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkHexagonalPrism_GetFaceArray_10(int faceId);

		public static IntPtr GetFaceArray(int faceId)
		{
			return vtkHexagonalPrism.vtkHexagonalPrism_GetFaceArray_10(faceId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHexagonalPrism_GetNumberOfEdges_11(HandleRef pThis);

		public override int GetNumberOfEdges()
		{
			return vtkHexagonalPrism.vtkHexagonalPrism_GetNumberOfEdges_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHexagonalPrism_GetNumberOfFaces_12(HandleRef pThis);

		public override int GetNumberOfFaces()
		{
			return vtkHexagonalPrism.vtkHexagonalPrism_GetNumberOfFaces_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHexagonalPrism_GetParametricCenter_13(HandleRef pThis, IntPtr pcoords);

		public override int GetParametricCenter(IntPtr pcoords)
		{
			return vtkHexagonalPrism.vtkHexagonalPrism_GetParametricCenter_13(base.GetCppThis(), pcoords);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHexagonalPrism_GetParametricCoords_14(HandleRef pThis);

		public override IntPtr GetParametricCoords()
		{
			return vtkHexagonalPrism.vtkHexagonalPrism_GetParametricCoords_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHexagonalPrism_InterpolateDerivs_15(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkHexagonalPrism.vtkHexagonalPrism_InterpolateDerivs_15(base.GetCppThis(), pcoords, derivs);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHexagonalPrism_InterpolateFunctions_16(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkHexagonalPrism.vtkHexagonalPrism_InterpolateFunctions_16(base.GetCppThis(), pcoords, weights);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHexagonalPrism_InterpolationDerivs_17(IntPtr pcoords, IntPtr derivs);

		public static void InterpolationDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkHexagonalPrism.vtkHexagonalPrism_InterpolationDerivs_17(pcoords, derivs);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkHexagonalPrism_InterpolationFunctions_18(IntPtr pcoords, IntPtr weights);

		public static void InterpolationFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkHexagonalPrism.vtkHexagonalPrism_InterpolationFunctions_18(pcoords, weights);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHexagonalPrism_IntersectWithLine_19(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkHexagonalPrism.vtkHexagonalPrism_IntersectWithLine_19(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHexagonalPrism_IsA_20(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkHexagonalPrism.vtkHexagonalPrism_IsA_20(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHexagonalPrism_IsTypeOf_21(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkHexagonalPrism.vtkHexagonalPrism_IsTypeOf_21(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHexagonalPrism_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkHexagonalPrism NewInstance()
		{
			vtkHexagonalPrism result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHexagonalPrism.vtkHexagonalPrism_NewInstance_23(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHexagonalPrism)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkHexagonalPrism_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHexagonalPrism SafeDownCast(vtkObjectBase o)
		{
			vtkHexagonalPrism vtkHexagonalPrism = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHexagonalPrism.vtkHexagonalPrism_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHexagonalPrism = (vtkHexagonalPrism)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHexagonalPrism.Register(null);
				}
			}
			return vtkHexagonalPrism;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkHexagonalPrism_Triangulate_25(HandleRef pThis, int index, HandleRef ptIds, HandleRef pts);

		public override int Triangulate(int index, vtkIdList ptIds, vtkPoints pts)
		{
			return vtkHexagonalPrism.vtkHexagonalPrism_Triangulate_25(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis(), (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}
	}
}
