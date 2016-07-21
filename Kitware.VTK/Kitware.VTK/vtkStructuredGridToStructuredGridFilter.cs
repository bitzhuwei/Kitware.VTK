using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkStructuredGridToStructuredGridFilter : vtkStructuredGridSource
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkStructuredGridToStructuredGridFilter";

		public new static readonly string MRClassNameKey;

		static vtkStructuredGridToStructuredGridFilter()
		{
			vtkStructuredGridToStructuredGridFilter.MRClassNameKey = "class vtkStructuredGridToStructuredGridFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStructuredGridToStructuredGridFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStructuredGridToStructuredGridFilter"));
		}

		public vtkStructuredGridToStructuredGridFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredGridToStructuredGridFilter_GetInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkStructuredGrid GetInput()
		{
			vtkStructuredGrid vtkStructuredGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredGridToStructuredGridFilter.vtkStructuredGridToStructuredGridFilter_GetInput_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkStructuredGridToStructuredGridFilter_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkStructuredGridToStructuredGridFilter.vtkStructuredGridToStructuredGridFilter_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStructuredGridToStructuredGridFilter_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkStructuredGridToStructuredGridFilter.vtkStructuredGridToStructuredGridFilter_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredGridToStructuredGridFilter_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkStructuredGridToStructuredGridFilter NewInstance()
		{
			vtkStructuredGridToStructuredGridFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredGridToStructuredGridFilter.vtkStructuredGridToStructuredGridFilter_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredGridToStructuredGridFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredGridToStructuredGridFilter_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStructuredGridToStructuredGridFilter SafeDownCast(vtkObjectBase o)
		{
			vtkStructuredGridToStructuredGridFilter vtkStructuredGridToStructuredGridFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredGridToStructuredGridFilter.vtkStructuredGridToStructuredGridFilter_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredGridToStructuredGridFilter = (vtkStructuredGridToStructuredGridFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredGridToStructuredGridFilter.Register(null);
				}
			}
			return vtkStructuredGridToStructuredGridFilter;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkStructuredGridToStructuredGridFilter_SetInput_06(HandleRef pThis, HandleRef input);

		public void SetInput(vtkStructuredGrid input)
		{
			vtkStructuredGridToStructuredGridFilter.vtkStructuredGridToStructuredGridFilter_SetInput_06(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}
	}
}
