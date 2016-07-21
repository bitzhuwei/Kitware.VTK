using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkWindow : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkWindow";

		public new static readonly string MRClassNameKey;

		static vtkWindow()
		{
			vtkWindow.MRClassNameKey = "class vtkWindow";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWindow.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWindow"));
		}

		public vtkWindow(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindow_DoubleBufferOff_01(HandleRef pThis);

		public virtual void DoubleBufferOff()
		{
			vtkWindow.vtkWindow_DoubleBufferOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindow_DoubleBufferOn_02(HandleRef pThis);

		public virtual void DoubleBufferOn()
		{
			vtkWindow.vtkWindow_DoubleBufferOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindow_EraseOff_03(HandleRef pThis);

		public virtual void EraseOff()
		{
			vtkWindow.vtkWindow_EraseOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindow_EraseOn_04(HandleRef pThis);

		public virtual void EraseOn()
		{
			vtkWindow.vtkWindow_EraseOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkWindow_GetActualSize_05(HandleRef pThis);

		public IntPtr GetActualSize()
		{
			return vtkWindow.vtkWindow_GetActualSize_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkWindow_GetDPI_06(HandleRef pThis);

		public virtual int GetDPI()
		{
			return vtkWindow.vtkWindow_GetDPI_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkWindow_GetDPIMaxValue_07(HandleRef pThis);

		public virtual int GetDPIMaxValue()
		{
			return vtkWindow.vtkWindow_GetDPIMaxValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkWindow_GetDPIMinValue_08(HandleRef pThis);

		public virtual int GetDPIMinValue()
		{
			return vtkWindow.vtkWindow_GetDPIMinValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkWindow_GetDoubleBuffer_09(HandleRef pThis);

		public virtual int GetDoubleBuffer()
		{
			return vtkWindow.vtkWindow_GetDoubleBuffer_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkWindow_GetErase_10(HandleRef pThis);

		public virtual int GetErase()
		{
			return vtkWindow.vtkWindow_GetErase_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkWindow_GetGenericContext_11(HandleRef pThis);

		public virtual IntPtr GetGenericContext()
		{
			return vtkWindow.vtkWindow_GetGenericContext_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkWindow_GetGenericDisplayId_12(HandleRef pThis);

		public virtual IntPtr GetGenericDisplayId()
		{
			return vtkWindow.vtkWindow_GetGenericDisplayId_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkWindow_GetGenericDrawable_13(HandleRef pThis);

		public virtual IntPtr GetGenericDrawable()
		{
			return vtkWindow.vtkWindow_GetGenericDrawable_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkWindow_GetGenericParentId_14(HandleRef pThis);

		public virtual IntPtr GetGenericParentId()
		{
			return vtkWindow.vtkWindow_GetGenericParentId_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkWindow_GetGenericWindowId_15(HandleRef pThis);

		public virtual IntPtr GetGenericWindowId()
		{
			return vtkWindow.vtkWindow_GetGenericWindowId_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkWindow_GetMapped_16(HandleRef pThis);

		public virtual int GetMapped()
		{
			return vtkWindow.vtkWindow_GetMapped_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkWindow_GetOffScreenRendering_17(HandleRef pThis);

		public virtual int GetOffScreenRendering()
		{
			return vtkWindow.vtkWindow_GetOffScreenRendering_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkWindow_GetPixelData_18(HandleRef pThis, int x, int y, int x2, int y2, int front);

		public virtual IntPtr GetPixelData(int x, int y, int x2, int y2, int front)
		{
			return vtkWindow.vtkWindow_GetPixelData_18(base.GetCppThis(), x, y, x2, y2, front);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkWindow_GetPixelData_19(HandleRef pThis, int x, int y, int x2, int y2, int front, HandleRef data);

		public virtual int GetPixelData(int x, int y, int x2, int y2, int front, vtkUnsignedCharArray data)
		{
			return vtkWindow.vtkWindow_GetPixelData_19(base.GetCppThis(), x, y, x2, y2, front, (data == null) ? default(HandleRef) : data.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkWindow_GetPosition_20(HandleRef pThis);

		public virtual int[] GetPosition()
		{
			IntPtr intPtr = vtkWindow.vtkWindow_GetPosition_20(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkWindow_GetScreenSize_21(HandleRef pThis);

		public virtual IntPtr GetScreenSize()
		{
			return vtkWindow.vtkWindow_GetScreenSize_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkWindow_GetSize_22(HandleRef pThis);

		public virtual int[] GetSize()
		{
			IntPtr intPtr = vtkWindow.vtkWindow_GetSize_22(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkWindow_GetTileScale_23(HandleRef pThis);

		public virtual int[] GetTileScale()
		{
			IntPtr intPtr = vtkWindow.vtkWindow_GetTileScale_23(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindow_GetTileScale_24(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetTileScale(ref int _arg1, ref int _arg2)
		{
			vtkWindow.vtkWindow_GetTileScale_24(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindow_GetTileScale_25(HandleRef pThis, IntPtr _arg);

		public virtual void GetTileScale(IntPtr _arg)
		{
			vtkWindow.vtkWindow_GetTileScale_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkWindow_GetTileViewport_26(HandleRef pThis);

		public virtual double[] GetTileViewport()
		{
			IntPtr intPtr = vtkWindow.vtkWindow_GetTileViewport_26(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindow_GetTileViewport_27(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

		public virtual void GetTileViewport(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
		{
			vtkWindow.vtkWindow_GetTileViewport_27(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindow_GetTileViewport_28(HandleRef pThis, IntPtr _arg);

		public virtual void GetTileViewport(IntPtr _arg)
		{
			vtkWindow.vtkWindow_GetTileViewport_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkWindow_GetWindowName_29(HandleRef pThis);

		public virtual string GetWindowName()
		{
			return Marshal.PtrToStringAnsi(vtkWindow.vtkWindow_GetWindowName_29(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkWindow_IsA_30(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkWindow.vtkWindow_IsA_30(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkWindow_IsTypeOf_31(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkWindow.vtkWindow_IsTypeOf_31(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindow_MakeCurrent_32(HandleRef pThis);

		public virtual void MakeCurrent()
		{
			vtkWindow.vtkWindow_MakeCurrent_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindow_MappedOff_33(HandleRef pThis);

		public virtual void MappedOff()
		{
			vtkWindow.vtkWindow_MappedOff_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindow_MappedOn_34(HandleRef pThis);

		public virtual void MappedOn()
		{
			vtkWindow.vtkWindow_MappedOn_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkWindow_NewInstance_35(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkWindow NewInstance()
		{
			vtkWindow result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWindow.vtkWindow_NewInstance_35(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindow_OffScreenRenderingOff_36(HandleRef pThis);

		public virtual void OffScreenRenderingOff()
		{
			vtkWindow.vtkWindow_OffScreenRenderingOff_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindow_OffScreenRenderingOn_37(HandleRef pThis);

		public virtual void OffScreenRenderingOn()
		{
			vtkWindow.vtkWindow_OffScreenRenderingOn_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindow_Render_38(HandleRef pThis);

		public virtual void Render()
		{
			vtkWindow.vtkWindow_Render_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkWindow_SafeDownCast_39(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkWindow SafeDownCast(vtkObjectBase o)
		{
			vtkWindow vtkWindow = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWindow.vtkWindow_SafeDownCast_39((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWindow = (vtkWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWindow.Register(null);
				}
			}
			return vtkWindow;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindow_SetDPI_40(HandleRef pThis, int _arg);

		public virtual void SetDPI(int _arg)
		{
			vtkWindow.vtkWindow_SetDPI_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindow_SetDisplayId_41(HandleRef pThis, IntPtr arg0);

		public virtual void SetDisplayId(IntPtr arg0)
		{
			vtkWindow.vtkWindow_SetDisplayId_41(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindow_SetDoubleBuffer_42(HandleRef pThis, int _arg);

		public virtual void SetDoubleBuffer(int _arg)
		{
			vtkWindow.vtkWindow_SetDoubleBuffer_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindow_SetErase_43(HandleRef pThis, int _arg);

		public virtual void SetErase(int _arg)
		{
			vtkWindow.vtkWindow_SetErase_43(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindow_SetMapped_44(HandleRef pThis, int _arg);

		public virtual void SetMapped(int _arg)
		{
			vtkWindow.vtkWindow_SetMapped_44(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindow_SetOffScreenRendering_45(HandleRef pThis, int _arg);

		public virtual void SetOffScreenRendering(int _arg)
		{
			vtkWindow.vtkWindow_SetOffScreenRendering_45(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindow_SetParentId_46(HandleRef pThis, IntPtr arg0);

		public virtual void SetParentId(IntPtr arg0)
		{
			vtkWindow.vtkWindow_SetParentId_46(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindow_SetParentInfo_47(HandleRef pThis, string arg0);

		public virtual void SetParentInfo(string arg0)
		{
			vtkWindow.vtkWindow_SetParentInfo_47(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindow_SetPosition_48(HandleRef pThis, int arg0, int arg1);

		public virtual void SetPosition(int arg0, int arg1)
		{
			vtkWindow.vtkWindow_SetPosition_48(base.GetCppThis(), arg0, arg1);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindow_SetPosition_49(HandleRef pThis, IntPtr a);

		public virtual void SetPosition(IntPtr a)
		{
			vtkWindow.vtkWindow_SetPosition_49(base.GetCppThis(), a);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindow_SetSize_50(HandleRef pThis, int arg0, int arg1);

		public virtual void SetSize(int arg0, int arg1)
		{
			vtkWindow.vtkWindow_SetSize_50(base.GetCppThis(), arg0, arg1);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindow_SetSize_51(HandleRef pThis, IntPtr a);

		public virtual void SetSize(IntPtr a)
		{
			vtkWindow.vtkWindow_SetSize_51(base.GetCppThis(), a);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindow_SetTileScale_52(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetTileScale(int _arg1, int _arg2)
		{
			vtkWindow.vtkWindow_SetTileScale_52(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindow_SetTileScale_53(HandleRef pThis, IntPtr _arg);

		public void SetTileScale(IntPtr _arg)
		{
			vtkWindow.vtkWindow_SetTileScale_53(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindow_SetTileScale_54(HandleRef pThis, int s);

		public void SetTileScale(int s)
		{
			vtkWindow.vtkWindow_SetTileScale_54(base.GetCppThis(), s);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindow_SetTileViewport_55(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

		public virtual void SetTileViewport(double _arg1, double _arg2, double _arg3, double _arg4)
		{
			vtkWindow.vtkWindow_SetTileViewport_55(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindow_SetTileViewport_56(HandleRef pThis, IntPtr _arg);

		public virtual void SetTileViewport(IntPtr _arg)
		{
			vtkWindow.vtkWindow_SetTileViewport_56(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindow_SetWindowId_57(HandleRef pThis, IntPtr arg0);

		public virtual void SetWindowId(IntPtr arg0)
		{
			vtkWindow.vtkWindow_SetWindowId_57(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindow_SetWindowInfo_58(HandleRef pThis, string arg0);

		public virtual void SetWindowInfo(string arg0)
		{
			vtkWindow.vtkWindow_SetWindowInfo_58(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkWindow_SetWindowName_59(HandleRef pThis, string _arg);

		public virtual void SetWindowName(string _arg)
		{
			vtkWindow.vtkWindow_SetWindowName_59(base.GetCppThis(), _arg);
		}
	}
}
