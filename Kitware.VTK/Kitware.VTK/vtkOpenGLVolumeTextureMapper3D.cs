using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkOpenGLVolumeTextureMapper3D : vtkVolumeTextureMapper3D
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLVolumeTextureMapper3D";

		public new static readonly string MRClassNameKey;

		static vtkOpenGLVolumeTextureMapper3D()
		{
			vtkOpenGLVolumeTextureMapper3D.MRClassNameKey = "class vtkOpenGLVolumeTextureMapper3D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLVolumeTextureMapper3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLVolumeTextureMapper3D"));
		}

		public vtkOpenGLVolumeTextureMapper3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLVolumeTextureMapper3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpenGLVolumeTextureMapper3D New()
		{
			vtkOpenGLVolumeTextureMapper3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLVolumeTextureMapper3D.vtkOpenGLVolumeTextureMapper3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLVolumeTextureMapper3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkOpenGLVolumeTextureMapper3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkOpenGLVolumeTextureMapper3D.vtkOpenGLVolumeTextureMapper3D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLVolumeTextureMapper3D_GetInitialized_01(HandleRef pThis);

		public virtual int GetInitialized()
		{
			return vtkOpenGLVolumeTextureMapper3D.vtkOpenGLVolumeTextureMapper3D_GetInitialized_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLVolumeTextureMapper3D_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkOpenGLVolumeTextureMapper3D.vtkOpenGLVolumeTextureMapper3D_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLVolumeTextureMapper3D_IsRenderSupported_03(HandleRef pThis, HandleRef arg0, HandleRef ren);

		public override int IsRenderSupported(vtkVolumeProperty arg0, vtkRenderer ren)
		{
			return vtkOpenGLVolumeTextureMapper3D.vtkOpenGLVolumeTextureMapper3D_IsRenderSupported_03(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLVolumeTextureMapper3D_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLVolumeTextureMapper3D.vtkOpenGLVolumeTextureMapper3D_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLVolumeTextureMapper3D_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkOpenGLVolumeTextureMapper3D NewInstance()
		{
			vtkOpenGLVolumeTextureMapper3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLVolumeTextureMapper3D.vtkOpenGLVolumeTextureMapper3D_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLVolumeTextureMapper3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLVolumeTextureMapper3D_ReleaseGraphicsResources_07(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkOpenGLVolumeTextureMapper3D.vtkOpenGLVolumeTextureMapper3D_ReleaseGraphicsResources_07(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLVolumeTextureMapper3D_Render_08(HandleRef pThis, HandleRef ren, HandleRef vol);

		public override void Render(vtkRenderer ren, vtkVolume vol)
		{
			vtkOpenGLVolumeTextureMapper3D.vtkOpenGLVolumeTextureMapper3D_Render_08(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLVolumeTextureMapper3D_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpenGLVolumeTextureMapper3D SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLVolumeTextureMapper3D vtkOpenGLVolumeTextureMapper3D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLVolumeTextureMapper3D.vtkOpenGLVolumeTextureMapper3D_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLVolumeTextureMapper3D = (vtkOpenGLVolumeTextureMapper3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLVolumeTextureMapper3D.Register(null);
				}
			}
			return vtkOpenGLVolumeTextureMapper3D;
		}
	}
}
