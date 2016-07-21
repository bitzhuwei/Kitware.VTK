using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkGraph : vtkDataObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGraph";

		public new static readonly string MRClassNameKey;

		static vtkGraph()
		{
			vtkGraph.MRClassNameKey = "class vtkGraph";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGraph.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGraph"));
		}

		public vtkGraph(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGraph_AddEdgePoint_01(HandleRef pThis, long e, IntPtr x);

		public void AddEdgePoint(long e, IntPtr x)
		{
			vtkGraph.vtkGraph_AddEdgePoint_01(base.GetCppThis(), e, x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGraph_AddEdgePoint_02(HandleRef pThis, long e, double x, double y, double z);

		public void AddEdgePoint(long e, double x, double y, double z)
		{
			vtkGraph.vtkGraph_AddEdgePoint_02(base.GetCppThis(), e, x, y, z);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern byte vtkGraph_CheckedDeepCopy_03(HandleRef pThis, HandleRef g);

		public virtual bool CheckedDeepCopy(vtkGraph g)
		{
			return vtkGraph.vtkGraph_CheckedDeepCopy_03(base.GetCppThis(), (g == null) ? default(HandleRef) : g.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern byte vtkGraph_CheckedShallowCopy_04(HandleRef pThis, HandleRef g);

		public virtual bool CheckedShallowCopy(vtkGraph g)
		{
			return vtkGraph.vtkGraph_CheckedShallowCopy_04(base.GetCppThis(), (g == null) ? default(HandleRef) : g.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGraph_ClearEdgePoints_05(HandleRef pThis, long e);

		public void ClearEdgePoints(long e)
		{
			vtkGraph.vtkGraph_ClearEdgePoints_05(base.GetCppThis(), e);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGraph_ComputeBounds_06(HandleRef pThis);

		public void ComputeBounds()
		{
			vtkGraph.vtkGraph_ComputeBounds_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGraph_CopyStructure_07(HandleRef pThis, HandleRef g);

		public virtual void CopyStructure(vtkGraph g)
		{
			vtkGraph.vtkGraph_CopyStructure_07(base.GetCppThis(), (g == null) ? default(HandleRef) : g.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGraph_DeepCopy_08(HandleRef pThis, HandleRef obj);

		public override void DeepCopy(vtkDataObject obj)
		{
			vtkGraph.vtkGraph_DeepCopy_08(base.GetCppThis(), (obj == null) ? default(HandleRef) : obj.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGraph_DeepCopyEdgePoints_09(HandleRef pThis, HandleRef g);

		public void DeepCopyEdgePoints(vtkGraph g)
		{
			vtkGraph.vtkGraph_DeepCopyEdgePoints_09(base.GetCppThis(), (g == null) ? default(HandleRef) : g.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGraph_Dump_10(HandleRef pThis);

		public void Dump()
		{
			vtkGraph.vtkGraph_Dump_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGraph_GetAdjacentVertices_11(HandleRef pThis, long v, HandleRef it);

		public virtual void GetAdjacentVertices(long v, vtkAdjacentVertexIterator it)
		{
			vtkGraph.vtkGraph_GetAdjacentVertices_11(base.GetCppThis(), v, (it == null) ? default(HandleRef) : it.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraph_GetAttributesAsFieldData_12(HandleRef pThis, int type, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkFieldData GetAttributesAsFieldData(int type)
		{
			vtkFieldData vtkFieldData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraph.vtkGraph_GetAttributesAsFieldData_12(base.GetCppThis(), type, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFieldData = (vtkFieldData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFieldData.Register(null);
				}
			}
			return vtkFieldData;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraph_GetBounds_13(HandleRef pThis);

		public IntPtr GetBounds()
		{
			return vtkGraph.vtkGraph_GetBounds_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGraph_GetBounds_14(HandleRef pThis, IntPtr bounds);

		public void GetBounds(IntPtr bounds)
		{
			vtkGraph.vtkGraph_GetBounds_14(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraph_GetData_15(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGraph GetData(vtkInformation info)
		{
			vtkGraph vtkGraph = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraph.vtkGraph_GetData_15((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraph = (vtkGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraph.Register(null);
				}
			}
			return vtkGraph;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraph_GetData_16(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGraph GetData(vtkInformationVector v, int i)
		{
			vtkGraph vtkGraph = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraph.vtkGraph_GetData_16((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraph = (vtkGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraph.Register(null);
				}
			}
			return vtkGraph;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGraph_GetDataObjectType_17(HandleRef pThis);

		public override int GetDataObjectType()
		{
			return vtkGraph.vtkGraph_GetDataObjectType_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkGraph_GetDegree_18(HandleRef pThis, long v);

		public virtual long GetDegree(long v)
		{
			return vtkGraph.vtkGraph_GetDegree_18(base.GetCppThis(), v);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraph_GetDistributedGraphHelper_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDistributedGraphHelper GetDistributedGraphHelper()
		{
			vtkDistributedGraphHelper vtkDistributedGraphHelper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraph.vtkGraph_GetDistributedGraphHelper_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDistributedGraphHelper = (vtkDistributedGraphHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDistributedGraphHelper.Register(null);
				}
			}
			return vtkDistributedGraphHelper;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraph_GetEdgeData_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDataSetAttributes GetEdgeData()
		{
			vtkDataSetAttributes vtkDataSetAttributes = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraph.vtkGraph_GetEdgeData_20(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetAttributes = (vtkDataSetAttributes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetAttributes.Register(null);
				}
			}
			return vtkDataSetAttributes;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkGraph_GetEdgeId_21(HandleRef pThis, long a, long b);

		public long GetEdgeId(long a, long b)
		{
			return vtkGraph.vtkGraph_GetEdgeId_21(base.GetCppThis(), a, b);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraph_GetEdgePoint_22(HandleRef pThis, long e, long i);

		public double[] GetEdgePoint(long e, long i)
		{
			IntPtr intPtr = vtkGraph.vtkGraph_GetEdgePoint_22(base.GetCppThis(), e, i);
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGraph_GetEdges_23(HandleRef pThis, HandleRef it);

		public virtual void GetEdges(vtkEdgeListIterator it)
		{
			vtkGraph.vtkGraph_GetEdges_23(base.GetCppThis(), (it == null) ? default(HandleRef) : it.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraph_GetGraphInternals_24(HandleRef pThis, byte modifying, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkGraphInternals GetGraphInternals(bool modifying)
		{
			vtkGraphInternals vtkGraphInternals = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraph.vtkGraph_GetGraphInternals_24(base.GetCppThis(), modifying ? (byte)1 : (byte)0, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraphInternals = (vtkGraphInternals)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraphInternals.Register(null);
				}
			}
			return vtkGraphInternals;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkGraph_GetInDegree_25(HandleRef pThis, long v);

		public virtual long GetInDegree(long v)
		{
			return vtkGraph.vtkGraph_GetInDegree_25(base.GetCppThis(), v);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGraph_GetInEdge_26(HandleRef pThis, long v, long index, HandleRef e);

		public virtual void GetInEdge(long v, long index, vtkGraphEdge e)
		{
			vtkGraph.vtkGraph_GetInEdge_26(base.GetCppThis(), v, index, (e == null) ? default(HandleRef) : e.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGraph_GetInEdges_27(HandleRef pThis, long v, HandleRef it);

		public virtual void GetInEdges(long v, vtkInEdgeIterator it)
		{
			vtkGraph.vtkGraph_GetInEdges_27(base.GetCppThis(), v, (it == null) ? default(HandleRef) : it.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGraph_GetInducedEdges_28(HandleRef pThis, HandleRef verts, HandleRef edges);

		public void GetInducedEdges(vtkIdTypeArray verts, vtkIdTypeArray edges)
		{
			vtkGraph.vtkGraph_GetInducedEdges_28(base.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (edges == null) ? default(HandleRef) : edges.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern uint vtkGraph_GetMTime_29(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkGraph.vtkGraph_GetMTime_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkGraph_GetNumberOfEdgePoints_30(HandleRef pThis, long e);

		public long GetNumberOfEdgePoints(long e)
		{
			return vtkGraph.vtkGraph_GetNumberOfEdgePoints_30(base.GetCppThis(), e);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkGraph_GetNumberOfEdges_31(HandleRef pThis);

		public virtual long GetNumberOfEdges()
		{
			return vtkGraph.vtkGraph_GetNumberOfEdges_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkGraph_GetNumberOfElements_32(HandleRef pThis, int type);

		public override long GetNumberOfElements(int type)
		{
			return vtkGraph.vtkGraph_GetNumberOfElements_32(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkGraph_GetNumberOfVertices_33(HandleRef pThis);

		public virtual long GetNumberOfVertices()
		{
			return vtkGraph.vtkGraph_GetNumberOfVertices_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkGraph_GetOutDegree_34(HandleRef pThis, long v);

		public virtual long GetOutDegree(long v)
		{
			return vtkGraph.vtkGraph_GetOutDegree_34(base.GetCppThis(), v);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGraph_GetOutEdge_35(HandleRef pThis, long v, long index, HandleRef e);

		public virtual void GetOutEdge(long v, long index, vtkGraphEdge e)
		{
			vtkGraph.vtkGraph_GetOutEdge_35(base.GetCppThis(), v, index, (e == null) ? default(HandleRef) : e.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGraph_GetOutEdges_36(HandleRef pThis, long v, HandleRef it);

		public virtual void GetOutEdges(long v, vtkOutEdgeIterator it)
		{
			vtkGraph.vtkGraph_GetOutEdges_36(base.GetCppThis(), v, (it == null) ? default(HandleRef) : it.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraph_GetPoint_37(HandleRef pThis, long ptId);

		public IntPtr GetPoint(long ptId)
		{
			return vtkGraph.vtkGraph_GetPoint_37(base.GetCppThis(), ptId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGraph_GetPoint_38(HandleRef pThis, long ptId, IntPtr x);

		public void GetPoint(long ptId, IntPtr x)
		{
			vtkGraph.vtkGraph_GetPoint_38(base.GetCppThis(), ptId, x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraph_GetPoints_39(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPoints GetPoints()
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraph.vtkGraph_GetPoints_39(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern long vtkGraph_GetSourceVertex_40(HandleRef pThis, long e);

		public long GetSourceVertex(long e)
		{
			return vtkGraph.vtkGraph_GetSourceVertex_40(base.GetCppThis(), e);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkGraph_GetTargetVertex_41(HandleRef pThis, long e);

		public long GetTargetVertex(long e)
		{
			return vtkGraph.vtkGraph_GetTargetVertex_41(base.GetCppThis(), e);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraph_GetVertexData_42(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDataSetAttributes GetVertexData()
		{
			vtkDataSetAttributes vtkDataSetAttributes = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraph.vtkGraph_GetVertexData_42(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetAttributes = (vtkDataSetAttributes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetAttributes.Register(null);
				}
			}
			return vtkDataSetAttributes;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGraph_GetVertices_43(HandleRef pThis, HandleRef it);

		public virtual void GetVertices(vtkVertexListIterator it)
		{
			vtkGraph.vtkGraph_GetVertices_43(base.GetCppThis(), (it == null) ? default(HandleRef) : it.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGraph_Initialize_44(HandleRef pThis);

		public override void Initialize()
		{
			vtkGraph.vtkGraph_Initialize_44(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGraph_IsA_45(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGraph.vtkGraph_IsA_45(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern byte vtkGraph_IsSameStructure_46(HandleRef pThis, HandleRef other);

		public bool IsSameStructure(vtkGraph other)
		{
			return vtkGraph.vtkGraph_IsSameStructure_46(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkGraph_IsTypeOf_47(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGraph.vtkGraph_IsTypeOf_47(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraph_NewInstance_48(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGraph NewInstance()
		{
			vtkGraph result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraph.vtkGraph_NewInstance_48(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGraph_ReorderOutVertices_49(HandleRef pThis, long v, HandleRef vertices);

		public void ReorderOutVertices(long v, vtkIdTypeArray vertices)
		{
			vtkGraph.vtkGraph_ReorderOutVertices_49(base.GetCppThis(), v, (vertices == null) ? default(HandleRef) : vertices.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraph_SafeDownCast_50(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGraph SafeDownCast(vtkObjectBase o)
		{
			vtkGraph vtkGraph = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraph.vtkGraph_SafeDownCast_50((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraph = (vtkGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraph.Register(null);
				}
			}
			return vtkGraph;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGraph_SetDistributedGraphHelper_51(HandleRef pThis, HandleRef helper);

		public void SetDistributedGraphHelper(vtkDistributedGraphHelper helper)
		{
			vtkGraph.vtkGraph_SetDistributedGraphHelper_51(base.GetCppThis(), (helper == null) ? default(HandleRef) : helper.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGraph_SetEdgePoint_52(HandleRef pThis, long e, long i, IntPtr x);

		public void SetEdgePoint(long e, long i, IntPtr x)
		{
			vtkGraph.vtkGraph_SetEdgePoint_52(base.GetCppThis(), e, i, x);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGraph_SetEdgePoint_53(HandleRef pThis, long e, long i, double x, double y, double z);

		public void SetEdgePoint(long e, long i, double x, double y, double z)
		{
			vtkGraph.vtkGraph_SetEdgePoint_53(base.GetCppThis(), e, i, x, y, z);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGraph_SetEdgePoints_54(HandleRef pThis, long e, long npts, IntPtr pts);

		public void SetEdgePoints(long e, long npts, IntPtr pts)
		{
			vtkGraph.vtkGraph_SetEdgePoints_54(base.GetCppThis(), e, npts, pts);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGraph_SetPoints_55(HandleRef pThis, HandleRef points);

		public virtual void SetPoints(vtkPoints points)
		{
			vtkGraph.vtkGraph_SetPoints_55(base.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGraph_ShallowCopy_56(HandleRef pThis, HandleRef obj);

		public override void ShallowCopy(vtkDataObject obj)
		{
			vtkGraph.vtkGraph_ShallowCopy_56(base.GetCppThis(), (obj == null) ? default(HandleRef) : obj.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGraph_ShallowCopyEdgePoints_57(HandleRef pThis, HandleRef g);

		public void ShallowCopyEdgePoints(vtkGraph g)
		{
			vtkGraph.vtkGraph_ShallowCopyEdgePoints_57(base.GetCppThis(), (g == null) ? default(HandleRef) : g.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkGraph_Squeeze_58(HandleRef pThis);

		public virtual void Squeeze()
		{
			vtkGraph.vtkGraph_Squeeze_58(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern byte vtkGraph_ToDirectedGraph_59(HandleRef pThis, HandleRef g);

		public bool ToDirectedGraph(vtkDirectedGraph g)
		{
			return vtkGraph.vtkGraph_ToDirectedGraph_59(base.GetCppThis(), (g == null) ? default(HandleRef) : g.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern byte vtkGraph_ToUndirectedGraph_60(HandleRef pThis, HandleRef g);

		public bool ToUndirectedGraph(vtkUndirectedGraph g)
		{
			return vtkGraph.vtkGraph_ToUndirectedGraph_60(base.GetCppThis(), (g == null) ? default(HandleRef) : g.GetCppThis()) != 0;
		}
	}
}
