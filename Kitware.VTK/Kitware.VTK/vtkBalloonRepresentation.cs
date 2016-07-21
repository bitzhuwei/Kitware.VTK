using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkBalloonRepresentation : vtkWidgetRepresentation
	{
		public enum ImageBottom_WrapperEnum
		{
			ImageBottom = 2,
			ImageLeft = 0,
			ImageRight,
			ImageTop = 3
		}

		public enum _InteractionState
		{
			OnImage = 2,
			OnText = 1,
			Outside = 0
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkBalloonRepresentation";

		public new static readonly string MRClassNameKey;

		static vtkBalloonRepresentation()
		{
			vtkBalloonRepresentation.MRClassNameKey = "class vtkBalloonRepresentation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBalloonRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBalloonRepresentation"));
		}

		public vtkBalloonRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBalloonRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBalloonRepresentation New()
		{
			vtkBalloonRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBalloonRepresentation.vtkBalloonRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBalloonRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkBalloonRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkBalloonRepresentation.vtkBalloonRepresentation_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBalloonRepresentation_BuildRepresentation_01(HandleRef pThis);

		public override void BuildRepresentation()
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBalloonRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkBalloonRepresentation.vtkBalloonRepresentation_ComputeInteractionState_02(base.GetCppThis(), X, Y, modify);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBalloonRepresentation_EndWidgetInteraction_03(HandleRef pThis, IntPtr e);

		public override void EndWidgetInteraction(IntPtr e)
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_EndWidgetInteraction_03(base.GetCppThis(), e);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBalloonRepresentation_GetBalloonImage_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImageData GetBalloonImage()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBalloonRepresentation.vtkBalloonRepresentation_GetBalloonImage_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBalloonRepresentation_GetBalloonLayout_05(HandleRef pThis);

		public virtual int GetBalloonLayout()
		{
			return vtkBalloonRepresentation.vtkBalloonRepresentation_GetBalloonLayout_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBalloonRepresentation_GetBalloonText_06(HandleRef pThis);

		public virtual string GetBalloonText()
		{
			return Marshal.PtrToStringAnsi(vtkBalloonRepresentation.vtkBalloonRepresentation_GetBalloonText_06(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBalloonRepresentation_GetFrameProperty_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty2D GetFrameProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBalloonRepresentation.vtkBalloonRepresentation_GetFrameProperty_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty2D = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty2D.Register(null);
				}
			}
			return vtkProperty2D;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBalloonRepresentation_GetImageProperty_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty2D GetImageProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBalloonRepresentation.vtkBalloonRepresentation_GetImageProperty_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty2D = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty2D.Register(null);
				}
			}
			return vtkProperty2D;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBalloonRepresentation_GetImageSize_09(HandleRef pThis);

		public virtual int[] GetImageSize()
		{
			IntPtr intPtr = vtkBalloonRepresentation.vtkBalloonRepresentation_GetImageSize_09(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBalloonRepresentation_GetImageSize_10(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetImageSize(ref int _arg1, ref int _arg2)
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_GetImageSize_10(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBalloonRepresentation_GetImageSize_11(HandleRef pThis, IntPtr _arg);

		public virtual void GetImageSize(IntPtr _arg)
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_GetImageSize_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBalloonRepresentation_GetOffset_12(HandleRef pThis);

		public virtual int[] GetOffset()
		{
			IntPtr intPtr = vtkBalloonRepresentation.vtkBalloonRepresentation_GetOffset_12(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBalloonRepresentation_GetOffset_13(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetOffset(ref int _arg1, ref int _arg2)
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_GetOffset_13(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBalloonRepresentation_GetOffset_14(HandleRef pThis, IntPtr _arg);

		public virtual void GetOffset(IntPtr _arg)
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_GetOffset_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBalloonRepresentation_GetPadding_15(HandleRef pThis);

		public virtual int GetPadding()
		{
			return vtkBalloonRepresentation.vtkBalloonRepresentation_GetPadding_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBalloonRepresentation_GetPaddingMaxValue_16(HandleRef pThis);

		public virtual int GetPaddingMaxValue()
		{
			return vtkBalloonRepresentation.vtkBalloonRepresentation_GetPaddingMaxValue_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBalloonRepresentation_GetPaddingMinValue_17(HandleRef pThis);

		public virtual int GetPaddingMinValue()
		{
			return vtkBalloonRepresentation.vtkBalloonRepresentation_GetPaddingMinValue_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBalloonRepresentation_GetTextProperty_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBalloonRepresentation.vtkBalloonRepresentation_GetTextProperty_18(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBalloonRepresentation_IsA_19(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkBalloonRepresentation.vtkBalloonRepresentation_IsA_19(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBalloonRepresentation_IsTypeOf_20(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkBalloonRepresentation.vtkBalloonRepresentation_IsTypeOf_20(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBalloonRepresentation_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkBalloonRepresentation NewInstance()
		{
			vtkBalloonRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBalloonRepresentation.vtkBalloonRepresentation_NewInstance_22(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBalloonRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBalloonRepresentation_ReleaseGraphicsResources_23(HandleRef pThis, HandleRef w);

		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_ReleaseGraphicsResources_23(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBalloonRepresentation_RenderOverlay_24(HandleRef pThis, HandleRef viewport);

		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkBalloonRepresentation.vtkBalloonRepresentation_RenderOverlay_24(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBalloonRepresentation_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBalloonRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkBalloonRepresentation vtkBalloonRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBalloonRepresentation.vtkBalloonRepresentation_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBalloonRepresentation = (vtkBalloonRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBalloonRepresentation.Register(null);
				}
			}
			return vtkBalloonRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBalloonRepresentation_SetBalloonImage_26(HandleRef pThis, HandleRef img);

		public virtual void SetBalloonImage(vtkImageData img)
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_SetBalloonImage_26(base.GetCppThis(), (img == null) ? default(HandleRef) : img.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBalloonRepresentation_SetBalloonLayout_27(HandleRef pThis, int _arg);

		public virtual void SetBalloonLayout(int _arg)
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_SetBalloonLayout_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBalloonRepresentation_SetBalloonLayoutToImageBottom_28(HandleRef pThis);

		public void SetBalloonLayoutToImageBottom()
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_SetBalloonLayoutToImageBottom_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBalloonRepresentation_SetBalloonLayoutToImageLeft_29(HandleRef pThis);

		public void SetBalloonLayoutToImageLeft()
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_SetBalloonLayoutToImageLeft_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBalloonRepresentation_SetBalloonLayoutToImageRight_30(HandleRef pThis);

		public void SetBalloonLayoutToImageRight()
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_SetBalloonLayoutToImageRight_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBalloonRepresentation_SetBalloonLayoutToImageTop_31(HandleRef pThis);

		public void SetBalloonLayoutToImageTop()
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_SetBalloonLayoutToImageTop_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBalloonRepresentation_SetBalloonLayoutToTextBottom_32(HandleRef pThis);

		public void SetBalloonLayoutToTextBottom()
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_SetBalloonLayoutToTextBottom_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBalloonRepresentation_SetBalloonLayoutToTextLeft_33(HandleRef pThis);

		public void SetBalloonLayoutToTextLeft()
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_SetBalloonLayoutToTextLeft_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBalloonRepresentation_SetBalloonLayoutToTextRight_34(HandleRef pThis);

		public void SetBalloonLayoutToTextRight()
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_SetBalloonLayoutToTextRight_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBalloonRepresentation_SetBalloonLayoutToTextTop_35(HandleRef pThis);

		public void SetBalloonLayoutToTextTop()
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_SetBalloonLayoutToTextTop_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBalloonRepresentation_SetBalloonText_36(HandleRef pThis, string _arg);

		public virtual void SetBalloonText(string _arg)
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_SetBalloonText_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBalloonRepresentation_SetFrameProperty_37(HandleRef pThis, HandleRef p);

		public virtual void SetFrameProperty(vtkProperty2D p)
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_SetFrameProperty_37(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBalloonRepresentation_SetImageProperty_38(HandleRef pThis, HandleRef p);

		public virtual void SetImageProperty(vtkProperty2D p)
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_SetImageProperty_38(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBalloonRepresentation_SetImageSize_39(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetImageSize(int _arg1, int _arg2)
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_SetImageSize_39(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBalloonRepresentation_SetImageSize_40(HandleRef pThis, IntPtr _arg);

		public void SetImageSize(IntPtr _arg)
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_SetImageSize_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBalloonRepresentation_SetOffset_41(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetOffset(int _arg1, int _arg2)
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_SetOffset_41(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBalloonRepresentation_SetOffset_42(HandleRef pThis, IntPtr _arg);

		public void SetOffset(IntPtr _arg)
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_SetOffset_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBalloonRepresentation_SetPadding_43(HandleRef pThis, int _arg);

		public virtual void SetPadding(int _arg)
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_SetPadding_43(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBalloonRepresentation_SetTextProperty_44(HandleRef pThis, HandleRef p);

		public virtual void SetTextProperty(vtkTextProperty p)
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_SetTextProperty_44(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBalloonRepresentation_StartWidgetInteraction_45(HandleRef pThis, IntPtr e);

		public override void StartWidgetInteraction(IntPtr e)
		{
			vtkBalloonRepresentation.vtkBalloonRepresentation_StartWidgetInteraction_45(base.GetCppThis(), e);
		}
	}
}
