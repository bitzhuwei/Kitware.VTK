using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkOpenGLScalarsToColorsPainter : vtkScalarsToColorsPainter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLScalarsToColorsPainter";

		public new static readonly string MRClassNameKey;

		static vtkOpenGLScalarsToColorsPainter()
		{
			vtkOpenGLScalarsToColorsPainter.MRClassNameKey = "class vtkOpenGLScalarsToColorsPainter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLScalarsToColorsPainter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLScalarsToColorsPainter"));
		}

		public vtkOpenGLScalarsToColorsPainter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLScalarsToColorsPainter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpenGLScalarsToColorsPainter New()
		{
			vtkOpenGLScalarsToColorsPainter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLScalarsToColorsPainter.vtkOpenGLScalarsToColorsPainter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLScalarsToColorsPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkOpenGLScalarsToColorsPainter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkOpenGLScalarsToColorsPainter.vtkOpenGLScalarsToColorsPainter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLScalarsToColorsPainter_GetPremultiplyColorsWithAlpha_01(HandleRef pThis, HandleRef actor);

		public override int GetPremultiplyColorsWithAlpha(vtkActor actor)
		{
			return vtkOpenGLScalarsToColorsPainter.vtkOpenGLScalarsToColorsPainter_GetPremultiplyColorsWithAlpha_01(base.GetCppThis(), (actor == null) ? default(HandleRef) : actor.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern long vtkOpenGLScalarsToColorsPainter_GetTextureSizeLimit_02(HandleRef pThis);

		public override long GetTextureSizeLimit()
		{
			return vtkOpenGLScalarsToColorsPainter.vtkOpenGLScalarsToColorsPainter_GetTextureSizeLimit_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLScalarsToColorsPainter_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkOpenGLScalarsToColorsPainter.vtkOpenGLScalarsToColorsPainter_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLScalarsToColorsPainter_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLScalarsToColorsPainter.vtkOpenGLScalarsToColorsPainter_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLScalarsToColorsPainter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkOpenGLScalarsToColorsPainter NewInstance()
		{
			vtkOpenGLScalarsToColorsPainter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLScalarsToColorsPainter.vtkOpenGLScalarsToColorsPainter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLScalarsToColorsPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLScalarsToColorsPainter_ReleaseGraphicsResources_07(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkOpenGLScalarsToColorsPainter.vtkOpenGLScalarsToColorsPainter_ReleaseGraphicsResources_07(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLScalarsToColorsPainter_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpenGLScalarsToColorsPainter SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLScalarsToColorsPainter vtkOpenGLScalarsToColorsPainter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLScalarsToColorsPainter.vtkOpenGLScalarsToColorsPainter_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLScalarsToColorsPainter = (vtkOpenGLScalarsToColorsPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLScalarsToColorsPainter.Register(null);
				}
			}
			return vtkOpenGLScalarsToColorsPainter;
		}
	}
}
