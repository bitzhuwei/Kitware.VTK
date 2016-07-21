using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCollapseGraph : vtkGraphAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCollapseGraph";

		public new static readonly string MRClassNameKey;

		static vtkCollapseGraph()
		{
			vtkCollapseGraph.MRClassNameKey = "class vtkCollapseGraph";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCollapseGraph.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCollapseGraph"));
		}

		public vtkCollapseGraph(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkCollapseGraph_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCollapseGraph New()
		{
			vtkCollapseGraph result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCollapseGraph.vtkCollapseGraph_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCollapseGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCollapseGraph() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCollapseGraph.vtkCollapseGraph_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkCollapseGraph_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCollapseGraph.vtkCollapseGraph_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkCollapseGraph_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCollapseGraph.vtkCollapseGraph_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkCollapseGraph_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCollapseGraph NewInstance()
		{
			vtkCollapseGraph result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCollapseGraph.vtkCollapseGraph_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCollapseGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkCollapseGraph_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCollapseGraph SafeDownCast(vtkObjectBase o)
		{
			vtkCollapseGraph vtkCollapseGraph = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCollapseGraph.vtkCollapseGraph_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCollapseGraph = (vtkCollapseGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCollapseGraph.Register(null);
				}
			}
			return vtkCollapseGraph;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkCollapseGraph_SetGraphConnection_06(HandleRef pThis, HandleRef arg0);

		public void SetGraphConnection(vtkAlgorithmOutput arg0)
		{
			vtkCollapseGraph.vtkCollapseGraph_SetGraphConnection_06(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkCollapseGraph_SetSelectionConnection_07(HandleRef pThis, HandleRef arg0);

		public void SetSelectionConnection(vtkAlgorithmOutput arg0)
		{
			vtkCollapseGraph.vtkCollapseGraph_SetSelectionConnection_07(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
