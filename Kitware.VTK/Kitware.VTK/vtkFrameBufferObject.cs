using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkFrameBufferObject : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkFrameBufferObject";

		public new static readonly string MRClassNameKey;

		static vtkFrameBufferObject()
		{
			vtkFrameBufferObject.MRClassNameKey = "class vtkFrameBufferObject";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFrameBufferObject.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFrameBufferObject"));
		}

		public vtkFrameBufferObject(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFrameBufferObject_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFrameBufferObject New()
		{
			vtkFrameBufferObject result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFrameBufferObject.vtkFrameBufferObject_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFrameBufferObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkFrameBufferObject() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkFrameBufferObject.vtkFrameBufferObject_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkFrameBufferObject_Bind_01(HandleRef pThis);

		public void Bind()
		{
			vtkFrameBufferObject.vtkFrameBufferObject_Bind_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFrameBufferObject_GetColorBuffer_02(HandleRef pThis, uint index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkTextureObject GetColorBuffer(uint index)
		{
			vtkTextureObject vtkTextureObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFrameBufferObject.vtkFrameBufferObject_GetColorBuffer_02(base.GetCppThis(), index, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkFrameBufferObject_GetContext_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkRenderWindow GetContext()
		{
			vtkRenderWindow vtkRenderWindow = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFrameBufferObject.vtkFrameBufferObject_GetContext_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern byte vtkFrameBufferObject_GetDepthBufferNeeded_04(HandleRef pThis);

		public virtual bool GetDepthBufferNeeded()
		{
			return vtkFrameBufferObject.vtkFrameBufferObject_GetDepthBufferNeeded_04(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFrameBufferObject_GetLastSize_05(HandleRef pThis);

		public virtual int[] GetLastSize()
		{
			IntPtr intPtr = vtkFrameBufferObject.vtkFrameBufferObject_GetLastSize_05(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkFrameBufferObject_GetLastSize_06(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetLastSize(ref int _arg1, ref int _arg2)
		{
			vtkFrameBufferObject.vtkFrameBufferObject_GetLastSize_06(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkFrameBufferObject_GetLastSize_07(HandleRef pThis, IntPtr _arg);

		public virtual void GetLastSize(IntPtr _arg)
		{
			vtkFrameBufferObject.vtkFrameBufferObject_GetLastSize_07(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkFrameBufferObject_GetMaximumNumberOfActiveTargets_08(HandleRef pThis);

		public uint GetMaximumNumberOfActiveTargets()
		{
			return vtkFrameBufferObject.vtkFrameBufferObject_GetMaximumNumberOfActiveTargets_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkFrameBufferObject_GetMaximumNumberOfRenderTargets_09(HandleRef pThis);

		public uint GetMaximumNumberOfRenderTargets()
		{
			return vtkFrameBufferObject.vtkFrameBufferObject_GetMaximumNumberOfRenderTargets_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkFrameBufferObject_GetNumberOfRenderTargets_10(HandleRef pThis);

		public virtual uint GetNumberOfRenderTargets()
		{
			return vtkFrameBufferObject.vtkFrameBufferObject_GetNumberOfRenderTargets_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkFrameBufferObject_IsA_11(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkFrameBufferObject.vtkFrameBufferObject_IsA_11(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkFrameBufferObject_IsSupported_12(HandleRef renWin);

		public static bool IsSupported(vtkRenderWindow renWin)
		{
			return vtkFrameBufferObject.vtkFrameBufferObject_IsSupported_12((renWin == null) ? default(HandleRef) : renWin.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkFrameBufferObject_IsTypeOf_13(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkFrameBufferObject.vtkFrameBufferObject_IsTypeOf_13(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFrameBufferObject_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkFrameBufferObject NewInstance()
		{
			vtkFrameBufferObject result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFrameBufferObject.vtkFrameBufferObject_NewInstance_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFrameBufferObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkFrameBufferObject_RemoveAllColorBuffers_16(HandleRef pThis);

		public void RemoveAllColorBuffers()
		{
			vtkFrameBufferObject.vtkFrameBufferObject_RemoveAllColorBuffers_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkFrameBufferObject_RemoveColorBuffer_17(HandleRef pThis, uint index);

		public void RemoveColorBuffer(uint index)
		{
			vtkFrameBufferObject.vtkFrameBufferObject_RemoveColorBuffer_17(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkFrameBufferObject_RemoveDepthBuffer_18(HandleRef pThis);

		public void RemoveDepthBuffer()
		{
			vtkFrameBufferObject.vtkFrameBufferObject_RemoveDepthBuffer_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkFrameBufferObject_RenderQuad_19(HandleRef pThis, int minX, int maxX, int minY, int maxY);

		public void RenderQuad(int minX, int maxX, int minY, int maxY)
		{
			vtkFrameBufferObject.vtkFrameBufferObject_RenderQuad_19(base.GetCppThis(), minX, maxX, minY, maxY);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkFrameBufferObject_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFrameBufferObject SafeDownCast(vtkObjectBase o)
		{
			vtkFrameBufferObject vtkFrameBufferObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFrameBufferObject.vtkFrameBufferObject_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFrameBufferObject = (vtkFrameBufferObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFrameBufferObject.Register(null);
				}
			}
			return vtkFrameBufferObject;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkFrameBufferObject_SetActiveBuffer_21(HandleRef pThis, uint index);

		public void SetActiveBuffer(uint index)
		{
			vtkFrameBufferObject.vtkFrameBufferObject_SetActiveBuffer_21(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkFrameBufferObject_SetActiveBuffers_22(HandleRef pThis, int numbuffers, IntPtr indices);

		public void SetActiveBuffers(int numbuffers, IntPtr indices)
		{
			vtkFrameBufferObject.vtkFrameBufferObject_SetActiveBuffers_22(base.GetCppThis(), numbuffers, indices);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkFrameBufferObject_SetColorBuffer_23(HandleRef pThis, uint index, HandleRef texture, uint zslice);

		public void SetColorBuffer(uint index, vtkTextureObject texture, uint zslice)
		{
			vtkFrameBufferObject.vtkFrameBufferObject_SetColorBuffer_23(base.GetCppThis(), index, (texture == null) ? default(HandleRef) : texture.GetCppThis(), zslice);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkFrameBufferObject_SetContext_24(HandleRef pThis, HandleRef context);

		public void SetContext(vtkRenderWindow context)
		{
			vtkFrameBufferObject.vtkFrameBufferObject_SetContext_24(base.GetCppThis(), (context == null) ? default(HandleRef) : context.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkFrameBufferObject_SetDepthBuffer_25(HandleRef pThis, HandleRef depthTexture);

		public void SetDepthBuffer(vtkTextureObject depthTexture)
		{
			vtkFrameBufferObject.vtkFrameBufferObject_SetDepthBuffer_25(base.GetCppThis(), (depthTexture == null) ? default(HandleRef) : depthTexture.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkFrameBufferObject_SetDepthBufferNeeded_26(HandleRef pThis, byte _arg);

		public virtual void SetDepthBufferNeeded(bool _arg)
		{
			vtkFrameBufferObject.vtkFrameBufferObject_SetDepthBufferNeeded_26(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkFrameBufferObject_SetNumberOfRenderTargets_27(HandleRef pThis, uint arg0);

		public void SetNumberOfRenderTargets(uint arg0)
		{
			vtkFrameBufferObject.vtkFrameBufferObject_SetNumberOfRenderTargets_27(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkFrameBufferObject_Start_28(HandleRef pThis, int width, int height, byte shaderSupportsTextureInt);

		public bool Start(int width, int height, bool shaderSupportsTextureInt)
		{
			return vtkFrameBufferObject.vtkFrameBufferObject_Start_28(base.GetCppThis(), width, height, shaderSupportsTextureInt ? (byte)1 : (byte)0) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkFrameBufferObject_StartNonOrtho_29(HandleRef pThis, int width, int height, byte shaderSupportsTextureInt);

		public bool StartNonOrtho(int width, int height, bool shaderSupportsTextureInt)
		{
			return vtkFrameBufferObject.vtkFrameBufferObject_StartNonOrtho_29(base.GetCppThis(), width, height, shaderSupportsTextureInt ? (byte)1 : (byte)0) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkFrameBufferObject_UnBind_30(HandleRef pThis);

		public void UnBind()
		{
			vtkFrameBufferObject.vtkFrameBufferObject_UnBind_30(base.GetCppThis());
		}
	}
}
