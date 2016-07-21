using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkOpenGLGlyph3DMapper : vtkGlyph3DMapper
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLGlyph3DMapper";

		public new static readonly string MRClassNameKey;

		static vtkOpenGLGlyph3DMapper()
		{
			vtkOpenGLGlyph3DMapper.MRClassNameKey = "class vtkOpenGLGlyph3DMapper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLGlyph3DMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLGlyph3DMapper"));
		}

		public vtkOpenGLGlyph3DMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLGlyph3DMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpenGLGlyph3DMapper New()
		{
			vtkOpenGLGlyph3DMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLGlyph3DMapper.vtkOpenGLGlyph3DMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLGlyph3DMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkOpenGLGlyph3DMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkOpenGLGlyph3DMapper.vtkOpenGLGlyph3DMapper_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLGlyph3DMapper_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkOpenGLGlyph3DMapper.vtkOpenGLGlyph3DMapper_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLGlyph3DMapper_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLGlyph3DMapper.vtkOpenGLGlyph3DMapper_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLGlyph3DMapper_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkOpenGLGlyph3DMapper NewInstance()
		{
			vtkOpenGLGlyph3DMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLGlyph3DMapper.vtkOpenGLGlyph3DMapper_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLGlyph3DMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLGlyph3DMapper_ReleaseGraphicsResources_05(HandleRef pThis, HandleRef window);

		public override void ReleaseGraphicsResources(vtkWindow window)
		{
			vtkOpenGLGlyph3DMapper.vtkOpenGLGlyph3DMapper_ReleaseGraphicsResources_05(base.GetCppThis(), (window == null) ? default(HandleRef) : window.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLGlyph3DMapper_Render_06(HandleRef pThis, HandleRef ren, HandleRef a);

		public override void Render(vtkRenderer ren, vtkActor a)
		{
			vtkOpenGLGlyph3DMapper.vtkOpenGLGlyph3DMapper_Render_06(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLGlyph3DMapper_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpenGLGlyph3DMapper SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLGlyph3DMapper vtkOpenGLGlyph3DMapper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLGlyph3DMapper.vtkOpenGLGlyph3DMapper_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLGlyph3DMapper = (vtkOpenGLGlyph3DMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLGlyph3DMapper.Register(null);
				}
			}
			return vtkOpenGLGlyph3DMapper;
		}
	}
}
