using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkOpenGLVolumeTextureMapper2D : vtkVolumeTextureMapper2D
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLVolumeTextureMapper2D";

		public new static readonly string MRClassNameKey;

		static vtkOpenGLVolumeTextureMapper2D()
		{
			vtkOpenGLVolumeTextureMapper2D.MRClassNameKey = "class vtkOpenGLVolumeTextureMapper2D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLVolumeTextureMapper2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLVolumeTextureMapper2D"));
		}

		public vtkOpenGLVolumeTextureMapper2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLVolumeTextureMapper2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpenGLVolumeTextureMapper2D New()
		{
			vtkOpenGLVolumeTextureMapper2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLVolumeTextureMapper2D.vtkOpenGLVolumeTextureMapper2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLVolumeTextureMapper2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkOpenGLVolumeTextureMapper2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkOpenGLVolumeTextureMapper2D.vtkOpenGLVolumeTextureMapper2D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLVolumeTextureMapper2D_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkOpenGLVolumeTextureMapper2D.vtkOpenGLVolumeTextureMapper2D_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLVolumeTextureMapper2D_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLVolumeTextureMapper2D.vtkOpenGLVolumeTextureMapper2D_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLVolumeTextureMapper2D_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkOpenGLVolumeTextureMapper2D NewInstance()
		{
			vtkOpenGLVolumeTextureMapper2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLVolumeTextureMapper2D.vtkOpenGLVolumeTextureMapper2D_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLVolumeTextureMapper2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLVolumeTextureMapper2D_Render_05(HandleRef pThis, HandleRef ren, HandleRef vol);

		public override void Render(vtkRenderer ren, vtkVolume vol)
		{
			vtkOpenGLVolumeTextureMapper2D.vtkOpenGLVolumeTextureMapper2D_Render_05(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLVolumeTextureMapper2D_RenderQuads_06(HandleRef pThis, int count, IntPtr v, IntPtr t, IntPtr texture, IntPtr size, int reverseFlag);

		public override void RenderQuads(int count, IntPtr v, IntPtr t, IntPtr texture, IntPtr size, int reverseFlag)
		{
			vtkOpenGLVolumeTextureMapper2D.vtkOpenGLVolumeTextureMapper2D_RenderQuads_06(base.GetCppThis(), count, v, t, texture, size, reverseFlag);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLVolumeTextureMapper2D_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpenGLVolumeTextureMapper2D SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLVolumeTextureMapper2D vtkOpenGLVolumeTextureMapper2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLVolumeTextureMapper2D.vtkOpenGLVolumeTextureMapper2D_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLVolumeTextureMapper2D = (vtkOpenGLVolumeTextureMapper2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLVolumeTextureMapper2D.Register(null);
				}
			}
			return vtkOpenGLVolumeTextureMapper2D;
		}
	}
}
