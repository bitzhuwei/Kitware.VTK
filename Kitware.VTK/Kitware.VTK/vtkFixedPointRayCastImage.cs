using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkFixedPointRayCastImage : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkFixedPointRayCastImage";

		public new static readonly string MRClassNameKey;

		static vtkFixedPointRayCastImage()
		{
			vtkFixedPointRayCastImage.MRClassNameKey = "class vtkFixedPointRayCastImage";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFixedPointRayCastImage.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFixedPointRayCastImage"));
		}

		public vtkFixedPointRayCastImage(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedPointRayCastImage_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFixedPointRayCastImage New()
		{
			vtkFixedPointRayCastImage result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFixedPointRayCastImage)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkFixedPointRayCastImage() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointRayCastImage_AllocateImage_01(HandleRef pThis);

		public void AllocateImage()
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_AllocateImage_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointRayCastImage_AllocateZBuffer_02(HandleRef pThis);

		public void AllocateZBuffer()
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_AllocateZBuffer_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointRayCastImage_ClearImage_03(HandleRef pThis);

		public void ClearImage()
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_ClearImage_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedPointRayCastImage_GetImage_04(HandleRef pThis);

		public IntPtr GetImage()
		{
			return vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_GetImage_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedPointRayCastImage_GetImageInUseSize_05(HandleRef pThis);

		public virtual int[] GetImageInUseSize()
		{
			IntPtr intPtr = vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_GetImageInUseSize_05(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointRayCastImage_GetImageInUseSize_06(HandleRef pThis, IntPtr data);

		public virtual void GetImageInUseSize(IntPtr data)
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_GetImageInUseSize_06(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedPointRayCastImage_GetImageMemorySize_07(HandleRef pThis);

		public virtual int[] GetImageMemorySize()
		{
			IntPtr intPtr = vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_GetImageMemorySize_07(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointRayCastImage_GetImageMemorySize_08(HandleRef pThis, IntPtr data);

		public virtual void GetImageMemorySize(IntPtr data)
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_GetImageMemorySize_08(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedPointRayCastImage_GetImageOrigin_09(HandleRef pThis);

		public virtual int[] GetImageOrigin()
		{
			IntPtr intPtr = vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_GetImageOrigin_09(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointRayCastImage_GetImageOrigin_10(HandleRef pThis, IntPtr data);

		public virtual void GetImageOrigin(IntPtr data)
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_GetImageOrigin_10(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkFixedPointRayCastImage_GetImageSampleDistance_11(HandleRef pThis);

		public virtual float GetImageSampleDistance()
		{
			return vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_GetImageSampleDistance_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedPointRayCastImage_GetImageViewportSize_12(HandleRef pThis);

		public virtual int[] GetImageViewportSize()
		{
			IntPtr intPtr = vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_GetImageViewportSize_12(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointRayCastImage_GetImageViewportSize_13(HandleRef pThis, IntPtr data);

		public virtual void GetImageViewportSize(IntPtr data)
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_GetImageViewportSize_13(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkFixedPointRayCastImage_GetUseZBuffer_14(HandleRef pThis);

		public virtual int GetUseZBuffer()
		{
			return vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_GetUseZBuffer_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkFixedPointRayCastImage_GetUseZBufferMaxValue_15(HandleRef pThis);

		public virtual int GetUseZBufferMaxValue()
		{
			return vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_GetUseZBufferMaxValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkFixedPointRayCastImage_GetUseZBufferMinValue_16(HandleRef pThis);

		public virtual int GetUseZBufferMinValue()
		{
			return vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_GetUseZBufferMinValue_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedPointRayCastImage_GetZBuffer_17(HandleRef pThis);

		public IntPtr GetZBuffer()
		{
			return vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_GetZBuffer_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedPointRayCastImage_GetZBufferOrigin_18(HandleRef pThis);

		public virtual int[] GetZBufferOrigin()
		{
			IntPtr intPtr = vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_GetZBufferOrigin_18(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointRayCastImage_GetZBufferOrigin_19(HandleRef pThis, IntPtr data);

		public virtual void GetZBufferOrigin(IntPtr data)
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_GetZBufferOrigin_19(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedPointRayCastImage_GetZBufferSize_20(HandleRef pThis);

		public virtual int[] GetZBufferSize()
		{
			IntPtr intPtr = vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_GetZBufferSize_20(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointRayCastImage_GetZBufferSize_21(HandleRef pThis, IntPtr data);

		public virtual void GetZBufferSize(IntPtr data)
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_GetZBufferSize_21(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkFixedPointRayCastImage_GetZBufferValue_22(HandleRef pThis, int x, int y);

		public float GetZBufferValue(int x, int y)
		{
			return vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_GetZBufferValue_22(base.GetCppThis(), x, y);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkFixedPointRayCastImage_IsA_23(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_IsA_23(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkFixedPointRayCastImage_IsTypeOf_24(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_IsTypeOf_24(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedPointRayCastImage_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkFixedPointRayCastImage NewInstance()
		{
			vtkFixedPointRayCastImage result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_NewInstance_26(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFixedPointRayCastImage)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFixedPointRayCastImage_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFixedPointRayCastImage SafeDownCast(vtkObjectBase o)
		{
			vtkFixedPointRayCastImage vtkFixedPointRayCastImage = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFixedPointRayCastImage = (vtkFixedPointRayCastImage)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFixedPointRayCastImage.Register(null);
				}
			}
			return vtkFixedPointRayCastImage;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointRayCastImage_SetImageInUseSize_28(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetImageInUseSize(int _arg1, int _arg2)
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_SetImageInUseSize_28(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointRayCastImage_SetImageInUseSize_29(HandleRef pThis, IntPtr _arg);

		public void SetImageInUseSize(IntPtr _arg)
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_SetImageInUseSize_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointRayCastImage_SetImageMemorySize_30(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetImageMemorySize(int _arg1, int _arg2)
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_SetImageMemorySize_30(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointRayCastImage_SetImageMemorySize_31(HandleRef pThis, IntPtr _arg);

		public void SetImageMemorySize(IntPtr _arg)
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_SetImageMemorySize_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointRayCastImage_SetImageOrigin_32(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetImageOrigin(int _arg1, int _arg2)
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_SetImageOrigin_32(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointRayCastImage_SetImageOrigin_33(HandleRef pThis, IntPtr _arg);

		public void SetImageOrigin(IntPtr _arg)
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_SetImageOrigin_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointRayCastImage_SetImageSampleDistance_34(HandleRef pThis, float _arg);

		public virtual void SetImageSampleDistance(float _arg)
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_SetImageSampleDistance_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointRayCastImage_SetImageViewportSize_35(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetImageViewportSize(int _arg1, int _arg2)
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_SetImageViewportSize_35(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointRayCastImage_SetImageViewportSize_36(HandleRef pThis, IntPtr _arg);

		public void SetImageViewportSize(IntPtr _arg)
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_SetImageViewportSize_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointRayCastImage_SetUseZBuffer_37(HandleRef pThis, int _arg);

		public virtual void SetUseZBuffer(int _arg)
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_SetUseZBuffer_37(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointRayCastImage_SetZBufferOrigin_38(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetZBufferOrigin(int _arg1, int _arg2)
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_SetZBufferOrigin_38(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointRayCastImage_SetZBufferOrigin_39(HandleRef pThis, IntPtr _arg);

		public void SetZBufferOrigin(IntPtr _arg)
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_SetZBufferOrigin_39(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointRayCastImage_SetZBufferSize_40(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetZBufferSize(int _arg1, int _arg2)
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_SetZBufferSize_40(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointRayCastImage_SetZBufferSize_41(HandleRef pThis, IntPtr _arg);

		public void SetZBufferSize(IntPtr _arg)
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_SetZBufferSize_41(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointRayCastImage_UseZBufferOff_42(HandleRef pThis);

		public virtual void UseZBufferOff()
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_UseZBufferOff_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkFixedPointRayCastImage_UseZBufferOn_43(HandleRef pThis);

		public virtual void UseZBufferOn()
		{
			vtkFixedPointRayCastImage.vtkFixedPointRayCastImage_UseZBufferOn_43(base.GetCppThis());
		}
	}
}
