using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTexturedButtonRepresentation2D : vtkButtonRepresentation
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTexturedButtonRepresentation2D";

		public new static readonly string MRClassNameKey;

		static vtkTexturedButtonRepresentation2D()
		{
			vtkTexturedButtonRepresentation2D.MRClassNameKey = "class vtkTexturedButtonRepresentation2D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTexturedButtonRepresentation2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTexturedButtonRepresentation2D"));
		}

		public vtkTexturedButtonRepresentation2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkTexturedButtonRepresentation2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTexturedButtonRepresentation2D New()
		{
			vtkTexturedButtonRepresentation2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTexturedButtonRepresentation2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTexturedButtonRepresentation2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTexturedButtonRepresentation2D_BuildRepresentation_01(HandleRef pThis);

		public override void BuildRepresentation()
		{
			vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_BuildRepresentation_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkTexturedButtonRepresentation2D_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_ComputeInteractionState_02(base.GetCppThis(), X, Y, modify);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTexturedButtonRepresentation2D_GetActors_03(HandleRef pThis, HandleRef pc);

		public override void GetActors(vtkPropCollection pc)
		{
			vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_GetActors_03(base.GetCppThis(), (pc == null) ? default(HandleRef) : pc.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkTexturedButtonRepresentation2D_GetBalloon_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkBalloonRepresentation GetBalloon()
		{
			vtkBalloonRepresentation vtkBalloonRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_GetBalloon_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBalloonRepresentation = (vtkBalloonRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBalloonRepresentation.Register(null);
				}
			}
			return vtkBalloonRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkTexturedButtonRepresentation2D_GetBounds_05(HandleRef pThis);

		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_GetBounds_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkTexturedButtonRepresentation2D_GetButtonTexture_06(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkImageData GetButtonTexture(int i)
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_GetButtonTexture_06(base.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkTexturedButtonRepresentation2D_GetHoveringProperty_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty2D GetHoveringProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_GetHoveringProperty_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkTexturedButtonRepresentation2D_GetProperty_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty2D GetProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_GetProperty_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkTexturedButtonRepresentation2D_GetSelectingProperty_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty2D GetSelectingProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_GetSelectingProperty_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkTexturedButtonRepresentation2D_HasTranslucentPolygonalGeometry_10(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_HasTranslucentPolygonalGeometry_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTexturedButtonRepresentation2D_Highlight_11(HandleRef pThis, int state);

		public override void Highlight(int state)
		{
			vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_Highlight_11(base.GetCppThis(), state);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkTexturedButtonRepresentation2D_IsA_12(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_IsA_12(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkTexturedButtonRepresentation2D_IsTypeOf_13(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_IsTypeOf_13(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkTexturedButtonRepresentation2D_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTexturedButtonRepresentation2D NewInstance()
		{
			vtkTexturedButtonRepresentation2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_NewInstance_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTexturedButtonRepresentation2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTexturedButtonRepresentation2D_PlaceWidget_16(HandleRef pThis, IntPtr bounds);

		public override void PlaceWidget(IntPtr bounds)
		{
			vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_PlaceWidget_16(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTexturedButtonRepresentation2D_PlaceWidget_17(HandleRef pThis, IntPtr anchor, IntPtr size);

		public virtual void PlaceWidget(IntPtr anchor, IntPtr size)
		{
			vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_PlaceWidget_17(base.GetCppThis(), anchor, size);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTexturedButtonRepresentation2D_ReleaseGraphicsResources_18(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_ReleaseGraphicsResources_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkTexturedButtonRepresentation2D_RenderOverlay_19(HandleRef pThis, HandleRef arg0);

		public override int RenderOverlay(vtkViewport arg0)
		{
			return vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_RenderOverlay_19(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkTexturedButtonRepresentation2D_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTexturedButtonRepresentation2D SafeDownCast(vtkObjectBase o)
		{
			vtkTexturedButtonRepresentation2D vtkTexturedButtonRepresentation2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTexturedButtonRepresentation2D = (vtkTexturedButtonRepresentation2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTexturedButtonRepresentation2D.Register(null);
				}
			}
			return vtkTexturedButtonRepresentation2D;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTexturedButtonRepresentation2D_SetButtonTexture_21(HandleRef pThis, int i, HandleRef image);

		public void SetButtonTexture(int i, vtkImageData image)
		{
			vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_SetButtonTexture_21(base.GetCppThis(), i, (image == null) ? default(HandleRef) : image.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTexturedButtonRepresentation2D_SetHoveringProperty_22(HandleRef pThis, HandleRef p);

		public virtual void SetHoveringProperty(vtkProperty2D p)
		{
			vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_SetHoveringProperty_22(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTexturedButtonRepresentation2D_SetProperty_23(HandleRef pThis, HandleRef p);

		public virtual void SetProperty(vtkProperty2D p)
		{
			vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_SetProperty_23(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTexturedButtonRepresentation2D_SetSelectingProperty_24(HandleRef pThis, HandleRef p);

		public virtual void SetSelectingProperty(vtkProperty2D p)
		{
			vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_SetSelectingProperty_24(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkTexturedButtonRepresentation2D_ShallowCopy_25(HandleRef pThis, HandleRef prop);

		public override void ShallowCopy(vtkProp prop)
		{
			vtkTexturedButtonRepresentation2D.vtkTexturedButtonRepresentation2D_ShallowCopy_25(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}
	}
}
