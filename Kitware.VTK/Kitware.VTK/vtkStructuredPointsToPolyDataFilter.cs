using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkStructuredPointsToPolyDataFilter : vtkPolyDataSource
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkStructuredPointsToPolyDataFilter";

		public new static readonly string MRClassNameKey;

		static vtkStructuredPointsToPolyDataFilter()
		{
			vtkStructuredPointsToPolyDataFilter.MRClassNameKey = "class vtkStructuredPointsToPolyDataFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStructuredPointsToPolyDataFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStructuredPointsToPolyDataFilter"));
		}

		public vtkStructuredPointsToPolyDataFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredPointsToPolyDataFilter_GetInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkImageData GetInput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredPointsToPolyDataFilter.vtkStructuredPointsToPolyDataFilter_GetInput_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkStructuredPointsToPolyDataFilter_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkStructuredPointsToPolyDataFilter.vtkStructuredPointsToPolyDataFilter_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkStructuredPointsToPolyDataFilter_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkStructuredPointsToPolyDataFilter.vtkStructuredPointsToPolyDataFilter_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredPointsToPolyDataFilter_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkStructuredPointsToPolyDataFilter NewInstance()
		{
			vtkStructuredPointsToPolyDataFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredPointsToPolyDataFilter.vtkStructuredPointsToPolyDataFilter_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredPointsToPolyDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredPointsToPolyDataFilter_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStructuredPointsToPolyDataFilter SafeDownCast(vtkObjectBase o)
		{
			vtkStructuredPointsToPolyDataFilter vtkStructuredPointsToPolyDataFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredPointsToPolyDataFilter.vtkStructuredPointsToPolyDataFilter_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredPointsToPolyDataFilter = (vtkStructuredPointsToPolyDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredPointsToPolyDataFilter.Register(null);
				}
			}
			return vtkStructuredPointsToPolyDataFilter;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkStructuredPointsToPolyDataFilter_SetInput_06(HandleRef pThis, HandleRef input);

		public virtual void SetInput(vtkImageData input)
		{
			vtkStructuredPointsToPolyDataFilter.vtkStructuredPointsToPolyDataFilter_SetInput_06(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}
	}
}
