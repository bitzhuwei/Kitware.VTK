using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkScalarBarRepresentation : vtkBorderRepresentation
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkScalarBarRepresentation";

		public new static readonly string MRClassNameKey;

		static vtkScalarBarRepresentation()
		{
			vtkScalarBarRepresentation.MRClassNameKey = "class vtkScalarBarRepresentation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkScalarBarRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkScalarBarRepresentation"));
		}

		public vtkScalarBarRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkScalarBarRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkScalarBarRepresentation New()
		{
			vtkScalarBarRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkScalarBarRepresentation.vtkScalarBarRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkScalarBarRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkScalarBarRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkScalarBarRepresentation.vtkScalarBarRepresentation_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkScalarBarRepresentation_BuildRepresentation_01(HandleRef pThis);

		public override void BuildRepresentation()
		{
			vtkScalarBarRepresentation.vtkScalarBarRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkScalarBarRepresentation_GetActors2D_02(HandleRef pThis, HandleRef collection);

		public override void GetActors2D(vtkPropCollection collection)
		{
			vtkScalarBarRepresentation.vtkScalarBarRepresentation_GetActors2D_02(base.GetCppThis(), (collection == null) ? default(HandleRef) : collection.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkScalarBarRepresentation_GetOrientation_03(HandleRef pThis);

		public int GetOrientation()
		{
			return vtkScalarBarRepresentation.vtkScalarBarRepresentation_GetOrientation_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkScalarBarRepresentation_GetScalarBarActor_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkScalarBarActor GetScalarBarActor()
		{
			vtkScalarBarActor vtkScalarBarActor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkScalarBarRepresentation.vtkScalarBarRepresentation_GetScalarBarActor_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarBarActor = (vtkScalarBarActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarBarActor.Register(null);
				}
			}
			return vtkScalarBarActor;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkScalarBarRepresentation_GetSize_05(HandleRef pThis, IntPtr size);

		public override void GetSize(IntPtr size)
		{
			vtkScalarBarRepresentation.vtkScalarBarRepresentation_GetSize_05(base.GetCppThis(), size);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkScalarBarRepresentation_HasTranslucentPolygonalGeometry_06(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkScalarBarRepresentation.vtkScalarBarRepresentation_HasTranslucentPolygonalGeometry_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkScalarBarRepresentation_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkScalarBarRepresentation.vtkScalarBarRepresentation_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkScalarBarRepresentation_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkScalarBarRepresentation.vtkScalarBarRepresentation_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkScalarBarRepresentation_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkScalarBarRepresentation NewInstance()
		{
			vtkScalarBarRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkScalarBarRepresentation.vtkScalarBarRepresentation_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkScalarBarRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkScalarBarRepresentation_ReleaseGraphicsResources_11(HandleRef pThis, HandleRef window);

		public override void ReleaseGraphicsResources(vtkWindow window)
		{
			vtkScalarBarRepresentation.vtkScalarBarRepresentation_ReleaseGraphicsResources_11(base.GetCppThis(), (window == null) ? default(HandleRef) : window.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkScalarBarRepresentation_RenderOpaqueGeometry_12(HandleRef pThis, HandleRef arg0);

		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkScalarBarRepresentation.vtkScalarBarRepresentation_RenderOpaqueGeometry_12(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkScalarBarRepresentation_RenderOverlay_13(HandleRef pThis, HandleRef arg0);

		public override int RenderOverlay(vtkViewport arg0)
		{
			return vtkScalarBarRepresentation.vtkScalarBarRepresentation_RenderOverlay_13(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkScalarBarRepresentation_RenderTranslucentPolygonalGeometry_14(HandleRef pThis, HandleRef arg0);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkScalarBarRepresentation.vtkScalarBarRepresentation_RenderTranslucentPolygonalGeometry_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkScalarBarRepresentation_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkScalarBarRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkScalarBarRepresentation vtkScalarBarRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkScalarBarRepresentation.vtkScalarBarRepresentation_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarBarRepresentation = (vtkScalarBarRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarBarRepresentation.Register(null);
				}
			}
			return vtkScalarBarRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkScalarBarRepresentation_SetOrientation_16(HandleRef pThis, int orient);

		public void SetOrientation(int orient)
		{
			vtkScalarBarRepresentation.vtkScalarBarRepresentation_SetOrientation_16(base.GetCppThis(), orient);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkScalarBarRepresentation_SetScalarBarActor_17(HandleRef pThis, HandleRef arg0);

		public virtual void SetScalarBarActor(vtkScalarBarActor arg0)
		{
			vtkScalarBarRepresentation.vtkScalarBarRepresentation_SetScalarBarActor_17(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkScalarBarRepresentation_WidgetInteraction_18(HandleRef pThis, IntPtr eventPos);

		public override void WidgetInteraction(IntPtr eventPos)
		{
			vtkScalarBarRepresentation.vtkScalarBarRepresentation_WidgetInteraction_18(base.GetCppThis(), eventPos);
		}
	}
}
