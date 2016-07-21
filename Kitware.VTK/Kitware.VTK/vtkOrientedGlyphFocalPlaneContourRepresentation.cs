using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkOrientedGlyphFocalPlaneContourRepresentation : vtkFocalPlaneContourRepresentation
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkOrientedGlyphFocalPlaneContourRepresentation";

		public new static readonly string MRClassNameKey;

		static vtkOrientedGlyphFocalPlaneContourRepresentation()
		{
			vtkOrientedGlyphFocalPlaneContourRepresentation.MRClassNameKey = "class vtkOrientedGlyphFocalPlaneContourRepresentation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOrientedGlyphFocalPlaneContourRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOrientedGlyphFocalPlaneContourRepresentation"));
		}

		public vtkOrientedGlyphFocalPlaneContourRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkOrientedGlyphFocalPlaneContourRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOrientedGlyphFocalPlaneContourRepresentation New()
		{
			vtkOrientedGlyphFocalPlaneContourRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOrientedGlyphFocalPlaneContourRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkOrientedGlyphFocalPlaneContourRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkOrientedGlyphFocalPlaneContourRepresentation_BuildRepresentation_01(HandleRef pThis);

		public override void BuildRepresentation()
		{
			vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkOrientedGlyphFocalPlaneContourRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modified);

		public override int ComputeInteractionState(int X, int Y, int modified)
		{
			return vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_ComputeInteractionState_02(base.GetCppThis(), X, Y, modified);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkOrientedGlyphFocalPlaneContourRepresentation_GetActiveCursorShape_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPolyData GetActiveCursorShape()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_GetActiveCursorShape_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkOrientedGlyphFocalPlaneContourRepresentation_GetActiveProperty_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty2D GetActiveProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_GetActiveProperty_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkOrientedGlyphFocalPlaneContourRepresentation_GetActors2D_05(HandleRef pThis, HandleRef arg0);

		public override void GetActors2D(vtkPropCollection arg0)
		{
			vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_GetActors2D_05(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkOrientedGlyphFocalPlaneContourRepresentation_GetContourPlaneDirectionCosines_06(HandleRef pThis, IntPtr origin, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkMatrix4x4 GetContourPlaneDirectionCosines(IntPtr origin)
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_GetContourPlaneDirectionCosines_06(base.GetCppThis(), origin, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix4x = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix4x.Register(null);
				}
			}
			return vtkMatrix4x;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkOrientedGlyphFocalPlaneContourRepresentation_GetContourRepresentationAsPolyData_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkPolyData GetContourRepresentationAsPolyData()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_GetContourRepresentationAsPolyData_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkOrientedGlyphFocalPlaneContourRepresentation_GetCursorShape_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPolyData GetCursorShape()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_GetCursorShape_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkOrientedGlyphFocalPlaneContourRepresentation_GetLinesProperty_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty2D GetLinesProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_GetLinesProperty_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkOrientedGlyphFocalPlaneContourRepresentation_GetProperty_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty2D GetProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_GetProperty_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkOrientedGlyphFocalPlaneContourRepresentation_HasTranslucentPolygonalGeometry_11(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_HasTranslucentPolygonalGeometry_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkOrientedGlyphFocalPlaneContourRepresentation_IsA_12(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_IsA_12(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkOrientedGlyphFocalPlaneContourRepresentation_IsTypeOf_13(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_IsTypeOf_13(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkOrientedGlyphFocalPlaneContourRepresentation_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkOrientedGlyphFocalPlaneContourRepresentation NewInstance()
		{
			vtkOrientedGlyphFocalPlaneContourRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_NewInstance_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOrientedGlyphFocalPlaneContourRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkOrientedGlyphFocalPlaneContourRepresentation_ReleaseGraphicsResources_16(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_ReleaseGraphicsResources_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkOrientedGlyphFocalPlaneContourRepresentation_RenderOpaqueGeometry_17(HandleRef pThis, HandleRef viewport);

		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_RenderOpaqueGeometry_17(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkOrientedGlyphFocalPlaneContourRepresentation_RenderOverlay_18(HandleRef pThis, HandleRef viewport);

		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_RenderOverlay_18(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkOrientedGlyphFocalPlaneContourRepresentation_RenderTranslucentPolygonalGeometry_19(HandleRef pThis, HandleRef viewport);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_RenderTranslucentPolygonalGeometry_19(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkOrientedGlyphFocalPlaneContourRepresentation_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOrientedGlyphFocalPlaneContourRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkOrientedGlyphFocalPlaneContourRepresentation vtkOrientedGlyphFocalPlaneContourRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOrientedGlyphFocalPlaneContourRepresentation = (vtkOrientedGlyphFocalPlaneContourRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOrientedGlyphFocalPlaneContourRepresentation.Register(null);
				}
			}
			return vtkOrientedGlyphFocalPlaneContourRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkOrientedGlyphFocalPlaneContourRepresentation_SetActiveCursorShape_21(HandleRef pThis, HandleRef activeShape);

		public void SetActiveCursorShape(vtkPolyData activeShape)
		{
			vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_SetActiveCursorShape_21(base.GetCppThis(), (activeShape == null) ? default(HandleRef) : activeShape.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkOrientedGlyphFocalPlaneContourRepresentation_SetCursorShape_22(HandleRef pThis, HandleRef cursorShape);

		public void SetCursorShape(vtkPolyData cursorShape)
		{
			vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_SetCursorShape_22(base.GetCppThis(), (cursorShape == null) ? default(HandleRef) : cursorShape.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkOrientedGlyphFocalPlaneContourRepresentation_SetRenderer_23(HandleRef pThis, HandleRef ren);

		public override void SetRenderer(vtkRenderer ren)
		{
			vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_SetRenderer_23(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkOrientedGlyphFocalPlaneContourRepresentation_StartWidgetInteraction_24(HandleRef pThis, IntPtr eventPos);

		public override void StartWidgetInteraction(IntPtr eventPos)
		{
			vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_StartWidgetInteraction_24(base.GetCppThis(), eventPos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkOrientedGlyphFocalPlaneContourRepresentation_WidgetInteraction_25(HandleRef pThis, IntPtr eventPos);

		public override void WidgetInteraction(IntPtr eventPos)
		{
			vtkOrientedGlyphFocalPlaneContourRepresentation.vtkOrientedGlyphFocalPlaneContourRepresentation_WidgetInteraction_25(base.GetCppThis(), eventPos);
		}
	}
}
