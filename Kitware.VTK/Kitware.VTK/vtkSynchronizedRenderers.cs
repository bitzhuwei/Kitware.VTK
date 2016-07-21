using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSynchronizedRenderers : vtkObject
	{
		public enum COMPUTE_BOUNDS_TAG_WrapperEnum
		{
			COMPUTE_BOUNDS_TAG = 15103,
			RESET_CAMERA_TAG = 15102,
			SYNC_RENDERER_TAG = 15101
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkSynchronizedRenderers";

		public new static readonly string MRClassNameKey;

		static vtkSynchronizedRenderers()
		{
			vtkSynchronizedRenderers.MRClassNameKey = "class vtkSynchronizedRenderers";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSynchronizedRenderers.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSynchronizedRenderers"));
		}

		public vtkSynchronizedRenderers(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkSynchronizedRenderers_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSynchronizedRenderers New()
		{
			vtkSynchronizedRenderers result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSynchronizedRenderers.vtkSynchronizedRenderers_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSynchronizedRenderers)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSynchronizedRenderers() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSynchronizedRenderers.vtkSynchronizedRenderers_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkSynchronizedRenderers_AutomaticEventHandlingOff_01(HandleRef pThis);

		public virtual void AutomaticEventHandlingOff()
		{
			vtkSynchronizedRenderers.vtkSynchronizedRenderers_AutomaticEventHandlingOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkSynchronizedRenderers_AutomaticEventHandlingOn_02(HandleRef pThis);

		public virtual void AutomaticEventHandlingOn()
		{
			vtkSynchronizedRenderers.vtkSynchronizedRenderers_AutomaticEventHandlingOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkSynchronizedRenderers_CollectiveExpandForVisiblePropBounds_03(HandleRef pThis, IntPtr bounds);

		public void CollectiveExpandForVisiblePropBounds(IntPtr bounds)
		{
			vtkSynchronizedRenderers.vtkSynchronizedRenderers_CollectiveExpandForVisiblePropBounds_03(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern byte vtkSynchronizedRenderers_GetAutomaticEventHandling_04(HandleRef pThis);

		public virtual bool GetAutomaticEventHandling()
		{
			return vtkSynchronizedRenderers.vtkSynchronizedRenderers_GetAutomaticEventHandling_04(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkSynchronizedRenderers_GetCaptureDelegate_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkSynchronizedRenderers GetCaptureDelegate()
		{
			vtkSynchronizedRenderers vtkSynchronizedRenderers = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSynchronizedRenderers.vtkSynchronizedRenderers_GetCaptureDelegate_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSynchronizedRenderers = (vtkSynchronizedRenderers)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSynchronizedRenderers.Register(null);
				}
			}
			return vtkSynchronizedRenderers;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSynchronizedRenderers_GetImageReductionFactor_06(HandleRef pThis);

		public virtual int GetImageReductionFactor()
		{
			return vtkSynchronizedRenderers.vtkSynchronizedRenderers_GetImageReductionFactor_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSynchronizedRenderers_GetImageReductionFactorMaxValue_07(HandleRef pThis);

		public virtual int GetImageReductionFactorMaxValue()
		{
			return vtkSynchronizedRenderers.vtkSynchronizedRenderers_GetImageReductionFactorMaxValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSynchronizedRenderers_GetImageReductionFactorMinValue_08(HandleRef pThis);

		public virtual int GetImageReductionFactorMinValue()
		{
			return vtkSynchronizedRenderers.vtkSynchronizedRenderers_GetImageReductionFactorMinValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkSynchronizedRenderers_GetParallelController_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMultiProcessController GetParallelController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSynchronizedRenderers.vtkSynchronizedRenderers_GetParallelController_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern byte vtkSynchronizedRenderers_GetParallelRendering_10(HandleRef pThis);

		public virtual bool GetParallelRendering()
		{
			return vtkSynchronizedRenderers.vtkSynchronizedRenderers_GetParallelRendering_10(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkSynchronizedRenderers_GetRenderer_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkRenderer GetRenderer()
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSynchronizedRenderers.vtkSynchronizedRenderers_GetRenderer_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkSynchronizedRenderers_GetRootProcessId_12(HandleRef pThis);

		public virtual int GetRootProcessId()
		{
			return vtkSynchronizedRenderers.vtkSynchronizedRenderers_GetRootProcessId_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern byte vtkSynchronizedRenderers_GetWriteBackImages_13(HandleRef pThis);

		public virtual bool GetWriteBackImages()
		{
			return vtkSynchronizedRenderers.vtkSynchronizedRenderers_GetWriteBackImages_13(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSynchronizedRenderers_IsA_14(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSynchronizedRenderers.vtkSynchronizedRenderers_IsA_14(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkSynchronizedRenderers_IsTypeOf_15(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSynchronizedRenderers.vtkSynchronizedRenderers_IsTypeOf_15(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkSynchronizedRenderers_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSynchronizedRenderers NewInstance()
		{
			vtkSynchronizedRenderers result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSynchronizedRenderers.vtkSynchronizedRenderers_NewInstance_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSynchronizedRenderers)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkSynchronizedRenderers_ParallelRenderingOff_18(HandleRef pThis);

		public virtual void ParallelRenderingOff()
		{
			vtkSynchronizedRenderers.vtkSynchronizedRenderers_ParallelRenderingOff_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkSynchronizedRenderers_ParallelRenderingOn_19(HandleRef pThis);

		public virtual void ParallelRenderingOn()
		{
			vtkSynchronizedRenderers.vtkSynchronizedRenderers_ParallelRenderingOn_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkSynchronizedRenderers_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSynchronizedRenderers SafeDownCast(vtkObjectBase o)
		{
			vtkSynchronizedRenderers vtkSynchronizedRenderers = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSynchronizedRenderers.vtkSynchronizedRenderers_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSynchronizedRenderers = (vtkSynchronizedRenderers)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSynchronizedRenderers.Register(null);
				}
			}
			return vtkSynchronizedRenderers;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkSynchronizedRenderers_SetAutomaticEventHandling_21(HandleRef pThis, byte _arg);

		public virtual void SetAutomaticEventHandling(bool _arg)
		{
			vtkSynchronizedRenderers.vtkSynchronizedRenderers_SetAutomaticEventHandling_21(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkSynchronizedRenderers_SetCaptureDelegate_22(HandleRef pThis, HandleRef arg0);

		public virtual void SetCaptureDelegate(vtkSynchronizedRenderers arg0)
		{
			vtkSynchronizedRenderers.vtkSynchronizedRenderers_SetCaptureDelegate_22(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkSynchronizedRenderers_SetImageReductionFactor_23(HandleRef pThis, int _arg);

		public virtual void SetImageReductionFactor(int _arg)
		{
			vtkSynchronizedRenderers.vtkSynchronizedRenderers_SetImageReductionFactor_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkSynchronizedRenderers_SetParallelController_24(HandleRef pThis, HandleRef arg0);

		public virtual void SetParallelController(vtkMultiProcessController arg0)
		{
			vtkSynchronizedRenderers.vtkSynchronizedRenderers_SetParallelController_24(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkSynchronizedRenderers_SetParallelRendering_25(HandleRef pThis, byte _arg);

		public virtual void SetParallelRendering(bool _arg)
		{
			vtkSynchronizedRenderers.vtkSynchronizedRenderers_SetParallelRendering_25(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkSynchronizedRenderers_SetRenderer_26(HandleRef pThis, HandleRef arg0);

		public virtual void SetRenderer(vtkRenderer arg0)
		{
			vtkSynchronizedRenderers.vtkSynchronizedRenderers_SetRenderer_26(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkSynchronizedRenderers_SetRootProcessId_27(HandleRef pThis, int _arg);

		public virtual void SetRootProcessId(int _arg)
		{
			vtkSynchronizedRenderers.vtkSynchronizedRenderers_SetRootProcessId_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkSynchronizedRenderers_SetWriteBackImages_28(HandleRef pThis, byte _arg);

		public virtual void SetWriteBackImages(bool _arg)
		{
			vtkSynchronizedRenderers.vtkSynchronizedRenderers_SetWriteBackImages_28(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkSynchronizedRenderers_WriteBackImagesOff_29(HandleRef pThis);

		public virtual void WriteBackImagesOff()
		{
			vtkSynchronizedRenderers.vtkSynchronizedRenderers_WriteBackImagesOff_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkSynchronizedRenderers_WriteBackImagesOn_30(HandleRef pThis);

		public virtual void WriteBackImagesOn()
		{
			vtkSynchronizedRenderers.vtkSynchronizedRenderers_WriteBackImagesOn_30(base.GetCppThis());
		}
	}
}
