using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkRayCastImageDisplayHelper : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkRayCastImageDisplayHelper";

		public new static readonly string MRClassNameKey;

		static vtkRayCastImageDisplayHelper()
		{
			vtkRayCastImageDisplayHelper.MRClassNameKey = "class vtkRayCastImageDisplayHelper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRayCastImageDisplayHelper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRayCastImageDisplayHelper"));
		}

		public vtkRayCastImageDisplayHelper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRayCastImageDisplayHelper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRayCastImageDisplayHelper New()
		{
			vtkRayCastImageDisplayHelper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRayCastImageDisplayHelper.vtkRayCastImageDisplayHelper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRayCastImageDisplayHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkRayCastImageDisplayHelper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkRayCastImageDisplayHelper.vtkRayCastImageDisplayHelper_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkRayCastImageDisplayHelper_GetPixelScale_01(HandleRef pThis);

		public virtual float GetPixelScale()
		{
			return vtkRayCastImageDisplayHelper.vtkRayCastImageDisplayHelper_GetPixelScale_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkRayCastImageDisplayHelper_GetPreMultipliedColors_02(HandleRef pThis);

		public virtual int GetPreMultipliedColors()
		{
			return vtkRayCastImageDisplayHelper.vtkRayCastImageDisplayHelper_GetPreMultipliedColors_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkRayCastImageDisplayHelper_GetPreMultipliedColorsMaxValue_03(HandleRef pThis);

		public virtual int GetPreMultipliedColorsMaxValue()
		{
			return vtkRayCastImageDisplayHelper.vtkRayCastImageDisplayHelper_GetPreMultipliedColorsMaxValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkRayCastImageDisplayHelper_GetPreMultipliedColorsMinValue_04(HandleRef pThis);

		public virtual int GetPreMultipliedColorsMinValue()
		{
			return vtkRayCastImageDisplayHelper.vtkRayCastImageDisplayHelper_GetPreMultipliedColorsMinValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkRayCastImageDisplayHelper_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkRayCastImageDisplayHelper.vtkRayCastImageDisplayHelper_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkRayCastImageDisplayHelper_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkRayCastImageDisplayHelper.vtkRayCastImageDisplayHelper_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRayCastImageDisplayHelper_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRayCastImageDisplayHelper NewInstance()
		{
			vtkRayCastImageDisplayHelper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRayCastImageDisplayHelper.vtkRayCastImageDisplayHelper_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRayCastImageDisplayHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkRayCastImageDisplayHelper_PreMultipliedColorsOff_09(HandleRef pThis);

		public virtual void PreMultipliedColorsOff()
		{
			vtkRayCastImageDisplayHelper.vtkRayCastImageDisplayHelper_PreMultipliedColorsOff_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkRayCastImageDisplayHelper_PreMultipliedColorsOn_10(HandleRef pThis);

		public virtual void PreMultipliedColorsOn()
		{
			vtkRayCastImageDisplayHelper.vtkRayCastImageDisplayHelper_PreMultipliedColorsOn_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkRayCastImageDisplayHelper_RenderTexture_11(HandleRef pThis, HandleRef vol, HandleRef ren, IntPtr imageMemorySize, IntPtr imageViewportSize, IntPtr imageInUseSize, IntPtr imageOrigin, float requestedDepth, IntPtr image);

		public virtual void RenderTexture(vtkVolume vol, vtkRenderer ren, IntPtr imageMemorySize, IntPtr imageViewportSize, IntPtr imageInUseSize, IntPtr imageOrigin, float requestedDepth, IntPtr image)
		{
			vtkRayCastImageDisplayHelper.vtkRayCastImageDisplayHelper_RenderTexture_11(base.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), imageMemorySize, imageViewportSize, imageInUseSize, imageOrigin, requestedDepth, image);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkRayCastImageDisplayHelper_RenderTexture_12(HandleRef pThis, HandleRef vol, HandleRef ren, HandleRef image, float requestedDepth);

		public virtual void RenderTexture(vtkVolume vol, vtkRenderer ren, vtkFixedPointRayCastImage image, float requestedDepth)
		{
			vtkRayCastImageDisplayHelper.vtkRayCastImageDisplayHelper_RenderTexture_12(base.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (image == null) ? default(HandleRef) : image.GetCppThis(), requestedDepth);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkRayCastImageDisplayHelper_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRayCastImageDisplayHelper SafeDownCast(vtkObjectBase o)
		{
			vtkRayCastImageDisplayHelper vtkRayCastImageDisplayHelper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRayCastImageDisplayHelper.vtkRayCastImageDisplayHelper_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRayCastImageDisplayHelper = (vtkRayCastImageDisplayHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRayCastImageDisplayHelper.Register(null);
				}
			}
			return vtkRayCastImageDisplayHelper;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkRayCastImageDisplayHelper_SetPixelScale_14(HandleRef pThis, float _arg);

		public virtual void SetPixelScale(float _arg)
		{
			vtkRayCastImageDisplayHelper.vtkRayCastImageDisplayHelper_SetPixelScale_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkRayCastImageDisplayHelper_SetPreMultipliedColors_15(HandleRef pThis, int _arg);

		public virtual void SetPreMultipliedColors(int _arg)
		{
			vtkRayCastImageDisplayHelper.vtkRayCastImageDisplayHelper_SetPreMultipliedColors_15(base.GetCppThis(), _arg);
		}
	}
}
