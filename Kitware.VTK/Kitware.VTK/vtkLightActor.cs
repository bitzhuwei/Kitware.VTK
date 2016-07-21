using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkLightActor : vtkProp3D
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkLightActor";

		public new static readonly string MRClassNameKey;

		static vtkLightActor()
		{
			vtkLightActor.MRClassNameKey = "class vtkLightActor";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLightActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLightActor"));
		}

		public vtkLightActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLightActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLightActor New()
		{
			vtkLightActor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLightActor.vtkLightActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLightActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkLightActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkLightActor.vtkLightActor_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLightActor_GetBounds_01(HandleRef pThis);

		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkLightActor.vtkLightActor_GetBounds_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLightActor_GetClippingRange_02(HandleRef pThis);

		public virtual double[] GetClippingRange()
		{
			IntPtr intPtr = vtkLightActor.vtkLightActor_GetClippingRange_02(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLightActor_GetClippingRange_03(HandleRef pThis, ref double _arg1, ref double _arg2);

		public virtual void GetClippingRange(ref double _arg1, ref double _arg2)
		{
			vtkLightActor.vtkLightActor_GetClippingRange_03(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLightActor_GetClippingRange_04(HandleRef pThis, IntPtr _arg);

		public virtual void GetClippingRange(IntPtr _arg)
		{
			vtkLightActor.vtkLightActor_GetClippingRange_04(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLightActor_GetLight_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkLight GetLight()
		{
			vtkLight vtkLight = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLightActor.vtkLightActor_GetLight_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLight = (vtkLight)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLight.Register(null);
				}
			}
			return vtkLight;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkLightActor_GetMTime_06(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkLightActor.vtkLightActor_GetMTime_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLightActor_HasTranslucentPolygonalGeometry_07(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkLightActor.vtkLightActor_HasTranslucentPolygonalGeometry_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLightActor_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkLightActor.vtkLightActor_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLightActor_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkLightActor.vtkLightActor_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLightActor_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkLightActor NewInstance()
		{
			vtkLightActor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLightActor.vtkLightActor_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLightActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLightActor_ReleaseGraphicsResources_12(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkLightActor.vtkLightActor_ReleaseGraphicsResources_12(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLightActor_RenderOpaqueGeometry_13(HandleRef pThis, HandleRef viewport);

		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkLightActor.vtkLightActor_RenderOpaqueGeometry_13(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLightActor_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLightActor SafeDownCast(vtkObjectBase o)
		{
			vtkLightActor vtkLightActor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLightActor.vtkLightActor_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLightActor = (vtkLightActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLightActor.Register(null);
				}
			}
			return vtkLightActor;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLightActor_SetClippingRange_15(HandleRef pThis, double dNear, double dFar);

		public void SetClippingRange(double dNear, double dFar)
		{
			vtkLightActor.vtkLightActor_SetClippingRange_15(base.GetCppThis(), dNear, dFar);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLightActor_SetClippingRange_16(HandleRef pThis, IntPtr a);

		public void SetClippingRange(IntPtr a)
		{
			vtkLightActor.vtkLightActor_SetClippingRange_16(base.GetCppThis(), a);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLightActor_SetLight_17(HandleRef pThis, HandleRef light);

		public void SetLight(vtkLight light)
		{
			vtkLightActor.vtkLightActor_SetLight_17(base.GetCppThis(), (light == null) ? default(HandleRef) : light.GetCppThis());
		}
	}
}
