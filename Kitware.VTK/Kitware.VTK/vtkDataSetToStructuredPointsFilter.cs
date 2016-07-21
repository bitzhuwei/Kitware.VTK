using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDataSetToStructuredPointsFilter : vtkStructuredPointsSource
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataSetToStructuredPointsFilter";

		public new static readonly string MRClassNameKey;

		static vtkDataSetToStructuredPointsFilter()
		{
			vtkDataSetToStructuredPointsFilter.MRClassNameKey = "class vtkDataSetToStructuredPointsFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataSetToStructuredPointsFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataSetToStructuredPointsFilter"));
		}

		public vtkDataSetToStructuredPointsFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetToStructuredPointsFilter_GetInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataSet GetInput()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetToStructuredPointsFilter.vtkDataSetToStructuredPointsFilter_GetInput_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkDataSetToStructuredPointsFilter_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDataSetToStructuredPointsFilter.vtkDataSetToStructuredPointsFilter_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkDataSetToStructuredPointsFilter_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDataSetToStructuredPointsFilter.vtkDataSetToStructuredPointsFilter_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetToStructuredPointsFilter_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDataSetToStructuredPointsFilter NewInstance()
		{
			vtkDataSetToStructuredPointsFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetToStructuredPointsFilter.vtkDataSetToStructuredPointsFilter_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataSetToStructuredPointsFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataSetToStructuredPointsFilter_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataSetToStructuredPointsFilter SafeDownCast(vtkObjectBase o)
		{
			vtkDataSetToStructuredPointsFilter vtkDataSetToStructuredPointsFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataSetToStructuredPointsFilter.vtkDataSetToStructuredPointsFilter_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetToStructuredPointsFilter = (vtkDataSetToStructuredPointsFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetToStructuredPointsFilter.Register(null);
				}
			}
			return vtkDataSetToStructuredPointsFilter;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkDataSetToStructuredPointsFilter_SetInput_06(HandleRef pThis, HandleRef input);

		public virtual void SetInput(vtkDataSet input)
		{
			vtkDataSetToStructuredPointsFilter.vtkDataSetToStructuredPointsFilter_SetInput_06(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}
	}
}
