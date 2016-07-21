using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMutableGraphHelper : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMutableGraphHelper";

		public new static readonly string MRClassNameKey;

		static vtkMutableGraphHelper()
		{
			vtkMutableGraphHelper.MRClassNameKey = "class vtkMutableGraphHelper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMutableGraphHelper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMutableGraphHelper"));
		}

		public vtkMutableGraphHelper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkMutableGraphHelper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMutableGraphHelper New()
		{
			vtkMutableGraphHelper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMutableGraphHelper.vtkMutableGraphHelper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMutableGraphHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMutableGraphHelper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMutableGraphHelper.vtkMutableGraphHelper_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkMutableGraphHelper_AddGraphEdge_01(HandleRef pThis, long u, long v, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkGraphEdge AddGraphEdge(long u, long v)
		{
			vtkGraphEdge vtkGraphEdge = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMutableGraphHelper.vtkMutableGraphHelper_AddGraphEdge_01(base.GetCppThis(), u, v, ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern long vtkMutableGraphHelper_AddVertex_02(HandleRef pThis);

		public long AddVertex()
		{
			return vtkMutableGraphHelper.vtkMutableGraphHelper_AddVertex_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkMutableGraphHelper_GetGraph_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkGraph GetGraph()
		{
			vtkGraph vtkGraph = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMutableGraphHelper.vtkMutableGraphHelper_GetGraph_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkMutableGraphHelper_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMutableGraphHelper.vtkMutableGraphHelper_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkMutableGraphHelper_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMutableGraphHelper.vtkMutableGraphHelper_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkMutableGraphHelper_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMutableGraphHelper NewInstance()
		{
			vtkMutableGraphHelper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMutableGraphHelper.vtkMutableGraphHelper_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMutableGraphHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkMutableGraphHelper_RemoveEdge_08(HandleRef pThis, long e);

		public void RemoveEdge(long e)
		{
			vtkMutableGraphHelper.vtkMutableGraphHelper_RemoveEdge_08(base.GetCppThis(), e);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkMutableGraphHelper_RemoveEdges_09(HandleRef pThis, HandleRef edges);

		public void RemoveEdges(vtkIdTypeArray edges)
		{
			vtkMutableGraphHelper.vtkMutableGraphHelper_RemoveEdges_09(base.GetCppThis(), (edges == null) ? default(HandleRef) : edges.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkMutableGraphHelper_RemoveVertex_10(HandleRef pThis, long v);

		public void RemoveVertex(long v)
		{
			vtkMutableGraphHelper.vtkMutableGraphHelper_RemoveVertex_10(base.GetCppThis(), v);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkMutableGraphHelper_RemoveVertices_11(HandleRef pThis, HandleRef verts);

		public void RemoveVertices(vtkIdTypeArray verts)
		{
			vtkMutableGraphHelper.vtkMutableGraphHelper_RemoveVertices_11(base.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkMutableGraphHelper_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMutableGraphHelper SafeDownCast(vtkObjectBase o)
		{
			vtkMutableGraphHelper vtkMutableGraphHelper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMutableGraphHelper.vtkMutableGraphHelper_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMutableGraphHelper = (vtkMutableGraphHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMutableGraphHelper.Register(null);
				}
			}
			return vtkMutableGraphHelper;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkMutableGraphHelper_SetGraph_13(HandleRef pThis, HandleRef g);

		public void SetGraph(vtkGraph g)
		{
			vtkMutableGraphHelper.vtkMutableGraphHelper_SetGraph_13(base.GetCppThis(), (g == null) ? default(HandleRef) : g.GetCppThis());
		}
	}
}
