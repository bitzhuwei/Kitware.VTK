using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageSpatialAlgorithm : vtkThreadedImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageSpatialAlgorithm";

		public new static readonly string MRClassNameKey;

		static vtkImageSpatialAlgorithm()
		{
			vtkImageSpatialAlgorithm.MRClassNameKey = "class vtkImageSpatialAlgorithm";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageSpatialAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageSpatialAlgorithm"));
		}

		public vtkImageSpatialAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageSpatialAlgorithm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageSpatialAlgorithm New()
		{
			vtkImageSpatialAlgorithm result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageSpatialAlgorithm.vtkImageSpatialAlgorithm_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageSpatialAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageSpatialAlgorithm() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageSpatialAlgorithm.vtkImageSpatialAlgorithm_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageSpatialAlgorithm_GetKernelMiddle_01(HandleRef pThis);

		public virtual int[] GetKernelMiddle()
		{
			IntPtr intPtr = vtkImageSpatialAlgorithm.vtkImageSpatialAlgorithm_GetKernelMiddle_01(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSpatialAlgorithm_GetKernelMiddle_02(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		public virtual void GetKernelMiddle(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkImageSpatialAlgorithm.vtkImageSpatialAlgorithm_GetKernelMiddle_02(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSpatialAlgorithm_GetKernelMiddle_03(HandleRef pThis, IntPtr _arg);

		public virtual void GetKernelMiddle(IntPtr _arg)
		{
			vtkImageSpatialAlgorithm.vtkImageSpatialAlgorithm_GetKernelMiddle_03(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageSpatialAlgorithm_GetKernelSize_04(HandleRef pThis);

		public virtual int[] GetKernelSize()
		{
			IntPtr intPtr = vtkImageSpatialAlgorithm.vtkImageSpatialAlgorithm_GetKernelSize_04(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSpatialAlgorithm_GetKernelSize_05(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		public virtual void GetKernelSize(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkImageSpatialAlgorithm.vtkImageSpatialAlgorithm_GetKernelSize_05(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageSpatialAlgorithm_GetKernelSize_06(HandleRef pThis, IntPtr _arg);

		public virtual void GetKernelSize(IntPtr _arg)
		{
			vtkImageSpatialAlgorithm.vtkImageSpatialAlgorithm_GetKernelSize_06(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageSpatialAlgorithm_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageSpatialAlgorithm.vtkImageSpatialAlgorithm_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageSpatialAlgorithm_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageSpatialAlgorithm.vtkImageSpatialAlgorithm_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageSpatialAlgorithm_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageSpatialAlgorithm NewInstance()
		{
			vtkImageSpatialAlgorithm result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageSpatialAlgorithm.vtkImageSpatialAlgorithm_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageSpatialAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageSpatialAlgorithm_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageSpatialAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkImageSpatialAlgorithm vtkImageSpatialAlgorithm = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageSpatialAlgorithm.vtkImageSpatialAlgorithm_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageSpatialAlgorithm = (vtkImageSpatialAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageSpatialAlgorithm.Register(null);
				}
			}
			return vtkImageSpatialAlgorithm;
		}
	}
}
