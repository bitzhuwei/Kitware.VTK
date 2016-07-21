using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkLabelPlacementMapper : vtkMapper2D
	{
		public enum LabelShape
		{
			NONE,
			NUMBER_OF_LABEL_SHAPES = 3,
			RECT = 1,
			ROUNDED_RECT
		}

		public enum LabelStyle
		{
			FILLED,
			NUMBER_OF_LABEL_STYLES = 2,
			OUTLINE = 1
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkLabelPlacementMapper";

		public new static readonly string MRClassNameKey;

		static vtkLabelPlacementMapper()
		{
			vtkLabelPlacementMapper.MRClassNameKey = "class vtkLabelPlacementMapper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLabelPlacementMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLabelPlacementMapper"));
		}

		public vtkLabelPlacementMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabelPlacementMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLabelPlacementMapper New()
		{
			vtkLabelPlacementMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabelPlacementMapper.vtkLabelPlacementMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLabelPlacementMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkLabelPlacementMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkLabelPlacementMapper.vtkLabelPlacementMapper_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacementMapper_GeneratePerturbedLabelSpokesOff_01(HandleRef pThis);

		public virtual void GeneratePerturbedLabelSpokesOff()
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_GeneratePerturbedLabelSpokesOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacementMapper_GeneratePerturbedLabelSpokesOn_02(HandleRef pThis);

		public virtual void GeneratePerturbedLabelSpokesOn()
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_GeneratePerturbedLabelSpokesOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabelPlacementMapper_GetAnchorTransform_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCoordinate GetAnchorTransform()
		{
			vtkCoordinate vtkCoordinate = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetAnchorTransform_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacementMapper_GetBackgroundColor_04(HandleRef pThis, IntPtr _arg);

		public virtual void GetBackgroundColor(IntPtr _arg)
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetBackgroundColor_04(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabelPlacementMapper_GetBackgroundColor_05(HandleRef pThis);

		public virtual double[] GetBackgroundColor()
		{
			IntPtr intPtr = vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetBackgroundColor_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacementMapper_GetBackgroundColor_06(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetBackgroundColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetBackgroundColor_06(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLabelPlacementMapper_GetBackgroundOpacity_07(HandleRef pThis);

		public virtual double GetBackgroundOpacity()
		{
			return vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetBackgroundOpacity_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLabelPlacementMapper_GetBackgroundOpacityMaxValue_08(HandleRef pThis);

		public virtual double GetBackgroundOpacityMaxValue()
		{
			return vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetBackgroundOpacityMaxValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLabelPlacementMapper_GetBackgroundOpacityMinValue_09(HandleRef pThis);

		public virtual double GetBackgroundOpacityMinValue()
		{
			return vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetBackgroundOpacityMinValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkLabelPlacementMapper_GetGeneratePerturbedLabelSpokes_10(HandleRef pThis);

		public virtual bool GetGeneratePerturbedLabelSpokes()
		{
			return vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetGeneratePerturbedLabelSpokes_10(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLabelPlacementMapper_GetIteratorType_11(HandleRef pThis);

		public virtual int GetIteratorType()
		{
			return vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetIteratorType_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLabelPlacementMapper_GetMargin_12(HandleRef pThis);

		public virtual double GetMargin()
		{
			return vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetMargin_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLabelPlacementMapper_GetMaximumLabelFraction_13(HandleRef pThis);

		public virtual double GetMaximumLabelFraction()
		{
			return vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetMaximumLabelFraction_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLabelPlacementMapper_GetMaximumLabelFractionMaxValue_14(HandleRef pThis);

		public virtual double GetMaximumLabelFractionMaxValue()
		{
			return vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetMaximumLabelFractionMaxValue_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLabelPlacementMapper_GetMaximumLabelFractionMinValue_15(HandleRef pThis);

		public virtual double GetMaximumLabelFractionMinValue()
		{
			return vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetMaximumLabelFractionMinValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkLabelPlacementMapper_GetOutputTraversedBounds_16(HandleRef pThis);

		public virtual bool GetOutputTraversedBounds()
		{
			return vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetOutputTraversedBounds_16(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkLabelPlacementMapper_GetPlaceAllLabels_17(HandleRef pThis);

		public virtual bool GetPlaceAllLabels()
		{
			return vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetPlaceAllLabels_17(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkLabelPlacementMapper_GetPositionsAsNormals_18(HandleRef pThis);

		public virtual bool GetPositionsAsNormals()
		{
			return vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetPositionsAsNormals_18(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabelPlacementMapper_GetRenderStrategy_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkLabelRenderStrategy GetRenderStrategy()
		{
			vtkLabelRenderStrategy vtkLabelRenderStrategy = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetRenderStrategy_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLabelRenderStrategy = (vtkLabelRenderStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLabelRenderStrategy.Register(null);
				}
			}
			return vtkLabelRenderStrategy;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLabelPlacementMapper_GetShape_20(HandleRef pThis);

		public virtual int GetShape()
		{
			return vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetShape_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLabelPlacementMapper_GetShapeMaxValue_21(HandleRef pThis);

		public virtual int GetShapeMaxValue()
		{
			return vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetShapeMaxValue_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLabelPlacementMapper_GetShapeMinValue_22(HandleRef pThis);

		public virtual int GetShapeMinValue()
		{
			return vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetShapeMinValue_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLabelPlacementMapper_GetStyle_23(HandleRef pThis);

		public virtual int GetStyle()
		{
			return vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetStyle_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLabelPlacementMapper_GetStyleMaxValue_24(HandleRef pThis);

		public virtual int GetStyleMaxValue()
		{
			return vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetStyleMaxValue_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLabelPlacementMapper_GetStyleMinValue_25(HandleRef pThis);

		public virtual int GetStyleMinValue()
		{
			return vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetStyleMinValue_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkLabelPlacementMapper_GetUseDepthBuffer_26(HandleRef pThis);

		public virtual bool GetUseDepthBuffer()
		{
			return vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetUseDepthBuffer_26(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkLabelPlacementMapper_GetUseUnicodeStrings_27(HandleRef pThis);

		public virtual bool GetUseUnicodeStrings()
		{
			return vtkLabelPlacementMapper.vtkLabelPlacementMapper_GetUseUnicodeStrings_27(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLabelPlacementMapper_IsA_28(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkLabelPlacementMapper.vtkLabelPlacementMapper_IsA_28(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLabelPlacementMapper_IsTypeOf_29(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkLabelPlacementMapper.vtkLabelPlacementMapper_IsTypeOf_29(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabelPlacementMapper_NewInstance_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkLabelPlacementMapper NewInstance()
		{
			vtkLabelPlacementMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabelPlacementMapper.vtkLabelPlacementMapper_NewInstance_31(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLabelPlacementMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacementMapper_OutputTraversedBoundsOff_32(HandleRef pThis);

		public virtual void OutputTraversedBoundsOff()
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_OutputTraversedBoundsOff_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacementMapper_OutputTraversedBoundsOn_33(HandleRef pThis);

		public virtual void OutputTraversedBoundsOn()
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_OutputTraversedBoundsOn_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacementMapper_PlaceAllLabelsOff_34(HandleRef pThis);

		public virtual void PlaceAllLabelsOff()
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_PlaceAllLabelsOff_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacementMapper_PlaceAllLabelsOn_35(HandleRef pThis);

		public virtual void PlaceAllLabelsOn()
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_PlaceAllLabelsOn_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacementMapper_PositionsAsNormalsOff_36(HandleRef pThis);

		public virtual void PositionsAsNormalsOff()
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_PositionsAsNormalsOff_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacementMapper_PositionsAsNormalsOn_37(HandleRef pThis);

		public virtual void PositionsAsNormalsOn()
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_PositionsAsNormalsOn_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacementMapper_RenderOverlay_38(HandleRef pThis, HandleRef viewport, HandleRef actor);

		public override void RenderOverlay(vtkViewport viewport, vtkActor2D actor)
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_RenderOverlay_38(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis(), (actor == null) ? default(HandleRef) : actor.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabelPlacementMapper_SafeDownCast_39(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLabelPlacementMapper SafeDownCast(vtkObjectBase o)
		{
			vtkLabelPlacementMapper vtkLabelPlacementMapper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabelPlacementMapper.vtkLabelPlacementMapper_SafeDownCast_39((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLabelPlacementMapper = (vtkLabelPlacementMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLabelPlacementMapper.Register(null);
				}
			}
			return vtkLabelPlacementMapper;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacementMapper_SetBackgroundColor_40(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetBackgroundColor(double _arg1, double _arg2, double _arg3)
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_SetBackgroundColor_40(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacementMapper_SetBackgroundColor_41(HandleRef pThis, IntPtr _arg);

		public virtual void SetBackgroundColor(IntPtr _arg)
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_SetBackgroundColor_41(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacementMapper_SetBackgroundOpacity_42(HandleRef pThis, double _arg);

		public virtual void SetBackgroundOpacity(double _arg)
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_SetBackgroundOpacity_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacementMapper_SetGeneratePerturbedLabelSpokes_43(HandleRef pThis, byte _arg);

		public virtual void SetGeneratePerturbedLabelSpokes(bool _arg)
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_SetGeneratePerturbedLabelSpokes_43(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacementMapper_SetIteratorType_44(HandleRef pThis, int _arg);

		public virtual void SetIteratorType(int _arg)
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_SetIteratorType_44(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacementMapper_SetMargin_45(HandleRef pThis, double _arg);

		public virtual void SetMargin(double _arg)
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_SetMargin_45(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacementMapper_SetMaximumLabelFraction_46(HandleRef pThis, double _arg);

		public virtual void SetMaximumLabelFraction(double _arg)
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_SetMaximumLabelFraction_46(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacementMapper_SetOutputTraversedBounds_47(HandleRef pThis, byte _arg);

		public virtual void SetOutputTraversedBounds(bool _arg)
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_SetOutputTraversedBounds_47(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacementMapper_SetPlaceAllLabels_48(HandleRef pThis, byte _arg);

		public virtual void SetPlaceAllLabels(bool _arg)
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_SetPlaceAllLabels_48(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacementMapper_SetPositionsAsNormals_49(HandleRef pThis, byte _arg);

		public virtual void SetPositionsAsNormals(bool _arg)
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_SetPositionsAsNormals_49(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacementMapper_SetRenderStrategy_50(HandleRef pThis, HandleRef s);

		public virtual void SetRenderStrategy(vtkLabelRenderStrategy s)
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_SetRenderStrategy_50(base.GetCppThis(), (s == null) ? default(HandleRef) : s.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacementMapper_SetShape_51(HandleRef pThis, int _arg);

		public virtual void SetShape(int _arg)
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_SetShape_51(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacementMapper_SetShapeToNone_52(HandleRef pThis);

		public virtual void SetShapeToNone()
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_SetShapeToNone_52(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacementMapper_SetShapeToRect_53(HandleRef pThis);

		public virtual void SetShapeToRect()
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_SetShapeToRect_53(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacementMapper_SetShapeToRoundedRect_54(HandleRef pThis);

		public virtual void SetShapeToRoundedRect()
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_SetShapeToRoundedRect_54(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacementMapper_SetStyle_55(HandleRef pThis, int _arg);

		public virtual void SetStyle(int _arg)
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_SetStyle_55(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacementMapper_SetStyleToFilled_56(HandleRef pThis);

		public virtual void SetStyleToFilled()
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_SetStyleToFilled_56(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacementMapper_SetStyleToOutline_57(HandleRef pThis);

		public virtual void SetStyleToOutline()
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_SetStyleToOutline_57(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacementMapper_SetUseDepthBuffer_58(HandleRef pThis, byte _arg);

		public virtual void SetUseDepthBuffer(bool _arg)
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_SetUseDepthBuffer_58(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacementMapper_SetUseUnicodeStrings_59(HandleRef pThis, byte _arg);

		public virtual void SetUseUnicodeStrings(bool _arg)
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_SetUseUnicodeStrings_59(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacementMapper_UseDepthBufferOff_60(HandleRef pThis);

		public virtual void UseDepthBufferOff()
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_UseDepthBufferOff_60(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacementMapper_UseDepthBufferOn_61(HandleRef pThis);

		public virtual void UseDepthBufferOn()
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_UseDepthBufferOn_61(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacementMapper_UseUnicodeStringsOff_62(HandleRef pThis);

		public virtual void UseUnicodeStringsOff()
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_UseUnicodeStringsOff_62(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacementMapper_UseUnicodeStringsOn_63(HandleRef pThis);

		public virtual void UseUnicodeStringsOn()
		{
			vtkLabelPlacementMapper.vtkLabelPlacementMapper_UseUnicodeStringsOn_63(base.GetCppThis());
		}
	}
}
