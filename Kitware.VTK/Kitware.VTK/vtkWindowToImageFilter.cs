using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkWindowToImageFilter : vtkAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkWindowToImageFilter";

		public new static readonly string MRClassNameKey;

		static vtkWindowToImageFilter()
		{
			vtkWindowToImageFilter.MRClassNameKey = "class vtkWindowToImageFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWindowToImageFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWindowToImageFilter"));
		}

		public vtkWindowToImageFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkWindowToImageFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkWindowToImageFilter New()
		{
			vtkWindowToImageFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWindowToImageFilter.vtkWindowToImageFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWindowToImageFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkWindowToImageFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkWindowToImageFilter.vtkWindowToImageFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWindowToImageFilter_FixBoundaryOff_01(HandleRef pThis);

		public virtual void FixBoundaryOff()
		{
			vtkWindowToImageFilter.vtkWindowToImageFilter_FixBoundaryOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWindowToImageFilter_FixBoundaryOn_02(HandleRef pThis);

		public virtual void FixBoundaryOn()
		{
			vtkWindowToImageFilter.vtkWindowToImageFilter_FixBoundaryOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkWindowToImageFilter_GetFixBoundary_03(HandleRef pThis);

		public virtual bool GetFixBoundary()
		{
			return vtkWindowToImageFilter.vtkWindowToImageFilter_GetFixBoundary_03(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkWindowToImageFilter_GetInput_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkWindow GetInput()
		{
			vtkWindow vtkWindow = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWindowToImageFilter.vtkWindowToImageFilter_GetInput_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkWindowToImageFilter_GetInputBufferType_05(HandleRef pThis);

		public virtual int GetInputBufferType()
		{
			return vtkWindowToImageFilter.vtkWindowToImageFilter_GetInputBufferType_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkWindowToImageFilter_GetMagnification_06(HandleRef pThis);

		public virtual int GetMagnification()
		{
			return vtkWindowToImageFilter.vtkWindowToImageFilter_GetMagnification_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkWindowToImageFilter_GetMagnificationMaxValue_07(HandleRef pThis);

		public virtual int GetMagnificationMaxValue()
		{
			return vtkWindowToImageFilter.vtkWindowToImageFilter_GetMagnificationMaxValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkWindowToImageFilter_GetMagnificationMinValue_08(HandleRef pThis);

		public virtual int GetMagnificationMinValue()
		{
			return vtkWindowToImageFilter.vtkWindowToImageFilter_GetMagnificationMinValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkWindowToImageFilter_GetOutput_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkImageData GetOutput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWindowToImageFilter.vtkWindowToImageFilter_GetOutput_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkWindowToImageFilter_GetReadFrontBuffer_10(HandleRef pThis);

		public virtual int GetReadFrontBuffer()
		{
			return vtkWindowToImageFilter.vtkWindowToImageFilter_GetReadFrontBuffer_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkWindowToImageFilter_GetShouldRerender_11(HandleRef pThis);

		public virtual int GetShouldRerender()
		{
			return vtkWindowToImageFilter.vtkWindowToImageFilter_GetShouldRerender_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkWindowToImageFilter_GetViewport_12(HandleRef pThis);

		public virtual double[] GetViewport()
		{
			IntPtr intPtr = vtkWindowToImageFilter.vtkWindowToImageFilter_GetViewport_12(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWindowToImageFilter_GetViewport_13(HandleRef pThis, IntPtr data);

		public virtual void GetViewport(IntPtr data)
		{
			vtkWindowToImageFilter.vtkWindowToImageFilter_GetViewport_13(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkWindowToImageFilter_IsA_14(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkWindowToImageFilter.vtkWindowToImageFilter_IsA_14(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkWindowToImageFilter_IsTypeOf_15(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkWindowToImageFilter.vtkWindowToImageFilter_IsTypeOf_15(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkWindowToImageFilter_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkWindowToImageFilter NewInstance()
		{
			vtkWindowToImageFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWindowToImageFilter.vtkWindowToImageFilter_NewInstance_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWindowToImageFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWindowToImageFilter_ReadFrontBufferOff_18(HandleRef pThis);

		public virtual void ReadFrontBufferOff()
		{
			vtkWindowToImageFilter.vtkWindowToImageFilter_ReadFrontBufferOff_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWindowToImageFilter_ReadFrontBufferOn_19(HandleRef pThis);

		public virtual void ReadFrontBufferOn()
		{
			vtkWindowToImageFilter.vtkWindowToImageFilter_ReadFrontBufferOn_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkWindowToImageFilter_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkWindowToImageFilter SafeDownCast(vtkObjectBase o)
		{
			vtkWindowToImageFilter vtkWindowToImageFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWindowToImageFilter.vtkWindowToImageFilter_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWindowToImageFilter = (vtkWindowToImageFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWindowToImageFilter.Register(null);
				}
			}
			return vtkWindowToImageFilter;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWindowToImageFilter_SetFixBoundary_21(HandleRef pThis, byte _arg);

		public virtual void SetFixBoundary(bool _arg)
		{
			vtkWindowToImageFilter.vtkWindowToImageFilter_SetFixBoundary_21(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWindowToImageFilter_SetInput_22(HandleRef pThis, HandleRef input);

		public void SetInput(vtkWindow input)
		{
			vtkWindowToImageFilter.vtkWindowToImageFilter_SetInput_22(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWindowToImageFilter_SetInputBufferType_23(HandleRef pThis, int _arg);

		public virtual void SetInputBufferType(int _arg)
		{
			vtkWindowToImageFilter.vtkWindowToImageFilter_SetInputBufferType_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWindowToImageFilter_SetInputBufferTypeToRGB_24(HandleRef pThis);

		public void SetInputBufferTypeToRGB()
		{
			vtkWindowToImageFilter.vtkWindowToImageFilter_SetInputBufferTypeToRGB_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWindowToImageFilter_SetInputBufferTypeToRGBA_25(HandleRef pThis);

		public void SetInputBufferTypeToRGBA()
		{
			vtkWindowToImageFilter.vtkWindowToImageFilter_SetInputBufferTypeToRGBA_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWindowToImageFilter_SetInputBufferTypeToZBuffer_26(HandleRef pThis);

		public void SetInputBufferTypeToZBuffer()
		{
			vtkWindowToImageFilter.vtkWindowToImageFilter_SetInputBufferTypeToZBuffer_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWindowToImageFilter_SetMagnification_27(HandleRef pThis, int _arg);

		public virtual void SetMagnification(int _arg)
		{
			vtkWindowToImageFilter.vtkWindowToImageFilter_SetMagnification_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWindowToImageFilter_SetReadFrontBuffer_28(HandleRef pThis, int _arg);

		public virtual void SetReadFrontBuffer(int _arg)
		{
			vtkWindowToImageFilter.vtkWindowToImageFilter_SetReadFrontBuffer_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWindowToImageFilter_SetShouldRerender_29(HandleRef pThis, int _arg);

		public virtual void SetShouldRerender(int _arg)
		{
			vtkWindowToImageFilter.vtkWindowToImageFilter_SetShouldRerender_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWindowToImageFilter_SetViewport_30(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

		public virtual void SetViewport(double _arg1, double _arg2, double _arg3, double _arg4)
		{
			vtkWindowToImageFilter.vtkWindowToImageFilter_SetViewport_30(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWindowToImageFilter_SetViewport_31(HandleRef pThis, IntPtr _arg);

		public virtual void SetViewport(IntPtr _arg)
		{
			vtkWindowToImageFilter.vtkWindowToImageFilter_SetViewport_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWindowToImageFilter_ShouldRerenderOff_32(HandleRef pThis);

		public virtual void ShouldRerenderOff()
		{
			vtkWindowToImageFilter.vtkWindowToImageFilter_ShouldRerenderOff_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkWindowToImageFilter_ShouldRerenderOn_33(HandleRef pThis);

		public virtual void ShouldRerenderOn()
		{
			vtkWindowToImageFilter.vtkWindowToImageFilter_ShouldRerenderOn_33(base.GetCppThis());
		}
	}
}
