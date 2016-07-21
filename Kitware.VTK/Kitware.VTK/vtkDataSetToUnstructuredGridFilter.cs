using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDataSetToUnstructuredGridFilter : vtkUnstructuredGridSource
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataSetToUnstructuredGridFilter";

		public new static readonly string MRClassNameKey;

		static vtkDataSetToUnstructuredGridFilter()
		{
			vtkDataSetToUnstructuredGridFilter.MRClassNameKey = "class vtkDataSetToUnstructuredGridFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataSetToUnstructuredGridFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataSetToUnstructuredGridFilter"));
		}

		public vtkDataSetToUnstructuredGridFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetToUnstructuredGridFilter_GetInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataSet GetInput()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetToUnstructuredGridFilter.vtkDataSetToUnstructuredGridFilter_GetInput_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataSetToUnstructuredGridFilter_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDataSetToUnstructuredGridFilter.vtkDataSetToUnstructuredGridFilter_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataSetToUnstructuredGridFilter_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDataSetToUnstructuredGridFilter.vtkDataSetToUnstructuredGridFilter_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetToUnstructuredGridFilter_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDataSetToUnstructuredGridFilter NewInstance()
		{
			vtkDataSetToUnstructuredGridFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetToUnstructuredGridFilter.vtkDataSetToUnstructuredGridFilter_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSetToUnstructuredGridFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetToUnstructuredGridFilter_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataSetToUnstructuredGridFilter SafeDownCast(vtkObjectBase o)
		{
			vtkDataSetToUnstructuredGridFilter vtkDataSetToUnstructuredGridFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetToUnstructuredGridFilter.vtkDataSetToUnstructuredGridFilter_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetToUnstructuredGridFilter = (vtkDataSetToUnstructuredGridFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetToUnstructuredGridFilter.Register(null);
				}
			}
			return vtkDataSetToUnstructuredGridFilter;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSetToUnstructuredGridFilter_SetInput_06(HandleRef pThis, HandleRef input);

		public virtual void SetInput(vtkDataSet input)
		{
			vtkDataSetToUnstructuredGridFilter.vtkDataSetToUnstructuredGridFilter_SetInput_06(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}
	}
}
