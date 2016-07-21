using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkStructuredPointsToStructuredPointsFilter : vtkStructuredPointsSource
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkStructuredPointsToStructuredPointsFilter";

		public new static readonly string MRClassNameKey;

		static vtkStructuredPointsToStructuredPointsFilter()
		{
			vtkStructuredPointsToStructuredPointsFilter.MRClassNameKey = "class vtkStructuredPointsToStructuredPointsFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStructuredPointsToStructuredPointsFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStructuredPointsToStructuredPointsFilter"));
		}

		public vtkStructuredPointsToStructuredPointsFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredPointsToStructuredPointsFilter_GetInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkImageData GetInput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredPointsToStructuredPointsFilter.vtkStructuredPointsToStructuredPointsFilter_GetInput_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkStructuredPointsToStructuredPointsFilter_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkStructuredPointsToStructuredPointsFilter.vtkStructuredPointsToStructuredPointsFilter_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStructuredPointsToStructuredPointsFilter_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkStructuredPointsToStructuredPointsFilter.vtkStructuredPointsToStructuredPointsFilter_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredPointsToStructuredPointsFilter_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkStructuredPointsToStructuredPointsFilter NewInstance()
		{
			vtkStructuredPointsToStructuredPointsFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredPointsToStructuredPointsFilter.vtkStructuredPointsToStructuredPointsFilter_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredPointsToStructuredPointsFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredPointsToStructuredPointsFilter_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStructuredPointsToStructuredPointsFilter SafeDownCast(vtkObjectBase o)
		{
			vtkStructuredPointsToStructuredPointsFilter vtkStructuredPointsToStructuredPointsFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredPointsToStructuredPointsFilter.vtkStructuredPointsToStructuredPointsFilter_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredPointsToStructuredPointsFilter = (vtkStructuredPointsToStructuredPointsFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredPointsToStructuredPointsFilter.Register(null);
				}
			}
			return vtkStructuredPointsToStructuredPointsFilter;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkStructuredPointsToStructuredPointsFilter_SetInput_06(HandleRef pThis, HandleRef input);

		public void SetInput(vtkImageData input)
		{
			vtkStructuredPointsToStructuredPointsFilter.vtkStructuredPointsToStructuredPointsFilter_SetInput_06(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}
	}
}
