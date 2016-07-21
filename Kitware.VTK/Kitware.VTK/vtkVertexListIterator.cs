using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkVertexListIterator : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkVertexListIterator";

		public new static readonly string MRClassNameKey;

		static vtkVertexListIterator()
		{
			vtkVertexListIterator.MRClassNameKey = "class vtkVertexListIterator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVertexListIterator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVertexListIterator"));
		}

		public vtkVertexListIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkVertexListIterator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVertexListIterator New()
		{
			vtkVertexListIterator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVertexListIterator.vtkVertexListIterator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVertexListIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkVertexListIterator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkVertexListIterator.vtkVertexListIterator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkVertexListIterator_GetGraph_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkGraph GetGraph()
		{
			vtkGraph vtkGraph = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVertexListIterator.vtkVertexListIterator_GetGraph_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern byte vtkVertexListIterator_HasNext_02(HandleRef pThis);

		public bool HasNext()
		{
			return vtkVertexListIterator.vtkVertexListIterator_HasNext_02(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkVertexListIterator_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkVertexListIterator.vtkVertexListIterator_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkVertexListIterator_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkVertexListIterator.vtkVertexListIterator_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkVertexListIterator_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkVertexListIterator NewInstance()
		{
			vtkVertexListIterator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVertexListIterator.vtkVertexListIterator_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVertexListIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkVertexListIterator_Next_07(HandleRef pThis);

		public long Next()
		{
			return vtkVertexListIterator.vtkVertexListIterator_Next_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkVertexListIterator_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVertexListIterator SafeDownCast(vtkObjectBase o)
		{
			vtkVertexListIterator vtkVertexListIterator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVertexListIterator.vtkVertexListIterator_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVertexListIterator = (vtkVertexListIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVertexListIterator.Register(null);
				}
			}
			return vtkVertexListIterator;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkVertexListIterator_SetGraph_09(HandleRef pThis, HandleRef graph);

		public virtual void SetGraph(vtkGraph graph)
		{
			vtkVertexListIterator.vtkVertexListIterator_SetGraph_09(base.GetCppThis(), (graph == null) ? default(HandleRef) : graph.GetCppThis());
		}
	}
}
