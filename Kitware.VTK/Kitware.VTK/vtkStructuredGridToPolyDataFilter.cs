using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkStructuredGridToPolyDataFilter : vtkPolyDataSource
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkStructuredGridToPolyDataFilter";

		public new static readonly string MRClassNameKey;

		static vtkStructuredGridToPolyDataFilter()
		{
			vtkStructuredGridToPolyDataFilter.MRClassNameKey = "class vtkStructuredGridToPolyDataFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStructuredGridToPolyDataFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStructuredGridToPolyDataFilter"));
		}

		public vtkStructuredGridToPolyDataFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredGridToPolyDataFilter_GetInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkStructuredGrid GetInput()
		{
			vtkStructuredGrid vtkStructuredGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredGridToPolyDataFilter.vtkStructuredGridToPolyDataFilter_GetInput_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredGrid = (vtkStructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredGrid.Register(null);
				}
			}
			return vtkStructuredGrid;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStructuredGridToPolyDataFilter_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkStructuredGridToPolyDataFilter.vtkStructuredGridToPolyDataFilter_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStructuredGridToPolyDataFilter_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkStructuredGridToPolyDataFilter.vtkStructuredGridToPolyDataFilter_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredGridToPolyDataFilter_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkStructuredGridToPolyDataFilter NewInstance()
		{
			vtkStructuredGridToPolyDataFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredGridToPolyDataFilter.vtkStructuredGridToPolyDataFilter_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredGridToPolyDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredGridToPolyDataFilter_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStructuredGridToPolyDataFilter SafeDownCast(vtkObjectBase o)
		{
			vtkStructuredGridToPolyDataFilter vtkStructuredGridToPolyDataFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredGridToPolyDataFilter.vtkStructuredGridToPolyDataFilter_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredGridToPolyDataFilter = (vtkStructuredGridToPolyDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredGridToPolyDataFilter.Register(null);
				}
			}
			return vtkStructuredGridToPolyDataFilter;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkStructuredGridToPolyDataFilter_SetInput_06(HandleRef pThis, HandleRef input);

		public void SetInput(vtkStructuredGrid input)
		{
			vtkStructuredGridToPolyDataFilter.vtkStructuredGridToPolyDataFilter_SetInput_06(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}
	}
}
