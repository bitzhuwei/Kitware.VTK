using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkAffineRepresentation2D : vtkAffineRepresentation
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkAffineRepresentation2D";

		public new static readonly string MRClassNameKey;

		static vtkAffineRepresentation2D()
		{
			vtkAffineRepresentation2D.MRClassNameKey = "class vtkAffineRepresentation2D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAffineRepresentation2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAffineRepresentation2D"));
		}

		public vtkAffineRepresentation2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAffineRepresentation2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAffineRepresentation2D New()
		{
			vtkAffineRepresentation2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAffineRepresentation2D.vtkAffineRepresentation2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAffineRepresentation2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkAffineRepresentation2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkAffineRepresentation2D.vtkAffineRepresentation2D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAffineRepresentation2D_BuildRepresentation_01(HandleRef pThis);

		public override void BuildRepresentation()
		{
			vtkAffineRepresentation2D.vtkAffineRepresentation2D_BuildRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAffineRepresentation2D_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkAffineRepresentation2D.vtkAffineRepresentation2D_ComputeInteractionState_02(base.GetCppThis(), X, Y, modify);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAffineRepresentation2D_DisplayTextOff_03(HandleRef pThis);

		public virtual void DisplayTextOff()
		{
			vtkAffineRepresentation2D.vtkAffineRepresentation2D_DisplayTextOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAffineRepresentation2D_DisplayTextOn_04(HandleRef pThis);

		public virtual void DisplayTextOn()
		{
			vtkAffineRepresentation2D.vtkAffineRepresentation2D_DisplayTextOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAffineRepresentation2D_EndWidgetInteraction_05(HandleRef pThis, IntPtr eventPos);

		public override void EndWidgetInteraction(IntPtr eventPos)
		{
			vtkAffineRepresentation2D.vtkAffineRepresentation2D_EndWidgetInteraction_05(base.GetCppThis(), eventPos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAffineRepresentation2D_GetActors2D_06(HandleRef pThis, HandleRef arg0);

		public override void GetActors2D(vtkPropCollection arg0)
		{
			vtkAffineRepresentation2D.vtkAffineRepresentation2D_GetActors2D_06(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAffineRepresentation2D_GetAxesWidth_07(HandleRef pThis);

		public virtual int GetAxesWidth()
		{
			return vtkAffineRepresentation2D.vtkAffineRepresentation2D_GetAxesWidth_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAffineRepresentation2D_GetAxesWidthMaxValue_08(HandleRef pThis);

		public virtual int GetAxesWidthMaxValue()
		{
			return vtkAffineRepresentation2D.vtkAffineRepresentation2D_GetAxesWidthMaxValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAffineRepresentation2D_GetAxesWidthMinValue_09(HandleRef pThis);

		public virtual int GetAxesWidthMinValue()
		{
			return vtkAffineRepresentation2D.vtkAffineRepresentation2D_GetAxesWidthMinValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAffineRepresentation2D_GetBoxWidth_10(HandleRef pThis);

		public virtual int GetBoxWidth()
		{
			return vtkAffineRepresentation2D.vtkAffineRepresentation2D_GetBoxWidth_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAffineRepresentation2D_GetBoxWidthMaxValue_11(HandleRef pThis);

		public virtual int GetBoxWidthMaxValue()
		{
			return vtkAffineRepresentation2D.vtkAffineRepresentation2D_GetBoxWidthMaxValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAffineRepresentation2D_GetBoxWidthMinValue_12(HandleRef pThis);

		public virtual int GetBoxWidthMinValue()
		{
			return vtkAffineRepresentation2D.vtkAffineRepresentation2D_GetBoxWidthMinValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAffineRepresentation2D_GetCircleWidth_13(HandleRef pThis);

		public virtual int GetCircleWidth()
		{
			return vtkAffineRepresentation2D.vtkAffineRepresentation2D_GetCircleWidth_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAffineRepresentation2D_GetCircleWidthMaxValue_14(HandleRef pThis);

		public virtual int GetCircleWidthMaxValue()
		{
			return vtkAffineRepresentation2D.vtkAffineRepresentation2D_GetCircleWidthMaxValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAffineRepresentation2D_GetCircleWidthMinValue_15(HandleRef pThis);

		public virtual int GetCircleWidthMinValue()
		{
			return vtkAffineRepresentation2D.vtkAffineRepresentation2D_GetCircleWidthMinValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAffineRepresentation2D_GetDisplayText_16(HandleRef pThis);

		public virtual int GetDisplayText()
		{
			return vtkAffineRepresentation2D.vtkAffineRepresentation2D_GetDisplayText_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAffineRepresentation2D_GetOrigin_17(HandleRef pThis);

		public virtual double[] GetOrigin()
		{
			IntPtr intPtr = vtkAffineRepresentation2D.vtkAffineRepresentation2D_GetOrigin_17(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAffineRepresentation2D_GetOrigin_18(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkAffineRepresentation2D.vtkAffineRepresentation2D_GetOrigin_18(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAffineRepresentation2D_GetOrigin_19(HandleRef pThis, IntPtr _arg);

		public virtual void GetOrigin(IntPtr _arg)
		{
			vtkAffineRepresentation2D.vtkAffineRepresentation2D_GetOrigin_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAffineRepresentation2D_GetProperty_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty2D GetProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAffineRepresentation2D.vtkAffineRepresentation2D_GetProperty_20(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkAffineRepresentation2D_GetSelectedProperty_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty2D GetSelectedProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAffineRepresentation2D.vtkAffineRepresentation2D_GetSelectedProperty_21(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkAffineRepresentation2D_GetTextProperty_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAffineRepresentation2D.vtkAffineRepresentation2D_GetTextProperty_22(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkAffineRepresentation2D_GetTransform_23(HandleRef pThis, HandleRef t);

		public override void GetTransform(vtkTransform t)
		{
			vtkAffineRepresentation2D.vtkAffineRepresentation2D_GetTransform_23(base.GetCppThis(), (t == null) ? default(HandleRef) : t.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAffineRepresentation2D_IsA_24(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAffineRepresentation2D.vtkAffineRepresentation2D_IsA_24(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAffineRepresentation2D_IsTypeOf_25(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAffineRepresentation2D.vtkAffineRepresentation2D_IsTypeOf_25(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAffineRepresentation2D_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAffineRepresentation2D NewInstance()
		{
			vtkAffineRepresentation2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAffineRepresentation2D.vtkAffineRepresentation2D_NewInstance_27(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAffineRepresentation2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAffineRepresentation2D_PlaceWidget_28(HandleRef pThis, IntPtr bounds);

		public override void PlaceWidget(IntPtr bounds)
		{
			vtkAffineRepresentation2D.vtkAffineRepresentation2D_PlaceWidget_28(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAffineRepresentation2D_ReleaseGraphicsResources_29(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkAffineRepresentation2D.vtkAffineRepresentation2D_ReleaseGraphicsResources_29(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAffineRepresentation2D_RenderOverlay_30(HandleRef pThis, HandleRef viewport);

		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkAffineRepresentation2D.vtkAffineRepresentation2D_RenderOverlay_30(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAffineRepresentation2D_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAffineRepresentation2D SafeDownCast(vtkObjectBase o)
		{
			vtkAffineRepresentation2D vtkAffineRepresentation2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAffineRepresentation2D.vtkAffineRepresentation2D_SafeDownCast_31((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAffineRepresentation2D = (vtkAffineRepresentation2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAffineRepresentation2D.Register(null);
				}
			}
			return vtkAffineRepresentation2D;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAffineRepresentation2D_SetAxesWidth_32(HandleRef pThis, int _arg);

		public virtual void SetAxesWidth(int _arg)
		{
			vtkAffineRepresentation2D.vtkAffineRepresentation2D_SetAxesWidth_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAffineRepresentation2D_SetBoxWidth_33(HandleRef pThis, int _arg);

		public virtual void SetBoxWidth(int _arg)
		{
			vtkAffineRepresentation2D.vtkAffineRepresentation2D_SetBoxWidth_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAffineRepresentation2D_SetCircleWidth_34(HandleRef pThis, int _arg);

		public virtual void SetCircleWidth(int _arg)
		{
			vtkAffineRepresentation2D.vtkAffineRepresentation2D_SetCircleWidth_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAffineRepresentation2D_SetDisplayText_35(HandleRef pThis, int _arg);

		public virtual void SetDisplayText(int _arg)
		{
			vtkAffineRepresentation2D.vtkAffineRepresentation2D_SetDisplayText_35(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAffineRepresentation2D_SetOrigin_36(HandleRef pThis, IntPtr o);

		public void SetOrigin(IntPtr o)
		{
			vtkAffineRepresentation2D.vtkAffineRepresentation2D_SetOrigin_36(base.GetCppThis(), o);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAffineRepresentation2D_SetOrigin_37(HandleRef pThis, double ox, double oy, double oz);

		public void SetOrigin(double ox, double oy, double oz)
		{
			vtkAffineRepresentation2D.vtkAffineRepresentation2D_SetOrigin_37(base.GetCppThis(), ox, oy, oz);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAffineRepresentation2D_SetProperty_38(HandleRef pThis, HandleRef arg0);

		public void SetProperty(vtkProperty2D arg0)
		{
			vtkAffineRepresentation2D.vtkAffineRepresentation2D_SetProperty_38(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAffineRepresentation2D_SetSelectedProperty_39(HandleRef pThis, HandleRef arg0);

		public void SetSelectedProperty(vtkProperty2D arg0)
		{
			vtkAffineRepresentation2D.vtkAffineRepresentation2D_SetSelectedProperty_39(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAffineRepresentation2D_SetTextProperty_40(HandleRef pThis, HandleRef arg0);

		public void SetTextProperty(vtkTextProperty arg0)
		{
			vtkAffineRepresentation2D.vtkAffineRepresentation2D_SetTextProperty_40(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAffineRepresentation2D_ShallowCopy_41(HandleRef pThis, HandleRef prop);

		public override void ShallowCopy(vtkProp prop)
		{
			vtkAffineRepresentation2D.vtkAffineRepresentation2D_ShallowCopy_41(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAffineRepresentation2D_StartWidgetInteraction_42(HandleRef pThis, IntPtr eventPos);

		public override void StartWidgetInteraction(IntPtr eventPos)
		{
			vtkAffineRepresentation2D.vtkAffineRepresentation2D_StartWidgetInteraction_42(base.GetCppThis(), eventPos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAffineRepresentation2D_WidgetInteraction_43(HandleRef pThis, IntPtr eventPos);

		public override void WidgetInteraction(IntPtr eventPos)
		{
			vtkAffineRepresentation2D.vtkAffineRepresentation2D_WidgetInteraction_43(base.GetCppThis(), eventPos);
		}
	}
}
