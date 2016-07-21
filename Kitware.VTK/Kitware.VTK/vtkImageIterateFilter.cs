using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageIterateFilter : vtkThreadedImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageIterateFilter";

		public new static readonly string MRClassNameKey;

		static vtkImageIterateFilter()
		{
			vtkImageIterateFilter.MRClassNameKey = "class vtkImageIterateFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageIterateFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageIterateFilter"));
		}

		public vtkImageIterateFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageIterateFilter_GetIteration_01(HandleRef pThis);

		public virtual int GetIteration()
		{
			return vtkImageIterateFilter.vtkImageIterateFilter_GetIteration_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageIterateFilter_GetNumberOfIterations_02(HandleRef pThis);

		public virtual int GetNumberOfIterations()
		{
			return vtkImageIterateFilter.vtkImageIterateFilter_GetNumberOfIterations_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageIterateFilter_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageIterateFilter.vtkImageIterateFilter_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageIterateFilter_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageIterateFilter.vtkImageIterateFilter_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageIterateFilter_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageIterateFilter NewInstance()
		{
			vtkImageIterateFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageIterateFilter.vtkImageIterateFilter_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageIterateFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageIterateFilter_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageIterateFilter SafeDownCast(vtkObjectBase o)
		{
			vtkImageIterateFilter vtkImageIterateFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageIterateFilter.vtkImageIterateFilter_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageIterateFilter = (vtkImageIterateFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageIterateFilter.Register(null);
				}
			}
			return vtkImageIterateFilter;
		}
	}
}
