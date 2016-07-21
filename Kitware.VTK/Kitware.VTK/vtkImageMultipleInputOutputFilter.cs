using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageMultipleInputOutputFilter : vtkImageMultipleInputFilter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageMultipleInputOutputFilter";

		public new static readonly string MRClassNameKey;

		static vtkImageMultipleInputOutputFilter()
		{
			vtkImageMultipleInputOutputFilter.MRClassNameKey = "class vtkImageMultipleInputOutputFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageMultipleInputOutputFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageMultipleInputOutputFilter"));
		}

		public vtkImageMultipleInputOutputFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMultipleInputOutputFilter_GetOutput_01(HandleRef pThis, int num, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageData GetOutput(int num)
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMultipleInputOutputFilter.vtkImageMultipleInputOutputFilter_GetOutput_01(base.GetCppThis(), num, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkImageMultipleInputOutputFilter_GetOutput_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageData GetOutput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMultipleInputOutputFilter.vtkImageMultipleInputOutputFilter_GetOutput_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkImageMultipleInputOutputFilter_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageMultipleInputOutputFilter.vtkImageMultipleInputOutputFilter_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImageMultipleInputOutputFilter_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageMultipleInputOutputFilter.vtkImageMultipleInputOutputFilter_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMultipleInputOutputFilter_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageMultipleInputOutputFilter NewInstance()
		{
			vtkImageMultipleInputOutputFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMultipleInputOutputFilter.vtkImageMultipleInputOutputFilter_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMultipleInputOutputFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMultipleInputOutputFilter_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageMultipleInputOutputFilter SafeDownCast(vtkObjectBase o)
		{
			vtkImageMultipleInputOutputFilter vtkImageMultipleInputOutputFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMultipleInputOutputFilter.vtkImageMultipleInputOutputFilter_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageMultipleInputOutputFilter = (vtkImageMultipleInputOutputFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageMultipleInputOutputFilter.Register(null);
				}
			}
			return vtkImageMultipleInputOutputFilter;
		}
	}
}
