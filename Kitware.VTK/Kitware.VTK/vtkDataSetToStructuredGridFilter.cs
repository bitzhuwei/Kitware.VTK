using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDataSetToStructuredGridFilter : vtkStructuredGridSource
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataSetToStructuredGridFilter";

		public new static readonly string MRClassNameKey;

		static vtkDataSetToStructuredGridFilter()
		{
			vtkDataSetToStructuredGridFilter.MRClassNameKey = "class vtkDataSetToStructuredGridFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataSetToStructuredGridFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataSetToStructuredGridFilter"));
		}

		public vtkDataSetToStructuredGridFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetToStructuredGridFilter_GetInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataSet GetInput()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetToStructuredGridFilter.vtkDataSetToStructuredGridFilter_GetInput_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkDataSetToStructuredGridFilter_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDataSetToStructuredGridFilter.vtkDataSetToStructuredGridFilter_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataSetToStructuredGridFilter_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDataSetToStructuredGridFilter.vtkDataSetToStructuredGridFilter_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetToStructuredGridFilter_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDataSetToStructuredGridFilter NewInstance()
		{
			vtkDataSetToStructuredGridFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetToStructuredGridFilter.vtkDataSetToStructuredGridFilter_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSetToStructuredGridFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetToStructuredGridFilter_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataSetToStructuredGridFilter SafeDownCast(vtkObjectBase o)
		{
			vtkDataSetToStructuredGridFilter vtkDataSetToStructuredGridFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetToStructuredGridFilter.vtkDataSetToStructuredGridFilter_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetToStructuredGridFilter = (vtkDataSetToStructuredGridFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetToStructuredGridFilter.Register(null);
				}
			}
			return vtkDataSetToStructuredGridFilter;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSetToStructuredGridFilter_SetInput_06(HandleRef pThis, HandleRef input);

		public virtual void SetInput(vtkDataSet input)
		{
			vtkDataSetToStructuredGridFilter.vtkDataSetToStructuredGridFilter_SetInput_06(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}
	}
}
