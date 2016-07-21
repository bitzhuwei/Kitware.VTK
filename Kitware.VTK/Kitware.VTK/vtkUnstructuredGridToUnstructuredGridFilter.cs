using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkUnstructuredGridToUnstructuredGridFilter : vtkUnstructuredGridSource
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridToUnstructuredGridFilter";

		public new static readonly string MRClassNameKey;

		static vtkUnstructuredGridToUnstructuredGridFilter()
		{
			vtkUnstructuredGridToUnstructuredGridFilter.MRClassNameKey = "class vtkUnstructuredGridToUnstructuredGridFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnstructuredGridToUnstructuredGridFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridToUnstructuredGridFilter"));
		}

		public vtkUnstructuredGridToUnstructuredGridFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridToUnstructuredGridFilter_FillInputPortInformation_01(HandleRef pThis, int arg0, HandleRef arg1);

		public virtual int FillInputPortInformation(int arg0, vtkInformation arg1)
		{
			return vtkUnstructuredGridToUnstructuredGridFilter.vtkUnstructuredGridToUnstructuredGridFilter_FillInputPortInformation_01(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridToUnstructuredGridFilter_GetInput_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkUnstructuredGrid GetInput()
		{
			vtkUnstructuredGrid vtkUnstructuredGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridToUnstructuredGridFilter.vtkUnstructuredGridToUnstructuredGridFilter_GetInput_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkUnstructuredGridToUnstructuredGridFilter_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkUnstructuredGridToUnstructuredGridFilter.vtkUnstructuredGridToUnstructuredGridFilter_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkUnstructuredGridToUnstructuredGridFilter_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkUnstructuredGridToUnstructuredGridFilter.vtkUnstructuredGridToUnstructuredGridFilter_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridToUnstructuredGridFilter_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkUnstructuredGridToUnstructuredGridFilter NewInstance()
		{
			vtkUnstructuredGridToUnstructuredGridFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridToUnstructuredGridFilter.vtkUnstructuredGridToUnstructuredGridFilter_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridToUnstructuredGridFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkUnstructuredGridToUnstructuredGridFilter_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUnstructuredGridToUnstructuredGridFilter SafeDownCast(vtkObjectBase o)
		{
			vtkUnstructuredGridToUnstructuredGridFilter vtkUnstructuredGridToUnstructuredGridFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUnstructuredGridToUnstructuredGridFilter.vtkUnstructuredGridToUnstructuredGridFilter_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridToUnstructuredGridFilter = (vtkUnstructuredGridToUnstructuredGridFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridToUnstructuredGridFilter.Register(null);
				}
			}
			return vtkUnstructuredGridToUnstructuredGridFilter;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkUnstructuredGridToUnstructuredGridFilter_SetInput_07(HandleRef pThis, HandleRef input);

		public void SetInput(vtkUnstructuredGrid input)
		{
			vtkUnstructuredGridToUnstructuredGridFilter.vtkUnstructuredGridToUnstructuredGridFilter_SetInput_07(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}
	}
}
