using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTexturedActor2D : vtkActor2D
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTexturedActor2D";

		public new static readonly string MRClassNameKey;

		static vtkTexturedActor2D()
		{
			vtkTexturedActor2D.MRClassNameKey = "class vtkTexturedActor2D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTexturedActor2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTexturedActor2D"));
		}

		public vtkTexturedActor2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTexturedActor2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTexturedActor2D New()
		{
			vtkTexturedActor2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTexturedActor2D.vtkTexturedActor2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTexturedActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTexturedActor2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTexturedActor2D.vtkTexturedActor2D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkTexturedActor2D_GetMTime_01(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkTexturedActor2D.vtkTexturedActor2D_GetMTime_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTexturedActor2D_GetTexture_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTexture GetTexture()
		{
			vtkTexture vtkTexture = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTexturedActor2D.vtkTexturedActor2D_GetTexture_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkTexturedActor2D_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTexturedActor2D.vtkTexturedActor2D_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTexturedActor2D_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTexturedActor2D.vtkTexturedActor2D_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTexturedActor2D_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTexturedActor2D NewInstance()
		{
			vtkTexturedActor2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTexturedActor2D.vtkTexturedActor2D_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTexturedActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTexturedActor2D_ReleaseGraphicsResources_07(HandleRef pThis, HandleRef win);

		public override void ReleaseGraphicsResources(vtkWindow win)
		{
			vtkTexturedActor2D.vtkTexturedActor2D_ReleaseGraphicsResources_07(base.GetCppThis(), (win == null) ? default(HandleRef) : win.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTexturedActor2D_RenderOpaqueGeometry_08(HandleRef pThis, HandleRef viewport);

		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkTexturedActor2D.vtkTexturedActor2D_RenderOpaqueGeometry_08(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTexturedActor2D_RenderOverlay_09(HandleRef pThis, HandleRef viewport);

		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkTexturedActor2D.vtkTexturedActor2D_RenderOverlay_09(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTexturedActor2D_RenderTranslucentPolygonalGeometry_10(HandleRef pThis, HandleRef viewport);

		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkTexturedActor2D.vtkTexturedActor2D_RenderTranslucentPolygonalGeometry_10(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTexturedActor2D_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTexturedActor2D SafeDownCast(vtkObjectBase o)
		{
			vtkTexturedActor2D vtkTexturedActor2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTexturedActor2D.vtkTexturedActor2D_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTexturedActor2D = (vtkTexturedActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTexturedActor2D.Register(null);
				}
			}
			return vtkTexturedActor2D;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTexturedActor2D_SetTexture_12(HandleRef pThis, HandleRef texture);

		public virtual void SetTexture(vtkTexture texture)
		{
			vtkTexturedActor2D.vtkTexturedActor2D_SetTexture_12(base.GetCppThis(), (texture == null) ? default(HandleRef) : texture.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTexturedActor2D_ShallowCopy_13(HandleRef pThis, HandleRef prop);

		public override void ShallowCopy(vtkProp prop)
		{
			vtkTexturedActor2D.vtkTexturedActor2D_ShallowCopy_13(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}
	}
}
