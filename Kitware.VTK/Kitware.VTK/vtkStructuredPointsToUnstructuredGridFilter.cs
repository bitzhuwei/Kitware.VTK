using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkStructuredPointsToUnstructuredGridFilter : vtkUnstructuredGridSource
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkStructuredPointsToUnstructuredGridFilter";

		public new static readonly string MRClassNameKey;

		static vtkStructuredPointsToUnstructuredGridFilter()
		{
			vtkStructuredPointsToUnstructuredGridFilter.MRClassNameKey = "class vtkStructuredPointsToUnstructuredGridFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStructuredPointsToUnstructuredGridFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStructuredPointsToUnstructuredGridFilter"));
		}

		public vtkStructuredPointsToUnstructuredGridFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredPointsToUnstructuredGridFilter_GetInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkImageData GetInput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredPointsToUnstructuredGridFilter.vtkStructuredPointsToUnstructuredGridFilter_GetInput_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStructuredPointsToUnstructuredGridFilter_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkStructuredPointsToUnstructuredGridFilter.vtkStructuredPointsToUnstructuredGridFilter_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStructuredPointsToUnstructuredGridFilter_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkStructuredPointsToUnstructuredGridFilter.vtkStructuredPointsToUnstructuredGridFilter_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredPointsToUnstructuredGridFilter_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkStructuredPointsToUnstructuredGridFilter NewInstance()
		{
			vtkStructuredPointsToUnstructuredGridFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredPointsToUnstructuredGridFilter.vtkStructuredPointsToUnstructuredGridFilter_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredPointsToUnstructuredGridFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredPointsToUnstructuredGridFilter_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStructuredPointsToUnstructuredGridFilter SafeDownCast(vtkObjectBase o)
		{
			vtkStructuredPointsToUnstructuredGridFilter vtkStructuredPointsToUnstructuredGridFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredPointsToUnstructuredGridFilter.vtkStructuredPointsToUnstructuredGridFilter_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredPointsToUnstructuredGridFilter = (vtkStructuredPointsToUnstructuredGridFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredPointsToUnstructuredGridFilter.Register(null);
				}
			}
			return vtkStructuredPointsToUnstructuredGridFilter;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkStructuredPointsToUnstructuredGridFilter_SetInput_06(HandleRef pThis, HandleRef input);

		public void SetInput(vtkImageData input)
		{
			vtkStructuredPointsToUnstructuredGridFilter.vtkStructuredPointsToUnstructuredGridFilter_SetInput_06(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}
	}
}
