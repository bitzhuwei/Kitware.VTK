using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkParallelopipedRepresentation : vtkWidgetRepresentation
	{
		public enum _InteractionState
		{
			ChairMode = 10,
			Inside = 1,
			Outside = 0,
			RequestChairMode = 4,
			RequestResizeParallelopiped = 2,
			RequestResizeParallelopipedAlongAnAxis,
			RequestRotateParallelopiped = 7,
			RequestScaleParallelopiped = 6,
			RequestTranslateParallelopiped = 5,
			ResizingParallelopiped = 8,
			ResizingParallelopipedAlongAnAxis,
			RotatingParallelopiped = 13,
			ScalingParallelopiped = 12,
			TranslatingParallelopiped = 11
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkParallelopipedRepresentation";

		public new static readonly string MRClassNameKey;

		static vtkParallelopipedRepresentation()
		{
			vtkParallelopipedRepresentation.MRClassNameKey = "class vtkParallelopipedRepresentation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParallelopipedRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParallelopipedRepresentation"));
		}

		public vtkParallelopipedRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelopipedRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkParallelopipedRepresentation New()
		{
			vtkParallelopipedRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParallelopipedRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkParallelopipedRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkParallelopipedRepresentation_BuildRepresentation_01(HandleRef pThis);

		public override void BuildRepresentation()
		{
			vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkParallelopipedRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_ComputeInteractionState_02(base.GetCppThis(), X, Y, modify);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkParallelopipedRepresentation_GetActors_03(HandleRef pThis, HandleRef pc);

		public override void GetActors(vtkPropCollection pc)
		{
			vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_GetActors_03(base.GetCppThis(), (pc == null) ? default(HandleRef) : pc.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkParallelopipedRepresentation_GetBoundingPlanes_04(HandleRef pThis, HandleRef pc);

		public void GetBoundingPlanes(vtkPlaneCollection pc)
		{
			vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_GetBoundingPlanes_04(base.GetCppThis(), (pc == null) ? default(HandleRef) : pc.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelopipedRepresentation_GetBounds_05(HandleRef pThis);

		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_GetBounds_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelopipedRepresentation_GetFaceProperty_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetFaceProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_GetFaceProperty_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkParallelopipedRepresentation_GetHandleProperty_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetHandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_GetHandleProperty_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkParallelopipedRepresentation_GetHandleRepresentation_08(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkHandleRepresentation GetHandleRepresentation(int index)
		{
			vtkHandleRepresentation vtkHandleRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_GetHandleRepresentation_08(base.GetCppThis(), index, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHandleRepresentation = (vtkHandleRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHandleRepresentation.Register(null);
				}
			}
			return vtkHandleRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelopipedRepresentation_GetHoveredHandleProperty_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetHoveredHandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_GetHoveredHandleProperty_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern double vtkParallelopipedRepresentation_GetMinimumThickness_10(HandleRef pThis);

		public virtual double GetMinimumThickness()
		{
			return vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_GetMinimumThickness_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelopipedRepresentation_GetOutlineProperty_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetOutlineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_GetOutlineProperty_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkParallelopipedRepresentation_GetPolyData_12(HandleRef pThis, HandleRef pd);

		public void GetPolyData(vtkPolyData pd)
		{
			vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_GetPolyData_12(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelopipedRepresentation_GetSelectedFaceProperty_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetSelectedFaceProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_GetSelectedFaceProperty_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkParallelopipedRepresentation_GetSelectedHandleProperty_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetSelectedHandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_GetSelectedHandleProperty_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkParallelopipedRepresentation_GetSelectedOutlineProperty_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetSelectedOutlineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_GetSelectedOutlineProperty_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkParallelopipedRepresentation_HandlesOff_16(HandleRef pThis);

		public void HandlesOff()
		{
			vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_HandlesOff_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkParallelopipedRepresentation_HandlesOn_17(HandleRef pThis);

		public void HandlesOn()
		{
			vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_HandlesOn_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkParallelopipedRepresentation_IsA_18(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_IsA_18(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkParallelopipedRepresentation_IsTypeOf_19(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_IsTypeOf_19(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelopipedRepresentation_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkParallelopipedRepresentation NewInstance()
		{
			vtkParallelopipedRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_NewInstance_21(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParallelopipedRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkParallelopipedRepresentation_PlaceWidget_22(HandleRef pThis, IntPtr bounds);

		public override void PlaceWidget(IntPtr bounds)
		{
			vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_PlaceWidget_22(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkParallelopipedRepresentation_PositionHandles_23(HandleRef pThis);

		public virtual void PositionHandles()
		{
			vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_PositionHandles_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkParallelopipedRepresentation_ReleaseGraphicsResources_24(HandleRef pThis, HandleRef w);

		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_ReleaseGraphicsResources_24(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkParallelopipedRepresentation_RenderOpaqueGeometry_25(HandleRef pThis, HandleRef viewport);

		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_RenderOpaqueGeometry_25(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkParallelopipedRepresentation_RenderOverlay_26(HandleRef pThis, HandleRef viewport);

		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_RenderOverlay_26(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelopipedRepresentation_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkParallelopipedRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkParallelopipedRepresentation vtkParallelopipedRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParallelopipedRepresentation = (vtkParallelopipedRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParallelopipedRepresentation.Register(null);
				}
			}
			return vtkParallelopipedRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkParallelopipedRepresentation_Scale_28(HandleRef pThis, int X, int Y);

		public virtual void Scale(int X, int Y)
		{
			vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_Scale_28(base.GetCppThis(), X, Y);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkParallelopipedRepresentation_SetHandleProperty_29(HandleRef pThis, HandleRef arg0);

		public virtual void SetHandleProperty(vtkProperty arg0)
		{
			vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_SetHandleProperty_29(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkParallelopipedRepresentation_SetHandleRepresentation_30(HandleRef pThis, HandleRef handle);

		public void SetHandleRepresentation(vtkHandleRepresentation handle)
		{
			vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_SetHandleRepresentation_30(base.GetCppThis(), (handle == null) ? default(HandleRef) : handle.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkParallelopipedRepresentation_SetHoveredHandleProperty_31(HandleRef pThis, HandleRef arg0);

		public virtual void SetHoveredHandleProperty(vtkProperty arg0)
		{
			vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_SetHoveredHandleProperty_31(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkParallelopipedRepresentation_SetInteractionState_32(HandleRef pThis, int _arg);

		public virtual void SetInteractionState(int _arg)
		{
			vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_SetInteractionState_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkParallelopipedRepresentation_SetMinimumThickness_33(HandleRef pThis, double _arg);

		public virtual void SetMinimumThickness(double _arg)
		{
			vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_SetMinimumThickness_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkParallelopipedRepresentation_SetSelectedHandleProperty_34(HandleRef pThis, HandleRef arg0);

		public virtual void SetSelectedHandleProperty(vtkProperty arg0)
		{
			vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_SetSelectedHandleProperty_34(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkParallelopipedRepresentation_Translate_35(HandleRef pThis, IntPtr translation);

		public virtual void Translate(IntPtr translation)
		{
			vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_Translate_35(base.GetCppThis(), translation);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkParallelopipedRepresentation_Translate_36(HandleRef pThis, int X, int Y);

		public virtual void Translate(int X, int Y)
		{
			vtkParallelopipedRepresentation.vtkParallelopipedRepresentation_Translate_36(base.GetCppThis(), X, Y);
		}
	}
}
