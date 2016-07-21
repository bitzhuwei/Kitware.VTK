using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkLineRepresentation : vtkWidgetRepresentation
	{
		public enum OnLine_WrapperEnum
		{
			OnLine = 5,
			OnP1 = 1,
			OnP2,
			Outside = 0,
			Scaling = 6,
			TranslatingP1 = 3,
			TranslatingP2
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkLineRepresentation";

		public new static readonly string MRClassNameKey;

		static vtkLineRepresentation()
		{
			vtkLineRepresentation.MRClassNameKey = "class vtkLineRepresentation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLineRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLineRepresentation"));
		}

		public vtkLineRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkLineRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLineRepresentation New()
		{
			vtkLineRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLineRepresentation.vtkLineRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLineRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkLineRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkLineRepresentation.vtkLineRepresentation_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineRepresentation_BuildRepresentation_01(HandleRef pThis);

		public override void BuildRepresentation()
		{
			vtkLineRepresentation.vtkLineRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkLineRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkLineRepresentation.vtkLineRepresentation_ComputeInteractionState_02(base.GetCppThis(), X, Y, modify);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineRepresentation_DistanceAnnotationVisibilityOff_03(HandleRef pThis);

		public virtual void DistanceAnnotationVisibilityOff()
		{
			vtkLineRepresentation.vtkLineRepresentation_DistanceAnnotationVisibilityOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineRepresentation_DistanceAnnotationVisibilityOn_04(HandleRef pThis);

		public virtual void DistanceAnnotationVisibilityOn()
		{
			vtkLineRepresentation.vtkLineRepresentation_DistanceAnnotationVisibilityOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineRepresentation_GetActors_05(HandleRef pThis, HandleRef pc);

		public override void GetActors(vtkPropCollection pc)
		{
			vtkLineRepresentation.vtkLineRepresentation_GetActors_05(base.GetCppThis(), (pc == null) ? default(HandleRef) : pc.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkLineRepresentation_GetBounds_06(HandleRef pThis);

		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkLineRepresentation.vtkLineRepresentation_GetBounds_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkLineRepresentation_GetDistance_07(HandleRef pThis);

		public double GetDistance()
		{
			return vtkLineRepresentation.vtkLineRepresentation_GetDistance_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkLineRepresentation_GetDistanceAnnotationFormat_08(HandleRef pThis);

		public virtual string GetDistanceAnnotationFormat()
		{
			return Marshal.PtrToStringAnsi(vtkLineRepresentation.vtkLineRepresentation_GetDistanceAnnotationFormat_08(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkLineRepresentation_GetDistanceAnnotationProperty_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetDistanceAnnotationProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLineRepresentation.vtkLineRepresentation_GetDistanceAnnotationProperty_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkLineRepresentation_GetDistanceAnnotationScale_10(HandleRef pThis);

		public virtual IntPtr GetDistanceAnnotationScale()
		{
			return vtkLineRepresentation.vtkLineRepresentation_GetDistanceAnnotationScale_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkLineRepresentation_GetDistanceAnnotationVisibility_11(HandleRef pThis);

		public virtual int GetDistanceAnnotationVisibility()
		{
			return vtkLineRepresentation.vtkLineRepresentation_GetDistanceAnnotationVisibility_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkLineRepresentation_GetEndPoint2Property_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetEndPoint2Property()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLineRepresentation.vtkLineRepresentation_GetEndPoint2Property_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkLineRepresentation_GetEndPointProperty_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetEndPointProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLineRepresentation.vtkLineRepresentation_GetEndPointProperty_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkLineRepresentation_GetInteractionStateMaxValue_14(HandleRef pThis);

		public virtual int GetInteractionStateMaxValue()
		{
			return vtkLineRepresentation.vtkLineRepresentation_GetInteractionStateMaxValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkLineRepresentation_GetInteractionStateMinValue_15(HandleRef pThis);

		public virtual int GetInteractionStateMinValue()
		{
			return vtkLineRepresentation.vtkLineRepresentation_GetInteractionStateMinValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkLineRepresentation_GetLineHandleRepresentation_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPointHandleRepresentation3D GetLineHandleRepresentation()
		{
			vtkPointHandleRepresentation3D vtkPointHandleRepresentation3D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLineRepresentation.vtkLineRepresentation_GetLineHandleRepresentation_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointHandleRepresentation3D = (vtkPointHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointHandleRepresentation3D.Register(null);
				}
			}
			return vtkPointHandleRepresentation3D;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkLineRepresentation_GetLineProperty_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetLineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLineRepresentation.vtkLineRepresentation_GetLineProperty_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern uint vtkLineRepresentation_GetMTime_18(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkLineRepresentation.vtkLineRepresentation_GetMTime_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineRepresentation_GetPoint1DisplayPosition_19(HandleRef pThis, IntPtr pos);

		public void GetPoint1DisplayPosition(IntPtr pos)
		{
			vtkLineRepresentation.vtkLineRepresentation_GetPoint1DisplayPosition_19(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkLineRepresentation_GetPoint1DisplayPosition_20(HandleRef pThis);

		public double[] GetPoint1DisplayPosition()
		{
			IntPtr intPtr = vtkLineRepresentation.vtkLineRepresentation_GetPoint1DisplayPosition_20(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkLineRepresentation_GetPoint1Representation_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPointHandleRepresentation3D GetPoint1Representation()
		{
			vtkPointHandleRepresentation3D vtkPointHandleRepresentation3D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLineRepresentation.vtkLineRepresentation_GetPoint1Representation_21(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointHandleRepresentation3D = (vtkPointHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointHandleRepresentation3D.Register(null);
				}
			}
			return vtkPointHandleRepresentation3D;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineRepresentation_GetPoint1WorldPosition_22(HandleRef pThis, IntPtr pos);

		public void GetPoint1WorldPosition(IntPtr pos)
		{
			vtkLineRepresentation.vtkLineRepresentation_GetPoint1WorldPosition_22(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkLineRepresentation_GetPoint1WorldPosition_23(HandleRef pThis);

		public double[] GetPoint1WorldPosition()
		{
			IntPtr intPtr = vtkLineRepresentation.vtkLineRepresentation_GetPoint1WorldPosition_23(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineRepresentation_GetPoint2DisplayPosition_24(HandleRef pThis, IntPtr pos);

		public void GetPoint2DisplayPosition(IntPtr pos)
		{
			vtkLineRepresentation.vtkLineRepresentation_GetPoint2DisplayPosition_24(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkLineRepresentation_GetPoint2DisplayPosition_25(HandleRef pThis);

		public double[] GetPoint2DisplayPosition()
		{
			IntPtr intPtr = vtkLineRepresentation.vtkLineRepresentation_GetPoint2DisplayPosition_25(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkLineRepresentation_GetPoint2Representation_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPointHandleRepresentation3D GetPoint2Representation()
		{
			vtkPointHandleRepresentation3D vtkPointHandleRepresentation3D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLineRepresentation.vtkLineRepresentation_GetPoint2Representation_26(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointHandleRepresentation3D = (vtkPointHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointHandleRepresentation3D.Register(null);
				}
			}
			return vtkPointHandleRepresentation3D;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineRepresentation_GetPoint2WorldPosition_27(HandleRef pThis, IntPtr pos);

		public void GetPoint2WorldPosition(IntPtr pos)
		{
			vtkLineRepresentation.vtkLineRepresentation_GetPoint2WorldPosition_27(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkLineRepresentation_GetPoint2WorldPosition_28(HandleRef pThis);

		public double[] GetPoint2WorldPosition()
		{
			IntPtr intPtr = vtkLineRepresentation.vtkLineRepresentation_GetPoint2WorldPosition_28(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineRepresentation_GetPolyData_29(HandleRef pThis, HandleRef pd);

		public void GetPolyData(vtkPolyData pd)
		{
			vtkLineRepresentation.vtkLineRepresentation_GetPolyData_29(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkLineRepresentation_GetRepresentationState_30(HandleRef pThis);

		public virtual int GetRepresentationState()
		{
			return vtkLineRepresentation.vtkLineRepresentation_GetRepresentationState_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkLineRepresentation_GetResolution_31(HandleRef pThis);

		public int GetResolution()
		{
			return vtkLineRepresentation.vtkLineRepresentation_GetResolution_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkLineRepresentation_GetSelectedEndPoint2Property_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetSelectedEndPoint2Property()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLineRepresentation.vtkLineRepresentation_GetSelectedEndPoint2Property_32(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkLineRepresentation_GetSelectedEndPointProperty_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetSelectedEndPointProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLineRepresentation.vtkLineRepresentation_GetSelectedEndPointProperty_33(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkLineRepresentation_GetSelectedLineProperty_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetSelectedLineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLineRepresentation.vtkLineRepresentation_GetSelectedLineProperty_34(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkLineRepresentation_GetTextActor_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkFollower GetTextActor()
		{
			vtkFollower vtkFollower = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLineRepresentation.vtkLineRepresentation_GetTextActor_35(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkLineRepresentation_GetTolerance_36(HandleRef pThis);

		public virtual int GetTolerance()
		{
			return vtkLineRepresentation.vtkLineRepresentation_GetTolerance_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkLineRepresentation_GetToleranceMaxValue_37(HandleRef pThis);

		public virtual int GetToleranceMaxValue()
		{
			return vtkLineRepresentation.vtkLineRepresentation_GetToleranceMaxValue_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkLineRepresentation_GetToleranceMinValue_38(HandleRef pThis);

		public virtual int GetToleranceMinValue()
		{
			return vtkLineRepresentation.vtkLineRepresentation_GetToleranceMinValue_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkLineRepresentation_HasTranslucentPolygonalGeometry_39(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkLineRepresentation.vtkLineRepresentation_HasTranslucentPolygonalGeometry_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineRepresentation_InstantiateHandleRepresentation_40(HandleRef pThis);

		public void InstantiateHandleRepresentation()
		{
			vtkLineRepresentation.vtkLineRepresentation_InstantiateHandleRepresentation_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkLineRepresentation_IsA_41(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkLineRepresentation.vtkLineRepresentation_IsA_41(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkLineRepresentation_IsTypeOf_42(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkLineRepresentation.vtkLineRepresentation_IsTypeOf_42(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkLineRepresentation_NewInstance_44(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkLineRepresentation NewInstance()
		{
			vtkLineRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLineRepresentation.vtkLineRepresentation_NewInstance_44(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLineRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineRepresentation_PlaceWidget_45(HandleRef pThis, IntPtr bounds);

		public override void PlaceWidget(IntPtr bounds)
		{
			vtkLineRepresentation.vtkLineRepresentation_PlaceWidget_45(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineRepresentation_ReleaseGraphicsResources_46(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkLineRepresentation.vtkLineRepresentation_ReleaseGraphicsResources_46(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkLineRepresentation_RenderOpaqueGeometry_47(HandleRef pThis, HandleRef arg0);

		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkLineRepresentation.vtkLineRepresentation_RenderOpaqueGeometry_47(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkLineRepresentation_RenderTranslucentPolygonalGeometry_48(HandleRef pThis, HandleRef arg0);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkLineRepresentation.vtkLineRepresentation_RenderTranslucentPolygonalGeometry_48(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkLineRepresentation_SafeDownCast_49(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLineRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkLineRepresentation vtkLineRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLineRepresentation.vtkLineRepresentation_SafeDownCast_49((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLineRepresentation = (vtkLineRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLineRepresentation.Register(null);
				}
			}
			return vtkLineRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineRepresentation_SetDistanceAnnotationFormat_50(HandleRef pThis, string _arg);

		public virtual void SetDistanceAnnotationFormat(string _arg)
		{
			vtkLineRepresentation.vtkLineRepresentation_SetDistanceAnnotationFormat_50(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineRepresentation_SetDistanceAnnotationScale_51(HandleRef pThis, double x, double y, double z);

		public void SetDistanceAnnotationScale(double x, double y, double z)
		{
			vtkLineRepresentation.vtkLineRepresentation_SetDistanceAnnotationScale_51(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineRepresentation_SetDistanceAnnotationScale_52(HandleRef pThis, IntPtr scale);

		public virtual void SetDistanceAnnotationScale(IntPtr scale)
		{
			vtkLineRepresentation.vtkLineRepresentation_SetDistanceAnnotationScale_52(base.GetCppThis(), scale);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineRepresentation_SetDistanceAnnotationVisibility_53(HandleRef pThis, int _arg);

		public virtual void SetDistanceAnnotationVisibility(int _arg)
		{
			vtkLineRepresentation.vtkLineRepresentation_SetDistanceAnnotationVisibility_53(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineRepresentation_SetHandleRepresentation_54(HandleRef pThis, HandleRef handle);

		public void SetHandleRepresentation(vtkPointHandleRepresentation3D handle)
		{
			vtkLineRepresentation.vtkLineRepresentation_SetHandleRepresentation_54(base.GetCppThis(), (handle == null) ? default(HandleRef) : handle.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineRepresentation_SetInteractionState_55(HandleRef pThis, int _arg);

		public virtual void SetInteractionState(int _arg)
		{
			vtkLineRepresentation.vtkLineRepresentation_SetInteractionState_55(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineRepresentation_SetLineColor_56(HandleRef pThis, double r, double g, double b);

		public void SetLineColor(double r, double g, double b)
		{
			vtkLineRepresentation.vtkLineRepresentation_SetLineColor_56(base.GetCppThis(), r, g, b);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineRepresentation_SetPoint1DisplayPosition_57(HandleRef pThis, IntPtr pos);

		public void SetPoint1DisplayPosition(IntPtr pos)
		{
			vtkLineRepresentation.vtkLineRepresentation_SetPoint1DisplayPosition_57(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineRepresentation_SetPoint1WorldPosition_58(HandleRef pThis, IntPtr pos);

		public void SetPoint1WorldPosition(IntPtr pos)
		{
			vtkLineRepresentation.vtkLineRepresentation_SetPoint1WorldPosition_58(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineRepresentation_SetPoint2DisplayPosition_59(HandleRef pThis, IntPtr pos);

		public void SetPoint2DisplayPosition(IntPtr pos)
		{
			vtkLineRepresentation.vtkLineRepresentation_SetPoint2DisplayPosition_59(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineRepresentation_SetPoint2WorldPosition_60(HandleRef pThis, IntPtr pos);

		public void SetPoint2WorldPosition(IntPtr pos)
		{
			vtkLineRepresentation.vtkLineRepresentation_SetPoint2WorldPosition_60(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineRepresentation_SetRenderer_61(HandleRef pThis, HandleRef ren);

		public override void SetRenderer(vtkRenderer ren)
		{
			vtkLineRepresentation.vtkLineRepresentation_SetRenderer_61(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineRepresentation_SetRepresentationState_62(HandleRef pThis, int arg0);

		public virtual void SetRepresentationState(int arg0)
		{
			vtkLineRepresentation.vtkLineRepresentation_SetRepresentationState_62(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineRepresentation_SetResolution_63(HandleRef pThis, int res);

		public void SetResolution(int res)
		{
			vtkLineRepresentation.vtkLineRepresentation_SetResolution_63(base.GetCppThis(), res);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineRepresentation_SetTolerance_64(HandleRef pThis, int _arg);

		public virtual void SetTolerance(int _arg)
		{
			vtkLineRepresentation.vtkLineRepresentation_SetTolerance_64(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineRepresentation_StartWidgetInteraction_65(HandleRef pThis, IntPtr e);

		public override void StartWidgetInteraction(IntPtr e)
		{
			vtkLineRepresentation.vtkLineRepresentation_StartWidgetInteraction_65(base.GetCppThis(), e);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkLineRepresentation_WidgetInteraction_66(HandleRef pThis, IntPtr e);

		public override void WidgetInteraction(IntPtr e)
		{
			vtkLineRepresentation.vtkLineRepresentation_WidgetInteraction_66(base.GetCppThis(), e);
		}
	}
}
