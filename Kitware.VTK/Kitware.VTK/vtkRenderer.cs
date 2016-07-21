using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkRenderer : vtkViewport
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkRenderer";

		public new static readonly string MRClassNameKey;

		static vtkRenderer()
		{
			vtkRenderer.MRClassNameKey = "class vtkRenderer";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRenderer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRenderer"));
		}

		public vtkRenderer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRenderer New()
		{
			vtkRenderer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderer.vtkRenderer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkRenderer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkRenderer.vtkRenderer_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_AddActor_01(HandleRef pThis, HandleRef p);

		public void AddActor(vtkProp p)
		{
			vtkRenderer.vtkRenderer_AddActor_01(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_AddCuller_02(HandleRef pThis, HandleRef arg0);

		public void AddCuller(vtkCuller arg0)
		{
			vtkRenderer.vtkRenderer_AddCuller_02(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_AddLight_03(HandleRef pThis, HandleRef arg0);

		public void AddLight(vtkLight arg0)
		{
			vtkRenderer.vtkRenderer_AddLight_03(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_AddVolume_04(HandleRef pThis, HandleRef p);

		public void AddVolume(vtkProp p)
		{
			vtkRenderer.vtkRenderer_AddVolume_04(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_AutomaticLightCreationOff_05(HandleRef pThis);

		public virtual void AutomaticLightCreationOff()
		{
			vtkRenderer.vtkRenderer_AutomaticLightCreationOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_AutomaticLightCreationOn_06(HandleRef pThis);

		public virtual void AutomaticLightCreationOn()
		{
			vtkRenderer.vtkRenderer_AutomaticLightCreationOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_BackingStoreOff_07(HandleRef pThis);

		public virtual void BackingStoreOff()
		{
			vtkRenderer.vtkRenderer_BackingStoreOff_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_BackingStoreOn_08(HandleRef pThis);

		public virtual void BackingStoreOn()
		{
			vtkRenderer.vtkRenderer_BackingStoreOn_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_Clear_09(HandleRef pThis);

		public virtual void Clear()
		{
			vtkRenderer.vtkRenderer_Clear_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_ComputeVisiblePropBounds_10(HandleRef pThis, IntPtr bounds);

		public void ComputeVisiblePropBounds(IntPtr bounds)
		{
			vtkRenderer.vtkRenderer_ComputeVisiblePropBounds_10(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderer_ComputeVisiblePropBounds_11(HandleRef pThis);

		public double[] ComputeVisiblePropBounds()
		{
			IntPtr intPtr = vtkRenderer.vtkRenderer_ComputeVisiblePropBounds_11(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_CreateLight_12(HandleRef pThis);

		public void CreateLight()
		{
			vtkRenderer.vtkRenderer_CreateLight_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_DeviceRender_13(HandleRef pThis);

		public virtual void DeviceRender()
		{
			vtkRenderer.vtkRenderer_DeviceRender_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_DeviceRenderTranslucentPolygonalGeometry_14(HandleRef pThis);

		public virtual void DeviceRenderTranslucentPolygonalGeometry()
		{
			vtkRenderer.vtkRenderer_DeviceRenderTranslucentPolygonalGeometry_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_DrawOff_15(HandleRef pThis);

		public virtual void DrawOff()
		{
			vtkRenderer.vtkRenderer_DrawOff_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_DrawOn_16(HandleRef pThis);

		public virtual void DrawOn()
		{
			vtkRenderer.vtkRenderer_DrawOn_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_EraseOff_17(HandleRef pThis);

		public virtual void EraseOff()
		{
			vtkRenderer.vtkRenderer_EraseOff_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_EraseOn_18(HandleRef pThis);

		public virtual void EraseOn()
		{
			vtkRenderer.vtkRenderer_EraseOn_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderer_GetActiveCamera_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkCamera GetActiveCamera()
		{
			vtkCamera vtkCamera = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderer.vtkRenderer_GetActiveCamera_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCamera = (vtkCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCamera.Register(null);
				}
			}
			return vtkCamera;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderer_GetActors_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkActorCollection GetActors()
		{
			vtkActorCollection vtkActorCollection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderer.vtkRenderer_GetActors_20(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkActorCollection = (vtkActorCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkActorCollection.Register(null);
				}
			}
			return vtkActorCollection;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkRenderer_GetAllocatedRenderTime_21(HandleRef pThis);

		public virtual double GetAllocatedRenderTime()
		{
			return vtkRenderer.vtkRenderer_GetAllocatedRenderTime_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderer_GetAmbient_22(HandleRef pThis);

		public virtual double[] GetAmbient()
		{
			IntPtr intPtr = vtkRenderer.vtkRenderer_GetAmbient_22(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_GetAmbient_23(HandleRef pThis, IntPtr data);

		public virtual void GetAmbient(IntPtr data)
		{
			vtkRenderer.vtkRenderer_GetAmbient_23(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderer_GetAutomaticLightCreation_24(HandleRef pThis);

		public virtual int GetAutomaticLightCreation()
		{
			return vtkRenderer.vtkRenderer_GetAutomaticLightCreation_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderer_GetBackgroundTexture_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTexture GetBackgroundTexture()
		{
			vtkTexture vtkTexture = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderer.vtkRenderer_GetBackgroundTexture_25(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTexture = (vtkTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTexture.Register(null);
				}
			}
			return vtkTexture;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderer_GetBackingStore_26(HandleRef pThis);

		public virtual int GetBackingStore()
		{
			return vtkRenderer.vtkRenderer_GetBackingStore_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderer_GetCullers_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkCullerCollection GetCullers()
		{
			vtkCullerCollection vtkCullerCollection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderer.vtkRenderer_GetCullers_27(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCullerCollection = (vtkCullerCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCullerCollection.Register(null);
				}
			}
			return vtkCullerCollection;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderer_GetDelegate_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkRendererDelegate GetDelegate()
		{
			vtkRendererDelegate vtkRendererDelegate = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderer.vtkRenderer_GetDelegate_28(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRendererDelegate = (vtkRendererDelegate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRendererDelegate.Register(null);
				}
			}
			return vtkRendererDelegate;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderer_GetDraw_29(HandleRef pThis);

		public virtual int GetDraw()
		{
			return vtkRenderer.vtkRenderer_GetDraw_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderer_GetErase_30(HandleRef pThis);

		public virtual int GetErase()
		{
			return vtkRenderer.vtkRenderer_GetErase_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderer_GetInteractive_31(HandleRef pThis);

		public virtual int GetInteractive()
		{
			return vtkRenderer.vtkRenderer_GetInteractive_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkRenderer_GetLastRenderTimeInSeconds_32(HandleRef pThis);

		public virtual double GetLastRenderTimeInSeconds()
		{
			return vtkRenderer.vtkRenderer_GetLastRenderTimeInSeconds_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderer_GetLastRenderingUsedDepthPeeling_33(HandleRef pThis);

		public virtual int GetLastRenderingUsedDepthPeeling()
		{
			return vtkRenderer.vtkRenderer_GetLastRenderingUsedDepthPeeling_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderer_GetLayer_34(HandleRef pThis);

		public virtual int GetLayer()
		{
			return vtkRenderer.vtkRenderer_GetLayer_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderer_GetLightFollowCamera_35(HandleRef pThis);

		public virtual int GetLightFollowCamera()
		{
			return vtkRenderer.vtkRenderer_GetLightFollowCamera_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderer_GetLights_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkLightCollection GetLights()
		{
			vtkLightCollection vtkLightCollection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderer.vtkRenderer_GetLights_36(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLightCollection = (vtkLightCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLightCollection.Register(null);
				}
			}
			return vtkLightCollection;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkRenderer_GetMTime_37(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkRenderer.vtkRenderer_GetMTime_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderer_GetMaximumNumberOfPeels_38(HandleRef pThis);

		public virtual int GetMaximumNumberOfPeels()
		{
			return vtkRenderer.vtkRenderer_GetMaximumNumberOfPeels_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkRenderer_GetNearClippingPlaneTolerance_39(HandleRef pThis);

		public virtual double GetNearClippingPlaneTolerance()
		{
			return vtkRenderer.vtkRenderer_GetNearClippingPlaneTolerance_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkRenderer_GetNearClippingPlaneToleranceMaxValue_40(HandleRef pThis);

		public virtual double GetNearClippingPlaneToleranceMaxValue()
		{
			return vtkRenderer.vtkRenderer_GetNearClippingPlaneToleranceMaxValue_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkRenderer_GetNearClippingPlaneToleranceMinValue_41(HandleRef pThis);

		public virtual double GetNearClippingPlaneToleranceMinValue()
		{
			return vtkRenderer.vtkRenderer_GetNearClippingPlaneToleranceMinValue_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderer_GetNumberOfPropsRendered_42(HandleRef pThis);

		public virtual int GetNumberOfPropsRendered()
		{
			return vtkRenderer.vtkRenderer_GetNumberOfPropsRendered_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkRenderer_GetOcclusionRatio_43(HandleRef pThis);

		public virtual double GetOcclusionRatio()
		{
			return vtkRenderer.vtkRenderer_GetOcclusionRatio_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkRenderer_GetOcclusionRatioMaxValue_44(HandleRef pThis);

		public virtual double GetOcclusionRatioMaxValue()
		{
			return vtkRenderer.vtkRenderer_GetOcclusionRatioMaxValue_44(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkRenderer_GetOcclusionRatioMinValue_45(HandleRef pThis);

		public virtual double GetOcclusionRatioMinValue()
		{
			return vtkRenderer.vtkRenderer_GetOcclusionRatioMinValue_45(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderer_GetPass_46(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkRenderPass GetPass()
		{
			vtkRenderPass vtkRenderPass = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderer.vtkRenderer_GetPass_46(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderPass = (vtkRenderPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderPass.Register(null);
				}
			}
			return vtkRenderPass;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderer_GetPreserveDepthBuffer_47(HandleRef pThis);

		public virtual int GetPreserveDepthBuffer()
		{
			return vtkRenderer.vtkRenderer_GetPreserveDepthBuffer_47(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderer_GetRenderWindow_48(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkRenderWindow GetRenderWindow()
		{
			vtkRenderWindow vtkRenderWindow = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderer.vtkRenderer_GetRenderWindow_48(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderer_GetSelector_49(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkHardwareSelector GetSelector()
		{
			vtkHardwareSelector vtkHardwareSelector = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderer.vtkRenderer_GetSelector_49(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHardwareSelector = (vtkHardwareSelector)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHardwareSelector.Register(null);
				}
			}
			return vtkHardwareSelector;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkRenderer_GetTexturedBackground_50(HandleRef pThis);

		public virtual bool GetTexturedBackground()
		{
			return vtkRenderer.vtkRenderer_GetTexturedBackground_50(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkRenderer_GetTiledAspectRatio_51(HandleRef pThis);

		public double GetTiledAspectRatio()
		{
			return vtkRenderer.vtkRenderer_GetTiledAspectRatio_51(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkRenderer_GetTimeFactor_52(HandleRef pThis);

		public virtual double GetTimeFactor()
		{
			return vtkRenderer.vtkRenderer_GetTimeFactor_52(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderer_GetTwoSidedLighting_53(HandleRef pThis);

		public virtual int GetTwoSidedLighting()
		{
			return vtkRenderer.vtkRenderer_GetTwoSidedLighting_53(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderer_GetUseDepthPeeling_54(HandleRef pThis);

		public virtual int GetUseDepthPeeling()
		{
			return vtkRenderer.vtkRenderer_GetUseDepthPeeling_54(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderer_GetVTKWindow_55(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkWindow GetVTKWindow()
		{
			vtkWindow vtkWindow = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderer.vtkRenderer_GetVTKWindow_55(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWindow = (vtkWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWindow.Register(null);
				}
			}
			return vtkWindow;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderer_GetVolumes_56(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkVolumeCollection GetVolumes()
		{
			vtkVolumeCollection vtkVolumeCollection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderer.vtkRenderer_GetVolumes_56(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolumeCollection = (vtkVolumeCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolumeCollection.Register(null);
				}
			}
			return vtkVolumeCollection;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkRenderer_GetZ_57(HandleRef pThis, int x, int y);

		public double GetZ(int x, int y)
		{
			return vtkRenderer.vtkRenderer_GetZ_57(base.GetCppThis(), x, y);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_InteractiveOff_58(HandleRef pThis);

		public virtual void InteractiveOff()
		{
			vtkRenderer.vtkRenderer_InteractiveOff_58(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_InteractiveOn_59(HandleRef pThis);

		public virtual void InteractiveOn()
		{
			vtkRenderer.vtkRenderer_InteractiveOn_59(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderer_IsA_60(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkRenderer.vtkRenderer_IsA_60(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderer_IsActiveCameraCreated_61(HandleRef pThis);

		public int IsActiveCameraCreated()
		{
			return vtkRenderer.vtkRenderer_IsActiveCameraCreated_61(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderer_IsTypeOf_62(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkRenderer.vtkRenderer_IsTypeOf_62(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_LightFollowCameraOff_63(HandleRef pThis);

		public virtual void LightFollowCameraOff()
		{
			vtkRenderer.vtkRenderer_LightFollowCameraOff_63(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_LightFollowCameraOn_64(HandleRef pThis);

		public virtual void LightFollowCameraOn()
		{
			vtkRenderer.vtkRenderer_LightFollowCameraOn_64(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderer_MakeCamera_65(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCamera MakeCamera()
		{
			vtkCamera vtkCamera = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderer.vtkRenderer_MakeCamera_65(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCamera = (vtkCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCamera.Register(null);
				}
			}
			return vtkCamera;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderer_MakeLight_66(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkLight MakeLight()
		{
			vtkLight vtkLight = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderer.vtkRenderer_MakeLight_66(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLight = (vtkLight)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLight.Register(null);
				}
			}
			return vtkLight;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderer_NewInstance_68(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRenderer NewInstance()
		{
			vtkRenderer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderer.vtkRenderer_NewInstance_68(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderer_PickProp_69(HandleRef pThis, double selectionX, double selectionY, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkAssemblyPath PickProp(double selectionX, double selectionY)
		{
			vtkAssemblyPath vtkAssemblyPath = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderer.vtkRenderer_PickProp_69(base.GetCppThis(), selectionX, selectionY, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAssemblyPath = (vtkAssemblyPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAssemblyPath.Register(null);
				}
			}
			return vtkAssemblyPath;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderer_PickProp_70(HandleRef pThis, double selectionX1, double selectionY1, double selectionX2, double selectionY2, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkAssemblyPath PickProp(double selectionX1, double selectionY1, double selectionX2, double selectionY2)
		{
			vtkAssemblyPath vtkAssemblyPath = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderer.vtkRenderer_PickProp_70(base.GetCppThis(), selectionX1, selectionY1, selectionX2, selectionY2, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAssemblyPath = (vtkAssemblyPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAssemblyPath.Register(null);
				}
			}
			return vtkAssemblyPath;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_PreserveDepthBufferOff_71(HandleRef pThis);

		public virtual void PreserveDepthBufferOff()
		{
			vtkRenderer.vtkRenderer_PreserveDepthBufferOff_71(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_PreserveDepthBufferOn_72(HandleRef pThis);

		public virtual void PreserveDepthBufferOn()
		{
			vtkRenderer.vtkRenderer_PreserveDepthBufferOn_72(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_RemoveActor_73(HandleRef pThis, HandleRef p);

		public void RemoveActor(vtkProp p)
		{
			vtkRenderer.vtkRenderer_RemoveActor_73(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_RemoveAllLights_74(HandleRef pThis);

		public void RemoveAllLights()
		{
			vtkRenderer.vtkRenderer_RemoveAllLights_74(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_RemoveCuller_75(HandleRef pThis, HandleRef arg0);

		public void RemoveCuller(vtkCuller arg0)
		{
			vtkRenderer.vtkRenderer_RemoveCuller_75(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_RemoveLight_76(HandleRef pThis, HandleRef arg0);

		public void RemoveLight(vtkLight arg0)
		{
			vtkRenderer.vtkRenderer_RemoveLight_76(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_RemoveVolume_77(HandleRef pThis, HandleRef p);

		public void RemoveVolume(vtkProp p)
		{
			vtkRenderer.vtkRenderer_RemoveVolume_77(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_Render_78(HandleRef pThis);

		public virtual void Render()
		{
			vtkRenderer.vtkRenderer_Render_78(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_ResetCamera_79(HandleRef pThis);

		public void ResetCamera()
		{
			vtkRenderer.vtkRenderer_ResetCamera_79(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_ResetCamera_80(HandleRef pThis, IntPtr bounds);

		public void ResetCamera(IntPtr bounds)
		{
			vtkRenderer.vtkRenderer_ResetCamera_80(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_ResetCamera_81(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

		public void ResetCamera(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
		{
			vtkRenderer.vtkRenderer_ResetCamera_81(base.GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_ResetCameraClippingRange_82(HandleRef pThis);

		public void ResetCameraClippingRange()
		{
			vtkRenderer.vtkRenderer_ResetCameraClippingRange_82(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_ResetCameraClippingRange_83(HandleRef pThis, IntPtr bounds);

		public void ResetCameraClippingRange(IntPtr bounds)
		{
			vtkRenderer.vtkRenderer_ResetCameraClippingRange_83(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_ResetCameraClippingRange_84(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

		public void ResetCameraClippingRange(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
		{
			vtkRenderer.vtkRenderer_ResetCameraClippingRange_84(base.GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderer_SafeDownCast_85(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRenderer SafeDownCast(vtkObjectBase o)
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderer.vtkRenderer_SafeDownCast_85((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_SetActiveCamera_86(HandleRef pThis, HandleRef arg0);

		public void SetActiveCamera(vtkCamera arg0)
		{
			vtkRenderer.vtkRenderer_SetActiveCamera_86(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_SetAllocatedRenderTime_87(HandleRef pThis, double _arg);

		public virtual void SetAllocatedRenderTime(double _arg)
		{
			vtkRenderer.vtkRenderer_SetAllocatedRenderTime_87(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_SetAmbient_88(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetAmbient(double _arg1, double _arg2, double _arg3)
		{
			vtkRenderer.vtkRenderer_SetAmbient_88(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_SetAmbient_89(HandleRef pThis, IntPtr _arg);

		public virtual void SetAmbient(IntPtr _arg)
		{
			vtkRenderer.vtkRenderer_SetAmbient_89(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_SetAutomaticLightCreation_90(HandleRef pThis, int _arg);

		public virtual void SetAutomaticLightCreation(int _arg)
		{
			vtkRenderer.vtkRenderer_SetAutomaticLightCreation_90(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_SetBackgroundTexture_91(HandleRef pThis, HandleRef arg0);

		public void SetBackgroundTexture(vtkTexture arg0)
		{
			vtkRenderer.vtkRenderer_SetBackgroundTexture_91(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_SetBackingStore_92(HandleRef pThis, int _arg);

		public virtual void SetBackingStore(int _arg)
		{
			vtkRenderer.vtkRenderer_SetBackingStore_92(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_SetDelegate_93(HandleRef pThis, HandleRef d);

		public void SetDelegate(vtkRendererDelegate d)
		{
			vtkRenderer.vtkRenderer_SetDelegate_93(base.GetCppThis(), (d == null) ? default(HandleRef) : d.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_SetDraw_94(HandleRef pThis, int _arg);

		public virtual void SetDraw(int _arg)
		{
			vtkRenderer.vtkRenderer_SetDraw_94(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_SetErase_95(HandleRef pThis, int _arg);

		public virtual void SetErase(int _arg)
		{
			vtkRenderer.vtkRenderer_SetErase_95(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_SetInteractive_96(HandleRef pThis, int _arg);

		public virtual void SetInteractive(int _arg)
		{
			vtkRenderer.vtkRenderer_SetInteractive_96(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_SetLayer_97(HandleRef pThis, int _arg);

		public virtual void SetLayer(int _arg)
		{
			vtkRenderer.vtkRenderer_SetLayer_97(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_SetLightCollection_98(HandleRef pThis, HandleRef lights);

		public void SetLightCollection(vtkLightCollection lights)
		{
			vtkRenderer.vtkRenderer_SetLightCollection_98(base.GetCppThis(), (lights == null) ? default(HandleRef) : lights.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_SetLightFollowCamera_99(HandleRef pThis, int _arg);

		public virtual void SetLightFollowCamera(int _arg)
		{
			vtkRenderer.vtkRenderer_SetLightFollowCamera_99(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_SetMaximumNumberOfPeels_100(HandleRef pThis, int _arg);

		public virtual void SetMaximumNumberOfPeels(int _arg)
		{
			vtkRenderer.vtkRenderer_SetMaximumNumberOfPeels_100(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_SetNearClippingPlaneTolerance_101(HandleRef pThis, double _arg);

		public virtual void SetNearClippingPlaneTolerance(double _arg)
		{
			vtkRenderer.vtkRenderer_SetNearClippingPlaneTolerance_101(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_SetOcclusionRatio_102(HandleRef pThis, double _arg);

		public virtual void SetOcclusionRatio(double _arg)
		{
			vtkRenderer.vtkRenderer_SetOcclusionRatio_102(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_SetPass_103(HandleRef pThis, HandleRef p);

		public void SetPass(vtkRenderPass p)
		{
			vtkRenderer.vtkRenderer_SetPass_103(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_SetPreserveDepthBuffer_104(HandleRef pThis, int _arg);

		public virtual void SetPreserveDepthBuffer(int _arg)
		{
			vtkRenderer.vtkRenderer_SetPreserveDepthBuffer_104(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_SetRenderWindow_105(HandleRef pThis, HandleRef arg0);

		public void SetRenderWindow(vtkRenderWindow arg0)
		{
			vtkRenderer.vtkRenderer_SetRenderWindow_105(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_SetTexturedBackground_106(HandleRef pThis, byte _arg);

		public virtual void SetTexturedBackground(bool _arg)
		{
			vtkRenderer.vtkRenderer_SetTexturedBackground_106(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_SetTwoSidedLighting_107(HandleRef pThis, int _arg);

		public virtual void SetTwoSidedLighting(int _arg)
		{
			vtkRenderer.vtkRenderer_SetTwoSidedLighting_107(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_SetUseDepthPeeling_108(HandleRef pThis, int _arg);

		public virtual void SetUseDepthPeeling(int _arg)
		{
			vtkRenderer.vtkRenderer_SetUseDepthPeeling_108(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_StereoMidpoint_109(HandleRef pThis);

		public virtual void StereoMidpoint()
		{
			vtkRenderer.vtkRenderer_StereoMidpoint_109(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_TexturedBackgroundOff_110(HandleRef pThis);

		public virtual void TexturedBackgroundOff()
		{
			vtkRenderer.vtkRenderer_TexturedBackgroundOff_110(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_TexturedBackgroundOn_111(HandleRef pThis);

		public virtual void TexturedBackgroundOn()
		{
			vtkRenderer.vtkRenderer_TexturedBackgroundOn_111(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderer_Transparent_112(HandleRef pThis);

		public int Transparent()
		{
			return vtkRenderer.vtkRenderer_Transparent_112(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_TwoSidedLightingOff_113(HandleRef pThis);

		public virtual void TwoSidedLightingOff()
		{
			vtkRenderer.vtkRenderer_TwoSidedLightingOff_113(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_TwoSidedLightingOn_114(HandleRef pThis);

		public virtual void TwoSidedLightingOn()
		{
			vtkRenderer.vtkRenderer_TwoSidedLightingOn_114(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderer_UpdateLightsGeometryToFollowCamera_115(HandleRef pThis);

		public virtual int UpdateLightsGeometryToFollowCamera()
		{
			return vtkRenderer.vtkRenderer_UpdateLightsGeometryToFollowCamera_115(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_UseDepthPeelingOff_116(HandleRef pThis);

		public virtual void UseDepthPeelingOff()
		{
			vtkRenderer.vtkRenderer_UseDepthPeelingOff_116(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_UseDepthPeelingOn_117(HandleRef pThis);

		public virtual void UseDepthPeelingOn()
		{
			vtkRenderer.vtkRenderer_UseDepthPeelingOn_117(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_ViewToWorld_118(HandleRef pThis);

		public override void ViewToWorld()
		{
			vtkRenderer.vtkRenderer_ViewToWorld_118(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_ViewToWorld_119(HandleRef pThis, ref double wx, ref double wy, ref double wz);

		public override void ViewToWorld(ref double wx, ref double wy, ref double wz)
		{
			vtkRenderer.vtkRenderer_ViewToWorld_119(base.GetCppThis(), ref wx, ref wy, ref wz);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderer_VisibleActorCount_120(HandleRef pThis);

		public int VisibleActorCount()
		{
			return vtkRenderer.vtkRenderer_VisibleActorCount_120(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderer_VisibleVolumeCount_121(HandleRef pThis);

		public int VisibleVolumeCount()
		{
			return vtkRenderer.vtkRenderer_VisibleVolumeCount_121(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_WorldToView_122(HandleRef pThis);

		public override void WorldToView()
		{
			vtkRenderer.vtkRenderer_WorldToView_122(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderer_WorldToView_123(HandleRef pThis, ref double wx, ref double wy, ref double wz);

		public override void WorldToView(ref double wx, ref double wy, ref double wz)
		{
			vtkRenderer.vtkRenderer_WorldToView_123(base.GetCppThis(), ref wx, ref wy, ref wz);
		}
	}
}
