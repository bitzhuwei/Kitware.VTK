using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkOpenGLPolyDataMapper : vtkPolyDataMapper
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLPolyDataMapper";

		public new static readonly string MRClassNameKey;

		static vtkOpenGLPolyDataMapper()
		{
			vtkOpenGLPolyDataMapper.MRClassNameKey = "class vtkOpenGLPolyDataMapper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLPolyDataMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLPolyDataMapper"));
		}

		public vtkOpenGLPolyDataMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLPolyDataMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpenGLPolyDataMapper New()
		{
			vtkOpenGLPolyDataMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLPolyDataMapper.vtkOpenGLPolyDataMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLPolyDataMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkOpenGLPolyDataMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkOpenGLPolyDataMapper.vtkOpenGLPolyDataMapper_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLPolyDataMapper_Draw_01(HandleRef pThis, HandleRef ren, HandleRef a);

		public virtual int Draw(vtkRenderer ren, vtkActor a)
		{
			return vtkOpenGLPolyDataMapper.vtkOpenGLPolyDataMapper_Draw_01(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLPolyDataMapper_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkOpenGLPolyDataMapper.vtkOpenGLPolyDataMapper_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLPolyDataMapper_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLPolyDataMapper.vtkOpenGLPolyDataMapper_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLPolyDataMapper_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkOpenGLPolyDataMapper NewInstance()
		{
			vtkOpenGLPolyDataMapper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLPolyDataMapper.vtkOpenGLPolyDataMapper_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLPolyDataMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLPolyDataMapper_ReleaseGraphicsResources_06(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkOpenGLPolyDataMapper.vtkOpenGLPolyDataMapper_ReleaseGraphicsResources_06(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLPolyDataMapper_RenderPiece_07(HandleRef pThis, HandleRef ren, HandleRef a);

		public override void RenderPiece(vtkRenderer ren, vtkActor a)
		{
			vtkOpenGLPolyDataMapper.vtkOpenGLPolyDataMapper_RenderPiece_07(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLPolyDataMapper_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpenGLPolyDataMapper SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLPolyDataMapper vtkOpenGLPolyDataMapper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLPolyDataMapper.vtkOpenGLPolyDataMapper_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLPolyDataMapper = (vtkOpenGLPolyDataMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLPolyDataMapper.Register(null);
				}
			}
			return vtkOpenGLPolyDataMapper;
		}
	}
}
