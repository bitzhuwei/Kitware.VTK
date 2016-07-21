using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTextureObject : vtkObject
	{
		public enum AlwaysTrue_WrapperEnum
		{
			AlwaysTrue = 6,
			Equal = 4,
			Gequal = 1,
			Greater = 3,
			Lequal = 0,
			Less = 2,
			Never = 7,
			NotEqual = 5,
			NumberOfDepthTextureCompareFunctions = 8
		}

		public enum Alpha_WrapperEnum
		{
			Alpha = 2,
			Intensity = 1,
			Luminance = 0,
			NumberOfDepthTextureModes = 3
		}

		public enum Clamp_WrapperEnum
		{
			Clamp,
			ClampToBorder = 3,
			ClampToEdge = 1,
			MirroredRepeat = 4,
			NumberOfWrapModes,
			Repeat = 2
		}

		public enum Linear_WrapperEnum
		{
			Linear = 1,
			LinearMipmapLinear = 5,
			LinearMipmapNearest = 4,
			Nearest = 0,
			NearestMipmapLinear = 3,
			NearestMipmapNearest = 2,
			NumberOfMinificationModes = 6
		}

		public enum Fixed16_WrapperEnum
		{
			Fixed16 = 1,
			Fixed24,
			Fixed32,
			Float32,
			Native = 0,
			NumberOfDepthFormats = 5
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkTextureObject";

		public new static readonly string MRClassNameKey;

		static vtkTextureObject()
		{
			vtkTextureObject.MRClassNameKey = "class vtkTextureObject";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTextureObject.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTextureObject"));
		}

		public vtkTextureObject(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTextureObject_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTextureObject New()
		{
			vtkTextureObject result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTextureObject.vtkTextureObject_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextureObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTextureObject() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTextureObject.vtkTextureObject_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkTextureObject_Allocate1D_01(HandleRef pThis, uint width, int numComps, int vtkType);

		public bool Allocate1D(uint width, int numComps, int vtkType)
		{
			return vtkTextureObject.vtkTextureObject_Allocate1D_01(base.GetCppThis(), width, numComps, vtkType) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkTextureObject_Allocate2D_02(HandleRef pThis, uint width, uint height, int numComps, int vtkType);

		public bool Allocate2D(uint width, uint height, int numComps, int vtkType)
		{
			return vtkTextureObject.vtkTextureObject_Allocate2D_02(base.GetCppThis(), width, height, numComps, vtkType) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkTextureObject_Allocate3D_03(HandleRef pThis, uint width, uint height, uint depth, int numComps, int vtkType);

		public bool Allocate3D(uint width, uint height, uint depth, int numComps, int vtkType)
		{
			return vtkTextureObject.vtkTextureObject_Allocate3D_03(base.GetCppThis(), width, height, depth, numComps, vtkType) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkTextureObject_AllocateDepth_04(HandleRef pThis, uint width, uint height, int internalFormat);

		public bool AllocateDepth(uint width, uint height, int internalFormat)
		{
			return vtkTextureObject.vtkTextureObject_AllocateDepth_04(base.GetCppThis(), width, height, internalFormat) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextureObject_Bind_05(HandleRef pThis);

		public void Bind()
		{
			vtkTextureObject.vtkTextureObject_Bind_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextureObject_CopyFromFrameBuffer_06(HandleRef pThis, int srcXmin, int srcYmin, int dstXmin, int dstYmin, int width, int height);

		public void CopyFromFrameBuffer(int srcXmin, int srcYmin, int dstXmin, int dstYmin, int width, int height)
		{
			vtkTextureObject.vtkTextureObject_CopyFromFrameBuffer_06(base.GetCppThis(), srcXmin, srcYmin, dstXmin, dstYmin, width, height);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextureObject_CopyToFrameBuffer_07(HandleRef pThis, int srcXmin, int srcYmin, int srcXmax, int srcYmax, int dstXmin, int dstYmin, int width, int height);

		public void CopyToFrameBuffer(int srcXmin, int srcYmin, int srcXmax, int srcYmax, int dstXmin, int dstYmin, int width, int height)
		{
			vtkTextureObject.vtkTextureObject_CopyToFrameBuffer_07(base.GetCppThis(), srcXmin, srcYmin, srcXmax, srcYmax, dstXmin, dstYmin, width, height);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkTextureObject_Create1D_08(HandleRef pThis, int numComps, HandleRef pbo, byte shaderSupportsTextureInt);

		public bool Create1D(int numComps, vtkPixelBufferObject pbo, bool shaderSupportsTextureInt)
		{
			return vtkTextureObject.vtkTextureObject_Create1D_08(base.GetCppThis(), numComps, (pbo == null) ? default(HandleRef) : pbo.GetCppThis(), shaderSupportsTextureInt ? (byte)1 : (byte)0) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkTextureObject_Create2D_09(HandleRef pThis, uint width, uint height, int numComps, HandleRef pbo, byte shaderSupportsTextureInt);

		public bool Create2D(uint width, uint height, int numComps, vtkPixelBufferObject pbo, bool shaderSupportsTextureInt)
		{
			return vtkTextureObject.vtkTextureObject_Create2D_09(base.GetCppThis(), width, height, numComps, (pbo == null) ? default(HandleRef) : pbo.GetCppThis(), shaderSupportsTextureInt ? (byte)1 : (byte)0) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkTextureObject_Create2D_10(HandleRef pThis, uint width, uint height, int numComps, int vtktype, byte shaderSupportsTextureInt);

		public bool Create2D(uint width, uint height, int numComps, int vtktype, bool shaderSupportsTextureInt)
		{
			return vtkTextureObject.vtkTextureObject_Create2D_10(base.GetCppThis(), width, height, numComps, vtktype, shaderSupportsTextureInt ? (byte)1 : (byte)0) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkTextureObject_Create3D_11(HandleRef pThis, uint width, uint height, uint depth, int numComps, HandleRef pbo, byte shaderSupportsTextureInt);

		public bool Create3D(uint width, uint height, uint depth, int numComps, vtkPixelBufferObject pbo, bool shaderSupportsTextureInt)
		{
			return vtkTextureObject.vtkTextureObject_Create3D_11(base.GetCppThis(), width, height, depth, numComps, (pbo == null) ? default(HandleRef) : pbo.GetCppThis(), shaderSupportsTextureInt ? (byte)1 : (byte)0) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkTextureObject_Create3D_12(HandleRef pThis, uint width, uint height, uint depth, int numComps, int vtktype, byte shaderSupportsTextureInt);

		public bool Create3D(uint width, uint height, uint depth, int numComps, int vtktype, bool shaderSupportsTextureInt)
		{
			return vtkTextureObject.vtkTextureObject_Create3D_12(base.GetCppThis(), width, height, depth, numComps, vtktype, shaderSupportsTextureInt ? (byte)1 : (byte)0) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkTextureObject_CreateDepth_13(HandleRef pThis, uint width, uint height, int internalFormat, HandleRef pbo);

		public bool CreateDepth(uint width, uint height, int internalFormat, vtkPixelBufferObject pbo)
		{
			return vtkTextureObject.vtkTextureObject_CreateDepth_13(base.GetCppThis(), width, height, internalFormat, (pbo == null) ? default(HandleRef) : pbo.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkTextureObject_CreateDepthFromRaw_14(HandleRef pThis, uint width, uint height, int internalFormat, int rawType, IntPtr raw);

		public bool CreateDepthFromRaw(uint width, uint height, int internalFormat, int rawType, IntPtr raw)
		{
			return vtkTextureObject.vtkTextureObject_CreateDepthFromRaw_14(base.GetCppThis(), width, height, internalFormat, rawType, raw) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTextureObject_Download_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPixelBufferObject Download()
		{
			vtkPixelBufferObject vtkPixelBufferObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTextureObject.vtkTextureObject_Download_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPixelBufferObject = (vtkPixelBufferObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPixelBufferObject.Register(null);
				}
			}
			return vtkPixelBufferObject;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextureObject_GetBaseLevel_16(HandleRef pThis);

		public virtual int GetBaseLevel()
		{
			return vtkTextureObject.vtkTextureObject_GetBaseLevel_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTextureObject_GetBorderColor_17(HandleRef pThis);

		public virtual float[] GetBorderColor()
		{
			IntPtr intPtr = vtkTextureObject.vtkTextureObject_GetBorderColor_17(base.GetCppThis());
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextureObject_GetBorderColor_18(HandleRef pThis, ref float _arg1, ref float _arg2, ref float _arg3, ref float _arg4);

		public virtual void GetBorderColor(ref float _arg1, ref float _arg2, ref float _arg3, ref float _arg4)
		{
			vtkTextureObject.vtkTextureObject_GetBorderColor_18(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextureObject_GetBorderColor_19(HandleRef pThis, IntPtr _arg);

		public virtual void GetBorderColor(IntPtr _arg)
		{
			vtkTextureObject.vtkTextureObject_GetBorderColor_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextureObject_GetComponents_20(HandleRef pThis);

		public virtual int GetComponents()
		{
			return vtkTextureObject.vtkTextureObject_GetComponents_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTextureObject_GetContext_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkRenderWindow GetContext()
		{
			vtkRenderWindow vtkRenderWindow = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTextureObject.vtkTextureObject_GetContext_21(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderWindow = (vtkRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderWindow.Register(null);
				}
			}
			return vtkRenderWindow;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextureObject_GetDataType_22(HandleRef pThis);

		public int GetDataType()
		{
			return vtkTextureObject.vtkTextureObject_GetDataType_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkTextureObject_GetDepth_23(HandleRef pThis);

		public virtual uint GetDepth()
		{
			return vtkTextureObject.vtkTextureObject_GetDepth_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkTextureObject_GetDepthTextureCompare_24(HandleRef pThis);

		public virtual bool GetDepthTextureCompare()
		{
			return vtkTextureObject.vtkTextureObject_GetDepthTextureCompare_24(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextureObject_GetDepthTextureCompareFunction_25(HandleRef pThis);

		public virtual int GetDepthTextureCompareFunction()
		{
			return vtkTextureObject.vtkTextureObject_GetDepthTextureCompareFunction_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextureObject_GetDepthTextureMode_26(HandleRef pThis);

		public virtual int GetDepthTextureMode()
		{
			return vtkTextureObject.vtkTextureObject_GetDepthTextureMode_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkTextureObject_GetFormat_27(HandleRef pThis, int vtktype, int numComps, byte shaderSupportsTextureInt);

		public uint GetFormat(int vtktype, int numComps, bool shaderSupportsTextureInt)
		{
			return vtkTextureObject.vtkTextureObject_GetFormat_27(base.GetCppThis(), vtktype, numComps, shaderSupportsTextureInt ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkTextureObject_GetGenerateMipmap_28(HandleRef pThis);

		public virtual bool GetGenerateMipmap()
		{
			return vtkTextureObject.vtkTextureObject_GetGenerateMipmap_28(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkTextureObject_GetHandle_29(HandleRef pThis);

		public virtual uint GetHandle()
		{
			return vtkTextureObject.vtkTextureObject_GetHandle_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkTextureObject_GetHeight_30(HandleRef pThis);

		public virtual uint GetHeight()
		{
			return vtkTextureObject.vtkTextureObject_GetHeight_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkTextureObject_GetInternalFormat_31(HandleRef pThis, int vtktype, int numComps, byte shaderSupportsTextureInt);

		public uint GetInternalFormat(int vtktype, int numComps, bool shaderSupportsTextureInt)
		{
			return vtkTextureObject.vtkTextureObject_GetInternalFormat_31(base.GetCppThis(), vtktype, numComps, shaderSupportsTextureInt ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkTextureObject_GetLinearMagnification_32(HandleRef pThis);

		public virtual bool GetLinearMagnification()
		{
			return vtkTextureObject.vtkTextureObject_GetLinearMagnification_32(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern float vtkTextureObject_GetMaxLOD_33(HandleRef pThis);

		public virtual float GetMaxLOD()
		{
			return vtkTextureObject.vtkTextureObject_GetMaxLOD_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextureObject_GetMaxLevel_34(HandleRef pThis);

		public virtual int GetMaxLevel()
		{
			return vtkTextureObject.vtkTextureObject_GetMaxLevel_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern float vtkTextureObject_GetMinLOD_35(HandleRef pThis);

		public virtual float GetMinLOD()
		{
			return vtkTextureObject.vtkTextureObject_GetMinLOD_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextureObject_GetMinificationFilter_36(HandleRef pThis);

		public virtual int GetMinificationFilter()
		{
			return vtkTextureObject.vtkTextureObject_GetMinificationFilter_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextureObject_GetNumberOfDimensions_37(HandleRef pThis);

		public virtual int GetNumberOfDimensions()
		{
			return vtkTextureObject.vtkTextureObject_GetNumberOfDimensions_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern float vtkTextureObject_GetPriority_38(HandleRef pThis);

		public virtual float GetPriority()
		{
			return vtkTextureObject.vtkTextureObject_GetPriority_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkTextureObject_GetTarget_39(HandleRef pThis);

		public virtual uint GetTarget()
		{
			return vtkTextureObject.vtkTextureObject_GetTarget_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkTextureObject_GetWidth_40(HandleRef pThis);

		public virtual uint GetWidth()
		{
			return vtkTextureObject.vtkTextureObject_GetWidth_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextureObject_GetWrapR_41(HandleRef pThis);

		public virtual int GetWrapR()
		{
			return vtkTextureObject.vtkTextureObject_GetWrapR_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextureObject_GetWrapS_42(HandleRef pThis);

		public virtual int GetWrapS()
		{
			return vtkTextureObject.vtkTextureObject_GetWrapS_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextureObject_GetWrapT_43(HandleRef pThis);

		public virtual int GetWrapT()
		{
			return vtkTextureObject.vtkTextureObject_GetWrapT_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextureObject_IsA_44(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTextureObject.vtkTextureObject_IsA_44(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkTextureObject_IsBound_45(HandleRef pThis);

		public bool IsBound()
		{
			return vtkTextureObject.vtkTextureObject_IsBound_45(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkTextureObject_IsSupported_46(HandleRef renWin);

		public static bool IsSupported(vtkRenderWindow renWin)
		{
			return vtkTextureObject.vtkTextureObject_IsSupported_46((renWin == null) ? default(HandleRef) : renWin.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTextureObject_IsTypeOf_47(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTextureObject.vtkTextureObject_IsTypeOf_47(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTextureObject_NewInstance_49(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTextureObject NewInstance()
		{
			vtkTextureObject result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTextureObject.vtkTextureObject_NewInstance_49(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextureObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTextureObject_SafeDownCast_50(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTextureObject SafeDownCast(vtkObjectBase o)
		{
			vtkTextureObject vtkTextureObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTextureObject.vtkTextureObject_SafeDownCast_50((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextureObject = (vtkTextureObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextureObject.Register(null);
				}
			}
			return vtkTextureObject;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextureObject_SendParameters_51(HandleRef pThis);

		public void SendParameters()
		{
			vtkTextureObject.vtkTextureObject_SendParameters_51(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextureObject_SetBaseLevel_52(HandleRef pThis, int _arg);

		public virtual void SetBaseLevel(int _arg)
		{
			vtkTextureObject.vtkTextureObject_SetBaseLevel_52(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextureObject_SetBorderColor_53(HandleRef pThis, float _arg1, float _arg2, float _arg3, float _arg4);

		public virtual void SetBorderColor(float _arg1, float _arg2, float _arg3, float _arg4)
		{
			vtkTextureObject.vtkTextureObject_SetBorderColor_53(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextureObject_SetBorderColor_54(HandleRef pThis, IntPtr _arg);

		public virtual void SetBorderColor(IntPtr _arg)
		{
			vtkTextureObject.vtkTextureObject_SetBorderColor_54(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextureObject_SetContext_55(HandleRef pThis, HandleRef arg0);

		public void SetContext(vtkRenderWindow arg0)
		{
			vtkTextureObject.vtkTextureObject_SetContext_55(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextureObject_SetDepthTextureCompare_56(HandleRef pThis, byte _arg);

		public virtual void SetDepthTextureCompare(bool _arg)
		{
			vtkTextureObject.vtkTextureObject_SetDepthTextureCompare_56(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextureObject_SetDepthTextureCompareFunction_57(HandleRef pThis, int _arg);

		public virtual void SetDepthTextureCompareFunction(int _arg)
		{
			vtkTextureObject.vtkTextureObject_SetDepthTextureCompareFunction_57(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextureObject_SetDepthTextureMode_58(HandleRef pThis, int _arg);

		public virtual void SetDepthTextureMode(int _arg)
		{
			vtkTextureObject.vtkTextureObject_SetDepthTextureMode_58(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextureObject_SetGenerateMipmap_59(HandleRef pThis, byte _arg);

		public virtual void SetGenerateMipmap(bool _arg)
		{
			vtkTextureObject.vtkTextureObject_SetGenerateMipmap_59(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextureObject_SetLinearMagnification_60(HandleRef pThis, byte _arg);

		public virtual void SetLinearMagnification(bool _arg)
		{
			vtkTextureObject.vtkTextureObject_SetLinearMagnification_60(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextureObject_SetMaxLOD_61(HandleRef pThis, float _arg);

		public virtual void SetMaxLOD(float _arg)
		{
			vtkTextureObject.vtkTextureObject_SetMaxLOD_61(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextureObject_SetMaxLevel_62(HandleRef pThis, int _arg);

		public virtual void SetMaxLevel(int _arg)
		{
			vtkTextureObject.vtkTextureObject_SetMaxLevel_62(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextureObject_SetMinLOD_63(HandleRef pThis, float _arg);

		public virtual void SetMinLOD(float _arg)
		{
			vtkTextureObject.vtkTextureObject_SetMinLOD_63(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextureObject_SetMinificationFilter_64(HandleRef pThis, int _arg);

		public virtual void SetMinificationFilter(int _arg)
		{
			vtkTextureObject.vtkTextureObject_SetMinificationFilter_64(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextureObject_SetPriority_65(HandleRef pThis, float _arg);

		public virtual void SetPriority(float _arg)
		{
			vtkTextureObject.vtkTextureObject_SetPriority_65(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextureObject_SetWrapR_66(HandleRef pThis, int _arg);

		public virtual void SetWrapR(int _arg)
		{
			vtkTextureObject.vtkTextureObject_SetWrapR_66(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextureObject_SetWrapS_67(HandleRef pThis, int _arg);

		public virtual void SetWrapS(int _arg)
		{
			vtkTextureObject.vtkTextureObject_SetWrapS_67(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextureObject_SetWrapT_68(HandleRef pThis, int _arg);

		public virtual void SetWrapT(int _arg)
		{
			vtkTextureObject.vtkTextureObject_SetWrapT_68(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTextureObject_UnBind_69(HandleRef pThis);

		public void UnBind()
		{
			vtkTextureObject.vtkTextureObject_UnBind_69(base.GetCppThis());
		}
	}
}
