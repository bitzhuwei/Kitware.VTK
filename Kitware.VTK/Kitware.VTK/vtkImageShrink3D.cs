using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageShrink3D : vtkThreadedImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageShrink3D";

		public new static readonly string MRClassNameKey;

		static vtkImageShrink3D()
		{
			vtkImageShrink3D.MRClassNameKey = "class vtkImageShrink3D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageShrink3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageShrink3D"));
		}

		public vtkImageShrink3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageShrink3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageShrink3D New()
		{
			vtkImageShrink3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageShrink3D.vtkImageShrink3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageShrink3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageShrink3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageShrink3D.vtkImageShrink3D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageShrink3D_AveragingOff_01(HandleRef pThis);

		public virtual void AveragingOff()
		{
			vtkImageShrink3D.vtkImageShrink3D_AveragingOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageShrink3D_AveragingOn_02(HandleRef pThis);

		public virtual void AveragingOn()
		{
			vtkImageShrink3D.vtkImageShrink3D_AveragingOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageShrink3D_GetAveraging_03(HandleRef pThis);

		public int GetAveraging()
		{
			return vtkImageShrink3D.vtkImageShrink3D_GetAveraging_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageShrink3D_GetMaximum_04(HandleRef pThis);

		public virtual int GetMaximum()
		{
			return vtkImageShrink3D.vtkImageShrink3D_GetMaximum_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageShrink3D_GetMean_05(HandleRef pThis);

		public virtual int GetMean()
		{
			return vtkImageShrink3D.vtkImageShrink3D_GetMean_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageShrink3D_GetMedian_06(HandleRef pThis);

		public virtual int GetMedian()
		{
			return vtkImageShrink3D.vtkImageShrink3D_GetMedian_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageShrink3D_GetMinimum_07(HandleRef pThis);

		public virtual int GetMinimum()
		{
			return vtkImageShrink3D.vtkImageShrink3D_GetMinimum_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageShrink3D_GetShift_08(HandleRef pThis);

		public virtual int[] GetShift()
		{
			IntPtr intPtr = vtkImageShrink3D.vtkImageShrink3D_GetShift_08(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageShrink3D_GetShift_09(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		public virtual void GetShift(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkImageShrink3D.vtkImageShrink3D_GetShift_09(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageShrink3D_GetShift_10(HandleRef pThis, IntPtr _arg);

		public virtual void GetShift(IntPtr _arg)
		{
			vtkImageShrink3D.vtkImageShrink3D_GetShift_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageShrink3D_GetShrinkFactors_11(HandleRef pThis);

		public virtual int[] GetShrinkFactors()
		{
			IntPtr intPtr = vtkImageShrink3D.vtkImageShrink3D_GetShrinkFactors_11(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageShrink3D_GetShrinkFactors_12(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		public virtual void GetShrinkFactors(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkImageShrink3D.vtkImageShrink3D_GetShrinkFactors_12(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageShrink3D_GetShrinkFactors_13(HandleRef pThis, IntPtr _arg);

		public virtual void GetShrinkFactors(IntPtr _arg)
		{
			vtkImageShrink3D.vtkImageShrink3D_GetShrinkFactors_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageShrink3D_IsA_14(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageShrink3D.vtkImageShrink3D_IsA_14(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageShrink3D_IsTypeOf_15(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageShrink3D.vtkImageShrink3D_IsTypeOf_15(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageShrink3D_MaximumOff_16(HandleRef pThis);

		public virtual void MaximumOff()
		{
			vtkImageShrink3D.vtkImageShrink3D_MaximumOff_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageShrink3D_MaximumOn_17(HandleRef pThis);

		public virtual void MaximumOn()
		{
			vtkImageShrink3D.vtkImageShrink3D_MaximumOn_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageShrink3D_MeanOff_18(HandleRef pThis);

		public virtual void MeanOff()
		{
			vtkImageShrink3D.vtkImageShrink3D_MeanOff_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageShrink3D_MeanOn_19(HandleRef pThis);

		public virtual void MeanOn()
		{
			vtkImageShrink3D.vtkImageShrink3D_MeanOn_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageShrink3D_MedianOff_20(HandleRef pThis);

		public virtual void MedianOff()
		{
			vtkImageShrink3D.vtkImageShrink3D_MedianOff_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageShrink3D_MedianOn_21(HandleRef pThis);

		public virtual void MedianOn()
		{
			vtkImageShrink3D.vtkImageShrink3D_MedianOn_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageShrink3D_MinimumOff_22(HandleRef pThis);

		public virtual void MinimumOff()
		{
			vtkImageShrink3D.vtkImageShrink3D_MinimumOff_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageShrink3D_MinimumOn_23(HandleRef pThis);

		public virtual void MinimumOn()
		{
			vtkImageShrink3D.vtkImageShrink3D_MinimumOn_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageShrink3D_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageShrink3D NewInstance()
		{
			vtkImageShrink3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageShrink3D.vtkImageShrink3D_NewInstance_25(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageShrink3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageShrink3D_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageShrink3D SafeDownCast(vtkObjectBase o)
		{
			vtkImageShrink3D vtkImageShrink3D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageShrink3D.vtkImageShrink3D_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageShrink3D = (vtkImageShrink3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageShrink3D.Register(null);
				}
			}
			return vtkImageShrink3D;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageShrink3D_SetAveraging_27(HandleRef pThis, int arg0);

		public void SetAveraging(int arg0)
		{
			vtkImageShrink3D.vtkImageShrink3D_SetAveraging_27(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageShrink3D_SetMaximum_28(HandleRef pThis, int arg0);

		public void SetMaximum(int arg0)
		{
			vtkImageShrink3D.vtkImageShrink3D_SetMaximum_28(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageShrink3D_SetMean_29(HandleRef pThis, int arg0);

		public void SetMean(int arg0)
		{
			vtkImageShrink3D.vtkImageShrink3D_SetMean_29(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageShrink3D_SetMedian_30(HandleRef pThis, int arg0);

		public void SetMedian(int arg0)
		{
			vtkImageShrink3D.vtkImageShrink3D_SetMedian_30(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageShrink3D_SetMinimum_31(HandleRef pThis, int arg0);

		public void SetMinimum(int arg0)
		{
			vtkImageShrink3D.vtkImageShrink3D_SetMinimum_31(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageShrink3D_SetShift_32(HandleRef pThis, int _arg1, int _arg2, int _arg3);

		public virtual void SetShift(int _arg1, int _arg2, int _arg3)
		{
			vtkImageShrink3D.vtkImageShrink3D_SetShift_32(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageShrink3D_SetShift_33(HandleRef pThis, IntPtr _arg);

		public virtual void SetShift(IntPtr _arg)
		{
			vtkImageShrink3D.vtkImageShrink3D_SetShift_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageShrink3D_SetShrinkFactors_34(HandleRef pThis, int _arg1, int _arg2, int _arg3);

		public virtual void SetShrinkFactors(int _arg1, int _arg2, int _arg3)
		{
			vtkImageShrink3D.vtkImageShrink3D_SetShrinkFactors_34(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageShrink3D_SetShrinkFactors_35(HandleRef pThis, IntPtr _arg);

		public virtual void SetShrinkFactors(IntPtr _arg)
		{
			vtkImageShrink3D.vtkImageShrink3D_SetShrinkFactors_35(base.GetCppThis(), _arg);
		}
	}
}
