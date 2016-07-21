using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkExtractSelectedGraph : vtkGraphAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractSelectedGraph";

		public new static readonly string MRClassNameKey;

		static vtkExtractSelectedGraph()
		{
			vtkExtractSelectedGraph.MRClassNameKey = "class vtkExtractSelectedGraph";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractSelectedGraph.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractSelectedGraph"));
		}

		public vtkExtractSelectedGraph(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractSelectedGraph_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractSelectedGraph New()
		{
			vtkExtractSelectedGraph result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractSelectedGraph.vtkExtractSelectedGraph_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractSelectedGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkExtractSelectedGraph() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkExtractSelectedGraph.vtkExtractSelectedGraph_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkExtractSelectedGraph_FillInputPortInformation_01(HandleRef pThis, int port, HandleRef info);

		public virtual int FillInputPortInformation(int port, vtkInformation info)
		{
			return vtkExtractSelectedGraph.vtkExtractSelectedGraph_FillInputPortInformation_01(base.GetCppThis(), port, (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkExtractSelectedGraph_GetRemoveIsolatedVertices_02(HandleRef pThis);

		public virtual bool GetRemoveIsolatedVertices()
		{
			return vtkExtractSelectedGraph.vtkExtractSelectedGraph_GetRemoveIsolatedVertices_02(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkExtractSelectedGraph_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkExtractSelectedGraph.vtkExtractSelectedGraph_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkExtractSelectedGraph_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkExtractSelectedGraph.vtkExtractSelectedGraph_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractSelectedGraph_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkExtractSelectedGraph NewInstance()
		{
			vtkExtractSelectedGraph result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractSelectedGraph.vtkExtractSelectedGraph_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractSelectedGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkExtractSelectedGraph_RemoveIsolatedVerticesOff_07(HandleRef pThis);

		public virtual void RemoveIsolatedVerticesOff()
		{
			vtkExtractSelectedGraph.vtkExtractSelectedGraph_RemoveIsolatedVerticesOff_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkExtractSelectedGraph_RemoveIsolatedVerticesOn_08(HandleRef pThis);

		public virtual void RemoveIsolatedVerticesOn()
		{
			vtkExtractSelectedGraph.vtkExtractSelectedGraph_RemoveIsolatedVerticesOn_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractSelectedGraph_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractSelectedGraph SafeDownCast(vtkObjectBase o)
		{
			vtkExtractSelectedGraph vtkExtractSelectedGraph = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractSelectedGraph.vtkExtractSelectedGraph_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractSelectedGraph = (vtkExtractSelectedGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractSelectedGraph.Register(null);
				}
			}
			return vtkExtractSelectedGraph;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkExtractSelectedGraph_SetAnnotationLayersConnection_10(HandleRef pThis, HandleRef arg0);

		public void SetAnnotationLayersConnection(vtkAlgorithmOutput arg0)
		{
			vtkExtractSelectedGraph.vtkExtractSelectedGraph_SetAnnotationLayersConnection_10(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkExtractSelectedGraph_SetRemoveIsolatedVertices_11(HandleRef pThis, byte _arg);

		public virtual void SetRemoveIsolatedVertices(bool _arg)
		{
			vtkExtractSelectedGraph.vtkExtractSelectedGraph_SetRemoveIsolatedVertices_11(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkExtractSelectedGraph_SetSelectionConnection_12(HandleRef pThis, HandleRef arg0);

		public void SetSelectionConnection(vtkAlgorithmOutput arg0)
		{
			vtkExtractSelectedGraph.vtkExtractSelectedGraph_SetSelectionConnection_12(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
