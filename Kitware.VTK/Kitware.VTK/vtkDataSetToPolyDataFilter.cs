using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDataSetToPolyDataFilter : vtkPolyDataSource
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataSetToPolyDataFilter";

		public new static readonly string MRClassNameKey;

		static vtkDataSetToPolyDataFilter()
		{
			vtkDataSetToPolyDataFilter.MRClassNameKey = "class vtkDataSetToPolyDataFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataSetToPolyDataFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataSetToPolyDataFilter"));
		}

		public vtkDataSetToPolyDataFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSetToPolyDataFilter_ComputeInputUpdateExtents_01(HandleRef pThis, HandleRef output);

		public override void ComputeInputUpdateExtents(vtkDataObject output)
		{
			vtkDataSetToPolyDataFilter.vtkDataSetToPolyDataFilter_ComputeInputUpdateExtents_01(base.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetToPolyDataFilter_GetInput_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataSet GetInput()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetToPolyDataFilter.vtkDataSetToPolyDataFilter_GetInput_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkDataSetToPolyDataFilter_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDataSetToPolyDataFilter.vtkDataSetToPolyDataFilter_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataSetToPolyDataFilter_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDataSetToPolyDataFilter.vtkDataSetToPolyDataFilter_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetToPolyDataFilter_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDataSetToPolyDataFilter NewInstance()
		{
			vtkDataSetToPolyDataFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetToPolyDataFilter.vtkDataSetToPolyDataFilter_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSetToPolyDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetToPolyDataFilter_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataSetToPolyDataFilter SafeDownCast(vtkObjectBase o)
		{
			vtkDataSetToPolyDataFilter vtkDataSetToPolyDataFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetToPolyDataFilter.vtkDataSetToPolyDataFilter_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetToPolyDataFilter = (vtkDataSetToPolyDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetToPolyDataFilter.Register(null);
				}
			}
			return vtkDataSetToPolyDataFilter;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSetToPolyDataFilter_SetInput_07(HandleRef pThis, HandleRef input);

		public virtual void SetInput(vtkDataSet input)
		{
			vtkDataSetToPolyDataFilter.vtkDataSetToPolyDataFilter_SetInput_07(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}
	}
}
