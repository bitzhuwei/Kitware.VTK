using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkOpenGLClipPlanesPainter : vtkClipPlanesPainter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLClipPlanesPainter";

		public new static readonly string MRClassNameKey;

		static vtkOpenGLClipPlanesPainter()
		{
			vtkOpenGLClipPlanesPainter.MRClassNameKey = "class vtkOpenGLClipPlanesPainter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLClipPlanesPainter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLClipPlanesPainter"));
		}

		public vtkOpenGLClipPlanesPainter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLClipPlanesPainter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpenGLClipPlanesPainter New()
		{
			vtkOpenGLClipPlanesPainter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLClipPlanesPainter.vtkOpenGLClipPlanesPainter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLClipPlanesPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkOpenGLClipPlanesPainter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkOpenGLClipPlanesPainter.vtkOpenGLClipPlanesPainter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLClipPlanesPainter_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkOpenGLClipPlanesPainter.vtkOpenGLClipPlanesPainter_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLClipPlanesPainter_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLClipPlanesPainter.vtkOpenGLClipPlanesPainter_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLClipPlanesPainter_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkOpenGLClipPlanesPainter NewInstance()
		{
			vtkOpenGLClipPlanesPainter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLClipPlanesPainter.vtkOpenGLClipPlanesPainter_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLClipPlanesPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLClipPlanesPainter_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpenGLClipPlanesPainter SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLClipPlanesPainter vtkOpenGLClipPlanesPainter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLClipPlanesPainter.vtkOpenGLClipPlanesPainter_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLClipPlanesPainter = (vtkOpenGLClipPlanesPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLClipPlanesPainter.Register(null);
				}
			}
			return vtkOpenGLClipPlanesPainter;
		}
	}
}
