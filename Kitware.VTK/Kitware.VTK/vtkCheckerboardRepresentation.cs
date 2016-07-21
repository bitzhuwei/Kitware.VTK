using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCheckerboardRepresentation : vtkWidgetRepresentation
	{
		public enum BottomSlider_WrapperEnum
		{
			BottomSlider = 2,
			LeftSlider,
			RightSlider = 1,
			TopSlider = 0
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkCheckerboardRepresentation";

		public new static readonly string MRClassNameKey;

		static vtkCheckerboardRepresentation()
		{
			vtkCheckerboardRepresentation.MRClassNameKey = "class vtkCheckerboardRepresentation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCheckerboardRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCheckerboardRepresentation"));
		}

		public vtkCheckerboardRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkCheckerboardRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCheckerboardRepresentation New()
		{
			vtkCheckerboardRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCheckerboardRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCheckerboardRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkCheckerboardRepresentation_BuildRepresentation_01(HandleRef pThis);

		public override void BuildRepresentation()
		{
			vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkCheckerboardRepresentation_GetActors_02(HandleRef pThis, HandleRef arg0);

		public override void GetActors(vtkPropCollection arg0)
		{
			vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_GetActors_02(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkCheckerboardRepresentation_GetBottomRepresentation_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkSliderRepresentation3D GetBottomRepresentation()
		{
			vtkSliderRepresentation3D vtkSliderRepresentation3D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_GetBottomRepresentation_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSliderRepresentation3D = (vtkSliderRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSliderRepresentation3D.Register(null);
				}
			}
			return vtkSliderRepresentation3D;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkCheckerboardRepresentation_GetCheckerboard_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImageCheckerboard GetCheckerboard()
		{
			vtkImageCheckerboard vtkImageCheckerboard = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_GetCheckerboard_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageCheckerboard = (vtkImageCheckerboard)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageCheckerboard.Register(null);
				}
			}
			return vtkImageCheckerboard;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkCheckerboardRepresentation_GetCornerOffset_05(HandleRef pThis);

		public virtual double GetCornerOffset()
		{
			return vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_GetCornerOffset_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkCheckerboardRepresentation_GetCornerOffsetMaxValue_06(HandleRef pThis);

		public virtual double GetCornerOffsetMaxValue()
		{
			return vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_GetCornerOffsetMaxValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkCheckerboardRepresentation_GetCornerOffsetMinValue_07(HandleRef pThis);

		public virtual double GetCornerOffsetMinValue()
		{
			return vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_GetCornerOffsetMinValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkCheckerboardRepresentation_GetImageActor_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImageActor GetImageActor()
		{
			vtkImageActor vtkImageActor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_GetImageActor_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageActor = (vtkImageActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageActor.Register(null);
				}
			}
			return vtkImageActor;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkCheckerboardRepresentation_GetLeftRepresentation_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkSliderRepresentation3D GetLeftRepresentation()
		{
			vtkSliderRepresentation3D vtkSliderRepresentation3D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_GetLeftRepresentation_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSliderRepresentation3D = (vtkSliderRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSliderRepresentation3D.Register(null);
				}
			}
			return vtkSliderRepresentation3D;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkCheckerboardRepresentation_GetRightRepresentation_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkSliderRepresentation3D GetRightRepresentation()
		{
			vtkSliderRepresentation3D vtkSliderRepresentation3D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_GetRightRepresentation_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSliderRepresentation3D = (vtkSliderRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSliderRepresentation3D.Register(null);
				}
			}
			return vtkSliderRepresentation3D;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkCheckerboardRepresentation_GetTopRepresentation_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkSliderRepresentation3D GetTopRepresentation()
		{
			vtkSliderRepresentation3D vtkSliderRepresentation3D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_GetTopRepresentation_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSliderRepresentation3D = (vtkSliderRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSliderRepresentation3D.Register(null);
				}
			}
			return vtkSliderRepresentation3D;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkCheckerboardRepresentation_HasTranslucentPolygonalGeometry_12(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_HasTranslucentPolygonalGeometry_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkCheckerboardRepresentation_IsA_13(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_IsA_13(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkCheckerboardRepresentation_IsTypeOf_14(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_IsTypeOf_14(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkCheckerboardRepresentation_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCheckerboardRepresentation NewInstance()
		{
			vtkCheckerboardRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_NewInstance_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCheckerboardRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkCheckerboardRepresentation_ReleaseGraphicsResources_17(HandleRef pThis, HandleRef w);

		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_ReleaseGraphicsResources_17(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkCheckerboardRepresentation_RenderOpaqueGeometry_18(HandleRef pThis, HandleRef viewport);

		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_RenderOpaqueGeometry_18(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkCheckerboardRepresentation_RenderOverlay_19(HandleRef pThis, HandleRef viewport);

		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_RenderOverlay_19(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkCheckerboardRepresentation_RenderTranslucentPolygonalGeometry_20(HandleRef pThis, HandleRef viewport);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_RenderTranslucentPolygonalGeometry_20(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkCheckerboardRepresentation_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCheckerboardRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkCheckerboardRepresentation vtkCheckerboardRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCheckerboardRepresentation = (vtkCheckerboardRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCheckerboardRepresentation.Register(null);
				}
			}
			return vtkCheckerboardRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkCheckerboardRepresentation_SetBottomRepresentation_22(HandleRef pThis, HandleRef arg0);

		public void SetBottomRepresentation(vtkSliderRepresentation3D arg0)
		{
			vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_SetBottomRepresentation_22(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkCheckerboardRepresentation_SetCheckerboard_23(HandleRef pThis, HandleRef chkrbrd);

		public void SetCheckerboard(vtkImageCheckerboard chkrbrd)
		{
			vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_SetCheckerboard_23(base.GetCppThis(), (chkrbrd == null) ? default(HandleRef) : chkrbrd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkCheckerboardRepresentation_SetCornerOffset_24(HandleRef pThis, double _arg);

		public virtual void SetCornerOffset(double _arg)
		{
			vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_SetCornerOffset_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkCheckerboardRepresentation_SetImageActor_25(HandleRef pThis, HandleRef imageActor);

		public void SetImageActor(vtkImageActor imageActor)
		{
			vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_SetImageActor_25(base.GetCppThis(), (imageActor == null) ? default(HandleRef) : imageActor.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkCheckerboardRepresentation_SetLeftRepresentation_26(HandleRef pThis, HandleRef arg0);

		public void SetLeftRepresentation(vtkSliderRepresentation3D arg0)
		{
			vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_SetLeftRepresentation_26(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkCheckerboardRepresentation_SetRightRepresentation_27(HandleRef pThis, HandleRef arg0);

		public void SetRightRepresentation(vtkSliderRepresentation3D arg0)
		{
			vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_SetRightRepresentation_27(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkCheckerboardRepresentation_SetTopRepresentation_28(HandleRef pThis, HandleRef arg0);

		public void SetTopRepresentation(vtkSliderRepresentation3D arg0)
		{
			vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_SetTopRepresentation_28(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkCheckerboardRepresentation_SliderValueChanged_29(HandleRef pThis, int sliderNum);

		public void SliderValueChanged(int sliderNum)
		{
			vtkCheckerboardRepresentation.vtkCheckerboardRepresentation_SliderValueChanged_29(base.GetCppThis(), sliderNum);
		}
	}
}
