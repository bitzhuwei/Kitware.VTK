using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkAdjacentVertexIterator : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkAdjacentVertexIterator";

		public new static readonly string MRClassNameKey;

		static vtkAdjacentVertexIterator()
		{
			vtkAdjacentVertexIterator.MRClassNameKey = "class vtkAdjacentVertexIterator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAdjacentVertexIterator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAdjacentVertexIterator"));
		}

		public vtkAdjacentVertexIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAdjacentVertexIterator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAdjacentVertexIterator New()
		{
			vtkAdjacentVertexIterator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAdjacentVertexIterator.vtkAdjacentVertexIterator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAdjacentVertexIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkAdjacentVertexIterator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkAdjacentVertexIterator.vtkAdjacentVertexIterator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAdjacentVertexIterator_GetGraph_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkGraph GetGraph()
		{
			vtkGraph vtkGraph = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAdjacentVertexIterator.vtkAdjacentVertexIterator_GetGraph_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern long vtkAdjacentVertexIterator_GetVertex_02(HandleRef pThis);

		public virtual long GetVertex()
		{
			return vtkAdjacentVertexIterator.vtkAdjacentVertexIterator_GetVertex_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern byte vtkAdjacentVertexIterator_HasNext_03(HandleRef pThis);

		public bool HasNext()
		{
			return vtkAdjacentVertexIterator.vtkAdjacentVertexIterator_HasNext_03(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkAdjacentVertexIterator_Initialize_04(HandleRef pThis, HandleRef g, long v);

		public void Initialize(vtkGraph g, long v)
		{
			vtkAdjacentVertexIterator.vtkAdjacentVertexIterator_Initialize_04(base.GetCppThis(), (g == null) ? default(HandleRef) : g.GetCppThis(), v);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAdjacentVertexIterator_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAdjacentVertexIterator.vtkAdjacentVertexIterator_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkAdjacentVertexIterator_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAdjacentVertexIterator.vtkAdjacentVertexIterator_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAdjacentVertexIterator_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAdjacentVertexIterator NewInstance()
		{
			vtkAdjacentVertexIterator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAdjacentVertexIterator.vtkAdjacentVertexIterator_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAdjacentVertexIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern long vtkAdjacentVertexIterator_Next_09(HandleRef pThis);

		public long Next()
		{
			return vtkAdjacentVertexIterator.vtkAdjacentVertexIterator_Next_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkAdjacentVertexIterator_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAdjacentVertexIterator SafeDownCast(vtkObjectBase o)
		{
			vtkAdjacentVertexIterator vtkAdjacentVertexIterator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAdjacentVertexIterator.vtkAdjacentVertexIterator_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAdjacentVertexIterator = (vtkAdjacentVertexIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAdjacentVertexIterator.Register(null);
				}
			}
			return vtkAdjacentVertexIterator;
		}
	}
}
