using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkRenderView : vtkRenderViewBase
	{
		public enum INTERACTION_MODE_2D_WrapperEnum
		{
			INTERACTION_MODE_2D,
			INTERACTION_MODE_3D,
			INTERACTION_MODE_UNKNOWN
		}

		public enum FRUSTUM_WrapperEnum
		{
			FRUSTUM = 1,
			SURFACE = 0
		}

		public enum ALL_WrapperEnum
		{
			ALL = 1,
			NO_OVERLAP = 0
		}

		public enum FREETYPE_WrapperEnum
		{
			FREETYPE,
			QT
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkRenderView";

		public new static readonly string MRClassNameKey;

		static vtkRenderView()
		{
			vtkRenderView.MRClassNameKey = "class vtkRenderView";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRenderView.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRenderView"));
		}

		public vtkRenderView(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderView_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRenderView New()
		{
			vtkRenderView result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderView.vtkRenderView_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkRenderView() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkRenderView.vtkRenderView_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderView_AddLabels_01(HandleRef pThis, HandleRef conn);

		public virtual void AddLabels(vtkAlgorithmOutput conn)
		{
			vtkRenderView.vtkRenderView_AddLabels_01(base.GetCppThis(), (conn == null) ? default(HandleRef) : conn.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderView_ApplyViewTheme_02(HandleRef pThis, HandleRef theme);

		public override void ApplyViewTheme(vtkViewTheme theme)
		{
			vtkRenderView.vtkRenderView_ApplyViewTheme_02(base.GetCppThis(), (theme == null) ? default(HandleRef) : theme.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderView_DisplayHoverTextOff_03(HandleRef pThis);

		public virtual void DisplayHoverTextOff()
		{
			vtkRenderView.vtkRenderView_DisplayHoverTextOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderView_DisplayHoverTextOn_04(HandleRef pThis);

		public virtual void DisplayHoverTextOn()
		{
			vtkRenderView.vtkRenderView_DisplayHoverTextOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkRenderView_GetDisplayHoverText_05(HandleRef pThis);

		public virtual bool GetDisplayHoverText()
		{
			return vtkRenderView.vtkRenderView_GetDisplayHoverText_05(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderView_GetDisplaySize_06(HandleRef pThis);

		public IntPtr GetDisplaySize()
		{
			return vtkRenderView.vtkRenderView_GetDisplaySize_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderView_GetDisplaySize_07(HandleRef pThis, ref int dsx, ref int dsy);

		public void GetDisplaySize(ref int dsx, ref int dsy)
		{
			vtkRenderView.vtkRenderView_GetDisplaySize_07(base.GetCppThis(), ref dsx, ref dsy);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderView_GetIconSize_08(HandleRef pThis);

		public virtual int[] GetIconSize()
		{
			IntPtr intPtr = vtkRenderView.vtkRenderView_GetIconSize_08(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderView_GetIconSize_09(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetIconSize(ref int _arg1, ref int _arg2)
		{
			vtkRenderView.vtkRenderView_GetIconSize_09(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderView_GetIconSize_10(HandleRef pThis, IntPtr _arg);

		public virtual void GetIconSize(IntPtr _arg)
		{
			vtkRenderView.vtkRenderView_GetIconSize_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderView_GetIconTexture_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTexture GetIconTexture()
		{
			vtkTexture vtkTexture = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderView.vtkRenderView_GetIconTexture_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkRenderView_GetInteractionMode_12(HandleRef pThis);

		public virtual int GetInteractionMode()
		{
			return vtkRenderView.vtkRenderView_GetInteractionMode_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderView_GetInteractorStyle_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkInteractorObserver GetInteractorStyle()
		{
			vtkInteractorObserver vtkInteractorObserver = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderView.vtkRenderView_GetInteractorStyle_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorObserver = (vtkInteractorObserver)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorObserver.Register(null);
				}
			}
			return vtkInteractorObserver;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkRenderView_GetLabelPlacementMode_14(HandleRef pThis);

		public virtual int GetLabelPlacementMode()
		{
			return vtkRenderView.vtkRenderView_GetLabelPlacementMode_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkRenderView_GetLabelRenderMode_15(HandleRef pThis);

		public virtual int GetLabelRenderMode()
		{
			return vtkRenderView.vtkRenderView_GetLabelRenderMode_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern byte vtkRenderView_GetRenderOnMouseMove_16(HandleRef pThis);

		public virtual bool GetRenderOnMouseMove()
		{
			return vtkRenderView.vtkRenderView_GetRenderOnMouseMove_16(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkRenderView_GetSelectionMode_17(HandleRef pThis);

		public virtual int GetSelectionMode()
		{
			return vtkRenderView.vtkRenderView_GetSelectionMode_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkRenderView_GetSelectionModeMaxValue_18(HandleRef pThis);

		public virtual int GetSelectionModeMaxValue()
		{
			return vtkRenderView.vtkRenderView_GetSelectionModeMaxValue_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkRenderView_GetSelectionModeMinValue_19(HandleRef pThis);

		public virtual int GetSelectionModeMinValue()
		{
			return vtkRenderView.vtkRenderView_GetSelectionModeMinValue_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderView_GetTransform_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAbstractTransform GetTransform()
		{
			vtkAbstractTransform vtkAbstractTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderView.vtkRenderView_GetTransform_20(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractTransform = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractTransform.Register(null);
				}
			}
			return vtkAbstractTransform;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkRenderView_IsA_21(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkRenderView.vtkRenderView_IsA_21(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern int vtkRenderView_IsTypeOf_22(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkRenderView.vtkRenderView_IsTypeOf_22(type);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderView_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRenderView NewInstance()
		{
			vtkRenderView result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderView.vtkRenderView_NewInstance_24(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRenderView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderView_RemoveLabels_25(HandleRef pThis, HandleRef conn);

		public virtual void RemoveLabels(vtkAlgorithmOutput conn)
		{
			vtkRenderView.vtkRenderView_RemoveLabels_25(base.GetCppThis(), (conn == null) ? default(HandleRef) : conn.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderView_Render_26(HandleRef pThis);

		public override void Render()
		{
			vtkRenderView.vtkRenderView_Render_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderView_RenderOnMouseMoveOff_27(HandleRef pThis);

		public virtual void RenderOnMouseMoveOff()
		{
			vtkRenderView.vtkRenderView_RenderOnMouseMoveOff_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderView_RenderOnMouseMoveOn_28(HandleRef pThis);

		public virtual void RenderOnMouseMoveOn()
		{
			vtkRenderView.vtkRenderView_RenderOnMouseMoveOn_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern IntPtr vtkRenderView_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRenderView SafeDownCast(vtkObjectBase o)
		{
			vtkRenderView vtkRenderView = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRenderView.vtkRenderView_SafeDownCast_29((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderView = (vtkRenderView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderView.Register(null);
				}
			}
			return vtkRenderView;
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderView_SetDisplayHoverText_30(HandleRef pThis, byte b);

		public virtual void SetDisplayHoverText(bool b)
		{
			vtkRenderView.vtkRenderView_SetDisplayHoverText_30(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderView_SetDisplaySize_31(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetDisplaySize(int _arg1, int _arg2)
		{
			vtkRenderView.vtkRenderView_SetDisplaySize_31(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderView_SetDisplaySize_32(HandleRef pThis, IntPtr _arg);

		public void SetDisplaySize(IntPtr _arg)
		{
			vtkRenderView.vtkRenderView_SetDisplaySize_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderView_SetIconSize_33(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetIconSize(int _arg1, int _arg2)
		{
			vtkRenderView.vtkRenderView_SetIconSize_33(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderView_SetIconSize_34(HandleRef pThis, IntPtr _arg);

		public void SetIconSize(IntPtr _arg)
		{
			vtkRenderView.vtkRenderView_SetIconSize_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderView_SetIconTexture_35(HandleRef pThis, HandleRef texture);

		public virtual void SetIconTexture(vtkTexture texture)
		{
			vtkRenderView.vtkRenderView_SetIconTexture_35(base.GetCppThis(), (texture == null) ? default(HandleRef) : texture.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderView_SetInteractionMode_36(HandleRef pThis, int mode);

		public void SetInteractionMode(int mode)
		{
			vtkRenderView.vtkRenderView_SetInteractionMode_36(base.GetCppThis(), mode);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderView_SetInteractionModeTo2D_37(HandleRef pThis);

		public virtual void SetInteractionModeTo2D()
		{
			vtkRenderView.vtkRenderView_SetInteractionModeTo2D_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderView_SetInteractionModeTo3D_38(HandleRef pThis);

		public virtual void SetInteractionModeTo3D()
		{
			vtkRenderView.vtkRenderView_SetInteractionModeTo3D_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderView_SetInteractor_39(HandleRef pThis, HandleRef interactor);

		public override void SetInteractor(vtkRenderWindowInteractor interactor)
		{
			vtkRenderView.vtkRenderView_SetInteractor_39(base.GetCppThis(), (interactor == null) ? default(HandleRef) : interactor.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderView_SetInteractorStyle_40(HandleRef pThis, HandleRef style);

		public virtual void SetInteractorStyle(vtkInteractorObserver style)
		{
			vtkRenderView.vtkRenderView_SetInteractorStyle_40(base.GetCppThis(), (style == null) ? default(HandleRef) : style.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderView_SetLabelPlacementMode_41(HandleRef pThis, int mode);

		public virtual void SetLabelPlacementMode(int mode)
		{
			vtkRenderView.vtkRenderView_SetLabelPlacementMode_41(base.GetCppThis(), mode);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderView_SetLabelPlacementModeToAll_42(HandleRef pThis);

		public virtual void SetLabelPlacementModeToAll()
		{
			vtkRenderView.vtkRenderView_SetLabelPlacementModeToAll_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderView_SetLabelPlacementModeToNoOverlap_43(HandleRef pThis);

		public virtual void SetLabelPlacementModeToNoOverlap()
		{
			vtkRenderView.vtkRenderView_SetLabelPlacementModeToNoOverlap_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderView_SetLabelRenderMode_44(HandleRef pThis, int mode);

		public virtual void SetLabelRenderMode(int mode)
		{
			vtkRenderView.vtkRenderView_SetLabelRenderMode_44(base.GetCppThis(), mode);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderView_SetLabelRenderModeToFreetype_45(HandleRef pThis);

		public virtual void SetLabelRenderModeToFreetype()
		{
			vtkRenderView.vtkRenderView_SetLabelRenderModeToFreetype_45(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderView_SetLabelRenderModeToQt_46(HandleRef pThis);

		public virtual void SetLabelRenderModeToQt()
		{
			vtkRenderView.vtkRenderView_SetLabelRenderModeToQt_46(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderView_SetRenderOnMouseMove_47(HandleRef pThis, byte b);

		public void SetRenderOnMouseMove(bool b)
		{
			vtkRenderView.vtkRenderView_SetRenderOnMouseMove_47(base.GetCppThis(), b ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderView_SetRenderWindow_48(HandleRef pThis, HandleRef win);

		public override void SetRenderWindow(vtkRenderWindow win)
		{
			vtkRenderView.vtkRenderView_SetRenderWindow_48(base.GetCppThis(), (win == null) ? default(HandleRef) : win.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderView_SetSelectionMode_49(HandleRef pThis, int _arg);

		public virtual void SetSelectionMode(int _arg)
		{
			vtkRenderView.vtkRenderView_SetSelectionMode_49(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderView_SetSelectionModeToFrustum_50(HandleRef pThis);

		public void SetSelectionModeToFrustum()
		{
			vtkRenderView.vtkRenderView_SetSelectionModeToFrustum_50(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderView_SetSelectionModeToSurface_51(HandleRef pThis);

		public void SetSelectionModeToSurface()
		{
			vtkRenderView.vtkRenderView_SetSelectionModeToSurface_51(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkViews.Unmanaged.dll")]
		internal static extern void vtkRenderView_SetTransform_52(HandleRef pThis, HandleRef transform);

		public virtual void SetTransform(vtkAbstractTransform transform)
		{
			vtkRenderView.vtkRenderView_SetTransform_52(base.GetCppThis(), (transform == null) ? default(HandleRef) : transform.GetCppThis());
		}
	}
}
