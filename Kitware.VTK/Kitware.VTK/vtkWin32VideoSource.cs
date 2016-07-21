using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkWin32VideoSource : vtkVideoSource
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkWin32VideoSource";

		public new static readonly string MRClassNameKey;

		static vtkWin32VideoSource()
		{
			vtkWin32VideoSource.MRClassNameKey = "class vtkWin32VideoSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWin32VideoSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWin32VideoSource"));
		}

		public vtkWin32VideoSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkWin32VideoSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkWin32VideoSource New()
		{
			vtkWin32VideoSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWin32VideoSource.vtkWin32VideoSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWin32VideoSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkWin32VideoSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkWin32VideoSource.vtkWin32VideoSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkWin32VideoSource_GetPreview_01(HandleRef pThis);

		public virtual int GetPreview()
		{
			return vtkWin32VideoSource.vtkWin32VideoSource_GetPreview_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkWin32VideoSource_Grab_02(HandleRef pThis);

		public override void Grab()
		{
			vtkWin32VideoSource.vtkWin32VideoSource_Grab_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkWin32VideoSource_Initialize_03(HandleRef pThis);

		public override void Initialize()
		{
			vtkWin32VideoSource.vtkWin32VideoSource_Initialize_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkWin32VideoSource_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkWin32VideoSource.vtkWin32VideoSource_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkWin32VideoSource_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkWin32VideoSource.vtkWin32VideoSource_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkWin32VideoSource_LocalInternalGrab_06(HandleRef pThis, IntPtr arg0);

		public void LocalInternalGrab(IntPtr arg0)
		{
			vtkWin32VideoSource.vtkWin32VideoSource_LocalInternalGrab_06(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkWin32VideoSource_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkWin32VideoSource NewInstance()
		{
			vtkWin32VideoSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWin32VideoSource.vtkWin32VideoSource_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWin32VideoSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkWin32VideoSource_OnParentWndDestroy_09(HandleRef pThis);

		public void OnParentWndDestroy()
		{
			vtkWin32VideoSource.vtkWin32VideoSource_OnParentWndDestroy_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkWin32VideoSource_Play_10(HandleRef pThis);

		public override void Play()
		{
			vtkWin32VideoSource.vtkWin32VideoSource_Play_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkWin32VideoSource_PreviewOff_11(HandleRef pThis);

		public virtual void PreviewOff()
		{
			vtkWin32VideoSource.vtkWin32VideoSource_PreviewOff_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkWin32VideoSource_PreviewOn_12(HandleRef pThis);

		public virtual void PreviewOn()
		{
			vtkWin32VideoSource.vtkWin32VideoSource_PreviewOn_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkWin32VideoSource_Record_13(HandleRef pThis);

		public override void Record()
		{
			vtkWin32VideoSource.vtkWin32VideoSource_Record_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkWin32VideoSource_ReleaseSystemResources_14(HandleRef pThis);

		public override void ReleaseSystemResources()
		{
			vtkWin32VideoSource.vtkWin32VideoSource_ReleaseSystemResources_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkWin32VideoSource_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkWin32VideoSource SafeDownCast(vtkObjectBase o)
		{
			vtkWin32VideoSource vtkWin32VideoSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWin32VideoSource.vtkWin32VideoSource_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWin32VideoSource = (vtkWin32VideoSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWin32VideoSource.Register(null);
				}
			}
			return vtkWin32VideoSource;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkWin32VideoSource_SetFrameRate_16(HandleRef pThis, float rate);

		public override void SetFrameRate(float rate)
		{
			vtkWin32VideoSource.vtkWin32VideoSource_SetFrameRate_16(base.GetCppThis(), rate);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkWin32VideoSource_SetFrameSize_17(HandleRef pThis, int x, int y, int z);

		public override void SetFrameSize(int x, int y, int z)
		{
			vtkWin32VideoSource.vtkWin32VideoSource_SetFrameSize_17(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkWin32VideoSource_SetFrameSize_18(HandleRef pThis, IntPtr dim);

		public override void SetFrameSize(IntPtr dim)
		{
			vtkWin32VideoSource.vtkWin32VideoSource_SetFrameSize_18(base.GetCppThis(), dim);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkWin32VideoSource_SetOutputFormat_19(HandleRef pThis, int format);

		public override void SetOutputFormat(int format)
		{
			vtkWin32VideoSource.vtkWin32VideoSource_SetOutputFormat_19(base.GetCppThis(), format);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkWin32VideoSource_SetPreview_20(HandleRef pThis, int p);

		public void SetPreview(int p)
		{
			vtkWin32VideoSource.vtkWin32VideoSource_SetPreview_20(base.GetCppThis(), p);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkWin32VideoSource_Stop_21(HandleRef pThis);

		public override void Stop()
		{
			vtkWin32VideoSource.vtkWin32VideoSource_Stop_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkWin32VideoSource_VideoFormatDialog_22(HandleRef pThis);

		public void VideoFormatDialog()
		{
			vtkWin32VideoSource.vtkWin32VideoSource_VideoFormatDialog_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkWin32VideoSource_VideoSourceDialog_23(HandleRef pThis);

		public void VideoSourceDialog()
		{
			vtkWin32VideoSource.vtkWin32VideoSource_VideoSourceDialog_23(base.GetCppThis());
		}
	}
}
