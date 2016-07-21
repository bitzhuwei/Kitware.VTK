using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkRectilinearWipeRepresentation : vtkWidgetRepresentation
	{
		public enum _InteractionState
		{
			MovingCenter = 3,
			MovingHPane = 1,
			MovingVPane,
			Outside = 0
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkRectilinearWipeRepresentation";

		public new static readonly string MRClassNameKey;

		static vtkRectilinearWipeRepresentation()
		{
			vtkRectilinearWipeRepresentation.MRClassNameKey = "class vtkRectilinearWipeRepresentation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRectilinearWipeRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRectilinearWipeRepresentation"));
		}

		public vtkRectilinearWipeRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkRectilinearWipeRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRectilinearWipeRepresentation New()
		{
			vtkRectilinearWipeRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectilinearWipeRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkRectilinearWipeRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkRectilinearWipeRepresentation_BuildRepresentation_01(HandleRef pThis);

		public override void BuildRepresentation()
		{
			vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkRectilinearWipeRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_ComputeInteractionState_02(base.GetCppThis(), X, Y, modify);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkRectilinearWipeRepresentation_GetActors2D_03(HandleRef pThis, HandleRef arg0);

		public override void GetActors2D(vtkPropCollection arg0)
		{
			vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_GetActors2D_03(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkRectilinearWipeRepresentation_GetImageActor_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImageActor GetImageActor()
		{
			vtkImageActor vtkImageActor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_GetImageActor_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageActor = (vtkImageActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageActor.Register(null);
				}
			}
			return vtkImageActor;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkRectilinearWipeRepresentation_GetProperty_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty2D GetProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_GetProperty_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkRectilinearWipeRepresentation_GetRectilinearWipe_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImageRectilinearWipe GetRectilinearWipe()
		{
			vtkImageRectilinearWipe vtkImageRectilinearWipe = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_GetRectilinearWipe_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageRectilinearWipe = (vtkImageRectilinearWipe)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageRectilinearWipe.Register(null);
				}
			}
			return vtkImageRectilinearWipe;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkRectilinearWipeRepresentation_GetTolerance_07(HandleRef pThis);

		public virtual int GetTolerance()
		{
			return vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_GetTolerance_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkRectilinearWipeRepresentation_GetToleranceMaxValue_08(HandleRef pThis);

		public virtual int GetToleranceMaxValue()
		{
			return vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_GetToleranceMaxValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkRectilinearWipeRepresentation_GetToleranceMinValue_09(HandleRef pThis);

		public virtual int GetToleranceMinValue()
		{
			return vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_GetToleranceMinValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkRectilinearWipeRepresentation_HasTranslucentPolygonalGeometry_10(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_HasTranslucentPolygonalGeometry_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkRectilinearWipeRepresentation_IsA_11(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_IsA_11(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkRectilinearWipeRepresentation_IsTypeOf_12(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_IsTypeOf_12(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkRectilinearWipeRepresentation_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRectilinearWipeRepresentation NewInstance()
		{
			vtkRectilinearWipeRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_NewInstance_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRectilinearWipeRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkRectilinearWipeRepresentation_ReleaseGraphicsResources_15(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_ReleaseGraphicsResources_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkRectilinearWipeRepresentation_RenderOpaqueGeometry_16(HandleRef pThis, HandleRef viewport);

		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_RenderOpaqueGeometry_16(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkRectilinearWipeRepresentation_RenderOverlay_17(HandleRef pThis, HandleRef viewport);

		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_RenderOverlay_17(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkRectilinearWipeRepresentation_RenderTranslucentPolygonalGeometry_18(HandleRef pThis, HandleRef viewport);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_RenderTranslucentPolygonalGeometry_18(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkRectilinearWipeRepresentation_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRectilinearWipeRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkRectilinearWipeRepresentation vtkRectilinearWipeRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRectilinearWipeRepresentation = (vtkRectilinearWipeRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRectilinearWipeRepresentation.Register(null);
				}
			}
			return vtkRectilinearWipeRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkRectilinearWipeRepresentation_SetImageActor_20(HandleRef pThis, HandleRef imageActor);

		public void SetImageActor(vtkImageActor imageActor)
		{
			vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_SetImageActor_20(base.GetCppThis(), (imageActor == null) ? default(HandleRef) : imageActor.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkRectilinearWipeRepresentation_SetRectilinearWipe_21(HandleRef pThis, HandleRef wipe);

		public void SetRectilinearWipe(vtkImageRectilinearWipe wipe)
		{
			vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_SetRectilinearWipe_21(base.GetCppThis(), (wipe == null) ? default(HandleRef) : wipe.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkRectilinearWipeRepresentation_SetTolerance_22(HandleRef pThis, int _arg);

		public virtual void SetTolerance(int _arg)
		{
			vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_SetTolerance_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkRectilinearWipeRepresentation_StartWidgetInteraction_23(HandleRef pThis, IntPtr eventPos);

		public override void StartWidgetInteraction(IntPtr eventPos)
		{
			vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_StartWidgetInteraction_23(base.GetCppThis(), eventPos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkRectilinearWipeRepresentation_WidgetInteraction_24(HandleRef pThis, IntPtr eventPos);

		public override void WidgetInteraction(IntPtr eventPos)
		{
			vtkRectilinearWipeRepresentation.vtkRectilinearWipeRepresentation_WidgetInteraction_24(base.GetCppThis(), eventPos);
		}
	}
}
