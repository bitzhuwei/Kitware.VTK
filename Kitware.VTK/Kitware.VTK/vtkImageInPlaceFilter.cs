using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageInPlaceFilter : vtkImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageInPlaceFilter";

		public new static readonly string MRClassNameKey;

		static vtkImageInPlaceFilter()
		{
			vtkImageInPlaceFilter.MRClassNameKey = "class vtkImageInPlaceFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageInPlaceFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageInPlaceFilter"));
		}

		public vtkImageInPlaceFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImageInPlaceFilter_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageInPlaceFilter.vtkImageInPlaceFilter_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkImageInPlaceFilter_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageInPlaceFilter.vtkImageInPlaceFilter_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageInPlaceFilter_NewInstance_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageInPlaceFilter NewInstance()
		{
			vtkImageInPlaceFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageInPlaceFilter.vtkImageInPlaceFilter_NewInstance_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageInPlaceFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageInPlaceFilter_SafeDownCast_04(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageInPlaceFilter SafeDownCast(vtkObjectBase o)
		{
			vtkImageInPlaceFilter vtkImageInPlaceFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageInPlaceFilter.vtkImageInPlaceFilter_SafeDownCast_04((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageInPlaceFilter = (vtkImageInPlaceFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageInPlaceFilter.Register(null);
				}
			}
			return vtkImageInPlaceFilter;
		}
	}
}
