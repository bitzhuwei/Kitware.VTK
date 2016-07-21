using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkBoxRepresentation : vtkWidgetRepresentation
	{
		public enum MoveF0_WrapperEnum
		{
			MoveF0 = 1,
			MoveF1,
			MoveF2,
			MoveF3,
			MoveF4,
			MoveF5,
			Outside = 0,
			Rotating = 8,
			Scaling,
			Translating = 7
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkBoxRepresentation";

		public new static readonly string MRClassNameKey;

		static vtkBoxRepresentation()
		{
			vtkBoxRepresentation.MRClassNameKey = "class vtkBoxRepresentation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBoxRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBoxRepresentation"));
		}

		public vtkBoxRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBoxRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBoxRepresentation New()
		{
			vtkBoxRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBoxRepresentation.vtkBoxRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBoxRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkBoxRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkBoxRepresentation.vtkBoxRepresentation_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxRepresentation_BuildRepresentation_01(HandleRef pThis);

		public override void BuildRepresentation()
		{
			vtkBoxRepresentation.vtkBoxRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBoxRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkBoxRepresentation.vtkBoxRepresentation_ComputeInteractionState_02(base.GetCppThis(), X, Y, modify);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBoxRepresentation_GetBounds_03(HandleRef pThis);

		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkBoxRepresentation.vtkBoxRepresentation_GetBounds_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBoxRepresentation_GetFaceProperty_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetFaceProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBoxRepresentation.vtkBoxRepresentation_GetFaceProperty_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkBoxRepresentation_GetHandleProperty_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetHandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBoxRepresentation.vtkBoxRepresentation_GetHandleProperty_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkBoxRepresentation_GetInsideOut_06(HandleRef pThis);

		public virtual int GetInsideOut()
		{
			return vtkBoxRepresentation.vtkBoxRepresentation_GetInsideOut_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBoxRepresentation_GetOutlineCursorWires_07(HandleRef pThis);

		public virtual int GetOutlineCursorWires()
		{
			return vtkBoxRepresentation.vtkBoxRepresentation_GetOutlineCursorWires_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBoxRepresentation_GetOutlineFaceWires_08(HandleRef pThis);

		public virtual int GetOutlineFaceWires()
		{
			return vtkBoxRepresentation.vtkBoxRepresentation_GetOutlineFaceWires_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBoxRepresentation_GetOutlineProperty_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetOutlineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBoxRepresentation.vtkBoxRepresentation_GetOutlineProperty_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkBoxRepresentation_GetPlanes_10(HandleRef pThis, HandleRef planes);

		public void GetPlanes(vtkPlanes planes)
		{
			vtkBoxRepresentation.vtkBoxRepresentation_GetPlanes_10(base.GetCppThis(), (planes == null) ? default(HandleRef) : planes.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxRepresentation_GetPolyData_11(HandleRef pThis, HandleRef pd);

		public void GetPolyData(vtkPolyData pd)
		{
			vtkBoxRepresentation.vtkBoxRepresentation_GetPolyData_11(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBoxRepresentation_GetSelectedFaceProperty_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetSelectedFaceProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBoxRepresentation.vtkBoxRepresentation_GetSelectedFaceProperty_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkBoxRepresentation_GetSelectedHandleProperty_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetSelectedHandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBoxRepresentation.vtkBoxRepresentation_GetSelectedHandleProperty_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkBoxRepresentation_GetSelectedOutlineProperty_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetSelectedOutlineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBoxRepresentation.vtkBoxRepresentation_GetSelectedOutlineProperty_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkBoxRepresentation_GetTransform_15(HandleRef pThis, HandleRef t);

		public virtual void GetTransform(vtkTransform t)
		{
			vtkBoxRepresentation.vtkBoxRepresentation_GetTransform_15(base.GetCppThis(), (t == null) ? default(HandleRef) : t.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxRepresentation_HandlesOff_16(HandleRef pThis);

		public virtual void HandlesOff()
		{
			vtkBoxRepresentation.vtkBoxRepresentation_HandlesOff_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxRepresentation_HandlesOn_17(HandleRef pThis);

		public virtual void HandlesOn()
		{
			vtkBoxRepresentation.vtkBoxRepresentation_HandlesOn_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBoxRepresentation_HasTranslucentPolygonalGeometry_18(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkBoxRepresentation.vtkBoxRepresentation_HasTranslucentPolygonalGeometry_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxRepresentation_InsideOutOff_19(HandleRef pThis);

		public virtual void InsideOutOff()
		{
			vtkBoxRepresentation.vtkBoxRepresentation_InsideOutOff_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxRepresentation_InsideOutOn_20(HandleRef pThis);

		public virtual void InsideOutOn()
		{
			vtkBoxRepresentation.vtkBoxRepresentation_InsideOutOn_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBoxRepresentation_IsA_21(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkBoxRepresentation.vtkBoxRepresentation_IsA_21(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBoxRepresentation_IsTypeOf_22(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkBoxRepresentation.vtkBoxRepresentation_IsTypeOf_22(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBoxRepresentation_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkBoxRepresentation NewInstance()
		{
			vtkBoxRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBoxRepresentation.vtkBoxRepresentation_NewInstance_24(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBoxRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxRepresentation_OutlineCursorWiresOff_25(HandleRef pThis);

		public void OutlineCursorWiresOff()
		{
			vtkBoxRepresentation.vtkBoxRepresentation_OutlineCursorWiresOff_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxRepresentation_OutlineCursorWiresOn_26(HandleRef pThis);

		public void OutlineCursorWiresOn()
		{
			vtkBoxRepresentation.vtkBoxRepresentation_OutlineCursorWiresOn_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxRepresentation_OutlineFaceWiresOff_27(HandleRef pThis);

		public void OutlineFaceWiresOff()
		{
			vtkBoxRepresentation.vtkBoxRepresentation_OutlineFaceWiresOff_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxRepresentation_OutlineFaceWiresOn_28(HandleRef pThis);

		public void OutlineFaceWiresOn()
		{
			vtkBoxRepresentation.vtkBoxRepresentation_OutlineFaceWiresOn_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxRepresentation_PlaceWidget_29(HandleRef pThis, IntPtr bounds);

		public override void PlaceWidget(IntPtr bounds)
		{
			vtkBoxRepresentation.vtkBoxRepresentation_PlaceWidget_29(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxRepresentation_ReleaseGraphicsResources_30(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkBoxRepresentation.vtkBoxRepresentation_ReleaseGraphicsResources_30(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBoxRepresentation_RenderOpaqueGeometry_31(HandleRef pThis, HandleRef arg0);

		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkBoxRepresentation.vtkBoxRepresentation_RenderOpaqueGeometry_31(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBoxRepresentation_RenderTranslucentPolygonalGeometry_32(HandleRef pThis, HandleRef arg0);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkBoxRepresentation.vtkBoxRepresentation_RenderTranslucentPolygonalGeometry_32(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBoxRepresentation_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBoxRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkBoxRepresentation vtkBoxRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBoxRepresentation.vtkBoxRepresentation_SafeDownCast_33((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBoxRepresentation = (vtkBoxRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBoxRepresentation.Register(null);
				}
			}
			return vtkBoxRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxRepresentation_SetInsideOut_34(HandleRef pThis, int _arg);

		public virtual void SetInsideOut(int _arg)
		{
			vtkBoxRepresentation.vtkBoxRepresentation_SetInsideOut_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxRepresentation_SetInteractionState_35(HandleRef pThis, int state);

		public void SetInteractionState(int state)
		{
			vtkBoxRepresentation.vtkBoxRepresentation_SetInteractionState_35(base.GetCppThis(), state);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxRepresentation_SetOutlineCursorWires_36(HandleRef pThis, int arg0);

		public void SetOutlineCursorWires(int arg0)
		{
			vtkBoxRepresentation.vtkBoxRepresentation_SetOutlineCursorWires_36(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxRepresentation_SetOutlineFaceWires_37(HandleRef pThis, int arg0);

		public void SetOutlineFaceWires(int arg0)
		{
			vtkBoxRepresentation.vtkBoxRepresentation_SetOutlineFaceWires_37(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxRepresentation_SetTransform_38(HandleRef pThis, HandleRef t);

		public virtual void SetTransform(vtkTransform t)
		{
			vtkBoxRepresentation.vtkBoxRepresentation_SetTransform_38(base.GetCppThis(), (t == null) ? default(HandleRef) : t.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxRepresentation_StartWidgetInteraction_39(HandleRef pThis, IntPtr e);

		public override void StartWidgetInteraction(IntPtr e)
		{
			vtkBoxRepresentation.vtkBoxRepresentation_StartWidgetInteraction_39(base.GetCppThis(), e);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBoxRepresentation_WidgetInteraction_40(HandleRef pThis, IntPtr e);

		public override void WidgetInteraction(IntPtr e)
		{
			vtkBoxRepresentation.vtkBoxRepresentation_WidgetInteraction_40(base.GetCppThis(), e);
		}
	}
}
