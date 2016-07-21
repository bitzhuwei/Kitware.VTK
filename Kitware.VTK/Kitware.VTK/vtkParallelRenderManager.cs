using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkParallelRenderManager : vtkObject
	{
		public enum LINEAR_WrapperEnum
		{
			LINEAR = 1,
			NEAREST = 0
		}

		public enum Tags
		{
			BOUNDS_TAG = 23543,
			COMPUTE_VISIBLE_PROP_BOUNDS_RMI_TAG = 54636,
			LIGHT_INFO_TAG = 87838,
			RENDER_RMI_TAG = 34532,
			REN_ID_TAG = 58794,
			REN_INFO_TAG = 87836,
			WIN_INFO_TAG = 87834
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkParallelRenderManager";

		public new static readonly string MRClassNameKey;

		static vtkParallelRenderManager()
		{
			vtkParallelRenderManager.MRClassNameKey = "class vtkParallelRenderManager";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParallelRenderManager.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParallelRenderManager"));
		}

		public vtkParallelRenderManager(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_AddRenderer_01(HandleRef pThis, HandleRef arg0);

		public virtual void AddRenderer(vtkRenderer arg0)
		{
			vtkParallelRenderManager.vtkParallelRenderManager_AddRenderer_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_AutoImageReductionFactorOff_02(HandleRef pThis);

		public virtual void AutoImageReductionFactorOff()
		{
			vtkParallelRenderManager.vtkParallelRenderManager_AutoImageReductionFactorOff_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_AutoImageReductionFactorOn_03(HandleRef pThis);

		public virtual void AutoImageReductionFactorOn()
		{
			vtkParallelRenderManager.vtkParallelRenderManager_AutoImageReductionFactorOn_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkParallelRenderManager_CheckForAbortComposite_04(HandleRef pThis);

		public virtual int CheckForAbortComposite()
		{
			return vtkParallelRenderManager.vtkParallelRenderManager_CheckForAbortComposite_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_CheckForAbortRender_05(HandleRef pThis);

		public virtual void CheckForAbortRender()
		{
			vtkParallelRenderManager.vtkParallelRenderManager_CheckForAbortRender_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_ComputeVisiblePropBounds_06(HandleRef pThis, HandleRef ren, IntPtr bounds);

		public virtual void ComputeVisiblePropBounds(vtkRenderer ren, IntPtr bounds)
		{
			vtkParallelRenderManager.vtkParallelRenderManager_ComputeVisiblePropBounds_06(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_ComputeVisiblePropBoundsRMI_07(HandleRef pThis, int renderId);

		public virtual void ComputeVisiblePropBoundsRMI(int renderId)
		{
			vtkParallelRenderManager.vtkParallelRenderManager_ComputeVisiblePropBoundsRMI_07(base.GetCppThis(), renderId);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_EndRender_08(HandleRef pThis);

		public virtual void EndRender()
		{
			vtkParallelRenderManager.vtkParallelRenderManager_EndRender_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_GenericEndRenderCallback_09(HandleRef pThis);

		public virtual void GenericEndRenderCallback()
		{
			vtkParallelRenderManager.vtkParallelRenderManager_GenericEndRenderCallback_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_GenericStartRenderCallback_10(HandleRef pThis);

		public virtual void GenericStartRenderCallback()
		{
			vtkParallelRenderManager.vtkParallelRenderManager_GenericStartRenderCallback_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkParallelRenderManager_GetAutoImageReductionFactor_11(HandleRef pThis);

		public virtual int GetAutoImageReductionFactor()
		{
			return vtkParallelRenderManager.vtkParallelRenderManager_GetAutoImageReductionFactor_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelRenderManager_GetController_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParallelRenderManager.vtkParallelRenderManager_GetController_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiProcessController = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiProcessController.Register(null);
				}
			}
			return vtkMultiProcessController;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern byte vtkParallelRenderManager_GetDefaultRenderEventPropagation_13();

		public static bool GetDefaultRenderEventPropagation()
		{
			return vtkParallelRenderManager.vtkParallelRenderManager_GetDefaultRenderEventPropagation_13() != 0;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkParallelRenderManager_GetForceRenderWindowSize_14(HandleRef pThis);

		public virtual int GetForceRenderWindowSize()
		{
			return vtkParallelRenderManager.vtkParallelRenderManager_GetForceRenderWindowSize_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelRenderManager_GetForcedRenderWindowSize_15(HandleRef pThis);

		public virtual int[] GetForcedRenderWindowSize()
		{
			IntPtr intPtr = vtkParallelRenderManager.vtkParallelRenderManager_GetForcedRenderWindowSize_15(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_GetForcedRenderWindowSize_16(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetForcedRenderWindowSize(ref int _arg1, ref int _arg2)
		{
			vtkParallelRenderManager.vtkParallelRenderManager_GetForcedRenderWindowSize_16(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_GetForcedRenderWindowSize_17(HandleRef pThis, IntPtr _arg);

		public virtual void GetForcedRenderWindowSize(IntPtr _arg)
		{
			vtkParallelRenderManager.vtkParallelRenderManager_GetForcedRenderWindowSize_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelRenderManager_GetFullImageSize_18(HandleRef pThis);

		public virtual int[] GetFullImageSize()
		{
			IntPtr intPtr = vtkParallelRenderManager.vtkParallelRenderManager_GetFullImageSize_18(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_GetFullImageSize_19(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetFullImageSize(ref int _arg1, ref int _arg2)
		{
			vtkParallelRenderManager.vtkParallelRenderManager_GetFullImageSize_19(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_GetFullImageSize_20(HandleRef pThis, IntPtr _arg);

		public virtual void GetFullImageSize(IntPtr _arg)
		{
			vtkParallelRenderManager.vtkParallelRenderManager_GetFullImageSize_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern double vtkParallelRenderManager_GetImageProcessingTime_21(HandleRef pThis);

		public virtual double GetImageProcessingTime()
		{
			return vtkParallelRenderManager.vtkParallelRenderManager_GetImageProcessingTime_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern double vtkParallelRenderManager_GetImageReductionFactor_22(HandleRef pThis);

		public virtual double GetImageReductionFactor()
		{
			return vtkParallelRenderManager.vtkParallelRenderManager_GetImageReductionFactor_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkParallelRenderManager_GetMagnifyImageMethod_23(HandleRef pThis);

		public virtual int GetMagnifyImageMethod()
		{
			return vtkParallelRenderManager.vtkParallelRenderManager_GetMagnifyImageMethod_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkParallelRenderManager_GetMagnifyImages_24(HandleRef pThis);

		public virtual int GetMagnifyImages()
		{
			return vtkParallelRenderManager.vtkParallelRenderManager_GetMagnifyImages_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern double vtkParallelRenderManager_GetMaxImageReductionFactor_25(HandleRef pThis);

		public virtual double GetMaxImageReductionFactor()
		{
			return vtkParallelRenderManager.vtkParallelRenderManager_GetMaxImageReductionFactor_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkParallelRenderManager_GetParallelRendering_26(HandleRef pThis);

		public virtual int GetParallelRendering()
		{
			return vtkParallelRenderManager.vtkParallelRenderManager_GetParallelRendering_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_GetPixelData_27(HandleRef pThis, HandleRef data);

		public virtual void GetPixelData(vtkUnsignedCharArray data)
		{
			vtkParallelRenderManager.vtkParallelRenderManager_GetPixelData_27(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_GetPixelData_28(HandleRef pThis, int x1, int y1, int x2, int y2, HandleRef data);

		public virtual void GetPixelData(int x1, int y1, int x2, int y2, vtkUnsignedCharArray data)
		{
			vtkParallelRenderManager.vtkParallelRenderManager_GetPixelData_28(base.GetCppThis(), x1, y1, x2, y2, (data == null) ? default(HandleRef) : data.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelRenderManager_GetReducedImageSize_29(HandleRef pThis);

		public virtual int[] GetReducedImageSize()
		{
			IntPtr intPtr = vtkParallelRenderManager.vtkParallelRenderManager_GetReducedImageSize_29(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_GetReducedImageSize_30(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetReducedImageSize(ref int _arg1, ref int _arg2)
		{
			vtkParallelRenderManager.vtkParallelRenderManager_GetReducedImageSize_30(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_GetReducedImageSize_31(HandleRef pThis, IntPtr _arg);

		public virtual void GetReducedImageSize(IntPtr _arg)
		{
			vtkParallelRenderManager.vtkParallelRenderManager_GetReducedImageSize_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_GetReducedPixelData_32(HandleRef pThis, HandleRef data);

		public virtual void GetReducedPixelData(vtkUnsignedCharArray data)
		{
			vtkParallelRenderManager.vtkParallelRenderManager_GetReducedPixelData_32(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_GetReducedPixelData_33(HandleRef pThis, int x1, int y1, int x2, int y2, HandleRef data);

		public virtual void GetReducedPixelData(int x1, int y1, int x2, int y2, vtkUnsignedCharArray data)
		{
			vtkParallelRenderManager.vtkParallelRenderManager_GetReducedPixelData_33(base.GetCppThis(), x1, y1, x2, y2, (data == null) ? default(HandleRef) : data.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkParallelRenderManager_GetRenderEventPropagation_34(HandleRef pThis);

		public virtual int GetRenderEventPropagation()
		{
			return vtkParallelRenderManager.vtkParallelRenderManager_GetRenderEventPropagation_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern double vtkParallelRenderManager_GetRenderTime_35(HandleRef pThis);

		public virtual double GetRenderTime()
		{
			return vtkParallelRenderManager.vtkParallelRenderManager_GetRenderTime_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelRenderManager_GetRenderWindow_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkRenderWindow GetRenderWindow()
		{
			vtkRenderWindow vtkRenderWindow = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParallelRenderManager.vtkParallelRenderManager_GetRenderWindow_36(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderWindow = (vtkRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderWindow.Register(null);
				}
			}
			return vtkRenderWindow;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkParallelRenderManager_GetSyncRenderWindowRenderers_37(HandleRef pThis);

		public virtual int GetSyncRenderWindowRenderers()
		{
			return vtkParallelRenderManager.vtkParallelRenderManager_GetSyncRenderWindowRenderers_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkParallelRenderManager_GetSynchronizeTileProperties_38(HandleRef pThis);

		public virtual int GetSynchronizeTileProperties()
		{
			return vtkParallelRenderManager.vtkParallelRenderManager_GetSynchronizeTileProperties_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkParallelRenderManager_GetUseBackBuffer_39(HandleRef pThis);

		public virtual int GetUseBackBuffer()
		{
			return vtkParallelRenderManager.vtkParallelRenderManager_GetUseBackBuffer_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkParallelRenderManager_GetUseCompositing_40(HandleRef pThis);

		public virtual int GetUseCompositing()
		{
			return vtkParallelRenderManager.vtkParallelRenderManager_GetUseCompositing_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkParallelRenderManager_GetUseRGBA_41(HandleRef pThis);

		public virtual int GetUseRGBA()
		{
			return vtkParallelRenderManager.vtkParallelRenderManager_GetUseRGBA_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkParallelRenderManager_GetWriteBackImages_42(HandleRef pThis);

		public virtual int GetWriteBackImages()
		{
			return vtkParallelRenderManager.vtkParallelRenderManager_GetWriteBackImages_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_InitializeOffScreen_43(HandleRef pThis);

		public virtual void InitializeOffScreen()
		{
			vtkParallelRenderManager.vtkParallelRenderManager_InitializeOffScreen_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_InitializePieces_44(HandleRef pThis);

		public virtual void InitializePieces()
		{
			vtkParallelRenderManager.vtkParallelRenderManager_InitializePieces_44(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_InitializeRMIs_45(HandleRef pThis);

		public virtual void InitializeRMIs()
		{
			vtkParallelRenderManager.vtkParallelRenderManager_InitializeRMIs_45(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkParallelRenderManager_IsA_46(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkParallelRenderManager.vtkParallelRenderManager_IsA_46(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkParallelRenderManager_IsTypeOf_47(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkParallelRenderManager.vtkParallelRenderManager_IsTypeOf_47(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_MagnifyImage_48(HandleRef pThis, HandleRef fullImage, IntPtr fullImageSize, HandleRef reducedImage, IntPtr reducedImageSize, IntPtr fullImageViewport, IntPtr reducedImageViewport);

		public virtual void MagnifyImage(vtkUnsignedCharArray fullImage, IntPtr fullImageSize, vtkUnsignedCharArray reducedImage, IntPtr reducedImageSize, IntPtr fullImageViewport, IntPtr reducedImageViewport)
		{
			vtkParallelRenderManager.vtkParallelRenderManager_MagnifyImage_48(base.GetCppThis(), (fullImage == null) ? default(HandleRef) : fullImage.GetCppThis(), fullImageSize, (reducedImage == null) ? default(HandleRef) : reducedImage.GetCppThis(), reducedImageSize, fullImageViewport, reducedImageViewport);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_MagnifyImageLinear_49(HandleRef fullImage, IntPtr fullImageSize, HandleRef reducedImage, IntPtr reducedImageSize, IntPtr fullImageViewport, IntPtr reducedImageViewport);

		public static void MagnifyImageLinear(vtkUnsignedCharArray fullImage, IntPtr fullImageSize, vtkUnsignedCharArray reducedImage, IntPtr reducedImageSize, IntPtr fullImageViewport, IntPtr reducedImageViewport)
		{
			vtkParallelRenderManager.vtkParallelRenderManager_MagnifyImageLinear_49((fullImage == null) ? default(HandleRef) : fullImage.GetCppThis(), fullImageSize, (reducedImage == null) ? default(HandleRef) : reducedImage.GetCppThis(), reducedImageSize, fullImageViewport, reducedImageViewport);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_MagnifyImageNearest_50(HandleRef fullImage, IntPtr fullImageSize, HandleRef reducedImage, IntPtr reducedImageSize, IntPtr fullImageViewport, IntPtr reducedImageViewport);

		public static void MagnifyImageNearest(vtkUnsignedCharArray fullImage, IntPtr fullImageSize, vtkUnsignedCharArray reducedImage, IntPtr reducedImageSize, IntPtr fullImageViewport, IntPtr reducedImageViewport)
		{
			vtkParallelRenderManager.vtkParallelRenderManager_MagnifyImageNearest_50((fullImage == null) ? default(HandleRef) : fullImage.GetCppThis(), fullImageSize, (reducedImage == null) ? default(HandleRef) : reducedImage.GetCppThis(), reducedImageSize, fullImageViewport, reducedImageViewport);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_MagnifyImagesOff_51(HandleRef pThis);

		public virtual void MagnifyImagesOff()
		{
			vtkParallelRenderManager.vtkParallelRenderManager_MagnifyImagesOff_51(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_MagnifyImagesOn_52(HandleRef pThis);

		public virtual void MagnifyImagesOn()
		{
			vtkParallelRenderManager.vtkParallelRenderManager_MagnifyImagesOn_52(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelRenderManager_MakeRenderWindow_53(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkRenderWindow MakeRenderWindow()
		{
			vtkRenderWindow vtkRenderWindow = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParallelRenderManager.vtkParallelRenderManager_MakeRenderWindow_53(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderWindow = (vtkRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderWindow.Register(null);
				}
			}
			return vtkRenderWindow;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelRenderManager_MakeRenderer_54(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkRenderer MakeRenderer()
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParallelRenderManager.vtkParallelRenderManager_MakeRenderer_54(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderer = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderer.Register(null);
				}
			}
			return vtkRenderer;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelRenderManager_NewInstance_55(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkParallelRenderManager NewInstance()
		{
			vtkParallelRenderManager result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParallelRenderManager.vtkParallelRenderManager_NewInstance_55(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParallelRenderManager)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_ParallelRenderingOff_56(HandleRef pThis);

		public virtual void ParallelRenderingOff()
		{
			vtkParallelRenderManager.vtkParallelRenderManager_ParallelRenderingOff_56(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_ParallelRenderingOn_57(HandleRef pThis);

		public virtual void ParallelRenderingOn()
		{
			vtkParallelRenderManager.vtkParallelRenderManager_ParallelRenderingOn_57(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_RemoveAllRenderers_58(HandleRef pThis);

		public virtual void RemoveAllRenderers()
		{
			vtkParallelRenderManager.vtkParallelRenderManager_RemoveAllRenderers_58(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_RemoveRenderer_59(HandleRef pThis, HandleRef arg0);

		public virtual void RemoveRenderer(vtkRenderer arg0)
		{
			vtkParallelRenderManager.vtkParallelRenderManager_RemoveRenderer_59(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_RenderEventPropagationOff_60(HandleRef pThis);

		public virtual void RenderEventPropagationOff()
		{
			vtkParallelRenderManager.vtkParallelRenderManager_RenderEventPropagationOff_60(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_RenderEventPropagationOn_61(HandleRef pThis);

		public virtual void RenderEventPropagationOn()
		{
			vtkParallelRenderManager.vtkParallelRenderManager_RenderEventPropagationOn_61(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_RenderRMI_62(HandleRef pThis);

		public virtual void RenderRMI()
		{
			vtkParallelRenderManager.vtkParallelRenderManager_RenderRMI_62(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_ResetAllCameras_63(HandleRef pThis);

		public virtual void ResetAllCameras()
		{
			vtkParallelRenderManager.vtkParallelRenderManager_ResetAllCameras_63(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_ResetCamera_64(HandleRef pThis, HandleRef ren);

		public virtual void ResetCamera(vtkRenderer ren)
		{
			vtkParallelRenderManager.vtkParallelRenderManager_ResetCamera_64(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_ResetCameraClippingRange_65(HandleRef pThis, HandleRef ren);

		public virtual void ResetCameraClippingRange(vtkRenderer ren)
		{
			vtkParallelRenderManager.vtkParallelRenderManager_ResetCameraClippingRange_65(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelRenderManager_SafeDownCast_66(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkParallelRenderManager SafeDownCast(vtkObjectBase o)
		{
			vtkParallelRenderManager vtkParallelRenderManager = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParallelRenderManager.vtkParallelRenderManager_SafeDownCast_66((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParallelRenderManager = (vtkParallelRenderManager)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParallelRenderManager.Register(null);
				}
			}
			return vtkParallelRenderManager;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_SatelliteEndRender_67(HandleRef pThis);

		public virtual void SatelliteEndRender()
		{
			vtkParallelRenderManager.vtkParallelRenderManager_SatelliteEndRender_67(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_SatelliteStartRender_68(HandleRef pThis);

		public virtual void SatelliteStartRender()
		{
			vtkParallelRenderManager.vtkParallelRenderManager_SatelliteStartRender_68(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_SetAutoImageReductionFactor_69(HandleRef pThis, int _arg);

		public virtual void SetAutoImageReductionFactor(int _arg)
		{
			vtkParallelRenderManager.vtkParallelRenderManager_SetAutoImageReductionFactor_69(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_SetController_70(HandleRef pThis, HandleRef controller);

		public virtual void SetController(vtkMultiProcessController controller)
		{
			vtkParallelRenderManager.vtkParallelRenderManager_SetController_70(base.GetCppThis(), (controller == null) ? default(HandleRef) : controller.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_SetDefaultRenderEventPropagation_71(byte val);

		public static void SetDefaultRenderEventPropagation(bool val)
		{
			vtkParallelRenderManager.vtkParallelRenderManager_SetDefaultRenderEventPropagation_71(val ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_SetForceRenderWindowSize_72(HandleRef pThis, int _arg);

		public virtual void SetForceRenderWindowSize(int _arg)
		{
			vtkParallelRenderManager.vtkParallelRenderManager_SetForceRenderWindowSize_72(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_SetForcedRenderWindowSize_73(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetForcedRenderWindowSize(int _arg1, int _arg2)
		{
			vtkParallelRenderManager.vtkParallelRenderManager_SetForcedRenderWindowSize_73(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_SetForcedRenderWindowSize_74(HandleRef pThis, IntPtr _arg);

		public void SetForcedRenderWindowSize(IntPtr _arg)
		{
			vtkParallelRenderManager.vtkParallelRenderManager_SetForcedRenderWindowSize_74(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_SetImageReductionFactor_75(HandleRef pThis, double factor);

		public virtual void SetImageReductionFactor(double factor)
		{
			vtkParallelRenderManager.vtkParallelRenderManager_SetImageReductionFactor_75(base.GetCppThis(), factor);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_SetImageReductionFactorForUpdateRate_76(HandleRef pThis, double DesiredUpdateRate);

		public virtual void SetImageReductionFactorForUpdateRate(double DesiredUpdateRate)
		{
			vtkParallelRenderManager.vtkParallelRenderManager_SetImageReductionFactorForUpdateRate_76(base.GetCppThis(), DesiredUpdateRate);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_SetMagnifyImageMethod_77(HandleRef pThis, int method);

		public virtual void SetMagnifyImageMethod(int method)
		{
			vtkParallelRenderManager.vtkParallelRenderManager_SetMagnifyImageMethod_77(base.GetCppThis(), method);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_SetMagnifyImageMethodToLinear_78(HandleRef pThis);

		public void SetMagnifyImageMethodToLinear()
		{
			vtkParallelRenderManager.vtkParallelRenderManager_SetMagnifyImageMethodToLinear_78(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_SetMagnifyImageMethodToNearest_79(HandleRef pThis);

		public void SetMagnifyImageMethodToNearest()
		{
			vtkParallelRenderManager.vtkParallelRenderManager_SetMagnifyImageMethodToNearest_79(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_SetMagnifyImages_80(HandleRef pThis, int _arg);

		public virtual void SetMagnifyImages(int _arg)
		{
			vtkParallelRenderManager.vtkParallelRenderManager_SetMagnifyImages_80(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_SetMaxImageReductionFactor_81(HandleRef pThis, double _arg);

		public virtual void SetMaxImageReductionFactor(double _arg)
		{
			vtkParallelRenderManager.vtkParallelRenderManager_SetMaxImageReductionFactor_81(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_SetParallelRendering_82(HandleRef pThis, int _arg);

		public virtual void SetParallelRendering(int _arg)
		{
			vtkParallelRenderManager.vtkParallelRenderManager_SetParallelRendering_82(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_SetRenderEventPropagation_83(HandleRef pThis, int _arg);

		public virtual void SetRenderEventPropagation(int _arg)
		{
			vtkParallelRenderManager.vtkParallelRenderManager_SetRenderEventPropagation_83(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_SetRenderWindow_84(HandleRef pThis, HandleRef renWin);

		public virtual void SetRenderWindow(vtkRenderWindow renWin)
		{
			vtkParallelRenderManager.vtkParallelRenderManager_SetRenderWindow_84(base.GetCppThis(), (renWin == null) ? default(HandleRef) : renWin.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_SetSyncRenderWindowRenderers_85(HandleRef pThis, int _arg);

		public virtual void SetSyncRenderWindowRenderers(int _arg)
		{
			vtkParallelRenderManager.vtkParallelRenderManager_SetSyncRenderWindowRenderers_85(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_SetSynchronizeTileProperties_86(HandleRef pThis, int _arg);

		public virtual void SetSynchronizeTileProperties(int _arg)
		{
			vtkParallelRenderManager.vtkParallelRenderManager_SetSynchronizeTileProperties_86(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_SetUseBackBuffer_87(HandleRef pThis, int _arg);

		public virtual void SetUseBackBuffer(int _arg)
		{
			vtkParallelRenderManager.vtkParallelRenderManager_SetUseBackBuffer_87(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_SetUseCompositing_88(HandleRef pThis, int _arg);

		public virtual void SetUseCompositing(int _arg)
		{
			vtkParallelRenderManager.vtkParallelRenderManager_SetUseCompositing_88(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_SetUseRGBA_89(HandleRef pThis, int _arg);

		public virtual void SetUseRGBA(int _arg)
		{
			vtkParallelRenderManager.vtkParallelRenderManager_SetUseRGBA_89(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_SetWriteBackImages_90(HandleRef pThis, int _arg);

		public virtual void SetWriteBackImages(int _arg)
		{
			vtkParallelRenderManager.vtkParallelRenderManager_SetWriteBackImages_90(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_StartInteractor_91(HandleRef pThis);

		public virtual void StartInteractor()
		{
			vtkParallelRenderManager.vtkParallelRenderManager_StartInteractor_91(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_StartRender_92(HandleRef pThis);

		public virtual void StartRender()
		{
			vtkParallelRenderManager.vtkParallelRenderManager_StartRender_92(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_StartServices_93(HandleRef pThis);

		public virtual void StartServices()
		{
			vtkParallelRenderManager.vtkParallelRenderManager_StartServices_93(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_StopServices_94(HandleRef pThis);

		public virtual void StopServices()
		{
			vtkParallelRenderManager.vtkParallelRenderManager_StopServices_94(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_SyncRenderWindowRenderersOff_95(HandleRef pThis);

		public virtual void SyncRenderWindowRenderersOff()
		{
			vtkParallelRenderManager.vtkParallelRenderManager_SyncRenderWindowRenderersOff_95(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_SyncRenderWindowRenderersOn_96(HandleRef pThis);

		public virtual void SyncRenderWindowRenderersOn()
		{
			vtkParallelRenderManager.vtkParallelRenderManager_SyncRenderWindowRenderersOn_96(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_SynchronizeTilePropertiesOff_97(HandleRef pThis);

		public virtual void SynchronizeTilePropertiesOff()
		{
			vtkParallelRenderManager.vtkParallelRenderManager_SynchronizeTilePropertiesOff_97(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_SynchronizeTilePropertiesOn_98(HandleRef pThis);

		public virtual void SynchronizeTilePropertiesOn()
		{
			vtkParallelRenderManager.vtkParallelRenderManager_SynchronizeTilePropertiesOn_98(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_TileWindows_99(HandleRef pThis, int xsize, int ysize, int nColumns);

		public void TileWindows(int xsize, int ysize, int nColumns)
		{
			vtkParallelRenderManager.vtkParallelRenderManager_TileWindows_99(base.GetCppThis(), xsize, ysize, nColumns);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_UseBackBufferOff_100(HandleRef pThis);

		public virtual void UseBackBufferOff()
		{
			vtkParallelRenderManager.vtkParallelRenderManager_UseBackBufferOff_100(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_UseBackBufferOn_101(HandleRef pThis);

		public virtual void UseBackBufferOn()
		{
			vtkParallelRenderManager.vtkParallelRenderManager_UseBackBufferOn_101(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_UseCompositingOff_102(HandleRef pThis);

		public virtual void UseCompositingOff()
		{
			vtkParallelRenderManager.vtkParallelRenderManager_UseCompositingOff_102(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_UseCompositingOn_103(HandleRef pThis);

		public virtual void UseCompositingOn()
		{
			vtkParallelRenderManager.vtkParallelRenderManager_UseCompositingOn_103(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_WriteBackImagesOff_104(HandleRef pThis);

		public virtual void WriteBackImagesOff()
		{
			vtkParallelRenderManager.vtkParallelRenderManager_WriteBackImagesOff_104(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkParallelRenderManager_WriteBackImagesOn_105(HandleRef pThis);

		public virtual void WriteBackImagesOn()
		{
			vtkParallelRenderManager.vtkParallelRenderManager_WriteBackImagesOn_105(base.GetCppThis());
		}
	}
}
