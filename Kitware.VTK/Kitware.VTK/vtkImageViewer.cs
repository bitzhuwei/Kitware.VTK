using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageViewer : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageViewer";

		public new static readonly string MRClassNameKey;

		static vtkImageViewer()
		{
			vtkImageViewer.MRClassNameKey = "class vtkImageViewer";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageViewer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageViewer"));
		}

		public vtkImageViewer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageViewer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageViewer New()
		{
			vtkImageViewer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageViewer.vtkImageViewer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageViewer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageViewer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageViewer.vtkImageViewer_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageViewer_GetActor2D_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkActor2D GetActor2D()
		{
			vtkActor2D vtkActor2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageViewer.vtkImageViewer_GetActor2D_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkActor2D = (vtkActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkActor2D.Register(null);
				}
			}
			return vtkActor2D;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkImageViewer_GetColorLevel_02(HandleRef pThis);

		public double GetColorLevel()
		{
			return vtkImageViewer.vtkImageViewer_GetColorLevel_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkImageViewer_GetColorWindow_03(HandleRef pThis);

		public double GetColorWindow()
		{
			return vtkImageViewer.vtkImageViewer_GetColorWindow_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageViewer_GetImageMapper_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImageMapper GetImageMapper()
		{
			vtkImageMapper vtkImageMapper = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageViewer.vtkImageViewer_GetImageMapper_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageMapper = (vtkImageMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageMapper.Register(null);
				}
			}
			return vtkImageMapper;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageViewer_GetInput_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkImageData GetInput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageViewer.vtkImageViewer_GetInput_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkImageViewer_GetOffScreenRendering_06(HandleRef pThis);

		public int GetOffScreenRendering()
		{
			return vtkImageViewer.vtkImageViewer_GetOffScreenRendering_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageViewer_GetPosition_07(HandleRef pThis);

		public int[] GetPosition()
		{
			IntPtr intPtr = vtkImageViewer.vtkImageViewer_GetPosition_07(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageViewer_GetRenderWindow_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkRenderWindow GetRenderWindow()
		{
			vtkRenderWindow vtkRenderWindow = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageViewer.vtkImageViewer_GetRenderWindow_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkImageViewer_GetRenderer_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkRenderer GetRenderer()
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageViewer.vtkImageViewer_GetRenderer_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderer = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderer.Register(null);
				}
			}
			return vtkRenderer;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageViewer_GetSize_10(HandleRef pThis);

		public int[] GetSize()
		{
			IntPtr intPtr = vtkImageViewer.vtkImageViewer_GetSize_10(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkImageViewer_GetWholeZMax_11(HandleRef pThis);

		public int GetWholeZMax()
		{
			return vtkImageViewer.vtkImageViewer_GetWholeZMax_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkImageViewer_GetWholeZMin_12(HandleRef pThis);

		public int GetWholeZMin()
		{
			return vtkImageViewer.vtkImageViewer_GetWholeZMin_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageViewer_GetWindowName_13(HandleRef pThis);

		public string GetWindowName()
		{
			return Marshal.PtrToStringAnsi(vtkImageViewer.vtkImageViewer_GetWindowName_13(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkImageViewer_GetZSlice_14(HandleRef pThis);

		public int GetZSlice()
		{
			return vtkImageViewer.vtkImageViewer_GetZSlice_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkImageViewer_IsA_15(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageViewer.vtkImageViewer_IsA_15(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkImageViewer_IsTypeOf_16(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageViewer.vtkImageViewer_IsTypeOf_16(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageViewer_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageViewer NewInstance()
		{
			vtkImageViewer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageViewer.vtkImageViewer_NewInstance_18(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageViewer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageViewer_OffScreenRenderingOff_19(HandleRef pThis);

		public void OffScreenRenderingOff()
		{
			vtkImageViewer.vtkImageViewer_OffScreenRenderingOff_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageViewer_OffScreenRenderingOn_20(HandleRef pThis);

		public void OffScreenRenderingOn()
		{
			vtkImageViewer.vtkImageViewer_OffScreenRenderingOn_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageViewer_Render_21(HandleRef pThis);

		public virtual void Render()
		{
			vtkImageViewer.vtkImageViewer_Render_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageViewer_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageViewer SafeDownCast(vtkObjectBase o)
		{
			vtkImageViewer vtkImageViewer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageViewer.vtkImageViewer_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageViewer = (vtkImageViewer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageViewer.Register(null);
				}
			}
			return vtkImageViewer;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageViewer_SetColorLevel_23(HandleRef pThis, double s);

		public void SetColorLevel(double s)
		{
			vtkImageViewer.vtkImageViewer_SetColorLevel_23(base.GetCppThis(), s);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageViewer_SetColorWindow_24(HandleRef pThis, double s);

		public void SetColorWindow(double s)
		{
			vtkImageViewer.vtkImageViewer_SetColorWindow_24(base.GetCppThis(), s);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageViewer_SetDisplayId_25(HandleRef pThis, IntPtr a);

		public void SetDisplayId(IntPtr a)
		{
			vtkImageViewer.vtkImageViewer_SetDisplayId_25(base.GetCppThis(), a);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageViewer_SetInput_26(HandleRef pThis, HandleRef arg0);

		public void SetInput(vtkImageData arg0)
		{
			vtkImageViewer.vtkImageViewer_SetInput_26(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageViewer_SetInputConnection_27(HandleRef pThis, HandleRef input);

		public virtual void SetInputConnection(vtkAlgorithmOutput input)
		{
			vtkImageViewer.vtkImageViewer_SetInputConnection_27(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageViewer_SetOffScreenRendering_28(HandleRef pThis, int arg0);

		public void SetOffScreenRendering(int arg0)
		{
			vtkImageViewer.vtkImageViewer_SetOffScreenRendering_28(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageViewer_SetParentId_29(HandleRef pThis, IntPtr a);

		public void SetParentId(IntPtr a)
		{
			vtkImageViewer.vtkImageViewer_SetParentId_29(base.GetCppThis(), a);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageViewer_SetPosition_30(HandleRef pThis, int a, int b);

		public void SetPosition(int a, int b)
		{
			vtkImageViewer.vtkImageViewer_SetPosition_30(base.GetCppThis(), a, b);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageViewer_SetPosition_31(HandleRef pThis, IntPtr a);

		public virtual void SetPosition(IntPtr a)
		{
			vtkImageViewer.vtkImageViewer_SetPosition_31(base.GetCppThis(), a);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageViewer_SetSize_32(HandleRef pThis, int a, int b);

		public void SetSize(int a, int b)
		{
			vtkImageViewer.vtkImageViewer_SetSize_32(base.GetCppThis(), a, b);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageViewer_SetSize_33(HandleRef pThis, IntPtr a);

		public virtual void SetSize(IntPtr a)
		{
			vtkImageViewer.vtkImageViewer_SetSize_33(base.GetCppThis(), a);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageViewer_SetWindowId_34(HandleRef pThis, IntPtr a);

		public void SetWindowId(IntPtr a)
		{
			vtkImageViewer.vtkImageViewer_SetWindowId_34(base.GetCppThis(), a);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageViewer_SetZSlice_35(HandleRef pThis, int s);

		public void SetZSlice(int s)
		{
			vtkImageViewer.vtkImageViewer_SetZSlice_35(base.GetCppThis(), s);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageViewer_SetupInteractor_36(HandleRef pThis, HandleRef arg0);

		public void SetupInteractor(vtkRenderWindowInteractor arg0)
		{
			vtkImageViewer.vtkImageViewer_SetupInteractor_36(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
