using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCameraActor : vtkProp3D
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCameraActor";

		public new static readonly string MRClassNameKey;

		static vtkCameraActor()
		{
			vtkCameraActor.MRClassNameKey = "class vtkCameraActor";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCameraActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCameraActor"));
		}

		public vtkCameraActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCameraActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCameraActor New()
		{
			vtkCameraActor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCameraActor.vtkCameraActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCameraActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCameraActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCameraActor.vtkCameraActor_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCameraActor_GetBounds_01(HandleRef pThis);

		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkCameraActor.vtkCameraActor_GetBounds_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCameraActor_GetCamera_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCamera GetCamera()
		{
			vtkCamera vtkCamera = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCameraActor.vtkCameraActor_GetCamera_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkCameraActor_GetMTime_03(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkCameraActor.vtkCameraActor_GetMTime_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCameraActor_GetProperty_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkProperty GetProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCameraActor.vtkCameraActor_GetProperty_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkCameraActor_GetWidthByHeightRatio_05(HandleRef pThis);

		public virtual double GetWidthByHeightRatio()
		{
			return vtkCameraActor.vtkCameraActor_GetWidthByHeightRatio_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkCameraActor_HasTranslucentPolygonalGeometry_06(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkCameraActor.vtkCameraActor_HasTranslucentPolygonalGeometry_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkCameraActor_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCameraActor.vtkCameraActor_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkCameraActor_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCameraActor.vtkCameraActor_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCameraActor_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCameraActor NewInstance()
		{
			vtkCameraActor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCameraActor.vtkCameraActor_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCameraActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCameraActor_ReleaseGraphicsResources_11(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkCameraActor.vtkCameraActor_ReleaseGraphicsResources_11(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkCameraActor_RenderOpaqueGeometry_12(HandleRef pThis, HandleRef viewport);

		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkCameraActor.vtkCameraActor_RenderOpaqueGeometry_12(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCameraActor_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCameraActor SafeDownCast(vtkObjectBase o)
		{
			vtkCameraActor vtkCameraActor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCameraActor.vtkCameraActor_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCameraActor = (vtkCameraActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCameraActor.Register(null);
				}
			}
			return vtkCameraActor;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCameraActor_SetCamera_14(HandleRef pThis, HandleRef camera);

		public void SetCamera(vtkCamera camera)
		{
			vtkCameraActor.vtkCameraActor_SetCamera_14(base.GetCppThis(), (camera == null) ? default(HandleRef) : camera.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCameraActor_SetProperty_15(HandleRef pThis, HandleRef p);

		public void SetProperty(vtkProperty p)
		{
			vtkCameraActor.vtkCameraActor_SetProperty_15(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCameraActor_SetWidthByHeightRatio_16(HandleRef pThis, double _arg);

		public virtual void SetWidthByHeightRatio(double _arg)
		{
			vtkCameraActor.vtkCameraActor_SetWidthByHeightRatio_16(base.GetCppThis(), _arg);
		}
	}
}
