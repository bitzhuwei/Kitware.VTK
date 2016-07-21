using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMutableUndirectedGraph : vtkUndirectedGraph
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMutableUndirectedGraph";

		public new static readonly string MRClassNameKey;

		static vtkMutableUndirectedGraph()
		{
			vtkMutableUndirectedGraph.MRClassNameKey = "class vtkMutableUndirectedGraph";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMutableUndirectedGraph.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMutableUndirectedGraph"));
		}

		public vtkMutableUndirectedGraph(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkMutableUndirectedGraph_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMutableUndirectedGraph New()
		{
			vtkMutableUndirectedGraph result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMutableUndirectedGraph.vtkMutableUndirectedGraph_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMutableUndirectedGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMutableUndirectedGraph() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMutableUndirectedGraph.vtkMutableUndirectedGraph_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkMutableUndirectedGraph_AddGraphEdge_01(HandleRef pThis, long u, long v, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkGraphEdge AddGraphEdge(long u, long v)
		{
			vtkGraphEdge vtkGraphEdge = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMutableUndirectedGraph.vtkMutableUndirectedGraph_AddGraphEdge_01(base.GetCppThis(), u, v, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraphEdge = (vtkGraphEdge)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraphEdge.Register(null);
				}
			}
			return vtkGraphEdge;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkMutableUndirectedGraph_AddVertex_02(HandleRef pThis);

		public long AddVertex()
		{
			return vtkMutableUndirectedGraph.vtkMutableUndirectedGraph_AddVertex_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkMutableUndirectedGraph_AddVertex_03(HandleRef pThis, HandleRef propertyArr);

		public long AddVertex(vtkVariantArray propertyArr)
		{
			return vtkMutableUndirectedGraph.vtkMutableUndirectedGraph_AddVertex_03(base.GetCppThis(), (propertyArr == null) ? default(HandleRef) : propertyArr.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkMutableUndirectedGraph_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMutableUndirectedGraph.vtkMutableUndirectedGraph_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkMutableUndirectedGraph_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMutableUndirectedGraph.vtkMutableUndirectedGraph_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkMutableUndirectedGraph_LazyAddEdge_06(HandleRef pThis, long u, long v);

		public void LazyAddEdge(long u, long v)
		{
			vtkMutableUndirectedGraph.vtkMutableUndirectedGraph_LazyAddEdge_06(base.GetCppThis(), u, v);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkMutableUndirectedGraph_LazyAddEdge_07(HandleRef pThis, long u, long v, HandleRef propertyArr);

		public void LazyAddEdge(long u, long v, vtkVariantArray propertyArr)
		{
			vtkMutableUndirectedGraph.vtkMutableUndirectedGraph_LazyAddEdge_07(base.GetCppThis(), u, v, (propertyArr == null) ? default(HandleRef) : propertyArr.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkMutableUndirectedGraph_LazyAddVertex_08(HandleRef pThis);

		public void LazyAddVertex()
		{
			vtkMutableUndirectedGraph.vtkMutableUndirectedGraph_LazyAddVertex_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkMutableUndirectedGraph_LazyAddVertex_09(HandleRef pThis, HandleRef propertyArr);

		public void LazyAddVertex(vtkVariantArray propertyArr)
		{
			vtkMutableUndirectedGraph.vtkMutableUndirectedGraph_LazyAddVertex_09(base.GetCppThis(), (propertyArr == null) ? default(HandleRef) : propertyArr.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkMutableUndirectedGraph_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMutableUndirectedGraph NewInstance()
		{
			vtkMutableUndirectedGraph result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMutableUndirectedGraph.vtkMutableUndirectedGraph_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMutableUndirectedGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkMutableUndirectedGraph_RemoveEdge_12(HandleRef pThis, long e);

		public void RemoveEdge(long e)
		{
			vtkMutableUndirectedGraph.vtkMutableUndirectedGraph_RemoveEdge_12(base.GetCppThis(), e);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkMutableUndirectedGraph_RemoveEdges_13(HandleRef pThis, HandleRef arr);

		public void RemoveEdges(vtkIdTypeArray arr)
		{
			vtkMutableUndirectedGraph.vtkMutableUndirectedGraph_RemoveEdges_13(base.GetCppThis(), (arr == null) ? default(HandleRef) : arr.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkMutableUndirectedGraph_RemoveVertex_14(HandleRef pThis, long v);

		public void RemoveVertex(long v)
		{
			vtkMutableUndirectedGraph.vtkMutableUndirectedGraph_RemoveVertex_14(base.GetCppThis(), v);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkMutableUndirectedGraph_RemoveVertices_15(HandleRef pThis, HandleRef arr);

		public void RemoveVertices(vtkIdTypeArray arr)
		{
			vtkMutableUndirectedGraph.vtkMutableUndirectedGraph_RemoveVertices_15(base.GetCppThis(), (arr == null) ? default(HandleRef) : arr.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkMutableUndirectedGraph_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMutableUndirectedGraph SafeDownCast(vtkObjectBase o)
		{
			vtkMutableUndirectedGraph vtkMutableUndirectedGraph = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMutableUndirectedGraph.vtkMutableUndirectedGraph_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMutableUndirectedGraph = (vtkMutableUndirectedGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMutableUndirectedGraph.Register(null);
				}
			}
			return vtkMutableUndirectedGraph;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkMutableUndirectedGraph_SetNumberOfVertices_17(HandleRef pThis, long numVerts);

		public virtual long SetNumberOfVertices(long numVerts)
		{
			return vtkMutableUndirectedGraph.vtkMutableUndirectedGraph_SetNumberOfVertices_17(base.GetCppThis(), numVerts);
		}
	}
}
