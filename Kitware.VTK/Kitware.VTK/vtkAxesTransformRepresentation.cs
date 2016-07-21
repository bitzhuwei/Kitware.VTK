using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkAxesTransformRepresentation : vtkWidgetRepresentation
	{
		public enum OnOrigin_WrapperEnum
		{
			OnOrigin = 1,
			OnX,
			OnXEnd = 5,
			OnY = 3,
			OnYEnd = 6,
			OnZ = 4,
			OnZEnd = 7,
			Outside = 0
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkAxesTransformRepresentation";

		public new static readonly string MRClassNameKey;

		static vtkAxesTransformRepresentation()
		{
			vtkAxesTransformRepresentation.MRClassNameKey = "class vtkAxesTransformRepresentation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAxesTransformRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAxesTransformRepresentation"));
		}

		public vtkAxesTransformRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAxesTransformRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAxesTransformRepresentation New()
		{
			vtkAxesTransformRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAxesTransformRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkAxesTransformRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAxesTransformRepresentation_BuildRepresentation_01(HandleRef pThis);

		public override void BuildRepresentation()
		{
			vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAxesTransformRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_ComputeInteractionState_02(base.GetCppThis(), X, Y, modify);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAxesTransformRepresentation_GetBounds_03(HandleRef pThis);

		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_GetBounds_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAxesTransformRepresentation_GetInteractionStateMaxValue_04(HandleRef pThis);

		public virtual int GetInteractionStateMaxValue()
		{
			return vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_GetInteractionStateMaxValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAxesTransformRepresentation_GetInteractionStateMinValue_05(HandleRef pThis);

		public virtual int GetInteractionStateMinValue()
		{
			return vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_GetInteractionStateMinValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAxesTransformRepresentation_GetLabelFormat_06(HandleRef pThis);

		public virtual string GetLabelFormat()
		{
			return Marshal.PtrToStringAnsi(vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_GetLabelFormat_06(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAxesTransformRepresentation_GetLabelProperty_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetLabelProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_GetLabelProperty_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkAxesTransformRepresentation_GetLabelScale_08(HandleRef pThis);

		public virtual IntPtr GetLabelScale()
		{
			return vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_GetLabelScale_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAxesTransformRepresentation_GetOriginDisplayPosition_09(HandleRef pThis, IntPtr pos);

		public void GetOriginDisplayPosition(IntPtr pos)
		{
			vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_GetOriginDisplayPosition_09(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAxesTransformRepresentation_GetOriginRepresentation_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkHandleRepresentation GetOriginRepresentation()
		{
			vtkHandleRepresentation vtkHandleRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_GetOriginRepresentation_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkAxesTransformRepresentation_GetOriginWorldPosition_11(HandleRef pThis);

		public IntPtr GetOriginWorldPosition()
		{
			return vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_GetOriginWorldPosition_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAxesTransformRepresentation_GetOriginWorldPosition_12(HandleRef pThis, IntPtr pos);

		public void GetOriginWorldPosition(IntPtr pos)
		{
			vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_GetOriginWorldPosition_12(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAxesTransformRepresentation_GetSelectionRepresentation_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkHandleRepresentation GetSelectionRepresentation()
		{
			vtkHandleRepresentation vtkHandleRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_GetSelectionRepresentation_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkAxesTransformRepresentation_GetTolerance_14(HandleRef pThis);

		public virtual int GetTolerance()
		{
			return vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_GetTolerance_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAxesTransformRepresentation_GetToleranceMaxValue_15(HandleRef pThis);

		public virtual int GetToleranceMaxValue()
		{
			return vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_GetToleranceMaxValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAxesTransformRepresentation_GetToleranceMinValue_16(HandleRef pThis);

		public virtual int GetToleranceMinValue()
		{
			return vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_GetToleranceMinValue_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAxesTransformRepresentation_IsA_17(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_IsA_17(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAxesTransformRepresentation_IsTypeOf_18(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_IsTypeOf_18(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAxesTransformRepresentation_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAxesTransformRepresentation NewInstance()
		{
			vtkAxesTransformRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_NewInstance_20(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAxesTransformRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAxesTransformRepresentation_ReleaseGraphicsResources_21(HandleRef pThis, HandleRef w);

		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_ReleaseGraphicsResources_21(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAxesTransformRepresentation_RenderOpaqueGeometry_22(HandleRef pThis, HandleRef viewport);

		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_RenderOpaqueGeometry_22(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkAxesTransformRepresentation_RenderTranslucentPolygonalGeometry_23(HandleRef pThis, HandleRef viewport);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_RenderTranslucentPolygonalGeometry_23(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkAxesTransformRepresentation_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAxesTransformRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkAxesTransformRepresentation vtkAxesTransformRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAxesTransformRepresentation = (vtkAxesTransformRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAxesTransformRepresentation.Register(null);
				}
			}
			return vtkAxesTransformRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAxesTransformRepresentation_SetInteractionState_25(HandleRef pThis, int _arg);

		public virtual void SetInteractionState(int _arg)
		{
			vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_SetInteractionState_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAxesTransformRepresentation_SetLabelFormat_26(HandleRef pThis, string _arg);

		public virtual void SetLabelFormat(string _arg)
		{
			vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_SetLabelFormat_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAxesTransformRepresentation_SetLabelScale_27(HandleRef pThis, double x, double y, double z);

		public void SetLabelScale(double x, double y, double z)
		{
			vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_SetLabelScale_27(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAxesTransformRepresentation_SetLabelScale_28(HandleRef pThis, IntPtr scale);

		public virtual void SetLabelScale(IntPtr scale)
		{
			vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_SetLabelScale_28(base.GetCppThis(), scale);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAxesTransformRepresentation_SetOriginDisplayPosition_29(HandleRef pThis, IntPtr pos);

		public void SetOriginDisplayPosition(IntPtr pos)
		{
			vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_SetOriginDisplayPosition_29(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAxesTransformRepresentation_SetOriginWorldPosition_30(HandleRef pThis, IntPtr pos);

		public void SetOriginWorldPosition(IntPtr pos)
		{
			vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_SetOriginWorldPosition_30(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAxesTransformRepresentation_SetTolerance_31(HandleRef pThis, int _arg);

		public virtual void SetTolerance(int _arg)
		{
			vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_SetTolerance_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAxesTransformRepresentation_StartWidgetInteraction_32(HandleRef pThis, IntPtr e);

		public override void StartWidgetInteraction(IntPtr e)
		{
			vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_StartWidgetInteraction_32(base.GetCppThis(), e);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkAxesTransformRepresentation_WidgetInteraction_33(HandleRef pThis, IntPtr e);

		public override void WidgetInteraction(IntPtr e)
		{
			vtkAxesTransformRepresentation.vtkAxesTransformRepresentation_WidgetInteraction_33(base.GetCppThis(), e);
		}
	}
}
