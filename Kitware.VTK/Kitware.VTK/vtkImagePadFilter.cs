using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImagePadFilter : vtkThreadedImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImagePadFilter";

		public new static readonly string MRClassNameKey;

		static vtkImagePadFilter()
		{
			vtkImagePadFilter.MRClassNameKey = "class vtkImagePadFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImagePadFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImagePadFilter"));
		}

		public vtkImagePadFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImagePadFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImagePadFilter New()
		{
			vtkImagePadFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImagePadFilter.vtkImagePadFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImagePadFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImagePadFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImagePadFilter.vtkImagePadFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImagePadFilter_GetOutputNumberOfScalarComponents_01(HandleRef pThis);

		public virtual int GetOutputNumberOfScalarComponents()
		{
			return vtkImagePadFilter.vtkImagePadFilter_GetOutputNumberOfScalarComponents_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImagePadFilter_GetOutputWholeExtent_02(HandleRef pThis, IntPtr extent);

		public void GetOutputWholeExtent(IntPtr extent)
		{
			vtkImagePadFilter.vtkImagePadFilter_GetOutputWholeExtent_02(base.GetCppThis(), extent);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImagePadFilter_GetOutputWholeExtent_03(HandleRef pThis);

		public int[] GetOutputWholeExtent()
		{
			IntPtr intPtr = vtkImagePadFilter.vtkImagePadFilter_GetOutputWholeExtent_03(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImagePadFilter_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImagePadFilter.vtkImagePadFilter_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImagePadFilter_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImagePadFilter.vtkImagePadFilter_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImagePadFilter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImagePadFilter NewInstance()
		{
			vtkImagePadFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImagePadFilter.vtkImagePadFilter_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImagePadFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImagePadFilter_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImagePadFilter SafeDownCast(vtkObjectBase o)
		{
			vtkImagePadFilter vtkImagePadFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImagePadFilter.vtkImagePadFilter_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImagePadFilter = (vtkImagePadFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImagePadFilter.Register(null);
				}
			}
			return vtkImagePadFilter;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImagePadFilter_SetOutputNumberOfScalarComponents_09(HandleRef pThis, int _arg);

		public virtual void SetOutputNumberOfScalarComponents(int _arg)
		{
			vtkImagePadFilter.vtkImagePadFilter_SetOutputNumberOfScalarComponents_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImagePadFilter_SetOutputWholeExtent_10(HandleRef pThis, IntPtr extent);

		public void SetOutputWholeExtent(IntPtr extent)
		{
			vtkImagePadFilter.vtkImagePadFilter_SetOutputWholeExtent_10(base.GetCppThis(), extent);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImagePadFilter_SetOutputWholeExtent_11(HandleRef pThis, int minX, int maxX, int minY, int maxY, int minZ, int maxZ);

		public void SetOutputWholeExtent(int minX, int maxX, int minY, int maxY, int minZ, int maxZ)
		{
			vtkImagePadFilter.vtkImagePadFilter_SetOutputWholeExtent_11(base.GetCppThis(), minX, maxX, minY, maxY, minZ, maxZ);
		}
	}
}
