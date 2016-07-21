using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkOpenGLRayCastImageDisplayHelper : vtkRayCastImageDisplayHelper
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLRayCastImageDisplayHelper";

		public new static readonly string MRClassNameKey;

		static vtkOpenGLRayCastImageDisplayHelper()
		{
			vtkOpenGLRayCastImageDisplayHelper.MRClassNameKey = "class vtkOpenGLRayCastImageDisplayHelper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLRayCastImageDisplayHelper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLRayCastImageDisplayHelper"));
		}

		public vtkOpenGLRayCastImageDisplayHelper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLRayCastImageDisplayHelper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpenGLRayCastImageDisplayHelper New()
		{
			vtkOpenGLRayCastImageDisplayHelper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLRayCastImageDisplayHelper.vtkOpenGLRayCastImageDisplayHelper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLRayCastImageDisplayHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkOpenGLRayCastImageDisplayHelper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkOpenGLRayCastImageDisplayHelper.vtkOpenGLRayCastImageDisplayHelper_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLRayCastImageDisplayHelper_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkOpenGLRayCastImageDisplayHelper.vtkOpenGLRayCastImageDisplayHelper_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkOpenGLRayCastImageDisplayHelper_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLRayCastImageDisplayHelper.vtkOpenGLRayCastImageDisplayHelper_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLRayCastImageDisplayHelper_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkOpenGLRayCastImageDisplayHelper NewInstance()
		{
			vtkOpenGLRayCastImageDisplayHelper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLRayCastImageDisplayHelper.vtkOpenGLRayCastImageDisplayHelper_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLRayCastImageDisplayHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLRayCastImageDisplayHelper_RenderTexture_05(HandleRef pThis, HandleRef vol, HandleRef ren, IntPtr imageMemorySize, IntPtr imageViewportSize, IntPtr imageInUseSize, IntPtr imageOrigin, float requestedDepth, IntPtr image);

		public override void RenderTexture(vtkVolume vol, vtkRenderer ren, IntPtr imageMemorySize, IntPtr imageViewportSize, IntPtr imageInUseSize, IntPtr imageOrigin, float requestedDepth, IntPtr image)
		{
			vtkOpenGLRayCastImageDisplayHelper.vtkOpenGLRayCastImageDisplayHelper_RenderTexture_05(base.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), imageMemorySize, imageViewportSize, imageInUseSize, imageOrigin, requestedDepth, image);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkOpenGLRayCastImageDisplayHelper_RenderTexture_06(HandleRef pThis, HandleRef vol, HandleRef ren, HandleRef image, float requestedDepth);

		public override void RenderTexture(vtkVolume vol, vtkRenderer ren, vtkFixedPointRayCastImage image, float requestedDepth)
		{
			vtkOpenGLRayCastImageDisplayHelper.vtkOpenGLRayCastImageDisplayHelper_RenderTexture_06(base.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (image == null) ? default(HandleRef) : image.GetCppThis(), requestedDepth);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkOpenGLRayCastImageDisplayHelper_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOpenGLRayCastImageDisplayHelper SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLRayCastImageDisplayHelper vtkOpenGLRayCastImageDisplayHelper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOpenGLRayCastImageDisplayHelper.vtkOpenGLRayCastImageDisplayHelper_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLRayCastImageDisplayHelper = (vtkOpenGLRayCastImageDisplayHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLRayCastImageDisplayHelper.Register(null);
				}
			}
			return vtkOpenGLRayCastImageDisplayHelper;
		}
	}
}
