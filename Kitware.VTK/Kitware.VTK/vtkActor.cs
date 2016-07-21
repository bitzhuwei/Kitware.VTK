using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkActor : vtkProp3D
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkActor";

		public new static readonly string MRClassNameKey;

		static vtkActor()
		{
			vtkActor.MRClassNameKey = "class vtkActor";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkActor"));
		}

		public vtkActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkActor New()
		{
			vtkActor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkActor.vtkActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkActor.vtkActor_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkActor_ApplyProperties_01(HandleRef pThis);

		public virtual void ApplyProperties()
		{
			vtkActor.vtkActor_ApplyProperties_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkActor_GetActors_02(HandleRef pThis, HandleRef arg0);

		public override void GetActors(vtkPropCollection arg0)
		{
			vtkActor.vtkActor_GetActors_02(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkActor_GetBackfaceProperty_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty GetBackfaceProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkActor.vtkActor_GetBackfaceProperty_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern void vtkActor_GetBounds_04(HandleRef pThis, IntPtr bounds);

		public new void GetBounds(IntPtr bounds)
		{
			vtkActor.vtkActor_GetBounds_04(base.GetCppThis(), bounds);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkActor_GetBounds_05(HandleRef pThis);

		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkActor.vtkActor_GetBounds_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkActor_GetMTime_06(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkActor.vtkActor_GetMTime_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkActor_GetMapper_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMapper GetMapper()
		{
			vtkMapper vtkMapper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkActor.vtkActor_GetMapper_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMapper = (vtkMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMapper.Register(null);
				}
			}
			return vtkMapper;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkActor_GetProperty_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkProperty GetProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkActor.vtkActor_GetProperty_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern uint vtkActor_GetRedrawMTime_09(HandleRef pThis);

		public override uint GetRedrawMTime()
		{
			return vtkActor.vtkActor_GetRedrawMTime_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkActor_GetSupportsSelection_10(HandleRef pThis);

		public override bool GetSupportsSelection()
		{
			return vtkActor.vtkActor_GetSupportsSelection_10(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkActor_GetTexture_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTexture GetTexture()
		{
			vtkTexture vtkTexture = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkActor.vtkActor_GetTexture_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTexture = (vtkTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTexture.Register(null);
				}
			}
			return vtkTexture;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkActor_HasTranslucentPolygonalGeometry_12(HandleRef pThis);

		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkActor.vtkActor_HasTranslucentPolygonalGeometry_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkActor_IsA_13(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkActor.vtkActor_IsA_13(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkActor_IsTypeOf_14(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkActor.vtkActor_IsTypeOf_14(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkActor_MakeProperty_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkProperty MakeProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkActor.vtkActor_MakeProperty_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkActor_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkActor NewInstance()
		{
			vtkActor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkActor.vtkActor_NewInstance_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkActor_ReleaseGraphicsResources_18(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkActor.vtkActor_ReleaseGraphicsResources_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkActor_Render_19(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		public virtual void Render(vtkRenderer arg0, vtkMapper arg1)
		{
			vtkActor.vtkActor_Render_19(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkActor_RenderOpaqueGeometry_20(HandleRef pThis, HandleRef viewport);

		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkActor.vtkActor_RenderOpaqueGeometry_20(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkActor_RenderTranslucentPolygonalGeometry_21(HandleRef pThis, HandleRef viewport);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkActor.vtkActor_RenderTranslucentPolygonalGeometry_21(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkActor_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkActor SafeDownCast(vtkObjectBase o)
		{
			vtkActor vtkActor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkActor.vtkActor_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkActor = (vtkActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkActor.Register(null);
				}
			}
			return vtkActor;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkActor_SetBackfaceProperty_23(HandleRef pThis, HandleRef lut);

		public void SetBackfaceProperty(vtkProperty lut)
		{
			vtkActor.vtkActor_SetBackfaceProperty_23(base.GetCppThis(), (lut == null) ? default(HandleRef) : lut.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkActor_SetMapper_24(HandleRef pThis, HandleRef arg0);

		public virtual void SetMapper(vtkMapper arg0)
		{
			vtkActor.vtkActor_SetMapper_24(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkActor_SetProperty_25(HandleRef pThis, HandleRef lut);

		public void SetProperty(vtkProperty lut)
		{
			vtkActor.vtkActor_SetProperty_25(base.GetCppThis(), (lut == null) ? default(HandleRef) : lut.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkActor_SetTexture_26(HandleRef pThis, HandleRef arg0);

		public virtual void SetTexture(vtkTexture arg0)
		{
			vtkActor.vtkActor_SetTexture_26(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkActor_ShallowCopy_27(HandleRef pThis, HandleRef prop);

		public override void ShallowCopy(vtkProp prop)
		{
			vtkActor.vtkActor_ShallowCopy_27(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}
	}
}
