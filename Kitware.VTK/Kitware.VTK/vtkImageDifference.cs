using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageDifference : vtkThreadedImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageDifference";

		public new static readonly string MRClassNameKey;

		static vtkImageDifference()
		{
			vtkImageDifference.MRClassNameKey = "class vtkImageDifference";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageDifference.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageDifference"));
		}

		public vtkImageDifference(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageDifference_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageDifference New()
		{
			vtkImageDifference result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageDifference.vtkImageDifference_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageDifference)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageDifference() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageDifference.vtkImageDifference_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageDifference_AllowShiftOff_01(HandleRef pThis);

		public virtual void AllowShiftOff()
		{
			vtkImageDifference.vtkImageDifference_AllowShiftOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageDifference_AllowShiftOn_02(HandleRef pThis);

		public virtual void AllowShiftOn()
		{
			vtkImageDifference.vtkImageDifference_AllowShiftOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageDifference_AveragingOff_03(HandleRef pThis);

		public virtual void AveragingOff()
		{
			vtkImageDifference.vtkImageDifference_AveragingOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageDifference_AveragingOn_04(HandleRef pThis);

		public virtual void AveragingOn()
		{
			vtkImageDifference.vtkImageDifference_AveragingOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageDifference_GetAllowShift_05(HandleRef pThis);

		public virtual int GetAllowShift()
		{
			return vtkImageDifference.vtkImageDifference_GetAllowShift_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageDifference_GetAveraging_06(HandleRef pThis);

		public virtual int GetAveraging()
		{
			return vtkImageDifference.vtkImageDifference_GetAveraging_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageDifference_GetError_07(HandleRef pThis);

		public double GetError()
		{
			return vtkImageDifference.vtkImageDifference_GetError_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageDifference_GetError_08(HandleRef pThis, IntPtr e);

		public void GetError(IntPtr e)
		{
			vtkImageDifference.vtkImageDifference_GetError_08(base.GetCppThis(), e);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageDifference_GetImage_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkImageData GetImage()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageDifference.vtkImageDifference_GetImage_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageDifference_GetThreshold_10(HandleRef pThis);

		public virtual int GetThreshold()
		{
			return vtkImageDifference.vtkImageDifference_GetThreshold_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageDifference_GetThresholdedError_11(HandleRef pThis);

		public double GetThresholdedError()
		{
			return vtkImageDifference.vtkImageDifference_GetThresholdedError_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageDifference_GetThresholdedError_12(HandleRef pThis, IntPtr e);

		public void GetThresholdedError(IntPtr e)
		{
			vtkImageDifference.vtkImageDifference_GetThresholdedError_12(base.GetCppThis(), e);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageDifference_IsA_13(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageDifference.vtkImageDifference_IsA_13(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageDifference_IsTypeOf_14(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageDifference.vtkImageDifference_IsTypeOf_14(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageDifference_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageDifference NewInstance()
		{
			vtkImageDifference result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageDifference.vtkImageDifference_NewInstance_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageDifference)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageDifference_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageDifference SafeDownCast(vtkObjectBase o)
		{
			vtkImageDifference vtkImageDifference = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageDifference.vtkImageDifference_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageDifference = (vtkImageDifference)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageDifference.Register(null);
				}
			}
			return vtkImageDifference;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageDifference_SetAllowShift_18(HandleRef pThis, int _arg);

		public virtual void SetAllowShift(int _arg)
		{
			vtkImageDifference.vtkImageDifference_SetAllowShift_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageDifference_SetAveraging_19(HandleRef pThis, int _arg);

		public virtual void SetAveraging(int _arg)
		{
			vtkImageDifference.vtkImageDifference_SetAveraging_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageDifference_SetImage_20(HandleRef pThis, HandleRef image);

		public void SetImage(vtkDataObject image)
		{
			vtkImageDifference.vtkImageDifference_SetImage_20(base.GetCppThis(), (image == null) ? default(HandleRef) : image.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageDifference_SetThreshold_21(HandleRef pThis, int _arg);

		public virtual void SetThreshold(int _arg)
		{
			vtkImageDifference.vtkImageDifference_SetThreshold_21(base.GetCppThis(), _arg);
		}
	}
}
