using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkVolumeTextureMapper2D : vtkVolumeTextureMapper
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkVolumeTextureMapper2D";

		public new static readonly string MRClassNameKey;

		static vtkVolumeTextureMapper2D()
		{
			vtkVolumeTextureMapper2D.MRClassNameKey = "class vtkVolumeTextureMapper2D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVolumeTextureMapper2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVolumeTextureMapper2D"));
		}

		public vtkVolumeTextureMapper2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeTextureMapper2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVolumeTextureMapper2D New()
		{
			vtkVolumeTextureMapper2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeTextureMapper2D.vtkVolumeTextureMapper2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeTextureMapper2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkVolumeTextureMapper2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkVolumeTextureMapper2D.vtkVolumeTextureMapper2D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeTextureMapper2D_GetAxisTextureSize_01(HandleRef pThis);

		public IntPtr GetAxisTextureSize()
		{
			return vtkVolumeTextureMapper2D.vtkVolumeTextureMapper2D_GetAxisTextureSize_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeTextureMapper2D_GetInternalSkipFactor_02(HandleRef pThis);

		public int GetInternalSkipFactor()
		{
			return vtkVolumeTextureMapper2D.vtkVolumeTextureMapper2D_GetInternalSkipFactor_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeTextureMapper2D_GetMaximumNumberOfPlanes_03(HandleRef pThis);

		public virtual int GetMaximumNumberOfPlanes()
		{
			return vtkVolumeTextureMapper2D.vtkVolumeTextureMapper2D_GetMaximumNumberOfPlanes_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeTextureMapper2D_GetMaximumStorageSize_04(HandleRef pThis);

		public virtual int GetMaximumStorageSize()
		{
			return vtkVolumeTextureMapper2D.vtkVolumeTextureMapper2D_GetMaximumStorageSize_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeTextureMapper2D_GetSaveTextures_05(HandleRef pThis);

		public int GetSaveTextures()
		{
			return vtkVolumeTextureMapper2D.vtkVolumeTextureMapper2D_GetSaveTextures_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeTextureMapper2D_GetTargetTextureSize_06(HandleRef pThis);

		public virtual int[] GetTargetTextureSize()
		{
			IntPtr intPtr = vtkVolumeTextureMapper2D.vtkVolumeTextureMapper2D_GetTargetTextureSize_06(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeTextureMapper2D_GetTargetTextureSize_07(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetTargetTextureSize(ref int _arg1, ref int _arg2)
		{
			vtkVolumeTextureMapper2D.vtkVolumeTextureMapper2D_GetTargetTextureSize_07(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeTextureMapper2D_GetTargetTextureSize_08(HandleRef pThis, IntPtr _arg);

		public virtual void GetTargetTextureSize(IntPtr _arg)
		{
			vtkVolumeTextureMapper2D.vtkVolumeTextureMapper2D_GetTargetTextureSize_08(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeTextureMapper2D_GetTexture_09(HandleRef pThis);

		public IntPtr GetTexture()
		{
			return vtkVolumeTextureMapper2D.vtkVolumeTextureMapper2D_GetTexture_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeTextureMapper2D_IsA_10(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkVolumeTextureMapper2D.vtkVolumeTextureMapper2D_IsA_10(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeTextureMapper2D_IsTypeOf_11(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkVolumeTextureMapper2D.vtkVolumeTextureMapper2D_IsTypeOf_11(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeTextureMapper2D_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkVolumeTextureMapper2D NewInstance()
		{
			vtkVolumeTextureMapper2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeTextureMapper2D.vtkVolumeTextureMapper2D_NewInstance_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeTextureMapper2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeTextureMapper2D_Render_14(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		public override void Render(vtkRenderer arg0, vtkVolume arg1)
		{
			vtkVolumeTextureMapper2D.vtkVolumeTextureMapper2D_Render_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeTextureMapper2D_RenderQuads_15(HandleRef pThis, int arg0, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, int arg5);

		public virtual void RenderQuads(int arg0, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, int arg5)
		{
			vtkVolumeTextureMapper2D.vtkVolumeTextureMapper2D_RenderQuads_15(base.GetCppThis(), arg0, arg1, arg2, arg3, arg4, arg5);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeTextureMapper2D_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVolumeTextureMapper2D SafeDownCast(vtkObjectBase o)
		{
			vtkVolumeTextureMapper2D vtkVolumeTextureMapper2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeTextureMapper2D.vtkVolumeTextureMapper2D_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolumeTextureMapper2D = (vtkVolumeTextureMapper2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolumeTextureMapper2D.Register(null);
				}
			}
			return vtkVolumeTextureMapper2D;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeTextureMapper2D_SetMaximumNumberOfPlanes_17(HandleRef pThis, int _arg);

		public virtual void SetMaximumNumberOfPlanes(int _arg)
		{
			vtkVolumeTextureMapper2D.vtkVolumeTextureMapper2D_SetMaximumNumberOfPlanes_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeTextureMapper2D_SetMaximumStorageSize_18(HandleRef pThis, int _arg);

		public virtual void SetMaximumStorageSize(int _arg)
		{
			vtkVolumeTextureMapper2D.vtkVolumeTextureMapper2D_SetMaximumStorageSize_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeTextureMapper2D_SetTargetTextureSize_19(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetTargetTextureSize(int _arg1, int _arg2)
		{
			vtkVolumeTextureMapper2D.vtkVolumeTextureMapper2D_SetTargetTextureSize_19(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeTextureMapper2D_SetTargetTextureSize_20(HandleRef pThis, IntPtr _arg);

		public void SetTargetTextureSize(IntPtr _arg)
		{
			vtkVolumeTextureMapper2D.vtkVolumeTextureMapper2D_SetTargetTextureSize_20(base.GetCppThis(), _arg);
		}
	}
}
