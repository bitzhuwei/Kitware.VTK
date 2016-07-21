using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMutableDirectedGraph : vtkDirectedGraph
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMutableDirectedGraph";

		public new static readonly string MRClassNameKey;

		static vtkMutableDirectedGraph()
		{
			vtkMutableDirectedGraph.MRClassNameKey = "class vtkMutableDirectedGraph";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMutableDirectedGraph.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMutableDirectedGraph"));
		}

		public vtkMutableDirectedGraph(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkMutableDirectedGraph_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMutableDirectedGraph New()
		{
			vtkMutableDirectedGraph result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMutableDirectedGraph.vtkMutableDirectedGraph_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMutableDirectedGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMutableDirectedGraph() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMutableDirectedGraph.vtkMutableDirectedGraph_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkMutableDirectedGraph_AddChild_01(HandleRef pThis, long parent, HandleRef propertyArr);

		public long AddChild(long parent, vtkVariantArray propertyArr)
		{
			return vtkMutableDirectedGraph.vtkMutableDirectedGraph_AddChild_01(base.GetCppThis(), parent, (propertyArr == null) ? default(HandleRef) : propertyArr.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkMutableDirectedGraph_AddChild_02(HandleRef pThis, long parent);

		public long AddChild(long parent)
		{
			return vtkMutableDirectedGraph.vtkMutableDirectedGraph_AddChild_02(base.GetCppThis(), parent);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkMutableDirectedGraph_AddGraphEdge_03(HandleRef pThis, long u, long v, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkGraphEdge AddGraphEdge(long u, long v)
		{
			vtkGraphEdge vtkGraphEdge = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMutableDirectedGraph.vtkMutableDirectedGraph_AddGraphEdge_03(base.GetCppThis(), u, v, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern long vtkMutableDirectedGraph_AddVertex_04(HandleRef pThis);

		public long AddVertex()
		{
			return vtkMutableDirectedGraph.vtkMutableDirectedGraph_AddVertex_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkMutableDirectedGraph_AddVertex_05(HandleRef pThis, HandleRef propertyArr);

		public long AddVertex(vtkVariantArray propertyArr)
		{
			return vtkMutableDirectedGraph.vtkMutableDirectedGraph_AddVertex_05(base.GetCppThis(), (propertyArr == null) ? default(HandleRef) : propertyArr.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkMutableDirectedGraph_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMutableDirectedGraph.vtkMutableDirectedGraph_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkMutableDirectedGraph_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMutableDirectedGraph.vtkMutableDirectedGraph_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkMutableDirectedGraph_LazyAddEdge_08(HandleRef pThis, long u, long v, HandleRef propertyArr);

		public void LazyAddEdge(long u, long v, vtkVariantArray propertyArr)
		{
			vtkMutableDirectedGraph.vtkMutableDirectedGraph_LazyAddEdge_08(base.GetCppThis(), u, v, (propertyArr == null) ? default(HandleRef) : propertyArr.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkMutableDirectedGraph_LazyAddVertex_09(HandleRef pThis);

		public void LazyAddVertex()
		{
			vtkMutableDirectedGraph.vtkMutableDirectedGraph_LazyAddVertex_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkMutableDirectedGraph_LazyAddVertex_10(HandleRef pThis, HandleRef propertyArr);

		public void LazyAddVertex(vtkVariantArray propertyArr)
		{
			vtkMutableDirectedGraph.vtkMutableDirectedGraph_LazyAddVertex_10(base.GetCppThis(), (propertyArr == null) ? default(HandleRef) : propertyArr.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkMutableDirectedGraph_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMutableDirectedGraph NewInstance()
		{
			vtkMutableDirectedGraph result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMutableDirectedGraph.vtkMutableDirectedGraph_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMutableDirectedGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkMutableDirectedGraph_RemoveEdge_13(HandleRef pThis, long e);

		public void RemoveEdge(long e)
		{
			vtkMutableDirectedGraph.vtkMutableDirectedGraph_RemoveEdge_13(base.GetCppThis(), e);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkMutableDirectedGraph_RemoveEdges_14(HandleRef pThis, HandleRef arr);

		public void RemoveEdges(vtkIdTypeArray arr)
		{
			vtkMutableDirectedGraph.vtkMutableDirectedGraph_RemoveEdges_14(base.GetCppThis(), (arr == null) ? default(HandleRef) : arr.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkMutableDirectedGraph_RemoveVertex_15(HandleRef pThis, long v);

		public void RemoveVertex(long v)
		{
			vtkMutableDirectedGraph.vtkMutableDirectedGraph_RemoveVertex_15(base.GetCppThis(), v);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkMutableDirectedGraph_RemoveVertices_16(HandleRef pThis, HandleRef arr);

		public void RemoveVertices(vtkIdTypeArray arr)
		{
			vtkMutableDirectedGraph.vtkMutableDirectedGraph_RemoveVertices_16(base.GetCppThis(), (arr == null) ? default(HandleRef) : arr.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkMutableDirectedGraph_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMutableDirectedGraph SafeDownCast(vtkObjectBase o)
		{
			vtkMutableDirectedGraph vtkMutableDirectedGraph = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMutableDirectedGraph.vtkMutableDirectedGraph_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMutableDirectedGraph = (vtkMutableDirectedGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMutableDirectedGraph.Register(null);
				}
			}
			return vtkMutableDirectedGraph;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkMutableDirectedGraph_SetNumberOfVertices_18(HandleRef pThis, long numVerts);

		public virtual long SetNumberOfVertices(long numVerts)
		{
			return vtkMutableDirectedGraph.vtkMutableDirectedGraph_SetNumberOfVertices_18(base.GetCppThis(), numVerts);
		}
	}
}
