using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkRectilinearGridToPolyDataFilter : vtkPolyDataSource
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkRectilinearGridToPolyDataFilter";

		public new static readonly string MRClassNameKey;

		static vtkRectilinearGridToPolyDataFilter()
		{
			vtkRectilinearGridToPolyDataFilter.MRClassNameKey = "class vtkRectilinearGridToPolyDataFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRectilinearGridToPolyDataFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRectilinearGridToPolyDataFilter"));
		}

		public vtkRectilinearGridToPolyDataFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkRectilinearGridToPolyDataFilter_GetInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkRectilinearGrid GetInput()
		{
			vtkRectilinearGrid vtkRectilinearGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRectilinearGridToPolyDataFilter.vtkRectilinearGridToPolyDataFilter_GetInput_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRectilinearGrid = (vtkRectilinearGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRectilinearGrid.Register(null);
				}
			}
			return vtkRectilinearGrid;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkRectilinearGridToPolyDataFilter_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkRectilinearGridToPolyDataFilter.vtkRectilinearGridToPolyDataFilter_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkRectilinearGridToPolyDataFilter_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkRectilinearGridToPolyDataFilter.vtkRectilinearGridToPolyDataFilter_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkRectilinearGridToPolyDataFilter_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRectilinearGridToPolyDataFilter NewInstance()
		{
			vtkRectilinearGridToPolyDataFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRectilinearGridToPolyDataFilter.vtkRectilinearGridToPolyDataFilter_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectilinearGridToPolyDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkRectilinearGridToPolyDataFilter_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRectilinearGridToPolyDataFilter SafeDownCast(vtkObjectBase o)
		{
			vtkRectilinearGridToPolyDataFilter vtkRectilinearGridToPolyDataFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRectilinearGridToPolyDataFilter.vtkRectilinearGridToPolyDataFilter_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRectilinearGridToPolyDataFilter = (vtkRectilinearGridToPolyDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRectilinearGridToPolyDataFilter.Register(null);
				}
			}
			return vtkRectilinearGridToPolyDataFilter;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkRectilinearGridToPolyDataFilter_SetInput_06(HandleRef pThis, HandleRef input);

		public void SetInput(vtkRectilinearGrid input)
		{
			vtkRectilinearGridToPolyDataFilter.vtkRectilinearGridToPolyDataFilter_SetInput_06(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}
	}
}
