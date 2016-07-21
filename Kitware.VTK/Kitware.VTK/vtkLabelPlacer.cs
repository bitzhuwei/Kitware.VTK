using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkLabelPlacer : vtkPolyDataAlgorithm
	{
		public enum LabelGravity
		{
			BaselineCenter = 34,
			BaselineLeft = 18,
			BaselineRight = 66,
			CenterCenter = 36,
			CenterLeft = 20,
			CenterRight = 68,
			HorizontalBitMask = 112,
			HorizontalCenterBit = 32,
			HorizontalLeftBit = 16,
			HorizontalRightBit = 64,
			LowerCenter = 33,
			LowerLeft = 17,
			LowerRight = 65,
			UpperCenter = 40,
			UpperLeft = 24,
			UpperRight = 72,
			VerticalBaselineBit = 2,
			VerticalBitMask = 15,
			VerticalBottomBit = 1,
			VerticalCenterBit = 4,
			VerticalTopBit = 8
		}

		public enum OutputCoordinates
		{
			DISPLAY = 1,
			WORLD = 0
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkLabelPlacer";

		public new static readonly string MRClassNameKey;

		static vtkLabelPlacer()
		{
			vtkLabelPlacer.MRClassNameKey = "class vtkLabelPlacer";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLabelPlacer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLabelPlacer"));
		}

		public vtkLabelPlacer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabelPlacer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLabelPlacer New()
		{
			vtkLabelPlacer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabelPlacer.vtkLabelPlacer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLabelPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkLabelPlacer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkLabelPlacer.vtkLabelPlacer_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacer_GeneratePerturbedLabelSpokesOff_01(HandleRef pThis);

		public virtual void GeneratePerturbedLabelSpokesOff()
		{
			vtkLabelPlacer.vtkLabelPlacer_GeneratePerturbedLabelSpokesOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacer_GeneratePerturbedLabelSpokesOn_02(HandleRef pThis);

		public virtual void GeneratePerturbedLabelSpokesOn()
		{
			vtkLabelPlacer.vtkLabelPlacer_GeneratePerturbedLabelSpokesOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabelPlacer_GetAnchorTransform_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCoordinate GetAnchorTransform()
		{
			vtkCoordinate vtkCoordinate = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabelPlacer.vtkLabelPlacer_GetAnchorTransform_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern byte vtkLabelPlacer_GetGeneratePerturbedLabelSpokes_04(HandleRef pThis);

		public virtual bool GetGeneratePerturbedLabelSpokes()
		{
			return vtkLabelPlacer.vtkLabelPlacer_GetGeneratePerturbedLabelSpokes_04(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLabelPlacer_GetGravity_05(HandleRef pThis);

		public virtual int GetGravity()
		{
			return vtkLabelPlacer.vtkLabelPlacer_GetGravity_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLabelPlacer_GetIteratorType_06(HandleRef pThis);

		public virtual int GetIteratorType()
		{
			return vtkLabelPlacer.vtkLabelPlacer_GetIteratorType_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkLabelPlacer_GetMTime_07(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkLabelPlacer.vtkLabelPlacer_GetMTime_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLabelPlacer_GetMaximumLabelFraction_08(HandleRef pThis);

		public virtual double GetMaximumLabelFraction()
		{
			return vtkLabelPlacer.vtkLabelPlacer_GetMaximumLabelFraction_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLabelPlacer_GetMaximumLabelFractionMaxValue_09(HandleRef pThis);

		public virtual double GetMaximumLabelFractionMaxValue()
		{
			return vtkLabelPlacer.vtkLabelPlacer_GetMaximumLabelFractionMaxValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLabelPlacer_GetMaximumLabelFractionMinValue_10(HandleRef pThis);

		public virtual double GetMaximumLabelFractionMinValue()
		{
			return vtkLabelPlacer.vtkLabelPlacer_GetMaximumLabelFractionMinValue_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLabelPlacer_GetOutputCoordinateSystem_11(HandleRef pThis);

		public virtual int GetOutputCoordinateSystem()
		{
			return vtkLabelPlacer.vtkLabelPlacer_GetOutputCoordinateSystem_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLabelPlacer_GetOutputCoordinateSystemMaxValue_12(HandleRef pThis);

		public virtual int GetOutputCoordinateSystemMaxValue()
		{
			return vtkLabelPlacer.vtkLabelPlacer_GetOutputCoordinateSystemMaxValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLabelPlacer_GetOutputCoordinateSystemMinValue_13(HandleRef pThis);

		public virtual int GetOutputCoordinateSystemMinValue()
		{
			return vtkLabelPlacer.vtkLabelPlacer_GetOutputCoordinateSystemMinValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkLabelPlacer_GetOutputTraversedBounds_14(HandleRef pThis);

		public virtual bool GetOutputTraversedBounds()
		{
			return vtkLabelPlacer.vtkLabelPlacer_GetOutputTraversedBounds_14(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkLabelPlacer_GetPositionsAsNormals_15(HandleRef pThis);

		public virtual bool GetPositionsAsNormals()
		{
			return vtkLabelPlacer.vtkLabelPlacer_GetPositionsAsNormals_15(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabelPlacer_GetRenderer_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkRenderer GetRenderer()
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabelPlacer.vtkLabelPlacer_GetRenderer_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderer = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderer.Register(null);
				}
			}
			return vtkRenderer;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkLabelPlacer_GetUseDepthBuffer_17(HandleRef pThis);

		public virtual bool GetUseDepthBuffer()
		{
			return vtkLabelPlacer.vtkLabelPlacer_GetUseDepthBuffer_17(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkLabelPlacer_GetUseUnicodeStrings_18(HandleRef pThis);

		public virtual bool GetUseUnicodeStrings()
		{
			return vtkLabelPlacer.vtkLabelPlacer_GetUseUnicodeStrings_18(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLabelPlacer_IsA_19(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkLabelPlacer.vtkLabelPlacer_IsA_19(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLabelPlacer_IsTypeOf_20(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkLabelPlacer.vtkLabelPlacer_IsTypeOf_20(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabelPlacer_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkLabelPlacer NewInstance()
		{
			vtkLabelPlacer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabelPlacer.vtkLabelPlacer_NewInstance_22(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLabelPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacer_OutputCoordinateSystemDisplay_23(HandleRef pThis);

		public void OutputCoordinateSystemDisplay()
		{
			vtkLabelPlacer.vtkLabelPlacer_OutputCoordinateSystemDisplay_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacer_OutputCoordinateSystemWorld_24(HandleRef pThis);

		public void OutputCoordinateSystemWorld()
		{
			vtkLabelPlacer.vtkLabelPlacer_OutputCoordinateSystemWorld_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacer_OutputTraversedBoundsOff_25(HandleRef pThis);

		public virtual void OutputTraversedBoundsOff()
		{
			vtkLabelPlacer.vtkLabelPlacer_OutputTraversedBoundsOff_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacer_OutputTraversedBoundsOn_26(HandleRef pThis);

		public virtual void OutputTraversedBoundsOn()
		{
			vtkLabelPlacer.vtkLabelPlacer_OutputTraversedBoundsOn_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacer_PositionsAsNormalsOff_27(HandleRef pThis);

		public virtual void PositionsAsNormalsOff()
		{
			vtkLabelPlacer.vtkLabelPlacer_PositionsAsNormalsOff_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacer_PositionsAsNormalsOn_28(HandleRef pThis);

		public virtual void PositionsAsNormalsOn()
		{
			vtkLabelPlacer.vtkLabelPlacer_PositionsAsNormalsOn_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLabelPlacer_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLabelPlacer SafeDownCast(vtkObjectBase o)
		{
			vtkLabelPlacer vtkLabelPlacer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLabelPlacer.vtkLabelPlacer_SafeDownCast_29((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLabelPlacer = (vtkLabelPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLabelPlacer.Register(null);
				}
			}
			return vtkLabelPlacer;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacer_SetGeneratePerturbedLabelSpokes_30(HandleRef pThis, byte _arg);

		public virtual void SetGeneratePerturbedLabelSpokes(bool _arg)
		{
			vtkLabelPlacer.vtkLabelPlacer_SetGeneratePerturbedLabelSpokes_30(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacer_SetGravity_31(HandleRef pThis, int gravity);

		public virtual void SetGravity(int gravity)
		{
			vtkLabelPlacer.vtkLabelPlacer_SetGravity_31(base.GetCppThis(), gravity);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacer_SetIteratorType_32(HandleRef pThis, int _arg);

		public virtual void SetIteratorType(int _arg)
		{
			vtkLabelPlacer.vtkLabelPlacer_SetIteratorType_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacer_SetMaximumLabelFraction_33(HandleRef pThis, double _arg);

		public virtual void SetMaximumLabelFraction(double _arg)
		{
			vtkLabelPlacer.vtkLabelPlacer_SetMaximumLabelFraction_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacer_SetOutputCoordinateSystem_34(HandleRef pThis, int _arg);

		public virtual void SetOutputCoordinateSystem(int _arg)
		{
			vtkLabelPlacer.vtkLabelPlacer_SetOutputCoordinateSystem_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacer_SetOutputTraversedBounds_35(HandleRef pThis, byte _arg);

		public virtual void SetOutputTraversedBounds(bool _arg)
		{
			vtkLabelPlacer.vtkLabelPlacer_SetOutputTraversedBounds_35(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacer_SetPositionsAsNormals_36(HandleRef pThis, byte _arg);

		public virtual void SetPositionsAsNormals(bool _arg)
		{
			vtkLabelPlacer.vtkLabelPlacer_SetPositionsAsNormals_36(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacer_SetRenderer_37(HandleRef pThis, HandleRef arg0);

		public virtual void SetRenderer(vtkRenderer arg0)
		{
			vtkLabelPlacer.vtkLabelPlacer_SetRenderer_37(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacer_SetUseDepthBuffer_38(HandleRef pThis, byte _arg);

		public virtual void SetUseDepthBuffer(bool _arg)
		{
			vtkLabelPlacer.vtkLabelPlacer_SetUseDepthBuffer_38(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacer_SetUseUnicodeStrings_39(HandleRef pThis, byte _arg);

		public virtual void SetUseUnicodeStrings(bool _arg)
		{
			vtkLabelPlacer.vtkLabelPlacer_SetUseUnicodeStrings_39(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacer_UseDepthBufferOff_40(HandleRef pThis);

		public virtual void UseDepthBufferOff()
		{
			vtkLabelPlacer.vtkLabelPlacer_UseDepthBufferOff_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacer_UseDepthBufferOn_41(HandleRef pThis);

		public virtual void UseDepthBufferOn()
		{
			vtkLabelPlacer.vtkLabelPlacer_UseDepthBufferOn_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacer_UseUnicodeStringsOff_42(HandleRef pThis);

		public virtual void UseUnicodeStringsOff()
		{
			vtkLabelPlacer.vtkLabelPlacer_UseUnicodeStringsOff_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLabelPlacer_UseUnicodeStringsOn_43(HandleRef pThis);

		public virtual void UseUnicodeStringsOn()
		{
			vtkLabelPlacer.vtkLabelPlacer_UseUnicodeStringsOn_43(base.GetCppThis());
		}
	}
}
