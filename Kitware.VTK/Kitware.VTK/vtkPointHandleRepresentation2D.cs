using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPointHandleRepresentation2D : vtkHandleRepresentation
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPointHandleRepresentation2D";

		public new static readonly string MRClassNameKey;

		static vtkPointHandleRepresentation2D()
		{
			vtkPointHandleRepresentation2D.MRClassNameKey = "class vtkPointHandleRepresentation2D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPointHandleRepresentation2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointHandleRepresentation2D"));
		}

		public vtkPointHandleRepresentation2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPointHandleRepresentation2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPointHandleRepresentation2D New()
		{
			vtkPointHandleRepresentation2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPointHandleRepresentation2D.vtkPointHandleRepresentation2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointHandleRepresentation2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPointHandleRepresentation2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPointHandleRepresentation2D.vtkPointHandleRepresentation2D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointHandleRepresentation2D_BuildRepresentation_01(HandleRef pThis);

		public override void BuildRepresentation()
		{
			vtkPointHandleRepresentation2D.vtkPointHandleRepresentation2D_BuildRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPointHandleRepresentation2D_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkPointHandleRepresentation2D.vtkPointHandleRepresentation2D_ComputeInteractionState_02(base.GetCppThis(), X, Y, modify);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointHandleRepresentation2D_DeepCopy_03(HandleRef pThis, HandleRef prop);

		public override void DeepCopy(vtkProp prop)
		{
			vtkPointHandleRepresentation2D.vtkPointHandleRepresentation2D_DeepCopy_03(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointHandleRepresentation2D_GetActors2D_04(HandleRef pThis, HandleRef arg0);

		public override void GetActors2D(vtkPropCollection arg0)
		{
			vtkPointHandleRepresentation2D.vtkPointHandleRepresentation2D_GetActors2D_04(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPointHandleRepresentation2D_GetBounds_05(HandleRef pThis);

		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkPointHandleRepresentation2D.vtkPointHandleRepresentation2D_GetBounds_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPointHandleRepresentation2D_GetCursorShape_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPolyData GetCursorShape()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPointHandleRepresentation2D.vtkPointHandleRepresentation2D_GetCursorShape_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkPointHandleRepresentation2D_GetProperty_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty2D GetProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPointHandleRepresentation2D.vtkPointHandleRepresentation2D_GetProperty_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkPointHandleRepresentation2D_GetSelectedProperty_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty2D GetSelectedProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPointHandleRepresentation2D.vtkPointHandleRepresentation2D_GetSelectedProperty_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkPointHandleRepresentation2D_Highlight_09(HandleRef pThis, int highlight);

		public override void Highlight(int highlight)
		{
			vtkPointHandleRepresentation2D.vtkPointHandleRepresentation2D_Highlight_09(base.GetCppThis(), highlight);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPointHandleRepresentation2D_IsA_10(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPointHandleRepresentation2D.vtkPointHandleRepresentation2D_IsA_10(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPointHandleRepresentation2D_IsTypeOf_11(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPointHandleRepresentation2D.vtkPointHandleRepresentation2D_IsTypeOf_11(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPointHandleRepresentation2D_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPointHandleRepresentation2D NewInstance()
		{
			vtkPointHandleRepresentation2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPointHandleRepresentation2D.vtkPointHandleRepresentation2D_NewInstance_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPointHandleRepresentation2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointHandleRepresentation2D_ReleaseGraphicsResources_14(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkPointHandleRepresentation2D.vtkPointHandleRepresentation2D_ReleaseGraphicsResources_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPointHandleRepresentation2D_RenderOverlay_15(HandleRef pThis, HandleRef viewport);

		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkPointHandleRepresentation2D.vtkPointHandleRepresentation2D_RenderOverlay_15(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPointHandleRepresentation2D_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPointHandleRepresentation2D SafeDownCast(vtkObjectBase o)
		{
			vtkPointHandleRepresentation2D vtkPointHandleRepresentation2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPointHandleRepresentation2D.vtkPointHandleRepresentation2D_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointHandleRepresentation2D = (vtkPointHandleRepresentation2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointHandleRepresentation2D.Register(null);
				}
			}
			return vtkPointHandleRepresentation2D;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointHandleRepresentation2D_SetCursorShape_17(HandleRef pThis, HandleRef cursorShape);

		public void SetCursorShape(vtkPolyData cursorShape)
		{
			vtkPointHandleRepresentation2D.vtkPointHandleRepresentation2D_SetCursorShape_17(base.GetCppThis(), (cursorShape == null) ? default(HandleRef) : cursorShape.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointHandleRepresentation2D_SetDisplayPosition_18(HandleRef pThis, IntPtr xyz);

		public override void SetDisplayPosition(IntPtr xyz)
		{
			vtkPointHandleRepresentation2D.vtkPointHandleRepresentation2D_SetDisplayPosition_18(base.GetCppThis(), xyz);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointHandleRepresentation2D_SetPointPlacer_19(HandleRef pThis, HandleRef arg0);

		public override void SetPointPlacer(vtkPointPlacer arg0)
		{
			vtkPointHandleRepresentation2D.vtkPointHandleRepresentation2D_SetPointPlacer_19(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointHandleRepresentation2D_SetProperty_20(HandleRef pThis, HandleRef arg0);

		public void SetProperty(vtkProperty2D arg0)
		{
			vtkPointHandleRepresentation2D.vtkPointHandleRepresentation2D_SetProperty_20(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointHandleRepresentation2D_SetSelectedProperty_21(HandleRef pThis, HandleRef arg0);

		public void SetSelectedProperty(vtkProperty2D arg0)
		{
			vtkPointHandleRepresentation2D.vtkPointHandleRepresentation2D_SetSelectedProperty_21(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointHandleRepresentation2D_ShallowCopy_22(HandleRef pThis, HandleRef prop);

		public override void ShallowCopy(vtkProp prop)
		{
			vtkPointHandleRepresentation2D.vtkPointHandleRepresentation2D_ShallowCopy_22(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointHandleRepresentation2D_StartWidgetInteraction_23(HandleRef pThis, IntPtr eventPos);

		public override void StartWidgetInteraction(IntPtr eventPos)
		{
			vtkPointHandleRepresentation2D.vtkPointHandleRepresentation2D_StartWidgetInteraction_23(base.GetCppThis(), eventPos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPointHandleRepresentation2D_WidgetInteraction_24(HandleRef pThis, IntPtr eventPos);

		public override void WidgetInteraction(IntPtr eventPos)
		{
			vtkPointHandleRepresentation2D.vtkPointHandleRepresentation2D_WidgetInteraction_24(base.GetCppThis(), eventPos);
		}
	}
}
