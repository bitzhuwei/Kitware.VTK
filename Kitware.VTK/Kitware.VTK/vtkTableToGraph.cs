using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTableToGraph : vtkGraphAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTableToGraph";

		public new static readonly string MRClassNameKey;

		static vtkTableToGraph()
		{
			vtkTableToGraph.MRClassNameKey = "class vtkTableToGraph";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTableToGraph.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTableToGraph"));
		}

		public vtkTableToGraph(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTableToGraph_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTableToGraph New()
		{
			vtkTableToGraph result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTableToGraph.vtkTableToGraph_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTableToGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTableToGraph() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTableToGraph.vtkTableToGraph_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTableToGraph_AddLinkEdge_01(HandleRef pThis, string column1, string column2);

		public void AddLinkEdge(string column1, string column2)
		{
			vtkTableToGraph.vtkTableToGraph_AddLinkEdge_01(base.GetCppThis(), column1, column2);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTableToGraph_AddLinkVertex_02(HandleRef pThis, string column, string domain, int hidden);

		public void AddLinkVertex(string column, string domain, int hidden)
		{
			vtkTableToGraph.vtkTableToGraph_AddLinkVertex_02(base.GetCppThis(), column, domain, hidden);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTableToGraph_ClearLinkEdges_03(HandleRef pThis);

		public void ClearLinkEdges()
		{
			vtkTableToGraph.vtkTableToGraph_ClearLinkEdges_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTableToGraph_ClearLinkVertices_04(HandleRef pThis);

		public void ClearLinkVertices()
		{
			vtkTableToGraph.vtkTableToGraph_ClearLinkVertices_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTableToGraph_DirectedOff_05(HandleRef pThis);

		public virtual void DirectedOff()
		{
			vtkTableToGraph.vtkTableToGraph_DirectedOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTableToGraph_DirectedOn_06(HandleRef pThis);

		public virtual void DirectedOn()
		{
			vtkTableToGraph.vtkTableToGraph_DirectedOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkTableToGraph_GetDirected_07(HandleRef pThis);

		public virtual bool GetDirected()
		{
			return vtkTableToGraph.vtkTableToGraph_GetDirected_07(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTableToGraph_GetLinkGraph_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMutableDirectedGraph GetLinkGraph()
		{
			vtkMutableDirectedGraph vtkMutableDirectedGraph = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTableToGraph.vtkTableToGraph_GetLinkGraph_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern uint vtkTableToGraph_GetMTime_09(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkTableToGraph.vtkTableToGraph_GetMTime_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkTableToGraph_IsA_10(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTableToGraph.vtkTableToGraph_IsA_10(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkTableToGraph_IsTypeOf_11(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTableToGraph.vtkTableToGraph_IsTypeOf_11(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTableToGraph_LinkColumnPath_12(HandleRef pThis, HandleRef column, HandleRef domain, HandleRef hidden);

		public void LinkColumnPath(vtkStringArray column, vtkStringArray domain, vtkBitArray hidden)
		{
			vtkTableToGraph.vtkTableToGraph_LinkColumnPath_12(base.GetCppThis(), (column == null) ? default(HandleRef) : column.GetCppThis(), (domain == null) ? default(HandleRef) : domain.GetCppThis(), (hidden == null) ? default(HandleRef) : hidden.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTableToGraph_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTableToGraph NewInstance()
		{
			vtkTableToGraph result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTableToGraph.vtkTableToGraph_NewInstance_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTableToGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTableToGraph_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTableToGraph SafeDownCast(vtkObjectBase o)
		{
			vtkTableToGraph vtkTableToGraph = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTableToGraph.vtkTableToGraph_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTableToGraph = (vtkTableToGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTableToGraph.Register(null);
				}
			}
			return vtkTableToGraph;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTableToGraph_SetDirected_16(HandleRef pThis, byte _arg);

		public virtual void SetDirected(bool _arg)
		{
			vtkTableToGraph.vtkTableToGraph_SetDirected_16(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTableToGraph_SetLinkGraph_17(HandleRef pThis, HandleRef g);

		public void SetLinkGraph(vtkMutableDirectedGraph g)
		{
			vtkTableToGraph.vtkTableToGraph_SetLinkGraph_17(base.GetCppThis(), (g == null) ? default(HandleRef) : g.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTableToGraph_SetVertexTableConnection_18(HandleRef pThis, HandleRef arg0);

		public void SetVertexTableConnection(vtkAlgorithmOutput arg0)
		{
			vtkTableToGraph.vtkTableToGraph_SetVertexTableConnection_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
