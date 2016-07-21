using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkRenderWindow : vtkWindow
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkRenderWindow";

		public new static readonly string MRClassNameKey;

		static vtkRenderWindow()
		{
			vtkRenderWindow.MRClassNameKey = "class vtkRenderWindow";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRenderWindow.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRenderWindow"));
		}

		public vtkRenderWindow(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderWindow_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRenderWindow New()
		{
			vtkRenderWindow result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderWindow.vtkRenderWindow_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkRenderWindow() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkRenderWindow.vtkRenderWindow_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_UnRegister_158(HandleRef pThis, HandleRef o);

		protected override void Dispose(bool disposing)
		{
			try
			{
				if (base.GetCallDisposalMethod())
				{
					vtkRenderWindow.vtkRenderWindow_UnRegister_158(base.GetCppThis(), default(HandleRef));
					base.ClearCppThis();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_AddRenderer_01(HandleRef pThis, HandleRef arg0);

		public virtual void AddRenderer(vtkRenderer arg0)
		{
			vtkRenderWindow.vtkRenderWindow_AddRenderer_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_AlphaBitPlanesOff_02(HandleRef pThis);

		public virtual void AlphaBitPlanesOff()
		{
			vtkRenderWindow.vtkRenderWindow_AlphaBitPlanesOff_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_AlphaBitPlanesOn_03(HandleRef pThis);

		public virtual void AlphaBitPlanesOn()
		{
			vtkRenderWindow.vtkRenderWindow_AlphaBitPlanesOn_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_BordersOff_04(HandleRef pThis);

		public virtual void BordersOff()
		{
			vtkRenderWindow.vtkRenderWindow_BordersOff_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_BordersOn_05(HandleRef pThis);

		public virtual void BordersOn()
		{
			vtkRenderWindow.vtkRenderWindow_BordersOn_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindow_CheckAbortStatus_06(HandleRef pThis);

		public virtual int CheckAbortStatus()
		{
			return vtkRenderWindow.vtkRenderWindow_CheckAbortStatus_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_CheckGraphicError_07(HandleRef pThis);

		public virtual void CheckGraphicError()
		{
			vtkRenderWindow.vtkRenderWindow_CheckGraphicError_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindow_CheckInRenderStatus_08(HandleRef pThis);

		public virtual int CheckInRenderStatus()
		{
			return vtkRenderWindow.vtkRenderWindow_CheckInRenderStatus_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_ClearInRenderStatus_09(HandleRef pThis);

		public virtual void ClearInRenderStatus()
		{
			vtkRenderWindow.vtkRenderWindow_ClearInRenderStatus_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_CopyResultFrame_10(HandleRef pThis);

		public virtual void CopyResultFrame()
		{
			vtkRenderWindow.vtkRenderWindow_CopyResultFrame_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_Finalize_11(HandleRef pThis);

		public virtual void FinalizeWrapper()
		{
			vtkRenderWindow.vtkRenderWindow_Finalize_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_Frame_12(HandleRef pThis);

		public virtual void Frame()
		{
			vtkRenderWindow.vtkRenderWindow_Frame_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_FullScreenOff_13(HandleRef pThis);

		public virtual void FullScreenOff()
		{
			vtkRenderWindow.vtkRenderWindow_FullScreenOff_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_FullScreenOn_14(HandleRef pThis);

		public virtual void FullScreenOn()
		{
			vtkRenderWindow.vtkRenderWindow_FullScreenOn_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindow_GetAAFrames_15(HandleRef pThis);

		public virtual int GetAAFrames()
		{
			return vtkRenderWindow.vtkRenderWindow_GetAAFrames_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindow_GetAbortRender_16(HandleRef pThis);

		public virtual int GetAbortRender()
		{
			return vtkRenderWindow.vtkRenderWindow_GetAbortRender_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindow_GetAlphaBitPlanes_17(HandleRef pThis);

		public virtual int GetAlphaBitPlanes()
		{
			return vtkRenderWindow.vtkRenderWindow_GetAlphaBitPlanes_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderWindow_GetAnaglyphColorMask_18(HandleRef pThis);

		public virtual int[] GetAnaglyphColorMask()
		{
			IntPtr intPtr = vtkRenderWindow.vtkRenderWindow_GetAnaglyphColorMask_18(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_GetAnaglyphColorMask_19(HandleRef pThis, IntPtr data);

		public virtual void GetAnaglyphColorMask(IntPtr data)
		{
			vtkRenderWindow.vtkRenderWindow_GetAnaglyphColorMask_19(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern float vtkRenderWindow_GetAnaglyphColorSaturation_20(HandleRef pThis);

		public virtual float GetAnaglyphColorSaturation()
		{
			return vtkRenderWindow.vtkRenderWindow_GetAnaglyphColorSaturation_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern float vtkRenderWindow_GetAnaglyphColorSaturationMaxValue_21(HandleRef pThis);

		public virtual float GetAnaglyphColorSaturationMaxValue()
		{
			return vtkRenderWindow.vtkRenderWindow_GetAnaglyphColorSaturationMaxValue_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern float vtkRenderWindow_GetAnaglyphColorSaturationMinValue_22(HandleRef pThis);

		public virtual float GetAnaglyphColorSaturationMinValue()
		{
			return vtkRenderWindow.vtkRenderWindow_GetAnaglyphColorSaturationMinValue_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindow_GetBorders_23(HandleRef pThis);

		public virtual int GetBorders()
		{
			return vtkRenderWindow.vtkRenderWindow_GetBorders_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindow_GetColorBufferSizes_24(HandleRef pThis, IntPtr rgba);

		public virtual int GetColorBufferSizes(IntPtr rgba)
		{
			return vtkRenderWindow.vtkRenderWindow_GetColorBufferSizes_24(base.GetCppThis(), rgba);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindow_GetCurrentCursor_25(HandleRef pThis);

		public virtual int GetCurrentCursor()
		{
			return vtkRenderWindow.vtkRenderWindow_GetCurrentCursor_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindow_GetDepthBufferSize_26(HandleRef pThis);

		public virtual int GetDepthBufferSize()
		{
			return vtkRenderWindow.vtkRenderWindow_GetDepthBufferSize_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkRenderWindow_GetDesiredUpdateRate_27(HandleRef pThis);

		public virtual double GetDesiredUpdateRate()
		{
			return vtkRenderWindow.vtkRenderWindow_GetDesiredUpdateRate_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindow_GetEventPending_28(HandleRef pThis);

		public virtual int GetEventPending()
		{
			return vtkRenderWindow.vtkRenderWindow_GetEventPending_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindow_GetFDFrames_29(HandleRef pThis);

		public virtual int GetFDFrames()
		{
			return vtkRenderWindow.vtkRenderWindow_GetFDFrames_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindow_GetFullScreen_30(HandleRef pThis);

		public virtual int GetFullScreen()
		{
			return vtkRenderWindow.vtkRenderWindow_GetFullScreen_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderWindow_GetGenericContext_31(HandleRef pThis);

		public override IntPtr GetGenericContext()
		{
			return vtkRenderWindow.vtkRenderWindow_GetGenericContext_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderWindow_GetGenericDisplayId_32(HandleRef pThis);

		public override IntPtr GetGenericDisplayId()
		{
			return vtkRenderWindow.vtkRenderWindow_GetGenericDisplayId_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderWindow_GetGenericDrawable_33(HandleRef pThis);

		public override IntPtr GetGenericDrawable()
		{
			return vtkRenderWindow.vtkRenderWindow_GetGenericDrawable_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderWindow_GetGenericParentId_34(HandleRef pThis);

		public override IntPtr GetGenericParentId()
		{
			return vtkRenderWindow.vtkRenderWindow_GetGenericParentId_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderWindow_GetGenericWindowId_35(HandleRef pThis);

		public override IntPtr GetGenericWindowId()
		{
			return vtkRenderWindow.vtkRenderWindow_GetGenericWindowId_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindow_GetInAbortCheck_36(HandleRef pThis);

		public virtual int GetInAbortCheck()
		{
			return vtkRenderWindow.vtkRenderWindow_GetInAbortCheck_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderWindow_GetInteractor_37(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkRenderWindowInteractor GetInteractor()
		{
			vtkRenderWindowInteractor vtkRenderWindowInteractor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderWindow.vtkRenderWindow_GetInteractor_37(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderWindowInteractor = (vtkRenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderWindowInteractor.Register(null);
				}
			}
			return vtkRenderWindowInteractor;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindow_GetIsPicking_38(HandleRef pThis);

		public virtual int GetIsPicking()
		{
			return vtkRenderWindow.vtkRenderWindow_GetIsPicking_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderWindow_GetLastGraphicErrorString_39(HandleRef pThis);

		public virtual string GetLastGraphicErrorString()
		{
			return Marshal.PtrToStringAnsi(vtkRenderWindow.vtkRenderWindow_GetLastGraphicErrorString_39(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindow_GetLineSmoothing_40(HandleRef pThis);

		public virtual int GetLineSmoothing()
		{
			return vtkRenderWindow.vtkRenderWindow_GetLineSmoothing_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindow_GetMultiSamples_41(HandleRef pThis);

		public virtual int GetMultiSamples()
		{
			return vtkRenderWindow.vtkRenderWindow_GetMultiSamples_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindow_GetNeverRendered_42(HandleRef pThis);

		public virtual int GetNeverRendered()
		{
			return vtkRenderWindow.vtkRenderWindow_GetNeverRendered_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindow_GetNumberOfLayers_43(HandleRef pThis);

		public virtual int GetNumberOfLayers()
		{
			return vtkRenderWindow.vtkRenderWindow_GetNumberOfLayers_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindow_GetNumberOfLayersMaxValue_44(HandleRef pThis);

		public virtual int GetNumberOfLayersMaxValue()
		{
			return vtkRenderWindow.vtkRenderWindow_GetNumberOfLayersMaxValue_44(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindow_GetNumberOfLayersMinValue_45(HandleRef pThis);

		public virtual int GetNumberOfLayersMinValue()
		{
			return vtkRenderWindow.vtkRenderWindow_GetNumberOfLayersMinValue_45(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderWindow_GetPainterDeviceAdapter_46(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPainterDeviceAdapter GetPainterDeviceAdapter()
		{
			vtkPainterDeviceAdapter vtkPainterDeviceAdapter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderWindow.vtkRenderWindow_GetPainterDeviceAdapter_46(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPainterDeviceAdapter = (vtkPainterDeviceAdapter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPainterDeviceAdapter.Register(null);
				}
			}
			return vtkPainterDeviceAdapter;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindow_GetPointSmoothing_47(HandleRef pThis);

		public virtual int GetPointSmoothing()
		{
			return vtkRenderWindow.vtkRenderWindow_GetPointSmoothing_47(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindow_GetPolygonSmoothing_48(HandleRef pThis);

		public virtual int GetPolygonSmoothing()
		{
			return vtkRenderWindow.vtkRenderWindow_GetPolygonSmoothing_48(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderWindow_GetRGBACharPixelData_49(HandleRef pThis, int x, int y, int x2, int y2, int front);

		public virtual IntPtr GetRGBACharPixelData(int x, int y, int x2, int y2, int front)
		{
			return vtkRenderWindow.vtkRenderWindow_GetRGBACharPixelData_49(base.GetCppThis(), x, y, x2, y2, front);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindow_GetRGBACharPixelData_50(HandleRef pThis, int x, int y, int x2, int y2, int front, HandleRef data);

		public virtual int GetRGBACharPixelData(int x, int y, int x2, int y2, int front, vtkUnsignedCharArray data)
		{
			return vtkRenderWindow.vtkRenderWindow_GetRGBACharPixelData_50(base.GetCppThis(), x, y, x2, y2, front, (data == null) ? default(HandleRef) : data.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderWindow_GetRGBAPixelData_51(HandleRef pThis, int x, int y, int x2, int y2, int front);

		public virtual IntPtr GetRGBAPixelData(int x, int y, int x2, int y2, int front)
		{
			return vtkRenderWindow.vtkRenderWindow_GetRGBAPixelData_51(base.GetCppThis(), x, y, x2, y2, front);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindow_GetRGBAPixelData_52(HandleRef pThis, int x, int y, int x2, int y2, int front, HandleRef data);

		public virtual int GetRGBAPixelData(int x, int y, int x2, int y2, int front, vtkFloatArray data)
		{
			return vtkRenderWindow.vtkRenderWindow_GetRGBAPixelData_52(base.GetCppThis(), x, y, x2, y2, front, (data == null) ? default(HandleRef) : data.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderWindow_GetRenderLibrary_53();

		public static string GetRenderLibrary()
		{
			return Marshal.PtrToStringAnsi(vtkRenderWindow.vtkRenderWindow_GetRenderLibrary_53());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderWindow_GetRenderers_54(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkRendererCollection GetRenderers()
		{
			vtkRendererCollection vtkRendererCollection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderWindow.vtkRenderWindow_GetRenderers_54(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRendererCollection = (vtkRendererCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRendererCollection.Register(null);
				}
			}
			return vtkRendererCollection;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindow_GetReportGraphicErrors_55(HandleRef pThis);

		public virtual int GetReportGraphicErrors()
		{
			return vtkRenderWindow.vtkRenderWindow_GetReportGraphicErrors_55(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindow_GetStencilCapable_56(HandleRef pThis);

		public virtual int GetStencilCapable()
		{
			return vtkRenderWindow.vtkRenderWindow_GetStencilCapable_56(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindow_GetStereoCapableWindow_57(HandleRef pThis);

		public virtual int GetStereoCapableWindow()
		{
			return vtkRenderWindow.vtkRenderWindow_GetStereoCapableWindow_57(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindow_GetStereoRender_58(HandleRef pThis);

		public virtual int GetStereoRender()
		{
			return vtkRenderWindow.vtkRenderWindow_GetStereoRender_58(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindow_GetStereoType_59(HandleRef pThis);

		public virtual int GetStereoType()
		{
			return vtkRenderWindow.vtkRenderWindow_GetStereoType_59(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderWindow_GetStereoTypeAsString_60(HandleRef pThis);

		public string GetStereoTypeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkRenderWindow.vtkRenderWindow_GetStereoTypeAsString_60(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindow_GetSubFrames_61(HandleRef pThis);

		public virtual int GetSubFrames()
		{
			return vtkRenderWindow.vtkRenderWindow_GetSubFrames_61(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindow_GetSwapBuffers_62(HandleRef pThis);

		public virtual int GetSwapBuffers()
		{
			return vtkRenderWindow.vtkRenderWindow_GetSwapBuffers_62(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderWindow_GetZbufferData_63(HandleRef pThis, int x, int y, int x2, int y2);

		public virtual IntPtr GetZbufferData(int x, int y, int x2, int y2)
		{
			return vtkRenderWindow.vtkRenderWindow_GetZbufferData_63(base.GetCppThis(), x, y, x2, y2);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindow_GetZbufferData_64(HandleRef pThis, int x, int y, int x2, int y2, IntPtr z);

		public virtual int GetZbufferData(int x, int y, int x2, int y2, IntPtr z)
		{
			return vtkRenderWindow.vtkRenderWindow_GetZbufferData_64(base.GetCppThis(), x, y, x2, y2, z);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindow_GetZbufferData_65(HandleRef pThis, int x, int y, int x2, int y2, HandleRef z);

		public virtual int GetZbufferData(int x, int y, int x2, int y2, vtkFloatArray z)
		{
			return vtkRenderWindow.vtkRenderWindow_GetZbufferData_65(base.GetCppThis(), x, y, x2, y2, (z == null) ? default(HandleRef) : z.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern float vtkRenderWindow_GetZbufferDataAtPoint_66(HandleRef pThis, int x, int y);

		public float GetZbufferDataAtPoint(int x, int y)
		{
			return vtkRenderWindow.vtkRenderWindow_GetZbufferDataAtPoint_66(base.GetCppThis(), x, y);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindow_HasGraphicError_67(HandleRef pThis);

		public virtual int HasGraphicError()
		{
			return vtkRenderWindow.vtkRenderWindow_HasGraphicError_67(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindow_HasRenderer_68(HandleRef pThis, HandleRef arg0);

		public int HasRenderer(vtkRenderer arg0)
		{
			return vtkRenderWindow.vtkRenderWindow_HasRenderer_68(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_HideCursor_69(HandleRef pThis);

		public virtual void HideCursor()
		{
			vtkRenderWindow.vtkRenderWindow_HideCursor_69(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindow_IsA_70(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkRenderWindow.vtkRenderWindow_IsA_70(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkRenderWindow_IsCurrent_71(HandleRef pThis);

		public virtual bool IsCurrent()
		{
			return vtkRenderWindow.vtkRenderWindow_IsCurrent_71(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindow_IsDirect_72(HandleRef pThis);

		public virtual int IsDirect()
		{
			return vtkRenderWindow.vtkRenderWindow_IsDirect_72(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_IsPickingOff_73(HandleRef pThis);

		public virtual void IsPickingOff()
		{
			vtkRenderWindow.vtkRenderWindow_IsPickingOff_73(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_IsPickingOn_74(HandleRef pThis);

		public virtual void IsPickingOn()
		{
			vtkRenderWindow.vtkRenderWindow_IsPickingOn_74(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindow_IsTypeOf_75(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkRenderWindow.vtkRenderWindow_IsTypeOf_75(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_LineSmoothingOff_76(HandleRef pThis);

		public virtual void LineSmoothingOff()
		{
			vtkRenderWindow.vtkRenderWindow_LineSmoothingOff_76(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_LineSmoothingOn_77(HandleRef pThis);

		public virtual void LineSmoothingOn()
		{
			vtkRenderWindow.vtkRenderWindow_LineSmoothingOn_77(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_MakeCurrent_78(HandleRef pThis);

		public override void MakeCurrent()
		{
			vtkRenderWindow.vtkRenderWindow_MakeCurrent_78(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderWindow_MakeRenderWindowInteractor_79(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkRenderWindowInteractor MakeRenderWindowInteractor()
		{
			vtkRenderWindowInteractor vtkRenderWindowInteractor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderWindow.vtkRenderWindow_MakeRenderWindowInteractor_79(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderWindowInteractor = (vtkRenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderWindowInteractor.Register(null);
				}
			}
			return vtkRenderWindowInteractor;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderWindow_NewInstance_81(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRenderWindow NewInstance()
		{
			vtkRenderWindow result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderWindow.vtkRenderWindow_NewInstance_81(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_PointSmoothingOff_82(HandleRef pThis);

		public virtual void PointSmoothingOff()
		{
			vtkRenderWindow.vtkRenderWindow_PointSmoothingOff_82(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_PointSmoothingOn_83(HandleRef pThis);

		public virtual void PointSmoothingOn()
		{
			vtkRenderWindow.vtkRenderWindow_PointSmoothingOn_83(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_PolygonSmoothingOff_84(HandleRef pThis);

		public virtual void PolygonSmoothingOff()
		{
			vtkRenderWindow.vtkRenderWindow_PolygonSmoothingOff_84(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_PolygonSmoothingOn_85(HandleRef pThis);

		public virtual void PolygonSmoothingOn()
		{
			vtkRenderWindow.vtkRenderWindow_PolygonSmoothingOn_85(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_ReleaseRGBAPixelData_86(HandleRef pThis, IntPtr data);

		public virtual void ReleaseRGBAPixelData(IntPtr data)
		{
			vtkRenderWindow.vtkRenderWindow_ReleaseRGBAPixelData_86(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_RemoveRenderer_87(HandleRef pThis, HandleRef arg0);

		public void RemoveRenderer(vtkRenderer arg0)
		{
			vtkRenderWindow.vtkRenderWindow_RemoveRenderer_87(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_Render_88(HandleRef pThis);

		public override void Render()
		{
			vtkRenderWindow.vtkRenderWindow_Render_88(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderWindow_ReportCapabilities_89(HandleRef pThis);

		public virtual string ReportCapabilities()
		{
			return Marshal.PtrToStringAnsi(vtkRenderWindow.vtkRenderWindow_ReportCapabilities_89(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_ReportGraphicErrorsOff_90(HandleRef pThis);

		public virtual void ReportGraphicErrorsOff()
		{
			vtkRenderWindow.vtkRenderWindow_ReportGraphicErrorsOff_90(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_ReportGraphicErrorsOn_91(HandleRef pThis);

		public virtual void ReportGraphicErrorsOn()
		{
			vtkRenderWindow.vtkRenderWindow_ReportGraphicErrorsOn_91(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderWindow_SafeDownCast_92(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRenderWindow SafeDownCast(vtkObjectBase o)
		{
			vtkRenderWindow vtkRenderWindow = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderWindow.vtkRenderWindow_SafeDownCast_92((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkRenderWindow_SetAAFrames_93(HandleRef pThis, int _arg);

		public virtual void SetAAFrames(int _arg)
		{
			vtkRenderWindow.vtkRenderWindow_SetAAFrames_93(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_SetAbortRender_94(HandleRef pThis, int _arg);

		public virtual void SetAbortRender(int _arg)
		{
			vtkRenderWindow.vtkRenderWindow_SetAbortRender_94(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_SetAlphaBitPlanes_95(HandleRef pThis, int _arg);

		public virtual void SetAlphaBitPlanes(int _arg)
		{
			vtkRenderWindow.vtkRenderWindow_SetAlphaBitPlanes_95(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_SetAnaglyphColorMask_96(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetAnaglyphColorMask(int _arg1, int _arg2)
		{
			vtkRenderWindow.vtkRenderWindow_SetAnaglyphColorMask_96(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_SetAnaglyphColorMask_97(HandleRef pThis, IntPtr _arg);

		public void SetAnaglyphColorMask(IntPtr _arg)
		{
			vtkRenderWindow.vtkRenderWindow_SetAnaglyphColorMask_97(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_SetAnaglyphColorSaturation_98(HandleRef pThis, float _arg);

		public virtual void SetAnaglyphColorSaturation(float _arg)
		{
			vtkRenderWindow.vtkRenderWindow_SetAnaglyphColorSaturation_98(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_SetBorders_99(HandleRef pThis, int _arg);

		public virtual void SetBorders(int _arg)
		{
			vtkRenderWindow.vtkRenderWindow_SetBorders_99(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_SetCurrentCursor_100(HandleRef pThis, int _arg);

		public virtual void SetCurrentCursor(int _arg)
		{
			vtkRenderWindow.vtkRenderWindow_SetCurrentCursor_100(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_SetCursorPosition_101(HandleRef pThis, int arg0, int arg1);

		public virtual void SetCursorPosition(int arg0, int arg1)
		{
			vtkRenderWindow.vtkRenderWindow_SetCursorPosition_101(base.GetCppThis(), arg0, arg1);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_SetDesiredUpdateRate_102(HandleRef pThis, double arg0);

		public virtual void SetDesiredUpdateRate(double arg0)
		{
			vtkRenderWindow.vtkRenderWindow_SetDesiredUpdateRate_102(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_SetDisplayId_103(HandleRef pThis, IntPtr arg0);

		public override void SetDisplayId(IntPtr arg0)
		{
			vtkRenderWindow.vtkRenderWindow_SetDisplayId_103(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_SetFDFrames_104(HandleRef pThis, int _arg);

		public virtual void SetFDFrames(int _arg)
		{
			vtkRenderWindow.vtkRenderWindow_SetFDFrames_104(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_SetForceMakeCurrent_105(HandleRef pThis);

		public virtual void SetForceMakeCurrent()
		{
			vtkRenderWindow.vtkRenderWindow_SetForceMakeCurrent_105(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_SetFullScreen_106(HandleRef pThis, int arg0);

		public virtual void SetFullScreen(int arg0)
		{
			vtkRenderWindow.vtkRenderWindow_SetFullScreen_106(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_SetInAbortCheck_107(HandleRef pThis, int _arg);

		public virtual void SetInAbortCheck(int _arg)
		{
			vtkRenderWindow.vtkRenderWindow_SetInAbortCheck_107(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_SetInteractor_108(HandleRef pThis, HandleRef arg0);

		public void SetInteractor(vtkRenderWindowInteractor arg0)
		{
			vtkRenderWindow.vtkRenderWindow_SetInteractor_108(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_SetIsPicking_109(HandleRef pThis, int _arg);

		public virtual void SetIsPicking(int _arg)
		{
			vtkRenderWindow.vtkRenderWindow_SetIsPicking_109(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_SetLineSmoothing_110(HandleRef pThis, int _arg);

		public virtual void SetLineSmoothing(int _arg)
		{
			vtkRenderWindow.vtkRenderWindow_SetLineSmoothing_110(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_SetMultiSamples_111(HandleRef pThis, int _arg);

		public virtual void SetMultiSamples(int _arg)
		{
			vtkRenderWindow.vtkRenderWindow_SetMultiSamples_111(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_SetNextWindowId_112(HandleRef pThis, IntPtr arg0);

		public virtual void SetNextWindowId(IntPtr arg0)
		{
			vtkRenderWindow.vtkRenderWindow_SetNextWindowId_112(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_SetNextWindowInfo_113(HandleRef pThis, string arg0);

		public virtual void SetNextWindowInfo(string arg0)
		{
			vtkRenderWindow.vtkRenderWindow_SetNextWindowInfo_113(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_SetNumberOfLayers_114(HandleRef pThis, int _arg);

		public virtual void SetNumberOfLayers(int _arg)
		{
			vtkRenderWindow.vtkRenderWindow_SetNumberOfLayers_114(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_SetParentId_115(HandleRef pThis, IntPtr arg0);

		public override void SetParentId(IntPtr arg0)
		{
			vtkRenderWindow.vtkRenderWindow_SetParentId_115(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_SetParentInfo_116(HandleRef pThis, string arg0);

		public override void SetParentInfo(string arg0)
		{
			vtkRenderWindow.vtkRenderWindow_SetParentInfo_116(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindow_SetPixelData_117(HandleRef pThis, int x, int y, int x2, int y2, IntPtr data, int front);

		public virtual int SetPixelData(int x, int y, int x2, int y2, IntPtr data, int front)
		{
			return vtkRenderWindow.vtkRenderWindow_SetPixelData_117(base.GetCppThis(), x, y, x2, y2, data, front);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindow_SetPixelData_118(HandleRef pThis, int x, int y, int x2, int y2, HandleRef data, int front);

		public virtual int SetPixelData(int x, int y, int x2, int y2, vtkUnsignedCharArray data, int front)
		{
			return vtkRenderWindow.vtkRenderWindow_SetPixelData_118(base.GetCppThis(), x, y, x2, y2, (data == null) ? default(HandleRef) : data.GetCppThis(), front);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_SetPointSmoothing_119(HandleRef pThis, int _arg);

		public virtual void SetPointSmoothing(int _arg)
		{
			vtkRenderWindow.vtkRenderWindow_SetPointSmoothing_119(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_SetPolygonSmoothing_120(HandleRef pThis, int _arg);

		public virtual void SetPolygonSmoothing(int _arg)
		{
			vtkRenderWindow.vtkRenderWindow_SetPolygonSmoothing_120(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindow_SetRGBACharPixelData_121(HandleRef pThis, int x, int y, int x2, int y2, IntPtr data, int front, int blend);

		public virtual int SetRGBACharPixelData(int x, int y, int x2, int y2, IntPtr data, int front, int blend)
		{
			return vtkRenderWindow.vtkRenderWindow_SetRGBACharPixelData_121(base.GetCppThis(), x, y, x2, y2, data, front, blend);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindow_SetRGBACharPixelData_122(HandleRef pThis, int x, int y, int x2, int y2, HandleRef data, int front, int blend);

		public virtual int SetRGBACharPixelData(int x, int y, int x2, int y2, vtkUnsignedCharArray data, int front, int blend)
		{
			return vtkRenderWindow.vtkRenderWindow_SetRGBACharPixelData_122(base.GetCppThis(), x, y, x2, y2, (data == null) ? default(HandleRef) : data.GetCppThis(), front, blend);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindow_SetRGBAPixelData_123(HandleRef pThis, int x, int y, int x2, int y2, IntPtr arg4, int front, int blend);

		public virtual int SetRGBAPixelData(int x, int y, int x2, int y2, IntPtr arg4, int front, int blend)
		{
			return vtkRenderWindow.vtkRenderWindow_SetRGBAPixelData_123(base.GetCppThis(), x, y, x2, y2, arg4, front, blend);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindow_SetRGBAPixelData_124(HandleRef pThis, int arg0, int arg1, int arg2, int arg3, HandleRef arg4, int arg5, int blend);

		public virtual int SetRGBAPixelData(int arg0, int arg1, int arg2, int arg3, vtkFloatArray arg4, int arg5, int blend)
		{
			return vtkRenderWindow.vtkRenderWindow_SetRGBAPixelData_124(base.GetCppThis(), arg0, arg1, arg2, arg3, (arg4 == null) ? default(HandleRef) : arg4.GetCppThis(), arg5, blend);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_SetReportGraphicErrors_125(HandleRef pThis, int _arg);

		public virtual void SetReportGraphicErrors(int _arg)
		{
			vtkRenderWindow.vtkRenderWindow_SetReportGraphicErrors_125(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_SetStencilCapable_126(HandleRef pThis, int _arg);

		public virtual void SetStencilCapable(int _arg)
		{
			vtkRenderWindow.vtkRenderWindow_SetStencilCapable_126(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_SetStereoCapableWindow_127(HandleRef pThis, int capable);

		public virtual void SetStereoCapableWindow(int capable)
		{
			vtkRenderWindow.vtkRenderWindow_SetStereoCapableWindow_127(base.GetCppThis(), capable);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_SetStereoRender_128(HandleRef pThis, int stereo);

		public void SetStereoRender(int stereo)
		{
			vtkRenderWindow.vtkRenderWindow_SetStereoRender_128(base.GetCppThis(), stereo);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_SetStereoType_129(HandleRef pThis, int _arg);

		public virtual void SetStereoType(int _arg)
		{
			vtkRenderWindow.vtkRenderWindow_SetStereoType_129(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_SetStereoTypeToAnaglyph_130(HandleRef pThis);

		public void SetStereoTypeToAnaglyph()
		{
			vtkRenderWindow.vtkRenderWindow_SetStereoTypeToAnaglyph_130(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_SetStereoTypeToCheckerboard_131(HandleRef pThis);

		public void SetStereoTypeToCheckerboard()
		{
			vtkRenderWindow.vtkRenderWindow_SetStereoTypeToCheckerboard_131(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_SetStereoTypeToCrystalEyes_132(HandleRef pThis);

		public void SetStereoTypeToCrystalEyes()
		{
			vtkRenderWindow.vtkRenderWindow_SetStereoTypeToCrystalEyes_132(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_SetStereoTypeToDresden_133(HandleRef pThis);

		public void SetStereoTypeToDresden()
		{
			vtkRenderWindow.vtkRenderWindow_SetStereoTypeToDresden_133(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_SetStereoTypeToInterlaced_134(HandleRef pThis);

		public void SetStereoTypeToInterlaced()
		{
			vtkRenderWindow.vtkRenderWindow_SetStereoTypeToInterlaced_134(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_SetStereoTypeToLeft_135(HandleRef pThis);

		public void SetStereoTypeToLeft()
		{
			vtkRenderWindow.vtkRenderWindow_SetStereoTypeToLeft_135(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_SetStereoTypeToRedBlue_136(HandleRef pThis);

		public void SetStereoTypeToRedBlue()
		{
			vtkRenderWindow.vtkRenderWindow_SetStereoTypeToRedBlue_136(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_SetStereoTypeToRight_137(HandleRef pThis);

		public void SetStereoTypeToRight()
		{
			vtkRenderWindow.vtkRenderWindow_SetStereoTypeToRight_137(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_SetSubFrames_138(HandleRef pThis, int subFrames);

		public virtual void SetSubFrames(int subFrames)
		{
			vtkRenderWindow.vtkRenderWindow_SetSubFrames_138(base.GetCppThis(), subFrames);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_SetSwapBuffers_139(HandleRef pThis, int _arg);

		public virtual void SetSwapBuffers(int _arg)
		{
			vtkRenderWindow.vtkRenderWindow_SetSwapBuffers_139(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_SetWindowId_140(HandleRef pThis, IntPtr arg0);

		public override void SetWindowId(IntPtr arg0)
		{
			vtkRenderWindow.vtkRenderWindow_SetWindowId_140(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_SetWindowInfo_141(HandleRef pThis, string arg0);

		public override void SetWindowInfo(string arg0)
		{
			vtkRenderWindow.vtkRenderWindow_SetWindowInfo_141(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindow_SetZbufferData_142(HandleRef pThis, int x, int y, int x2, int y2, IntPtr z);

		public virtual int SetZbufferData(int x, int y, int x2, int y2, IntPtr z)
		{
			return vtkRenderWindow.vtkRenderWindow_SetZbufferData_142(base.GetCppThis(), x, y, x2, y2, z);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindow_SetZbufferData_143(HandleRef pThis, int x, int y, int x2, int y2, HandleRef z);

		public virtual int SetZbufferData(int x, int y, int x2, int y2, vtkFloatArray z)
		{
			return vtkRenderWindow.vtkRenderWindow_SetZbufferData_143(base.GetCppThis(), x, y, x2, y2, (z == null) ? default(HandleRef) : z.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_ShowCursor_144(HandleRef pThis);

		public virtual void ShowCursor()
		{
			vtkRenderWindow.vtkRenderWindow_ShowCursor_144(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_Start_145(HandleRef pThis);

		public virtual void Start()
		{
			vtkRenderWindow.vtkRenderWindow_Start_145(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_StencilCapableOff_146(HandleRef pThis);

		public virtual void StencilCapableOff()
		{
			vtkRenderWindow.vtkRenderWindow_StencilCapableOff_146(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_StencilCapableOn_147(HandleRef pThis);

		public virtual void StencilCapableOn()
		{
			vtkRenderWindow.vtkRenderWindow_StencilCapableOn_147(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_StereoCapableWindowOff_148(HandleRef pThis);

		public virtual void StereoCapableWindowOff()
		{
			vtkRenderWindow.vtkRenderWindow_StereoCapableWindowOff_148(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_StereoCapableWindowOn_149(HandleRef pThis);

		public virtual void StereoCapableWindowOn()
		{
			vtkRenderWindow.vtkRenderWindow_StereoCapableWindowOn_149(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_StereoMidpoint_150(HandleRef pThis);

		public virtual void StereoMidpoint()
		{
			vtkRenderWindow.vtkRenderWindow_StereoMidpoint_150(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_StereoRenderComplete_151(HandleRef pThis);

		public virtual void StereoRenderComplete()
		{
			vtkRenderWindow.vtkRenderWindow_StereoRenderComplete_151(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_StereoRenderOff_152(HandleRef pThis);

		public virtual void StereoRenderOff()
		{
			vtkRenderWindow.vtkRenderWindow_StereoRenderOff_152(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_StereoRenderOn_153(HandleRef pThis);

		public virtual void StereoRenderOn()
		{
			vtkRenderWindow.vtkRenderWindow_StereoRenderOn_153(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_StereoUpdate_154(HandleRef pThis);

		public virtual void StereoUpdate()
		{
			vtkRenderWindow.vtkRenderWindow_StereoUpdate_154(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkRenderWindow_SupportsOpenGL_155(HandleRef pThis);

		public virtual int SupportsOpenGL()
		{
			return vtkRenderWindow.vtkRenderWindow_SupportsOpenGL_155(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_SwapBuffersOff_156(HandleRef pThis);

		public virtual void SwapBuffersOff()
		{
			vtkRenderWindow.vtkRenderWindow_SwapBuffersOff_156(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_SwapBuffersOn_157(HandleRef pThis);

		public virtual void SwapBuffersOn()
		{
			vtkRenderWindow.vtkRenderWindow_SwapBuffersOn_157(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_WaitForCompletion_159(HandleRef pThis);

		public virtual void WaitForCompletion()
		{
			vtkRenderWindow.vtkRenderWindow_WaitForCompletion_159(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkRenderWindow_WindowRemap_160(HandleRef pThis);

		public virtual void WindowRemap()
		{
			vtkRenderWindow.vtkRenderWindow_WindowRemap_160(base.GetCppThis());
		}
	}
}
