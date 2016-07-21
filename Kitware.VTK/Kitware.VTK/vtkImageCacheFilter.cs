using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageCacheFilter : vtkImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageCacheFilter";

		public new static readonly string MRClassNameKey;

		static vtkImageCacheFilter()
		{
			vtkImageCacheFilter.MRClassNameKey = "class vtkImageCacheFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageCacheFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageCacheFilter"));
		}

		public vtkImageCacheFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageCacheFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageCacheFilter New()
		{
			vtkImageCacheFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageCacheFilter.vtkImageCacheFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageCacheFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageCacheFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageCacheFilter.vtkImageCacheFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageCacheFilter_GetCacheSize_01(HandleRef pThis);

		public int GetCacheSize()
		{
			return vtkImageCacheFilter.vtkImageCacheFilter_GetCacheSize_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageCacheFilter_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageCacheFilter.vtkImageCacheFilter_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageCacheFilter_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageCacheFilter.vtkImageCacheFilter_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageCacheFilter_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageCacheFilter NewInstance()
		{
			vtkImageCacheFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageCacheFilter.vtkImageCacheFilter_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageCacheFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageCacheFilter_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageCacheFilter SafeDownCast(vtkObjectBase o)
		{
			vtkImageCacheFilter vtkImageCacheFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageCacheFilter.vtkImageCacheFilter_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageCacheFilter = (vtkImageCacheFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageCacheFilter.Register(null);
				}
			}
			return vtkImageCacheFilter;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCacheFilter_SetCacheSize_07(HandleRef pThis, int size);

		public void SetCacheSize(int size)
		{
			vtkImageCacheFilter.vtkImageCacheFilter_SetCacheSize_07(base.GetCppThis(), size);
		}
	}
}
