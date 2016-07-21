using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCameraRepresentation : vtkBorderRepresentation
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCameraRepresentation";

		public new static readonly string MRClassNameKey;

		static vtkCameraRepresentation()
		{
			vtkCameraRepresentation.MRClassNameKey = "class vtkCameraRepresentation";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCameraRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCameraRepresentation"));
		}

		public vtkCameraRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkCameraRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCameraRepresentation New()
		{
			vtkCameraRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCameraRepresentation.vtkCameraRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCameraRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCameraRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCameraRepresentation.vtkCameraRepresentation_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkCameraRepresentation_AddCameraToPath_01(HandleRef pThis);

		public void AddCameraToPath()
		{
			vtkCameraRepresentation.vtkCameraRepresentation_AddCameraToPath_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkCameraRepresentation_AnimatePath_02(HandleRef pThis, HandleRef rwi);

		public void AnimatePath(vtkRenderWindowInteractor rwi)
		{
			vtkCameraRepresentation.vtkCameraRepresentation_AnimatePath_02(base.GetCppThis(), (rwi == null) ? default(HandleRef) : rwi.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkCameraRepresentation_BuildRepresentation_03(HandleRef pThis);

		public override void BuildRepresentation()
		{
			vtkCameraRepresentation.vtkCameraRepresentation_BuildRepresentation_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkCameraRepresentation_GetActors2D_04(HandleRef pThis, HandleRef arg0);

		public override void GetActors2D(vtkPropCollection arg0)
		{
			vtkCameraRepresentation.vtkCameraRepresentation_GetActors2D_04(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkCameraRepresentation_GetCamera_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCamera GetCamera()
		{
			vtkCamera vtkCamera = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCameraRepresentation.vtkCameraRepresentation_GetCamera_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCamera = (vtkCamera)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCamera.Register(null);
				}
			}
			return vtkCamera;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkCameraRepresentation_GetInterpolator_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCameraInterpolator GetInterpolator()
		{
			vtkCameraInterpolator vtkCameraInterpolator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCameraRepresentation.vtkCameraRepresentation_GetInterpolator_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCameraInterpolator = (vtkCameraInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCameraInterpolator.Register(null);
				}
			}
			return vtkCameraInterpolator;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkCameraRepresentation_GetNumberOfFrames_07(HandleRef pThis);

		public virtual int GetNumberOfFrames()
		{
			return vtkCameraRepresentation.vtkCameraRepresentation_GetNumberOfFrames_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkCameraRepresentation_GetNumberOfFramesMaxValue_08(HandleRef pThis);

		public virtual int GetNumberOfFramesMaxValue()
		{
			return vtkCameraRepresentation.vtkCameraRepresentation_GetNumberOfFramesMaxValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkCameraRepresentation_GetNumberOfFramesMinValue_09(HandleRef pThis);

		public virtual int GetNumberOfFramesMinValue()
		{
			return vtkCameraRepresentation.vtkCameraRepresentation_GetNumberOfFramesMinValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkCameraRepresentation_GetProperty_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty2D GetProperty()
		{
			vtkProperty2D vtkProperty2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCameraRepresentation.vtkCameraRepresentation_GetProperty_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkCameraRepresentation_GetSize_11(HandleRef pThis, IntPtr size);

		public override void GetSize(IntPtr size)
		{
			vtkCameraRepresentation.vtkCameraRepresentation_GetSize_11(base.GetCppThis(), size);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkCameraRepresentation_HasTranslucentPolygonalGeometry_12(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkCameraRepresentation.vtkCameraRepresentation_HasTranslucentPolygonalGeometry_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkCameraRepresentation_InitializePath_13(HandleRef pThis);

		public void InitializePath()
		{
			vtkCameraRepresentation.vtkCameraRepresentation_InitializePath_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkCameraRepresentation_IsA_14(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCameraRepresentation.vtkCameraRepresentation_IsA_14(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkCameraRepresentation_IsTypeOf_15(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCameraRepresentation.vtkCameraRepresentation_IsTypeOf_15(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkCameraRepresentation_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCameraRepresentation NewInstance()
		{
			vtkCameraRepresentation result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCameraRepresentation.vtkCameraRepresentation_NewInstance_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCameraRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkCameraRepresentation_ReleaseGraphicsResources_18(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkCameraRepresentation.vtkCameraRepresentation_ReleaseGraphicsResources_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkCameraRepresentation_RenderOpaqueGeometry_19(HandleRef pThis, HandleRef arg0);

		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkCameraRepresentation.vtkCameraRepresentation_RenderOpaqueGeometry_19(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkCameraRepresentation_RenderOverlay_20(HandleRef pThis, HandleRef arg0);

		public override int RenderOverlay(vtkViewport arg0)
		{
			return vtkCameraRepresentation.vtkCameraRepresentation_RenderOverlay_20(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkCameraRepresentation_RenderTranslucentPolygonalGeometry_21(HandleRef pThis, HandleRef arg0);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkCameraRepresentation.vtkCameraRepresentation_RenderTranslucentPolygonalGeometry_21(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkCameraRepresentation_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCameraRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkCameraRepresentation vtkCameraRepresentation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCameraRepresentation.vtkCameraRepresentation_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCameraRepresentation = (vtkCameraRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCameraRepresentation.Register(null);
				}
			}
			return vtkCameraRepresentation;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkCameraRepresentation_SetCamera_23(HandleRef pThis, HandleRef camera);

		public void SetCamera(vtkCamera camera)
		{
			vtkCameraRepresentation.vtkCameraRepresentation_SetCamera_23(base.GetCppThis(), (camera == null) ? default(HandleRef) : camera.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkCameraRepresentation_SetInterpolator_24(HandleRef pThis, HandleRef camInt);

		public void SetInterpolator(vtkCameraInterpolator camInt)
		{
			vtkCameraRepresentation.vtkCameraRepresentation_SetInterpolator_24(base.GetCppThis(), (camInt == null) ? default(HandleRef) : camInt.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkCameraRepresentation_SetNumberOfFrames_25(HandleRef pThis, int _arg);

		public virtual void SetNumberOfFrames(int _arg)
		{
			vtkCameraRepresentation.vtkCameraRepresentation_SetNumberOfFrames_25(base.GetCppThis(), _arg);
		}
	}
}
