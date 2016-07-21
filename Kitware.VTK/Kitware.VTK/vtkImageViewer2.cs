using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageViewer2 : vtkObject
	{
		public enum SLICE_ORIENTATION_XY_WrapperEnum
		{
			SLICE_ORIENTATION_XY = 2,
			SLICE_ORIENTATION_XZ = 1,
			SLICE_ORIENTATION_YZ = 0
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkImageViewer2";

		public new static readonly string MRClassNameKey;

		static vtkImageViewer2()
		{
			vtkImageViewer2.MRClassNameKey = "class vtkImageViewer2";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageViewer2.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageViewer2"));
		}

		public vtkImageViewer2(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageViewer2_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageViewer2 New()
		{
			vtkImageViewer2 result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageViewer2.vtkImageViewer2_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageViewer2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageViewer2() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageViewer2.vtkImageViewer2_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkImageViewer2_GetColorLevel_01(HandleRef pThis);

		public virtual double GetColorLevel()
		{
			return vtkImageViewer2.vtkImageViewer2_GetColorLevel_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkImageViewer2_GetColorWindow_02(HandleRef pThis);

		public virtual double GetColorWindow()
		{
			return vtkImageViewer2.vtkImageViewer2_GetColorWindow_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageViewer2_GetImageActor_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImageActor GetImageActor()
		{
			vtkImageActor vtkImageActor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageViewer2.vtkImageViewer2_GetImageActor_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageActor = (vtkImageActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageActor.Register(null);
				}
			}
			return vtkImageActor;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageViewer2_GetInput_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImageData GetInput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageViewer2.vtkImageViewer2_GetInput_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkImageViewer2_GetInteractorStyle_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkInteractorStyleImage GetInteractorStyle()
		{
			vtkInteractorStyleImage vtkInteractorStyleImage = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageViewer2.vtkImageViewer2_GetInteractorStyle_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorStyleImage = (vtkInteractorStyleImage)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorStyleImage.Register(null);
				}
			}
			return vtkInteractorStyleImage;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkImageViewer2_GetOffScreenRendering_06(HandleRef pThis);

		public virtual int GetOffScreenRendering()
		{
			return vtkImageViewer2.vtkImageViewer2_GetOffScreenRendering_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageViewer2_GetPosition_07(HandleRef pThis);

		public virtual IntPtr GetPosition()
		{
			return vtkImageViewer2.vtkImageViewer2_GetPosition_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageViewer2_GetRenderWindow_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkRenderWindow GetRenderWindow()
		{
			vtkRenderWindow vtkRenderWindow = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageViewer2.vtkImageViewer2_GetRenderWindow_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkImageViewer2_GetRenderer_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkRenderer GetRenderer()
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageViewer2.vtkImageViewer2_GetRenderer_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkImageViewer2_GetSize_10(HandleRef pThis);

		public virtual IntPtr GetSize()
		{
			return vtkImageViewer2.vtkImageViewer2_GetSize_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkImageViewer2_GetSlice_11(HandleRef pThis);

		public virtual int GetSlice()
		{
			return vtkImageViewer2.vtkImageViewer2_GetSlice_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkImageViewer2_GetSliceMax_12(HandleRef pThis);

		public virtual int GetSliceMax()
		{
			return vtkImageViewer2.vtkImageViewer2_GetSliceMax_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkImageViewer2_GetSliceMin_13(HandleRef pThis);

		public virtual int GetSliceMin()
		{
			return vtkImageViewer2.vtkImageViewer2_GetSliceMin_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkImageViewer2_GetSliceOrientation_14(HandleRef pThis);

		public virtual int GetSliceOrientation()
		{
			return vtkImageViewer2.vtkImageViewer2_GetSliceOrientation_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageViewer2_GetSliceRange_15(HandleRef pThis, IntPtr range);

		public virtual void GetSliceRange(IntPtr range)
		{
			vtkImageViewer2.vtkImageViewer2_GetSliceRange_15(base.GetCppThis(), range);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageViewer2_GetSliceRange_16(HandleRef pThis, ref int min, ref int max);

		public virtual void GetSliceRange(ref int min, ref int max)
		{
			vtkImageViewer2.vtkImageViewer2_GetSliceRange_16(base.GetCppThis(), ref min, ref max);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageViewer2_GetSliceRange_17(HandleRef pThis);

		public virtual IntPtr GetSliceRange()
		{
			return vtkImageViewer2.vtkImageViewer2_GetSliceRange_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageViewer2_GetWindowLevel_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImageMapToWindowLevelColors GetWindowLevel()
		{
			vtkImageMapToWindowLevelColors vtkImageMapToWindowLevelColors = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageViewer2.vtkImageViewer2_GetWindowLevel_18(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageMapToWindowLevelColors = (vtkImageMapToWindowLevelColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageMapToWindowLevelColors.Register(null);
				}
			}
			return vtkImageMapToWindowLevelColors;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageViewer2_GetWindowName_19(HandleRef pThis);

		public virtual string GetWindowName()
		{
			return Marshal.PtrToStringAnsi(vtkImageViewer2.vtkImageViewer2_GetWindowName_19(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkImageViewer2_IsA_20(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageViewer2.vtkImageViewer2_IsA_20(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkImageViewer2_IsTypeOf_21(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageViewer2.vtkImageViewer2_IsTypeOf_21(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageViewer2_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageViewer2 NewInstance()
		{
			vtkImageViewer2 result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageViewer2.vtkImageViewer2_NewInstance_23(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageViewer2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageViewer2_OffScreenRenderingOff_24(HandleRef pThis);

		public virtual void OffScreenRenderingOff()
		{
			vtkImageViewer2.vtkImageViewer2_OffScreenRenderingOff_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageViewer2_OffScreenRenderingOn_25(HandleRef pThis);

		public virtual void OffScreenRenderingOn()
		{
			vtkImageViewer2.vtkImageViewer2_OffScreenRenderingOn_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageViewer2_Render_26(HandleRef pThis);

		public virtual void Render()
		{
			vtkImageViewer2.vtkImageViewer2_Render_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkImageViewer2_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageViewer2 SafeDownCast(vtkObjectBase o)
		{
			vtkImageViewer2 vtkImageViewer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageViewer2.vtkImageViewer2_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageViewer = (vtkImageViewer2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageViewer.Register(null);
				}
			}
			return vtkImageViewer;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageViewer2_SetColorLevel_28(HandleRef pThis, double s);

		public virtual void SetColorLevel(double s)
		{
			vtkImageViewer2.vtkImageViewer2_SetColorLevel_28(base.GetCppThis(), s);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageViewer2_SetColorWindow_29(HandleRef pThis, double s);

		public virtual void SetColorWindow(double s)
		{
			vtkImageViewer2.vtkImageViewer2_SetColorWindow_29(base.GetCppThis(), s);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageViewer2_SetDisplayId_30(HandleRef pThis, IntPtr a);

		public virtual void SetDisplayId(IntPtr a)
		{
			vtkImageViewer2.vtkImageViewer2_SetDisplayId_30(base.GetCppThis(), a);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageViewer2_SetInput_31(HandleRef pThis, HandleRef arg0);

		public virtual void SetInput(vtkImageData arg0)
		{
			vtkImageViewer2.vtkImageViewer2_SetInput_31(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageViewer2_SetInputConnection_32(HandleRef pThis, HandleRef input);

		public virtual void SetInputConnection(vtkAlgorithmOutput input)
		{
			vtkImageViewer2.vtkImageViewer2_SetInputConnection_32(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageViewer2_SetOffScreenRendering_33(HandleRef pThis, int arg0);

		public virtual void SetOffScreenRendering(int arg0)
		{
			vtkImageViewer2.vtkImageViewer2_SetOffScreenRendering_33(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageViewer2_SetParentId_34(HandleRef pThis, IntPtr a);

		public virtual void SetParentId(IntPtr a)
		{
			vtkImageViewer2.vtkImageViewer2_SetParentId_34(base.GetCppThis(), a);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageViewer2_SetPosition_35(HandleRef pThis, int a, int b);

		public virtual void SetPosition(int a, int b)
		{
			vtkImageViewer2.vtkImageViewer2_SetPosition_35(base.GetCppThis(), a, b);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageViewer2_SetPosition_36(HandleRef pThis, IntPtr a);

		public virtual void SetPosition(IntPtr a)
		{
			vtkImageViewer2.vtkImageViewer2_SetPosition_36(base.GetCppThis(), a);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageViewer2_SetRenderWindow_37(HandleRef pThis, HandleRef arg);

		public virtual void SetRenderWindow(vtkRenderWindow arg)
		{
			vtkImageViewer2.vtkImageViewer2_SetRenderWindow_37(base.GetCppThis(), (arg == null) ? default(HandleRef) : arg.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageViewer2_SetRenderer_38(HandleRef pThis, HandleRef arg);

		public virtual void SetRenderer(vtkRenderer arg)
		{
			vtkImageViewer2.vtkImageViewer2_SetRenderer_38(base.GetCppThis(), (arg == null) ? default(HandleRef) : arg.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageViewer2_SetSize_39(HandleRef pThis, int a, int b);

		public virtual void SetSize(int a, int b)
		{
			vtkImageViewer2.vtkImageViewer2_SetSize_39(base.GetCppThis(), a, b);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageViewer2_SetSize_40(HandleRef pThis, IntPtr a);

		public virtual void SetSize(IntPtr a)
		{
			vtkImageViewer2.vtkImageViewer2_SetSize_40(base.GetCppThis(), a);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageViewer2_SetSlice_41(HandleRef pThis, int s);

		public virtual void SetSlice(int s)
		{
			vtkImageViewer2.vtkImageViewer2_SetSlice_41(base.GetCppThis(), s);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageViewer2_SetSliceOrientation_42(HandleRef pThis, int orientation);

		public virtual void SetSliceOrientation(int orientation)
		{
			vtkImageViewer2.vtkImageViewer2_SetSliceOrientation_42(base.GetCppThis(), orientation);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageViewer2_SetSliceOrientationToXY_43(HandleRef pThis);

		public virtual void SetSliceOrientationToXY()
		{
			vtkImageViewer2.vtkImageViewer2_SetSliceOrientationToXY_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageViewer2_SetSliceOrientationToXZ_44(HandleRef pThis);

		public virtual void SetSliceOrientationToXZ()
		{
			vtkImageViewer2.vtkImageViewer2_SetSliceOrientationToXZ_44(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageViewer2_SetSliceOrientationToYZ_45(HandleRef pThis);

		public virtual void SetSliceOrientationToYZ()
		{
			vtkImageViewer2.vtkImageViewer2_SetSliceOrientationToYZ_45(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageViewer2_SetWindowId_46(HandleRef pThis, IntPtr a);

		public virtual void SetWindowId(IntPtr a)
		{
			vtkImageViewer2.vtkImageViewer2_SetWindowId_46(base.GetCppThis(), a);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageViewer2_SetupInteractor_47(HandleRef pThis, HandleRef arg0);

		public virtual void SetupInteractor(vtkRenderWindowInteractor arg0)
		{
			vtkImageViewer2.vtkImageViewer2_SetupInteractor_47(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImageViewer2_UpdateDisplayExtent_48(HandleRef pThis);

		public virtual void UpdateDisplayExtent()
		{
			vtkImageViewer2.vtkImageViewer2_UpdateDisplayExtent_48(base.GetCppThis());
		}
	}
}
