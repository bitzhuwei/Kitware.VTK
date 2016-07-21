using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDirectedAcyclicGraph : vtkDirectedGraph
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDirectedAcyclicGraph";

		public new static readonly string MRClassNameKey;

		static vtkDirectedAcyclicGraph()
		{
			vtkDirectedAcyclicGraph.MRClassNameKey = "class vtkDirectedAcyclicGraph";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDirectedAcyclicGraph.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDirectedAcyclicGraph"));
		}

		public vtkDirectedAcyclicGraph(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDirectedAcyclicGraph_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDirectedAcyclicGraph New()
		{
			vtkDirectedAcyclicGraph result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDirectedAcyclicGraph.vtkDirectedAcyclicGraph_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDirectedAcyclicGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDirectedAcyclicGraph() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDirectedAcyclicGraph.vtkDirectedAcyclicGraph_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDirectedAcyclicGraph_GetData_01(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDirectedAcyclicGraph GetData(vtkInformation info)
		{
			vtkDirectedAcyclicGraph vtkDirectedAcyclicGraph = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDirectedAcyclicGraph.vtkDirectedAcyclicGraph_GetData_01((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDirectedAcyclicGraph = (vtkDirectedAcyclicGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDirectedAcyclicGraph.Register(null);
				}
			}
			return vtkDirectedAcyclicGraph;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDirectedAcyclicGraph_GetData_02(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDirectedAcyclicGraph GetData(vtkInformationVector v, int i)
		{
			vtkDirectedAcyclicGraph vtkDirectedAcyclicGraph = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDirectedAcyclicGraph.vtkDirectedAcyclicGraph_GetData_02((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDirectedAcyclicGraph = (vtkDirectedAcyclicGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDirectedAcyclicGraph.Register(null);
				}
			}
			return vtkDirectedAcyclicGraph;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDirectedAcyclicGraph_GetDataObjectType_03(HandleRef pThis);

		public override int GetDataObjectType()
		{
			return vtkDirectedAcyclicGraph.vtkDirectedAcyclicGraph_GetDataObjectType_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDirectedAcyclicGraph_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDirectedAcyclicGraph.vtkDirectedAcyclicGraph_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDirectedAcyclicGraph_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDirectedAcyclicGraph.vtkDirectedAcyclicGraph_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDirectedAcyclicGraph_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDirectedAcyclicGraph NewInstance()
		{
			vtkDirectedAcyclicGraph result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDirectedAcyclicGraph.vtkDirectedAcyclicGraph_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDirectedAcyclicGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDirectedAcyclicGraph_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDirectedAcyclicGraph SafeDownCast(vtkObjectBase o)
		{
			vtkDirectedAcyclicGraph vtkDirectedAcyclicGraph = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDirectedAcyclicGraph.vtkDirectedAcyclicGraph_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDirectedAcyclicGraph = (vtkDirectedAcyclicGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDirectedAcyclicGraph.Register(null);
				}
			}
			return vtkDirectedAcyclicGraph;
		}
	}
}
