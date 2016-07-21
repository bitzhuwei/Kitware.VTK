using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageDecomposeFilter : vtkImageIterateFilter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageDecomposeFilter";

		public new static readonly string MRClassNameKey;

		static vtkImageDecomposeFilter()
		{
			vtkImageDecomposeFilter.MRClassNameKey = "class vtkImageDecomposeFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageDecomposeFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageDecomposeFilter"));
		}

		public vtkImageDecomposeFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageDecomposeFilter_GetDimensionality_01(HandleRef pThis);

		public virtual int GetDimensionality()
		{
			return vtkImageDecomposeFilter.vtkImageDecomposeFilter_GetDimensionality_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageDecomposeFilter_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageDecomposeFilter.vtkImageDecomposeFilter_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageDecomposeFilter_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageDecomposeFilter.vtkImageDecomposeFilter_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageDecomposeFilter_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageDecomposeFilter NewInstance()
		{
			vtkImageDecomposeFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageDecomposeFilter.vtkImageDecomposeFilter_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageDecomposeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageDecomposeFilter_PermuteExtent_05(HandleRef pThis, IntPtr extent, ref int min0, ref int max0, ref int min1, ref int max1, ref int min2, ref int max2);

		public void PermuteExtent(IntPtr extent, ref int min0, ref int max0, ref int min1, ref int max1, ref int min2, ref int max2)
		{
			vtkImageDecomposeFilter.vtkImageDecomposeFilter_PermuteExtent_05(base.GetCppThis(), extent, ref min0, ref max0, ref min1, ref max1, ref min2, ref max2);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageDecomposeFilter_PermuteIncrements_06(HandleRef pThis, IntPtr increments, ref long inc0, ref long inc1, ref long inc2);

		public void PermuteIncrements(IntPtr increments, ref long inc0, ref long inc1, ref long inc2)
		{
			vtkImageDecomposeFilter.vtkImageDecomposeFilter_PermuteIncrements_06(base.GetCppThis(), increments, ref inc0, ref inc1, ref inc2);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageDecomposeFilter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageDecomposeFilter SafeDownCast(vtkObjectBase o)
		{
			vtkImageDecomposeFilter vtkImageDecomposeFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageDecomposeFilter.vtkImageDecomposeFilter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageDecomposeFilter = (vtkImageDecomposeFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageDecomposeFilter.Register(null);
				}
			}
			return vtkImageDecomposeFilter;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageDecomposeFilter_SetDimensionality_08(HandleRef pThis, int dim);

		public void SetDimensionality(int dim)
		{
			vtkImageDecomposeFilter.vtkImageDecomposeFilter_SetDimensionality_08(base.GetCppThis(), dim);
		}
	}
}
