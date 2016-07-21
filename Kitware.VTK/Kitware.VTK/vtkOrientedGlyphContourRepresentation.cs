using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkOrientedGlyphContourRepresentation : vtkContourRepresentation
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkOrientedGlyphContourRepresentation";

		public new static readonly string MRClassNameKey;

		static vtkOrientedGlyphContourRepresentation()
		{
			vtkOrientedGlyphContourRepresentation.MRClassNameKey = "class vtkOrientedGlyphContourRepresentation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOrientedGlyphContourRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOrientedGlyphContourRepresentation"));
		}

		public vtkOrientedGlyphContourRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkOrientedGlyphContourRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOrientedGlyphContourRepresentation New()
		{
			vtkOrientedGlyphContourRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOrientedGlyphContourRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkOrientedGlyphContourRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkOrientedGlyphContourRepresentation_AlwaysOnTopOff_01(HandleRef pThis);

		public virtual void AlwaysOnTopOff()
		{
			vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_AlwaysOnTopOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkOrientedGlyphContourRepresentation_AlwaysOnTopOn_02(HandleRef pThis);

		public virtual void AlwaysOnTopOn()
		{
			vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_AlwaysOnTopOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkOrientedGlyphContourRepresentation_BuildRepresentation_03(HandleRef pThis);

		public override void BuildRepresentation()
		{
			vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_BuildRepresentation_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkOrientedGlyphContourRepresentation_ComputeInteractionState_04(HandleRef pThis, int X, int Y, int modified);

		public override int ComputeInteractionState(int X, int Y, int modified)
		{
			return vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_ComputeInteractionState_04(base.GetCppThis(), X, Y, modified);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkOrientedGlyphContourRepresentation_GetActiveCursorShape_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPolyData GetActiveCursorShape()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_GetActiveCursorShape_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkOrientedGlyphContourRepresentation_GetActiveProperty_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetActiveProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_GetActiveProperty_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkOrientedGlyphContourRepresentation_GetActors_07(HandleRef pThis, HandleRef arg0);

		public override void GetActors(vtkPropCollection arg0)
		{
			vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_GetActors_07(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkOrientedGlyphContourRepresentation_GetAlwaysOnTop_08(HandleRef pThis);

		public virtual int GetAlwaysOnTop()
		{
			return vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_GetAlwaysOnTop_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkOrientedGlyphContourRepresentation_GetBounds_09(HandleRef pThis);

		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_GetBounds_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkOrientedGlyphContourRepresentation_GetContourRepresentationAsPolyData_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkPolyData GetContourRepresentationAsPolyData()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_GetContourRepresentationAsPolyData_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkOrientedGlyphContourRepresentation_GetCursorShape_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPolyData GetCursorShape()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_GetCursorShape_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkOrientedGlyphContourRepresentation_GetLinesProperty_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetLinesProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_GetLinesProperty_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkOrientedGlyphContourRepresentation_GetProperty_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_GetProperty_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkOrientedGlyphContourRepresentation_HasTranslucentPolygonalGeometry_14(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_HasTranslucentPolygonalGeometry_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkOrientedGlyphContourRepresentation_IsA_15(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_IsA_15(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkOrientedGlyphContourRepresentation_IsTypeOf_16(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_IsTypeOf_16(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkOrientedGlyphContourRepresentation_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkOrientedGlyphContourRepresentation NewInstance()
		{
			vtkOrientedGlyphContourRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_NewInstance_18(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOrientedGlyphContourRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkOrientedGlyphContourRepresentation_ReleaseGraphicsResources_19(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_ReleaseGraphicsResources_19(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkOrientedGlyphContourRepresentation_RenderOpaqueGeometry_20(HandleRef pThis, HandleRef viewport);

		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_RenderOpaqueGeometry_20(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkOrientedGlyphContourRepresentation_RenderOverlay_21(HandleRef pThis, HandleRef viewport);

		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_RenderOverlay_21(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkOrientedGlyphContourRepresentation_RenderTranslucentPolygonalGeometry_22(HandleRef pThis, HandleRef viewport);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_RenderTranslucentPolygonalGeometry_22(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkOrientedGlyphContourRepresentation_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOrientedGlyphContourRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkOrientedGlyphContourRepresentation vtkOrientedGlyphContourRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOrientedGlyphContourRepresentation = (vtkOrientedGlyphContourRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOrientedGlyphContourRepresentation.Register(null);
				}
			}
			return vtkOrientedGlyphContourRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkOrientedGlyphContourRepresentation_SetActiveCursorShape_24(HandleRef pThis, HandleRef activeShape);

		public void SetActiveCursorShape(vtkPolyData activeShape)
		{
			vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_SetActiveCursorShape_24(base.GetCppThis(), (activeShape == null) ? default(HandleRef) : activeShape.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkOrientedGlyphContourRepresentation_SetAlwaysOnTop_25(HandleRef pThis, int _arg);

		public virtual void SetAlwaysOnTop(int _arg)
		{
			vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_SetAlwaysOnTop_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkOrientedGlyphContourRepresentation_SetCursorShape_26(HandleRef pThis, HandleRef cursorShape);

		public void SetCursorShape(vtkPolyData cursorShape)
		{
			vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_SetCursorShape_26(base.GetCppThis(), (cursorShape == null) ? default(HandleRef) : cursorShape.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkOrientedGlyphContourRepresentation_SetLineColor_27(HandleRef pThis, double r, double g, double b);

		public void SetLineColor(double r, double g, double b)
		{
			vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_SetLineColor_27(base.GetCppThis(), r, g, b);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkOrientedGlyphContourRepresentation_SetRenderer_28(HandleRef pThis, HandleRef ren);

		public override void SetRenderer(vtkRenderer ren)
		{
			vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_SetRenderer_28(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkOrientedGlyphContourRepresentation_SetShowSelectedNodes_29(HandleRef pThis, int arg0);

		public override void SetShowSelectedNodes(int arg0)
		{
			vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_SetShowSelectedNodes_29(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkOrientedGlyphContourRepresentation_StartWidgetInteraction_30(HandleRef pThis, IntPtr eventPos);

		public override void StartWidgetInteraction(IntPtr eventPos)
		{
			vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_StartWidgetInteraction_30(base.GetCppThis(), eventPos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkOrientedGlyphContourRepresentation_WidgetInteraction_31(HandleRef pThis, IntPtr eventPos);

		public override void WidgetInteraction(IntPtr eventPos)
		{
			vtkOrientedGlyphContourRepresentation.vtkOrientedGlyphContourRepresentation_WidgetInteraction_31(base.GetCppThis(), eventPos);
		}
	}
}
