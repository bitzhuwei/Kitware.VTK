using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkGenericAdaptorCell : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericAdaptorCell";

		public new static readonly string MRClassNameKey;

		static vtkGenericAdaptorCell()
		{
			vtkGenericAdaptorCell.MRClassNameKey = "class vtkGenericAdaptorCell";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericAdaptorCell.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericAdaptorCell"));
		}

		public vtkGenericAdaptorCell(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericAdaptorCell_Clip_01(HandleRef pThis, double value, HandleRef f, HandleRef attributes, HandleRef tess, int insideOut, HandleRef locator, HandleRef connectivity, HandleRef outPd, HandleRef outCd, HandleRef internalPd, HandleRef secondaryPd, HandleRef secondaryCd);

		public virtual void Clip(double value, vtkImplicitFunction f, vtkGenericAttributeCollection attributes, vtkGenericCellTessellator tess, int insideOut, vtkIncrementalPointLocator locator, vtkCellArray connectivity, vtkPointData outPd, vtkCellData outCd, vtkPointData internalPd, vtkPointData secondaryPd, vtkCellData secondaryCd)
		{
			vtkGenericAdaptorCell.vtkGenericAdaptorCell_Clip_01(base.GetCppThis(), value, (f == null) ? default(HandleRef) : f.GetCppThis(), (attributes == null) ? default(HandleRef) : attributes.GetCppThis(), (tess == null) ? default(HandleRef) : tess.GetCppThis(), insideOut, (locator == null) ? default(HandleRef) : locator.GetCppThis(), (connectivity == null) ? default(HandleRef) : connectivity.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), (internalPd == null) ? default(HandleRef) : internalPd.GetCppThis(), (secondaryPd == null) ? default(HandleRef) : secondaryPd.GetCppThis(), (secondaryCd == null) ? default(HandleRef) : secondaryCd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericAdaptorCell_Contour_02(HandleRef pThis, HandleRef values, HandleRef f, HandleRef attributes, HandleRef tess, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef outPd, HandleRef outCd, HandleRef internalPd, HandleRef secondaryPd, HandleRef secondaryCd);

		public virtual void Contour(vtkContourValues values, vtkImplicitFunction f, vtkGenericAttributeCollection attributes, vtkGenericCellTessellator tess, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData outPd, vtkCellData outCd, vtkPointData internalPd, vtkPointData secondaryPd, vtkCellData secondaryCd)
		{
			vtkGenericAdaptorCell.vtkGenericAdaptorCell_Contour_02(base.GetCppThis(), (values == null) ? default(HandleRef) : values.GetCppThis(), (f == null) ? default(HandleRef) : f.GetCppThis(), (attributes == null) ? default(HandleRef) : attributes.GetCppThis(), (tess == null) ? default(HandleRef) : tess.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), (internalPd == null) ? default(HandleRef) : internalPd.GetCppThis(), (secondaryPd == null) ? default(HandleRef) : secondaryPd.GetCppThis(), (secondaryCd == null) ? default(HandleRef) : secondaryCd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericAdaptorCell_CountEdgeNeighbors_03(HandleRef pThis, IntPtr sharing);

		public virtual void CountEdgeNeighbors(IntPtr sharing)
		{
			vtkGenericAdaptorCell.vtkGenericAdaptorCell_CountEdgeNeighbors_03(base.GetCppThis(), sharing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericAdaptorCell_CountNeighbors_04(HandleRef pThis, HandleRef boundary);

		public virtual int CountNeighbors(vtkGenericAdaptorCell boundary)
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_CountNeighbors_04(base.GetCppThis(), (boundary == null) ? default(HandleRef) : boundary.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericAdaptorCell_Derivatives_05(HandleRef pThis, int subId, IntPtr pcoords, HandleRef attribute, IntPtr derivs);

		public virtual void Derivatives(int subId, IntPtr pcoords, vtkGenericAttribute attribute, IntPtr derivs)
		{
			vtkGenericAdaptorCell.vtkGenericAdaptorCell_Derivatives_05(base.GetCppThis(), subId, pcoords, (attribute == null) ? default(HandleRef) : attribute.GetCppThis(), derivs);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericAdaptorCell_EvaluateLocation_06(HandleRef pThis, int subId, IntPtr pcoords, IntPtr x);

		public virtual void EvaluateLocation(int subId, IntPtr pcoords, IntPtr x)
		{
			vtkGenericAdaptorCell.vtkGenericAdaptorCell_EvaluateLocation_06(base.GetCppThis(), subId, pcoords, x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericAdaptorCell_EvaluatePosition_07(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2);

		public virtual int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2)
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_EvaluatePosition_07(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericAdaptorCell_FindClosestBoundary_08(HandleRef pThis, int subId, IntPtr pcoords, HandleRef boundary);

		public virtual int FindClosestBoundary(int subId, IntPtr pcoords, vtkGenericCellIterator boundary)
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_FindClosestBoundary_08(base.GetCppThis(), subId, pcoords, (boundary == null) ? default(HandleRef) : boundary.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericAdaptorCell_GetAttributeOrder_09(HandleRef pThis, HandleRef a);

		public virtual int GetAttributeOrder(vtkGenericAttribute a)
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_GetAttributeOrder_09(base.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericAdaptorCell_GetBoundaryIterator_10(HandleRef pThis, HandleRef boundaries, int dim);

		public virtual void GetBoundaryIterator(vtkGenericCellIterator boundaries, int dim)
		{
			vtkGenericAdaptorCell.vtkGenericAdaptorCell_GetBoundaryIterator_10(base.GetCppThis(), (boundaries == null) ? default(HandleRef) : boundaries.GetCppThis(), dim);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericAdaptorCell_GetBounds_11(HandleRef pThis, IntPtr bounds);

		public virtual void GetBounds(IntPtr bounds)
		{
			vtkGenericAdaptorCell.vtkGenericAdaptorCell_GetBounds_11(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericAdaptorCell_GetBounds_12(HandleRef pThis);

		public virtual IntPtr GetBounds()
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_GetBounds_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericAdaptorCell_GetDimension_13(HandleRef pThis);

		public virtual int GetDimension()
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_GetDimension_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericAdaptorCell_GetEdgeArray_14(HandleRef pThis, int edgeId);

		public virtual IntPtr GetEdgeArray(int edgeId)
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_GetEdgeArray_14(base.GetCppThis(), edgeId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericAdaptorCell_GetFaceArray_15(HandleRef pThis, int faceId);

		public virtual IntPtr GetFaceArray(int faceId)
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_GetFaceArray_15(base.GetCppThis(), faceId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericAdaptorCell_GetGeometryOrder_16(HandleRef pThis);

		public virtual int GetGeometryOrder()
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_GetGeometryOrder_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericAdaptorCell_GetHighestOrderAttribute_17(HandleRef pThis, HandleRef ac);

		public virtual int GetHighestOrderAttribute(vtkGenericAttributeCollection ac)
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_GetHighestOrderAttribute_17(base.GetCppThis(), (ac == null) ? default(HandleRef) : ac.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkGenericAdaptorCell_GetId_18(HandleRef pThis);

		public virtual long GetId()
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_GetId_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkGenericAdaptorCell_GetLength2_19(HandleRef pThis);

		public virtual double GetLength2()
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_GetLength2_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericAdaptorCell_GetNeighbors_20(HandleRef pThis, HandleRef boundary, HandleRef neighbors);

		public virtual void GetNeighbors(vtkGenericAdaptorCell boundary, vtkGenericCellIterator neighbors)
		{
			vtkGenericAdaptorCell.vtkGenericAdaptorCell_GetNeighbors_20(base.GetCppThis(), (boundary == null) ? default(HandleRef) : boundary.GetCppThis(), (neighbors == null) ? default(HandleRef) : neighbors.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericAdaptorCell_GetNumberOfBoundaries_21(HandleRef pThis, int dim);

		public virtual int GetNumberOfBoundaries(int dim)
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_GetNumberOfBoundaries_21(base.GetCppThis(), dim);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericAdaptorCell_GetNumberOfDOFNodes_22(HandleRef pThis);

		public virtual int GetNumberOfDOFNodes()
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_GetNumberOfDOFNodes_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericAdaptorCell_GetNumberOfPoints_23(HandleRef pThis);

		public virtual int GetNumberOfPoints()
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_GetNumberOfPoints_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericAdaptorCell_GetNumberOfVerticesOnFace_24(HandleRef pThis, int faceId);

		public virtual int GetNumberOfVerticesOnFace(int faceId)
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_GetNumberOfVerticesOnFace_24(base.GetCppThis(), faceId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericAdaptorCell_GetParametricCenter_25(HandleRef pThis, IntPtr pcoords);

		public virtual int GetParametricCenter(IntPtr pcoords)
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_GetParametricCenter_25(base.GetCppThis(), pcoords);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericAdaptorCell_GetParametricCoords_26(HandleRef pThis);

		public virtual IntPtr GetParametricCoords()
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_GetParametricCoords_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkGenericAdaptorCell_GetParametricDistance_27(HandleRef pThis, IntPtr pcoords);

		public virtual double GetParametricDistance(IntPtr pcoords)
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_GetParametricDistance_27(base.GetCppThis(), pcoords);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericAdaptorCell_GetPointIds_28(HandleRef pThis, IntPtr id);

		public virtual void GetPointIds(IntPtr id)
		{
			vtkGenericAdaptorCell.vtkGenericAdaptorCell_GetPointIds_28(base.GetCppThis(), id);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericAdaptorCell_GetPointIterator_29(HandleRef pThis, HandleRef it);

		public virtual void GetPointIterator(vtkGenericPointIterator it)
		{
			vtkGenericAdaptorCell.vtkGenericAdaptorCell_GetPointIterator_29(base.GetCppThis(), (it == null) ? default(HandleRef) : it.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericAdaptorCell_GetType_30(HandleRef pThis);

		public virtual int GetTypeWrapper()
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_GetType_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericAdaptorCell_InterpolateTuple_31(HandleRef pThis, HandleRef a, IntPtr pcoords, IntPtr val);

		public virtual void InterpolateTuple(vtkGenericAttribute a, IntPtr pcoords, IntPtr val)
		{
			vtkGenericAdaptorCell.vtkGenericAdaptorCell_InterpolateTuple_31(base.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis(), pcoords, val);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericAdaptorCell_InterpolateTuple_32(HandleRef pThis, HandleRef c, IntPtr pcoords, IntPtr val);

		public virtual void InterpolateTuple(vtkGenericAttributeCollection c, IntPtr pcoords, IntPtr val)
		{
			vtkGenericAdaptorCell.vtkGenericAdaptorCell_InterpolateTuple_32(base.GetCppThis(), (c == null) ? default(HandleRef) : c.GetCppThis(), pcoords, val);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericAdaptorCell_IntersectWithLine_33(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		public virtual int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_IntersectWithLine_33(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericAdaptorCell_IsA_34(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_IsA_34(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericAdaptorCell_IsAttributeLinear_35(HandleRef pThis, HandleRef a);

		public int IsAttributeLinear(vtkGenericAttribute a)
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_IsAttributeLinear_35(base.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericAdaptorCell_IsFaceOnBoundary_36(HandleRef pThis, long faceId);

		public virtual int IsFaceOnBoundary(long faceId)
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_IsFaceOnBoundary_36(base.GetCppThis(), faceId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericAdaptorCell_IsGeometryLinear_37(HandleRef pThis);

		public int IsGeometryLinear()
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_IsGeometryLinear_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericAdaptorCell_IsInDataSet_38(HandleRef pThis);

		public virtual int IsInDataSet()
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_IsInDataSet_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericAdaptorCell_IsOnBoundary_39(HandleRef pThis);

		public virtual int IsOnBoundary()
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_IsOnBoundary_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericAdaptorCell_IsPrimary_40(HandleRef pThis);

		public virtual int IsPrimary()
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_IsPrimary_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGenericAdaptorCell_IsTypeOf_41(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGenericAdaptorCell.vtkGenericAdaptorCell_IsTypeOf_41(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericAdaptorCell_NewCellIterator_42(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkGenericCellIterator NewCellIterator()
		{
			vtkGenericCellIterator vtkGenericCellIterator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericAdaptorCell.vtkGenericAdaptorCell_NewCellIterator_42(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericCellIterator = (vtkGenericCellIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericCellIterator.Register(null);
				}
			}
			return vtkGenericCellIterator;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericAdaptorCell_NewInstance_43(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGenericAdaptorCell NewInstance()
		{
			vtkGenericAdaptorCell result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericAdaptorCell.vtkGenericAdaptorCell_NewInstance_43(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericAdaptorCell)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGenericAdaptorCell_SafeDownCast_44(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGenericAdaptorCell SafeDownCast(vtkObjectBase o)
		{
			vtkGenericAdaptorCell vtkGenericAdaptorCell = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGenericAdaptorCell.vtkGenericAdaptorCell_SafeDownCast_44((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericAdaptorCell = (vtkGenericAdaptorCell)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericAdaptorCell.Register(null);
				}
			}
			return vtkGenericAdaptorCell;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericAdaptorCell_Tessellate_45(HandleRef pThis, HandleRef attributes, HandleRef tess, HandleRef points, HandleRef locator, HandleRef cellArray, HandleRef internalPd, HandleRef pd, HandleRef cd, HandleRef types);

		public virtual void Tessellate(vtkGenericAttributeCollection attributes, vtkGenericCellTessellator tess, vtkPoints points, vtkIncrementalPointLocator locator, vtkCellArray cellArray, vtkPointData internalPd, vtkPointData pd, vtkCellData cd, vtkUnsignedCharArray types)
		{
			vtkGenericAdaptorCell.vtkGenericAdaptorCell_Tessellate_45(base.GetCppThis(), (attributes == null) ? default(HandleRef) : attributes.GetCppThis(), (tess == null) ? default(HandleRef) : tess.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (cellArray == null) ? default(HandleRef) : cellArray.GetCppThis(), (internalPd == null) ? default(HandleRef) : internalPd.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis(), (cd == null) ? default(HandleRef) : cd.GetCppThis(), (types == null) ? default(HandleRef) : types.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGenericAdaptorCell_TriangulateFace_46(HandleRef pThis, HandleRef attributes, HandleRef tess, int index, HandleRef points, HandleRef locator, HandleRef cellArray, HandleRef internalPd, HandleRef pd, HandleRef cd);

		public virtual void TriangulateFace(vtkGenericAttributeCollection attributes, vtkGenericCellTessellator tess, int index, vtkPoints points, vtkIncrementalPointLocator locator, vtkCellArray cellArray, vtkPointData internalPd, vtkPointData pd, vtkCellData cd)
		{
			vtkGenericAdaptorCell.vtkGenericAdaptorCell_TriangulateFace_46(base.GetCppThis(), (attributes == null) ? default(HandleRef) : attributes.GetCppThis(), (tess == null) ? default(HandleRef) : tess.GetCppThis(), index, (points == null) ? default(HandleRef) : points.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (cellArray == null) ? default(HandleRef) : cellArray.GetCppThis(), (internalPd == null) ? default(HandleRef) : internalPd.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis(), (cd == null) ? default(HandleRef) : cd.GetCppThis());
		}
	}
}
