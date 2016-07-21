using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageFlip : vtkImageReslice
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageFlip";

		public new static readonly string MRClassNameKey;

		static vtkImageFlip()
		{
			vtkImageFlip.MRClassNameKey = "class vtkImageFlip";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageFlip.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageFlip"));
		}

		public vtkImageFlip(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageFlip_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageFlip New()
		{
			vtkImageFlip result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageFlip.vtkImageFlip_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageFlip)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageFlip() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageFlip.vtkImageFlip_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageFlip_FlipAboutOriginOff_01(HandleRef pThis);

		public virtual void FlipAboutOriginOff()
		{
			vtkImageFlip.vtkImageFlip_FlipAboutOriginOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageFlip_FlipAboutOriginOn_02(HandleRef pThis);

		public virtual void FlipAboutOriginOn()
		{
			vtkImageFlip.vtkImageFlip_FlipAboutOriginOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageFlip_GetFilteredAxes_03(HandleRef pThis);

		public int GetFilteredAxes()
		{
			return vtkImageFlip.vtkImageFlip_GetFilteredAxes_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageFlip_GetFilteredAxis_04(HandleRef pThis);

		public virtual int GetFilteredAxis()
		{
			return vtkImageFlip.vtkImageFlip_GetFilteredAxis_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageFlip_GetFlipAboutOrigin_05(HandleRef pThis);

		public virtual int GetFlipAboutOrigin()
		{
			return vtkImageFlip.vtkImageFlip_GetFlipAboutOrigin_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageFlip_GetPreserveImageExtent_06(HandleRef pThis);

		public virtual int GetPreserveImageExtent()
		{
			return vtkImageFlip.vtkImageFlip_GetPreserveImageExtent_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageFlip_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageFlip.vtkImageFlip_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageFlip_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageFlip.vtkImageFlip_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageFlip_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageFlip NewInstance()
		{
			vtkImageFlip result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageFlip.vtkImageFlip_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageFlip)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageFlip_PreserveImageExtentOff_11(HandleRef pThis);

		public virtual void PreserveImageExtentOff()
		{
			vtkImageFlip.vtkImageFlip_PreserveImageExtentOff_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageFlip_PreserveImageExtentOn_12(HandleRef pThis);

		public virtual void PreserveImageExtentOn()
		{
			vtkImageFlip.vtkImageFlip_PreserveImageExtentOn_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageFlip_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageFlip SafeDownCast(vtkObjectBase o)
		{
			vtkImageFlip vtkImageFlip = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageFlip.vtkImageFlip_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageFlip = (vtkImageFlip)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageFlip.Register(null);
				}
			}
			return vtkImageFlip;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageFlip_SetFilteredAxes_14(HandleRef pThis, int axis);

		public void SetFilteredAxes(int axis)
		{
			vtkImageFlip.vtkImageFlip_SetFilteredAxes_14(base.GetCppThis(), axis);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageFlip_SetFilteredAxis_15(HandleRef pThis, int _arg);

		public virtual void SetFilteredAxis(int _arg)
		{
			vtkImageFlip.vtkImageFlip_SetFilteredAxis_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageFlip_SetFlipAboutOrigin_16(HandleRef pThis, int _arg);

		public virtual void SetFlipAboutOrigin(int _arg)
		{
			vtkImageFlip.vtkImageFlip_SetFlipAboutOrigin_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageFlip_SetPreserveImageExtent_17(HandleRef pThis, int _arg);

		public virtual void SetPreserveImageExtent(int _arg)
		{
			vtkImageFlip.vtkImageFlip_SetPreserveImageExtent_17(base.GetCppThis(), _arg);
		}
	}
}
