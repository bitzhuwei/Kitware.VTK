using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageConvolve : vtkThreadedImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageConvolve";

		public new static readonly string MRClassNameKey;

		static vtkImageConvolve()
		{
			vtkImageConvolve.MRClassNameKey = "class vtkImageConvolve";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageConvolve.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageConvolve"));
		}

		public vtkImageConvolve(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageConvolve_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageConvolve New()
		{
			vtkImageConvolve result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageConvolve.vtkImageConvolve_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageConvolve)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageConvolve() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageConvolve.vtkImageConvolve_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageConvolve_GetKernel3x3_01(HandleRef pThis);

		public IntPtr GetKernel3x3()
		{
			return vtkImageConvolve.vtkImageConvolve_GetKernel3x3_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageConvolve_GetKernel3x3_02(HandleRef pThis, IntPtr kernel);

		public void GetKernel3x3(IntPtr kernel)
		{
			vtkImageConvolve.vtkImageConvolve_GetKernel3x3_02(base.GetCppThis(), kernel);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageConvolve_GetKernel3x3x3_03(HandleRef pThis);

		public IntPtr GetKernel3x3x3()
		{
			return vtkImageConvolve.vtkImageConvolve_GetKernel3x3x3_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageConvolve_GetKernel3x3x3_04(HandleRef pThis, IntPtr kernel);

		public void GetKernel3x3x3(IntPtr kernel)
		{
			vtkImageConvolve.vtkImageConvolve_GetKernel3x3x3_04(base.GetCppThis(), kernel);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageConvolve_GetKernel5x5_05(HandleRef pThis);

		public IntPtr GetKernel5x5()
		{
			return vtkImageConvolve.vtkImageConvolve_GetKernel5x5_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageConvolve_GetKernel5x5_06(HandleRef pThis, IntPtr kernel);

		public void GetKernel5x5(IntPtr kernel)
		{
			vtkImageConvolve.vtkImageConvolve_GetKernel5x5_06(base.GetCppThis(), kernel);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageConvolve_GetKernel5x5x5_07(HandleRef pThis);

		public IntPtr GetKernel5x5x5()
		{
			return vtkImageConvolve.vtkImageConvolve_GetKernel5x5x5_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageConvolve_GetKernel5x5x5_08(HandleRef pThis, IntPtr kernel);

		public void GetKernel5x5x5(IntPtr kernel)
		{
			vtkImageConvolve.vtkImageConvolve_GetKernel5x5x5_08(base.GetCppThis(), kernel);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageConvolve_GetKernel7x7_09(HandleRef pThis);

		public IntPtr GetKernel7x7()
		{
			return vtkImageConvolve.vtkImageConvolve_GetKernel7x7_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageConvolve_GetKernel7x7_10(HandleRef pThis, IntPtr kernel);

		public void GetKernel7x7(IntPtr kernel)
		{
			vtkImageConvolve.vtkImageConvolve_GetKernel7x7_10(base.GetCppThis(), kernel);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageConvolve_GetKernel7x7x7_11(HandleRef pThis);

		public IntPtr GetKernel7x7x7()
		{
			return vtkImageConvolve.vtkImageConvolve_GetKernel7x7x7_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageConvolve_GetKernel7x7x7_12(HandleRef pThis, IntPtr kernel);

		public void GetKernel7x7x7(IntPtr kernel)
		{
			vtkImageConvolve.vtkImageConvolve_GetKernel7x7x7_12(base.GetCppThis(), kernel);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageConvolve_GetKernelSize_13(HandleRef pThis);

		public virtual int[] GetKernelSize()
		{
			IntPtr intPtr = vtkImageConvolve.vtkImageConvolve_GetKernelSize_13(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageConvolve_GetKernelSize_14(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		public virtual void GetKernelSize(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkImageConvolve.vtkImageConvolve_GetKernelSize_14(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageConvolve_GetKernelSize_15(HandleRef pThis, IntPtr _arg);

		public virtual void GetKernelSize(IntPtr _arg)
		{
			vtkImageConvolve.vtkImageConvolve_GetKernelSize_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageConvolve_IsA_16(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageConvolve.vtkImageConvolve_IsA_16(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageConvolve_IsTypeOf_17(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageConvolve.vtkImageConvolve_IsTypeOf_17(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageConvolve_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageConvolve NewInstance()
		{
			vtkImageConvolve result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageConvolve.vtkImageConvolve_NewInstance_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageConvolve)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageConvolve_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageConvolve SafeDownCast(vtkObjectBase o)
		{
			vtkImageConvolve vtkImageConvolve = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageConvolve.vtkImageConvolve_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageConvolve = (vtkImageConvolve)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageConvolve.Register(null);
				}
			}
			return vtkImageConvolve;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageConvolve_SetKernel3x3_21(HandleRef pThis, IntPtr kernel);

		public void SetKernel3x3(IntPtr kernel)
		{
			vtkImageConvolve.vtkImageConvolve_SetKernel3x3_21(base.GetCppThis(), kernel);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageConvolve_SetKernel3x3x3_22(HandleRef pThis, IntPtr kernel);

		public void SetKernel3x3x3(IntPtr kernel)
		{
			vtkImageConvolve.vtkImageConvolve_SetKernel3x3x3_22(base.GetCppThis(), kernel);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageConvolve_SetKernel5x5_23(HandleRef pThis, IntPtr kernel);

		public void SetKernel5x5(IntPtr kernel)
		{
			vtkImageConvolve.vtkImageConvolve_SetKernel5x5_23(base.GetCppThis(), kernel);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageConvolve_SetKernel5x5x5_24(HandleRef pThis, IntPtr kernel);

		public void SetKernel5x5x5(IntPtr kernel)
		{
			vtkImageConvolve.vtkImageConvolve_SetKernel5x5x5_24(base.GetCppThis(), kernel);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageConvolve_SetKernel7x7_25(HandleRef pThis, IntPtr kernel);

		public void SetKernel7x7(IntPtr kernel)
		{
			vtkImageConvolve.vtkImageConvolve_SetKernel7x7_25(base.GetCppThis(), kernel);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageConvolve_SetKernel7x7x7_26(HandleRef pThis, IntPtr kernel);

		public void SetKernel7x7x7(IntPtr kernel)
		{
			vtkImageConvolve.vtkImageConvolve_SetKernel7x7x7_26(base.GetCppThis(), kernel);
		}
	}
}
