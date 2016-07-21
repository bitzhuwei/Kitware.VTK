using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkUnstructuredGridToPolyDataFilter : vtkPolyDataSource
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridToPolyDataFilter";

		public new static readonly string MRClassNameKey;

		static vtkUnstructuredGridToPolyDataFilter()
		{
			vtkUnstructuredGridToPolyDataFilter.MRClassNameKey = "class vtkUnstructuredGridToPolyDataFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnstructuredGridToPolyDataFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridToPolyDataFilter"));
		}

		public vtkUnstructuredGridToPolyDataFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridToPolyDataFilter_ComputeInputUpdateExtents_01(HandleRef pThis, HandleRef output);

		public override void ComputeInputUpdateExtents(vtkDataObject output)
		{
			vtkUnstructuredGridToPolyDataFilter.vtkUnstructuredGridToPolyDataFilter_ComputeInputUpdateExtents_01(base.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridToPolyDataFilter_GetInput_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkUnstructuredGrid GetInput()
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridToPolyDataFilter.vtkUnstructuredGridToPolyDataFilter_GetInput_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGrid = (vtkUnstructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGrid.Register(null);
				}
			}
			return vtkUnstructuredGrid;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridToPolyDataFilter_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkUnstructuredGridToPolyDataFilter.vtkUnstructuredGridToPolyDataFilter_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridToPolyDataFilter_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkUnstructuredGridToPolyDataFilter.vtkUnstructuredGridToPolyDataFilter_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridToPolyDataFilter_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkUnstructuredGridToPolyDataFilter NewInstance()
		{
			vtkUnstructuredGridToPolyDataFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridToPolyDataFilter.vtkUnstructuredGridToPolyDataFilter_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridToPolyDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridToPolyDataFilter_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUnstructuredGridToPolyDataFilter SafeDownCast(vtkObjectBase o)
		{
			vtkUnstructuredGridToPolyDataFilter vtkUnstructuredGridToPolyDataFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridToPolyDataFilter.vtkUnstructuredGridToPolyDataFilter_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridToPolyDataFilter = (vtkUnstructuredGridToPolyDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridToPolyDataFilter.Register(null);
				}
			}
			return vtkUnstructuredGridToPolyDataFilter;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridToPolyDataFilter_SetInput_07(HandleRef pThis, HandleRef input);

		public virtual void SetInput(vtkUnstructuredGrid input)
		{
			vtkUnstructuredGridToPolyDataFilter.vtkUnstructuredGridToPolyDataFilter_SetInput_07(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}
	}
}
