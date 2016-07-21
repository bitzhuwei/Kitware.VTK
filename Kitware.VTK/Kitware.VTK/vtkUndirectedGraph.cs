using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkUndirectedGraph : vtkGraph
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkUndirectedGraph";

		public new static readonly string MRClassNameKey;

		static vtkUndirectedGraph()
		{
			vtkUndirectedGraph.MRClassNameKey = "class vtkUndirectedGraph";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUndirectedGraph.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUndirectedGraph"));
		}

		public vtkUndirectedGraph(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkUndirectedGraph_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUndirectedGraph New()
		{
			vtkUndirectedGraph result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUndirectedGraph.vtkUndirectedGraph_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUndirectedGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkUndirectedGraph() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkUndirectedGraph.vtkUndirectedGraph_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkUndirectedGraph_GetData_01(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUndirectedGraph GetData(vtkInformation info)
		{
			vtkUndirectedGraph vtkUndirectedGraph = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUndirectedGraph.vtkUndirectedGraph_GetData_01((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUndirectedGraph = (vtkUndirectedGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUndirectedGraph.Register(null);
				}
			}
			return vtkUndirectedGraph;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkUndirectedGraph_GetData_02(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUndirectedGraph GetData(vtkInformationVector v, int i)
		{
			vtkUndirectedGraph vtkUndirectedGraph = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUndirectedGraph.vtkUndirectedGraph_GetData_02((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUndirectedGraph = (vtkUndirectedGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUndirectedGraph.Register(null);
				}
			}
			return vtkUndirectedGraph;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkUndirectedGraph_GetDataObjectType_03(HandleRef pThis);

		public override int GetDataObjectType()
		{
			return vtkUndirectedGraph.vtkUndirectedGraph_GetDataObjectType_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkUndirectedGraph_GetInDegree_04(HandleRef pThis, long v);

		public override long GetInDegree(long v)
		{
			return vtkUndirectedGraph.vtkUndirectedGraph_GetInDegree_04(base.GetCppThis(), v);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUndirectedGraph_GetInEdge_05(HandleRef pThis, long v, long i, HandleRef e);

		public override void GetInEdge(long v, long i, vtkGraphEdge e)
		{
			vtkUndirectedGraph.vtkUndirectedGraph_GetInEdge_05(base.GetCppThis(), v, i, (e == null) ? default(HandleRef) : e.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUndirectedGraph_GetInEdges_06(HandleRef pThis, long v, HandleRef it);

		public override void GetInEdges(long v, vtkInEdgeIterator it)
		{
			vtkUndirectedGraph.vtkUndirectedGraph_GetInEdges_06(base.GetCppThis(), v, (it == null) ? default(HandleRef) : it.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkUndirectedGraph_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkUndirectedGraph.vtkUndirectedGraph_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern byte vtkUndirectedGraph_IsStructureValid_08(HandleRef pThis, HandleRef g);

		public virtual bool IsStructureValid(vtkGraph g)
		{
			return vtkUndirectedGraph.vtkUndirectedGraph_IsStructureValid_08(base.GetCppThis(), (g == null) ? default(HandleRef) : g.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkUndirectedGraph_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkUndirectedGraph.vtkUndirectedGraph_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkUndirectedGraph_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkUndirectedGraph NewInstance()
		{
			vtkUndirectedGraph result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUndirectedGraph.vtkUndirectedGraph_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUndirectedGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkUndirectedGraph_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUndirectedGraph SafeDownCast(vtkObjectBase o)
		{
			vtkUndirectedGraph vtkUndirectedGraph = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUndirectedGraph.vtkUndirectedGraph_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUndirectedGraph = (vtkUndirectedGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUndirectedGraph.Register(null);
				}
			}
			return vtkUndirectedGraph;
		}
	}
}
