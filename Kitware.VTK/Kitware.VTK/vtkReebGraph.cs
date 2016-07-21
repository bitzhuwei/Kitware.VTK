using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkReebGraph : vtkMutableDirectedGraph
	{
		public enum ERR_INCORRECT_FIELD_WrapperEnum
		{
			ERR_INCORRECT_FIELD = -1,
			ERR_NOT_A_SIMPLICIAL_MESH = -3,
			ERR_NO_SUCH_FIELD
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkReebGraph";

		public new static readonly string MRClassNameKey;

		static vtkReebGraph()
		{
			vtkReebGraph.MRClassNameKey = "class vtkReebGraph";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkReebGraph.MRClassNameKey, Type.GetType("Kitware.VTK.vtkReebGraph"));
		}

		public vtkReebGraph(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkReebGraph_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkReebGraph New()
		{
			vtkReebGraph result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkReebGraph.vtkReebGraph_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkReebGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkReebGraph() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkReebGraph.vtkReebGraph_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkReebGraph_Build_01(HandleRef pThis, HandleRef mesh, HandleRef scalarField);

		public int Build(vtkPolyData mesh, vtkDataArray scalarField)
		{
			return vtkReebGraph.vtkReebGraph_Build_01(base.GetCppThis(), (mesh == null) ? default(HandleRef) : mesh.GetCppThis(), (scalarField == null) ? default(HandleRef) : scalarField.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkReebGraph_Build_02(HandleRef pThis, HandleRef mesh, HandleRef scalarField);

		public int Build(vtkUnstructuredGrid mesh, vtkDataArray scalarField)
		{
			return vtkReebGraph.vtkReebGraph_Build_02(base.GetCppThis(), (mesh == null) ? default(HandleRef) : mesh.GetCppThis(), (scalarField == null) ? default(HandleRef) : scalarField.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkReebGraph_Build_03(HandleRef pThis, HandleRef mesh, long scalarFieldId);

		public int Build(vtkPolyData mesh, long scalarFieldId)
		{
			return vtkReebGraph.vtkReebGraph_Build_03(base.GetCppThis(), (mesh == null) ? default(HandleRef) : mesh.GetCppThis(), scalarFieldId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkReebGraph_Build_04(HandleRef pThis, HandleRef mesh, long scalarFieldId);

		public int Build(vtkUnstructuredGrid mesh, long scalarFieldId)
		{
			return vtkReebGraph.vtkReebGraph_Build_04(base.GetCppThis(), (mesh == null) ? default(HandleRef) : mesh.GetCppThis(), scalarFieldId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkReebGraph_Build_05(HandleRef pThis, HandleRef mesh, string scalarFieldName);

		public int Build(vtkPolyData mesh, string scalarFieldName)
		{
			return vtkReebGraph.vtkReebGraph_Build_05(base.GetCppThis(), (mesh == null) ? default(HandleRef) : mesh.GetCppThis(), scalarFieldName);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkReebGraph_Build_06(HandleRef pThis, HandleRef mesh, string scalarFieldName);

		public int Build(vtkUnstructuredGrid mesh, string scalarFieldName)
		{
			return vtkReebGraph.vtkReebGraph_Build_06(base.GetCppThis(), (mesh == null) ? default(HandleRef) : mesh.GetCppThis(), scalarFieldName);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkReebGraph_CloseStream_07(HandleRef pThis);

		public void CloseStream()
		{
			vtkReebGraph.vtkReebGraph_CloseStream_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkReebGraph_DeepCopy_08(HandleRef pThis, HandleRef src);

		public override void DeepCopy(vtkDataObject src)
		{
			vtkReebGraph.vtkReebGraph_DeepCopy_08(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkReebGraph_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkReebGraph.vtkReebGraph_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkReebGraph_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkReebGraph.vtkReebGraph_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkReebGraph_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkReebGraph NewInstance()
		{
			vtkReebGraph result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkReebGraph.vtkReebGraph_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkReebGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkReebGraph_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkReebGraph SafeDownCast(vtkObjectBase o)
		{
			vtkReebGraph vtkReebGraph = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkReebGraph.vtkReebGraph_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkReebGraph = (vtkReebGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkReebGraph.Register(null);
				}
			}
			return vtkReebGraph;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkReebGraph_Set_14(HandleRef pThis, HandleRef g);

		public void Set(vtkMutableDirectedGraph g)
		{
			vtkReebGraph.vtkReebGraph_Set_14(base.GetCppThis(), (g == null) ? default(HandleRef) : g.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkReebGraph_Simplify_15(HandleRef pThis, double simplificationThreshold, HandleRef simplificationMetric);

		public int Simplify(double simplificationThreshold, vtkReebGraphSimplificationMetric simplificationMetric)
		{
			return vtkReebGraph.vtkReebGraph_Simplify_15(base.GetCppThis(), simplificationThreshold, (simplificationMetric == null) ? default(HandleRef) : simplificationMetric.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkReebGraph_StreamTetrahedron_16(HandleRef pThis, long vertex0Id, double scalar0, long vertex1Id, double scalar1, long vertex2Id, double scalar2, long vertex3Id, double scalar3);

		public int StreamTetrahedron(long vertex0Id, double scalar0, long vertex1Id, double scalar1, long vertex2Id, double scalar2, long vertex3Id, double scalar3)
		{
			return vtkReebGraph.vtkReebGraph_StreamTetrahedron_16(base.GetCppThis(), vertex0Id, scalar0, vertex1Id, scalar1, vertex2Id, scalar2, vertex3Id, scalar3);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkReebGraph_StreamTriangle_17(HandleRef pThis, long vertex0Id, double scalar0, long vertex1Id, double scalar1, long vertex2Id, double scalar2);

		public int StreamTriangle(long vertex0Id, double scalar0, long vertex1Id, double scalar1, long vertex2Id, double scalar2)
		{
			return vtkReebGraph.vtkReebGraph_StreamTriangle_17(base.GetCppThis(), vertex0Id, scalar0, vertex1Id, scalar1, vertex2Id, scalar2);
		}
	}
}
