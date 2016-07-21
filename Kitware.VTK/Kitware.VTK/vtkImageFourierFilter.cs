using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageFourierFilter : vtkImageDecomposeFilter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageFourierFilter";

		public new static readonly string MRClassNameKey;

		static vtkImageFourierFilter()
		{
			vtkImageFourierFilter.MRClassNameKey = "class vtkImageFourierFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageFourierFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageFourierFilter"));
		}

		public vtkImageFourierFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageFourierFilter_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageFourierFilter.vtkImageFourierFilter_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageFourierFilter_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageFourierFilter.vtkImageFourierFilter_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageFourierFilter_NewInstance_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageFourierFilter NewInstance()
		{
			vtkImageFourierFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageFourierFilter.vtkImageFourierFilter_NewInstance_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageFourierFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageFourierFilter_SafeDownCast_04(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageFourierFilter SafeDownCast(vtkObjectBase o)
		{
			vtkImageFourierFilter vtkImageFourierFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageFourierFilter.vtkImageFourierFilter_SafeDownCast_04((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageFourierFilter = (vtkImageFourierFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageFourierFilter.Register(null);
				}
			}
			return vtkImageFourierFilter;
		}
	}
}
