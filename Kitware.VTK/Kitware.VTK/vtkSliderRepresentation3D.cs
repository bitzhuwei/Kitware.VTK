using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSliderRepresentation3D : vtkSliderRepresentation
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSliderRepresentation3D";

		public new static readonly string MRClassNameKey;

		static vtkSliderRepresentation3D()
		{
			vtkSliderRepresentation3D.MRClassNameKey = "class vtkSliderRepresentation3D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSliderRepresentation3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSliderRepresentation3D"));
		}

		public vtkSliderRepresentation3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSliderRepresentation3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSliderRepresentation3D New()
		{
			vtkSliderRepresentation3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSliderRepresentation3D.vtkSliderRepresentation3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSliderRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSliderRepresentation3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSliderRepresentation3D.vtkSliderRepresentation3D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSliderRepresentation3D_BuildRepresentation_01(HandleRef pThis);

		public override void BuildRepresentation()
		{
			vtkSliderRepresentation3D.vtkSliderRepresentation3D_BuildRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSliderRepresentation3D_GetActors_02(HandleRef pThis, HandleRef arg0);

		public override void GetActors(vtkPropCollection arg0)
		{
			vtkSliderRepresentation3D.vtkSliderRepresentation3D_GetActors_02(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSliderRepresentation3D_GetBounds_03(HandleRef pThis);

		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkSliderRepresentation3D.vtkSliderRepresentation3D_GetBounds_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSliderRepresentation3D_GetCapProperty_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetCapProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSliderRepresentation3D.vtkSliderRepresentation3D_GetCapProperty_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern uint vtkSliderRepresentation3D_GetMTime_05(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkSliderRepresentation3D.vtkSliderRepresentation3D_GetMTime_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSliderRepresentation3D_GetPoint1Coordinate_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkCoordinate GetPoint1Coordinate()
		{
			vtkCoordinate vtkCoordinate = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSliderRepresentation3D.vtkSliderRepresentation3D_GetPoint1Coordinate_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCoordinate = (vtkCoordinate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCoordinate.Register(null);
				}
			}
			return vtkCoordinate;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSliderRepresentation3D_GetPoint2Coordinate_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkCoordinate GetPoint2Coordinate()
		{
			vtkCoordinate vtkCoordinate = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSliderRepresentation3D.vtkSliderRepresentation3D_GetPoint2Coordinate_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCoordinate = (vtkCoordinate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCoordinate.Register(null);
				}
			}
			return vtkCoordinate;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkSliderRepresentation3D_GetRotation_08(HandleRef pThis);

		public virtual double GetRotation()
		{
			return vtkSliderRepresentation3D.vtkSliderRepresentation3D_GetRotation_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSliderRepresentation3D_GetSelectedProperty_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetSelectedProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSliderRepresentation3D.vtkSliderRepresentation3D_GetSelectedProperty_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkSliderRepresentation3D_GetSliderProperty_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetSliderProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSliderRepresentation3D.vtkSliderRepresentation3D_GetSliderProperty_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkSliderRepresentation3D_GetSliderShape_11(HandleRef pThis);

		public virtual int GetSliderShape()
		{
			return vtkSliderRepresentation3D.vtkSliderRepresentation3D_GetSliderShape_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSliderRepresentation3D_GetSliderShapeMaxValue_12(HandleRef pThis);

		public virtual int GetSliderShapeMaxValue()
		{
			return vtkSliderRepresentation3D.vtkSliderRepresentation3D_GetSliderShapeMaxValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSliderRepresentation3D_GetSliderShapeMinValue_13(HandleRef pThis);

		public virtual int GetSliderShapeMinValue()
		{
			return vtkSliderRepresentation3D.vtkSliderRepresentation3D_GetSliderShapeMinValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSliderRepresentation3D_GetTitleText_14(HandleRef pThis);

		public override string GetTitleText()
		{
			return Marshal.PtrToStringAnsi(vtkSliderRepresentation3D.vtkSliderRepresentation3D_GetTitleText_14(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSliderRepresentation3D_GetTubeProperty_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetTubeProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSliderRepresentation3D.vtkSliderRepresentation3D_GetTubeProperty_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkSliderRepresentation3D_HasTranslucentPolygonalGeometry_16(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkSliderRepresentation3D.vtkSliderRepresentation3D_HasTranslucentPolygonalGeometry_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSliderRepresentation3D_Highlight_17(HandleRef pThis, int arg0);

		public override void Highlight(int arg0)
		{
			vtkSliderRepresentation3D.vtkSliderRepresentation3D_Highlight_17(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSliderRepresentation3D_IsA_18(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSliderRepresentation3D.vtkSliderRepresentation3D_IsA_18(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSliderRepresentation3D_IsTypeOf_19(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSliderRepresentation3D.vtkSliderRepresentation3D_IsTypeOf_19(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSliderRepresentation3D_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSliderRepresentation3D NewInstance()
		{
			vtkSliderRepresentation3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSliderRepresentation3D.vtkSliderRepresentation3D_NewInstance_21(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSliderRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSliderRepresentation3D_PlaceWidget_22(HandleRef pThis, IntPtr bounds);

		public override void PlaceWidget(IntPtr bounds)
		{
			vtkSliderRepresentation3D.vtkSliderRepresentation3D_PlaceWidget_22(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSliderRepresentation3D_ReleaseGraphicsResources_23(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkSliderRepresentation3D.vtkSliderRepresentation3D_ReleaseGraphicsResources_23(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSliderRepresentation3D_RenderOpaqueGeometry_24(HandleRef pThis, HandleRef arg0);

		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkSliderRepresentation3D.vtkSliderRepresentation3D_RenderOpaqueGeometry_24(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkSliderRepresentation3D_RenderTranslucentPolygonalGeometry_25(HandleRef pThis, HandleRef arg0);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkSliderRepresentation3D.vtkSliderRepresentation3D_RenderTranslucentPolygonalGeometry_25(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkSliderRepresentation3D_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSliderRepresentation3D SafeDownCast(vtkObjectBase o)
		{
			vtkSliderRepresentation3D vtkSliderRepresentation3D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSliderRepresentation3D.vtkSliderRepresentation3D_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkSliderRepresentation3D_SetPoint1InWorldCoordinates_27(HandleRef pThis, double x, double y, double z);

		public void SetPoint1InWorldCoordinates(double x, double y, double z)
		{
			vtkSliderRepresentation3D.vtkSliderRepresentation3D_SetPoint1InWorldCoordinates_27(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSliderRepresentation3D_SetPoint2InWorldCoordinates_28(HandleRef pThis, double x, double y, double z);

		public void SetPoint2InWorldCoordinates(double x, double y, double z)
		{
			vtkSliderRepresentation3D.vtkSliderRepresentation3D_SetPoint2InWorldCoordinates_28(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSliderRepresentation3D_SetRotation_29(HandleRef pThis, double _arg);

		public virtual void SetRotation(double _arg)
		{
			vtkSliderRepresentation3D.vtkSliderRepresentation3D_SetRotation_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSliderRepresentation3D_SetSliderShape_30(HandleRef pThis, int _arg);

		public virtual void SetSliderShape(int _arg)
		{
			vtkSliderRepresentation3D.vtkSliderRepresentation3D_SetSliderShape_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSliderRepresentation3D_SetSliderShapeToCylinder_31(HandleRef pThis);

		public void SetSliderShapeToCylinder()
		{
			vtkSliderRepresentation3D.vtkSliderRepresentation3D_SetSliderShapeToCylinder_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSliderRepresentation3D_SetSliderShapeToSphere_32(HandleRef pThis);

		public void SetSliderShapeToSphere()
		{
			vtkSliderRepresentation3D.vtkSliderRepresentation3D_SetSliderShapeToSphere_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSliderRepresentation3D_SetTitleText_33(HandleRef pThis, string arg0);

		public override void SetTitleText(string arg0)
		{
			vtkSliderRepresentation3D.vtkSliderRepresentation3D_SetTitleText_33(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSliderRepresentation3D_StartWidgetInteraction_34(HandleRef pThis, IntPtr eventPos);

		public override void StartWidgetInteraction(IntPtr eventPos)
		{
			vtkSliderRepresentation3D.vtkSliderRepresentation3D_StartWidgetInteraction_34(base.GetCppThis(), eventPos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkSliderRepresentation3D_WidgetInteraction_35(HandleRef pThis, IntPtr newEventPos);

		public override void WidgetInteraction(IntPtr newEventPos)
		{
			vtkSliderRepresentation3D.vtkSliderRepresentation3D_WidgetInteraction_35(base.GetCppThis(), newEventPos);
		}
	}
}
