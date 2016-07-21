using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTextRepresentation : vtkBorderRepresentation
	{
		public enum AnyLocation_WrapperEnum
		{
			AnyLocation,
			LowerCenter = 3,
			LowerLeftCorner = 1,
			LowerRightCorner,
			UpperCenter = 6,
			UpperLeftCorner = 4,
			UpperRightCorner
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkTextRepresentation";

		public new static readonly string MRClassNameKey;

		static vtkTextRepresentation()
		{
			vtkTextRepresentation.MRClassNameKey = "class vtkTextRepresentation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTextRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTextRepresentation"));
		}

		public vtkTextRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkTextRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTextRepresentation New()
		{
			vtkTextRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTextRepresentation.vtkTextRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTextRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTextRepresentation.vtkTextRepresentation_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTextRepresentation_BuildRepresentation_01(HandleRef pThis);

		public override void BuildRepresentation()
		{
			vtkTextRepresentation.vtkTextRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTextRepresentation_ExecuteTextActorModifiedEvent_02(HandleRef pThis, HandleRef obj, uint enumEvent, IntPtr p);

		public void ExecuteTextActorModifiedEvent(vtkObject obj, uint enumEvent, IntPtr p)
		{
			vtkTextRepresentation.vtkTextRepresentation_ExecuteTextActorModifiedEvent_02(base.GetCppThis(), (obj == null) ? default(HandleRef) : obj.GetCppThis(), enumEvent, p);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTextRepresentation_ExecuteTextPropertyModifiedEvent_03(HandleRef pThis, HandleRef obj, uint enumEvent, IntPtr p);

		public void ExecuteTextPropertyModifiedEvent(vtkObject obj, uint enumEvent, IntPtr p)
		{
			vtkTextRepresentation.vtkTextRepresentation_ExecuteTextPropertyModifiedEvent_03(base.GetCppThis(), (obj == null) ? default(HandleRef) : obj.GetCppThis(), enumEvent, p);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTextRepresentation_GetActors2D_04(HandleRef pThis, HandleRef arg0);

		public override void GetActors2D(vtkPropCollection arg0)
		{
			vtkTextRepresentation.vtkTextRepresentation_GetActors2D_04(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTextRepresentation_GetSize_05(HandleRef pThis, IntPtr size);

		public override void GetSize(IntPtr size)
		{
			vtkTextRepresentation.vtkTextRepresentation_GetSize_05(base.GetCppThis(), size);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkTextRepresentation_GetText_06(HandleRef pThis);

		public string GetText()
		{
			return Marshal.PtrToStringAnsi(vtkTextRepresentation.vtkTextRepresentation_GetText_06(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkTextRepresentation_GetTextActor_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextActor GetTextActor()
		{
			vtkTextActor vtkTextActor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTextRepresentation.vtkTextRepresentation_GetTextActor_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextActor = (vtkTextActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextActor.Register(null);
				}
			}
			return vtkTextActor;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkTextRepresentation_GetWindowLocation_08(HandleRef pThis);

		public virtual int GetWindowLocation()
		{
			return vtkTextRepresentation.vtkTextRepresentation_GetWindowLocation_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkTextRepresentation_HasTranslucentPolygonalGeometry_09(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkTextRepresentation.vtkTextRepresentation_HasTranslucentPolygonalGeometry_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkTextRepresentation_IsA_10(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTextRepresentation.vtkTextRepresentation_IsA_10(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkTextRepresentation_IsTypeOf_11(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTextRepresentation.vtkTextRepresentation_IsTypeOf_11(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkTextRepresentation_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTextRepresentation NewInstance()
		{
			vtkTextRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTextRepresentation.vtkTextRepresentation_NewInstance_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTextRepresentation_ReleaseGraphicsResources_14(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkTextRepresentation.vtkTextRepresentation_ReleaseGraphicsResources_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkTextRepresentation_RenderOpaqueGeometry_15(HandleRef pThis, HandleRef arg0);

		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkTextRepresentation.vtkTextRepresentation_RenderOpaqueGeometry_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkTextRepresentation_RenderOverlay_16(HandleRef pThis, HandleRef arg0);

		public override int RenderOverlay(vtkViewport arg0)
		{
			return vtkTextRepresentation.vtkTextRepresentation_RenderOverlay_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkTextRepresentation_RenderTranslucentPolygonalGeometry_17(HandleRef pThis, HandleRef arg0);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkTextRepresentation.vtkTextRepresentation_RenderTranslucentPolygonalGeometry_17(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkTextRepresentation_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTextRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkTextRepresentation vtkTextRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTextRepresentation.vtkTextRepresentation_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextRepresentation = (vtkTextRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextRepresentation.Register(null);
				}
			}
			return vtkTextRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTextRepresentation_SetPosition_19(HandleRef pThis, double x, double y);

		public override void SetPosition(double x, double y)
		{
			vtkTextRepresentation.vtkTextRepresentation_SetPosition_19(base.GetCppThis(), x, y);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTextRepresentation_SetPosition_20(HandleRef pThis, IntPtr pos);

		public override void SetPosition(IntPtr pos)
		{
			vtkTextRepresentation.vtkTextRepresentation_SetPosition_20(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTextRepresentation_SetText_21(HandleRef pThis, string text);

		public void SetText(string text)
		{
			vtkTextRepresentation.vtkTextRepresentation_SetText_21(base.GetCppThis(), text);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTextRepresentation_SetTextActor_22(HandleRef pThis, HandleRef textActor);

		public void SetTextActor(vtkTextActor textActor)
		{
			vtkTextRepresentation.vtkTextRepresentation_SetTextActor_22(base.GetCppThis(), (textActor == null) ? default(HandleRef) : textActor.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTextRepresentation_SetWindowLocation_23(HandleRef pThis, int enumLocation);

		public virtual void SetWindowLocation(int enumLocation)
		{
			vtkTextRepresentation.vtkTextRepresentation_SetWindowLocation_23(base.GetCppThis(), enumLocation);
		}
	}
}
