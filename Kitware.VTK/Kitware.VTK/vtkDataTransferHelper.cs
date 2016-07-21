using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDataTransferHelper : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataTransferHelper";

		public new static readonly string MRClassNameKey;

		static vtkDataTransferHelper()
		{
			vtkDataTransferHelper.MRClassNameKey = "class vtkDataTransferHelper";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataTransferHelper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataTransferHelper"));
		}

		public vtkDataTransferHelper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataTransferHelper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataTransferHelper New()
		{
			vtkDataTransferHelper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataTransferHelper.vtkDataTransferHelper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataTransferHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDataTransferHelper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDataTransferHelper.vtkDataTransferHelper_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkDataTransferHelper_Download_01(HandleRef pThis);

		public bool Download()
		{
			return vtkDataTransferHelper.vtkDataTransferHelper_Download_01(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkDataTransferHelper_DownloadAsync1_02(HandleRef pThis);

		public bool DownloadAsync1()
		{
			return vtkDataTransferHelper.vtkDataTransferHelper_DownloadAsync1_02(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkDataTransferHelper_DownloadAsync2_03(HandleRef pThis);

		public bool DownloadAsync2()
		{
			return vtkDataTransferHelper.vtkDataTransferHelper_DownloadAsync2_03(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataTransferHelper_GetArray_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDataArray GetArray()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataTransferHelper.vtkDataTransferHelper_GetArray_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataTransferHelper_GetCPUExtent_05(HandleRef pThis);

		public virtual int[] GetCPUExtent()
		{
			IntPtr intPtr = vtkDataTransferHelper.vtkDataTransferHelper_GetCPUExtent_05(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDataTransferHelper_GetCPUExtent_06(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		public virtual void GetCPUExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkDataTransferHelper.vtkDataTransferHelper_GetCPUExtent_06(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDataTransferHelper_GetCPUExtent_07(HandleRef pThis, IntPtr _arg);

		public virtual void GetCPUExtent(IntPtr _arg)
		{
			vtkDataTransferHelper.vtkDataTransferHelper_GetCPUExtent_07(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkDataTransferHelper_GetCPUExtentIsValid_08(HandleRef pThis);

		public bool GetCPUExtentIsValid()
		{
			return vtkDataTransferHelper.vtkDataTransferHelper_GetCPUExtentIsValid_08(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataTransferHelper_GetContext_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkRenderWindow GetContext()
		{
			vtkRenderWindow vtkRenderWindow = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataTransferHelper.vtkDataTransferHelper_GetContext_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern byte vtkDataTransferHelper_GetExtentIsValid_10(HandleRef pThis, IntPtr extent);

		public bool GetExtentIsValid(IntPtr extent)
		{
			return vtkDataTransferHelper.vtkDataTransferHelper_GetExtentIsValid_10(base.GetCppThis(), extent) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataTransferHelper_GetGPUExtent_11(HandleRef pThis);

		public virtual int[] GetGPUExtent()
		{
			IntPtr intPtr = vtkDataTransferHelper.vtkDataTransferHelper_GetGPUExtent_11(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDataTransferHelper_GetGPUExtent_12(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		public virtual void GetGPUExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkDataTransferHelper.vtkDataTransferHelper_GetGPUExtent_12(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDataTransferHelper_GetGPUExtent_13(HandleRef pThis, IntPtr _arg);

		public virtual void GetGPUExtent(IntPtr _arg)
		{
			vtkDataTransferHelper.vtkDataTransferHelper_GetGPUExtent_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkDataTransferHelper_GetGPUExtentIsValid_14(HandleRef pThis);

		public bool GetGPUExtentIsValid()
		{
			return vtkDataTransferHelper.vtkDataTransferHelper_GetGPUExtentIsValid_14(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkDataTransferHelper_GetMinTextureDimension_15(HandleRef pThis);

		public virtual int GetMinTextureDimension()
		{
			return vtkDataTransferHelper.vtkDataTransferHelper_GetMinTextureDimension_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkDataTransferHelper_GetShaderSupportsTextureInt_16(HandleRef pThis);

		public bool GetShaderSupportsTextureInt()
		{
			return vtkDataTransferHelper.vtkDataTransferHelper_GetShaderSupportsTextureInt_16(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataTransferHelper_GetTexture_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextureObject GetTexture()
		{
			vtkTextureObject vtkTextureObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataTransferHelper.vtkDataTransferHelper_GetTexture_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkDataTransferHelper_GetTextureExtent_18(HandleRef pThis);

		public virtual int[] GetTextureExtent()
		{
			IntPtr intPtr = vtkDataTransferHelper.vtkDataTransferHelper_GetTextureExtent_18(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDataTransferHelper_GetTextureExtent_19(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		public virtual void GetTextureExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkDataTransferHelper.vtkDataTransferHelper_GetTextureExtent_19(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDataTransferHelper_GetTextureExtent_20(HandleRef pThis, IntPtr _arg);

		public virtual void GetTextureExtent(IntPtr _arg)
		{
			vtkDataTransferHelper.vtkDataTransferHelper_GetTextureExtent_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkDataTransferHelper_GetTextureExtentIsValid_21(HandleRef pThis);

		public bool GetTextureExtentIsValid()
		{
			return vtkDataTransferHelper.vtkDataTransferHelper_GetTextureExtentIsValid_21(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkDataTransferHelper_IsA_22(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDataTransferHelper.vtkDataTransferHelper_IsA_22(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkDataTransferHelper_IsSupported_23(HandleRef renWin);

		public static bool IsSupported(vtkRenderWindow renWin)
		{
			return vtkDataTransferHelper.vtkDataTransferHelper_IsSupported_23((renWin == null) ? default(HandleRef) : renWin.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkDataTransferHelper_IsTypeOf_24(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDataTransferHelper.vtkDataTransferHelper_IsTypeOf_24(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataTransferHelper_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDataTransferHelper NewInstance()
		{
			vtkDataTransferHelper result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataTransferHelper.vtkDataTransferHelper_NewInstance_26(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataTransferHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDataTransferHelper_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataTransferHelper SafeDownCast(vtkObjectBase o)
		{
			vtkDataTransferHelper vtkDataTransferHelper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataTransferHelper.vtkDataTransferHelper_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataTransferHelper = (vtkDataTransferHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataTransferHelper.Register(null);
				}
			}
			return vtkDataTransferHelper;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDataTransferHelper_SetArray_28(HandleRef pThis, HandleRef array);

		public void SetArray(vtkDataArray array)
		{
			vtkDataTransferHelper.vtkDataTransferHelper_SetArray_28(base.GetCppThis(), (array == null) ? default(HandleRef) : array.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDataTransferHelper_SetCPUExtent_29(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		public virtual void SetCPUExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkDataTransferHelper.vtkDataTransferHelper_SetCPUExtent_29(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDataTransferHelper_SetCPUExtent_30(HandleRef pThis, IntPtr _arg);

		public virtual void SetCPUExtent(IntPtr _arg)
		{
			vtkDataTransferHelper.vtkDataTransferHelper_SetCPUExtent_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDataTransferHelper_SetContext_31(HandleRef pThis, HandleRef context);

		public void SetContext(vtkRenderWindow context)
		{
			vtkDataTransferHelper.vtkDataTransferHelper_SetContext_31(base.GetCppThis(), (context == null) ? default(HandleRef) : context.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDataTransferHelper_SetGPUExtent_32(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		public virtual void SetGPUExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkDataTransferHelper.vtkDataTransferHelper_SetGPUExtent_32(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDataTransferHelper_SetGPUExtent_33(HandleRef pThis, IntPtr _arg);

		public virtual void SetGPUExtent(IntPtr _arg)
		{
			vtkDataTransferHelper.vtkDataTransferHelper_SetGPUExtent_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDataTransferHelper_SetMinTextureDimension_34(HandleRef pThis, int _arg);

		public virtual void SetMinTextureDimension(int _arg)
		{
			vtkDataTransferHelper.vtkDataTransferHelper_SetMinTextureDimension_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDataTransferHelper_SetShaderSupportsTextureInt_35(HandleRef pThis, byte value);

		public void SetShaderSupportsTextureInt(bool value)
		{
			vtkDataTransferHelper.vtkDataTransferHelper_SetShaderSupportsTextureInt_35(base.GetCppThis(), value ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDataTransferHelper_SetTexture_36(HandleRef pThis, HandleRef texture);

		public void SetTexture(vtkTextureObject texture)
		{
			vtkDataTransferHelper.vtkDataTransferHelper_SetTexture_36(base.GetCppThis(), (texture == null) ? default(HandleRef) : texture.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDataTransferHelper_SetTextureExtent_37(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		public virtual void SetTextureExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkDataTransferHelper.vtkDataTransferHelper_SetTextureExtent_37(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDataTransferHelper_SetTextureExtent_38(HandleRef pThis, IntPtr _arg);

		public virtual void SetTextureExtent(IntPtr _arg)
		{
			vtkDataTransferHelper.vtkDataTransferHelper_SetTextureExtent_38(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkDataTransferHelper_Upload_39(HandleRef pThis, int components, IntPtr componentList);

		public bool Upload(int components, IntPtr componentList)
		{
			return vtkDataTransferHelper.vtkDataTransferHelper_Upload_39(base.GetCppThis(), components, componentList) != 0;
		}
	}
}
