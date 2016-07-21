using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImplicitPlaneRepresentation : vtkWidgetRepresentation
	{
		public enum _InteractionState
		{
			Moving = 1,
			MovingOrigin = 3,
			MovingOutline = 2,
			MovingPlane = 6,
			Outside = 0,
			Pushing = 5,
			Rotating = 4,
			Scaling = 7
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitPlaneRepresentation";

		public new static readonly string MRClassNameKey;

		static vtkImplicitPlaneRepresentation()
		{
			vtkImplicitPlaneRepresentation.MRClassNameKey = "class vtkImplicitPlaneRepresentation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImplicitPlaneRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitPlaneRepresentation"));
		}

		public vtkImplicitPlaneRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitPlaneRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImplicitPlaneRepresentation New()
		{
			vtkImplicitPlaneRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitPlaneRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImplicitPlaneRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneRepresentation_BuildRepresentation_01(HandleRef pThis);

		public override void BuildRepresentation()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImplicitPlaneRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_ComputeInteractionState_02(base.GetCppThis(), X, Y, modify);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneRepresentation_DrawPlaneOff_03(HandleRef pThis);

		public virtual void DrawPlaneOff()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_DrawPlaneOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneRepresentation_DrawPlaneOn_04(HandleRef pThis);

		public virtual void DrawPlaneOn()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_DrawPlaneOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneRepresentation_EndWidgetInteraction_05(HandleRef pThis, IntPtr newEventPos);

		public override void EndWidgetInteraction(IntPtr newEventPos)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_EndWidgetInteraction_05(base.GetCppThis(), newEventPos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneRepresentation_GetActors_06(HandleRef pThis, HandleRef pc);

		public override void GetActors(vtkPropCollection pc)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetActors_06(base.GetCppThis(), (pc == null) ? default(HandleRef) : pc.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitPlaneRepresentation_GetBounds_07(HandleRef pThis);

		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetBounds_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImplicitPlaneRepresentation_GetDrawPlane_08(HandleRef pThis);

		public virtual int GetDrawPlane()
		{
			return vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetDrawPlane_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitPlaneRepresentation_GetEdgesProperty_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetEdgesProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetEdgesProperty_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkImplicitPlaneRepresentation_GetInteractionStateMaxValue_10(HandleRef pThis);

		public virtual int GetInteractionStateMaxValue()
		{
			return vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetInteractionStateMaxValue_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImplicitPlaneRepresentation_GetInteractionStateMinValue_11(HandleRef pThis);

		public virtual int GetInteractionStateMinValue()
		{
			return vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetInteractionStateMinValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitPlaneRepresentation_GetNormal_12(HandleRef pThis);

		public double[] GetNormal()
		{
			IntPtr intPtr = vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetNormal_12(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneRepresentation_GetNormal_13(HandleRef pThis, IntPtr xyz);

		public void GetNormal(IntPtr xyz)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetNormal_13(base.GetCppThis(), xyz);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitPlaneRepresentation_GetNormalProperty_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetNormalProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetNormalProperty_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkImplicitPlaneRepresentation_GetNormalToXAxis_15(HandleRef pThis);

		public virtual int GetNormalToXAxis()
		{
			return vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetNormalToXAxis_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImplicitPlaneRepresentation_GetNormalToYAxis_16(HandleRef pThis);

		public virtual int GetNormalToYAxis()
		{
			return vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetNormalToYAxis_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImplicitPlaneRepresentation_GetNormalToZAxis_17(HandleRef pThis);

		public virtual int GetNormalToZAxis()
		{
			return vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetNormalToZAxis_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitPlaneRepresentation_GetOrigin_18(HandleRef pThis);

		public double[] GetOrigin()
		{
			IntPtr intPtr = vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetOrigin_18(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneRepresentation_GetOrigin_19(HandleRef pThis, IntPtr xyz);

		public void GetOrigin(IntPtr xyz)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetOrigin_19(base.GetCppThis(), xyz);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitPlaneRepresentation_GetOutlineProperty_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetOutlineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetOutlineProperty_20(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkImplicitPlaneRepresentation_GetOutlineTranslation_21(HandleRef pThis);

		public virtual int GetOutlineTranslation()
		{
			return vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetOutlineTranslation_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImplicitPlaneRepresentation_GetOutsideBounds_22(HandleRef pThis);

		public virtual int GetOutsideBounds()
		{
			return vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetOutsideBounds_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneRepresentation_GetPlane_23(HandleRef pThis, HandleRef plane);

		public void GetPlane(vtkPlane plane)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetPlane_23(base.GetCppThis(), (plane == null) ? default(HandleRef) : plane.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitPlaneRepresentation_GetPlaneProperty_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetPlaneProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetPlaneProperty_24(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkImplicitPlaneRepresentation_GetPolyData_25(HandleRef pThis, HandleRef pd);

		public void GetPolyData(vtkPolyData pd)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetPolyData_25(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitPlaneRepresentation_GetPolyDataAlgorithm_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPolyDataAlgorithm GetPolyDataAlgorithm()
		{
			vtkPolyDataAlgorithm vtkPolyDataAlgorithm = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetPolyDataAlgorithm_26(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataAlgorithm = (vtkPolyDataAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataAlgorithm.Register(null);
				}
			}
			return vtkPolyDataAlgorithm;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImplicitPlaneRepresentation_GetRepresentationState_27(HandleRef pThis);

		public virtual int GetRepresentationState()
		{
			return vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetRepresentationState_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImplicitPlaneRepresentation_GetScaleEnabled_28(HandleRef pThis);

		public virtual int GetScaleEnabled()
		{
			return vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetScaleEnabled_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitPlaneRepresentation_GetSelectedNormalProperty_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetSelectedNormalProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetSelectedNormalProperty_29(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkImplicitPlaneRepresentation_GetSelectedOutlineProperty_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetSelectedOutlineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetSelectedOutlineProperty_30(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkImplicitPlaneRepresentation_GetSelectedPlaneProperty_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetSelectedPlaneProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetSelectedPlaneProperty_31(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkImplicitPlaneRepresentation_GetTubing_32(HandleRef pThis);

		public virtual int GetTubing()
		{
			return vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_GetTubing_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImplicitPlaneRepresentation_HasTranslucentPolygonalGeometry_33(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_HasTranslucentPolygonalGeometry_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImplicitPlaneRepresentation_IsA_34(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_IsA_34(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImplicitPlaneRepresentation_IsTypeOf_35(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_IsTypeOf_35(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitPlaneRepresentation_NewInstance_37(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImplicitPlaneRepresentation NewInstance()
		{
			vtkImplicitPlaneRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_NewInstance_37(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitPlaneRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneRepresentation_NormalToXAxisOff_38(HandleRef pThis);

		public virtual void NormalToXAxisOff()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_NormalToXAxisOff_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneRepresentation_NormalToXAxisOn_39(HandleRef pThis);

		public virtual void NormalToXAxisOn()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_NormalToXAxisOn_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneRepresentation_NormalToYAxisOff_40(HandleRef pThis);

		public virtual void NormalToYAxisOff()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_NormalToYAxisOff_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneRepresentation_NormalToYAxisOn_41(HandleRef pThis);

		public virtual void NormalToYAxisOn()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_NormalToYAxisOn_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneRepresentation_NormalToZAxisOff_42(HandleRef pThis);

		public virtual void NormalToZAxisOff()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_NormalToZAxisOff_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneRepresentation_NormalToZAxisOn_43(HandleRef pThis);

		public virtual void NormalToZAxisOn()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_NormalToZAxisOn_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneRepresentation_OutlineTranslationOff_44(HandleRef pThis);

		public virtual void OutlineTranslationOff()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_OutlineTranslationOff_44(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneRepresentation_OutlineTranslationOn_45(HandleRef pThis);

		public virtual void OutlineTranslationOn()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_OutlineTranslationOn_45(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneRepresentation_OutsideBoundsOff_46(HandleRef pThis);

		public virtual void OutsideBoundsOff()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_OutsideBoundsOff_46(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneRepresentation_OutsideBoundsOn_47(HandleRef pThis);

		public virtual void OutsideBoundsOn()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_OutsideBoundsOn_47(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneRepresentation_PlaceWidget_48(HandleRef pThis, IntPtr bounds);

		public override void PlaceWidget(IntPtr bounds)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_PlaceWidget_48(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneRepresentation_ReleaseGraphicsResources_49(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_ReleaseGraphicsResources_49(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImplicitPlaneRepresentation_RenderOpaqueGeometry_50(HandleRef pThis, HandleRef arg0);

		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_RenderOpaqueGeometry_50(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImplicitPlaneRepresentation_RenderTranslucentPolygonalGeometry_51(HandleRef pThis, HandleRef arg0);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_RenderTranslucentPolygonalGeometry_51(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImplicitPlaneRepresentation_SafeDownCast_52(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImplicitPlaneRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkImplicitPlaneRepresentation vtkImplicitPlaneRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SafeDownCast_52((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitPlaneRepresentation = (vtkImplicitPlaneRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitPlaneRepresentation.Register(null);
				}
			}
			return vtkImplicitPlaneRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneRepresentation_ScaleEnabledOff_53(HandleRef pThis);

		public virtual void ScaleEnabledOff()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_ScaleEnabledOff_53(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneRepresentation_ScaleEnabledOn_54(HandleRef pThis);

		public virtual void ScaleEnabledOn()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_ScaleEnabledOn_54(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneRepresentation_SetDrawPlane_55(HandleRef pThis, int plane);

		public void SetDrawPlane(int plane)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetDrawPlane_55(base.GetCppThis(), plane);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneRepresentation_SetInteractionState_56(HandleRef pThis, int _arg);

		public virtual void SetInteractionState(int _arg)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetInteractionState_56(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneRepresentation_SetNormal_57(HandleRef pThis, double x, double y, double z);

		public void SetNormal(double x, double y, double z)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetNormal_57(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneRepresentation_SetNormal_58(HandleRef pThis, IntPtr x);

		public void SetNormal(IntPtr x)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetNormal_58(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneRepresentation_SetNormalToXAxis_59(HandleRef pThis, int arg0);

		public void SetNormalToXAxis(int arg0)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetNormalToXAxis_59(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneRepresentation_SetNormalToYAxis_60(HandleRef pThis, int arg0);

		public void SetNormalToYAxis(int arg0)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetNormalToYAxis_60(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneRepresentation_SetNormalToZAxis_61(HandleRef pThis, int arg0);

		public void SetNormalToZAxis(int arg0)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetNormalToZAxis_61(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneRepresentation_SetOrigin_62(HandleRef pThis, double x, double y, double z);

		public void SetOrigin(double x, double y, double z)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetOrigin_62(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneRepresentation_SetOrigin_63(HandleRef pThis, IntPtr x);

		public void SetOrigin(IntPtr x)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetOrigin_63(base.GetCppThis(), x);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneRepresentation_SetOutlineTranslation_64(HandleRef pThis, int _arg);

		public virtual void SetOutlineTranslation(int _arg)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetOutlineTranslation_64(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneRepresentation_SetOutsideBounds_65(HandleRef pThis, int _arg);

		public virtual void SetOutsideBounds(int _arg)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetOutsideBounds_65(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneRepresentation_SetRepresentationState_66(HandleRef pThis, int arg0);

		public virtual void SetRepresentationState(int arg0)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetRepresentationState_66(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneRepresentation_SetScaleEnabled_67(HandleRef pThis, int _arg);

		public virtual void SetScaleEnabled(int _arg)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetScaleEnabled_67(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneRepresentation_SetTubing_68(HandleRef pThis, int _arg);

		public virtual void SetTubing(int _arg)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_SetTubing_68(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneRepresentation_StartWidgetInteraction_69(HandleRef pThis, IntPtr eventPos);

		public override void StartWidgetInteraction(IntPtr eventPos)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_StartWidgetInteraction_69(base.GetCppThis(), eventPos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneRepresentation_TubingOff_70(HandleRef pThis);

		public virtual void TubingOff()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_TubingOff_70(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneRepresentation_TubingOn_71(HandleRef pThis);

		public virtual void TubingOn()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_TubingOn_71(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneRepresentation_UpdatePlacement_72(HandleRef pThis);

		public void UpdatePlacement()
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_UpdatePlacement_72(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImplicitPlaneRepresentation_WidgetInteraction_73(HandleRef pThis, IntPtr newEventPos);

		public override void WidgetInteraction(IntPtr newEventPos)
		{
			vtkImplicitPlaneRepresentation.vtkImplicitPlaneRepresentation_WidgetInteraction_73(base.GetCppThis(), newEventPos);
		}
	}
}
