using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTexture : vtkImageAlgorithm
	{
		public enum VTKTextureBlendingMode
		{
			VTK_TEXTURE_BLENDING_MODE_ADD = 3,
			VTK_TEXTURE_BLENDING_MODE_ADD_SIGNED,
			VTK_TEXTURE_BLENDING_MODE_INTERPOLATE,
			VTK_TEXTURE_BLENDING_MODE_MODULATE = 2,
			VTK_TEXTURE_BLENDING_MODE_NONE = 0,
			VTK_TEXTURE_BLENDING_MODE_REPLACE,
			VTK_TEXTURE_BLENDING_MODE_SUBTRACT = 6
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkTexture";

		public new static readonly string MRClassNameKey;

		static vtkTexture()
		{
			vtkTexture.MRClassNameKey = "class vtkTexture";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTexture.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTexture"));
		}

		public vtkTexture(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTexture_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTexture New()
		{
			vtkTexture result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTexture.vtkTexture_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTexture() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTexture.vtkTexture_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTexture_EdgeClampOff_01(HandleRef pThis);

		public virtual void EdgeClampOff()
		{
			vtkTexture.vtkTexture_EdgeClampOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTexture_EdgeClampOn_02(HandleRef pThis);

		public virtual void EdgeClampOn()
		{
			vtkTexture.vtkTexture_EdgeClampOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTexture_GetBlendingMode_03(HandleRef pThis);

		public virtual int GetBlendingMode()
		{
			return vtkTexture.vtkTexture_GetBlendingMode_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTexture_GetEdgeClamp_04(HandleRef pThis);

		public virtual int GetEdgeClamp()
		{
			return vtkTexture.vtkTexture_GetEdgeClamp_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTexture_GetInput_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageData GetInput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTexture.vtkTexture_GetInput_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTexture_GetInterpolate_06(HandleRef pThis);

		public virtual int GetInterpolate()
		{
			return vtkTexture.vtkTexture_GetInterpolate_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTexture_GetLookupTable_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkScalarsToColors GetLookupTable()
		{
			vtkScalarsToColors vtkScalarsToColors = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTexture.vtkTexture_GetLookupTable_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarsToColors = (vtkScalarsToColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarsToColors.Register(null);
				}
			}
			return vtkScalarsToColors;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTexture_GetMapColorScalarsThroughLookupTable_08(HandleRef pThis);

		public virtual int GetMapColorScalarsThroughLookupTable()
		{
			return vtkTexture.vtkTexture_GetMapColorScalarsThroughLookupTable_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTexture_GetMappedScalars_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkUnsignedCharArray GetMappedScalars()
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTexture.vtkTexture_GetMappedScalars_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedCharArray = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedCharArray.Register(null);
				}
			}
			return vtkUnsignedCharArray;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkTexture_GetPremultipliedAlpha_10(HandleRef pThis);

		public virtual bool GetPremultipliedAlpha()
		{
			return vtkTexture.vtkTexture_GetPremultipliedAlpha_10(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTexture_GetQuality_11(HandleRef pThis);

		public virtual int GetQuality()
		{
			return vtkTexture.vtkTexture_GetQuality_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTexture_GetRepeat_12(HandleRef pThis);

		public virtual int GetRepeat()
		{
			return vtkTexture.vtkTexture_GetRepeat_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTexture_GetRestrictPowerOf2ImageSmaller_13(HandleRef pThis);

		public virtual int GetRestrictPowerOf2ImageSmaller()
		{
			return vtkTexture.vtkTexture_GetRestrictPowerOf2ImageSmaller_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTexture_GetTransform_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTransform GetTransform()
		{
			vtkTransform vtkTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTexture.vtkTexture_GetTransform_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransform = (vtkTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransform.Register(null);
				}
			}
			return vtkTransform;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTexture_InterpolateOff_15(HandleRef pThis);

		public virtual void InterpolateOff()
		{
			vtkTexture.vtkTexture_InterpolateOff_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTexture_InterpolateOn_16(HandleRef pThis);

		public virtual void InterpolateOn()
		{
			vtkTexture.vtkTexture_InterpolateOn_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTexture_IsA_17(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTexture.vtkTexture_IsA_17(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTexture_IsTranslucent_18(HandleRef pThis);

		public virtual int IsTranslucent()
		{
			return vtkTexture.vtkTexture_IsTranslucent_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTexture_IsTypeOf_19(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTexture.vtkTexture_IsTypeOf_19(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTexture_Load_20(HandleRef pThis, HandleRef arg0);

		public virtual void Load(vtkRenderer arg0)
		{
			vtkTexture.vtkTexture_Load_20(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTexture_MapColorScalarsThroughLookupTableOff_21(HandleRef pThis);

		public virtual void MapColorScalarsThroughLookupTableOff()
		{
			vtkTexture.vtkTexture_MapColorScalarsThroughLookupTableOff_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTexture_MapColorScalarsThroughLookupTableOn_22(HandleRef pThis);

		public virtual void MapColorScalarsThroughLookupTableOn()
		{
			vtkTexture.vtkTexture_MapColorScalarsThroughLookupTableOn_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTexture_MapScalarsToColors_23(HandleRef pThis, HandleRef scalars);

		public IntPtr MapScalarsToColors(vtkDataArray scalars)
		{
			return vtkTexture.vtkTexture_MapScalarsToColors_23(base.GetCppThis(), (scalars == null) ? default(HandleRef) : scalars.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTexture_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTexture NewInstance()
		{
			vtkTexture result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTexture.vtkTexture_NewInstance_25(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTexture_PostRender_26(HandleRef pThis, HandleRef arg0);

		public virtual void PostRender(vtkRenderer arg0)
		{
			vtkTexture.vtkTexture_PostRender_26(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTexture_PremultipliedAlphaOff_27(HandleRef pThis);

		public virtual void PremultipliedAlphaOff()
		{
			vtkTexture.vtkTexture_PremultipliedAlphaOff_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTexture_PremultipliedAlphaOn_28(HandleRef pThis);

		public virtual void PremultipliedAlphaOn()
		{
			vtkTexture.vtkTexture_PremultipliedAlphaOn_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTexture_ReleaseGraphicsResources_29(HandleRef pThis, HandleRef arg0);

		public virtual void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkTexture.vtkTexture_ReleaseGraphicsResources_29(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTexture_Render_30(HandleRef pThis, HandleRef ren);

		public virtual void Render(vtkRenderer ren)
		{
			vtkTexture.vtkTexture_Render_30(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTexture_RepeatOff_31(HandleRef pThis);

		public virtual void RepeatOff()
		{
			vtkTexture.vtkTexture_RepeatOff_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTexture_RepeatOn_32(HandleRef pThis);

		public virtual void RepeatOn()
		{
			vtkTexture.vtkTexture_RepeatOn_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTexture_RestrictPowerOf2ImageSmallerOff_33(HandleRef pThis);

		public virtual void RestrictPowerOf2ImageSmallerOff()
		{
			vtkTexture.vtkTexture_RestrictPowerOf2ImageSmallerOff_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTexture_RestrictPowerOf2ImageSmallerOn_34(HandleRef pThis);

		public virtual void RestrictPowerOf2ImageSmallerOn()
		{
			vtkTexture.vtkTexture_RestrictPowerOf2ImageSmallerOn_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTexture_SafeDownCast_35(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTexture SafeDownCast(vtkObjectBase o)
		{
			vtkTexture vtkTexture = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTexture.vtkTexture_SafeDownCast_35((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTexture = (vtkTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTexture.Register(null);
				}
			}
			return vtkTexture;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTexture_SetBlendingMode_36(HandleRef pThis, int _arg);

		public virtual void SetBlendingMode(int _arg)
		{
			vtkTexture.vtkTexture_SetBlendingMode_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTexture_SetEdgeClamp_37(HandleRef pThis, int _arg);

		public virtual void SetEdgeClamp(int _arg)
		{
			vtkTexture.vtkTexture_SetEdgeClamp_37(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTexture_SetInterpolate_38(HandleRef pThis, int _arg);

		public virtual void SetInterpolate(int _arg)
		{
			vtkTexture.vtkTexture_SetInterpolate_38(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTexture_SetLookupTable_39(HandleRef pThis, HandleRef arg0);

		public void SetLookupTable(vtkScalarsToColors arg0)
		{
			vtkTexture.vtkTexture_SetLookupTable_39(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTexture_SetMapColorScalarsThroughLookupTable_40(HandleRef pThis, int _arg);

		public virtual void SetMapColorScalarsThroughLookupTable(int _arg)
		{
			vtkTexture.vtkTexture_SetMapColorScalarsThroughLookupTable_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTexture_SetPremultipliedAlpha_41(HandleRef pThis, byte _arg);

		public virtual void SetPremultipliedAlpha(bool _arg)
		{
			vtkTexture.vtkTexture_SetPremultipliedAlpha_41(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTexture_SetQuality_42(HandleRef pThis, int _arg);

		public virtual void SetQuality(int _arg)
		{
			vtkTexture.vtkTexture_SetQuality_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTexture_SetQualityTo16Bit_43(HandleRef pThis);

		public void SetQualityTo16Bit()
		{
			vtkTexture.vtkTexture_SetQualityTo16Bit_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTexture_SetQualityTo32Bit_44(HandleRef pThis);

		public void SetQualityTo32Bit()
		{
			vtkTexture.vtkTexture_SetQualityTo32Bit_44(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTexture_SetQualityToDefault_45(HandleRef pThis);

		public void SetQualityToDefault()
		{
			vtkTexture.vtkTexture_SetQualityToDefault_45(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTexture_SetRepeat_46(HandleRef pThis, int _arg);

		public virtual void SetRepeat(int _arg)
		{
			vtkTexture.vtkTexture_SetRepeat_46(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTexture_SetRestrictPowerOf2ImageSmaller_47(HandleRef pThis, int _arg);

		public virtual void SetRestrictPowerOf2ImageSmaller(int _arg)
		{
			vtkTexture.vtkTexture_SetRestrictPowerOf2ImageSmaller_47(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTexture_SetTransform_48(HandleRef pThis, HandleRef transform);

		public void SetTransform(vtkTransform transform)
		{
			vtkTexture.vtkTexture_SetTransform_48(base.GetCppThis(), (transform == null) ? default(HandleRef) : transform.GetCppThis());
		}
	}
}
