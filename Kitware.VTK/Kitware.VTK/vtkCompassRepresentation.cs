using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCompassRepresentation : vtkContinuousValueWidgetRepresentation
	{
		public new enum _InteractionState
		{
			Adjusting = 2,
			DistanceAdjusting = 8,
			DistanceIn = 7,
			DistanceOut = 6,
			Inside = 1,
			Outside = 0,
			TiltAdjusting = 5,
			TiltDown = 3,
			TiltUp
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkCompassRepresentation";

		public new static readonly string MRClassNameKey;

		static vtkCompassRepresentation()
		{
			vtkCompassRepresentation.MRClassNameKey = "class vtkCompassRepresentation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCompassRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompassRepresentation"));
		}

		public vtkCompassRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkCompassRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCompassRepresentation New()
		{
			vtkCompassRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompassRepresentation.vtkCompassRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompassRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCompassRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCompassRepresentation.vtkCompassRepresentation_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkCompassRepresentation_BuildRepresentation_01(HandleRef pThis);

		public override void BuildRepresentation()
		{
			vtkCompassRepresentation.vtkCompassRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkCompassRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkCompassRepresentation.vtkCompassRepresentation_ComputeInteractionState_02(base.GetCppThis(), X, Y, modify);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkCompassRepresentation_DistanceWidgetInteraction_03(HandleRef pThis, IntPtr eventPos);

		public virtual void DistanceWidgetInteraction(IntPtr eventPos)
		{
			vtkCompassRepresentation.vtkCompassRepresentation_DistanceWidgetInteraction_03(base.GetCppThis(), eventPos);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkCompassRepresentation_EndDistance_04(HandleRef pThis);

		public virtual void EndDistance()
		{
			vtkCompassRepresentation.vtkCompassRepresentation_EndDistance_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkCompassRepresentation_EndTilt_05(HandleRef pThis);

		public virtual void EndTilt()
		{
			vtkCompassRepresentation.vtkCompassRepresentation_EndTilt_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkCompassRepresentation_GetActors_06(HandleRef pThis, HandleRef arg0);

		public override void GetActors(vtkPropCollection arg0)
		{
			vtkCompassRepresentation.vtkCompassRepresentation_GetActors_06(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkCompassRepresentation_GetDistance_07(HandleRef pThis);

		public virtual double GetDistance()
		{
			return vtkCompassRepresentation.vtkCompassRepresentation_GetDistance_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkCompassRepresentation_GetHeading_08(HandleRef pThis);

		public virtual double GetHeading()
		{
			return vtkCompassRepresentation.vtkCompassRepresentation_GetHeading_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkCompassRepresentation_GetLabelProperty_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetLabelProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompassRepresentation.vtkCompassRepresentation_GetLabelProperty_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkCompassRepresentation_GetPoint1Coordinate_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkCoordinate GetPoint1Coordinate()
		{
			vtkCoordinate vtkCoordinate = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompassRepresentation.vtkCompassRepresentation_GetPoint1Coordinate_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkCompassRepresentation_GetPoint2Coordinate_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkCoordinate GetPoint2Coordinate()
		{
			vtkCoordinate vtkCoordinate = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompassRepresentation.vtkCompassRepresentation_GetPoint2Coordinate_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkCompassRepresentation_GetRingProperty_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty2D GetRingProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompassRepresentation.vtkCompassRepresentation_GetRingProperty_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkCompassRepresentation_GetSelectedProperty_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty2D GetSelectedProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompassRepresentation.vtkCompassRepresentation_GetSelectedProperty_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkCompassRepresentation_GetTilt_14(HandleRef pThis);

		public virtual double GetTilt()
		{
			return vtkCompassRepresentation.vtkCompassRepresentation_GetTilt_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkCompassRepresentation_Highlight_15(HandleRef pThis, int arg0);

		public override void Highlight(int arg0)
		{
			vtkCompassRepresentation.vtkCompassRepresentation_Highlight_15(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkCompassRepresentation_IsA_16(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCompassRepresentation.vtkCompassRepresentation_IsA_16(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkCompassRepresentation_IsTypeOf_17(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCompassRepresentation.vtkCompassRepresentation_IsTypeOf_17(type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkCompassRepresentation_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCompassRepresentation NewInstance()
		{
			vtkCompassRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompassRepresentation.vtkCompassRepresentation_NewInstance_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompassRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkCompassRepresentation_PlaceWidget_20(HandleRef pThis, IntPtr bounds);

		public override void PlaceWidget(IntPtr bounds)
		{
			vtkCompassRepresentation.vtkCompassRepresentation_PlaceWidget_20(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkCompassRepresentation_ReleaseGraphicsResources_21(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkCompassRepresentation.vtkCompassRepresentation_ReleaseGraphicsResources_21(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkCompassRepresentation_RenderOpaqueGeometry_22(HandleRef pThis, HandleRef arg0);

		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkCompassRepresentation.vtkCompassRepresentation_RenderOpaqueGeometry_22(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkCompassRepresentation_RenderOverlay_23(HandleRef pThis, HandleRef arg0);

		public override int RenderOverlay(vtkViewport arg0)
		{
			return vtkCompassRepresentation.vtkCompassRepresentation_RenderOverlay_23(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkCompassRepresentation_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCompassRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkCompassRepresentation vtkCompassRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompassRepresentation.vtkCompassRepresentation_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompassRepresentation = (vtkCompassRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompassRepresentation.Register(null);
				}
			}
			return vtkCompassRepresentation;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkCompassRepresentation_SetDistance_25(HandleRef pThis, double value);

		public virtual void SetDistance(double value)
		{
			vtkCompassRepresentation.vtkCompassRepresentation_SetDistance_25(base.GetCppThis(), value);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkCompassRepresentation_SetHeading_26(HandleRef pThis, double value);

		public virtual void SetHeading(double value)
		{
			vtkCompassRepresentation.vtkCompassRepresentation_SetHeading_26(base.GetCppThis(), value);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkCompassRepresentation_SetRenderer_27(HandleRef pThis, HandleRef ren);

		public override void SetRenderer(vtkRenderer ren)
		{
			vtkCompassRepresentation.vtkCompassRepresentation_SetRenderer_27(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkCompassRepresentation_SetTilt_28(HandleRef pThis, double value);

		public virtual void SetTilt(double value)
		{
			vtkCompassRepresentation.vtkCompassRepresentation_SetTilt_28(base.GetCppThis(), value);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkCompassRepresentation_StartWidgetInteraction_29(HandleRef pThis, IntPtr eventPos);

		public override void StartWidgetInteraction(IntPtr eventPos)
		{
			vtkCompassRepresentation.vtkCompassRepresentation_StartWidgetInteraction_29(base.GetCppThis(), eventPos);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkCompassRepresentation_TiltWidgetInteraction_30(HandleRef pThis, IntPtr eventPos);

		public virtual void TiltWidgetInteraction(IntPtr eventPos)
		{
			vtkCompassRepresentation.vtkCompassRepresentation_TiltWidgetInteraction_30(base.GetCppThis(), eventPos);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkCompassRepresentation_UpdateDistance_31(HandleRef pThis, double time);

		public virtual void UpdateDistance(double time)
		{
			vtkCompassRepresentation.vtkCompassRepresentation_UpdateDistance_31(base.GetCppThis(), time);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkCompassRepresentation_UpdateTilt_32(HandleRef pThis, double time);

		public virtual void UpdateTilt(double time)
		{
			vtkCompassRepresentation.vtkCompassRepresentation_UpdateTilt_32(base.GetCppThis(), time);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkCompassRepresentation_WidgetInteraction_33(HandleRef pThis, IntPtr eventPos);

		public override void WidgetInteraction(IntPtr eventPos)
		{
			vtkCompassRepresentation.vtkCompassRepresentation_WidgetInteraction_33(base.GetCppThis(), eventPos);
		}
	}
}
