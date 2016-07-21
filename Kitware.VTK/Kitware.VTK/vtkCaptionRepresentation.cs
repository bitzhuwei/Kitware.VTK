using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCaptionRepresentation : vtkBorderRepresentation
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCaptionRepresentation";

		public new static readonly string MRClassNameKey;

		static vtkCaptionRepresentation()
		{
			vtkCaptionRepresentation.MRClassNameKey = "class vtkCaptionRepresentation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCaptionRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCaptionRepresentation"));
		}

		public vtkCaptionRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkCaptionRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCaptionRepresentation New()
		{
			vtkCaptionRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCaptionRepresentation.vtkCaptionRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCaptionRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCaptionRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCaptionRepresentation.vtkCaptionRepresentation_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkCaptionRepresentation_BuildRepresentation_01(HandleRef pThis);

		public override void BuildRepresentation()
		{
			vtkCaptionRepresentation.vtkCaptionRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkCaptionRepresentation_GetActors2D_02(HandleRef pThis, HandleRef arg0);

		public override void GetActors2D(vtkPropCollection arg0)
		{
			vtkCaptionRepresentation.vtkCaptionRepresentation_GetActors2D_02(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkCaptionRepresentation_GetAnchorPosition_03(HandleRef pThis, IntPtr pos);

		public void GetAnchorPosition(IntPtr pos)
		{
			vtkCaptionRepresentation.vtkCaptionRepresentation_GetAnchorPosition_03(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkCaptionRepresentation_GetAnchorRepresentation_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPointHandleRepresentation3D GetAnchorRepresentation()
		{
			vtkPointHandleRepresentation3D vtkPointHandleRepresentation3D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCaptionRepresentation.vtkCaptionRepresentation_GetAnchorRepresentation_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointHandleRepresentation3D = (vtkPointHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointHandleRepresentation3D.Register(null);
				}
			}
			return vtkPointHandleRepresentation3D;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkCaptionRepresentation_GetCaptionActor2D_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCaptionActor2D GetCaptionActor2D()
		{
			vtkCaptionActor2D vtkCaptionActor2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCaptionRepresentation.vtkCaptionRepresentation_GetCaptionActor2D_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCaptionActor2D = (vtkCaptionActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCaptionActor2D.Register(null);
				}
			}
			return vtkCaptionActor2D;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkCaptionRepresentation_GetFontFactor_06(HandleRef pThis);

		public virtual double GetFontFactor()
		{
			return vtkCaptionRepresentation.vtkCaptionRepresentation_GetFontFactor_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkCaptionRepresentation_GetFontFactorMaxValue_07(HandleRef pThis);

		public virtual double GetFontFactorMaxValue()
		{
			return vtkCaptionRepresentation.vtkCaptionRepresentation_GetFontFactorMaxValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkCaptionRepresentation_GetFontFactorMinValue_08(HandleRef pThis);

		public virtual double GetFontFactorMinValue()
		{
			return vtkCaptionRepresentation.vtkCaptionRepresentation_GetFontFactorMinValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkCaptionRepresentation_GetSize_09(HandleRef pThis, IntPtr size);

		public override void GetSize(IntPtr size)
		{
			vtkCaptionRepresentation.vtkCaptionRepresentation_GetSize_09(base.GetCppThis(), size);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkCaptionRepresentation_HasTranslucentPolygonalGeometry_10(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkCaptionRepresentation.vtkCaptionRepresentation_HasTranslucentPolygonalGeometry_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkCaptionRepresentation_IsA_11(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCaptionRepresentation.vtkCaptionRepresentation_IsA_11(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkCaptionRepresentation_IsTypeOf_12(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCaptionRepresentation.vtkCaptionRepresentation_IsTypeOf_12(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkCaptionRepresentation_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCaptionRepresentation NewInstance()
		{
			vtkCaptionRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCaptionRepresentation.vtkCaptionRepresentation_NewInstance_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCaptionRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkCaptionRepresentation_ReleaseGraphicsResources_15(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkCaptionRepresentation.vtkCaptionRepresentation_ReleaseGraphicsResources_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkCaptionRepresentation_RenderOpaqueGeometry_16(HandleRef pThis, HandleRef arg0);

		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkCaptionRepresentation.vtkCaptionRepresentation_RenderOpaqueGeometry_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkCaptionRepresentation_RenderOverlay_17(HandleRef pThis, HandleRef arg0);

		public override int RenderOverlay(vtkViewport arg0)
		{
			return vtkCaptionRepresentation.vtkCaptionRepresentation_RenderOverlay_17(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkCaptionRepresentation_RenderTranslucentPolygonalGeometry_18(HandleRef pThis, HandleRef arg0);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkCaptionRepresentation.vtkCaptionRepresentation_RenderTranslucentPolygonalGeometry_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkCaptionRepresentation_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCaptionRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkCaptionRepresentation vtkCaptionRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCaptionRepresentation.vtkCaptionRepresentation_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCaptionRepresentation = (vtkCaptionRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCaptionRepresentation.Register(null);
				}
			}
			return vtkCaptionRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkCaptionRepresentation_SetAnchorPosition_20(HandleRef pThis, IntPtr pos);

		public void SetAnchorPosition(IntPtr pos)
		{
			vtkCaptionRepresentation.vtkCaptionRepresentation_SetAnchorPosition_20(base.GetCppThis(), pos);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkCaptionRepresentation_SetAnchorRepresentation_21(HandleRef pThis, HandleRef arg0);

		public void SetAnchorRepresentation(vtkPointHandleRepresentation3D arg0)
		{
			vtkCaptionRepresentation.vtkCaptionRepresentation_SetAnchorRepresentation_21(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkCaptionRepresentation_SetCaptionActor2D_22(HandleRef pThis, HandleRef captionActor);

		public void SetCaptionActor2D(vtkCaptionActor2D captionActor)
		{
			vtkCaptionRepresentation.vtkCaptionRepresentation_SetCaptionActor2D_22(base.GetCppThis(), (captionActor == null) ? default(HandleRef) : captionActor.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkCaptionRepresentation_SetFontFactor_23(HandleRef pThis, double _arg);

		public virtual void SetFontFactor(double _arg)
		{
			vtkCaptionRepresentation.vtkCaptionRepresentation_SetFontFactor_23(base.GetCppThis(), _arg);
		}
	}
}
