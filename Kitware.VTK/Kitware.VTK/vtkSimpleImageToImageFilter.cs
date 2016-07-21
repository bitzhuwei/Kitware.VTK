using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkSimpleImageToImageFilter : vtkImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSimpleImageToImageFilter";

		public new static readonly string MRClassNameKey;

		static vtkSimpleImageToImageFilter()
		{
			vtkSimpleImageToImageFilter.MRClassNameKey = "class vtkSimpleImageToImageFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSimpleImageToImageFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSimpleImageToImageFilter"));
		}

		public vtkSimpleImageToImageFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkSimpleImageToImageFilter_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSimpleImageToImageFilter.vtkSimpleImageToImageFilter_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkSimpleImageToImageFilter_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSimpleImageToImageFilter.vtkSimpleImageToImageFilter_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkSimpleImageToImageFilter_NewInstance_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSimpleImageToImageFilter NewInstance()
		{
			vtkSimpleImageToImageFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSimpleImageToImageFilter.vtkSimpleImageToImageFilter_NewInstance_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSimpleImageToImageFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkSimpleImageToImageFilter_SafeDownCast_04(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSimpleImageToImageFilter SafeDownCast(vtkObjectBase o)
		{
			vtkSimpleImageToImageFilter vtkSimpleImageToImageFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSimpleImageToImageFilter.vtkSimpleImageToImageFilter_SafeDownCast_04((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSimpleImageToImageFilter = (vtkSimpleImageToImageFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSimpleImageToImageFilter.Register(null);
				}
			}
			return vtkSimpleImageToImageFilter;
		}
	}
}
