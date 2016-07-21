using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkOpenGLFreeTypeTextMapper : vtkTextMapper
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLFreeTypeTextMapper";

		public new static readonly string MRClassNameKey;

		static vtkOpenGLFreeTypeTextMapper()
		{
			vtkOpenGLFreeTypeTextMapper.MRClassNameKey = "class vtkOpenGLFreeTypeTextMapper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLFreeTypeTextMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLFreeTypeTextMapper"));
		}

		public vtkOpenGLFreeTypeTextMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLFreeTypeTextMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpenGLFreeTypeTextMapper New()
		{
			vtkOpenGLFreeTypeTextMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLFreeTypeTextMapper.vtkOpenGLFreeTypeTextMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLFreeTypeTextMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkOpenGLFreeTypeTextMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkOpenGLFreeTypeTextMapper.vtkOpenGLFreeTypeTextMapper_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLFreeTypeTextMapper_GetSize_01(HandleRef pThis, HandleRef viewport, IntPtr size);

		public override void GetSize(vtkViewport viewport, IntPtr size)
		{
			vtkOpenGLFreeTypeTextMapper.vtkOpenGLFreeTypeTextMapper_GetSize_01(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis(), size);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLFreeTypeTextMapper_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkOpenGLFreeTypeTextMapper.vtkOpenGLFreeTypeTextMapper_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLFreeTypeTextMapper_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLFreeTypeTextMapper.vtkOpenGLFreeTypeTextMapper_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLFreeTypeTextMapper_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkOpenGLFreeTypeTextMapper NewInstance()
		{
			vtkOpenGLFreeTypeTextMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLFreeTypeTextMapper.vtkOpenGLFreeTypeTextMapper_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLFreeTypeTextMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLFreeTypeTextMapper_ReleaseGraphicsResources_06(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkOpenGLFreeTypeTextMapper.vtkOpenGLFreeTypeTextMapper_ReleaseGraphicsResources_06(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLFreeTypeTextMapper_RenderOverlay_07(HandleRef pThis, HandleRef viewport, HandleRef actor);

		public override void RenderOverlay(vtkViewport viewport, vtkActor2D actor)
		{
			vtkOpenGLFreeTypeTextMapper.vtkOpenGLFreeTypeTextMapper_RenderOverlay_07(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis(), (actor == null) ? default(HandleRef) : actor.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLFreeTypeTextMapper_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpenGLFreeTypeTextMapper SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLFreeTypeTextMapper vtkOpenGLFreeTypeTextMapper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLFreeTypeTextMapper.vtkOpenGLFreeTypeTextMapper_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLFreeTypeTextMapper = (vtkOpenGLFreeTypeTextMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLFreeTypeTextMapper.Register(null);
				}
			}
			return vtkOpenGLFreeTypeTextMapper;
		}
	}
}
