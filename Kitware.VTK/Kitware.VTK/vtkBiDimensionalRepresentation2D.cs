using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkBiDimensionalRepresentation2D : vtkBiDimensionalRepresentation
	{
		public new enum NearP1_WrapperEnum
		{
			NearP1 = 1,
			NearP2,
			NearP3,
			NearP4,
			OnCenter = 9,
			OnL1Inner = 5,
			OnL1Outer,
			OnL2Inner,
			OnL2Outer,
			Outside = 0
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkBiDimensionalRepresentation2D";

		public new static readonly string MRClassNameKey;

		static vtkBiDimensionalRepresentation2D()
		{
			vtkBiDimensionalRepresentation2D.MRClassNameKey = "class vtkBiDimensionalRepresentation2D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBiDimensionalRepresentation2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBiDimensionalRepresentation2D"));
		}

		public vtkBiDimensionalRepresentation2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBiDimensionalRepresentation2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBiDimensionalRepresentation2D New()
		{
			vtkBiDimensionalRepresentation2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBiDimensionalRepresentation2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkBiDimensionalRepresentation2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalRepresentation2D_BuildRepresentation_01(HandleRef pThis);

		public override void BuildRepresentation()
		{
			vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_BuildRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBiDimensionalRepresentation2D_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_ComputeInteractionState_02(base.GetCppThis(), X, Y, modify);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBiDimensionalRepresentation2D_GetLabelPosition_03(HandleRef pThis);

		public override IntPtr GetLabelPosition()
		{
			return vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_GetLabelPosition_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalRepresentation2D_GetLabelPosition_04(HandleRef pThis, IntPtr pos);

		public override void GetLabelPosition(IntPtr pos)
		{
			vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_GetLabelPosition_04(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBiDimensionalRepresentation2D_GetLabelText_05(HandleRef pThis);

		public override string GetLabelText()
		{
			return Marshal.PtrToStringAnsi(vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_GetLabelText_05(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBiDimensionalRepresentation2D_GetLineProperty_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty2D GetLineProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_GetLineProperty_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkBiDimensionalRepresentation2D_GetSelectedLineProperty_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty2D GetSelectedLineProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_GetSelectedLineProperty_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkBiDimensionalRepresentation2D_GetTextProperty_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextProperty GetTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_GetTextProperty_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalRepresentation2D_GetWorldLabelPosition_09(HandleRef pThis, IntPtr pos);

		public override void GetWorldLabelPosition(IntPtr pos)
		{
			vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_GetWorldLabelPosition_09(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalRepresentation2D_Highlight_10(HandleRef pThis, int highlightOn);

		public override void Highlight(int highlightOn)
		{
			vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_Highlight_10(base.GetCppThis(), highlightOn);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBiDimensionalRepresentation2D_IsA_11(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_IsA_11(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBiDimensionalRepresentation2D_IsTypeOf_12(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_IsTypeOf_12(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBiDimensionalRepresentation2D_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkBiDimensionalRepresentation2D NewInstance()
		{
			vtkBiDimensionalRepresentation2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_NewInstance_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBiDimensionalRepresentation2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalRepresentation2D_Point2WidgetInteraction_15(HandleRef pThis, IntPtr e);

		public override void Point2WidgetInteraction(IntPtr e)
		{
			vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_Point2WidgetInteraction_15(base.GetCppThis(), e);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalRepresentation2D_Point3WidgetInteraction_16(HandleRef pThis, IntPtr e);

		public override void Point3WidgetInteraction(IntPtr e)
		{
			vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_Point3WidgetInteraction_16(base.GetCppThis(), e);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalRepresentation2D_ReleaseGraphicsResources_17(HandleRef pThis, HandleRef w);

		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_ReleaseGraphicsResources_17(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBiDimensionalRepresentation2D_RenderOverlay_18(HandleRef pThis, HandleRef viewport);

		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_RenderOverlay_18(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBiDimensionalRepresentation2D_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBiDimensionalRepresentation2D SafeDownCast(vtkObjectBase o)
		{
			vtkBiDimensionalRepresentation2D vtkBiDimensionalRepresentation2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBiDimensionalRepresentation2D = (vtkBiDimensionalRepresentation2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBiDimensionalRepresentation2D.Register(null);
				}
			}
			return vtkBiDimensionalRepresentation2D;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalRepresentation2D_StartWidgetDefinition_20(HandleRef pThis, IntPtr e);

		public override void StartWidgetDefinition(IntPtr e)
		{
			vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_StartWidgetDefinition_20(base.GetCppThis(), e);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalRepresentation2D_StartWidgetManipulation_21(HandleRef pThis, IntPtr e);

		public override void StartWidgetManipulation(IntPtr e)
		{
			vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_StartWidgetManipulation_21(base.GetCppThis(), e);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBiDimensionalRepresentation2D_WidgetInteraction_22(HandleRef pThis, IntPtr e);

		public override void WidgetInteraction(IntPtr e)
		{
			vtkBiDimensionalRepresentation2D.vtkBiDimensionalRepresentation2D_WidgetInteraction_22(base.GetCppThis(), e);
		}
	}
}
