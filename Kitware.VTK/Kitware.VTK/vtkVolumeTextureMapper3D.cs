using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkVolumeTextureMapper3D : vtkVolumeMapper
	{
		public enum ATI_METHOD_WrapperEnum
		{
			ATI_METHOD = 2,
			FRAGMENT_PROGRAM_METHOD = 0,
			NO_METHOD = 3,
			NVIDIA_METHOD = 1
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkVolumeTextureMapper3D";

		public new static readonly string MRClassNameKey;

		static vtkVolumeTextureMapper3D()
		{
			vtkVolumeTextureMapper3D.MRClassNameKey = "class vtkVolumeTextureMapper3D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVolumeTextureMapper3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVolumeTextureMapper3D"));
		}

		public vtkVolumeTextureMapper3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeTextureMapper3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVolumeTextureMapper3D New()
		{
			vtkVolumeTextureMapper3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeTextureMapper3D.vtkVolumeTextureMapper3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeTextureMapper3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkVolumeTextureMapper3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkVolumeTextureMapper3D.vtkVolumeTextureMapper3D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkVolumeTextureMapper3D_GetActualSampleDistance_01(HandleRef pThis);

		public virtual float GetActualSampleDistance()
		{
			return vtkVolumeTextureMapper3D.vtkVolumeTextureMapper3D_GetActualSampleDistance_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeTextureMapper3D_GetNumberOfPolygons_02(HandleRef pThis);

		public virtual int GetNumberOfPolygons()
		{
			return vtkVolumeTextureMapper3D.vtkVolumeTextureMapper3D_GetNumberOfPolygons_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeTextureMapper3D_GetPreferredRenderMethod_03(HandleRef pThis);

		public virtual int GetPreferredRenderMethod()
		{
			return vtkVolumeTextureMapper3D.vtkVolumeTextureMapper3D_GetPreferredRenderMethod_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeTextureMapper3D_GetPreferredRenderMethodMaxValue_04(HandleRef pThis);

		public virtual int GetPreferredRenderMethodMaxValue()
		{
			return vtkVolumeTextureMapper3D.vtkVolumeTextureMapper3D_GetPreferredRenderMethodMaxValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeTextureMapper3D_GetPreferredRenderMethodMinValue_05(HandleRef pThis);

		public virtual int GetPreferredRenderMethodMinValue()
		{
			return vtkVolumeTextureMapper3D.vtkVolumeTextureMapper3D_GetPreferredRenderMethodMinValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern float vtkVolumeTextureMapper3D_GetSampleDistance_06(HandleRef pThis);

		public virtual float GetSampleDistance()
		{
			return vtkVolumeTextureMapper3D.vtkVolumeTextureMapper3D_GetSampleDistance_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern byte vtkVolumeTextureMapper3D_GetUseCompressedTexture_07(HandleRef pThis);

		public virtual bool GetUseCompressedTexture()
		{
			return vtkVolumeTextureMapper3D.vtkVolumeTextureMapper3D_GetUseCompressedTexture_07(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeTextureMapper3D_GetVolumeDimensions_08(HandleRef pThis);

		public virtual int[] GetVolumeDimensions()
		{
			IntPtr intPtr = vtkVolumeTextureMapper3D.vtkVolumeTextureMapper3D_GetVolumeDimensions_08(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeTextureMapper3D_GetVolumeDimensions_09(HandleRef pThis, IntPtr data);

		public virtual void GetVolumeDimensions(IntPtr data)
		{
			vtkVolumeTextureMapper3D.vtkVolumeTextureMapper3D_GetVolumeDimensions_09(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeTextureMapper3D_GetVolumeSpacing_10(HandleRef pThis);

		public virtual float[] GetVolumeSpacing()
		{
			IntPtr intPtr = vtkVolumeTextureMapper3D.vtkVolumeTextureMapper3D_GetVolumeSpacing_10(base.GetCppThis());
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeTextureMapper3D_GetVolumeSpacing_11(HandleRef pThis, IntPtr data);

		public virtual void GetVolumeSpacing(IntPtr data)
		{
			vtkVolumeTextureMapper3D.vtkVolumeTextureMapper3D_GetVolumeSpacing_11(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeTextureMapper3D_IsA_12(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkVolumeTextureMapper3D.vtkVolumeTextureMapper3D_IsA_12(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeTextureMapper3D_IsRenderSupported_13(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		public virtual int IsRenderSupported(vtkVolumeProperty arg0, vtkRenderer arg1)
		{
			return vtkVolumeTextureMapper3D.vtkVolumeTextureMapper3D_IsRenderSupported_13(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeTextureMapper3D_IsTypeOf_14(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkVolumeTextureMapper3D.vtkVolumeTextureMapper3D_IsTypeOf_14(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeTextureMapper3D_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkVolumeTextureMapper3D NewInstance()
		{
			vtkVolumeTextureMapper3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeTextureMapper3D.vtkVolumeTextureMapper3D_NewInstance_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeTextureMapper3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeTextureMapper3D_Render_17(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		public override void Render(vtkRenderer arg0, vtkVolume arg1)
		{
			vtkVolumeTextureMapper3D.vtkVolumeTextureMapper3D_Render_17(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeTextureMapper3D_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVolumeTextureMapper3D SafeDownCast(vtkObjectBase o)
		{
			vtkVolumeTextureMapper3D vtkVolumeTextureMapper3D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeTextureMapper3D.vtkVolumeTextureMapper3D_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolumeTextureMapper3D = (vtkVolumeTextureMapper3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolumeTextureMapper3D.Register(null);
				}
			}
			return vtkVolumeTextureMapper3D;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeTextureMapper3D_SetPreferredMethodToFragmentProgram_19(HandleRef pThis);

		public void SetPreferredMethodToFragmentProgram()
		{
			vtkVolumeTextureMapper3D.vtkVolumeTextureMapper3D_SetPreferredMethodToFragmentProgram_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeTextureMapper3D_SetPreferredMethodToNVidia_20(HandleRef pThis);

		public void SetPreferredMethodToNVidia()
		{
			vtkVolumeTextureMapper3D.vtkVolumeTextureMapper3D_SetPreferredMethodToNVidia_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeTextureMapper3D_SetPreferredRenderMethod_21(HandleRef pThis, int _arg);

		public virtual void SetPreferredRenderMethod(int _arg)
		{
			vtkVolumeTextureMapper3D.vtkVolumeTextureMapper3D_SetPreferredRenderMethod_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeTextureMapper3D_SetSampleDistance_22(HandleRef pThis, float _arg);

		public virtual void SetSampleDistance(float _arg)
		{
			vtkVolumeTextureMapper3D.vtkVolumeTextureMapper3D_SetSampleDistance_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeTextureMapper3D_SetUseCompressedTexture_23(HandleRef pThis, byte _arg);

		public virtual void SetUseCompressedTexture(bool _arg)
		{
			vtkVolumeTextureMapper3D.vtkVolumeTextureMapper3D_SetUseCompressedTexture_23(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}
	}
}
