using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkAbstractPolygonalHandleRepresentation3D : vtkHandleRepresentation
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractPolygonalHandleRepresentation3D";

		public new static readonly string MRClassNameKey;

		static vtkAbstractPolygonalHandleRepresentation3D()
		{
			vtkAbstractPolygonalHandleRepresentation3D.MRClassNameKey = "class vtkAbstractPolygonalHandleRepresentation3D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAbstractPolygonalHandleRepresentation3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractPolygonalHandleRepresentation3D"));
		}

		public vtkAbstractPolygonalHandleRepresentation3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_BuildRepresentation_01(HandleRef pThis);

		public override void BuildRepresentation()
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_BuildRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAbstractPolygonalHandleRepresentation3D_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_ComputeInteractionState_02(base.GetCppThis(), X, Y, modify);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_DeepCopy_03(HandleRef pThis, HandleRef prop);

		public override void DeepCopy(vtkProp prop)
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_DeepCopy_03(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_GetActors_04(HandleRef pThis, HandleRef arg0);

		public override void GetActors(vtkPropCollection arg0)
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_GetActors_04(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractPolygonalHandleRepresentation3D_GetBounds_05(HandleRef pThis);

		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_GetBounds_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractPolygonalHandleRepresentation3D_GetHandle_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPolyData GetHandle()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_GetHandle_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAbstractPolygonalHandleRepresentation3D_GetHandleVisibility_07(HandleRef pThis);

		public virtual int GetHandleVisibility()
		{
			return vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_GetHandleVisibility_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractPolygonalHandleRepresentation3D_GetLabelText_08(HandleRef pThis);

		public virtual string GetLabelText()
		{
			return Marshal.PtrToStringAnsi(vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_GetLabelText_08(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractPolygonalHandleRepresentation3D_GetLabelTextActor_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkFollower GetLabelTextActor()
		{
			vtkFollower vtkFollower = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_GetLabelTextActor_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFollower = (vtkFollower)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFollower.Register(null);
				}
			}
			return vtkFollower;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractPolygonalHandleRepresentation3D_GetLabelTextScale_10(HandleRef pThis);

		public virtual IntPtr GetLabelTextScale()
		{
			return vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_GetLabelTextScale_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAbstractPolygonalHandleRepresentation3D_GetLabelVisibility_11(HandleRef pThis);

		public virtual int GetLabelVisibility()
		{
			return vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_GetLabelVisibility_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractPolygonalHandleRepresentation3D_GetProperty_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_GetProperty_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractPolygonalHandleRepresentation3D_GetSelectedProperty_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetSelectedProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_GetSelectedProperty_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractPolygonalHandleRepresentation3D_GetTransform_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAbstractTransform GetTransform()
		{
			vtkAbstractTransform vtkAbstractTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_GetTransform_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_HandleVisibilityOff_15(HandleRef pThis);

		public virtual void HandleVisibilityOff()
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_HandleVisibilityOff_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_HandleVisibilityOn_16(HandleRef pThis);

		public virtual void HandleVisibilityOn()
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_HandleVisibilityOn_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAbstractPolygonalHandleRepresentation3D_HasTranslucentPolygonalGeometry_17(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_HasTranslucentPolygonalGeometry_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_Highlight_18(HandleRef pThis, int highlight);

		public override void Highlight(int highlight)
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_Highlight_18(base.GetCppThis(), highlight);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAbstractPolygonalHandleRepresentation3D_IsA_19(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_IsA_19(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAbstractPolygonalHandleRepresentation3D_IsTypeOf_20(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_IsTypeOf_20(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_LabelVisibilityOff_21(HandleRef pThis);

		public virtual void LabelVisibilityOff()
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_LabelVisibilityOff_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_LabelVisibilityOn_22(HandleRef pThis);

		public virtual void LabelVisibilityOn()
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_LabelVisibilityOn_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractPolygonalHandleRepresentation3D_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAbstractPolygonalHandleRepresentation3D NewInstance()
		{
			vtkAbstractPolygonalHandleRepresentation3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_NewInstance_23(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractPolygonalHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_ReleaseGraphicsResources_24(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_ReleaseGraphicsResources_24(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAbstractPolygonalHandleRepresentation3D_RenderOpaqueGeometry_25(HandleRef pThis, HandleRef viewport);

		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_RenderOpaqueGeometry_25(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAbstractPolygonalHandleRepresentation3D_RenderTranslucentPolygonalGeometry_26(HandleRef pThis, HandleRef viewport);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_RenderTranslucentPolygonalGeometry_26(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractPolygonalHandleRepresentation3D_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAbstractPolygonalHandleRepresentation3D SafeDownCast(vtkObjectBase o)
		{
			vtkAbstractPolygonalHandleRepresentation3D vtkAbstractPolygonalHandleRepresentation3D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractPolygonalHandleRepresentation3D = (vtkAbstractPolygonalHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractPolygonalHandleRepresentation3D.Register(null);
				}
			}
			return vtkAbstractPolygonalHandleRepresentation3D;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_SetDisplayPosition_28(HandleRef pThis, IntPtr p);

		public override void SetDisplayPosition(IntPtr p)
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_SetDisplayPosition_28(base.GetCppThis(), p);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_SetHandle_29(HandleRef pThis, HandleRef arg0);

		public void SetHandle(vtkPolyData arg0)
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_SetHandle_29(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_SetHandleVisibility_30(HandleRef pThis, int _arg);

		public virtual void SetHandleVisibility(int _arg)
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_SetHandleVisibility_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_SetLabelText_31(HandleRef pThis, string label);

		public virtual void SetLabelText(string label)
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_SetLabelText_31(base.GetCppThis(), label);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_SetLabelTextScale_32(HandleRef pThis, IntPtr scale);

		public virtual void SetLabelTextScale(IntPtr scale)
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_SetLabelTextScale_32(base.GetCppThis(), scale);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_SetLabelTextScale_33(HandleRef pThis, double x, double y, double z);

		public void SetLabelTextScale(double x, double y, double z)
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_SetLabelTextScale_33(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_SetLabelVisibility_34(HandleRef pThis, int _arg);

		public virtual void SetLabelVisibility(int _arg)
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_SetLabelVisibility_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_SetProperty_35(HandleRef pThis, HandleRef arg0);

		public void SetProperty(vtkProperty arg0)
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_SetProperty_35(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_SetSelectedProperty_36(HandleRef pThis, HandleRef arg0);

		public void SetSelectedProperty(vtkProperty arg0)
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_SetSelectedProperty_36(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_SetUniformScale_37(HandleRef pThis, double scale);

		public virtual void SetUniformScale(double scale)
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_SetUniformScale_37(base.GetCppThis(), scale);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_SetWorldPosition_38(HandleRef pThis, IntPtr p);

		public override void SetWorldPosition(IntPtr p)
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_SetWorldPosition_38(base.GetCppThis(), p);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_ShallowCopy_39(HandleRef pThis, HandleRef prop);

		public override void ShallowCopy(vtkProp prop)
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_ShallowCopy_39(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_StartWidgetInteraction_40(HandleRef pThis, IntPtr eventPos);

		public override void StartWidgetInteraction(IntPtr eventPos)
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_StartWidgetInteraction_40(base.GetCppThis(), eventPos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAbstractPolygonalHandleRepresentation3D_WidgetInteraction_41(HandleRef pThis, IntPtr eventPos);

		public override void WidgetInteraction(IntPtr eventPos)
		{
			vtkAbstractPolygonalHandleRepresentation3D.vtkAbstractPolygonalHandleRepresentation3D_WidgetInteraction_41(base.GetCppThis(), eventPos);
		}
	}
}
